using System.Text;
using GrandTheftMultiplayer.Server;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;

namespace IcaroRPG.Global
{
    public static class Util
    {
        public static string Repeat(string str, int times)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < times; i++)
            {
                sb.Append(str);
            }

            return sb.ToString();
        }

        public static void TeleportWithFade(Client player, Vector3 targetpos)
        {
            if (player.vehicle != null) return;
           // API.shared.sendNativeToPlayer(player, Hash.DO_SCREEN_FADE_OUT, 200);
          //  API.shared.delay(300, true, () => {
                API.shared.setEntityPosition(player.handle, targetpos);
             //   API.shared.sendNativeToPlayer(player, Hash.DO_SCREEN_FADE_IN, 1000);
         //   });
        }

        public static bool IsInRangeOf(Vector3 playerPos, Vector3 target, float range)
        {
            var direct = new Vector3(target.X - playerPos.X, target.Y - playerPos.Y, target.Z - playerPos.Z);
            var len = direct.X * direct.X + direct.Y * direct.Y + direct.Z * direct.Z;
            return range * range > len;
        }
    }
}