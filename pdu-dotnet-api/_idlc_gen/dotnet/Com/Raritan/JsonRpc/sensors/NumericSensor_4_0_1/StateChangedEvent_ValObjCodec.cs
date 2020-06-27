// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from NumericSensor.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.sensors.NumericSensor_4_0_1 {
  public class StateChangedEvent_ValObjCodec : Com.Raritan.JsonRpc.idl.Event_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StateChangedEvent.typeInfo, new StateChangedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StateChangedEvent)vo;
      json["oldReading"] = inst.oldReading.Encode();
      json["newReading"] = inst.newReading.Encode();
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StateChangedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StateChangedEvent();
      } else {
        inst = (Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StateChangedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.oldReading = Com.Raritan.Idl.sensors.NumericSensor_4_0_1.Reading.Decode(json["oldReading"], agent);
      inst.newReading = Com.Raritan.Idl.sensors.NumericSensor_4_0_1.Reading.Decode(json["newReading"], agent);
      return inst;
    }

  }
}
