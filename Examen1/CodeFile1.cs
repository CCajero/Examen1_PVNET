public class ruleta
{
    List<int> list;
    Random random;

    public ruleta()
    {
        list = new List<int>();
        random = new Random();
    }
    public int hacerTiro()
    { 
        int a = random.Next(0, 37);
        list.Add(a);
        return a;
    }

    public void mostrarHistorialTiros()
    {
        foreach(int i in list)
        {
            Console.WriteLine(i);
        }
    }

    public void elementoMasRepetido()
    {
        foreach (var item in list.GroupBy(x => x))
        {
            Console.WriteLine($"El número {item.Key} ha salido {item.Count()} veces");
        }
    }
}