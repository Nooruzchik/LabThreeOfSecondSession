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
            rectanglesControl1 = new LabThreeOfSecondSession.View.Pannels.RectanglesControl();
            tabPage2 = new TabPage();
            moviesControl1 = new LabThreeOfSecondSession.View.Pannels.MoviesControl();
            tabPage3 = new TabPage();
            seasonsControl1 = new LabThreeOfSecondSession.View.Pannels.SeasonsControl();
            weekdayParseControl1 = new LabThreeOfSecondSession.View.Pannels.WeekdayParseControl();
            enumsListControl1 = new LabThreeOfSecondSession.View.Pannels.EnumsListControl();
            tabPage4 = new TabPage();
            rectanglesCollisionControl1 = new LabThreeOfSecondSession.View.RectanglesCollisionControl();
            tabPage5 = new TabPage();
            listOfBooks1 = new LabThreeOfSecondSession.View.Pannels.ListOfBooks();
            tabPageClasses.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageClasses
            // 
            tabPageClasses.Controls.Add(tabPage1);
            tabPageClasses.Controls.Add(tabPage2);
            tabPageClasses.Controls.Add(tabPage3);
            tabPageClasses.Controls.Add(tabPage4);
            tabPageClasses.Controls.Add(tabPage5);
            tabPageClasses.Dock = DockStyle.Fill;
            tabPageClasses.Location = new Point(0, 0);
            tabPageClasses.Margin = new Padding(3, 2, 3, 2);
            tabPageClasses.Name = "tabPageClasses";
            tabPageClasses.SelectedIndex = 0;
            tabPageClasses.Size = new Size(740, 521);
            tabPageClasses.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(rectanglesControl1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(742, 459);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Classes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // rectanglesControl1
            // 
            rectanglesControl1.Dock = DockStyle.Fill;
            rectanglesControl1.Location = new Point(3, 2);
            rectanglesControl1.Margin = new Padding(3, 2, 3, 2);
            rectanglesControl1.Name = "rectanglesControl1";
            rectanglesControl1.Size = new Size(736, 455);
            rectanglesControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(moviesControl1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(742, 459);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Movies";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // moviesControl1
            // 
            moviesControl1.Dock = DockStyle.Fill;
            moviesControl1.Location = new Point(0, 0);
            moviesControl1.Margin = new Padding(3, 2, 3, 2);
            moviesControl1.Name = "moviesControl1";
            moviesControl1.Size = new Size(742, 459);
            moviesControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(seasonsControl1);
            tabPage3.Controls.Add(weekdayParseControl1);
            tabPage3.Controls.Add(enumsListControl1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(742, 459);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Enums";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // seasonsControl1
            // 
            seasonsControl1.BackColor = Color.White;
            seasonsControl1.Location = new Point(403, 274);
            seasonsControl1.Margin = new Padding(3, 2, 3, 2);
            seasonsControl1.Name = "seasonsControl1";
            seasonsControl1.Size = new Size(343, 258);
            seasonsControl1.TabIndex = 4;
            // 
            // weekdayParseControl1
            // 
            weekdayParseControl1.Location = new Point(0, 274);
            weekdayParseControl1.Margin = new Padding(3, 2, 3, 2);
            weekdayParseControl1.Name = "weekdayParseControl1";
            weekdayParseControl1.Size = new Size(398, 186);
            weekdayParseControl1.TabIndex = 3;
            // 
            // enumsListControl1
            // 
            enumsListControl1.Location = new Point(0, 0);
            enumsListControl1.Margin = new Padding(3, 2, 3, 2);
            enumsListControl1.Name = "enumsListControl1";
            enumsListControl1.Size = new Size(746, 276);
            enumsListControl1.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(rectanglesCollisionControl1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(742, 459);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Rectangles";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(0, 0);
            rectanglesCollisionControl1.Margin = new Padding(3, 2, 3, 2);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(742, 459);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(listOfBooks1);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(732, 493);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Book";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // listOfBooks1
            // 
            listOfBooks1.Dock = DockStyle.Fill;
            listOfBooks1.Location = new Point(0, 0);
            listOfBooks1.Name = "listOfBooks1";
            listOfBooks1.Size = new Size(732, 493);
            listOfBooks1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 521);
            Controls.Add(tabPageClasses);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabPageClasses.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPageClasses;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private View.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Pannels.EnumsListControl enumsListControl1;
        private View.Pannels.WeekdayParseControl weekdayParseControl1;
        private View.Pannels.SeasonsControl seasonsControl1;
        private View.Pannels.RectanglesControl rectanglesControl1;
        private View.Pannels.MoviesControl moviesControl1;
        private TabPage tabPage5;
        private View.Pannels.ListOfBooks listOfBooks1;
    }
}
