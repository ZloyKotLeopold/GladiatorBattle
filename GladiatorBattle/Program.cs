using System;

namespace GladiatorBattle
{
    internal class Program
    {
        static void Main()
        {
            RoundModeling roundModeling = new RoundModeling();

            IFighter ahiles = new Berserker("Ахилес", 80, 18);
            IFighter thor = new Berserker("Тор", 60, 15);
            IFighter goliath = new Goliath("Голиаф", 150, 10);
            IFighter david = new Goliath("Давид", 100, 13);

            roundModeling.Modeling(ahiles, goliath);
        }
    }

    public interface IFighter : IDamageble, IIsAlive
    {
        string Name { get; }
        void Attack(IFighter fighter);
    }

    public interface IDamageble
    {
        void GiveDamage(double damage);
    }

    public interface IIsAlive
    {
        bool IsAlive();
    }

    public class RoundModeling
    {
        public void Modeling(IFighter fighter1, IFighter fighter2)
        {
            while (fighter1.IsAlive() && fighter2.IsAlive())
            {
                fighter1.Attack(fighter2);

                if (fighter2.IsAlive())
                    fighter2.Attack(fighter1);
            }

            if (fighter1.IsAlive() && fighter1.IsAlive())
            {
                Console.WriteLine("Бойцы храбро срадались но никто не победил");
            }
            else if (fighter1.IsAlive())
            {
                Console.WriteLine($"{fighter1.Name} победил!");
            }
            else
            {
                Console.WriteLine($"{fighter2.Name} победил!");
            }
        }
    }

    public class Fighter
    {
        protected string Name { get; set; }
        protected double Health { get; set; }
        protected double Damage { get; set; }

        public void GiveDamage(double damage)
        {
            Health -= damage;

            Console.WriteLine($"{Name} получает {damage} урона и осталось {Health} здоровья.");
        }

        public bool IsAlive()
        {
            return Health >= 0;
        }
    }

    public class Berserker : Fighter, IFighter
    {
        const double CoefficientDamageIncrease = 1.6;
        const double CoefficientHealthDecrease = 0.7;

        public Berserker(string name, int health, int damage)
        {
            Name = name;
            Health = health * CoefficientHealthDecrease;
            Damage = damage;
        }

        string IFighter.Name => Name;

        public void Attack(IFighter fighter)
        {
            int berserkerDamage = (int)(Damage * CoefficientDamageIncrease);

            Console.WriteLine($"{Name} атакует {fighter.Name} и наносит {berserkerDamage} урона.");

            fighter.GiveDamage(berserkerDamage);
        }
    }

    public class Goliath : Fighter, IFighter
    {
        const double CoefficientArmorIncrease = 1.6;
        const double CoefficientDamageDecrease = 0.6;
        const double CoefficientHealthIncrease = 1.3;

        public Goliath(string name, int health, int damage)
        {
            Name = name;
            Damage = damage * CoefficientDamageDecrease;
            Health = health * CoefficientHealthIncrease;
        }

        string IFighter.Name => Name;

        public void Attack(IFighter fighter)
        {
            double berserkerDamage = Damage * CoefficientArmorIncrease;

            Console.WriteLine($"{Name} атакует {fighter.Name} и наносит {berserkerDamage} урона.");

            fighter.GiveDamage(berserkerDamage);
        }
    }
}
