namespace EventDrivenProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball() { Id = 33 };
          

            ball.BallLocation = new Location(3, 7, 9);

            Console.WriteLine(ball.BallLocation);

            Player p1 = new Player() { Id = 3, Name = "gg", Team = "hhh" };

            Player p2 = new Player() { Id = 5, Name = "dg", Team = "yyy" };

            Player p3 = new Player() { Id = 13, Name = "ff", Team = "ll" };


            Player p4= new Player() { Id = 12, Name = "aaa", Team = "uu" };

            ball.BallLocationChanged += p1.Run;
            ball.BallLocationChanged += p2.Run;
            ball.BallLocationChanged += p3.Run;
            ball.BallLocationChanged += p4.Run;

            Console.WriteLine("after event firing");
            ball.BallLocation = new Location(32, 17, 93);

            Console.WriteLine(ball.BallLocation);

            Refree r1 = new Refree() { Id = 44, Name = "lklk" };
            ball.BallLocationChanged += r1.Look;
        }
    }
}
