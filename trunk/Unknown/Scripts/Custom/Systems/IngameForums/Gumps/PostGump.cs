using System;
using System.Collections;

using Server;
using Server.Misc;
using Server.Items;
using Server.Gumps;
using Server.Mobiles;
using Server.Prompts;
using Server.Network;
using Server.Accounting;

namespace Server.Forums
{
	public class PostGump : Gump
	{
        private ThreadEntry m_ThreadEntry;
        private bool m_NewThread;
        private int LabelColor = 0x7FFF;

        public enum Buttons
        {
            Reply = 1,
            TextEntry2 = 2,
            TextEntry3 = 3,
            Checkbox1 = 4,
            Checkbox2 = 5,
            Checkbox3 = 6,
            LongMessage = 7,
        }

        public PostGump( Mobile pm, string text ) : base( 0, 0 )
        {
            pm.SendGump( new PostGump( pm, true, m_ThreadEntry, text ) );
        }

        public PostGump(Mobile pm) : base( 0, 0 )
		{
            pm.SendGump( new PostGump( pm, true, m_ThreadEntry, "" ) );
        }

        private Mobile m_Player;

		public PostGump( Mobile pm, bool newThread, ThreadEntry te, string previousText ) : base( 0, 0 )
		{
            if( !newThread )
                m_ThreadEntry = te;

            m_Lines = new ArrayList();
            m_Player = pm;
            m_NewThread = newThread;
            Closable = true;
            Disposable = true;
            Dragable = true;
            Resizable = false;
            AddPage( 0 );
            AddBackground( 10, 15, 477, 467, 9200 );
            AddLabel( 22, 38, 0, @"Subject:" );
            AddImageTiled( 21, 58, 447, 21, 2624 );
            AddAlphaRegion( 21, 58, 446, 20 );
            AddImageTiled( 22, 102, 446, 302, 2624 );
            AddAlphaRegion( 22, 101, 446, 302 );
            AddButton( 22, 409, 4029, 4029, ( int )Buttons.Reply, GumpButtonType.Reply, 0 );
            AddLabel( 55, 409, 0, @"Post" );
            AddButton( 22, 434, 4029, 4029, ( int )Buttons.LongMessage, GumpButtonType.Reply, 0 );
            AddLabel( 55, 434, 0, @"Long Post" );
            AddLabel( 22, 78, 0, @"Content:" );
            AddLabel( 306, 78, 0, @"Date:" );
            if( newThread )
                AddLabel( 202, 20, 0, @"New Post" );
            else
                AddLabel( 202, 20, 0, @"Post Reply" );
                
            if( newThread )
                AddTextEntry( 22, 59, 442, 20, 38, ( int )Buttons.TextEntry2, "" );
            else
                AddHtml( 22, 59, 442, 20, Color( m_ThreadEntry.Subject, LabelColor ), false, false );

            AddTextEntry( 22, 102, 446, 304, 38, ( int )Buttons.TextEntry3, previousText );

            if( m_Player.AccessLevel >= AccessLevel.Counselor )
            {
                AddCheck( 449, 411, 210, 211, false, ( int )Buttons.Checkbox1 );
                AddLabel( 378, 412, 0, @"Staff Only" );
                AddCheck( 350, 411, 210, 211, false, ( int )Buttons.Checkbox2 );
                AddLabel( 305, 412, 0, @"Sticky" );
                AddCheck( 279, 411, 210, 211, false, ( int )Buttons.Checkbox3 );
                AddLabel( 186, 412, 0, @"Announcement" );
            }     
		}       

        public string Color( string text, int color )
        {
            return String.Format( "<BASEFONT COLOR=#{0:X6}>{1}</BASEFONT>", color, text );
        }

        public override void OnResponse( Server.Network.NetState sender, RelayInfo info )
        {
            Mobile m_Player = ( Mobile )sender.Mobile;

            if( m_Player == null )
                return;

            switch( info.ButtonID )
            {
                case 0:
                    {
                        ForumCore.Threads.Sort( new DateSort() );
                        m_Player.CloseGump( typeof( ForumGump ) );
                        m_Player.SendGump( new ForumGump( m_Player, 0 ) );
                        break;
                    }
                case 1:
                    {
                        if( m_NewThread )
                        {
                            TextRelay topic = info.GetTextEntry( 2 );
                            TextRelay post = info.GetTextEntry( 3 );

                            int[] switches = info.Switches;

                            bool staff = false;
                            bool sticky = false;
                            bool announcement = false;

                            for( int i = 0; i < switches.Length; i++ )
                            {
                                if( switches[i] == 4)
                                    staff = true;
                                if( switches[i] == 5 )
                                    sticky = true;
                                if( switches[i] == 6 )
                                    announcement = true;                                
                            }

                            if( sticky && announcement )
                            {
                                m_Player.SendMessage( "Since you checked both sticky and announcement, this post was changed to sticky by default!" );
                                announcement = false;                                
                            }

                            if( topic.Text.Length < ForumCore.MinPostCharactersCount )
                            {
                                m_Player.SendMessage( "The subject of the post must be more then {0} characters in length.", ForumCore.MinPostCharactersCount.ToString() );
                                m_Player.SendGump( this );
                                break;
                            }

                            if( post.Text.Length < ForumCore.MinPostCharactersCount )
                            {
                                m_Player.SendMessage( "The content of the post must be more then {0} characters in length.", ForumCore.MinPostCharactersCount.ToString() );
                                m_Player.SendGump( this );
                                break;
                            }

                            if( post.Text.Length > ForumCore.MaxPostCharactersCount )
                            {
                                m_Player.SendMessage( "The content of the post must be less then {0} characters in length.", ForumCore.MaxPostCharactersCount.ToString() );
                                m_Player.SendGump( new PostGump( m_Player, post.Text ) );
                                break;
                            }

                            ThreadType type;

                            if( sticky )
                                type = ThreadType.Sticky;
                            else if( announcement )
                                type = ThreadType.Announcement;
                            else
                                type = ThreadType.RegularThread;

                            PostEntry pe = new PostEntry( m_Player, m_Player.Serial, post.Text, DateTime.Now );
                            ThreadEntry te = new ThreadEntry( topic.Text, pe, m_Player, DateTime.Now, ForumCore.ThreadNumber, type );

                            if( staff )
                                te.StaffMessage = true;

                            te.LastPostTime = DateTime.Now;

                            ForumCore.Threads.Add( te );
                            ForumCore.UpdatePlayerStatistics( m_Player );
                                                        
                            ForumCore.Threads.Sort( new DateSort() );
                            m_Player.CloseGump( typeof( ForumGump ) );
                            m_Player.SendGump( new ForumGump( m_Player, 0 ) );
                        }
                        else
                        {
                            TextRelay post = info.GetTextEntry( 3 );
                            PostEntry pe = new PostEntry( m_Player, m_Player.Serial, post.Text, DateTime.Now );
                            
                            m_ThreadEntry.AddPost( pe );
                            m_ThreadEntry.LastPostTime = DateTime.Now;
                            ForumCore.UpdatePlayerStatistics( m_Player );
  
                            ForumCore.Threads.Sort( new DateSort() );
                            m_Player.CloseGump( typeof( ForumGump ) );
                            m_Player.SendGump( new ForumGump( m_Player, 0 ) );
                        }
                        
                        break;
                    }
                case 7:
                    {
                        if( m_NewThread )
                        {
                            TextRelay topic = info.GetTextEntry( 2 );

                            if( topic.Text.Length < ForumCore.MinPostCharactersCount )
                            {
                                m_Player.SendMessage( "The subject of the post must be more then {0} characters in length.", ForumCore.MinPostCharactersCount.ToString() );
                                m_Player.SendGump( this );
                                break;
                            }                            
                            m_Topic = topic.Text;
                            m_Switches = info.Switches;
                        }

                        m_Player.Prompt = new LongPostLinesPrompt( this, m_Player );                        
                        break;

                    }
            }
        }

        private int[] m_Switches;
        private string m_Topic;
        private ArrayList m_Lines;

        public ArrayList Lines { get { return m_Lines; } set { m_Lines = value; } }

        public void Post()
        {
            if( m_NewThread )
            {
                bool staff = false;
                bool sticky = false;
                bool announcement = false;

                for( int i = 0; i < m_Switches.Length; i++ )
                {
                    if( m_Switches[i] == 4 )
                        staff = true;
                    if( m_Switches[i] == 5 )
                        sticky = true;
                    if( m_Switches[i] == 6 )
                        announcement = true;
                }

                if( sticky && announcement )
                {
                    m_Player.SendMessage( "Since you checked both sticky and announcement, this post was changed to sticky by default!" );
                    announcement = false;
                }

                ThreadType type;

                if( sticky )
                    type = ThreadType.Sticky;
                else if( announcement )
                    type = ThreadType.Announcement;
                else
                    type = ThreadType.RegularThread;

                string post = GetText();

                PostEntry pe = new PostEntry( m_Player, m_Player.Serial, post, DateTime.Now );
                ThreadEntry te = new ThreadEntry( m_Topic, pe, m_Player, DateTime.Now, ForumCore.ThreadNumber, type );

                if( staff )
                    te.StaffMessage = true;

                te.LastPostTime = DateTime.Now;

                ForumCore.Threads.Add( te );
                ForumCore.UpdatePlayerStatistics( m_Player );

                ForumCore.Threads.Sort( new DateSort() );
                m_Player.CloseGump( typeof( ForumGump ) );
                m_Player.SendGump( new ForumGump( m_Player, 0 ) );
            }
            else
            {
                string post = GetText();
                PostEntry pe = new PostEntry( m_Player, m_Player.Serial, post, DateTime.Now );

                m_ThreadEntry.AddPost( pe );
                m_ThreadEntry.LastPostTime = DateTime.Now;
                ForumCore.UpdatePlayerStatistics( m_Player );

                ForumCore.Threads.Sort( new DateSort() );
                m_Player.CloseGump( typeof( ForumGump ) );
                m_Player.SendGump( new ForumGump( m_Player, 0 ) );
            }
        }

        private string GetText()
        {
            string text = "";

            for( int i = 0; i < m_Lines.Count; i++ )
            {
                text += String.Format( "{0} ", (string)m_Lines[i] );
            }

            return text;
        }

        public class LongPostLinesPrompt : Prompt
        {
            private PostGump m_PG;

            public LongPostLinesPrompt( PostGump pg, Mobile m )
            {
                m_PG = pg;
                m.SendMessage( "Start typing your post, press enter to add another line or <ESC> if the post is finished." );
            }

            public override void OnResponse( Mobile from, string text )
            {
                m_PG.Lines.Add( text );


                from.SendMessage( "Enter the next line of you post, or press <ESC> if the post is finished." );
                from.Prompt = new LongPostLinesPrompt( m_PG, from );
            }

            public override void OnCancel( Mobile from )
            {
                if( m_PG.Lines.Count == 0 )
                    return;

                if( m_PG.Lines.Count > 0 )
                {
                    m_PG.Post();
                    from.SendMessage( "Message has been set." );
                }                
            }
        }
    }
}