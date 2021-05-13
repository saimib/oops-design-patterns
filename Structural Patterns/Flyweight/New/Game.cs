using System.Collections.Generic;
using System.Linq;

namespace design_patterns.Flyweight.New
{
    class Game {

      private List<MovingParticle> _movingParticles = new List<MovingParticle>();
      private List<Particle> _particles = new List<Particle>();

      public Game(string path)
      {
          _particles.Add(new Particle(path));
      }
      public void AddParticle()
      {
        _movingParticles.Add(new MovingParticle(_particles.FirstOrDefault()));
      }

      public void Draw() {
        foreach (var item in _movingParticles)
        {
            item.Draw();
        }
      }
    }
}