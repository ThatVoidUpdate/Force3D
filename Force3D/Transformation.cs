using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace Force3D
{
    /// <summary>
    /// Stores a transformation of a GameObject
    /// </summary>
    public class Transformation
    {
        public Vector3 Position; //The position of the object
        public Vector3 Scale; //The scale of the object
        public Vector3 Rotation; //The rotation of the object

        /// <summary>
        /// Creates an identity transformation
        /// </summary>
        public Transformation()
        {
            Position = Vector3.Zero; //Center of the world
            Scale = new Vector3(1, 1, 1); //Unscaled
            Rotation = Vector3.Zero; //No rotation
        }

        /// <summary>
        /// Creates a transformation with the given parameters
        /// </summary>
        /// <param name="_Position">The position for the object</param>
        /// <param name="_Scale">The scale for the gameobject</param>
        /// <param name="_Rotation">The rotation of the gameobject</param>
        public Transformation(Vector3 _Position, Vector3 _Scale, Vector3 _Rotation)
        {
            Position = _Position;
            Scale = _Scale;
            Rotation = _Rotation;
        }
    }
}
