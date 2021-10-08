namespace assigmentlogginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picturebox2 = new System.Windows.Forms.PictureBox();
            this.poorPawsLogo = new System.Windows.Forms.TextBox();
            this.dogpicture = new System.Windows.Forms.PictureBox();
            this.msgToTheUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(185)))), ((int)(((byte)(218)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmit.Location = new System.Drawing.Point(111, 234);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(152, 52);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(74, 134);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 30);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "username...";
            this.txtUsername.Enter += new System.EventHandler(this.TxtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.TxtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(74, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(232, 30);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "password...";
            this.txtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log in";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(319, 134);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // picturebox2
            // 
            this.picturebox2.Location = new System.Drawing.Point(319, 179);
            this.picturebox2.Margin = new System.Windows.Forms.Padding(2);
            this.picturebox2.Name = "picturebox2";
            this.picturebox2.Size = new System.Drawing.Size(45, 26);
            this.picturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox2.TabIndex = 4;
            this.picturebox2.TabStop = false;
            // 
            // poorPawsLogo
            // 
            this.poorPawsLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.poorPawsLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poorPawsLogo.ForeColor = System.Drawing.SystemColors.Window;
            this.poorPawsLogo.Location = new System.Drawing.Point(453, 54);
            this.poorPawsLogo.Name = "poorPawsLogo";
            this.poorPawsLogo.Size = new System.Drawing.Size(263, 38);
            this.poorPawsLogo.TabIndex = 6;
            this.poorPawsLogo.Text = "Poor Paws";
            this.poorPawsLogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dogpicture
            // 
            this.dogpicture.Image = ((System.Drawing.Image)(resources.GetObject("dogpicture.Image")));
            this.dogpicture.Location = new System.Drawing.Point(436, 116);
            this.dogpicture.Name = "dogpicture";
            this.dogpicture.Size = new System.Drawing.Size(298, 189);
            this.dogpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dogpicture.TabIndex = 8;
            this.dogpicture.TabStop = false;
            // 
            // msgToTheUser
            // 
            this.msgToTheUser.AutoSize = true;
            this.msgToTheUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgToTheUser.Location = new System.Drawing.Point(397, 320);
            this.msgToTheUser.Name = "msgToTheUser";
            this.msgToTheUser.Size = new System.Drawing.Size(391, 20);
            this.msgToTheUser.TabIndex = 9;
            this.msgToTheUser.Text = "\"Help these resuced animals find  a new home \"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msgToTheUser);
            this.Controls.Add(this.dogpicture);
            this.Controls.Add(this.poorPawsLogo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picturebox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picturebox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox poorPawsLogo;
        private System.Windows.Forms.PictureBox dogpicture;
        private System.Windows.Forms.Label msgToTheUser;
    }
}

