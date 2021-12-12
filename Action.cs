using System;
using System.Collections.Generic;
using FinalProject.Casting;
using FinalProject.Services;

namespace FinalProject
{
    /// <summary>
    /// The base class of all other actions.
    /// </summary>
    public abstract class Action
    {
        public abstract void Execute(Dictionary<string, List<Actor>> cast);
    }
}