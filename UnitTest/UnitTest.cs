using Library;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddPlayers()
        {
            // TODO U.1
            Team team = new Team("squadra"); 
            team.AddPlayer(new Player("mario", "rossi", Player.ERole.Rosa));
            team.AddPlayer(new Player("mario", "rossi", Player.ERole.Rosa));
            team.AddPlayer(new Player("mario", "rossi", Player.ERole.Rosa));
            team.AddPlayer(new Player("mario", "rossi", Player.ERole.Rosa));
            team.AddPlayer(new Player("mario", "rossi", Player.ERole.Rosa));
            team.AddPlayer(new Player("mario", "rossi", Player.ERole.Rosa));
            team.AddPlayer(new Player("mario", "rossi", Player.ERole.Rosa));
            team.AddPlayer(new Player("mario", "rossi", Player.ERole.Rosa));
            team.AddPlayer(new Player("mario", "rossi", Player.ERole.Rosa));
            team.AddPlayer(new Player("mario", "rossi", Player.ERole.Rosa));

            Assert.IsTrue(team.AddPlayer(new Player("mario", "rossi", Player.ERole.Rosa)) == true);
            Assert.IsTrue(team.AddPlayer(new Player("mario", "rossi", Player.ERole.Rosa)) == false);

        }

        [Test]
        public void AddCaptain()
        {
            // TODO U.2
            Team team = new Team("squadra");
            Player p = new Player("mario", "rossi", Player.ERole.Riserva);
            Assert.IsTrue(team.AddCaptain(p) == false);
        }
    }
}