
namespace Nocjar.Golf
{
    public abstract class GolfObjectBase
    {
        /* Placeholder */

    } /* end abstract class */

    public abstract class GolfObject : GolfObjectBase
    {

        public GolfObject() : base ()
        {
            /* 
             * Some sort of a unique identifier within the system.
             * Will most likely need to embellish to account for destruction.
             * assign the next object id.
             */
            id = _idCounter++;
        } /* end constructor */

        protected int id{ get; set; }

        private static int _idCounter = 0;
    } /* end class */


}