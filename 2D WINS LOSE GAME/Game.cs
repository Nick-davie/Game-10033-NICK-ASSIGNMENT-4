// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
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

            Draw.SetLineColor(0);
            Draw.SetLineSize(3);
            Draw.Line(0, 200, 600, 200);
            Draw.Line(0, 100, 600, 100);
            Draw.Line(60, 0, 60, 200);


            Draw.SetFillColor(150, 150, 150);
            Draw.SetLineColor(0, 0, 0);
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 25);

            ///timer box
            Draw.SetFillColor(0, 0, 255);
            Draw.SetLineSize(0);
            Draw.Rectangle(0, 0, 58, 98);


            ///lives box
            ///3
            Draw.SetFillColor(0, 255, 0);
            Draw.SetLineSize(0);
            Draw.Rectangle(0, 102, 58, 97);
            ///2
            Draw.SetFillColor(255, 255, 0);
            Draw.SetLineSize(0);
            Draw.Rectangle(0, 102, 58, 60);
            ///1
            Draw.SetFillColor(255, 0, 0);
            Draw.SetLineSize(0);
            Draw.Rectangle(0, 102, 58, 20);


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
