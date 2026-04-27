namespace LabThreeOfSecondSession.View.Pannels
{
    partial class EnumsListControl
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ValuesListBox = new ListBox();
            intValueReturn = new TextBox();
            EnumsListBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ValuesListBox);
            groupBox1.Controls.Add(intValueReturn);
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 370);
            groupBox1.TabIndex = 1;
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
            // EnumsListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "EnumsListControl";
            Size = new Size(858, 370);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox ValuesListBox;
        private TextBox intValueReturn;
        private ListBox EnumsListBox;
    }
}
