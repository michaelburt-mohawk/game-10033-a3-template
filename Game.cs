// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Class1 object1 = new Class1();
        Class2 object2 = new Class2();
        Class3 object3 = new Class3();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            // use the proper size for your assignment design
            Window.SetSize(400, 400);

            // create a title that matches your assignment
            Window.SetTitle("Assignment 3 Title");

            object1.Setup();
            object2.Setup();
            object3.Setup();

            UniqueFunction1();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // choose a background color as appropriate
            Window.ClearBackground(Color.OffWhite);

            object1.Update();
            object2.Update();
            object3.Update();

            // for loop 1
            // main example: draw multiples of something
            // however, any use of for loops is valid
            // note: 10 loops is just an example. change it in your A3!
            for (int i = 0; i < 10; i++)
            {
                // Draw.FillColor ...
                // Draw.Circle ...
                // etc.
            }

            // for loop 2
            // note: 5 loops is just an example. change it in your A3!
            for (int i = 0; i < 5; i++)
            {

            }

            UniqueFunction2();
        }

        public void UniqueFunction1()
        {

        }

        public void UniqueFunction2()
        {

        }
    }

}
