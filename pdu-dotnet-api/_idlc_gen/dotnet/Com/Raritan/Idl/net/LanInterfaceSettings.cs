// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Net.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.net {

  public class LanInterfaceSettings : ICloneable {
    public object Clone() {
      LanInterfaceSettings copy = new LanInterfaceSettings();
      copy.speed = this.speed;
      copy.duplex = this.duplex;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["speed"] = (int)this.speed;
      json["duplex"] = (int)this.duplex;
      return json;
    }

    public static LanInterfaceSettings Decode(LightJson.JsonObject json, Agent agent) {
      LanInterfaceSettings inst = new LanInterfaceSettings();
      inst.speed = (Com.Raritan.Idl.net.LanSpeed)(int)json["speed"];
      inst.duplex = (Com.Raritan.Idl.net.LanDuplex)(int)json["duplex"];
      return inst;
    }

    public Com.Raritan.Idl.net.LanSpeed speed = Com.Raritan.Idl.net.LanSpeed.LAN_SPEED_AUTO;
    public Com.Raritan.Idl.net.LanDuplex duplex = Com.Raritan.Idl.net.LanDuplex.LAN_DUPLEX_AUTO;
  }
}
