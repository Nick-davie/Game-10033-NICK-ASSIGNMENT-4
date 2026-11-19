// Include the namespaces (code libraries) you need below.
using System;
using System.ComponentModel.Design;
using System.Net;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Timed Game");
            Window.SetSize(600, 800);
            Vector2 vector = new Vector2();

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(240);
            Draw.Line(0, 400, 600, 400);

            Draw.SetFillColor(250, 0, 0);
            Draw.SetLineColor(0);
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 25);

            // Variables in our code for our player
            // Notice how the position and size could be anything we want
            Vector2 position = new Vector2();
            Vector2 size = new Vector2();


            // Compute each side of the player
            float playerLeftEdge = position.X;
            float playerRightEdge = position.X + size.X;
            float playerTopEdge = position.Y;
            float playerBottomEdge = position.Y + size.Y;

            // Check each side and see if player is out-of-bounds
            bool isLeftOfWindow = playerLeftEdge <= 0;             // left check
            bool isRightOfWindow = playerRightEdge >= Window.Width;  // right check
            bool isAboveWindow = playerTopEdge <= 0;             // top check
            bool isBelowWindow = playerBottomEdge >= Window.Height; // bottom check
        }

    }
}
