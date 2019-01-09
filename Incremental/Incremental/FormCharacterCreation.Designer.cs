namespace Incremental
{
    partial class FormCharacterCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCharacterCreation));
            this.TextBox_CharacterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox_Gender = new System.Windows.Forms.GroupBox();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.GroupBox_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_CharacterName
            // 
            this.TextBox_CharacterName.Location = new System.Drawing.Point(59, 12);
            this.TextBox_CharacterName.Name = "TextBox_CharacterName";
            this.TextBox_CharacterName.Size = new System.Drawing.Size(175, 20);
            this.TextBox_CharacterName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name: ";
            // 
            // GroupBox_Gender
            // 
            this.GroupBox_Gender.Controls.Add(this.radioButton_female);
            this.GroupBox_Gender.Controls.Add(this.radioButton_male);
            this.GroupBox_Gender.Location = new System.Drawing.Point(13, 49);
            this.GroupBox_Gender.Name = "GroupBox_Gender";
            this.GroupBox_Gender.Size = new System.Drawing.Size(125, 49);
            this.GroupBox_Gender.TabIndex = 2;
            this.GroupBox_Gender.TabStop = false;
            this.GroupBox_Gender.Text = "Gender";
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(61, 20);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(59, 17);
            this.radioButton_female.TabIndex = 0;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Checked = true;
            this.radioButton_male.Location = new System.Drawing.Point(7, 20);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(48, 17);
            this.radioButton_male.TabIndex = 0;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // comboBox_class
            // 
            this.comboBox_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Items.AddRange(new object[] {
            "Mage",
            "Rogue",
            "Cleric",
            "Paladin",
            "Warrior",
            "Depraved"});
            this.comboBox_class.Location = new System.Drawing.Point(20, 125);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(121, 21);
            this.comboBox_class.TabIndex = 3;
            this.comboBox_class.SelectedIndexChanged += new System.EventHandler(this.comboBox_class_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(665, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Starting Stats (Stats will be gained throughout the duration of the playth" +
    "rough, up to 99, this will only affect early game performance!)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLabel.Location = new System.Drawing.Point(166, 126);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(166, 20);
            this.ClassLabel.TabIndex = 6;
            this.ClassLabel.Text = "Choose Starting Stats";
            // 
            // FormCharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_class);
            this.Controls.Add(this.GroupBox_Gender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_CharacterName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCharacterCreation";
            this.Text = "Character Creation";
            this.GroupBox_Gender.ResumeLayout(false);
            this.GroupBox_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_CharacterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupBox_Gender;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ClassLabel;
    }
}