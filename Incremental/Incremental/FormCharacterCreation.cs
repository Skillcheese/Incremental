using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String output = "";
            String name = TextBox_CharacterName.Text;
            bool isFemale = radioButton_female.Checked;
            String startingClass = "";
            if(comboBox_class.SelectedItem != null)
            {
                startingClass = comboBox_class.SelectedItem.ToString();
            }
            bool failure = false;
            if (name != "")
            {
                output += "Name: " + name + "\n";
            }
            else
            {
                failure = true;
            }
            output += "Gender: " + (isFemale ? "Female" : "Male");
            if(startingClass != "")
            {
                output += "\nClass: " + startingClass;
            }
            else
            {
                failure = true;
            }
            if(failure)
            {
                MessageBox.Show("Please fill out all options to continue!");
            }
            else
            {
                MessageBox.Show(output);
                CLASSES characterClass = convertStringToClasses(startingClass);
                Character c = new Character(name, characterClass, isFemale);
                mainMenu.StartGame(c, true);
                Close();
            }
        }

        private CLASSES convertStringToClasses(String s)
        {
            switch (s)
            {
                case "Mage":
                    return CLASSES.MAGE;
                case "Rogue":
                    return CLASSES.ROGUE;
                case "Cleric":
                    return CLASSES.CLERIC;
                case "Paladin":
                    return CLASSES.PALADIN;
                case "Depraved":
                    return CLASSES.DEPRAVED;
                default:
                    return CLASSES.DEPRAVED;
            }
        }
    }
}
