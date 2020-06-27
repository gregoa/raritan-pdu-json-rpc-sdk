// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from CardReaderManager.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.smartcard.CardReaderManager {
  public class CardReaderEvent_ValObjCodec : Com.Raritan.JsonRpc.idl.Event_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.smartcard.CardReaderManager.CardReaderEvent.typeInfo, new CardReaderEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.smartcard.CardReaderManager.CardReaderEvent)vo;
      json["cardReader"] = inst.cardReader != null ? inst.cardReader.Encode() : JsonValue.Null;
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.smartcard.CardReaderManager.CardReaderEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.smartcard.CardReaderManager.CardReaderEvent();
      } else {
        inst = (Com.Raritan.Idl.smartcard.CardReaderManager.CardReaderEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      inst.cardReader = Com.Raritan.Idl.smartcard.CardReader.StaticCast(ObjectProxy.Decode(json["cardReader"], agent));
      return inst;
    }

  }
}
