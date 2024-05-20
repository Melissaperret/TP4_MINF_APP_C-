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
            this.bt_Clear_TX = new System.Windows.Forms.Button();
            this.bt_SendContinuous = new System.Windows.Forms.Button();
            this.bt_Send = new System.Windows.Forms.Button();
            this.lstDataOut = new System.Windows.Forms.ListBox();
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
            this.lb_SaveOK = new System.Windows.Forms.Label();
            this.lb_Save_Rx = new System.Windows.Forms.Label();
            this.txt_Offset = new System.Windows.Forms.TextBox();
            this.txt_Amp = new System.Windows.Forms.TextBox();
            this.txt_Freq = new System.Windows.Forms.TextBox();
            this.lb_Offset_Rx = new System.Windows.Forms.Label();
            this.lb_Amp_Rx = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_Freq_Rx = new System.Windows.Forms.Label();
            this.txt_Form = new System.Windows.Forms.TextBox();
            this.bt_Clear_RX = new System.Windows.Forms.Button();
            this.lstDataIn = new System.Windows.Forms.ListBox();
            this.lb_Form_Rx = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.gbCom.Location = new System.Drawing.Point(21, 18);
            this.gbCom.Margin = new System.Windows.Forms.Padding(4);
            this.gbCom.Name = "gbCom";
            this.gbCom.Padding = new System.Windows.Forms.Padding(4);
            this.gbCom.Size = new System.Drawing.Size(1107, 94);
            this.gbCom.TabIndex = 6;
            this.gbCom.TabStop = false;
            this.gbCom.Text = "Ouverture port communication";
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Port.Location = new System.Drawing.Point(309, 38);
            this.lb_Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(106, 24);
            this.lb_Port.TabIndex = 3;
            this.lb_Port.Text = "Port fermé";
            // 
            // cbo_PortNames
            // 
            this.cbo_PortNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_PortNames.FormattingEnabled = true;
            this.cbo_PortNames.Location = new System.Drawing.Point(135, 38);
            this.cbo_PortNames.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_PortNames.Name = "cbo_PortNames";
            this.cbo_PortNames.Size = new System.Drawing.Size(125, 24);
            this.cbo_PortNames.TabIndex = 2;
            // 
            // bt_OpenClose
            // 
            this.bt_OpenClose.Location = new System.Drawing.Point(21, 37);
            this.bt_OpenClose.Margin = new System.Windows.Forms.Padding(4);
            this.bt_OpenClose.Name = "bt_OpenClose";
            this.bt_OpenClose.Size = new System.Drawing.Size(88, 27);
            this.bt_OpenClose.TabIndex = 0;
            this.bt_OpenClose.Text = "Open";
            this.bt_OpenClose.UseVisualStyleBackColor = true;
            this.bt_OpenClose.Click += new System.EventHandler(this.btOpenClose_Click);
            // 
            // gb_Tx
            // 
            this.gb_Tx.Controls.Add(this.bt_Clear_TX);
            this.gb_Tx.Controls.Add(this.bt_SendContinuous);
            this.gb_Tx.Controls.Add(this.bt_Send);
            this.gb_Tx.Controls.Add(this.lstDataOut);
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
            this.gb_Tx.Location = new System.Drawing.Point(21, 119);
            this.gb_Tx.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Tx.Name = "gb_Tx";
            this.gb_Tx.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Tx.Size = new System.Drawing.Size(547, 431);
            this.gb_Tx.TabIndex = 7;
            this.gb_Tx.TabStop = false;
            this.gb_Tx.Text = "Transmission_TX";
            // 
            // bt_Clear_TX
            // 
            this.bt_Clear_TX.Location = new System.Drawing.Point(380, 215);
            this.bt_Clear_TX.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Clear_TX.Name = "bt_Clear_TX";
            this.bt_Clear_TX.Size = new System.Drawing.Size(144, 28);
            this.bt_Clear_TX.TabIndex = 20;
            this.bt_Clear_TX.Text = "Clear liste TX";
            this.bt_Clear_TX.UseVisualStyleBackColor = true;
            this.bt_Clear_TX.Click += new System.EventHandler(this.bt_Clear_TX_Click);
            // 
            // bt_SendContinuous
            // 
            this.bt_SendContinuous.Location = new System.Drawing.Point(151, 215);
            this.bt_SendContinuous.Margin = new System.Windows.Forms.Padding(4);
            this.bt_SendContinuous.Name = "bt_SendContinuous";
            this.bt_SendContinuous.Size = new System.Drawing.Size(144, 28);
            this.bt_SendContinuous.TabIndex = 19;
            this.bt_SendContinuous.Text = "Envoie continu";
            this.bt_SendContinuous.UseVisualStyleBackColor = true;
            this.bt_SendContinuous.Click += new System.EventHandler(this.bt_SendContinuous_Click);
            // 
            // bt_Send
            // 
            this.bt_Send.Location = new System.Drawing.Point(27, 215);
            this.bt_Send.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(100, 28);
            this.bt_Send.TabIndex = 18;
            this.bt_Send.Text = "Envoi";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            // 
            // lstDataOut
            // 
            this.lstDataOut.FormattingEnabled = true;
            this.lstDataOut.ItemHeight = 16;
            this.lstDataOut.Location = new System.Drawing.Point(21, 263);
            this.lstDataOut.Margin = new System.Windows.Forms.Padding(4);
            this.lstDataOut.Name = "lstDataOut";
            this.lstDataOut.Size = new System.Drawing.Size(503, 148);
            this.lstDataOut.TabIndex = 17;
            // 
            // UpDown_Offset
            // 
            this.UpDown_Offset.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.UpDown_Offset.Location = new System.Drawing.Point(135, 167);
            this.UpDown_Offset.Margin = new System.Windows.Forms.Padding(4);
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
            this.UpDown_Offset.Size = new System.Drawing.Size(127, 22);
            this.UpDown_Offset.TabIndex = 16;
            this.UpDown_Offset.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // lb_Offset_Tx
            // 
            this.lb_Offset_Tx.AutoSize = true;
            this.lb_Offset_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Offset_Tx.Location = new System.Drawing.Point(19, 165);
            this.lb_Offset_Tx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Offset_Tx.Name = "lb_Offset_Tx";
            this.lb_Offset_Tx.Size = new System.Drawing.Size(57, 24);
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
            this.UpDown_Amp.Location = new System.Drawing.Point(135, 122);
            this.UpDown_Amp.Margin = new System.Windows.Forms.Padding(4);
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
            this.UpDown_Amp.Size = new System.Drawing.Size(127, 22);
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
            this.lb_Amp_Tx.Location = new System.Drawing.Point(19, 119);
            this.lb_Amp_Tx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Amp_Tx.Name = "lb_Amp_Tx";
            this.lb_Amp_Tx.Size = new System.Drawing.Size(95, 24);
            this.lb_Amp_Tx.TabIndex = 13;
            this.lb_Amp_Tx.Text = "Amplitude";
            // 
            // chk_Save
            // 
            this.chk_Save.AutoSize = true;
            this.chk_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Save.Location = new System.Drawing.Point(361, 167);
            this.chk_Save.Margin = new System.Windows.Forms.Padding(4);
            this.chk_Save.Name = "chk_Save";
            this.chk_Save.Size = new System.Drawing.Size(129, 24);
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
            this.UpDown_Freq.Location = new System.Drawing.Point(135, 76);
            this.UpDown_Freq.Margin = new System.Windows.Forms.Padding(4);
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
            this.UpDown_Freq.Size = new System.Drawing.Size(127, 22);
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
            this.lb_Freq_Tx.Location = new System.Drawing.Point(19, 74);
            this.lb_Freq_Tx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Freq_Tx.Name = "lb_Freq_Tx";
            this.lb_Freq_Tx.Size = new System.Drawing.Size(104, 24);
            this.lb_Freq_Tx.TabIndex = 9;
            this.lb_Freq_Tx.Text = "Fréquence";
            // 
            // lb_Form_Tx
            // 
            this.lb_Form_Tx.AutoSize = true;
            this.lb_Form_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Form_Tx.Location = new System.Drawing.Point(19, 28);
            this.lb_Form_Tx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Form_Tx.Name = "lb_Form_Tx";
            this.lb_Form_Tx.Size = new System.Drawing.Size(66, 24);
            this.lb_Form_Tx.TabIndex = 8;
            this.lb_Form_Tx.Text = "Forme";
            // 
            // pb_PictureForm
            // 
            this.pb_PictureForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_PictureForm.Location = new System.Drawing.Point(313, 28);
            this.pb_PictureForm.Margin = new System.Windows.Forms.Padding(4);
            this.pb_PictureForm.Name = "pb_PictureForm";
            this.pb_PictureForm.Size = new System.Drawing.Size(217, 131);
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
            this.cbo_Form.Location = new System.Drawing.Point(135, 28);
            this.cbo_Form.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Form.Name = "cbo_Form";
            this.cbo_Form.Size = new System.Drawing.Size(125, 24);
            this.cbo_Form.TabIndex = 4;
            this.cbo_Form.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // gb_Rx
            // 
            this.gb_Rx.Controls.Add(this.lb_SaveOK);
            this.gb_Rx.Controls.Add(this.lb_Save_Rx);
            this.gb_Rx.Controls.Add(this.txt_Offset);
            this.gb_Rx.Controls.Add(this.txt_Amp);
            this.gb_Rx.Controls.Add(this.txt_Freq);
            this.gb_Rx.Controls.Add(this.lb_Offset_Rx);
            this.gb_Rx.Controls.Add(this.lb_Amp_Rx);
            this.gb_Rx.Controls.Add(this.textBox2);
            this.gb_Rx.Controls.Add(this.lb_Freq_Rx);
            this.gb_Rx.Controls.Add(this.txt_Form);
            this.gb_Rx.Controls.Add(this.bt_Clear_RX);
            this.gb_Rx.Controls.Add(this.lstDataIn);
            this.gb_Rx.Controls.Add(this.lb_Form_Rx);
            this.gb_Rx.Location = new System.Drawing.Point(581, 119);
            this.gb_Rx.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Rx.Name = "gb_Rx";
            this.gb_Rx.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Rx.Size = new System.Drawing.Size(547, 431);
            this.gb_Rx.TabIndex = 12;
            this.gb_Rx.TabStop = false;
            this.gb_Rx.Text = "Réception_RX";
            // 
            // lb_SaveOK
            // 
            this.lb_SaveOK.AutoSize = true;
            this.lb_SaveOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SaveOK.Location = new System.Drawing.Point(355, 215);
            this.lb_SaveOK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_SaveOK.Name = "lb_SaveOK";
            this.lb_SaveOK.Size = new System.Drawing.Size(16, 24);
            this.lb_SaveOK.TabIndex = 32;
            this.lb_SaveOK.Text = "-";
            // 
            // lb_Save_Rx
            // 
            this.lb_Save_Rx.AutoSize = true;
            this.lb_Save_Rx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Save_Rx.Location = new System.Drawing.Point(225, 215);
            this.lb_Save_Rx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Save_Rx.Name = "lb_Save_Rx";
            this.lb_Save_Rx.Size = new System.Drawing.Size(122, 24);
            this.lb_Save_Rx.TabIndex = 31;
            this.lb_Save_Rx.Text = "Sauvegarde :";
            // 
            // txt_Offset
            // 
            this.txt_Offset.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Offset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Offset.Location = new System.Drawing.Point(163, 165);
            this.txt_Offset.Name = "txt_Offset";
            this.txt_Offset.Size = new System.Drawing.Size(214, 22);
            this.txt_Offset.TabIndex = 30;
            // 
            // txt_Amp
            // 
            this.txt_Amp.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Amp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Amp.Location = new System.Drawing.Point(163, 119);
            this.txt_Amp.Name = "txt_Amp";
            this.txt_Amp.Size = new System.Drawing.Size(214, 22);
            this.txt_Amp.TabIndex = 29;
            // 
            // txt_Freq
            // 
            this.txt_Freq.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Freq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Freq.Location = new System.Drawing.Point(163, 74);
            this.txt_Freq.Name = "txt_Freq";
            this.txt_Freq.Size = new System.Drawing.Size(214, 22);
            this.txt_Freq.TabIndex = 28;
            // 
            // lb_Offset_Rx
            // 
            this.lb_Offset_Rx.AutoSize = true;
            this.lb_Offset_Rx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Offset_Rx.Location = new System.Drawing.Point(17, 165);
            this.lb_Offset_Rx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Offset_Rx.Name = "lb_Offset_Rx";
            this.lb_Offset_Rx.Size = new System.Drawing.Size(57, 24);
            this.lb_Offset_Rx.TabIndex = 27;
            this.lb_Offset_Rx.Text = "Offset";
            // 
            // lb_Amp_Rx
            // 
            this.lb_Amp_Rx.AutoSize = true;
            this.lb_Amp_Rx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Amp_Rx.Location = new System.Drawing.Point(17, 119);
            this.lb_Amp_Rx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Amp_Rx.Name = "lb_Amp_Rx";
            this.lb_Amp_Rx.Size = new System.Drawing.Size(95, 24);
            this.lb_Amp_Rx.TabIndex = 25;
            this.lb_Amp_Rx.Text = "Amplitude";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 22);
            this.textBox2.TabIndex = 24;
            // 
            // lb_Freq_Rx
            // 
            this.lb_Freq_Rx.AutoSize = true;
            this.lb_Freq_Rx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Freq_Rx.Location = new System.Drawing.Point(17, 74);
            this.lb_Freq_Rx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Freq_Rx.Name = "lb_Freq_Rx";
            this.lb_Freq_Rx.Size = new System.Drawing.Size(104, 24);
            this.lb_Freq_Rx.TabIndex = 23;
            this.lb_Freq_Rx.Text = "Fréquence";
            // 
            // txt_Form
            // 
            this.txt_Form.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Form.Location = new System.Drawing.Point(163, 28);
            this.txt_Form.Name = "txt_Form";
            this.txt_Form.Size = new System.Drawing.Size(214, 22);
            this.txt_Form.TabIndex = 22;
            // 
            // bt_Clear_RX
            // 
            this.bt_Clear_RX.Location = new System.Drawing.Point(21, 215);
            this.bt_Clear_RX.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Clear_RX.Name = "bt_Clear_RX";
            this.bt_Clear_RX.Size = new System.Drawing.Size(144, 28);
            this.bt_Clear_RX.TabIndex = 21;
            this.bt_Clear_RX.Text = "Clear liste RX";
            this.bt_Clear_RX.UseVisualStyleBackColor = true;
            this.bt_Clear_RX.Click += new System.EventHandler(this.bt_Clear_RX_Click);
            // 
            // lstDataIn
            // 
            this.lstDataIn.FormattingEnabled = true;
            this.lstDataIn.ItemHeight = 16;
            this.lstDataIn.Location = new System.Drawing.Point(21, 263);
            this.lstDataIn.Margin = new System.Windows.Forms.Padding(4);
            this.lstDataIn.Name = "lstDataIn";
            this.lstDataIn.Size = new System.Drawing.Size(503, 148);
            this.lstDataIn.TabIndex = 19;
            // 
            // lb_Form_Rx
            // 
            this.lb_Form_Rx.AutoSize = true;
            this.lb_Form_Rx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Form_Rx.Location = new System.Drawing.Point(17, 28);
            this.lb_Form_Rx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Form_Rx.Name = "lb_Form_Rx";
            this.lb_Form_Rx.Size = new System.Drawing.Size(66, 24);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
        private System.Windows.Forms.ListBox lstDataOut;
        private System.Windows.Forms.ListBox lstDataIn;
        private System.Windows.Forms.Button bt_SendContinuous;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bt_Clear_TX;
        private System.Windows.Forms.Button bt_Clear_RX;
        private System.Windows.Forms.TextBox txt_Offset;
        private System.Windows.Forms.TextBox txt_Amp;
        private System.Windows.Forms.TextBox txt_Freq;
        private System.Windows.Forms.Label lb_Offset_Rx;
        private System.Windows.Forms.Label lb_Amp_Rx;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_Freq_Rx;
        private System.Windows.Forms.TextBox txt_Form;
        private System.Windows.Forms.Label lb_Save_Rx;
        private System.Windows.Forms.Label lb_SaveOK;
    }
}

