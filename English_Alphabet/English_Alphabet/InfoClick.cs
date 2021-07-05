using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // для відтворення звуку на формі скористаємся  System.Media
using System.IO; // бібліотека для читання тексту із файлів

namespace English_Alphabet
{
    public partial class InfoClick : Form
    {
        public string f;
        public InfoClick(string letter)
        {
            f = letter;
            InitializeComponent();
        }

        //Масив кнопок
        public Button[] AudioExmeple = new Button[5];

        //Масив міток
        public Label[] TextExmeple = new Label[5];

        private void InfoClick_Load(object sender, EventArgs e)
        {
            // створюємо 5 кнопочок на які додаватимо певні звуки
            for (int k = 0; k < 5; k++)
            {
                AudioExmeple[k] = new Button();
                AudioExmeple[k].BackColor = Color.Transparent;
                AudioExmeple[k].BackgroundImage = Image.FromFile(@"Music\so.png");
                AudioExmeple[k].BackgroundImageLayout = ImageLayout.Stretch;
                AudioExmeple[k].FlatAppearance.BorderSize = 0;
                AudioExmeple[k].FlatAppearance.MouseDownBackColor = Color.Transparent;
                AudioExmeple[k].FlatAppearance.MouseOverBackColor = Color.Transparent;
                AudioExmeple[k].FlatStyle = FlatStyle.Flat;
                AudioExmeple[k].ForeColor = Color.Transparent;
                AudioExmeple[k].Location = new Point(10, 45 + (50 * k));
                AudioExmeple[k].Name = "example" + k;
                AudioExmeple[k].Size = new Size(30, 25);
                AudioExmeple[k].UseVisualStyleBackColor = false;
                AudioExmeple[k].Click += AudioExmeple_Click;
                AudioExmeple[k].Parent = this;
                AudioExmeple[k].MouseLeave += Audios_MouseLeave;
                AudioExmeple[k].MouseEnter += Audios_MouseEnter;

                TextExmeple[k] = new Label();
                TextExmeple[k].Size = new Size(300, 30);
                TextExmeple[k].Location = new Point(50, 40 + (50 * k));
                TextExmeple[k].BackColor = Color.Transparent;
                TextExmeple[k].ForeColor = Color.White;
                TextExmeple[k].Font = new Font("Arial", 12);
                try
                {
                    string[] lines  =File.ReadAllLines(@"examples\Audio\" + f + @"\" + f + ".txt");
                    TextExmeple[k].Text = lines[k];
                }
                catch
                {
                    MessageBox.Show("Перевірте файл текстовий з рядками слів");
                }
                TextExmeple[k].TextAlign = ContentAlignment.MiddleLeft;
                TextExmeple[k].Parent = this;
            }        
        }

        // функція програвання звуку при натиску на кнопку
        public void AudioExmeple_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < 5; k++)
            {
                if (sender == AudioExmeple[k])
                {
                    try
                    {
                        SoundPlayer simpleSound = new SoundPlayer(@"examples\Audio\" + f + @"\" + k + ".wav");
                        simpleSound.Play();
                    }
                    catch
                    {
                        MessageBox.Show("Перевірте файли звука в папці Example");
                    }
                }
            }
        }
        // функції зміни кнопки при наведені та відведені
        private void Audios_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackgroundImage = Image.FromFile(@"Music\so.png");
            
        }
        private void Audios_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackgroundImage = Image.FromFile(@"Music\os.png");
           
        }
    }
}
