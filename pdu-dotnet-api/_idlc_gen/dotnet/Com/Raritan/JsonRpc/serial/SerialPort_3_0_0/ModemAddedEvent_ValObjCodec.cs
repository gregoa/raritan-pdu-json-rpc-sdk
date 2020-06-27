// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from SerialPort.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.serial.SerialPort_3_0_0 {
  public class ModemAddedEvent_ValObjCodec : Com.Raritan.JsonRpc.serial.SerialPort_3_0_0.ModemEvent_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.serial.SerialPort_3_0_0.ModemAddedEvent.typeInfo, new ModemAddedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.serial.SerialPort_3_0_0.ModemAddedEvent)vo;
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.serial.SerialPort_3_0_0.ModemAddedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.serial.SerialPort_3_0_0.ModemAddedEvent();
      } else {
        inst = (Com.Raritan.Idl.serial.SerialPort_3_0_0.ModemAddedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      return inst;
    }

  }
}
