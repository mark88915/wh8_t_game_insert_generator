namespace tgame_insert_sql_generator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSelectBtn = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.generateBtn = new System.Windows.Forms.Button();
            this.gametype = new System.Windows.Forms.TextBox();
            this.gametypelabel = new System.Windows.Forms.Label();
            this.gamekindlabel = new System.Windows.Forms.Label();
            this.gamekind = new System.Windows.Forms.TextBox();
            this.devicelabel = new System.Windows.Forms.Label();
            this.device = new System.Windows.Forms.TextBox();
            this.platformlabel = new System.Windows.Forms.Label();
            this.platform = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.isThExist = new System.Windows.Forms.RadioButton();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.isViExist = new System.Windows.Forms.RadioButton();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.isIdExist = new System.Windows.Forms.RadioButton();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.isEsExist = new System.Windows.Forms.RadioButton();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.isPtExist = new System.Windows.Forms.RadioButton();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSelectBtn
            // 
            this.fileSelectBtn.Font = new System.Drawing.Font("新細明體", 18F);
            this.fileSelectBtn.Location = new System.Drawing.Point(33, 694);
            this.fileSelectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.fileSelectBtn.Name = "fileSelectBtn";
            this.fileSelectBtn.Size = new System.Drawing.Size(168, 49);
            this.fileSelectBtn.TabIndex = 0;
            this.fileSelectBtn.Text = "Select File";
            this.fileSelectBtn.UseVisualStyleBackColor = true;
            this.fileSelectBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("新細明體", 18F);
            this.fileNameLabel.Location = new System.Drawing.Point(28, 108);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(163, 30);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "檔案名稱：";
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Font = new System.Drawing.Font("新細明體", 18F);
            this.fileName.Location = new System.Drawing.Point(28, 138);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(193, 30);
            this.fileName.TabIndex = 2;
            this.fileName.Text = "尚未選擇檔案";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_FileOk);
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("新細明體", 14F);
            this.generateBtn.Location = new System.Drawing.Point(209, 694);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(168, 49);
            this.generateBtn.TabIndex = 3;
            this.generateBtn.Text = "SQL Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // gametype
            // 
            this.gametype.Font = new System.Drawing.Font("新細明體", 18F);
            this.gametype.Location = new System.Drawing.Point(197, 235);
            this.gametype.Name = "gametype";
            this.gametype.Size = new System.Drawing.Size(211, 43);
            this.gametype.TabIndex = 4;
            // 
            // gametypelabel
            // 
            this.gametypelabel.AutoSize = true;
            this.gametypelabel.Font = new System.Drawing.Font("新細明體", 18F);
            this.gametypelabel.Location = new System.Drawing.Point(28, 238);
            this.gametypelabel.Name = "gametypelabel";
            this.gametypelabel.Size = new System.Drawing.Size(160, 30);
            this.gametypelabel.TabIndex = 5;
            this.gametypelabel.Text = "Gametype：";
            this.gametypelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gamekindlabel
            // 
            this.gamekindlabel.AutoSize = true;
            this.gamekindlabel.Font = new System.Drawing.Font("新細明體", 18F);
            this.gamekindlabel.Location = new System.Drawing.Point(27, 290);
            this.gamekindlabel.Name = "gamekindlabel";
            this.gamekindlabel.Size = new System.Drawing.Size(161, 30);
            this.gamekindlabel.TabIndex = 7;
            this.gamekindlabel.Text = "Gamekind：";
            this.gamekindlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gamekind
            // 
            this.gamekind.Font = new System.Drawing.Font("新細明體", 18F);
            this.gamekind.Location = new System.Drawing.Point(197, 287);
            this.gamekind.Name = "gamekind";
            this.gamekind.Size = new System.Drawing.Size(211, 43);
            this.gamekind.TabIndex = 6;
            // 
            // devicelabel
            // 
            this.devicelabel.AutoSize = true;
            this.devicelabel.Font = new System.Drawing.Font("新細明體", 18F);
            this.devicelabel.Location = new System.Drawing.Point(32, 346);
            this.devicelabel.Name = "devicelabel";
            this.devicelabel.Size = new System.Drawing.Size(124, 30);
            this.devicelabel.TabIndex = 9;
            this.devicelabel.Text = "Device：";
            this.devicelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // device
            // 
            this.device.Font = new System.Drawing.Font("新細明體", 18F);
            this.device.Location = new System.Drawing.Point(197, 343);
            this.device.Name = "device";
            this.device.Size = new System.Drawing.Size(211, 43);
            this.device.TabIndex = 8;
            // 
            // platformlabel
            // 
            this.platformlabel.AutoSize = true;
            this.platformlabel.Font = new System.Drawing.Font("新細明體", 18F);
            this.platformlabel.Location = new System.Drawing.Point(32, 401);
            this.platformlabel.Name = "platformlabel";
            this.platformlabel.Size = new System.Drawing.Size(142, 30);
            this.platformlabel.TabIndex = 11;
            this.platformlabel.Text = "Platform：";
            this.platformlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // platform
            // 
            this.platform.Font = new System.Drawing.Font("新細明體", 18F);
            this.platform.Location = new System.Drawing.Point(197, 398);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(211, 43);
            this.platform.TabIndex = 10;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.isThExist);
            this.GroupBox1.Location = new System.Drawing.Point(37, 456);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(119, 59);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "是否有th";
            // 
            // isThExist
            // 
            this.isThExist.AutoSize = true;
            this.isThExist.Location = new System.Drawing.Point(6, 24);
            this.isThExist.Name = "isThExist";
            this.isThExist.Size = new System.Drawing.Size(43, 19);
            this.isThExist.TabIndex = 0;
            this.isThExist.TabStop = true;
            this.isThExist.Text = "有";
            this.isThExist.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.isViExist);
            this.GroupBox2.Location = new System.Drawing.Point(226, 456);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(111, 59);
            this.GroupBox2.TabIndex = 13;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "是否有vi";
            // 
            // isViExist
            // 
            this.isViExist.AutoSize = true;
            this.isViExist.Location = new System.Drawing.Point(6, 24);
            this.isViExist.Name = "isViExist";
            this.isViExist.Size = new System.Drawing.Size(43, 19);
            this.isViExist.TabIndex = 0;
            this.isViExist.TabStop = true;
            this.isViExist.Text = "有";
            this.isViExist.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.isIdExist);
            this.GroupBox3.Location = new System.Drawing.Point(37, 531);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(119, 59);
            this.GroupBox3.TabIndex = 14;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "是否有id";
            // 
            // isIdExist
            // 
            this.isIdExist.AutoSize = true;
            this.isIdExist.Location = new System.Drawing.Point(6, 24);
            this.isIdExist.Name = "isIdExist";
            this.isIdExist.Size = new System.Drawing.Size(43, 19);
            this.isIdExist.TabIndex = 0;
            this.isIdExist.TabStop = true;
            this.isIdExist.Text = "有";
            this.isIdExist.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.isEsExist);
            this.GroupBox4.Location = new System.Drawing.Point(226, 531);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(111, 59);
            this.GroupBox4.TabIndex = 15;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "是否有es";
            // 
            // isEsExist
            // 
            this.isEsExist.AutoSize = true;
            this.isEsExist.Location = new System.Drawing.Point(6, 24);
            this.isEsExist.Name = "isEsExist";
            this.isEsExist.Size = new System.Drawing.Size(43, 19);
            this.isEsExist.TabIndex = 0;
            this.isEsExist.TabStop = true;
            this.isEsExist.Text = "有";
            this.isEsExist.UseVisualStyleBackColor = true;
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.isPtExist);
            this.GroupBox5.Location = new System.Drawing.Point(37, 607);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(119, 59);
            this.GroupBox5.TabIndex = 16;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "是否有pt";
            // 
            // isPtExist
            // 
            this.isPtExist.AutoSize = true;
            this.isPtExist.Location = new System.Drawing.Point(6, 24);
            this.isPtExist.Name = "isPtExist";
            this.isPtExist.Size = new System.Drawing.Size(43, 19);
            this.isPtExist.TabIndex = 0;
            this.isPtExist.TabStop = true;
            this.isPtExist.Text = "有";
            this.isPtExist.UseVisualStyleBackColor = true;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(499, 90);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(410, 653);
            this.resultBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(28, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(870, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "請將Excel檔案按照Gamecode, cn, hk, en, th, vi, id, es, pt的順序排好，沒有的就放en";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 763);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.platformlabel);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.devicelabel);
            this.Controls.Add(this.device);
            this.Controls.Add(this.gamekindlabel);
            this.Controls.Add(this.gamekind);
            this.Controls.Add(this.gametypelabel);
            this.Controls.Add(this.gametype);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileSelectBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "t_game SQL Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileSelectBtn;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox gametype;
        private System.Windows.Forms.Label gametypelabel;
        private System.Windows.Forms.Label gamekindlabel;
        private System.Windows.Forms.TextBox gamekind;
        private System.Windows.Forms.Label devicelabel;
        private System.Windows.Forms.TextBox device;
        private System.Windows.Forms.Label platformlabel;
        private System.Windows.Forms.TextBox platform;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.RadioButton isThExist;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.RadioButton isViExist;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.RadioButton isIdExist;
        private System.Windows.Forms.GroupBox GroupBox4;
        private System.Windows.Forms.RadioButton isEsExist;
        private System.Windows.Forms.GroupBox GroupBox5;
        private System.Windows.Forms.RadioButton isPtExist;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label1;
    }
}

