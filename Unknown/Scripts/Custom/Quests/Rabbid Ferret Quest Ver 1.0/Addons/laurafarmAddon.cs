/* Pieced together by evilfreak*/



/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class AG_laurafarmAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AG_laurafarmAddonDeed();
			}
		}

		[ Constructable ]
		public AG_laurafarmAddon()
		{
			AddComponent( new AddonComponent( 12791 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 12791 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 12790 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 2145 ), 3, -2, 0 );
			AddComponent( new AddonComponent( 12791 ), 3, -2, 0 );
			AddComponent( new AddonComponent( 2145 ), 3, -1, 0 );
			AddComponent( new AddonComponent( 2143 ), 3, -1, 0 );
			AddComponent( new AddonComponent( 12791 ), 3, -1, 0 );
			AddComponent( new AddonComponent( 12790 ), 3, 4, 0 );
			AddComponent( new AddonComponent( 12790 ), 2, 4, 0 );
			AddComponent( new AddonComponent( 2144 ), 2, 3, 0 );
			AddComponent( new AddonComponent( 12791 ), 2, 3, 0 );
			AddComponent( new AddonComponent( 2152 ), 0, 3, 0 );
			AddComponent( new AddonComponent( 12791 ), 0, 3, 0 );
			AddComponent( new AddonComponent( 12791 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 12790 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 2144 ), -2, 3, 0 );
			AddComponent( new AddonComponent( 2143 ), -2, 3, 0 );
			AddComponent( new AddonComponent( 12791 ), -2, 3, 0 );
			AddComponent( new AddonComponent( 12791 ), -2, 2, 0 );
			AddComponent( new AddonComponent( 12789 ), -2, 2, 0 );
			AddComponent( new AddonComponent( 12791 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 12791 ), -2, 0, 0 );
			AddComponent( new AddonComponent( 12789 ), -2, 0, 0 );
			AddComponent( new AddonComponent( 12791 ), -2, -1, 0 );
			AddComponent( new AddonComponent( 12791 ), -2, -2, 0 );
			AddComponent( new AddonComponent( 12791 ), -3, -2, 0 );
			AddComponent( new AddonComponent( 12789 ), -3, -2, 0 );
			AddComponent( new AddonComponent( 12790 ), -3, -2, 0 );
			AddComponent( new AddonComponent( 12791 ), -3, -1, 0 );
			AddComponent( new AddonComponent( 12789 ), -3, -1, 0 );
			AddComponent( new AddonComponent( 12790 ), -3, -1, 0 );
			AddComponent( new AddonComponent( 12791 ), -3, 0, 0 );
			AddComponent( new AddonComponent( 12791 ), -3, 1, 0 );
			AddComponent( new AddonComponent( 12790 ), -3, 1, 0 );
			AddComponent( new AddonComponent( 12791 ), -3, 2, 0 );
			AddComponent( new AddonComponent( 2145 ), -4, 2, 0 );
			AddComponent( new AddonComponent( 12790 ), -4, 2, 0 );
			AddComponent( new AddonComponent( 12790 ), 4, -1, 0 );
			AddComponent( new AddonComponent( 12791 ), 2, 2, 0 );
			AddComponent( new AddonComponent( 12789 ), 2, 2, 0 );
			AddComponent( new AddonComponent( 12789 ), 2, 2, 0 );
			AddComponent( new AddonComponent( 12790 ), 4, -2, 0 );
			AddComponent( new AddonComponent( 12790 ), 4, 0, 0 );
			AddComponent( new AddonComponent( 12790 ), 4, 3, 0 );
			AddComponent( new AddonComponent( 12790 ), 4, 2, 0 );
			AddComponent( new AddonComponent( 2145 ), 3, 2, 0 );
			AddComponent( new AddonComponent( 12791 ), 3, 2, 0 );
			AddComponent( new AddonComponent( 12791 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 12790 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 2144 ), 1, 3, 0 );
			AddComponent( new AddonComponent( 2143 ), 1, 3, 0 );
			AddComponent( new AddonComponent( 12791 ), 1, 3, 0 );
			AddComponent( new AddonComponent( 12791 ), 2, -1, 0 );
			AddComponent( new AddonComponent( 12789 ), 2, -1, 0 );
			AddComponent( new AddonComponent( 12790 ), 2, -1, 0 );
			AddComponent( new AddonComponent( 12791 ), 2, -2, 0 );
			AddComponent( new AddonComponent( 12791 ), 1, -2, 0 );
			AddComponent( new AddonComponent( 12791 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 12790 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 12791 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 12789 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 12790 ), -1, 4, 0 );
			AddComponent( new AddonComponent( 12790 ), -2, 4, 0 );
			AddComponent( new AddonComponent( 12791 ), -1, 2, 0 );
			AddComponent( new AddonComponent( 2144 ), -1, 3, 0 );
			AddComponent( new AddonComponent( 12791 ), -1, 3, 0 );
			AddComponent( new AddonComponent( 12791 ), -2, 1, 0 );
			AddComponent( new AddonComponent( 12790 ), -2, 1, 0 );
			AddComponent( new AddonComponent( 12791 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 12790 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 12790 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 12791 ), -1, -2, 0 );
			AddComponent( new AddonComponent( 12791 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 12789 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 12789 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 12790 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 2145 ), -4, -1, 0 );
			AddComponent( new AddonComponent( 2143 ), -4, -1, 0 );
			AddComponent( new AddonComponent( 12790 ), -4, -1, 0 );
			AddComponent( new AddonComponent( 2145 ), -4, -2, 0 );
			AddComponent( new AddonComponent( 12790 ), -4, -2, 0 );
			AddComponent( new AddonComponent( 2145 ), -4, 1, 0 );
			AddComponent( new AddonComponent( 2143 ), -4, 1, 0 );
			AddComponent( new AddonComponent( 12790 ), -4, 1, 0 );
			AddComponent( new AddonComponent( 2145 ), -4, 0, 0 );
			AddComponent( new AddonComponent( 12790 ), -4, 0, 0 );
			AddComponent( new AddonComponent( 2142 ), -4, 3, 0 );
			AddComponent( new AddonComponent( 12790 ), -4, 3, 0 );
			AddComponent( new AddonComponent( 2144 ), -3, 3, 0 );
			AddComponent( new AddonComponent( 12791 ), -3, 3, 0 );
			AddComponent( new AddonComponent( 12790 ), -3, 4, 0 );
			AddComponent( new AddonComponent( 12790 ), -4, 4, 0 );
			AddComponent( new AddonComponent( 2140 ), 3, 3, 0 );
			AddComponent( new AddonComponent( 12791 ), 3, 3, 0 );
			AddComponent( new AddonComponent( 12791 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 2145 ), 3, 1, 0 );
			AddComponent( new AddonComponent( 2143 ), 3, 1, 0 );
			AddComponent( new AddonComponent( 12791 ), 3, 1, 0 );
			AddComponent( new AddonComponent( 12790 ), 4, 1, 0 );
			AddComponent( new AddonComponent( 2143 ), -4, -3, 0 );
			AddComponent( new AddonComponent( 12790 ), -4, -3, 0 );
			AddComponent( new AddonComponent( 2144 ), -3, -3, 0 );
			AddComponent( new AddonComponent( 12790 ), -3, -3, 0 );
			AddComponent( new AddonComponent( 2144 ), -2, -3, 0 );
			AddComponent( new AddonComponent( 2143 ), -2, -3, 0 );
			AddComponent( new AddonComponent( 12790 ), -2, -3, 0 );
			AddComponent( new AddonComponent( 2144 ), -1, -3, 0 );
			AddComponent( new AddonComponent( 12790 ), -1, -3, 0 );
			AddComponent( new AddonComponent( 2144 ), 0, -3, 0 );
			AddComponent( new AddonComponent( 12790 ), 0, -3, 0 );
			AddComponent( new AddonComponent( 2144 ), 1, -3, 0 );
			AddComponent( new AddonComponent( 2143 ), 1, -3, 0 );
			AddComponent( new AddonComponent( 12790 ), 1, -3, 0 );
			AddComponent( new AddonComponent( 12790 ), 1, 4, 0 );
			AddComponent( new AddonComponent( 12790 ), 0, 4, 0 );
			AddComponent( new AddonComponent( 12791 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 12791 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 12790 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 12790 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 12791 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 12790 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 12791 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 12791 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 12789 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 2144 ), 2, -3, 0 );
			AddComponent( new AddonComponent( 12790 ), 2, -3, 0 );
			AddComponent( new AddonComponent( 2141 ), 3, -3, 0 );
			AddComponent( new AddonComponent( 12790 ), 3, -3, 0 );
			AddComponent( new AddonComponent( 12790 ), 4, -3, 0 );
			AddComponent( new AddonComponent( 12790 ), 4, 4, 0 );
			AddComponent( new AddonComponent( 2145 ), 3, 0, 0 );
			AddComponent( new AddonComponent( 12791 ), 3, 0, 0 );
			AddonComponent ac;
			ac = new AddonComponent( 2144 );
			AddComponent( ac, -3, -3, 0 );
			ac = new AddonComponent( 2143 );
			AddComponent( ac, -4, -3, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -3, -3, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -4, -3, 0 );
			ac = new AddonComponent( 2144 );
			AddComponent( ac, -3, 3, 0 );
			ac = new AddonComponent( 2142 );
			AddComponent( ac, -4, 3, 0 );
			ac = new AddonComponent( 2145 );
			AddComponent( ac, -4, 2, 0 );
			ac = new AddonComponent( 2145 );
			AddComponent( ac, -4, 1, 0 );
			ac = new AddonComponent( 2145 );
			AddComponent( ac, -4, 0, 0 );
			ac = new AddonComponent( 2145 );
			AddComponent( ac, -4, -1, 0 );
			ac = new AddonComponent( 2145 );
			AddComponent( ac, -4, -2, 0 );
			ac = new AddonComponent( 2143 );
			AddComponent( ac, -4, -1, 0 );
			ac = new AddonComponent( 2143 );
			AddComponent( ac, -4, 1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -3, -2, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -3, 0, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -3, 2, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -3, 3, 0 );
			ac = new AddonComponent( 12789 );
			AddComponent( ac, -3, -2, 0 );
			ac = new AddonComponent( 12789 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -3, -2, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -3, -1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -4, -2, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -4, -1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -4, 0, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -4, 1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -4, 2, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -4, 3, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -4, 4, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -3, 4, 0 );
			ac = new AddonComponent( 2141 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 2144 );
			AddComponent( ac, 2, -3, 0 );
			ac = new AddonComponent( 2144 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 2144 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 2144 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 2144 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 2143 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 2143 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 4, -3, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 2, -3, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 2140 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 2145 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 2145 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 2145 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 2144 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 2144 );
			AddComponent( ac, 1, 3, 0 );
			ac = new AddonComponent( 2144 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 2144 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 2145 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 2145 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 2143 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 2143 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 2143 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 2143 );
			AddComponent( ac, 1, 3, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -2, 3, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -1, 3, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 0, 3, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 1, 3, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 2, 3, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 3, 3, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 3, 2, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 3, -2, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 2, -2, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 12791 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 12789 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 12789 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 12789 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 12789 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 12789 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 12789 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 12789 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 12789 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 12789 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 1, 4, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 2, 4, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 3, 4, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 4, 3, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 4, 4, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 4, 2, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 4, 1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 4, 0, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 4, -1, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 4, -2, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -2, 4, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, -1, 4, 0 );
			ac = new AddonComponent( 12790 );
			AddComponent( ac, 0, 4, 0 );

		}

		public AG_laurafarmAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class AG_laurafarmAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AG_laurafarmAddon();
			}
		}

		[Constructable]
		public AG_laurafarmAddonDeed()
		{
			Name = "AG_laurafarm";
		}

		public AG_laurafarmAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}