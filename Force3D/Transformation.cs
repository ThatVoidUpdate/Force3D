using OpenTK;
using System;

namespace Force3D
{
    /// <summary>
    /// Stores a transformation of a GameObject
    /// </summary>
    public class Transformation
    {
        /// <summary>
        /// The position of the object
        /// </summary>
        public Vector3 position;
        /// <summary>
        /// The scale of the object
        /// </summary>
        public Vector3 scale;
        /// <summary>
        /// The rotation of the object
        /// </summary>
        public Vector3 rotation;

        /// <summary>
        /// The gameobject that this Transformaiton is attached to 
        /// </summary>
        public GameObject gameObject;

        /// <summary>
        /// Creates an identity transformation
        /// </summary>
        /// <param name="_gameObject">The GameObject that this Transformation is attached to</param>
        public Transformation(GameObject _gameObject)
        {
            gameObject = _gameObject;
            position = Vector3.Zero; //Center of the world
            scale = new Vector3(1, 1, 1); //Unscaled
            rotation = Vector3.Zero; //No rotation
        }

        /// <summary>
        /// Creates a transformation with the given parameters
        /// </summary>
        /// <param name="_gameObject">The GameObject that this Transformation is attached to</param>
        /// <param name="_Position">The position for the object</param>
        /// <param name="_Scale">The scale for the gameobject</param>
        /// <param name="_Rotation">The rotation of the gameobject</param>
        public Transformation(GameObject _gameObject, Vector3 _Position, Vector3 _Scale, Vector3 _Rotation)
        {
            gameObject = _gameObject;
            position = _Position;
            scale = _Scale;
            rotation = _Rotation;
        }

        /// <summary>
        /// Used to translate a gameobject by a vector3 (adds to current location)
        /// </summary>
        /// <param name="vector">This will translate by (translation in x, translation in y, translation in z)</param>
        public void Translate(Vector3 vector)
        {//to translate, just translate every triangle by that amount
            position += vector;
            foreach (Tri tri in gameObject.model.Geometry)
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
            scale *= vector;
            foreach (Tri tri in gameObject.model.Geometry)
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
            this.rotation += _rotation;
            float conversion = (float)Math.PI / 180f;
            _rotation *= conversion; //convert from deg to rad

            Matrix3 rotation = new Matrix3((float)(Math.Cos(_rotation.Z) * Math.Cos(_rotation.Y)), (float)(Math.Cos(_rotation.Z) * Math.Sin(_rotation.Y) * Math.Sin(_rotation.X) - Math.Sin(_rotation.Z) * Math.Cos(_rotation.X)), (float)(Math.Sin(_rotation.Z) * Math.Sin(_rotation.X) + Math.Cos(_rotation.Z) * Math.Sin(_rotation.Y) * Math.Cos(_rotation.X)),
                                           (float)(Math.Sin(_rotation.Z) * Math.Cos(_rotation.Y)), (float)(Math.Cos(_rotation.Z) * Math.Cos(_rotation.X) + Math.Sin(_rotation.Z) * Math.Sin(_rotation.Y) * Math.Sin(_rotation.X)), (float)(Math.Sin(_rotation.Z) * Math.Sin(_rotation.Y) * Math.Cos(_rotation.X) - Math.Cos(_rotation.Z) * Math.Sin(_rotation.X)),
                                           (float)(-Math.Sin(_rotation.Y)), (float)(Math.Cos(_rotation.Y) * Math.Sin(_rotation.X)), (float)(Math.Cos(_rotation.Y) * Math.Cos(_rotation.X)));
            //compute the rotation matrix

            foreach (Tri tri in gameObject.model.Geometry)
            {//pre-multiply each point of every triangle by the rotation matrix
                tri.p1 = rotation * tri.p1;
                tri.p2 = rotation * tri.p2;
                tri.p3 = rotation * tri.p3;
            }
        }
    }
}
