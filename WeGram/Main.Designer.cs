namespace WindowsFormsApplication1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NotifyBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.PhoneNumT = new System.Windows.Forms.ComboBox();
            this.VerfyCodeB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.VerfyCodeT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectB = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ChatsDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetChatsBT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MessagesDGV = new System.Windows.Forms.DataGridView();
            this.ChannelsDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupsDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetGroupsBT = new System.Windows.Forms.Button();
            this.ContactsDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetContactsBT = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SendMessageB = new System.Windows.Forms.Button();
            this.MessageTB = new System.Windows.Forms.TextBox();
            this.MessageBOx = new System.Windows.Forms.TextBox();
            this.ForwardB = new System.Windows.Forms.Button();
            this.ForwardTB = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChatsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NotifyBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 571);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(700, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NotifyBar
            // 
            this.NotifyBar.Name = "NotifyBar";
            this.NotifyBar.Size = new System.Drawing.Size(66, 17);
            this.NotifyBar.Text = "خوش آمدید!";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 556);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.PhoneNumT);
            this.tabPage1.Controls.Add(this.VerfyCodeB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.VerfyCodeT);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ConnectB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اتصال";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(9, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "کمک مالی";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PhoneNumT
            // 
            this.PhoneNumT.FormattingEnabled = true;
            this.PhoneNumT.Location = new System.Drawing.Point(409, 6);
            this.PhoneNumT.Name = "PhoneNumT";
            this.PhoneNumT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PhoneNumT.Size = new System.Drawing.Size(197, 21);
            this.PhoneNumT.TabIndex = 26;
            // 
            // VerfyCodeB
            // 
            this.VerfyCodeB.Enabled = false;
            this.VerfyCodeB.Location = new System.Drawing.Point(9, 9);
            this.VerfyCodeB.Name = "VerfyCodeB";
            this.VerfyCodeB.Size = new System.Drawing.Size(85, 23);
            this.VerfyCodeB.TabIndex = 23;
            this.VerfyCodeB.Text = "تایید کد";
            this.VerfyCodeB.UseVisualStyleBackColor = true;
            this.VerfyCodeB.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "کد تایید:";
            // 
            // VerfyCodeT
            // 
            this.VerfyCodeT.Enabled = false;
            this.VerfyCodeT.Location = new System.Drawing.Point(100, 9);
            this.VerfyCodeT.Name = "VerfyCodeT";
            this.VerfyCodeT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VerfyCodeT.Size = new System.Drawing.Size(85, 21);
            this.VerfyCodeT.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "شماره همراه:";
            // 
            // ConnectB
            // 
            this.ConnectB.Location = new System.Drawing.Point(241, 6);
            this.ConnectB.Name = "ConnectB";
            this.ConnectB.Size = new System.Drawing.Size(162, 23);
            this.ConnectB.TabIndex = 19;
            this.ConnectB.Text = "اتصال";
            this.ConnectB.UseVisualStyleBackColor = true;
            this.ConnectB.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MessageBOx);
            this.tabPage3.Controls.Add(this.ChatsDGV);
            this.tabPage3.Controls.Add(this.GetChatsBT);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.MessagesDGV);
            this.tabPage3.Controls.Add(this.ChannelsDGV);
            this.tabPage3.Controls.Add(this.GroupsDGV);
            this.tabPage3.Controls.Add(this.GetGroupsBT);
            this.tabPage3.Controls.Add(this.ContactsDGV);
            this.tabPage3.Controls.Add(this.GetContactsBT);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(692, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "مخاطبان/گروه ها/کانالها";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ChatsDGV
            // 
            this.ChatsDGV.AllowUserToAddRows = false;
            this.ChatsDGV.AllowUserToDeleteRows = false;
            this.ChatsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChatsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.ChatsDGV.Location = new System.Drawing.Point(8, 6);
            this.ChatsDGV.Name = "ChatsDGV";
            this.ChatsDGV.ReadOnly = true;
            this.ChatsDGV.Size = new System.Drawing.Size(307, 139);
            this.ChatsDGV.TabIndex = 48;
            this.ChatsDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChatsDGV_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "عنوان";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "نام کاربری";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "همراه";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "کد";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "کدهش";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // GetChatsBT
            // 
            this.GetChatsBT.Location = new System.Drawing.Point(8, 151);
            this.GetChatsBT.Name = "GetChatsBT";
            this.GetChatsBT.Size = new System.Drawing.Size(307, 23);
            this.GetChatsBT.TabIndex = 47;
            this.GetChatsBT.Text = "دریافت لیست چت ها";
            this.GetChatsBT.UseVisualStyleBackColor = true;
            this.GetChatsBT.Click += new System.EventHandler(this.GetChatsBT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "لیست گروه ها:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "لیست پیام ها:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "لیست کانال ها:";
            // 
            // MessagesDGV
            // 
            this.MessagesDGV.AllowUserToAddRows = false;
            this.MessagesDGV.AllowUserToDeleteRows = false;
            this.MessagesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MessagesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.Column6,
            this.Column7});
            this.MessagesDGV.Location = new System.Drawing.Point(8, 193);
            this.MessagesDGV.Name = "MessagesDGV";
            this.MessagesDGV.ReadOnly = true;
            this.MessagesDGV.Size = new System.Drawing.Size(307, 218);
            this.MessagesDGV.TabIndex = 43;
            this.MessagesDGV.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.MessagesDGV_CellEnter);
            // 
            // ChannelsDGV
            // 
            this.ChannelsDGV.AllowUserToAddRows = false;
            this.ChannelsDGV.AllowUserToDeleteRows = false;
            this.ChannelsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChannelsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.ChannelsDGV.Location = new System.Drawing.Point(321, 354);
            this.ChannelsDGV.Name = "ChannelsDGV";
            this.ChannelsDGV.ReadOnly = true;
            this.ChannelsDGV.Size = new System.Drawing.Size(363, 139);
            this.ChannelsDGV.TabIndex = 42;
            this.ChannelsDGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ChannelsDGV_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "عنوان";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "نام کاربری";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "کد";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "کدهش";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // GroupsDGV
            // 
            this.GroupsDGV.AllowUserToAddRows = false;
            this.GroupsDGV.AllowUserToDeleteRows = false;
            this.GroupsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.GroupsDGV.Location = new System.Drawing.Point(321, 193);
            this.GroupsDGV.Name = "GroupsDGV";
            this.GroupsDGV.ReadOnly = true;
            this.GroupsDGV.Size = new System.Drawing.Size(363, 142);
            this.GroupsDGV.TabIndex = 40;
            this.GroupsDGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GroupsDGV_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "عنوان";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "نام کاربری";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "کد";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "کدهش";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // GetGroupsBT
            // 
            this.GetGroupsBT.Location = new System.Drawing.Point(321, 499);
            this.GetGroupsBT.Name = "GetGroupsBT";
            this.GetGroupsBT.Size = new System.Drawing.Size(363, 23);
            this.GetGroupsBT.TabIndex = 39;
            this.GetGroupsBT.Text = "دریافت لیست گروه ها/کانال ها";
            this.GetGroupsBT.UseVisualStyleBackColor = true;
            this.GetGroupsBT.Click += new System.EventHandler(this.GetGroupsBT_Click);
            // 
            // ContactsDGV
            // 
            this.ContactsDGV.AllowUserToAddRows = false;
            this.ContactsDGV.AllowUserToDeleteRows = false;
            this.ContactsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column2,
            this.Column3});
            this.ContactsDGV.Location = new System.Drawing.Point(321, 6);
            this.ContactsDGV.Name = "ContactsDGV";
            this.ContactsDGV.ReadOnly = true;
            this.ContactsDGV.Size = new System.Drawing.Size(363, 139);
            this.ContactsDGV.TabIndex = 38;
            this.ContactsDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContactsDGV_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "عنوان";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "نام کاربری";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "همراه";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "کد";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "کدهش";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // GetContactsBT
            // 
            this.GetContactsBT.Location = new System.Drawing.Point(321, 151);
            this.GetContactsBT.Name = "GetContactsBT";
            this.GetContactsBT.Size = new System.Drawing.Size(363, 23);
            this.GetContactsBT.TabIndex = 37;
            this.GetContactsBT.Text = "دریافت لیست مخاطبان";
            this.GetContactsBT.UseVisualStyleBackColor = true;
            this.GetContactsBT.Click += new System.EventHandler(this.GetContactsBT_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ForwardB);
            this.tabPage2.Controls.Add(this.ForwardTB);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.SendMessageB);
            this.tabPage2.Controls.Add(this.MessageTB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(692, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ارسال/فوروارد پیام";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(616, 21);
            this.textBox1.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "گیرنده پیام:";
            // 
            // SendMessageB
            // 
            this.SendMessageB.Enabled = false;
            this.SendMessageB.Location = new System.Drawing.Point(310, 128);
            this.SendMessageB.Name = "SendMessageB";
            this.SendMessageB.Size = new System.Drawing.Size(312, 41);
            this.SendMessageB.TabIndex = 32;
            this.SendMessageB.Text = "ارسال پیام";
            this.SendMessageB.UseVisualStyleBackColor = true;
            this.SendMessageB.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // MessageTB
            // 
            this.MessageTB.Enabled = false;
            this.MessageTB.Location = new System.Drawing.Point(310, 33);
            this.MessageTB.Multiline = true;
            this.MessageTB.Name = "MessageTB";
            this.MessageTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MessageTB.Size = new System.Drawing.Size(312, 89);
            this.MessageTB.TabIndex = 31;
            // 
            // MessageBOx
            // 
            this.MessageBOx.Location = new System.Drawing.Point(8, 417);
            this.MessageBOx.Multiline = true;
            this.MessageBOx.Name = "MessageBOx";
            this.MessageBOx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageBOx.Size = new System.Drawing.Size(307, 105);
            this.MessageBOx.TabIndex = 49;
            // 
            // ForwardB
            // 
            this.ForwardB.Location = new System.Drawing.Point(6, 128);
            this.ForwardB.Name = "ForwardB";
            this.ForwardB.Size = new System.Drawing.Size(298, 41);
            this.ForwardB.TabIndex = 37;
            this.ForwardB.Text = "فوروارد پیام";
            this.ForwardB.UseVisualStyleBackColor = true;
            this.ForwardB.Click += new System.EventHandler(this.ForwardB_Click);
            // 
            // ForwardTB
            // 
            this.ForwardTB.Enabled = false;
            this.ForwardTB.Location = new System.Drawing.Point(6, 33);
            this.ForwardTB.Multiline = true;
            this.ForwardTB.Name = "ForwardTB";
            this.ForwardTB.ReadOnly = true;
            this.ForwardTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ForwardTB.Size = new System.Drawing.Size(298, 89);
            this.ForwardTB.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "تاریخ";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "کد";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "پیام";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "peerID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "peerAccess";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 593);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "وی گرام | @WeCanCo | گروه وی کن";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChatsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NotifyBar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox PhoneNumT;
        private System.Windows.Forms.Button VerfyCodeB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VerfyCodeT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectB;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView ChannelsDGV;
        private System.Windows.Forms.DataGridView GroupsDGV;
        private System.Windows.Forms.Button GetGroupsBT;
        private System.Windows.Forms.DataGridView ContactsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button GetContactsBT;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SendMessageB;
        private System.Windows.Forms.TextBox MessageTB;
        private System.Windows.Forms.DataGridView MessagesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ChatsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Button GetChatsBT;
        private System.Windows.Forms.TextBox MessageBOx;
        private System.Windows.Forms.Button ForwardB;
        private System.Windows.Forms.TextBox ForwardTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

