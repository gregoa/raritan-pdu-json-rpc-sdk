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

namespace Com.Raritan.Idl.peripheral {

  public class DeviceID_3_0_1 : ICloneable {
    public object Clone() {
      DeviceID_3_0_1 copy = new DeviceID_3_0_1();
      copy.serial = this.serial;
      copy.type = this.type;
      copy.isActuator = this.isActuator;
      copy.channel = this.channel;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["serial"] = this.serial;
      json["type"] = this.type.Encode();
      json["isActuator"] = this.isActuator;
      json["channel"] = this.channel;
      return json;
    }

    public static DeviceID_3_0_1 Decode(LightJson.JsonObject json, Agent agent) {
      DeviceID_3_0_1 inst = new DeviceID_3_0_1();
      inst.serial = (string)json["serial"];
      inst.type = Com.Raritan.Idl.sensors.Sensor_4_0_2.TypeSpec.Decode(json["type"], agent);
      inst.isActuator = (bool)json["isActuator"];
      inst.channel = (int)json["channel"];
      return inst;
    }

    public string serial = "";
    public Com.Raritan.Idl.sensors.Sensor_4_0_2.TypeSpec type = new Com.Raritan.Idl.sensors.Sensor_4_0_2.TypeSpec();
    public bool isActuator = false;
    public int channel = 0;
  }
}
