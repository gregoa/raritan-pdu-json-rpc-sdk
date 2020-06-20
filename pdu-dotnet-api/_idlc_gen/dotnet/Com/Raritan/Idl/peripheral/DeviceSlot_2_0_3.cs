// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from PeripheralDeviceSlot.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.peripheral {
  public class DeviceSlot_2_0_3 : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DeviceSlot:2.0.3", null);

    public DeviceSlot_2_0_3(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public DeviceSlot_2_0_3(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new DeviceSlot_2_0_3 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new DeviceSlot_2_0_3(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int ERR_INVALID_PARAMS = 1;

    public const int ERR_NOT_SUPPORTED = 2;

    public const int CHANNEL_INVALID = -1;

    public class Location : ICloneable {
      public object Clone() {
        Location copy = new Location();
        copy.x = this.x;
        copy.y = this.y;
        copy.z = this.z;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["x"] = this.x;
        json["y"] = this.y;
        json["z"] = this.z;
        return json;
      }

      public static Location Decode(LightJson.JsonObject json, Agent agent) {
        Location inst = new Location();
        inst.x = (string)json["x"];
        inst.y = (string)json["y"];
        inst.z = (string)json["z"];
        return inst;
      }

      public string x = "";
      public string y = "";
      public string z = "";
    }

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.name = this.name;
        copy.description = this.description;
        copy.location = this.location;
        copy.useDefaultThresholds = this.useDefaultThresholds;
        copy.properties = this.properties;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["name"] = this.name;
        json["description"] = this.description;
        json["location"] = this.location.Encode();
        json["useDefaultThresholds"] = this.useDefaultThresholds;
        json["properties"] = new JsonArray(this.properties.Select(_entry => (JsonValue) new JsonObject(new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, LightJson.JsonValue>> {
          new System.Collections.Generic.KeyValuePair<string, JsonValue>("key", _entry.Key),
          new System.Collections.Generic.KeyValuePair<string, JsonValue>("value", _entry.Value)
        })));
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.name = (string)json["name"];
        inst.description = (string)json["description"];
        inst.location = Com.Raritan.Idl.peripheral.DeviceSlot_2_0_3.Location.Decode(json["location"], agent);
        inst.useDefaultThresholds = (bool)json["useDefaultThresholds"];
        inst.properties = DictionaryHelper.Create(json["properties"].AsJsonArray.Select(
          _value => new System.Collections.Generic.KeyValuePair<string, string>(_value["key"], (string)_value["value"])));
        return inst;
      }

      public string name = "";
      public string description = "";
      public Com.Raritan.Idl.peripheral.DeviceSlot_2_0_3.Location location = new Com.Raritan.Idl.peripheral.DeviceSlot_2_0_3.Location();
      public bool useDefaultThresholds = false;
      public System.Collections.Generic.IDictionary<string, string> properties = new System.Collections.Generic.Dictionary<string, string>();
    }

    public class DeviceChangedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DeviceSlot_2_0_3.DeviceChangedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public Com.Raritan.Idl.peripheral.Device_3_0_2 oldDevice = new Com.Raritan.Idl.peripheral.Device_3_0_2();
      public Com.Raritan.Idl.peripheral.Device_3_0_2 newDevice = new Com.Raritan.Idl.peripheral.Device_3_0_2();
    }

    public class SettingsChangedEvent : Com.Raritan.Idl._event.UserEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DeviceSlot_2_0_3.SettingsChangedEvent:1.0.0", Com.Raritan.Idl._event.UserEvent.typeInfo);

      public Com.Raritan.Idl.peripheral.DeviceSlot_2_0_3.Settings oldSettings = new Com.Raritan.Idl.peripheral.DeviceSlot_2_0_3.Settings();
      public Com.Raritan.Idl.peripheral.DeviceSlot_2_0_3.Settings newSettings = new Com.Raritan.Idl.peripheral.DeviceSlot_2_0_3.Settings();
    }

    public class GetDeviceResult {
      public Com.Raritan.Idl.peripheral.Device_3_0_2 _ret_;
    }

    public GetDeviceResult getDevice() {
      JsonObject _parameters = null;
      var _result = RpcCall("getDevice", _parameters);
      var _ret = new GetDeviceResult();
      _ret._ret_ = ((Com.Raritan.Idl.peripheral.Device_3_0_2)ValueObjectCodec.DecodeAs(_result["_ret_"], agent, Com.Raritan.Idl.peripheral.Device_3_0_2.typeInfo));
      return _ret;
    }

    public AsyncRequest getDevice(AsyncRpcResponse<GetDeviceResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getDevice(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getDevice(AsyncRpcResponse<GetDeviceResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getDevice", _parameters,
        _result => {
          try {
            var _ret = new GetDeviceResult();
            _ret._ret_ = ((Com.Raritan.Idl.peripheral.Device_3_0_2)ValueObjectCodec.DecodeAs(_result["_ret_"], agent, Com.Raritan.Idl.peripheral.Device_3_0_2.typeInfo));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class AssignResult {
      public int _ret_;
    }

    public AssignResult assign(Com.Raritan.Idl.peripheral.DeviceID_4_0_0 devid) {
      var _parameters = new LightJson.JsonObject();
      _parameters["devid"] = devid.Encode();

      var _result = RpcCall("assign", _parameters);
      var _ret = new AssignResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest assign(Com.Raritan.Idl.peripheral.DeviceID_4_0_0 devid, AsyncRpcResponse<AssignResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return assign(devid, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest assign(Com.Raritan.Idl.peripheral.DeviceID_4_0_0 devid, AsyncRpcResponse<AssignResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["devid"] = devid.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("assign", _parameters,
        _result => {
          try {
            var _ret = new AssignResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class AssignAddressResult {
      public int _ret_;
    }

    public AssignAddressResult assignAddress(string packageClass, Com.Raritan.Idl.peripheral.Address_4_0_0 address) {
      var _parameters = new LightJson.JsonObject();
      _parameters["packageClass"] = packageClass;
      _parameters["address"] = address.Encode();

      var _result = RpcCall("assignAddress", _parameters);
      var _ret = new AssignAddressResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest assignAddress(string packageClass, Com.Raritan.Idl.peripheral.Address_4_0_0 address, AsyncRpcResponse<AssignAddressResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return assignAddress(packageClass, address, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest assignAddress(string packageClass, Com.Raritan.Idl.peripheral.Address_4_0_0 address, AsyncRpcResponse<AssignAddressResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["packageClass"] = packageClass;
        _parameters["address"] = address.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("assignAddress", _parameters,
        _result => {
          try {
            var _ret = new AssignAddressResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class UnassignResult {
      public int _ret_;
    }

    public UnassignResult unassign() {
      JsonObject _parameters = null;
      var _result = RpcCall("unassign", _parameters);
      var _ret = new UnassignResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest unassign(AsyncRpcResponse<UnassignResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return unassign(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest unassign(AsyncRpcResponse<UnassignResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("unassign", _parameters,
        _result => {
          try {
            var _ret = new UnassignResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.peripheral.DeviceSlot_2_0_3.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.peripheral.DeviceSlot_2_0_3.Settings.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.peripheral.DeviceSlot_2_0_3.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.peripheral.DeviceSlot_2_0_3.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.peripheral.DeviceSlot_2_0_3.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.peripheral.DeviceSlot_2_0_3.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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
