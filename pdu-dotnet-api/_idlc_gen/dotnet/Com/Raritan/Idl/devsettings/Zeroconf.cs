// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Zeroconf.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.devsettings {
  public class Zeroconf : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("devsettings.Zeroconf:1.0.0", null);

    public Zeroconf(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Zeroconf(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Zeroconf StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Zeroconf(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.mdnsEnabled = this.mdnsEnabled;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["mdnsEnabled"] = this.mdnsEnabled;
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.mdnsEnabled = (bool)json["mdnsEnabled"];
        return inst;
      }

      public bool mdnsEnabled = false;
    }

    public class SettingsChangedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("devsettings.Zeroconf.SettingsChangedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public Com.Raritan.Idl.devsettings.Zeroconf.Settings oldSettings = new Com.Raritan.Idl.devsettings.Zeroconf.Settings();
      public Com.Raritan.Idl.devsettings.Zeroconf.Settings newSettings = new Com.Raritan.Idl.devsettings.Zeroconf.Settings();
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.devsettings.Zeroconf.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.devsettings.Zeroconf.Settings.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.devsettings.Zeroconf.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.devsettings.Zeroconf.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.devsettings.Zeroconf.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.devsettings.Zeroconf.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
