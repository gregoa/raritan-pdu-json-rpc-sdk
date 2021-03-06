// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Pole.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {

  public class ThrowPole_2_0_0 : ICloneable {
    public object Clone() {
      ThrowPole_2_0_0 copy = new ThrowPole_2_0_0();
      copy.label = this.label;
      copy.line = this.line;
      copy.inNodeIds = this.inNodeIds;
      copy.outNodeId = this.outNodeId;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["label"] = this.label;
      json["line"] = (int)this.line;
      json["inNodeIds"] = new JsonArray(this.inNodeIds.Select(
        _value => (JsonValue)(_value)));
      json["outNodeId"] = this.outNodeId;
      return json;
    }

    public static ThrowPole_2_0_0 Decode(LightJson.JsonObject json, Agent agent) {
      ThrowPole_2_0_0 inst = new ThrowPole_2_0_0();
      inst.label = (string)json["label"];
      inst.line = (Com.Raritan.Idl.pdumodel.PowerLine_2_0_0)(int)json["line"];
      inst.inNodeIds = new System.Collections.Generic.List<int>(json["inNodeIds"].AsJsonArray.Select(
        _value => (int)_value));
      inst.outNodeId = (int)json["outNodeId"];
      return inst;
    }

    public string label = "";
    public Com.Raritan.Idl.pdumodel.PowerLine_2_0_0 line = Com.Raritan.Idl.pdumodel.PowerLine_2_0_0.L1;
    public System.Collections.Generic.IEnumerable<int> inNodeIds = new System.Collections.Generic.List<int>();
    public int outNodeId = 0;
  }
}
