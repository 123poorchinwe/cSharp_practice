namespace output
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_comfirm1 = new System.Windows.Forms.Button();
            this.button1_cansel = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_secret = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_secret = new System.Windows.Forms.TextBox();
            this.label_forget = new System.Windows.Forms.Label();
            this.label_register = new System.Windows.Forms.Label();
            this.label_title1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_comfirm1
            // 
            this.button_comfirm1.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_comfirm1.Location = new System.Drawing.Point(74, 270);
            this.button_comfirm1.Name = "button_comfirm1";
            this.button_comfirm1.Size = new System.Drawing.Size(117, 51);
            this.button_comfirm1.TabIndex = 0;
            this.button_comfirm1.Text = "确定";
            this.button_comfirm1.UseVisualStyleBackColor = true;
            this.button_comfirm1.Click += new System.EventHandler(this.button_comfirm1_Click);
            // 
            // button1_cansel
            // 
            this.button1_cansel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1_cansel.Location = new System.Drawing.Point(256, 270);
            this.button1_cansel.Name = "button1_cansel";
            this.button1_cansel.Size = new System.Drawing.Size(117, 51);
            this.button1_cansel.TabIndex = 1;
            this.button1_cansel.Text = "取消";
            this.button1_cansel.UseVisualStyleBackColor = true;
            this.button1_cansel.Click += new System.EventHandler(this.button1__Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_name.Location = new System.Drawing.Point(51, 142);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(93, 20);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "用户名：";
            // 
            // label_secret
            // 
            this.label_secret.AutoSize = true;
            this.label_secret.BackColor = System.Drawing.Color.Transparent;
            this.label_secret.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_secret.ForeColor = System.Drawing.Color.Black;
            this.label_secret.Location = new System.Drawing.Point(51, 187);
            this.label_secret.Name = "label_secret";
            this.label_secret.Size = new System.Drawing.Size(94, 20);
            this.label_secret.TabIndex = 3;
            this.label_secret.Text = "密  码：";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(159, 142);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(174, 25);
            this.textBox_name.TabIndex = 4;
            // 
            // textBox_secret
            // 
            this.textBox_secret.Location = new System.Drawing.Point(159, 182);
            this.textBox_secret.Name = "textBox_secret";
            this.textBox_secret.Size = new System.Drawing.Size(174, 25);
            this.textBox_secret.TabIndex = 5;
            // 
            // label_forget
            // 
            this.label_forget.AutoSize = true;
            this.label_forget.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_forget.Location = new System.Drawing.Point(89, 227);
            this.label_forget.Name = "label_forget";
            this.label_forget.Size = new System.Drawing.Size(82, 15);
            this.label_forget.TabIndex = 6;
            this.label_forget.Text = "忘记密码？";
            // 
            // label_register
            // 
            this.label_register.AutoSize = true;
            this.label_register.BackColor = System.Drawing.Color.Transparent;
            this.label_register.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_register.Location = new System.Drawing.Point(271, 227);
            this.label_register.Name = "label_register";
            this.label_register.Size = new System.Drawing.Size(67, 15);
            this.label_register.TabIndex = 7;
            this.label_register.Text = "注册账号";
            this.label_register.Click += new System.EventHandler(this.label_register_Click);
            // 
            // label_title1
            // 
            this.label_title1.AutoSize = true;
            this.label_title1.BackColor = System.Drawing.Color.Transparent;
            this.label_title1.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_title1.Location = new System.Drawing.Point(151, 44);
            this.label_title1.Name = "label_title1";
            this.label_title1.Size = new System.Drawing.Size(118, 44);
            this.label_title1.TabIndex = 8;
            this.label_title1.Text = "EyGIS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-108, -86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(656, 634);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.label_title1);
            this.Controls.Add(this.label_register);
            this.Controls.Add(this.label_forget);
            this.Controls.Add(this.textBox_secret);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_secret);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button1_cansel);
            this.Controls.Add(this.button_comfirm1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "用户登录界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_comfirm1;
        private System.Windows.Forms.Button button1_cansel;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_secret;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_secret;
        private System.Windows.Forms.Label label_forget;
        private System.Windows.Forms.Label label_register;
        private System.Windows.Forms.Label label_title1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

