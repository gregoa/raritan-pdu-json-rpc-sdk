// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from LhxConfig.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.lhxmodel {
  public class Config : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("lhxmodel.Config:1.0.0", null);

    public Config(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Config(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Config StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Config(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int NO_ERROR = 0;

    public const int ERR_INVALID_PARAMS = 1;

    public enum Events {
      EVT_KEY_COMSETTINGS_CHANGED,
      EVT_KEY_PORTNAME_CHANGED,
    }

    public class ComSettings : ICloneable {
      public object Clone() {
        ComSettings copy = new ComSettings();
        copy.devAddr = this.devAddr;
        copy.lhxAddr = this.lhxAddr;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["devAddr"] = this.devAddr;
        json["lhxAddr"] = this.lhxAddr;
        return json;
      }

      public static ComSettings Decode(LightJson.JsonObject json, Agent agent) {
        ComSettings inst = new ComSettings();
        inst.devAddr = (byte)json["devAddr"];
        inst.lhxAddr = (byte)json["lhxAddr"];
        return inst;
      }

      public byte devAddr = 0;
      public byte lhxAddr = 0;
    }

    public class GetComSettingsResult {
      public Com.Raritan.Idl.lhxmodel.Config.ComSettings _ret_;
    }

    public GetComSettingsResult getComSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getComSettings", _parameters);
      var _ret = new GetComSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.lhxmodel.Config.ComSettings.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getComSettings(AsyncRpcResponse<GetComSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getComSettings(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getComSettings(AsyncRpcResponse<GetComSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getComSettings", _parameters,
        _result => {
          try {
            var _ret = new GetComSettingsResult();
            _ret._ret_ = Com.Raritan.Idl.lhxmodel.Config.ComSettings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetComSettingsResult {
      public int _ret_;
    }

    public SetComSettingsResult setComSettings(Com.Raritan.Idl.lhxmodel.Config.ComSettings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setComSettings", _parameters);
      var _ret = new SetComSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setComSettings(Com.Raritan.Idl.lhxmodel.Config.ComSettings settings, AsyncRpcResponse<SetComSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setComSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setComSettings(Com.Raritan.Idl.lhxmodel.Config.ComSettings settings, AsyncRpcResponse<SetComSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["settings"] = settings.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setComSettings", _parameters,
        _result => {
          try {
            var _ret = new SetComSettingsResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetNameResult {
      public string _ret_;
    }

    public GetNameResult getName() {
      JsonObject _parameters = null;
      var _result = RpcCall("getName", _parameters);
      var _ret = new GetNameResult();
      _ret._ret_ = (string)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest getName(AsyncRpcResponse<GetNameResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getName(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getName(AsyncRpcResponse<GetNameResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getName", _parameters,
        _result => {
          try {
            var _ret = new GetNameResult();
            _ret._ret_ = (string)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetNameResult {
      public int _ret_;
    }

    public SetNameResult setName(string name) {
      var _parameters = new LightJson.JsonObject();
      _parameters["name"] = name;

      var _result = RpcCall("setName", _parameters);
      var _ret = new SetNameResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setName(string name, AsyncRpcResponse<SetNameResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setName(name, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setName(string name, AsyncRpcResponse<SetNameResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["name"] = name;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setName", _parameters,
        _result => {
          try {
            var _ret = new SetNameResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
