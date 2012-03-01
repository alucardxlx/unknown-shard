using System;
using System.Collections;
using System.IO;
using Server;
using Server.Mobiles; 
using Server.Items;
using Server.Commands; 
using Server.Network;
using Server.Gumps;

namespace Server.Commands 
{
	public class PremiumSpawnerCommand
	{
		public PremiumSpawnerCommand()
		{
		}

		public static void Initialize() 
		{ 
			CommandSystem.Register( "PremiumSpawner", AccessLevel.Administrator, new CommandEventHandler( PremiumSpawner_OnCommand ) );
			CommandSystem.Register( "Spawner", AccessLevel.Administrator, new CommandEventHandler( PremiumSpawner_OnCommand ) ); 
		}
 
		[Usage( "just use [PremiumSpawner" )]
		[Aliases( "Spawner" )]
		[Description( "Main Gump to access Premium Spawner functions." )]
		private static void PremiumSpawner_OnCommand( CommandEventArgs e )
		{
			e.Mobile.SendGump( new PremiumSpawnerMainGump( e ) );
		}
	}
}

namespace Server.Gumps
{
	public class PremiumSpawnerMainGump : Gump
	{
		public void AddBlackAlpha( int x, int y, int width, int height )
		{
			AddImageTiled( x, y, width, height, 2624 );
			AddAlphaRegion( x, y, width, height );
		}

		private CommandEventArgs m_CommandEventArgs;
		public PremiumSpawnerMainGump( CommandEventArgs e ) : base( 50,50 )
		{
			m_CommandEventArgs = e;
			Closable = true;
			Dragable = true;

			AddPage(1);

			AddBackground( 0, 0, 267, 450, 5054 );

			AddHtml( 8, 8, 250, 42, "        PREMIUM SPAWNER<BR>" + "by Nerun                   v5.1.0", true, false );


			AddBlackAlpha( 8, 58, 250, 50 );

			AddBlackAlpha( 8, 116, 250, 130 );

			AddBlackAlpha( 8, 254, 250, 130 );

			AddButton( 220, 405, 0x158A, 0x158B, 10000, GumpButtonType.Reply, 1 ); //Quit Button
//Options---------------------
			AddLabel( 10, 60, 52, "WORLD CREATION OPTIONS" );
			AddLabel( 10, 118, 52, "SPAWN OPTIONS" );
			AddLabel( 10, 256, 52, "UNLOAD SPAWNS" );

			AddLabel( 45, 80, 52, "Create World gump" );
			AddButton( 25, 80, 0x845, 0x846, 10001, GumpButtonType.Reply, 0 );

			AddLabel( 45, 138, 52, "Spawn Trammel" );
			AddButton( 25, 138, 0x845, 0x846, 10002, GumpButtonType.Reply, 0 );

			AddLabel( 45, 158, 52, "Spawn Felucca" );
			AddButton( 25, 158, 0x845, 0x846, 10003, GumpButtonType.Reply, 0 );

			AddLabel( 45, 178, 52, "Spawn Ilshenar" );
			AddButton( 25, 178, 0x845, 0x846, 10004, GumpButtonType.Reply, 0 );

			AddLabel( 45, 198, 52, "Spawn Malas" );
			AddButton( 25, 198, 0x845, 0x846, 10104, GumpButtonType.Reply, 0 );

			AddLabel( 45, 218, 52, "Spawn Tokuno" );
			AddButton( 25, 218, 0x845, 0x846, 10105, GumpButtonType.Reply, 0 );

			AddLabel( 45, 278, 52, "Unload Trammel spawns" );
			AddButton( 25, 278, 0x845, 0x846, 10005, GumpButtonType.Reply, 0 );

			AddLabel( 45, 298, 52, "Unload Felucca spawns" );
			AddButton( 25, 298, 0x845, 0x846, 10006, GumpButtonType.Reply, 0 );

			AddLabel( 45, 318, 52, "Unload Ilshenar spawns" );
			AddButton( 25, 318, 0x845, 0x846, 10007, GumpButtonType.Reply, 0 );

			AddLabel( 45, 338, 52, "Unload Malas spawns" );
			AddButton( 25, 338, 0x845, 0x846, 10107, GumpButtonType.Reply, 0 );

			AddLabel( 45, 358, 52, "Unload Tokuno spawns" );
			AddButton( 25, 358, 0x845, 0x846, 10108, GumpButtonType.Reply, 0 );

			AddLabel( 120, 410, 200, "1/3" );
			AddButton( 145, 410, 0x15E1, 0x15E5, 0, GumpButtonType.Page, 2 );
// -----------------------------------------
			AddPage(2);

			AddBackground( 0, 0, 267, 450, 5054 );

			AddHtml( 8, 8, 250, 42, "        PREMIUM SPAWNER<BR>" + "by Nerun                   v5.1.0", true, false );

			AddBlackAlpha( 8, 58, 250, 110 );

			AddBlackAlpha( 8, 176, 250, 130 );

			AddBlackAlpha( 8, 314, 250, 88 );

			AddButton( 220, 405, 0x158A, 0x158B, 10000, GumpButtonType.Reply, 1 ); //Quit Button
//Options---------------------
			AddLabel( 10, 60, 52, "SAVE OPTIONS" );
			AddLabel( 10, 178, 52, "REMOVE OPTIONS" );
			AddLabel( 10, 316, 52, "EDITION OPTIONS" );

			AddLabel( 45, 80, 52, "Save All spawns (spawns.map)" );
			AddButton( 25, 80, 0x845, 0x846, 10008, GumpButtonType.Reply, 0 );

			AddLabel( 45, 100, 52, "Save 'By Hand' spawns (byhand.map)" );
			AddButton( 25, 100, 0x845, 0x846, 10009, GumpButtonType.Reply, 0 );

			AddLabel( 45, 120, 52, "Save spawns inside Region" );
			AddButton( 25, 120, 0x845, 0x846, 10010, GumpButtonType.Reply, 0 );

			AddLabel( 45, 140, 52, "Save spawns by Coordinates" );
			AddButton( 25, 140, 0x845, 0x846, 10011, GumpButtonType.Reply, 0 );

			AddLabel( 45, 198, 52, "Remove All spawners (all facets)" );
			AddButton( 25, 198, 0x845, 0x846, 10012, GumpButtonType.Reply, 0 );

			AddLabel( 45, 218, 52, "Remove All spawners (current map)" );
			AddButton( 25, 218, 0x845, 0x846, 10013, GumpButtonType.Reply, 0 );

			AddLabel( 45, 238, 52, "Remove spawners by ID" );
			AddButton( 25, 238, 0x845, 0x846, 10014, GumpButtonType.Reply, 0 );

			AddLabel( 45, 258, 52, "Remove spawners by Coordinates" );
			AddButton( 25, 258, 0x845, 0x846, 10015, GumpButtonType.Reply, 0 );

			AddLabel( 45, 278, 52, "Remove spawners inside Region" );
			AddButton( 25, 278, 0x845, 0x846, 10016, GumpButtonType.Reply, 0 );

			AddLabel( 45, 336, 52, "Spawn Editor" );
			AddButton( 25, 336, 0x845, 0x846, 10017, GumpButtonType.Reply, 0 );

			AddLabel( 45, 356, 52, "Clear All Facets" );
			AddButton( 25, 356, 0x845, 0x846, 10018, GumpButtonType.Reply, 0 );

			AddLabel( 45, 376, 52, "Set my own body to GM Style" );
			AddButton( 25, 376, 0x845, 0x846, 10019, GumpButtonType.Reply, 0 );

			AddLabel( 120, 410, 200, "2/3" );
			AddButton( 100, 410, 0x15E3, 0x15E7, 0, GumpButtonType.Page, 1 );
			AddButton( 145, 410, 0x15E1, 0x15E5, 0, GumpButtonType.Page, 3 );
// -----------------------------------------
			AddPage(3);

			AddBackground( 0, 0, 267, 450, 5054 );

			AddHtml( 8, 8, 250, 42, "        PREMIUM SPAWNER<BR>" + "by Nerun                   v5.1.0", true, false );

			AddBlackAlpha( 8, 58, 250, 50 );

			AddBlackAlpha( 8, 116, 250, 70 );

			AddButton( 220, 405, 0x158A, 0x158B, 10000, GumpButtonType.Reply, 1 ); //Quit Button
//Options---------------------
			AddLabel( 10, 60, 52, "CONVERSION UTILITY" );
			AddLabel( 10, 118, 52, "SMART PLAYER RANGE SENSITIVE" );

			AddLabel( 45, 80, 52, "RunUO Spawns to PremiumSpawner" );
			AddButton( 25, 80, 0x845, 0x846, 10200, GumpButtonType.Reply, 0 );

			AddLabel( 45, 138, 52, "Enable" );
			AddButton( 25, 138, 0x845, 0x846, 10301, GumpButtonType.Reply, 0 );

			AddLabel( 45, 158, 52, "Disable" );
			AddButton( 25, 158, 0x845, 0x846, 10302, GumpButtonType.Reply, 0 );

			AddLabel( 120, 410, 200, "3/3" );
			AddButton( 100, 410, 0x15E3, 0x15E7, 0, GumpButtonType.Page, 2 );
		}

		public override void OnResponse( NetState state, RelayInfo info )
		{
			Mobile from = state.Mobile;

			switch( info.ButtonID )
			{
				case 10000:
				{
					//Quit
					break;
				}
				case 10001:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}createworld", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10002:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}spawntrammel", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10003:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}spawnfelucca", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10004:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}spawnilshenar", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10005:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}unloadtrammel", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10006:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}unloadfelucca", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10007:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}unloadilshenar", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10008:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}spawngen save", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10009:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}spawngen savebyhand", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10010:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}GumpSaveRegion", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10011:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}GumpSaveCoordinate", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10012:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}spawngen remove", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10013:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}spawnrem", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10014:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}GumpRemoveID", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10015:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}GumpRemoveCoordinate", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10016:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}GumpRemoveRegion", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10017:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}editor", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10018:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}clearall", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10019:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}gmbody", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10104:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}spawnmalas", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10105:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}spawntokuno", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10107:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}unloadmalas", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10108:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}unloadtokuno", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10200:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}rse", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );
					break;
				}
				case 10301:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}global set smartprs 1 where premiumspawner", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );

					ArrayList pri = new ArrayList();

					foreach ( Item item in World.Items.Values )
					{
						if ( item is PremiumSpawner )
						{
							pri.Add( item );
						}
					}

					foreach ( Item spawner in pri )
					{
						((PremiumSpawner)spawner).Respawn();
					}

					break;
				}
				case 10302:
				{
					string prefix = Server.Commands.CommandSystem.Prefix;
					CommandSystem.Handle( from, String.Format( "{0}global set smartprs 0 where premiumspawner", prefix ) );
					CommandSystem.Handle( from, String.Format( "{0}spawner", prefix ) );

					ArrayList pri = new ArrayList();

					foreach ( Item item in World.Items.Values )
					{
						if ( item is PremiumSpawner )
						{
							pri.Add( item );
						}
					}

					foreach ( Item spawner in pri )
					{
						((PremiumSpawner)spawner).Respawn();
					}

					break;
				}
			}
		}
	}
}