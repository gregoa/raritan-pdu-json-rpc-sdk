// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from TfwEvent.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.tfw {

  public class Event : ICloneable {
    public object Clone() {
      Event copy = new Event();
      copy.type = this.type;
      copy.src = this.src;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["type"] = this.type.Encode();
      json["src"] = this.src != null ? this.src.Encode() : JsonValue.Null;
      return json;
    }

    public static Event Decode(LightJson.JsonObject json, Agent agent) {
      Event inst = new Event();
      inst.type = Com.Raritan.Idl.tfw.EventType.Decode(json["type"], agent);
      inst.src = ObjectProxy.Decode(json["src"], agent);
      return inst;
    }

    public Com.Raritan.Idl.tfw.EventType type = new Com.Raritan.Idl.tfw.EventType();
    public ObjectProxy src = null;
  }
}