// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from PortDispatcher.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.serial {
  public class PortDispatcher_1_0_1 : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("serial.PortDispatcher:1.0.1", null);

    public PortDispatcher_1_0_1(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public PortDispatcher_1_0_1(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new PortDispatcher_1_0_1 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new PortDispatcher_1_0_1(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class GetPortsResult {
      public System.Collections.Generic.IDictionary<string, Com.Raritan.Idl.serial.SerialPort_1_0_1> _ret_;
    }

    public GetPortsResult getPorts() {
      JsonObject _parameters = null;
      var _result = RpcCall("getPorts", _parameters);
      var _ret = new GetPortsResult();
      _ret._ret_ = DictionaryHelper.Create(_result["_ret_"].AsJsonArray.Select(
        _value => new System.Collections.Generic.KeyValuePair<string, Com.Raritan.Idl.serial.SerialPort_1_0_1>(_value["key"], Com.Raritan.Idl.serial.SerialPort_1_0_1.StaticCast(ObjectProxy.Decode(_value["value"], agent)))));
      return _ret;
    }

    public AsyncRequest getPorts(AsyncRpcResponse<GetPortsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getPorts(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getPorts(AsyncRpcResponse<GetPortsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getPorts", _parameters,
        _result => {
          try {
            var _ret = new GetPortsResult();
            _ret._ret_ = DictionaryHelper.Create(_result["_ret_"].AsJsonArray.Select(
              _value => new System.Collections.Generic.KeyValuePair<string, Com.Raritan.Idl.serial.SerialPort_1_0_1>(_value["key"], Com.Raritan.Idl.serial.SerialPort_1_0_1.StaticCast(ObjectProxy.Decode(_value["value"], agent)))));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
