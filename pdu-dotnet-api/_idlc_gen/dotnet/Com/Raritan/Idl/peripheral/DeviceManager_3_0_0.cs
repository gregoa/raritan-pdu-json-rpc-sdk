// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from PeripheralDeviceManager.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.peripheral {
  public class DeviceManager_3_0_0 : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DeviceManager:3.0.0", null);

    public DeviceManager_3_0_0(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public DeviceManager_3_0_0(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new DeviceManager_3_0_0 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new DeviceManager_3_0_0(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int ERR_INVALID_PARAMS = 1;

    public enum ZCoordMode {
      RACKUNITS,
      FREEFORM,
    }

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.zCoordMode = this.zCoordMode;
        copy.autoManageNewDevices = this.autoManageNewDevices;
        copy.deviceAltitude = this.deviceAltitude;
        copy.presenceDetectionTimeout = this.presenceDetectionTimeout;
        copy.defaultThresholdsMap = this.defaultThresholdsMap;
        copy.maxActivePoweredDryContacts = this.maxActivePoweredDryContacts;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["zCoordMode"] = (int)this.zCoordMode;
        json["autoManageNewDevices"] = this.autoManageNewDevices;
        json["deviceAltitude"] = this.deviceAltitude;
        json["presenceDetectionTimeout"] = this.presenceDetectionTimeout;
        json["defaultThresholdsMap"] = new JsonArray(this.defaultThresholdsMap.Select(_entry => (JsonValue) new JsonObject(new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, LightJson.JsonValue>> {
          new System.Collections.Generic.KeyValuePair<string, JsonValue>("key", _entry.Key),
          new System.Collections.Generic.KeyValuePair<string, JsonValue>("value", _entry.Value.Encode())
        })));
        json["maxActivePoweredDryContacts"] = this.maxActivePoweredDryContacts;
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.zCoordMode = (Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.ZCoordMode)(int)json["zCoordMode"];
        inst.autoManageNewDevices = (bool)json["autoManageNewDevices"];
        inst.deviceAltitude = (float)json["deviceAltitude"];
        inst.presenceDetectionTimeout = (int)json["presenceDetectionTimeout"];
        inst.defaultThresholdsMap = DictionaryHelper.Create(json["defaultThresholdsMap"].AsJsonArray.Select(
          _value => new System.Collections.Generic.KeyValuePair<string, Com.Raritan.Idl.sensors.NumericSensor_4_0_2.Thresholds>(_value["key"], Com.Raritan.Idl.sensors.NumericSensor_4_0_2.Thresholds.Decode(_value["value"], agent))));
        inst.maxActivePoweredDryContacts = (int)json["maxActivePoweredDryContacts"];
        return inst;
      }

      public Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.ZCoordMode zCoordMode = Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.ZCoordMode.RACKUNITS;
      public bool autoManageNewDevices = false;
      public float deviceAltitude = 0.0f;
      public int presenceDetectionTimeout = 0;
      public System.Collections.Generic.IDictionary<string, Com.Raritan.Idl.sensors.NumericSensor_4_0_2.Thresholds> defaultThresholdsMap = new System.Collections.Generic.Dictionary<string, Com.Raritan.Idl.sensors.NumericSensor_4_0_2.Thresholds>();
      public int maxActivePoweredDryContacts = 0;
    }

    public class MetaData : ICloneable {
      public object Clone() {
        MetaData copy = new MetaData();
        copy.oneWirePortCount = this.oneWirePortCount;
        copy.onboardDeviceCount = this.onboardDeviceCount;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["oneWirePortCount"] = this.oneWirePortCount;
        json["onboardDeviceCount"] = this.onboardDeviceCount;
        return json;
      }

      public static MetaData Decode(LightJson.JsonObject json, Agent agent) {
        MetaData inst = new MetaData();
        inst.oneWirePortCount = (int)json["oneWirePortCount"];
        inst.onboardDeviceCount = (int)json["onboardDeviceCount"];
        return inst;
      }

      public int oneWirePortCount = 0;
      public int onboardDeviceCount = 0;
    }

    public class DeviceTypeInfo : ICloneable {
      public object Clone() {
        DeviceTypeInfo copy = new DeviceTypeInfo();
        copy.type = this.type;
        copy.isActuator = this.isActuator;
        copy.identifier = this.identifier;
        copy.name = this.name;
        copy.defaultRange = this.defaultRange;
        copy.defaultDecDigits = this.defaultDecDigits;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["type"] = this.type.Encode();
        json["isActuator"] = this.isActuator;
        json["identifier"] = this.identifier;
        json["name"] = this.name;
        json["defaultRange"] = this.defaultRange.Encode();
        json["defaultDecDigits"] = this.defaultDecDigits;
        return json;
      }

      public static DeviceTypeInfo Decode(LightJson.JsonObject json, Agent agent) {
        DeviceTypeInfo inst = new DeviceTypeInfo();
        inst.type = Com.Raritan.Idl.sensors.Sensor_4_0_2.TypeSpec.Decode(json["type"], agent);
        inst.isActuator = (bool)json["isActuator"];
        inst.identifier = (string)json["identifier"];
        inst.name = (string)json["name"];
        inst.defaultRange = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.Range.Decode(json["defaultRange"], agent);
        inst.defaultDecDigits = (int)json["defaultDecDigits"];
        return inst;
      }

      public Com.Raritan.Idl.sensors.Sensor_4_0_2.TypeSpec type = new Com.Raritan.Idl.sensors.Sensor_4_0_2.TypeSpec();
      public bool isActuator = false;
      public string identifier = "";
      public string name = "";
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2.Range defaultRange = new Com.Raritan.Idl.sensors.NumericSensor_4_0_2.Range();
      public int defaultDecDigits = 0;
    }

    public class FirmwareUpdateState : ICloneable {
      public object Clone() {
        FirmwareUpdateState copy = new FirmwareUpdateState();
        copy.active = this.active;
        copy.remaining = this.remaining;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["active"] = this.active;
        json["remaining"] = this.remaining;
        return json;
      }

      public static FirmwareUpdateState Decode(LightJson.JsonObject json, Agent agent) {
        FirmwareUpdateState inst = new FirmwareUpdateState();
        inst.active = (bool)json["active"];
        inst.remaining = (int)json["remaining"];
        return inst;
      }

      public bool active = false;
      public int remaining = 0;
    }

    public class SettingsChangedEvent : Com.Raritan.Idl._event.UserEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DeviceManager_3_0_0.SettingsChangedEvent:1.0.0", Com.Raritan.Idl._event.UserEvent.typeInfo);

      public Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.Settings oldSettings = new Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.Settings();
      public Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.Settings newSettings = new Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.Settings();
    }

    public class DeviceEvent_2_0_0 : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DeviceManager_3_0_0.DeviceEvent:2.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.peripheral.Device_3_0_1> devices = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.Device_3_0_1>();
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.peripheral.Device_3_0_1> allDevices = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.Device_3_0_1>();
    }

    public class DeviceAddedEvent_2_0_0 : Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.DeviceEvent_2_0_0 {
      static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DeviceManager_3_0_0.DeviceAddedEvent:2.0.0", Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.DeviceEvent_2_0_0.typeInfo);

    }

    public class DeviceRemovedEvent_2_0_0 : Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.DeviceEvent_2_0_0 {
      static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DeviceManager_3_0_0.DeviceRemovedEvent:2.0.0", Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.DeviceEvent_2_0_0.typeInfo);

    }

    public class UnknownDeviceAttachedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DeviceManager_3_0_0.UnknownDeviceAttachedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public string romCode = "";
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.peripheral.PosElement> position = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.PosElement>();
    }

    public enum DeviceFirmwareUpdateState {
      UPDATE_STARTED,
      UPDATE_SUCCESSFUL,
      UPDATE_FAILED,
    }

    public class DeviceFirmwareUpdateStateChangedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DeviceManager_3_0_0.DeviceFirmwareUpdateStateChangedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public string oldVersion = "";
      public string newVersion = "";
      public string serial = "";
      public Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.DeviceFirmwareUpdateState state = Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.DeviceFirmwareUpdateState.UPDATE_STARTED;
    }

    public class FirmwareUpdateStateChangedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DeviceManager_3_0_0.FirmwareUpdateStateChangedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.FirmwareUpdateState newState = new Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.FirmwareUpdateState();
    }

    public class PackageEvent_2_0_0 : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DeviceManager_3_0_0.PackageEvent:2.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.peripheral.PackageInfo_2_0_0> packageInfos = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.PackageInfo_2_0_0>();
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.peripheral.PackageInfo_2_0_0> allPackages = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.PackageInfo_2_0_0>();
    }

    public class PackageAddedEvent_2_0_0 : Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.PackageEvent_2_0_0 {
      static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DeviceManager_3_0_0.PackageAddedEvent:2.0.0", Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.PackageEvent_2_0_0.typeInfo);

    }

    public class PackageRemovedEvent_2_0_0 : Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.PackageEvent_2_0_0 {
      static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.DeviceManager_3_0_0.PackageRemovedEvent:2.0.0", Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.PackageEvent_2_0_0.typeInfo);

    }

    public class Statistics : ICloneable {
      public object Clone() {
        Statistics copy = new Statistics();
        copy.cSumErrCnt = this.cSumErrCnt;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["cSumErrCnt"] = this.cSumErrCnt;
        return json;
      }

      public static Statistics Decode(LightJson.JsonObject json, Agent agent) {
        Statistics inst = new Statistics();
        inst.cSumErrCnt = (int)json["cSumErrCnt"];
        return inst;
      }

      public int cSumErrCnt = 0;
    }

    public class GetDeviceSlotsResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.peripheral.DeviceSlot_2_0_2> _ret_;
    }

    public GetDeviceSlotsResult getDeviceSlots() {
      JsonObject _parameters = null;
      var _result = RpcCall("getDeviceSlots", _parameters);
      var _ret = new GetDeviceSlotsResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.DeviceSlot_2_0_2>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.peripheral.DeviceSlot_2_0_2.StaticCast(ObjectProxy.Decode(_value, agent))));
      return _ret;
    }

    public AsyncRequest getDeviceSlots(AsyncRpcResponse<GetDeviceSlotsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getDeviceSlots(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getDeviceSlots(AsyncRpcResponse<GetDeviceSlotsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getDeviceSlots", _parameters,
        _result => {
          try {
            var _ret = new GetDeviceSlotsResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.DeviceSlot_2_0_2>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.peripheral.DeviceSlot_2_0_2.StaticCast(ObjectProxy.Decode(_value, agent))));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetDeviceSlotResult {
      public Com.Raritan.Idl.peripheral.DeviceSlot_2_0_2 _ret_;
    }

    public GetDeviceSlotResult getDeviceSlot(int idx) {
      var _parameters = new LightJson.JsonObject();
      _parameters["idx"] = idx;

      var _result = RpcCall("getDeviceSlot", _parameters);
      var _ret = new GetDeviceSlotResult();
      _ret._ret_ = Com.Raritan.Idl.peripheral.DeviceSlot_2_0_2.StaticCast(ObjectProxy.Decode(_result["_ret_"], agent));
      return _ret;
    }

    public AsyncRequest getDeviceSlot(int idx, AsyncRpcResponse<GetDeviceSlotResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getDeviceSlot(idx, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getDeviceSlot(int idx, AsyncRpcResponse<GetDeviceSlotResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["idx"] = idx;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("getDeviceSlot", _parameters,
        _result => {
          try {
            var _ret = new GetDeviceSlotResult();
            _ret._ret_ = Com.Raritan.Idl.peripheral.DeviceSlot_2_0_2.StaticCast(ObjectProxy.Decode(_result["_ret_"], agent));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetDiscoveredDevicesResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.peripheral.Device_3_0_1> _ret_;
    }

    public GetDiscoveredDevicesResult getDiscoveredDevices() {
      JsonObject _parameters = null;
      var _result = RpcCall("getDiscoveredDevices", _parameters);
      var _ret = new GetDiscoveredDevicesResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.Device_3_0_1>(_result["_ret_"].AsJsonArray.Select(
        _value => ((Com.Raritan.Idl.peripheral.Device_3_0_1)ValueObjectCodec.DecodeAs(_value, agent, Com.Raritan.Idl.peripheral.Device_3_0_1.typeInfo))));
      return _ret;
    }

    public AsyncRequest getDiscoveredDevices(AsyncRpcResponse<GetDiscoveredDevicesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getDiscoveredDevices(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getDiscoveredDevices(AsyncRpcResponse<GetDiscoveredDevicesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getDiscoveredDevices", _parameters,
        _result => {
          try {
            var _ret = new GetDiscoveredDevicesResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.Device_3_0_1>(_result["_ret_"].AsJsonArray.Select(
              _value => ((Com.Raritan.Idl.peripheral.Device_3_0_1)ValueObjectCodec.DecodeAs(_value, agent, Com.Raritan.Idl.peripheral.Device_3_0_1.typeInfo))));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetDiscoveredPackageInfosResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.peripheral.PackageInfo_2_0_0> _ret_;
    }

    public GetDiscoveredPackageInfosResult getDiscoveredPackageInfos() {
      JsonObject _parameters = null;
      var _result = RpcCall("getDiscoveredPackageInfos", _parameters);
      var _ret = new GetDiscoveredPackageInfosResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.PackageInfo_2_0_0>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.peripheral.PackageInfo_2_0_0.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getDiscoveredPackageInfos(AsyncRpcResponse<GetDiscoveredPackageInfosResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getDiscoveredPackageInfos(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getDiscoveredPackageInfos(AsyncRpcResponse<GetDiscoveredPackageInfosResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getDiscoveredPackageInfos", _parameters,
        _result => {
          try {
            var _ret = new GetDiscoveredPackageInfosResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.PackageInfo_2_0_0>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.peripheral.PackageInfo_2_0_0.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.Settings.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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

    public class GetMetaDataResult {
      public Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.MetaData _ret_;
    }

    public GetMetaDataResult getMetaData() {
      JsonObject _parameters = null;
      var _result = RpcCall("getMetaData", _parameters);
      var _ret = new GetMetaDataResult();
      _ret._ret_ = Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.MetaData.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getMetaData(AsyncRpcResponse<GetMetaDataResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getMetaData(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getMetaData(AsyncRpcResponse<GetMetaDataResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getMetaData", _parameters,
        _result => {
          try {
            var _ret = new GetMetaDataResult();
            _ret._ret_ = Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.MetaData.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetDeviceTypeInfosResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.DeviceTypeInfo> _ret_;
    }

    public GetDeviceTypeInfosResult getDeviceTypeInfos() {
      JsonObject _parameters = null;
      var _result = RpcCall("getDeviceTypeInfos", _parameters);
      var _ret = new GetDeviceTypeInfosResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.DeviceTypeInfo>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.DeviceTypeInfo.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getDeviceTypeInfos(AsyncRpcResponse<GetDeviceTypeInfosResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getDeviceTypeInfos(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getDeviceTypeInfos(AsyncRpcResponse<GetDeviceTypeInfosResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getDeviceTypeInfos", _parameters,
        _result => {
          try {
            var _ret = new GetDeviceTypeInfosResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.DeviceTypeInfo>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.DeviceTypeInfo.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetFirmwareUpdateStateResult {
      public Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.FirmwareUpdateState _ret_;
    }

    public GetFirmwareUpdateStateResult getFirmwareUpdateState() {
      JsonObject _parameters = null;
      var _result = RpcCall("getFirmwareUpdateState", _parameters);
      var _ret = new GetFirmwareUpdateStateResult();
      _ret._ret_ = Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.FirmwareUpdateState.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getFirmwareUpdateState(AsyncRpcResponse<GetFirmwareUpdateStateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getFirmwareUpdateState(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getFirmwareUpdateState(AsyncRpcResponse<GetFirmwareUpdateStateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getFirmwareUpdateState", _parameters,
        _result => {
          try {
            var _ret = new GetFirmwareUpdateStateResult();
            _ret._ret_ = Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.FirmwareUpdateState.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetStatisticsResult {
      public Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.Statistics _ret_;
    }

    public GetStatisticsResult getStatistics() {
      JsonObject _parameters = null;
      var _result = RpcCall("getStatistics", _parameters);
      var _ret = new GetStatisticsResult();
      _ret._ret_ = Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.Statistics.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getStatistics(AsyncRpcResponse<GetStatisticsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getStatistics(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getStatistics(AsyncRpcResponse<GetStatisticsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getStatistics", _parameters,
        _result => {
          try {
            var _ret = new GetStatisticsResult();
            _ret._ret_ = Com.Raritan.Idl.peripheral.DeviceManager_3_0_0.Statistics.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetDiscoveredPackagesResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.peripheral.Package> _ret_;
    }

    public GetDiscoveredPackagesResult getDiscoveredPackages() {
      JsonObject _parameters = null;
      var _result = RpcCall("getDiscoveredPackages", _parameters);
      var _ret = new GetDiscoveredPackagesResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.Package>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.peripheral.Package.StaticCast(ObjectProxy.Decode(_value, agent))));
      return _ret;
    }

    public AsyncRequest getDiscoveredPackages(AsyncRpcResponse<GetDiscoveredPackagesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getDiscoveredPackages(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getDiscoveredPackages(AsyncRpcResponse<GetDiscoveredPackagesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getDiscoveredPackages", _parameters,
        _result => {
          try {
            var _ret = new GetDiscoveredPackagesResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.Package>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.peripheral.Package.StaticCast(ObjectProxy.Decode(_value, agent))));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
