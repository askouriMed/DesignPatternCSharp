﻿namespace PrototypePattern
{
   public class Nano:BasicCare
    {
        public Nano(string m)
        {
            ModelName = m;
        }

        public override BasicCare Clone()
        {
            return (Nano) MemberwiseClone();// Shallow clone 
        }
    }
}
