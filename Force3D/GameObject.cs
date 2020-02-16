﻿using System;
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
        public enum Primitive { Cube, Cylinder };
        public Vector3 pos; //position of the gameobject
        public List<Tri> tris; //the array of triangles to be manipulated

        /// <summary>
        /// If you just want to be a right pain, and use a new list of tris, previously unheard of by humankind, then this is the method for you. no primitives, no locations, just raw triangles
        /// </summary>
        /// <param name="_tris">The list of tris to use, you foolish idiot</param>
        public GameObject(List<Tri> _tris)
        {//if the gameobject is instantiated with a list of tris, then just store them
            tris = _tris;
        }

        /// <summary>
        /// Used to instantiate a gameobject if you just have a primitive type, and want to transform it later, as it will be instantiated at 0,0,0
        /// </summary>
        /// <param name="type">The primitive type to use</param>
        public GameObject(Primitive type)
        {//if its initialised with a type, then set the tris accordingly
            switch (type)
            {
                case Primitive.Cube:
                    tris = Primitives.Cube;
                    break;
                case Primitive.Cylinder:
                    tris = Primitives.Cylinder;
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// Used to instantiate a gameobject if you have a primitive type and a vector3 as the position
        /// </summary>
        /// <param name="type">The primitive type to use</param>
        /// <param name="pos">The position as a vector3</param>
        public GameObject(Primitive type, Vector3 pos)
        {//if passed a type and a pos, then set the tris accordingly, and change the pos
            switch (type)
            {
                case Primitive.Cube:
                    tris = Primitives.Cube;
                    break;
                case Primitive.Cylinder:
                    tris = Primitives.Cylinder;
                    break;
                default:
                    break;
            }
            this.pos = pos;
        }

        /// <summary>
        /// Used to instantiate a gameobject if you have a primitive type and the components of a vector3, but cant be bothered to instantiate a new vector3
        /// </summary>
        /// <param name="type">The primitive type to use</param>
        /// <param name="x">The x position of this gameobject</param>
        /// <param name="y">The y position of this gameobject</param>
        /// <param name="z">The z position of this gameobject</param>
        public GameObject(Primitive type, float x, float y, float z)
        {//if passed a type and the components of a vector3, then init the triangles accordingly, and set the position
            switch (type)
            {
                case Primitive.Cube:
                    tris = Primitives.Cube;
                    break;
                case Primitive.Cylinder:
                    tris = Primitives.Cylinder;
                    break;
                default:
                    break;
            }
            this.pos = new Vector3(x, y, z);
        }


        /// <summary>
        /// Used to draw the gameobject in the scene
        /// </summary>
        public void Draw()
        {//to draw, translate the gameobject to the correct position, draw the triangles and translate back. 
         //This keeps the tri positions where they are meant to be, for easier manipulating
            Translate(pos);
            foreach (Tri tri in tris)
            {
                tri.Draw();
            }
            Translate(-pos);
        }


        /// <summary>
        /// Used to translate a gameobject by a vector3 (adds to current location)
        /// </summary>
        /// <param name="vector">This will translate by (translation in x, translation in y, translation in z)</param>
        public void Translate(Vector3 vector)
        {//to translate, just translate every triangle by that amount
            //pos += vector;
            foreach (Tri tri in tris)
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
            foreach (Tri tri in tris)
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

            foreach (Tri tri in tris)
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
            foreach (Tri tri in tris)
            {
                tri.setColour(colour);
            }
        }

        /// <summary>
        /// Randomises the colour of all triangles in the model
        /// </summary>
        public void RandomiseColour()
        {
            foreach (Tri tri in tris)
            {
                tri.setColour(Color.FromArgb(Window.rnd.Next(0, 256), Window.rnd.Next(0, 256), Window.rnd.Next(0, 256)));
            }
        }
    }
}

