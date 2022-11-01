namespace GoodocV4LinkOnDotNetSample
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
            this.textBoxChartCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHospitalCode = new System.Windows.Forms.TextBox();
            this.textBoxInitType = new System.Windows.Forms.TextBox();
            this.textBoxSendData = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonInit = new System.Windows.Forms.Button();
            this.buttonDeinit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxReceiveData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxChartCode
            // 
            this.textBoxChartCode.Location = new System.Drawing.Point(162, 46);
            this.textBoxChartCode.Name = "textBoxChartCode";
            this.textBoxChartCode.Size = new System.Drawing.Size(285, 47);
            this.textBoxChartCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "차트코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "병원코드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "구동타입";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "송신";
            // 
            // textBoxHospitalCode
            // 
            this.textBoxHospitalCode.Location = new System.Drawing.Point(162, 124);
            this.textBoxHospitalCode.Name = "textBoxHospitalCode";
            this.textBoxHospitalCode.Size = new System.Drawing.Size(285, 47);
            this.textBoxHospitalCode.TabIndex = 5;
            // 
            // textBoxInitType
            // 
            this.textBoxInitType.Location = new System.Drawing.Point(162, 202);
            this.textBoxInitType.Name = "textBoxInitType";
            this.textBoxInitType.Size = new System.Drawing.Size(285, 47);
            this.textBoxInitType.TabIndex = 6;
            // 
            // textBoxSendData
            // 
            this.textBoxSendData.Location = new System.Drawing.Point(22, 474);
            this.textBoxSendData.Multiline = true;
            this.textBoxSendData.Name = "textBoxSendData";
            this.textBoxSendData.Size = new System.Drawing.Size(915, 248);
            this.textBoxSendData.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeinit);
            this.groupBox1.Controls.Add(this.buttonInit);
            this.groupBox1.Controls.Add(this.textBoxInitType);
            this.groupBox1.Controls.Add(this.textBoxHospitalCode);
            this.groupBox1.Controls.Add(this.textBoxChartCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 371);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Init";
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(18, 283);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(216, 58);
            this.buttonInit.TabIndex = 7;
            this.buttonInit.Text = "Init";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // buttonDeinit
            // 
            this.buttonDeinit.Location = new System.Drawing.Point(240, 283);
            this.buttonDeinit.Name = "buttonDeinit";
            this.buttonDeinit.Size = new System.Drawing.Size(207, 58);
            this.buttonDeinit.TabIndex = 8;
            this.buttonDeinit.Text = "Deinit";
            this.buttonDeinit.UseVisualStyleBackColor = true;
            this.buttonDeinit.Click += new System.EventHandler(this.buttonDeinit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLogin);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(530, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 371);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 41);
            this.label5.TabIndex = 0;
            this.label5.Text = "아이디";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 41);
            this.label6.TabIndex = 1;
            this.label6.Text = "암호";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 47);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 47);
            this.textBox2.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(23, 283);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(364, 58);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(22, 728);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(915, 201);
            this.buttonSend.TabIndex = 10;
            this.buttonSend.Text = "전송";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(957, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 41);
            this.label7.TabIndex = 11;
            this.label7.Text = "수신";
            // 
            // textBoxReceiveData
            // 
            this.textBoxReceiveData.Location = new System.Drawing.Point(957, 70);
            this.textBoxReceiveData.Multiline = true;
            this.textBoxReceiveData.Name = "textBoxReceiveData";
            this.textBoxReceiveData.ReadOnly = true;
            this.textBoxReceiveData.Size = new System.Drawing.Size(941, 859);
            this.textBoxReceiveData.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 941);
            this.Controls.Add(this.textBoxReceiveData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxSendData);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxChartCode;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxHospitalCode;
        private TextBox textBoxInitType;
        private TextBox textBoxSendData;
        private GroupBox groupBox1;
        private Button buttonDeinit;
        private Button buttonInit;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Button buttonLogin;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button buttonSend;
        private Label label7;
        private TextBox textBoxReceiveData;
    }
}