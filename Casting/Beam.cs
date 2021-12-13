using System;

namespace FinalProject.Casting
{
    public class Beam: Actor
    {
        public Beam()
        {
            SetWidth(Constants.BALL_WIDTH);
            SetHeight(Constants.BALL_HEIGHT);
            SetImage(Constants.IMAGE_Beam);
            Point velocity = new Point(0,-5);
            SetVelocity(velocity);
        }
    }
}
