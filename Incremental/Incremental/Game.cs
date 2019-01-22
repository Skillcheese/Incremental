using System;
using System.Collections.Generic;

namespace Incremental
{
    public class Game
    {
        public static Form_MainMenu gameWindow;
        public static List<Enemy> enemies = new List<Enemy>();
        public static Character player;
        public static int tickRateBase = 1000;
        public static int msPerUpdate = tickRateBase;
        public static int chunkSize = 25;
        public static int incChunk = 1;
        public static int incChunkGroup = 1;

        public Game()
        {

        }

        public Game(Form_MainMenu _gameWindow, Character _player)
        {
            gameWindow = _gameWindow;
            player = _player;
            MakeNewChunk();
        }

        public static void MakeNewChunk()
        {
            for (int i = 0; i < chunkSize; i++)
            {
                enemies.Add(new Enemy(incChunk));
            }
            incChunk++;
        }

        public static void EnemyDead()
        {
            enemies.RemoveAt(0);
            if(enemies.Count == 0)
            {
                MakeNewChunk();
            }
            gameWindow.Render();
        }
    }
}
