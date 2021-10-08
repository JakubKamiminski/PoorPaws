
namespace assigmentlogginform
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.dtpVaccination = new System.Windows.Forms.DateTimePicker();
            this.dtpAvailable = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUploadPicture = new System.Windows.Forms.Button();
            this.picAnimal = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.picID = new System.Windows.Forms.PictureBox();
            this.picAnimalType = new System.Windows.Forms.PictureBox();
            this.picAnimalSubtype = new System.Windows.Forms.PictureBox();
            this.picAnimalMaxAge = new System.Windows.Forms.PictureBox();
            this.picCost = new System.Windows.Forms.PictureBox();
            this.picDOB = new System.Windows.Forms.PictureBox();
            this.picVaccination = new System.Windows.Forms.PictureBox();
            this.picAvailable = new System.Windows.Forms.PictureBox();
            this.picDescribtion = new System.Windows.Forms.PictureBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtSubtype = new System.Windows.Forms.TextBox();
            this.txtMaxAge = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.picPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimalSubtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimalMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDOB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVaccination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDescribtion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 63);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 122);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Silver;
            this.txtID.Location = new System.Drawing.Point(11, 210);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(92, 24);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "ID...";
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(189, 265);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(118, 20);
            this.dtpDOB.TabIndex = 7;
            // 
            // dtpVaccination
            // 
            this.dtpVaccination.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVaccination.Location = new System.Drawing.Point(189, 314);
            this.dtpVaccination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpVaccination.Name = "dtpVaccination";
            this.dtpVaccination.Size = new System.Drawing.Size(118, 20);
            this.dtpVaccination.TabIndex = 8;
            // 
            // dtpAvailable
            // 
            this.dtpAvailable.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAvailable.Location = new System.Drawing.Point(189, 370);
            this.dtpAvailable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpAvailable.Name = "dtpAvailable";
            this.dtpAvailable.Size = new System.Drawing.Size(118, 20);
            this.dtpAvailable.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(598, 416);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(124, 44);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(598, 356);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 44);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUploadPicture
            // 
            this.btnUploadPicture.Location = new System.Drawing.Point(598, 194);
            this.btnUploadPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUploadPicture.Name = "btnUploadPicture";
            this.btnUploadPicture.Size = new System.Drawing.Size(124, 44);
            this.btnUploadPicture.TabIndex = 12;
            this.btnUploadPicture.Text = "Upload the picture of the animal";
            this.btnUploadPicture.UseVisualStyleBackColor = true;
            this.btnUploadPicture.Click += new System.EventHandler(this.btnUploadPicture_Click);
            // 
            // picAnimal
            // 
            this.picAnimal.Location = new System.Drawing.Point(598, 249);
            this.picAnimal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAnimal.Name = "picAnimal";
            this.picAnimal.Size = new System.Drawing.Size(124, 91);
            this.picAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnimal.TabIndex = 13;
            this.picAnimal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Animal Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 299);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Animal Subtype";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 349);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Max age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 404);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Date of birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(188, 296);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Last Vaccination";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(188, 351);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Date available";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(360, 200);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Description";
            // 
            // txtLogo
            // 
            this.txtLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(64)))), ((int)(((byte)(83)))));
            this.txtLogo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogo.ForeColor = System.Drawing.Color.White;
            this.txtLogo.Location = new System.Drawing.Point(8, 11);
            this.txtLogo.Multiline = true;
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.ReadOnly = true;
            this.txtLogo.Size = new System.Drawing.Size(744, 35);
            this.txtLogo.TabIndex = 25;
            this.txtLogo.Text = "Poor Paws";
            this.txtLogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLogo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLogo_MouseClick);
            // 
            // picID
            // 
            this.picID.Location = new System.Drawing.Point(111, 211);
            this.picID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picID.Name = "picID";
            this.picID.Size = new System.Drawing.Size(34, 22);
            this.picID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picID.TabIndex = 26;
            this.picID.TabStop = false;
            // 
            // picAnimalType
            // 
            this.picAnimalType.Location = new System.Drawing.Point(140, 265);
            this.picAnimalType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAnimalType.Name = "picAnimalType";
            this.picAnimalType.Size = new System.Drawing.Size(34, 23);
            this.picAnimalType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnimalType.TabIndex = 27;
            this.picAnimalType.TabStop = false;
            // 
            // picAnimalSubtype
            // 
            this.picAnimalSubtype.Location = new System.Drawing.Point(140, 318);
            this.picAnimalSubtype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAnimalSubtype.Name = "picAnimalSubtype";
            this.picAnimalSubtype.Size = new System.Drawing.Size(34, 23);
            this.picAnimalSubtype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnimalSubtype.TabIndex = 28;
            this.picAnimalSubtype.TabStop = false;
            // 
            // picAnimalMaxAge
            // 
            this.picAnimalMaxAge.Location = new System.Drawing.Point(140, 367);
            this.picAnimalMaxAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAnimalMaxAge.Name = "picAnimalMaxAge";
            this.picAnimalMaxAge.Size = new System.Drawing.Size(34, 23);
            this.picAnimalMaxAge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnimalMaxAge.TabIndex = 29;
            this.picAnimalMaxAge.TabStop = false;
            // 
            // picCost
            // 
            this.picCost.Location = new System.Drawing.Point(140, 422);
            this.picCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCost.Name = "picCost";
            this.picCost.Size = new System.Drawing.Size(34, 23);
            this.picCost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCost.TabIndex = 30;
            this.picCost.TabStop = false;
            // 
            // picDOB
            // 
            this.picDOB.Location = new System.Drawing.Point(320, 260);
            this.picDOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picDOB.Name = "picDOB";
            this.picDOB.Size = new System.Drawing.Size(34, 23);
            this.picDOB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDOB.TabIndex = 32;
            this.picDOB.TabStop = false;
            // 
            // picVaccination
            // 
            this.picVaccination.Location = new System.Drawing.Point(320, 314);
            this.picVaccination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picVaccination.Name = "picVaccination";
            this.picVaccination.Size = new System.Drawing.Size(34, 23);
            this.picVaccination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVaccination.TabIndex = 33;
            this.picVaccination.TabStop = false;
            // 
            // picAvailable
            // 
            this.picAvailable.Location = new System.Drawing.Point(320, 370);
            this.picAvailable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAvailable.Name = "picAvailable";
            this.picAvailable.Size = new System.Drawing.Size(34, 23);
            this.picAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvailable.TabIndex = 34;
            this.picAvailable.TabStop = false;
            // 
            // picDescribtion
            // 
            this.picDescribtion.Location = new System.Drawing.Point(462, 197);
            this.picDescribtion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picDescribtion.Name = "picDescribtion";
            this.picDescribtion.Size = new System.Drawing.Size(34, 23);
            this.picDescribtion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDescribtion.TabIndex = 35;
            this.picDescribtion.TabStop = false;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.Color.Silver;
            this.txtType.Location = new System.Drawing.Point(11, 265);
            this.txtType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(117, 24);
            this.txtType.TabIndex = 36;
            this.txtType.Text = "animal type...";
            this.txtType.Enter += new System.EventHandler(this.txtType_Enter);
            this.txtType.Leave += new System.EventHandler(this.txtType_Leave);
            // 
            // txtSubtype
            // 
            this.txtSubtype.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtype.ForeColor = System.Drawing.Color.Silver;
            this.txtSubtype.Location = new System.Drawing.Point(12, 318);
            this.txtSubtype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubtype.Name = "txtSubtype";
            this.txtSubtype.Size = new System.Drawing.Size(116, 24);
            this.txtSubtype.TabIndex = 37;
            this.txtSubtype.Text = "animal subtype...";
            this.txtSubtype.Enter += new System.EventHandler(this.txtSubtype_Enter);
            this.txtSubtype.Leave += new System.EventHandler(this.txtSubtype_Leave);
            // 
            // txtMaxAge
            // 
            this.txtMaxAge.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxAge.ForeColor = System.Drawing.Color.Silver;
            this.txtMaxAge.Location = new System.Drawing.Point(11, 367);
            this.txtMaxAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaxAge.Name = "txtMaxAge";
            this.txtMaxAge.Size = new System.Drawing.Size(117, 24);
            this.txtMaxAge.TabIndex = 38;
            this.txtMaxAge.Text = "max age...";
            this.txtMaxAge.Enter += new System.EventHandler(this.txtMaxAge_Enter);
            this.txtMaxAge.Leave += new System.EventHandler(this.txtMaxAge_Leave);
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.ForeColor = System.Drawing.Color.Silver;
            this.txtCost.Location = new System.Drawing.Point(11, 422);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(117, 24);
            this.txtCost.TabIndex = 39;
            this.txtCost.Text = "£££cost...";
            this.txtCost.Enter += new System.EventHandler(this.txtCost_Enter);
            this.txtCost.Leave += new System.EventHandler(this.txtCost_Leave);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Silver;
            this.txtDescription.Location = new System.Drawing.Point(363, 225);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(218, 236);
            this.txtDescription.TabIndex = 40;
            this.txtDescription.Text = "animal\'s needs description...";
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // picPicture
            // 
            this.picPicture.Location = new System.Drawing.Point(726, 279);
            this.picPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(29, 33);
            this.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPicture.TabIndex = 41;
            this.picPicture.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(758, 480);
            this.Controls.Add(this.picPicture);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtMaxAge);
            this.Controls.Add(this.txtSubtype);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.picDescribtion);
            this.Controls.Add(this.picAvailable);
            this.Controls.Add(this.picVaccination);
            this.Controls.Add(this.picDOB);
            this.Controls.Add(this.picCost);
            this.Controls.Add(this.picAnimalMaxAge);
            this.Controls.Add(this.picAnimalSubtype);
            this.Controls.Add(this.picAnimalType);
            this.Controls.Add(this.picID);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAnimal);
            this.Controls.Add(this.btnUploadPicture);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpAvailable);
            this.Controls.Add(this.dtpVaccination);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimalSubtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimalMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDOB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVaccination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDescribtion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.DateTimePicker dtpVaccination;
        private System.Windows.Forms.DateTimePicker dtpAvailable;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUploadPicture;
        private System.Windows.Forms.PictureBox picAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.PictureBox picID;
        private System.Windows.Forms.PictureBox picAnimalType;
        private System.Windows.Forms.PictureBox picAnimalSubtype;
        private System.Windows.Forms.PictureBox picAnimalMaxAge;
        private System.Windows.Forms.PictureBox picCost;
        private System.Windows.Forms.PictureBox picDOB;
        private System.Windows.Forms.PictureBox picVaccination;
        private System.Windows.Forms.PictureBox picAvailable;
        private System.Windows.Forms.PictureBox picDescribtion;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtSubtype;
        private System.Windows.Forms.TextBox txtMaxAge;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox picPicture;
    }
}