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
            if (cboQuantidade.Text != "" )
            {
                int caseSwitch = int.Parse(cboQuantidade.Text);
                erasePaths();

                if (cboSerie.Text == "Fire Emblem Echoes (Alm)")
                {
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

                }
                else { MessageBox.Show("You must choose a series!", "Alert"); }


            } else { MessageBox.Show("You must select characters quantity!", "alert"); }

        }

        public void definepic1()
        {
                string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
                Random rnd = new Random();
                picBox1.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
         }

        public void definepic2()
        {
            string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
            Random rnd = new Random();

            for (picBox2.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
            picBox2.ImageLocation == picBox1.ImageLocation; picBox2.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
        }

        public void definepic3()
        {
            string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
            Random rnd = new Random();
            for (picBox3.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                           picBox3.ImageLocation == picBox1.ImageLocation || picBox3.ImageLocation == picBox2.ImageLocation; 
                           picBox3.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
        }

        public void definepic4()
        {
            string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
            Random rnd = new Random();
            for (picBox4.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                           picBox4.ImageLocation == picBox1.ImageLocation || picBox4.ImageLocation == picBox2.ImageLocation || picBox4.ImageLocation == picBox3.ImageLocation;
                           picBox4.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
         }

        public void definepic5()
        {
            string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
            Random rnd = new Random();
            for (picBox5.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                           picBox5.ImageLocation == picBox1.ImageLocation || picBox5.ImageLocation == picBox2.ImageLocation || picBox5.ImageLocation == picBox3.ImageLocation || picBox5.ImageLocation == picBox4.ImageLocation;
                           picBox5.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
        }

        public void definepic6()
        {
            string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
            Random rnd = new Random();
            for (picBox6.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                           picBox6.ImageLocation == picBox1.ImageLocation || picBox6.ImageLocation == picBox2.ImageLocation || picBox6.ImageLocation == picBox3.ImageLocation
                           || picBox6.ImageLocation == picBox4.ImageLocation || picBox6.ImageLocation == picBox5.ImageLocation;
                           picBox6.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
        }

        public void definepic7()
        {
            string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
            Random rnd = new Random();
            for (picBox7.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                           picBox7.ImageLocation == picBox1.ImageLocation || picBox7.ImageLocation == picBox2.ImageLocation || picBox7.ImageLocation == picBox3.ImageLocation
                           || picBox7.ImageLocation == picBox4.ImageLocation || picBox7.ImageLocation == picBox5.ImageLocation || picBox7.ImageLocation == picBox6.ImageLocation;
                           picBox7.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
        }

        public void definepic8()
        {
            string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
            Random rnd = new Random();
            for (picBox8.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                           picBox8.ImageLocation == picBox1.ImageLocation || picBox8.ImageLocation == picBox2.ImageLocation || picBox8.ImageLocation == picBox3.ImageLocation
                           || picBox8.ImageLocation == picBox4.ImageLocation || picBox8.ImageLocation == picBox5.ImageLocation || picBox8.ImageLocation == picBox6.ImageLocation
                           || picBox8.ImageLocation == picBox7.ImageLocation;
                           picBox8.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
        }

        public void definepic9()
        {
            string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
            Random rnd = new Random();
            for (picBox9.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                           picBox9.ImageLocation == picBox1.ImageLocation || picBox9.ImageLocation == picBox2.ImageLocation || picBox9.ImageLocation == picBox3.ImageLocation
                           || picBox9.ImageLocation == picBox4.ImageLocation || picBox9.ImageLocation == picBox5.ImageLocation
                           || picBox9.ImageLocation == picBox6.ImageLocation || picBox9.ImageLocation == picBox7.ImageLocation || picBox9.ImageLocation == picBox8.ImageLocation;
                           picBox9.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
        }

        public void definepic10()
        {
            string[] almchar = new string[] {"Gray", "Tobin", "Faye", "Kliff", "Lukas", "Silque", "Clair", "Clive",
                "Forsyth", "Python", "Luthier", "Mathilda", "Delthea", "Tatiana", "Zeke", "Mycen"};
            Random rnd = new Random();
            for (picBox10.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png";
                           picBox10.ImageLocation == picBox1.ImageLocation || picBox10.ImageLocation == picBox2.ImageLocation || picBox10.ImageLocation == picBox3.ImageLocation
                           || picBox10.ImageLocation == picBox4.ImageLocation || picBox10.ImageLocation == picBox5.ImageLocation
                           || picBox10.ImageLocation == picBox6.ImageLocation || picBox10.ImageLocation == picBox7.ImageLocation || picBox10.ImageLocation == picBox8.ImageLocation || picBox10.ImageLocation == picBox9.ImageLocation;
                           picBox10.ImageLocation = @"C:\Users\felip\source\repos\FEpimpMyunit\Resources\fire emblem images\" + almchar[rnd.Next(almchar.Length)] + ".png") { }
        }

      }
}
