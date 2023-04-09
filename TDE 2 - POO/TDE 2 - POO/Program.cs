using System;
using System.Collections.Generic;
using System.IO;
using TDE_2___POO;
using Newtonsoft.Json;
using System.Data;

class program
{
    static void Main(string[] args)
    {
        List<Animal> animais = new List<Animal>();
        animais.Add(new Animal { NomeAnimal = "Bidu", Idade = 5, Proprietario = "Caio" });
        animais.Add(new Animal { NomeAnimal = "Bobby", Idade = 4, Proprietario = "Carla" });
        animais.Add(new Animal { NomeAnimal = "Chiara", Idade = 9, Proprietario = "Yasmin" });

        string json = JsonConvert.SerializeObject(animais);




       
        
            json = File.ReadAllText("output(1).json");









       List<Animal> Animais = JsonConvert.DeserializeObject<List<Animal>>(json);

        foreach (Animal animal in animais)
        {
            Console.WriteLine("Nome do Animal: " + animal.NomeAnimal);
            Console.WriteLine("Idade: " + animal.Idade);
            Console.WriteLine("Proprietario: " + animal.Proprietario);
            Console.WriteLine();
        }

    }


}
