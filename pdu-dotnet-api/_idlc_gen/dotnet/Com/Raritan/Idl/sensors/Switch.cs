// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Switch.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.sensors {
  public class Switch : Com.Raritan.Idl.sensors.StateSensor_3_0_1 {

    static public readonly new TypeInfo typeInfo = new TypeInfo("sensors.Switch:1.0.0", null);

    public Switch(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Switch(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Switch StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Switch(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int ERR_INVALID_PARAMETER = 1;

    public const int ERR_NOT_AVAILABLE = 2;

    public class SetStateResult {
      public int _ret_;
    }

    public SetStateResult setState(int newState) {
      var _parameters = new LightJson.JsonObject();
      _parameters["newState"] = newState;

      var _result = RpcCall("setState", _parameters);
      var _ret = new SetStateResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setState(int newState, AsyncRpcResponse<SetStateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setState(newState, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setState(int newState, AsyncRpcResponse<SetStateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["newState"] = newState;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setState", _parameters,
        _result => {
          try {
            var _ret = new SetStateResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}