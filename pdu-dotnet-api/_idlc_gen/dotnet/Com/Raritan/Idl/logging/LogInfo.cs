// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Log.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.logging {

  public class LogInfo : ICloneable {
    public object Clone() {
      LogInfo copy = new LogInfo();
      copy.creationTime = this.creationTime;
      copy.idFirst = this.idFirst;
      copy.idNext = this.idNext;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["creationTime"] = this.creationTime;
      json["idFirst"] = this.idFirst;
      json["idNext"] = this.idNext;
      return json;
    }

    public static LogInfo Decode(LightJson.JsonObject json, Agent agent) {
      LogInfo inst = new LogInfo();
      inst.creationTime = (long)json["creationTime"];
      inst.idFirst = (int)json["idFirst"];
      inst.idNext = (int)json["idNext"];
      return inst;
    }

    public long creationTime = 0;
    public int idFirst = 0;
    public int idNext = 0;
  }
}
