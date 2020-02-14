using System;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using System.Drawing;



namespace Force3D
{
    /// <summary>
    /// A single triangle that can be drawn, moved around and scaled. Used to make up basic geometry in a scene, usually
    /// </summary>
    class Tri : IDisposable
    {//a single triangle to be rendered
        public Vector3 p1, p2, p3;//the positions of the points
        public Color p1c, p2c, p3c; //the colours of the points

        /// <summary>
        /// Instantiates a new tri with the three points specified
        /// </summary>
        /// <param name="_p1">Point 1 of the tri</param>
        /// <param name="_p2">Point 2 of the tri</param>
        /// <param name="_p3">Point 3 of the tri</param>
        public Tri(Vector3 _p1, Vector3 _p2, Vector3 _p3)
        {//if no colours are passed in the constructor, then just use random ones,and set the oints accordingly
            p1 = _p1;
            p2 = _p2;
            p3 = _p3;
            p1c = Color.FromArgb(0,0,0);
            p2c = Color.FromArgb(0,0,0);
            p3c = Color.FromArgb(0,0,0);
        }

        /// <summary>
        /// Draws the tri
        /// </summary>
        public void Draw()
        {//if it can be drawn, then tell opentk what colour to draw, and draw them
            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(p1c);
            GL.Vertex3(p1);
            GL.Color3(p2c);
            GL.Vertex3(p2);
            GL.Color3(p3c);
            GL.Vertex3(p3);
            GL.End();
        }

        /// <summary>
        /// Translates the tri by adding to all points
        /// </summary>
        /// <param name="vector">Amount to translate by in each direction</param>
        public void Translate(Vector3 vector)
        {//add the translation to every point for translateion
            p1 += vector;
            p2 += vector;
            p3 += vector;
        }

        /// <summary>
        /// Scales the Tri by multiplying all points by the correct amounts
        /// </summary>
        /// <param name="vector">Amount to scale by in each direction</param>
        public void Scale(Vector3 vector)
        {//to scale, multiply every point by the corresponding point fo the scaling vector
            p1.X = p1.X * vector.X;
            p1.Y = p1.Y * vector.Y;
            p1.Z = p1.Z * vector.Z;
            p2.X = p2.X * vector.X;
            p2.Y = p2.Y * vector.Y;
            p2.Z = p2.Z * vector.Z;
            p3.X = p3.X * vector.X;
            p3.Y = p3.Y * vector.Y;
            p3.Z = p3.Z * vector.Z;
        }

        /// <summary>
        /// Used to set the colour of the triangle
        /// </summary>
        /// <param name="colour">A c# color that the tri colour will be set to</param>
        public void setColour(Color colour)
        {//to set the colour of the tri, just set all point colours to that colour, opentk does the rest of the interpolation work by itself
            p1c = colour;
            p2c = colour;
            p3c = colour;
        }

        /// <summary>
        /// Honestly, I have no idea. It just kinda makes things work
        /// </summary>
        public void Dispose()
        {//add compatibility for "using". dont actually know what this does, but the internet told me to
            GC.SuppressFinalize(this);
        }
    }
}
