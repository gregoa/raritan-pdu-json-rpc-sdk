// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from NumericSensor.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.sensors {
  public class NumericSensor_2_0_0 : Com.Raritan.Idl.sensors.Sensor_2_0_0 {

    static public readonly new TypeInfo typeInfo = new TypeInfo("sensors.NumericSensor:2.0.0", null);

    public NumericSensor_2_0_0(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public NumericSensor_2_0_0(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new NumericSensor_2_0_0 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new NumericSensor_2_0_0(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int THRESHOLD_OUT_OF_RANGE = 1;

    public const int THRESHOLD_INVALID = 2;

    public const int THRESHOLD_NOT_SUPPORTED = 3;

    public enum Events {
      EVT_KEY_READING,
      EVT_KEY_STATE,
      EVT_KEY_METADATA,
      EVT_KEY_THRESHOLDS,
    }

    public class Range : ICloneable {
      public object Clone() {
        Range copy = new Range();
        copy.lower = this.lower;
        copy.upper = this.upper;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["lower"] = this.lower;
        json["upper"] = this.upper;
        return json;
      }

      public static Range Decode(LightJson.JsonObject json, Agent agent) {
        Range inst = new Range();
        inst.lower = (double)json["lower"];
        inst.upper = (double)json["upper"];
        return inst;
      }

      public double lower = 0.0;
      public double upper = 0.0;
    }

    public class ThresholdCapabilities : ICloneable {
      public object Clone() {
        ThresholdCapabilities copy = new ThresholdCapabilities();
        copy.hasUpperCritical = this.hasUpperCritical;
        copy.hasUpperWarning = this.hasUpperWarning;
        copy.hasLowerWarning = this.hasLowerWarning;
        copy.hasLowerCritical = this.hasLowerCritical;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["hasUpperCritical"] = this.hasUpperCritical;
        json["hasUpperWarning"] = this.hasUpperWarning;
        json["hasLowerWarning"] = this.hasLowerWarning;
        json["hasLowerCritical"] = this.hasLowerCritical;
        return json;
      }

      public static ThresholdCapabilities Decode(LightJson.JsonObject json, Agent agent) {
        ThresholdCapabilities inst = new ThresholdCapabilities();
        inst.hasUpperCritical = (bool)json["hasUpperCritical"];
        inst.hasUpperWarning = (bool)json["hasUpperWarning"];
        inst.hasLowerWarning = (bool)json["hasLowerWarning"];
        inst.hasLowerCritical = (bool)json["hasLowerCritical"];
        return inst;
      }

      public bool hasUpperCritical = false;
      public bool hasUpperWarning = false;
      public bool hasLowerWarning = false;
      public bool hasLowerCritical = false;
    }

    public class MetaData : ICloneable {
      public object Clone() {
        MetaData copy = new MetaData();
        copy.type = this.type;
        copy.decdigits = this.decdigits;
        copy.accuracy = this.accuracy;
        copy.resolution = this.resolution;
        copy.tolerance = this.tolerance;
        copy.range = this.range;
        copy.thresholdCaps = this.thresholdCaps;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["type"] = this.type.Encode();
        json["decdigits"] = this.decdigits;
        json["accuracy"] = this.accuracy;
        json["resolution"] = this.resolution;
        json["tolerance"] = this.tolerance;
        json["range"] = this.range.Encode();
        json["thresholdCaps"] = this.thresholdCaps.Encode();
        return json;
      }

      public static MetaData Decode(LightJson.JsonObject json, Agent agent) {
        MetaData inst = new MetaData();
        inst.type = Com.Raritan.Idl.sensors.Sensor_2_0_0.TypeSpec.Decode(json["type"], agent);
        inst.decdigits = (int)json["decdigits"];
        inst.accuracy = (float)json["accuracy"];
        inst.resolution = (float)json["resolution"];
        inst.tolerance = (float)json["tolerance"];
        inst.range = Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Range.Decode(json["range"], agent);
        inst.thresholdCaps = Com.Raritan.Idl.sensors.NumericSensor_2_0_0.ThresholdCapabilities.Decode(json["thresholdCaps"], agent);
        return inst;
      }

      public Com.Raritan.Idl.sensors.Sensor_2_0_0.TypeSpec type = new Com.Raritan.Idl.sensors.Sensor_2_0_0.TypeSpec();
      public int decdigits = 0;
      public float accuracy = 0.0f;
      public float resolution = 0.0f;
      public float tolerance = 0.0f;
      public Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Range range = new Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Range();
      public Com.Raritan.Idl.sensors.NumericSensor_2_0_0.ThresholdCapabilities thresholdCaps = new Com.Raritan.Idl.sensors.NumericSensor_2_0_0.ThresholdCapabilities();
    }

    public class Thresholds : ICloneable {
      public object Clone() {
        Thresholds copy = new Thresholds();
        copy.upperCriticalActive = this.upperCriticalActive;
        copy.upperCritical = this.upperCritical;
        copy.upperWarningActive = this.upperWarningActive;
        copy.upperWarning = this.upperWarning;
        copy.lowerWarningActive = this.lowerWarningActive;
        copy.lowerWarning = this.lowerWarning;
        copy.lowerCriticalActive = this.lowerCriticalActive;
        copy.lowerCritical = this.lowerCritical;
        copy.assertionTimeout = this.assertionTimeout;
        copy.deassertionHysteresis = this.deassertionHysteresis;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["upperCriticalActive"] = this.upperCriticalActive;
        json["upperCritical"] = this.upperCritical;
        json["upperWarningActive"] = this.upperWarningActive;
        json["upperWarning"] = this.upperWarning;
        json["lowerWarningActive"] = this.lowerWarningActive;
        json["lowerWarning"] = this.lowerWarning;
        json["lowerCriticalActive"] = this.lowerCriticalActive;
        json["lowerCritical"] = this.lowerCritical;
        json["assertionTimeout"] = this.assertionTimeout;
        json["deassertionHysteresis"] = this.deassertionHysteresis;
        return json;
      }

      public static Thresholds Decode(LightJson.JsonObject json, Agent agent) {
        Thresholds inst = new Thresholds();
        inst.upperCriticalActive = (bool)json["upperCriticalActive"];
        inst.upperCritical = (double)json["upperCritical"];
        inst.upperWarningActive = (bool)json["upperWarningActive"];
        inst.upperWarning = (double)json["upperWarning"];
        inst.lowerWarningActive = (bool)json["lowerWarningActive"];
        inst.lowerWarning = (double)json["lowerWarning"];
        inst.lowerCriticalActive = (bool)json["lowerCriticalActive"];
        inst.lowerCritical = (double)json["lowerCritical"];
        inst.assertionTimeout = (int)json["assertionTimeout"];
        inst.deassertionHysteresis = (float)json["deassertionHysteresis"];
        return inst;
      }

      public bool upperCriticalActive = false;
      public double upperCritical = 0.0;
      public bool upperWarningActive = false;
      public double upperWarning = 0.0;
      public bool lowerWarningActive = false;
      public double lowerWarning = 0.0;
      public bool lowerCriticalActive = false;
      public double lowerCritical = 0.0;
      public int assertionTimeout = 0;
      public float deassertionHysteresis = 0.0f;
    }

    public class Reading : ICloneable {
      public object Clone() {
        Reading copy = new Reading();
        copy.timestamp = this.timestamp;
        copy.available = this.available;
        copy.status = this.status;
        copy.valid = this.valid;
        copy.value = this.value;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["timestamp"] = this.timestamp.Ticks;
        json["available"] = this.available;
        json["status"] = this.status.Encode();
        json["valid"] = this.valid;
        json["value"] = this.value;
        return json;
      }

      public static Reading Decode(LightJson.JsonObject json, Agent agent) {
        Reading inst = new Reading();
        inst.timestamp = new System.DateTime(json["timestamp"]);
        inst.available = (bool)json["available"];
        inst.status = Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Reading.Status.Decode(json["status"], agent);
        inst.valid = (bool)json["valid"];
        inst.value = (double)json["value"];
        return inst;
      }


      public class Status : ICloneable {
        public object Clone() {
          Status copy = new Status();
          copy.aboveUpperCritical = this.aboveUpperCritical;
          copy.aboveUpperWarning = this.aboveUpperWarning;
          copy.belowLowerWarning = this.belowLowerWarning;
          copy.belowLowerCritical = this.belowLowerCritical;
          return copy;
        }

        public LightJson.JsonObject Encode() {
          LightJson.JsonObject json = new LightJson.JsonObject();
          json["aboveUpperCritical"] = this.aboveUpperCritical;
          json["aboveUpperWarning"] = this.aboveUpperWarning;
          json["belowLowerWarning"] = this.belowLowerWarning;
          json["belowLowerCritical"] = this.belowLowerCritical;
          return json;
        }

        public static Status Decode(LightJson.JsonObject json, Agent agent) {
          Status inst = new Status();
          inst.aboveUpperCritical = (bool)json["aboveUpperCritical"];
          inst.aboveUpperWarning = (bool)json["aboveUpperWarning"];
          inst.belowLowerWarning = (bool)json["belowLowerWarning"];
          inst.belowLowerCritical = (bool)json["belowLowerCritical"];
          return inst;
        }

        public bool aboveUpperCritical = false;
        public bool aboveUpperWarning = false;
        public bool belowLowerWarning = false;
        public bool belowLowerCritical = false;
      }
      public System.DateTime timestamp = new System.DateTime(0);
      public bool available = false;
      public Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Reading.Status status = new Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Reading.Status();
      public bool valid = false;
      public double value = 0.0;
    }

    public class GetMetaDataResult {
      public Com.Raritan.Idl.sensors.NumericSensor_2_0_0.MetaData _ret_;
    }

    public GetMetaDataResult getMetaData() {
      JsonObject _parameters = null;
      var _result = RpcCall("getMetaData", _parameters);
      var _ret = new GetMetaDataResult();
      _ret._ret_ = Com.Raritan.Idl.sensors.NumericSensor_2_0_0.MetaData.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.sensors.NumericSensor_2_0_0.MetaData.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetDefaultThresholdsResult {
      public Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Thresholds _ret_;
    }

    public GetDefaultThresholdsResult getDefaultThresholds() {
      JsonObject _parameters = null;
      var _result = RpcCall("getDefaultThresholds", _parameters);
      var _ret = new GetDefaultThresholdsResult();
      _ret._ret_ = Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Thresholds.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getDefaultThresholds(AsyncRpcResponse<GetDefaultThresholdsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getDefaultThresholds(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getDefaultThresholds(AsyncRpcResponse<GetDefaultThresholdsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getDefaultThresholds", _parameters,
        _result => {
          try {
            var _ret = new GetDefaultThresholdsResult();
            _ret._ret_ = Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Thresholds.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetThresholdsResult {
      public Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Thresholds _ret_;
    }

    public GetThresholdsResult getThresholds() {
      JsonObject _parameters = null;
      var _result = RpcCall("getThresholds", _parameters);
      var _ret = new GetThresholdsResult();
      _ret._ret_ = Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Thresholds.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getThresholds(AsyncRpcResponse<GetThresholdsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getThresholds(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getThresholds(AsyncRpcResponse<GetThresholdsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getThresholds", _parameters,
        _result => {
          try {
            var _ret = new GetThresholdsResult();
            _ret._ret_ = Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Thresholds.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetThresholdsResult {
      public int _ret_;
    }

    public SetThresholdsResult setThresholds(Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Thresholds thresh) {
      var _parameters = new LightJson.JsonObject();
      _parameters["thresh"] = thresh.Encode();

      var _result = RpcCall("setThresholds", _parameters);
      var _ret = new SetThresholdsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setThresholds(Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Thresholds thresh, AsyncRpcResponse<SetThresholdsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setThresholds(thresh, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setThresholds(Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Thresholds thresh, AsyncRpcResponse<SetThresholdsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["thresh"] = thresh.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setThresholds", _parameters,
        _result => {
          try {
            var _ret = new SetThresholdsResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetReadingResult {
      public Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Reading _ret_;
    }

    public GetReadingResult getReading() {
      JsonObject _parameters = null;
      var _result = RpcCall("getReading", _parameters);
      var _ret = new GetReadingResult();
      _ret._ret_ = Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Reading.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getReading(AsyncRpcResponse<GetReadingResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getReading(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getReading(AsyncRpcResponse<GetReadingResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getReading", _parameters,
        _result => {
          try {
            var _ret = new GetReadingResult();
            _ret._ret_ = Com.Raritan.Idl.sensors.NumericSensor_2_0_0.Reading.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}