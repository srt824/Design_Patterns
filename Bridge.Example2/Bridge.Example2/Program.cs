namespace Bridge.Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle carWithPetrolEngine = new Car(new PetrolEngine());
            carWithPetrolEngine.Drive();

            Vehicle busWithElectricEngine = new Bus(new ElectricEngine());
            busWithElectricEngine.Drive();
        }
    }
}
