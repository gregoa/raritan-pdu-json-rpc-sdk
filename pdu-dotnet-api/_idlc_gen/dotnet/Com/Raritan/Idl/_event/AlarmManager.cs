// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from AlarmManager.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl._event {
  public class AlarmManager : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("event.AlarmManager:1.0.0", null);

    public AlarmManager(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public AlarmManager(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new AlarmManager StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new AlarmManager(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int NO_ERROR = 0;

    public const int ERR_UNKNOWN_ALARM_ID = 1;

    public const int ERR_EXECUTING_ACTIONS = 2;

    public class Alert : ICloneable {
      public object Clone() {
        Alert copy = new Alert();
        copy.eventCondition = this.eventCondition;
        copy.message = this.message;
        copy.firstAppearance = this.firstAppearance;
        copy.lastAppearance = this.lastAppearance;
        copy.numberAlerts = this.numberAlerts;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["eventCondition"] = this.eventCondition;
        json["message"] = this.message;
        json["firstAppearance"] = this.firstAppearance.Ticks;
        json["lastAppearance"] = this.lastAppearance.Ticks;
        json["numberAlerts"] = this.numberAlerts;
        return json;
      }

      public static Alert Decode(LightJson.JsonObject json, Agent agent) {
        Alert inst = new Alert();
        inst.eventCondition = (string)json["eventCondition"];
        inst.message = (string)json["message"];
        inst.firstAppearance = new System.DateTime(json["firstAppearance"]);
        inst.lastAppearance = new System.DateTime(json["lastAppearance"]);
        inst.numberAlerts = (int)json["numberAlerts"];
        return inst;
      }

      public string eventCondition = "";
      public string message = "";
      public System.DateTime firstAppearance = new System.DateTime(0);
      public System.DateTime lastAppearance = new System.DateTime(0);
      public int numberAlerts = 0;
    }

    public class Alarm : ICloneable {
      public object Clone() {
        Alarm copy = new Alarm();
        copy.id = this.id;
        copy.name = this.name;
        copy.actionId = this.actionId;
        copy.alerts = this.alerts;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["id"] = this.id;
        json["name"] = this.name;
        json["actionId"] = this.actionId;
        json["alerts"] = new JsonArray(this.alerts.Select(
          _value => (JsonValue)(_value.Encode())));
        return json;
      }

      public static Alarm Decode(LightJson.JsonObject json, Agent agent) {
        Alarm inst = new Alarm();
        inst.id = (string)json["id"];
        inst.name = (string)json["name"];
        inst.actionId = (string)json["actionId"];
        inst.alerts = new System.Collections.Generic.List<Com.Raritan.Idl._event.AlarmManager.Alert>(json["alerts"].AsJsonArray.Select(
          _value => Com.Raritan.Idl._event.AlarmManager.Alert.Decode(_value, agent)));
        return inst;
      }

      public string id = "";
      public string name = "";
      public string actionId = "";
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl._event.AlarmManager.Alert> alerts = new System.Collections.Generic.List<Com.Raritan.Idl._event.AlarmManager.Alert>();
    }

    public class AlarmAddedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("event.AlarmManager.AlarmAddedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public Com.Raritan.Idl._event.AlarmManager.Alarm alarm = new Com.Raritan.Idl._event.AlarmManager.Alarm();
    }

    public class AlarmUpdatedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("event.AlarmManager.AlarmUpdatedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public Com.Raritan.Idl._event.AlarmManager.Alarm alarm = new Com.Raritan.Idl._event.AlarmManager.Alarm();
    }

    public class AlarmAcknowledgedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("event.AlarmManager.AlarmAcknowledgedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public string alarmId = "";
    }

    public class AcknowledgeAlarmResult {
      public int _ret_;
    }

    public AcknowledgeAlarmResult acknowledgeAlarm(string alarmId) {
      var _parameters = new LightJson.JsonObject();
      _parameters["alarmId"] = alarmId;

      var _result = RpcCall("acknowledgeAlarm", _parameters);
      var _ret = new AcknowledgeAlarmResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest acknowledgeAlarm(string alarmId, AsyncRpcResponse<AcknowledgeAlarmResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return acknowledgeAlarm(alarmId, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest acknowledgeAlarm(string alarmId, AsyncRpcResponse<AcknowledgeAlarmResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["alarmId"] = alarmId;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("acknowledgeAlarm", _parameters,
        _result => {
          try {
            var _ret = new AcknowledgeAlarmResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class ListAlarmsResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl._event.AlarmManager.Alarm> _ret_;
    }

    public ListAlarmsResult listAlarms() {
      JsonObject _parameters = null;
      var _result = RpcCall("listAlarms", _parameters);
      var _ret = new ListAlarmsResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl._event.AlarmManager.Alarm>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl._event.AlarmManager.Alarm.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest listAlarms(AsyncRpcResponse<ListAlarmsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return listAlarms(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest listAlarms(AsyncRpcResponse<ListAlarmsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("listAlarms", _parameters,
        _result => {
          try {
            var _ret = new ListAlarmsResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl._event.AlarmManager.Alarm>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl._event.AlarmManager.Alarm.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
