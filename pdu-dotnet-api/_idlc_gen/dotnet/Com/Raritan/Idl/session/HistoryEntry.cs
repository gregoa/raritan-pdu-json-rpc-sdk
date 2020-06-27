// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from SessionManager.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.session {

  public class HistoryEntry : ICloneable {
    public object Clone() {
      HistoryEntry copy = new HistoryEntry();
      copy.creationTime = this.creationTime;
      copy.remoteIp = this.remoteIp;
      copy.clientType = this.clientType;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["creationTime"] = this.creationTime.Ticks;
      json["remoteIp"] = this.remoteIp;
      json["clientType"] = this.clientType;
      return json;
    }

    public static HistoryEntry Decode(LightJson.JsonObject json, Agent agent) {
      HistoryEntry inst = new HistoryEntry();
      inst.creationTime = new System.DateTime(json["creationTime"]);
      inst.remoteIp = (string)json["remoteIp"];
      inst.clientType = (string)json["clientType"];
      return inst;
    }

    public System.DateTime creationTime = new System.DateTime(0);
    public string remoteIp = "";
    public string clientType = "";
  }
}
