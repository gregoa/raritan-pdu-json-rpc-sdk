// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Production.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.production {
  public class Production : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("production.Production:1.0.0", null);

    public Production(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Production(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Production StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Production(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class EnterFactoryConfigModeResult {
      public int _ret_;
    }

    public EnterFactoryConfigModeResult enterFactoryConfigMode(string password) {
      var _parameters = new LightJson.JsonObject();
      _parameters["password"] = password;

      var _result = RpcCall("enterFactoryConfigMode", _parameters);
      var _ret = new EnterFactoryConfigModeResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest enterFactoryConfigMode(string password, AsyncRpcResponse<EnterFactoryConfigModeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return enterFactoryConfigMode(password, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest enterFactoryConfigMode(string password, AsyncRpcResponse<EnterFactoryConfigModeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["password"] = password;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("enterFactoryConfigMode", _parameters,
        _result => {
          try {
            var _ret = new EnterFactoryConfigModeResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class LeaveFactoryConfigModeResult {
    }

    public LeaveFactoryConfigModeResult leaveFactoryConfigMode() {
      JsonObject _parameters = null;
      var _result = RpcCall("leaveFactoryConfigMode", _parameters);
      var _ret = new LeaveFactoryConfigModeResult();
      return _ret;
    }

    public AsyncRequest leaveFactoryConfigMode(AsyncRpcResponse<LeaveFactoryConfigModeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return leaveFactoryConfigMode(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest leaveFactoryConfigMode(AsyncRpcResponse<LeaveFactoryConfigModeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("leaveFactoryConfigMode", _parameters,
        _result => {
          try {
            var _ret = new LeaveFactoryConfigModeResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class IsFactoryConfigModeEnabledResult {
      public bool _ret_;
    }

    public IsFactoryConfigModeEnabledResult isFactoryConfigModeEnabled() {
      JsonObject _parameters = null;
      var _result = RpcCall("isFactoryConfigModeEnabled", _parameters);
      var _ret = new IsFactoryConfigModeEnabledResult();
      _ret._ret_ = (bool)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest isFactoryConfigModeEnabled(AsyncRpcResponse<IsFactoryConfigModeEnabledResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return isFactoryConfigModeEnabled(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest isFactoryConfigModeEnabled(AsyncRpcResponse<IsFactoryConfigModeEnabledResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("isFactoryConfigModeEnabled", _parameters,
        _result => {
          try {
            var _ret = new IsFactoryConfigModeEnabledResult();
            _ret._ret_ = (bool)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}