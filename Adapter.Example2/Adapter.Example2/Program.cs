namespace Adapter.Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LegacyDatabase legacyDatabase = new LegacyDatabase();
            DatabaseAdapter adapter = new DatabaseAdapter(legacyDatabase);

            NewSystem newSystem = new NewSystem(adapter);

            newSystem.SaveData("Important data");
            newSystem.LoadData();
        }
    }
}
