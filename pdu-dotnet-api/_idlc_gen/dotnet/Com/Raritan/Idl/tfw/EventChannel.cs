// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from TfwEventChannel.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.tfw {
  public class EventChannel : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("tfw.EventChannel:1.0.0", null);

    public EventChannel(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public EventChannel(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new EventChannel StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new EventChannel(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class PollNextEventsResult {
      public bool _ret_;
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.tfw.Event> events;
    }

    public PollNextEventsResult pollNextEvents() {
      JsonObject _parameters = null;
      var _result = RpcCall("pollNextEvents", _parameters);
      var _ret = new PollNextEventsResult();
      _ret._ret_ = (bool)_result["_ret_"];
      _ret.events = new System.Collections.Generic.List<Com.Raritan.Idl.tfw.Event>(_result["events"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.tfw.Event.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest pollNextEvents(AsyncRpcResponse<PollNextEventsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return pollNextEvents(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest pollNextEvents(AsyncRpcResponse<PollNextEventsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("pollNextEvents", _parameters,
        _result => {
          try {
            var _ret = new PollNextEventsResult();
            _ret._ret_ = (bool)_result["_ret_"];
            _ret.events = new System.Collections.Generic.List<Com.Raritan.Idl.tfw.Event>(_result["events"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.tfw.Event.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class DemandEventTypeResult {
    }

    public DemandEventTypeResult demandEventType(Com.Raritan.Idl.tfw.EventType evttype) {
      var _parameters = new LightJson.JsonObject();
      _parameters["evttype"] = evttype.Encode();

      var _result = RpcCall("demandEventType", _parameters);
      var _ret = new DemandEventTypeResult();
      return _ret;
    }

    public AsyncRequest demandEventType(Com.Raritan.Idl.tfw.EventType evttype, AsyncRpcResponse<DemandEventTypeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return demandEventType(evttype, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest demandEventType(Com.Raritan.Idl.tfw.EventType evttype, AsyncRpcResponse<DemandEventTypeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["evttype"] = evttype.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("demandEventType", _parameters,
        _result => {
          try {
            var _ret = new DemandEventTypeResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class DemandEventTypesResult {
    }

    public DemandEventTypesResult demandEventTypes(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.tfw.EventType> evttypes) {
      var _parameters = new LightJson.JsonObject();
      _parameters["evttypes"] = new JsonArray(evttypes.Select(
        _value => (JsonValue)(_value.Encode())));

      var _result = RpcCall("demandEventTypes", _parameters);
      var _ret = new DemandEventTypesResult();
      return _ret;
    }

    public AsyncRequest demandEventTypes(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.tfw.EventType> evttypes, AsyncRpcResponse<DemandEventTypesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return demandEventTypes(evttypes, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest demandEventTypes(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.tfw.EventType> evttypes, AsyncRpcResponse<DemandEventTypesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["evttypes"] = new JsonArray(evttypes.Select(
          _value => (JsonValue)(_value.Encode())));
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("demandEventTypes", _parameters,
        _result => {
          try {
            var _ret = new DemandEventTypesResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class DemandEventResult {
      public int _ret_;
    }

    public DemandEventResult demandEvent(Com.Raritan.Idl.tfw.EventType evttype, ObjectProxy src) {
      var _parameters = new LightJson.JsonObject();
      _parameters["evttype"] = evttype.Encode();
      _parameters["src"] = src != null ? src.Encode() : JsonValue.Null;

      var _result = RpcCall("demandEvent", _parameters);
      var _ret = new DemandEventResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest demandEvent(Com.Raritan.Idl.tfw.EventType evttype, ObjectProxy src, AsyncRpcResponse<DemandEventResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return demandEvent(evttype, src, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest demandEvent(Com.Raritan.Idl.tfw.EventType evttype, ObjectProxy src, AsyncRpcResponse<DemandEventResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["evttype"] = evttype.Encode();
        _parameters["src"] = src != null ? src.Encode() : JsonValue.Null;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("demandEvent", _parameters,
        _result => {
          try {
            var _ret = new DemandEventResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class DemandEventsResult {
      public int _ret_;
    }

    public DemandEventsResult demandEvents(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.tfw.Event> events) {
      var _parameters = new LightJson.JsonObject();
      _parameters["events"] = new JsonArray(events.Select(
        _value => (JsonValue)(_value.Encode())));

      var _result = RpcCall("demandEvents", _parameters);
      var _ret = new DemandEventsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest demandEvents(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.tfw.Event> events, AsyncRpcResponse<DemandEventsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return demandEvents(events, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest demandEvents(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.tfw.Event> events, AsyncRpcResponse<DemandEventsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["events"] = new JsonArray(events.Select(
          _value => (JsonValue)(_value.Encode())));
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("demandEvents", _parameters,
        _result => {
          try {
            var _ret = new DemandEventsResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class CancelEventTypeResult {
    }

    public CancelEventTypeResult cancelEventType(Com.Raritan.Idl.tfw.EventType evttype) {
      var _parameters = new LightJson.JsonObject();
      _parameters["evttype"] = evttype.Encode();

      var _result = RpcCall("cancelEventType", _parameters);
      var _ret = new CancelEventTypeResult();
      return _ret;
    }

    public AsyncRequest cancelEventType(Com.Raritan.Idl.tfw.EventType evttype, AsyncRpcResponse<CancelEventTypeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return cancelEventType(evttype, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest cancelEventType(Com.Raritan.Idl.tfw.EventType evttype, AsyncRpcResponse<CancelEventTypeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["evttype"] = evttype.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("cancelEventType", _parameters,
        _result => {
          try {
            var _ret = new CancelEventTypeResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class CancelEventTypesResult {
    }

    public CancelEventTypesResult cancelEventTypes(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.tfw.EventType> evttypes) {
      var _parameters = new LightJson.JsonObject();
      _parameters["evttypes"] = new JsonArray(evttypes.Select(
        _value => (JsonValue)(_value.Encode())));

      var _result = RpcCall("cancelEventTypes", _parameters);
      var _ret = new CancelEventTypesResult();
      return _ret;
    }

    public AsyncRequest cancelEventTypes(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.tfw.EventType> evttypes, AsyncRpcResponse<CancelEventTypesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return cancelEventTypes(evttypes, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest cancelEventTypes(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.tfw.EventType> evttypes, AsyncRpcResponse<CancelEventTypesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["evttypes"] = new JsonArray(evttypes.Select(
          _value => (JsonValue)(_value.Encode())));
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("cancelEventTypes", _parameters,
        _result => {
          try {
            var _ret = new CancelEventTypesResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class CancelEventResult {
    }

    public CancelEventResult cancelEvent(Com.Raritan.Idl.tfw.EventType evttype, ObjectProxy src) {
      var _parameters = new LightJson.JsonObject();
      _parameters["evttype"] = evttype.Encode();
      _parameters["src"] = src != null ? src.Encode() : JsonValue.Null;

      var _result = RpcCall("cancelEvent", _parameters);
      var _ret = new CancelEventResult();
      return _ret;
    }

    public AsyncRequest cancelEvent(Com.Raritan.Idl.tfw.EventType evttype, ObjectProxy src, AsyncRpcResponse<CancelEventResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return cancelEvent(evttype, src, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest cancelEvent(Com.Raritan.Idl.tfw.EventType evttype, ObjectProxy src, AsyncRpcResponse<CancelEventResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["evttype"] = evttype.Encode();
        _parameters["src"] = src != null ? src.Encode() : JsonValue.Null;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("cancelEvent", _parameters,
        _result => {
          try {
            var _ret = new CancelEventResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class CancelEventsResult {
    }

    public CancelEventsResult cancelEvents(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.tfw.Event> events) {
      var _parameters = new LightJson.JsonObject();
      _parameters["events"] = new JsonArray(events.Select(
        _value => (JsonValue)(_value.Encode())));

      var _result = RpcCall("cancelEvents", _parameters);
      var _ret = new CancelEventsResult();
      return _ret;
    }

    public AsyncRequest cancelEvents(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.tfw.Event> events, AsyncRpcResponse<CancelEventsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return cancelEvents(events, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest cancelEvents(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.tfw.Event> events, AsyncRpcResponse<CancelEventsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["events"] = new JsonArray(events.Select(
          _value => (JsonValue)(_value.Encode())));
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("cancelEvents", _parameters,
        _result => {
          try {
            var _ret = new CancelEventsResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
