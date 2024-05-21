using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace APP_MINF_CSHARP_MELISSA
{
    public partial class Form1 : Form
    {
        // Déclaration d'un délégué pour la réception de données
        public delegate void ReceiverD();
        public ReceiverD myDelegate;

        public Form1()
        {
            InitializeComponent(); // Initialise les composants de l'interface utilisateur
            string[] ports = SerialPort.GetPortNames(); // Récupère les noms de tous les ports série disponibles
            cbo_PortNames.Items.AddRange(ports); // Ajoute les noms de port dans le combobox

            if (ports.Length > 0)
            {
                cbo_PortNames.SelectedIndex = 0; // Selection automatique du premier port
            }
            else
            {
                bt_OpenClose.Enabled = false; // Désactive le bouton Open si aucun port n'est trouvé
                lb_Port.Text = "Aucun Port Disponible !"; // Message informatif pour l'utilisateur
            }
            // Désactive les groupes Tx et Rx
            gb_Tx.Enabled = false;
            gb_Rx.Enabled = false;

            myDelegate = new ReceiverD(DispInListRxData); // Initialise le délégué pour la réception de données
        }

        // Méthode pour composer le message à envoyer
        string CompositionMessage()
        {
            string messageTotal;

            messageTotal = "!S="; // Début de la trame

            messageTotal += ((string)cbo_Form.SelectedItem)[0];  // Ajoute la première lettre du nom de la forme sélectionnée

            messageTotal += "F="; // Ajoute "F="
            messageTotal += UpDown_Freq.Value.ToString(); // Ajoute la valeur de la fréquence

            messageTotal += "A="; // Ajoute "A="
            messageTotal += UpDown_Amp.Value.ToString(); // Ajoute la valeur de l'amplitude

            messageTotal += "O="; // Ajoute "O="

            if (UpDown_Offset.Value >= 0)
            {
                messageTotal += "+"; // Ajoute le signe plus "+" si l'offset est positif
            }

            messageTotal += UpDown_Offset.Value.ToString();  // Ajoute la valeur de l'offset

            messageTotal += "W="; // Ajoute "W="

            // Gestion de la sauvegarde avec l'aide du bouton "Sauvegarde"
            if (chk_Save.Checked == true)
            {
                messageTotal += "1"; // Ajoute "1" si le bouton est coché
            }
            else
            {
                messageTotal += "0"; // Ajoute "0" si le bouton est décoché 
            }
            messageTotal += "#"; // Fin de la trame 

            return messageTotal; // Retourne le message complet
        } // Fin CompositionMessage

        public void DispInListRxData()
        {
            // Allocation d'un tableau de bytes pour les données reçues
            byte[] data = new byte[30];  // 30 pour prendre en compte le + et le P en compte dans le message reçu

            // Recherche début de trame
            do
            {
                data[0] = (byte)serialPort1.ReadByte(); // Lit un byte depuis le port série
            } while (data[0] != '!');    // Continue jusqu'à trouver '!' 

            int index = 0;
            while (data[index] != '#')   // Continue jusqu'à trouver '#'
            {
                if (serialPort1.BytesToRead > 0)
                {
                    index++;
                    data[index] = (byte)serialPort1.ReadByte();  // Lit un autre byte depuis le port série
                }
            }
            // Conversion des données reçues en string
            string receivedMessage = System.Text.Encoding.ASCII.GetString(data, 0, index + 1);

            // Décodage et mise à jour des champs de texte
            string[] parts = receivedMessage.Split('='); // Divise le message en parties séparées par '='

            // Assurez-vous que le message est bien formé avant de le traiter
            if (parts.Length >= 5 && parts[0] == "!S")
            {
                txt_Form.Text = parts[1].TrimEnd('F'); // Mise à jour du champ de texte pour la forme
                txt_Freq.Text = parts[2].TrimEnd('A'); // Mise à jour du champ de texte pour la fréquence
                txt_Amp.Text = parts[3].TrimEnd('O'); // Mise à jour du champ de texte pour l'amplitude                
                txt_Offset.Text = parts[4].TrimStart('+').TrimEnd('W', 'P'); // Mise à jour du champ de texte pour l'offset

                bool saved = Convert.ToBoolean(int.Parse(parts[5].TrimEnd('#'))); // Vérifie si la sauvegarde est activée
                if (saved)
                {
                    lb_SaveOK.Text = "Oui"; // Affiche "Oui" si la sauvegarde est activée
                }
                else
                {
                    lb_SaveOK.Text = "Non"; // Affiche "Non" si la sauvegarde n'est pas activée
                }
            }

            // Ajoute le message reçu à la liste des données entrantes
            lstDataIn.Items.Add(receivedMessage);

            // Limite la liste à 10 éléments
            if (lstDataIn.Items.Count > 10)
            {
                lstDataIn.Items.RemoveAt(0);
            }
        } // Fin DispInListRxData

        // Méthode pour fermer le port série
        private void CloseCom()
        {
            // Fermeture du port
            serialPort1.Close();
            cbo_PortNames.Text = "Open"; // Met à jour le texte du combobox
            gb_Tx.Enabled = false; // Désactive le groupe Tx
            gb_Rx.Enabled = false; // Désactive le groupe Rx
            cbo_PortNames.Enabled = true; // Active le combobox
            bt_SendContinuous.Text = "Envoi continu"; // Met à jour le texte du bouton d'envoi continu

            // Récupère les noms de tous les ports série disponibles
            string[] ports = SerialPort.GetPortNames();
            cbo_PortNames.Items.Clear(); // Vide le combobox
            cbo_PortNames.Items.AddRange(ports); // Ajoute les noms de port dans le combobox
            cbo_PortNames.SelectedIndex = 0; // Sélection automatique du premier port

            // Nettoie les listes de transmission et réception
            lstDataIn.Items.Clear();
            lstDataOut.Items.Clear();
        } // Fin CloseCom

        // Méthode appelée lorsque des données sont reçues sur le port série
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            lstDataIn.BeginInvoke(myDelegate);  // Invoque le délégué pour afficher les données reçues
        }

        // Méthode appelée lorsque le bouton Open/Close est cliqué
        private void btOpenClose_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)    // Si le port n'est pas ouvert
            {
                // Configuration du port
                serialPort1.PortName = (string)cbo_PortNames.SelectedItem;
                serialPort1.BaudRate = 57600;
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.RequestToSend;

                // Définition des timeouts de lecture/écriture
                serialPort1.ReadTimeout = 100;
                serialPort1.WriteTimeout = 100;

                try
                {
                    serialPort1.Open(); // Ouvre le port

                    bt_OpenClose.Text = "Close"; // Met à jour le texte du bouton
                    lb_Port.Text = "Port ouvert"; // Affiche un message indiquant que le port est ouvert
                    gb_Rx.Enabled = true; // Active le groupe Rx
                    gb_Tx.Enabled = true; // Active le groupe Tx
                    cbo_PortNames.Enabled = false; // Désactive le combobox
                    cbo_Form.SelectedIndex = 0; // Sélectionne automatiquement la première forme
                }
                catch (Exception ex)
                {
                    if (!serialPort1.IsOpen)
                        MessageBox.Show(ex.ToString(), "Erreur à l'ouverture du port !", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Affiche un message d'erreur en cas d'échec
                }
            }
            else // Fermeture
            {
                serialPort1.Close();

                bt_OpenClose.Text = "Open"; // Met à jour le texte du bouton
                lb_Port.Text = "Port fermé"; // Affiche un message indiquant que le port est fermé
                gb_Rx.Enabled = false; // Désactive le groupe Rx
                gb_Tx.Enabled = false; // Désactive le groupe Tx
                cbo_PortNames.Enabled = true; // Active le combobox
            }

        } // Fin btOpenClose_Click

        // Méthode appelée lors du choix de la forme
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sélection de l'élément
            string choixSignal = cbo_Form.SelectedItem.ToString();

            // Modifier l'image en fonction du choix sélectionné
            switch (choixSignal)
            {
                case "Sinus":
                    // Charger et afficher l'image sinus.jpg
                    pb_PictureForm.Image = imageList1.Images[0];
                    break;
                case "Carre":
                    // Charger et afficher l'image carre.png
                    pb_PictureForm.Image = imageList1.Images[1];
                    break;
                case "Triangle":
                    // Charger et afficher l'image triangle.png
                    pb_PictureForm.Image = imageList1.Images[2];
                    break;
                case "Dent de scie":
                    // Charger et afficher l'image dent_de_scie.png
                    pb_PictureForm.Image = imageList1.Images[3];
                    break;
                default:
                    break;
            }
        } // Fin comboBox1_SelectedIndexChanged

        // Méthode appelée lorsqu'on change la valeur de UpDown_Freq (contrôle de la fréquence)
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            UpDown_Freq.Value = System.Math.Round(UpDown_Freq.Value / 20) * 20; // Force à l'arrondi le plus proche pour éviter d'avoir un autre offset que ceux désirés
        }

        // Méthode appelée lorsqu'on change la valeur de UpDown_Amp (contrôle de l'amplitude)
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpDown_Amp.Value = System.Math.Round(UpDown_Amp.Value / 100) * 100; // Force à l'arrondi le plus proche pour éviter d'avoir un autre offset que ceux désirés
        }

        // Méthode appelée lorsqu'on change la valeur de UpDown_Offset (contrôle de l'offset)
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            UpDown_Offset.Value = System.Math.Round(UpDown_Offset.Value / 100) * 100; // Force à l'arrondi le plus proche pour éviter d'avoir un autre offset que ceux désirés
        }

        // Méthode appelée lorsqu'on clique sur le bouton d'envoi
        private void bt_Send_Click(object sender, EventArgs e)
        {
            // Compose le message final
            string messageFinal = CompositionMessage();

            // Affiche le message dans la liste des données envoyées
            lstDataOut.Items.Add(messageFinal);

            // Convertit le message final en tableau de bytes
            byte[] Datasend = new byte[30];
            for (int i = 0; i < messageFinal.Length; i++)
            {
                Datasend[i] = Convert.ToByte(messageFinal[i]); // Convertit chaque caractère en byte
            }

            // Envoie la trame via le port série
            try
            {
                serialPort1.Write(Datasend, 0, Datasend.Length);  // Envoie les données via le port série
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur d'envoi", MessageBoxButtons.OK, MessageBoxIcon.Error);  // Affiche un message d'erreur en cas d'échec
            }
        } // Fin bt_Send_Click

        // Méthode appelée lorsqu'on clique sur le bouton d'envoi continu
        private void bt_SendContinuous_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) // Vérifie si le port série est ouvert
            {
                // Active l'envoi continu
                if (!timer1.Enabled)
                {
                    //active envoi continu
                    timer1.Interval = 50;  // Définit l'intervalle du timer pour envoyer un message toutes les 50 ms
                    timer1.Start(); // Démarre le timer
                    bt_SendContinuous.Text = "Stop envoi"; // Change le texte du bouton
                }
                else
                {
                    // Désactive l'envoi continu
                    timer1.Stop(); // Arrête le timer
                    bt_SendContinuous.Text = "Envoi continue"; // Change le texte du bouton
                }
            }
            else
            {
                MessageBox.Show("Port non ouvert", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); // Affiche un message d'erreur en cas d'échec
                timer1.Stop();  // Arrête le timer pour éviter les problèmes en mode continu
                CloseCom(); // Ferme le port si non ouvert correctement
            }
        } // Fin bt_SendContinuous_Click

        // Méthode appelée à chaque tick du timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) // Vérifie si le port série est ouvert
            {
                bt_Send_Click(sender, e); // Envoie un message
            }
            else
            {
                // Met à jour l'interface si le port est fermé
                bt_OpenClose.Text = "Open";
                gb_Tx.Enabled = false;
                gb_Rx.Enabled = false;
                lb_Port.Text = "Aucun Port Disponible !";
            }
        }

        // Méthode appelée lorsqu'on clique sur le bouton pour effacer les données Tx
        private void bt_Clear_TX_Click(object sender, EventArgs e)
        {
            lstDataOut.Items.Clear(); // Efface toutes les données de la liste des données envoyées
        }

        // Méthode appelée lorsqu'on clique sur le bouton pour effacer les données Rx
        private void bt_Clear_RX_Click(object sender, EventArgs e)
        {
            lstDataIn.Items.Clear(); // Efface toutes les données de la liste des données reçues
        }
    }
}



