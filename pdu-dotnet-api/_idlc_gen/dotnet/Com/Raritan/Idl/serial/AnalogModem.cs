// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from AnalogModem.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.serial {
  public class AnalogModem : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("serial.AnalogModem:1.0.0", null);

    public AnalogModem(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public AnalogModem(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new AnalogModem StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new AnalogModem(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int SUCCESS = 0;

    public const int ERR_INVALID_VALUE = 1;

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.dialInEnabled = this.dialInEnabled;
        copy.ringsUntilAnswer = this.ringsUntilAnswer;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["dialInEnabled"] = this.dialInEnabled;
        json["ringsUntilAnswer"] = this.ringsUntilAnswer;
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.dialInEnabled = (bool)json["dialInEnabled"];
        inst.ringsUntilAnswer = (int)json["ringsUntilAnswer"];
        return inst;
      }

      public bool dialInEnabled = false;
      public int ringsUntilAnswer = 0;
    }

    public class DialInEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("serial.AnalogModem.DialInEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public string number = "";
    }

    public class CallReceivedEvent : Com.Raritan.Idl.serial.AnalogModem.DialInEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("serial.AnalogModem.CallReceivedEvent:1.0.0", Com.Raritan.Idl.serial.AnalogModem.DialInEvent.typeInfo);

    }

    public class CallEndedEvent : Com.Raritan.Idl.serial.AnalogModem.DialInEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("serial.AnalogModem.CallEndedEvent:1.0.0", Com.Raritan.Idl.serial.AnalogModem.DialInEvent.typeInfo);

      public bool disconnectedRemotely = false;
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.serial.AnalogModem.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.serial.AnalogModem.Settings.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.serial.AnalogModem.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.serial.AnalogModem.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.serial.AnalogModem.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.serial.AnalogModem.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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
