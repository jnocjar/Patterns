
using Golf;

namespace Golf.GolfGear
{

public enum GolfGearCategory{INVALID, BAG, CLUB, BALL, GLOVE};


public class GolfGear : Golf.GolfObject
{
    public struct GolfGearInstance
    {
        public GolfGearCategory gearCat;
    } /* struct */

    public GolfGear()
    {
        _gearCat = GolfGearCategory.INVALID;
    } /* end default constructor */

    public GolfGear (in GolfGearCategory gearCategory)
    {
        _gearCat = gearCategory;
    } /* end constructor */

    public GolfGearCategory GetGearCategory()
    {
        return (_gearCat);
    }

    private GolfGearCategory _gearCat;
} /* end class */

public class GolfBag : GolfGear
{

    public GolfBag( string name ) : base (GolfGearCategory.BAG)
    {
        _name = name;
    } /* end GolfBag */

    /*
     * Override the Object.ToString() method to be more informative.
     */
    public override string ToString()
    {
        return $"GolfGear: {this._name} is a {this.GetGearCategory()}";
    } /* end ToString */

    private string _name;
//    private Club[]  _clubs;
} /* end class */

} /* end namespace */