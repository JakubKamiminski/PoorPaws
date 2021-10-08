using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace assigmentlogginform
{
    public partial class Form4 : Form
    {
        // creating connections to other classes and declering vriables that will be used later on
        private static readonly Database databaseObject = new Database();

        private static readonly MyUtilities mu = new MyUtilities();

        private DataSet DS = new DataSet();

        private SQLiteDataAdapter DB;

        private DataTable DT = new DataTable();

        SQLiteCommand myCommand;

        int ID;

        string base64String = null;
        string picturePath = "";
        public Form4()
        {
            InitializeComponent();


            LoadData();



        }

        // loads in the data from the databse
        private void LoadData()
        {
            databaseObject.OpenConnection();
            string query = ("SELECT * from list_of_animals");
            DB = new SQLiteDataAdapter(query, databaseObject.myConnection);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            databaseObject.CloseConnection();
        }




        private void txtID_Enter(object sender, EventArgs e)
        {
            mu.Placeholder_enter(txtID, "ID");
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            mu.Placeholder_leave(txtID, "ID");
        }

        private void txtType_Enter(object sender, EventArgs e)
        {
            mu.Placeholder_enter(txtType, "animal type");
        }

        private void txtType_Leave(object sender, EventArgs e)
        {
            mu.Placeholder_leave(txtType, "animal type");
        }

        private void txtSubtype_Enter(object sender, EventArgs e)
        {
            mu.Placeholder_enter(txtSubtype, "animal subtype");
        }

        private void txtSubtype_Leave(object sender, EventArgs e)
        {
            mu.Placeholder_leave(txtSubtype, "animal subtype");
        }

        private void txtMaxAge_Enter(object sender, EventArgs e)
        {
            mu.Placeholder_enter(txtMaxAge, "max age");
        }

        private void txtMaxAge_Leave(object sender, EventArgs e)
        {
            mu.Placeholder_leave(txtMaxAge, "max age");
        }

        private void txtCost_Enter(object sender, EventArgs e)
        {
            mu.Placeholder_enter(txtCost, "£££cost");
        }

        private void txtCost_Leave(object sender, EventArgs e)
        {
            mu.Placeholder_leave(txtCost, "£££cost");
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            mu.Placeholder_enter(txtDescription, "animal's needs description");
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            mu.Placeholder_leave(txtDescription, "animal's needs description");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //assignign the data from the textboxes and datetimepickers to variables
            PictureBox[] pictureBoxes = { picID, picAnimalType, picAnimalSubtype, picAnimalMaxAge, picCost, picDescribtion, picDOB, picVaccination, picAvailable, picPicture };
            string animalType, animalSubtype, stranimalMaxAge, stranimalCost, animalDescription, errorMessage = "", strDOB, strAvailable, strVaccination;
            DateTime animalLastVaccination, animalDOB, dateavailable;
            int validationPoints = 0, animalCost, animalMaxAge;
            animalType = txtType.Text;
            animalSubtype = txtSubtype.Text;
            stranimalMaxAge = txtMaxAge.Text;
            stranimalCost = txtCost.Text;
            animalDescription = txtDescription.Text;
            animalLastVaccination = dtpVaccination.Value;
            animalDOB = dtpDOB.Value;
            dateavailable = dtpAvailable.Value;
            strDOB = dtpDOB.Value.ToString("MM/dd/yyyy");
            strAvailable = dtpAvailable.Value.ToString("MM/dd/yyyy");
            strVaccination = dtpVaccination.Value.ToString("MM/dd/yyyy");
            mu.LenghtAndDigitCheck(txtType, "animal type", picAnimalType);
            if (picAnimalType.Image == Global.redcross)
            {
                // if a validation test is negative an error massesge is attached to a varaible that will display the user all the failed validation tests and how to fix them
                errorMessage = errorMessage + "Animal tpye field eihter is empty or stores incorrect data type \n";
            }
            mu.LenghtAndDigitCheck(txtSubtype, "animal subtype", picAnimalSubtype);
            if (picAnimalSubtype.Image == Global.redcross)
            {
                errorMessage = errorMessage + "Animal subtype field eihter is empty or stores incorrect data type \n";
            }
            mu.LengthAndLetterCheck(txtMaxAge, "expected maximum age", picAnimalMaxAge);
            if (picAnimalMaxAge.Image == Global.redcross)
            {
                errorMessage = errorMessage + "Animal max age field eihter is empty or stores incorrect data type \n";
            }
            mu.LengthAndLetterCheck(txtID, "ID", picID);
            if (picID.Image == Global.redcross)
            {
                errorMessage = errorMessage + "Animal ID field eihter is empty or stores incorrect data type \n";
            }
            mu.LengthAndLetterCheck(txtCost, "cost £££", picCost);
            if (picCost.Image == Global.redcross)
            {
                errorMessage = errorMessage + "Animal cost field eihter is empty or stores incorrect data type \n";
            }
            if (txtDescription.Text == "" || txtDescription.Text == "animal's needs description" + "...")
            {
                mu.InCorrectValue(txtDescription, picDescribtion);
            }
            else
            {
                mu.CorrectValue(txtDescription, picDescribtion);
            }
            if (picDescribtion.Image == Global.redcross)
            {
                errorMessage = errorMessage + "Animal description field eihter is empty or stores incorrect data type \n";
            }
            mu.Datecheck(animalLastVaccination, picVaccination);
            if (picVaccination.Image == Global.redcross)
            {
                errorMessage = errorMessage + "Animal's last vaccination date field eihter is empty or stores incorrect data type \n";
            }
            mu.Datecheck(animalDOB, picDOB);
            if (picDOB.Image == Global.redcross)
            {
                errorMessage = errorMessage + "Animal's date of birth field eihter is empty or stores incorrect data type \n";
            }
            if(dateavailable != null)
            {
                picAvailable.Image = Global.greentick;
            }
            else
            {
                picAvailable.Image = Global.redcross;
            }

            if (picAnimal.Image != null)
            {
                picPicture.Image = Global.greentick;
            }
            else
            {
                picPicture.Image = Global.redcross;
                errorMessage = errorMessage + "The picture for the described animal is empty, please insert one in  \n";
            }
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                if (pictureBoxes[i].Image == Global.greentick)
                {
                    validationPoints = validationPoints + 1;
                }
                else
                {
                    MessageBox.Show(errorMessage);
                    break;
                }
            }

            if (validationPoints == pictureBoxes.Length)
            {
                // updates the field chose by the user when their input passed all the validation rules
                animalCost = Int32.Parse(stranimalCost);
                animalMaxAge = Int32.Parse(stranimalMaxAge);
                ID = Int32.Parse(txtID.Text);
                MessageBox.Show("True");
                string query = "UPDATE list_of_animals SET animal_type = @animalType,animal_subtype = @animalSubtype,animal_max_age = @animalMaxAge,date_of_birth = @DOB,date_of_last_vaccination = @LastVaccination,cost = @cost,description = @description,picture = @picture WHERE animal_ID = @id";
                myCommand = new SQLiteCommand(query, databaseObject.myConnection);
                myCommand.Parameters.AddWithValue("@animalType", animalType);
                myCommand.Parameters.AddWithValue("@animalSubtype", animalSubtype);
                myCommand.Parameters.AddWithValue("@animalMaxAge", animalMaxAge);
                myCommand.Parameters.AddWithValue("@DOB", strDOB);
                myCommand.Parameters.AddWithValue("@LastVaccination", strVaccination);
                myCommand.Parameters.AddWithValue("@cost", animalCost);
                myCommand.Parameters.AddWithValue("@description", animalDescription);
                myCommand.Parameters.AddWithValue("@picture", base64String);
                myCommand.Parameters.AddWithValue("@available", strAvailable);
                myCommand.Parameters.AddWithValue("@id", ID);            
                databaseObject.OpenConnection();
                var result = myCommand.ExecuteNonQuery();
                databaseObject.CloseConnection();
                LoadData();
            }
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmaps|*.bmp|jpeps|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picAnimal.ImageLocation = openFileDialog.FileName;
            }

            picturePath = picAnimal.ImageLocation;

            using (Image image = Image.FromFile(picturePath))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();


                    base64String = Convert.ToBase64String(imageBytes);
                }
            }
        }



        private void txtLogo_MouseClick(object sender, MouseEventArgs e)
        {
            // lets the user to come back to the previous form
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   
            // delets a record based on which ID user chose
            if(txtID.Text != "ID...")
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                string title = "Confirmation Window";
                string message = "Are you sure you want to deleted this field from the database?";
                DialogResult msgResult = MessageBox.Show(message,title,buttons);
                if (msgResult == DialogResult.Yes)
                {
                    ID = Int32.Parse(txtID.Text);
                    string query = "DELETE from list_of_animals WHERE animal_ID = '" + ID + "'";
                    myCommand = new SQLiteCommand(query, databaseObject.myConnection);
                    databaseObject.OpenConnection();
                    var result = myCommand.ExecuteNonQuery();
                    databaseObject.CloseConnection();
                    LoadData();
                }
            }
            else
            {
                //if user clicked  delete but haven't picked ID of the field they get this message
                MessageBox.Show("You haven't selected the ID of the animal to be deleted from the database");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
