namespace LabThreeOfSecondSession.View
{
    partial class RectanglesCollisionControl
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
            tabPageClasses = new TabControl();
            tabPage4 = new TabPage();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            labelIdNew = new Label();
            labelSelect = new Label();
            btnDel = new Button();
            btnAdd = new Button();
            labelRectanges = new Label();
            CanvasPanel = new Panel();
            textBoxHeight2 = new TextBox();
            textBoxWidth2 = new TextBox();
            textBoxPosY = new TextBox();
            textBoxPosX = new TextBox();
            textBoxIdNew = new TextBox();
            listBoxRectanglesNew = new ListBox();
            tabPageClasses.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageClasses
            // 
            tabPageClasses.Controls.Add(tabPage4);
            tabPageClasses.Dock = DockStyle.Fill;
            tabPageClasses.Location = new Point(0, 0);
            tabPageClasses.Name = "tabPageClasses";
            tabPageClasses.SelectedIndex = 0;
            tabPageClasses.Size = new Size(761, 705);
            tabPageClasses.TabIndex = 1;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(labelIdNew);
            tabPage4.Controls.Add(labelSelect);
            tabPage4.Controls.Add(btnDel);
            tabPage4.Controls.Add(btnAdd);
            tabPage4.Controls.Add(labelRectanges);
            tabPage4.Controls.Add(CanvasPanel);
            tabPage4.Controls.Add(textBoxHeight2);
            tabPage4.Controls.Add(textBoxWidth2);
            tabPage4.Controls.Add(textBoxPosY);
            tabPage4.Controls.Add(textBoxPosX);
            tabPage4.Controls.Add(textBoxIdNew);
            tabPage4.Controls.Add(listBoxRectanglesNew);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(753, 672);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Rectangles";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 487);
            label12.Name = "label12";
            label12.Size = new Size(54, 20);
            label12.TabIndex = 15;
            label12.Text = "Height";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 454);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 14;
            label11.Text = "Width";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 421);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 13;
            label10.Text = "Y";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 385);
            label9.Name = "label9";
            label9.Size = new Size(18, 20);
            label9.TabIndex = 12;
            label9.Text = "X";
            // 
            // labelIdNew
            // 
            labelIdNew.AutoSize = true;
            labelIdNew.Location = new Point(24, 355);
            labelIdNew.Name = "labelIdNew";
            labelIdNew.Size = new Size(22, 20);
            labelIdNew.TabIndex = 11;
            labelIdNew.Text = "Id";
            // 
            // labelSelect
            // 
            labelSelect.AutoSize = true;
            labelSelect.Location = new Point(24, 322);
            labelSelect.Name = "labelSelect";
            labelSelect.Size = new Size(136, 20);
            labelSelect.TabIndex = 10;
            labelSelect.Text = "Selected Rectangle";
            // 
            // btnDel
            // 
            btnDel.Location = new Point(176, 259);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(65, 41);
            btnDel.TabIndex = 9;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(69, 259);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(55, 41);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_click;
            // 
            // labelRectanges
            // 
            labelRectanges.AutoSize = true;
            labelRectanges.Location = new Point(24, 29);
            labelRectanges.Name = "labelRectanges";
            labelRectanges.Size = new Size(81, 20);
            labelRectanges.TabIndex = 7;
            labelRectanges.Text = "Rectangles";
            // 
            // CanvasPanel
            // 
            CanvasPanel.BorderStyle = BorderStyle.FixedSingle;
            CanvasPanel.Location = new Point(355, 29);
            CanvasPanel.Name = "CanvasPanel";
            CanvasPanel.Size = new Size(437, 513);
            CanvasPanel.TabIndex = 6;
            // 
            // textBoxHeight2
            // 
            textBoxHeight2.Location = new Point(93, 484);
            textBoxHeight2.Name = "textBoxHeight2";
            textBoxHeight2.Size = new Size(119, 27);
            textBoxHeight2.TabIndex = 5;
            textBoxHeight2.TextChanged += textBoxHeight2_TextChanged;
            // 
            // textBoxWidth2
            // 
            textBoxWidth2.Location = new Point(93, 451);
            textBoxWidth2.Name = "textBoxWidth2";
            textBoxWidth2.Size = new Size(119, 27);
            textBoxWidth2.TabIndex = 4;
            textBoxWidth2.TextChanged += textBoxWidth2_TextChanged;
            // 
            // textBoxPosY
            // 
            textBoxPosY.Location = new Point(93, 418);
            textBoxPosY.Name = "textBoxPosY";
            textBoxPosY.Size = new Size(119, 27);
            textBoxPosY.TabIndex = 3;
            textBoxPosY.TextChanged += textBoxPosY_TextChanged;
            // 
            // textBoxPosX
            // 
            textBoxPosX.Location = new Point(93, 385);
            textBoxPosX.Name = "textBoxPosX";
            textBoxPosX.Size = new Size(119, 27);
            textBoxPosX.TabIndex = 2;
            textBoxPosX.TextChanged += textBoxPosX_TextChanged;
            // 
            // textBoxIdNew
            // 
            textBoxIdNew.Location = new Point(93, 352);
            textBoxIdNew.Name = "textBoxIdNew";
            textBoxIdNew.ReadOnly = true;
            textBoxIdNew.Size = new Size(119, 27);
            textBoxIdNew.TabIndex = 1;
            // 
            // listBoxRectanglesNew
            // 
            listBoxRectanglesNew.FormattingEnabled = true;
            listBoxRectanglesNew.Location = new Point(24, 52);
            listBoxRectanglesNew.Name = "listBoxRectanglesNew";
            listBoxRectanglesNew.Size = new Size(325, 184);
            listBoxRectanglesNew.TabIndex = 0;
            listBoxRectanglesNew.SelectedIndexChanged += RectangleListBoxNew_SelectedIndexChanged;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabPageClasses);
            Name = "RectanglesCollisionControl";
            Size = new Size(761, 705);
            tabPageClasses.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPageClasses;
        private TabPage tabPage4;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label labelIdNew;
        private Label labelSelect;
        private Button btnDel;
        private Button btnAdd;
        private Label labelRectanges;
        private Panel CanvasPanel;
        private TextBox textBoxHeight2;
        private TextBox textBoxWidth2;
        private TextBox textBoxPosY;
        private TextBox textBoxPosX;
        private TextBox textBoxIdNew;
        private ListBox listBoxRectanglesNew;
    }
}
