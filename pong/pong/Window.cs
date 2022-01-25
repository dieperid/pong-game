using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;


namespace pong
{
    /// <summary>
    /// Class Window
    /// </summary>
    class Window
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sizeWindow">Window size</param>
        public Window(uint sizeWindow)
        {
            RenderWindow window = new RenderWindow(new VideoMode(sizeWindow, sizeWindow), "Pong");  // New window
            Player player = new Player();   // New player
            Enemy enemy = new Enemy();      // New enemy
            Ball ball = new Ball();         // New ball
            
            // Create a List of Drwable items and add the items to it
            List<Drawable> drawableItems = new List<Drawable>();
            drawableItems.Add(player.PlayerShape);
            drawableItems.Add(enemy.EnemyShape);
            drawableItems.Add(ball.BallShape);

            // Set framerate limit to 60
            window.SetFramerateLimit(60);

            // Initialize the position of the items
            ball.Position += new Vector2f(ball.VBallX, ball.VBallY);
            player.Position = new Vector2f(0, player.Position.Y);
            enemy.Position = new Vector2f(sizeWindow - enemy.EnemyWidth, 0);

            // Fill the color or the items
            foreach (RectangleShape item in drawableItems)
            {
                item.FillColor = Color.Red;
            }

            // If window is closed
            window.Closed += CloseHandle;

            // While window is Open
            while (window.IsOpen)
            {
                // Initialize the position of the items
                enemy.Position = new Vector2f(sizeWindow - enemy.EnemyWidth, enemy.Position.Y);
                ball.Position += new Vector2f(ball.VBallX, ball.VBallY);
                player.Position = new Vector2f(0, player.Position.Y);

                // If down key is pressed
                if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
                {
                    if (player.Position.Y + player.PlayerHeight < sizeWindow)
                    {
                        player.Position += new Vector2f(0, player.VPlayerY);
                    }
                }
                // else if up key is pressed
                else if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
                {
                    if (player.Position.Y > 0)
                    {
                        player.Position -= new Vector2f(0, player.VPlayerY);
                    }
                }
                // Check for de velocity of the ball if she has to go to the left
                if (ball.Position.X + ball.BallWidth > sizeWindow || ball.Position.X + ball.BallWidth == enemy.Position.X && (ball.Position.Y > enemy.Position.Y || ball.Position.Y < enemy.Position.Y))
                {
                    ball.VBallX = -5;
                }
                // Check for de velocity of the ball if she has to go to the right
                else if (ball.Position.X < 0 || ball.Position.X == player.Position.X + player.PlayerWidth && ball.Position.Y > player.Position.Y && ball.Position.Y < player.Position.Y + player.PlayerHeight)
                {
                    ball.VBallX = 5;
                }
                // Check for the ball if she's not going above the limit
                if(ball.Position.Y + ball.BallWidth == sizeWindow)
                {
                    ball.VBallY = -5;
                }
                // Check for the ball if she's not going above the limit
                else if (ball.Position.Y == 0)
                {
                    ball.VBallY = 5;
                }

                // Apply new position to the enemy
                enemy.Position = new Vector2f(sizeWindow - enemy.EnemyWidth, ball.Position.Y - enemy.EnemyHeight / 2 + 10);

                // Check for the enemy if he's not going above the limit
                if (enemy.Position.Y < 0)
                {
                    enemy.Position = new Vector2f(sizeWindow, 0);
                }
                // Check for the enemy if he's not going above the limit
                else if (enemy.Position.Y + enemy.EnemyHeight > sizeWindow)
                {
                    enemy.Position = new Vector2f(sizeWindow, sizeWindow - enemy.EnemyHeight);
                }

                // Apply new position to the enemy
                enemy.Position = new Vector2f(sizeWindow - enemy.EnemyWidth, enemy.Position.Y);

                window.DispatchEvents();

                // Clear
                window.Clear();

                // Draw all the items that they're in the list
                foreach (var element in drawableItems)
                {
                    window.Draw(element);
                }

                // Display the window
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
