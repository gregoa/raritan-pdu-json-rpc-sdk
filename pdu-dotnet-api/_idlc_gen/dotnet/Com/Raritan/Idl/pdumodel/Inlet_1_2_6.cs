// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Inlet.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {
  public class Inlet_1_2_6 : Com.Raritan.Idl.pdumodel.EDevice {

    static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.Inlet:1.2.6", null);

    public Inlet_1_2_6(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Inlet_1_2_6(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Inlet_1_2_6 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Inlet_1_2_6(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class MetaData : ICloneable {
      public object Clone() {
        MetaData copy = new MetaData();
        copy.label = this.label;
        copy.plugType = this.plugType;
        copy.namePlate = this.namePlate;
        copy.rating = this.rating;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["label"] = this.label;
        json["plugType"] = this.plugType;
        json["namePlate"] = this.namePlate.Encode();
        json["rating"] = this.rating.Encode();
        return json;
      }

      public static MetaData Decode(LightJson.JsonObject json, Agent agent) {
        MetaData inst = new MetaData();
        inst.label = (string)json["label"];
        inst.plugType = (string)json["plugType"];
        inst.namePlate = Com.Raritan.Idl.pdumodel.Nameplate.Decode(json["namePlate"], agent);
        inst.rating = Com.Raritan.Idl.pdumodel.Rating.Decode(json["rating"], agent);
        return inst;
      }

      public string label = "";
      public string plugType = "";
      public Com.Raritan.Idl.pdumodel.Nameplate namePlate = new Com.Raritan.Idl.pdumodel.Nameplate();
      public Com.Raritan.Idl.pdumodel.Rating rating = new Com.Raritan.Idl.pdumodel.Rating();
    }

    public class Sensors : ICloneable {
      public object Clone() {
        Sensors copy = new Sensors();
        copy.voltage = this.voltage;
        copy.current = this.current;
        copy.peakCurrent = this.peakCurrent;
        copy.residualCurrent = this.residualCurrent;
        copy.activePower = this.activePower;
        copy.apparentPower = this.apparentPower;
        copy.powerFactor = this.powerFactor;
        copy.activeEnergy = this.activeEnergy;
        copy.apparentEnergy = this.apparentEnergy;
        copy.unbalancedCurrent = this.unbalancedCurrent;
        copy.lineFrequency = this.lineFrequency;
        copy.phaseAngle = this.phaseAngle;
        copy.powerQuality = this.powerQuality;
        copy.surgeProtectorStatus = this.surgeProtectorStatus;
        copy.residualCurrentStatus = this.residualCurrentStatus;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["voltage"] = this.voltage != null ? this.voltage.Encode() : JsonValue.Null;
        json["current"] = this.current != null ? this.current.Encode() : JsonValue.Null;
        json["peakCurrent"] = this.peakCurrent != null ? this.peakCurrent.Encode() : JsonValue.Null;
        json["residualCurrent"] = this.residualCurrent != null ? this.residualCurrent.Encode() : JsonValue.Null;
        json["activePower"] = this.activePower != null ? this.activePower.Encode() : JsonValue.Null;
        json["apparentPower"] = this.apparentPower != null ? this.apparentPower.Encode() : JsonValue.Null;
        json["powerFactor"] = this.powerFactor != null ? this.powerFactor.Encode() : JsonValue.Null;
        json["activeEnergy"] = this.activeEnergy != null ? this.activeEnergy.Encode() : JsonValue.Null;
        json["apparentEnergy"] = this.apparentEnergy != null ? this.apparentEnergy.Encode() : JsonValue.Null;
        json["unbalancedCurrent"] = this.unbalancedCurrent != null ? this.unbalancedCurrent.Encode() : JsonValue.Null;
        json["lineFrequency"] = this.lineFrequency != null ? this.lineFrequency.Encode() : JsonValue.Null;
        json["phaseAngle"] = this.phaseAngle != null ? this.phaseAngle.Encode() : JsonValue.Null;
        json["powerQuality"] = this.powerQuality != null ? this.powerQuality.Encode() : JsonValue.Null;
        json["surgeProtectorStatus"] = this.surgeProtectorStatus != null ? this.surgeProtectorStatus.Encode() : JsonValue.Null;
        json["residualCurrentStatus"] = this.residualCurrentStatus != null ? this.residualCurrentStatus.Encode() : JsonValue.Null;
        return json;
      }

      public static Sensors Decode(LightJson.JsonObject json, Agent agent) {
        Sensors inst = new Sensors();
        inst.voltage = Com.Raritan.Idl.sensors.NumericSensor_4_0_0.StaticCast(ObjectProxy.Decode(json["voltage"], agent));
        inst.current = Com.Raritan.Idl.sensors.NumericSensor_4_0_0.StaticCast(ObjectProxy.Decode(json["current"], agent));
        inst.peakCurrent = Com.Raritan.Idl.sensors.NumericSensor_4_0_0.StaticCast(ObjectProxy.Decode(json["peakCurrent"], agent));
        inst.residualCurrent = Com.Raritan.Idl.sensors.NumericSensor_4_0_0.StaticCast(ObjectProxy.Decode(json["residualCurrent"], agent));
        inst.activePower = Com.Raritan.Idl.sensors.NumericSensor_4_0_0.StaticCast(ObjectProxy.Decode(json["activePower"], agent));
        inst.apparentPower = Com.Raritan.Idl.sensors.NumericSensor_4_0_0.StaticCast(ObjectProxy.Decode(json["apparentPower"], agent));
        inst.powerFactor = Com.Raritan.Idl.sensors.NumericSensor_4_0_0.StaticCast(ObjectProxy.Decode(json["powerFactor"], agent));
        inst.activeEnergy = Com.Raritan.Idl.sensors.NumericSensor_4_0_0.StaticCast(ObjectProxy.Decode(json["activeEnergy"], agent));
        inst.apparentEnergy = Com.Raritan.Idl.sensors.NumericSensor_4_0_0.StaticCast(ObjectProxy.Decode(json["apparentEnergy"], agent));
        inst.unbalancedCurrent = Com.Raritan.Idl.sensors.NumericSensor_4_0_0.StaticCast(ObjectProxy.Decode(json["unbalancedCurrent"], agent));
        inst.lineFrequency = Com.Raritan.Idl.sensors.NumericSensor_4_0_0.StaticCast(ObjectProxy.Decode(json["lineFrequency"], agent));
        inst.phaseAngle = Com.Raritan.Idl.sensors.NumericSensor_4_0_0.StaticCast(ObjectProxy.Decode(json["phaseAngle"], agent));
        inst.powerQuality = Com.Raritan.Idl.sensors.StateSensor_4_0_0.StaticCast(ObjectProxy.Decode(json["powerQuality"], agent));
        inst.surgeProtectorStatus = Com.Raritan.Idl.sensors.StateSensor_4_0_0.StaticCast(ObjectProxy.Decode(json["surgeProtectorStatus"], agent));
        inst.residualCurrentStatus = Com.Raritan.Idl.pdumodel.ResidualCurrentStateSensor_2_0_0.StaticCast(ObjectProxy.Decode(json["residualCurrentStatus"], agent));
        return inst;
      }

      public Com.Raritan.Idl.sensors.NumericSensor_4_0_0 voltage = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_0 current = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_0 peakCurrent = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_0 residualCurrent = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_0 activePower = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_0 apparentPower = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_0 powerFactor = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_0 activeEnergy = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_0 apparentEnergy = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_0 unbalancedCurrent = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_0 lineFrequency = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_0 phaseAngle = null;
      public Com.Raritan.Idl.sensors.StateSensor_4_0_0 powerQuality = null;
      public Com.Raritan.Idl.sensors.StateSensor_4_0_0 surgeProtectorStatus = null;
      public Com.Raritan.Idl.pdumodel.ResidualCurrentStateSensor_2_0_0 residualCurrentStatus = null;
    }

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.name = this.name;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["name"] = this.name;
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.name = (string)json["name"];
        return inst;
      }

      public string name = "";
    }

    public class SettingsChangedEvent : Com.Raritan.Idl._event.UserEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.Inlet_1_2_6.SettingsChangedEvent:1.0.0", Com.Raritan.Idl._event.UserEvent.typeInfo);

      public Com.Raritan.Idl.pdumodel.Inlet_1_2_6.Settings oldSettings = new Com.Raritan.Idl.pdumodel.Inlet_1_2_6.Settings();
      public Com.Raritan.Idl.pdumodel.Inlet_1_2_6.Settings newSettings = new Com.Raritan.Idl.pdumodel.Inlet_1_2_6.Settings();
    }

    public class EnableStateChangedEvent : Com.Raritan.Idl._event.UserEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.Inlet_1_2_6.EnableStateChangedEvent:1.0.0", Com.Raritan.Idl._event.UserEvent.typeInfo);

      public bool enabled = false;
    }

    public class GetMetaDataResult {
      public Com.Raritan.Idl.pdumodel.Inlet_1_2_6.MetaData _ret_;
    }

    public GetMetaDataResult getMetaData() {
      JsonObject _parameters = null;
      var _result = RpcCall("getMetaData", _parameters);
      var _ret = new GetMetaDataResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.Inlet_1_2_6.MetaData.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.Inlet_1_2_6.MetaData.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSensorsResult {
      public Com.Raritan.Idl.pdumodel.Inlet_1_2_6.Sensors _ret_;
    }

    public GetSensorsResult getSensors() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSensors", _parameters);
      var _ret = new GetSensorsResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.Inlet_1_2_6.Sensors.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getSensors(AsyncRpcResponse<GetSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getSensors(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getSensors(AsyncRpcResponse<GetSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getSensors", _parameters,
        _result => {
          try {
            var _ret = new GetSensorsResult();
            _ret._ret_ = Com.Raritan.Idl.pdumodel.Inlet_1_2_6.Sensors.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetPolesResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.pdumodel.Pole_2_0_0> _ret_;
    }

    public GetPolesResult getPoles() {
      JsonObject _parameters = null;
      var _result = RpcCall("getPoles", _parameters);
      var _ret = new GetPolesResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.pdumodel.Pole_2_0_0>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.pdumodel.Pole_2_0_0.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getPoles(AsyncRpcResponse<GetPolesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getPoles(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getPoles(AsyncRpcResponse<GetPolesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getPoles", _parameters,
        _result => {
          try {
            var _ret = new GetPolesResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.pdumodel.Pole_2_0_0>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.pdumodel.Pole_2_0_0.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.pdumodel.Inlet_1_2_6.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.Inlet_1_2_6.Settings.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.Inlet_1_2_6.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.pdumodel.Inlet_1_2_6.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.pdumodel.Inlet_1_2_6.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.pdumodel.Inlet_1_2_6.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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

    public class SetEnabledResult {
    }

    public SetEnabledResult setEnabled(bool enabled) {
      var _parameters = new LightJson.JsonObject();
      _parameters["enabled"] = enabled;

      var _result = RpcCall("setEnabled", _parameters);
      var _ret = new SetEnabledResult();
      return _ret;
    }

    public AsyncRequest setEnabled(bool enabled, AsyncRpcResponse<SetEnabledResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setEnabled(enabled, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setEnabled(bool enabled, AsyncRpcResponse<SetEnabledResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["enabled"] = enabled;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setEnabled", _parameters,
        _result => {
          try {
            var _ret = new SetEnabledResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class IsEnabledResult {
      public bool _ret_;
    }

    public IsEnabledResult isEnabled() {
      JsonObject _parameters = null;
      var _result = RpcCall("isEnabled", _parameters);
      var _ret = new IsEnabledResult();
      _ret._ret_ = (bool)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest isEnabled(AsyncRpcResponse<IsEnabledResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return isEnabled(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest isEnabled(AsyncRpcResponse<IsEnabledResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("isEnabled", _parameters,
        _result => {
          try {
            var _ret = new IsEnabledResult();
            _ret._ret_ = (bool)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
