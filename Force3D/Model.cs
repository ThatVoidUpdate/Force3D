using System.Collections.Generic;

namespace Force3D
{
    /// <summary>
    /// Stores geometry used for a GameObject to render
    /// </summary>
    public class Model
    {
        /// <summary>
        /// A list of tris to express the geometry
        /// </summary>
        public List<Tri> Geometry;

        /// <summary>
        /// Create a Model with blank geometry
        /// </summary>
        public Model()
        {
            Geometry = new List<Tri>();
        }

        /// <summary>
        /// Crete a model with defined geometry
        /// </summary>
        /// <param name="_Geometry">The geometry to use</param>
        public Model(List<Tri> _Geometry)
        {
            Geometry = _Geometry;
        }
    }
}
