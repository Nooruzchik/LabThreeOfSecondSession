using LabThreeOfSecondSession.Model;

namespace LabThreeOfSecondSession
{
    public partial class MainForm : Form
    {
        private Model.Rectangle[] _rectangles;        
        private Model.Rectangle _currentRectangle;    
        public MainForm()
        {
            InitializeComponent();

            Random rand = new Random();
            _rectangles = new Model.Rectangle[5];
            

            for (int i = 0; i < _rectangles.Length; i++)
            {
                double length = rand.Next(1, 101);
                double width = rand.Next(1, 101);
                string color = "color" + i;

                _rectangles[i] = new Model.Rectangle(length, width, color);
            }
            

            for (int i = 0; i < _rectangles.Length; i++)
            {
                listBoxRectangles.Items.Add($"Rectangle {i + 1}");
            }
        }
    }
}
