using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Timers;
using System.Numerics;

namespace Incremental
{
    public partial class Form_MainMenu : Form
    {
        public static Game game;
        public static String savePath = Environment.CurrentDirectory + "\\GameSave.txt";
        public static DateTime lastTick;
        public static int saveInterval = 2500;
        public static int saveIntervalRemaining = saveInterval;
        public static List<EnemyBox> enemyBoxs = new List<EnemyBox>();
        public static FormCharacterCreation characterCreationForm;
        public static List<RadioButton> skillButtons = new List<RadioButton>();
        System.Timers.Timer myTimer;

        public Form_MainMenu()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void Button_CreateCharacter_Click(object sender, EventArgs e)
        {
            FormCharacterCreation characterCreator = new FormCharacterCreation();
            characterCreator.mainMenu = this;
            characterCreator.Show();
            characterCreationForm = characterCreator;
        }

        private void Label_GameTitle_Click(object sender, EventArgs e)
        {

        }

        private void Button_LoadGame_Click(object sender, EventArgs e)
        {
            if(characterCreationForm != null)
            {
                characterCreationForm.Close();
                characterCreationForm = null;
            }
            Character load = LoadGame();
            if(load == null)
            {
                MessageBox.Show("No save file found, create a new character!");
            }
            else
            {
                StartGame(load, false);
            }

        }

        private Character LoadGame()
        {
            Console.WriteLine("Loading game");
            if (File.Exists(savePath))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Character));
                StreamReader reader = new StreamReader(savePath);
                var input = xml.Deserialize(reader);
                if(input.GetType() == typeof(Character))
                {
                    Character loadedCharacter = (Character) input;
                    loadedCharacter.PostReadFromFile();
                    reader.Close();
                    return loadedCharacter;
                }
                reader.Close();
                return null;
            }
            else
            {
                Console.WriteLine("File not found at: " + savePath);
                return null;
            }
        }

        private void SaveGame(Character c)
        {
            Console.WriteLine("Saving game");
            if(File.GetLastAccessTime(savePath) != DateTime.Now)
            {
                File.Delete(savePath);
                Stream stream = File.OpenWrite(savePath);
                XmlSerializer xml = new XmlSerializer(typeof(Character));
                c.PrepareToWrite();
                xml.Serialize(stream, c);
                stream.Close();
            }
        }

        public void StartGame(Character c, bool shouldSave)
        {
            if(shouldSave)
            {
                SaveGame(c);
            }
            else
            {
                MessageBox.Show("starting game with character: \n" + c.CharacterToString());
            }
            Button_CreateCharacter.Hide();
            Button_CreateCharacter.Enabled = false;
            Button_LoadGame.Hide();
            Button_LoadGame.Enabled = false;
            Label_GameTitle.Hide();

            PanelMain.Show();

            game = new Game(this, c);
            InitSkillButtons();
            Run();
        }

        public void Run()
        {
            myTimer = new System.Timers.Timer(Game.msPerUpdate);
            lastTick = DateTime.Now;
            myTimer.Elapsed += UpdateMethod;
            myTimer.AutoReset = true;
            myTimer.Enabled = true;
            Render();
        }

        private void InitSkillButtons()
        {
            for (int i = 0; i < Enum.GetValues(typeof(SkillType)).Length; i++)
            {
                SkillType type = (SkillType) Enum.GetValues(typeof(SkillType)).GetValue(i);
                Skills.GetValues(type, out string name, out string description, out bool ability);
                RadioButton button = new RadioButton();
                button.Text = name;
                button.AccessibleDescription = name + "\n" + description;
                tabPage3.Controls.Add(button);
                skillButtons.Add(button);
                int x, y;
                x = i % 3;
                y = i / 3;
                button.SetBounds(x * 300 + 14, y * 35 + 250, 300, 35);
            }
        }

        private void UpdateMethod(object source, ElapsedEventArgs e)
        {
            if(Game.enemies.Count == 0)
            {
                Game.MakeNewChunk();
            }
            Update((int)(e.SignalTime - lastTick).TotalMilliseconds);
            lastTick = e.SignalTime;
            Render();
        }

        private void Update(int deltaSeconds)
        {
            Game.player.skills.Update();
            myTimer.Interval = Math.Max(Game.msPerUpdate, 1);
            saveIntervalRemaining -= deltaSeconds;
            if(saveIntervalRemaining <= 0)
            {
                SaveGame(Game.player);
                saveIntervalRemaining = saveInterval;
            }

            PlayerAttackEnemy(Game.player.GetDamage());

            BigInteger playerDamage = Game.enemies[0].damage;
            if (Game.player.TakeDamage(playerDamage))
            {
                //if player dies
                Game.player.Die();
            }
        }

        private static void PlayerAttackEnemy(BigInteger damage)
        {
            BigInteger xp = Game.enemies[0].healthMax;
            if (Game.enemies[0].TakeDamage(damage))
            {
                //if enemy dies
                Game.player.GetStat(StatsEnum.VENGEANCE).AddToStatXP(-BigInteger.Pow(Number.logBase, Game.player.GetStatLevel(StatsEnum.VENGEANCE)));
                AttackType attackType = Game.player.GetAttackType();
                StatsEnum stat = AttackTypeToStat(attackType);
                if (stat != StatsEnum.VENGEANCE)
                {
                    Game.player.GetStat(stat).AddToStatXP(xp);
                }
            }
        }

        public void Render()
        {
            if (LabelTickSpeed.InvokeRequired)
            {
                LabelTickSpeed.BeginInvoke((MethodInvoker)delegate () {
                    RenderAsync();
                });
            }
            else
            {
                RenderAsync();
            }
        }

        private Enemy enemyTemp;

        private void RenderAsync()
        {
            //main tab
            PictureBoxPlayerHealth.Width = Number.clamp((int)(224 * Game.player.health / Game.player.GetHealthMax()), 0, 224);
            LabelDPS.Text = "Damage per tick: " + (Game.player.GetDamage());
            LabelPlayer.Text = Game.player.name + " " + Game.player.health + "/" + Game.player.GetHealthMax();
            ButtonAttack.Text = "Attack: " + Game.player.GetDamage();
            LabelTickSpeed.Text = "Ticks per second: " + (1000.0 / Game.msPerUpdate);
            int enemiesRemaining = Number.clamp(Game.enemies.Count - 10, 0, int.MaxValue);
            LabelEnemiesLeft.Text = "Enemies Left: " + enemiesRemaining;

            //enemies
            if(Game.enemies.Count > 0)
            {
                if(enemyTemp != Game.enemies[0])
                {
                    enemyTemp = Game.enemies[0];
                    foreach (EnemyBox box in enemyBoxs)
                    {
                        box.Dispose();
                    }
                    enemyBoxs.Clear();
                    for (int i = 0; i < 10; i++)
                    {
                        if (i < Game.enemies.Count)
                        {
                            EnemyBox box = new EnemyBox();
                            box.BringToFront();
                            if(i < Game.enemies.Count) box.UpdateEnemy(Game.enemies[i]);
                            box.SetBounds(0, 480 - i * 50, 240, 50);
                            enemyBoxs.Add(box);
                            tabPage1.Controls.Add(box);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    enemyBoxs[0].UpdateEnemy(Game.enemies[0]);
                }
            }
            
            //stats tab
            LabelAttack.Text = Game.player.GetStat(StatsEnum.ATTACK).StatToStringLong();
            LabelCharisma.Text = Game.player.GetStat(StatsEnum.CHARISMA).StatToStringLong();
            LabelToughness.Text = Game.player.GetStat(StatsEnum.TOUGHNESS).StatToStringLong();
            LabelIntelligence.Text = Game.player.GetStat(StatsEnum.INTELLIGENCE).StatToStringLong();
            LabelVengeance.Text = Game.player.GetStat(StatsEnum.VENGEANCE).StatToStringLong();
            LabelIngenuity.Text = Game.player.GetStat(StatsEnum.INGENUITY).StatToStringLong();
            LabelDexterity.Text = Game.player.GetStat(StatsEnum.DEXTERITY).StatToStringLong();
            LabelLoyalty.Text = Game.player.GetStat(StatsEnum.LOYALTY).StatToStringLong();
            LabelExperience.Text = Game.player.GetStat(StatsEnum.EXPERIENCE).StatToStringLong();

            //Skills tab
            LabelSkillPointsRemaining.Text = "Skill points remaining: " + Game.player.skills.GetSkill(SkillType.NOTALLOCATED).value;
            LabelSkillName.Text = GetSelectedRadioButtonText();
            LabelPowerLevel.Text = "Power Level: " + Game.player.GetPowerLevel();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void ButtonAttack_Click(object sender, EventArgs e)
        {
            PlayerAttackButton();
        }

        public static void PlayerAttackButton()
        {
            PlayerAttackEnemy(Game.player.GetDamage());
        }

        private static StatsEnum AttackTypeToStat(AttackType type)
        {
            switch (type)
            {
                case AttackType.MELEE:
                    return StatsEnum.ATTACK;
                case AttackType.RANGED:
                    return StatsEnum.DEXTERITY;
                case AttackType.MAGIC:
                    return StatsEnum.INTELLIGENCE;
            }
            return StatsEnum.VENGEANCE;
        }

        private SkillType GetSelectedRadioButtonSkillType()
        {
            int index = skillButtons.FindIndex(x => x.Checked);
            if(index != -1)
            {
                return (SkillType) Enum.GetValues(typeof(SkillType)).GetValue(index);

            }
            return SkillType.NOTALLOCATED;
        }

        private string GetSelectedRadioButtonText()
        {
            Skills.GetValues(GetSelectedRadioButtonSkillType(), out string name, out string description, out bool ability);
            return name + "\n" + description;
        }

        private void PurchaseSkillButton_Click(object sender, EventArgs e)
        {
            SkillType type = GetSelectedRadioButtonSkillType();
            if(type != SkillType.NOTALLOCATED)
            {
                Skill skill = Game.player.skills.GetSkill(type);
                if (skill.CanUpgrade())
                {
                    skill.Upgrade();
                }
            }
        }
    }
}
