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
            tabPageClasses.SuspendLayout();
            tabPage1.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageClasses
            // 
            tabPageClasses.Controls.Add(tabPage1);
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
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(317, 227);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(151, 27);
            textBoxColor.TabIndex = 6;
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(317, 143);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(151, 27);
            textBoxWidth.TabIndex = 5;
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new Point(317, 64);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new Size(151, 27);
            textBoxLength.TabIndex = 4;
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
    }
}
