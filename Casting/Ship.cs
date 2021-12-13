using System;

namespace FinalProject.Casting
{
    public class Ship: Actor
    {
        public Ship()
        {
            SetWidth(Constants.BALL_WIDTH);
            SetHeight(Constants.BALL_HEIGHT);
            SetImage(Constants.IMAGE_Ship);
            SetPosition(new Point(Constants.PADDLE_X, Constants.PADDLE_Y));
        }
        
    }
}
