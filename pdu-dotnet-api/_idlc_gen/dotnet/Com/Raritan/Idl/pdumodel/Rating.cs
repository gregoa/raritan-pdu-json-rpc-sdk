// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Nameplate.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {

  public class Rating : ICloneable {
    public object Clone() {
      Rating copy = new Rating();
      copy.current = this.current;
      copy.minVoltage = this.minVoltage;
      copy.maxVoltage = this.maxVoltage;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["current"] = this.current;
      json["minVoltage"] = this.minVoltage;
      json["maxVoltage"] = this.maxVoltage;
      return json;
    }

    public static Rating Decode(LightJson.JsonObject json, Agent agent) {
      Rating inst = new Rating();
      inst.current = (int)json["current"];
      inst.minVoltage = (int)json["minVoltage"];
      inst.maxVoltage = (int)json["maxVoltage"];
      return inst;
    }

    public int current = 0;
    public int minVoltage = 0;
    public int maxVoltage = 0;
  }
}
