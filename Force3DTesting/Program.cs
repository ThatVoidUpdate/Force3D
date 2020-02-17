using System;
using System.Collections.Generic;
using System.Drawing;
using Force3D;
using OpenTK;

namespace Force3DTesting
{
    class Program
    {
        static void Main()
        {
            Window window = new Window();//Create a new window to render stuff in
            GameObject[] cubes = new GameObject[9];
            for (int i = 0; i < 9; i++)
            {
                cubes[i] = new GameObject(Primitives.Cube, new Vector3(i / 3, 0, i % 3));//Create a new gameobject with a cylinder mesh
                cubes[i].RegisterScript(new ExampleGameScript());//Register a new GameScript to be attached onto this GameObject
                window.RegisterGameObject(cubes[i]);//Register the GameObject with the renderer
            }
            GameObject Floor = new GameObject(Primitives.Cube, new Vector3(0, -1, 0));
            Floor.transformation.Scale(new Vector3(10, 0.5f, 10));
            Floor.RandomiseColour();
            window.RegisterGameObject(Floor);
            window.Run(60);//Start rendering
        }

    }
    class ExampleGameScript : GameScript
    {
        private int i;
        public override void OnAwake()
        {
            gameObject.RandomiseColour();
        }

        /// <summary>
        /// To be executed every frame
        /// </summary>
        public override void OnFrame()
        {
            gameObject.transformation.Rotate(new Vector3(0,1,0));
            gameObject.transformation.position = new Vector3(gameObject.transformation.position.X, (float)Math.Abs(Math.Sin(Time.GameTime - gameObject.transformation.position.Z / 5 - gameObject.transformation.position.X / 5)), gameObject.transformation.position.Z);//Move the gameobject up and down
        }
    }
}
