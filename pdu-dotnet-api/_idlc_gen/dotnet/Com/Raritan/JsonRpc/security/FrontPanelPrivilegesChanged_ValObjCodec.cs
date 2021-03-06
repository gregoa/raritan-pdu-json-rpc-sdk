// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Security.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.security {
  public class FrontPanelPrivilegesChanged_ValObjCodec : Com.Raritan.JsonRpc._event.UserEvent_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.security.FrontPanelPrivilegesChanged.typeInfo, new FrontPanelPrivilegesChanged_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.security.FrontPanelPrivilegesChanged)vo;
      json["oldPrivileges"] = new JsonArray(inst.oldPrivileges.Select(
        _value => (JsonValue)(_value)));
      json["newPrivileges"] = new JsonArray(inst.newPrivileges.Select(
        _value => (JsonValue)(_value)));
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.security.FrontPanelPrivilegesChanged inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.security.FrontPanelPrivilegesChanged();
      } else {
        inst = (Com.Raritan.Idl.security.FrontPanelPrivilegesChanged)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.oldPrivileges = new System.Collections.Generic.List<string>(json["oldPrivileges"].AsJsonArray.Select(
        _value => (string)_value));
      inst.newPrivileges = new System.Collections.Generic.List<string>(json["newPrivileges"].AsJsonArray.Select(
        _value => (string)_value));
      return inst;
    }

  }
}
