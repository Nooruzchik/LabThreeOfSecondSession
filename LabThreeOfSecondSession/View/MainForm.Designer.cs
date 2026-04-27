namespace LabThreeOfSecondSession
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPageClasses = new TabControl();
            tabPage1 = new TabPage();
            RectanglesGroupBox = new GroupBox();
            labelId = new Label();
            textBoxId = new TextBox();
            labelY = new Label();
            labelX = new Label();
            textBoxCenterY = new TextBox();
            textBoxCenterX = new TextBox();
            buttonFind = new Button();
            textBoxColor = new TextBox();
            textBoxWidth = new TextBox();
            textBoxLength = new TextBox();
            listBoxRectangles = new ListBox();
            labelColor = new Label();
            labelWidth = new Label();
            labelLength = new Label();
            tabPage2 = new TabPage();
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
            tabPage3 = new TabPage();
            seasonsControl1 = new LabThreeOfSecondSession.View.Pannels.SeasonsControl();
            weekdayParseControl1 = new LabThreeOfSecondSession.View.Pannels.WeekdayParseControl();
            enumsListControl1 = new LabThreeOfSecondSession.View.Pannels.EnumsListControl();
            tabPage4 = new TabPage();
            rectanglesCollisionControl1 = new LabThreeOfSecondSession.View.RectanglesCollisionControl();
            tabPageClasses.SuspendLayout();
            tabPage1.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBoxMovie.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageClasses
            // 
            tabPageClasses.Controls.Add(tabPage1);
            tabPageClasses.Controls.Add(tabPage2);
            tabPageClasses.Controls.Add(tabPage3);
            tabPageClasses.Controls.Add(tabPage4);
            tabPageClasses.Dock = DockStyle.Fill;
            tabPageClasses.Location = new Point(0, 0);
            tabPageClasses.Name = "tabPageClasses";
            tabPageClasses.SelectedIndex = 0;
            tabPageClasses.Size = new Size(857, 649);
            tabPageClasses.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(RectanglesGroupBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(849, 616);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Classes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(labelId);
            RectanglesGroupBox.Controls.Add(textBoxId);
            RectanglesGroupBox.Controls.Add(labelY);
            RectanglesGroupBox.Controls.Add(labelX);
            RectanglesGroupBox.Controls.Add(textBoxCenterY);
            RectanglesGroupBox.Controls.Add(textBoxCenterX);
            RectanglesGroupBox.Controls.Add(buttonFind);
            RectanglesGroupBox.Controls.Add(textBoxColor);
            RectanglesGroupBox.Controls.Add(textBoxWidth);
            RectanglesGroupBox.Controls.Add(textBoxLength);
            RectanglesGroupBox.Controls.Add(listBoxRectangles);
            RectanglesGroupBox.Controls.Add(labelColor);
            RectanglesGroupBox.Controls.Add(labelWidth);
            RectanglesGroupBox.Controls.Add(labelLength);
            RectanglesGroupBox.Dock = DockStyle.Fill;
            RectanglesGroupBox.Location = new Point(3, 3);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(843, 610);
            RectanglesGroupBox.TabIndex = 0;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(539, 191);
            labelId.Name = "labelId";
            labelId.Size = new Size(22, 20);
            labelId.TabIndex = 13;
            labelId.Text = "Id";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(539, 227);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(84, 27);
            textBoxId.TabIndex = 12;
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(539, 106);
            labelY.Name = "labelY";
            labelY.Size = new Size(64, 20);
            labelY.TabIndex = 11;
            labelY.Text = "Center Y";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(539, 37);
            labelX.Name = "labelX";
            labelX.Size = new Size(65, 20);
            labelX.TabIndex = 10;
            labelX.Text = "Center X";
            // 
            // textBoxCenterY
            // 
            textBoxCenterY.Location = new Point(539, 143);
            textBoxCenterY.Name = "textBoxCenterY";
            textBoxCenterY.ReadOnly = true;
            textBoxCenterY.Size = new Size(84, 27);
            textBoxCenterY.TabIndex = 9;
            // 
            // textBoxCenterX
            // 
            textBoxCenterX.Location = new Point(539, 64);
            textBoxCenterX.Name = "textBoxCenterX";
            textBoxCenterX.ReadOnly = true;
            textBoxCenterX.Size = new Size(84, 27);
            textBoxCenterX.TabIndex = 8;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(317, 296);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(151, 29);
            buttonFind.TabIndex = 7;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += btnFind_click;
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(317, 227);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(151, 27);
            textBoxColor.TabIndex = 6;
            textBoxColor.TextChanged += textBoxColor_TextChanged;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(317, 143);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(151, 27);
            textBoxWidth.TabIndex = 5;
            textBoxWidth.TextChanged += textBoxWidth_changed;
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(317, 64);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(151, 27);
            textBoxLength.TabIndex = 4;
            textBoxLength.TextChanged += textBoxLength_changed;
            // 
            // listBoxRectangles
            // 
            listBoxRectangles.FormattingEnabled = true;
            listBoxRectangles.Location = new Point(20, 41);
            listBoxRectangles.Name = "listBoxRectangles";
            listBoxRectangles.Size = new Size(227, 284);
            listBoxRectangles.TabIndex = 3;
            listBoxRectangles.SelectedIndexChanged += RectangleListBox_SelectedIndexChanged;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(317, 191);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(45, 20);
            labelColor.TabIndex = 2;
            labelColor.Text = "Color";
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(317, 106);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(49, 20);
            labelWidth.TabIndex = 1;
            labelWidth.Text = "Width";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(317, 41);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(54, 20);
            labelLength.TabIndex = 0;
            labelLength.Text = "Length";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBoxMovie);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(849, 616);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Movies";
            tabPage2.UseVisualStyleBackColor = true;
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
            groupBoxMovie.Size = new Size(849, 616);
            groupBoxMovie.TabIndex = 0;
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
            // tabPage3
            // 
            tabPage3.Controls.Add(seasonsControl1);
            tabPage3.Controls.Add(weekdayParseControl1);
            tabPage3.Controls.Add(enumsListControl1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(849, 616);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Enums";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // seasonsControl1
            // 
            seasonsControl1.Location = new Point(461, 365);
            seasonsControl1.Name = "seasonsControl1";
            seasonsControl1.Size = new Size(392, 344);
            seasonsControl1.TabIndex = 4;
            // 
            // weekdayParseControl1
            // 
            weekdayParseControl1.Location = new Point(0, 365);
            weekdayParseControl1.Name = "weekdayParseControl1";
            weekdayParseControl1.Size = new Size(455, 248);
            weekdayParseControl1.TabIndex = 3;
            // 
            // enumsListControl1
            // 
            enumsListControl1.Location = new Point(0, 0);
            enumsListControl1.Name = "enumsListControl1";
            enumsListControl1.Size = new Size(853, 368);
            enumsListControl1.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(rectanglesCollisionControl1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(849, 616);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Rectangles";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(0, 0);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(849, 616);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 649);
            Controls.Add(tabPageClasses);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabPageClasses.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBoxMovie.ResumeLayout(false);
            groupBoxMovie.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPageClasses;
        private TabPage tabPage1;
        private GroupBox RectanglesGroupBox;
        private Button buttonFind;
        private TextBox textBoxColor;
        private TextBox textBoxWidth;
        private TextBox textBoxLength;
        private ListBox listBoxRectangles;
        private Label labelColor;
        private Label labelWidth;
        private Label labelLength;
        private TabPage tabPage2;
        private GroupBox groupBoxMovie;
        private Label labelRating;
        private Label labelYearMade;
        private Label labelDuration;
        private TextBox textBoxRating;
        private TextBox textBoxYearMade;
        private TextBox textBoxDuration;
        private Button buttonFindTwo;
        private ListBox listBoxFilms;
        private TextBox textBoxName;
        private Label labelName;
        private Label lableGenre;
        private TextBox textBoxGenre;
        private TabPage tabPage3;
        private Label labelX;
        private TextBox textBoxCenterY;
        private TextBox textBoxCenterX;
        private Label labelY;
        private Label labelId;
        private TextBox textBoxId;
        private TabPage tabPage4;
        private View.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Pannels.EnumsListControl enumsListControl1;
        private View.Pannels.WeekdayParseControl weekdayParseControl1;
        private View.Pannels.SeasonsControl seasonsControl1;
    }
}
