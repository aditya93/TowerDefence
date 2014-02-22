using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Tower_Defence
{
    class Menu
    {
        private List<string> menuItems;
        private int iterator;
        public string infoText { get; set; }
        public string title { get; set; }

        public int Iterator
        {
            get { return iterator; }

            set
            {
                iterator = value;
                if (iterator > menuItems.Count - 1) iterator = menuItems.Count - 1;
                if (iterator < 0) iterator = 0;
            }
        }

        public Menu()
        {
            title = "Tower Defence";
            menuItems = new List<string>();
            menuItems.Add("Enter Game");
            menuItems.Add("Exit Game");
            Iterator = 0;
            infoText = string.Empty;
        }

        public int GetNumberOfOption()
        {
            return menuItems.Count;
        }

        public string GetItem(int index)
        {
            return menuItems[index];
        }

        public void DrawMenu(SpriteBatch spriteBatch, int screenWidth, SpriteFont arial)
        {
            spriteBatch.DrawString(arial, title, new Vector2(20, 20), Color.White);
            int yPos = 100;
            for (int i = 0; i < GetNumberOfOption(); i++)
            {
                Color colour = Color.White;
                if (i == Iterator)
                {
                    colour = Color.Gray;
                }
                spriteBatch.DrawString(arial, GetItem(i), new Vector2(screenWidth / 2 - arial.MeasureString(GetItem(i)).X / 2, yPos), colour);
                yPos += 50;
            }
        }

        public void DrawEndScreen(SpriteBatch batch, int screenWidth, SpriteFont arial)
        {
            batch.DrawString(arial, infoText, new Vector2(screenWidth / 2 - arial.MeasureString(infoText).X / 2, 300), Color.White);
            string prompt = "Press Enter to Continue";
            batch.DrawString(arial, prompt, new Vector2(screenWidth / 2 - arial.MeasureString(prompt).X / 2, 400), Color.White);
        }
    }
}
