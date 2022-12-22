// See https://aka.ms/new-console-template for more information
using CSharp_Entity_Framework_Players;

Console.WriteLine("Hello, World!");

//Milestone 1:
/*
using(CalcioContext db= new CalcioContext())
{
    Random Casuale = new Random();
    double PunteggioGen = Casuale.NextDouble() * 9 + 1;
    int PartiteGiocateGen = Casuale.Next(1, 101);
    int partiteVinteGen = Casuale.Next(0, PartiteGiocateGen + 1);

    //create
    Player giocatore = new Player() { Name = "pinco", Surname = "pallo", Punteggio = PunteggioGen, partiteGiocate = PartiteGiocateGen, partiteVinte = partiteVinteGen};
    db.Add(giocatore);
    db.SaveChanges();
    Console.WriteLine(giocatore.ToString());

    //update
    giocatore.Name = "marco";
    giocatore.Surname = "pinco";
    db.SaveChanges();
    Console.WriteLine("update: "+giocatore.ToString());

    // Delete
    db.Remove(giocatore);
    db.SaveChanges();
    Console.WriteLine("il gio giocatore è stato cancellato");


}*/

//Milestone 2 : 

using (CalcioContext db = new CalcioContext())
{
    Random Casuale = new Random();
    double PunteggioGen = Casuale.NextDouble() * 9 + 1;
    int PartiteGiocateGen = Casuale.Next(1, 101);
    int partiteVinteGen = Casuale.Next(0, PartiteGiocateGen + 1);

    //create
    Player giocatore = new Player() { Name = "pin64c6456o", Surname = "pallo45644564", Punteggio = PunteggioGen, partiteGiocate = PartiteGiocateGen, partiteVinte = partiteVinteGen };
    db.Add(giocatore);
    
    Console.WriteLine(giocatore.ToString());

    Player giocatore2 = new Player() { Name = "pin6c4564o", Surname = "pallo45664", Punteggio = PunteggioGen, partiteGiocate = PartiteGiocateGen, partiteVinte = partiteVinteGen };
    db.Add(giocatore2);
    
    Console.WriteLine(giocatore.ToString());

    Player giocatore3 = new Player() { Name = "pinco45638564", Surname = "pallo4566474", Punteggio = PunteggioGen, partiteGiocate = PartiteGiocateGen, partiteVinte = partiteVinteGen };
    db.Add(giocatore3);
    
    Console.WriteLine(giocatore.ToString());


    Team Squadra1 = new Team() { Name = "Squadra1", City = "milano", Trainer = "allenatore 1", Players = new List<Player>()};
    Squadra1.Players.Add(giocatore);
    Squadra1.Players.Add(giocatore2);
    Squadra1.Players.Add(giocatore3);

    db.Add(Squadra1);
    db.SaveChanges();

}

