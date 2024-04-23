namespace APP_MINF_CSHARP_MELISSA
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbCom = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPortNames = new System.Windows.Forms.ComboBox();
            this.btOpenClose = new System.Windows.Forms.Button();
            this.gb_Tx = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lb_Freq_Tx = new System.Windows.Forms.Label();
            this.lb_Forme_Tx = new System.Windows.Forms.Label();
            this.pb_Images = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gb_Rx = new System.Windows.Forms.GroupBox();
            this.lb_Forme_Rx = new System.Windows.Forms.Label();
            this.cb_Sauvegarde = new System.Windows.Forms.CheckBox();
            this.lb_Amp_Tx = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lb_Offset_Tx = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.gbCom.SuspendLayout();
            this.gb_Tx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Images)).BeginInit();
            this.gb_Rx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCom
            // 
            this.gbCom.Controls.Add(this.label4);
            this.gbCom.Controls.Add(this.cboPortNames);
            this.gbCom.Controls.Add(this.btOpenClose);
            this.gbCom.Location = new System.Drawing.Point(16, 15);
            this.gbCom.Name = "gbCom";
            this.gbCom.Size = new System.Drawing.Size(830, 76);
            this.gbCom.TabIndex = 6;
            this.gbCom.TabStop = false;
            this.gbCom.Text = "Ouverture port communication";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port fermé";
            // 
            // cboPortNames
            // 
            this.cboPortNames.FormattingEnabled = true;
            this.cboPortNames.Location = new System.Drawing.Point(101, 31);
            this.cboPortNames.Name = "cboPortNames";
            this.cboPortNames.Size = new System.Drawing.Size(95, 21);
            this.cboPortNames.TabIndex = 2;
            this.cboPortNames.SelectedIndexChanged += new System.EventHandler(this.cmbport_SelectedIndexChanged);
            // 
            // btOpenClose
            // 
            this.btOpenClose.Location = new System.Drawing.Point(16, 30);
            this.btOpenClose.Name = "btOpenClose";
            this.btOpenClose.Size = new System.Drawing.Size(66, 22);
            this.btOpenClose.TabIndex = 0;
            this.btOpenClose.Text = "Open";
            this.btOpenClose.UseVisualStyleBackColor = true;
            this.btOpenClose.Click += new System.EventHandler(this.btOpenClose_Click);
            // 
            // gb_Tx
            // 
            this.gb_Tx.Controls.Add(this.numericUpDown3);
            this.gb_Tx.Controls.Add(this.lb_Offset_Tx);
            this.gb_Tx.Controls.Add(this.numericUpDown1);
            this.gb_Tx.Controls.Add(this.lb_Amp_Tx);
            this.gb_Tx.Controls.Add(this.cb_Sauvegarde);
            this.gb_Tx.Controls.Add(this.numericUpDown2);
            this.gb_Tx.Controls.Add(this.lb_Freq_Tx);
            this.gb_Tx.Controls.Add(this.lb_Forme_Tx);
            this.gb_Tx.Controls.Add(this.pb_Images);
            this.gb_Tx.Controls.Add(this.comboBox1);
            this.gb_Tx.Location = new System.Drawing.Point(16, 97);
            this.gb_Tx.Name = "gb_Tx";
            this.gb_Tx.Size = new System.Drawing.Size(410, 350);
            this.gb_Tx.TabIndex = 7;
            this.gb_Tx.TabStop = false;
            this.gb_Tx.Text = "TX";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(101, 74);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lb_Freq_Tx
            // 
            this.lb_Freq_Tx.AutoSize = true;
            this.lb_Freq_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Freq_Tx.Location = new System.Drawing.Point(14, 72);
            this.lb_Freq_Tx.Name = "lb_Freq_Tx";
            this.lb_Freq_Tx.Size = new System.Drawing.Size(78, 18);
            this.lb_Freq_Tx.TabIndex = 9;
            this.lb_Freq_Tx.Text = "Fréquence";
            // 
            // lb_Forme_Tx
            // 
            this.lb_Forme_Tx.AutoSize = true;
            this.lb_Forme_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Forme_Tx.Location = new System.Drawing.Point(14, 35);
            this.lb_Forme_Tx.Name = "lb_Forme_Tx";
            this.lb_Forme_Tx.Size = new System.Drawing.Size(52, 18);
            this.lb_Forme_Tx.TabIndex = 8;
            this.lb_Forme_Tx.Text = "Forme";
            // 
            // pb_Images
            // 
            this.pb_Images.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Images.Image = global::APP_MINF_CSHARP_MELISSA.Properties.Resources._1;
            this.pb_Images.Location = new System.Drawing.Point(235, 23);
            this.pb_Images.Name = "pb_Images";
            this.pb_Images.Size = new System.Drawing.Size(154, 94);
            this.pb_Images.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Images.TabIndex = 5;
            this.pb_Images.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sinus",
            "Carre",
            "Triangle",
            "Dent de scie"});
            this.comboBox1.Location = new System.Drawing.Point(101, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // gb_Rx
            // 
            this.gb_Rx.Controls.Add(this.lb_Forme_Rx);
            this.gb_Rx.Location = new System.Drawing.Point(436, 97);
            this.gb_Rx.Name = "gb_Rx";
            this.gb_Rx.Size = new System.Drawing.Size(410, 350);
            this.gb_Rx.TabIndex = 12;
            this.gb_Rx.TabStop = false;
            this.gb_Rx.Text = "RX";
            // 
            // lb_Forme_Rx
            // 
            this.lb_Forme_Rx.AutoSize = true;
            this.lb_Forme_Rx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Forme_Rx.Location = new System.Drawing.Point(13, 35);
            this.lb_Forme_Rx.Name = "lb_Forme_Rx";
            this.lb_Forme_Rx.Size = new System.Drawing.Size(52, 18);
            this.lb_Forme_Rx.TabIndex = 9;
            this.lb_Forme_Rx.Text = "Forme";
            // 
            // cb_Sauvegarde
            // 
            this.cb_Sauvegarde.AutoSize = true;
            this.cb_Sauvegarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Sauvegarde.Location = new System.Drawing.Point(257, 123);
            this.cb_Sauvegarde.Name = "cb_Sauvegarde";
            this.cb_Sauvegarde.Size = new System.Drawing.Size(111, 20);
            this.cb_Sauvegarde.TabIndex = 12;
            this.cb_Sauvegarde.Text = "Sauvegarde";
            this.cb_Sauvegarde.UseVisualStyleBackColor = true;
            // 
            // lb_Amp_Tx
            // 
            this.lb_Amp_Tx.AutoSize = true;
            this.lb_Amp_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Amp_Tx.Location = new System.Drawing.Point(14, 109);
            this.lb_Amp_Tx.Name = "lb_Amp_Tx";
            this.lb_Amp_Tx.Size = new System.Drawing.Size(72, 18);
            this.lb_Amp_Tx.TabIndex = 13;
            this.lb_Amp_Tx.Text = "Amplitude";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(101, 111);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lb_Offset_Tx
            // 
            this.lb_Offset_Tx.AutoSize = true;
            this.lb_Offset_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Offset_Tx.Location = new System.Drawing.Point(14, 146);
            this.lb_Offset_Tx.Name = "lb_Offset_Tx";
            this.lb_Offset_Tx.Size = new System.Drawing.Size(48, 18);
            this.lb_Offset_Tx.TabIndex = 15;
            this.lb_Offset_Tx.Text = "Offset";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(101, 148);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown3.TabIndex = 16;
            this.numericUpDown3.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 486);
            this.Controls.Add(this.gb_Rx);
            this.Controls.Add(this.gb_Tx);
            this.Controls.Add(this.gbCom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCom.ResumeLayout(false);
            this.gbCom.PerformLayout();
            this.gb_Tx.ResumeLayout(false);
            this.gb_Tx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Images)).EndInit();
            this.gb_Rx.ResumeLayout(false);
            this.gb_Rx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPortNames;
        private System.Windows.Forms.Button btOpenClose;
        private System.Windows.Forms.GroupBox gb_Tx;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lb_Freq_Tx;
        private System.Windows.Forms.Label lb_Forme_Tx;
        private System.Windows.Forms.PictureBox pb_Images;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox cb_Sauvegarde;
        private System.Windows.Forms.GroupBox gb_Rx;
        private System.Windows.Forms.Label lb_Forme_Rx;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lb_Amp_Tx;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label lb_Offset_Tx;
    }
}

