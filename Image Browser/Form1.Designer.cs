namespace Image_Browser
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вышеЯркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.идеальныйОтражательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.растяжениеКонтрастностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волны1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волны2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гауссToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.собельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторПоОсиYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторПоОсиXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htprjcnmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сдвигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сдвигВЛевоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сдвигВправоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделениеГраницToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторЩарраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поОсиYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поОсиXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторПрюиттаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поОсиYToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поОсиXToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.матморфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.эффектСтеклаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(99, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1039, 546);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.матморфологияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1215, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            this.сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            this.сохранитьФайлToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
            this.сохранитьФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьФайлToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.сдвигиToolStripMenuItem,
            this.выделениеГраницToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.grayScaleToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.вышеЯркостьToolStripMenuItem,
            this.идеальныйОтражательToolStripMenuItem,
            this.растяжениеКонтрастностиToolStripMenuItem,
            this.волныToolStripMenuItem,
            this.поворотToolStripMenuItem,
            this.эффектСтеклаToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.grayScaleToolStripMenuItem.Text = "Полутоновый";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // вышеЯркостьToolStripMenuItem
            // 
            this.вышеЯркостьToolStripMenuItem.Name = "вышеЯркостьToolStripMenuItem";
            this.вышеЯркостьToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.вышеЯркостьToolStripMenuItem.Text = "Выше яркость";
            this.вышеЯркостьToolStripMenuItem.Click += new System.EventHandler(this.вышеЯркостьToolStripMenuItem_Click);
            // 
            // идеальныйОтражательToolStripMenuItem
            // 
            this.идеальныйОтражательToolStripMenuItem.Name = "идеальныйОтражательToolStripMenuItem";
            this.идеальныйОтражательToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.идеальныйОтражательToolStripMenuItem.Text = "Идеальный отражатель";
            this.идеальныйОтражательToolStripMenuItem.Click += new System.EventHandler(this.идеальныйОтражательToolStripMenuItem_Click);
            // 
            // растяжениеКонтрастностиToolStripMenuItem
            // 
            this.растяжениеКонтрастностиToolStripMenuItem.Name = "растяжениеКонтрастностиToolStripMenuItem";
            this.растяжениеКонтрастностиToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.растяжениеКонтрастностиToolStripMenuItem.Text = "Растяжение контрастности";
            this.растяжениеКонтрастностиToolStripMenuItem.Click += new System.EventHandler(this.растяжениеКонтрастностиToolStripMenuItem_Click);
            // 
            // волныToolStripMenuItem
            // 
            this.волныToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.волны1ToolStripMenuItem,
            this.волны2ToolStripMenuItem});
            this.волныToolStripMenuItem.Name = "волныToolStripMenuItem";
            this.волныToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.волныToolStripMenuItem.Text = "Волны";
            // 
            // волны1ToolStripMenuItem
            // 
            this.волны1ToolStripMenuItem.Name = "волны1ToolStripMenuItem";
            this.волны1ToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.волны1ToolStripMenuItem.Text = "Волны 1";
            this.волны1ToolStripMenuItem.Click += new System.EventHandler(this.волны1ToolStripMenuItem_Click);
            // 
            // волны2ToolStripMenuItem
            // 
            this.волны2ToolStripMenuItem.Name = "волны2ToolStripMenuItem";
            this.волны2ToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.волны2ToolStripMenuItem.Text = "Волны 2";
            this.волны2ToolStripMenuItem.Click += new System.EventHandler(this.волны2ToolStripMenuItem_Click);
            // 
            // поворотToolStripMenuItem
            // 
            this.поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            this.поворотToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.поворотToolStripMenuItem.Text = "Поворот";
            this.поворотToolStripMenuItem.Click += new System.EventHandler(this.поворотToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.гауссToolStripMenuItem,
            this.собельToolStripMenuItem,
            this.htprjcnmToolStripMenuItem,
            this.тиснениеToolStripMenuItem,
            this.медианныйToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // гауссToolStripMenuItem
            // 
            this.гауссToolStripMenuItem.Name = "гауссToolStripMenuItem";
            this.гауссToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.гауссToolStripMenuItem.Text = "Гаусс";
            this.гауссToolStripMenuItem.Click += new System.EventHandler(this.гауссToolStripMenuItem_Click);
            // 
            // собельToolStripMenuItem
            // 
            this.собельToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операторПоОсиYToolStripMenuItem,
            this.операторПоОсиXToolStripMenuItem});
            this.собельToolStripMenuItem.Name = "собельToolStripMenuItem";
            this.собельToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.собельToolStripMenuItem.Text = "Собель";
            this.собельToolStripMenuItem.Click += new System.EventHandler(this.собельToolStripMenuItem_Click);
            // 
            // операторПоОсиYToolStripMenuItem
            // 
            this.операторПоОсиYToolStripMenuItem.Name = "операторПоОсиYToolStripMenuItem";
            this.операторПоОсиYToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.операторПоОсиYToolStripMenuItem.Text = "Оператор по оси Y ";
            this.операторПоОсиYToolStripMenuItem.Click += new System.EventHandler(this.операторПоОсиYToolStripMenuItem_Click);
            // 
            // операторПоОсиXToolStripMenuItem
            // 
            this.операторПоОсиXToolStripMenuItem.Name = "операторПоОсиXToolStripMenuItem";
            this.операторПоОсиXToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.операторПоОсиXToolStripMenuItem.Text = "Оператор по оси X";
            this.операторПоОсиXToolStripMenuItem.Click += new System.EventHandler(this.операторПоОсиXToolStripMenuItem_Click);
            // 
            // htprjcnmToolStripMenuItem
            // 
            this.htprjcnmToolStripMenuItem.Name = "htprjcnmToolStripMenuItem";
            this.htprjcnmToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.htprjcnmToolStripMenuItem.Text = "Резкость";
            this.htprjcnmToolStripMenuItem.Click += new System.EventHandler(this.htprjcnmToolStripMenuItem_Click);
            // 
            // тиснениеToolStripMenuItem
            // 
            this.тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            this.тиснениеToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.тиснениеToolStripMenuItem.Text = "Тиснение";
            this.тиснениеToolStripMenuItem.Click += new System.EventHandler(this.тиснениеToolStripMenuItem_Click);
            // 
            // медианныйToolStripMenuItem
            // 
            this.медианныйToolStripMenuItem.Name = "медианныйToolStripMenuItem";
            this.медианныйToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.медианныйToolStripMenuItem.Text = "Медианный ";
            this.медианныйToolStripMenuItem.Click += new System.EventHandler(this.медианныйToolStripMenuItem_Click);
            // 
            // сдвигиToolStripMenuItem
            // 
            this.сдвигиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сдвигВЛевоToolStripMenuItem,
            this.сдвигВправоToolStripMenuItem});
            this.сдвигиToolStripMenuItem.Name = "сдвигиToolStripMenuItem";
            this.сдвигиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сдвигиToolStripMenuItem.Text = "Сдвиги";
            // 
            // сдвигВЛевоToolStripMenuItem
            // 
            this.сдвигВЛевоToolStripMenuItem.Name = "сдвигВЛевоToolStripMenuItem";
            this.сдвигВЛевоToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.сдвигВЛевоToolStripMenuItem.Text = "Сдвиг влево";
            this.сдвигВЛевоToolStripMenuItem.Click += new System.EventHandler(this.сдвигВЛевоToolStripMenuItem_Click);
            // 
            // сдвигВправоToolStripMenuItem
            // 
            this.сдвигВправоToolStripMenuItem.Name = "сдвигВправоToolStripMenuItem";
            this.сдвигВправоToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.сдвигВправоToolStripMenuItem.Text = "Сдвиг вправо";
            this.сдвигВправоToolStripMenuItem.Click += new System.EventHandler(this.сдвигВправоToolStripMenuItem_Click);
            // 
            // выделениеГраницToolStripMenuItem
            // 
            this.выделениеГраницToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операторЩарраToolStripMenuItem,
            this.операторПрюиттаToolStripMenuItem});
            this.выделениеГраницToolStripMenuItem.Name = "выделениеГраницToolStripMenuItem";
            this.выделениеГраницToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выделениеГраницToolStripMenuItem.Text = "Выделение границ";
            // 
            // операторЩарраToolStripMenuItem
            // 
            this.операторЩарраToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поОсиYToolStripMenuItem,
            this.поОсиXToolStripMenuItem});
            this.операторЩарраToolStripMenuItem.Name = "операторЩарраToolStripMenuItem";
            this.операторЩарраToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.операторЩарраToolStripMenuItem.Text = "Оператор Щарра";
            this.операторЩарраToolStripMenuItem.Click += new System.EventHandler(this.операторЩарраToolStripMenuItem_Click);
            // 
            // поОсиYToolStripMenuItem
            // 
            this.поОсиYToolStripMenuItem.Name = "поОсиYToolStripMenuItem";
            this.поОсиYToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.поОсиYToolStripMenuItem.Text = "По оси Y";
            this.поОсиYToolStripMenuItem.Click += new System.EventHandler(this.поОсиYToolStripMenuItem_Click);
            // 
            // поОсиXToolStripMenuItem
            // 
            this.поОсиXToolStripMenuItem.Name = "поОсиXToolStripMenuItem";
            this.поОсиXToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.поОсиXToolStripMenuItem.Text = "По оси X";
            this.поОсиXToolStripMenuItem.Click += new System.EventHandler(this.поОсиXToolStripMenuItem_Click);
            // 
            // операторПрюиттаToolStripMenuItem
            // 
            this.операторПрюиттаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поОсиYToolStripMenuItem1,
            this.поОсиXToolStripMenuItem1});
            this.операторПрюиттаToolStripMenuItem.Name = "операторПрюиттаToolStripMenuItem";
            this.операторПрюиттаToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.операторПрюиттаToolStripMenuItem.Text = "Оператор Прюитта";
            // 
            // поОсиYToolStripMenuItem1
            // 
            this.поОсиYToolStripMenuItem1.Name = "поОсиYToolStripMenuItem1";
            this.поОсиYToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.поОсиYToolStripMenuItem1.Text = "По оси Y";
            this.поОсиYToolStripMenuItem1.Click += new System.EventHandler(this.поОсиYToolStripMenuItem1_Click);
            // 
            // поОсиXToolStripMenuItem1
            // 
            this.поОсиXToolStripMenuItem1.Name = "поОсиXToolStripMenuItem1";
            this.поОсиXToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.поОсиXToolStripMenuItem1.Text = "По оси X";
            this.поОсиXToolStripMenuItem1.Click += new System.EventHandler(this.поОсиXToolStripMenuItem1_Click);
            // 
            // матморфологияToolStripMenuItem
            // 
            this.матморфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem});
            this.матморфологияToolStripMenuItem.Name = "матморфологияToolStripMenuItem";
            this.матморфологияToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.матморфологияToolStripMenuItem.Text = "Матморфология";
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.dilationToolStripMenuItem.Text = "dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.erosionToolStripMenuItem.Text = "erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(99, 686);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(853, 28);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(979, 683);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // эффектСтеклаToolStripMenuItem
            // 
            this.эффектСтеклаToolStripMenuItem.Name = "эффектСтеклаToolStripMenuItem";
            this.эффектСтеклаToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.эффектСтеклаToolStripMenuItem.Text = "Эффект стекла";
            this.эффектСтеклаToolStripMenuItem.Click += new System.EventHandler(this.эффектСтеклаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1215, 763);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Browser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гауссToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вышеЯркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторПоОсиYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторПоОсиXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htprjcnmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem идеальныйОтражательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem растяжениеКонтрастностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волны1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волны2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тиснениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матморфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сдвигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сдвигВЛевоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сдвигВправоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделениеГраницToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторЩарраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поОсиYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поОсиXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторПрюиттаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поОсиYToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поОсиXToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem медианныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффектСтеклаToolStripMenuItem;
    }
}

