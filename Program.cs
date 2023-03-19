namespace TPMOD5_1302213045
{
    class mainProgram
    {
        static void Main(String[] args)
        {
            HaloGeneric haloGeneric = new HaloGeneric();
            haloGeneric.Sapauser("Risjad");

            Console.WriteLine("");

            DataGeneric <string> data = new DataGeneric<string> ("1302213045");
            data.PrintData();
        }
    }
}