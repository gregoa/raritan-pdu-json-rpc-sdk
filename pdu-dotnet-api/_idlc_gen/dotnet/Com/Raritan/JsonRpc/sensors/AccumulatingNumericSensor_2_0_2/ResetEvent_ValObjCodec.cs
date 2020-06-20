// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from AccumulatingNumericSensor.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.sensors.AccumulatingNumericSensor_2_0_2 {
  public class ResetEvent_ValObjCodec : Com.Raritan.JsonRpc._event.UserEvent_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.sensors.AccumulatingNumericSensor_2_0_2.ResetEvent.typeInfo, new ResetEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.sensors.AccumulatingNumericSensor_2_0_2.ResetEvent)vo;
      json["oldReading"] = inst.oldReading.Encode();
      json["newReading"] = inst.newReading.Encode();
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.sensors.AccumulatingNumericSensor_2_0_2.ResetEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.sensors.AccumulatingNumericSensor_2_0_2.ResetEvent();
      } else {
        inst = (Com.Raritan.Idl.sensors.AccumulatingNumericSensor_2_0_2.ResetEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.oldReading = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.Reading.Decode(json["oldReading"], agent);
      inst.newReading = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.Reading.Decode(json["newReading"], agent);
      return inst;
    }

  }
}
