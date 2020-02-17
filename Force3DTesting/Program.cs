using System;
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

            GameObject TestObject = new GameObject(Primitives.Cube);//Create a new gameobject with a cylinder mesh
            TestObject.RegisterScript(new ExampleGameScript());//Register a new GameScript to be attached onto this GameObject
            window.RegisterGameObject(TestObject);//Register the GameObject with the renderer
            window.Run(60);//Start rendering
        }

    }
    class ExampleGameScript : GameScript
    {
        private int i;
        public override void OnAwake()
        {
            ParentObject.RandomiseColour();
        }

        /// <summary>
        /// To be executed every frame
        /// </summary>
        public override void OnFrame()
        {
            ParentObject.Rotate(new Vector3(1, 1, 1));
            ParentObject.transformation.Position = new Vector3(ParentObject.transformation.Position.X, (float)Math.Abs(Math.Sin(Time.GameTime)), ParentObject.transformation.Position.Z);//Move the gameobject up and down
            i++;
            i %= ParentObject.model.Geometry.Count;
            ParentObject.model.Geometry[i].setColour(Color.FromArgb(Window.rnd.Next(0, 255), Window.rnd.Next(0, 255), Window.rnd.Next(0, 255)));
        }
    }
}
