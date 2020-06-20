// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from ModbusGatewayMgr.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.modbus {
  public class GatewayMgr : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("modbus.GatewayMgr:1.0.0", null);

    public GatewayMgr(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public GatewayMgr(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new GatewayMgr StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new GatewayMgr(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int NO_ERROR = 0;

    public const int ERR_INVALID_PARAMS = 1;

    public class RtuSettings : ICloneable {
      public object Clone() {
        RtuSettings copy = new RtuSettings();
        copy.defaultAddr = this.defaultAddr;
        copy.speed = this.speed;
        copy.parity = this.parity;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["defaultAddr"] = this.defaultAddr;
        json["speed"] = this.speed;
        json["parity"] = this.parity;
        return json;
      }

      public static RtuSettings Decode(LightJson.JsonObject json, Agent agent) {
        RtuSettings inst = new RtuSettings();
        inst.defaultAddr = (byte)json["defaultAddr"];
        inst.speed = (int)json["speed"];
        inst.parity = (byte)json["parity"];
        return inst;
      }

      public byte defaultAddr = 0;
      public int speed = 0;
      public byte parity = 0;
    }

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.rtu = this.rtu;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["rtu"] = this.rtu.Encode();
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.rtu = Com.Raritan.Idl.modbus.GatewayMgr.RtuSettings.Decode(json["rtu"], agent);
        return inst;
      }

      public Com.Raritan.Idl.modbus.GatewayMgr.RtuSettings rtu = new Com.Raritan.Idl.modbus.GatewayMgr.RtuSettings();
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.modbus.GatewayMgr.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.modbus.GatewayMgr.Settings.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.modbus.GatewayMgr.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.modbus.GatewayMgr.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.modbus.GatewayMgr.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.modbus.GatewayMgr.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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
