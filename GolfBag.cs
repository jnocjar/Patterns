using Nocjar.Golf;

public class GolfBag : GolfGear
{

    public GolfBag( string name ) : base ()
    {
        _name = name;

        /* need to do something to init the golf clubs */

    } /* end GolfBag */

    /*
     * Override the Object.ToString() method to be more informative.
     */
    public override string ToString()
    {
        return $"{this.GetType()}: id = {this.id} {this._name}";
    } /* end ToString */

    private string _name;
/*    private Club  _clubs[]; */
} /* end class */