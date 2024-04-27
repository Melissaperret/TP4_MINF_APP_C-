using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace APP_MINF_CSHARP_MELISSA
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btOpenClose_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)    //ouverture du port
            {
                // Configuration du port
                serialPort1.PortName = (string)cboPortNames.SelectedItem;
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

                    btOpenClose.Text = "Close";
                    gb_Rx.Enabled = true;
                    gb_Tx.Enabled = true;
                    cboPortNames.Enabled = false;
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

                btOpenClose.Text = "Open";
                gb_Rx.Enabled = true;
                gb_Tx.Enabled = true;
                cboPortNames.Enabled = true;
                //timer1.Stop();
                //btSendContinuous.Text = "Envoi continu";
            }

        } // end btOpenClose_Click

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sélection de l'élément
            string choixSignal = comboBox1.SelectedItem.ToString();

            // Modifier l'image en fonction du choix sélectionné
            switch (choixSignal)
            {
                case "Sinus":
                    // Charger et afficher l'image sinus.jpg
                    pb_ImagesFormes.Image = imageList1.Images[0];
                    break;
                case "Carre":
                    // Charger et afficher l'image carre.png
                    pb_ImagesFormes.Image = imageList1.Images[1];
                    break;
                case "Triangle":
                    // Charger et afficher l'image triangle.png
                    pb_ImagesFormes.Image = imageList1.Images[2];
                    break;
                case "Dent de scie":
                    // Charger et afficher l'image dent_de_scie.png
                    pb_ImagesFormes.Image = imageList1.Images[3];
                    break;
                default:
                    break;
            }
        }

        private void pb_Images_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Value = System.Math.Round(numericUpDown2.Value / 20) * 20;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = System.Math.Round(numericUpDown1.Value / 100) * 100;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            //Force à l'arrondi le plus proche pour éviter d'avoir un autre offset que ceux désirés
            numericUpDown3.Value = System.Math.Round(numericUpDown3.Value / 100) * 100;
        }
    }

}
