using System;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Collections.Generic;

namespace GladiatorBattle
{
    internal class Program
    {
        static void Main()
        {
            int strength = 0;
            int health = 0;
            int energy = 0;
            int regeneration = 0;
            int armor = 0;

            List<Thing> equipmentBerserkList = new List<Thing>
            {
                new ShlementBerserk(),
                new AmuletBerserk(),
                new ShoulderPadsBerserk(),
                new CloakBerserk(),
                new BibBerserk(),
                new BeltBerserk(),
                new PantsBerserk(),
                new BraceletBerserk(),
                new GlovesBerserk(),
                new RingBerserk(),
                new WeaponBerserk(),
                new ShoesBerserk()
            };

            /*
             * У персонажа будет рюкзак в рюкзаке будут храниться вещи их можно будет надеть это сортировка в рюкзаке
            *equipmentBerserkList.Sort((a, b) => a.GetType().Name.CompareTo(b.GetType().Name));
            */

            foreach (Thing equipment in equipmentBerserkList)
            {
                Workshop workshop = new Sharpener(equipment);
                workshop.Sharpen(300, 300, 300, 300, 300);
                equipment.ImproveThing(workshop);

                workshop = new Blacksmith(equipment);
                workshop.Forge(13);
                equipment.ImproveThing(workshop);

                strength += equipment.Strength;
                health += equipment.Health;
                energy += equipment.Energy;
                regeneration += equipment.Regeneration;
                armor += equipment.Armor;

                Console.WriteLine(
                    $"{equipment.GetType().Name}: {nameof(equipment.Strength)} = {equipment.Strength}\n" +
                    $"{equipment.GetType().Name}: {nameof(equipment.Health)} = {equipment.Health}\n" +
                    $"{equipment.GetType().Name}: {nameof(equipment.Energy)} = {equipment.Energy}\n" +
                    $"{equipment.GetType().Name}: {nameof(equipment.Regeneration)} = {equipment.Regeneration}\n" +
                    $"{equipment.GetType().Name}: {nameof(equipment.Armor)} = {equipment.Armor}\n\n");

            }

            Arena roundModeling = new Arena();

            Berserker berserk = new Berserker("Берсерк", health, strength, armor, regeneration);
            Goliath goliath = new Goliath("Голиаф", health, strength, armor, regeneration);
            Athlant athlant = new Athlant("Атлант", 1500, 250, 40, 50);
            Legionary legionary = new Legionary("Легионер", 1500, 250, 40, 50);
            Hoplite hoplite = new Hoplite("Гоплит", 1500, 250, 40, 50);

            roundModeling.Fight(berserk, goliath);
        }

        public interface IFighter
        {
            string Name { get; }

            void Attack(IFighter fighter);

            void TakeDamage();

            bool IsAlive();
        }

        public class Arena
        {
            public void Fight(IFighter fighter1, IFighter fighter2)
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

        public class Fighter : IFighter
        {
            protected string Name { get; set; }
            protected double Health { get; set; }
            protected double Damage { get; set; }
            protected double Armor { get; set; }
            protected double Regeneration { get; set; }

            string IFighter.Name => Name;

            public void TakeDamage()
            {
                double finalDamage = Damage * (1 - Armor / (Armor + Health));

                Health -= finalDamage;

                Console.WriteLine($"{Name} получает {finalDamage} урона и у него осталось {Health} здоровья.");
            }

            public void RegenirationHealth()
            {
                Health = Regeneration;
            }

            public void Attack(IFighter fighter)
            {
                RegenirationHealth();

                Console.WriteLine($"{Name} восстанавливает {Regeneration} здоровья и атакует {fighter.Name} нанося {Damage} урона.\n");

                fighter.TakeDamage();
            }

            public bool IsAlive()
            {
                return Health >= 0;
            }
        }

        public class Berserker : Fighter
        {
            const double CoefficientDamageIncrease = 1.6;
            const double CoefficientHealthDecrease = 0.7;

            public Berserker(string name, int health, int damage, int armor, int regeneration)
            {
                Name = name;
                Health = health * CoefficientHealthDecrease;
                Damage = damage * CoefficientDamageIncrease;
                Armor = armor;
                Regeneration = regeneration;
            }
        }

        public class Goliath : Fighter
        {
            const double CoefficientArmorIncrease = 1.6;
            const double CoefficientDamageDecrease = 0.6;
            const double CoefficientHealthIncrease = 1.3;

            public Goliath(string name, int health, int damage, int armor, int regeneration)
            {
                Name = name;
                Damage = damage * CoefficientDamageDecrease;
                Health = health * CoefficientHealthIncrease;
                Armor = armor * CoefficientArmorIncrease;
                Regeneration = regeneration;
            }
        }

        public class Athlant : Fighter
        {
            const double CoefficientRegenerationIncrease = 2;
            const double CoefficientDamageDecrease = 0.5;

            public Athlant(string name, int health, int damage, int armor, int regeneration)
            {
                Name = name;
                Damage = damage * CoefficientDamageDecrease;
                Health = health;
                Armor = armor;
                Regeneration = regeneration * CoefficientRegenerationIncrease;
            }
        }

        public class Legionary : Fighter
        {
            const double CoefficientAllParameters = 1.3;

            public Legionary(string name, int health, int damage, int armor, int regeneration)
            {
                Name = name;
                Damage = damage * CoefficientAllParameters;
                Health = health * CoefficientAllParameters;
                Armor = armor * CoefficientAllParameters;
                Regeneration = regeneration * CoefficientAllParameters;
            }
        }

        public class Hoplite : Fighter
        {
            const double CoefficientHealthIncrease = 1.8;
            const double CoefficientRegenerationDecrease = 0.4;

            public Hoplite(string name, int health, int damage, int armor, int regeneration)
            {
                Name = name;
                Damage = damage;
                Health = health * CoefficientHealthIncrease;
                Armor = armor;
                Regeneration = regeneration * CoefficientRegenerationDecrease;
            }
        }
    }
}