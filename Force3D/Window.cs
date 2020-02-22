using OpenTK;
using System;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Collections.Generic;

namespace Force3D
{
    public class Window : GameWindow
    {
        /// <summary>
        /// FOV of the camera in radians
        /// </summary>
        public double fov = Math.PI / 4;

        /// <summary>
        /// The viweport matrix
        /// </summary>
        public static Matrix4 modelview = Matrix4.Identity;

        /// <summary>
        /// The position of the camera
        /// </summary>
        public static Vector3 CameraPosition = new Vector3(0, 0, -3);

        /// <summary>
        /// An instance of the random class. Will be moved to a new class in future
        /// </summary>
        public static Random rnd = new Random();

        /// <summary>
        /// List of all the registered GameObjects in the scene to render, execute scripts on etc.
        /// </summary>
        private static List<GameObject> RegisteredObjects = new List<GameObject>();

        /// <summary>
        /// Called as soon as the game is first loaded
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {//runs when the game is first loaded
            base.OnLoad(e);//Tell OpenTK to load a new window

            GL.ClearColor(Color.CornflowerBlue); //change the background colour that everything is drawn on top of
            GL.Enable(EnableCap.Texture2D);
            GL.Enable(EnableCap.DepthTest);//Sort polygons by distance when drawing
            GL.DepthMask(true);
            GL.DepthFunc(DepthFunction.Lequal);

            GameInit(); //initialising the game
        }

        /// <summary>
        /// Called every time a frame is rendered
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderFrame(FrameEventArgs e)
        {//called every time the game wants to render a frame
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);//clear the screen
            Time.OnFrame(e);//Tell the time class how long the frame lasted

            Title = "FPS: " + 1 / e.Time;//Set the title of the window

            GameLogic();//perform all logic
            GameRender();//render the scene

            SwapBuffers();//send the data to the graphics card
        }

        /// <summary>
        /// Called whenever the window is resized
        /// </summary>
        /// <param name="e"></param>
        protected override void OnResize(EventArgs e)
        {//called whenever the game is resized
            base.OnResize(e);
            GL.Viewport(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width, ClientRectangle.Height);//set the viewport of the camera
            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView((float)fov, Width / (float)Height, 1.0f, 64.0f);//set how the camera renders to the screen
            GL.MatrixMode(MatrixMode.Projection);//change to editing the projection matrix
            GL.LoadMatrix(ref projection);//store the matrix
        }

        /// <summary>
        /// Call to register a GameObject to be drawn, have scripts executed on it, etc.
        /// </summary>
        /// <param name="Object">The object to be registered</param>
        public void RegisterGameObject(GameObject Object)
        {
            RegisteredObjects.Add(Object);
        }

        /// <summary>
        /// Initialises the engine, calling all OnAwake functions, etc.
        /// </summary>
        protected void GameInit()
        {

            foreach (GameObject Object in RegisteredObjects)
            {
                Object.OnAwake();
            }

            CameraPosition = new Vector3(-3, 1, -3);
            modelview = Matrix4.LookAt(CameraPosition, Vector3.Zero, Vector3.UnitY); //set the position and rotation of the camera
        }

        /// <summary>
        /// Calls the OnFrame methods of all of the GameObjects
        /// </summary>
        protected void GameLogic()
        {
            //the frame logic for all elements            

            foreach (GameObject Object in RegisteredObjects)
            {
                Object.OnFrame();
            }
        }

        /// <summary>
        /// Performs all rendering of GameObjects in the scene
        /// </summary>
        protected void GameRender()
        {
            GL.MatrixMode(MatrixMode.Modelview);//change to rendering 3d models
            GL.LoadMatrix(ref modelview);//load the matrix describing the camera

            //rendering all game elements
            foreach (GameObject gameObject in RegisteredObjects)
            {
                gameObject.Draw();
            }
        }

    }
}
