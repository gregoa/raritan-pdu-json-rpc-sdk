// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Firmware.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.firmware {
  public class FirmwareUpdateFailedEvent_ValObjCodec : Com.Raritan.JsonRpc.firmware.FirmwareUpdateEvent_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.firmware.FirmwareUpdateFailedEvent.typeInfo, new FirmwareUpdateFailedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.firmware.FirmwareUpdateFailedEvent)vo;
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.firmware.FirmwareUpdateFailedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.firmware.FirmwareUpdateFailedEvent();
      } else {
        inst = (Com.Raritan.Idl.firmware.FirmwareUpdateFailedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      return inst;
    }

  }
}
