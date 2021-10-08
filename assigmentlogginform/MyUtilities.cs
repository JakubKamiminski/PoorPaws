using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Messaging;

namespace assigmentlogginform
{
    class Global
    {
        // creates global varaibles that are used throughout few forms
        public static Image greentick = Properties.Resources.greentick;
        public static Image redcross = Properties.Resources.redcross;
        public static int selectedAnimal;
        public static int currentUser;

    }
    internal class MyUtilities
    {
        Database databaseObject = new Database();

        // when the user clicks on the textbox the text stored in there used as a placeholder disappears
        public void Placeholder_enter(TextBox textBoxName, string placeholder)
        {
            if (textBoxName.ForeColor == Color.Red)
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
                textBoxName.Font = new Font(textBoxName.Font, FontStyle.Regular);
            }
            if (textBoxName.Text == placeholder + "...")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
                textBoxName.Font = new Font(textBoxName.Font, FontStyle.Regular);
            }

        }
        // if the user leaves the textbox without entering anyhitng back in, the placeholder text comes back
        public void Placeholder_leave(TextBox textBoxName, string placeholder)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = placeholder + "...";
                textBoxName.ForeColor = Color.Silver;
                textBoxName.Font = new Font(textBoxName.Font, FontStyle.Italic);
            }
        }

        public void Password_placeholder_enter(TextBox textBoxName, string placeholder)
        {
            if (textBoxName.ForeColor == Color.Red)
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
                textBoxName.Font = new Font(textBoxName.Font, FontStyle.Regular);
            }
            if (textBoxName.Text == placeholder + "...")
            {
                textBoxName.PasswordChar = '*';
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
                textBoxName.Font = new Font(textBoxName.Font, FontStyle.Regular);
            }
        }
        public void Password_placeholder_leave(TextBox textBoxName, string placeholder)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.PasswordChar = '\0';
                textBoxName.Text = placeholder + "...";
                textBoxName.ForeColor = Color.Silver;
                textBoxName.Font = new Font(textBoxName.Font, FontStyle.Italic);
            }
        }
        //makes the textbox with a correct value look like the stored in ther is correct, so the user know he can skip this box when going through themagain to fix any errors
        public void CorrectValue(TextBox textBoxName, PictureBox pictureBoxNumber)
        {
            textBoxName.ForeColor = Color.Green;
            pictureBoxNumber.Image = Global.greentick;
        }
        // makes the textbox look like the data stored in them is incorrect to make looking for errors easier
        public void InCorrectValue(TextBox textBoxName, PictureBox pictureBoxNumber)
        {
            textBoxName.ForeColor = Color.Red;
            pictureBoxNumber.Image = Global.redcross;
        }

        //checks if the date entered is real and already happened
        public void Datecheck(DateTime dtpvalue, PictureBox pictureBoxName)
        {
            DateTime todaysdate = DateTime.Today;
            int result = DateTime.Compare(dtpvalue, todaysdate);
            if (result > 0)
            {
                pictureBoxName.Image = Global.redcross;
            }
            else
            {
                pictureBoxName.Image = Global.greentick;
            }
        }

        //check if anything has been input in a textbox and if it contains any digits 
        public void LenghtAndDigitCheck(TextBox textBoxName, string placeholder, PictureBox pictureBoxName)
        {
            bool lengthCheck = false, digitCheck = false;
            if (textBoxName.Text == "" || textBoxName.Text == placeholder + "...")
            {
                InCorrectValue(textBoxName, pictureBoxName);
            }
            else
            {
                lengthCheck = true;
            }
            if (textBoxName.Text.Any(char.IsDigit))
            {
                InCorrectValue(textBoxName, pictureBoxName);
            }
            else
            {
                digitCheck = true;
            }
            if (lengthCheck == true && digitCheck == true)
            {
                CorrectValue(textBoxName, pictureBoxName);
            }


        }
        //check if anything has been input in a textbox and if it contains any letters
        public void LengthAndLetterCheck(TextBox textBoxName, string placeholder, PictureBox pictureBoxName)
        {
            bool lengthCheck = false, letterCheck = false;
            if (textBoxName.Text == "" || textBoxName.Text == placeholder + "...")
            {
                InCorrectValue(textBoxName, pictureBoxName);
            }
            else
            {
                lengthCheck = true;
            }
            if (textBoxName.Text.Any(char.IsLetter))
            {
                InCorrectValue(textBoxName, pictureBoxName);
            }
            else
            {
                letterCheck = true;
            }
            if (lengthCheck == true && letterCheck == true)
            {
                CorrectValue(textBoxName, pictureBoxName);
            }
        }

        //sets animal subtype label to show whatever is stored in the database
        public void SetAnimalSubtype(int idValue, Label label)
        {

            string query = ("SELECT animal_subtype FROM list_of_animals WHERE animal_ID  = @id");
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            myCommand.Parameters.AddWithValue("@id", idValue);
            databaseObject.OpenConnection();
            myCommand.CommandText = query;
            label.Text = myCommand.ExecuteScalar().ToString();
            databaseObject.CloseConnection();

        }
        //sets animal last vaccination label to show whatever is stored in the database
        public void SetLastVaccination(int idValue, Label label)
        {
            string query = ("SELECT date_of_last_vaccination FROM list_of_animals WHERE animal_ID = @id");
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            myCommand.Parameters.AddWithValue("@id", idValue);
            databaseObject.OpenConnection();
            myCommand.CommandText = query;
            label.Text = myCommand.ExecuteScalar().ToString();
            databaseObject.CloseConnection();

        }
        //sets animal availability date label to show whatever is stored in the database
        public void SetDateAvailalbe(int idValue, Label label)
        {
            string query = ("SELECT date_available_for_rehoming FROM list_of_animals WHERE animal_ID  = @id");
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            myCommand.Parameters.AddWithValue("@id", idValue);
            databaseObject.OpenConnection();
            myCommand.CommandText = query;
            label.Text = myCommand.ExecuteScalar().ToString();
            databaseObject.CloseConnection();

        }
        //sets animal age label to show whatever is stored in the database
        public void SetAge(int idValue, Label label)
        {
            string query = ("SELECT date_of_birth FROM list_of_animals WHERE animal_ID  = @id");
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            myCommand.Parameters.AddWithValue("@id", idValue);
            databaseObject.OpenConnection();
            myCommand.CommandText = query;
            string strdate = myCommand.ExecuteScalar().ToString();
            DateTime date = DateTime.ParseExact(strdate, "MM/dd/yyyy", null);
            databaseObject.CloseConnection();
            DateTime today = DateTime.Today;
            int yearDOB = date.Year;
            int currentYear = today.Year;
            int age = currentYear - yearDOB;
            strdate = age.ToString();
            label.Text = strdate;

        }
        //sets animal cost label to show whatever is stored in the database
        public void SetCost(int idValue, Label label)
        {
            string query = ("SELECT cost FROM list_of_animals WHERE animal_ID  = @id");
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            myCommand.Parameters.AddWithValue("@id", idValue);
            databaseObject.OpenConnection();
            myCommand.CommandText = query;
            label.Text = ("£" + myCommand.ExecuteScalar().ToString());
            databaseObject.CloseConnection();

        }
        //sets animal image to show whatever is stored in the database
        public void SetImage(int idValue, PictureBox pictureBoxName)
        {
            string query = ("SELECT picture FROM list_of_animals WHERE animal_ID  = @id");
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            myCommand.Parameters.AddWithValue("@id", idValue);
            databaseObject.OpenConnection();
            myCommand.CommandText = query;
            string base64String = myCommand.ExecuteScalar().ToString();
            databaseObject.CloseConnection();

            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            pictureBoxName.Image = image;
        }

        public void SetDOB(int idValue, Label label)
        {

            string query = ("SELECT date_of_birth FROM list_of_animals WHERE animal_ID  = @id");
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            myCommand.Parameters.AddWithValue("@id", idValue);
            databaseObject.OpenConnection();
            myCommand.CommandText = query;
            label.Text = myCommand.ExecuteScalar().ToString();
            databaseObject.CloseConnection();

        }

        public void SetDescription(int idValue, Label label)
        {

            string query = ("SELECT description FROM list_of_animals WHERE animal_ID  = @id");
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            myCommand.Parameters.AddWithValue("@id", idValue);
            databaseObject.OpenConnection();
            myCommand.CommandText = query;
            label.Text = myCommand.ExecuteScalar().ToString();
            databaseObject.CloseConnection();

        }

        public void SetType(int idValue, Label label)
        {

            string query = ("SELECT animal_type FROM list_of_animals WHERE animal_ID  = @id");
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            myCommand.Parameters.AddWithValue("@id", idValue);
            databaseObject.OpenConnection();
            myCommand.CommandText = query;
            label.Text = myCommand.ExecuteScalar().ToString();
            databaseObject.CloseConnection();

        }

        public void SetMaxAge(int idValue, Label label)
        {

            string query = ("SELECT animal_max_age FROM list_of_animals WHERE animal_ID  = @id");
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            myCommand.Parameters.AddWithValue("@id", idValue);
            databaseObject.OpenConnection();
            myCommand.CommandText = query;
            label.Text = myCommand.ExecuteScalar().ToString();
            databaseObject.CloseConnection();

        }


        // used   when user click on something that is not completed yet
        public void Error()
        {
            MessageBox.Show("This feature is not available yet");
        }
    }
}