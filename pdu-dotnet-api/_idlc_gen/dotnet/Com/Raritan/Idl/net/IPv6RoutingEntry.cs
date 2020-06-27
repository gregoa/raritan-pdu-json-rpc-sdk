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

  public class IPv6RoutingEntry : ICloneable {
    public object Clone() {
      IPv6RoutingEntry copy = new IPv6RoutingEntry();
      copy.dest = this.dest;
      copy.nexthop = this.nexthop;
      copy.intf = this.intf;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["dest"] = this.dest;
      json["nexthop"] = this.nexthop;
      json["intf"] = this.intf;
      return json;
    }

    public static IPv6RoutingEntry Decode(LightJson.JsonObject json, Agent agent) {
      IPv6RoutingEntry inst = new IPv6RoutingEntry();
      inst.dest = (string)json["dest"];
      inst.nexthop = (string)json["nexthop"];
      inst.intf = (string)json["intf"];
      return inst;
    }

    public string dest = "";
    public string nexthop = "";
    public string intf = "";
  }
}
