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

namespace assigmentlogginform
{
    public partial class Form1 : Form
    {
        // form is getting connected to other classes
        private static readonly Database databaseObject = new Database();

        private static readonly MyUtilities mu = new MyUtilities();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // when the button is pressed the varaibles are assigned with  the data stored in the textboxes
            string password, username, query;
            password = txtPassword.Text;
            username = txtUsername.Text;
            // query varaible is assigned with a query that returs evertyhing from the fields were username nad password match the one entered by the user
            query = ("SELECT * FROM admin_users WHERE username = @username AND password = @password");
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            myCommand.Parameters.AddWithValue("@username", username);
            myCommand.Parameters.AddWithValue("@password", password);
            databaseObject.OpenConnection(); 
            SQLiteDataReader result = myCommand.ExecuteReader(); // the query is executed 
            
            // if anyhting is returned from the query which means there is an account that matches the user input this section happens
            if (result.HasRows)
            {
                //1 tells the varaible that an admin is logging in
                Global.currentUser = 1;
                //connection is closed and the command and results are disposed so they are not affecting future commands
                databaseObject.CloseConnection();
                myCommand.Dispose();
                result.Dispose();
                // new form is being open
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
            }
            else
            {
                //0 tells the variable that a normal user is logging in
                Global.currentUser = 0;
                // the section above was for admin users, if nothing is returned program checks the normal user table to see if there is a result here
                query = ("SELECT * FROM normal_users WHERE username = @username AND password = @password");
                myCommand = new SQLiteCommand(query, databaseObject.myConnection);
                myCommand.Parameters.AddWithValue("@username", username);
                myCommand.Parameters.AddWithValue("@password", password);
                databaseObject.OpenConnection();
                result = myCommand.ExecuteReader();
                if (result.HasRows)
                {
                    databaseObject.CloseConnection();
                    myCommand.Dispose();
                    result.Dispose();
                    // form for normal users is getting open
                    Form5 f5 = new Form5();
                    this.Hide();
                    f5.ShowDialog();
                }
                else
                {
                    // if there is no result in both tables it means that the account doesn't exist
                    MessageBox.Show("False");
                    mu.InCorrectValue(txtPassword, picturebox2);
                    mu.InCorrectValue(txtUsername, pictureBox1);
                }

            }
            
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
           mu.Placeholder_enter(txtUsername,"username");
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            mu.Placeholder_leave(txtUsername,"username");
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            mu.Password_placeholder_enter(txtPassword,"password");
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            mu.Password_placeholder_leave(txtPassword,"password");
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }




    }
