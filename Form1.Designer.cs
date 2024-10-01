namespace BankAccount
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            SelectMainWindow = new TabPage();
            dataGridView1 = new DataGridView();
            CreateMain = new TabPage();
            tabControl2 = new TabControl();
            Client = new TabPage();
            submit = new Button();
            PinInsert = new TextBox();
            PinFl = new Label();
            NameCreate = new TextBox();
            NameInsert = new Label();
            dataGridView3 = new DataGridView();
            Account = new TabPage();
            label15 = new Label();
            label14 = new Label();
            textBox4 = new TextBox();
            IdAccCr = new ComboBox();
            textBox3 = new TextBox();
            Type = new Label();
            Accouncr = new Button();
            A = new Label();
            dataGridView4 = new DataGridView();
            Card = new TabPage();
            textBox2 = new ComboBox();
            idTextboxType = new ComboBox();
            label3 = new Label();
            SubmitCard = new Button();
            TypeCard = new Label();
            Client_ = new Label();
            dataGridView5 = new DataGridView();
            UpdateMain = new TabPage();
            tabControl3 = new TabControl();
            ClientUpdate = new TabPage();
            label1 = new Label();
            TypeUpdate = new TextBox();
            CbUpdateName = new ComboBox();
            UpdateData = new Button();
            NameUpdate = new TextBox();
            label4 = new Label();
            UpdatePin = new Label();
            NewName = new Label();
            dataGridView2 = new DataGridView();
            DeleteMain = new TabPage();
            tabControl4 = new TabControl();
            ClientDelete = new TabPage();
            DDelete = new Button();
            label2 = new Label();
            Delete = new ComboBox();
            dataGridView6 = new DataGridView();
            Rubbish = new TabPage();
            ReverseSubmit = new Button();
            label5 = new Label();
            Reverse = new ComboBox();
            dataGridView7 = new DataGridView();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            npgsqlCommandBuilder2 = new Npgsql.NpgsqlCommandBuilder();
            tabControl1.SuspendLayout();
            SelectMainWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            CreateMain.SuspendLayout();
            tabControl2.SuspendLayout();
            Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            Account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            UpdateMain.SuspendLayout();
            tabControl3.SuspendLayout();
            ClientUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            DeleteMain.SuspendLayout();
            tabControl4.SuspendLayout();
            ClientDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            Rubbish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(SelectMainWindow);
            tabControl1.Controls.Add(CreateMain);
            tabControl1.Controls.Add(UpdateMain);
            tabControl1.Controls.Add(DeleteMain);
            tabControl1.Location = new Point(2, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 445);
            tabControl1.TabIndex = 0;
            // 
            // SelectMainWindow
            // 
            SelectMainWindow.Controls.Add(dataGridView1);
            SelectMainWindow.Location = new Point(4, 29);
            SelectMainWindow.Name = "SelectMainWindow";
            SelectMainWindow.Padding = new Padding(3);
            SelectMainWindow.Size = new Size(789, 412);
            SelectMainWindow.TabIndex = 0;
            SelectMainWindow.Text = "Select";
            SelectMainWindow.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.PapayaWhip;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(789, 416);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CreateMain
            // 
            CreateMain.Controls.Add(tabControl2);
            CreateMain.Location = new Point(4, 29);
            CreateMain.Name = "CreateMain";
            CreateMain.Padding = new Padding(3);
            CreateMain.Size = new Size(789, 412);
            CreateMain.TabIndex = 1;
            CreateMain.Text = "Create";
            CreateMain.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(Client);
            tabControl2.Controls.Add(Account);
            tabControl2.Controls.Add(Card);
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(789, 416);
            tabControl2.TabIndex = 0;
            // 
            // Client
            // 
            Client.BackColor = Color.PapayaWhip;
            Client.Controls.Add(submit);
            Client.Controls.Add(PinInsert);
            Client.Controls.Add(PinFl);
            Client.Controls.Add(NameCreate);
            Client.Controls.Add(NameInsert);
            Client.Controls.Add(dataGridView3);
            Client.Location = new Point(4, 29);
            Client.Name = "Client";
            Client.Padding = new Padding(3);
            Client.Size = new Size(781, 383);
            Client.TabIndex = 0;
            Client.Text = "Client";
            // 
            // submit
            // 
            submit.BackColor = SystemColors.Window;
            submit.Location = new Point(532, 249);
            submit.Name = "submit";
            submit.Size = new Size(107, 29);
            submit.TabIndex = 7;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // PinInsert
            // 
            PinInsert.BackColor = Color.AliceBlue;
            PinInsert.Location = new Point(491, 165);
            PinInsert.Name = "PinInsert";
            PinInsert.Size = new Size(200, 27);
            PinInsert.TabIndex = 6;
            PinInsert.TextChanged += PinInsert_TextChanged;
            // 
            // PinFl
            // 
            PinFl.AutoSize = true;
            PinFl.Location = new Point(429, 172);
            PinFl.Name = "PinFl";
            PinFl.Size = new Size(29, 20);
            PinFl.TabIndex = 5;
            PinFl.Text = "Pin";
            PinFl.Click += PinFl_Click;
            // 
            // NameCreate
            // 
            NameCreate.BackColor = Color.AliceBlue;
            NameCreate.Location = new Point(491, 72);
            NameCreate.Name = "NameCreate";
            NameCreate.Size = new Size(200, 27);
            NameCreate.TabIndex = 4;
            NameCreate.TextChanged += NameCreate_TextChanged;
            // 
            // NameInsert
            // 
            NameInsert.AutoSize = true;
            NameInsert.Location = new Point(429, 75);
            NameInsert.Name = "NameInsert";
            NameInsert.Size = new Size(49, 20);
            NameInsert.TabIndex = 3;
            NameInsert.Text = "Name";
            NameInsert.Click += NameInsert_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.PapayaWhip;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(363, 387);
            dataGridView3.TabIndex = 2;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // Account
            // 
            Account.BackColor = Color.PapayaWhip;
            Account.BackgroundImageLayout = ImageLayout.None;
            Account.Controls.Add(label15);
            Account.Controls.Add(label14);
            Account.Controls.Add(textBox4);
            Account.Controls.Add(IdAccCr);
            Account.Controls.Add(textBox3);
            Account.Controls.Add(Type);
            Account.Controls.Add(Accouncr);
            Account.Controls.Add(A);
            Account.Controls.Add(dataGridView4);
            Account.Location = new Point(4, 29);
            Account.Name = "Account";
            Account.Padding = new Padding(3);
            Account.Size = new Size(781, 383);
            Account.TabIndex = 1;
            Account.Text = "Account";
            Account.Click += Account_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(568, 80);
            label15.Name = "label15";
            label15.Size = new Size(52, 20);
            label15.TabIndex = 17;
            label15.Text = "Create";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(450, 121);
            label14.Name = "label14";
            label14.Size = new Size(63, 20);
            label14.TabIndex = 16;
            label14.Text = "Number";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.AliceBlue;
            textBox4.Location = new Point(528, 118);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 27);
            textBox4.TabIndex = 15;
            // 
            // IdAccCr
            // 
            IdAccCr.BackColor = Color.AliceBlue;
            IdAccCr.ForeColor = Color.Black;
            IdAccCr.FormattingEnabled = true;
            IdAccCr.Location = new Point(528, 230);
            IdAccCr.Name = "IdAccCr";
            IdAccCr.Size = new Size(151, 28);
            IdAccCr.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.AliceBlue;
            textBox3.Location = new Point(528, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 27);
            textBox3.TabIndex = 13;
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Location = new Point(450, 176);
            Type.Name = "Type";
            Type.Size = new Size(40, 20);
            Type.TabIndex = 12;
            Type.Text = "Type";
            // 
            // Accouncr
            // 
            Accouncr.BackColor = SystemColors.Window;
            Accouncr.Location = new Point(556, 300);
            Accouncr.Name = "Accouncr";
            Accouncr.Size = new Size(94, 29);
            Accouncr.TabIndex = 6;
            Accouncr.Text = "Submit";
            Accouncr.UseVisualStyleBackColor = false;
            Accouncr.Click += Accouncr_Click;
            // 
            // A
            // 
            A.AutoSize = true;
            A.Location = new Point(450, 233);
            A.Name = "A";
            A.Size = new Size(64, 20);
            A.TabIndex = 1;
            A.Text = "Client Id";
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = Color.PapayaWhip;
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(-4, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(420, 383);
            dataGridView4.TabIndex = 0;
            dataGridView4.CellContentClick += dataGridView4_CellContentClick;
            // 
            // Card
            // 
            Card.BackColor = Color.PapayaWhip;
            Card.Controls.Add(textBox2);
            Card.Controls.Add(idTextboxType);
            Card.Controls.Add(label3);
            Card.Controls.Add(SubmitCard);
            Card.Controls.Add(TypeCard);
            Card.Controls.Add(Client_);
            Card.Controls.Add(dataGridView5);
            Card.Location = new Point(4, 29);
            Card.Name = "Card";
            Card.Size = new Size(781, 383);
            Card.TabIndex = 2;
            Card.Text = "Card";
            Card.Click += Card_Click;
            // 
            // textBox2
            // 
            textBox2.FormattingEnabled = true;
            textBox2.Location = new Point(533, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 28);
            textBox2.TabIndex = 14;
            textBox2.SelectedIndexChanged += textBox2_SelectedIndexChanged;
            // 
            // idTextboxType
            // 
            idTextboxType.FormattingEnabled = true;
            idTextboxType.Location = new Point(533, 112);
            idTextboxType.Name = "idTextboxType";
            idTextboxType.Size = new Size(191, 28);
            idTextboxType.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(600, 50);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 12;
            label3.Text = "Data";
            // 
            // SubmitCard
            // 
            SubmitCard.BackColor = SystemColors.Window;
            SubmitCard.Location = new Point(579, 270);
            SubmitCard.Name = "SubmitCard";
            SubmitCard.Size = new Size(94, 29);
            SubmitCard.TabIndex = 5;
            SubmitCard.Text = "Submit";
            SubmitCard.UseVisualStyleBackColor = false;
            SubmitCard.Click += SubmitCard_Click;
            // 
            // TypeCard
            // 
            TypeCard.AutoSize = true;
            TypeCard.Location = new Point(445, 115);
            TypeCard.Name = "TypeCard";
            TypeCard.Size = new Size(40, 20);
            TypeCard.TabIndex = 4;
            TypeCard.Text = "Type";
            // 
            // Client_
            // 
            Client_.AutoSize = true;
            Client_.Location = new Point(445, 184);
            Client_.Name = "Client_";
            Client_.Size = new Size(64, 20);
            Client_.TabIndex = 1;
            Client_.Text = "Client Id";
            Client_.Click += Cardnumber_Click;
            // 
            // dataGridView5
            // 
            dataGridView5.BackgroundColor = Color.PapayaWhip;
            dataGridView5.BorderStyle = BorderStyle.None;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(0, 0);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.ReadOnly = true;
            dataGridView5.RowHeadersWidth = 51;
            dataGridView5.Size = new Size(398, 383);
            dataGridView5.TabIndex = 0;
            dataGridView5.CellContentClick += dataGridView5_CellContentClick;
            // 
            // UpdateMain
            // 
            UpdateMain.Controls.Add(tabControl3);
            UpdateMain.Location = new Point(4, 29);
            UpdateMain.Name = "UpdateMain";
            UpdateMain.Size = new Size(789, 412);
            UpdateMain.TabIndex = 2;
            UpdateMain.Text = "Update";
            UpdateMain.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(ClientUpdate);
            tabControl3.Location = new Point(-1, 1);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(790, 415);
            tabControl3.TabIndex = 0;
            // 
            // ClientUpdate
            // 
            ClientUpdate.BackColor = Color.PapayaWhip;
            ClientUpdate.Controls.Add(label1);
            ClientUpdate.Controls.Add(TypeUpdate);
            ClientUpdate.Controls.Add(CbUpdateName);
            ClientUpdate.Controls.Add(UpdateData);
            ClientUpdate.Controls.Add(NameUpdate);
            ClientUpdate.Controls.Add(label4);
            ClientUpdate.Controls.Add(UpdatePin);
            ClientUpdate.Controls.Add(NewName);
            ClientUpdate.Controls.Add(dataGridView2);
            ClientUpdate.Location = new Point(4, 29);
            ClientUpdate.Name = "ClientUpdate";
            ClientUpdate.Padding = new Padding(3);
            ClientUpdate.Size = new Size(782, 382);
            ClientUpdate.TabIndex = 0;
            ClientUpdate.Text = "Client";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(443, 236);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 12;
            label1.Text = "Type";
            // 
            // TypeUpdate
            // 
            TypeUpdate.BackColor = Color.AliceBlue;
            TypeUpdate.Location = new Point(512, 233);
            TypeUpdate.Name = "TypeUpdate";
            TypeUpdate.Size = new Size(207, 27);
            TypeUpdate.TabIndex = 11;
            TypeUpdate.TextChanged += TypeUpdate_TextChanged;
            // 
            // CbUpdateName
            // 
            CbUpdateName.BackColor = Color.AliceBlue;
            CbUpdateName.FormattingEnabled = true;
            CbUpdateName.Location = new Point(512, 125);
            CbUpdateName.Name = "CbUpdateName";
            CbUpdateName.Size = new Size(207, 28);
            CbUpdateName.TabIndex = 10;
            // 
            // UpdateData
            // 
            UpdateData.BackColor = SystemColors.Window;
            UpdateData.Location = new Point(568, 276);
            UpdateData.Name = "UpdateData";
            UpdateData.Size = new Size(94, 29);
            UpdateData.TabIndex = 9;
            UpdateData.Text = "Submit";
            UpdateData.UseVisualStyleBackColor = false;
            UpdateData.Click += UpdateData_Click;
            // 
            // NameUpdate
            // 
            NameUpdate.BackColor = Color.AliceBlue;
            NameUpdate.Location = new Point(512, 179);
            NameUpdate.Name = "NameUpdate";
            NameUpdate.Size = new Size(207, 27);
            NameUpdate.TabIndex = 3;
            NameUpdate.TextChanged += textBox7_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(583, 67);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 2;
            label4.Text = "Update";
            // 
            // UpdatePin
            // 
            UpdatePin.AutoSize = true;
            UpdatePin.Location = new Point(443, 182);
            UpdatePin.Name = "UpdatePin";
            UpdatePin.Size = new Size(63, 20);
            UpdatePin.TabIndex = 1;
            UpdatePin.Text = "Number";
            // 
            // NewName
            // 
            NewName.AutoSize = true;
            NewName.Location = new Point(444, 128);
            NewName.Name = "NewName";
            NewName.Size = new Size(49, 20);
            NewName.TabIndex = 1;
            NewName.Text = "Name";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.PapayaWhip;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(-3, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(376, 382);
            dataGridView2.TabIndex = 0;
            // 
            // DeleteMain
            // 
            DeleteMain.Controls.Add(tabControl4);
            DeleteMain.Location = new Point(4, 29);
            DeleteMain.Name = "DeleteMain";
            DeleteMain.Size = new Size(789, 412);
            DeleteMain.TabIndex = 3;
            DeleteMain.Text = "Delete";
            DeleteMain.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            tabControl4.Controls.Add(ClientDelete);
            tabControl4.Controls.Add(Rubbish);
            tabControl4.Location = new Point(-5, 0);
            tabControl4.Name = "tabControl4";
            tabControl4.SelectedIndex = 0;
            tabControl4.Size = new Size(798, 416);
            tabControl4.TabIndex = 0;
            // 
            // ClientDelete
            // 
            ClientDelete.BackColor = Color.PapayaWhip;
            ClientDelete.Controls.Add(DDelete);
            ClientDelete.Controls.Add(label2);
            ClientDelete.Controls.Add(Delete);
            ClientDelete.Controls.Add(dataGridView6);
            ClientDelete.Location = new Point(4, 29);
            ClientDelete.Name = "ClientDelete";
            ClientDelete.Size = new Size(790, 383);
            ClientDelete.TabIndex = 2;
            ClientDelete.Text = "Client";
            // 
            // DDelete
            // 
            DDelete.BackColor = SystemColors.Window;
            DDelete.Location = new Point(181, 291);
            DDelete.Name = "DDelete";
            DDelete.Size = new Size(94, 29);
            DDelete.TabIndex = 3;
            DDelete.Text = "Delete";
            DDelete.UseVisualStyleBackColor = false;
            DDelete.Click += DDelete_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 231);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 2;
            label2.Text = "Who want to delete";
            // 
            // Delete
            // 
            Delete.BackColor = Color.AliceBlue;
            Delete.FormattingEnabled = true;
            Delete.Location = new Point(153, 228);
            Delete.Name = "Delete";
            Delete.Size = new Size(151, 28);
            Delete.TabIndex = 1;
            // 
            // dataGridView6
            // 
            dataGridView6.BackgroundColor = Color.PapayaWhip;
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(-4, 0);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.RowHeadersWidth = 51;
            dataGridView6.Size = new Size(794, 200);
            dataGridView6.TabIndex = 0;
            // 
            // Rubbish
            // 
            Rubbish.BackColor = Color.PapayaWhip;
            Rubbish.Controls.Add(ReverseSubmit);
            Rubbish.Controls.Add(label5);
            Rubbish.Controls.Add(Reverse);
            Rubbish.Controls.Add(dataGridView7);
            Rubbish.Location = new Point(4, 29);
            Rubbish.Name = "Rubbish";
            Rubbish.Size = new Size(790, 383);
            Rubbish.TabIndex = 3;
            Rubbish.Text = "Bin";
            // 
            // ReverseSubmit
            // 
            ReverseSubmit.BackColor = SystemColors.Window;
            ReverseSubmit.Location = new Point(104, 287);
            ReverseSubmit.Name = "ReverseSubmit";
            ReverseSubmit.Size = new Size(94, 29);
            ReverseSubmit.TabIndex = 3;
            ReverseSubmit.Text = "Submit";
            ReverseSubmit.UseVisualStyleBackColor = false;
            ReverseSubmit.Click += ReverseSubmit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 230);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 2;
            label5.Text = "Reverse";
            // 
            // Reverse
            // 
            Reverse.BackColor = Color.AliceBlue;
            Reverse.FormattingEnabled = true;
            Reverse.Location = new Point(73, 227);
            Reverse.Name = "Reverse";
            Reverse.Size = new Size(151, 28);
            Reverse.TabIndex = 1;
            // 
            // dataGridView7
            // 
            dataGridView7.BackgroundColor = Color.PapayaWhip;
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(-4, 0);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 51;
            dataGridView7.Size = new Size(794, 200);
            dataGridView7.TabIndex = 0;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // npgsqlCommandBuilder2
            // 
            npgsqlCommandBuilder2.QuotePrefix = "\"";
            npgsqlCommandBuilder2.QuoteSuffix = "\"";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            SelectMainWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            CreateMain.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            Client.ResumeLayout(false);
            Client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            Account.ResumeLayout(false);
            Account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            Card.ResumeLayout(false);
            Card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            UpdateMain.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            ClientUpdate.ResumeLayout(false);
            ClientUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            DeleteMain.ResumeLayout(false);
            tabControl4.ResumeLayout(false);
            ClientDelete.ResumeLayout(false);
            ClientDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            Rubbish.ResumeLayout(false);
            Rubbish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage SelectMainWindow;
        private TabPage CreateMain;
        private TabPage UpdateMain;
        private TabPage DeleteMain;
        private DataGridView dataGridView1;
        private TabControl tabControl2;
        private TabPage Client;
        private TabControl tabControl3;
        private TabPage ClientUpdate;
        private TabControl tabControl4;
        private TabPage Card;
        private TabPage ClientDelete;
        private DataGridView dataGridView3;
        private Label NameInsert;
        private TextBox PinInsert;
        private Label PinFl;
        private TextBox NameCreate;
        private DataGridView dataGridView5;
        private Label Client_;
        private Button submit;
        private Label TypeCard;
        private Button SubmitCard;
        private Label label3;
        private TextBox NameUpdate;
        private Label label4;
        private Label UpdatePin;
        private Label NewName;
        private Button UpdateData;
        public DataGridView dataGridView2;
        private TabPage Account;
        private Label label15;
        private Label label14;
        private TextBox textBox4;
        private ComboBox IdAccCr;
        private TextBox textBox3;
        private Label Type;
        private Button Accouncr;
        private Label A;
        private DataGridView dataGridView4;
        private ComboBox textBox2;
        private ComboBox idTextboxType;
        private Label label1;
        private TextBox TypeUpdate;
        private ComboBox CbUpdateName;
        private DataGridView dataGridView6;
        private Label label2;
        private ComboBox Delete;
        private TabPage Rubbish;
        private DataGridView dataGridView7;
        private Label label5;
        private ComboBox Reverse;
        private Button DDelete;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Button ReverseSubmit;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder2;
    }
}
