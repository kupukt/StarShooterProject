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

            cast["rocks"] = new List<Actor>();

            List<Rock> _rocks = new List<Rock>();

            for (int x = Constants.Rock_SPACE; x < 760; x += (Constants.Rock_WIDTH + Constants.Rock_SPACE))
            {
                for (int y = 0; y < 150; y += (Constants.Rock_HEIGHT + Constants.Rock_SPACE))
                {
                    Rock _rock = new Rock();
                    Point _point = new Point(x,y);
                    _rock.SetPosition(_point);
                    cast["rocks"].Add(_rock);
                }
            }

            cast["beams"] = new List<Actor>();
            List<Beam> _beam = new List<Beam>();
            Beam _beams = new Beam();
            _beams.SetPosition(_ships.GetPosition());
            cast["beams"].Add(_beams);
            InputService _startBeam = new InputService();
        
            if(_startBeam.SetSpaceInput() == 0)
            {
                cast["beams"].Add(_beams);
            }

            cast["healthpoints"] = new List<Actor>();
            List<Health> _health = new List<Health>();
            
            for(int x = 0; x<4; x++)
            {
                Actor Health = new Actor();
                cast["healthpoints"].Add(Health);
            }

            



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

            HandleCollisionAction collision = new HandleCollisionAction();
            script["update"].Add(collision);


            MoveActorsAction move = new MoveActorsAction();
            script["update"].Add(move);


            ControlActorsActions moveShip = new ControlActorsActions();
            script["input"].Add(moveShip);

            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "ShipMaster", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();


        }
    }
}
