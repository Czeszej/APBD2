using APBD2;

namespace APBD2
{
    public class Kontenery
    {
        public static void Main(string[] args)
        {
            //Tworzenie kontenerow
            Container container1 = new Container(0, 200, 1500, 50, APBD2.Type.G, 500);
            ContainerL containerL = new ContainerL(0, 200, 1500, 50, APBD2.Type.L, 500, false);
            ContainerG containerG = new ContainerG(1300, 300, 2000, 50, Type.G, 3000, 50.5);
            ContainerC containerC = new ContainerC(2000, 400, 4000, 50, Type.C, 5000, 20.3);

            //Zaladowanie ladunku do kontenera
            containerL.AddCargo(400);
           
            //Przekroczenie masy ladunku kontenera
            containerL.AddCargo(150);

            //Dodawanie i usuwanie konteneru na i ze statku
            Ship ship = new Ship(30,50,15000);
            Ship ship2 = new Ship(40, 60, 20000);
            ship.AddContainer(containerL);
            ship.RemoveContainer(containerL);
            ship.AddContainer(containerG);

            //Rozladowanie kontenera
            containerL.RemoveCargo(400);

            Console.WriteLine(containerL.showContainerId());
            containerG.NotifyHazard();
            //Wypisanie informacji o danym kontenerze
            containerL.ShowInfo();

            //Wypisanie informacji o statku i jego ładunku
            ship.ShowInfo();

            //Zastapienie kontenera innym
            ship.ChangeContainer("KON-G-3", containerC);

            //Przeniesienie kontenera miedzy statkami
            ship.ChangeShipForContainer(containerC, ship, ship2);



        }
    }
}