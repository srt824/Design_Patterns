namespace Builder.Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRobotBuilder robotBuilder = new RobotBuilder();
            RobotDirector robotDirector = new RobotDirector(robotBuilder);

            robotDirector.ConstructRobot();
            Robot robot = robotBuilder.GetRobot();

            robot.DisplayRobotInfo();
        }
    }
}
