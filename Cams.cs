using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrandTheftMultiplayer.Server;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;

namespace IcaroRPG
{
    public static class Cams
    {
        public static void pointCameraAtLocalPlayer(Client player, int camera, Vector3 offset)
        {
            API.shared.triggerClientEvent(player, "pointCameraAtLocalPlayer", camera, offset);
        } 

        public static void setActiveCamera(Client player, int camera)
        {
            API.shared.triggerClientEvent(player, "setActiveCamera", camera);
        }
        
        public static void interpolateCamera(Client player, int tocamera, double duration, bool easepos, bool easerot )
        {
            API.shared.triggerClientEvent(player, "interpolateCamera", tocamera, duration, easepos, easerot);
        }

        public static void createCameraActive(Client player, Vector3 position, Vector3 rotation)
        {
                API.shared.triggerClientEvent(player, "createCameraActive", position, rotation);
        }
        public static void createCameraInactive(Client player, Vector3 position, Vector3 rotation)
        {
            API.shared.triggerClientEvent(player, "createCameraInactive", position, rotation);
        }

        public static void setCameraHeading(Client player, int camera, double heading)
        {
            API.shared.triggerClientEvent(player, "setCameraHeading", camera, heading);
        }

        public static void createCameraAtGamecam(Client player)
        {
            API.shared.triggerClientEvent(player, "createCameraAtGamecam");
        }

        public static void backToGamecam(Client player)
        {
            API.shared.triggerClientEvent(player, "backToGamecam");
        }

        public static void setCameraFov(Client player, int camera, float fov)
        {
            API.shared.triggerClientEvent(player, "setCameraFov", camera, fov);
        }

        public static void clearCameras(Client player)
        {
            API.shared.triggerClientEvent(player, "clearCameras");
        }
    }
}
