using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        List<Character> chr = new List<Character>();
        public Random ran = new Random();
        public int MaxPoints = 20;
        public int r = 0;

        internal List<Character> Chr { get => chr; set => chr = value; }

        public Form1()
        {
            InitializeComponent();
            ran = new Random();
            // List<Character> Chr = new List<Character>();

        //Chr = new List<Character>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBL_Click(object sender, EventArgs e)
        {

        }

        private void grou_Enter(object sender, EventArgs e)
        {

        }

        private void GrpStats_Enter(object sender, EventArgs e)
        {

        }

        private void BtnRoll_Click(object sender, EventArgs e)
        {
            MaxPoints = 20;
            r = 0;

            Roll();
            NudStrength.Value = r;
            Roll();
            NudIntelligence.Value = r;
            Roll();
            NudCharisma.Value = r;
            Roll();
            NudDexterity.Value = r;
            Roll();
            NudWisdom.Value = r;
            Roll();
            NudConstitution.Value = r;
            UpdatePoints();

        }

        public void Roll()
        {
            if (MaxPoints > 0)
            {
                int max = MaxPoints;
                if (max > 6) { max = 6; }
                r = ran.Next() % (max+1);
                MaxPoints -= r;
                UpdatePoints();
            }
        }

        public void UpdatePoints( NumericUpDown n = null)
        {

            decimal sum = 0;
            sum += NudConstitution.Value;
            sum += NudCharisma.Value;
            sum += NudDexterity.Value;
            sum += NudIntelligence.Value;
            sum += NudWisdom.Value;
            sum += NudStrength.Value;
            MaxPoints = 20 - (int)sum;
            if (MaxPoints < 0)
            {
                n.Value--;
                UpdatePoints(n);
            }
            else
            {
                LblPoints.Text = "Points Left: " + MaxPoints;
            }
        }
        public decimal Clamp(int num, int min = 0, int max = 20)
        {
            
            int n = num;

            if (num > max)
            {
                num = max;
            }
            if (num < min)
            {
                num = min;
            }
            

            return Convert.ToDecimal(num);
        }
        private void LblPoints_Click(object sender, EventArgs e)
        {
            
        }

        private void NudConstitution_ValueChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(NudConstitution.Value);
            UpdatePoints(NudConstitution);
        }

        private void NudStrength_ValueChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(NudStrength.Value);
            UpdatePoints(NudStrength);
        }

        private void NudDexterity_ValueChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(NudDexterity.Value);
            UpdatePoints(NudDexterity);
        }

        private void NudIntelligence_ValueChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(NudIntelligence.Value);
            UpdatePoints(NudIntelligence);
        }

        private void NudWisdom_ValueChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(NudWisdom.Value);
            UpdatePoints(NudWisdom);
        }

        private void NudCharisma_ValueChanged(object sender, EventArgs e)
        {
        int num = Convert.ToInt32(NudCharisma.Value);
        UpdatePoints(NudCharisma);
        }

        private void CbxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = CbxClass.SelectedIndex;
                 //   MessageBox.Show(Convert.ToString(i), " ");
            
            /*switch (i)
            {
                case "Cleric":
                    break;
                default:
                    LblClassSpecific1.Text = i;// "Turn Undead Uses: ";
                    break;
            }*/
            
        }

        private void actionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string firstname = TxtFirstName.Text;
            string lastname = TxtLastName.Text;
            //string race = (string)CbxRace.Items[CbxRace.SelectedIndex];
            int race = CbxRace.SelectedIndex;
            int age = (int)(NudAge.Value);
            //MessageBox.Show("jooj",Convert.ToString(CbxClass.SelectedIndex));
            Character character;// = new Character(firstname,lastname,race,age);
            int value = CbxClass.SelectedIndex, cval = (int)NudCS1.Value, i2 = CbxCS2size.SelectedIndex, i3 = CbxCS2familiar.SelectedIndex;
            string text1 = CbxCS1.GetItemText(CbxCS1.SelectedItem),
                text2 = CbxCS2size.GetItemText(CbxCS2size.SelectedItem),
                text3 = CbxCS2familiar.GetItemText(CbxCS2familiar.SelectedItem);
            switch (value)
            {
                case 0:
                    character = new Cleric(cval);
                    break;
                case 1:
                    character = new Fighter(cval);
                break;
                case 2:
                    character = new Monk(cval);
                    break;
                case 3:
                    character = new Paladin(cval);
                    break;
                case 4:
                    character = new Rogue(cval);
                    break;
                case 5:
                    character = new Sorcerer(cval);
                    break;
                case 6:
                    character = new Druid(text1);
                    break;
               
                case 7:
                    character = new Ranger(text1,text2);
                    character.patch(i2);
                    break; 
                case 8:
                    character = new Wizard(cval, text3);
                    character.patch(i3);
                    break;
                default:
                    character = new Character();
                    break;
            }
            CInit(character);
            character.SetRace(CbxRace.SelectedIndex);
            SetStats(character);
            if (firstname == "" || lastname == "")
            {
                MessageBox.Show("Enter a full name!");
            }
            else if (CbxClass.SelectedIndex == -1)
            {
                MessageBox.Show("No Class Chosen!");
            }
            else if (CbxRace.SelectedIndex == -1)
            {
                MessageBox.Show("No Race Chosen!");
            }
            else if (MaxPoints == 20)
            {
                MessageBox.Show("At least use one point. . .");
            }
            else
            {
                LbxCharacters.Items.Add(character);

                ClearMenu();
            }
        }
        void CInit(Character c)
        {
            string first = TxtFirstName.Text, last = TxtLastName.Text;
            int age = (int)NudAge.Value;
            c.SetCharacter(first, last, age);
            c.cls = CbxClass.SelectedIndex;
        }
        void SetStats(Character c) {
            int strength = (int)NudStrength.Value, dexterity = (int)NudDexterity.Value,
                charisma = (int)NudCharisma.Value, intelligence = (int)NudIntelligence.Value,
                wisdom = (int)NudWisdom.Value, constitution = (int)NudConstitution.Value;
            c.SetStats(strength, dexterity, constitution, intelligence, wisdom, charisma);
        }

        public void ClearMenu()
        {
        TxtFirstName.Text = "";
        TxtLastName.Text = "";
        NudAge.Value = 0;
        CbxRace.SelectedIndex = -1;
        CbxClass.SelectedIndex = -1;

        NudStrength.Value = 0;
        NudDexterity.Value = 0;
        NudConstitution.Value = 0;
        NudIntelligence.Value = 0;
        NudWisdom.Value = 0;
        NudCharisma.Value = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Warning!", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void LbxCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = LbxCharacters.SelectedIndex;
            if (ind != -1)
            {
                Character c = (Character)LbxCharacters.Items[ind];
                TxtFirstName.Text = c.firstname;
                TxtLastName.Text = c.lastname;
                NudAge.Value = c.Age;
                NudStrength.Value = c.str;
                NudDexterity.Value = c.dex;
                NudConstitution.Value = c.cons;
                NudIntelligence.Value = c.intel;
                NudWisdom.Value = c.wis;
                NudCharisma.Value = c.charis;
                CbxClass.SelectedIndex = c.cls;
                CbxRace.SelectedIndex = c.race;
                int num = (int)(c.GetSpecialValues()[0]);
                object[] obj = c.GetSpecialValues();
                if (num < CbxCS1.Items.Count)
                {
                    CbxCS1.SelectedIndex = num;
                }
                    NudCS1.Value = num;
                if (c.secondind != -1)
                {
                    
                    CbxCS2familiar.SelectedIndex = (c.secondind);
                    CbxCS2size.SelectedIndex = (c.secondind);
                }

            }

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LbxCharacters.SelectedIndex != -1)
            {
                LbxCharacters.Items.RemoveAt(LbxCharacters.SelectedIndex);
            }
            else
            {
                MessageBox.Show("No Character selected!","Error!");
            }
        }

        private void CbxClass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int i = CbxClass.SelectedIndex;
            NumericUpDown n1 = NudCS1;
            NumericUpDown n2;
            ComboBox c1 = CbxCS1, c2 = CbxCS2size, c3 = CbxCS2familiar;
            Label l  = LblClassSpecific1,
                  l2 = LblClassSpecific2;

            n1.Visible = true;
            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;
            l2.Text = "";
            switch (i)
            {
                case 0:
                    //Cleric.
                    l.Text = "Turn Undead Uses ";
                    
                    break;
                case 1:
                    //Fighter
                    l.Text = "Extra Feats ";
                    break;
                case 2:
                    //Monk
                    l.Text = "Extra Attacks ";
                    break;
                case 3:
                    //Paladin
                    l.Text = "Lay On Hands Uses ";
                    break;
                case 4:
                    //Rogue.
                    l.Text = "Sneak Attack Dice ";
                    break;
                case 5:
                    //Sorcerer.
                    l.Text = "Spell Slots ";
                    break;
                case 6:
                    //Druid.
                    l.Text = "Pet Race";
                    n1.Visible = false;
                    c1.Visible = true;
                    break;
                case 7:
                    //Ranger.
                    l.Text = "Pet Race";
                    l2.Text = "Pet Size";
                    n1.Visible = false;
                    c1.Visible = true;
                    c2.Visible = true;
                    break;
                case 8:
                    //Wizard.
                    l.Text = "Spells Known";
                    l2.Text = "Familiar";
                    c3.Visible = true;
                    break;
            }
        }

        private void CbxRace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblClassSpecific2_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LbxCharacters.SelectedIndex != -1)
            {
                Character character = (Character)LbxCharacters.SelectedItem;
                SetStats(character);
                character.SetRace(CbxRace.SelectedIndex);
                CInit(character);
                int num;
                if (NudCS1.Visible)
                {
                    num = (int)NudCS1.Value;
                }
                else
                {
                    num = CbxCS1.SelectedIndex;
                }
                if (character.GetSpecialValues().Length > 1)
                {
                    int num2;
                    if (CbxCS2familiar.Visible)
                    {
                        num2 = CbxCS2familiar.SelectedIndex;
                    }
                    else
                    {
                        num2 = CbxCS2size.SelectedIndex;
                    }
                    character.SetSpecialValues(num, num2);
                    character.patch(num2);
                }
                else
                {
                    character.SetSpecialValues(num);
                }
                
            }
            else
            {
                MessageBox.Show("No Character Selected!","Error!");
            }
        }

        private void characterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearMenu();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to reset everything?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ClearMenu();
                LbxCharacters.Items.Clear();
            }
        }
    }
}
