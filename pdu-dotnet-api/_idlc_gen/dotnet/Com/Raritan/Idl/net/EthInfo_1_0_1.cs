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

  public class EthInfo_1_0_1 : ICloneable {
    public object Clone() {
      EthInfo_1_0_1 copy = new EthInfo_1_0_1();
      copy.eapStatus = this.eapStatus;
      copy.linkMode = this.linkMode;
      copy.linkModeValid = this.linkModeValid;
      copy.autonegEnabled = this.autonegEnabled;
      copy.linkDetected = this.linkDetected;
      copy.supportedLinkModes = this.supportedLinkModes;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["eapStatus"] = (int)this.eapStatus;
      json["linkMode"] = this.linkMode.Encode();
      json["linkModeValid"] = this.linkModeValid;
      json["autonegEnabled"] = this.autonegEnabled;
      json["linkDetected"] = this.linkDetected;
      json["supportedLinkModes"] = new JsonArray(this.supportedLinkModes.Select(
        _value => (JsonValue)(_value.Encode())));
      return json;
    }

    public static EthInfo_1_0_1 Decode(LightJson.JsonObject json, Agent agent) {
      EthInfo_1_0_1 inst = new EthInfo_1_0_1();
      inst.eapStatus = (Com.Raritan.Idl.net.EapStatus)(int)json["eapStatus"];
      inst.linkMode = Com.Raritan.Idl.net.EthLinkMode.Decode(json["linkMode"], agent);
      inst.linkModeValid = (bool)json["linkModeValid"];
      inst.autonegEnabled = (bool)json["autonegEnabled"];
      inst.linkDetected = (bool)json["linkDetected"];
      inst.supportedLinkModes = new System.Collections.Generic.List<Com.Raritan.Idl.net.EthLinkMode>(json["supportedLinkModes"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.net.EthLinkMode.Decode(_value, agent)));
      return inst;
    }

    public Com.Raritan.Idl.net.EapStatus eapStatus = Com.Raritan.Idl.net.EapStatus.EAP_STATUS_DISABLED;
    public Com.Raritan.Idl.net.EthLinkMode linkMode = new Com.Raritan.Idl.net.EthLinkMode();
    public bool linkModeValid = false;
    public bool autonegEnabled = false;
    public bool linkDetected = false;
    public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.EthLinkMode> supportedLinkModes = new System.Collections.Generic.List<Com.Raritan.Idl.net.EthLinkMode>();
  }
}
