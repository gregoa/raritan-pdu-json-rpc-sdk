// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Security.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.security {

  public class IpfwRuleset : ICloneable {
    public object Clone() {
      IpfwRuleset copy = new IpfwRuleset();
      copy.ipMask = this.ipMask;
      copy.policy = this.policy;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["ipMask"] = this.ipMask;
      json["policy"] = (int)this.policy;
      return json;
    }

    public static IpfwRuleset Decode(LightJson.JsonObject json, Agent agent) {
      IpfwRuleset inst = new IpfwRuleset();
      inst.ipMask = (string)json["ipMask"];
      inst.policy = (Com.Raritan.Idl.security.IpfwPolicy)(int)json["policy"];
      return inst;
    }

    public string ipMask = "";
    public Com.Raritan.Idl.security.IpfwPolicy policy = Com.Raritan.Idl.security.IpfwPolicy.ACCEPT;
  }
}