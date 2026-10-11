using BlaisePascal.ExEnemyOrPlayer.Domain;

namespace BlaisePascal.ExEnemyOrPlayer.DomainTest
{
    public class EnemyTests
    {

        [Fact]
        public void Enemy_HealthLessThanZero()
        {
            Enemy enemy = new Enemy("Dracula", -10, 35);

            Assert.Equal(0, enemy.Health);
        }

        [Fact]
        public void Enemy_HealthMoreThanAHundred()
        {
            Enemy enemy = new Enemy("Dracula", 200, 35);

            Assert.Equal(100, enemy.Health);
        }

        [Fact]
        public void Enemy_HealthIsCorrect()
        {
            Enemy enemy = new Enemy("Dracula", 70, 35);

            Assert.Equal(70, enemy.Health);
        }

        [Fact]
        public void IsAlive_EnemyIsAlive()
        {
            Enemy enemy = new Enemy("Dracula", 70, 35);

            Assert.Equal(true, enemy.IsAlive());
        }

        [Fact]
        public void IsAlive_EnemyIsDead()
        {
            Enemy enemy = new Enemy("Dracula", 70, 35);
            enemy.TakeDamage(80);

            Assert.Equal(false, enemy.IsAlive());
        }

        [Fact]
        public void TakeDamage_HealthDecreases()
        {
            Enemy enemy = new Enemy("Dracula", 70, 35);
            enemy.TakeDamage(20);

            Assert.Equal(50, enemy.Health);
        }
    }
}