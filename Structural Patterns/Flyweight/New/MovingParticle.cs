using System;
using System.IO;

namespace design_patterns.Flyweight.New
{
    class MovingParticle {

      private Particle _particle;
      public int Coords { get; set; } = 10;
      public int Vector { get; set; } = 20;
      public int Speed { get; set; } = 50;

      public MovingParticle(Particle particle)
      {
          _particle = particle;
      }
      public void Draw(){
        _particle.Draw(Coords,Vector,Speed);
      }
    }
}