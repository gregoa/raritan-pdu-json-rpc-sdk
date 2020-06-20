// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from PeripheralDeviceManager.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.peripheral.DeviceManager_2_0_1 {
  public class DeviceEvent_ValObjCodec : Com.Raritan.JsonRpc.idl.Event_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.peripheral.DeviceManager_2_0_1.DeviceEvent.typeInfo, new DeviceEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.peripheral.DeviceManager_2_0_1.DeviceEvent)vo;
      json["device"] = ValueObjectCodec.Encode(inst.device);
      json["allDevices"] = new JsonArray(inst.allDevices.Select(
        _value => (JsonValue)(ValueObjectCodec.Encode(_value))));
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.peripheral.DeviceManager_2_0_1.DeviceEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.peripheral.DeviceManager_2_0_1.DeviceEvent();
      } else {
        inst = (Com.Raritan.Idl.peripheral.DeviceManager_2_0_1.DeviceEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.device = ((Com.Raritan.Idl.peripheral.Device_3_0_0)ValueObjectCodec.DecodeAs(json["device"], agent, Com.Raritan.Idl.peripheral.Device_3_0_0.typeInfo));
      inst.allDevices = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.Device_3_0_0>(json["allDevices"].AsJsonArray.Select(
        _value => ((Com.Raritan.Idl.peripheral.Device_3_0_0)ValueObjectCodec.DecodeAs(_value, agent, Com.Raritan.Idl.peripheral.Device_3_0_0.typeInfo))));
      return inst;
    }

  }
}