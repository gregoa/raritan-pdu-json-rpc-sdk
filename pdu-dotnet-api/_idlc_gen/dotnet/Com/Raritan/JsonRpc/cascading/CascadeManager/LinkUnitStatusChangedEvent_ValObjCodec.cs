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
  public class LinkUnitStatusChangedEvent_ValObjCodec : Com.Raritan.JsonRpc.idl.Event_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.cascading.CascadeManager.LinkUnitStatusChangedEvent.typeInfo, new LinkUnitStatusChangedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.cascading.CascadeManager.LinkUnitStatusChangedEvent)vo;
      json["linkId"] = inst.linkId;
      json["host"] = inst.host;
      json["oldStatus"] = (int)inst.oldStatus;
      json["newStatus"] = (int)inst.newStatus;
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.cascading.CascadeManager.LinkUnitStatusChangedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.cascading.CascadeManager.LinkUnitStatusChangedEvent();
      } else {
        inst = (Com.Raritan.Idl.cascading.CascadeManager.LinkUnitStatusChangedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.linkId = (int)json["linkId"];
      inst.host = (string)json["host"];
      inst.oldStatus = (Com.Raritan.Idl.cascading.CascadeManager.LinkUnitStatus)(int)json["oldStatus"];
      inst.newStatus = (Com.Raritan.Idl.cascading.CascadeManager.LinkUnitStatus)(int)json["newStatus"];
      return inst;
    }

  }
}
