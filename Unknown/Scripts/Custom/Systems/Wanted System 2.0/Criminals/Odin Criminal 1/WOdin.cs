using System;
using Server;
using Server.Misc;
using Server.Items;

namespace Server.Mobiles 
{ 
	[CorpseName( "Odins corpse" )] 
	public class WOdin : BaseCreature 
	{ 
	
    private static bool m_Talked; // flag to prevent spam 

      string[] kfcsay = new string[] // things to say while greating 
      { 
         "Death becomes you Bitch!", 
         "Owned",   
         "God your so fucking stupid you newb!",
};
		[Constructable] 
		public WOdin() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 ) 
		{ 
			
			Name = "Odin the Ruthless";
			Body = 400;
			Hue = 0;  

			SetStr( 100, 120 );
			SetDex( 90, 120 );
			SetInt( 95, 120 );

			SetHits( 200, 250 );

			SetDamage( 40, 60 );

			SetDamageType( ResistanceType.Physical, 10 );

			SetResistance( ResistanceType.Physical, 0, 1 );
			SetResistance( ResistanceType.Fire, 0, 1 );
			SetResistance( ResistanceType.Poison, 0, 1 );
			SetResistance( ResistanceType.Energy, 0, 1 );

			SetSkill( SkillName.EvalInt, 25.0, 50.0 );
			SetSkill( SkillName.Tactics, 25.1, 30.0 );
			SetSkill( SkillName.MagicResist, 45.0, 57.5 );
			SetSkill( SkillName.Wrestling, 50.2, 105.0 );
			SetSkill( SkillName.Meditation, 20.0);
			SetSkill( SkillName.Focus, 90.0);
			SetSkill( SkillName.Swords, 10.0, 20.0 );

			Fame = 250;
			Karma = -250;

			Tamable = false;
			ControlSlots = 1;
			MinTameSkill = 119.5;

			VirtualArmor = 15;
			
			PackItem( new HeadofOdin() );
			
			new Horse().Rider = this;


			Item hair = new Item( Utility.RandomList( 0x203B, 0x2049, 0x2048, 0x204A ) );
			
				hair.Hue = 1150;
				hair.Layer = Layer.Hair;
				hair.Movable = false;
				AddItem( hair );
            
			Odinshirt Chest = new Odinshirt();
			Chest.Movable = false;
			AddItem(Chest); 
			
			OdinCloak BaseCloak = new OdinCloak();
			BaseCloak.Movable = false;
			AddItem(BaseCloak);
			
			OdinKryss BaseSword = new OdinKryss();
			BaseSword.Movable = false;
			AddItem(BaseSword);
			
			OdinBoots BaseShoes = new OdinBoots();
			BaseShoes.Movable = false;
			AddItem(BaseShoes);

			OdinPants Legs = new OdinPants();
			Legs.Movable = false;
			AddItem(Legs);				
			
			}
			
		public override void OnMovement( Mobile m, Point3D oldLocation ) 
               {                                                    
         if( m_Talked == false ) 
         { 
            if ( m.InRange( this, 4 ) ) 
            {                
               m_Talked = true; 
               SayRandom( kfcsay, this ); 
               this.Move( GetDirectionTo( m.Location ) ); 
                  // Start timer to prevent spam 
               SpamTimer t = new SpamTimer(); 
               t.Start(); 
            } 
         } 
      } 

      private class SpamTimer : Timer 
      { 
         public SpamTimer() : base( TimeSpan.FromSeconds( 8 ) ) 
         { 
            Priority = TimerPriority.OneSecond; 
         } 

         protected override void OnTick() 
         { 
            m_Talked = false; 
         } 
      } 

      private static void SayRandom( string[] say, Mobile m ) 
      { 
         m.Say( say[Utility.Random( say.Length )] ); 
      }
		
		public WOdin( Serial serial ) : base( serial )
		{
		}
        public override bool AlwaysMurderer{ get{ return true; } }
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}
