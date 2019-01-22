using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incremental
{
    public partial class FormCharacterCreation : Form
    {
        public Form_MainMenu mainMenu;

        public FormCharacterCreation()
        {
            InitializeComponent();
        }

        private void comboBox_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            string className = comboBox_class.SelectedItem.ToString();
            Stat[] classStats = ConvertStringToClasses(className);
            string r = className + "\n";
            for(int i = 0; i < classStats.Length; i++)
            {
                Stat stat = classStats[i];
                if (stat.GetLevel() > 1)
                {
                    r += stat.name + " " + stat.GetLevel() + "\n";
                }
            }
            ClassLabel.Text = r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = TextBox_CharacterName.Text;
            bool isFemale = radioButton_female.Checked;
            string startingClass = "";
            if(comboBox_class.SelectedItem != null)
            {
                startingClass = comboBox_class.SelectedItem.ToString();
            }

            bool failure = false;

            if (name == "")
            {
                failure = true;
            }
            if(startingClass == "")
            {
                failure = true;
            }
            if(failure)
            {
                MessageBox.Show("Please fill out all options to continue!");
            }
            else
            {
                Stat[] characterClass = ConvertStringToClasses(startingClass);
                Character c = new Character(name, characterClass, isFemale);
                Gear g = new Gear("sword", new int[] {  }, new StatsEnum[] {  }, GearSlots.RIGHTHAND, 0, AttackType.MELEE);
                c.SetGearInSlot(GearSlots.RIGHTHAND, g);
                MessageBox.Show("You have created a new character!\n" + c.CharacterToString());
                mainMenu.StartGame(c, true);
                Close();
            }
        }

        private Stat[] ConvertStringToClasses(string s)
        {

            Stat[] r = new Stat[Stat.numStats];
            foreach (StatsEnum stat in StatsEnum.GetValues(typeof(StatsEnum)))
            {
                r[(int)stat] = new Stat(stat);
            }
            switch (s)
            {
                case "Mage":
                    r[(int) StatsEnum.ATTACK].AddToStatXP(BigInteger.Pow(10, 10));
                    r[(int) StatsEnum.CHARISMA].AddToStatXP(BigInteger.Pow(10, 25));
                    r[(int) StatsEnum.DEXTERITY].AddToStatXP(BigInteger.Pow(10, 15));
                    r[(int) StatsEnum.INGENUITY].AddToStatXP(BigInteger.Pow(10, 35));
                    r[(int) StatsEnum.INTELLIGENCE].AddToStatXP(BigInteger.Pow(10, 60));
                    r[(int) StatsEnum.TOUGHNESS].AddToStatXP(BigInteger.Pow(10, 20));
                    break;
                case "Rogue":
                    r[(int)StatsEnum.ATTACK].AddToStatXP(BigInteger.Pow(10, 50));
                    r[(int)StatsEnum.CHARISMA].AddToStatXP(BigInteger.Pow(10, 15));
                    r[(int)StatsEnum.DEXTERITY].AddToStatXP(BigInteger.Pow(10, 50));
                    r[(int)StatsEnum.INGENUITY].AddToStatXP(BigInteger.Pow(10, 40));
                    r[(int)StatsEnum.INTELLIGENCE].AddToStatXP(BigInteger.Pow(10, 20));
                    r[(int)StatsEnum.TOUGHNESS].AddToStatXP(BigInteger.Pow(10, 20));
                    break;
                case "Cleric":
                    r[(int)StatsEnum.ATTACK].AddToStatXP(BigInteger.Pow(10, 10));
                    r[(int)StatsEnum.CHARISMA].AddToStatXP(BigInteger.Pow(10, 25));
                    r[(int)StatsEnum.DEXTERITY].AddToStatXP(BigInteger.Pow(10, 25));
                    r[(int)StatsEnum.INGENUITY].AddToStatXP(BigInteger.Pow(10, 40));
                    r[(int)StatsEnum.INTELLIGENCE].AddToStatXP(BigInteger.Pow(10, 55));
                    r[(int)StatsEnum.TOUGHNESS].AddToStatXP(BigInteger.Pow(10, 35));
                    break;
                case "Paladin":
                    r[(int)StatsEnum.ATTACK].AddToStatXP(BigInteger.Pow(10, 50));
                    r[(int)StatsEnum.CHARISMA].AddToStatXP(BigInteger.Pow(10, 40));
                    r[(int)StatsEnum.DEXTERITY].AddToStatXP(BigInteger.Pow(10, 15));
                    r[(int)StatsEnum.INGENUITY].AddToStatXP(BigInteger.Pow(10, 40));
                    r[(int)StatsEnum.INTELLIGENCE].AddToStatXP(BigInteger.Pow(10, 50));
                    r[(int)StatsEnum.TOUGHNESS].AddToStatXP(BigInteger.Pow(10, 50));
                    break;
                case "Depraved":
                    //keep all stats at 0 xp
                    break;
                case "Warrior":
                    r[(int)StatsEnum.ATTACK].AddToStatXP(BigInteger.Pow(10, 60));
                    r[(int)StatsEnum.CHARISMA].AddToStatXP(BigInteger.Pow(10, 15));
                    r[(int)StatsEnum.DEXTERITY].AddToStatXP(BigInteger.Pow(10, 20));
                    r[(int)StatsEnum.INGENUITY].AddToStatXP(BigInteger.Pow(10, 20));
                    r[(int)StatsEnum.INTELLIGENCE].AddToStatXP(BigInteger.Pow(10, 10));
                    r[(int)StatsEnum.TOUGHNESS].AddToStatXP(BigInteger.Pow(10, 60));
                    break;
                default:
                    break;
            }
            return r;
        }
    }
}
