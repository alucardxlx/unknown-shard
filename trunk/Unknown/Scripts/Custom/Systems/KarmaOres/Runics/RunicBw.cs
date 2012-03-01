using System;
using Server;
using Server.Engines.Craft;


namespace Server.Items
{
	public class RunicBw : RunicFletchersTools
	{

		[Constructable]
		public RunicBw() : this( 10 )
		{
		}		

		[Constructable]
		public RunicBw( int uses ) : base( CraftResource.Bloodwood )
		{
			Weight = 1.0;
			UsesRemaining = uses;
		}
		public RunicBw( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}