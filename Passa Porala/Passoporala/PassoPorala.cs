using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passoporala
{
    public partial class PassoPorala : Form
    {
        public PassoPorala()
        {
            InitializeComponent();
        }

        int questiono = 0, correct = 0, wrong = 0;

        

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (questiono)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            wrong++;
                            label4.Text=wrong.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            button8.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            button9.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            button10.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            button11.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            button12.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            button13.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            button14.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            button15.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "orhan veli")
                        {
                            button16.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            button17.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            button18.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            button19.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            button20.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "ümit")
                        {
                            button21.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            button22.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            button23.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            button24.BackColor = Color.Green;
                            correct++;
                            label2.Text = correct.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            wrong++;
                            label4.Text = wrong.ToString();
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Next";
            questiono++;
            this.Text = questiono.ToString();

            if (questiono == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmında ki kıyı bölgesi nedir? ";
                button1.BackColor = Color.Yellow;
            }
            if (questiono == 2)
            {
                richTextBox1.Text = "Yeşiliği ile ünlü marmara ilimiz? ";
                button2.BackColor = Color.Yellow;
            }
            if (questiono == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü? ";
                button3.BackColor = Color.Yellow;
            }
            if (questiono == 4)
            {
                richTextBox1.Text = "Karpuzu ile ünlü ilimiz? ";
                button4.BackColor = Color.Yellow;
            }
            if (questiono == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamı? ";
                button5.BackColor = Color.Yellow;
            }
            if (questiono == 6)
            {
                richTextBox1.Text = "Padişah emirlerinin yazılı hali? ";
                button6.BackColor = Color.Yellow;
            }
            if (questiono == 7)
            {
                richTextBox1.Text = "Ülkemizin güney kısmında ki kıyı bölgesi nedir? ";
                button7.BackColor = Color.Yellow;
            }
            if (questiono == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü not getirince bakıştığı nesne? ";
                button8.BackColor = Color.Yellow;
            }
            if (questiono == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz? ";
                button9.BackColor = Color.Yellow;
            }
            if (questiono == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi? ";
                button10.BackColor = Color.Yellow;
            }
            if (questiono == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk? ";
                button11.BackColor = Color.Yellow;
            }
            if (questiono == 12)
            {
                richTextBox1.Text = "Malatyanın Meşhur ili? ";
                button12.BackColor = Color.Yellow;
            }
            if (questiono == 13)
            {
                richTextBox1.Text = "Her yıl düzenlenen meşhur çiçek festivali? ";
                button13.BackColor = Color.Yellow;
            }
            if (questiono == 14)
            {
                richTextBox1.Text = "Yılın 3. ayı? ";
                button14.BackColor = Color.Yellow;
            }
            if (questiono == 15)
            {
                richTextBox1.Text = "Üflemeli çalgı aleti? ";
                button15.BackColor = Color.Yellow;
            }
            if (questiono == 16)
            {
                richTextBox1.Text = "Halk şairi? ";
                button16.BackColor = Color.Yellow;
            }
            if (questiono == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç ve havuç ile yapılan sebzeli yemek? ";
                button17.BackColor = Color.Yellow;
            }
            if (questiono == 18)
            {
                richTextBox1.Text = "11 ayın sultanı? ";
                button18.BackColor = Color.Yellow;
            }
            if (questiono == 19)
            {
                richTextBox1.Text = "İngilizcede yılan? ";
                button19.BackColor = Color.Yellow;
            }
            if (questiono == 20)
            {
                richTextBox1.Text = "Türkiyenin mega starı? ";
                button20.BackColor = Color.Yellow;
            }
            if (questiono == 21)
            {
                richTextBox1.Text = "Umut kelimesinin eş anlamlısı? ";
                button21.BackColor = Color.Yellow;
            }
            if (questiono == 22)
            {
                richTextBox1.Text = "Kahvaltı ile ünlü ilimiz? ";
                button22.BackColor = Color.Yellow;
            }
            if (questiono == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamısı? ";
                button23.BackColor = Color.Yellow;
            }
            if (questiono == 24)
            {
                richTextBox1.Text = "Ege bölgesinde en çok bulunan ve yağıda yapılan kahvaltı besini ? ";
                button24.BackColor = Color.Yellow;
            }

        }
    }
}
