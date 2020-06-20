// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from FirmwareUpdateStatus.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.firmware {

  public class UpdateStatus : ICloneable {
    public object Clone() {
      UpdateStatus copy = new UpdateStatus();
      copy.state = this.state;
      copy.elapsed = this.elapsed;
      copy.estimated = this.estimated;
      copy.error_message = this.error_message;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["state"] = this.state;
      json["elapsed"] = this.elapsed;
      json["estimated"] = this.estimated;
      json["error_message"] = this.error_message;
      return json;
    }

    public static UpdateStatus Decode(LightJson.JsonObject json, Agent agent) {
      UpdateStatus inst = new UpdateStatus();
      inst.state = (string)json["state"];
      inst.elapsed = (int)json["elapsed"];
      inst.estimated = (int)json["estimated"];
      inst.error_message = (string)json["error_message"];
      return inst;
    }

    public string state = "";
    public int elapsed = 0;
    public int estimated = 0;
    public string error_message = "";
  }
}