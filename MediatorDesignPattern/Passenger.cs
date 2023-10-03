namespace MediatorDesignPattern
{
    internal interface IPassenger
    {
        string Name { get; }
        string Addrees { get; }

        int Location { get; }

        void Acknowledge(string name);
    }
    internal class Passenger : IPassenger
    {
        private string _name;
        private string _location;
        private int _id;

        public Passenger(string name,string address,int location)
        {
            _name = name;
            _location = address;
            _id = location; 
        }
        public string Name => _name;

        public string Addrees => _location;

        public int Location => _id;

        public void Acknowledge(string name)
        =>Console.WriteLine($"Passenger {Name} , Cab: {name}");
    }
}
