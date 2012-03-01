using System;
using Server;

namespace Server.Items
{
	public class CapOfTheFallenKing : LeatherCap
	{
		public override int LabelNumber{ get{ return 1061094; } } // Cap of the Fallen King
		public override int ArtifactRarity{ get{ return 11; } }

		public override int BaseColdResistance{ get{ return 12; } }
		public override int BaseEnergyResistance{ get{ return 12; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public CapOfTheFallenKing()
		{
			Name = "Cap of the Fallen";
			Hue = 0x76D;
			Attributes.BonusStr = 5;
			Attributes.RegenHits = 5;
			Attributes.RegenStam = 1;
		}

		public CapOfTheFallenKing( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			if ( version < 1 )
			{
				if ( Hue == 0x551 )
					Hue = 0x76D;

				ColdBonus = 0;
				EnergyBonus = 0;
			}
		}
	}
}