using System;
using System.Collections.Generic;
using System.Numerics;

namespace Incremental
{
    public class Enemy
    {
        public String name;
        public int level;
        public BigInteger health, healthMax;
        public BigInteger armor;
        public BigInteger damage;
        public List<Ability> abilities;

        public Enemy()
        {
            abilities = new List<Ability>();
        }

        public Enemy(int _level)
        {
            level = _level;
            name = GetRandomEnemyName(level);
            health = healthMax = Number.GetRandomBigInteger(level * 10);
            armor = (level * 2) / 7;
            damage = level;
        }

        private static String GetRandomEnemyName(int _level)
        {
            return Names.GetRandomName(_level);
        }

        public bool TakeDamage(BigInteger damage)
        {
            damage = BigInteger.Max(damage, 1);
            BigInteger damageToTake = damage - armor;
            if (damageToTake > 0) health -= damageToTake;
            bool isDead = health <= 0;
            if(isDead)
            {
                Game.EnemyDead();
            }
            return isDead;
        }

        public static Enemy GetRandomEnemy(int _level)
        {
            Enemy r = new Enemy(_level);
            return r;
        }

        public string EnemyToString()
        {
            return "Lv " + level + " " + name + ": " + health.ToString() + "/" + healthMax.ToString() + " DPS: " + damage.ToString();
        }
    }

    public class Ability
    {
        public Ability()
        {

        }
    }
}