﻿using GrandTheftMultiplayer.Server;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;
using IcaroRPG.Cops;

namespace IcaroRPG.Global
{
    public class RespawnManager : Script
    {
        public RespawnManager()
        {
            API.onPlayerRespawn += RespawnPlayer;
            API.onVehicleDeath += OnVehicleExplode;
        }

        public void RespawnPlayer(Client player)
        {
            if (API.getEntityData(player, "IS_COP") == true)
            {
                API.call("SpawnManager", "SpawnCop", player);
            }
            else if (API.getEntityData(player, "Jailed") == true)
            {
                API.setEntityPosition(player, JailController.JailCenter);
            }
        }

        public void OnVehicleExplode(NetHandle vehicle)
        {
        /*    
            if (API.getEntityData(vehicle, "RESPAWNABLE") == true)
            {

                    var color1 = API.getVehiclePrimaryColor(vehicle);
                    var color2 = API.getVehicleSecondaryColor(vehicle);
                    var model = API.getEntityModel(vehicle);
                    var spawnPos = API.getEntityData(vehicle, "SPAWN_POS");

                    API.deleteEntity(vehicle);

                    API.createVehicle((VehicleHash) model, spawnPos, new Vector3(0, 0, 0), color1, color2);
                    API.setEntityData(vehicle, "SPAWN_POS", spawnPos);
                    API.setEntityData(vehicle, "RESPAWNABLE", true);
                    
            }
            */
            
        }
    }
}