using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    /*
    Cleric
    Fighter
    Monk
    Paladin
    Rogue
    Sorcerer
    Druid
    Ranger
    Wizard
    */
    enum PetRace
    {
        Bear,
        Cat,
        Hawk,
        Wolf
    }
    enum PetSize
    {
        small,
        medium,
        large
    }
    enum Familiar
    {
        Bat,
        Owl,
        Toad
    }
    
    class Cleric : Character
    {
        int MaxUndead;
        public Cleric(int m = 0)
        {
            MaxUndead = m;
            cls = 1;
        }
        public override object[] GetSpecialValues()
        {
            object[] set = new object[1];
            set[0] = MaxUndead;
            return set;
        }

        public override void SetSpecialValues(int num)
        {
            MaxUndead = num;
        }
    }
    class Fighter : Character
    {
        int Feats;
        public Fighter(int f)
        {
            Feats = f;
            cls = 2;
        }
        public override object[] GetSpecialValues()
        {
            object[] set = new object[1];
            set[0] = Feats;
            return set;
        }
        public override void SetSpecialValues(int num)
        {
            Feats = num;
        }
    }
    class Monk : Character
    {
        int Attacks;
        public Monk(int a)
        {
            Attacks = a;
            cls = 3;
        }
        public override object[] GetSpecialValues()
        {
            object[] set = new object[1];
            set[0] = Attacks;
            return set;
        }
        public override void SetSpecialValues(int num)
        {
            Attacks = num;
        }
    }
    class Paladin : Character
    {
        int LOH;
        public Paladin(int l)
        {
            LOH = l;
            cls = 4;
        }
        public override object[] GetSpecialValues()
        {
            object[] set = new object[1];
            set[0] = LOH;
            return set;
        }
        public override void SetSpecialValues(int num)
        {
            LOH = num;
        }
    }
    class Rogue : Character
    {
        int stealth;
        public Rogue(int s)
        {
            stealth = s;
            cls = 5;
        }
        public override object[] GetSpecialValues()
        {
            object[] set = new object[1];
            set[0] = stealth;
            return set;
        }
        public override void SetSpecialValues(int num)
        {
            stealth = num;
        }
    }
    class Sorcerer : Character
    {
        int slots;
        public Sorcerer(int s)
        {
            slots = s;
            cls = 6;
        }
        public override object[] GetSpecialValues()
        {
            object[] set = new object[1];
            set[0] = slots;
            return set;
        }
        public override void SetSpecialValues(int num)
        {
            slots = num;
        }

    }
    class Druid : Character
    {
        PetRace pet;
        AnimalCompanion companion;
        public Druid(string p = "")
        {
            multival = true;
            pet = StringToPet(p);
            companion = new AnimalCompanion(pet);
            cls = 7;
        }

        public PetRace getPet()
        {
            return pet;
        }
        class AnimalCompanion
        {
            PetRace race;
            public AnimalCompanion(PetRace p)
            {
                race = p;
            }
        }
        public override object[] GetSpecialValues()
        {
            object[] set = new object[1];
            set[0] = (int)pet;
            return set;
        }
        public override void SetSpecialValues(int num)
        {
            pet = (PetRace)num;
        }
        public override void patch(int t)
        {
            secondind = t;
        }
    }
    class Ranger : Character
    {
        PetRace pet;
        PetSize size;
        AnimalCompanion companion;
        public Ranger(string p, string s)
        {
            multival = true;
            pet = StringToPet(p);
            size = StringToSize(s);
            companion = new AnimalCompanion(pet, size);
            cls = 7;
        }
        public override void patch(int t)
        {
            secondind = t;
        }
        class AnimalCompanion
        {
            PetRace race;
            PetSize size;
            public AnimalCompanion(PetRace p, PetSize s)
            {
                race = p;
                size = s;
            }
            public void NewCompanion(PetRace p, PetSize s)
            {
                race = p;
                size = s;
            }

        }

        public override object[] GetSpecialValues()
        {
            object[] set = new object[2];
            set[0] = (int)pet;
            set[1] = (int)size;
            return set;
        }
        public override void SetSpecialValues(int num, int num2)
        {
            pet = (PetRace)num;
            size = (PetSize)num2;
            companion.NewCompanion(pet, size);
        }

    }
    class Wizard : Character
    {
        int spells;
        Familiar familiar;
        FamiliarCompanion companion;
        
        public Wizard(int s, string f)
        {
            multival = true;
            spells = s;
            familiar = StringToFam(f);
            companion = new FamiliarCompanion(familiar);
            cls = 8;
        }
        class FamiliarCompanion
        {
            Familiar type;
            public FamiliarCompanion(Familiar f = Familiar.Bat)
            {
                type = f;
            }
            public void NewCompanion(Familiar f = Familiar.Bat)
            {
                type = f;
            }

        }
        public override object[] GetSpecialValues()
        {
            object[] set = new object[2];
            set[0] = spells;
            set[1] = (int)familiar;
            return set;
        }
        public override void SetSpecialValues(int num, int num2)
        {
            spells = num;
            familiar = (Familiar)num2;
            companion.NewCompanion(familiar);
        }
        public override void patch(int t)
        {
            secondind = t;
        }
    }
    class Character
    {
        public bool multival = false;
        public string firstname, lastname;
        public int Age, str, dex, cons, intel, wis, charis, race, cls = 0, secondind;
        public virtual object[] GetSpecialValues()
        {
            return null;
        }
        public virtual void SetSpecialValues(int num, int num2)
        {

        }
        public virtual void SetSpecialValues(int num)
        {
        }
        public virtual void patch(int t)
        {
            secondind = -1;
        }

        public Character(string f = "joo", string l = "ooj", int r = 0,int a = 0)
        {
            firstname = f;
            lastname = l;
            race = r;
            Age = a;
            secondind = -1;
        }
        public void SetRace(int r)
        {
            race = r;
        }
        public void SetRace(string r)
        {
            switch (r)
            {
                case "Dwarf":
                    race = 0;
                    break;
                case "Elf":
                    race = 1;
                    break;
                case "Gnome":
                    race = 2;
                    break;
                case "HalfElf":
                    race = 3;
                    break;
                case "HalfOrc":
                    race = 4;
                    break;
                case "Halfling":
                    race = 5;
                    break;
                case "Human":
                    race = 6;
                    break;
            }
        }
        public void SetCharacter(string f = "", string l = "", int a = 0)
        {
            firstname = f;
            lastname = l;
            //race = r;
            Age = a;
        }
        public void SetStats(int s, int d, int c, int i, int w, int ch)
        {
            str = s;
            dex = d;
            cons = c;
            intel = i;
            wis = w;
            charis = ch;
        }

        public override string ToString()
        {
            return firstname + " " + lastname;
        }
        public PetRace StringToPet(string p)
        {
            PetRace pet;
            switch (p)
            {
                case "Cat":
                    pet = PetRace.Cat;
                    break;
                case "Hawk":
                    pet = PetRace.Hawk;
                    break;
                case "Wolf":
                    pet = PetRace.Wolf;
                    break;
                default:
                    pet = PetRace.Bear;
                    break;
            }

            return pet;
        }
        public PetSize StringToSize(string s)
        {
            PetSize size;

            switch (s)
            {
                case "Medium":
                    size = PetSize.medium;
                    break;
                case "Large":
                    size = PetSize.large;
                    break;
                default:
                    size = PetSize.small;
                    break;
            }
            return size;
        }
        public Familiar StringToFam(string f)
        {
            Familiar fam;

            switch (f)
            {
                default:
                    fam = Familiar.Bat;
                    break;
                case "Owl":
                    fam = Familiar.Owl;
                    break;
                case "Toad":
                    fam = Familiar.Toad;
                    break;
            }

            return fam;
        }
    }
}
