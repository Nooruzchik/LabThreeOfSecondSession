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
            groupBox1 = new GroupBox();
            listBoxFilms = new ListBox();
            buttonFindTwo = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            labelDuration = new Label();
            labelYearMade = new Label();
            labelRating = new Label();
            tabPageClasses.SuspendLayout();
            tabPage1.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageClasses
            // 
            tabPageClasses.Controls.Add(tabPage1);
            tabPageClasses.Controls.Add(tabPage2);
            tabPageClasses.Dock = DockStyle.Fill;
            tabPageClasses.Location = new Point(0, 0);
            tabPageClasses.Name = "tabPageClasses";
            tabPageClasses.SelectedIndex = 0;
            tabPageClasses.Size = new Size(800, 450);
            tabPageClasses.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(RectanglesGroupBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
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
            RectanglesGroupBox.Size = new Size(786, 411);
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
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Movies";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelRating);
            groupBox1.Controls.Add(labelYearMade);
            groupBox1.Controls.Add(labelDuration);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(buttonFindTwo);
            groupBox1.Controls.Add(listBoxFilms);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(792, 417);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Films";
            // 
            // listBoxFilms
            // 
            listBoxFilms.FormattingEnabled = true;
            listBoxFilms.Location = new Point(21, 52);
            listBoxFilms.Name = "listBoxFilms";
            listBoxFilms.Size = new Size(241, 284);
            listBoxFilms.TabIndex = 0;
            // 
            // buttonFindTwo
            // 
            buttonFindTwo.Location = new Point(304, 307);
            buttonFindTwo.Name = "buttonFindTwo";
            buttonFindTwo.Size = new Size(146, 29);
            buttonFindTwo.TabIndex = 1;
            buttonFindTwo.Text = "Find";
            buttonFindTwo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(304, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(304, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(304, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 27);
            textBox3.TabIndex = 4;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Location = new Point(304, 52);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(67, 20);
            labelDuration.TabIndex = 5;
            labelDuration.Text = "Duration";
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
            // labelRating
            // 
            labelRating.AutoSize = true;
            labelRating.Location = new Point(304, 206);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(52, 20);
            labelRating.TabIndex = 7;
            labelRating.Text = "Rating";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabPageClasses);
            Name = "MainForm";
            Text = "Form1";
            tabPageClasses.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            tabPage2.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private Label labelRating;
        private Label labelYearMade;
        private Label labelDuration;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button buttonFindTwo;
        private ListBox listBoxFilms;
    }
}
