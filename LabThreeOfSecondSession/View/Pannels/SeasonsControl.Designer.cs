namespace LabThreeOfSecondSession.View.Pannels
{
    partial class SeasonsControl
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
            groupBox3 = new GroupBox();
            seasonComboBox = new ComboBox();
            button2 = new Button();
            label5 = new Label();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(seasonComboBox);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label5);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(397, 275);
            groupBox3.TabIndex = 2;
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
            seasonComboBox.SelectedIndexChanged += ComboBox_change;
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
            // SeasonsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Name = "SeasonsControl";
            Size = new Size(397, 275);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private ComboBox seasonComboBox;
        private Button button2;
        private Label label5;
    }
}
