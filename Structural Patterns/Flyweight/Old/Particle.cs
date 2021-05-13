using System;
using System.IO;

namespace design_patterns.Flyweight.Old
{
    class Particle {
      public int Coords { get; set; } = 10;
      public int Vector { get; set; } = 20;
      public int Speed { get; set; } = 50;
      public string Color { get; set; } = "Red";
      public byte[] Sprite { get; set; } = null;

      public Particle(string path)
      {
          Sprite = File.ReadAllBytes(path);
      }
      public void Draw(){
        Console.WriteLine("Look at me, I am a particle!!");
      }
    }
}