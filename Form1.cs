using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button12.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string pass = "qazwsxedcrfvtgbyhnujmikolp";
            if (checkBox1.Checked == true)
            {
                pass += "!@#$%^&*()";
            }
            if (checkBox2.Checked == true)
            {
                pass += "1234567890";
            }
            if (checkBox3.Checked == true)
            {
                pass += "MNBVCXZLKJHGFDSAPOIUYTREWQ";
            }

            /*textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;
            textBox10.Text = null;
            */
            foreach(var tb in this.Controls.OfType < TextBox>()) 
            {
                tb.Text = null; 
            }
            button12.Visible = true;

            Random rnd = new Random();
            for (int i = 0; i < numericUpDown1.Value; i++)
             
            {
                foreach (var tb in this.Controls.OfType<TextBox>())
                {
                    tb.Text += pass[rnd.Next(pass.Length)];

                  /*  textBox1.Text += pass[rnd.Next(pass.Length)];
                    textBox2.Text += pass[rnd.Next(pass.Length)];
                    textBox3.Text += pass[rnd.Next(pass.Length)];
                    textBox4.Text += pass[rnd.Next(pass.Length)];
                    textBox5.Text += pass[rnd.Next(pass.Length)];
                    textBox6.Text += pass[rnd.Next(pass.Length)];
                    textBox7.Text += pass[rnd.Next(pass.Length)];
                    textBox8.Text += pass[rnd.Next(pass.Length)];
                    textBox9.Text += pass[rnd.Next(pass.Length)];
                    textBox10.Text += pass[rnd.Next(pass.Length)]; */
                }
            }
        } //End button1_Click

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in this.Controls) // обходим все элементы формы
            {
                if (item is Button) // проверяем, что это кнопка
                {
                    string t = (string)((Button)sender).Tag; //Текст будет копироваться в зависимости от тэга нажатой кнопки                            
                  switch (Convert.ToInt32(t)) //Ненавижу ЯП с строгой типизацией
                    {
                        case 2: Clipboard.SetText(textBox1.Text); break;     //case'ы можно загнать в цикл, но как при этом переключать textBox'ы ?
                        case 3: Clipboard.SetText(textBox2.Text); break;
                        case 4: Clipboard.SetText(textBox3.Text); break;
                        case 5: Clipboard.SetText(textBox4.Text); break;
                        case 6: Clipboard.SetText(textBox5.Text); break;
                        case 7: Clipboard.SetText(textBox6.Text); break;
                        case 8: Clipboard.SetText(textBox7.Text); break;
                        case 9: Clipboard.SetText(textBox8.Text); break;
                        case 10: Clipboard.SetText(textBox9.Text); break;
                        case 11: Clipboard.SetText(textBox10.Text); break;
                    }
                }
            }           
        }  

        private void button12_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            string TextAll = null;
            foreach (var tb in this.Controls.OfType<TextBox>())
            { TextAll += tb.Text + Environment.NewLine; };
            System.IO.File.WriteAllText(filename, TextAll);
            //System.IO.File.WriteAllText(filename, textBox1.Text+ Environment.NewLine +textBox2.Text + Environment.NewLine +textBox3.Text + Environment.NewLine+ textBox4.Text + Environment.NewLine+ textBox5.Text + Environment.NewLine + textBox6.Text + Environment.NewLine+textBox7.Text + Environment.NewLine+textBox8.Text + Environment.NewLine+textBox9.Text + Environment.NewLine+textBox10.Text);
        }

    } //End public partial class Form1 : Form
} //End namespace test2
