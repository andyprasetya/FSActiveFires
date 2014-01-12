﻿using BeatlesBlog.SimConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSActiveFires {
    /// <summary>
    /// Simulation variables belong as DataItem objects.  The objects are created, assigned values, then sent to the simulation using SimConnect_SetDataOnSimObject
    /// </summary>

    [DataStruct()]
    public struct LatLon {
        [DataItem("PLANE LATITUDE", "degrees")]
        public double Latitude;

        [DataItem("PLANE LONGITUDE", "degrees")]
        public double Longitude;
    }

    /// <summary>
    /// Make a new request for doing stuff so it can be later identified 
    /// </summary>
    enum Requests {
        DisplayText,
        CreateAI,
        RemoveAI,
        UserPosition,

        AIAddInfo = 0x01000000,
    }

    /// <summary>
    /// Event IDs are listed in the enum, mapped to the simulation using SimConnect_MapClientEventToSimEvent and used by SimConnect_TransmitClientEvent
    /// </summary>
    enum Events {
        AddObject,
        RemoveObject,
    }
}
