namespace BlaisePascal.ExEnemyOrPlayer.Domain
{
    public class Player
    {
        public string Name { get; set; }
        private int _level;
        private int _experience;
        private int _health;
        private int _maxHealth;
        public bool IsAlive { get; private set; }
        private int _gold;

        public int Level
        {
            get
            {
                return _level;
            }
            private set
            {
                if (value <= 0) { _level = 1; }
                else
                { _level = value; }
            }
        }

        public int Experience
        {
            get
            { 
                return _experience;
            }
            private set
            {
                if (value < 0) { _experience = 0; }
                else
                { _experience = value; }
            }
        }

        public int Health
        {
            get
            { 
                return _health;
            }
            private set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else if (value > _maxHealth)
                {
                    _health = _maxHealth;
                }
                else
                {
                    _health = value;
                }
            }
        }

        public int MaxHealth
        {
            get
            { 
                return _maxHealth;
            }
            private set
            {
                if(value < _health) { throw new ArgumentException("The value of the maximum health cant be less than the health"); }
                else if (value <= 0)
                {
                    _maxHealth = 100;
                }
                else
                { _maxHealth = value; }
            }
        }

        public int Gold
        {
            get
            {
                return _gold;
            }
            private set
            {
                if(value < 0)
                { _gold = 0; }
                else
                { _gold = value; }
            }
        }


        public Player(string nameOfPlayer)
        {
            Name = nameOfPlayer;
            Level = 1;
            Experience = 0;
            MaxHealth = 100;
            Health = MaxHealth;
            IsAlive = true;
            Gold = 0;
        }

        public void AddExperience(int amount)
        {
            if(amount <= 0) { throw new ArgumentException("Cant add a negative or zero amount"); }

            Experience += amount;
            while(Experience >= 100)
            {
                Level += 1;
                Experience -= 100;
            }
        }

        public void ResetExperience()
        {
            Experience = 0;
        }

        public void TakeDamage(int amount)
        {
            if (amount <= 0 || IsAlive == false) { throw new ArgumentException("Error"); }

            Health -= amount;
            if(Health == 0)
            {
                IsAlive = false;
            }
        }

        public void Heal(int amount)
        {
            if (amount <= 0 || IsAlive == false) { throw new ArgumentException("Error"); }

            Health += amount;
            if(Health > MaxHealth)
            {
                Health = MaxHealth;
            }
        }

        public void AddGold(int amount)
        {
            if (amount <= 0) { throw new ArgumentException("Cant add a negative or zero amount"); }

            Gold += amount;
        }

        public void ResetHealth()
        {
            Health = MaxHealth;
            IsAlive = true;
        }


    }
}
