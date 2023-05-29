class Villan
{
    private string namn;
    private int ålder;
    private int hälsa;
    private int skott;
    private int erfarenhet;
    
  public Villan()
    {
        namn = "";
        ålder = 0;
        hälsa = 0;
        skott = 0;
        erfarenhet = 0;
    }

    public string Namn
    {
        get { return namn; }
        set { namn = value; }
    }

    public int Ålder
    {
        get { return ålder; }
        set { ålder = value; }
    }

    public int Hälsa
    {
        get { return hälsa; }
        set { hälsa=value; }
    }
         
    public int Skott
    {
        get { return skott; }
        set {
            if(value >= 0 && value <= 30) 
            {
                skott = value;
            }
            else
            {
                Console.WriteLine("Du kan inte ha fler än 30 eller mindre än 0 skott");
            }
        }
    }
    
    public int Erfarenhet
    {
        get { return erfarenhet; }
        set {
            if(value >= 0 && value <= 100) 
            {
                erfarenhet = value;
            }
            else
            {
                Console.WriteLine("Erfarenheten kan inte vara större än 100 eller mindre än 0");
            }
        }
    }
    
    public void info()
    {
        Console.WriteLine(namn+ " är "+ ålder+ " år gammal. " + namn+ " har "+ hälsa+ " i hälsa, och "+ erfarenhet+ " i erfarhenhet.");
    }
    public void skjuter(Agent target)
{
    Random x = new Random();
    int y = x.Next(0, skott+1);
    Console.WriteLine(namn + " skjuter: " + y + " Skott");
    
    target.Hälsa -= y;
        Console.WriteLine("skotten träffar "+ target.Namn+ " och gör "+ y+ " skada.");
        Console.WriteLine("Nu har "+ target.Namn +" " + target.Hälsa+ " i hälsa");
    if (target.Hälsa <= 0)
        {
            Console.WriteLine(namn + " Vinner! "+ target.Namn + " har dött."); 
        }
}
}
