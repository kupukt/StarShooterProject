using System;
using System.Collections.Generic;
using FinalProject.Services;
using FinalProject.Casting;

namespace FinalProject.Scripting
{
    public class HandleCollisionAction: Action
    {
        PhysicsService physics = new PhysicsService();

        HandleOffScreenAction bounce = new HandleOffScreenAction();

        AudioService audio = new AudioService();

        public HandleCollisionAction()
        {
            physics = new PhysicsService();
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> beams = cast["beams"];
            List<Actor> ship = cast["ships"];
            List<Actor> rocks = cast["rocks"];
            List<Actor> healthpoints = cast["healthpoints"];
            List<Actor> removeRocks = new List<Actor>();
            List<Actor> removeShip = new List<Actor>();
            List<Actor> removeBeam = new List<Actor>();
            List<Actor> removeHealth = new List<Actor>();

            foreach(Actor Rock in cast["rocks"])
            {
                foreach(Actor Beam in beams)
                {
                    if(physics.IsCollision(Beam, Rock))
                    {
                        
                        removeRocks.Add(Rock);
                        removeBeam.Add(Beam);
                        audio.PlaySound(Constants.SOUND_Explode);

                    }
                }
                
                foreach(Actor Ship in cast["ships"])
                {
                    foreach(Actor Health in healthpoints)
                    {
                        if(physics.IsCollision(Rock,Ship))
                        {
                            removeRocks.Add(Rock);
                            removeHealth.Add(Health);

                            if(removeHealth.Count == 3)
                            {
                                removeShip.Add(Ship);
                                audio.PlaySound(Constants.SOUND_OVER);
                                Raylib_cs.Raylib.WindowShouldClose();
                            }
                        }
                        
                        
                    }

                    
                }
                
            }
            
            foreach(Actor Rock in removeRocks)
            {
                rocks.Remove(Rock);
            }

            foreach(Actor Beam in removeBeam)
            {
                beams.Remove(Beam);
            }

            foreach(Actor Health in removeHealth)
            {
                healthpoints.Remove(Health);
            }

            foreach(Actor Ship in removeShip)
            {
                ship.Remove(Ship);
            }
        }
    }
}
