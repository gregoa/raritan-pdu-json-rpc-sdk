// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from StateSensor.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.sensors {
  public class StateSensor : Com.Raritan.Idl.sensors.Sensor {

    static public readonly new TypeInfo typeInfo = new TypeInfo("sensors.StateSensor:1.0.0", null);

    public StateSensor(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public StateSensor(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new StateSensor StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new StateSensor(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public enum Events {
      EVT_KEY_STATE,
    }

    public class State : ICloneable {
      public object Clone() {
        State copy = new State();
        copy.timestamp = this.timestamp;
        copy.available = this.available;
        copy.value = this.value;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["timestamp"] = this.timestamp.Ticks;
        json["available"] = this.available;
        json["value"] = this.value;
        return json;
      }

      public static State Decode(LightJson.JsonObject json, Agent agent) {
        State inst = new State();
        inst.timestamp = new System.DateTime(json["timestamp"]);
        inst.available = (bool)json["available"];
        inst.value = (int)json["value"];
        return inst;
      }

      public System.DateTime timestamp = new System.DateTime(0);
      public bool available = false;
      public int value = 0;
    }

    public class GetStateResult {
      public Com.Raritan.Idl.sensors.StateSensor.State _ret_;
    }

    public GetStateResult getState() {
      JsonObject _parameters = null;
      var _result = RpcCall("getState", _parameters);
      var _ret = new GetStateResult();
      _ret._ret_ = Com.Raritan.Idl.sensors.StateSensor.State.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.sensors.StateSensor.State.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
