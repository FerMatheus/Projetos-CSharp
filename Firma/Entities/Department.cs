namespace Firma.Entities
{
    class Department
    {
        public string Name { get; set; }
        List<Worker> staff { get; set; }

        public Department(string name)
        {
            Name = name;
            staff = new List<Worker>();
        }
        public void AddWorker(Worker x)
        {
            staff.Add(x);
        }
    }
}
