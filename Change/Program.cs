namespace Change
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Dollar = ");
            int sum = int.Parse(Console.ReadLine());
            int kurs = 389;
            ChangeClass changeClass = new ChangeClass();
            int k = changeClass.Poxanakum(sum, kurs);
            Console.Write("Dram = ");
            Console.WriteLine(k);
            Tpel tpel = new Tpel();
            tpel.Tpell(k);

        }
    }
}