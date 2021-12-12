using System;
using System.Collections.Generic;
using FinalProject.Casting;
using FinalProject.Services;
using FinalProject.Scripting;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

            cast["ships"] = new List<Actor>();

            List<Ship> _ship = new List<Ship>();

            Ship _ships = new Ship();
            _ships.SetPosition(new Point(Constants.PADDLE_X, Constants.PADDLE_Y));
            cast["ships"].Add(_ships);

            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);


            MoveActorsAction move = new MoveActorsAction();
            script["update"].Add(move);


            ControlActorsActions moveShip = new ControlActorsActions();
            script["input"].Add(moveShip);

            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Batter", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();


        }
    }
}
