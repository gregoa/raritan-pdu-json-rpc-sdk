// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from OverCurrentProtectors.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {
  public class OverCurrentProtectors : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.OverCurrentProtectors:1.0.0", null);

    public OverCurrentProtectors(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public OverCurrentProtectors(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new OverCurrentProtectors StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new OverCurrentProtectors(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class Info : ICloneable {
      public object Clone() {
        Info copy = new Info();
        copy.numberOfOCPs = this.numberOfOCPs;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["numberOfOCPs"] = this.numberOfOCPs;
        return json;
      }

      public static Info Decode(LightJson.JsonObject json, Agent agent) {
        Info inst = new Info();
        inst.numberOfOCPs = (int)json["numberOfOCPs"];
        return inst;
      }

      public int numberOfOCPs = 0;
    }

    public class GetInfoResult {
      public Com.Raritan.Idl.pdumodel.OverCurrentProtectors.Info _ret_;
    }

    public GetInfoResult getInfo() {
      JsonObject _parameters = null;
      var _result = RpcCall("getInfo", _parameters);
      var _ret = new GetInfoResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.OverCurrentProtectors.Info.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getInfo(AsyncRpcResponse<GetInfoResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getInfo(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getInfo(AsyncRpcResponse<GetInfoResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getInfo", _parameters,
        _result => {
          try {
            var _ret = new GetInfoResult();
            _ret._ret_ = Com.Raritan.Idl.pdumodel.OverCurrentProtectors.Info.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
