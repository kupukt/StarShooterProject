using System;
using System.Collections.Generic;
using FinalProject.Casting;
using FinalProject.Services;

namespace FinalProject
{
    public static class Constants
    {
        public const int MAX_X = 800;
        public const int MAX_Y = 600;
        public const int FRAME_RATE = 30;

        public const int DEFAULT_SQUARE_SIZE = 20;
        public const int DEFAULT_FONT_SIZE = 20;
        public const int DEFAULT_TEXT_OFFSET = 4;

        public const string IMAGE_Rock = "./Assets/rock.png";
        public const string IMAGE_Beam = "./Assets/Beam.png";
        public const string IMAGE_Ship = "./Assets/Ship.png";

        public const string SOUND_START = "./Assets/StartUp.wav";
        public const string SOUND_Explode = "./Assets/Explosion.wav";
        public const string SOUND_OVER = "./Assets/EndGame.wav";

        public const int BALL_X = MAX_X / 2;
        public const int BALL_Y = MAX_Y - 125;

        public const int BALL_DX = 8;
        public const int BALL_DY = BALL_DX * -1;

        public const int PADDLE_X = MAX_X / 2;
        public const int PADDLE_Y = MAX_Y + 500;

        public const int Rock_WIDTH = 48;
        public const int Rock_HEIGHT = 24;

        public const int Rock_SPACE = 10;

        public const int PADDLE_SPEED = 15;

        public const int PADDLE_WIDTH = 60;
        public const int PADDLE_HEIGHT = 60;

        public const int Ship_WIDTH = 30;
        public const int Ship_HEIGHT = 80;
    }
}
