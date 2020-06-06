using Nocjar.Golf;

public abstract class GolfClub : GolfGear
{
    public GolfClub() : base ()
    {
        golfClubName = "Unknown";
        golfClubSetting = 0;
    }


    public virtual void Swing() {}


    protected string golfClubName { get; set; }
    protected int golfClubSetting{ get; set; }


}