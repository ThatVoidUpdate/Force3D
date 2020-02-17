using OpenTK;
using System;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Collections.Generic;

namespace Force3D
{
    public class Window : GameWindow
    {
        public double fov = Math.PI / 4;

        public static Matrix4 modelview = Matrix4.Identity;

        public static Vector3 CameraPosition = new Vector3(0, 0, -3);

        public static int FramesSinceStart = 0;

        public static Random rnd = new Random();

        public static List<GameObject> RegisteredObjects = new List<GameObject>();

        protected override void OnLoad(EventArgs e)
        {//runs when the game is first loaded
            base.OnLoad(e);
            GL.ClearColor(Color.CornflowerBlue); //change the background colour that everything is drawn on top of
            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.DepthTest);//enabling various opentk shenanigans
            GL.DepthMask(true);
            GL.DepthFunc(DepthFunction.Lequal);//ensuring that polygons draw in the correct order

            GameInit(); //initialising the game
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {//called every time the game wants to render a frame
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);//clear the screen
            Time.OnFrame(e);

            Title = "FPS: " + 1 / e.Time;

            GameLogic();//perform all logic
            GameRender();//render the scene

            SwapBuffers();//send the data to the graphics card
        }

        protected override void OnResize(EventArgs e)
        {//called whenever the game is resized
            base.OnResize(e);
            GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);//set the viewport of the camera
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)fov, Width / (float)Height, 1.0f, 64.0f);//set how the camera renders to the screen
            GL.MatrixMode(MatrixMode.Projection);//change to editing the projection matrix
            GL.LoadMatrix(ref projection);//store the matrix
        }

        public void RegisterGameObject(GameObject Object)
        {
            RegisteredObjects.Add(Object);
        }


        static void GameInit()
        {

            foreach (GameObject Object in RegisteredObjects)
            {
                Object.OnAwake();
            }

            CameraPosition = new Vector3(-3, 1, -3);
            modelview = Matrix4.LookAt(CameraPosition, Vector3.Zero, Vector3.UnitY); //set the position and rotation of the camera
        }

        static void GameLogic()
        {
            //the frame logic for all elements            

            foreach (GameObject Object in RegisteredObjects)
            {
                Object.OnFrame();
            }
            
            GL.MatrixMode(MatrixMode.Modelview);//change to rendering 3d models
            GL.LoadMatrix(ref modelview);//load the matrix describing the camera
        }

        static void GameRender()
        {
            //rendering all game elements
            foreach (GameObject gameObject in RegisteredObjects)
            {
                gameObject.Draw();
            }
        }

    }
}
