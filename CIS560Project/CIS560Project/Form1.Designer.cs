namespace CIS560Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RatingBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReleasedBox2 = new System.Windows.Forms.TextBox();
            this.ReleasedBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenreBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CountryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DirectorNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ActorNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RatingCheckBox = new System.Windows.Forms.CheckBox();
            this.ReleaseCheckBox = new System.Windows.Forms.CheckBox();
            this.CountryCheckBox = new System.Windows.Forms.CheckBox();
            this.GenreCheckBox = new System.Windows.Forms.CheckBox();
            this.DirectCheckBox = new System.Windows.Forms.CheckBox();
            this.ActorNameCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.reportResultsBox = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Controls.Add(this.tabPage3);
            this.Tab.Location = new System.Drawing.Point(10, 1);
            this.Tab.Margin = new System.Windows.Forms.Padding(2);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(719, 461);
            this.Tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(711, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reportButton);
            this.groupBox3.Controls.Add(this.Results);
            this.groupBox3.Location = new System.Drawing.Point(464, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(265, 444);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results.";
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(3, 404);
            this.reportButton.Margin = new System.Windows.Forms.Padding(2);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(242, 27);
            this.reportButton.TabIndex = 25;
            this.reportButton.Text = "More Info";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.Location = new System.Drawing.Point(3, 18);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(242, 381);
            this.Results.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearButton);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.MovieTitleTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.RatingBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ReleasedBox2);
            this.groupBox2.Controls.Add(this.ReleasedBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.GenreBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CountryBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DirectorNameTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ActorNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(208, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(252, 444);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter search parameters.";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(4, 403);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(242, 27);
            this.ClearButton.TabIndex = 24;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(4, 372);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(242, 27);
            this.searchButton.TabIndex = 23;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Movie Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 15;
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Location = new System.Drawing.Point(22, 54);
            this.MovieTitleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.Size = new System.Drawing.Size(172, 20);
            this.MovieTitleTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rating";
            // 
            // RatingBox
            // 
            this.RatingBox.FormattingEnabled = true;
            this.RatingBox.Items.AddRange(new object[] {
            "1 Stars",
            "2 Stars",
            "3 Stars",
            "4 Stars",
            "5 Stars"});
            this.RatingBox.Location = new System.Drawing.Point(22, 339);
            this.RatingBox.Name = "RatingBox";
            this.RatingBox.Size = new System.Drawing.Size(121, 21);
            this.RatingBox.TabIndex = 12;
            this.RatingBox.Text = "Please select...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "and";
            // 
            // ReleasedBox2
            // 
            this.ReleasedBox2.Location = new System.Drawing.Point(87, 296);
            this.ReleasedBox2.Name = "ReleasedBox2";
            this.ReleasedBox2.Size = new System.Drawing.Size(34, 20);
            this.ReleasedBox2.TabIndex = 10;
            // 
            // ReleasedBox1
            // 
            this.ReleasedBox1.Location = new System.Drawing.Point(20, 295);
            this.ReleasedBox1.Name = "ReleasedBox1";
            this.ReleasedBox1.Size = new System.Drawing.Size(34, 20);
            this.ReleasedBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Released Between";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genre";
            // 
            // GenreBox
            // 
            this.GenreBox.FormattingEnabled = true;
            this.GenreBox.Items.AddRange(new object[] {
            "Action",
            "Animation",
            "Comedy",
            "Documentary",
            "Drama",
            "Horror",
            "Indie",
            "Musical",
            "Mystery",
            "Romance",
            "Sci-Fi",
            "Sports",
            "Thriller",
            "War",
            "Western"});
            this.GenreBox.Location = new System.Drawing.Point(21, 244);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(121, 21);
            this.GenreBox.TabIndex = 6;
            this.GenreBox.Text = "Please select...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Country";
            // 
            // CountryBox
            // 
            this.CountryBox.FormattingEnabled = true;
            this.CountryBox.Items.AddRange(new object[] {
            "United States",
            "Australia",
            "Canada",
            "Costa Rica",
            "France",
            "Japan",
            "Mexico",
            "United Kingdom"});
            this.CountryBox.Location = new System.Drawing.Point(20, 192);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(121, 21);
            this.CountryBox.TabIndex = 4;
            this.CountryBox.Text = "Please select...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Director Name";
            // 
            // DirectorNameTextBox
            // 
            this.DirectorNameTextBox.Location = new System.Drawing.Point(20, 149);
            this.DirectorNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DirectorNameTextBox.Name = "DirectorNameTextBox";
            this.DirectorNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.DirectorNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actor/Actress Name";
            // 
            // ActorNameTextBox
            // 
            this.ActorNameTextBox.Location = new System.Drawing.Point(20, 103);
            this.ActorNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ActorNameTextBox.Name = "ActorNameTextBox";
            this.ActorNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.ActorNameTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RatingCheckBox);
            this.groupBox1.Controls.Add(this.ReleaseCheckBox);
            this.groupBox1.Controls.Add(this.CountryCheckBox);
            this.groupBox1.Controls.Add(this.GenreCheckBox);
            this.groupBox1.Controls.Add(this.DirectCheckBox);
            this.groupBox1.Controls.Add(this.ActorNameCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(195, 444);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select your search type.";
            // 
            // RatingCheckBox
            // 
            this.RatingCheckBox.AutoSize = true;
            this.RatingCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingCheckBox.Location = new System.Drawing.Point(5, 323);
            this.RatingCheckBox.Name = "RatingCheckBox";
            this.RatingCheckBox.Size = new System.Drawing.Size(82, 28);
            this.RatingCheckBox.TabIndex = 5;
            this.RatingCheckBox.Text = "Rating";
            this.RatingCheckBox.UseVisualStyleBackColor = true;
            this.RatingCheckBox.CheckedChanged += new System.EventHandler(this.RatingCheckBox_CheckedChanged);
            // 
            // ReleaseCheckBox
            // 
            this.ReleaseCheckBox.AutoSize = true;
            this.ReleaseCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseCheckBox.Location = new System.Drawing.Point(5, 283);
            this.ReleaseCheckBox.Name = "ReleaseCheckBox";
            this.ReleaseCheckBox.Size = new System.Drawing.Size(141, 28);
            this.ReleaseCheckBox.TabIndex = 4;
            this.ReleaseCheckBox.Text = "Release Date";
            this.ReleaseCheckBox.UseVisualStyleBackColor = true;
            this.ReleaseCheckBox.CheckedChanged += new System.EventHandler(this.ReleaseCheckBox_CheckedChanged);
            // 
            // CountryCheckBox
            // 
            this.CountryCheckBox.AutoSize = true;
            this.CountryCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryCheckBox.Location = new System.Drawing.Point(5, 186);
            this.CountryCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.CountryCheckBox.Name = "CountryCheckBox";
            this.CountryCheckBox.Size = new System.Drawing.Size(94, 28);
            this.CountryCheckBox.TabIndex = 3;
            this.CountryCheckBox.Text = "Country";
            this.CountryCheckBox.UseVisualStyleBackColor = true;
            this.CountryCheckBox.CheckedChanged += new System.EventHandler(this.CountryCheckBox_CheckedChanged);
            // 
            // GenreCheckBox
            // 
            this.GenreCheckBox.AutoSize = true;
            this.GenreCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreCheckBox.Location = new System.Drawing.Point(5, 237);
            this.GenreCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenreCheckBox.Name = "GenreCheckBox";
            this.GenreCheckBox.Size = new System.Drawing.Size(82, 28);
            this.GenreCheckBox.TabIndex = 2;
            this.GenreCheckBox.Text = "Genre";
            this.GenreCheckBox.UseVisualStyleBackColor = true;
            this.GenreCheckBox.CheckedChanged += new System.EventHandler(this.GenreCheckBox_CheckedChanged);
            // 
            // DirectCheckBox
            // 
            this.DirectCheckBox.AutoSize = true;
            this.DirectCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectCheckBox.Location = new System.Drawing.Point(5, 143);
            this.DirectCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.DirectCheckBox.Name = "DirectCheckBox";
            this.DirectCheckBox.Size = new System.Drawing.Size(94, 28);
            this.DirectCheckBox.TabIndex = 1;
            this.DirectCheckBox.Text = "Director";
            this.DirectCheckBox.UseVisualStyleBackColor = true;
            this.DirectCheckBox.CheckedChanged += new System.EventHandler(this.DirectCheckBox_CheckedChanged);
            // 
            // ActorNameCheckBox
            // 
            this.ActorNameCheckBox.AutoSize = true;
            this.ActorNameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorNameCheckBox.Location = new System.Drawing.Point(4, 99);
            this.ActorNameCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ActorNameCheckBox.Name = "ActorNameCheckBox";
            this.ActorNameCheckBox.Size = new System.Drawing.Size(196, 28);
            this.ActorNameCheckBox.TabIndex = 0;
            this.ActorNameCheckBox.Text = "Actor/Actress Name";
            this.ActorNameCheckBox.UseVisualStyleBackColor = true;
            this.ActorNameCheckBox.CheckedChanged += new System.EventHandler(this.ActorNameCheckBox_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(711, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox5);
            this.groupBox4.Controls.Add(this.checkBox6);
            this.groupBox4.Controls.Add(this.checkBox7);
            this.groupBox4.Controls.Add(this.checkBox8);
            this.groupBox4.Location = new System.Drawing.Point(2, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(224, 435);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(5, 84);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 17);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(5, 106);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(80, 17);
            this.checkBox6.TabIndex = 2;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(5, 62);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(80, 17);
            this.checkBox7.TabIndex = 1;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(5, 40);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(80, 17);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.reportResultsBox);
            this.groupBox5.Location = new System.Drawing.Point(462, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(245, 439);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Report Results";
            // 
            // reportResultsBox
            // 
            this.reportResultsBox.FormattingEnabled = true;
            this.reportResultsBox.Location = new System.Drawing.Point(5, 27);
            this.reportResultsBox.Name = "reportResultsBox";
            this.reportResultsBox.Size = new System.Drawing.Size(237, 394);
            this.reportResultsBox.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Location = new System.Drawing.Point(230, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(228, 439);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 40);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(711, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Admin";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.listBox1);
            this.groupBox7.Location = new System.Drawing.Point(4, 11);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(703, 420);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Admin Page - Add, Delete, Update";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 290);
            this.listBox1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Search A Movie Title";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 473);
            this.Controls.Add(this.Tab);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Movie Database";
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ActorNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CountryCheckBox;
        private System.Windows.Forms.CheckBox GenreCheckBox;
        private System.Windows.Forms.CheckBox DirectCheckBox;
        private System.Windows.Forms.CheckBox ActorNameCheckBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CountryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DirectorNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox RatingCheckBox;
        private System.Windows.Forms.CheckBox ReleaseCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox RatingBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ReleasedBox2;
        private System.Windows.Forms.TextBox ReleasedBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox GenreBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.ListBox reportResultsBox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox1;
    }
}

