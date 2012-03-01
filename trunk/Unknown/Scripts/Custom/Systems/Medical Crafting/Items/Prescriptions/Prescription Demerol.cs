using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Guilds;
using Server.Gumps;
using Server.Mobiles; 
using Server.Targeting;

namespace Server.Items
{
	public class PrescriptionDemerol : Item 
	{
		[Constructable]
		public PrescriptionDemerol() : base( 0x14F0 )
		{
			Weight = 0.1;
			Name = "a prescription for Demerol";
			LootType = LootType.Blessed;
		}

		public PrescriptionDemerol( Serial serial ) : base( serial )
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

		//public override bool DisplayLootType{ get{ return true; } }

		public override void OnDoubleClick( Mobile from ) // Override double click of the deed to call our target
		{
			if ( !IsChildOf( from.Backpack ) ) // Make sure its in their pack
			{
				 from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
			else
			{
		 		this.Delete(); 
				from.SendMessage( "The item has been placed in your backpack." );
				switch ( Utility.Random( 5 ) ) //Random chance of armor 
                        	{ 
                          		case 0: from.AddToBackpack( new Demerol( ) ); 
                          		break; 
                          		case 1: from.AddToBackpack( new Demerol( ) ); 
                          		break; 
                          		case 2: from.AddToBackpack( new Demerol( ) ); 
                          		break; 
                          		case 3: from.AddToBackpack( new Demerol( ) ); 
                          		break; 
                          		case 4: from.AddToBackpack( new Demerol( ) ); 
                          		break; 
                        	} 

			 }
		}	
	}
}


