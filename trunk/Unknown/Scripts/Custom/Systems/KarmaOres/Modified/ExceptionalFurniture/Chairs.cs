using System;

namespace Server.Items
{
	[Furniture]
	[Flipable( 0xB4F, 0xB4E, 0xB50, 0xB51 )]
	public class FancyWoodenChairCushion : BaseFurniture
	{
		[Constructable]
		public FancyWoodenChairCushion() : base(0xB4F)
		{
			Weight = 20.0;
		}

		public FancyWoodenChairCushion(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int) 0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();

			if ( Weight == 6.0 )
				Weight = 20.0;
		}
	}

	[Furniture]
	[Flipable( 0xB53, 0xB52, 0xB54, 0xB55 )]
	public class WoodenChairCushion : BaseFurniture
	{
		[Constructable]
		public WoodenChairCushion() : base(0xB53)
		{
			Weight = 20.0;
		}

		public WoodenChairCushion(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int) 0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();

			if ( Weight == 6.0 )
				Weight = 20.0;
		}
	}

	[Furniture]
	[Flipable( 0xB57, 0xB56, 0xB59, 0xB58 )]
	public class WoodenChair : BaseFurniture
	{
		[Constructable]
		public WoodenChair() : base(0xB57)
		{
			Weight = 20.0;
		}

		public WoodenChair(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int) 0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();

			if ( Weight == 6.0 )
				Weight = 20.0;
		}
	}

	[Furniture]
	[Flipable( 0xB5B, 0xB5A, 0xB5C, 0xB5D )]
	public class BambooChair : BaseFurniture
	{
		[Constructable]
		public BambooChair() : base(0xB5B)
		{
			Weight = 20.0;
		}

		public BambooChair(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int) 0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();

			if ( Weight == 6.0 )
				Weight = 20.0;
		}
	}

	[DynamicFliping]
	[Flipable(0x1218, 0x1219, 0x121A, 0x121B)]
	public class StoneChair : BaseFurniture
	{
		[Constructable]
		public StoneChair() : base(0x1218)
		{
			Weight = 20;
		}

		public StoneChair(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int) 0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
}
