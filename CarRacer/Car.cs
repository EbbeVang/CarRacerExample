using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.XInput;

namespace CarRacer
{
    class Car
    {
        public Texture2D image;
        private KeyboardState _keyboard;
        private Vector2 _position;

        public float Direction { get; set; }
        public float Speed { get; set; }
     

        public void Update()
        {
           
            _keyboard = Keyboard.GetState();

            if (_keyboard.IsKeyDown(Keys.Up))
            {
              //  _position.X++;
                _position.X += Speed * (float) Math.Cos(Direction);
                _position.Y += Speed * (float) Math.Sin(Direction);

                if (_keyboard.IsKeyDown(Keys.Left))
                {
                    Direction -= 0.02f;
                }
                if (_keyboard.IsKeyDown(Keys.Right))
                {
                    Direction += 0.02f;
                }
            }
           
            if (_keyboard.IsKeyDown(Keys.Down))
            {
                _position.X -= Speed * (float)Math.Cos(Direction);
                _position.Y -= Speed * (float)Math.Sin(Direction);
                if (_keyboard.IsKeyDown(Keys.Left))
                {
                    Direction += 0.03f;
                }
                if (_keyboard.IsKeyDown(Keys.Right))
                {
                    Direction -= 0.03f;
                }
            }
        }

        public void Draw(SpriteBatch sb)
        {
         //   sb.Draw(image, _position,  Color.White);
            sb.Draw(image, _position, new Rectangle(0,0,image.Width, image.Height), Color.White, Direction, new Vector2(image.Width/4, image.Height/2), 1f, SpriteEffects.None, 0f );
        }
    }
}
