// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from PeripheralDeviceSlot.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.peripheral {
  public class Device_ValObjCodec : ValueObjectCodec
 {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.peripheral.Device.typeInfo, new Device_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      var inst = (Com.Raritan.Idl.peripheral.Device)vo;
      json["deviceID"] = inst.deviceID.Encode();
      json["position"] = new JsonArray(inst.position.Select(
        _value => (JsonValue)(_value.Encode())));
      json["packageClass"] = inst.packageClass;
      json["device"] = inst.device != null ? inst.device.Encode() : JsonValue.Null;
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.peripheral.Device inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.peripheral.Device();
      } else {
        inst = (Com.Raritan.Idl.peripheral.Device)vo;
      }
      inst.deviceID = Com.Raritan.Idl.peripheral.DeviceID.Decode(json["deviceID"], agent);
      inst.position = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.PosElement>(json["position"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.peripheral.PosElement.Decode(_value, agent)));
      inst.packageClass = (string)json["packageClass"];
      inst.device = Com.Raritan.Idl.sensors.Sensor_3_0_0.StaticCast(ObjectProxy.Decode(json["device"], agent));
      return inst;
    }

  }
}
