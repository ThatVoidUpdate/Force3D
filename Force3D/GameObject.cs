using System;
using System.Collections.Generic;
using System.Drawing;
using OpenTK;

namespace Force3D
{
    /// <summary>
    /// An object in a game, holding a list of Triangles that can be drawn, scaled and translated all at the same time
    /// </summary>
    class GameObject
    {

        public Model model; //The model to be used when rendering etc.
        public Transformation transformation;

        /// <summary>
        /// Creates a GameObject with a list of triangles as its geometry
        /// </summary>
        /// <param name="_tris">The list of tris to use</param>
        public GameObject(List<Tri> _tris)
        {//If the gameobject is instantiated with a list of tris, then just store them
            model = new Model(_tris);
            transformation = new Transformation();
        }

        /// <summary>
        /// Creates a GameObject with a list of triangles as its geometry, and a position to start at
        /// </summary>
        /// <param name="_tris">The list of tris to use</param>
        /// <param name="position">The position to place the gameobject at</param>
        public GameObject(List<Tri> _tris, Vector3 position)
        {
            model = new Model(_tris);
            transformation = new Transformation(position, new Vector3(1,1,1), Vector3.Zero);
        }

        /// <summary>
        /// Used to draw the gameobject in the scene
        /// </summary>
        public void Draw()
        {//To draw, translate the gameobject to the correct position, draw the triangles and translate back. 
         //This keeps the tri positions where they are meant to be, for easier manipulating
            foreach (Tri tri in model.Geometry)
            {
                tri.Translate(transformation.Position);
                tri.Draw();
                tri.Translate(-transformation.Position);
            }
        }


        /// <summary>
        /// Used to translate a gameobject by a vector3 (adds to current location)
        /// </summary>
        /// <param name="vector">This will translate by (translation in x, translation in y, translation in z)</param>
        public void Translate(Vector3 vector)
        {//to translate, just translate every triangle by that amount
            transformation.Position += vector;
            foreach (Tri tri in model.Geometry)
            {
                tri.Translate(vector);
            }
        }

        /// <summary>
        /// Used to scale a gameobject, with the centre at (0,0,0)
        /// </summary>
        /// <param name="vector">This will scale by (scale in x, scale in y, scale in z)</param>
        public void Scale(Vector3 vector)
        {//same for scaling
            foreach (Tri tri in model.Geometry)
            {
                tri.Scale(vector);
            }
        }


        /// <summary>
        /// Used to rotate a gameobject by a specified amount (degrees). Note that rotations are non-commutative. ABB`A` /= ABA`B`
        /// </summary>
        /// <param name="_rotation">This will rotate by (amount in x axis, amount in y axis, amount in z axis)</param>
        public void Rotate(Vector3 _rotation)
        {//rotation is the hard one
            float conversion = (float)Math.PI / 180f;
            _rotation *= conversion; //convert from deg to rad

            Matrix3 rotation = new Matrix3((float)(Math.Cos(_rotation.Z) * Math.Cos(_rotation.Y)), (float)(Math.Cos(_rotation.Z) * Math.Sin(_rotation.Y) * Math.Sin(_rotation.X) - Math.Sin(_rotation.Z) * Math.Cos(_rotation.X)), (float)(Math.Sin(_rotation.Z) * Math.Sin(_rotation.X) + Math.Cos(_rotation.Z) * Math.Sin(_rotation.Y) * Math.Cos(_rotation.X)),
                                           (float)(Math.Sin(_rotation.Z) * Math.Cos(_rotation.Y)), (float)(Math.Cos(_rotation.Z) * Math.Cos(_rotation.X) + Math.Sin(_rotation.Z) * Math.Sin(_rotation.Y) * Math.Sin(_rotation.X)), (float)(Math.Sin(_rotation.Z) * Math.Sin(_rotation.Y) * Math.Cos(_rotation.X) - Math.Cos(_rotation.Z) * Math.Sin(_rotation.X)),
                                           (float)(-Math.Sin(_rotation.Y)), (float)(Math.Cos(_rotation.Y) * Math.Sin(_rotation.X)), (float)(Math.Cos(_rotation.Y) * Math.Cos(_rotation.X)));
            //compute the rotation matrix

            foreach (Tri tri in model.Geometry)
            {//pre-multiply each point of every triangle by the ration matrix
                tri.p1 = rotation * tri.p1;
                tri.p2 = rotation * tri.p2;
                tri.p3 = rotation * tri.p3;
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
    }
}

