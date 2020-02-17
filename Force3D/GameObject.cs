using System;
using System.Collections.Generic;
using System.Drawing;
using OpenTK;

namespace Force3D
{
    /// <summary>
    /// An object in a game, holding a list of Triangles that can be drawn, scaled and translated all at the same time
    /// </summary>
    public class GameObject
    {
        public Model model; //The model to be used when rendering etc.
        public Transformation transformation;

        /// <summary>
        /// A list of GameScripts that will be executed on this GameObject
        /// </summary>
        private List<GameScript> AttachedScripts = new List<GameScript>();


        #region Ctors
        /// <summary>
        /// Creates a GameObject with a list of triangles as its geometry
        /// </summary>
        /// <param name="_tris">The list of tris to use</param>
        public GameObject(List<Tri> _tris)
        {//If the gameobject is instantiated with a list of tris, then just store them
            model = new Model(_tris);
            transformation = new Transformation(this);
        }

        /// <summary>
        /// Creates a GameObject with a list of triangles as its geometry, and a position to start at
        /// </summary>
        /// <param name="_tris">The list of tris to use</param>
        /// <param name="position">The position to place the gameobject at</param>
        public GameObject(List<Tri> _tris, Vector3 position)
        {
            model = new Model(_tris);
            transformation = new Transformation(this, position, new Vector3(1,1,1), Vector3.Zero);
        }

        #endregion Ctors

        /// <summary>
        /// Used to draw the gameobject in the scene
        /// </summary>
        public void Draw()
        {//To draw, translate the gameobject to the correct position, draw the triangles and translate back. 
         //This keeps the tri positions where they are meant to be, for easier manipulating
            foreach (Tri tri in model.Geometry)
            {
                tri.Translate(transformation.position);
                tri.Draw();
                tri.Translate(-transformation.position);
            }
        }

        /// <summary>
        /// Used to set the colour of a gameobject, which sets the face colours of all the tris under it
        /// </summary>
        /// <param name="colour">The colour to set the gameobject to</param>
        public void setColour(Color colour)
        {
            foreach (Tri tri in model.Geometry)
            {
                tri.setColour(colour);
            }
        }

        /// <summary>
        /// Randomises the colour of all triangles in the model
        /// </summary>
        public void RandomiseColour()
        {
            foreach (Tri tri in model.Geometry)
            {
                tri.setColour(Color.FromArgb(Window.rnd.Next(0, 256), Window.rnd.Next(0, 256), Window.rnd.Next(0, 256)));
            }
        }

        /// <summary>
        /// Registers a GameScript to be executed on this GameObject
        /// </summary>
        /// <param name="Script">The script to be attached</param>
        public void RegisterScript(GameScript Script)
        {
            AttachedScripts.Add(Script);
        }

        /// <summary>
        /// Called when the GameObject loads, triggers OnAwake functions in child GameScripts
        /// </summary>
        public void OnAwake()
        {
            foreach (GameScript script in AttachedScripts)
            {
                script.ParentObject = this;
                script.OnAwake();
            }
        }

        /// <summary>
        /// Called every frame, triggers OnFrame functions in child GameScripts
        /// </summary>
        public void OnFrame()
        {
            foreach (GameScript script in AttachedScripts)
            {
                script.OnFrame();
            }
        }
    }
}

