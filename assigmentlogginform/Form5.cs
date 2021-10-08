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
    public partial class Form5 : Form
    {
        private static readonly Database databaseObject = new Database();

        private static readonly MyUtilities mu = new MyUtilities();

        public Form5()
        {
            InitializeComponent();
            Label[] ageLabels = { ansAge1, ansAge2, ansAge3, ansAge4, ansAge5, ansAge6 };
            Label[] subtypeLabels = { ansSubtype1, ansSubtype2, ansSubtype3, ansSubtype4, ansSubtype5, ansSubtype6 };
            Label[] costLabels = { lblPrice1, lblPrice2, lblPrice3, lblPrice4, lblPrice5, lblPrice6 };
            Label[] availableLabels = { ansAvailable1, ansAvailable2, ansAvailable3, ansAvailable4, ansAvailable5, ansAvailable6 };
            Label[] vaccinationLabels = { ansVaccination1, ansVaccination2, ansVaccination3, ansVaccination4, ansVaccination5, ansVaccination6 };
            PictureBox[] animalPictureboxes = { pic1, pic2, pic3, pic4, pic5, pic6 };
            string query = ("SELECT count(animal_ID) FROM list_of_animals");
            int RowCount = 0;

            databaseObject.OpenConnection();
            SQLiteCommand myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            RowCount = Convert.ToInt32(myCommand.ExecuteScalar());
            myCommand.CommandText = ("SELECT animal_ID FROM list_of_animals");
            SQLiteDataReader result = myCommand.ExecuteReader();
            databaseObject.CloseConnection();


            int j = 0;
            // for loop to go through all the labels in the form and fill them with inforamtion from database
            for (int i = 1; i < RowCount + 1; i++)
            {
                // i represents the ID of the field that the functions will take infromartion from
                //j is wchich label in an array will be assigned data to now
                mu.SetAnimalSubtype(i, subtypeLabels[j]);
                mu.SetCost(i, costLabels[j]);
                mu.SetDateAvailalbe(i, availableLabels[j]);
                mu.SetLastVaccination(i, vaccinationLabels[j]);
                mu.SetAge(i, ageLabels[j]);
                mu.SetImage(i, animalPictureboxes[j]);
                j += 1;

            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            mu.Error();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are currently on this part of the app");
        }
        private void TxtrRangeBottom_Enter(object sender, EventArgs e)
        {
            mu.Placeholder_enter(txtrRangeBottom, "£££");
        }

        private void TxtrRangeBottom_Leave(object sender, EventArgs e)
        {
            mu.Placeholder_leave(txtrRangeBottom, "£££");
        }

        private void TxtRangeTop_Enter(object sender, EventArgs e)
        {
            mu.Placeholder_enter(txtRangeTop, "£££");
        }

        private void TxtRangeTop_Leave(object sender, EventArgs e)
        {
            mu.Placeholder_leave(txtRangeTop, "£££");
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            Global.selectedAnimal = 1;
            Form6 f6 = new Form6();
            this.Hide();
            f6.ShowDialog();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            Global.selectedAnimal = 2;
            Form6 f6 = new Form6();
            this.Hide();
            f6.ShowDialog();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            Global.selectedAnimal = 3;
            Form6 f6 = new Form6();
            this.Hide();
            f6.ShowDialog();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            Global.selectedAnimal = 4;
            Form6 f6 = new Form6();
            this.Hide();
            f6.ShowDialog();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            Global.selectedAnimal = 5;
            Form6 f6 = new Form6();
            this.Hide();
            f6.ShowDialog();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            Global.selectedAnimal = 6;
            Form6 f6 = new Form6();
            this.Hide();
            f6.ShowDialog();
        }
    }
}
