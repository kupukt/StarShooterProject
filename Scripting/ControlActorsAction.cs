using System;
using System.Collections.Generic;
using FinalProject.Casting;
using FinalProject.Services;

namespace FinalProject.Scripting
{
   public class ControlActorsActions: Action
    {
        InputService _input;

        public ControlActorsActions()
        {
            _input = new InputService();
        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
           Point direction = _input.GetDirection();

           Actor ship = cast["ships"][0];

           Point velocity = direction.Scale(Constants.PADDLE_SPEED);
           ship.SetVelocity(velocity);
        }
    }
}
