// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from PowerMeterController.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {
  public class PowerMeterController : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.PowerMeterController:1.0.0", null);

    public PowerMeterController(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public PowerMeterController(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new PowerMeterController StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new PowerMeterController(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int ERR_INVALID_PARAM = 1;

    public const int ERR_METER_BOARD_BUSY = 2;

    public class ScanResult : ICloneable {
      public object Clone() {
        ScanResult copy = new ScanResult();
        copy.present = this.present;
        copy.meterCount = this.meterCount;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["present"] = this.present;
        json["meterCount"] = this.meterCount;
        return json;
      }

      public static ScanResult Decode(LightJson.JsonObject json, Agent agent) {
        ScanResult inst = new ScanResult();
        inst.present = (bool)json["present"];
        inst.meterCount = (int)json["meterCount"];
        return inst;
      }

      public bool present = false;
      public int meterCount = 0;
    }

    public class ScanMeterBoardResult {
      public int _ret_;
      public Com.Raritan.Idl.pdumodel.PowerMeterController.ScanResult result;
    }

    public ScanMeterBoardResult scanMeterBoard(int powerMeterId) {
      var _parameters = new LightJson.JsonObject();
      _parameters["powerMeterId"] = powerMeterId;

      var _result = RpcCall("scanMeterBoard", _parameters);
      var _ret = new ScanMeterBoardResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.result = Com.Raritan.Idl.pdumodel.PowerMeterController.ScanResult.Decode(_result["result"], agent);
      return _ret;
    }

    public AsyncRequest scanMeterBoard(int powerMeterId, AsyncRpcResponse<ScanMeterBoardResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return scanMeterBoard(powerMeterId, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest scanMeterBoard(int powerMeterId, AsyncRpcResponse<ScanMeterBoardResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["powerMeterId"] = powerMeterId;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("scanMeterBoard", _parameters,
        _result => {
          try {
            var _ret = new ScanMeterBoardResult();
            _ret._ret_ = (int)_result["_ret_"];
            _ret.result = Com.Raritan.Idl.pdumodel.PowerMeterController.ScanResult.Decode(_result["result"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class PowerMeterCreatedEvent : Com.Raritan.Idl._event.UserEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.PowerMeterController.PowerMeterCreatedEvent:1.0.0", Com.Raritan.Idl._event.UserEvent.typeInfo);

      public Com.Raritan.Idl.pdumodel.PowerMeter powerMeter = null;
      public Com.Raritan.Idl.pdumodel.PowerMeter.Config config = new Com.Raritan.Idl.pdumodel.PowerMeter.Config();
      public Com.Raritan.Idl.pdumodel.PowerMeter.Settings settings = new Com.Raritan.Idl.pdumodel.PowerMeter.Settings();
    }

    public class PowerMeterDeletedEvent : Com.Raritan.Idl._event.UserEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.PowerMeterController.PowerMeterDeletedEvent:1.0.0", Com.Raritan.Idl._event.UserEvent.typeInfo);

      public Com.Raritan.Idl.pdumodel.PowerMeter.Config config = new Com.Raritan.Idl.pdumodel.PowerMeter.Config();
      public Com.Raritan.Idl.pdumodel.PowerMeter.Settings settings = new Com.Raritan.Idl.pdumodel.PowerMeter.Settings();
    }

    public class PanelCreatedEvent : Com.Raritan.Idl.pdumodel.PowerMeterController.PowerMeterCreatedEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.PowerMeterController.PanelCreatedEvent:1.0.0", Com.Raritan.Idl.pdumodel.PowerMeterController.PowerMeterCreatedEvent.typeInfo);

      public Com.Raritan.Idl.pdumodel.Panel.PanelSettings panelSettings = new Com.Raritan.Idl.pdumodel.Panel.PanelSettings();
    }

    public class PanelDeletedEvent : Com.Raritan.Idl.pdumodel.PowerMeterController.PowerMeterDeletedEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.PowerMeterController.PanelDeletedEvent:1.0.0", Com.Raritan.Idl.pdumodel.PowerMeterController.PowerMeterDeletedEvent.typeInfo);

      public Com.Raritan.Idl.pdumodel.Panel.PanelSettings panelSettings = new Com.Raritan.Idl.pdumodel.Panel.PanelSettings();
    }

    public class GetPowerMetersResult {
      public System.Collections.Generic.IDictionary<int, Com.Raritan.Idl.pdumodel.PowerMeter> _ret_;
    }

    public GetPowerMetersResult getPowerMeters() {
      JsonObject _parameters = null;
      var _result = RpcCall("getPowerMeters", _parameters);
      var _ret = new GetPowerMetersResult();
      _ret._ret_ = DictionaryHelper.Create(_result["_ret_"].AsJsonArray.Select(
        _value => new System.Collections.Generic.KeyValuePair<int, Com.Raritan.Idl.pdumodel.PowerMeter>(_value["key"], Com.Raritan.Idl.pdumodel.PowerMeter.StaticCast(ObjectProxy.Decode(_value["value"], agent)))));
      return _ret;
    }

    public AsyncRequest getPowerMeters(AsyncRpcResponse<GetPowerMetersResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getPowerMeters(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getPowerMeters(AsyncRpcResponse<GetPowerMetersResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getPowerMeters", _parameters,
        _result => {
          try {
            var _ret = new GetPowerMetersResult();
            _ret._ret_ = DictionaryHelper.Create(_result["_ret_"].AsJsonArray.Select(
              _value => new System.Collections.Generic.KeyValuePair<int, Com.Raritan.Idl.pdumodel.PowerMeter>(_value["key"], Com.Raritan.Idl.pdumodel.PowerMeter.StaticCast(ObjectProxy.Decode(_value["value"], agent)))));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class CreatePowerMeterResult {
      public int _ret_;
      public Com.Raritan.Idl.pdumodel.PowerMeter powerMeter;
    }

    public CreatePowerMeterResult createPowerMeter(Com.Raritan.Idl.pdumodel.PowerMeter.Config config, Com.Raritan.Idl.pdumodel.PowerMeter.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["config"] = config.Encode();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("createPowerMeter", _parameters);
      var _ret = new CreatePowerMeterResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.powerMeter = Com.Raritan.Idl.pdumodel.PowerMeter.StaticCast(ObjectProxy.Decode(_result["powerMeter"], agent));
      return _ret;
    }

    public AsyncRequest createPowerMeter(Com.Raritan.Idl.pdumodel.PowerMeter.Config config, Com.Raritan.Idl.pdumodel.PowerMeter.Settings settings, AsyncRpcResponse<CreatePowerMeterResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return createPowerMeter(config, settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest createPowerMeter(Com.Raritan.Idl.pdumodel.PowerMeter.Config config, Com.Raritan.Idl.pdumodel.PowerMeter.Settings settings, AsyncRpcResponse<CreatePowerMeterResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["config"] = config.Encode();
        _parameters["settings"] = settings.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("createPowerMeter", _parameters,
        _result => {
          try {
            var _ret = new CreatePowerMeterResult();
            _ret._ret_ = (int)_result["_ret_"];
            _ret.powerMeter = Com.Raritan.Idl.pdumodel.PowerMeter.StaticCast(ObjectProxy.Decode(_result["powerMeter"], agent));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class CreatePanelResult {
      public int _ret_;
      public Com.Raritan.Idl.pdumodel.Panel panel;
    }

    public CreatePanelResult createPanel(Com.Raritan.Idl.pdumodel.PowerMeter.Config config, Com.Raritan.Idl.pdumodel.PowerMeter.Settings powerMeterSettings, Com.Raritan.Idl.pdumodel.Panel.PanelSettings panelSettings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["config"] = config.Encode();
      _parameters["powerMeterSettings"] = powerMeterSettings.Encode();
      _parameters["panelSettings"] = panelSettings.Encode();

      var _result = RpcCall("createPanel", _parameters);
      var _ret = new CreatePanelResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.panel = Com.Raritan.Idl.pdumodel.Panel.StaticCast(ObjectProxy.Decode(_result["panel"], agent));
      return _ret;
    }

    public AsyncRequest createPanel(Com.Raritan.Idl.pdumodel.PowerMeter.Config config, Com.Raritan.Idl.pdumodel.PowerMeter.Settings powerMeterSettings, Com.Raritan.Idl.pdumodel.Panel.PanelSettings panelSettings, AsyncRpcResponse<CreatePanelResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return createPanel(config, powerMeterSettings, panelSettings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest createPanel(Com.Raritan.Idl.pdumodel.PowerMeter.Config config, Com.Raritan.Idl.pdumodel.PowerMeter.Settings powerMeterSettings, Com.Raritan.Idl.pdumodel.Panel.PanelSettings panelSettings, AsyncRpcResponse<CreatePanelResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["config"] = config.Encode();
        _parameters["powerMeterSettings"] = powerMeterSettings.Encode();
        _parameters["panelSettings"] = panelSettings.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("createPanel", _parameters,
        _result => {
          try {
            var _ret = new CreatePanelResult();
            _ret._ret_ = (int)_result["_ret_"];
            _ret.panel = Com.Raritan.Idl.pdumodel.Panel.StaticCast(ObjectProxy.Decode(_result["panel"], agent));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class DeletePowerMeterResult {
      public int _ret_;
    }

    public DeletePowerMeterResult deletePowerMeter(int powerMeterId) {
      var _parameters = new LightJson.JsonObject();
      _parameters["powerMeterId"] = powerMeterId;

      var _result = RpcCall("deletePowerMeter", _parameters);
      var _ret = new DeletePowerMeterResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest deletePowerMeter(int powerMeterId, AsyncRpcResponse<DeletePowerMeterResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return deletePowerMeter(powerMeterId, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest deletePowerMeter(int powerMeterId, AsyncRpcResponse<DeletePowerMeterResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["powerMeterId"] = powerMeterId;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("deletePowerMeter", _parameters,
        _result => {
          try {
            var _ret = new DeletePowerMeterResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
