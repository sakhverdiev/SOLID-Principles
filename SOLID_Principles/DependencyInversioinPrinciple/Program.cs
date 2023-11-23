// ==========================================================================================================
// D – Dependency Inversion Principle (DIP)  => High Level Class-lar, Low Level Class-lara asili olmamalidir.
// ==========================================================================================================


namespace DIP_Before
{
    class PersonRepository
    {
        private readonly string _connectionString;
        private readonly int _connectionTimeout;

        public PersonRepository(string connectionString, int connectionTimeout)
        {
            _connectionString = connectionString;
            _connectionTimeout = connectionTimeout;
        }

        public void ConnectToDatabase()
        {
            // connection to database
        }

        public void GetAllPeople()
        {
            // return people
        }
    }
    class MyService
    {
        private readonly PersonRepository _personRepository;

        public MyService()
        {
            _personRepository = new PersonRepository("myConnectionString", 123);
        }
    }
}


// ===========================================================================


namespace DIP_After
{
    interface IPersonRepository
    {
        void GetAllPeople();
    }

    class PersonRepository : IPersonRepository
    {
        private readonly string _connectionString;
        private readonly int _connectionTimeout;

        public PersonRepository(string connectionString, int connectionTimeout)
        {
            _connectionString = connectionString;
            _connectionTimeout = connectionTimeout;
        }

        private void connectToDatabase()
        {
            // connection to database
        }

        public void GetAllPeople()
        {
            connectToDatabase();
            // return people. 
        }
    }
    class MyService
    {
        private readonly IPersonRepository _personRepository;

        public MyService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
    }
}