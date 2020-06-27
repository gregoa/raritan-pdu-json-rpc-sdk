// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Lhx.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.lhxmodel {
  public class Lhx : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("lhxmodel.Lhx:1.0.0", null);

    public Lhx(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Lhx(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Lhx StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Lhx(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int ERR_INVALID_PARAMS = 1;

    public enum Events {
      EVT_KEY_OPSTATE_CHANGED,
      EVT_KEY_SETTINGS_CHANGED,
    }

    public class MetaData : ICloneable {
      public object Clone() {
        MetaData copy = new MetaData();
        copy.model = this.model;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["model"] = this.model;
        return json;
      }

      public static MetaData Decode(LightJson.JsonObject json, Agent agent) {
        MetaData inst = new MetaData();
        inst.model = (string)json["model"];
        return inst;
      }

      public string model = "";
    }

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.setpointWaterValve = this.setpointWaterValve;
        copy.setpointVentilators = this.setpointVentilators;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["setpointWaterValve"] = this.setpointWaterValve;
        json["setpointVentilators"] = this.setpointVentilators;
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.setpointWaterValve = (double)json["setpointWaterValve"];
        inst.setpointVentilators = (double)json["setpointVentilators"];
        return inst;
      }

      public double setpointWaterValve = 0.0;
      public double setpointVentilators = 0.0;
    }

    public class Sensors : ICloneable {
      public object Clone() {
        Sensors copy = new Sensors();
        copy.airTemp = this.airTemp;
        copy.waterTemp = this.waterTemp;
        copy.fanSpeed = this.fanSpeed;
        copy.doorContact = this.doorContact;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["airTemp"] = new JsonArray(this.airTemp.Select(
          _value => (JsonValue)(_value != null ? _value.Encode() : JsonValue.Null)));
        json["waterTemp"] = new JsonArray(this.waterTemp.Select(
          _value => (JsonValue)(_value != null ? _value.Encode() : JsonValue.Null)));
        json["fanSpeed"] = new JsonArray(this.fanSpeed.Select(
          _value => (JsonValue)(_value != null ? _value.Encode() : JsonValue.Null)));
        json["doorContact"] = this.doorContact != null ? this.doorContact.Encode() : JsonValue.Null;
        return json;
      }

      public static Sensors Decode(LightJson.JsonObject json, Agent agent) {
        Sensors inst = new Sensors();
        inst.airTemp = new System.Collections.Generic.List<Com.Raritan.Idl.lhxmodel.Sensor>(json["airTemp"].AsJsonArray.Select(
          _value => Com.Raritan.Idl.lhxmodel.Sensor.StaticCast(ObjectProxy.Decode(_value, agent))));
        inst.waterTemp = new System.Collections.Generic.List<Com.Raritan.Idl.lhxmodel.Sensor>(json["waterTemp"].AsJsonArray.Select(
          _value => Com.Raritan.Idl.lhxmodel.Sensor.StaticCast(ObjectProxy.Decode(_value, agent))));
        inst.fanSpeed = new System.Collections.Generic.List<Com.Raritan.Idl.lhxmodel.Sensor>(json["fanSpeed"].AsJsonArray.Select(
          _value => Com.Raritan.Idl.lhxmodel.Sensor.StaticCast(ObjectProxy.Decode(_value, agent))));
        inst.doorContact = Com.Raritan.Idl.lhxmodel.Sensor.StaticCast(ObjectProxy.Decode(json["doorContact"], agent));
        return inst;
      }

      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.lhxmodel.Sensor> airTemp = new System.Collections.Generic.List<Com.Raritan.Idl.lhxmodel.Sensor>();
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.lhxmodel.Sensor> waterTemp = new System.Collections.Generic.List<Com.Raritan.Idl.lhxmodel.Sensor>();
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.lhxmodel.Sensor> fanSpeed = new System.Collections.Generic.List<Com.Raritan.Idl.lhxmodel.Sensor>();
      public Com.Raritan.Idl.lhxmodel.Sensor doorContact = null;
    }

    public class AlertStatus : ICloneable {
      public object Clone() {
        AlertStatus copy = new AlertStatus();
        copy.sensorFailure = this.sensorFailure;
        copy.fanFailure = this.fanFailure;
        copy.powerSupplyFailure = this.powerSupplyFailure;
        copy.thresholdAirOutlet = this.thresholdAirOutlet;
        copy.thresholdAirInlet = this.thresholdAirInlet;
        copy.thresholdWaterInlet = this.thresholdWaterInlet;
        copy.doorOpened = this.doorOpened;
        copy.maximumCoolingRequest = this.maximumCoolingRequest;
        copy.emergencyCooling = this.emergencyCooling;
        copy.waterLeak = this.waterLeak;
        copy.thresholdHumidity = this.thresholdHumidity;
        copy.externalWaterCoolingFailure = this.externalWaterCoolingFailure;
        copy.thresholdWaterOutlet = this.thresholdWaterOutlet;
        copy.parameterDataLoss = this.parameterDataLoss;
        copy.stBusError = this.stBusError;
        copy.collectiveFault = this.collectiveFault;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["sensorFailure"] = new JsonArray(this.sensorFailure.Select(
          _value => (JsonValue)(_value)));
        json["fanFailure"] = new JsonArray(this.fanFailure.Select(
          _value => (JsonValue)(_value)));
        json["powerSupplyFailure"] = new JsonArray(this.powerSupplyFailure.Select(
          _value => (JsonValue)(_value)));
        json["thresholdAirOutlet"] = this.thresholdAirOutlet;
        json["thresholdAirInlet"] = this.thresholdAirInlet;
        json["thresholdWaterInlet"] = this.thresholdWaterInlet;
        json["doorOpened"] = this.doorOpened;
        json["maximumCoolingRequest"] = this.maximumCoolingRequest;
        json["emergencyCooling"] = this.emergencyCooling;
        json["waterLeak"] = this.waterLeak;
        json["thresholdHumidity"] = this.thresholdHumidity;
        json["externalWaterCoolingFailure"] = this.externalWaterCoolingFailure;
        json["thresholdWaterOutlet"] = this.thresholdWaterOutlet;
        json["parameterDataLoss"] = this.parameterDataLoss;
        json["stBusError"] = this.stBusError;
        json["collectiveFault"] = this.collectiveFault;
        return json;
      }

      public static AlertStatus Decode(LightJson.JsonObject json, Agent agent) {
        AlertStatus inst = new AlertStatus();
        inst.sensorFailure = new System.Collections.Generic.List<bool>(json["sensorFailure"].AsJsonArray.Select(
          _value => (bool)_value));
        inst.fanFailure = new System.Collections.Generic.List<bool>(json["fanFailure"].AsJsonArray.Select(
          _value => (bool)_value));
        inst.powerSupplyFailure = new System.Collections.Generic.List<bool>(json["powerSupplyFailure"].AsJsonArray.Select(
          _value => (bool)_value));
        inst.thresholdAirOutlet = (bool)json["thresholdAirOutlet"];
        inst.thresholdAirInlet = (bool)json["thresholdAirInlet"];
        inst.thresholdWaterInlet = (bool)json["thresholdWaterInlet"];
        inst.doorOpened = (bool)json["doorOpened"];
        inst.maximumCoolingRequest = (bool)json["maximumCoolingRequest"];
        inst.emergencyCooling = (bool)json["emergencyCooling"];
        inst.waterLeak = (bool)json["waterLeak"];
        inst.thresholdHumidity = (bool)json["thresholdHumidity"];
        inst.externalWaterCoolingFailure = (bool)json["externalWaterCoolingFailure"];
        inst.thresholdWaterOutlet = (bool)json["thresholdWaterOutlet"];
        inst.parameterDataLoss = (bool)json["parameterDataLoss"];
        inst.stBusError = (bool)json["stBusError"];
        inst.collectiveFault = (bool)json["collectiveFault"];
        return inst;
      }

      public System.Collections.Generic.IEnumerable<bool> sensorFailure = new System.Collections.Generic.List<bool>();
      public System.Collections.Generic.IEnumerable<bool> fanFailure = new System.Collections.Generic.List<bool>();
      public System.Collections.Generic.IEnumerable<bool> powerSupplyFailure = new System.Collections.Generic.List<bool>();
      public bool thresholdAirOutlet = false;
      public bool thresholdAirInlet = false;
      public bool thresholdWaterInlet = false;
      public bool doorOpened = false;
      public bool maximumCoolingRequest = false;
      public bool emergencyCooling = false;
      public bool waterLeak = false;
      public bool thresholdHumidity = false;
      public bool externalWaterCoolingFailure = false;
      public bool thresholdWaterOutlet = false;
      public bool parameterDataLoss = false;
      public bool stBusError = false;
      public bool collectiveFault = false;
    }

    public class OpState : ICloneable {
      public object Clone() {
        OpState copy = new OpState();
        copy.on = this.on;
        copy.alertStatus = this.alertStatus;
        copy.operatingHoursLhx = this.operatingHoursLhx;
        copy.operatingHoursFan = this.operatingHoursFan;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["on"] = this.on;
        json["alertStatus"] = this.alertStatus.Encode();
        json["operatingHoursLhx"] = this.operatingHoursLhx;
        json["operatingHoursFan"] = new JsonArray(this.operatingHoursFan.Select(
          _value => (JsonValue)(_value)));
        return json;
      }

      public static OpState Decode(LightJson.JsonObject json, Agent agent) {
        OpState inst = new OpState();
        inst.on = (bool)json["on"];
        inst.alertStatus = Com.Raritan.Idl.lhxmodel.Lhx.AlertStatus.Decode(json["alertStatus"], agent);
        inst.operatingHoursLhx = (int)json["operatingHoursLhx"];
        inst.operatingHoursFan = new System.Collections.Generic.List<int>(json["operatingHoursFan"].AsJsonArray.Select(
          _value => (int)_value));
        return inst;
      }

      public bool on = false;
      public Com.Raritan.Idl.lhxmodel.Lhx.AlertStatus alertStatus = new Com.Raritan.Idl.lhxmodel.Lhx.AlertStatus();
      public int operatingHoursLhx = 0;
      public System.Collections.Generic.IEnumerable<int> operatingHoursFan = new System.Collections.Generic.List<int>();
    }

    public class GetMetaDataResult {
      public Com.Raritan.Idl.lhxmodel.Lhx.MetaData _ret_;
    }

    public GetMetaDataResult getMetaData() {
      JsonObject _parameters = null;
      var _result = RpcCall("getMetaData", _parameters);
      var _ret = new GetMetaDataResult();
      _ret._ret_ = Com.Raritan.Idl.lhxmodel.Lhx.MetaData.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.lhxmodel.Lhx.MetaData.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.lhxmodel.Lhx.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.lhxmodel.Lhx.Settings.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.lhxmodel.Lhx.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.lhxmodel.Lhx.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.lhxmodel.Lhx.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.lhxmodel.Lhx.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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

    public class GetSensorsResult {
      public Com.Raritan.Idl.lhxmodel.Lhx.Sensors _ret_;
    }

    public GetSensorsResult getSensors() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSensors", _parameters);
      var _ret = new GetSensorsResult();
      _ret._ret_ = Com.Raritan.Idl.lhxmodel.Lhx.Sensors.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.lhxmodel.Lhx.Sensors.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetOpStateResult {
      public Com.Raritan.Idl.lhxmodel.Lhx.OpState _ret_;
    }

    public GetOpStateResult getOpState() {
      JsonObject _parameters = null;
      var _result = RpcCall("getOpState", _parameters);
      var _ret = new GetOpStateResult();
      _ret._ret_ = Com.Raritan.Idl.lhxmodel.Lhx.OpState.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getOpState(AsyncRpcResponse<GetOpStateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getOpState(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getOpState(AsyncRpcResponse<GetOpStateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getOpState", _parameters,
        _result => {
          try {
            var _ret = new GetOpStateResult();
            _ret._ret_ = Com.Raritan.Idl.lhxmodel.Lhx.OpState.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetPowerStateResult {
    }

    public SetPowerStateResult setPowerState(Com.Raritan.Idl.sensors.Sensor.OnOffState state) {
      var _parameters = new LightJson.JsonObject();
      _parameters["state"] = (int)state;

      var _result = RpcCall("setPowerState", _parameters);
      var _ret = new SetPowerStateResult();
      return _ret;
    }

    public AsyncRequest setPowerState(Com.Raritan.Idl.sensors.Sensor.OnOffState state, AsyncRpcResponse<SetPowerStateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setPowerState(state, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setPowerState(Com.Raritan.Idl.sensors.Sensor.OnOffState state, AsyncRpcResponse<SetPowerStateResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["state"] = (int)state;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setPowerState", _parameters,
        _result => {
          try {
            var _ret = new SetPowerStateResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
