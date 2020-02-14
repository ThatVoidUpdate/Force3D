using OpenTK;
using System;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace Force3D
{
    class Window : GameWindow
    {
        double fov = Math.PI / 4;

        public static GameObject cube = new GameObject(GameObject.Primitive.Cube);

        public static Matrix4 modelview = Matrix4.Identity;

        public static Vector3 CameraPosition = new Vector3(0, 0, -3);

        public static int FramesSinceStart = 0;

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


        static void GameInit()
        {
            //initialise all variables etc.
        }

        static void GameLogic()
        {
            //the frame logic for all elements
            FramesSinceStart++; //Increment the currect frame the game is on

            CameraPosition = new Vector3((float)Math.Sin(FramesSinceStart / (2 * Math.PI)) * 3, 1, (float)Math.Cos(FramesSinceStart / (2 * Math.PI)) * 3); //move the camera in a circle


            modelview = Matrix4.LookAt(CameraPosition, Vector3.Zero, Vector3.UnitY); //set the position and rotation of the camera
            GL.MatrixMode(MatrixMode.Modelview);//change to rendering 3d models
            GL.LoadMatrix(ref modelview);//load the matrix describing the camera
        }

        static void GameRender()
        {
            //rendering all game elements
            cube.Draw();
        }

    }
}
