namespace English_Alphabet
{
    partial class Home
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Homes = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.Author = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TESTS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Homes
            // 
            this.Homes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Homes.Image = ((System.Drawing.Image)(resources.GetObject("Homes.Image")));
            this.Homes.Name = "Homes";
            this.Homes.Size = new System.Drawing.Size(101, 24);
            this.Homes.Text = "Головна";
            this.Homes.Click += new System.EventHandler(this.Homes_Click);
            // 
            // ProgramsInfo
            // 
            this.ProgramsInfo.Image = ((System.Drawing.Image)(resources.GetObject("ProgramsInfo.Image")));
            this.ProgramsInfo.Name = "ProgramsInfo";
            this.ProgramsInfo.Size = new System.Drawing.Size(144, 24);
            this.ProgramsInfo.Text = "Про програму";
            this.ProgramsInfo.Click += new System.EventHandler(this.ProgramsInfo_Click);
            // 
            // Author
            // 
            this.Author.Image = ((System.Drawing.Image)(resources.GetObject("Author.Image")));
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(124, 24);
            this.Author.Text = "Про автора";
            this.Author.Click += new System.EventHandler(this.Author_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Homes,
            this.ProgramsInfo,
            this.Author,
            this.TESTS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1244, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TESTS
            // 
            this.TESTS.Image = ((System.Drawing.Image)(resources.GetObject("TESTS.Image")));
            this.TESTS.Name = "TESTS";
            this.TESTS.Size = new System.Drawing.Size(121, 24);
            this.TESTS.Text = "Тестування";
            this.TESTS.Click += new System.EventHandler(this.TESTS_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 646);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "English alphabet for children";
            this.Load += new System.EventHandler(this.Home_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Home_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem Homes;
        private System.Windows.Forms.ToolStripMenuItem ProgramsInfo;
        private System.Windows.Forms.ToolStripMenuItem Author;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TESTS;
    }
}

