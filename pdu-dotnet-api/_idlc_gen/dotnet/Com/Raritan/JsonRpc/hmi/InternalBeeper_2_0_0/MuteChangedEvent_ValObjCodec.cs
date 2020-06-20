// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from InternalBeeper.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.hmi.InternalBeeper_2_0_0 {
  public class MuteChangedEvent_ValObjCodec : Com.Raritan.JsonRpc._event.UserEvent_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.hmi.InternalBeeper_2_0_0.MuteChangedEvent.typeInfo, new MuteChangedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.hmi.InternalBeeper_2_0_0.MuteChangedEvent)vo;
      json["muted"] = inst.muted;
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.hmi.InternalBeeper_2_0_0.MuteChangedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.hmi.InternalBeeper_2_0_0.MuteChangedEvent();
      } else {
        inst = (Com.Raritan.Idl.hmi.InternalBeeper_2_0_0.MuteChangedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.muted = (bool)json["muted"];
      return inst;
    }

  }
}
