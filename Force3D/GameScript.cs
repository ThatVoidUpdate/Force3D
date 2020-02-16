using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Force3D
{
    public abstract class GameScript
    {
        /// <summary>
        /// The parent gameobject of this script
        /// </summary>
        public GameObject ParentObject;

        /// <summary>
        /// If this method is implemented in the child, it will be called as soon as the game starts up
        /// </summary>
        public virtual void OnAwake() { }

        /// <summary>
        /// If this method is implemented in the child, it will be called every frame
        /// </summary>
        public virtual void OnFrame() { }

        /// <summary>
        /// If this methd is implemented in the child, it will be called when any key is pressed
        /// </summary>
        public virtual void OnKeypress() { }

    }

}
