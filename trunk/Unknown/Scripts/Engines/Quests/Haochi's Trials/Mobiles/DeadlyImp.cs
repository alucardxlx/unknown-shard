using System;
using Server.Mobiles;

namespace Server.Engines.Quests.Samurai
{
	public class DeadlyImp : BaseCreature
	{
		[Constructable]
		public DeadlyImp() : base( AIType.AI_Melee, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			Name = "a deadly imp";
			Body = 74;
			BaseSoundID = 422;
			Hue = 0x66A;

			SetStr( 30 );
			SetDex( 12 );
			SetInt( 100 );

			SetHits( 300 );

			SetDamage( 3, 5 );

			SetDamageType( ResistanceType.Fire, 100 );

			SetResistance( ResistanceType.Physical, 95, 98 );
			SetResistance( ResistanceType.Fire, 95, 98 );
			SetResistance( ResistanceType.Cold, 95, 98 );
			SetResistance( ResistanceType.Poison, 95, 98 );
			SetResistance( ResistanceType.Energy, 95, 98 );

			SetSkill( SkillName.Magery, 120.0 );
			SetSkill( SkillName.Tactics, 120.0 );
			SetSkill( SkillName.Wrestling, 120.0 );

			Fame = 2500;
			Karma = -2500;

			CantWalk = true;
		}

		public override void AggressiveAction( Mobile aggressor, bool criminal )
		{
			base.AggressiveAction( aggressor, criminal );

			PlayerMobile player = aggressor as PlayerMobile;
			if ( player != null )
			{
				QuestSystem qs = player.Quest;
				if ( qs is HaochisTrialsQuest )
				{
					QuestObjective obj = qs.FindObjective( typeof( SecondTrialAttackObjective ) );
					if ( obj != null && !obj.Completed )
					{
						obj.Complete();
						qs.AddObjective( new SecondTrialReturnObjective( false ) );
					}
				}
			}
		}

		public DeadlyImp( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}