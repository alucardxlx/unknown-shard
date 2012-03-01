//////////////////////////
/// Created by Rosey1  ///  
/// thought up by Aeric///
///                    ///
//////////////////////////

using System;
using Server.Items;

namespace Server.Items 
{
    public class JonahMarker : Item
    {
        private DateTime m_DecayTime;
        private Timer m_Timer;

        [Constructable]
        public JonahMarker()
            : base(0x176B)
        {
            Weight = 0;
            Name = "Jonah's Marker";
            Hue = 0;
            LootType = LootType.Blessed;
            Movable = false;
            Visible = false;

            m_DecayTime = DateTime.Now + TimeSpan.FromDays(1);

            m_Timer = new InternalTimer(this, m_DecayTime);
            m_Timer.Start();
        }

        public JonahMarker(Serial serial)
            : base(serial)
        {
        }

        public override void OnAfterDelete()
        {
            if (m_Timer != null)
                m_Timer.Stop();

            base.OnAfterDelete();
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);

            writer.WriteDeltaTime(m_DecayTime);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            m_DecayTime = reader.ReadDeltaTime();
            m_Timer = new InternalTimer(this, m_DecayTime);
            m_Timer.Start();

        }

        private class InternalTimer : Timer
        {
            private Item m_Item;

            public InternalTimer(Item item, DateTime end)
                : base(end - DateTime.Now)
            {
                m_Item = item;
            }

            protected override void OnTick()
            {
                m_Item.Delete();
            }
        }
    }
} 