

namespace Golf
{
    public enum GolfType { GOLF_UNDEFINDED, GOLF_COURSE, GOLF_GAME, GOLF_SET, GOLF_BAG, GOLF_CLUB, GOLF_BALL };

    public abstract class GolfObjectBase
    {
        public virtual GolfType Type{ get; set; }

    } /* end abstract class */

    public class GolfObject : GolfObjectBase
    {
        private GolfType _golfType;

        public override GolfType Type
        {
            get
            {
                return _golfType;
            }
            set
            {
                _golfType = value;
            }
        } /* end override */

    } /* end class */


}