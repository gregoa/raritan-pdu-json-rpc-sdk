// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from ResidualCurrentStateSensor.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {
  public class ResidualCurrentStateSensor : Com.Raritan.Idl.sensors.StateSensor_3_0_1 {

    static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.ResidualCurrentStateSensor:1.0.0", null);

    public ResidualCurrentStateSensor(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public ResidualCurrentStateSensor(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new ResidualCurrentStateSensor StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new ResidualCurrentStateSensor(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int STATE_NORMAL = 0;

    public const int STATE_WARNING = 1;

    public const int STATE_CRITICAL = 2;

    public const int STATE_SELFTEST = 3;

    public const int STATE_FAILURE = 4;

    public enum Events {
      EVT_KEY_SETTINGS_CHANGED,
    }

    public class StartSelfTestResult {
      public int _ret_;
    }

    public StartSelfTestResult startSelfTest() {
      JsonObject _parameters = null;
      var _result = RpcCall("startSelfTest", _parameters);
      var _ret = new StartSelfTestResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest startSelfTest(AsyncRpcResponse<StartSelfTestResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return startSelfTest(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest startSelfTest(AsyncRpcResponse<StartSelfTestResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("startSelfTest", _parameters,
        _result => {
          try {
            var _ret = new StartSelfTestResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
