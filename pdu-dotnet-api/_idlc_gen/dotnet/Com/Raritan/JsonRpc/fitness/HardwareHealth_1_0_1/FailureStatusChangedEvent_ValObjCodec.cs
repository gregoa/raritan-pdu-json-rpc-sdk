// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from HardwareHealth.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.fitness.HardwareHealth_1_0_1 {
  public class FailureStatusChangedEvent_ValObjCodec : Com.Raritan.JsonRpc.idl.Event_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.fitness.HardwareHealth_1_0_1.FailureStatusChangedEvent.typeInfo, new FailureStatusChangedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.fitness.HardwareHealth_1_0_1.FailureStatusChangedEvent)vo;
      json["componentId"] = inst.componentId;
      json["failureType"] = inst.failureType;
      json["isAsserted"] = inst.isAsserted;
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.fitness.HardwareHealth_1_0_1.FailureStatusChangedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.fitness.HardwareHealth_1_0_1.FailureStatusChangedEvent();
      } else {
        inst = (Com.Raritan.Idl.fitness.HardwareHealth_1_0_1.FailureStatusChangedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.componentId = (string)json["componentId"];
      inst.failureType = (int)json["failureType"];
      inst.isAsserted = (bool)json["isAsserted"];
      return inst;
    }

  }
}