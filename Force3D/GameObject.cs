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
                    tris = new List<Tri>() {new Tri(new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(-0.5f, -0.5f, -0.5f), new Vector3(0.5f, -0.5f, -0.5f)),
                                                            new Tri(new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(0.5f, 0.5f, -0.5f), new Vector3(0.5f, -0.5f, -0.5f)),
                                                            new Tri(new Vector3(0.5f, 0.5f, -0.5f), new Vector3(0.5f, -0.5f, -0.5f), new Vector3(0.5f, -0.5f, 0.5f)),
                                                            new Tri(new Vector3(0.5f, 0.5f, -0.5f), new Vector3(0.5f, 0.5f, 0.5f), new Vector3(0.5f, -0.5f, 0.5f)),
                                                            new Tri(new Vector3(0.5f, 0.5f, 0.5f), new Vector3(0.5f, -0.5f, 0.5f), new Vector3(-0.5f, -0.5f, 0.5f)),
                                                            new Tri(new Vector3(0.5f, 0.5f, 0.5f), new Vector3(-0.5f, 0.5f, 0.5f), new Vector3(-0.5f, -0.5f, 0.5f)),
                                                            new Tri(new Vector3(-0.5f, 0.5f, 0.5f), new Vector3(-0.5f, -0.5f, 0.5f), new Vector3(-0.5f, -0.5f, -0.5f)),
                                                            new Tri(new Vector3(-0.5f, 0.5f, 0.5f), new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(-0.5f, -0.5f, -0.5f)),
                                                            new Tri(new Vector3(0.5f, 0.5f, 0.5f), new Vector3(-0.5f, 0.5f, 0.5f), new Vector3(-0.5f, 0.5f, -0.5f)),
                                                            new Tri(new Vector3(0.5f, 0.5f, 0.5f), new Vector3(0.5f, 0.5f, -0.5f), new Vector3(-0.5f, 0.5f, -0.5f)),
                                                            new Tri(new Vector3(0.5f, -0.5f, 0.5f), new Vector3(-0.5f, -0.5f, 0.5f), new Vector3(-0.5f, -0.5f, -0.5f)),
                                                            new Tri(new Vector3(0.5f, -0.5f, 0.5f), new Vector3(0.5f, -0.5f, -0.5f), new Vector3(-0.5f, -0.5f, -0.5f))};
                    break;
                case Primitive.Cylinder:
                    tris = new List<Tri>() { new Tri(new Vector3(0.47553f, -0.15451f, 0.5f), new Vector3(0.47553f, 0.15451f, 0.5f), new Vector3(0.47553f, -0.15451f, -0.5f)) };
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
                    tris = new List<Tri>()
                    {
                        new Tri(new Vector3(-0.5f, 0.5f, 0.5f), new Vector3(-0.5f, -0.5f, -0.5f),
                            new Vector3(-0.5f, -0.5f, 0.5f)),
                        new Tri(new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(0.5f, -0.5f, -0.5f),
                            new Vector3(-0.5f, -0.5f, -0.5f)),
                        new Tri(new Vector3(0.5f, 0.5f, -0.5f), new Vector3(0.5f, -0.5f, 0.5f),
                            new Vector3(0.5f, -0.5f, -0.5f)),
                        new Tri(new Vector3(0.5f, 0.5f, 0.5f), new Vector3(-0.5f, -0.5f, 0.5f),
                            new Vector3(0.5f, -0.5f, 0.5f)),
                        new Tri(new Vector3(0.5f, -0.5f, -0.5f), new Vector3(-0.5f, -0.5f, 0.5f),
                            new Vector3(-0.5f, -0.5f, -0.5f)),
                        new Tri(new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(0.5f, 0.5f, 0.5f),
                            new Vector3(0.5f, 0.5f, -0.5f)),
                        new Tri(new Vector3(-0.5f, 0.5f, 0.5f), new Vector3(-0.5f, 0.5f, -0.5f),
                            new Vector3(-0.5f, -0.5f, -0.5f)),
                        new Tri(new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(0.5f, 0.5f, -0.5f),
                            new Vector3(0.5f, -0.5f, -0.5f)),
                        new Tri(new Vector3(0.5f, 0.5f, -0.5f), new Vector3(0.5f, 0.5f, 0.5f),
                            new Vector3(0.5f, -0.5f, 0.5f)),
                        new Tri(new Vector3(0.5f, 0.5f, 0.5f), new Vector3(-0.5f, 0.5f, 0.5f),
                            new Vector3(-0.5f, -0.5f, 0.5f)),
                        new Tri(new Vector3(0.5f, -0.5f, -0.5f), new Vector3(0.5f, -0.5f, 0.5f),
                            new Vector3(-0.5f, -0.5f, 0.5f)),
                        new Tri(new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(-0.5f, 0.5f, 0.5f),
                            new Vector3(0.5f, 0.5f, 0.5f))
                    };
                    break;
                case Primitive.Cylinder:
                    tris = new List<Tri>()
                    {
                        new Tri(new Vector3(0.475525f, 0.500001f, 0.154503f),
                            new Vector3(0.29389f, -0.499999f, 0.404503f),
                            new Vector3(0.475525f, -0.499999f, 0.154503f)),
                        new Tri(new Vector3(-0.475531f, -0.499999f, 0.154503f),
                            new Vector3(-0.475531f, -0.499999f, -0.154514f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-3E-06f, 0.500001f, 0.499995f),
                            new Vector3(-0.293896f, 0.500001f, 0.404503f),
                            new Vector3(-0.293896f, -0.499999f, 0.404503f)),
                        new Tri(new Vector3(0.475525f, 0.500001f, -0.154514f),
                            new Vector3(0.475525f, -0.499999f, 0.154503f),
                            new Vector3(0.475525f, -0.499999f, -0.154514f)),
                        new Tri(new Vector3(-0.475531f, -0.499999f, -0.154514f),
                            new Vector3(-0.293895f, -0.499999f, -0.404514f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-0.293896f, 0.500001f, 0.404503f),
                            new Vector3(-0.475531f, 0.500001f, 0.154503f),
                            new Vector3(-0.475531f, -0.499999f, 0.154503f)),
                        new Tri(new Vector3(0.29389f, 0.500001f, -0.404514f),
                            new Vector3(0.475525f, -0.499999f, -0.154514f),
                            new Vector3(0.29389f, -0.499999f, -0.404514f)),
                        new Tri(new Vector3(-0.293895f, -0.499999f, -0.404514f),
                            new Vector3(-3E-06f, -0.499999f, -0.500005f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-0.293895f, 0.500001f, -0.404514f),
                            new Vector3(-3E-06f, 0.500001f, -0.500005f), new Vector3(-3E-06f, -0.499999f, -0.500005f)),
                        new Tri(new Vector3(-3E-06f, 0.500001f, -0.500005f),
                            new Vector3(0.29389f, -0.499999f, -0.404514f),
                            new Vector3(-3E-06f, -0.499999f, -0.500005f)),
                        new Tri(new Vector3(-3E-06f, -0.499999f, -0.500005f),
                            new Vector3(0.29389f, -0.499999f, -0.404514f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-0.475531f, 0.500001f, -0.154514f),
                            new Vector3(-0.293895f, 0.500001f, -0.404514f),
                            new Vector3(-0.293895f, -0.499999f, -0.404514f)),
                        new Tri(new Vector3(0.29389f, 0.500001f, 0.404503f), new Vector3(-3E-06f, 0.500001f, 0.499995f),
                            new Vector3(-3E-06f, -0.499999f, 0.499995f)),
                        new Tri(new Vector3(-0.293896f, -0.499999f, 0.404503f),
                            new Vector3(-0.475531f, -0.499999f, 0.154503f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(0.29389f, 0.500001f, 0.404503f),
                            new Vector3(-3E-06f, -0.499999f, 0.499995f), new Vector3(0.29389f, -0.499999f, 0.404503f)),
                        new Tri(new Vector3(-3E-06f, 0.500001f, -0.500005f),
                            new Vector3(0.29389f, 0.500001f, -0.404514f),
                            new Vector3(0.29389f, -0.499999f, -0.404514f)),
                        new Tri(new Vector3(-3E-06f, -0.499999f, 0.499995f),
                            new Vector3(-0.293896f, -0.499999f, 0.404503f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-3E-06f, 0.500001f, 0.499995f),
                            new Vector3(-0.293896f, -0.499999f, 0.404503f),
                            new Vector3(-3E-06f, -0.499999f, 0.499995f)),
                        new Tri(new Vector3(0.29389f, 0.500001f, -0.404514f),
                            new Vector3(0.475525f, 0.500001f, -0.154514f),
                            new Vector3(0.475525f, -0.499999f, -0.154514f)),
                        new Tri(new Vector3(0.29389f, -0.499999f, 0.404503f),
                            new Vector3(-3E-06f, -0.499999f, 0.499995f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-0.293896f, 0.500001f, 0.404503f),
                            new Vector3(-0.475531f, -0.499999f, 0.154503f),
                            new Vector3(-0.293896f, -0.499999f, 0.404503f)),
                        new Tri(new Vector3(0.475525f, 0.500001f, -0.154514f),
                            new Vector3(0.475525f, 0.500001f, 0.154503f),
                            new Vector3(0.475525f, -0.499999f, 0.154503f)),
                        new Tri(new Vector3(0.475525f, -0.499999f, 0.154503f),
                            new Vector3(0.29389f, -0.499999f, 0.404503f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-0.475531f, 0.500001f, 0.154503f),
                            new Vector3(-0.475531f, -0.499999f, -0.154514f),
                            new Vector3(-0.475531f, -0.499999f, 0.154503f)),
                        new Tri(new Vector3(0.475525f, 0.500001f, 0.154503f),
                            new Vector3(0.29389f, 0.500001f, 0.404503f), new Vector3(0.29389f, -0.499999f, 0.404503f)),
                        new Tri(new Vector3(0.29389f, 0.500001f, 0.404503f),
                            new Vector3(0.475525f, 0.500001f, 0.154503f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(-0.475531f, 0.500001f, -0.154514f),
                            new Vector3(-0.293895f, -0.499999f, -0.404514f),
                            new Vector3(-0.475531f, -0.499999f, -0.154514f)),
                        new Tri(new Vector3(-0.475531f, 0.500001f, 0.154503f),
                            new Vector3(-0.475531f, 0.500001f, -0.154514f),
                            new Vector3(-0.475531f, -0.499999f, -0.154514f)),
                        new Tri(new Vector3(0.29389f, -0.499999f, -0.404514f),
                            new Vector3(0.475525f, -0.499999f, -0.154514f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-0.293895f, 0.500001f, -0.404514f),
                            new Vector3(-3E-06f, -0.499999f, -0.500005f),
                            new Vector3(-0.293895f, -0.499999f, -0.404514f)),
                        new Tri(new Vector3(0.475525f, -0.499999f, -0.154514f),
                            new Vector3(0.475525f, -0.499999f, 0.154503f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(0.475525f, 0.500001f, 0.154503f),
                            new Vector3(0.475525f, 0.500001f, -0.154514f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(0.475525f, 0.500001f, -0.154514f),
                            new Vector3(0.29389f, 0.500001f, -0.404514f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(0.29389f, 0.500001f, -0.404514f),
                            new Vector3(-3E-06f, 0.500001f, -0.500005f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(-3E-06f, 0.500001f, -0.500005f),
                            new Vector3(-0.293895f, 0.500001f, -0.404514f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(-0.293895f, 0.500001f, -0.404514f),
                            new Vector3(-0.475531f, 0.500001f, -0.154514f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(-0.475531f, 0.500001f, -0.154514f),
                            new Vector3(-0.475531f, 0.500001f, 0.154503f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(-0.475531f, 0.500001f, 0.154503f),
                            new Vector3(-0.293896f, 0.500001f, 0.404503f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(-0.293896f, 0.500001f, 0.404503f),
                            new Vector3(-3E-06f, 0.500001f, 0.499995f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(-3E-06f, 0.500001f, 0.499995f), new Vector3(0.29389f, 0.500001f, 0.404503f),
                            new Vector3(-3E-06f, 0.500001f, -5E-06f))
                    };
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
                    tris = new List<Tri>() {new Tri(new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(-0.5f, -0.5f, -0.5f), new Vector3(0.5f, -0.5f, -0.5f)),
                                                            new Tri(new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(0.5f, 0.5f, -0.5f), new Vector3(0.5f, -0.5f, -0.5f)),
                                                            new Tri(new Vector3(0.5f, 0.5f, -0.5f), new Vector3(0.5f, -0.5f, -0.5f), new Vector3(0.5f, -0.5f, 0.5f)),
                                                            new Tri(new Vector3(0.5f, 0.5f, -0.5f), new Vector3(0.5f, 0.5f, 0.5f), new Vector3(0.5f, -0.5f, 0.5f)),
                                                            new Tri(new Vector3(0.5f, 0.5f, 0.5f), new Vector3(0.5f, -0.5f, 0.5f), new Vector3(-0.5f, -0.5f, 0.5f)),
                                                            new Tri(new Vector3(0.5f, 0.5f, 0.5f), new Vector3(-0.5f, 0.5f, 0.5f), new Vector3(-0.5f, -0.5f, 0.5f)),
                                                            new Tri(new Vector3(-0.5f, 0.5f, 0.5f), new Vector3(-0.5f, -0.5f, 0.5f), new Vector3(-0.5f, -0.5f, -0.5f)),
                                                            new Tri(new Vector3(-0.5f, 0.5f, 0.5f), new Vector3(-0.5f, 0.5f, -0.5f), new Vector3(-0.5f, -0.5f, -0.5f)),
                                                            new Tri(new Vector3(0.5f, 0.5f, 0.5f), new Vector3(-0.5f, 0.5f, 0.5f), new Vector3(-0.5f, 0.5f, -0.5f)),
                                                            new Tri(new Vector3(0.5f, 0.5f, 0.5f), new Vector3(0.5f, 0.5f, -0.5f), new Vector3(-0.5f, 0.5f, -0.5f)),
                                                            new Tri(new Vector3(0.5f, -0.5f, 0.5f), new Vector3(-0.5f, -0.5f, 0.5f), new Vector3(-0.5f, -0.5f, -0.5f)),
                                                            new Tri(new Vector3(0.5f, -0.5f, 0.5f), new Vector3(0.5f, -0.5f, -0.5f), new Vector3(-0.5f, -0.5f, -0.5f))};
                    break;
                case Primitive.Cylinder:
                    tris = new List<Tri>()
                    {
                        new Tri(new Vector3(0.475525f, 0.500001f, 0.154503f),
                            new Vector3(0.29389f, -0.499999f, 0.404503f),
                            new Vector3(0.475525f, -0.499999f, 0.154503f)),
                        new Tri(new Vector3(-0.475531f, -0.499999f, 0.154503f),
                            new Vector3(-0.475531f, -0.499999f, -0.154514f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-3E-06f, 0.500001f, 0.499995f),
                            new Vector3(-0.293896f, 0.500001f, 0.404503f),
                            new Vector3(-0.293896f, -0.499999f, 0.404503f)),
                        new Tri(new Vector3(0.475525f, 0.500001f, -0.154514f),
                            new Vector3(0.475525f, -0.499999f, 0.154503f),
                            new Vector3(0.475525f, -0.499999f, -0.154514f)),
                        new Tri(new Vector3(-0.475531f, -0.499999f, -0.154514f),
                            new Vector3(-0.293895f, -0.499999f, -0.404514f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-0.293896f, 0.500001f, 0.404503f),
                            new Vector3(-0.475531f, 0.500001f, 0.154503f),
                            new Vector3(-0.475531f, -0.499999f, 0.154503f)),
                        new Tri(new Vector3(0.29389f, 0.500001f, -0.404514f),
                            new Vector3(0.475525f, -0.499999f, -0.154514f),
                            new Vector3(0.29389f, -0.499999f, -0.404514f)),
                        new Tri(new Vector3(-0.293895f, -0.499999f, -0.404514f),
                            new Vector3(-3E-06f, -0.499999f, -0.500005f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-0.293895f, 0.500001f, -0.404514f),
                            new Vector3(-3E-06f, 0.500001f, -0.500005f), new Vector3(-3E-06f, -0.499999f, -0.500005f)),
                        new Tri(new Vector3(-3E-06f, 0.500001f, -0.500005f),
                            new Vector3(0.29389f, -0.499999f, -0.404514f),
                            new Vector3(-3E-06f, -0.499999f, -0.500005f)),
                        new Tri(new Vector3(-3E-06f, -0.499999f, -0.500005f),
                            new Vector3(0.29389f, -0.499999f, -0.404514f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-0.475531f, 0.500001f, -0.154514f),
                            new Vector3(-0.293895f, 0.500001f, -0.404514f),
                            new Vector3(-0.293895f, -0.499999f, -0.404514f)),
                        new Tri(new Vector3(0.29389f, 0.500001f, 0.404503f), new Vector3(-3E-06f, 0.500001f, 0.499995f),
                            new Vector3(-3E-06f, -0.499999f, 0.499995f)),
                        new Tri(new Vector3(-0.293896f, -0.499999f, 0.404503f),
                            new Vector3(-0.475531f, -0.499999f, 0.154503f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(0.29389f, 0.500001f, 0.404503f),
                            new Vector3(-3E-06f, -0.499999f, 0.499995f), new Vector3(0.29389f, -0.499999f, 0.404503f)),
                        new Tri(new Vector3(-3E-06f, 0.500001f, -0.500005f),
                            new Vector3(0.29389f, 0.500001f, -0.404514f),
                            new Vector3(0.29389f, -0.499999f, -0.404514f)),
                        new Tri(new Vector3(-3E-06f, -0.499999f, 0.499995f),
                            new Vector3(-0.293896f, -0.499999f, 0.404503f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-3E-06f, 0.500001f, 0.499995f),
                            new Vector3(-0.293896f, -0.499999f, 0.404503f),
                            new Vector3(-3E-06f, -0.499999f, 0.499995f)),
                        new Tri(new Vector3(0.29389f, 0.500001f, -0.404514f),
                            new Vector3(0.475525f, 0.500001f, -0.154514f),
                            new Vector3(0.475525f, -0.499999f, -0.154514f)),
                        new Tri(new Vector3(0.29389f, -0.499999f, 0.404503f),
                            new Vector3(-3E-06f, -0.499999f, 0.499995f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-0.293896f, 0.500001f, 0.404503f),
                            new Vector3(-0.475531f, -0.499999f, 0.154503f),
                            new Vector3(-0.293896f, -0.499999f, 0.404503f)),
                        new Tri(new Vector3(0.475525f, 0.500001f, -0.154514f),
                            new Vector3(0.475525f, 0.500001f, 0.154503f),
                            new Vector3(0.475525f, -0.499999f, 0.154503f)),
                        new Tri(new Vector3(0.475525f, -0.499999f, 0.154503f),
                            new Vector3(0.29389f, -0.499999f, 0.404503f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-0.475531f, 0.500001f, 0.154503f),
                            new Vector3(-0.475531f, -0.499999f, -0.154514f),
                            new Vector3(-0.475531f, -0.499999f, 0.154503f)),
                        new Tri(new Vector3(0.475525f, 0.500001f, 0.154503f),
                            new Vector3(0.29389f, 0.500001f, 0.404503f), new Vector3(0.29389f, -0.499999f, 0.404503f)),
                        new Tri(new Vector3(0.29389f, 0.500001f, 0.404503f),
                            new Vector3(0.475525f, 0.500001f, 0.154503f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(-0.475531f, 0.500001f, -0.154514f),
                            new Vector3(-0.293895f, -0.499999f, -0.404514f),
                            new Vector3(-0.475531f, -0.499999f, -0.154514f)),
                        new Tri(new Vector3(-0.475531f, 0.500001f, 0.154503f),
                            new Vector3(-0.475531f, 0.500001f, -0.154514f),
                            new Vector3(-0.475531f, -0.499999f, -0.154514f)),
                        new Tri(new Vector3(0.29389f, -0.499999f, -0.404514f),
                            new Vector3(0.475525f, -0.499999f, -0.154514f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(-0.293895f, 0.500001f, -0.404514f),
                            new Vector3(-3E-06f, -0.499999f, -0.500005f),
                            new Vector3(-0.293895f, -0.499999f, -0.404514f)),
                        new Tri(new Vector3(0.475525f, -0.499999f, -0.154514f),
                            new Vector3(0.475525f, -0.499999f, 0.154503f), new Vector3(-3E-06f, -0.499999f, -5E-06f)),
                        new Tri(new Vector3(0.475525f, 0.500001f, 0.154503f),
                            new Vector3(0.475525f, 0.500001f, -0.154514f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(0.475525f, 0.500001f, -0.154514f),
                            new Vector3(0.29389f, 0.500001f, -0.404514f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(0.29389f, 0.500001f, -0.404514f),
                            new Vector3(-3E-06f, 0.500001f, -0.500005f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(-3E-06f, 0.500001f, -0.500005f),
                            new Vector3(-0.293895f, 0.500001f, -0.404514f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(-0.293895f, 0.500001f, -0.404514f),
                            new Vector3(-0.475531f, 0.500001f, -0.154514f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(-0.475531f, 0.500001f, -0.154514f),
                            new Vector3(-0.475531f, 0.500001f, 0.154503f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(-0.475531f, 0.500001f, 0.154503f),
                            new Vector3(-0.293896f, 0.500001f, 0.404503f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(-0.293896f, 0.500001f, 0.404503f),
                            new Vector3(-3E-06f, 0.500001f, 0.499995f), new Vector3(-3E-06f, 0.500001f, -5E-06f)),
                        new Tri(new Vector3(-3E-06f, 0.500001f, 0.499995f), new Vector3(0.29389f, 0.500001f, 0.404503f),
                            new Vector3(-3E-06f, 0.500001f, -5E-06f))
                    };
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
        /// <param name="vector">This will translate by (translation in x, translation in y, translation in )</param>
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
        /// not currently implemented, due to poor understanding of collision, but will soon be implemented
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool isColliding(GameObject other)
        {//not yet properly implemented
            throw new NotImplementedException();
            return (tris.ToArray()[7].p1.X <= other.tris.ToArray()[3].p1.X && tris.ToArray()[3].p1.X >= other.tris.ToArray()[7].p1.X) &&
                   (tris.ToArray()[1].p1.Y <= other.tris.ToArray()[1].p2.Y && tris.ToArray()[1].p1.Y >= other.tris.ToArray()[1].p2.Y) &&
                   (tris.ToArray()[1].p1.Z <= other.tris.ToArray()[5].p1.Z && tris.ToArray()[5].p1.Z >= other.tris.ToArray()[1].p1.Z);
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
    }
}

