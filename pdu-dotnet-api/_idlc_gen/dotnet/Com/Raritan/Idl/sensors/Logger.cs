// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from SensorLogger.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.sensors {
  public class Logger : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("sensors.Logger:1.0.0", null);

    public Logger(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Logger(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Logger StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Logger(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public enum Events {
      EVT_KEY_SETTINGS_CHANGED,
      EVT_KEY_LOGGED_SENSORS_CHANGED,
    }

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.isEnabled = this.isEnabled;
        copy.samplePeriod = this.samplePeriod;
        copy.samplesPerRecord = this.samplesPerRecord;
        copy.oldestRecId = this.oldestRecId;
        copy.newestRecId = this.newestRecId;
        copy.logCapacity = this.logCapacity;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["isEnabled"] = this.isEnabled;
        json["samplePeriod"] = this.samplePeriod;
        json["samplesPerRecord"] = this.samplesPerRecord;
        json["oldestRecId"] = this.oldestRecId;
        json["newestRecId"] = this.newestRecId;
        json["logCapacity"] = this.logCapacity;
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.isEnabled = (bool)json["isEnabled"];
        inst.samplePeriod = (int)json["samplePeriod"];
        inst.samplesPerRecord = (int)json["samplesPerRecord"];
        inst.oldestRecId = (int)json["oldestRecId"];
        inst.newestRecId = (int)json["newestRecId"];
        inst.logCapacity = (int)json["logCapacity"];
        return inst;
      }

      public bool isEnabled = false;
      public int samplePeriod = 0;
      public int samplesPerRecord = 0;
      public int oldestRecId = 0;
      public int newestRecId = 0;
      public int logCapacity = 0;
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.sensors.Logger.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.sensors.Logger.Settings.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.sensors.Logger.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(bool isEnabled, int samplesPerRecord) {
      var _parameters = new LightJson.JsonObject();
      _parameters["isEnabled"] = isEnabled;
      _parameters["samplesPerRecord"] = samplesPerRecord;

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(bool isEnabled, int samplesPerRecord, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(isEnabled, samplesPerRecord, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(bool isEnabled, int samplesPerRecord, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["isEnabled"] = isEnabled;
        _parameters["samplesPerRecord"] = samplesPerRecord;
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

    public enum SensorState {
      UNAVAILABLE,
      OPEN,
      CLOSE,
      BELOW_LOWER_CRITICAL,
      BELOW_LOWER_WARNING,
      NORMAL,
      ABOVE_UPPER_WARNING,
      ABOVE_UPPER_CRITICAL,
      ON,
      OFF,
      ALARMED,
      OK,
      MARGINAL,
      FAIL,
      YES,
      NO,
      STANDBY,
      ONE,
      TWO,
      IN_SYNC,
      OUT_OF_SYNC,
    }

    public class GetTimeStampsResult {
      public int _ret_;
      public System.Collections.Generic.IEnumerable<System.DateTime> timestamps;
    }

    public GetTimeStampsResult getTimeStamps(int recid, int count) {
      var _parameters = new LightJson.JsonObject();
      _parameters["recid"] = recid;
      _parameters["count"] = count;

      var _result = RpcCall("getTimeStamps", _parameters);
      var _ret = new GetTimeStampsResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.timestamps = new System.Collections.Generic.List<System.DateTime>(_result["timestamps"].AsJsonArray.Select(
        _value => new System.DateTime(_value)));
      return _ret;
    }

    public AsyncRequest getTimeStamps(int recid, int count, AsyncRpcResponse<GetTimeStampsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getTimeStamps(recid, count, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getTimeStamps(int recid, int count, AsyncRpcResponse<GetTimeStampsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["recid"] = recid;
        _parameters["count"] = count;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("getTimeStamps", _parameters,
        _result => {
          try {
            var _ret = new GetTimeStampsResult();
            _ret._ret_ = (int)_result["_ret_"];
            _ret.timestamps = new System.Collections.Generic.List<System.DateTime>(_result["timestamps"].AsJsonArray.Select(
              _value => new System.DateTime(_value)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class Record : ICloneable {
      public object Clone() {
        Record copy = new Record();
        copy.available = this.available;
        copy.takenValidSamples = this.takenValidSamples;
        copy.state = this.state;
        copy.minValue = this.minValue;
        copy.avgValue = this.avgValue;
        copy.maxValue = this.maxValue;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["available"] = this.available;
        json["takenValidSamples"] = this.takenValidSamples;
        json["state"] = (int)this.state;
        json["minValue"] = this.minValue;
        json["avgValue"] = this.avgValue;
        json["maxValue"] = this.maxValue;
        return json;
      }

      public static Record Decode(LightJson.JsonObject json, Agent agent) {
        Record inst = new Record();
        inst.available = (bool)json["available"];
        inst.takenValidSamples = (int)json["takenValidSamples"];
        inst.state = (Com.Raritan.Idl.sensors.Logger.SensorState)(int)json["state"];
        inst.minValue = (double)json["minValue"];
        inst.avgValue = (double)json["avgValue"];
        inst.maxValue = (double)json["maxValue"];
        return inst;
      }

      public bool available = false;
      public int takenValidSamples = 0;
      public Com.Raritan.Idl.sensors.Logger.SensorState state = Com.Raritan.Idl.sensors.Logger.SensorState.UNAVAILABLE;
      public double minValue = 0.0;
      public double avgValue = 0.0;
      public double maxValue = 0.0;
    }

    public class GetSensorRecordsResult {
      public int _ret_;
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.sensors.Logger.Record> recs;
    }

    public GetSensorRecordsResult getSensorRecords(Com.Raritan.Idl.sensors.Sensor_3_0_0 sensor, int recid, int count) {
      var _parameters = new LightJson.JsonObject();
      _parameters["sensor"] = sensor != null ? sensor.Encode() : JsonValue.Null;
      _parameters["recid"] = recid;
      _parameters["count"] = count;

      var _result = RpcCall("getSensorRecords", _parameters);
      var _ret = new GetSensorRecordsResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.recs = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Logger.Record>(_result["recs"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.sensors.Logger.Record.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getSensorRecords(Com.Raritan.Idl.sensors.Sensor_3_0_0 sensor, int recid, int count, AsyncRpcResponse<GetSensorRecordsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getSensorRecords(sensor, recid, count, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getSensorRecords(Com.Raritan.Idl.sensors.Sensor_3_0_0 sensor, int recid, int count, AsyncRpcResponse<GetSensorRecordsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["sensor"] = sensor != null ? sensor.Encode() : JsonValue.Null;
        _parameters["recid"] = recid;
        _parameters["count"] = count;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("getSensorRecords", _parameters,
        _result => {
          try {
            var _ret = new GetSensorRecordsResult();
            _ret._ret_ = (int)_result["_ret_"];
            _ret.recs = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Logger.Record>(_result["recs"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.sensors.Logger.Record.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetPeripheralDeviceRecordsResult {
      public int _ret_;
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.sensors.Logger.Record> recs;
    }

    public GetPeripheralDeviceRecordsResult getPeripheralDeviceRecords(Com.Raritan.Idl.peripheral.DeviceSlot slot, int recid, int count) {
      var _parameters = new LightJson.JsonObject();
      _parameters["slot"] = slot != null ? slot.Encode() : JsonValue.Null;
      _parameters["recid"] = recid;
      _parameters["count"] = count;

      var _result = RpcCall("getPeripheralDeviceRecords", _parameters);
      var _ret = new GetPeripheralDeviceRecordsResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.recs = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Logger.Record>(_result["recs"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.sensors.Logger.Record.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getPeripheralDeviceRecords(Com.Raritan.Idl.peripheral.DeviceSlot slot, int recid, int count, AsyncRpcResponse<GetPeripheralDeviceRecordsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getPeripheralDeviceRecords(slot, recid, count, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getPeripheralDeviceRecords(Com.Raritan.Idl.peripheral.DeviceSlot slot, int recid, int count, AsyncRpcResponse<GetPeripheralDeviceRecordsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["slot"] = slot != null ? slot.Encode() : JsonValue.Null;
        _parameters["recid"] = recid;
        _parameters["count"] = count;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("getPeripheralDeviceRecords", _parameters,
        _result => {
          try {
            var _ret = new GetPeripheralDeviceRecordsResult();
            _ret._ret_ = (int)_result["_ret_"];
            _ret.recs = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Logger.Record>(_result["recs"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.sensors.Logger.Record.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class TimedRecord : ICloneable {
      public object Clone() {
        TimedRecord copy = new TimedRecord();
        copy.timestamp = this.timestamp;
        copy.record = this.record;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["timestamp"] = this.timestamp.Ticks;
        json["record"] = this.record.Encode();
        return json;
      }

      public static TimedRecord Decode(LightJson.JsonObject json, Agent agent) {
        TimedRecord inst = new TimedRecord();
        inst.timestamp = new System.DateTime(json["timestamp"]);
        inst.record = Com.Raritan.Idl.sensors.Logger.Record.Decode(json["record"], agent);
        return inst;
      }

      public System.DateTime timestamp = new System.DateTime(0);
      public Com.Raritan.Idl.sensors.Logger.Record record = new Com.Raritan.Idl.sensors.Logger.Record();
    }

    public class GetSensorTimedRecordsResult {
      public int _ret_;
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.sensors.Logger.TimedRecord> recs;
    }

    public GetSensorTimedRecordsResult getSensorTimedRecords(Com.Raritan.Idl.sensors.Sensor_3_0_0 sensor, int recid, int count) {
      var _parameters = new LightJson.JsonObject();
      _parameters["sensor"] = sensor != null ? sensor.Encode() : JsonValue.Null;
      _parameters["recid"] = recid;
      _parameters["count"] = count;

      var _result = RpcCall("getSensorTimedRecords", _parameters);
      var _ret = new GetSensorTimedRecordsResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.recs = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Logger.TimedRecord>(_result["recs"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.sensors.Logger.TimedRecord.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getSensorTimedRecords(Com.Raritan.Idl.sensors.Sensor_3_0_0 sensor, int recid, int count, AsyncRpcResponse<GetSensorTimedRecordsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getSensorTimedRecords(sensor, recid, count, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getSensorTimedRecords(Com.Raritan.Idl.sensors.Sensor_3_0_0 sensor, int recid, int count, AsyncRpcResponse<GetSensorTimedRecordsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["sensor"] = sensor != null ? sensor.Encode() : JsonValue.Null;
        _parameters["recid"] = recid;
        _parameters["count"] = count;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("getSensorTimedRecords", _parameters,
        _result => {
          try {
            var _ret = new GetSensorTimedRecordsResult();
            _ret._ret_ = (int)_result["_ret_"];
            _ret.recs = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Logger.TimedRecord>(_result["recs"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.sensors.Logger.TimedRecord.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetPeripheralDeviceTimedRecordsResult {
      public int _ret_;
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.sensors.Logger.TimedRecord> recs;
    }

    public GetPeripheralDeviceTimedRecordsResult getPeripheralDeviceTimedRecords(Com.Raritan.Idl.peripheral.DeviceSlot slot, int recid, int count) {
      var _parameters = new LightJson.JsonObject();
      _parameters["slot"] = slot != null ? slot.Encode() : JsonValue.Null;
      _parameters["recid"] = recid;
      _parameters["count"] = count;

      var _result = RpcCall("getPeripheralDeviceTimedRecords", _parameters);
      var _ret = new GetPeripheralDeviceTimedRecordsResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.recs = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Logger.TimedRecord>(_result["recs"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.sensors.Logger.TimedRecord.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getPeripheralDeviceTimedRecords(Com.Raritan.Idl.peripheral.DeviceSlot slot, int recid, int count, AsyncRpcResponse<GetPeripheralDeviceTimedRecordsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getPeripheralDeviceTimedRecords(slot, recid, count, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getPeripheralDeviceTimedRecords(Com.Raritan.Idl.peripheral.DeviceSlot slot, int recid, int count, AsyncRpcResponse<GetPeripheralDeviceTimedRecordsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["slot"] = slot != null ? slot.Encode() : JsonValue.Null;
        _parameters["recid"] = recid;
        _parameters["count"] = count;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("getPeripheralDeviceTimedRecords", _parameters,
        _result => {
          try {
            var _ret = new GetPeripheralDeviceTimedRecordsResult();
            _ret._ret_ = (int)_result["_ret_"];
            _ret.recs = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Logger.TimedRecord>(_result["recs"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.sensors.Logger.TimedRecord.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SensorSet : ICloneable {
      public object Clone() {
        SensorSet copy = new SensorSet();
        copy.sensors = this.sensors;
        copy.slots = this.slots;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["sensors"] = new JsonArray(this.sensors.Select(
          _value => (JsonValue)(_value != null ? _value.Encode() : JsonValue.Null)));
        json["slots"] = new JsonArray(this.slots.Select(
          _value => (JsonValue)(_value != null ? _value.Encode() : JsonValue.Null)));
        return json;
      }

      public static SensorSet Decode(LightJson.JsonObject json, Agent agent) {
        SensorSet inst = new SensorSet();
        inst.sensors = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Sensor_3_0_0>(json["sensors"].AsJsonArray.Select(
          _value => Com.Raritan.Idl.sensors.Sensor_3_0_0.StaticCast(ObjectProxy.Decode(_value, agent))));
        inst.slots = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.DeviceSlot>(json["slots"].AsJsonArray.Select(
          _value => Com.Raritan.Idl.peripheral.DeviceSlot.StaticCast(ObjectProxy.Decode(_value, agent))));
        return inst;
      }

      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.sensors.Sensor_3_0_0> sensors = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Sensor_3_0_0>();
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.peripheral.DeviceSlot> slots = new System.Collections.Generic.List<Com.Raritan.Idl.peripheral.DeviceSlot>();
    }

    public class GetLoggedSensorsResult {
      public Com.Raritan.Idl.sensors.Logger.SensorSet _ret_;
    }

    public GetLoggedSensorsResult getLoggedSensors() {
      JsonObject _parameters = null;
      var _result = RpcCall("getLoggedSensors", _parameters);
      var _ret = new GetLoggedSensorsResult();
      _ret._ret_ = Com.Raritan.Idl.sensors.Logger.SensorSet.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getLoggedSensors(AsyncRpcResponse<GetLoggedSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getLoggedSensors(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getLoggedSensors(AsyncRpcResponse<GetLoggedSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getLoggedSensors", _parameters,
        _result => {
          try {
            var _ret = new GetLoggedSensorsResult();
            _ret._ret_ = Com.Raritan.Idl.sensors.Logger.SensorSet.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetLoggedSensorsResult {
      public int _ret_;
    }

    public SetLoggedSensorsResult setLoggedSensors(Com.Raritan.Idl.sensors.Logger.SensorSet sensors) {
      var _parameters = new LightJson.JsonObject();
      _parameters["sensors"] = sensors.Encode();

      var _result = RpcCall("setLoggedSensors", _parameters);
      var _ret = new SetLoggedSensorsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setLoggedSensors(Com.Raritan.Idl.sensors.Logger.SensorSet sensors, AsyncRpcResponse<SetLoggedSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setLoggedSensors(sensors, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setLoggedSensors(Com.Raritan.Idl.sensors.Logger.SensorSet sensors, AsyncRpcResponse<SetLoggedSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["sensors"] = sensors.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setLoggedSensors", _parameters,
        _result => {
          try {
            var _ret = new SetLoggedSensorsResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class EnableAllSensorsResult {
    }

    public EnableAllSensorsResult enableAllSensors() {
      JsonObject _parameters = null;
      var _result = RpcCall("enableAllSensors", _parameters);
      var _ret = new EnableAllSensorsResult();
      return _ret;
    }

    public AsyncRequest enableAllSensors(AsyncRpcResponse<EnableAllSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return enableAllSensors(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest enableAllSensors(AsyncRpcResponse<EnableAllSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("enableAllSensors", _parameters,
        _result => {
          try {
            var _ret = new EnableAllSensorsResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class DisableAllSensorsResult {
    }

    public DisableAllSensorsResult disableAllSensors() {
      JsonObject _parameters = null;
      var _result = RpcCall("disableAllSensors", _parameters);
      var _ret = new DisableAllSensorsResult();
      return _ret;
    }

    public AsyncRequest disableAllSensors(AsyncRpcResponse<DisableAllSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return disableAllSensors(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest disableAllSensors(AsyncRpcResponse<DisableAllSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("disableAllSensors", _parameters,
        _result => {
          try {
            var _ret = new DisableAllSensorsResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSensorSetTimestampResult {
      public System.DateTime _ret_;
    }

    public GetSensorSetTimestampResult getSensorSetTimestamp() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSensorSetTimestamp", _parameters);
      var _ret = new GetSensorSetTimestampResult();
      _ret._ret_ = new System.DateTime(_result["_ret_"]);
      return _ret;
    }

    public AsyncRequest getSensorSetTimestamp(AsyncRpcResponse<GetSensorSetTimestampResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getSensorSetTimestamp(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getSensorSetTimestamp(AsyncRpcResponse<GetSensorSetTimestampResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getSensorSetTimestamp", _parameters,
        _result => {
          try {
            var _ret = new GetSensorSetTimestampResult();
            _ret._ret_ = new System.DateTime(_result["_ret_"]);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class LogRow : ICloneable {
      public object Clone() {
        LogRow copy = new LogRow();
        copy.sensorSetTimestamp = this.sensorSetTimestamp;
        copy.timestamp = this.timestamp;
        copy.sensorRecords = this.sensorRecords;
        copy.peripheralDeviceRecords = this.peripheralDeviceRecords;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["sensorSetTimestamp"] = this.sensorSetTimestamp.Ticks;
        json["timestamp"] = this.timestamp.Ticks;
        json["sensorRecords"] = new JsonArray(this.sensorRecords.Select(
          _value => (JsonValue)(_value.Encode())));
        json["peripheralDeviceRecords"] = new JsonArray(this.peripheralDeviceRecords.Select(
          _value => (JsonValue)(_value.Encode())));
        return json;
      }

      public static LogRow Decode(LightJson.JsonObject json, Agent agent) {
        LogRow inst = new LogRow();
        inst.sensorSetTimestamp = new System.DateTime(json["sensorSetTimestamp"]);
        inst.timestamp = new System.DateTime(json["timestamp"]);
        inst.sensorRecords = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Logger.Record>(json["sensorRecords"].AsJsonArray.Select(
          _value => Com.Raritan.Idl.sensors.Logger.Record.Decode(_value, agent)));
        inst.peripheralDeviceRecords = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Logger.Record>(json["peripheralDeviceRecords"].AsJsonArray.Select(
          _value => Com.Raritan.Idl.sensors.Logger.Record.Decode(_value, agent)));
        return inst;
      }

      public System.DateTime sensorSetTimestamp = new System.DateTime(0);
      public System.DateTime timestamp = new System.DateTime(0);
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.sensors.Logger.Record> sensorRecords = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Logger.Record>();
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.sensors.Logger.Record> peripheralDeviceRecords = new System.Collections.Generic.List<Com.Raritan.Idl.sensors.Logger.Record>();
    }

    public class GetLogRowResult {
      public int _ret_;
      public Com.Raritan.Idl.sensors.Logger.LogRow row;
    }

    public GetLogRowResult getLogRow(int recid) {
      var _parameters = new LightJson.JsonObject();
      _parameters["recid"] = recid;

      var _result = RpcCall("getLogRow", _parameters);
      var _ret = new GetLogRowResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.row = Com.Raritan.Idl.sensors.Logger.LogRow.Decode(_result["row"], agent);
      return _ret;
    }

    public AsyncRequest getLogRow(int recid, AsyncRpcResponse<GetLogRowResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getLogRow(recid, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getLogRow(int recid, AsyncRpcResponse<GetLogRowResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["recid"] = recid;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("getLogRow", _parameters,
        _result => {
          try {
            var _ret = new GetLogRowResult();
            _ret._ret_ = (int)_result["_ret_"];
            _ret.row = Com.Raritan.Idl.sensors.Logger.LogRow.Decode(_result["row"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
