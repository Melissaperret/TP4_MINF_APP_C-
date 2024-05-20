using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace APP_MINF_CSHARP_MELISSA
{
    public partial class Form1 : Form
    {
        public delegate void ReceiverD();
        public ReceiverD myDelegate;


        public Form1()
        {
            InitializeComponent();
            //met tous les noms de port dans un tableau
            string[] ports = SerialPort.GetPortNames();
            //Array.Sort(ports);
            cbo_PortNames.Items.AddRange(ports);

            if (ports.Length > 0)
            {
                cbo_PortNames.SelectedIndex = 0; // Selection automatique du premier port
            }
            else
            {
                bt_OpenClose.Enabled = false; // Griser le bouton Open
                lb_Port.Text = "Aucun Port Disponible !"; // Message informatif pour l'utilisateur
            }

            gb_Tx.Enabled = false;
            gb_Rx.Enabled = false;

            myDelegate = new ReceiverD(DispInListRxData);
        }

        string CompositionMessage()
        {
            string messageTotal;

            messageTotal = "!S=";
            //gestion du caractère à afficher
            //switch (datas[0])
            //{
            //    case 0:
            //        messageTotal += "S";
            //        break;
            //    case 1:
            //        messageTotal += "C";
            //        break;
            //    case 2:
            //        messageTotal += "T";
            //        break;
            //    case 3:
            //        messageTotal += "D";
            //        break;
            //    default:
            //        break;
            //}

            messageTotal += ((string)cbo_Form.SelectedItem)[0]; // Ajoute la première lettre du nom de la formée sélectionée

            messageTotal += "F="; // Affiche F=
            messageTotal += UpDown_Freq.Value.ToString();
            //messageTotal += $"F={UpDown_Freq.Value}";

            messageTotal += "A="; // Affiche le A=
            messageTotal += UpDown_Amp.Value.ToString();
            //messageTotal += $"A={UpDown_Amp.Value.Value}";

            messageTotal += "O="; // Affiche le O=

            if (UpDown_Offset.Value >= 0)
            {
                messageTotal += "+";
            }

            messageTotal += UpDown_Offset.Value.ToString();

            messageTotal += "W="; // Affiche le W=

            //Gestion de la sauvegarde avec l'aide du bouton "Sauvegarde"
            if (chk_Save.Checked == true)
            {
                messageTotal += "1"; // Affiche 1 si le bouton est coché 
            }
            else
            {
                messageTotal += "0"; // Affiche 0 si le bouton est décoché 
            }
            messageTotal += "#"; // Affiche # à la fin de la trame 

            return messageTotal;
        }

        public void DispInListRxData()
        {
            int a = serialPort1.BytesToRead;

            byte[] data = new byte[30];  // 30 pour prendre en compte le + et le P dans le message reçu

            // Recherche début de trame
            do
            {
                data[0] = (byte)serialPort1.ReadByte();
            } while (data[0] != '!');    // Tant que RxMess != "!"

            int index = 0;
            while (data[index] != '#')
            {
                if (serialPort1.BytesToRead > 0)
                {
                    index++;
                    data[index] = (byte)serialPort1.ReadByte();
                }
            }


            //int bytesRead = serialPort1.Read(data, 0, data.Length);
            string receivedMessage = System.Text.Encoding.ASCII.GetString(data, 0, index + 1);
            //string receivedMessage = serialPort1.ReadExisting();

            // Décodage et mise à jour des champs de texte
            string[] parts = receivedMessage.Split('='); // Divise le message en parties séparées par '='

            // Assurez-vous que le message est bien formé avant de le traiter
            if (parts.Length >= 5 && parts[0] == "!S")
            {
                txt_Form.Text = parts[1].TrimEnd('F'); // Mise à jour du champ de texte pour la forme
                txt_Freq.Text = parts[2].TrimEnd('A'); // Mise à jour du champ de texte pour la fréquence
                txt_Amp.Text = parts[3].TrimEnd('O'); // Mise à jour du champ de texte pour l'amplitude                
                txt_Offset.Text = parts[4].TrimStart('+').TrimEnd('W', 'P'); // Mise à jour du champ de texte pour l'offset

                bool saved = Convert.ToBoolean(int.Parse(parts[5].TrimEnd('#')));
                if (saved)
                {
                    lb_SaveOK.Text = "Oui";
                }
                else
                {
                    lb_SaveOK.Text = "Non";
                }
            }

            //bool hasOne = receivedMessage.EndsWith("1#");
            ////Met à jour lb_SaveOK en conséquence
            //lb_SaveOK.Text = hasOne ? "oui" : "non";

            // Ajoute le message reçu à la liste des données entrantes
            lstDataIn.Items.Add(receivedMessage);

            // Limite la liste à 10 éléments
            if (lstDataIn.Items.Count > 10)
            {
                lstDataIn.Items.RemoveAt(0);
            }
        }

        private void CloseCom()
        {
            // Fermeture du port
            serialPort1.Close();
            cbo_PortNames.Text = "Open";
            gb_Tx.Enabled = false;
            gb_Rx.Enabled = false;
            cbo_PortNames.Enabled = true;
            bt_SendContinuous.Text = "Envoi continu";

            // Vérification des ports
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            cbo_PortNames.Items.Clear();
            cbo_PortNames.Items.AddRange(ports);
            cbo_PortNames.SelectedIndex = 0;

            // Nettoyage des listes de transmition récéption
            lstDataIn.Items.Clear();
            lstDataOut.Items.Clear();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //lstDataIn.Invoke(myDelegate);
            lstDataIn.BeginInvoke(myDelegate);
        }

        private void btOpenClose_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)    //ouverture du port
            {
                // Configuration du port
                serialPort1.PortName = (string)cbo_PortNames.SelectedItem;
                serialPort1.BaudRate = 57600;
                serialPort1.Parity = Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Handshake = Handshake.RequestToSend;

                // Set the read/write timeouts
                serialPort1.ReadTimeout = 100;
                serialPort1.WriteTimeout = 100;

                try
                {
                    serialPort1.Open();

                    bt_OpenClose.Text = "Close";
                    lb_Port.Text = "Port ouvert";
                    gb_Rx.Enabled = true;
                    gb_Tx.Enabled = true;
                    cbo_PortNames.Enabled = false;
                    cbo_Form.SelectedIndex = 0;

                }
                catch (Exception ex)
                {
                    if (!serialPort1.IsOpen)
                        MessageBox.Show(ex.ToString(), "Erreur à l'ouverture du port !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //fermeture
            {
                serialPort1.Close();

                bt_OpenClose.Text = "Open";
                lb_Port.Text = "Port fermé";
                gb_Rx.Enabled = false;
                gb_Tx.Enabled = false;
                cbo_PortNames.Enabled = true;
            }

        } // end btOpenClose_Click

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
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            UpDown_Freq.Value = System.Math.Round(UpDown_Freq.Value / 20) * 20; //Force à l'arrondi le plus proche pour éviter d'avoir un autre offset que ceux désirés
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpDown_Amp.Value = System.Math.Round(UpDown_Amp.Value / 100) * 100; //Force à l'arrondi le plus proche pour éviter d'avoir un autre offset que ceux désirés
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            UpDown_Offset.Value = System.Math.Round(UpDown_Offset.Value / 100) * 100; //Force à l'arrondi le plus proche pour éviter d'avoir un autre offset que ceux désirés
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            // Compose le message final
            string messageFinal = CompositionMessage();

            // Affiche le message dans la liste
            lstDataOut.Items.Add(messageFinal);

            // Convertit le message final en tableau de bytes
            byte[] Datasend = new byte[30];
            for (int i = 0; i < messageFinal.Length; i++)
            {
                Datasend[i] = Convert.ToByte(messageFinal[i]);
            }

            // Envoie la trame via le port série
            try
            {
                serialPort1.Write(Datasend, 0, Datasend.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Erreur d'envoi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_SendContinuous_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (!timer1.Enabled)
                {
                    //active envoi continu
                    timer1.Interval = 50;  // pour 1 message chaque 50 ms
                    timer1.Start();
                    bt_SendContinuous.Text = "Stop envoi";
                }
                else
                {
                    //désactive envoi continu
                    timer1.Stop();
                    bt_SendContinuous.Text = "Envoi continue";
                }
            }
            else
            {
                MessageBox.Show("Port non ouvert", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Stop();     // pour éviter problème en mode continu

                CloseCom(); // Fermeture du port si non ouvert correctement
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bt_Send_Click(sender, e);
        }

        private void bt_Clear_TX_Click(object sender, EventArgs e)
        {
            lstDataOut.Items.Clear();
        }

        private void bt_Clear_RX_Click(object sender, EventArgs e)
        {
            lstDataIn.Items.Clear();
        }
    }
}


