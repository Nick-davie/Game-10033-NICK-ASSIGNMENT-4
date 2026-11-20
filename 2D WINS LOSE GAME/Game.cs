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
            Window.SetSize((int)screensize.X, (int)screensize.Y); 


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



            Draw.SetFillColor(150, 150, 150);
            Draw.SetLineColor(0, 0, 0);
            Draw.Circle(playerposition, size.X);


            // Compute each side of the player
            float playerLeftEdge = Input.GetMouseX();
            float playerRightEdge = Input.GetMouseX();
            float playerTopEdge = Input.GetMouseY();
            float playerBottomEdge = Input.GetMouseY();

            // NEED LINE COLLISION


            // Check each side and see if player is out-of-bounds
            bool isLeftOfWindow = playerLeftEdge <= 20;            // left check
            bool isRightOfWindow = playerRightEdge >= Window.Width - 20;  // right check
            bool isAboveWindow = playerTopEdge <= 220;            // top check
            bool isBelowWindow = playerBottomEdge >= Window.Height - 20; // bottom check

            //Console.WriteLine($"Left: {isLeftOfWindow}, Right: {isRightOfWindow}, Top: {isAboveWindow}, Bottom: {isBelowWindow}");


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
