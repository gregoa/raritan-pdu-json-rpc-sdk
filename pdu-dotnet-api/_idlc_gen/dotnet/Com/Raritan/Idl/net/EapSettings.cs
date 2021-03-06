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

  public class EapSettings : ICloneable {
    public object Clone() {
      EapSettings copy = new EapSettings();
      copy.identity = this.identity;
      copy.password = this.password;
      copy.outerMethod = this.outerMethod;
      copy.innerMethod = this.innerMethod;
      copy.caCertificate = this.caCertificate;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["identity"] = this.identity;
      json["password"] = this.password;
      json["outerMethod"] = (int)this.outerMethod;
      json["innerMethod"] = (int)this.innerMethod;
      json["caCertificate"] = this.caCertificate;
      return json;
    }

    public static EapSettings Decode(LightJson.JsonObject json, Agent agent) {
      EapSettings inst = new EapSettings();
      inst.identity = (string)json["identity"];
      inst.password = (string)json["password"];
      inst.outerMethod = (Com.Raritan.Idl.net.EapOuterMethod)(int)json["outerMethod"];
      inst.innerMethod = (Com.Raritan.Idl.net.EapInnerMethod)(int)json["innerMethod"];
      inst.caCertificate = (string)json["caCertificate"];
      return inst;
    }

    public string identity = "";
    public string password = "";
    public Com.Raritan.Idl.net.EapOuterMethod outerMethod = Com.Raritan.Idl.net.EapOuterMethod.EAP_PEAP;
    public Com.Raritan.Idl.net.EapInnerMethod innerMethod = Com.Raritan.Idl.net.EapInnerMethod.EAP_MSCHAPv2;
    public string caCertificate = "";
  }
}
