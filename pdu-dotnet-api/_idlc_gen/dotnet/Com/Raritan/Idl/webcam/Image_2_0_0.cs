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

  public class Image_2_0_0 : ICloneable {
    public object Clone() {
      Image_2_0_0 copy = new Image_2_0_0();
      copy.meta = this.meta;
      copy.data = this.data;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["meta"] = this.meta.Encode();
      json["data"] = this.data;
      return json;
    }

    public static Image_2_0_0 Decode(LightJson.JsonObject json, Agent agent) {
      Image_2_0_0 inst = new Image_2_0_0();
      inst.meta = Com.Raritan.Idl.webcam.ImageMetaData.Decode(json["meta"], agent);
      inst.data = (string)json["data"];
      return inst;
    }

    public Com.Raritan.Idl.webcam.ImageMetaData meta = new Com.Raritan.Idl.webcam.ImageMetaData();
    public string data = "";
  }
}
