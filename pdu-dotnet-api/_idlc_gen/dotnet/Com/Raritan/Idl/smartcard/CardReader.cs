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

namespace Com.Raritan.Idl.smartcard {
  public class CardReader : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("smartcard.CardReader:1.0.0", null);

    public CardReader(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public CardReader(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new CardReader StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new CardReader(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int NO_ERROR = 0;

    public const int ERR_SLOT_EMPTY = 1;

    public class MetaData : ICloneable {
      public object Clone() {
        MetaData copy = new MetaData();
        copy.manufacturer = this.manufacturer;
        copy.product = this.product;
        copy.serialNumber = this.serialNumber;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["manufacturer"] = this.manufacturer;
        json["product"] = this.product;
        json["serialNumber"] = this.serialNumber;
        return json;
      }

      public static MetaData Decode(LightJson.JsonObject json, Agent agent) {
        MetaData inst = new MetaData();
        inst.manufacturer = (string)json["manufacturer"];
        inst.product = (string)json["product"];
        inst.serialNumber = (string)json["serialNumber"];
        return inst;
      }

      public string manufacturer = "";
      public string product = "";
      public string serialNumber = "";
    }

    public class CardInformation : ICloneable {
      public object Clone() {
        CardInformation copy = new CardInformation();
        copy.type = this.type;
        copy.uid = this.uid;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["type"] = this.type;
        json["uid"] = this.uid;
        return json;
      }

      public static CardInformation Decode(LightJson.JsonObject json, Agent agent) {
        CardInformation inst = new CardInformation();
        inst.type = (string)json["type"];
        inst.uid = (string)json["uid"];
        return inst;
      }

      public string type = "";
      public string uid = "";
    }

    public class CardEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("smartcard.CardReader.CardEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public Com.Raritan.Idl.smartcard.CardReader.CardInformation cardInfo = new Com.Raritan.Idl.smartcard.CardReader.CardInformation();
    }

    public class CardInsertedEvent : Com.Raritan.Idl.smartcard.CardReader.CardEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("smartcard.CardReader.CardInsertedEvent:1.0.0", Com.Raritan.Idl.smartcard.CardReader.CardEvent.typeInfo);

    }

    public class CardRemovedEvent : Com.Raritan.Idl.smartcard.CardReader.CardEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("smartcard.CardReader.CardRemovedEvent:1.0.0", Com.Raritan.Idl.smartcard.CardReader.CardEvent.typeInfo);

    }

    public class GetMetaDataResult {
      public Com.Raritan.Idl.smartcard.CardReader.MetaData _ret_;
    }

    public GetMetaDataResult getMetaData() {
      JsonObject _parameters = null;
      var _result = RpcCall("getMetaData", _parameters);
      var _ret = new GetMetaDataResult();
      _ret._ret_ = Com.Raritan.Idl.smartcard.CardReader.MetaData.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getMetaData(AsyncRpcResponse<GetMetaDataResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getMetaData(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getMetaData(AsyncRpcResponse<GetMetaDataResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getMetaData", _parameters,
        _result => {
          try {
            var _ret = new GetMetaDataResult();
            _ret._ret_ = Com.Raritan.Idl.smartcard.CardReader.MetaData.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetCardInformationResult {
      public int _ret_;
      public Com.Raritan.Idl.smartcard.CardReader.CardInformation cardInfo;
    }

    public GetCardInformationResult getCardInformation() {
      JsonObject _parameters = null;
      var _result = RpcCall("getCardInformation", _parameters);
      var _ret = new GetCardInformationResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.cardInfo = Com.Raritan.Idl.smartcard.CardReader.CardInformation.Decode(_result["cardInfo"], agent);
      return _ret;
    }

    public AsyncRequest getCardInformation(AsyncRpcResponse<GetCardInformationResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getCardInformation(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getCardInformation(AsyncRpcResponse<GetCardInformationResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getCardInformation", _parameters,
        _result => {
          try {
            var _ret = new GetCardInformationResult();
            _ret._ret_ = (int)_result["_ret_"];
            _ret.cardInfo = Com.Raritan.Idl.smartcard.CardReader.CardInformation.Decode(_result["cardInfo"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
