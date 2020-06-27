// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from OverCurrentProtector.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {
  public class OverCurrentProtector_1_1_0 : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.OverCurrentProtector:1.1.0", null);

    public OverCurrentProtector_1_1_0(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public OverCurrentProtector_1_1_0(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new OverCurrentProtector_1_1_0 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new OverCurrentProtector_1_1_0(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public enum Events {
      EVT_KEY_SETTINGS_CHANGED,
    }

    public enum Type {
      BREAKER_1POLE,
      BREAKER_2POLE,
      BREAKER_3POLE,
      FUSE,
      FUSE_PAIR,
    }

    public class MetaData : ICloneable {
      public object Clone() {
        MetaData copy = new MetaData();
        copy.label = this.label;
        copy.namePlate = this.namePlate;
        copy.rating = this.rating;
        copy.type = this.type;
        copy.maxTripCnt = this.maxTripCnt;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["label"] = this.label;
        json["namePlate"] = this.namePlate.Encode();
        json["rating"] = this.rating.Encode();
        json["type"] = (int)this.type;
        json["maxTripCnt"] = this.maxTripCnt;
        return json;
      }

      public static MetaData Decode(LightJson.JsonObject json, Agent agent) {
        MetaData inst = new MetaData();
        inst.label = (string)json["label"];
        inst.namePlate = Com.Raritan.Idl.pdumodel.Nameplate.Decode(json["namePlate"], agent);
        inst.rating = Com.Raritan.Idl.pdumodel.Rating.Decode(json["rating"], agent);
        inst.type = (Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.Type)(int)json["type"];
        inst.maxTripCnt = (int)json["maxTripCnt"];
        return inst;
      }

      public string label = "";
      public Com.Raritan.Idl.pdumodel.Nameplate namePlate = new Com.Raritan.Idl.pdumodel.Nameplate();
      public Com.Raritan.Idl.pdumodel.Rating rating = new Com.Raritan.Idl.pdumodel.Rating();
      public Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.Type type = Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.Type.BREAKER_1POLE;
      public int maxTripCnt = 0;
    }

    public class Sensors : ICloneable {
      public object Clone() {
        Sensors copy = new Sensors();
        copy.trip = this.trip;
        copy.current = this.current;
        copy.peakCurrent = this.peakCurrent;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["trip"] = this.trip != null ? this.trip.Encode() : JsonValue.Null;
        json["current"] = this.current != null ? this.current.Encode() : JsonValue.Null;
        json["peakCurrent"] = this.peakCurrent != null ? this.peakCurrent.Encode() : JsonValue.Null;
        return json;
      }

      public static Sensors Decode(LightJson.JsonObject json, Agent agent) {
        Sensors inst = new Sensors();
        inst.trip = Com.Raritan.Idl.sensors.StateSensor.StaticCast(ObjectProxy.Decode(json["trip"], agent));
        inst.current = Com.Raritan.Idl.sensors.NumericSensor.StaticCast(ObjectProxy.Decode(json["current"], agent));
        inst.peakCurrent = Com.Raritan.Idl.sensors.NumericSensor.StaticCast(ObjectProxy.Decode(json["peakCurrent"], agent));
        return inst;
      }

      public Com.Raritan.Idl.sensors.StateSensor trip = null;
      public Com.Raritan.Idl.sensors.NumericSensor current = null;
      public Com.Raritan.Idl.sensors.NumericSensor peakCurrent = null;
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

    public class GetMetaDataResult {
      public Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.MetaData _ret_;
    }

    public GetMetaDataResult getMetaData() {
      JsonObject _parameters = null;
      var _result = RpcCall("getMetaData", _parameters);
      var _ret = new GetMetaDataResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.MetaData.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.MetaData.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSensorsResult {
      public Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.Sensors _ret_;
    }

    public GetSensorsResult getSensors() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSensors", _parameters);
      var _ret = new GetSensorsResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.Sensors.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.Sensors.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetPolesResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.pdumodel.SwitchedPole> _ret_;
    }

    public GetPolesResult getPoles() {
      JsonObject _parameters = null;
      var _result = RpcCall("getPoles", _parameters);
      var _ret = new GetPolesResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.pdumodel.SwitchedPole>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.pdumodel.SwitchedPole.Decode(_value, agent)));
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
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.pdumodel.SwitchedPole>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.pdumodel.SwitchedPole.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetInletResult {
      public Com.Raritan.Idl.pdumodel.Inlet_1_0_1 _ret_;
    }

    public GetInletResult getInlet() {
      JsonObject _parameters = null;
      var _result = RpcCall("getInlet", _parameters);
      var _ret = new GetInletResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.Inlet_1_0_1.StaticCast(ObjectProxy.Decode(_result["_ret_"], agent));
      return _ret;
    }

    public AsyncRequest getInlet(AsyncRpcResponse<GetInletResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getInlet(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getInlet(AsyncRpcResponse<GetInletResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getInlet", _parameters,
        _result => {
          try {
            var _ret = new GetInletResult();
            _ret._ret_ = Com.Raritan.Idl.pdumodel.Inlet_1_0_1.StaticCast(ObjectProxy.Decode(_result["_ret_"], agent));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetOCPResult {
      public Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0 _ret_;
    }

    public GetOCPResult getOCP() {
      JsonObject _parameters = null;
      var _result = RpcCall("getOCP", _parameters);
      var _ret = new GetOCPResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.StaticCast(ObjectProxy.Decode(_result["_ret_"], agent));
      return _ret;
    }

    public AsyncRequest getOCP(AsyncRpcResponse<GetOCPResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getOCP(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getOCP(AsyncRpcResponse<GetOCPResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getOCP", _parameters,
        _result => {
          try {
            var _ret = new GetOCPResult();
            _ret._ret_ = Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.StaticCast(ObjectProxy.Decode(_result["_ret_"], agent));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.Settings.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.pdumodel.OverCurrentProtector_1_1_0.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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
