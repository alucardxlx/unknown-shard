using System;
using Server;
using Server.Items;
using Server.Network;
using Server.Mobiles;
using System.Collections;

namespace Server.Engines.XmlSpawner2
{
    public class XmlAddFaction : XmlAttachment
    {
        private int m_DataValue;    // default data
        private string m_GroupName;

        [CommandProperty( AccessLevel.GameMaster )]
        public int Value { get{ return m_DataValue; } set { m_DataValue = value; } }
        public string FactionType { get{ return m_GroupName; } set { m_GroupName = value; } }

        // These are the various ways in which the message attachment can be constructed.  
        // These can be called via the [addatt interface, via scripts, via the spawner ATTACH keyword.
        // Other overloads could be defined to handle other types of arguments
       
        // a serial constructor is REQUIRED
        public XmlAddFaction(ASerial serial) : base(serial)
        {
        }

        [Attachable]
        public XmlAddFaction(string factiontype, int value)
        {
            Value = value;
            FactionType = factiontype;
        }


        public override void Serialize( GenericWriter writer )
		{
            base.Serialize(writer);

            writer.Write( (int) 0 );
            // version 0
            writer.Write(m_DataValue);
            writer.Write(m_GroupName);

        }

        public override void Deserialize(GenericReader reader)
		{
		    base.Deserialize(reader);

            int version = reader.ReadInt();
            // version 0
            m_DataValue = reader.ReadInt();
            m_GroupName = reader.ReadString();
		}
		
		public override void OnAttach()
		{
		    base.OnAttach();
		    
		    // apply the mod
            if(AttachedTo is PlayerMobile)
            {
                // for players just add it immediately
                // lookup the group type
                XmlMobFactions.GroupTypes g = XmlMobFactions.GroupTypes.End_Unused;
                try{
                    g = (XmlMobFactions.GroupTypes)Enum.Parse(typeof(XmlMobFactions.GroupTypes),FactionType, true);
                } catch{}
                
                if(g != XmlMobFactions.GroupTypes.End_Unused)
                {

                    // get XmlMobFaction type attachments and add the faction
                    ArrayList list = XmlAttach.FindAttachments(AttachedTo, typeof(XmlMobFactions));
                    if(list != null && list.Count > 0)
                    {
                        foreach(XmlMobFactions x in list)
                        {
                            x.SetFactionLevel(g, x.GetFactionLevel(g) + Value);
                        }
                    }

                    ((Mobile)AttachedTo).SendMessage("Receive {0}",OnIdentify((Mobile)AttachedTo));
                } else 
                {
                    ((Mobile)AttachedTo).SendMessage("{0}: no such faction",FactionType);
                }
                // and then remove the attachment
                Delete();
            } else
            if(AttachedTo is Item)
            {
                // dont allow item attachments
                Delete();
            }

		}
		
		public override bool HandlesOnKilled { get { return true; } }
		
		public override void OnKilled(Mobile killed, Mobile killer )
		{
		    base.OnKill(killed, killer);

		    if(killer == null) return;
		    
		    XmlMobFactions.GroupTypes g = XmlMobFactions.GroupTypes.End_Unused;
            try{
                g = (XmlMobFactions.GroupTypes)Enum.Parse(typeof(XmlMobFactions.GroupTypes),FactionType, true);
            } catch{}
            
            if(g != XmlMobFactions.GroupTypes.End_Unused)
            {
    		    // give the killer the faction
    		    // get XmlMobFaction type attachments and add the faction
                ArrayList list = XmlAttach.FindAttachments(XmlAttach.MobileAttachments,killer, typeof(XmlMobFactions));
                if(list != null && list.Count > 0)
                {
                    foreach(XmlMobFactions x in list)
                    {
                        x.SetFactionLevel(g, x.GetFactionLevel(g) + Value);
                    }
                }

                killer.SendMessage("Receive {0}",OnIdentify(killer));
            }
		}


		public override string OnIdentify(Mobile from)
		{

            return String.Format("{0} {1} Faction", Value, FactionType);

		}
    }
}
