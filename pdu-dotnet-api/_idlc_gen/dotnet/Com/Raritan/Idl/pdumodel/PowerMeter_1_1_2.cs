// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from PowerMeter.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {
  public class PowerMeter_1_1_2 : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.PowerMeter:1.1.2", null);

    public PowerMeter_1_1_2(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public PowerMeter_1_1_2(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new PowerMeter_1_1_2 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new PowerMeter_1_1_2(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int ERR_INVALID_PARAM = 1;

    public const int ERR_MODBUS_UNIT_IN_USE = 2;

    public enum Type {
      ONE_PHASE,
      SPLIT_PHASE,
      THREE_PHASE,
    }

    public class Config : ICloneable {
      public object Clone() {
        Config copy = new Config();
        copy.powerMeterId = this.powerMeterId;
        copy.type = this.type;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["powerMeterId"] = this.powerMeterId;
        json["type"] = (int)this.type;
        return json;
      }

      public static Config Decode(LightJson.JsonObject json, Agent agent) {
        Config inst = new Config();
        inst.powerMeterId = (int)json["powerMeterId"];
        inst.type = (Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Type)(int)json["type"];
        return inst;
      }

      public int powerMeterId = 0;
      public Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Type type = Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Type.ONE_PHASE;
    }

    public class GetConfigResult {
      public Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Config _ret_;
    }

    public GetConfigResult getConfig() {
      JsonObject _parameters = null;
      var _result = RpcCall("getConfig", _parameters);
      var _ret = new GetConfigResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Config.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getConfig(AsyncRpcResponse<GetConfigResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getConfig(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getConfig(AsyncRpcResponse<GetConfigResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getConfig", _parameters,
        _result => {
          try {
            var _ret = new GetConfigResult();
            _ret._ret_ = Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Config.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class Sensors : ICloneable {
      public object Clone() {
        Sensors copy = new Sensors();
        copy.voltage = this.voltage;
        copy.lineFrequency = this.lineFrequency;
        copy.current = this.current;
        copy.activePower = this.activePower;
        copy.reactivePower = this.reactivePower;
        copy.apparentPower = this.apparentPower;
        copy.powerFactor = this.powerFactor;
        copy.phaseAngle = this.phaseAngle;
        copy.displacementPowerFactor = this.displacementPowerFactor;
        copy.activeEnergy = this.activeEnergy;
        copy.unbalancedCurrent = this.unbalancedCurrent;
        copy.powerQuality = this.powerQuality;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["voltage"] = this.voltage != null ? this.voltage.Encode() : JsonValue.Null;
        json["lineFrequency"] = this.lineFrequency != null ? this.lineFrequency.Encode() : JsonValue.Null;
        json["current"] = this.current != null ? this.current.Encode() : JsonValue.Null;
        json["activePower"] = this.activePower != null ? this.activePower.Encode() : JsonValue.Null;
        json["reactivePower"] = this.reactivePower != null ? this.reactivePower.Encode() : JsonValue.Null;
        json["apparentPower"] = this.apparentPower != null ? this.apparentPower.Encode() : JsonValue.Null;
        json["powerFactor"] = this.powerFactor != null ? this.powerFactor.Encode() : JsonValue.Null;
        json["phaseAngle"] = this.phaseAngle != null ? this.phaseAngle.Encode() : JsonValue.Null;
        json["displacementPowerFactor"] = this.displacementPowerFactor != null ? this.displacementPowerFactor.Encode() : JsonValue.Null;
        json["activeEnergy"] = this.activeEnergy != null ? this.activeEnergy.Encode() : JsonValue.Null;
        json["unbalancedCurrent"] = this.unbalancedCurrent != null ? this.unbalancedCurrent.Encode() : JsonValue.Null;
        json["powerQuality"] = this.powerQuality != null ? this.powerQuality.Encode() : JsonValue.Null;
        return json;
      }

      public static Sensors Decode(LightJson.JsonObject json, Agent agent) {
        Sensors inst = new Sensors();
        inst.voltage = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["voltage"], agent));
        inst.lineFrequency = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["lineFrequency"], agent));
        inst.current = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["current"], agent));
        inst.activePower = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["activePower"], agent));
        inst.reactivePower = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["reactivePower"], agent));
        inst.apparentPower = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["apparentPower"], agent));
        inst.powerFactor = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["powerFactor"], agent));
        inst.phaseAngle = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["phaseAngle"], agent));
        inst.displacementPowerFactor = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["displacementPowerFactor"], agent));
        inst.activeEnergy = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["activeEnergy"], agent));
        inst.unbalancedCurrent = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["unbalancedCurrent"], agent));
        inst.powerQuality = Com.Raritan.Idl.sensors.StateSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["powerQuality"], agent));
        return inst;
      }

      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 voltage = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 lineFrequency = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 current = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 activePower = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 reactivePower = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 apparentPower = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 powerFactor = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 phaseAngle = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 displacementPowerFactor = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 activeEnergy = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 unbalancedCurrent = null;
      public Com.Raritan.Idl.sensors.StateSensor_4_0_2 powerQuality = null;
    }

    public class GetSensorsResult {
      public Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Sensors _ret_;
    }

    public GetSensorsResult getSensors() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSensors", _parameters);
      var _ret = new GetSensorsResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Sensors.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Sensors.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetPolesResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.pdumodel.Pole_4_0_1> _ret_;
    }

    public GetPolesResult getPoles() {
      JsonObject _parameters = null;
      var _result = RpcCall("getPoles", _parameters);
      var _ret = new GetPolesResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.pdumodel.Pole_4_0_1>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.pdumodel.Pole_4_0_1.Decode(_value, agent)));
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
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.pdumodel.Pole_4_0_1>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.pdumodel.Pole_4_0_1.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetControllersResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.pdumodel.Controller_4_0_0> _ret_;
    }

    public GetControllersResult getControllers() {
      JsonObject _parameters = null;
      var _result = RpcCall("getControllers", _parameters);
      var _ret = new GetControllersResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.pdumodel.Controller_4_0_0>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.pdumodel.Controller_4_0_0.StaticCast(ObjectProxy.Decode(_value, agent))));
      return _ret;
    }

    public AsyncRequest getControllers(AsyncRpcResponse<GetControllersResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getControllers(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getControllers(AsyncRpcResponse<GetControllersResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getControllers", _parameters,
        _result => {
          try {
            var _ret = new GetControllersResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.pdumodel.Controller_4_0_0>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.pdumodel.Controller_4_0_0.StaticCast(ObjectProxy.Decode(_value, agent))));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.name = this.name;
        copy.currentRating = this.currentRating;
        copy.phaseCtRating = this.phaseCtRating;
        copy.neutralCtRating = this.neutralCtRating;
        copy.earthCtRating = this.earthCtRating;
        copy.modbusUnitAddress = this.modbusUnitAddress;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["name"] = this.name;
        json["currentRating"] = this.currentRating;
        json["phaseCtRating"] = this.phaseCtRating;
        json["neutralCtRating"] = this.neutralCtRating;
        json["earthCtRating"] = this.earthCtRating;
        json["modbusUnitAddress"] = this.modbusUnitAddress;
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.name = (string)json["name"];
        inst.currentRating = (int)json["currentRating"];
        inst.phaseCtRating = (int)json["phaseCtRating"];
        inst.neutralCtRating = (int)json["neutralCtRating"];
        inst.earthCtRating = (int)json["earthCtRating"];
        inst.modbusUnitAddress = (int)json["modbusUnitAddress"];
        return inst;
      }

      public string name = "";
      public int currentRating = 0;
      public int phaseCtRating = 0;
      public int neutralCtRating = 0;
      public int earthCtRating = 0;
      public int modbusUnitAddress = 0;
    }

    public class SettingsChangedEvent : Com.Raritan.Idl._event.UserEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.PowerMeter_1_1_2.SettingsChangedEvent:1.0.0", Com.Raritan.Idl._event.UserEvent.typeInfo);

      public Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Settings oldSettings = new Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Settings();
      public Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Settings newSettings = new Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Settings();
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Settings.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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

    public class EnergyPulseSettings : ICloneable {
      public object Clone() {
        EnergyPulseSettings copy = new EnergyPulseSettings();
        copy.pulseEnabled = this.pulseEnabled;
        copy.poles = this.poles;
        copy.pulsesPerKWh = this.pulsesPerKWh;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["pulseEnabled"] = this.pulseEnabled;
        json["poles"] = new JsonArray(this.poles.Select(
          _value => (JsonValue)(_value)));
        json["pulsesPerKWh"] = this.pulsesPerKWh;
        return json;
      }

      public static EnergyPulseSettings Decode(LightJson.JsonObject json, Agent agent) {
        EnergyPulseSettings inst = new EnergyPulseSettings();
        inst.pulseEnabled = (bool)json["pulseEnabled"];
        inst.poles = new System.Collections.Generic.List<int>(json["poles"].AsJsonArray.Select(
          _value => (int)_value));
        inst.pulsesPerKWh = (int)json["pulsesPerKWh"];
        return inst;
      }

      public bool pulseEnabled = false;
      public System.Collections.Generic.IEnumerable<int> poles = new System.Collections.Generic.List<int>();
      public int pulsesPerKWh = 0;
    }

    public class EnergyPulseSettingsChangedEvent : Com.Raritan.Idl._event.UserEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.PowerMeter_1_1_2.EnergyPulseSettingsChangedEvent:1.0.0", Com.Raritan.Idl._event.UserEvent.typeInfo);

      public Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.EnergyPulseSettings oldSettings = new Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.EnergyPulseSettings();
      public Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.EnergyPulseSettings newSettings = new Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.EnergyPulseSettings();
    }

    public class GetEnergyPulseSettingsResult {
      public Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.EnergyPulseSettings _ret_;
    }

    public GetEnergyPulseSettingsResult getEnergyPulseSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getEnergyPulseSettings", _parameters);
      var _ret = new GetEnergyPulseSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.EnergyPulseSettings.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getEnergyPulseSettings(AsyncRpcResponse<GetEnergyPulseSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getEnergyPulseSettings(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getEnergyPulseSettings(AsyncRpcResponse<GetEnergyPulseSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getEnergyPulseSettings", _parameters,
        _result => {
          try {
            var _ret = new GetEnergyPulseSettingsResult();
            _ret._ret_ = Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.EnergyPulseSettings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetEnergyPulseSettingsResult {
      public int _ret_;
    }

    public SetEnergyPulseSettingsResult setEnergyPulseSettings(Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.EnergyPulseSettings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setEnergyPulseSettings", _parameters);
      var _ret = new SetEnergyPulseSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setEnergyPulseSettings(Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.EnergyPulseSettings settings, AsyncRpcResponse<SetEnergyPulseSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setEnergyPulseSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setEnergyPulseSettings(Com.Raritan.Idl.pdumodel.PowerMeter_1_1_2.EnergyPulseSettings settings, AsyncRpcResponse<SetEnergyPulseSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["settings"] = settings.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setEnergyPulseSettings", _parameters,
        _result => {
          try {
            var _ret = new SetEnergyPulseSettingsResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
