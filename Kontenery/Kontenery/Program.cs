using APBD2;

namespace APBD2
{
    public class Kontenery
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            Container container1 = new Container(1000, 200, 1500, 50, APBD2.Type.G, 500);

            Container container2 = new Container(1000, 200, 1500, 50, APBD2.Type.L, 500);
            ContainerL container3 = new ContainerL(1000, 200, 1500, 50, APBD2.Type.L, 500);


            Console.WriteLine(container2.showContainerId());
            Console.WriteLine(container3.showContainerId());
            container3.NotifyHazard();
        }
    }
}