namespace DesignPatterns.Behavioral.Observer
{
    public interface ICelebrity
    {
        // Name of subject
        public string Name { get; }
        
        int Flag { get; set; }

        void Register(IObserver o);

        void UnRegister(IObserver o);

        void NotifyRegisteredUsers();
    }
}