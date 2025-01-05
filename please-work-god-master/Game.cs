﻿using Microsoft.VisualBasic.FileIO;
using System;
using System.Numerics;

namespace Game10003
{
    public class Game
    {
        private float normalSize = 200f; //variable for normal size of the square
        private float smallSize; //variable for small size of the square. No number just yet

        public void Setup()
        {
            Window.SetTitle("Toggle Size");
            Window.SetSize(400, 400);
            smallSize = normalSize / 2; //calculate the smallSize by making it equal to normalSize divided by 2
        }


        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            //currentSize variable
            float currentSize;

            //determine if space bare is pushed or not
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                currentSize = smallSize; //set to small size if spacebar is down
            }
            else
            {
                currentSize = normalSize; //set to normal size if it isnt pressed
            }

            //update color to different shades of blue
            Color currentColor;
            if (currentSize == smallSize)
            {
                currentColor = Color.Cyan; //smallsize gets Cyan
            }
            else if (currentSize == normalSize)
            {
                currentColor = Color.Teal; //medium size gets Teal
            }
            else
            {
                currentColor = Color.Blue; //default set to Blue
            }

            

            //set fill color to change different shades of blue
            Draw.FillColor = currentColor; 

            //draws the square with the currentsize
            Draw.Square(100, 100, currentSize);
        }
    }
}
