// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from PowerLogicPowerMeter.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.powerlogic.PowerMeter_1_2_5 {
  public class SetupChangedEvent_ValObjCodec : Com.Raritan.JsonRpc.idl.Event_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.powerlogic.PowerMeter_1_2_5.SetupChangedEvent.typeInfo, new SetupChangedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.powerlogic.PowerMeter_1_2_5.SetupChangedEvent)vo;
      json["oldSetup"] = inst.oldSetup.Encode();
      json["newSetup"] = inst.newSetup.Encode();
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.powerlogic.PowerMeter_1_2_5.SetupChangedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_5.SetupChangedEvent();
      } else {
        inst = (Com.Raritan.Idl.powerlogic.PowerMeter_1_2_5.SetupChangedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.oldSetup = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_5.Setup.Decode(json["oldSetup"], agent);
      inst.newSetup = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_5.Setup.Decode(json["newSetup"], agent);
      return inst;
    }

  }
}
