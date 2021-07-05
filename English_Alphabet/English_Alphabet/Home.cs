using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // для відтворення звуку на формі скористаємся  System.Media
using System.IO; // бібліотека для читання тексту із файлів

namespace English_Alphabet
{
    public partial class Home : Form
    {
        InfoClick f;
        
        // Інціалізація форми
        public Home()
        {
            InitializeComponent();
            // стратова прозиця окна по центру
            StartPosition = FormStartPosition.CenterScreen;
        }

        // функції які мніюють властивості форми при натису на відповідні пункти меню
        private void ProgramsInfo_Click(object sender, EventArgs e)
        {
            ProgramInfo();
        }
        private void Author_Click_1(object sender, EventArgs e)
        {
            AuthorJa();
        }
        private void Audios_Click(object sender, EventArgs e)
        {
            audio();
        }
        private void TESTS_Click(object sender, EventArgs e)
        {
            TEST();
        }
        private void Homes_Click(object sender, EventArgs e)
        {
            Hide();
            Home hm = new Home();
            hm.ShowDialog();
            Close();
        }

        //задаєм всі потрібні контролери
        public Button Bb = new Button();
        public Button bB = new Button();
        public Button Music = new Button();
        public Button Fire = new Button();
        public Button Erif = new Button();
        public Button Pop = new Button();
        public Button Muc = new Button();

        public PictureBox rock = new PictureBox();
        public PictureBox pic = new PictureBox();
        public PictureBox pica = new PictureBox();
        public PictureBox anim = new PictureBox();

        public Label info = new Label();
        public Label intcoduce = new Label();

        public TextBox entrence = new TextBox();

        public Random rnd = new Random();
        public int value;

        public Button[] buttons = new Button[26]; // створюємо масив кнопок
        // створюємо масив із назвами кнопок та звуків
        public string[] buttonsABS = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N",
            "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
        public bool dou = true;

        //лічильник правилних
        public int a = 0;
        //лічильник не правилних
        public int v = 0;
        //шо уводить користувач
        public string Sss;

        public void audio()
        {
            value = rnd.Next(0, 25);
            SoundPlayer simpleSound = new SoundPlayer(@"Audio\" + buttonsABS[value] + ".wav");
            simpleSound.Play();
        }
        // функція фвкладки тестування
        public void TEST()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            // встановлюємо фонове фото
            this.BackgroundImage = Image.FromFile(@"App\фончік.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Size = new Size(900, 600);

            intcoduce.Text = "Послухайте і введіть правильну відповідь";
            intcoduce.ForeColor = Color.DarkRed;
            intcoduce.TextAlign = ContentAlignment.MiddleCenter;
            intcoduce.BackColor = Color.Transparent;
            intcoduce.Name = "InfoJa";
            intcoduce.Location = new Point(100, 30);
            intcoduce.AutoSize = true;
            intcoduce.Font = new Font("Gabriola", 36);
            intcoduce.Parent = this;

            Fire.Name = "Fire1";
            Fire.Parent = this;
            Fire.FlatStyle = FlatStyle.Flat;
            Fire.Location = new Point(70, 200);
            Fire.Size = new Size(150, 150);
            Fire.Font = new Font("Impact", 14);
            Fire.TextAlign = ContentAlignment.BottomCenter;
            Fire.Image = Image.FromFile(@"Anim\Correct.gif");
            Fire.BackColor = Color.Transparent;
            Fire.ForeColor = Color.Green;
            Fire.FlatAppearance.BorderSize = 0;
            Fire.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Fire.FlatAppearance.MouseOverBackColor = Color.Transparent;


            Muc.Name = "Fire1";
            Muc.Parent = this;
            Muc.FlatStyle = FlatStyle.Flat;
            Muc.Location = new Point(470, 320);
            Muc.Size = new Size(20, 20);
            Muc.Font = new Font("Impact", 14);
            Muc.TextAlign = ContentAlignment.BottomCenter;
            Muc.BackgroundImage = Image.FromFile(@"App\go.png");
            Muc.BackgroundImageLayout = ImageLayout.Stretch;
            Muc.BackColor = Color.Gainsboro;
            Muc.ForeColor = Color.White;
            Muc.Click += Muc_Click;

            Erif.Name = "Fire";
            Erif.Parent = this;
            Erif.FlatStyle = FlatStyle.Flat;
            Erif.Location = new Point(650, 200);
            Erif.Size = new Size(150, 150);
            Erif.Font = new Font("Impact", 14);
            Erif.TextAlign = ContentAlignment.BottomCenter;
            Erif.Image = Image.FromFile(@"Anim\Wrong.gif");
            Erif.BackColor = Color.Transparent;
            Erif.ForeColor = Color.Red;
            Erif.FlatAppearance.BorderSize = 0;
            Erif.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Erif.FlatAppearance.MouseOverBackColor = Color.Transparent;

            Pop.Name = "as";
            Pop.Parent = this;
            Pop.FlatStyle = FlatStyle.Flat;
            Pop.Location = new Point(350, 150);
            Pop.Size = new Size(150, 150);
            Pop.BackColor = Color.Transparent;
            Pop.ForeColor = Color.Transparent;
            Pop.FlatAppearance.BorderSize = 0;
            Pop.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Pop.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Pop.BackgroundImage = Image.FromFile(@"App\зучок.png");
            Pop.BackgroundImageLayout = ImageLayout.Stretch;
            Pop.MouseEnter += ButtonAudios_MouseEnter;
            Pop.MouseLeave += ButtonAudios_MouseLeave;
            Pop.Click += Audios_Click;

            entrence.Location = new Point(365, 320);
            entrence.Parent = this;
            entrence.MaxLength = 1;
            entrence.CharacterCasing = CharacterCasing.Upper;
            entrence.TextAlign = HorizontalAlignment.Center;
            entrence.KeyDown += entrence_KeyDown;

            for (int c = 0; c < buttonsABS.Length; c++)
            {
                buttons[c].Visible = false;
            }
            bB.Visible = false;
            Bb.Visible = false;
            Music.Visible = false;
            info.Visible = false;
            pica.Visible = false;
            anim.Visible = false;
            rock.Visible = false;
            pic.Visible = false;
            intcoduce.Visible = true;
            Fire.Visible = true;
            Erif.Visible = true;
            entrence.Visible = true;
            Pop.Visible = true;
            Muc.Visible = true;
        }
        // функія вкладик про програму
        public void ProgramInfo()
        {
            // Обмежуємо порму
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            // встановлюємо фонове фото
            this.BackgroundImage = Image.FromFile(@"App\ono.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Size = new Size(900, 600);
            //  PictureBox для вогняного тексту
            rock.Image = Image.FromFile(@"Anim\довідка-огня.gif");
            rock.SizeMode = PictureBoxSizeMode.StretchImage;
            rock.Name = "Rock";
            rock.Location = new Point(350, -80);
            rock.Size = new Size(170, 170);
            rock.BackColor = Color.Transparent;
            rock.Parent = this;

            //  PictureBox для обробленого тексту    
            pic.BackgroundImage = Image.FromFile(@"Info\Інфо_п.png");
            pic.Name = "Grad";
            pic.BackgroundImageLayout = ImageLayout.Zoom;
            pic.Location = new Point(20, -90);
            pic.Size = new Size(800, 800);
            pic.BackColor = Color.Transparent;
            pic.Parent = this;
            for (int c = 0; c < buttonsABS.Length; c++)
            {
                buttons[c].Visible = false;
            }
            bB.Visible = false;
            Bb.Visible = false;
            Music.Visible = false;
            info.Visible = false;
            pica.Visible = false;
            anim.Visible = false;
            rock.Visible = true;
            pic.Visible = true;
            intcoduce.Visible = false;
            Fire.Visible = false;
            Erif.Visible = false;
            entrence.Visible = false;
            Pop.Visible = false;
            Muc.Visible = false;
        }
        // функція вкладки про автора
        public void AuthorJa()
        {
            // обмежуємо форму у розмірах
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            // задаєм фоновий рісунок
            this.BackgroundImage = Image.FromFile(@"App\phon.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Size = new Size(800, 610);
            //Додаєм відповідний теск про автора за домопогою Label і встановлюємо їй властивості

            info.Text = Convert.ToString(File.ReadAllText(@"Info\Info_author.txt", Encoding.GetEncoding(1251)));
            info.ForeColor = Color.White;
            info.BackColor = Color.Transparent;
            info.Name = "InfoJa";
            info.Location = new Point(10, 200);
            info.AutoSize = true;
            info.Font = new Font("Gabriola", 20);
            info.Parent = this;

            // Створим PictureBоx у який загружеш фото автора відповідні властивості

            pica.BackgroundImage = Image.FromFile(@"App\Ja.png");
            pica.Name = "Krasa";
            pica.BackgroundImageLayout = ImageLayout.Zoom;
            pica.Location = new Point(10, 50);
            pica.Size = new Size(120, 120);
            pica.BackColor = Color.Transparent;
            pica.MouseEnter += Pica_MouseEnter;
            pica.MouseLeave += Pica_MouseLeave;
            pica.Parent = this;

            //  PictureBox для анімації падіння нашої квітки

            anim.Image = Image.FromFile(@"Anim\Flower.gif");
            anim.Name = "Anim";
            anim.SizeMode = PictureBoxSizeMode.StretchImage;
            anim.Location = new Point(300, 0);
            anim.Size = new Size(500, 600);
            anim.BackColor = Color.Transparent;
            anim.MouseEnter += Pica_MouseEnter;
            anim.MouseLeave += Pica_MouseLeave;
            anim.Parent = this;


            for (int c = 0; c < buttonsABS.Length; c++)
            {
                buttons[c].Visible = false;
            }
            bB.Visible = false;
            Bb.Visible = false;
            Music.Visible = false;
            info.Visible = true;
            pica.Visible = true;
            anim.Visible = true;
            rock.Visible = false;
            pic.Visible = false;
            intcoduce.Visible = false;
            Fire.Visible = false;
            Erif.Visible = false;
            entrence.Visible = false;
            Pop.Visible = false;
            Muc.Visible = false;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            //Встановлюємо подвійну буферизацію щоб усунути блимання форми
            this.DoubleBuffered = true;
            // встановлюємо фон кнопці
            this.BackgroundImage = Image.FromFile(@"App\Course.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            // обмежуємо форму у розмірах
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // зміні для цикала які допомагають вистоїти кнопки у 4 ряди
            int f = 1;
            int d = 1;
            int r = 1;
            int g = 100;
            // цикл який встановює координати кнопок
            for (int i = 0; i < buttonsABS.Length; i++)
            {
                buttons[i] = new Button();
                if (i < 7)
                {
                    buttons[i].Location = new Point(12 * f, 100);
                    f += 11;
                }
                if (i < 14 && i >= 7)
                {
                    buttons[i].Location = new Point(12 * d, 200);
                    d += 11;
                }
                if (i < 21 && i >= 14)
                {
                    buttons[i].Location = new Point(12 * r, 300);
                    r += 11;
                }
                if (i <= 26 && i >= 21)
                {
                    buttons[i].Location = new Point(45 + g, 400);
                    g += 132;
                }

                // задаємо властивості кнопам
                buttons[i].Name = "button" + buttonsABS[i];
                buttons[i].Parent = this;
                buttons[i].Size = new Size(120, 75);
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].ForeColor = Color.DarkRed;
                buttons[i].FlatAppearance.BorderSize = 3;
                Image myimage = new Bitmap(@"ABS\" + buttonsABS[i] + ".jpg");
                buttons[i].BringToFront();
                buttons[i].BackgroundImage = myimage;
                buttons[i].BackgroundImageLayout = ImageLayout.Zoom;
                buttons[i].MouseEnter += Button_MouseEnter;
                buttons[i].MouseLeave += Button_MouseLeave;
                buttons[i].Click += ButtonAudio_Click;
                buttons[i].MouseDown += buttons_MouseDown;
                this.Controls.Add(buttons[i]);

            }
            // створюємо кнопку зміни транскрипції на англійську і задаєм їй властивості
            Bb.Name = "Trans";
            Bb.Parent = this;
            Bb.FlatStyle = FlatStyle.Flat;
            Bb.Location = new Point(300, 50);
            Bb.Size = new Size(120, 30);
            Bb.BackgroundImage = Image.FromFile(@"App\Транск.png");
            Bb.BackgroundImageLayout = ImageLayout.Stretch;
            Bb.BackColor = Color.Transparent;
            Bb.FlatAppearance.BorderSize = 0;
            Bb.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Bb.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Bb.MouseEnter += Button3_MouseEnter;
            Bb.MouseLeave += Button3_MouseLeave;
            Bb.Click += Bb_Click;

            // створюємо кнопку зміни транскрипції на українську вимову і задаєм їй властивості
            bB.Name = "UKR";
            bB.Parent = this;
            bB.FlatStyle = FlatStyle.Flat;
            bB.Location = new Point(515, 50);
            bB.Size = new Size(120, 30);
            bB.BackgroundImage = Image.FromFile(@"App\УКР2.png");
            bB.BackgroundImageLayout = ImageLayout.Stretch;
            bB.BackColor = Color.Transparent;
            bB.ForeColor = Color.Transparent;
            bB.FlatAppearance.BorderSize = 0;
            bB.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bB.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bB.MouseEnter += Button2_MouseEnter;
            bB.MouseLeave += Button2_MouseLeave;
            bB.Click += bB_Click;

            // створюємо кнопу для відтворення пісеньки 
            Music.Name = "ROCK";
            Music.Parent = this;
            Music.FlatStyle = FlatStyle.Flat;
            Music.Location = new Point(437, 32);
            Music.Size = new Size(60, 60);
            Music.BackgroundImage = Image.FromFile(@"Music\Go.png");
            Music.BackgroundImageLayout = ImageLayout.Stretch;
            Music.BackColor = Color.Transparent;
            Music.ForeColor = Color.Transparent;
            Music.FlatAppearance.BorderSize = 0;
            Music.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Music.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Music.Click += Music_Click;
            // задаєм події кнопці коли dou  
            if (dou)
            {
                Music.MouseEnter += ButtonMusic_MouseEnter;
                Music.MouseLeave += ButtonMusic_MouseLeave;
            }
        }

        private void Muc_Click(object sender, EventArgs e)
        {
            string Sss = entrence.Text;
            // якщо пуста строка
            if (Sss == "")
            {
                MessageBox.Show("Уведіть букву");
                return;
            }
            //Правильно відповів
            if (Sss == buttonsABS[value])
            {
                a += 1;
                Fire.Text = a.ToString();
                entrence.Clear();
            }
            // Неправильно
            if (Sss != buttonsABS[value])
            {
                v += 1;
                Erif.Text = v.ToString();
                entrence.Clear();
            }

        }
        public void entrence_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                Muc.PerformClick();
            }
        }
        // функція яка викликає нову форму при натиску на праву кнопку миші і до помагає змінювати фокус між формами
        private void buttons_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < buttonsABS.Length; i++)
                {
                    if (sender == buttons[i])
                    {
                        if (f == null || f.IsDisposed) { f = new InfoClick(buttonsABS[i]); f.Show(); }
                        else { f.Show(); f.Focus(); }
                    }
                }
            }
        }

        // функції зміни кольору кнопки при наведені на неї
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.ForeColor = Color.Red;
        }

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackgroundImage = Image.FromFile(@"App\УКРР.png");
        }

        private void Button3_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackgroundImage = Image.FromFile(@"App\Транс2.png");
        }

        private void ButtonMusic_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackgroundImage = Image.FromFile(@"Music\GoGo.png");
        }

        private void ButtonMusic2_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackgroundImage = Image.FromFile(@"Music\StopStop.png");
        }

        private void ButtonAudios_MouseEnter(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackgroundImage = Image.FromFile(@"App\звучок1.png");
        }

        // функції зміни кольору кнопки при відведені від неї
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.ForeColor = Color.DarkRed;
        }
        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackgroundImage = Image.FromFile(@"App\УКР2.png");
        }
        private void Button3_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackgroundImage = Image.FromFile(@"App\Транск.png");
        }

        private void ButtonMusic_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackgroundImage = Image.FromFile(@"Music\Go.png");
        }
        private void ButtonMusic2_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackgroundImage = Image.FromFile(@"Music\Stop.png");
        }
        private void ButtonAudios_MouseLeave(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.BackgroundImage = Image.FromFile(@"App\зучок.png");
        }


        // функція яка задає певний звук кожній кнопці і при натиску на неї відтворює його
        private void ButtonAudio_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < buttonsABS.Length; k++)
            {
                if (sender == buttons[k])
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"Audio\" + buttonsABS[k] + ".wav");
                    simpleSound.Play();

                }
            }
        }
        // функція яка задає відповідні властивості кноці в залежно від значення зміної dou
        private void Music_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            SoundPlayer simpleSound = new SoundPlayer(@"Music\Music.wav");
            if (dou)
            {
                dou = false;
                button.BackgroundImage = Image.FromFile(@"Music\StopStop.png");
                simpleSound.Play();
                button.MouseEnter += ButtonMusic2_MouseEnter;
                button.MouseLeave += ButtonMusic2_MouseLeave;
            }
            else
            {
                dou = true;
                button.BackgroundImage = Image.FromFile(@"Music\GoGo.png");
                simpleSound.Stop();
                button.MouseEnter += ButtonMusic_MouseEnter;
                button.MouseLeave += ButtonMusic_MouseLeave;
            }


        }

        // функції зміни фото на кнопках при натиску на відповідну кнопку
        private void Bb_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < buttons.Length; k++)
            {
                buttons[k].BackgroundImage = Image.FromFile(@"ABS\" + buttonsABS[k] + ".jpg");
            }
        }
        private void bB_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < buttons.Length; k++)
            {
                buttons[k].BackgroundImage = Image.FromFile(@"UKR\" + buttonsABS[k] + ".jpg");
            }
        }
        // Функція яка зімінює фото при наведені на picturebox
        private void Pica_MouseEnter(object sender, EventArgs e)
        {
            var picturebox = (PictureBox)sender;
            picturebox.BackgroundImage = Image.FromFile(@"App\Ja2.png");
        }


        // Функція яка зімінює фото при відведені на picturebox
        private void Pica_MouseLeave(object sender, EventArgs e)
        {
            var picturebox = (PictureBox)sender;
            picturebox.BackgroundImage = Image.FromFile(@"App\Ja.png");
        }
        // Створим обробник подій при натиску на кнопк

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                buttons[0].ForeColor = Color.Red;
                buttons[0].PerformClick();
            }
            if (e.KeyData == Keys.B)
            {
                buttons[1].ForeColor = Color.Red;
                buttons[1].PerformClick();
            }
            if (e.KeyData == Keys.C)
            {
                buttons[2].ForeColor = Color.Red;
                buttons[2].PerformClick();
            }
            if (e.KeyData == Keys.D)
            {
                buttons[3].ForeColor = Color.Red;
                buttons[3].PerformClick();
            }
            if (e.KeyData == Keys.E)
            {
                buttons[4].ForeColor = Color.Red;
                buttons[4].PerformClick();
            }
            if (e.KeyData == Keys.F)
            {
                buttons[5].ForeColor = Color.Red;
                buttons[5].PerformClick();
            }
            if (e.KeyData == Keys.G)
            {
                buttons[6].ForeColor = Color.Red;
                buttons[6].PerformClick();
            }
            if (e.KeyData == Keys.H)
            {
                buttons[7].ForeColor = Color.Red;
                buttons[7].PerformClick();
            }
            if (e.KeyData == Keys.I)
            {
                buttons[8].ForeColor = Color.Red;
                buttons[8].PerformClick();
            }
            if (e.KeyData == Keys.J)
            {
                buttons[9].ForeColor = Color.Red;
                buttons[9].PerformClick();
            }
            if (e.KeyData == Keys.K)
            {
                buttons[10].ForeColor = Color.Red;
                buttons[10].PerformClick();
            }
            if (e.KeyData == Keys.L)
            {
                buttons[11].ForeColor = Color.Red;
                buttons[11].PerformClick();
            }
            if (e.KeyData == Keys.M)
            {
                buttons[12].ForeColor = Color.Red;
                buttons[12].PerformClick();
            }
            if (e.KeyData == Keys.N)
            {
                buttons[13].ForeColor = Color.Red;
                buttons[13].PerformClick();
            }
            if (e.KeyData == Keys.O)
            {
                buttons[14].ForeColor = Color.Red;
                buttons[14].PerformClick();
            }
            if (e.KeyData == Keys.P)
            {
                buttons[15].ForeColor = Color.Red;
                buttons[15].PerformClick();
            }
            if (e.KeyData == Keys.Q)
            {
                buttons[16].ForeColor = Color.Red;
                buttons[16].PerformClick();
            }
            if (e.KeyData == Keys.R)
            {
                buttons[17].ForeColor = Color.Red;
                buttons[17].PerformClick();
            }
            if (e.KeyData == Keys.S)
            {
                buttons[18].ForeColor = Color.Red;
                buttons[18].PerformClick();
            }
            if (e.KeyData == Keys.T)
            {
                buttons[19].ForeColor = Color.Red;
                buttons[19].PerformClick();
            }
            if (e.KeyData == Keys.U)
            {
                buttons[20].ForeColor = Color.Red;
                buttons[20].PerformClick();
            }
            if (e.KeyData == Keys.V)
            {
                buttons[21].ForeColor = Color.Red;
                buttons[21].PerformClick();
            }
            if (e.KeyData == Keys.W)
            {
                buttons[22].ForeColor = Color.Red;
                buttons[22].PerformClick();
            }
            if (e.KeyData == Keys.X)
            {
                buttons[23].ForeColor = Color.Red;
                buttons[23].PerformClick();
            }
            if (e.KeyData == Keys.Y)
            {
                buttons[24].ForeColor = Color.Red;
                buttons[24].PerformClick();
            }
            if (e.KeyData == Keys.Z)
            {
                buttons[25].ForeColor = Color.Red;
                buttons[25].PerformClick();
            }
        }

        // обробник подій при відпусканні кнопки
        private void Home_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                buttons[0].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.B)
            {
                buttons[1].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.C)
            {
                buttons[2].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.D)
            {
                buttons[3].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.E)
            {
                buttons[4].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.F)
            {
                buttons[5].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.G)
            {
                buttons[6].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.H)
            {
                buttons[7].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.I)
            {
                buttons[8].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.J)
            {
                buttons[9].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.K)
            {
                buttons[10].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.L)
            {
                buttons[11].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.M)
            {
                buttons[12].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.N)
            {
                buttons[13].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.O)
            {
                buttons[14].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.P)
            {
                buttons[15].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.Q)
            {
                buttons[16].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.R)
            {
                buttons[17].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.S)
            {
                buttons[18].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.T)
            {
                buttons[19].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.U)
            {
                buttons[20].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.V)
            {
                buttons[21].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.W)
            {
                buttons[22].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.X)
            {
                buttons[23].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.Y)
            {
                buttons[24].ForeColor = Color.DarkRed;
            }
            if (e.KeyData == Keys.Z)
            {
                buttons[25].ForeColor = Color.DarkRed;
            }
        }
    }
}