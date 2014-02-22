using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Tower_Defence
{
    class Input
    {
        private KeyboardState keyboardState;
        private KeyboardState lastState;

        public Input()
        {
            keyboardState = Keyboard.GetState();
            lastState = keyboardState;
        }

        public void Update()
        {
            lastState = keyboardState;
            keyboardState = Keyboard.GetState();
        }

        public bool Up
        {
            get
            {
                if (Game1.gameStates == Game1.GameStates.Menu)
                {
                    return keyboardState.IsKeyDown(Keys.Up) && lastState.IsKeyDown(Keys.Up);
                }
                else
                {
                    return keyboardState.IsKeyDown(Keys.Up);
                }
            }
        }

        public bool Down
        {
            get
            {
                if (Game1.gameStates == Game1.GameStates.Menu)
                {
                    return keyboardState.IsKeyDown(Keys.Down) && lastState.IsKeyDown(Keys.Down);
                }
                else
                {
                    return keyboardState.IsKeyDown(Keys.Down);
                }
            }
        }

        public bool MenuSelect
        {
            get
            {
                return keyboardState.IsKeyDown(Keys.Enter) && lastState.IsKeyUp(Keys.Enter);
            }
        }
    }
}
