// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from TransferSwitch.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {
  public class TransferSwitch_2_0_0 : Com.Raritan.Idl.pdumodel.EDevice {

    static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.TransferSwitch:2.0.0", null);

    public TransferSwitch_2_0_0(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public TransferSwitch_2_0_0(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new TransferSwitch_2_0_0 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new TransferSwitch_2_0_0(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int ERR_INVALID_PARAM = 1;

    public const int ERR_SWITCH_FAULT = 2;

    public const int ERR_SWITCH_POWER_FAIL = 3;

    public enum Events {
      EVT_KEY_SETTINGS_CHANGED,
    }

    public enum Type {
      STS,
      ATS,
      HTS,
    }

    public enum TransferReason {
      REASON_UNKNOWN,
      REASON_STARTUP,
      REASON_MANUAL_TRANSFER,
      REASON_AUTO_RETRANSFER,
      REASON_POWER_FAILURE,
      REASON_POWER_QUALITY,
      REASON_OVERLOAD,
      REASON_OVERHEAT,
      REASON_INTERNAL_FAILURE,
    }

    public class MetaData : ICloneable {
      public object Clone() {
        MetaData copy = new MetaData();
        copy.label = this.label;
        copy.namePlate = this.namePlate;
        copy.rating = this.rating;
        copy.type = this.type;
        copy.sourceCount = this.sourceCount;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["label"] = this.label;
        json["namePlate"] = this.namePlate.Encode();
        json["rating"] = this.rating.Encode();
        json["type"] = (int)this.type;
        json["sourceCount"] = this.sourceCount;
        return json;
      }

      public static MetaData Decode(LightJson.JsonObject json, Agent agent) {
        MetaData inst = new MetaData();
        inst.label = (string)json["label"];
        inst.namePlate = Com.Raritan.Idl.pdumodel.Nameplate.Decode(json["namePlate"], agent);
        inst.rating = Com.Raritan.Idl.pdumodel.Rating.Decode(json["rating"], agent);
        inst.type = (Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.Type)(int)json["type"];
        inst.sourceCount = (int)json["sourceCount"];
        return inst;
      }

      public string label = "";
      public Com.Raritan.Idl.pdumodel.Nameplate namePlate = new Com.Raritan.Idl.pdumodel.Nameplate();
      public Com.Raritan.Idl.pdumodel.Rating rating = new Com.Raritan.Idl.pdumodel.Rating();
      public Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.Type type = Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.Type.STS;
      public int sourceCount = 0;
    }

    public const int OPERATIONAL_STATE_OFF = 0;

    public const int OPERATIONAL_STATE_NORMAL = 1;

    public const int OPERATIONAL_STATE_STANDBY = 2;

    public const int SWITCH_FAULT_OK = 0;

    public const int SWITCH_FAULT_OPEN = 1;

    public const int SWITCH_FAULT_SHORT = 2;

    public class Sensors : ICloneable {
      public object Clone() {
        Sensors copy = new Sensors();
        copy.selectedSource = this.selectedSource;
        copy.operationalState = this.operationalState;
        copy.sourceVoltagePhaseSyncAngle = this.sourceVoltagePhaseSyncAngle;
        copy.overloadAlarm = this.overloadAlarm;
        copy.phaseSyncAlarm = this.phaseSyncAlarm;
        copy.switchFault = this.switchFault;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["selectedSource"] = this.selectedSource != null ? this.selectedSource.Encode() : JsonValue.Null;
        json["operationalState"] = this.operationalState != null ? this.operationalState.Encode() : JsonValue.Null;
        json["sourceVoltagePhaseSyncAngle"] = this.sourceVoltagePhaseSyncAngle != null ? this.sourceVoltagePhaseSyncAngle.Encode() : JsonValue.Null;
        json["overloadAlarm"] = this.overloadAlarm != null ? this.overloadAlarm.Encode() : JsonValue.Null;
        json["phaseSyncAlarm"] = this.phaseSyncAlarm != null ? this.phaseSyncAlarm.Encode() : JsonValue.Null;
        json["switchFault"] = this.switchFault != null ? this.switchFault.Encode() : JsonValue.Null;
        return json;
      }

      public static Sensors Decode(LightJson.JsonObject json, Agent agent) {
        Sensors inst = new Sensors();
        inst.selectedSource = Com.Raritan.Idl.sensors.StateSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["selectedSource"], agent));
        inst.operationalState = Com.Raritan.Idl.sensors.StateSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["operationalState"], agent));
        inst.sourceVoltagePhaseSyncAngle = Com.Raritan.Idl.sensors.NumericSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["sourceVoltagePhaseSyncAngle"], agent));
        inst.overloadAlarm = Com.Raritan.Idl.sensors.StateSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["overloadAlarm"], agent));
        inst.phaseSyncAlarm = Com.Raritan.Idl.sensors.StateSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["phaseSyncAlarm"], agent));
        inst.switchFault = Com.Raritan.Idl.sensors.StateSensor_3_0_1.StaticCast(ObjectProxy.Decode(json["switchFault"], agent));
        return inst;
      }

      public Com.Raritan.Idl.sensors.StateSensor_3_0_1 selectedSource = null;
      public Com.Raritan.Idl.sensors.StateSensor_3_0_1 operationalState = null;
      public Com.Raritan.Idl.sensors.NumericSensor_3_0_1 sourceVoltagePhaseSyncAngle = null;
      public Com.Raritan.Idl.sensors.StateSensor_3_0_1 overloadAlarm = null;
      public Com.Raritan.Idl.sensors.StateSensor_3_0_1 phaseSyncAlarm = null;
      public Com.Raritan.Idl.sensors.StateSensor_3_0_1 switchFault = null;
    }

    public class PowerQualitySettings : ICloneable {
      public object Clone() {
        PowerQualitySettings copy = new PowerQualitySettings();
        copy.minMarginalVoltage = this.minMarginalVoltage;
        copy.minGoodVoltage = this.minGoodVoltage;
        copy.maxGoodVoltage = this.maxGoodVoltage;
        copy.maxMarginalVoltage = this.maxMarginalVoltage;
        copy.voltageHysteresis = this.voltageHysteresis;
        copy.voltageDetectTime = this.voltageDetectTime;
        copy.minGoodFrequency = this.minGoodFrequency;
        copy.maxGoodFrequency = this.maxGoodFrequency;
        copy.frequencyHysteresis = this.frequencyHysteresis;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["minMarginalVoltage"] = this.minMarginalVoltage;
        json["minGoodVoltage"] = this.minGoodVoltage;
        json["maxGoodVoltage"] = this.maxGoodVoltage;
        json["maxMarginalVoltage"] = this.maxMarginalVoltage;
        json["voltageHysteresis"] = this.voltageHysteresis;
        json["voltageDetectTime"] = this.voltageDetectTime;
        json["minGoodFrequency"] = this.minGoodFrequency;
        json["maxGoodFrequency"] = this.maxGoodFrequency;
        json["frequencyHysteresis"] = this.frequencyHysteresis;
        return json;
      }

      public static PowerQualitySettings Decode(LightJson.JsonObject json, Agent agent) {
        PowerQualitySettings inst = new PowerQualitySettings();
        inst.minMarginalVoltage = (double)json["minMarginalVoltage"];
        inst.minGoodVoltage = (double)json["minGoodVoltage"];
        inst.maxGoodVoltage = (double)json["maxGoodVoltage"];
        inst.maxMarginalVoltage = (double)json["maxMarginalVoltage"];
        inst.voltageHysteresis = (double)json["voltageHysteresis"];
        inst.voltageDetectTime = (int)json["voltageDetectTime"];
        inst.minGoodFrequency = (double)json["minGoodFrequency"];
        inst.maxGoodFrequency = (double)json["maxGoodFrequency"];
        inst.frequencyHysteresis = (double)json["frequencyHysteresis"];
        return inst;
      }

      public double minMarginalVoltage = 0.0;
      public double minGoodVoltage = 0.0;
      public double maxGoodVoltage = 0.0;
      public double maxMarginalVoltage = 0.0;
      public double voltageHysteresis = 0.0;
      public int voltageDetectTime = 0;
      public double minGoodFrequency = 0.0;
      public double maxGoodFrequency = 0.0;
      public double frequencyHysteresis = 0.0;
    }

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.name = this.name;
        copy.preferredSource = this.preferredSource;
        copy.autoRetransfer = this.autoRetransfer;
        copy.noAutoRetransferIfPhaseFault = this.noAutoRetransferIfPhaseFault;
        copy.autoRetransferWaitTime = this.autoRetransferWaitTime;
        copy.manualTransferEnabled = this.manualTransferEnabled;
        copy.powerQuality = this.powerQuality;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["name"] = this.name;
        json["preferredSource"] = this.preferredSource;
        json["autoRetransfer"] = this.autoRetransfer;
        json["noAutoRetransferIfPhaseFault"] = this.noAutoRetransferIfPhaseFault;
        json["autoRetransferWaitTime"] = this.autoRetransferWaitTime;
        json["manualTransferEnabled"] = this.manualTransferEnabled;
        json["powerQuality"] = this.powerQuality.Encode();
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.name = (string)json["name"];
        inst.preferredSource = (int)json["preferredSource"];
        inst.autoRetransfer = (bool)json["autoRetransfer"];
        inst.noAutoRetransferIfPhaseFault = (bool)json["noAutoRetransferIfPhaseFault"];
        inst.autoRetransferWaitTime = (int)json["autoRetransferWaitTime"];
        inst.manualTransferEnabled = (bool)json["manualTransferEnabled"];
        inst.powerQuality = Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.PowerQualitySettings.Decode(json["powerQuality"], agent);
        return inst;
      }

      public string name = "";
      public int preferredSource = 0;
      public bool autoRetransfer = false;
      public bool noAutoRetransferIfPhaseFault = false;
      public int autoRetransferWaitTime = 0;
      public bool manualTransferEnabled = false;
      public Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.PowerQualitySettings powerQuality = new Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.PowerQualitySettings();
    }

    public class GetMetaDataResult {
      public Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.MetaData _ret_;
    }

    public GetMetaDataResult getMetaData() {
      JsonObject _parameters = null;
      var _result = RpcCall("getMetaData", _parameters);
      var _ret = new GetMetaDataResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.MetaData.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.MetaData.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSensorsResult {
      public Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.Sensors _ret_;
    }

    public GetSensorsResult getSensors() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSensors", _parameters);
      var _ret = new GetSensorsResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.Sensors.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.Sensors.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetPolesResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.pdumodel.ThrowPole> _ret_;
    }

    public GetPolesResult getPoles() {
      JsonObject _parameters = null;
      var _result = RpcCall("getPoles", _parameters);
      var _ret = new GetPolesResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.pdumodel.ThrowPole>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.pdumodel.ThrowPole.Decode(_value, agent)));
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
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.pdumodel.ThrowPole>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.pdumodel.ThrowPole.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.Settings.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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

    public class TransferToSourceResult {
      public int _ret_;
    }

    public TransferToSourceResult transferToSource(int source, bool faultOverride) {
      var _parameters = new LightJson.JsonObject();
      _parameters["source"] = source;
      _parameters["faultOverride"] = faultOverride;

      var _result = RpcCall("transferToSource", _parameters);
      var _ret = new TransferToSourceResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest transferToSource(int source, bool faultOverride, AsyncRpcResponse<TransferToSourceResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return transferToSource(source, faultOverride, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest transferToSource(int source, bool faultOverride, AsyncRpcResponse<TransferToSourceResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["source"] = source;
        _parameters["faultOverride"] = faultOverride;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("transferToSource", _parameters,
        _result => {
          try {
            var _ret = new TransferToSourceResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetLastTransferReasonResult {
      public Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.TransferReason _ret_;
    }

    public GetLastTransferReasonResult getLastTransferReason() {
      JsonObject _parameters = null;
      var _result = RpcCall("getLastTransferReason", _parameters);
      var _ret = new GetLastTransferReasonResult();
      _ret._ret_ = (Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.TransferReason)(int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest getLastTransferReason(AsyncRpcResponse<GetLastTransferReasonResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getLastTransferReason(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getLastTransferReason(AsyncRpcResponse<GetLastTransferReasonResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getLastTransferReason", _parameters,
        _result => {
          try {
            var _ret = new GetLastTransferReasonResult();
            _ret._ret_ = (Com.Raritan.Idl.pdumodel.TransferSwitch_2_0_0.TransferReason)(int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
