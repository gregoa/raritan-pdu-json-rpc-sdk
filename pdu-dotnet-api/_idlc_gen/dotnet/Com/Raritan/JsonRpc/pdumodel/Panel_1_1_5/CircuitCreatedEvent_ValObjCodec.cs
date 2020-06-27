// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Panel.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.pdumodel.Panel_1_1_5 {
  public class CircuitCreatedEvent_ValObjCodec : Com.Raritan.JsonRpc._event.UserEvent_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.pdumodel.Panel_1_1_5.CircuitCreatedEvent.typeInfo, new CircuitCreatedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.pdumodel.Panel_1_1_5.CircuitCreatedEvent)vo;
      json["circuit"] = inst.circuit != null ? inst.circuit.Encode() : JsonValue.Null;
      json["config"] = inst.config.Encode();
      json["settings"] = inst.settings.Encode();
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.pdumodel.Panel_1_1_5.CircuitCreatedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.pdumodel.Panel_1_1_5.CircuitCreatedEvent();
      } else {
        inst = (Com.Raritan.Idl.pdumodel.Panel_1_1_5.CircuitCreatedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.circuit = Com.Raritan.Idl.pdumodel.Circuit_1_0_3.StaticCast(ObjectProxy.Decode(json["circuit"], agent));
      inst.config = Com.Raritan.Idl.pdumodel.Circuit_1_0_3.Config.Decode(json["config"], agent);
      inst.settings = Com.Raritan.Idl.pdumodel.Circuit_1_0_3.Settings.Decode(json["settings"], agent);
      return inst;
    }

  }
}
