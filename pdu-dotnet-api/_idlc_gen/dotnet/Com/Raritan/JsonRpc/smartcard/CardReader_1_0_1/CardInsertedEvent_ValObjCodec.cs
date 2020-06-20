// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from CardReader.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.JsonRpc.smartcard.CardReader_1_0_1 {
  public class CardInsertedEvent_ValObjCodec : Com.Raritan.JsonRpc.smartcard.CardReader_1_0_1.CardEvent_ValObjCodec {

    public static new void Register() {
      ValueObjectCodec.RegisterCodec(Com.Raritan.Idl.smartcard.CardReader_1_0_1.CardInsertedEvent.typeInfo, new CardInsertedEvent_ValObjCodec());
    }

    public override void EncodeValObj(LightJson.JsonObject json, ValueObject vo) {
      base.EncodeValObj(json, vo);
      var inst = (Com.Raritan.Idl.smartcard.CardReader_1_0_1.CardInsertedEvent)vo;
    }

    public override ValueObject DecodeValObj(ValueObject vo, LightJson.JsonObject json, Agent agent) {
      Com.Raritan.Idl.smartcard.CardReader_1_0_1.CardInsertedEvent inst;
      if (vo == null) {
        inst = new Com.Raritan.Idl.smartcard.CardReader_1_0_1.CardInsertedEvent();
      } else {
        inst = (Com.Raritan.Idl.smartcard.CardReader_1_0_1.CardInsertedEvent)vo;
      }
      base.DecodeValObj(vo, json, agent);
      return inst;
    }

  }
}