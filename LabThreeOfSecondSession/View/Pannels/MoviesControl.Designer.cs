namespace LabThreeOfSecondSession.View.Pannels
{
    partial class MoviesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxMovie = new GroupBox();
            lableGenre = new Label();
            textBoxGenre = new TextBox();
            textBoxName = new TextBox();
            labelName = new Label();
            labelRating = new Label();
            labelYearMade = new Label();
            labelDuration = new Label();
            textBoxRating = new TextBox();
            textBoxYearMade = new TextBox();
            textBoxDuration = new TextBox();
            buttonFindTwo = new Button();
            listBoxFilms = new ListBox();
            groupBoxMovie.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMovie
            // 
            groupBoxMovie.Controls.Add(lableGenre);
            groupBoxMovie.Controls.Add(textBoxGenre);
            groupBoxMovie.Controls.Add(textBoxName);
            groupBoxMovie.Controls.Add(labelName);
            groupBoxMovie.Controls.Add(labelRating);
            groupBoxMovie.Controls.Add(labelYearMade);
            groupBoxMovie.Controls.Add(labelDuration);
            groupBoxMovie.Controls.Add(textBoxRating);
            groupBoxMovie.Controls.Add(textBoxYearMade);
            groupBoxMovie.Controls.Add(textBoxDuration);
            groupBoxMovie.Controls.Add(buttonFindTwo);
            groupBoxMovie.Controls.Add(listBoxFilms);
            groupBoxMovie.Dock = DockStyle.Fill;
            groupBoxMovie.Location = new Point(0, 0);
            groupBoxMovie.Name = "groupBoxMovie";
            groupBoxMovie.Size = new Size(742, 607);
            groupBoxMovie.TabIndex = 1;
            groupBoxMovie.TabStop = false;
            groupBoxMovie.Text = "Films";
            // 
            // lableGenre
            // 
            lableGenre.AutoSize = true;
            lableGenre.Location = new Point(305, 191);
            lableGenre.Name = "lableGenre";
            lableGenre.Size = new Size(48, 20);
            lableGenre.TabIndex = 11;
            lableGenre.Text = "Genre";
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(304, 214);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(146, 27);
            textBoxGenre.TabIndex = 10;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(304, 77);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(146, 27);
            textBoxName.TabIndex = 9;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(304, 54);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 8;
            labelName.Text = "Name";
            // 
            // labelRating
            // 
            labelRating.AutoSize = true;
            labelRating.Location = new Point(499, 54);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(52, 20);
            labelRating.TabIndex = 7;
            labelRating.Text = "Rating";
            // 
            // labelYearMade
            // 
            labelYearMade.AutoSize = true;
            labelYearMade.Location = new Point(304, 122);
            labelYearMade.Name = "labelYearMade";
            labelYearMade.Size = new Size(75, 20);
            labelYearMade.TabIndex = 6;
            labelYearMade.Text = "YearMade";
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Location = new Point(305, 264);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(67, 20);
            labelDuration.TabIndex = 5;
            labelDuration.Text = "Duration";
            // 
            // textBoxRating
            // 
            textBoxRating.Location = new Point(499, 77);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(146, 27);
            textBoxRating.TabIndex = 4;
            textBoxRating.TextChanged += textBoxRating_changed;
            // 
            // textBoxYearMade
            // 
            textBoxYearMade.Location = new Point(304, 145);
            textBoxYearMade.Name = "textBoxYearMade";
            textBoxYearMade.Size = new Size(146, 27);
            textBoxYearMade.TabIndex = 3;
            // 
            // textBoxDuration
            // 
            textBoxDuration.Location = new Point(305, 287);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(146, 27);
            textBoxDuration.TabIndex = 2;
            // 
            // buttonFindTwo
            // 
            buttonFindTwo.Location = new Point(499, 143);
            buttonFindTwo.Name = "buttonFindTwo";
            buttonFindTwo.Size = new Size(146, 29);
            buttonFindTwo.TabIndex = 1;
            buttonFindTwo.Text = "Find";
            buttonFindTwo.UseVisualStyleBackColor = true;
            buttonFindTwo.Click += btnFindRating_click;
            // 
            // listBoxFilms
            // 
            listBoxFilms.FormattingEnabled = true;
            listBoxFilms.Location = new Point(21, 52);
            listBoxFilms.Name = "listBoxFilms";
            listBoxFilms.Size = new Size(241, 284);
            listBoxFilms.TabIndex = 0;
            listBoxFilms.SelectedIndexChanged += FilmsListBox_SelectedIndexChanged;
            // 
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxMovie);
            Name = "MoviesControl";
            Size = new Size(742, 607);
            groupBoxMovie.ResumeLayout(false);
            groupBoxMovie.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMovie;
        private Label lableGenre;
        private TextBox textBoxGenre;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelRating;
        private Label labelYearMade;
        private Label labelDuration;
        private TextBox textBoxRating;
        private TextBox textBoxYearMade;
        private TextBox textBoxDuration;
        private Button buttonFindTwo;
        private ListBox listBoxFilms;
    }
}
