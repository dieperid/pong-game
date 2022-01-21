using System;
using System.Collections.Generic;
using System.Text;
using SFML.Window;
using SFML.Graphics;
using SFML.System;


namespace pong
{
    class Window
    {
        const float BALL_WIDTH = 20;
        const float BALL_HEIGHT = 20;
        int velocityX = 5;
        int velocityY = 5;
        int velocityShapeY = 5;

        public Window(uint sizeWindow, float shapeWidth, float shapeHeight)
        {
            RenderWindow window = new RenderWindow(new VideoMode(sizeWindow, sizeWindow), "Pong");
            RectangleShape shape = new RectangleShape(new Vector2f(shapeWidth, shapeHeight));
            RectangleShape shape2 = new RectangleShape(new Vector2f(shapeWidth, shapeHeight));
            RectangleShape ball = new RectangleShape(new Vector2f(BALL_WIDTH, BALL_HEIGHT));
            Vector2f shapePosition = new Vector2f(0, 0);
            Vector2f shapePosition2 = new Vector2f(sizeWindow - shapeWidth, 0);
            Vector2f ballPosition = new Vector2f(sizeWindow / 2, sizeWindow / 2 - 100);
            window.SetFramerateLimit(60);

            List<Drawable> drawableItems = new List<Drawable>();
            drawableItems.Add(shape);
            drawableItems.Add(shape2);
            drawableItems.Add(ball);

            shape.Position = shapePosition;
            shape2.Position = shapePosition2;
            ball.Position = ballPosition;

            foreach (RectangleShape item in drawableItems)
            {
                item.FillColor = Color.Red;
            }

            window.Closed += CloseHandle;

            while (window.IsOpen)
            {
                if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
                {
                    velocityShapeY = 5;
                }
                else if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
                {
                    velocityShapeY = -5;
                }
                if (ballPosition.X + BALL_WIDTH > sizeWindow)
                {
                    velocityX = -5;
                }
                else if (ballPosition.X < 0)
                {
                    velocityX = 5;
                }
                if(ballPosition.Y + BALL_HEIGHT > sizeWindow)
                {
                    velocityY = -5;
                }
                else if(ballPosition.Y < 0)
                {
                    velocityY = 5;
                }

                shapePosition.Y = velocityShapeY;
                shapePosition2.Y = ballPosition.Y - shapeHeight / 2;
                ballPosition.X += velocityX;
                ballPosition.Y += velocityY;

                ball.Position = ballPosition;
                shape.Position = shapePosition;
                shape2.Position = shapePosition2;

                window.DispatchEvents();

                window.Clear();

                foreach (var element in drawableItems)
                {
                    window.Draw(element);
                }

                window.Display();
            }

            void CloseHandle(object sender, EventArgs args)
            {
                window.Close();
                Environment.Exit(0);
            }
        }
    }
}
