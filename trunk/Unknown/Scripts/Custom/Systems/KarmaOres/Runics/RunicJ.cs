using System;
using Server;
using Server.Engines.Craft;


namespace Server.Items
{
	public class RunicJ : RunicHammer
	{

		[Constructable]
		public RunicJ() : this( 10 )
		{
		}		

		[Constructable]
		public RunicJ( int uses ) : base( CraftResource.Jade )
		{
			Weight = 1.0;
			UsesRemaining = uses;
		}
		public RunicJ( Serial serial ) : base( serial )
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