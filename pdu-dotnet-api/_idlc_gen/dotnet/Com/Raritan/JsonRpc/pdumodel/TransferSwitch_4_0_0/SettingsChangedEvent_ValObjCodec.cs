// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from TransferSwitch.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.pdumodel.TransferSwitch_4_0_0 {
  public class SettingsChangedEvent_ValObjCodec : Com.Raritan.JsonRpc._event.UserEvent_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.pdumodel.TransferSwitch_4_0_0.SettingsChangedEvent.typeInfo, new SettingsChangedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.pdumodel.TransferSwitch_4_0_0.SettingsChangedEvent)vo;
      json["oldSettings"] = inst.oldSettings.Encode();
      json["newSettings"] = inst.newSettings.Encode();
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.pdumodel.TransferSwitch_4_0_0.SettingsChangedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.pdumodel.TransferSwitch_4_0_0.SettingsChangedEvent();
      } else {
        inst = (Com.Raritan.Idl.pdumodel.TransferSwitch_4_0_0.SettingsChangedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.oldSettings = Com.Raritan.Idl.pdumodel.TransferSwitch_4_0_0.Settings.Decode(json["oldSettings"], agent);
      inst.newSettings = Com.Raritan.Idl.pdumodel.TransferSwitch_4_0_0.Settings.Decode(json["newSettings"], agent);
      return inst;
    }

  }
}
