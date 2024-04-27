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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbCom = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPortNames = new System.Windows.Forms.ComboBox();
            this.btOpenClose = new System.Windows.Forms.Button();
            this.gb_Tx = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.lb_Offset_Tx = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lb_Amp_Tx = new System.Windows.Forms.Label();
            this.cb_Sauvegarde = new System.Windows.Forms.CheckBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lb_Freq_Tx = new System.Windows.Forms.Label();
            this.lb_Forme_Tx = new System.Windows.Forms.Label();
            this.pb_ImagesFormes = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gb_Rx = new System.Windows.Forms.GroupBox();
            this.lb_Forme_Rx = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbCom.SuspendLayout();
            this.gb_Tx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagesFormes)).BeginInit();
            this.gb_Rx.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCom
            // 
            this.gbCom.Controls.Add(this.label4);
            this.gbCom.Controls.Add(this.cboPortNames);
            this.gbCom.Controls.Add(this.btOpenClose);
            this.gbCom.Location = new System.Drawing.Point(21, 18);
            this.gbCom.Margin = new System.Windows.Forms.Padding(4);
            this.gbCom.Name = "gbCom";
            this.gbCom.Padding = new System.Windows.Forms.Padding(4);
            this.gbCom.Size = new System.Drawing.Size(1107, 94);
            this.gbCom.TabIndex = 6;
            this.gbCom.TabStop = false;
            this.gbCom.Text = "Ouverture port communication";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port fermé";
            // 
            // cboPortNames
            // 
            this.cboPortNames.FormattingEnabled = true;
            this.cboPortNames.Location = new System.Drawing.Point(135, 38);
            this.cboPortNames.Margin = new System.Windows.Forms.Padding(4);
            this.cboPortNames.Name = "cboPortNames";
            this.cboPortNames.Size = new System.Drawing.Size(125, 24);
            this.cboPortNames.TabIndex = 2;
            this.cboPortNames.SelectedIndexChanged += new System.EventHandler(this.cmbport_SelectedIndexChanged);
            // 
            // btOpenClose
            // 
            this.btOpenClose.Location = new System.Drawing.Point(21, 37);
            this.btOpenClose.Margin = new System.Windows.Forms.Padding(4);
            this.btOpenClose.Name = "btOpenClose";
            this.btOpenClose.Size = new System.Drawing.Size(88, 27);
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
            this.gb_Tx.Controls.Add(this.pb_ImagesFormes);
            this.gb_Tx.Controls.Add(this.comboBox1);
            this.gb_Tx.Location = new System.Drawing.Point(21, 119);
            this.gb_Tx.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Tx.Name = "gb_Tx";
            this.gb_Tx.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Tx.Size = new System.Drawing.Size(547, 431);
            this.gb_Tx.TabIndex = 7;
            this.gb_Tx.TabStop = false;
            this.gb_Tx.Text = "TX";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(135, 182);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(127, 22);
            this.numericUpDown3.TabIndex = 16;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // lb_Offset_Tx
            // 
            this.lb_Offset_Tx.AutoSize = true;
            this.lb_Offset_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Offset_Tx.Location = new System.Drawing.Point(19, 180);
            this.lb_Offset_Tx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Offset_Tx.Name = "lb_Offset_Tx";
            this.lb_Offset_Tx.Size = new System.Drawing.Size(57, 24);
            this.lb_Offset_Tx.TabIndex = 15;
            this.lb_Offset_Tx.Text = "Offset";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(135, 137);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(127, 22);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lb_Amp_Tx
            // 
            this.lb_Amp_Tx.AutoSize = true;
            this.lb_Amp_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Amp_Tx.Location = new System.Drawing.Point(19, 134);
            this.lb_Amp_Tx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Amp_Tx.Name = "lb_Amp_Tx";
            this.lb_Amp_Tx.Size = new System.Drawing.Size(95, 24);
            this.lb_Amp_Tx.TabIndex = 13;
            this.lb_Amp_Tx.Text = "Amplitude";
            // 
            // cb_Sauvegarde
            // 
            this.cb_Sauvegarde.AutoSize = true;
            this.cb_Sauvegarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Sauvegarde.Location = new System.Drawing.Point(361, 167);
            this.cb_Sauvegarde.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Sauvegarde.Name = "cb_Sauvegarde";
            this.cb_Sauvegarde.Size = new System.Drawing.Size(129, 24);
            this.cb_Sauvegarde.TabIndex = 12;
            this.cb_Sauvegarde.Text = "Sauvegarde";
            this.cb_Sauvegarde.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(135, 91);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
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
            this.numericUpDown2.Size = new System.Drawing.Size(127, 22);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // lb_Freq_Tx
            // 
            this.lb_Freq_Tx.AutoSize = true;
            this.lb_Freq_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Freq_Tx.Location = new System.Drawing.Point(19, 89);
            this.lb_Freq_Tx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Freq_Tx.Name = "lb_Freq_Tx";
            this.lb_Freq_Tx.Size = new System.Drawing.Size(104, 24);
            this.lb_Freq_Tx.TabIndex = 9;
            this.lb_Freq_Tx.Text = "Fréquence";
            // 
            // lb_Forme_Tx
            // 
            this.lb_Forme_Tx.AutoSize = true;
            this.lb_Forme_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Forme_Tx.Location = new System.Drawing.Point(19, 43);
            this.lb_Forme_Tx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Forme_Tx.Name = "lb_Forme_Tx";
            this.lb_Forme_Tx.Size = new System.Drawing.Size(66, 24);
            this.lb_Forme_Tx.TabIndex = 8;
            this.lb_Forme_Tx.Text = "Forme";
            // 
            // pb_ImagesFormes
            // 
            this.pb_ImagesFormes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_ImagesFormes.Location = new System.Drawing.Point(313, 28);
            this.pb_ImagesFormes.Margin = new System.Windows.Forms.Padding(4);
            this.pb_ImagesFormes.Name = "pb_ImagesFormes";
            this.pb_ImagesFormes.Size = new System.Drawing.Size(217, 131);
            this.pb_ImagesFormes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ImagesFormes.TabIndex = 5;
            this.pb_ImagesFormes.TabStop = false;
            this.pb_ImagesFormes.Click += new System.EventHandler(this.pb_Images_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sinus",
            "Carre",
            "Triangle",
            "Dent de scie"});
            this.comboBox1.Location = new System.Drawing.Point(135, 43);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gb_Rx
            // 
            this.gb_Rx.Controls.Add(this.lb_Forme_Rx);
            this.gb_Rx.Location = new System.Drawing.Point(581, 119);
            this.gb_Rx.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Rx.Name = "gb_Rx";
            this.gb_Rx.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Rx.Size = new System.Drawing.Size(547, 431);
            this.gb_Rx.TabIndex = 12;
            this.gb_Rx.TabStop = false;
            this.gb_Rx.Text = "RX";
            // 
            // lb_Forme_Rx
            // 
            this.lb_Forme_Rx.AutoSize = true;
            this.lb_Forme_Rx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Forme_Rx.Location = new System.Drawing.Point(17, 43);
            this.lb_Forme_Rx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Forme_Rx.Name = "lb_Forme_Rx";
            this.lb_Forme_Rx.Size = new System.Drawing.Size(66, 24);
            this.lb_Forme_Rx.TabIndex = 9;
            this.lb_Forme_Rx.Text = "Forme";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Sinus.png");
            this.imageList1.Images.SetKeyName(1, "Carre.png");
            this.imageList1.Images.SetKeyName(2, "Triangle.png");
            this.imageList1.Images.SetKeyName(3, "DentDeScie.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 598);
            this.Controls.Add(this.gb_Rx);
            this.Controls.Add(this.gb_Tx);
            this.Controls.Add(this.gbCom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCom.ResumeLayout(false);
            this.gbCom.PerformLayout();
            this.gb_Tx.ResumeLayout(false);
            this.gb_Tx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagesFormes)).EndInit();
            this.gb_Rx.ResumeLayout(false);
            this.gb_Rx.PerformLayout();
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
        private System.Windows.Forms.PictureBox pb_ImagesFormes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox cb_Sauvegarde;
        private System.Windows.Forms.GroupBox gb_Rx;
        private System.Windows.Forms.Label lb_Forme_Rx;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lb_Amp_Tx;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label lb_Offset_Tx;
        private System.Windows.Forms.ImageList imageList1;


    }
}

