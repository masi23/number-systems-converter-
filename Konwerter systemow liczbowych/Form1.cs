using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konwerter_systemow_liczbowych
{
    
    public partial class Form1 : Form
    {
       

        string selected_item, selected_item2;
        double z = 0, suma;
        int liczba;
        bool blad = false;
        System.String line;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            line = textBox1.Text;
            if(selected_item == "Binarny" && selected_item2 == "Dziesiętny")             //zamiana na dziesiętny START
            {
                
                    for (int i = line.Length - 1; i >= 0; i--)
                    {
                        liczba = Convert.ToInt32(line[i] - 48);
                    if(liczba < 0 || liczba > 1)
                    {
                        blad = true;
                    }
                        suma += (Convert.ToDouble(liczba) * (Math.Pow(2, z)));
                        z++;
                    }
                if(blad == false)
                {
                    MessageBox.Show("Twoja liczba w zapisie dziesietnym to " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("Podałeś nieodpowiednią wartość dla danego systemu liczbowego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blad = false;
                }
                    
                    z = 0;
                    suma = 0;
                    liczba = 0;
                
                
                
                
            }
            if(selected_item == "Trójkowy" && selected_item2 == "Dziesiętny")
            {
                
                    for(int i = line.Length - 1; i>=0; i--)
                    {
                        liczba = Convert.ToInt32(line[i] - 48);
                        suma += (Convert.ToDouble(liczba) * (Math.Pow(3, z)));
                        z++;
                    }
                if (blad == false)
                {
                    MessageBox.Show("Twoja liczba w zapisie dziesietnym to " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("Podałeś nieodpowiednią wartość dla danego systemu liczbowego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blad = false;
                }
                z = 0;
                    suma = 0;
                    liczba = 0;
                
            }
            if(selected_item == "Czwórkowy" && selected_item2 == "Dziesiętny")
            {
                
                    for(int i = line.Length - 1; i>=0; i--)
                    {
                        liczba = Convert.ToInt32(line[i] - 48);
                    if(liczba <0 || liczba > 3)
                    {
                        blad = true;
                    }
                        suma += (Convert.ToDouble(liczba) * (Math.Pow(4, z)));
                        z++;
                    }
                if (blad == false)
                {
                    MessageBox.Show("Twoja liczba w zapisie dziesietnym to " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("Podałeś nieodpowiednią wartość dla danego systemu liczbowego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blad = false;
                }
                z = 0;
                    suma = 0;
                    liczba = 0;
                
            }
            if(selected_item == "Piątkowy" && selected_item2 == "Dziesiętny")
            {
                for(int i = line.Length - 1; i>=0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    if(liczba < 0 || liczba > 4)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(5, z)));
                    z++;
                }
                if (blad == false)
                {
                    MessageBox.Show("Twoja liczba w zapisie dziesietnym to " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("Podałeś nieodpowiednią wartość dla danego systemu liczbowego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blad = false;
                }
                z = 0;
                suma = 0;
                liczba = 0;
            }
            if(selected_item == "Szóstkowy" && selected_item2 == "Dziesiętny")
            {
                for(int i = line.Length - 1; i>=0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    if(liczba < 0 || liczba > 5 )
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(6, z)));
                    z++;
                }
                if (blad == false)
                {
                    MessageBox.Show("Twoja liczba w zapisie dziesietnym to " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("Podałeś nieodpowiednią wartość dla danego systemu liczbowego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blad = false;
                }
                z = 0;
                suma = 0;
                liczba = 0;
            }
            if (selected_item == "Siódemkowy" && selected_item2 == "Dziesiętny")
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    if(liczba < 0 || liczba > 6)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(7, z)));
                    z++;
                }
                if (blad == false)
                {
                    MessageBox.Show("Twoja liczba w zapisie dziesietnym to " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("Podałeś nieodpowiednią wartość dla danego systemu liczbowego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blad = false;
                }
                z = 0;
                suma = 0;
                liczba = 0;
            }
            if (selected_item == "Ósemkowy" && selected_item2 == "Dziesiętny")
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    if(liczba < 0 || liczba > 7)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(8, z)));
                    z++;
                }
                if (blad == false)
                {
                    MessageBox.Show("Twoja liczba w zapisie dziesietnym to " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("Podałeś nieodpowiednią wartość dla danego systemu liczbowego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blad = false;
                }
                z = 0;
                suma = 0;
                liczba = 0;
            }
            if (selected_item == "Dziewiątkowy" && selected_item2 == "Dziesiętny")
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    if(liczba < 0 || liczba > 8)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(9, z)));
                    z++;
                }
                if (blad == false)
                {
                    MessageBox.Show("Twoja liczba w zapisie dziesietnym to " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("Podałeś nieodpowiednią wartość dla danego systemu liczbowego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blad = false;
                }
                z = 0;
                suma = 0;
                liczba = 0;
            }
            if (selected_item == "Jedenastkowy" && selected_item2 == "Dziesiętny")
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if(liczba < 0 || liczba > 10)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                if (blad == false)
                {
                    MessageBox.Show("Twoja liczba w zapisie dziesietnym to " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("Podałeś nieodpowiednią wartość dla danego systemu liczbowego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blad = false;
                }
                z = 0;
                suma = 0;
                liczba = 0;
            }
            if (selected_item == "Dwunastkowy" && selected_item2 == "Dziesiętny")
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    
                    if(liczba < 0 || liczba > 11)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(12, z)));
                    z++;
                }
                if (blad == false)
                {
                    MessageBox.Show("Twoja liczba w zapisie dziesietnym to " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("Podałeś nieodpowiednią wartość dla danego systemu liczbowego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blad = false;
                }
                z = 0;
                suma = 0;
                liczba = 0;
            }
            if (selected_item == "Trzynastkowy" && selected_item2 == "Dziesiętny")
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    
                    if(liczba < 0 || liczba > 12)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(13, z)));
                    z++;
                }
                if (blad == false)
                {
                    MessageBox.Show("Twoja liczba w zapisie dziesietnym to " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("Podałeś nieodpowiednią wartość dla danego systemu liczbowego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blad = false;
                }
                z = 0;
                suma = 0;
                liczba = 0;
            }
            if (selected_item == "Czternastkowy" && selected_item2 == "Dziesiętny")
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    
                    if(liczba < 0 || liczba > 13)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(14, z)));
                    z++;
                }
                if (blad == false)
                {
                    MessageBox.Show("Twoja liczba w zapisie dziesietnym to " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("Podałeś nieodpowiednią wartość dla danego systemu liczbowego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blad = false;
                }
                z = 0;
                suma = 0;
                liczba = 0;
            }
            if (selected_item == "Piętnastkowy" && selected_item2 == "Dziesiętny")
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }
                    if(liczba < 0 || liczba > 14)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(15, z)));
                    z++;
                }
                if (blad == false)
                {
                    MessageBox.Show("Twoja liczba w zapisie dziesietnym to " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("Podałeś nieodpowiednią wartość dla danego systemu liczbowego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blad = false;
                }
                z = 0;
                suma = 0;
                liczba = 0;
            }
            if (selected_item == "Szesnastkowy" && selected_item2 == "Dziesiętny")
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    
                    liczba = Convert.ToInt32(line[i] - 48);
                    if(liczba == 17)
                    {
                        liczba = 10;
                    }
                    if(liczba == 18)
                    { 
                        liczba = 11; 
                    }
                    if(liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }
                    if (liczba == 22)
                    {
                        liczba = 15;
                    }
                    
                    if(liczba < 0 || liczba > 15)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(16, z)));
                    z++;
                }
                if (blad == false)
                {
                    MessageBox.Show("Twoja liczba w zapisie dziesietnym to " + suma.ToString());
                }
                else
                {
                    MessageBox.Show("Podałeś nieodpowiednią wartość dla danego systemu liczbowego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    blad = false;
                }
                z = 0;
                suma = 0;
                liczba = 0;
            }                                                                        //zamiana na dziesiętny END
                                        
            if(selected_item == "Dziesiętny" && selected_item2 == "Binarny")         //zamiana dziesiętnego na binarny 
            {

                string xd = "";
                liczba = Convert.ToInt32(line);
                while (liczba > 0)
                {
                    xd = (liczba % 2).ToString() + xd;
                    liczba /= 2;
                }
                MessageBox.Show("Twoja liczba w zapisie binarnym to " + xd);
                liczba = 0;

            }

            if(selected_item == "Trójkowy" && selected_item2 == "Binarny")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(3, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);
                
                while (liczba > 0)
                {
                    xd = (liczba % 2).ToString() + xd;
                    liczba /= 2;
                }
                MessageBox.Show("Twoja liczba w zapisie binarnym to " + xd);
                liczba = 0;
                suma = 0;
                
            }
            
            if(selected_item == "Czwórkowy" && selected_item2 == "Binarny")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(4, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 2).ToString() + xd;
                    liczba /= 2;
                }
                MessageBox.Show("Twoja liczba w zapisie binarnym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Piątkowy" && selected_item2 == "Binarny")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(5, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 2).ToString() + xd;
                    liczba /= 2;
                }
                MessageBox.Show("Twoja liczba w zapisie binarnym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Szóstkowy" && selected_item2 == "Binarny")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(6, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 2).ToString() + xd;
                    liczba /= 2;
                }
                MessageBox.Show("Twoja liczba w zapisie binarnym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Siódemkowy" && selected_item2 == "Binarny")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(7, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 2).ToString() + xd;
                    liczba /= 2;
                }
                MessageBox.Show("Twoja liczba w zapisie binarnym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Ósemkowy" && selected_item2 == "Binarny")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(8, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 2).ToString() + xd;
                    liczba /= 2;
                }
                MessageBox.Show("Twoja liczba w zapisie binarnym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziewiątkowy" && selected_item2 == "Binarny")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(9, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 2).ToString() + xd;
                    liczba /= 2;
                }
                MessageBox.Show("Twoja liczba w zapisie binarnym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Jedenastkowy" && selected_item2 == "Binarny")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    
                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba < 0 || liczba > 10)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32( suma);
                while (liczba > 0)
                {
                    xd = (liczba % 2).ToString() + xd;
                    liczba /= 2;
                }
                MessageBox.Show("Twoja liczba w zapisie binarnym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;
                
            }
            if (selected_item == "Dwunastkowy" && selected_item2 == "Binarny")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    
                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if(liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba < 0 || liczba > 10)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(12, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 2).ToString() + xd;
                    liczba /= 2;
                }
                MessageBox.Show("Twoja liczba w zapisie binarnym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Trzynastkowy" && selected_item2 == "Binarny")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba < 0 || liczba > 10)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(13, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 2).ToString() + xd;
                    liczba /= 2;
                }
                MessageBox.Show("Twoja liczba w zapisie binarnym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Czternastkowy" && selected_item2 == "Binarny")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if(liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba < 0 || liczba > 10)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(14, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 2).ToString() + xd;
                    liczba /= 2;
                }
                MessageBox.Show("Twoja liczba w zapisie binarnym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Piętnastkowy" && selected_item2 == "Binarny")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if(liczba == 20)
                    {
                        liczba = 13;
                    }
                    if(liczba == 21)
                    {
                        liczba = 14;
                    }
                    if (liczba < 0 || liczba > 10)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(15, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 2).ToString() + xd;
                    liczba /= 2;
                }
                MessageBox.Show("Twoja liczba w zapisie binarnym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Szesnastkowy" && selected_item2 == "Binarny")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if(liczba == 20)
                    {
                        liczba = 13;
                    }
                    if(liczba == 21)
                    {
                        liczba = 14;
                    }
                    if(liczba == 22)
                    {
                        liczba = 15;
                    }
                    if (liczba < 0 || liczba > 10)
                    {
                        blad = true;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(16, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 2).ToString() + xd;
                    liczba /= 2;
                }
                MessageBox.Show("Twoja liczba w zapisie binarnym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if(selected_item == "Binarny" && selected_item2 == "Trójkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(2, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 3).ToString() + xd;
                    liczba /= 3;
                }
                MessageBox.Show("Twoja liczba w zapisie trójkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Czwórkowy" && selected_item2 == "Trójkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(4, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 3).ToString() + xd;
                    liczba /= 3;
                }
                MessageBox.Show("Twoja liczba w zapisie trójkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Piątkowy" && selected_item2 == "Trójkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(5, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 3).ToString() + xd;
                    liczba /= 3;
                }
                MessageBox.Show("Twoja liczba w zapisie trójkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Szóstkowy" && selected_item2 == "Trójkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(6, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 3).ToString() + xd;
                    liczba /= 3;
                }
                MessageBox.Show("Twoja liczba w zapisie trójkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Siódemkowy" && selected_item2 == "Trójkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(7, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 3).ToString() + xd;
                    liczba /= 3;
                }
                MessageBox.Show("Twoja liczba w zapisie trójkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Ósemkowy" && selected_item2 == "Trójkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(8, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 3).ToString() + xd;
                    liczba /= 3;
                }
                MessageBox.Show("Twoja liczba w zapisie trójkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziewiątkowy" && selected_item2 == "Trójkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(9, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 3).ToString() + xd;
                    liczba /= 3;
                }
                MessageBox.Show("Twoja liczba w zapisie trójkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziesiętny" && selected_item2 == "Trójkowy")
            {
                
                    liczba = Convert.ToInt32(line);
                string xd = "";

                while (liczba > 0)
                {
                    xd = (liczba % 3).ToString() + xd;
                    liczba /= 3;
                }
                MessageBox.Show("Twoja liczba w zapisie trójkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Jedenastkowy" && selected_item2 == "Trójkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 3).ToString() + xd;
                    liczba /= 3;
                }
                MessageBox.Show("Twoja liczba w zapisie trójkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Dwunastkowy" && selected_item2 == "Trójkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                   if(liczba == 18)
                    {
                        liczba = 11;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 3).ToString() + xd;
                    liczba /= 3;
                }
                MessageBox.Show("Twoja liczba w zapisie trójkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Trzynastkowy" && selected_item2 == "Trójkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if(liczba == 19)
                    {
                        liczba = 12;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 3).ToString() + xd;
                    liczba /= 3;
                }
                MessageBox.Show("Twoja liczba w zapisie trójkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Czternastkowy" && selected_item2 == "Trójkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if(liczba == 20)
                    {
                        liczba = 13;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 3).ToString() + xd;
                    liczba /= 3;
                }
                MessageBox.Show("Twoja liczba w zapisie trójkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Piętnastkowy" && selected_item2 == "Trójkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if(liczba == 21)
                    {
                        liczba = 14;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 3).ToString() + xd;
                    liczba /= 3;
                }
                MessageBox.Show("Twoja liczba w zapisie trójkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Szesnastkowy" && selected_item2 == "Trójkowy")        
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }
                    if (liczba == 22)
                    {
                        liczba = 15;
                    }
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 3).ToString() + xd;
                    liczba /= 3;
                }
                MessageBox.Show("Twoja liczba w zapisie trójkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }                                                                                       //na trójkowy KONIEC
            if (selected_item == "Binarny" && selected_item2 == "Czwórkowy")                        //na czwórkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(2, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 4).ToString() + xd;
                    liczba /= 4;
                }
                MessageBox.Show("Twoja liczba w zapisie czwórkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Trójkowy" && selected_item2 == "Czwórkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(3, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 4).ToString() + xd;
                    liczba /= 4;
                }
                MessageBox.Show("Twoja liczba w zapisie czwórkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Piątkowy" && selected_item2 == "Czwórkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(5, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 4).ToString() + xd;
                    liczba /= 4;
                }
                MessageBox.Show("Twoja liczba w zapisie czwórkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Szóstkowy" && selected_item2 == "Czwórkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(6, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 4).ToString() + xd;
                    liczba /= 4;
                }
                MessageBox.Show("Twoja liczba w zapisie czwórkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Siódemkowy" && selected_item2 == "Czwórkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(7, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 4).ToString() + xd;
                    liczba /= 4;
                }
                MessageBox.Show("Twoja liczba w zapisie czwórkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Ósemkowy" && selected_item2 == "Czwórkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(8, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 4).ToString() + xd;
                    liczba /= 4;
                }
                MessageBox.Show("Twoja liczba w zapisie czwórkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziewiątkowy" && selected_item2 == "Czwórkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(9, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 4).ToString() + xd;
                    liczba /= 4;
                }
                MessageBox.Show("Twoja liczba w zapisie czwórkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziesiętny" && selected_item2 == "Czwórkowy")         //zamiana dziesiętnego na binarny 
            {

                string xd = "";
                liczba = Convert.ToInt32(line);
                while (liczba > 0)
                {
                    xd = (liczba % 4).ToString() + xd;
                    liczba /= 4;
                }
                MessageBox.Show("Twoja liczba w zapisie czwórkowym to " + xd);
                liczba = 0;

            }
            if (selected_item == "Jedenastkowy" && selected_item2 == "Czwórkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 4).ToString() + xd;
                    liczba /= 4;
                }
                MessageBox.Show("Twoja liczba w zapisie czwórkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Dwunastkowy" && selected_item2 == "Czwórkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if(liczba == 18)
                    {
                        liczba = 11;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(12, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 4).ToString() + xd;
                    liczba /= 4;
                }
                MessageBox.Show("Twoja liczba w zapisie czwórkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Trzynastkowy" && selected_item2 == "Czwórkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(13, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 4).ToString() + xd;
                    liczba /= 4;
                }
                MessageBox.Show("Twoja liczba w zapisie czwórkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Czternastkowy" && selected_item2 == "Czwórkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(14, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 4).ToString() + xd;
                    liczba /= 4;
                }
                MessageBox.Show("Twoja liczba w zapisie czwórkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Piętnastkowy" && selected_item2 == "Czwórkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(15, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 4).ToString() + xd;
                    liczba /= 4;
                }
                MessageBox.Show("Twoja liczba w zapisie czwórkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Szesnastkowy" && selected_item2 == "Czwórkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }
                    if (liczba == 22)
                    {
                        liczba = 15;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(16, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 4).ToString() + xd;
                    liczba /= 4;
                }
                MessageBox.Show("Twoja liczba w zapisie czwórkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Binarny" && selected_item2 == "Piątkowy")                        //na Piątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(2, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 5).ToString() + xd;
                    liczba /= 5;
                }
                MessageBox.Show("Twoja liczba w zapisie  Piątkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Trójkowy" && selected_item2 == "Piątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(3, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 5).ToString() + xd;
                    liczba /= 5;
                }
                MessageBox.Show("Twoja liczba w zapisie Piątkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Czwórkowy" && selected_item2 == "Piątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(4, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 5).ToString() + xd;
                    liczba /= 5;
                }
                MessageBox.Show("Twoja liczba w zapisie Piątkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Szóstkowy" && selected_item2 == "Piątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(6, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 5).ToString() + xd;
                    liczba /= 5;
                }
                MessageBox.Show("Twoja liczba w zapisie Piątkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Siódemkowy" && selected_item2 == "Piątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(7, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 5).ToString() + xd;
                    liczba /= 5;
                }
                MessageBox.Show("Twoja liczba w zapisie Piątkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Ósemkowy" && selected_item2 == "Piątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(8, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 5).ToString() + xd;
                    liczba /= 5;
                }
                MessageBox.Show("Twoja liczba w zapisie Piątkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziewiątkowy" && selected_item2 == "Piątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(9, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 5).ToString() + xd;
                    liczba /= 5;
                }
                MessageBox.Show("Twoja liczba w zapisie Piątkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziesiętny" && selected_item2 == "Piątkowy")         //zamiana dziesiętnego na binarny 
            {

                string xd = "";
                liczba = Convert.ToInt32(line);
                while (liczba > 0)
                {
                    xd = (liczba % 5).ToString() + xd;
                    liczba /= 5;
                }
                MessageBox.Show("Twoja liczba w zapisie Piątkowym to " + xd);
                liczba = 0;

            }
            if (selected_item == "Jedenastkowy" && selected_item2 == "Piątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 5).ToString() + xd;
                    liczba /= 5;
                }
                MessageBox.Show("Twoja liczba w zapisie Piątkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Dwunastkowy" && selected_item2 == "Piątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(12, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 5).ToString() + xd;
                    liczba /= 5;
                }
                MessageBox.Show("Twoja liczba w zapisie Piątkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Trzynastkowy" && selected_item2 == "Piątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(13, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 5).ToString() + xd;
                    liczba /= 5;
                }
                MessageBox.Show("Twoja liczba w zapisie Piątkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Czternastkowy" && selected_item2 == "Piątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(14, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 5).ToString() + xd;
                    liczba /= 5;
                }
                MessageBox.Show("Twoja liczba w zapisie Piątkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Piętnastkowy" && selected_item2 == "Piątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(15, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 5).ToString() + xd;
                    liczba /= 5;
                }
                MessageBox.Show("Twoja liczba w zapisie Piątkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Szesnastkowy" && selected_item2 == "Piątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }
                    if (liczba == 22)
                    {
                        liczba = 15;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(16, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 5).ToString() + xd;
                    liczba /= 5;
                }
                MessageBox.Show("Twoja liczba w zapisie Piątkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Binarny" && selected_item2 == "Szóstkowy")                        //na Szóstkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(2, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 6).ToString() + xd;
                    liczba /= 6;
                }
                MessageBox.Show("Twoja liczba w zapisie  Szóstkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Trójkowy" && selected_item2 == "Szóstkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(3, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 6).ToString() + xd;
                    liczba /= 6;
                }
                MessageBox.Show("Twoja liczba w zapisie Szóstkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Czwórkowy" && selected_item2 == "Szóstkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(4, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 6).ToString() + xd;
                    liczba /= 6;
                }
                MessageBox.Show("Twoja liczba w zapisie Szóstkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Piątkowy" && selected_item2 == "Szóstkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(5, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 6).ToString() + xd;
                    liczba /= 6;
                }
                MessageBox.Show("Twoja liczba w zapisie Szóstkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Siódemkowy" && selected_item2 == "Szóstkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(7, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 6).ToString() + xd;
                    liczba /= 6;
                }
                MessageBox.Show("Twoja liczba w zapisie Szóstkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Ósemkowy" && selected_item2 == "Szóstkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(8, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 6).ToString() + xd;
                    liczba /= 6;
                }
                MessageBox.Show("Twoja liczba w zapisie Szóstkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziewiątkowy" && selected_item2 == "Szóstkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(9, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 6).ToString() + xd;
                    liczba /= 6;
                }
                MessageBox.Show("Twoja liczba w zapisie Szóstkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziesiętny" && selected_item2 == "Szóstkowy")         //zamiana dziesiętnego na binarny 
            {

                string xd = "";
                liczba = Convert.ToInt32(line);
                while (liczba > 0)
                {
                    xd = (liczba % 6).ToString() + xd;
                    liczba /= 6;
                }
                MessageBox.Show("Twoja liczba w zapisie Szóstkowym to " + xd);
                liczba = 0;

            }
            if (selected_item == "Jedenastkowy" && selected_item2 == "Szóstkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 6).ToString() + xd;
                    liczba /= 6;
                }
                MessageBox.Show("Twoja liczba w zapisie Szóstkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Dwunastkowy" && selected_item2 == "Szóstkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(12, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 6).ToString() + xd;
                    liczba /= 6;
                }
                MessageBox.Show("Twoja liczba w zapisie Szóstkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Trzynastkowy" && selected_item2 == "Szóstkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(13, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 6).ToString() + xd;
                    liczba /= 6;
                }
                MessageBox.Show("Twoja liczba w zapisie Szóstkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Czternastkowy" && selected_item2 == "Szóstkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(14, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 6).ToString() + xd;
                    liczba /= 6;
                }
                MessageBox.Show("Twoja liczba w zapisie Szóstkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Piętnastkowy" && selected_item2 == "Szóstkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(15, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 6).ToString() + xd;
                    liczba /= 6;
                }
                MessageBox.Show("Twoja liczba w zapisie Szóstkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Szesnastkowy" && selected_item2 == "Szóstkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }
                    if (liczba == 22)
                    {
                        liczba = 15;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(16, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 6).ToString() + xd;
                    liczba /= 6;
                }
                MessageBox.Show("Twoja liczba w zapisie Szóstkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Binarny" && selected_item2 == "Siódemkowy")                        //na Siódemkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(2, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 7).ToString() + xd;
                    liczba /= 7;
                }
                MessageBox.Show("Twoja liczba w zapisie  Siódemkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Trójkowy" && selected_item2 == "Siódemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(3, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 7).ToString() + xd;
                    liczba /= 7;
                }
                MessageBox.Show("Twoja liczba w zapisie Siódemkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Czwórkowy" && selected_item2 == "Siódemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(4, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 7).ToString() + xd;
                    liczba /= 7;
                }
                MessageBox.Show("Twoja liczba w zapisie Siódemkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Piątkowy" && selected_item2 == "Siódemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(5, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 7).ToString() + xd;
                    liczba /= 7;
                }
                MessageBox.Show("Twoja liczba w zapisie Siódemkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Szóstkowy" && selected_item2 == "Siódemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(6, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 7).ToString() + xd;
                    liczba /= 7;
                }
                MessageBox.Show("Twoja liczba w zapisie Siódemkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Ósemkowy" && selected_item2 == "Siódemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(8, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 7).ToString() + xd;
                    liczba /= 7;
                }
                MessageBox.Show("Twoja liczba w zapisie Siódemkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziewiątkowy" && selected_item2 == "Siódemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(9, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 7).ToString() + xd;
                    liczba /= 7;
                }
                MessageBox.Show("Twoja liczba w zapisie Siódemkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziesiętny" && selected_item2 == "Siódemkowy")         //zamiana dziesiętnego na binarny 
            {

                string xd = "";
                liczba = Convert.ToInt32(line);
                while (liczba > 0)
                {
                    xd = (liczba % 7).ToString() + xd;
                    liczba /= 7;
                }
                MessageBox.Show("Twoja liczba w zapisie Siódemkowym to " + xd);
                liczba = 0;

            }
            if (selected_item == "Jedenastkowy" && selected_item2 == "Siódemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 7).ToString() + xd;
                    liczba /= 7;
                }
                MessageBox.Show("Twoja liczba w zapisie Siódemkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Dwunastkowy" && selected_item2 == "Siódemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(12, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 7).ToString() + xd;
                    liczba /= 7;
                }
                MessageBox.Show("Twoja liczba w zapisie Siódemkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Trzynastkowy" && selected_item2 == "Siódemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(13, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 7).ToString() + xd;
                    liczba /= 7;
                }
                MessageBox.Show("Twoja liczba w zapisie Siódemkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Czternastkowy" && selected_item2 == "Siódemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(14, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 7).ToString() + xd;
                    liczba /= 7;
                }
                MessageBox.Show("Twoja liczba w zapisie Siódemkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Piętnastkowy" && selected_item2 == "Siódemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(15, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 7).ToString() + xd;
                    liczba /= 7;
                }
                MessageBox.Show("Twoja liczba w zapisie Siódemkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Szesnastkowy" && selected_item2 == "Siódemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }
                    if (liczba == 22)
                    {
                        liczba = 15;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(16, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 7).ToString() + xd;
                    liczba /= 7;
                }
                MessageBox.Show("Twoja liczba w zapisie Siódemkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Binarny" && selected_item2 == "Ósemkowy")                        //na Ósemkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(2, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 8).ToString() + xd;
                    liczba /= 8;
                }
                MessageBox.Show("Twoja liczba w zapisie  Ósemkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Trójkowy" && selected_item2 == "Ósemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(3, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 8).ToString() + xd;
                    liczba /= 8;
                }
                MessageBox.Show("Twoja liczba w zapisie Ósemkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Czwórkowy" && selected_item2 == "Ósemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(4, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 8).ToString() + xd;
                    liczba /= 8;
                }
                MessageBox.Show("Twoja liczba w zapisie Ósemkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Piątkowy" && selected_item2 == "Ósemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(5, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 8).ToString() + xd;
                    liczba /= 8;
                }
                MessageBox.Show("Twoja liczba w zapisie Ósemkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Szóstkowy" && selected_item2 == "Ósemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(6, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 8).ToString() + xd;
                    liczba /= 8;
                }
                MessageBox.Show("Twoja liczba w zapisie Ósemkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Siódemkowy" && selected_item2 == "Ósemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(7, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 8).ToString() + xd;
                    liczba /= 8;
                }
                MessageBox.Show("Twoja liczba w zapisie Ósemkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziewiątkowy" && selected_item2 == "Ósemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(9, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 8).ToString() + xd;
                    liczba /= 8;
                }
                MessageBox.Show("Twoja liczba w zapisie Ósemkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziesiętny" && selected_item2 == "Ósemkowy")         //zamiana dziesiętnego na binarny 
            {

                string xd = "";
                liczba = Convert.ToInt32(line);
                while (liczba > 0)
                {
                    xd = (liczba % 8).ToString() + xd;
                    liczba /= 8;
                }
                MessageBox.Show("Twoja liczba w zapisie Ósemkowym to " + xd);
                liczba = 0;

            }
            if (selected_item == "Jedenastkowy" && selected_item2 == "Ósemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 8).ToString() + xd;
                    liczba /= 8;
                }
                MessageBox.Show("Twoja liczba w zapisie Ósemkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Dwunastkowy" && selected_item2 == "Ósemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(12, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 8).ToString() + xd;
                    liczba /= 8;
                }
                MessageBox.Show("Twoja liczba w zapisie Ósemkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Trzynastkowy" && selected_item2 == "Ósemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(13, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 8).ToString() + xd;
                    liczba /= 8;
                }
                MessageBox.Show("Twoja liczba w zapisie Ósemkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Czternastkowy" && selected_item2 == "Ósemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(14, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 8).ToString() + xd;
                    liczba /= 8;
                }
                MessageBox.Show("Twoja liczba w zapisie Ósemkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Piętnastkowy" && selected_item2 == "Ósemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(15, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 8).ToString() + xd;
                    liczba /= 8;
                }
                MessageBox.Show("Twoja liczba w zapisie Ósemkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Szesnastkowy" && selected_item2 == "Ósemkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }
                    if (liczba == 22)
                    {
                        liczba = 15;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(16, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 8).ToString() + xd;
                    liczba /= 8;
                }
                MessageBox.Show("Twoja liczba w zapisie Ósemkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Binarny" && selected_item2 == "Dziewiątkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(2, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 9).ToString() + xd;
                    liczba /= 9;
                }
                MessageBox.Show("Twoja liczba w zapisie  Dziewiątkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Trójkowy" && selected_item2 == "Dziewiątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(3, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 9).ToString() + xd;
                    liczba /= 9;
                }
                MessageBox.Show("Twoja liczba w zapisie Dziewiątkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Czwórkowy" && selected_item2 == "Dziewiątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(4, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 9).ToString() + xd;
                    liczba /= 9;
                }
                MessageBox.Show("Twoja liczba w zapisie Dziewiątkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Piątkowy" && selected_item2 == "Dziewiątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(5, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 9).ToString() + xd;
                    liczba /= 9;
                }
                MessageBox.Show("Twoja liczba w zapisie Dziewiątkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Szóstkowy" && selected_item2 == "Dziewiątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(6, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 9).ToString() + xd;
                    liczba /= 9;
                }
                MessageBox.Show("Twoja liczba w zapisie Dziewiątkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Siódemkowy" && selected_item2 == "Dziewiątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(7, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 9).ToString() + xd;
                    liczba /= 9;
                }
                MessageBox.Show("Twoja liczba w zapisie Dziewiątkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Ósemkowy" && selected_item2 == "Dziewiątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(8, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    xd = (liczba % 9).ToString() + xd;
                    liczba /= 9;
                }
                MessageBox.Show("Twoja liczba w zapisie Dziewiątkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziesiętny" && selected_item2 == "Dziewiątkowy")         //zamiana dziesiętnego na binarny 
            {

                string xd = "";
                liczba = Convert.ToInt32(line);
                while (liczba > 0)
                {
                    xd = (liczba % 9).ToString() + xd;
                    liczba /= 9;
                }
                MessageBox.Show("Twoja liczba w zapisie Dziewiątkowym to " + xd);
                liczba = 0;

            }
            if (selected_item == "Jedenastkowy" && selected_item2 == "Dziewiątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 9).ToString() + xd;
                    liczba /= 9;
                }
                MessageBox.Show("Twoja liczba w zapisie Dziewiątkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Dwunastkowy" && selected_item2 == "Dziewiątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(12, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 9).ToString() + xd;
                    liczba /= 9;
                }
                MessageBox.Show("Twoja liczba w zapisie Dziewiątkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Trzynastkowy" && selected_item2 == "Dziewiątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(13, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 9).ToString() + xd;
                    liczba /= 9;
                }
                MessageBox.Show("Twoja liczba w zapisie Dziewiątkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Czternastkowy" && selected_item2 == "Dziewiątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(14, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 9).ToString() + xd;
                    liczba /= 9;
                }
                MessageBox.Show("Twoja liczba w zapisie Dziewiątkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Piętnastkowy" && selected_item2 == "Dziewiątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(15, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 9).ToString() + xd;
                    liczba /= 9;
                }
                MessageBox.Show("Twoja liczba w zapisie Dziewiątkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Szesnastkowy" && selected_item2 == "Dziewiątkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }
                    if (liczba == 22)
                    {
                        liczba = 15;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(16, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    xd = (liczba % 9).ToString() + xd;
                    liczba /= 9;
                }
                MessageBox.Show("Twoja liczba w zapisie Dziewiątkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
//na jedenastkowy START
            if (selected_item == "Dwójkowy" && selected_item2 == "Jedenastkowy")                 
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(2, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 11 > 9)
                    {
                        if (liczba % 11 == 10)
                        {
                            xd = "A" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 11).ToString() + xd;

                    }
                    liczba /= 11;

                }
                MessageBox.Show("Twoja liczba w zapisie  jedenastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Trójkowy" && selected_item2 == "Jedenastkowy")                        
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(3, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 11 > 9)
                    {
                        if (liczba % 11 == 10)
                        {
                            xd = "A" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 11).ToString() + xd;

                    }
                    liczba /= 11;

                }
                MessageBox.Show("Twoja liczba w zapisie  jedenastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Czwórkowy" && selected_item2 == "Jedenastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(4, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 11 > 9)
                    {
                        if (liczba % 11 == 10)
                        {
                            xd = "A" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 11).ToString() + xd;

                    }
                    liczba /= 11;

                }
                MessageBox.Show("Twoja liczba w zapisie  jedenastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Piątkowy" && selected_item2 == "Jedenastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(5, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 11 > 9)
                    {
                        if (liczba % 11 == 10)
                        {
                            xd = "A" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 11).ToString() + xd;

                    }
                    liczba /= 11;

                }
                MessageBox.Show("Twoja liczba w zapisie  jedenastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Szóstkowy" && selected_item2 == "Jedenastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(6, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 11 > 9)
                    {
                        if (liczba % 11 == 10)
                        {
                            xd = "A" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 11).ToString() + xd;

                    }
                    liczba /= 11;

                }
                MessageBox.Show("Twoja liczba w zapisie  jedenastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Siódemkowy" && selected_item2 == "Jedenastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(7, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 11 > 9)
                    {
                        if (liczba % 11 == 10)
                        {
                            xd = "A" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 11).ToString() + xd;

                    }
                    liczba /= 11;

                }
                MessageBox.Show("Twoja liczba w zapisie  jedenastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Ósemkowy" && selected_item2 == "Jedenastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(8, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 11 > 9)
                    {
                        if (liczba % 11 == 10)
                        {
                            xd = "A" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 11).ToString() + xd;

                    }
                    liczba /= 11;

                }
                MessageBox.Show("Twoja liczba w zapisie  jedenastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziewiątkowy" && selected_item2 == "Jedenastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(9, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 11 > 9)
                    {
                        if (liczba % 11 == 10)
                        {
                            xd = "A" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 11).ToString() + xd;

                    }
                    liczba /= 11;

                }
                MessageBox.Show("Twoja liczba w zapisie  jedenastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziesiętny" && selected_item2 == "Jedenastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                liczba = Convert.ToInt32(line);
                while (liczba > 0)
                {
                    if (liczba % 11 > 9)
                    {
                        if (liczba % 11 == 10)
                        {
                            xd = "A" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 11).ToString() + xd;
                    }
                    liczba /= 11;
                }

                MessageBox.Show("Twoja liczba w zapisie  jedenastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dwunastkowy" && selected_item2 == "Jedenastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(12, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 11 > 9)
                    {
                        if (liczba % 11 == 10)
                        {
                            xd = "A" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 11).ToString() + xd;
                    }
                    liczba /= 11;
                }
                MessageBox.Show("Twoja liczba w zapisie jedenastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Trzynastkowy" && selected_item2 == "Jedenastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if(liczba == 19)
                    {
                        liczba = 12;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(13, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 11 > 9)
                    {
                        if (liczba % 11 == 10)
                        {
                            xd = "A" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 11).ToString() + xd;
                    }
                    liczba /= 11;
                }
                MessageBox.Show("Twoja liczba w zapisie jedenastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Czternastkowy" && selected_item2 == "Jedenastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if(liczba == 20)
                    {
                        liczba = 13;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(14, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 11 > 9)
                    {
                        if (liczba % 11 == 10)
                        {
                            xd = "A" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 11).ToString() + xd;
                    }
                    liczba /= 11;
                }
                MessageBox.Show("Twoja liczba w zapisie jedenastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Piętnastkowy" && selected_item2 == "Jedenastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if(liczba == 21)
                    {
                        liczba = 14;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(15, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 11 > 9)
                    {
                        if (liczba % 11 == 10)
                        {
                            xd = "A" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 11).ToString() + xd;
                    }
                    liczba /= 11;
                }
                MessageBox.Show("Twoja liczba w zapisie jedenastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Szesnastkowy" && selected_item2 == "Jedenastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }
                    if(liczba == 22)
                    {
                        liczba = 15;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(16, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 11 > 9)
                    {
                        if (liczba % 11 == 10)
                        {
                            xd = "A" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 11).ToString() + xd;
                    }
                    liczba /= 11;
                }
                MessageBox.Show("Twoja liczba w zapisie jedenastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            // ZAMIANA NA DWUNASTKOWY START
            if (selected_item == "Dwójkowy" && selected_item2 == "Dwunastkowy")                 
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(2, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 12 > 9)
                    {
                        if (liczba % 12 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 12 == 11)
                        {
                            xd = "B" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 12).ToString() + xd;

                    }
                    liczba /= 12;

                }
                MessageBox.Show("Twoja liczba w zapisie  Dwunastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Trójkowy" && selected_item2 == "Dwunastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(3, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 12 > 9)
                    {
                        if (liczba % 12 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 12 == 11)
                        {
                            xd = "B" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 12).ToString() + xd;

                    }
                    liczba /= 12;

                }
                MessageBox.Show("Twoja liczba w zapisie  Dwunastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Czwórkowy" && selected_item2 == "Dwunastkowy")                        
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(4, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 12 > 9)
                    {
                        if (liczba % 12 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 12 == 11)
                        {
                            xd = "B" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 12).ToString() + xd;

                    }
                    liczba /= 12;

                }
                MessageBox.Show("Twoja liczba w zapisie  Dwunastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Piątkowy" && selected_item2 == "Dwunastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(5, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 12 > 9)
                    {
                        if (liczba % 12 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 12 == 11)
                        {
                            xd = "B" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 12).ToString() + xd;

                    }
                    liczba /= 12;

                }
                MessageBox.Show("Twoja liczba w zapisie  Dwunastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Szóstkowy" && selected_item2 == "Dwunastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(6, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 12 > 9)
                    {
                        if (liczba % 12 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 12 == 11)
                        {
                            xd = "B" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 12).ToString() + xd;

                    }
                    liczba /= 12;

                }
                MessageBox.Show("Twoja liczba w zapisie  Dwunastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Siódemkowy" && selected_item2 == "Dwunastkowy")                        
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(7, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 12 > 9)
                    {
                        if (liczba % 12 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 12 == 11)
                        {
                            xd = "B" + xd;
                        }

                    }
                    else
                    {
                        xd = (liczba % 12).ToString() + xd;

                    }
                    liczba /= 12;

                }
                MessageBox.Show("Twoja liczba w zapisie  Dwunastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Ósemkowy" && selected_item2 == "Dwunastkowy")                        
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(8, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 12 > 9)
                    {
                        if (liczba % 12 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 12 == 11)
                        {
                            xd = "B" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 12).ToString() + xd;

                    }
                    liczba /= 12;

                }
                MessageBox.Show("Twoja liczba w zapisie  Dwunastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziewiątkowy" && selected_item2 == "Dwunastkowy")                        
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(9, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 12 > 9)
                    {
                        if (liczba % 12 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 12 == 11)
                        {
                            xd = "B" + xd;
                        }

                    }
                    else
                    {
                        xd = (liczba % 12).ToString() + xd;

                    }
                    liczba /= 12;

                }
                MessageBox.Show("Twoja liczba w zapisie  Dwunastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziesiętny" && selected_item2 == "Dwunastkowy")                       
            {
                string xd = "";
                liczba = Convert.ToInt32(line);
                while (liczba > 0)
                {
                    if (liczba % 12 > 9)
                    {
                        if (liczba % 12 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 12 == 11)
                        {
                            xd = "B" + xd;
                        }

                    }
                    else
                    {
                        xd = (liczba % 12).ToString() + xd;
                    }
                    liczba /= 12;
                }

                MessageBox.Show("Twoja liczba w zapisie  Dwunastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Jedenastkowy" && selected_item2 == "Dwunastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 12 > 9)
                    {
                        if (liczba % 12 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 12 == 11)
                        {
                            xd = "B" + xd;
                        }

                    }
                    else
                    {
                        xd = (liczba % 12).ToString() + xd;
                    }
                    liczba /= 12;
                }
                MessageBox.Show("Twoja liczba w zapisie Dwunastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Trzynastkowy" && selected_item2 == "Dwunastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(13, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 12 > 9)
                    {
                        if (liczba % 12 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 12 == 11)
                        {
                            xd = "B" + xd;
                        }

                    }
                    else
                    {
                        xd = (liczba % 12).ToString() + xd;
                    }
                    liczba /= 12;
                }
                MessageBox.Show("Twoja liczba w zapisie Dwunastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Czternastkowy" && selected_item2 == "Dwunastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(14, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 12 > 9)
                    {
                        if (liczba % 12 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 12 == 11)
                        {
                            xd = "B" + xd;
                        }

                    }
                    else
                    {
                        xd = (liczba % 12).ToString() + xd;
                    }
                    liczba /= 12;
                }
                MessageBox.Show("Twoja liczba w zapisie Dwunastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Piętnastkowy" && selected_item2 == "Dwunastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(15, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 12 > 9)
                    {
                        if (liczba % 12 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 12 == 11)
                        {
                            xd = "B" + xd;
                        }

                    }
                    else
                    {
                        xd = (liczba % 12).ToString() + xd;
                    }
                    liczba /= 12;
                }
                MessageBox.Show("Twoja liczba w zapisie Dwunastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Szesnastkowy" && selected_item2 == "Dwunastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }
                    if (liczba == 22)
                    {
                        liczba = 15;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(16, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 12 > 9)
                    {
                        if (liczba % 12 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 12 == 11)
                        {
                            xd = "B" + xd;
                        }
                        
                    }
                    else
                    {
                        xd = (liczba % 12).ToString() + xd;
                    }
                    liczba /= 12;
                }
                MessageBox.Show("Twoja liczba w zapisie Dwunastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            //zamiana na trzynastkowy START
            if (selected_item == "Dwójkowy" && selected_item2 == "Trzynastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(2, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 13 > 9)
                    {
                        if (liczba % 13 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 13 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 13 == 12)
                        {
                            xd = "C" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 13).ToString() + xd;

                    }
                    liczba /= 13;

                }
                MessageBox.Show("Twoja liczba w zapisie  Trzynastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Trójkowy" && selected_item2 == "Trzynastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(3, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 13 > 9)
                    {
                        if (liczba % 13 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 13 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 13 == 12)
                        {
                            xd = "C" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 13).ToString() + xd;

                    }
                    liczba /= 13;

                }
                MessageBox.Show("Twoja liczba w zapisie  Trzynastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Czwórkowy" && selected_item2 == "Trzynastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(4, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 13 > 9)
                    {
                        if (liczba % 13 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 13 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 13 == 12)
                        {
                            xd = "C" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 13).ToString() + xd;

                    }
                    liczba /= 13;

                }
                MessageBox.Show("Twoja liczba w zapisie  Trzynastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Piątkowy" && selected_item2 == "Trzynastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(5, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 13 > 9)
                    {
                        if (liczba % 13 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 13 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 13 == 12)
                        {
                            xd = "C" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 13).ToString() + xd;

                    }
                    liczba /= 13;

                }
                MessageBox.Show("Twoja liczba w zapisie  Trzynastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Szóstkowy" && selected_item2 == "Trzynastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(6, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 13 > 9)
                    {
                        if (liczba % 13 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 13 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 13 == 12)
                        {
                            xd = "C" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 13).ToString() + xd;

                    }
                    liczba /= 13;

                }
                MessageBox.Show("Twoja liczba w zapisie  Trzynastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Siódemkowy" && selected_item2 == "Trzynastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(7, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 13 > 9)
                    {
                        if (liczba % 13 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 13 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 13 == 12)
                        {
                            xd = "C" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 13).ToString() + xd;

                    }
                    liczba /= 13;

                }
                MessageBox.Show("Twoja liczba w zapisie  Trzynastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Ósemkowy" && selected_item2 == "Trzynastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(8, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 13 > 9)
                    {
                        if (liczba % 13 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 13 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 13 == 12)
                        {
                            xd = "C" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 13).ToString() + xd;

                    }
                    liczba /= 13;

                }
                MessageBox.Show("Twoja liczba w zapisie  Trzynastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziewiątkowy" && selected_item2 == "Trzynastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(9, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 13 > 9)
                    {
                        if (liczba % 13 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 13 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 13 == 12)
                        {
                            xd = "C" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 13).ToString() + xd;

                    }
                    liczba /= 13;

                }
                MessageBox.Show("Twoja liczba w zapisie  Trzynastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziesiętny" && selected_item2 == "Trzynastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                liczba = Convert.ToInt32(line);
                while (liczba > 0)
                {
                    if (liczba % 13 > 9)
                    {
                        if (liczba % 13 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 13 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 13 == 12)
                        {
                            xd = "C" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 13).ToString() + xd;
                    }
                    liczba /= 13;
                }

                MessageBox.Show("Twoja liczba w zapisie  Trzynastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Jedenastkowy" && selected_item2 == "Trzynastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                   

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 13 > 9)
                    {
                        if (liczba % 13 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 13 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 13 == 12)
                        {
                            xd = "C" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 13).ToString() + xd;
                    }
                    liczba /= 13;
                }
                MessageBox.Show("Twoja liczba w zapisie Trzynastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Dwunastkowy" && selected_item2 == "Trzynastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(12, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 13 > 9)
                    {
                        if (liczba % 13 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 13 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 13 == 12)
                        {
                            xd = "C" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 13).ToString() + xd;
                    }
                    liczba /= 13;
                }
                MessageBox.Show("Twoja liczba w zapisie Trzynastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Czternastkowy" && selected_item2 == "Trzynastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(14, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 13 > 9)
                    {
                        if (liczba % 13 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 13 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 13 == 12)
                        {
                            xd = "C" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 13).ToString() + xd;
                    }
                    liczba /= 13;
                }
                MessageBox.Show("Twoja liczba w zapisie Trzynastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Piętnastkowy" && selected_item2 == "Trzynastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(15, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 13 > 9)
                    {
                    
                        if (liczba % 13 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 13 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 13 == 12)
                        {
                            xd = "C" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 13).ToString() + xd;
                    }
                    liczba /= 13;
                }
                MessageBox.Show("Twoja liczba w zapisie Trzynastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Szesnastkowy" && selected_item2 == "Trzynastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }
                    if (liczba == 22)
                    {
                        liczba = 15;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(16, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 13 > 9)
                    {
                        if (liczba % 13 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 13 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 13 == 12)
                        {
                            xd = "C" + xd;
                        }

                    }
                    else
                    {
                        xd = (liczba % 13).ToString() + xd;
                    }
                    liczba /= 13;
                }
                MessageBox.Show("Twoja liczba w zapisie Trzynastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            //zamiana na czternastkowy START
            if (selected_item == "Dwójkowy" && selected_item2 == "Czternastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(2, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 14 > 9)
                    {
                        if (liczba % 14 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 14 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 14 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 14 == 13)
                        {
                            xd = "D" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 14).ToString() + xd;

                    }
                    liczba /= 14;
                }
                MessageBox.Show("Twoja liczba w zapisie  Czternastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Trójkowy" && selected_item2 == "Czternastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(3, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 14 > 9)
                    {
                        if (liczba % 14 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 14 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 14 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 14 == 13)
                        {
                            xd = "D" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 14).ToString() + xd;

                    }
                    liczba /= 14;
                }
                MessageBox.Show("Twoja liczba w zapisie  Czternastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Czwórkowy" && selected_item2 == "Czternastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(4, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 14 > 9)
                    {
                        if (liczba % 14 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 14 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 14 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 14 == 13)
                        {
                            xd = "D" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 14).ToString() + xd;

                    }
                    liczba /= 14;
                }
                MessageBox.Show("Twoja liczba w zapisie  Czternastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Piątkowy" && selected_item2 == "Czternastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(5, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 14 > 9)
                    {
                        if (liczba % 14 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 14 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 14 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 14 == 13)
                        {
                            xd = "D" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 14).ToString() + xd;

                    }
                    liczba /= 14;
                }
                MessageBox.Show("Twoja liczba w zapisie  Czternastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Szóstkowy" && selected_item2 == "Czternastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(6, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 14 > 9)
                    {
                        if (liczba % 14 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 14 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 14 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 14 == 13)
                        {
                            xd = "D" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 14).ToString() + xd;

                    }
                    liczba /= 14;
                }
                MessageBox.Show("Twoja liczba w zapisie  Czternastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Siódemkowy" && selected_item2 == "Czternastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(7, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 14 > 9)
                    {
                        if (liczba % 14 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 14 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 14 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 14 == 13)
                        {
                            xd = "D" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 14).ToString() + xd;

                    }
                    liczba /= 14;
                }
                MessageBox.Show("Twoja liczba w zapisie  Czternastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Ósemkowy" && selected_item2 == "Czternastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(8, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 14 > 9)
                    {
                        if (liczba % 14 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 14 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 14 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 14 == 13)
                        {
                            xd = "D" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 14).ToString() + xd;

                    }
                    liczba /= 14;
                }
                MessageBox.Show("Twoja liczba w zapisie  Czternastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziewiątkowy" && selected_item2 == "Czternastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(9, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 14 > 9)
                    {
                        if (liczba % 14 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 14 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 14 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 14 == 13)
                        {
                            xd = "D" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 14).ToString() + xd;

                    }
                    liczba /= 14;
                }
                MessageBox.Show("Twoja liczba w zapisie  Czternastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziesiętny" && selected_item2 == "Czternastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                liczba = Convert.ToInt32(line);
                while (liczba > 0)
                {
                    if (liczba % 14 > 9)
                    {
                        if (liczba % 14 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 14 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 14 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 14 == 13)
                        {
                            xd = "D" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 14).ToString() + xd;
                    }
                    liczba /= 14;
                }

                MessageBox.Show("Twoja liczba w zapisie  Czternastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Jedenastkowy" && selected_item2 == "Czternastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 14 > 9)
                    {
                        if (liczba % 14 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 14 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 14 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 14 == 13)
                        {
                            xd = "D" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 14).ToString() + xd;
                    }
                    liczba /= 14;
                }
                MessageBox.Show("Twoja liczba w zapisie Czternastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Dwunastkowy" && selected_item2 == "Czternastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                   

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(12, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 14 > 9)
                    {
                        if (liczba % 14 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 14 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 14 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 14 == 13)
                        {
                            xd = "D" + xd;
                        }

                    }
                    else
                    {
                        xd = (liczba % 14).ToString() + xd;
                    }
                    liczba /= 14;
                }
                MessageBox.Show("Twoja liczba w zapisie Czternastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Trzynastkowy" && selected_item2 == "Czternastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                   

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(13, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 14 > 9)
                    {
                        if (liczba % 14 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 14 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 14 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 14 == 13)
                        {
                            xd = "D" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 14).ToString() + xd;
                    }
                    liczba /= 14;
                }
                MessageBox.Show("Twoja liczba w zapisie Czternastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Piętnastkowy" && selected_item2 == "Czternastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(15, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 14 > 9)
                    {
                        if (liczba % 14 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 14 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 14 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 14 == 13)
                        {
                            xd = "D" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 14).ToString() + xd;
                    }
                    liczba /= 14;
                }
                MessageBox.Show("Twoja liczba w zapisie Czternastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Szesnastkowy" && selected_item2 == "Czternastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }
                    if (liczba == 22)
                    {
                        liczba = 15;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(16, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 14 > 9)
                    {
                        if (liczba % 14 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 14 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 14 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 14 == 13)
                        {
                            xd = "D" + xd;
                        }

                    }
                    else
                    {
                        xd = (liczba % 14).ToString() + xd;
                    }
                    liczba /= 14;
                }
                MessageBox.Show("Twoja liczba w zapisie Czternastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            //zamiana na piętnastkowy START
            if (selected_item == "Dwójkowy" && selected_item2 == "Piętnastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(2, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 15 > 9)
                    {
                        if (liczba % 15 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 15 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 15 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 15 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 15 == 14)
                        {
                            xd = "E" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 15).ToString() + xd;

                    }
                    liczba /= 15;

                }
                MessageBox.Show("Twoja liczba w zapisie  Piętnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Trójkowy" && selected_item2 == "Piętnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(3, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 15 > 9)
                    {
                        if (liczba % 15 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 15 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 15 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 15 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 15 == 14)
                        {
                            xd = "E" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 15).ToString() + xd;

                    }
                    liczba /= 15;

                }
                MessageBox.Show("Twoja liczba w zapisie  Piętnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Czwórkowy" && selected_item2 == "Piętnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(4, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 15 > 9)
                    {
                        if (liczba % 15 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 15 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 15 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 15 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 15 == 14)
                        {
                            xd = "E" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 15).ToString() + xd;

                    }
                    liczba /= 15;

                }
                MessageBox.Show("Twoja liczba w zapisie  Piętnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Piątkowy" && selected_item2 == "Piętnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(5, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 15 > 9)
                    {
                        if (liczba % 15 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 15 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 15 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 15 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 15 == 14)
                        {
                            xd = "E" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 15).ToString() + xd;

                    }
                    liczba /= 15;

                }
                MessageBox.Show("Twoja liczba w zapisie  Piętnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Szóstkowy" && selected_item2 == "Piętnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(6, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 15 > 9)
                    {
                        if (liczba % 15 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 15 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 15 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 15 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 15 == 14)
                        {
                            xd = "E" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 15).ToString() + xd;

                    }
                    liczba /= 15;

                }
                MessageBox.Show("Twoja liczba w zapisie  Piętnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Siódemkowy" && selected_item2 == "Piętnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(7, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 15 > 9)
                    {
                        if (liczba % 15 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 15 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 15 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 15 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 15 == 14)
                        {
                            xd = "E" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 15).ToString() + xd;

                    }
                    liczba /= 15;

                }
                MessageBox.Show("Twoja liczba w zapisie  Piętnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Ósemkowy" && selected_item2 == "Piętnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(8, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 15 > 9)
                    {
                        if (liczba % 15 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 15 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 15 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 15 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 15 == 14)
                        {
                            xd = "E" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 15).ToString() + xd;

                    }
                    liczba /= 15;

                }
                MessageBox.Show("Twoja liczba w zapisie  Piętnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziewiątkowy" && selected_item2 == "Piętnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(9, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 15 > 9)
                    {
                        if (liczba % 15 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 15 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 15 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 15 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 15 == 14)
                        {
                            xd = "E" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 15).ToString() + xd;

                    }
                    liczba /= 15;

                }
                MessageBox.Show("Twoja liczba w zapisie  Piętnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziesiętny" && selected_item2 == "Piętnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                liczba = Convert.ToInt32(line);
                while (liczba > 0)
                {
                    if (liczba % 15 > 9)
                    {
                        if (liczba % 15 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 15 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 15 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 15 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 15 == 14)
                        {
                            xd = "E" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 15).ToString() + xd;
                    }
                    liczba /= 15;
                }

                MessageBox.Show("Twoja liczba w zapisie  Piętnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Jedenastkowy" && selected_item2 == "Piętnastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 15 > 9)
                    {
                        if (liczba % 15 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 15 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 15 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 15 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 15 == 14)
                        {
                            xd = "E" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 15).ToString() + xd;
                    }
                    liczba /= 15;
                }
                MessageBox.Show("Twoja liczba w zapisie Piętnastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Dwunastkowy" && selected_item2 == "Piętnastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(12, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 15 > 9)
                    {
                        if (liczba % 15 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 15 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 15 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 15 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 15 == 14)
                        {
                            xd = "E" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 15).ToString() + xd;
                    }
                    liczba /= 15;
                }
                MessageBox.Show("Twoja liczba w zapisie Piętnastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Trzynastkowy" && selected_item2 == "Piętnastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)

                        suma += (Convert.ToDouble(liczba) * (Math.Pow(13, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 15 > 9)
                    {
                        if (liczba % 15 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 15 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 15 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 15 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 15 == 14)
                        {
                            xd = "E" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 15).ToString() + xd;
                    }
                    liczba /= 15;
                }
                MessageBox.Show("Twoja liczba w zapisie Piętnastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Czternastkowy" && selected_item2 == "Piętnastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    

                        suma += (Convert.ToDouble(liczba) * (Math.Pow(14, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 15 > 9)
                    {
                        if (liczba % 15 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 15 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 15 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 15 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 15 == 14)
                        {
                            xd = "E" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 15).ToString() + xd;
                    }
                    liczba /= 15;
                }
                MessageBox.Show("Twoja liczba w zapisie Piętnastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Szesnastkowy" && selected_item2 == "Piętnastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }
                    if (liczba == 22)
                    {
                        liczba = 15;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(16, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 15 > 9)
                    {
                        if (liczba % 15 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 15 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 15 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 15 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 15 == 14)
                        {
                            xd = "E" + xd;
                        }

                    }
                    else
                    {
                        xd = (liczba % 15).ToString() + xd;
                    }
                    liczba /= 15;
                }
                MessageBox.Show("Twoja liczba w zapisie Piętnastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            //zamiana na szesnastkowy START
            if (selected_item == "Dwójkowy" && selected_item2 == "Szesnastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(2, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 16 > 9)
                    {
                        if (liczba % 16 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 16 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 16 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 16 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 16 == 14)
                        {
                            xd = "E" + xd;
                        }
                        if (liczba % 16 == 15)
                        {
                            xd = "F" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 16).ToString() + xd;

                    }
                    liczba /= 16;

                }
                MessageBox.Show("Twoja liczba w zapisie  Szesnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Trójkowy" && selected_item2 == "Szesnastkowy")                        
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(3, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 16 > 9)
                    {
                        if (liczba % 16 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 16 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 16 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 16 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 16 == 14)
                        {
                            xd = "E" + xd;
                        }
                        if (liczba % 16 == 15)
                        {
                            xd = "F" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 16).ToString() + xd;

                    }
                    liczba /= 16;

                }
                MessageBox.Show("Twoja liczba w zapisie  Szesnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Czwórkowy" && selected_item2 == "Szesnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(4, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 16 > 9)
                    {
                        if (liczba % 16 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 16 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 16 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 16 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 16 == 14)
                        {
                            xd = "E" + xd;
                        }
                        if (liczba % 16 == 15)
                        {
                            xd = "F" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 16).ToString() + xd;

                    }
                    liczba /= 16;

                }
                MessageBox.Show("Twoja liczba w zapisie  Szesnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Piątkowy" && selected_item2 == "Szesnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(5, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 16 > 9)
                    {
                        if (liczba % 16 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 16 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 16 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 16 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 16 == 14)
                        {
                            xd = "E" + xd;
                        }
                        if (liczba % 16 == 15)
                        {
                            xd = "F" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 16).ToString() + xd;

                    }
                    liczba /= 16;

                }
                MessageBox.Show("Twoja liczba w zapisie  Szesnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Szóstkowy" && selected_item2 == "Szesnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(6, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 16 > 9)
                    {
                        if (liczba % 16 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 16 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 16 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 16 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 16 == 14)
                        {
                            xd = "E" + xd;
                        }
                        if (liczba % 16 == 15)
                        {
                            xd = "F" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 16).ToString() + xd;

                    }
                    liczba /= 16;

                }
                MessageBox.Show("Twoja liczba w zapisie  Szesnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Siódemkowy" && selected_item2 == "Szesnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(7, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 16 > 9)
                    {
                        if (liczba % 16 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 16 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 16 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 16 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 16 == 14)
                        {
                            xd = "E" + xd;
                        }
                        if (liczba % 16 == 15)
                        {
                            xd = "F" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 16).ToString() + xd;

                    }
                    liczba /= 16;

                }
                MessageBox.Show("Twoja liczba w zapisie  Szesnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Ósemkowy" && selected_item2 == "Szesnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(8, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 16 > 9)
                    {
                        if (liczba % 16 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 16 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 16 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 16 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 16 == 14)
                        {
                            xd = "E" + xd;
                        }
                        if (liczba % 16 == 15)
                        {
                            xd = "F" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 16).ToString() + xd;

                    }
                    liczba /= 16;

                }
                MessageBox.Show("Twoja liczba w zapisie  Szesnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziewiątkowy" && selected_item2 == "Szesnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    liczba = Convert.ToInt32(line[i] - 48);
                    suma += (Convert.ToDouble(liczba) * (Math.Pow(9, z)));
                    z++;
                }
                z = 0;
                liczba = Convert.ToInt32(suma);

                while (liczba > 0)
                {
                    if (liczba % 16 > 9)
                    {
                        if (liczba % 16 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 16 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 16 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 16 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 16 == 14)
                        {
                            xd = "E" + xd;
                        }
                        if (liczba % 16 == 15)
                        {
                            xd = "F" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 16).ToString() + xd;

                    }
                    liczba /= 16;

                }
                MessageBox.Show("Twoja liczba w zapisie  Szesnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Dziesiętny" && selected_item2 == "Szesnastkowy")                        //na Dziewiątkowy START
            {
                string xd = "";
                liczba = Convert.ToInt32(line);
                while (liczba > 0)
                {
                    if (liczba % 16 > 9)
                    {
                        if (liczba % 16 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 16 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 16 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 16 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 16 == 14)
                        {
                            xd = "E" + xd;
                        }
                        if (liczba % 16 == 15)
                        {
                            xd = "F" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 16).ToString() + xd;
                    }
                    liczba /= 16;
                }

                MessageBox.Show("Twoja liczba w zapisie  Szesnastkowym to " + xd);
                liczba = 0;
                suma = 0;
            }
            if (selected_item == "Jedenastkowy" && selected_item2 == "Szesnastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(11, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 16 > 9)
                    {
                        if (liczba % 16 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 16 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 16 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 16 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 16 == 14)
                        {
                            xd = "E" + xd;
                        }
                        if (liczba % 16 == 15)
                        {
                            xd = "F" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 16).ToString() + xd;
                    }
                    liczba /= 16;
                }
                MessageBox.Show("Twoja liczba w zapisie Szesnastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Dwunastkowy" && selected_item2 == "Szesnastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(12, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 16 > 9)
                    {
                        if (liczba % 16 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 16 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 16 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 16 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 16 == 14)
                        {
                            xd = "E" + xd;
                        }
                        if (liczba % 16 == 15)
                        {
                            xd = "F" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 16).ToString() + xd;
                    }
                    liczba /= 16;
                }
                MessageBox.Show("Twoja liczba w zapisie Szesnastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Trzynastkowy" && selected_item2 == "Szesnastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    

                        suma += (Convert.ToDouble(liczba) * (Math.Pow(13, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 16 > 9)
                    {
                        if (liczba % 16 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 16 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 16 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 16 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 16 == 14)
                        {
                            xd = "E" + xd;
                        }
                        if (liczba % 16 == 15)
                        {
                            xd = "F" + xd ;
                        }
                    }
                    else
                    {
                        xd = (liczba % 16).ToString() + xd;
                    }
                    liczba /= 16;
                }
                MessageBox.Show("Twoja liczba w zapisie Szesnastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Czternastkowy" && selected_item2 == "Szesnastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    

                        suma += (Convert.ToDouble(liczba) * (Math.Pow(14, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 16 > 9)
                    {
                        if (liczba % 16 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 16 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 16 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 16 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 16 == 14)
                        {
                            xd = "E" + xd;
                        }
                        if (liczba % 16 == 15)
                        {
                            xd = "F" + xd;
                        }
                    }
                    else
                    {
                        xd = (liczba % 16).ToString() + xd;
                    }
                    liczba /= 16;
                }
                MessageBox.Show("Twoja liczba w zapisie Szesnastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }
            if (selected_item == "Piętnastkowy" && selected_item2 == "Szesnastkowy")
            {
                string xd = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {

                    liczba = Convert.ToInt32(line[i] - 48);
                    if (liczba == 17)
                    {
                        liczba = 10;
                    }
                    if (liczba == 18)
                    {
                        liczba = 11;
                    }
                    if (liczba == 19)
                    {
                        liczba = 12;
                    }
                    if (liczba == 20)
                    {
                        liczba = 13;
                    }
                    if (liczba == 21)
                    {
                        liczba = 14;
                    }

                    suma += (Convert.ToDouble(liczba) * (Math.Pow(15, z)));
                    z++;
                }
                liczba = Convert.ToInt32(suma);
                while (liczba > 0)
                {
                    if (liczba % 16 > 9)
                    {
                        if (liczba % 16 == 10)
                        {
                            xd = "A" + xd;
                        }
                        if (liczba % 16 == 11)
                        {
                            xd = "B" + xd;
                        }
                        if (liczba % 16 == 12)
                        {
                            xd = "C" + xd;
                        }
                        if (liczba % 16 == 13)
                        {
                            xd = "D" + xd;
                        }
                        if (liczba % 16 == 14)
                        {
                            xd = "E" + xd;
                        }
                        if (liczba % 16 == 15)
                        {
                            xd = "F" + xd;
                        }

                    }
                    else
                    {
                        xd = (liczba % 16).ToString() + xd;
                    }
                    liczba /= 16;
                }
                MessageBox.Show("Twoja liczba w zapisie Szesnastkowym to " + xd);

                z = 0;
                suma = 0;
                liczba = 0;

            }









        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void ListBox1click(object sender, EventArgs e)
        {
            listBox1.Size = new System.Drawing.Size(127, 199);
            textBox1.Visible = false;
            listBox2.Visible = false;
            button1.Visible = false;


        }

        private void listBox2click(object sender, EventArgs e)
        {
            listBox2.Size = new System.Drawing.Size(127, 199);
            button1.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1doubleclick(object sender, EventArgs e)
        {
            selected_item = listBox1.Text;
            if (listBox1.SelectedItem !=null)
            {
                listBox1.Size = new System.Drawing.Size(127, 17);
                textBox1.Visible = true;
                listBox2.Visible = true;
                button1.Visible = true;
                label5.Visible = true;
                label5.Text = selected_item;
            }
            
            
        }

        private void listBox2doubleclick(object sender, EventArgs e)
        {
            selected_item2 = listBox2.Text;
            if (listBox2.SelectedItem !=null)
            {
                listBox2.Size = new System.Drawing.Size(127, 17);
                button1.Visible = true;
                label6.Visible = true;
                label6.Text = selected_item2;

            }

            
            
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
