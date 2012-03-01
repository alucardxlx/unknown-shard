/*********************************************************************************/
/*                PBEquipment.cs | PBGameItem.cs | PBPlayerStorage.cs            */
/*            PBScoreBoard.cs | PBScoreGump.cs | PBGMGump.cs | PBTimer.cs        */
/*                             Created by A_Li_N                                 */
/*         Credits:                                                              */
/*                      Original Idea + Some Code - Clarke76                     */
/*                      Some Ideas + Code - Lucid Nagual                         */
/*********************************************************************************/

using System;
using System.Collections;
using Server.Network;
using Server.Items;
using Server.Mobiles;

namespace Server.Games.PaintBall
{
	public class PBPlayerStorage : Item
	{
		private Mobile m_Owner;

		private int Str, Dex, Int, Fame, Karma, Kills;
		private ArrayList StoredSkills;

		[Constructable]
		public PBPlayerStorage( Mobile from ) : base ( 4626 )
		{
			m_Owner = from;

			Movable = false;
			Name = m_Owner.Name + "'s Storage Chip";
			Hue = 1152;

			Str = m_Owner.Str;
			Dex = m_Owner.Dex;
			Int = m_Owner.Int;
			Fame = m_Owner.Fame;
			Karma = m_Owner.Karma;
			Kills = m_Owner.Kills;

			StoredSkills = new ArrayList();
			for( int i = 0; i < PowerScroll.Skills.Length; ++i )
				StoredSkills.Add( (double)m_Owner.Skills[PowerScroll.Skills[i]].Base );
		}

		public override void OnDoubleClick( Mobile from )
		{
			Restore();
			Delete();
		}

		public void Restore()
		{
			m_Owner.Str = Str;
			m_Owner.Dex = Dex;
			m_Owner.Int = Int;
			m_Owner.Fame = Fame;
			m_Owner.Karma = Karma;
			m_Owner.Kills = Kills;

			for( int i = 0; i < StoredSkills.Count; i++ )
				m_Owner.Skills[PowerScroll.Skills[i]].Base = (double)StoredSkills[i];
		}

		public PBPlayerStorage( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); //version

			writer.Write( m_Owner );

			writer.Write( (int)Str );
			writer.Write( (int)Dex );
			writer.Write( (int)Int );
			writer.Write( (int)Fame );
			writer.Write( (int)Karma );
			writer.Write( (int)Kills );

			writer.Write( (int)StoredSkills.Count );
			for( int i = 0; i < StoredSkills.Count; i++ )
				writer.Write( (double)StoredSkills[i] );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			StoredSkills = new ArrayList();

			m_Owner = reader.ReadMobile();

			Str = reader.ReadInt();
			Dex = reader.ReadInt();
			Int = reader.ReadInt();
			Fame = reader.ReadInt();
			Karma = reader.ReadInt();
			Kills = reader.ReadInt();

			int Count = reader.ReadInt();
			for( int i = 0; i < Count; i++ )
				StoredSkills.Add( reader.ReadDouble() );
		}
	}
}