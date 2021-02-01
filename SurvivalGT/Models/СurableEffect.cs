using SurvivalGT.Items;

namespace SurvivalGT.Models
{
    class СurableEffect : Effect
    {
        private Goods[] goods;

        public СurableEffect(string name, int duration) : base(duration, name)
        {

        }

        public Goods[] Goods { get => goods; }

        public override void Enter(Player player)
        {
            throw new System.NotImplementedException();
        }

        public override void Leave(Player player)
        {
            throw new System.NotImplementedException();
        }
    }

    //two hand weapon forbiden
    //class ArmTrauma : СurableEffect
    //{

    //}

    ////transport forbiden
    //class LegTrauma : СurableEffect
    //{

    //}

    ////mask forbidden
    //class HeadTrauma : СurableEffect
    //{

    //}

    ////bag forbidden
    //class TorsoTrauma : СurableEffect
    //{

    //}

    //class Bleeding : СurableEffect
    //{

    //}

    //class Burn : СurableEffect
    //{

    //}

    //class Poisoning : СurableEffect
    //{

    //}

    //class AcidBurn : СurableEffect
    //{

    //}

    //class RadiationSickness : СurableEffect
    //{

    //}

    //class Dysentery : СurableEffect
    //{

    //}

    //class BulletWound : СurableEffect
    //{

    //}

    //class Intoxication : СurableEffect
    //{

    //}

    //class Somnambulism : СurableEffect
    //{

    //}
}
