namespace LabThreeOfSecondSession.View.Pannels
{
    partial class WeekdayParseControl
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
            groupBox2 = new GroupBox();
            replaceToInt = new Label();
            textBoxForWeek = new TextBox();
            btnParse = new Button();
            label4 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(replaceToInt);
            groupBox2.Controls.Add(textBoxForWeek);
            groupBox2.Controls.Add(btnParse);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(455, 226);
            groupBox2.TabIndex = 2;
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
            btnParse.Click += buttonParse_Click;
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
            // WeekdayParseControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Name = "WeekdayParseControl";
            Size = new Size(455, 226);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label replaceToInt;
        private TextBox textBoxForWeek;
        private Button btnParse;
        private Label label4;
    }
}
