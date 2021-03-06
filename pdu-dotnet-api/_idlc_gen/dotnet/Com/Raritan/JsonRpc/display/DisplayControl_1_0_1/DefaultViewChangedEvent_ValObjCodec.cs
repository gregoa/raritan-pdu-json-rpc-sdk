// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from DisplayControl.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.display.DisplayControl_1_0_1 {
  public class DefaultViewChangedEvent_ValObjCodec : Com.Raritan.JsonRpc._event.UserEvent_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.display.DisplayControl_1_0_1.DefaultViewChangedEvent.typeInfo, new DefaultViewChangedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.display.DisplayControl_1_0_1.DefaultViewChangedEvent)vo;
      json["newView"] = inst.newView.Encode();
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.display.DisplayControl_1_0_1.DefaultViewChangedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.display.DisplayControl_1_0_1.DefaultViewChangedEvent();
      } else {
        inst = (Com.Raritan.Idl.display.DisplayControl_1_0_1.DefaultViewChangedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.newView = Com.Raritan.Idl.display.DisplayControl_1_0_1.DefaultViewItem.Decode(json["newView"], agent);
      return inst;
    }

  }
}
