// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Usb.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.usb {
  public class Usb_1_0_1 : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("usb.Usb:1.0.1", null);

    public Usb_1_0_1(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Usb_1_0_1(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Usb_1_0_1 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Usb_1_0_1(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.hostPortsEnabled = this.hostPortsEnabled;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["hostPortsEnabled"] = this.hostPortsEnabled;
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.hostPortsEnabled = (bool)json["hostPortsEnabled"];
        return inst;
      }

      public bool hostPortsEnabled = false;
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.usb.Usb_1_0_1.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.usb.Usb_1_0_1.Settings.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.usb.Usb_1_0_1.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.usb.Usb_1_0_1.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.usb.Usb_1_0_1.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.usb.Usb_1_0_1.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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

    public class GetDevicesResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.usb.UsbDevice> usbDevices;
    }

    public GetDevicesResult getDevices() {
      JsonObject _parameters = null;
      var _result = RpcCall("getDevices", _parameters);
      var _ret = new GetDevicesResult();
      _ret.usbDevices = new System.Collections.Generic.List<Com.Raritan.Idl.usb.UsbDevice>(_result["usbDevices"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.usb.UsbDevice.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getDevices(AsyncRpcResponse<GetDevicesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getDevices(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getDevices(AsyncRpcResponse<GetDevicesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getDevices", _parameters,
        _result => {
          try {
            var _ret = new GetDevicesResult();
            _ret.usbDevices = new System.Collections.Generic.List<Com.Raritan.Idl.usb.UsbDevice>(_result["usbDevices"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.usb.UsbDevice.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
