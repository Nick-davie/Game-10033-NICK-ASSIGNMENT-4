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
        Vector2 playerposition = new Vector2(300, 400);
        Vector2 screensize = new Vector2(600, 800);
        Vector2 size = new Vector2(20, 20);


        public void Setup()
        {
            Window.SetTitle("Timed Game");
            Window.SetSize(600, 800);
            Vector2 vector = new Vector2();


        }
        ///     Update runs every frame.
        public void Update()
        {

            Window.ClearBackground(240);

            Draw.SetLineColor(0);
            Draw.SetLineSize(3);
            Draw.Line(0, 200, 600, 200);
            Draw.Line(0, 100, 600, 100);
            Draw.Line(60, 0, 60, 200);

            playerposition.X = Input.GetMouseX();
            playerposition.Y = Input.GetMouseY();


            Draw.SetFillColor(150, 150, 150);
            Draw.SetLineColor(0, 0, 0);
            Draw.Circle(playerposition, size.X);

 
            // Compute each side of the player
            float playerLeftEdge = playerposition.X;
            float playerRightEdge = playerposition.X + size.X;
            float playerTopEdge = playerposition.Y;
            float playerBottomEdge = playerposition.Y + size.Y;

            // NEED LINE COLLISION


            // Check each side and see if player is out-of-bounds
            bool isLeftOfWindow = playerLeftEdge <= 0;             // left check
            bool isRightOfWindow = playerRightEdge >= Window.Width;  // right check
            bool isAboveWindow = playerTopEdge <= 200;             // top check
            bool isBelowWindow = playerBottomEdge >= Window.Height; // bottom check

            if (isLeftOfWindow || isRightOfWindow || isAboveWindow || isBelowWindow)
            {
                // Player is out-of-bounds
            }
            else
            {
                playerposition.X = Input.GetMouseX();
                playerposition.Y = Input.GetMouseY();
            }
        }

    }
}
