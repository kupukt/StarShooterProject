using System;

namespace FinalProject.Casting
{
    public class Ship: Actor
    {
        public Ship()
        {
            SetWidth(Constants.Ship_WIDTH);
            SetHeight(Constants.Ship_HEIGHT);
            SetImage(Constants.IMAGE_Ship);
            SetPosition(new Point(Constants.PADDLE_X, Constants.PADDLE_Y));
        }
        
    }
}
