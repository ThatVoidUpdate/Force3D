namespace Force3D
{
    /// <summary>
    /// The class to be used when adding custom behaviour to a GameObject
    /// </summary>
    /// <example>
    /// 
    /// class ExampleGameScript : GameScript
    ///{
    ///    public override void OnAwake()
    ///    {
    ///        gameObject.RandomiseColour();
    ///    }
    ///    
    ///    public override void OnFrame()
    ///    {
    ///        gameObject.transformation.Rotate(new Vector3(0, 1, 0));
    ///    }
    ///}
    /// </example>
public abstract class GameScript
    {
        /// <summary>
        /// The parent gameobject of this script
        /// </summary>
        public GameObject gameObject;

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
