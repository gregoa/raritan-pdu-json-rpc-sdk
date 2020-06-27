// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Wire.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {
  public class Wire_1_0_1 : Com.Raritan.Idl.pdumodel.EDevice {

    static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.Wire:1.0.1", null);

    public Wire_1_0_1(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Wire_1_0_1(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Wire_1_0_1 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Wire_1_0_1(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class MetaData : ICloneable {
      public object Clone() {
        MetaData copy = new MetaData();
        copy.label = this.label;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["label"] = this.label;
        return json;
      }

      public static MetaData Decode(LightJson.JsonObject json, Agent agent) {
        MetaData inst = new MetaData();
        inst.label = (string)json["label"];
        return inst;
      }

      public string label = "";
    }

    public class Sensors : ICloneable {
      public object Clone() {
        Sensors copy = new Sensors();
        copy.voltage = this.voltage;
        copy.current = this.current;
        copy.peakCurrent = this.peakCurrent;
        copy.activePower = this.activePower;
        copy.apparentPower = this.apparentPower;
        copy.powerFactor = this.powerFactor;
        copy.activeEnergy = this.activeEnergy;
        copy.apparentEnergy = this.apparentEnergy;
        copy.unbalancedCurrent = this.unbalancedCurrent;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["voltage"] = this.voltage != null ? this.voltage.Encode() : JsonValue.Null;
        json["current"] = this.current != null ? this.current.Encode() : JsonValue.Null;
        json["peakCurrent"] = this.peakCurrent != null ? this.peakCurrent.Encode() : JsonValue.Null;
        json["activePower"] = this.activePower != null ? this.activePower.Encode() : JsonValue.Null;
        json["apparentPower"] = this.apparentPower != null ? this.apparentPower.Encode() : JsonValue.Null;
        json["powerFactor"] = this.powerFactor != null ? this.powerFactor.Encode() : JsonValue.Null;
        json["activeEnergy"] = this.activeEnergy != null ? this.activeEnergy.Encode() : JsonValue.Null;
        json["apparentEnergy"] = this.apparentEnergy != null ? this.apparentEnergy.Encode() : JsonValue.Null;
        json["unbalancedCurrent"] = this.unbalancedCurrent != null ? this.unbalancedCurrent.Encode() : JsonValue.Null;
        return json;
      }

      public static Sensors Decode(LightJson.JsonObject json, Agent agent) {
        Sensors inst = new Sensors();
        inst.voltage = Com.Raritan.Idl.sensors.NumericSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["voltage"], agent));
        inst.current = Com.Raritan.Idl.sensors.NumericSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["current"], agent));
        inst.peakCurrent = Com.Raritan.Idl.sensors.NumericSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["peakCurrent"], agent));
        inst.activePower = Com.Raritan.Idl.sensors.NumericSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["activePower"], agent));
        inst.apparentPower = Com.Raritan.Idl.sensors.NumericSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["apparentPower"], agent));
        inst.powerFactor = Com.Raritan.Idl.sensors.NumericSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["powerFactor"], agent));
        inst.activeEnergy = Com.Raritan.Idl.sensors.NumericSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["activeEnergy"], agent));
        inst.apparentEnergy = Com.Raritan.Idl.sensors.NumericSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["apparentEnergy"], agent));
        inst.unbalancedCurrent = Com.Raritan.Idl.sensors.NumericSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["unbalancedCurrent"], agent));
        return inst;
      }

      public Com.Raritan.Idl.sensors.NumericSensor_3_0_1 voltage = null;
      public Com.Raritan.Idl.sensors.NumericSensor_3_0_1 current = null;
      public Com.Raritan.Idl.sensors.NumericSensor_3_0_1 peakCurrent = null;
      public Com.Raritan.Idl.sensors.NumericSensor_3_0_1 activePower = null;
      public Com.Raritan.Idl.sensors.NumericSensor_3_0_1 apparentPower = null;
      public Com.Raritan.Idl.sensors.NumericSensor_3_0_1 powerFactor = null;
      public Com.Raritan.Idl.sensors.NumericSensor_3_0_1 activeEnergy = null;
      public Com.Raritan.Idl.sensors.NumericSensor_3_0_1 apparentEnergy = null;
      public Com.Raritan.Idl.sensors.NumericSensor_3_0_1 unbalancedCurrent = null;
    }

    public class GetMetaDataResult {
      public Com.Raritan.Idl.pdumodel.Wire_1_0_1.MetaData _ret_;
    }

    public GetMetaDataResult getMetaData() {
      JsonObject _parameters = null;
      var _result = RpcCall("getMetaData", _parameters);
      var _ret = new GetMetaDataResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.Wire_1_0_1.MetaData.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.Wire_1_0_1.MetaData.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSensorsResult {
      public Com.Raritan.Idl.pdumodel.Wire_1_0_1.Sensors _ret_;
    }

    public GetSensorsResult getSensors() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSensors", _parameters);
      var _ret = new GetSensorsResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.Wire_1_0_1.Sensors.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.Wire_1_0_1.Sensors.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetPolesResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.pdumodel.DoublePole_1_0_1> _ret_;
    }

    public GetPolesResult getPoles() {
      JsonObject _parameters = null;
      var _result = RpcCall("getPoles", _parameters);
      var _ret = new GetPolesResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.pdumodel.DoublePole_1_0_1>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.pdumodel.DoublePole_1_0_1.Decode(_value, agent)));
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
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.pdumodel.DoublePole_1_0_1>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.pdumodel.DoublePole_1_0_1.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
