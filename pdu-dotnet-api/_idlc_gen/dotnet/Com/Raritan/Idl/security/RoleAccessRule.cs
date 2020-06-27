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

  public class RoleAccessRule : ICloneable {
    public object Clone() {
      RoleAccessRule copy = new RoleAccessRule();
      copy.startIp = this.startIp;
      copy.endIp = this.endIp;
      copy.roleId = this.roleId;
      copy.policy = this.policy;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["startIp"] = this.startIp;
      json["endIp"] = this.endIp;
      json["roleId"] = this.roleId;
      json["policy"] = (int)this.policy;
      return json;
    }

    public static RoleAccessRule Decode(LightJson.JsonObject json, Agent agent) {
      RoleAccessRule inst = new RoleAccessRule();
      inst.startIp = (string)json["startIp"];
      inst.endIp = (string)json["endIp"];
      inst.roleId = (int)json["roleId"];
      inst.policy = (Com.Raritan.Idl.security.RoleAccessPolicy)(int)json["policy"];
      return inst;
    }

    public string startIp = "";
    public string endIp = "";
    public int roleId = 0;
    public Com.Raritan.Idl.security.RoleAccessPolicy policy = Com.Raritan.Idl.security.RoleAccessPolicy.ALLOW;
  }
}