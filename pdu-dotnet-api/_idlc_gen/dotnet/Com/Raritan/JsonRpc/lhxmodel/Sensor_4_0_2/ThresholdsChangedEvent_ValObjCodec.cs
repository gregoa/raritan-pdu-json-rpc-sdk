// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from LhxSensor.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.lhxmodel.Sensor_4_0_2 {
  public class ThresholdsChangedEvent_ValObjCodec : Com.Raritan.JsonRpc._event.UserEvent_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.lhxmodel.Sensor_4_0_2.ThresholdsChangedEvent.typeInfo, new ThresholdsChangedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.lhxmodel.Sensor_4_0_2.ThresholdsChangedEvent)vo;
      json["oldThresholds"] = inst.oldThresholds.Encode();
      json["newThresholds"] = inst.newThresholds.Encode();
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.lhxmodel.Sensor_4_0_2.ThresholdsChangedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.lhxmodel.Sensor_4_0_2.ThresholdsChangedEvent();
      } else {
        inst = (Com.Raritan.Idl.lhxmodel.Sensor_4_0_2.ThresholdsChangedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.oldThresholds = Com.Raritan.Idl.lhxmodel.Sensor_4_0_2.NumThresholds.Decode(json["oldThresholds"], agent);
      inst.newThresholds = Com.Raritan.Idl.lhxmodel.Sensor_4_0_2.NumThresholds.Decode(json["newThresholds"], agent);
      return inst;
    }

  }
}