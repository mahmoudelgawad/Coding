namespace UnitTest_PlayGround
{
    public class Reservation
    {
        public User? MadeBy { get; set; } = null;

        public bool CanCancelledBy(User user) 
        {
            /*
            if (user.IsAdmin)
                return true;

            if (MadeBy != null && MadeBy == user)
                return true;

            return false;
            */

            //Refactoring
            return (user.IsAdmin) || (MadeBy != null && MadeBy == user);
        }
    }

    public class  User
    {
        public bool IsAdmin { get; set; }
    }
}
