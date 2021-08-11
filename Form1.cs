using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FEpimpMyunit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            eraseLabels();
        }

        public void eraseLabels()
        {
            lblNome1.Text = "";
            lblNome2.Text = "";
            lblNome3.Text = "";
            lblNome4.Text = "";
            lblNome5.Text = "";
            lblNome6.Text = "";
            lblNome7.Text = "";
            lblNome8.Text = "";
            lblNome9.Text = "";
            lblNome10.Text = "";
        }
        public void erasePaths()
        {
            picBox1.ImageLocation = "";
            picBox2.ImageLocation = "";
            picBox3.ImageLocation = "";
            picBox4.ImageLocation = "";
            picBox5.ImageLocation = "";
            picBox6.ImageLocation = "";
            picBox7.ImageLocation = "";
            picBox8.ImageLocation = "";
            picBox9.ImageLocation = "";
            picBox10.ImageLocation = "";
            }

        private void button1_Click(object sender, EventArgs e)
        {
            eraseLabels();
            if (cboSerie.Text != "")
            {
                if (cboQuantidade.Text != "")
                {
                    int caseSwitch = int.Parse(cboQuantidade.Text);
                    erasePaths();


                    switch (caseSwitch)
                    {
                        case 1:
                            definepic1();
                            break;

                        case 2:
                            definepic1();
                            definepic2();
                            break;

                        case 3:
                            definepic1();
                            definepic2();
                            definepic3();
                            break;

                        case 4:
                            definepic1();
                            definepic2();
                            definepic3();
                            definepic4();
                            break;

                        case 5:
                            definepic1();
                            definepic2();
                            definepic3();
                            definepic4();
                            definepic5();
                            break;

                        case 6:
                            definepic1();
                            definepic2();
                            definepic3();
                            definepic4();
                            definepic5();
                            definepic6();
                            break;

                        case 7:
                            definepic1();
                            definepic2();
                            definepic3();
                            definepic4();
                            definepic5();
                            definepic6();
                            definepic7();
                            break;

                        case 8:
                            definepic1();
                            definepic2();
                            definepic3();
                            definepic4();
                            definepic5();
                            definepic6();
                            definepic7();
                            definepic8();
                            break;

                        case 9:
                            definepic1();
                            definepic2();
                            definepic3();
                            definepic4();
                            definepic5();
                            definepic6();
                            definepic7();
                            definepic8();
                            definepic9();
                            break;

                        case 10:
                            definepic1();
                            definepic2();
                            definepic3();
                            definepic4();
                            definepic5();
                            definepic6();
                            definepic7();
                            definepic8();
                            definepic9();
                            definepic10();
                            break;
                    }

                }else { MessageBox.Show("You must select characters quantity!", "alert"); }
            }else { MessageBox.Show("You must select a series first!", "alert"); }
        }

        public void definepic1()
        {
            string textoswitch = cboSerie.Text;
            Random rnd = new Random();
            switch (textoswitch)
            {
                case "Fire Emblem Echoes (Alm)":
                    string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
                    picBox1.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                    lblNome1.Text = picBox1.ImageLocation.Substring(29).Replace(".png", "");
                    break;

                case "Fire Emblem Echoes (Celica)":
                    string[] celicachar = new string[] {"Mae", "Boey", "Genny", "Saber", "Valbar", "Leon",
            "Kamui", "Palla", "Catria", "Est", "Jesse", "Atlas", "Sonya", "Deen", "Nomah", "Conrad"};
                    picBox1.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
                    lblNome1.Text = picBox1.ImageLocation.Substring(29).Replace(".png", "");
                    break;
            }
        }

        public void definepic2()
        {
            string textoswitch = cboSerie.Text;
            Random rnd = new Random();
            switch (textoswitch)
            {
                case "Fire Emblem Echoes (Alm)":
                    string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
                    picBox2.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                    for (picBox2.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
            picBox2.ImageLocation == picBox1.ImageLocation; picBox2.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
                    lblNome2.Text = picBox2.ImageLocation.Substring(29).Replace(".png", "");
                    break;

                case "Fire Emblem Echoes (Celica)":
                    string[] celicachar = new string[] {"Mae", "Boey", "Genny", "Saber", "Valbar", "Leon",
            "Kamui", "Palla", "Catria", "Est", "Jesse", "Atlas", "Sonya", "Deen", "Nomah", "Conrad"};
                    picBox2.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
                    for (picBox2.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
            picBox2.ImageLocation == picBox1.ImageLocation; picBox2.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png") { }
                    lblNome2.Text = picBox2.ImageLocation.Substring(29).Replace(".png", "");
                    break;
            }
        }

        public void definepic3()
        {
            string textoswitch = cboSerie.Text;
            Random rnd = new Random();
            switch (textoswitch)
            {
                case "Fire Emblem Echoes (Alm)":
                    string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
                    picBox3.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                    for (picBox3.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
            picBox3.ImageLocation == picBox1.ImageLocation || picBox3.ImageLocation == picBox2.ImageLocation; picBox3.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
                    lblNome3.Text = picBox3.ImageLocation.Substring(29).Replace(".png", "");
                    break;

                case "Fire Emblem Echoes (Celica)":
                    string[] celicachar = new string[] {"Mae", "Boey", "Genny", "Saber", "Valbar", "Leon",
            "Kamui", "Palla", "Catria", "Est", "Jesse", "Atlas", "Sonya", "Deen", "Nomah", "Conrad"};
                    picBox3.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
                    for (picBox3.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
            picBox3.ImageLocation == picBox1.ImageLocation || picBox3.ImageLocation == picBox2.ImageLocation; picBox3.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png") { }
                    lblNome3.Text = picBox3.ImageLocation.Substring(29).Replace(".png", "");
                    break;
            }
        }

        public void definepic4()
        {
            string textoswitch = cboSerie.Text;
            Random rnd = new Random();
            switch (textoswitch)
            {
                case "Fire Emblem Echoes (Alm)":
                    string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
                    picBox4.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                    for (picBox4.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
            picBox4.ImageLocation == picBox1.ImageLocation || picBox4.ImageLocation == picBox2.ImageLocation || picBox4.ImageLocation == picBox3.ImageLocation; picBox4.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
                    lblNome4.Text = picBox4.ImageLocation.Substring(29).Replace(".png", "");
                    break;

                case "Fire Emblem Echoes (Celica)":
                    string[] celicachar = new string[] {"Mae", "Boey", "Genny", "Saber", "Valbar", "Leon",
            "Kamui", "Palla", "Catria", "Est", "Jesse", "Atlas", "Sonya", "Deen", "Nomah", "Conrad"};
                    picBox4.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
                    for (picBox4.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
            picBox4.ImageLocation == picBox1.ImageLocation || picBox4.ImageLocation == picBox2.ImageLocation || picBox4.ImageLocation == picBox3.ImageLocation; picBox4.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png") { }
                    lblNome4.Text = picBox4.ImageLocation.Substring(29).Replace(".png", "");
                    break;
            }

        }

        public void definepic5()
        {
            string textoswitch = cboSerie.Text;
            Random rnd = new Random();
            switch (textoswitch)
            {
                case "Fire Emblem Echoes (Alm)":
                    string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
                    picBox5.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                    for (picBox5.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
            picBox5.ImageLocation == picBox1.ImageLocation || picBox5.ImageLocation == picBox2.ImageLocation || picBox5.ImageLocation == picBox3.ImageLocation
            || picBox5.ImageLocation == picBox4.ImageLocation; picBox5.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
                    lblNome5.Text = picBox5.ImageLocation.Substring(29).Replace(".png", "");
                    break;

                case "Fire Emblem Echoes (Celica)":
                    string[] celicachar = new string[] {"Mae", "Boey", "Genny", "Saber", "Valbar", "Leon",
            "Kamui", "Palla", "Catria", "Est", "Jesse", "Atlas", "Sonya", "Deen", "Nomah", "Conrad"};
                    picBox5.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
                    for (picBox5.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
            picBox5.ImageLocation == picBox1.ImageLocation || picBox5.ImageLocation == picBox2.ImageLocation || picBox5.ImageLocation == picBox3.ImageLocation
            || picBox5.ImageLocation == picBox4.ImageLocation; picBox5.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png") { }
                    lblNome5.Text = picBox5.ImageLocation.Substring(29).Replace(".png", "");
                    break;
            }

        }

        public void definepic6()
        {
            string textoswitch = cboSerie.Text;
            Random rnd = new Random();
            switch (textoswitch)
            {
                case "Fire Emblem Echoes (Alm)":
                    string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
                    picBox6.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                    for (picBox6.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
            picBox6.ImageLocation == picBox1.ImageLocation || picBox6.ImageLocation == picBox2.ImageLocation || picBox6.ImageLocation == picBox3.ImageLocation
            || picBox6.ImageLocation == picBox4.ImageLocation || picBox6.ImageLocation == picBox5.ImageLocation; picBox6.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
                    lblNome6.Text = picBox6.ImageLocation.Substring(29).Replace(".png", "");
                    break;

                case "Fire Emblem Echoes (Celica)":
                    string[] celicachar = new string[] {"Mae", "Boey", "Genny", "Saber", "Valbar", "Leon",
            "Kamui", "Palla", "Catria", "Est", "Jesse", "Atlas", "Sonya", "Deen", "Nomah", "Conrad"};
                    picBox6.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
                    for (picBox6.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
            picBox6.ImageLocation == picBox1.ImageLocation || picBox6.ImageLocation == picBox2.ImageLocation || picBox6.ImageLocation == picBox3.ImageLocation
            || picBox6.ImageLocation == picBox4.ImageLocation || picBox6.ImageLocation == picBox5.ImageLocation; picBox6.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png") { }
                    lblNome6.Text = picBox6.ImageLocation.Substring(29).Replace(".png", "");
                    break;
            }
        }

            public void definepic7()
            {
                string textoswitch = cboSerie.Text;
                Random rnd = new Random();
                switch (textoswitch)
                {
                    case "Fire Emblem Echoes (Alm)":
                        string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
                        picBox7.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                        for (picBox7.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                picBox7.ImageLocation == picBox1.ImageLocation || picBox7.ImageLocation == picBox2.ImageLocation || picBox7.ImageLocation == picBox3.ImageLocation
                || picBox7.ImageLocation == picBox4.ImageLocation || picBox7.ImageLocation == picBox5.ImageLocation || picBox7.ImageLocation == picBox6.ImageLocation; picBox7.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
                    lblNome7.Text = picBox7.ImageLocation.Substring(29).Replace(".png", "");
                    break;

                    case "Fire Emblem Echoes (Celica)":
                        string[] celicachar = new string[] {"Mae", "Boey", "Genny", "Saber", "Valbar", "Leon",
            "Kamui", "Palla", "Catria", "Est", "Jesse", "Atlas", "Sonya", "Deen", "Nomah", "Conrad"};
                        picBox7.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
                        for (picBox7.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
                picBox7.ImageLocation == picBox1.ImageLocation || picBox7.ImageLocation == picBox2.ImageLocation || picBox7.ImageLocation == picBox3.ImageLocation
                || picBox7.ImageLocation == picBox4.ImageLocation || picBox7.ImageLocation == picBox5.ImageLocation || picBox7.ImageLocation == picBox6.ImageLocation; picBox7.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png") { }
                    lblNome7.Text = picBox7.ImageLocation.Substring(29).Replace(".png", "");
                    break;
                }
            }
        public void definepic8()
        {
            string textoswitch = cboSerie.Text;
            Random rnd = new Random();
            switch (textoswitch)
            {
                case "Fire Emblem Echoes (Alm)":
                    string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
                    picBox8.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                    for (picBox8.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
            picBox8.ImageLocation == picBox1.ImageLocation || picBox8.ImageLocation == picBox2.ImageLocation || picBox8.ImageLocation == picBox3.ImageLocation
            || picBox8.ImageLocation == picBox4.ImageLocation || picBox8.ImageLocation == picBox5.ImageLocation || picBox8.ImageLocation == picBox6.ImageLocation
            || picBox8.ImageLocation == picBox7.ImageLocation; picBox8.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
                    lblNome8.Text = picBox8.ImageLocation.Substring(29).Replace(".png", "");
                    break;

                case "Fire Emblem Echoes (Celica)":
                    string[] celicachar = new string[] {"Mae", "Boey", "Genny", "Saber", "Valbar", "Leon",
            "Kamui", "Palla", "Catria", "Est", "Jesse", "Atlas", "Sonya", "Deen", "Nomah", "Conrad"};
                    picBox8.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
                    for (picBox8.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
            picBox8.ImageLocation == picBox1.ImageLocation || picBox8.ImageLocation == picBox2.ImageLocation || picBox8.ImageLocation == picBox3.ImageLocation
            || picBox8.ImageLocation == picBox4.ImageLocation || picBox8.ImageLocation == picBox5.ImageLocation || picBox8.ImageLocation == picBox6.ImageLocation
            || picBox8.ImageLocation == picBox7.ImageLocation; picBox8.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png") { }
                    lblNome8.Text = picBox8.ImageLocation.Substring(29).Replace(".png", "");
                    break;
            }
        }

        public void definepic9()
        {
            string textoswitch = cboSerie.Text;
            Random rnd = new Random();
            switch (textoswitch)
            {
                case "Fire Emblem Echoes (Alm)":
                    string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
                    picBox9.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                    for (picBox9.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
            picBox9.ImageLocation == picBox1.ImageLocation || picBox9.ImageLocation == picBox2.ImageLocation || picBox9.ImageLocation == picBox3.ImageLocation
            || picBox9.ImageLocation == picBox4.ImageLocation || picBox9.ImageLocation == picBox5.ImageLocation || picBox9.ImageLocation == picBox6.ImageLocation
            || picBox9.ImageLocation == picBox7.ImageLocation || picBox9.ImageLocation == picBox8.ImageLocation; picBox9.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
                    lblNome9.Text = picBox9.ImageLocation.Substring(29).Replace(".png", "");
                    break;

                case "Fire Emblem Echoes (Celica)":
                    string[] celicachar = new string[] {"Mae", "Boey", "Genny", "Saber", "Valbar", "Leon",
            "Kamui", "Palla", "Catria", "Est", "Jesse", "Atlas", "Sonya", "Deen", "Nomah", "Conrad"};
                    picBox9.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
                    for (picBox9.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
            picBox9.ImageLocation == picBox1.ImageLocation || picBox9.ImageLocation == picBox2.ImageLocation || picBox9.ImageLocation == picBox3.ImageLocation
            || picBox9.ImageLocation == picBox4.ImageLocation || picBox9.ImageLocation == picBox5.ImageLocation || picBox9.ImageLocation == picBox6.ImageLocation
            || picBox9.ImageLocation == picBox7.ImageLocation || picBox9.ImageLocation == picBox8.ImageLocation; picBox9.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png") { }
                    lblNome9.Text = picBox9.ImageLocation.Substring(29).Replace(".png", "");
                    break;
            }
        }
            public void definepic10()
            {
                string textoswitch = cboSerie.Text;
                Random rnd = new Random();
                switch (textoswitch)
                {
                    case "Fire Emblem Echoes (Alm)":
                        string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
                        picBox10.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                        for (picBox10.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                picBox10.ImageLocation == picBox1.ImageLocation || picBox10.ImageLocation == picBox2.ImageLocation || picBox10.ImageLocation == picBox3.ImageLocation
                || picBox10.ImageLocation == picBox4.ImageLocation || picBox10.ImageLocation == picBox5.ImageLocation || picBox10.ImageLocation == picBox6.ImageLocation
                || picBox10.ImageLocation == picBox7.ImageLocation || picBox10.ImageLocation == picBox8.ImageLocation || picBox10.ImageLocation == picBox9.ImageLocation; picBox10.ImageLocation = @"Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
                    lblNome10.Text = picBox10.ImageLocation.Substring(29).Replace(".png", "");
                    break;

                    case "Fire Emblem Echoes (Celica)":
                        string[] celicachar = new string[] {"Mae", "Boey", "Genny", "Saber", "Valbar", "Leon",
            "Kamui", "Palla", "Catria", "Est", "Jesse", "Atlas", "Sonya", "Deen", "Nomah", "Conrad"};
                        picBox10.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
                        for (picBox10.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png";
                picBox10.ImageLocation == picBox1.ImageLocation || picBox10.ImageLocation == picBox2.ImageLocation || picBox10.ImageLocation == picBox3.ImageLocation
                || picBox10.ImageLocation == picBox4.ImageLocation || picBox10.ImageLocation == picBox5.ImageLocation || picBox10.ImageLocation == picBox6.ImageLocation
                || picBox10.ImageLocation == picBox7.ImageLocation || picBox10.ImageLocation == picBox8.ImageLocation || picBox10.ImageLocation == picBox9.ImageLocation; picBox10.ImageLocation = @"Resources\fire emblem images\" + celicachar[rnd.Next(celicachar.Length)] + ".png") { }
                    lblNome10.Text = picBox10.ImageLocation.Substring(29).Replace(".png", "");
                    break;
                }
            }
    }   
}
