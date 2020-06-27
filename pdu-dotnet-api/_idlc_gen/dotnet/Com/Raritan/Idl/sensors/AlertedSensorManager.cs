// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from AlertedSensorManager.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.sensors {
  public class AlertedSensorManager : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("sensors.AlertedSensorManager:1.0.0", null);

    public AlertedSensorManager(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public AlertedSensorManager(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new AlertedSensorManager StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new AlertedSensorManager(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public enum AlertState {
      UNAVAILABLE,
      NORMAL,
      CRITICAL,
      WARNED,
    }

    public class SensorCounts : ICloneable {
      public object Clone() {
        SensorCounts copy = new SensorCounts();
        copy.total = this.total;
        copy.unavailable = this.unavailable;
        copy.critical = this.critical;
        copy.warned = this.warned;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["total"] = this.total;
        json["unavailable"] = this.unavailable;
        json["critical"] = this.critical;
        json["warned"] = this.warned;
        return json;
      }

      public static SensorCounts Decode(LightJson.JsonObject json, Agent agent) {
        SensorCounts inst = new SensorCounts();
        inst.total = (int)json["total"];
        inst.unavailable = (int)json["unavailable"];
        inst.critical = (int)json["critical"];
        inst.warned = (int)json["warned"];
        return inst;
      }

      public int total = 0;
      public int unavailable = 0;
      public int critical = 0;
      public int warned = 0;
    }

    public class SensorData : ICloneable {
      public object Clone() {
        SensorData copy = new SensorData();
        copy.sensor = this.sensor;
        copy.parent = this.parent;
        copy.alertState = this.alertState;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["sensor"] = this.sensor != null ? this.sensor.Encode() : JsonValue.Null;
        json["parent"] = this.parent != null ? this.parent.Encode() : JsonValue.Null;
        json["alertState"] = (int)this.alertState;
        return json;
      }

      public static SensorData Decode(LightJson.JsonObject json, Agent agent) {
        SensorData inst = new SensorData();
        inst.sensor = Com.Raritan.Idl.sensors.Sensor_4_0_2.StaticCast(ObjectProxy.Decode(json["sensor"], agent));
        inst.parent = ObjectProxy.Decode(json["parent"], agent);
        inst.alertState = (Com.Raritan.Idl.sensors.AlertedSensorManager.AlertState)(int)json["alertState"];
        return inst;
      }

      public Com.Raritan.Idl.sensors.Sensor_4_0_2 sensor = null;
      public ObjectProxy parent = null;
      public Com.Raritan.Idl.sensors.AlertedSensorManager.AlertState alertState = Com.Raritan.Idl.sensors.AlertedSensorManager.AlertState.UNAVAILABLE;
    }

    public class MonitoredSensorsChangedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("sensors.AlertedSensorManager.MonitoredSensorsChangedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public Com.Raritan.Idl.sensors.AlertedSensorManager.SensorCounts counts = new Com.Raritan.Idl.sensors.AlertedSensorManager.SensorCounts();
    }

    public class AlertedSensorsChangedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("sensors.AlertedSensorManager.AlertedSensorsChangedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public Com.Raritan.Idl.sensors.AlertedSensorManager.SensorCounts counts = new Com.Raritan.Idl.sensors.AlertedSensorManager.SensorCounts();
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.sensors.AlertedSensorManager.SensorData> changedSensors = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.AlertedSensorManager.SensorData>();
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.sensors.Sensor_4_0_2> removedSensors = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Sensor_4_0_2>();
    }

    public class GetSensorCountsResult {
      public Com.Raritan.Idl.sensors.AlertedSensorManager.SensorCounts _ret_;
    }

    public GetSensorCountsResult getSensorCounts() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSensorCounts", _parameters);
      var _ret = new GetSensorCountsResult();
      _ret._ret_ = Com.Raritan.Idl.sensors.AlertedSensorManager.SensorCounts.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getSensorCounts(AsyncRpcResponse<GetSensorCountsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getSensorCounts(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getSensorCounts(AsyncRpcResponse<GetSensorCountsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getSensorCounts", _parameters,
        _result => {
          try {
            var _ret = new GetSensorCountsResult();
            _ret._ret_ = Com.Raritan.Idl.sensors.AlertedSensorManager.SensorCounts.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetAllSensorsResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.sensors.AlertedSensorManager.SensorData> _ret_;
    }

    public GetAllSensorsResult getAllSensors() {
      JsonObject _parameters = null;
      var _result = RpcCall("getAllSensors", _parameters);
      var _ret = new GetAllSensorsResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.AlertedSensorManager.SensorData>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.sensors.AlertedSensorManager.SensorData.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getAllSensors(AsyncRpcResponse<GetAllSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getAllSensors(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getAllSensors(AsyncRpcResponse<GetAllSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getAllSensors", _parameters,
        _result => {
          try {
            var _ret = new GetAllSensorsResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.AlertedSensorManager.SensorData>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.sensors.AlertedSensorManager.SensorData.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetAlertedSensorsResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.sensors.AlertedSensorManager.SensorData> _ret_;
    }

    public GetAlertedSensorsResult getAlertedSensors() {
      JsonObject _parameters = null;
      var _result = RpcCall("getAlertedSensors", _parameters);
      var _ret = new GetAlertedSensorsResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.AlertedSensorManager.SensorData>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.sensors.AlertedSensorManager.SensorData.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getAlertedSensors(AsyncRpcResponse<GetAlertedSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getAlertedSensors(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getAlertedSensors(AsyncRpcResponse<GetAlertedSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getAlertedSensors", _parameters,
        _result => {
          try {
            var _ret = new GetAlertedSensorsResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.AlertedSensorManager.SensorData>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.sensors.AlertedSensorManager.SensorData.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}