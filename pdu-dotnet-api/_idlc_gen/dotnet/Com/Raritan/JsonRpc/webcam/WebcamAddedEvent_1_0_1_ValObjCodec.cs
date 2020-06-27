// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from WebcamManager.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.webcam {
  public class WebcamAddedEvent_1_0_1_ValObjCodec : Com.Raritan.JsonRpc.webcam.WebcamEvent_1_0_1_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.webcam.WebcamAddedEvent_1_0_1.typeInfo, new WebcamAddedEvent_1_0_1_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.webcam.WebcamAddedEvent_1_0_1)vo;
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.webcam.WebcamAddedEvent_1_0_1 inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.webcam.WebcamAddedEvent_1_0_1();
      } else {
        inst = (Com.Raritan.Idl.webcam.WebcamAddedEvent_1_0_1)vo;
      }
      base.DecodeValObj(vo, json, agent);
      return inst;
    }

  }
}
