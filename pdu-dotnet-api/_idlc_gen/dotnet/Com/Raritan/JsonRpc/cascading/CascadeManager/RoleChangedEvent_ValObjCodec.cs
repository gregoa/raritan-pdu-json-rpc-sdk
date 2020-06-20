// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from CascadeManager.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.cascading.CascadeManager {
  public class RoleChangedEvent_ValObjCodec : Com.Raritan.JsonRpc.idl.Event_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.cascading.CascadeManager.RoleChangedEvent.typeInfo, new RoleChangedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.cascading.CascadeManager.RoleChangedEvent)vo;
      json["oldRole"] = (int)inst.oldRole;
      json["newRole"] = (int)inst.newRole;
      json["master"] = inst.master;
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.cascading.CascadeManager.RoleChangedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.cascading.CascadeManager.RoleChangedEvent();
      } else {
        inst = (Com.Raritan.Idl.cascading.CascadeManager.RoleChangedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.oldRole = (Com.Raritan.Idl.cascading.CascadeManager.Role)(int)json["oldRole"];
      inst.newRole = (Com.Raritan.Idl.cascading.CascadeManager.Role)(int)json["newRole"];
      inst.master = (string)json["master"];
      return inst;
    }

  }
}
