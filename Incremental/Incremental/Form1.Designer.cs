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
            this.Button_CreateCharacter.Location = new System.Drawing.Point(16, 41);
            this.Button_CreateCharacter.Name = "Button_CreateCharacter";
            this.Button_CreateCharacter.Size = new System.Drawing.Size(134, 34);
            this.Button_CreateCharacter.TabIndex = 1;
            this.Button_CreateCharacter.Text = "Create New Character";
            this.Button_CreateCharacter.UseVisualStyleBackColor = true;
            this.Button_CreateCharacter.Click += new System.EventHandler(this.Button_CreateCharacter_Click);
            // 
            // Button_LoadGame
            // 
            this.Button_LoadGame.Location = new System.Drawing.Point(179, 41);
            this.Button_LoadGame.Name = "Button_LoadGame";
            this.Button_LoadGame.Size = new System.Drawing.Size(98, 34);
            this.Button_LoadGame.TabIndex = 2;
            this.Button_LoadGame.Text = "Load Game";
            this.Button_LoadGame.UseVisualStyleBackColor = true;
            this.Button_LoadGame.Click += new System.EventHandler(this.Button_LoadGame_Click);
            // 
            // Form_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_LoadGame);
            this.Controls.Add(this.Button_CreateCharacter);
            this.Controls.Add(this.Label_GameTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MainMenu";
            this.Text = "RPG++";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_GameTitle;
        private System.Windows.Forms.Button Button_CreateCharacter;
        private System.Windows.Forms.Button Button_LoadGame;
    }
}

