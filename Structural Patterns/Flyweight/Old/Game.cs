using System.Collections.Generic;

namespace design_patterns.Flyweight.Old
{
    class Game {
      private List<Particle> _particles = new List<Particle>();

      public void AddParticle(Particle particle)
      {
        _particles.Add(particle);
      }

      public void Draw() {
        foreach (var item in _particles)
        {
            item.Draw();
        }
      }
    }
}