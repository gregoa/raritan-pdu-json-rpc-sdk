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

namespace Com.Raritan.JsonRpc.peripheral.DeviceManager_3_0_2 {
  public class PackageEvent_2_0_0_ValObjCodec : Com.Raritan.JsonRpc.idl.Event_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.peripheral.DeviceManager_3_0_2.PackageEvent_2_0_0.typeInfo, new PackageEvent_2_0_0_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.peripheral.DeviceManager_3_0_2.PackageEvent_2_0_0)vo;
      json["packageInfos"] = new JsonArray(inst.packageInfos.Select(
        _value => (JsonValue)(_value.Encode())));
      json["allPackages"] = new JsonArray(inst.allPackages.Select(
        _value => (JsonValue)(_value.Encode())));
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.peripheral.DeviceManager_3_0_2.PackageEvent_2_0_0 inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.peripheral.DeviceManager_3_0_2.PackageEvent_2_0_0();
      } else {
        inst = (Com.Raritan.Idl.peripheral.DeviceManager_3_0_2.PackageEvent_2_0_0)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.packageInfos = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.PackageInfo_2_0_1>(json["packageInfos"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.peripheral.PackageInfo_2_0_1.Decode(_value, agent)));
      inst.allPackages = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.PackageInfo_2_0_1>(json["allPackages"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.peripheral.PackageInfo_2_0_1.Decode(_value, agent)));
      return inst;
    }

  }
}
