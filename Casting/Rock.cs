using System;

namespace FinalProject.Casting
{
    class Rock: Actor
    {
        public Rock()
        {
            SetWidth(Constants.Rock_WIDTH);
            SetHeight(Constants.Rock_HEIGHT);
            SetImage(Constants.IMAGE_Rock);
             Point velocity = new Point(0,5);
            SetVelocity(velocity);
            
        }
    }
}
