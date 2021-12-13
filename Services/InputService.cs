using System;
using System.Collections.Generic;
using FinalProject.Casting;
using FinalProject.Services;
using FinalProject.Scripting;
using Raylib_cs;

namespace FinalProject.Services
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputService
    {
        public InputService()
        {

        }

        public bool IsLeftPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_LEFT);
        }

        public bool IsRightPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_RIGHT);
        }
        public bool IsUpPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_UP);
        }
        public bool IsDownPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_DOWN);
        }

        public bool IsSpacePressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_SPACE);
        }

        /// <summary>
        /// Gets the direction asked for by the current key presses
        /// </summary>
        /// <returns></returns>
        public Point GetDirection()
        {
            int x = 0;
            int y = 0;

            if (IsLeftPressed())
            {
                x = -1;
            }

            if (IsRightPressed())
            {
                x = 1;
            }

            if(IsUpPressed())
            {
                y = -1;
            }

            if(IsDownPressed())
            {
                y = 1;
            }
            
            return new Point(x, y);
        }

        public int SetSpaceInput()
        {
            int x = 0;
        
            if(IsSpacePressed())
            {
                return x;
            }
            else
            {
                x = 1;
                return x;
            }
        }

        

        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }
    }

}