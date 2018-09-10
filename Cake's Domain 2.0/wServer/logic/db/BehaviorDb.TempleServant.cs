using wServer.logic.behaviors;
using wServer.logic.transitions;
using wServer.logic.loot;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ TempleServant = () => Behav()

         .Init("Stone ball1",
                new State(
                    new State("Start",
                    new StayCloseToSpawn(0.3, range: 7),
                        new Wander(1),
                        new Shoot(20, 1, 0, 1, 60),
                        new Shoot(20, 1, 0, 1, 120),
                        new Shoot(20, 1, 0, 1, 180),
                        new Shoot(20, 1, 0, 1, 240),
                        new Shoot(20, 1, 0, 1, 300),
                        new Shoot(20, 1, 0, 1, 0)
                    )
            )
            );

      /*  .Init("Servant of the Temple",
             new State(
             new State("Greedings",
                 new ConditionalEffect(ConditionEffectIndex.Invincible),
                 new ConditionalEffect(ConditionEffectIndex.Invulnerable),
        */         

    }
}
