// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from PeripheralDevicePackage.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.peripheral {
  public class DoorHandleControllerPackage_1_0_1 : Com.Raritan.Idl.peripheral.Package_1_0_1 {

    static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DoorHandleControllerPackage:1.0.1", null);

    public DoorHandleControllerPackage_1_0_1(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public DoorHandleControllerPackage_1_0_1(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new DoorHandleControllerPackage_1_0_1 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new DoorHandleControllerPackage_1_0_1(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int SUCCESS = 0;

    public const int ERR_NOT_SUPPORTED = 1;

    public const int ERR_OPERATION_FAILED = 2;

    public class GetSupportedHandleTypesResult {
      public System.Collections.Generic.IEnumerable<string> _ret_;
    }

    public GetSupportedHandleTypesResult getSupportedHandleTypes() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSupportedHandleTypes", _parameters);
      var _ret = new GetSupportedHandleTypesResult();
      _ret._ret_ = new System.Collections.Generic.List<string>(_result["_ret_"].AsJsonArray.Select(
        _value => (string)_value));
      return _ret;
    }

    public AsyncRequest getSupportedHandleTypes(AsyncRpcResponse<GetSupportedHandleTypesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getSupportedHandleTypes(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getSupportedHandleTypes(AsyncRpcResponse<GetSupportedHandleTypesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getSupportedHandleTypes", _parameters,
        _result => {
          try {
            var _ret = new GetSupportedHandleTypesResult();
            _ret._ret_ = new System.Collections.Generic.List<string>(_result["_ret_"].AsJsonArray.Select(
              _value => (string)_value));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetHandleTypeResult {
      public string _ret_;
    }

    public GetHandleTypeResult getHandleType(int channel) {
      var _parameters = new LightJson.JsonObject();
      _parameters["channel"] = channel;

      var _result = RpcCall("getHandleType", _parameters);
      var _ret = new GetHandleTypeResult();
      _ret._ret_ = (string)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest getHandleType(int channel, AsyncRpcResponse<GetHandleTypeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getHandleType(channel, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getHandleType(int channel, AsyncRpcResponse<GetHandleTypeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["channel"] = channel;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("getHandleType", _parameters,
        _result => {
          try {
            var _ret = new GetHandleTypeResult();
            _ret._ret_ = (string)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetHandleTypeResult {
      public int _ret_;
    }

    public SetHandleTypeResult setHandleType(int channel, string handleType) {
      var _parameters = new LightJson.JsonObject();
      _parameters["channel"] = channel;
      _parameters["handleType"] = handleType;

      var _result = RpcCall("setHandleType", _parameters);
      var _ret = new SetHandleTypeResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setHandleType(int channel, string handleType, AsyncRpcResponse<SetHandleTypeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setHandleType(channel, handleType, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setHandleType(int channel, string handleType, AsyncRpcResponse<SetHandleTypeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["channel"] = channel;
        _parameters["handleType"] = handleType;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setHandleType", _parameters,
        _result => {
          try {
            var _ret = new SetHandleTypeResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}