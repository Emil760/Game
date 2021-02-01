using System;

namespace SurvivalGT.Items
{
    public class Fire : Item, ISpoilable
    {
        public int Time { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Spoil()
        {
            throw new NotImplementedException();
        }
    }
}
