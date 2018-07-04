namespace WindowsFormsApp1
{
    partial class jeffFlix
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.groupBoxPreview = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.pictureBoxStars = new System.Windows.Forms.PictureBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.movieTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movieReleaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMovies = new System.Windows.Forms.ListView();
            this.movieGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movieLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movieRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moviePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movieDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelReleaseDate = new System.Windows.Forms.Label();
            this.textBoxReleaseDate = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxSearchBar = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.labelDescription2 = new System.Windows.Forms.Label();
            this.textBoxDescription2 = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.groupBoxPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStars)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Location = new System.Drawing.Point(104, 14);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(212, 143);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // buttonPrev
            // 
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrev.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPrev.Location = new System.Drawing.Point(104, 163);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(97, 38);
            this.buttonPrev.TabIndex = 3;
            this.buttonPrev.Text = "Prev";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNext.Location = new System.Drawing.Point(219, 163);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(97, 38);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // groupBoxPreview
            // 
            this.groupBoxPreview.BackColor = System.Drawing.Color.Maroon;
            this.groupBoxPreview.Controls.Add(this.textBoxDescription);
            this.groupBoxPreview.Controls.Add(this.labelDescription);
            this.groupBoxPreview.Controls.Add(this.buttonNext);
            this.groupBoxPreview.Controls.Add(this.pictureBoxStars);
            this.groupBoxPreview.Controls.Add(this.buttonDelete);
            this.groupBoxPreview.Controls.Add(this.buttonPrev);
            this.groupBoxPreview.Controls.Add(this.pictureBoxMain);
            this.groupBoxPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPreview.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxPreview.Location = new System.Drawing.Point(47, 66);
            this.groupBoxPreview.Name = "groupBoxPreview";
            this.groupBoxPreview.Size = new System.Drawing.Size(698, 207);
            this.groupBoxPreview.TabIndex = 5;
            this.groupBoxPreview.TabStop = false;
            this.groupBoxPreview.Text = "Preview";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.Maroon;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxDescription.Location = new System.Drawing.Point(322, 99);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(359, 92);
            this.textBoxDescription.TabIndex = 7;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(322, 67);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(141, 29);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Description:";
            // 
            // pictureBoxStars
            // 
            this.pictureBoxStars.BackColor = System.Drawing.Color.Maroon;
            this.pictureBoxStars.Location = new System.Drawing.Point(322, 14);
            this.pictureBoxStars.Name = "pictureBoxStars";
            this.pictureBoxStars.Size = new System.Drawing.Size(174, 49);
            this.pictureBoxStars.TabIndex = 1;
            this.pictureBoxStars.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Maroon;
            this.buttonDelete.Font = new System.Drawing.Font("Eras Demi ITC", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(552, 14);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(146, 37);
            this.buttonDelete.TabIndex = 39;
            this.buttonDelete.Text = "Delete This Movie";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Eras Demi ITC", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(54, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(193, 54);
            this.title.TabIndex = 6;
            this.title.Text = "Jeff-Flix";
            // 
            // movieTitle
            // 
            this.movieTitle.Text = "Movie Title";
            this.movieTitle.Width = 229;
            // 
            // movieReleaseDate
            // 
            this.movieReleaseDate.Text = "Release Date";
            this.movieReleaseDate.Width = 84;
            // 
            // listViewMovies
            // 
            this.listViewMovies.BackColor = System.Drawing.Color.Maroon;
            this.listViewMovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.movieTitle,
            this.movieReleaseDate,
            this.movieGenre,
            this.movieLocation,
            this.movieRating,
            this.moviePrice,
            this.movieDuration});
            this.listViewMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMovies.ForeColor = System.Drawing.SystemColors.Menu;
            this.listViewMovies.Location = new System.Drawing.Point(47, 315);
            this.listViewMovies.Name = "listViewMovies";
            this.listViewMovies.Size = new System.Drawing.Size(698, 261);
            this.listViewMovies.TabIndex = 7;
            this.listViewMovies.UseCompatibleStateImageBehavior = false;
            this.listViewMovies.View = System.Windows.Forms.View.Details;
            this.listViewMovies.SelectedIndexChanged += new System.EventHandler(this.listViewMovies_SelectedIndexChanged);
            // 
            // movieGenre
            // 
            this.movieGenre.Text = "Genre";
            // 
            // movieLocation
            // 
            this.movieLocation.Text = "Location";
            // 
            // movieRating
            // 
            this.movieRating.Text = "Rating";
            // 
            // moviePrice
            // 
            this.moviePrice.Text = "Price";
            // 
            // movieDuration
            // 
            this.movieDuration.Text = "Duration";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(876, 330);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(106, 20);
            this.textBoxTitle.TabIndex = 8;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(757, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add a Movie!";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Transparent;
            this.labelTitle.Location = new System.Drawing.Point(764, 331);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(41, 19);
            this.labelTitle.TabIndex = 25;
            this.labelTitle.Text = "Title";
            // 
            // labelReleaseDate
            // 
            this.labelReleaseDate.AutoSize = true;
            this.labelReleaseDate.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReleaseDate.ForeColor = System.Drawing.Color.Transparent;
            this.labelReleaseDate.Location = new System.Drawing.Point(764, 357);
            this.labelReleaseDate.Name = "labelReleaseDate";
            this.labelReleaseDate.Size = new System.Drawing.Size(106, 19);
            this.labelReleaseDate.TabIndex = 27;
            this.labelReleaseDate.Text = "Release Date";
            // 
            // textBoxReleaseDate
            // 
            this.textBoxReleaseDate.Location = new System.Drawing.Point(876, 356);
            this.textBoxReleaseDate.Multiline = true;
            this.textBoxReleaseDate.Name = "textBoxReleaseDate";
            this.textBoxReleaseDate.Size = new System.Drawing.Size(106, 20);
            this.textBoxReleaseDate.TabIndex = 26;
            this.textBoxReleaseDate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.ForeColor = System.Drawing.Color.Transparent;
            this.labelGenre.Location = new System.Drawing.Point(764, 383);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(55, 19);
            this.labelGenre.TabIndex = 29;
            this.labelGenre.Text = "Genre";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(876, 382);
            this.textBoxGenre.Multiline = true;
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(106, 20);
            this.textBoxGenre.TabIndex = 28;
            this.textBoxGenre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.ForeColor = System.Drawing.Color.Transparent;
            this.labelLocation.Location = new System.Drawing.Point(764, 409);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(75, 19);
            this.labelLocation.TabIndex = 31;
            this.labelLocation.Text = "Location";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(876, 408);
            this.textBoxLocation.Multiline = true;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(106, 20);
            this.textBoxLocation.TabIndex = 30;
            this.textBoxLocation.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.ForeColor = System.Drawing.Color.Transparent;
            this.labelRating.Location = new System.Drawing.Point(764, 435);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(58, 19);
            this.labelRating.TabIndex = 33;
            this.labelRating.Text = "Rating";
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(876, 434);
            this.textBoxRating.Multiline = true;
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(106, 20);
            this.textBoxRating.TabIndex = 32;
            this.textBoxRating.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Transparent;
            this.labelPrice.Location = new System.Drawing.Point(764, 461);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(45, 19);
            this.labelPrice.TabIndex = 35;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(876, 460);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(106, 20);
            this.textBoxPrice.TabIndex = 34;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.ForeColor = System.Drawing.Color.Transparent;
            this.labelDuration.Location = new System.Drawing.Point(764, 487);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(76, 19);
            this.labelDuration.TabIndex = 37;
            this.labelDuration.Text = "Duration";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(876, 486);
            this.textBoxDuration.Multiline = true;
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(106, 20);
            this.textBoxDuration.TabIndex = 36;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSubmit.Font = new System.Drawing.Font("Eras Demi ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(768, 536);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(214, 40);
            this.buttonSubmit.TabIndex = 38;
            this.buttonSubmit.Text = "Submit the Movie!";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxSearchBar
            // 
            this.textBoxSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchBar.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxSearchBar.Location = new System.Drawing.Point(125, 279);
            this.textBoxSearchBar.Multiline = true;
            this.textBoxSearchBar.Name = "textBoxSearchBar";
            this.textBoxSearchBar.Size = new System.Drawing.Size(620, 30);
            this.textBoxSearchBar.TabIndex = 40;
            this.textBoxSearchBar.Enter += new System.EventHandler(this.textBoxSearchBar_Enter);
            this.textBoxSearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchBar_KeyDown);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.White;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSearch.Location = new System.Drawing.Point(47, 279);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 30);
            this.buttonSearch.TabIndex = 41;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 583);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Results:";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(89, 583);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(35, 13);
            this.labelResults.TabIndex = 43;
            this.labelResults.Text = "label9";
            // 
            // labelDescription2
            // 
            this.labelDescription2.AutoSize = true;
            this.labelDescription2.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription2.ForeColor = System.Drawing.Color.Transparent;
            this.labelDescription2.Location = new System.Drawing.Point(764, 514);
            this.labelDescription2.Name = "labelDescription2";
            this.labelDescription2.Size = new System.Drawing.Size(95, 19);
            this.labelDescription2.TabIndex = 45;
            this.labelDescription2.Text = "Description";
            this.labelDescription2.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxDescription2
            // 
            this.textBoxDescription2.Location = new System.Drawing.Point(876, 513);
            this.textBoxDescription2.Multiline = true;
            this.textBoxDescription2.Name = "textBoxDescription2";
            this.textBoxDescription2.Size = new System.Drawing.Size(106, 20);
            this.textBoxDescription2.TabIndex = 44;
            this.textBoxDescription2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.Maroon;
            this.buttonLoad.Font = new System.Drawing.Font("Eras Demi ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.Color.White;
            this.buttonLoad.Location = new System.Drawing.Point(768, 66);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(154, 51);
            this.buttonLoad.TabIndex = 46;
            this.buttonLoad.Text = "Load from file";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Maroon;
            this.buttonSave.Font = new System.Drawing.Font("Eras Demi ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(768, 133);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(154, 51);
            this.buttonSave.TabIndex = 47;
            this.buttonSave.Text = "Save to file";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // jeffFlix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(994, 604);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.labelDescription2);
            this.Controls.Add(this.textBoxDescription2);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchBar);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.labelReleaseDate);
            this.Controls.Add(this.textBoxReleaseDate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.listViewMovies);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupBoxPreview);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "jeffFlix";
            this.Text = "JeffFlix";
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            this.Load += new System.EventHandler(this.jeffFlix_Load);
            this.MouseHover += new System.EventHandler(this.jeffFlix_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.groupBoxPreview.ResumeLayout(false);
            this.groupBoxPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.GroupBox groupBoxPreview;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBoxStars;
        private System.Windows.Forms.ColumnHeader movieTitle;
        private System.Windows.Forms.ColumnHeader movieReleaseDate;
        private System.Windows.Forms.ListView listViewMovies;
        private System.Windows.Forms.ColumnHeader movieLocation;
        private System.Windows.Forms.ColumnHeader movieGenre;
        private System.Windows.Forms.ColumnHeader movieRating;
        private System.Windows.Forms.ColumnHeader moviePrice;
        private System.Windows.Forms.ColumnHeader movieDuration;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelReleaseDate;
        private System.Windows.Forms.TextBox textBoxReleaseDate;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxSearchBar;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label labelDescription2;
        private System.Windows.Forms.TextBox textBoxDescription2;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

