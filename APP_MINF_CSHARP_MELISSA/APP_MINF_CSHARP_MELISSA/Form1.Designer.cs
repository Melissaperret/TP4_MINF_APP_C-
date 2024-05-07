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
            this.lb_Port = new System.Windows.Forms.Label();
            this.cbo_PortNames = new System.Windows.Forms.ComboBox();
            this.bt_OpenClose = new System.Windows.Forms.Button();
            this.gb_Tx = new System.Windows.Forms.GroupBox();
            this.bt_SendContinuous = new System.Windows.Forms.Button();
            this.bt_Send = new System.Windows.Forms.Button();
            this.IstDataOut = new System.Windows.Forms.ListBox();
            this.UpDown_Offset = new System.Windows.Forms.NumericUpDown();
            this.lb_Offset_Tx = new System.Windows.Forms.Label();
            this.UpDown_Amp = new System.Windows.Forms.NumericUpDown();
            this.lb_Amp_Tx = new System.Windows.Forms.Label();
            this.chk_Save = new System.Windows.Forms.CheckBox();
            this.UpDown_Freq = new System.Windows.Forms.NumericUpDown();
            this.lb_Freq_Tx = new System.Windows.Forms.Label();
            this.lb_Form_Tx = new System.Windows.Forms.Label();
            this.pb_PictureForm = new System.Windows.Forms.PictureBox();
            this.cbo_Form = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gb_Rx = new System.Windows.Forms.GroupBox();
            this.lstDataIn = new System.Windows.Forms.ListBox();
            this.lb_Form_Rx = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbCom.SuspendLayout();
            this.gb_Tx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Offset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Amp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PictureForm)).BeginInit();
            this.gb_Rx.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCom
            // 
            this.gbCom.Controls.Add(this.lb_Port);
            this.gbCom.Controls.Add(this.cbo_PortNames);
            this.gbCom.Controls.Add(this.bt_OpenClose);
            this.gbCom.Location = new System.Drawing.Point(16, 15);
            this.gbCom.Name = "gbCom";
            this.gbCom.Size = new System.Drawing.Size(830, 76);
            this.gbCom.TabIndex = 6;
            this.gbCom.TabStop = false;
            this.gbCom.Text = "Ouverture port communication";
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Port.Location = new System.Drawing.Point(232, 31);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(88, 18);
            this.lb_Port.TabIndex = 3;
            this.lb_Port.Text = "Port fermé";
            // 
            // cbo_PortNames
            // 
            this.cbo_PortNames.FormattingEnabled = true;
            this.cbo_PortNames.Location = new System.Drawing.Point(101, 31);
            this.cbo_PortNames.Name = "cbo_PortNames";
            this.cbo_PortNames.Size = new System.Drawing.Size(95, 21);
            this.cbo_PortNames.TabIndex = 2;
            // 
            // bt_OpenClose
            // 
            this.bt_OpenClose.Location = new System.Drawing.Point(16, 30);
            this.bt_OpenClose.Name = "bt_OpenClose";
            this.bt_OpenClose.Size = new System.Drawing.Size(66, 22);
            this.bt_OpenClose.TabIndex = 0;
            this.bt_OpenClose.Text = "Open";
            this.bt_OpenClose.UseVisualStyleBackColor = true;
            this.bt_OpenClose.Click += new System.EventHandler(this.btOpenClose_Click);
            // 
            // gb_Tx
            // 
            this.gb_Tx.Controls.Add(this.bt_SendContinuous);
            this.gb_Tx.Controls.Add(this.bt_Send);
            this.gb_Tx.Controls.Add(this.IstDataOut);
            this.gb_Tx.Controls.Add(this.UpDown_Offset);
            this.gb_Tx.Controls.Add(this.lb_Offset_Tx);
            this.gb_Tx.Controls.Add(this.UpDown_Amp);
            this.gb_Tx.Controls.Add(this.lb_Amp_Tx);
            this.gb_Tx.Controls.Add(this.chk_Save);
            this.gb_Tx.Controls.Add(this.UpDown_Freq);
            this.gb_Tx.Controls.Add(this.lb_Freq_Tx);
            this.gb_Tx.Controls.Add(this.lb_Form_Tx);
            this.gb_Tx.Controls.Add(this.pb_PictureForm);
            this.gb_Tx.Controls.Add(this.cbo_Form);
            this.gb_Tx.Location = new System.Drawing.Point(16, 97);
            this.gb_Tx.Name = "gb_Tx";
            this.gb_Tx.Size = new System.Drawing.Size(410, 350);
            this.gb_Tx.TabIndex = 7;
            this.gb_Tx.TabStop = false;
            this.gb_Tx.Text = "TX";
            // 
            // bt_SendContinuous
            // 
            this.bt_SendContinuous.Location = new System.Drawing.Point(113, 175);
            this.bt_SendContinuous.Name = "bt_SendContinuous";
            this.bt_SendContinuous.Size = new System.Drawing.Size(108, 23);
            this.bt_SendContinuous.TabIndex = 19;
            this.bt_SendContinuous.Text = "Envoie continu";
            this.bt_SendContinuous.UseVisualStyleBackColor = true;
            // 
            // bt_Send
            // 
            this.bt_Send.Location = new System.Drawing.Point(20, 175);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(75, 23);
            this.bt_Send.TabIndex = 18;
            this.bt_Send.Text = "Envoi";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // IstDataOut
            // 
            this.IstDataOut.FormattingEnabled = true;
            this.IstDataOut.Location = new System.Drawing.Point(16, 214);
            this.IstDataOut.Name = "IstDataOut";
            this.IstDataOut.Size = new System.Drawing.Size(378, 121);
            this.IstDataOut.TabIndex = 17;
            // 
            // UpDown_Offset
            // 
            this.UpDown_Offset.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.UpDown_Offset.Location = new System.Drawing.Point(101, 136);
            this.UpDown_Offset.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.UpDown_Offset.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.UpDown_Offset.Name = "UpDown_Offset";
            this.UpDown_Offset.Size = new System.Drawing.Size(95, 20);
            this.UpDown_Offset.TabIndex = 16;
            this.UpDown_Offset.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // lb_Offset_Tx
            // 
            this.lb_Offset_Tx.AutoSize = true;
            this.lb_Offset_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Offset_Tx.Location = new System.Drawing.Point(14, 134);
            this.lb_Offset_Tx.Name = "lb_Offset_Tx";
            this.lb_Offset_Tx.Size = new System.Drawing.Size(48, 18);
            this.lb_Offset_Tx.TabIndex = 15;
            this.lb_Offset_Tx.Text = "Offset";
            // 
            // UpDown_Amp
            // 
            this.UpDown_Amp.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.UpDown_Amp.Location = new System.Drawing.Point(101, 99);
            this.UpDown_Amp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.UpDown_Amp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.UpDown_Amp.Name = "UpDown_Amp";
            this.UpDown_Amp.Size = new System.Drawing.Size(95, 20);
            this.UpDown_Amp.TabIndex = 14;
            this.UpDown_Amp.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.UpDown_Amp.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lb_Amp_Tx
            // 
            this.lb_Amp_Tx.AutoSize = true;
            this.lb_Amp_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Amp_Tx.Location = new System.Drawing.Point(14, 97);
            this.lb_Amp_Tx.Name = "lb_Amp_Tx";
            this.lb_Amp_Tx.Size = new System.Drawing.Size(72, 18);
            this.lb_Amp_Tx.TabIndex = 13;
            this.lb_Amp_Tx.Text = "Amplitude";
            // 
            // chk_Save
            // 
            this.chk_Save.AutoSize = true;
            this.chk_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Save.Location = new System.Drawing.Point(271, 136);
            this.chk_Save.Name = "chk_Save";
            this.chk_Save.Size = new System.Drawing.Size(111, 20);
            this.chk_Save.TabIndex = 12;
            this.chk_Save.Text = "Sauvegarde";
            this.chk_Save.UseVisualStyleBackColor = true;
            // 
            // UpDown_Freq
            // 
            this.UpDown_Freq.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UpDown_Freq.Location = new System.Drawing.Point(101, 62);
            this.UpDown_Freq.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.UpDown_Freq.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UpDown_Freq.Name = "UpDown_Freq";
            this.UpDown_Freq.Size = new System.Drawing.Size(95, 20);
            this.UpDown_Freq.TabIndex = 11;
            this.UpDown_Freq.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UpDown_Freq.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // lb_Freq_Tx
            // 
            this.lb_Freq_Tx.AutoSize = true;
            this.lb_Freq_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Freq_Tx.Location = new System.Drawing.Point(14, 60);
            this.lb_Freq_Tx.Name = "lb_Freq_Tx";
            this.lb_Freq_Tx.Size = new System.Drawing.Size(78, 18);
            this.lb_Freq_Tx.TabIndex = 9;
            this.lb_Freq_Tx.Text = "Fréquence";
            // 
            // lb_Form_Tx
            // 
            this.lb_Form_Tx.AutoSize = true;
            this.lb_Form_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Form_Tx.Location = new System.Drawing.Point(14, 23);
            this.lb_Form_Tx.Name = "lb_Form_Tx";
            this.lb_Form_Tx.Size = new System.Drawing.Size(52, 18);
            this.lb_Form_Tx.TabIndex = 8;
            this.lb_Form_Tx.Text = "Forme";
            // 
            // pb_PictureForm
            // 
            this.pb_PictureForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_PictureForm.Location = new System.Drawing.Point(235, 23);
            this.pb_PictureForm.Name = "pb_PictureForm";
            this.pb_PictureForm.Size = new System.Drawing.Size(163, 107);
            this.pb_PictureForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PictureForm.TabIndex = 5;
            this.pb_PictureForm.TabStop = false;
            // 
            // cbo_Form
            // 
            this.cbo_Form.FormattingEnabled = true;
            this.cbo_Form.Items.AddRange(new object[] {
            "Sinus",
            "Carre",
            "Triangle",
            "Dent de scie"});
            this.cbo_Form.Location = new System.Drawing.Point(101, 23);
            this.cbo_Form.Name = "cbo_Form";
            this.cbo_Form.Size = new System.Drawing.Size(95, 21);
            this.cbo_Form.TabIndex = 4;
            this.cbo_Form.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gb_Rx
            // 
            this.gb_Rx.Controls.Add(this.lstDataIn);
            this.gb_Rx.Controls.Add(this.lb_Form_Rx);
            this.gb_Rx.Location = new System.Drawing.Point(436, 97);
            this.gb_Rx.Name = "gb_Rx";
            this.gb_Rx.Size = new System.Drawing.Size(410, 350);
            this.gb_Rx.TabIndex = 12;
            this.gb_Rx.TabStop = false;
            this.gb_Rx.Text = "RX";
            // 
            // lstDataIn
            // 
            this.lstDataIn.FormattingEnabled = true;
            this.lstDataIn.Location = new System.Drawing.Point(16, 214);
            this.lstDataIn.Name = "lstDataIn";
            this.lstDataIn.Size = new System.Drawing.Size(378, 121);
            this.lstDataIn.TabIndex = 19;
            // 
            // lb_Form_Rx
            // 
            this.lb_Form_Rx.AutoSize = true;
            this.lb_Form_Rx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Form_Rx.Location = new System.Drawing.Point(13, 35);
            this.lb_Form_Rx.Name = "lb_Form_Rx";
            this.lb_Form_Rx.Size = new System.Drawing.Size(52, 18);
            this.lb_Form_Rx.TabIndex = 9;
            this.lb_Form_Rx.Text = "Forme";
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
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Offset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Amp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_Freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PictureForm)).EndInit();
            this.gb_Rx.ResumeLayout(false);
            this.gb_Rx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCom;
        private System.Windows.Forms.Label lb_Port;
        private System.Windows.Forms.ComboBox cbo_PortNames;
        private System.Windows.Forms.Button bt_OpenClose;
        private System.Windows.Forms.GroupBox gb_Tx;
        private System.Windows.Forms.NumericUpDown UpDown_Freq;
        private System.Windows.Forms.Label lb_Freq_Tx;
        private System.Windows.Forms.Label lb_Form_Tx;
        private System.Windows.Forms.PictureBox pb_PictureForm;
        private System.Windows.Forms.ComboBox cbo_Form;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chk_Save;
        private System.Windows.Forms.GroupBox gb_Rx;
        private System.Windows.Forms.Label lb_Form_Rx;
        private System.Windows.Forms.NumericUpDown UpDown_Amp;
        private System.Windows.Forms.Label lb_Amp_Tx;
        private System.Windows.Forms.NumericUpDown UpDown_Offset;
        private System.Windows.Forms.Label lb_Offset_Tx;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.ListBox IstDataOut;
        private System.Windows.Forms.ListBox lstDataIn;
        private System.Windows.Forms.Button bt_SendContinuous;
    }
}

