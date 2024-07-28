namespace Basketball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasketballPlayer player = new BasketballPlayer(23, "Forward", "LeBron", "James", 27.1);

            // Access and update using index
            player[2] = "Kobe";
            Console.WriteLine(player[0]); // JerseyNumber
            Console.WriteLine(player[1]); // Position
            Console.WriteLine(player[2]); // FirstName
            Console.WriteLine(player[3]); // LastName
            Console.WriteLine(player[4]); // PointsPerGame

            // Update and access using attribute name
            player["pointspergame"] = 30.1;
            Console.WriteLine("Jersey Number: " + player["jerseynumber"]);
            Console.WriteLine("Position: " + player["position"]);
            Console.WriteLine("First Name: " + player["firstname"]);
            Console.WriteLine("Last Name: " + player["lastname"]);
            Console.WriteLine("Points Per Game: " + player["pointspergame"]);
        }
    }
}