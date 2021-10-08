namespace assigmentlogginform
{
    partial class Form3
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
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnimalType = new System.Windows.Forms.TextBox();
            this.txtAnimalSubtype = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPictureSelect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxAge = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDescribtion = new System.Windows.Forms.TextBox();
            this.btnSubmitDetails = new System.Windows.Forms.Button();
            this.picAnimal = new System.Windows.Forms.PictureBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.picAnimalType = new System.Windows.Forms.PictureBox();
            this.picAnimalSubtype = new System.Windows.Forms.PictureBox();
            this.picDOB = new System.Windows.Forms.PictureBox();
            this.picMaxAge = new System.Windows.Forms.PictureBox();
            this.picLastVaccination = new System.Windows.Forms.PictureBox();
            this.picAvailable = new System.Windows.Forms.PictureBox();
            this.picCost = new System.Windows.Forms.PictureBox();
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.picDescription = new System.Windows.Forms.PictureBox();
            this.dtmDOB = new System.Windows.Forms.DateTimePicker();
            this.dtpLastVaccination = new System.Windows.Forms.DateTimePicker();
            this.dtpAvailable = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimalSubtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLastVaccination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogo
            // 
            this.txtLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.txtLogo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogo.ForeColor = System.Drawing.Color.White;
            this.txtLogo.Location = new System.Drawing.Point(12, 10);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.ReadOnly = true;
            this.txtLogo.Size = new System.Drawing.Size(803, 27);
            this.txtLogo.TabIndex = 0;
            this.txtLogo.Text = "Poor Paws";
            this.txtLogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLogo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLogo_MouseClick);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Animal type information";
            // 
            // txtAnimalType
            // 
            this.txtAnimalType.BackColor = System.Drawing.Color.White;
            this.txtAnimalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalType.ForeColor = System.Drawing.Color.Silver;
            this.txtAnimalType.Location = new System.Drawing.Point(15, 77);
            this.txtAnimalType.Name = "txtAnimalType";
            this.txtAnimalType.Size = new System.Drawing.Size(162, 22);
            this.txtAnimalType.TabIndex = 2;
            this.txtAnimalType.Text = "animal type...";
            this.txtAnimalType.Enter += new System.EventHandler(this.TxtAnimalType_Enter);
            this.txtAnimalType.Leave += new System.EventHandler(this.TxtAnimalType_Leave);
            // 
            // txtAnimalSubtype
            // 
            this.txtAnimalSubtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalSubtype.ForeColor = System.Drawing.Color.Silver;
            this.txtAnimalSubtype.Location = new System.Drawing.Point(15, 103);
            this.txtAnimalSubtype.Name = "txtAnimalSubtype";
            this.txtAnimalSubtype.Size = new System.Drawing.Size(162, 22);
            this.txtAnimalSubtype.TabIndex = 3;
            this.txtAnimalSubtype.Text = "animal subtype(breed)...";
            this.txtAnimalSubtype.Enter += new System.EventHandler(this.TxtAnimalSubtype_Enter);
            this.txtAnimalSubtype.Leave += new System.EventHandler(this.TxtAnimalSubtype_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cost/Picture";
            // 
            // btnPictureSelect
            // 
            this.btnPictureSelect.Location = new System.Drawing.Point(252, 103);
            this.btnPictureSelect.Name = "btnPictureSelect";
            this.btnPictureSelect.Size = new System.Drawing.Size(162, 46);
            this.btnPictureSelect.TabIndex = 11;
            this.btnPictureSelect.Text = "Upload the picture of the animal";
            this.btnPictureSelect.UseVisualStyleBackColor = true;
            this.btnPictureSelect.Click += new System.EventHandler(this.BtnPictureSelect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Animal\'s needs description";

            // 
            // txtMaxAge
            // 
            this.txtMaxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxAge.ForeColor = System.Drawing.Color.Silver;
            this.txtMaxAge.Location = new System.Drawing.Point(12, 210);
            this.txtMaxAge.Name = "txtMaxAge";
            this.txtMaxAge.Size = new System.Drawing.Size(178, 22);
            this.txtMaxAge.TabIndex = 16;
            this.txtMaxAge.Text = "expected maximum age...";
            this.txtMaxAge.Enter += new System.EventHandler(this.TxtMaxAge_Enter);
            this.txtMaxAge.Leave += new System.EventHandler(this.TxtMaxAge_Leave);
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.ForeColor = System.Drawing.Color.Silver;
            this.txtCost.Location = new System.Drawing.Point(252, 75);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(162, 22);
            this.txtCost.TabIndex = 19;
            this.txtCost.Text = "cost £££...";
            this.txtCost.Enter += new System.EventHandler(this.TxtCost_Enter);
            this.txtCost.Leave += new System.EventHandler(this.TxtCost_Leave);
            // 
            // txtDescribtion
            // 
            this.txtDescribtion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescribtion.ForeColor = System.Drawing.Color.Silver;
            this.txtDescribtion.Location = new System.Drawing.Point(488, 77);
            this.txtDescribtion.Multiline = true;
            this.txtDescribtion.Name = "txtDescribtion";
            this.txtDescribtion.Size = new System.Drawing.Size(237, 276);
            this.txtDescribtion.TabIndex = 21;
            this.txtDescribtion.Text = "animal\'s needs description...";
            this.txtDescribtion.Enter += new System.EventHandler(this.TxtDescribtion_Enter);
            this.txtDescribtion.Leave += new System.EventHandler(this.TxtDescribtion_Leave);
            // 
            // btnSubmitDetails
            // 
            this.btnSubmitDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.btnSubmitDetails.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitDetails.ForeColor = System.Drawing.Color.White;
            this.btnSubmitDetails.Location = new System.Drawing.Point(611, 370);
            this.btnSubmitDetails.Name = "btnSubmitDetails";
            this.btnSubmitDetails.Size = new System.Drawing.Size(114, 42);
            this.btnSubmitDetails.TabIndex = 22;
            this.btnSubmitDetails.Text = "Submit";
            this.btnSubmitDetails.UseVisualStyleBackColor = false;
            this.btnSubmitDetails.Click += new System.EventHandler(this.btnSubmitDetails_click);
            // 
            // picAnimal
            // 
            this.picAnimal.Location = new System.Drawing.Point(254, 182);
            this.picAnimal.Name = "picAnimal";
            this.picAnimal.Size = new System.Drawing.Size(162, 127);
            this.picAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnimal.TabIndex = 23;
            this.picAnimal.TabStop = false;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(251, 166);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(110, 13);
            this.lblPreview.TabIndex = 24;
            this.lblPreview.Text = "Preview of the picture";
            // 
            // picAnimalType
            // 
            this.picAnimalType.Location = new System.Drawing.Point(199, 77);
            this.picAnimalType.Name = "picAnimalType";
            this.picAnimalType.Size = new System.Drawing.Size(46, 22);
            this.picAnimalType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnimalType.TabIndex = 25;
            this.picAnimalType.TabStop = false;

            // 
            // picAnimalSubtype
            // 
            this.picAnimalSubtype.Location = new System.Drawing.Point(199, 103);
            this.picAnimalSubtype.Name = "picAnimalSubtype";
            this.picAnimalSubtype.Size = new System.Drawing.Size(46, 22);
            this.picAnimalSubtype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnimalSubtype.TabIndex = 26;
            this.picAnimalSubtype.TabStop = false;
            // 
            // picDOB
            // 
            this.picDOB.Location = new System.Drawing.Point(199, 182);
            this.picDOB.Name = "picDOB";
            this.picDOB.Size = new System.Drawing.Size(46, 20);
            this.picDOB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDOB.TabIndex = 27;
            this.picDOB.TabStop = false;
            // 
            // picMaxAge
            // 
            this.picMaxAge.Location = new System.Drawing.Point(199, 210);
            this.picMaxAge.Name = "picMaxAge";
            this.picMaxAge.Size = new System.Drawing.Size(46, 22);
            this.picMaxAge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMaxAge.TabIndex = 28;
            this.picMaxAge.TabStop = false;
            // 
            // picLastVaccination
            // 
            this.picLastVaccination.Location = new System.Drawing.Point(199, 263);
            this.picLastVaccination.Name = "picLastVaccination";
            this.picLastVaccination.Size = new System.Drawing.Size(46, 20);
            this.picLastVaccination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLastVaccination.TabIndex = 29;
            this.picLastVaccination.TabStop = false;
            // 
            // picAvailable
            // 
            this.picAvailable.Location = new System.Drawing.Point(199, 314);
            this.picAvailable.Name = "picAvailable";
            this.picAvailable.Size = new System.Drawing.Size(46, 20);
            this.picAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvailable.TabIndex = 30;
            this.picAvailable.TabStop = false;

            // 
            // picCost
            // 
            this.picCost.Location = new System.Drawing.Point(420, 75);
            this.picCost.Name = "picCost";
            this.picCost.Size = new System.Drawing.Size(41, 22);
            this.picCost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCost.TabIndex = 31;
            this.picCost.TabStop = false;
            // 
            // picPicture
            // 
            this.picPicture.Location = new System.Drawing.Point(420, 182);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(41, 22);
            this.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPicture.TabIndex = 32;
            this.picPicture.TabStop = false;
            // 
            // picDescription
            // 
            this.picDescription.Location = new System.Drawing.Point(740, 75);
            this.picDescription.Name = "picDescription";
            this.picDescription.Size = new System.Drawing.Size(41, 22);
            this.picDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDescription.TabIndex = 33;
            this.picDescription.TabStop = false;
            // 
            // dtmDOB
            // 
            this.dtmDOB.CustomFormat = "dd-MM-yyyy";
            this.dtmDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDOB.Location = new System.Drawing.Point(12, 182);
            this.dtmDOB.Name = "dtmDOB";
            this.dtmDOB.Size = new System.Drawing.Size(178, 20);
            this.dtmDOB.TabIndex = 34;
            // 
            // dtpLastVaccination
            // 
            this.dtpLastVaccination.CustomFormat = "dd-MM-yyyy";
            this.dtpLastVaccination.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLastVaccination.Location = new System.Drawing.Point(12, 263);
            this.dtpLastVaccination.Name = "dtpLastVaccination";
            this.dtpLastVaccination.Size = new System.Drawing.Size(178, 20);
            this.dtpLastVaccination.TabIndex = 35;
            // 
            // dtpAvailable
            // 
            this.dtpAvailable.CustomFormat = "dd-MM-yyyy";
            this.dtpAvailable.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAvailable.Location = new System.Drawing.Point(12, 314);
            this.dtpAvailable.Name = "dtpAvailable";
            this.dtpAvailable.Size = new System.Drawing.Size(178, 20);
            this.dtpAvailable.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "D.O.B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Date of last vaccination";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Date available for rehoming";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(827, 459);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpAvailable);
            this.Controls.Add(this.dtpLastVaccination);
            this.Controls.Add(this.dtmDOB);
            this.Controls.Add(this.picDescription);
            this.Controls.Add(this.picPicture);
            this.Controls.Add(this.picCost);
            this.Controls.Add(this.picAvailable);
            this.Controls.Add(this.picLastVaccination);
            this.Controls.Add(this.picMaxAge);
            this.Controls.Add(this.picDOB);
            this.Controls.Add(this.picAnimalSubtype);
            this.Controls.Add(this.picAnimalType);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.picAnimal);
            this.Controls.Add(this.btnSubmitDetails);
            this.Controls.Add(this.txtDescribtion);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtMaxAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPictureSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnimalSubtype);
            this.Controls.Add(this.txtAnimalType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLogo);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimalSubtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLastVaccination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnimalType;
        private System.Windows.Forms.TextBox txtAnimalSubtype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPictureSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxAge;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDescribtion;
        private System.Windows.Forms.Button btnSubmitDetails;
        private System.Windows.Forms.PictureBox picAnimal;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.PictureBox picAnimalType;
        private System.Windows.Forms.PictureBox picAnimalSubtype;
        private System.Windows.Forms.PictureBox picDOB;
        private System.Windows.Forms.PictureBox picMaxAge;
        private System.Windows.Forms.PictureBox picLastVaccination;
        private System.Windows.Forms.PictureBox picAvailable;
        private System.Windows.Forms.PictureBox picCost;
        private System.Windows.Forms.PictureBox picPicture;
        private System.Windows.Forms.PictureBox picDescription;
        private System.Windows.Forms.DateTimePicker dtmDOB;
        private System.Windows.Forms.DateTimePicker dtpLastVaccination;
        private System.Windows.Forms.DateTimePicker dtpAvailable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}