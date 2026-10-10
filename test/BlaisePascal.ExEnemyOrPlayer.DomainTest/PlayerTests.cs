using BlaisePascal.ExEnemyOrPlayer.Domain;

namespace BlaisePascal.ExEnemyOrPlayer.DomainTest
{
    public class PlayerTests
    {
        [Fact]
        public void Player_ShouldStartAtlevelOne()
        {
            // Arrange - Act (chiamata al costruttore in questo caso)
            Player player = new Player("Mario");

            Assert.Equal(1, player.Level);
        }
        

    }
}
