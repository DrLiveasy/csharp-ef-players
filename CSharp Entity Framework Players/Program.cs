// See https://aka.ms/new-console-template for more information
using CSharp_Entity_Framework_Players;

Console.WriteLine("Hello, World!");

//Milestone 1:
using(CalcioContext db= new CalcioContext())
{
    Random Casuale = new Random();
    double PunteggioGen = Casuale.NextDouble() * 9 + 1;
    int PartiteGiocateGen = Casuale.Next(1, 101);
    int partiteVinteGen = Casuale.Next(0, PartiteGiocateGen + 1);

    Player giocatore = new Player() { Name = "pinco", Surname = "pallo", Punteggio = PunteggioGen, partiteGiocate = PartiteGiocateGen, partiteVinte = partiteVinteGen};

    Console.WriteLine(giocatore.ToString());

    giocatore.Name = "marco";
    giocatore.Surname = "pinco";



}
