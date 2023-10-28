using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladiatorBattle
{
    public class Thing
    {
        public int Strength { get; protected set; }
        public int Health { get; protected set; }
        public int Energy { get; protected set; }
        public int Regeneration { get; protected set; }
        public int Armor { get; protected set; }

        virtual public void ImproveThing(Workshop workshop)
        {          
            Strength = workshop.Strength;
            Health = workshop.Health;
            Energy = workshop.Energy;
            Regeneration = workshop.Regeneration;
            Armor = workshop.Armor;
        }

    }

    public class ShlementBerserk : Thing
    {
        const int ConstStrength = 48;
        const int ConstHealth = 72;
        const int ConstRegeneration = 24;

        public ShlementBerserk()
        {
            Strength = ConstStrength;
            Health = ConstHealth;
            Energy = ConstRegeneration;
        }

    }

    public class HelmetGoliath : Thing
    {
        const int ConstHealth = 102;
        const int ConstRegeneration = 12;
        const int ConstArmor = 30;

        public HelmetGoliath()
        {
            Health = ConstHealth;
            Regeneration = ConstRegeneration;
            Armor = ConstArmor;
        }

    }

    public class HelmentGladiator : Thing
    {

    }

    public class HelmentAtlant : Thing
    {

    }

    public class HelmentHoplite : Thing
    {

    }


    public class AmuletBerserk : Thing
    {
        const int ConstStrength = 30;
        const int ConstEnergy = 96;
        const int ConstRegeneration = 18;

        public AmuletBerserk()
        {
            Strength = ConstStrength;
            Energy = ConstEnergy;
            Regeneration = ConstRegeneration;
        }

    }

    public class AmuletGoliath : Thing
    {
        const int ConstStrength = 24;
        const int ConstHealth = 45;
        const int ConstEnergy = 30;
        const int ConstArmor = 45;

        public AmuletGoliath()
        {
            Strength = ConstStrength;
            Health = ConstHealth;
            Energy = ConstEnergy;
            Armor = ConstArmor;
        }

    }

    public class AmuletGladiator : Thing
    {

    }

    public class AmuletAtlant : Thing
    {

    }

    public class AmuletHoplite : Thing
    {

    }


    public class ShoulderPadsBerserk : Thing
    {
        const int ConstStrength = 30;
        const int ConstHealth = 48;
        const int ConstRegeneration = 24;
        const int ConstArmor = 18;

        public ShoulderPadsBerserk()
        {
            Strength = ConstStrength;
            Health = ConstHealth;
            Regeneration = ConstRegeneration;
            Armor = ConstArmor;
        }

    }

    public class ShoulderPadsGoliath : Thing
    {
        const int ConstStrength = 24;
        const int ConstHealth = 54;
        const int ConstRegeneration = 12;
        const int ConstArmor = 30;

        public ShoulderPadsGoliath()
        {
            Strength = ConstStrength;
            Health = ConstHealth;
            Regeneration = ConstRegeneration;
            Armor = ConstArmor;
        }

    }

    public class ShoulderPadsGladiator : Thing
    {

    }

    public class ShoulderPadsAtlant : Thing
    {

    }

    public class ShoulderPadsHoplite : Thing
    {

    }


    public class CloakBerserk : Thing
    {
        const int ConstStrength = 30;
        const int ConstHealth = 18;
        const int ConstEnergy = 30;
        const int ConstRegeneration = 24;
        const int ConstArmor = 18;

        public CloakBerserk()
        {
            Strength = ConstStrength;
            Health = ConstHealth;
            Energy = ConstEnergy;
            Regeneration = ConstRegeneration;
            Armor = ConstArmor;
        }

    }

    public class CloakGoliath : Thing
    {
        const int ConstStrength = 24;
        const int ConstHealth = 30;
        const int ConstEnergy = 18;
        const int ConstRegeneration = 18;
        const int ConstArmor = 30;

        public CloakGoliath()
        {
            Strength = ConstStrength;
            Health = ConstHealth;
            Energy = ConstEnergy;
            Regeneration = ConstRegeneration;
            Armor = ConstArmor;
        }

    }

    public class CloakGladiator : Thing
    {

    }

    public class CloakAtlant : Thing
    {

    }

    public class CloakHoplite : Thing
    {

    }


    public class BibBerserk : Thing
    {
        const int ConstStrength = 48;
        const int ConstEnergy = 24;
        const int ConstArmor = 72;

        public BibBerserk()
        {
            Strength = ConstStrength;
            Energy = ConstEnergy;
            Armor = ConstArmor;
        }

    }

    public class BibGoliath : Thing
    {
        const int ConstStrength = 12;
        const int ConstHealth = 30;
        const int ConstArmor = 102;

        public BibGoliath()
        {
            Strength = ConstStrength;
            Health = ConstHealth;
            Armor = ConstArmor;
        }

    }

    public class BibGladiator : Thing
    {

    }

    public class BibAtlant : Thing
    {

    }

    public class BibHoplite : Thing
    {

    }


    public class BeltBerserk : Thing
    {
        const int ConstStrength = 30;
        const int ConstHealth = 18;
        const int ConstEnergy = 30;
        const int ConstRegeneration = 24;
        const int ConstArmor = 18;

        public BeltBerserk()
        {
            Strength = ConstStrength;
            Health = ConstHealth;
            Energy = ConstEnergy;
            Regeneration = ConstRegeneration;
            Armor = ConstArmor;
        }

    }

    public class BeltGoliath : Thing
    {
        const int ConstStrength = 24;
        const int ConstHealth = 30;
        const int ConstEnergy = 18;
        const int ConstRegeneration = 18;
        const int ConstArmor = 30;

        public BeltGoliath()
        {
            Strength = ConstStrength;
            Health = ConstHealth;
            Energy = ConstEnergy;
            Regeneration = ConstRegeneration;
            Armor = ConstArmor;
        }

    }

    public class BeltGladiator : Thing
    {

    }

    public class BeltAtlant : Thing
    {

    }

    public class BeltHoplite : Thing
    {

    }


    public class PantsBerserk : Thing
    {
        const int ConstStrength = 30;
        const int ConstEnergy = 24;
        const int ConstRegeneration = 18;
        const int ConstArmor = 48;

        public PantsBerserk()
        {
            Strength = ConstStrength;
            Energy = ConstEnergy;
            Regeneration = ConstRegeneration;
            Armor = ConstArmor;
        }

    }

    public class PantsGoliath : Thing
    {
        const int ConstStrength = 24;
        const int ConstEnergy = 24;
        const int ConstRegeneration = 18;
        const int ConstArmor = 54;

        public PantsGoliath()
        {
            Strength = ConstStrength;
            Energy = ConstEnergy;
            Regeneration = ConstRegeneration;
            Armor = ConstArmor;
        }


    }

    public class PantsGladiator : Thing
    {

    }

    public class PantsAtlant : Thing
    {

    }

    public class PantsHoplite : Thing
    {

    }


    public class BraceletBerserk : Thing
    {
        const int ConstHealth = 18;
        const int ConstEnergy = 30;
        const int ConstRegeneration = 54;
        const int ConstArmor = 18;

        public BraceletBerserk()
        {
            Health = ConstHealth;
            Energy = ConstEnergy;
            Regeneration = ConstRegeneration;
            Armor = ConstArmor;
        }

    }

    public class BraceletGoliath : Thing
    {
        const int ConstHealth = 30;
        const int ConstEnergy = 24;
        const int ConstRegeneration = 36;
        const int ConstArmor = 30;

        public BraceletGoliath()
        {
            Health = ConstHealth;
            Energy = ConstEnergy;
            Regeneration = ConstRegeneration;
            Armor = ConstArmor;
        }


    }

    public class BraceletGladiator : Thing
    {

    }

    public class BraceletAtlant : Thing
    {

    }

    public class BraceletHoplite : Thing
    {

    }


    public class GlovesBerserk : Thing
    {
        const int ConstStrength = 54;
        const int ConstEnergy = 24;
        const int ConstRegeneration = 24;
        const int ConstArmor = 18;

        public GlovesBerserk()
        {
            Strength = ConstStrength;
            Energy = ConstEnergy;
            Regeneration = ConstRegeneration;
            Armor = ConstArmor;
        }

    }

    public class GlovesGoliath : Thing
    {
        const int ConstStrength = 48;
        const int ConstEnergy = 24;
        const int ConstRegeneration = 18;
        const int ConstArmor = 30;

        public GlovesGoliath()
        {
            Strength = ConstStrength;
            Energy = ConstEnergy;
            Regeneration = ConstRegeneration;
            Armor = ConstArmor;
        }

    }

    public class GlovesGladiator : Thing
    {

    }

    public class GlovesAtlant : Thing
    {

    }

    public class GlovesHoplite : Thing
    {

    }


    public class RingBerserk : Thing
    {
        const int ConstHealth = 18;
        const int ConstEnergy = 30;
        const int ConstRegeneration = 96;

        public RingBerserk()
        {
            Health = ConstHealth;
            Energy = ConstEnergy;
            Regeneration = ConstRegeneration;
        }

    }

    public class RingGoliath : Thing
    {
        const int ConstHealth = 48;
        const int ConstEnergy = 24;
        const int ConstRegeneration = 72;

        public RingGoliath()
        {
            Health = ConstHealth;
            Energy = ConstEnergy;
            Regeneration = ConstRegeneration;
        }

    }

    public class RingGladiator : Thing
    {

    }

    public class RingAtlant : Thing
    {

    }

    public class RingHoplite : Thing
    {

    }


    public class WeaponBerserk : Thing
    {
        const int ConstStrength = 102;
        const int ConstHealth = 18;
        const int ConstEnergy = 24;

        public WeaponBerserk()
        {
            Strength = ConstStrength;
            Health = ConstHealth;
            Energy = ConstEnergy;
        }

    }

    public class WeaponGoliath : Thing
    {
        const int ConstStrength = 96;
        const int ConstHealth = 30;
        const int ConstEnergy = 18;

        public WeaponGoliath()
        {
            Strength = ConstStrength;
            Health = ConstHealth;
            Energy = ConstEnergy;
        }
       
    }

    public class WeaponGladiator : Thing
    {

    }

    public class WeaponAtlant : Thing
    {

    }

    public class WeaponHoplite : Thing
    {

    }


    public class ShoesBerserk : Thing
    {
        const int ConstStrength = 30;
        const int ConstHealth = 18;
        const int ConstEnergy = 54;
        const int ConstArmor = 18;

        public ShoesBerserk()
        {
            Strength = ConstStrength;
            Health = ConstHealth;
            Energy = ConstEnergy;
            Armor = ConstArmor;
        }


    }

    public class ShoesGoliath : Thing
    {
        const int ConstStrength = 24;
        const int ConstHealth = 30;
        const int ConstEnergy = 18;
        const int ConstArmor = 48;

        public ShoesGoliath()
        {
            Strength = ConstStrength;
            Health = ConstHealth;
            Energy = ConstEnergy;
            Armor = ConstArmor;
        }


    }

    public class ShoesGladiator : Thing
    {

    }

    public class ShoesAtlant : Thing
    {

    }

    public class ShoesHoplite : Thing
    {

    }

}
