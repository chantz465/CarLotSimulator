using System;

public class car
{
    public car()
    {






    }

    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDrivable { get; set; }

    public void MakeEnigneNoise(string EngineNoise);
    {
        Console.WriteLine(EngineNoise);

    }

    public void MakeHonkNoise(string honkNoise)
    {
        Console.WriteLine(honkNoise);
    }


}
