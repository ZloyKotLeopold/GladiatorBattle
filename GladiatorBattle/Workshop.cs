using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorBattle
{
    public class Workshop
    {
        protected Thing _thing;

        public Workshop(Thing thing)
        {
            _thing = thing;
        }

        public int Strength { get; protected set; }
        public int Health { get; protected set; }
        public int Energy { get; protected set; }
        public int Regeneration { get; protected set; }
        public int Armor { get; protected set; }

        public virtual void Sharpen
            (
            int upPercentStrength,
            int upPercentHealth,
            int upPercentEnergy,
            int upPercentRegeneration,
            int upPercentArmor
            )
        { }

        public virtual void Forge(int levelBlacksmith){ }

        protected int CalculateParameters(int baseParam, int improve)
        {
            float temp = baseParam * (1 + ((float)improve / 100));

            return (int)temp;
        }
    }

    public class Sharpener : Workshop
    {

        public Sharpener(Thing thing) : base(thing) { }

        override public void Sharpen
            (
            int upPercentStrength,
            int upPercentHealth,
            int upPercentEnergy,
            int upPercentRegeneration,
            int upPercentArmor
            )
        {
            Strength = CalculateParameters(_thing.Strength, upPercentStrength);

            Health = CalculateParameters(_thing.Health, upPercentHealth);

            Energy = CalculateParameters(_thing.Energy, upPercentEnergy);

            Regeneration = CalculateParameters(_thing.Regeneration, upPercentRegeneration);

            Armor = CalculateParameters(_thing.Armor, upPercentArmor);
        }

    }

    public class Blacksmith : Workshop
    {
        private const int MaxLevel = 13;
        private const int StepImprove = 5;

        private int _improveByLevel;

        public Blacksmith(Thing thing) : base(thing) { }

        override public void Forge(int levelBlacksmith)
        {
            if (levelBlacksmith <= MaxLevel)
            {
                for (int i = 0; i < levelBlacksmith; i++)
                    _improveByLevel += StepImprove;
            }
            else
            {
                Console.WriteLine($"Вещь нельзя улучшить больше максиматьного уровня: {MaxLevel}.");
            }

            Strength = CalculateParameters(_thing.Strength, _improveByLevel);

            Health = CalculateParameters(_thing.Health, _improveByLevel);

            Energy = CalculateParameters(_thing.Energy, _improveByLevel);

            Regeneration = CalculateParameters(_thing.Regeneration, _improveByLevel);

            Armor = CalculateParameters(_thing.Armor, _improveByLevel);

        }
    }
}
