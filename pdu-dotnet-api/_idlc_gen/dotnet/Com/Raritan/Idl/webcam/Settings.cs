// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Webcam.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.webcam {

  public class Settings : ICloneable {
    public object Clone() {
      Settings copy = new Settings();
      copy.format = this.format;
      copy.name = this.name;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["format"] = this.format.Encode();
      json["name"] = this.name;
      return json;
    }

    public static Settings Decode(LightJson.JsonObject json, Agent agent) {
      Settings inst = new Settings();
      inst.format = Com.Raritan.Idl.webcam.Format.Decode(json["format"], agent);
      inst.name = (string)json["name"];
      return inst;
    }

    public Com.Raritan.Idl.webcam.Format format = new Com.Raritan.Idl.webcam.Format();
    public string name = "";
  }
}
