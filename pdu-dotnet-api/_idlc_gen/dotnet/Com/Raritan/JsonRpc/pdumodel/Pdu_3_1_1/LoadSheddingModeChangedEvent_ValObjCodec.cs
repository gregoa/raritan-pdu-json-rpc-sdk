// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Pdu.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.pdumodel.Pdu_3_1_1 {
  public class LoadSheddingModeChangedEvent_ValObjCodec : Com.Raritan.JsonRpc._event.UserEvent_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.pdumodel.Pdu_3_1_1.LoadSheddingModeChangedEvent.typeInfo, new LoadSheddingModeChangedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.pdumodel.Pdu_3_1_1.LoadSheddingModeChangedEvent)vo;
      json["enabled"] = inst.enabled;
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.pdumodel.Pdu_3_1_1.LoadSheddingModeChangedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.pdumodel.Pdu_3_1_1.LoadSheddingModeChangedEvent();
      } else {
        inst = (Com.Raritan.Idl.pdumodel.Pdu_3_1_1.LoadSheddingModeChangedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.enabled = (bool)json["enabled"];
      return inst;
    }

  }
}
