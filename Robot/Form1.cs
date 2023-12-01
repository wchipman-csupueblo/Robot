namespace Robot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Robot robot = null!;

        private void Form1_Load(object sender, EventArgs e)
        {
            //create robot object

            robot = new Robot();

            // wire Crash event of robot object 

            robot.Crash += robot =>
            {
                string message = $"You can't go further {robot.DirectionText}.";
                MessageBox.Show(message, "Crash!");
            };

            //set initial position and direction arrow
            PositionRobot();
            lblRobot.Text = robot.DirectionArrow;

        }

        private void PositionRobot(int units = 0)
        {
            robot.Go(units);
            lblRobot.Location = new Point(robot.Position.X + 100, -robot.Position.Y + 100);
            lblPosition.Text = robot.Position.ToString();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            robot.Direction = RobotDirection.N;
            lblRobot.Text = robot.DirectionArrow;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            robot.Direction = RobotDirection.S;
            lblRobot.Text = robot.DirectionArrow;
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            robot.Direction = RobotDirection.W;
            lblRobot.Text = robot.DirectionArrow;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            robot.Direction = RobotDirection.E;
            lblRobot.Text = robot.DirectionArrow;
        }

        private void btnGo1_Click(object sender, EventArgs e)
        {
            PositionRobot(1);
        }

        private void btnGo10_Click(object sender, EventArgs e)
        {
            PositionRobot(10);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}