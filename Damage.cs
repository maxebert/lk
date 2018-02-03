using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrandTheftMultiplayer.Server;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;

namespace IcaroRPG
{
    public class Damage : Script
    {
        public Damage()
        {
            API.onClientEventTrigger += ClientTrigger;
        }
        public void ClientTrigger(Client sender, string eventName, object[] args)
        {
            if (eventName == "dmg")
            {
                API.setEntityData(sender, "Health", sender.health);
                API.setEntityData(sender, "Armor", sender.armor);
            }
        }
    }
}
