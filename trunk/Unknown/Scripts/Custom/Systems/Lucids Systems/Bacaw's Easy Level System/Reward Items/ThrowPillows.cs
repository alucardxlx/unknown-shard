using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
    public class ThrowPillows : Item
    {
        [Constructable]
        public ThrowPillows()
            : base(0x1944)
        {
            Name = "Throw Pillows";
            Stackable = false;
            Weight = 1.0;
        }

        public ThrowPillows(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}