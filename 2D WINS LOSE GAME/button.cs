namespace MohawkGame2D
{
    public class Button
    {

        
        int Shape = (1,2,3);
        int Color = (red, green, blue, yellow);
        Color red = (250, 0, 0);
        Color green = (0, 250, 0);
        Color blue = (0, 0, 250);
        Color yellow = (250, 250, 0);
        Shape Circle = 1;
        Shape Rectangle = 2;
        Shape Triangle = 3;

        public void setup()
        {
            Shape = Random.Range(1, 3);
            Color = Random.Range();
            vector2 position = (X, Y); 
        }
        public void update()
        {
            DrawShape();
        }

        void DrawShape()
        {
            if (Shape == 1)
            {
                Draw.Circle(position, size);
            }
            else if (Shape == 2)
            {
                Draw.Rectangle(position, size);
            }
            else if (Shape == 3)
            {
                Draw.Triangle(position, size);
            }
        }
        
                void DrawColor()
                {
                    if (Color == red)
                    {
                        Draw.SetFillColor(250, 0, 0);
                    }
                    else if (Color == green)
                    {
                        Draw.SetFillColor(0, 250, 0);
                    }
                    else if (Color == blue)
                    {
                        Draw.SetFillColor(0, 0, 250);
                    }
                    else if (Color == yellow)
                    {
                        Draw.SetFillColor(250, 250, 0);
                    }
                }

                public void OnClick()
                {
            if (Input.GetMouseButtonDown(0))
            {
                if (Input.GetMouseX() >= position.X && Input.GetMouseX() <= position.X + size.X &&
                    Input.GetMouseY() >= position.Y && Input.GetMouseY() <= position.Y + size.Y)
                {
                    // Button was clicked
                    // Perform action here
                }
            }
        }
    }
}

       // Draw.SetFillColor(250, 0, 0);
       // Draw.Circle(100, 300, 20);
       // Draw.Rectangle(500, 300, 40, 40);
       // Draw.Triangle(300, 260, 350, 310, 250, 310);


       // Draw.SetFillColor(0, 250, 0);
       // Draw.Circle(100, 400, 20);
       // Draw.Rectangle(500, 400, 40, 40);
       // Draw.Triangle(300, 360, 350, 410, 250, 410);


         //Draw.SetFillColor(0, 0, 250);
        // Draw.Circle(100, 500, 20);
        /// Draw.Rectangle(500, 500, 40, 40);
        // Draw.Triangle(300, 460, 350, 510, 250, 510);

        // Draw.SetFillColor(250, 250, 0);
        // Draw.Circle(100, 600, 20);
        // Draw.Rectangle(500, 600, 40, 40);
       //  Draw.Triangle(300, 560, 350, 610, 250, 610);