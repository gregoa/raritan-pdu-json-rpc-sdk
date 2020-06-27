// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from OverCurrentProtectorTripSensor.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.pdumodel.OverCurrentProtectorTripSensor {
  public class TripStateChangedEvent_ValObjCodec : Com.Raritan.JsonRpc.sensors.StateSensor_4_0_2.StateChangedEvent_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.pdumodel.OverCurrentProtectorTripSensor.TripStateChangedEvent.typeInfo, new TripStateChangedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.pdumodel.OverCurrentProtectorTripSensor.TripStateChangedEvent)vo;
      json["tripCause"] = inst.tripCause != null ? inst.tripCause.Encode() : JsonValue.Null;
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.pdumodel.OverCurrentProtectorTripSensor.TripStateChangedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.pdumodel.OverCurrentProtectorTripSensor.TripStateChangedEvent();
      } else {
        inst = (Com.Raritan.Idl.pdumodel.OverCurrentProtectorTripSensor.TripStateChangedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.tripCause = Com.Raritan.Idl.pdumodel.Outlet_2_1_1.StaticCast(ObjectProxy.Decode(json["tripCause"], agent));
      return inst;
    }

  }
}