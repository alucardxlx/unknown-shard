using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Commands
{
    public class EventStart
    {
        public static int EventX = 0;
        public static int EventY = 0;
        public static int EventZ = 0;
        public static Map EventMap;

        public static int is_event = 0;
        public static int seconds = 15;
       	public static Timer m_Timer;


        public static void Initialize()
        {
            CommandSystem.Register("createevent", AccessLevel.GameMaster, new CommandEventHandler(EventStart_OnCommand));
        }
        [Usage("createevent")]
        public static void EventStart_OnCommand(CommandEventArgs e)
        {
            Mobile sender = e.Mobile;
            EventStart.EventX = e.Mobile.X;
            EventStart.EventY = e.Mobile.Y;
            EventStart.EventZ = e.Mobile.Z;
            EventStart.EventMap = e.Mobile.Map;
            EventStart.is_event = 1;
            string text = "An Event Has Been Created.  Type [Event To Join.";
            World.Broadcast(64, true, String.Format("{0}", text));
            m_Timer = new BroadcastTimer();
		    m_Timer.Start();
        }
    
        private class BroadcastTimer : Timer
		{
            public BroadcastTimer() : base( TimeSpan.FromSeconds(EventStart.seconds),TimeSpan.FromSeconds(EventStart.seconds) )
			{
				Priority = TimerPriority.OneSecond;
			}

			protected override void OnTick()
			{
                string text = "An Event Is In Progress.  Type [Event To Join.";
                World.Broadcast(64, true, String.Format("{0}", text));
			}
		}
    }


    public class EventEnd
    {
        public static void Initialize()
        {
            CommandSystem.Register("closeevent", AccessLevel.GameMaster, new CommandEventHandler(EventEnd_OnCommand));
        }
        [Usage("closeevent")]
        public static void EventEnd_OnCommand(CommandEventArgs e)
        {
            string text = "The Event Is Now Closed.  We Are Not Accepting Any More Players.";
            Mobile sender = e.Mobile;
            EventStart.is_event = 0;
            World.Broadcast(64, true, String.Format("{0}", text));
   		    EventStart.m_Timer.Stop();

        }
    }

    public class EventTele
    {
        public static void Initialize()
        {
            CommandSystem.Register("event", AccessLevel.Player, new CommandEventHandler(EventTele_OnCommand));
        }
        [Usage("event")]
        public static void EventTele_OnCommand(CommandEventArgs e)
        {
            if (EventStart.is_event == 1)
            {
                Mobile sender = e.Mobile;
                e.Mobile.X = EventStart.EventX;
                e.Mobile.Y = EventStart.EventY;
                e.Mobile.Z = EventStart.EventZ;
                e.Mobile.Map = EventStart.EventMap;
            }
            else
            {
                e.Mobile.SendMessage("There is no active event to join");
            }
        }
    }
}