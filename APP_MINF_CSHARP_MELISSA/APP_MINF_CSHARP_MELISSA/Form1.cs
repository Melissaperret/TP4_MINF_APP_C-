using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace APP_MINF_CSHARP_MELISSA
{
    public partial class Form1 : Form
    {
        int[] datas = new int[4];

        public Form1()
        {
            InitializeComponent();
            //met tous les noms de port dans un tableau
            string[] ports = SerialPort.GetPortNames();
            //Array.Sort(ports);
            cbo_PortNames.Items.AddRange(ports);
            gb_Tx.Enabled = false;
            gb_Rx.Enabled = false;
            
            datas[1] = 20; //Mettre 20 pour la case 2 de datas pour éviter les beugs

        }

        string CompositionMessage()
        {
            string messageTotal;
            datas[0] = cbo_Form.SelectedIndex;

            messageTotal = "!S=";
            //gestion du caractère à afficher
            switch (datas[0])
            {
                case 0:
                    messageTotal += "S";
                    break;
                case 1:
                    messageTotal += "C";
                    break;
                case 2:
                    messageTotal += "T";
                    break;
                case 3:
                    messageTotal += "D";
                    break;
                default:

                    break;
            }
            messageTotal += "F="; // Affiche F=
            messageTotal += UpDown_Freq.Value.ToString();

            messageTotal += "A="; // Affiche le A=
            messageTotal += UpDown_Amp.Value.ToString();

            messageTotal += "O="; // Affiche le O=
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

                lb_Port.Text = "Port fermé";
                gb_Rx.Enabled = false;
                gb_Tx.Enabled = false;
                cbo_PortNames.Enabled = true;
                //timer1.Stop();
                //btSendContinuous.Text = "Envoi continu";
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
            byte[] envoieData = new byte[28];
            
            string messageFinal = CompositionMessage(); // Compose le message final 

            IstDataOut.Items.Add(messageFinal);

            //envoi de le trame 
            try
            {
                serialPort1.Write(envoieData, 0, 27);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Message correct");
            }
        }

    }
}


