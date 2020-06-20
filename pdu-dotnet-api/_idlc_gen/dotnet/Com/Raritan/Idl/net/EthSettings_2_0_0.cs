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

  public class EthSettings_2_0_0 : ICloneable {
    public object Clone() {
      EthSettings_2_0_0 copy = new EthSettings_2_0_0();
      copy.linkMode = this.linkMode;
      copy.authType = this.authType;
      copy.eap = this.eap;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["linkMode"] = this.linkMode.Encode();
      json["authType"] = (int)this.authType;
      json["eap"] = this.eap.Encode();
      return json;
    }

    public static EthSettings_2_0_0 Decode(LightJson.JsonObject json, Agent agent) {
      EthSettings_2_0_0 inst = new EthSettings_2_0_0();
      inst.linkMode = Com.Raritan.Idl.net.EthLinkMode.Decode(json["linkMode"], agent);
      inst.authType = (Com.Raritan.Idl.net.EthAuthType)(int)json["authType"];
      inst.eap = Com.Raritan.Idl.net.EapAuthSettings_3_0_0.Decode(json["eap"], agent);
      return inst;
    }

    public Com.Raritan.Idl.net.EthLinkMode linkMode = new Com.Raritan.Idl.net.EthLinkMode();
    public Com.Raritan.Idl.net.EthAuthType authType = Com.Raritan.Idl.net.EthAuthType.ETH_AUTH_NONE;
    public Com.Raritan.Idl.net.EapAuthSettings_3_0_0 eap = new Com.Raritan.Idl.net.EapAuthSettings_3_0_0();
  }
}
