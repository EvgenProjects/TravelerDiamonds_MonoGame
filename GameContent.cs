using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using System.Threading.Tasks;

namespace ÒravelerDiamonds_MonoGame
{
    static class GameContent
    {
        public static bool IsBaseLoaded { get; set; }
        public static bool IsLoaded { get; set; }
        public static int Counter;

        public static void Init(ContentManager content, GraphicsDevice graphics)
        {
            Counter = 0;
            Texture.Pixel = content.Load<Texture2D>("Pixel");
            Font.hudFont = content.Load<SpriteFont>("Fonts/Hud");
            IsBaseLoaded = true;

            Texture.winOverlay = content.Load<Texture2D>("Overlays/you_win"); Counter++;
            Texture.loseOverlay = content.Load<Texture2D>("Overlays/you_lose"); Counter++;
            Texture.diedOverlay = content.Load<Texture2D>("Overlays/you_died"); Counter++;
            Texture.VirtualControlArrow = content.Load<Texture2D>("Sprites/VirtualControlArrow"); Counter++;
            Texture.Idle = content.Load<Texture2D>("Sprites/Player/Idle"); Counter++;
            Texture.Run = content.Load<Texture2D>("Sprites/Player/Run"); Counter++;
            Texture.Jump = content.Load<Texture2D>("Sprites/Player/Jump"); Counter++;
            Texture.Celebrate = content.Load<Texture2D>("Sprites/Player/Celebrate"); Counter++;
            Texture.Die = content.Load<Texture2D>("Sprites/Player/Die"); Counter++;
            Texture.Gem = content.Load<Texture2D>("Sprites/Gem"); Counter++;

            Texture.BackgroundLayer = new Texture2D[3,3];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Texture.BackgroundLayer[x, y] = content.Load<Texture2D>("Backgrounds/Layer" + x + "_" + y);
                    Counter++;
                }
            }

            Texture.MonsterIdle = new Texture2D[4];
            Texture.MonsterRun = new Texture2D[4];
            for (int i = 0; i < 4; i++)
            {
                Texture.MonsterIdle[i] = content.Load<Texture2D>("Sprites/Monster" + i + "/Idle"); Counter++;
                Texture.MonsterRun[i] = content.Load<Texture2D>("Sprites/Monster" + i + "/Run"); Counter++;
            }

            Texture.Tiles = new Dictionary<string, Texture2D>();
            Texture.Tiles["BlockA0"] = content.Load<Texture2D>("Tiles/BlockA0"); Counter++;
            Texture.Tiles["BlockA1"] = content.Load<Texture2D>("Tiles/BlockA1"); Counter++;
            Texture.Tiles["BlockA2"] = content.Load<Texture2D>("Tiles/BlockA2"); Counter++;
            Texture.Tiles["BlockA3"] = content.Load<Texture2D>("Tiles/BlockA3"); Counter++;
            Texture.Tiles["BlockA4"] = content.Load<Texture2D>("Tiles/BlockA4"); Counter++;
            Texture.Tiles["BlockA5"] = content.Load<Texture2D>("Tiles/BlockA5"); Counter++;
            Texture.Tiles["BlockA6"] = content.Load<Texture2D>("Tiles/BlockA6"); Counter++;
            Texture.Tiles["BlockB0"] = content.Load<Texture2D>("Tiles/BlockB0"); Counter++;
            Texture.Tiles["BlockB1"] = content.Load<Texture2D>("Tiles/BlockB1"); Counter++;
            Texture.Tiles["Exit"] = content.Load<Texture2D>("Tiles/Exit"); Counter++;
            Texture.Tiles["Platform"] = content.Load<Texture2D>("Tiles/Platform"); Counter++;

            Songs.Music = content.Load<Song>("Sounds/Music"); Counter++;

            SoundEffects.killedSound = content.Load<SoundEffect>("Sounds/PlayerKilled"); Counter++;
            SoundEffects.jumpSound = content.Load<SoundEffect>("Sounds/PlayerJump"); Counter++;
            SoundEffects.fallSound = content.Load<SoundEffect>("Sounds/PlayerFall"); Counter++;
            SoundEffects.exitReachedSound = content.Load<SoundEffect>("Sounds/ExitReached"); Counter++;
            SoundEffects.collectedSound = content.Load<SoundEffect>("Sounds/GemCollected"); Counter++;
            /*
            SoundEffects.killedSound = content.Load<SoundEffect>("Sounds/PlayerKilled"); Counter++;
            SoundEffects.jumpSound = content.Load<SoundEffect>("Content/Sounds/PlayerJump.wav"); Counter++;
            SoundEffects.fallSound = content.Load<SoundEffect>("Content/Sounds/PlayerFall.wav"); Counter++;
            SoundEffects.exitReachedSound = content.Load<SoundEffect>("Content/Sounds/ExitReached.wav"); Counter++;
            SoundEffects.collectedSound = content.Load<SoundEffect>("Content/Sounds/GemCollected.wav"); Counter++;
            */

            Levels = new List<string[]>();
            for (int i = 0; i < 3; i++)
            {
                Levels.Add(System.IO.File.ReadAllLines("Content/Levels/" + i + ".txt"));
                Counter++;
            }

            IsLoaded = true;
        }

        public static class Texture
        {
            public static Texture2D winOverlay;
            public static Texture2D loseOverlay;
            public static Texture2D diedOverlay;
            public static Texture2D Pixel;

            public static Texture2D VirtualControlArrow;
            public static Texture2D Idle;
            public static Texture2D Run;
            public static Texture2D Jump;
            public static Texture2D Celebrate;
            public static Texture2D Die;
            public static Texture2D Gem;

            public static Texture2D[,] BackgroundLayer;
            public static Texture2D[] MonsterRun;
            public static Texture2D[] MonsterIdle;

            public static Dictionary<string, Texture2D> Tiles;
        }

        public static class Songs
        {
            public static Song Music;
        }

        public static class SoundEffects
        {
            public static SoundEffect killedSound;
            public static SoundEffect jumpSound;
            public static SoundEffect fallSound;

            public static SoundEffect exitReachedSound;
            public static SoundEffect collectedSound;
        }

        public static class Font
        {
            public static SpriteFont hudFont;
        }

        public static List<string[]> Levels;
    }
}
