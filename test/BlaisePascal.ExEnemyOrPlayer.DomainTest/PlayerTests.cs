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

        [Fact]
        public void Player_ShouldStartWith0Experience()
        {
            Player player = new Player("Mario");

            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void Player_ShouldStartWith100MaxHealth()
        {
            Player player = new Player("Mario");

            Assert.Equal(100, player.MaxHealth);
        }

        [Fact]
        public void Player_ShouldStartWithSameHealthAsMaxHealth()
        {
            Player player = new Player("Mario");

            Assert.Equal(player.MaxHealth, player.Health);
        }

        [Fact]
        public void Player_ShouldBeAlive()
        {
            Player player = new Player("Mario");

            Assert.Equal(true, player.IsAlive);
        }

        [Fact]
        public void Player_ShouldStartWith0Gold()
        {
            Player player = new Player("Mario");

            Assert.Equal(0, player.Gold);
        }

        [Fact]
        public void AddExperience_AmountIsNegative_Exception()
        {
            Player player = new Player("Mario");

            Assert.Throws<ArgumentException>(() => player.AddExperience(-1));
        }

        [Fact]
        public void AddExperience_AmountIsZero_Exception()
        {
            Player player = new Player("Mario");

            Assert.Throws <ArgumentException> (() => player.AddExperience(0));
        }

        [Fact]
        public void AddExperience_ExperienceAdded()
        {
            Player player = new Player("Mario");
            player.AddExperience(20);

            Assert.Equal(20, player.Experience) ;
        }

        [Fact]
        public void AddExperience_AmountIsPositive_LevelChanges()
        {
            Player player = new Player("Mario");
            player.AddExperience(100);

            Assert.Equal(2, player.Experience);
        }

        [Fact]
        public void ResetExperience_ExperienceIsZero()
        {
            Player player = new Player("Mario");
            player.AddExperience(50);
            player.ResetExperience();

            Assert.Equal(0, player.Experience);
        }

        [Fact]
        public void TakeDamage_AmountIsNegative_Exception()
        {
            Player player = new Player("Mario");

            Assert.Throws<ArgumentException>(() => player.TakeDamage(-20));
        }

        [Fact]
        public void TakeDamage_AmountIsZero_Exception()
        {
            Player player = new Player("Mario");

            Assert.Throws<ArgumentException>(() => player.TakeDamage(0));
        }

        [Fact]
        public void TakeDamage_PlayerIsNotAlive_Exception()
        {
            Player player = new Player("Mario");
            player.TakeDamage(110);

            Assert.Throws<ArgumentException>(() => player.TakeDamage(20));
        }

        [Fact]
        public void TakeDamage_PlayerIsKilled()
        {
            Player player = new Player("Mario");
            player.TakeDamage(120);

            Assert.Equal(false, player.IsAlive);
        }

        [Fact]
        public void Heal_AmountIsNegative_Exception()
        {
            Player player = new Player("Mario");

            Assert.Throws<ArgumentException>(() => player.Heal(-20));
        }

        [Fact]
        public void Heal_AmountIsZero_Exception()
        {
            Player player = new Player("Mario");

            Assert.Throws<ArgumentException>(() => player.Heal(0));
        }

        [Fact]
        public void Heal_PlayerIsNotAlive_Exception()
        {
            Player player = new Player("Mario");
            player.TakeDamage(110);

            Assert.Throws<ArgumentException>(() => player.Heal(20));
        }

        [Fact]
        public void Heal_PlayerIsHealed()
        {
            Player player = new Player("Mario");
            player.TakeDamage(80);
            player.Heal(30);

            Assert.Equal(50, player.Health);
        }

        [Fact]
        public void AddGold_AmountIsNegative_Exception()
        {
            Player player = new Player("Mario");

            Assert.Throws<ArgumentException>(() => player.AddGold(-20));
        }

        [Fact]
        public void AddGold_AmountIsZero_Exception()
        {
            Player player = new Player("Mario");

            Assert.Throws<ArgumentException>(() => player.AddGold(0));
        }

        [Fact]
        public void AddGold_GoldIsAdded()
        {
            Player player = new Player("Mario");
            player.AddGold(11);

            Assert.Equal(11, player.Gold);
        }

        [Fact]
        public void ResetHealth_HealthIsTheSameAsMaxHealth()
        {
            Player player = new Player("Mario");
            player.TakeDamage(50);
            player.ResetHealth();

            Assert.Equal(player.MaxHealth, player.Health);
        }

        [Fact]
        public void ResetHealth_PlayerIsBackAlive()
        {
            Player player = new Player("Mario");
            player.TakeDamage(140);
            player.ResetHealth();

            Assert.Equal(true, player.IsAlive);
        }



    }
}
