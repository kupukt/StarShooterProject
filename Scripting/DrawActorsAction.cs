using System;
using System.Collections.Generic;
using FinalProject.Services;
using FinalProject.Casting;

namespace FinalProject.Scripting
{
    public class DrawActorsAction: Action
    {
        private OutputService _outputService;

        public DrawActorsAction(OutputService outputService)
        {
            _outputService = outputService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            _outputService.StartDrawing();

            foreach (List<Actor> group in cast.Values)
            {
                _outputService.DrawActors(group);
            }

            _outputService.EndDrawing();
        }
    }
}
