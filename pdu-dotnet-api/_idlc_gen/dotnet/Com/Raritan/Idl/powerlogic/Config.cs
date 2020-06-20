// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from PowerLogicConfig.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.powerlogic {
  public class Config : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("powerlogic.Config:1.0.0", null);

    public Config(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Config(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Config StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Config(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int NO_ERROR = 0;

    public const int ERR_INVALID_PARAMS = 1;

    public enum Events {
      EVT_KEY_SETTINGS_CHANGED,
    }

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.name = this.name;
        copy.slaveAddr = this.slaveAddr;
        copy.baud = this.baud;
        copy.parity = this.parity;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["name"] = this.name;
        json["slaveAddr"] = this.slaveAddr;
        json["baud"] = this.baud;
        json["parity"] = this.parity;
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.name = (string)json["name"];
        inst.slaveAddr = (byte)json["slaveAddr"];
        inst.baud = (int)json["baud"];
        inst.parity = (byte)json["parity"];
        return inst;
      }

      public string name = "";
      public byte slaveAddr = 0;
      public int baud = 0;
      public byte parity = 0;
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.powerlogic.Config.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.powerlogic.Config.Settings.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getSettings(AsyncRpcResponse<GetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getSettings(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getSettings(AsyncRpcResponse<GetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getSettings", _parameters,
        _result => {
          try {
            var _ret = new GetSettingsResult();
            _ret._ret_ = Com.Raritan.Idl.powerlogic.Config.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.powerlogic.Config.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.powerlogic.Config.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.powerlogic.Config.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["settings"] = settings.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setSettings", _parameters,
        _result => {
          try {
            var _ret = new SetSettingsResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}