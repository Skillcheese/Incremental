using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incremental
{
    public partial class EnemyBox : UserControl
    {
        public int value = 0;
        public Enemy enemy;

        public EnemyBox()
        {
            InitializeComponent();
        }

        private void EnemyBox_Load(object sender, EventArgs e)
        {
        }

        public void UpdateEnemy(Enemy _enemy)
        {
            enemy = _enemy;
            pictureBox1.Width = Number.clamp(224 - (int)(224 * enemy.health / enemy.healthMax), 0, 224);
            LabelEnemy.ForeColor = GetColor(enemy, Game.player);
            LabelEnemy.Text = enemy.EnemyToString();
        }

        private Color GetColor(Enemy _enemy, Character player)
        {
            if (_enemy == null) return Color.Transparent;
            int enemyLevel = _enemy.level;
            int playerLevel = player.GetPowerLevel();

            if (enemyLevel < playerLevel) return Color.Green;
            else if (enemyLevel < playerLevel + 5) return Color.DarkOrange;
            else return Color.Red;
        }
    }
}
