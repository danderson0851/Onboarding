namespace OnBoardingApp
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => string.Join(" ", FirstName, LastName);
        public bool IsOwner { get; set; }
        public int PinNumer { get; set; }
    }
}
