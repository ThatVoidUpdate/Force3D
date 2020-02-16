using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace Force3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window();//Create a new window to render stuff in

            GameObject TestObject = new GameObject(Primitives.Cylinder);//Create a new gameobject with a cylinder mesh
            TestObject.RegisterScript(new ExampleGameScript());//Register a new GameScript to be attached onto this GameObject
            window.RegisterGameObject(TestObject);//Register the GameObject with the renderer
            window.Run(60);//Start rendering
        }

    }
    class ExampleGameScript : GameScript
    {
        public override void OnAwake()
        {
            ParentObject.RandomiseColour();
        }

        /// <summary>
        /// To be executed every frame
        /// </summary>
        public override void OnFrame()
        {
            ParentObject.Rotate(new Vector3(0, 1, 0));//Rotate the GameObject by 1 degree
            ParentObject.transformation.Position = new Vector3(ParentObject.transformation.Position.X,
                                                               (float)Math.Sin(Time.GameTime - ParentObject.transformation.Position.Z / 10),
                                                               ParentObject.transformation.Position.Z);//Move the gameobject up and down
        }
    }
}
