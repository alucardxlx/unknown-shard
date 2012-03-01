#region AuthorHeader
//
//	SpellCrafting version 3.0, by Xanthos and TheOutkastDev
//
//  Based on original ideas and code by TheOutkastDev
//
#endregion AuthorHeader
using System;
using Server;

namespace Server.SpellCrafting.Items
{
	public class HitLeechHitsJewel : BaseSpellCraft
	{
		[Constructable]
		public HitLeechHitsJewel() : this( 1 )
		{
		}

		[Constructable]
		public HitLeechHitsJewel( int amount ) : base( amount, 34 )
		{
		}

		public HitLeechHitsJewel( Serial serial ) : base( serial )
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
			int version = reader.ReadInt(); // version
		}
	}
}
