// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Firmware.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.firmware {
  public class Firmware_2_0_0 : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("firmware.Firmware:2.0.0", null);

    public Firmware_2_0_0(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Firmware_2_0_0(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Firmware_2_0_0 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Firmware_2_0_0(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class RebootResult {
    }

    public RebootResult reboot() {
      JsonObject _parameters = null;
      var _result = RpcCall("reboot", _parameters);
      var _ret = new RebootResult();
      return _ret;
    }

    public AsyncRequest reboot(AsyncRpcResponse<RebootResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return reboot(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest reboot(AsyncRpcResponse<RebootResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("reboot", _parameters,
        _result => {
          try {
            var _ret = new RebootResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class FactoryResetResult {
    }

    public FactoryResetResult factoryReset() {
      JsonObject _parameters = null;
      var _result = RpcCall("factoryReset", _parameters);
      var _ret = new FactoryResetResult();
      return _ret;
    }

    public AsyncRequest factoryReset(AsyncRpcResponse<FactoryResetResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return factoryReset(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest factoryReset(AsyncRpcResponse<FactoryResetResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("factoryReset", _parameters,
        _result => {
          try {
            var _ret = new FactoryResetResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetVersionResult {
      public string _ret_;
    }

    public GetVersionResult getVersion() {
      JsonObject _parameters = null;
      var _result = RpcCall("getVersion", _parameters);
      var _ret = new GetVersionResult();
      _ret._ret_ = (string)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest getVersion(AsyncRpcResponse<GetVersionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getVersion(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getVersion(AsyncRpcResponse<GetVersionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getVersion", _parameters,
        _result => {
          try {
            var _ret = new GetVersionResult();
            _ret._ret_ = (string)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetUpdateHistoryResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.firmware.UpdateHistoryEntry> _ret_;
    }

    public GetUpdateHistoryResult getUpdateHistory() {
      JsonObject _parameters = null;
      var _result = RpcCall("getUpdateHistory", _parameters);
      var _ret = new GetUpdateHistoryResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.firmware.UpdateHistoryEntry>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.firmware.UpdateHistoryEntry.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getUpdateHistory(AsyncRpcResponse<GetUpdateHistoryResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getUpdateHistory(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getUpdateHistory(AsyncRpcResponse<GetUpdateHistoryResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getUpdateHistory", _parameters,
        _result => {
          try {
            var _ret = new GetUpdateHistoryResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.firmware.UpdateHistoryEntry>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.firmware.UpdateHistoryEntry.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetImageStatusResult {
      public Com.Raritan.Idl.firmware.ImageStatus _ret_;
    }

    public GetImageStatusResult getImageStatus() {
      JsonObject _parameters = null;
      var _result = RpcCall("getImageStatus", _parameters);
      var _ret = new GetImageStatusResult();
      _ret._ret_ = Com.Raritan.Idl.firmware.ImageStatus.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getImageStatus(AsyncRpcResponse<GetImageStatusResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getImageStatus(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getImageStatus(AsyncRpcResponse<GetImageStatusResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getImageStatus", _parameters,
        _result => {
          try {
            var _ret = new GetImageStatusResult();
            _ret._ret_ = Com.Raritan.Idl.firmware.ImageStatus.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class DiscardImageResult {
    }

    public DiscardImageResult discardImage() {
      JsonObject _parameters = null;
      var _result = RpcCall("discardImage", _parameters);
      var _ret = new DiscardImageResult();
      return _ret;
    }

    public AsyncRequest discardImage(AsyncRpcResponse<DiscardImageResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return discardImage(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest discardImage(AsyncRpcResponse<DiscardImageResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("discardImage", _parameters,
        _result => {
          try {
            var _ret = new DiscardImageResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetImageInfoResult {
      public bool _ret_;
      public Com.Raritan.Idl.firmware.ImageInfo_1_0_1 info;
    }

    public GetImageInfoResult getImageInfo() {
      JsonObject _parameters = null;
      var _result = RpcCall("getImageInfo", _parameters);
      var _ret = new GetImageInfoResult();
      _ret._ret_ = (bool)_result["_ret_"];
      _ret.info = Com.Raritan.Idl.firmware.ImageInfo_1_0_1.Decode(_result["info"], agent);
      return _ret;
    }

    public AsyncRequest getImageInfo(AsyncRpcResponse<GetImageInfoResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getImageInfo(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getImageInfo(AsyncRpcResponse<GetImageInfoResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getImageInfo", _parameters,
        _result => {
          try {
            var _ret = new GetImageInfoResult();
            _ret._ret_ = (bool)_result["_ret_"];
            _ret.info = Com.Raritan.Idl.firmware.ImageInfo_1_0_1.Decode(_result["info"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class StartUpdateResult {
    }

    public StartUpdateResult startUpdate(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.firmware.UpdateFlags> flags) {
      var _parameters = new LightJson.JsonObject();
      _parameters["flags"] = new JsonArray(flags.Select(
        _value => (JsonValue)((int)_value)));

      var _result = RpcCall("startUpdate", _parameters);
      var _ret = new StartUpdateResult();
      return _ret;
    }

    public AsyncRequest startUpdate(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.firmware.UpdateFlags> flags, AsyncRpcResponse<StartUpdateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return startUpdate(flags, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest startUpdate(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.firmware.UpdateFlags> flags, AsyncRpcResponse<StartUpdateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["flags"] = new JsonArray(flags.Select(
          _value => (JsonValue)((int)_value)));
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("startUpdate", _parameters,
        _result => {
          try {
            var _ret = new StartUpdateResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
