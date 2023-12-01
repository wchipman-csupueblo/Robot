namespace Robot
{
    public enum RobotDirection
    {
        N,
        S,
        E,
        W
    }
    
    public class Robot
    {
        // Private fields
        private int X;
        private int Y;
        const int MaxRange = 100;


        // public delegate and event
        public delegate void CrashHandler(Robot robot);
        public event CrashHandler Crash = null!;

        public Robot()
        {
            X = 0;
            Y = 0;
            Direction = RobotDirection.N;
        }

        // public properties
        public Point Position => new Point(X, Y);
        public RobotDirection Direction { get; set; }

        public string DirectionArrow => Direction switch
        {
            RobotDirection.S => Convert.ToChar(234).ToString(),
            RobotDirection.E => Convert.ToChar(232).ToString(),
            RobotDirection.W => Convert.ToChar(231).ToString(),
            _ => Convert.ToChar(233).ToString(),
        };
        
      
        public string DirectionText => Direction switch
        {
            RobotDirection.S => "south",
            RobotDirection.E => "east",
            RobotDirection.W => "west",
            _ => "north"
        };

        // public method
        public void Go(int distance)
        {
            switch (Direction)
            {
                case RobotDirection.N:
                    Add(distance, ref Y);
                    break;
                case RobotDirection.S:
                    Subtract(distance, ref Y);
                    break;
                case RobotDirection.W:
                    Subtract(distance, ref X);
                    break;
                case RobotDirection.E:
                    Add(distance, ref X);
                    break;
            }
        }


        //private helper methods
        private void Add(int distance, ref int axis)
        {
            axis += distance;
            if (axis > MaxRange)
            {
                axis = MaxRange;
                if (Crash != null) Crash(this);
            }
        }

        private void Subtract(int distance, ref int axis)
        {
            axis -= distance;
            if (axis < -MaxRange)
            {
                axis = -MaxRange;
                if (Crash != null) Crash(this);
            }
        }

    }
}
