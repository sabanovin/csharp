namespace smsApi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.apitxt = new System.Windows.Forms.TextBox();
            this.gatewaytxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resulttxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusCodeTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.send_single_or_group_sms_btn = new System.Windows.Forms.Button();
            this.single_group_numbers_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.single_group_sms_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.get_smses_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.from_date_get_sms_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.to_date_get_sms_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.number_add_to_phone_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.group_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.add_to_phonebook_btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.smes_pair_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numbers_pair_txt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.send_pair_pair_sms = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ApiKey";
            // 
            // apitxt
            // 
            this.apitxt.Location = new System.Drawing.Point(216, 35);
            this.apitxt.Name = "apitxt";
            this.apitxt.Size = new System.Drawing.Size(827, 22);
            this.apitxt.TabIndex = 1;
            this.apitxt.Text = "sa659126429:mLumyhIpZsDYyIo1PNhiPq9O0UpdZiOYoE6q";
            // 
            // gatewaytxt
            // 
            this.gatewaytxt.Location = new System.Drawing.Point(216, 65);
            this.gatewaytxt.Name = "gatewaytxt";
            this.gatewaytxt.Size = new System.Drawing.Size(827, 22);
            this.gatewaytxt.TabIndex = 3;
            this.gatewaytxt.Text = "10009398238801";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gateway";
            // 
            // resulttxt
            // 
            this.resulttxt.Location = new System.Drawing.Point(216, 763);
            this.resulttxt.Multiline = true;
            this.resulttxt.Name = "resulttxt";
            this.resulttxt.Size = new System.Drawing.Size(838, 120);
            this.resulttxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 766);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Json Result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "GetBalance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // messageTxt
            // 
            this.messageTxt.Location = new System.Drawing.Point(216, 735);
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(827, 22);
            this.messageTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 738);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message";
            // 
            // statusCodeTxt
            // 
            this.statusCodeTxt.Location = new System.Drawing.Point(216, 707);
            this.statusCodeTxt.Name = "statusCodeTxt";
            this.statusCodeTxt.Size = new System.Drawing.Size(827, 22);
            this.statusCodeTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 710);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status Code";
            // 
            // resTxt
            // 
            this.resTxt.Location = new System.Drawing.Point(216, 679);
            this.resTxt.Name = "resTxt";
            this.resTxt.Size = new System.Drawing.Size(827, 22);
            this.resTxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 682);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Result";
            // 
            // send_single_or_group_sms_btn
            // 
            this.send_single_or_group_sms_btn.Location = new System.Drawing.Point(216, 173);
            this.send_single_or_group_sms_btn.Name = "send_single_or_group_sms_btn";
            this.send_single_or_group_sms_btn.Size = new System.Drawing.Size(210, 32);
            this.send_single_or_group_sms_btn.TabIndex = 13;
            this.send_single_or_group_sms_btn.Text = "Send Single Or Group Sms";
            this.send_single_or_group_sms_btn.UseVisualStyleBackColor = true;
            this.send_single_or_group_sms_btn.Click += new System.EventHandler(this.send_single_or_group_sms_btn_Click);
            // 
            // single_group_numbers_txt
            // 
            this.single_group_numbers_txt.Location = new System.Drawing.Point(789, 178);
            this.single_group_numbers_txt.Name = "single_group_numbers_txt";
            this.single_group_numbers_txt.Size = new System.Drawing.Size(346, 22);
            this.single_group_numbers_txt.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(345, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Your Numbers:example(09398238801,09175555555)";
            // 
            // single_group_sms_txt
            // 
            this.single_group_sms_txt.Location = new System.Drawing.Point(1228, 178);
            this.single_group_sms_txt.Multiline = true;
            this.single_group_sms_txt.Name = "single_group_sms_txt";
            this.single_group_sms_txt.Size = new System.Drawing.Size(271, 83);
            this.single_group_sms_txt.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1153, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Your Text";
            // 
            // get_smses_btn
            // 
            this.get_smses_btn.Location = new System.Drawing.Point(55, 13);
            this.get_smses_btn.Name = "get_smses_btn";
            this.get_smses_btn.Size = new System.Drawing.Size(210, 32);
            this.get_smses_btn.TabIndex = 18;
            this.get_smses_btn.Text = "Get Smses";
            this.get_smses_btn.UseVisualStyleBackColor = true;
            this.get_smses_btn.Click += new System.EventHandler(this.get_smses_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Location = new System.Drawing.Point(161, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 43);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Location = new System.Drawing.Point(161, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1338, 113);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.to_date_get_sms_txt);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.from_date_get_sms_txt);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.get_smses_btn);
            this.panel3.Location = new System.Drawing.Point(161, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1338, 55);
            this.panel3.TabIndex = 20;
            // 
            // from_date_get_sms_txt
            // 
            this.from_date_get_sms_txt.Location = new System.Drawing.Point(502, 18);
            this.from_date_get_sms_txt.Name = "from_date_get_sms_txt";
            this.from_date_get_sms_txt.Size = new System.Drawing.Size(113, 22);
            this.from_date_get_sms_txt.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "From Date:Exapmle(1397/04/05)";
            // 
            // to_date_get_sms_txt
            // 
            this.to_date_get_sms_txt.Location = new System.Drawing.Point(838, 18);
            this.to_date_get_sms_txt.Name = "to_date_get_sms_txt";
            this.to_date_get_sms_txt.Size = new System.Drawing.Size(113, 22);
            this.to_date_get_sms_txt.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(625, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "To Date:Exapmle(1397/05/12)";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Plum;
            this.panel4.Controls.Add(this.number_add_to_phone_txt);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.group_id);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.add_to_phonebook_btn);
            this.panel4.Location = new System.Drawing.Point(161, 386);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1338, 55);
            this.panel4.TabIndex = 25;
            // 
            // number_add_to_phone_txt
            // 
            this.number_add_to_phone_txt.Location = new System.Drawing.Point(553, 18);
            this.number_add_to_phone_txt.Name = "number_add_to_phone_txt";
            this.number_add_to_phone_txt.Size = new System.Drawing.Size(141, 22);
            this.number_add_to_phone_txt.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Number";
            // 
            // group_id
            // 
            this.group_id.Location = new System.Drawing.Point(359, 18);
            this.group_id.Name = "group_id";
            this.group_id.Size = new System.Drawing.Size(113, 22);
            this.group_id.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "group_id";
            // 
            // add_to_phonebook_btn
            // 
            this.add_to_phonebook_btn.Location = new System.Drawing.Point(55, 13);
            this.add_to_phonebook_btn.Name = "add_to_phonebook_btn";
            this.add_to_phonebook_btn.Size = new System.Drawing.Size(210, 32);
            this.add_to_phonebook_btn.TabIndex = 18;
            this.add_to_phonebook_btn.Text = "Add To Phonebook";
            this.add_to_phonebook_btn.UseVisualStyleBackColor = true;
            this.add_to_phonebook_btn.Click += new System.EventHandler(this.add_to_phonebook_btn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel5.Controls.Add(this.smes_pair_txt);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.numbers_pair_txt);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.send_pair_pair_sms);
            this.panel5.Location = new System.Drawing.Point(161, 458);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1338, 174);
            this.panel5.TabIndex = 26;
            // 
            // smes_pair_txt
            // 
            this.smes_pair_txt.Location = new System.Drawing.Point(1067, 16);
            this.smes_pair_txt.Multiline = true;
            this.smes_pair_txt.Name = "smes_pair_txt";
            this.smes_pair_txt.Size = new System.Drawing.Size(252, 96);
            this.smes_pair_txt.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(843, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(215, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Your Textes:Example(text1,text2)";
            // 
            // numbers_pair_txt
            // 
            this.numbers_pair_txt.Location = new System.Drawing.Point(606, 18);
            this.numbers_pair_txt.Multiline = true;
            this.numbers_pair_txt.Name = "numbers_pair_txt";
            this.numbers_pair_txt.Size = new System.Drawing.Size(231, 94);
            this.numbers_pair_txt.TabIndex = 22;
            this.numbers_pair_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(289, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(311, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Numbers:example(09398238801,09399999999)";
            // 
            // send_pair_pair_sms
            // 
            this.send_pair_pair_sms.Location = new System.Drawing.Point(55, 13);
            this.send_pair_pair_sms.Name = "send_pair_pair_sms";
            this.send_pair_pair_sms.Size = new System.Drawing.Size(210, 32);
            this.send_pair_pair_sms.TabIndex = 18;
            this.send_pair_pair_sms.Text = "Send Pair to Pair Sms";
            this.send_pair_pair_sms.UseVisualStyleBackColor = true;
            this.send_pair_pair_sms.Click += new System.EventHandler(this.send_pair_pair_sms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 1017);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.single_group_sms_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.single_group_numbers_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.send_single_or_group_sms_btn);
            this.Controls.Add(this.resTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusCodeTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.messageTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resulttxt);
            this.Controls.Add(this.gatewaytxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apitxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apitxt;
        private System.Windows.Forms.TextBox gatewaytxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resulttxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox messageTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox statusCodeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button send_single_or_group_sms_btn;
        private System.Windows.Forms.TextBox single_group_numbers_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox single_group_sms_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button get_smses_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox to_date_get_sms_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox from_date_get_sms_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox number_add_to_phone_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox group_id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button add_to_phonebook_btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox smes_pair_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox numbers_pair_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button send_pair_pair_sms;
    }
}

