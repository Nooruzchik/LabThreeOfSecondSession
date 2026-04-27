namespace LabThreeOfSecondSession.View.Pannels
{
    partial class RectanglesControl
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
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
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
            RectanglesGroupBox.Location = new Point(0, 0);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(716, 613);
            RectanglesGroupBox.TabIndex = 1;
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
            buttonFind.TextChanged += btnFind_click;
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
            // RectanglesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectanglesGroupBox);
            Name = "RectanglesControl";
            Size = new Size(716, 613);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private Label labelId;
        private TextBox textBoxId;
        private Label labelY;
        private Label labelX;
        private TextBox textBoxCenterY;
        private TextBox textBoxCenterX;
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
