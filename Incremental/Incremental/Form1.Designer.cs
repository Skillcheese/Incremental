namespace Incremental
{
    partial class Form_MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainMenu));
            this.Label_GameTitle = new System.Windows.Forms.Label();
            this.Button_CreateCharacter = new System.Windows.Forms.Button();
            this.Button_LoadGame = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LabelEnemiesLeft = new System.Windows.Forms.Label();
            this.LabelTickSpeed = new System.Windows.Forms.Label();
            this.LabelPlayer = new System.Windows.Forms.Label();
            this.PictureBoxPlayerHealth = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LabelDPS = new System.Windows.Forms.Label();
            this.ButtonAttack = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LabelExperience = new System.Windows.Forms.Label();
            this.LabelLoyalty = new System.Windows.Forms.Label();
            this.LabelDexterity = new System.Windows.Forms.Label();
            this.LabelIngenuity = new System.Windows.Forms.Label();
            this.LabelVengeance = new System.Windows.Forms.Label();
            this.LabelIntelligence = new System.Windows.Forms.Label();
            this.LabelToughness = new System.Windows.Forms.Label();
            this.LabelCharisma = new System.Windows.Forms.Label();
            this.LabelAttack = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LabelSkillPointsRemaining = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelSkillName = new System.Windows.Forms.Label();
            this.PurchaseSkillButton = new System.Windows.Forms.Button();
            this.LabelPowerLevel = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPlayerHealth)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_GameTitle
            // 
            this.Label_GameTitle.AutoSize = true;
            this.Label_GameTitle.Location = new System.Drawing.Point(13, 13);
            this.Label_GameTitle.Name = "Label_GameTitle";
            this.Label_GameTitle.Size = new System.Drawing.Size(42, 13);
            this.Label_GameTitle.TabIndex = 0;
            this.Label_GameTitle.Text = "RPG++";
            this.Label_GameTitle.Click += new System.EventHandler(this.Label_GameTitle_Click);
            // 
            // Button_CreateCharacter
            // 
            this.Button_CreateCharacter.Location = new System.Drawing.Point(75, 13);
            this.Button_CreateCharacter.Name = "Button_CreateCharacter";
            this.Button_CreateCharacter.Size = new System.Drawing.Size(134, 34);
            this.Button_CreateCharacter.TabIndex = 1;
            this.Button_CreateCharacter.Text = "Create New Character";
            this.Button_CreateCharacter.UseVisualStyleBackColor = true;
            this.Button_CreateCharacter.Click += new System.EventHandler(this.Button_CreateCharacter_Click);
            // 
            // Button_LoadGame
            // 
            this.Button_LoadGame.Location = new System.Drawing.Point(215, 13);
            this.Button_LoadGame.Name = "Button_LoadGame";
            this.Button_LoadGame.Size = new System.Drawing.Size(98, 34);
            this.Button_LoadGame.TabIndex = 2;
            this.Button_LoadGame.Text = "Load Game";
            this.Button_LoadGame.UseVisualStyleBackColor = true;
            this.Button_LoadGame.Click += new System.EventHandler(this.Button_LoadGame_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.DimGray;
            this.PanelMain.Controls.Add(this.tabControl1);
            this.PanelMain.Location = new System.Drawing.Point(12, 12);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1885, 960);
            this.PanelMain.TabIndex = 3;
            this.PanelMain.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1885, 960);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LabelEnemiesLeft);
            this.tabPage1.Controls.Add(this.LabelTickSpeed);
            this.tabPage1.Controls.Add(this.LabelPlayer);
            this.tabPage1.Controls.Add(this.PictureBoxPlayerHealth);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.LabelDPS);
            this.tabPage1.Controls.Add(this.ButtonAttack);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1877, 934);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LabelEnemiesLeft
            // 
            this.LabelEnemiesLeft.AutoSize = true;
            this.LabelEnemiesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEnemiesLeft.Location = new System.Drawing.Point(6, 3);
            this.LabelEnemiesLeft.Name = "LabelEnemiesLeft";
            this.LabelEnemiesLeft.Size = new System.Drawing.Size(143, 24);
            this.LabelEnemiesLeft.TabIndex = 9;
            this.LabelEnemiesLeft.Text = "Enemies Left: ";
            // 
            // LabelTickSpeed
            // 
            this.LabelTickSpeed.AutoSize = true;
            this.LabelTickSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTickSpeed.Location = new System.Drawing.Point(666, 56);
            this.LabelTickSpeed.Name = "LabelTickSpeed";
            this.LabelTickSpeed.Size = new System.Drawing.Size(57, 20);
            this.LabelTickSpeed.TabIndex = 8;
            this.LabelTickSpeed.Text = "label1";
            // 
            // LabelPlayer
            // 
            this.LabelPlayer.AutoSize = true;
            this.LabelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlayer.Location = new System.Drawing.Point(665, 3);
            this.LabelPlayer.Name = "LabelPlayer";
            this.LabelPlayer.Size = new System.Drawing.Size(57, 20);
            this.LabelPlayer.TabIndex = 7;
            this.LabelPlayer.Text = "label1";
            // 
            // PictureBoxPlayerHealth
            // 
            this.PictureBoxPlayerHealth.BackColor = System.Drawing.Color.ForestGreen;
            this.PictureBoxPlayerHealth.Location = new System.Drawing.Point(670, 31);
            this.PictureBoxPlayerHealth.Name = "PictureBoxPlayerHealth";
            this.PictureBoxPlayerHealth.Size = new System.Drawing.Size(224, 21);
            this.PictureBoxPlayerHealth.TabIndex = 6;
            this.PictureBoxPlayerHealth.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(669, 30);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(226, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // LabelDPS
            // 
            this.LabelDPS.AutoSize = true;
            this.LabelDPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDPS.Location = new System.Drawing.Point(900, 30);
            this.LabelDPS.Name = "LabelDPS";
            this.LabelDPS.Size = new System.Drawing.Size(45, 20);
            this.LabelDPS.TabIndex = 4;
            this.LabelDPS.Text = "DPS";
            // 
            // ButtonAttack
            // 
            this.ButtonAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAttack.Location = new System.Drawing.Point(668, 79);
            this.ButtonAttack.Name = "ButtonAttack";
            this.ButtonAttack.Size = new System.Drawing.Size(226, 42);
            this.ButtonAttack.TabIndex = 2;
            this.ButtonAttack.Text = "Attack";
            this.ButtonAttack.UseVisualStyleBackColor = true;
            this.ButtonAttack.Click += new System.EventHandler(this.ButtonAttack_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LabelExperience);
            this.tabPage2.Controls.Add(this.LabelLoyalty);
            this.tabPage2.Controls.Add(this.LabelDexterity);
            this.tabPage2.Controls.Add(this.LabelIngenuity);
            this.tabPage2.Controls.Add(this.LabelVengeance);
            this.tabPage2.Controls.Add(this.LabelIntelligence);
            this.tabPage2.Controls.Add(this.LabelToughness);
            this.tabPage2.Controls.Add(this.LabelCharisma);
            this.tabPage2.Controls.Add(this.LabelAttack);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1877, 934);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stats";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LabelExperience
            // 
            this.LabelExperience.AutoSize = true;
            this.LabelExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelExperience.Location = new System.Drawing.Point(7, 167);
            this.LabelExperience.Name = "LabelExperience";
            this.LabelExperience.Size = new System.Drawing.Size(57, 20);
            this.LabelExperience.TabIndex = 8;
            this.LabelExperience.Text = "label1";
            // 
            // LabelLoyalty
            // 
            this.LabelLoyalty.AutoSize = true;
            this.LabelLoyalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoyalty.Location = new System.Drawing.Point(7, 147);
            this.LabelLoyalty.Name = "LabelLoyalty";
            this.LabelLoyalty.Size = new System.Drawing.Size(57, 20);
            this.LabelLoyalty.TabIndex = 7;
            this.LabelLoyalty.Text = "label1";
            // 
            // LabelDexterity
            // 
            this.LabelDexterity.AutoSize = true;
            this.LabelDexterity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDexterity.Location = new System.Drawing.Point(7, 127);
            this.LabelDexterity.Name = "LabelDexterity";
            this.LabelDexterity.Size = new System.Drawing.Size(57, 20);
            this.LabelDexterity.TabIndex = 6;
            this.LabelDexterity.Text = "label1";
            // 
            // LabelIngenuity
            // 
            this.LabelIngenuity.AutoSize = true;
            this.LabelIngenuity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIngenuity.Location = new System.Drawing.Point(7, 107);
            this.LabelIngenuity.Name = "LabelIngenuity";
            this.LabelIngenuity.Size = new System.Drawing.Size(57, 20);
            this.LabelIngenuity.TabIndex = 5;
            this.LabelIngenuity.Text = "label1";
            // 
            // LabelVengeance
            // 
            this.LabelVengeance.AutoSize = true;
            this.LabelVengeance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVengeance.Location = new System.Drawing.Point(7, 87);
            this.LabelVengeance.Name = "LabelVengeance";
            this.LabelVengeance.Size = new System.Drawing.Size(57, 20);
            this.LabelVengeance.TabIndex = 4;
            this.LabelVengeance.Text = "label1";
            // 
            // LabelIntelligence
            // 
            this.LabelIntelligence.AutoSize = true;
            this.LabelIntelligence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIntelligence.Location = new System.Drawing.Point(7, 67);
            this.LabelIntelligence.Name = "LabelIntelligence";
            this.LabelIntelligence.Size = new System.Drawing.Size(57, 20);
            this.LabelIntelligence.TabIndex = 3;
            this.LabelIntelligence.Text = "label1";
            // 
            // LabelToughness
            // 
            this.LabelToughness.AutoSize = true;
            this.LabelToughness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelToughness.Location = new System.Drawing.Point(7, 47);
            this.LabelToughness.Name = "LabelToughness";
            this.LabelToughness.Size = new System.Drawing.Size(57, 20);
            this.LabelToughness.TabIndex = 2;
            this.LabelToughness.Text = "label1";
            // 
            // LabelCharisma
            // 
            this.LabelCharisma.AutoSize = true;
            this.LabelCharisma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCharisma.Location = new System.Drawing.Point(7, 27);
            this.LabelCharisma.Name = "LabelCharisma";
            this.LabelCharisma.Size = new System.Drawing.Size(57, 20);
            this.LabelCharisma.TabIndex = 1;
            this.LabelCharisma.Text = "label1";
            // 
            // LabelAttack
            // 
            this.LabelAttack.AutoSize = true;
            this.LabelAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAttack.Location = new System.Drawing.Point(7, 7);
            this.LabelAttack.Name = "LabelAttack";
            this.LabelAttack.Size = new System.Drawing.Size(57, 20);
            this.LabelAttack.TabIndex = 0;
            this.LabelAttack.Text = "label1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LabelPowerLevel);
            this.tabPage3.Controls.Add(this.PurchaseSkillButton);
            this.tabPage3.Controls.Add(this.LabelSkillName);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.LabelSkillPointsRemaining);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1877, 934);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Skills";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LabelSkillPointsRemaining
            // 
            this.LabelSkillPointsRemaining.AutoSize = true;
            this.LabelSkillPointsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSkillPointsRemaining.Location = new System.Drawing.Point(4, 4);
            this.LabelSkillPointsRemaining.Name = "LabelSkillPointsRemaining";
            this.LabelSkillPointsRemaining.Size = new System.Drawing.Size(92, 31);
            this.LabelSkillPointsRemaining.TabIndex = 0;
            this.LabelSkillPointsRemaining.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Melee Skills (Speed)";
            // 
            // LabelSkillName
            // 
            this.LabelSkillName.AutoSize = true;
            this.LabelSkillName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSkillName.Location = new System.Drawing.Point(408, 52);
            this.LabelSkillName.Name = "LabelSkillName";
            this.LabelSkillName.Size = new System.Drawing.Size(184, 72);
            this.LabelSkillName.TabIndex = 3;
            this.LabelSkillName.Text = "Skill Name\r\nSkill Description\r\nSkill Requirements";
            // 
            // PurchaseSkillButton
            // 
            this.PurchaseSkillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseSkillButton.Location = new System.Drawing.Point(890, 52);
            this.PurchaseSkillButton.Name = "PurchaseSkillButton";
            this.PurchaseSkillButton.Size = new System.Drawing.Size(136, 62);
            this.PurchaseSkillButton.TabIndex = 4;
            this.PurchaseSkillButton.Text = "Purchase Skill";
            this.PurchaseSkillButton.UseVisualStyleBackColor = true;
            this.PurchaseSkillButton.Click += new System.EventHandler(this.PurchaseSkillButton_Click);
            // 
            // LabelPowerLevel
            // 
            this.LabelPowerLevel.AutoSize = true;
            this.LabelPowerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPowerLevel.Location = new System.Drawing.Point(408, 4);
            this.LabelPowerLevel.Name = "LabelPowerLevel";
            this.LabelPowerLevel.Size = new System.Drawing.Size(66, 24);
            this.LabelPowerLevel.TabIndex = 5;
            this.LabelPowerLevel.Text = "label2";
            // 
            // Form_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1904, 985);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.Button_LoadGame);
            this.Controls.Add(this.Button_CreateCharacter);
            this.Controls.Add(this.Label_GameTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MainMenu";
            this.Text = "RPG++";
            this.PanelMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPlayerHealth)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_GameTitle;
        private System.Windows.Forms.Button Button_CreateCharacter;
        private System.Windows.Forms.Button Button_LoadGame;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ButtonAttack;
        private System.Windows.Forms.Label LabelDPS;
        private System.Windows.Forms.Label LabelPlayer;
        private System.Windows.Forms.PictureBox PictureBoxPlayerHealth;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label LabelTickSpeed;
        private System.Windows.Forms.Label LabelAttack;
        private System.Windows.Forms.Label LabelDexterity;
        private System.Windows.Forms.Label LabelIngenuity;
        private System.Windows.Forms.Label LabelVengeance;
        private System.Windows.Forms.Label LabelIntelligence;
        private System.Windows.Forms.Label LabelToughness;
        private System.Windows.Forms.Label LabelCharisma;
        private System.Windows.Forms.Label LabelExperience;
        private System.Windows.Forms.Label LabelLoyalty;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label LabelEnemiesLeft;
        private System.Windows.Forms.Label LabelSkillPointsRemaining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelSkillName;
        private System.Windows.Forms.Button PurchaseSkillButton;
        private System.Windows.Forms.Label LabelPowerLevel;
    }
}

