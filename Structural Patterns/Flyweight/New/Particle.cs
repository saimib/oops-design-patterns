using System;
using System.IO;

namespace design_patterns.Flyweight.New
{
    class Particle {
      public string Color { get; set; } = "Red";
      public byte[] Sprite { get; set; } = null;

      public Particle(string path)
      {
          Sprite = File.ReadAllBytes(path);
      }
      public void Draw(int coords, int vector, int speed){
        Console.WriteLine($"Look at me, I am a particle!! I am moving at {speed} speed with {vector} vector at {coords} coords");
      }
    }
}