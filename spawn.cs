﻿using System;
using GTANetworkServer;
using GTANetworkShared;

namespace DayZ
{
    public class SpawnManager : Script
    {

        private readonly Vector3 _copSpawnpoint = new Vector3(447.1f, -984.21f, 30.69f);
        private readonly Vector3 _crookSpawnpoint = new Vector3(-25.27f, -1554.27f, 30.69f);
        private readonly Vector3 _stripClub = new Vector3(126.135, 1278.583, 29.270 );

        public SpawnManager()
        {
            API.onClientEventTrigger += ClientEvent;
        }

        public void ClientEvent(Client sender, string eventName, object[] args)
        {

        }


        public void SpawnPlayer(Client target)
        {
            API.setEntityPosition(target, _crookSpawnpoint);
        }
    }
}