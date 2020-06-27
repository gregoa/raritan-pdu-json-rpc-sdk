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

  public class Device_3_0_1 : ValueObject {
    static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.Device:3.0.1", ValueObject.typeInfo);

    public Com.Raritan.Idl.peripheral.DeviceID_3_0_1 deviceID = new Com.Raritan.Idl.peripheral.DeviceID_3_0_1();
    public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.peripheral.PosElement> position = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.PosElement>();
    public string packageClass = "";
    public Com.Raritan.Idl.sensors.Sensor_4_0_2 device = null;
  }
}