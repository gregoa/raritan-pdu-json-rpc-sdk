// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Outlet.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {
  public class Outlet_2_1_2 : Com.Raritan.Idl.pdumodel.EDevice {

    static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.Outlet:2.1.2", null);

    public Outlet_2_1_2(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Outlet_2_1_2(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Outlet_2_1_2 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Outlet_2_1_2(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int ERR_OUTLET_NOT_SWITCHABLE = 1;

    public const int ERR_LOAD_SHEDDING_ACTIVE = 2;

    public const int ERR_OUTLET_DISABLED = 3;

    public const int ERR_OUTLET_NOT_OFF = 4;

    public const int ERR_INVALID_PARAM = 1;

    public class MetaData : ICloneable {
      public object Clone() {
        MetaData copy = new MetaData();
        copy.label = this.label;
        copy.receptacleType = this.receptacleType;
        copy.namePlate = this.namePlate;
        copy.rating = this.rating;
        copy.isSwitchable = this.isSwitchable;
        copy.isLatching = this.isLatching;
        copy.maxRelayCycleCnt = this.maxRelayCycleCnt;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["label"] = this.label;
        json["receptacleType"] = this.receptacleType;
        json["namePlate"] = this.namePlate.Encode();
        json["rating"] = this.rating.Encode();
        json["isSwitchable"] = this.isSwitchable;
        json["isLatching"] = this.isLatching;
        json["maxRelayCycleCnt"] = this.maxRelayCycleCnt;
        return json;
      }

      public static MetaData Decode(LightJson.JsonObject json, Agent agent) {
        MetaData inst = new MetaData();
        inst.label = (string)json["label"];
        inst.receptacleType = (string)json["receptacleType"];
        inst.namePlate = Com.Raritan.Idl.pdumodel.Nameplate.Decode(json["namePlate"], agent);
        inst.rating = Com.Raritan.Idl.pdumodel.Rating.Decode(json["rating"], agent);
        inst.isSwitchable = (bool)json["isSwitchable"];
        inst.isLatching = (bool)json["isLatching"];
        inst.maxRelayCycleCnt = (int)json["maxRelayCycleCnt"];
        return inst;
      }

      public string label = "";
      public string receptacleType = "";
      public Com.Raritan.Idl.pdumodel.Nameplate namePlate = new Com.Raritan.Idl.pdumodel.Nameplate();
      public Com.Raritan.Idl.pdumodel.Rating rating = new Com.Raritan.Idl.pdumodel.Rating();
      public bool isSwitchable = false;
      public bool isLatching = false;
      public int maxRelayCycleCnt = 0;
    }

    public enum PowerState {
      PS_OFF,
      PS_ON,
    }

    public class LedState : ICloneable {
      public object Clone() {
        LedState copy = new LedState();
        copy.red = this.red;
        copy.green = this.green;
        copy.blinking = this.blinking;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["red"] = this.red;
        json["green"] = this.green;
        json["blinking"] = this.blinking;
        return json;
      }

      public static LedState Decode(LightJson.JsonObject json, Agent agent) {
        LedState inst = new LedState();
        inst.red = (bool)json["red"];
        inst.green = (bool)json["green"];
        inst.blinking = (bool)json["blinking"];
        return inst;
      }

      public bool red = false;
      public bool green = false;
      public bool blinking = false;
    }

    public class State : ICloneable {
      public object Clone() {
        State copy = new State();
        copy.available = this.available;
        copy.powerState = this.powerState;
        copy.switchOnInProgress = this.switchOnInProgress;
        copy.cycleInProgress = this.cycleInProgress;
        copy.isLoadShed = this.isLoadShed;
        copy.ledState = this.ledState;
        copy.lastPowerStateChange = this.lastPowerStateChange;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["available"] = this.available;
        json["powerState"] = (int)this.powerState;
        json["switchOnInProgress"] = this.switchOnInProgress;
        json["cycleInProgress"] = this.cycleInProgress;
        json["isLoadShed"] = this.isLoadShed;
        json["ledState"] = this.ledState.Encode();
        json["lastPowerStateChange"] = this.lastPowerStateChange.Ticks;
        return json;
      }

      public static State Decode(LightJson.JsonObject json, Agent agent) {
        State inst = new State();
        inst.available = (bool)json["available"];
        inst.powerState = (Com.Raritan.Idl.pdumodel.Outlet_2_1_2.PowerState)(int)json["powerState"];
        inst.switchOnInProgress = (bool)json["switchOnInProgress"];
        inst.cycleInProgress = (bool)json["cycleInProgress"];
        inst.isLoadShed = (bool)json["isLoadShed"];
        inst.ledState = Com.Raritan.Idl.pdumodel.Outlet_2_1_2.LedState.Decode(json["ledState"], agent);
        inst.lastPowerStateChange = new System.DateTime(json["lastPowerStateChange"]);
        return inst;
      }

      public bool available = false;
      public Com.Raritan.Idl.pdumodel.Outlet_2_1_2.PowerState powerState = Com.Raritan.Idl.pdumodel.Outlet_2_1_2.PowerState.PS_OFF;
      public bool switchOnInProgress = false;
      public bool cycleInProgress = false;
      public bool isLoadShed = false;
      public Com.Raritan.Idl.pdumodel.Outlet_2_1_2.LedState ledState = new Com.Raritan.Idl.pdumodel.Outlet_2_1_2.LedState();
      public System.DateTime lastPowerStateChange = new System.DateTime(0);
    }

    public enum StartupState {
      SS_ON,
      SS_OFF,
      SS_LASTKNOWN,
      SS_PDUDEF,
    }

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.name = this.name;
        copy.startupState = this.startupState;
        copy.usePduCycleDelay = this.usePduCycleDelay;
        copy.cycleDelay = this.cycleDelay;
        copy.nonCritical = this.nonCritical;
        copy.sequenceDelay = this.sequenceDelay;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["name"] = this.name;
        json["startupState"] = (int)this.startupState;
        json["usePduCycleDelay"] = this.usePduCycleDelay;
        json["cycleDelay"] = this.cycleDelay;
        json["nonCritical"] = this.nonCritical;
        json["sequenceDelay"] = this.sequenceDelay;
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.name = (string)json["name"];
        inst.startupState = (Com.Raritan.Idl.pdumodel.Outlet_2_1_2.StartupState)(int)json["startupState"];
        inst.usePduCycleDelay = (bool)json["usePduCycleDelay"];
        inst.cycleDelay = (int)json["cycleDelay"];
        inst.nonCritical = (bool)json["nonCritical"];
        inst.sequenceDelay = (int)json["sequenceDelay"];
        return inst;
      }

      public string name = "";
      public Com.Raritan.Idl.pdumodel.Outlet_2_1_2.StartupState startupState = Com.Raritan.Idl.pdumodel.Outlet_2_1_2.StartupState.SS_ON;
      public bool usePduCycleDelay = false;
      public int cycleDelay = 0;
      public bool nonCritical = false;
      public int sequenceDelay = 0;
    }

    public class Sensors : ICloneable {
      public object Clone() {
        Sensors copy = new Sensors();
        copy.voltage = this.voltage;
        copy.current = this.current;
        copy.peakCurrent = this.peakCurrent;
        copy.maximumCurrent = this.maximumCurrent;
        copy.unbalancedCurrent = this.unbalancedCurrent;
        copy.activePower = this.activePower;
        copy.reactivePower = this.reactivePower;
        copy.apparentPower = this.apparentPower;
        copy.powerFactor = this.powerFactor;
        copy.displacementPowerFactor = this.displacementPowerFactor;
        copy.activeEnergy = this.activeEnergy;
        copy.apparentEnergy = this.apparentEnergy;
        copy.phaseAngle = this.phaseAngle;
        copy.lineFrequency = this.lineFrequency;
        copy.outletState = this.outletState;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["voltage"] = this.voltage != null ? this.voltage.Encode() : JsonValue.Null;
        json["current"] = this.current != null ? this.current.Encode() : JsonValue.Null;
        json["peakCurrent"] = this.peakCurrent != null ? this.peakCurrent.Encode() : JsonValue.Null;
        json["maximumCurrent"] = this.maximumCurrent != null ? this.maximumCurrent.Encode() : JsonValue.Null;
        json["unbalancedCurrent"] = this.unbalancedCurrent != null ? this.unbalancedCurrent.Encode() : JsonValue.Null;
        json["activePower"] = this.activePower != null ? this.activePower.Encode() : JsonValue.Null;
        json["reactivePower"] = this.reactivePower != null ? this.reactivePower.Encode() : JsonValue.Null;
        json["apparentPower"] = this.apparentPower != null ? this.apparentPower.Encode() : JsonValue.Null;
        json["powerFactor"] = this.powerFactor != null ? this.powerFactor.Encode() : JsonValue.Null;
        json["displacementPowerFactor"] = this.displacementPowerFactor != null ? this.displacementPowerFactor.Encode() : JsonValue.Null;
        json["activeEnergy"] = this.activeEnergy != null ? this.activeEnergy.Encode() : JsonValue.Null;
        json["apparentEnergy"] = this.apparentEnergy != null ? this.apparentEnergy.Encode() : JsonValue.Null;
        json["phaseAngle"] = this.phaseAngle != null ? this.phaseAngle.Encode() : JsonValue.Null;
        json["lineFrequency"] = this.lineFrequency != null ? this.lineFrequency.Encode() : JsonValue.Null;
        json["outletState"] = this.outletState != null ? this.outletState.Encode() : JsonValue.Null;
        return json;
      }

      public static Sensors Decode(LightJson.JsonObject json, Agent agent) {
        Sensors inst = new Sensors();
        inst.voltage = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["voltage"], agent));
        inst.current = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["current"], agent));
        inst.peakCurrent = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["peakCurrent"], agent));
        inst.maximumCurrent = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["maximumCurrent"], agent));
        inst.unbalancedCurrent = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["unbalancedCurrent"], agent));
        inst.activePower = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["activePower"], agent));
        inst.reactivePower = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["reactivePower"], agent));
        inst.apparentPower = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["apparentPower"], agent));
        inst.powerFactor = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["powerFactor"], agent));
        inst.displacementPowerFactor = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["displacementPowerFactor"], agent));
        inst.activeEnergy = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["activeEnergy"], agent));
        inst.apparentEnergy = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["apparentEnergy"], agent));
        inst.phaseAngle = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["phaseAngle"], agent));
        inst.lineFrequency = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["lineFrequency"], agent));
        inst.outletState = Com.Raritan.Idl.sensors.StateSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["outletState"], agent));
        return inst;
      }

      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 voltage = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 current = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 peakCurrent = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 maximumCurrent = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 unbalancedCurrent = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 activePower = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 reactivePower = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 apparentPower = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 powerFactor = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 displacementPowerFactor = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 activeEnergy = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 apparentEnergy = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 phaseAngle = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 lineFrequency = null;
      public Com.Raritan.Idl.sensors.StateSensor_4_0_2 outletState = null;
    }

    public class PowerControlEvent : Com.Raritan.Idl._event.UserEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.Outlet_2_1_2.PowerControlEvent:1.0.0", Com.Raritan.Idl._event.UserEvent.typeInfo);

      public Com.Raritan.Idl.pdumodel.Outlet_2_1_2.PowerState state = Com.Raritan.Idl.pdumodel.Outlet_2_1_2.PowerState.PS_OFF;
      public bool cycle = false;
    }

    public class StateChangedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.Outlet_2_1_2.StateChangedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public Com.Raritan.Idl.pdumodel.Outlet_2_1_2.State oldState = new Com.Raritan.Idl.pdumodel.Outlet_2_1_2.State();
      public Com.Raritan.Idl.pdumodel.Outlet_2_1_2.State newState = new Com.Raritan.Idl.pdumodel.Outlet_2_1_2.State();
    }

    public class SettingsChangedEvent : Com.Raritan.Idl._event.UserEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.Outlet_2_1_2.SettingsChangedEvent:1.0.0", Com.Raritan.Idl._event.UserEvent.typeInfo);

      public Com.Raritan.Idl.pdumodel.Outlet_2_1_2.Settings oldSettings = new Com.Raritan.Idl.pdumodel.Outlet_2_1_2.Settings();
      public Com.Raritan.Idl.pdumodel.Outlet_2_1_2.Settings newSettings = new Com.Raritan.Idl.pdumodel.Outlet_2_1_2.Settings();
    }

    public class GetMetaDataResult {
      public Com.Raritan.Idl.pdumodel.Outlet_2_1_2.MetaData _ret_;
    }

    public GetMetaDataResult getMetaData() {
      JsonObject _parameters = null;
      var _result = RpcCall("getMetaData", _parameters);
      var _ret = new GetMetaDataResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.Outlet_2_1_2.MetaData.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.Outlet_2_1_2.MetaData.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSensorsResult {
      public Com.Raritan.Idl.pdumodel.Outlet_2_1_2.Sensors _ret_;
    }

    public GetSensorsResult getSensors() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSensors", _parameters);
      var _ret = new GetSensorsResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.Outlet_2_1_2.Sensors.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.Outlet_2_1_2.Sensors.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetStateResult {
      public Com.Raritan.Idl.pdumodel.Outlet_2_1_2.State _ret_;
    }

    public GetStateResult getState() {
      JsonObject _parameters = null;
      var _result = RpcCall("getState", _parameters);
      var _ret = new GetStateResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.Outlet_2_1_2.State.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getState(AsyncRpcResponse<GetStateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getState(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getState(AsyncRpcResponse<GetStateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getState", _parameters,
        _result => {
          try {
            var _ret = new GetStateResult();
            _ret._ret_ = Com.Raritan.Idl.pdumodel.Outlet_2_1_2.State.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetPowerStateResult {
      public int _ret_;
    }

    public SetPowerStateResult setPowerState(Com.Raritan.Idl.pdumodel.Outlet_2_1_2.PowerState pstate) {
      var _parameters = new LightJson.JsonObject();
      _parameters["pstate"] = (int)pstate;

      var _result = RpcCall("setPowerState", _parameters);
      var _ret = new SetPowerStateResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setPowerState(Com.Raritan.Idl.pdumodel.Outlet_2_1_2.PowerState pstate, AsyncRpcResponse<SetPowerStateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setPowerState(pstate, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setPowerState(Com.Raritan.Idl.pdumodel.Outlet_2_1_2.PowerState pstate, AsyncRpcResponse<SetPowerStateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["pstate"] = (int)pstate;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setPowerState", _parameters,
        _result => {
          try {
            var _ret = new SetPowerStateResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class CyclePowerStateResult {
      public int _ret_;
    }

    public CyclePowerStateResult cyclePowerState() {
      JsonObject _parameters = null;
      var _result = RpcCall("cyclePowerState", _parameters);
      var _ret = new CyclePowerStateResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest cyclePowerState(AsyncRpcResponse<CyclePowerStateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return cyclePowerState(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest cyclePowerState(AsyncRpcResponse<CyclePowerStateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("cyclePowerState", _parameters,
        _result => {
          try {
            var _ret = new CyclePowerStateResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.pdumodel.Outlet_2_1_2.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.Outlet_2_1_2.Settings.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.Outlet_2_1_2.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.pdumodel.Outlet_2_1_2.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.pdumodel.Outlet_2_1_2.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.pdumodel.Outlet_2_1_2.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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

    public class GetIOPResult {
      public Com.Raritan.Idl.pdumodel.Inlet_2_0_2 i;
      public Com.Raritan.Idl.pdumodel.OverCurrentProtector_3_0_2 o;
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.pdumodel.Pole_4_0_2> p;
    }

    public GetIOPResult getIOP() {
      JsonObject _parameters = null;
      var _result = RpcCall("getIOP", _parameters);
      var _ret = new GetIOPResult();
      _ret.i = Com.Raritan.Idl.pdumodel.Inlet_2_0_2.StaticCast(ObjectProxy.Decode(_result["i"], agent));
      _ret.o = Com.Raritan.Idl.pdumodel.OverCurrentProtector_3_0_2.StaticCast(ObjectProxy.Decode(_result["o"], agent));
      _ret.p = new System.Collections.Generic.List<Com.Raritan.Idl.pdumodel.Pole_4_0_2>(_result["p"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.pdumodel.Pole_4_0_2.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getIOP(AsyncRpcResponse<GetIOPResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getIOP(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getIOP(AsyncRpcResponse<GetIOPResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getIOP", _parameters,
        _result => {
          try {
            var _ret = new GetIOPResult();
            _ret.i = Com.Raritan.Idl.pdumodel.Inlet_2_0_2.StaticCast(ObjectProxy.Decode(_result["i"], agent));
            _ret.o = Com.Raritan.Idl.pdumodel.OverCurrentProtector_3_0_2.StaticCast(ObjectProxy.Decode(_result["o"], agent));
            _ret.p = new System.Collections.Generic.List<Com.Raritan.Idl.pdumodel.Pole_4_0_2>(_result["p"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.pdumodel.Pole_4_0_2.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetControllerResult {
      public Com.Raritan.Idl.pdumodel.Controller_4_0_0 _ret_;
    }

    public GetControllerResult getController() {
      JsonObject _parameters = null;
      var _result = RpcCall("getController", _parameters);
      var _ret = new GetControllerResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.Controller_4_0_0.StaticCast(ObjectProxy.Decode(_result["_ret_"], agent));
      return _ret;
    }

    public AsyncRequest getController(AsyncRpcResponse<GetControllerResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getController(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getController(AsyncRpcResponse<GetControllerResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getController", _parameters,
        _result => {
          try {
            var _ret = new GetControllerResult();
            _ret._ret_ = Com.Raritan.Idl.pdumodel.Controller_4_0_0.StaticCast(ObjectProxy.Decode(_result["_ret_"], agent));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class UnstickResult {
      public int _ret_;
    }

    public UnstickResult unstick() {
      JsonObject _parameters = null;
      var _result = RpcCall("unstick", _parameters);
      var _ret = new UnstickResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest unstick(AsyncRpcResponse<UnstickResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return unstick(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest unstick(AsyncRpcResponse<UnstickResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("unstick", _parameters,
        _result => {
          try {
            var _ret = new UnstickResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
