namespace ConsoleApp1.Exam
{
    public class Car
    {
        private Engine _engine;

        // Property to indicate if the engine is started
        public bool IsEngineStarted { get; private set; }

        public Car(Engine engine)
        {
            _engine = engine;
            IsEngineStarted = false; // Initially, the engine is off
        }

        public void StartCar()
        {
            _engine.Start();
            IsEngineStarted = true; // Set to true when the car is started
        }
    }

    public class Engine
    {
        public void Start()
        {
            // Logic to start the engine
            Console.WriteLine("Engine started.");
        }
    }
}