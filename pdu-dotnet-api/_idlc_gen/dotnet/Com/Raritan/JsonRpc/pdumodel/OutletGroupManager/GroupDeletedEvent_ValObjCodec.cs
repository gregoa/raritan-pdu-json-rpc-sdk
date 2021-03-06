// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from OutletGroupManager.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.pdumodel.OutletGroupManager {
  public class GroupDeletedEvent_ValObjCodec : Com.Raritan.JsonRpc._event.UserEvent_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.pdumodel.OutletGroupManager.GroupDeletedEvent.typeInfo, new GroupDeletedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.pdumodel.OutletGroupManager.GroupDeletedEvent)vo;
      json["id"] = inst.id;
      json["uniqueId"] = inst.uniqueId;
      json["settings"] = inst.settings.Encode();
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.pdumodel.OutletGroupManager.GroupDeletedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.pdumodel.OutletGroupManager.GroupDeletedEvent();
      } else {
        inst = (Com.Raritan.Idl.pdumodel.OutletGroupManager.GroupDeletedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.id = (int)json["id"];
      inst.uniqueId = (int)json["uniqueId"];
      inst.settings = Com.Raritan.Idl.pdumodel.OutletGroup.Settings.Decode(json["settings"], agent);
      return inst;
    }

  }
}
