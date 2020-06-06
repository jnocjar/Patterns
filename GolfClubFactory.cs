using  Nocjar.Golf;

public class GolfClubFactory : AbstractGolfFactory
{
        public override GolfObject createGolfObject() 
        {
            return new GolfClub();

        }
}

