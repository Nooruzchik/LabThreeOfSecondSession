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
            groupBox3 = new GroupBox();
            seasonComboBox = new ComboBox();
            button2 = new Button();
            label5 = new Label();
            groupBox2 = new GroupBox();
            replaceToInt = new Label();
            textBoxForWeek = new TextBox();
            btnParse = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ValuesListBox = new ListBox();
            intValueReturn = new TextBox();
            EnumsListBox = new ListBox();
            tabPageClasses.SuspendLayout();
            tabPage1.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBoxMovie.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageClasses
            // 
            tabPageClasses.Controls.Add(tabPage1);
            tabPageClasses.Controls.Add(tabPage2);
            tabPageClasses.Controls.Add(tabPage3);
            tabPageClasses.Dock = DockStyle.Fill;
            tabPageClasses.Location = new Point(0, 0);
            tabPageClasses.Name = "tabPageClasses";
            tabPageClasses.SelectedIndex = 0;
            tabPageClasses.Size = new Size(808, 583);
            tabPageClasses.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(RectanglesGroupBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(800, 550);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Classes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // RectanglesGroupBox
            // 
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
            RectanglesGroupBox.Size = new Size(794, 544);
            RectanglesGroupBox.TabIndex = 0;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
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
            tabPage2.Size = new Size(800, 550);
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
            groupBoxMovie.Size = new Size(800, 550);
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
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(800, 550);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Enums";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(seasonComboBox);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label5);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Location = new Point(412, 365);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(388, 185);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Season Handle";
            // 
            // seasonComboBox
            // 
            seasonComboBox.FormattingEnabled = true;
            seasonComboBox.Location = new Point(31, 62);
            seasonComboBox.Name = "seasonComboBox";
            seasonComboBox.Size = new Size(189, 28);
            seasonComboBox.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(251, 61);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Go!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += goButton_click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 39);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 1;
            label5.Text = "Choose season";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(replaceToInt);
            groupBox2.Controls.Add(textBoxForWeek);
            groupBox2.Controls.Add(btnParse);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(0, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(406, 185);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Weekday Parsing";
            // 
            // replaceToInt
            // 
            replaceToInt.AutoSize = true;
            replaceToInt.Location = new Point(20, 111);
            replaceToInt.Name = "replaceToInt";
            replaceToInt.Size = new Size(172, 20);
            replaceToInt.TabIndex = 3;
            replaceToInt.Text = "Напишите день недели";
            // 
            // textBoxForWeek
            // 
            textBoxForWeek.Location = new Point(20, 62);
            textBoxForWeek.Name = "textBoxForWeek";
            textBoxForWeek.Size = new Size(246, 27);
            textBoxForWeek.TabIndex = 2;
            // 
            // btnParse
            // 
            btnParse.Location = new Point(287, 61);
            btnParse.Name = "btnParse";
            btnParse.Size = new Size(94, 29);
            btnParse.TabIndex = 1;
            btnParse.Text = "Parse";
            btnParse.UseVisualStyleBackColor = true;
            btnParse.MouseClick += buttonParse_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 39);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 0;
            label4.Text = "Type value for parsing";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ValuesListBox);
            groupBox1.Controls.Add(intValueReturn);
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 365);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumeration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 25);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 6;
            label3.Text = "Int Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 32);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 5;
            label2.Text = "Choose Value";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 4;
            label1.Text = "Choose Enumeration";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(261, 55);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(203, 304);
            ValuesListBox.TabIndex = 3;
            ValuesListBox.SelectedIndexChanged += ValueListBox_Changed;
            // 
            // intValueReturn
            // 
            intValueReturn.Location = new Point(512, 55);
            intValueReturn.Name = "intValueReturn";
            intValueReturn.Size = new Size(158, 27);
            intValueReturn.TabIndex = 2;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Location = new Point(20, 55);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(204, 304);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_Changed;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 583);
            Controls.Add(tabPageClasses);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainForm_Load;
            tabPageClasses.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBoxMovie.ResumeLayout(false);
            groupBoxMovie.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ListBox ValuesListBox;
        private TextBox intValueReturn;
        private ListBox EnumsListBox;
        private ComboBox seasonComboBox;
        private Button button2;
        private Label label5;
        private TextBox textBoxForWeek;
        private Button btnParse;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label replaceToInt;
    }
}
