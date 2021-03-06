// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Lhx.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.lhxmodel.Lhx_3_2_1 {
  public class OpStateChangedEvent_ValObjCodec : Com.Raritan.JsonRpc.idl.Event_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.lhxmodel.Lhx_3_2_1.OpStateChangedEvent.typeInfo, new OpStateChangedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.lhxmodel.Lhx_3_2_1.OpStateChangedEvent)vo;
      json["oldState"] = inst.oldState.Encode();
      json["newState"] = inst.newState.Encode();
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.lhxmodel.Lhx_3_2_1.OpStateChangedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.lhxmodel.Lhx_3_2_1.OpStateChangedEvent();
      } else {
        inst = (Com.Raritan.Idl.lhxmodel.Lhx_3_2_1.OpStateChangedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.oldState = Com.Raritan.Idl.lhxmodel.Lhx_3_2_1.OpState.Decode(json["oldState"], agent);
      inst.newState = Com.Raritan.Idl.lhxmodel.Lhx_3_2_1.OpState.Decode(json["newState"], agent);
      return inst;
    }

  }
}
