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

    public partial class Form3 : Form
    {
        // creates connection to other files that this program is using functions from
        Database databaseObject = new Database();

        MyUtilities mu = new MyUtilities();
        string base64String = null;

        //creating varaiables that i'll be able to use throughout entire program
        string picturePath = "";
        SQLiteCommand myCommand;



        public Form3()
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitDetails_click(object sender, EventArgs e)
        {
            // variables are assigned with the data stored in textboxes and datetimepickers
            string animalType, animalSubtype, stranimalMaxAge, stranimalCost, animalDescription, errorMessage = "",strDOB,strAvailable,strVaccination;
            DateTime animalLastVaccination, animalDOB, dateavailable;
            // array that stores pictureboxes that represent if the data entered by the user is correct
            PictureBox[] pictureBoxes = { picAnimalType, picAnimalSubtype,picPicture, picMaxAge, picCost, picDescription, picDOB,picLastVaccination,picAvailable };
            int validationPoints = 0,animalCost,animalMaxAge;
            animalType = txtAnimalType.Text;
            animalSubtype = txtAnimalSubtype.Text;
            stranimalMaxAge = txtMaxAge.Text;
            stranimalCost = txtCost.Text;
            animalDescription = txtDescribtion.Text;
            animalLastVaccination = dtpLastVaccination.Value;
            animalDOB = dtmDOB.Value;
            dateavailable = dtpAvailable.Value;
            // dates are converted into the rigth format
            strDOB = dtmDOB.Value.ToString("MM/dd/yyyy");
            strAvailable = dtpAvailable.Value.ToString("MM/dd/yyyy");
            strVaccination = dtpLastVaccination.Value.ToString("MM/dd/yyyy");

            // validation checks
            // mu.lengthandDigitchecks checks if the user input is in correct format,in this case check if the input has only numbers, it  also checks if the field user was meant to fill in isn't empty

            mu.LenghtAndDigitCheck(txtAnimalType, "animal type", picAnimalType);

            // the function used above that checks the userinput will make the picturebox next to the textbox where data was input turn into a redcorss if the data doesn't pass the check,
            //and it will turn it into a green tick if passess the check

            if(picAnimalType.Image == Global.redcross)
            {
                //this code will only happen if the user input doesn't pass the validation check

                errorMessage = errorMessage + "Animal tpye field eihter is empty or stores incorrect data type \n";

                //the line above will add a message to the error message that always appears if atleast one of the user input is incorrect,it's here so the user knows what to fix, so they don't get more errors
            }
            mu.LenghtAndDigitCheck(txtAnimalSubtype, "animal subtype(breed)", picAnimalSubtype);
            if (picAnimalSubtype.Image == Global.redcross)
            {
                errorMessage = errorMessage + "Animal subtype field eihter is empty or stores incorrect data type \n";
            }

            //mu.lengthandDigitcheck checks if the user input is in correct format,in this case check if the input has only letters, it  also checks if the field user was meant to fill in isn't empty

            mu.LengthAndLetterCheck(txtMaxAge, "expected maximum age", picMaxAge);

            if (picMaxAge.Image == Global.redcross)
            {
                errorMessage = errorMessage + "Animal max age field eihter is empty or stores incorrect data type \n";
            }
            mu.LengthAndLetterCheck(txtCost, "cost £££", picCost);
            if (picCost.Image == Global.redcross)
            {
                errorMessage = errorMessage + "Animal cost field eihter is empty or stores incorrect data type \n";
            }
            if (txtDescribtion.Text == "" || txtDescribtion.Text == "animal's needs description" + "...")
            {
                mu.InCorrectValue(txtDescribtion, picDescription);
            }
            else
            {
                mu.CorrectValue(txtDescribtion, picDescription);
            }
            if (picDescription.Image == Global.redcross)
            {
                errorMessage = errorMessage + "Animal description field eihter is empty or stores incorrect data type \n";
            }
            //mu.datecheck checks if the data thtat user input already happened 
            mu.Datecheck(animalLastVaccination, picLastVaccination);
            if (picLastVaccination.Image == Global.redcross)
            {
                errorMessage = errorMessage + "Animal's last vaccination date field eihter is empty or stores incorrect data type \n";
            }
            mu.Datecheck(animalDOB, picDOB);
            if (picDOB.Image == Global.redcross)
            {
                errorMessage = errorMessage + "Animal's date of birth field eihter is empty or stores incorrect data type \n";
            }
            if (dateavailable != null)
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

            //this for loop goes though all of the pixtureboxes in the picturebox array, and checks if the image they store is equal to the picture that represents that the userinput passes the validation test

            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                if(pictureBoxes[i].Image == Global.greentick)
                {
                    validationPoints = validationPoints + 1;
                }
                else
                {
                    MessageBox.Show(errorMessage);
                    break;
                }

                
               
            }

            // if all of the validations are passed this happens
            if (validationPoints == pictureBoxes.Length)
            { 

                //string data is converted into an integer

                animalCost = Int32.Parse(stranimalCost);
                animalMaxAge = Int32.Parse(stranimalMaxAge);
                MessageBox.Show("True");
                // the already validated data gets inserted into the database
                //line below sets the query with correct text
                string query = "INSERT INTO list_of_animals (`animal_type`, `animal_subtype`,'animal_max_age','date_of_birth','date_of_last_vaccination','cost','description','picture','date_available_for_rehoming') VALUES (@animalType,@animalSubtype,@animalMaxAge,@DOB,@LastVaccination,@cost,@description,@picture,@available)";
                myCommand = new SQLiteCommand(query, databaseObject.myConnection);
                myCommand.Parameters.AddWithValue("@animalType", animalType);
                myCommand.Parameters.AddWithValue("@animalSubtype",animalSubtype);
                myCommand.Parameters.AddWithValue("@animalMaxAge", animalMaxAge);
                myCommand.Parameters.AddWithValue("@DOB", strDOB);
                myCommand.Parameters.AddWithValue("@LastVaccination",strVaccination);
                myCommand.Parameters.AddWithValue("@cost", animalCost);
                myCommand.Parameters.AddWithValue("@description", animalDescription);
                myCommand.Parameters.AddWithValue("@picture", base64String);
                myCommand.Parameters.AddWithValue("@available", strAvailable);
                databaseObject.OpenConnection();
                var result = myCommand.ExecuteNonQuery();
                databaseObject.CloseConnection();


            }

        }

        private void TxtAnimalType_Enter(object sender, EventArgs e)
        {
            mu.Placeholder_enter(txtAnimalType, "animal type");
        }

        private void TxtAnimalType_Leave(object sender, EventArgs e)
        {
            mu.Placeholder_leave(txtAnimalType, "animal type");
        }

        private void TxtAnimalSubtype_Enter(object sender, EventArgs e)
        {
            mu.Placeholder_enter(txtAnimalSubtype, "animal subtype(breed)");
        }

        private void TxtAnimalSubtype_Leave(object sender, EventArgs e)
        {
            mu.Placeholder_leave(txtAnimalSubtype, "animal subtype(breed)");
        }

        private void TxtMaxAge_Enter(object sender, EventArgs e)
        {
            mu.Placeholder_enter(txtMaxAge, "expected maximum age");
        }

        private void TxtMaxAge_Leave(object sender, EventArgs e)
        {
            mu.Placeholder_leave(txtMaxAge, "expected maximum age");
        }

        private void TxtCost_Enter(object sender, EventArgs e)
        {
            mu.Placeholder_enter(txtCost, "cost £££");
        }

        private void TxtCost_Leave(object sender, EventArgs e)
        {
            mu.Placeholder_leave(txtCost, "cost £££");
        }

        private void TxtDescribtion_Enter(object sender, EventArgs e)
        {
            mu.Placeholder_enter(txtDescribtion,"animal's needs description");
        }



        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TxtDescribtion_Leave(object sender, EventArgs e)
        {
            mu.Placeholder_leave(txtDescribtion, "animal's needs description");
        }


        private void txtLogo_MouseClick(object sender, MouseEventArgs e)
        {

            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }





        private void BtnPictureSelect_Click(object sender, EventArgs e)
        {
            // opens the menu to select he picture from
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmaps|*.bmp|jpeps|*.jpg";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picAnimal.ImageLocation = openFileDialog.FileName;
            }

            picturePath = picAnimal.ImageLocation;

            // the image gets converted into a format that can be instred into the databse, 64 bse string
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

        
    }
}
