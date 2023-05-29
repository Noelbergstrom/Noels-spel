
class Program
{
    
    //Mitt lilla spel går ut på att en agent och en skurk väljs ut slumpmässigt ur en förbestämd lista.
    //Både skurk och agent har några förutbestämda egenskper såsom hälsa och antal skott.
    //De två ska slåss mot varandra genom att skjuta, när en person har förlorat all sin hälsa vinner den andra.
    static void Main(string[] args)
    { 
        List<Agent> fighters = new List<Agent>();
        Agent agent1 = new Agent();
        agent1.Namn="Mr Jones";
        agent1.Ålder=55;
        agent1.Erfarenhet=80;
        agent1.Hälsa=100;
        agent1.Skott=22;
        fighters.Add(agent1);

        Agent agent2 = new Agent();
        agent2.Namn="Mr bond";
        agent2.Ålder=50;
        agent2.Erfarenhet=85;
        agent2.Hälsa=100;
        agent2.Skott=30;
        fighters.Add(agent2);

        Agent agent3 = new Agent();
        agent3.Namn="Mr bourne";
        agent3.Ålder=35;
        agent3.Erfarenhet=75;
        agent3.Hälsa=85;
        agent3.Skott=25;
        fighters.Add(agent3);

        Agent agent4 = new Agent();
        agent4.Namn="Mr Washington";
        agent4.Ålder=60;
        agent4.Erfarenhet=65;
        agent4.Hälsa=70;
        agent4.Skott=20;
        fighters.Add(agent4);

        Agent agent5 = new Agent();
        agent5.Namn="Mr Stiffler";
        agent5.Ålder=23;
        agent5.Erfarenhet=50;
        agent5.Hälsa=90;
        agent5.Skott=22;
        fighters.Add(agent5);

    

        List<Villan>  skurkar = new List<Villan>();
        Villan skurk1 = new Villan();
        skurk1.Namn="Joker";
        skurk1.Ålder=55;
        skurk1.Erfarenhet=80;
        skurk1.Hälsa=100;
        skurk1.Skott=23;
        skurkar.Add(skurk1);

        Villan skurk2 = new Villan();
        skurk2.Namn="Darth vader";
        skurk2.Ålder=55;
        skurk2.Erfarenhet=80;
        skurk2.Hälsa=100;
        skurk2.Skott=15;
        skurkar.Add(skurk2);
        
        Villan skurk3 = new Villan();
        skurk3.Namn="Michael Myers";
        skurk3.Ålder=55;
        skurk3.Erfarenhet=80;
        skurk3.Hälsa=100;
        skurk3.Skott=25;
        skurkar.Add(skurk1);

        Villan skurk4 = new Villan();
        skurk4.Namn="IT";
        skurk4.Ålder=55;
        skurk4.Erfarenhet=80;
        skurk4.Hälsa=100;
        skurk4.Skott=20;
        skurkar.Add(skurk4);

        Villan skurk5 = new Villan();
        skurk5.Namn="Vector";
        skurk5.Ålder=20;
        skurk5.Erfarenhet=80;
        skurk5.Hälsa=100;
        skurk5.Skott=30;
        skurkar.Add(skurk5);

       
        Random rnd = new Random();
        int ai =rnd.Next(fighters.Count);
        Agent agent = fighters[ai];
        int si =rnd.Next(skurkar.Count);
        Villan villan = skurkar[si];

       
        Console.WriteLine( $"{agent.Namn} ska möta {villan.Namn}" );
        villan.info();
        agent.info();

       
       while(agent.Hälsa>0 && villan.Hälsa>0)
       {

        villan.skjuter(agent);
        if(agent.Hälsa<=0)
        {
            break;
        }
        agent.skjuter(villan);
       }
       
       
    }
}
