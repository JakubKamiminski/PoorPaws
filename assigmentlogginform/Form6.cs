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
    public partial class Form6 : Form
    {
        // creating connections to other classes and declering vriables that will be used later on
        private static readonly Database databaseObject = new Database();

        private static readonly MyUtilities mu = new MyUtilities();

        public Form6()
        {
            InitializeComponent();

            mu.SetAnimalSubtype(Global.selectedAnimal, AnimalSubtypeResult);
            mu.SetAge(Global.selectedAnimal, AgeResult);
            mu.SetCost(Global.selectedAnimal, costResult);
            mu.SetDateAvailalbe(Global.selectedAnimal, RehomingResult);
            mu.SetLastVaccination(Global.selectedAnimal, VaccinationResult);
            mu.SetImage(Global.selectedAnimal, AnimalPicture);
            mu.SetType(Global.selectedAnimal, animalTypeResult);
            mu.SetDescription(Global.selectedAnimal, DescriptionResullt);
            mu.SetDOB(Global.selectedAnimal, DOBResult);
            mu.SetMaxAge(Global.selectedAnimal, MaxAgeResult);
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnMeeting_Click(object sender, EventArgs e)
        {
            mu.Error();
        }

        private void BtnFavourite_Click(object sender, EventArgs e)
        {
            mu.Error();
        }

        private void TxtLogo_MouseClick(object sender, MouseEventArgs e)
        {
            if(Global.currentUser == 1)
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
            }
            else
            {
                Form5 f5 = new Form5();
                this.Hide();
                f5.ShowDialog();
            }
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
