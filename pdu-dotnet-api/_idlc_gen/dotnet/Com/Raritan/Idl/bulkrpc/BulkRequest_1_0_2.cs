// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from BulkRequest.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.bulkrpc {
  public class BulkRequest_1_0_2 : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("bulkrpc.BulkRequest:1.0.2", null);

    public BulkRequest_1_0_2(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public BulkRequest_1_0_2(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new BulkRequest_1_0_2 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new BulkRequest_1_0_2(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class Request : ICloneable {
      public object Clone() {
        Request copy = new Request();
        copy.rid = this.rid;
        copy.json = this.json;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["rid"] = this.rid;
        json["json"] = this.json.Encode();
        return json;
      }

      public static Request Decode(LightJson.JsonObject json, Agent agent) {
        Request inst = new Request();
        inst.rid = (string)json["rid"];
        inst.json = Com.Raritan.Idl.bulkrpc.JsonObject.Decode(json["json"], agent);
        return inst;
      }

      public string rid = "";
      public Com.Raritan.Idl.bulkrpc.JsonObject json = new Com.Raritan.Idl.bulkrpc.JsonObject();
    }

    public class Response : ICloneable {
      public object Clone() {
        Response copy = new Response();
        copy.json = this.json;
        copy.statcode = this.statcode;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["json"] = this.json.Encode();
        json["statcode"] = this.statcode;
        return json;
      }

      public static Response Decode(LightJson.JsonObject json, Agent agent) {
        Response inst = new Response();
        inst.json = Com.Raritan.Idl.bulkrpc.JsonObject.Decode(json["json"], agent);
        inst.statcode = (int)json["statcode"];
        return inst;
      }

      public Com.Raritan.Idl.bulkrpc.JsonObject json = new Com.Raritan.Idl.bulkrpc.JsonObject();
      public int statcode = 0;
    }

    public class PerformRequestResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.bulkrpc.Response> responses;
    }

    public PerformRequestResult performRequest(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.bulkrpc.Request> requests) {
      var _parameters = new LightJson.JsonObject();
      _parameters["requests"] = new JsonArray(requests.Select(
        _value => (JsonValue)(_value.Encode())));

      var _result = RpcCall("performRequest", _parameters);
      var _ret = new PerformRequestResult();
      _ret.responses = new System.Collections.Generic.List<Com.Raritan.Idl.bulkrpc.Response>(_result["responses"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.bulkrpc.Response.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest performRequest(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.bulkrpc.Request> requests, AsyncRpcResponse<PerformRequestResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return performRequest(requests, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest performRequest(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.bulkrpc.Request> requests, AsyncRpcResponse<PerformRequestResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["requests"] = new JsonArray(requests.Select(
          _value => (JsonValue)(_value.Encode())));
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("performRequest", _parameters,
        _result => {
          try {
            var _ret = new PerformRequestResult();
            _ret.responses = new System.Collections.Generic.List<Com.Raritan.Idl.bulkrpc.Response>(_result["responses"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.bulkrpc.Response.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class PerformBulkResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Response> responses;
    }

    public PerformBulkResult performBulk(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Request> requests) {
      var _parameters = new LightJson.JsonObject();
      _parameters["requests"] = new JsonArray(requests.Select(
        _value => (JsonValue)(_value.Encode())));

      var _result = RpcCall("performBulk", _parameters);
      var _ret = new PerformBulkResult();
      _ret.responses = new System.Collections.Generic.List<Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Response>(_result["responses"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Response.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest performBulk(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Request> requests, AsyncRpcResponse<PerformBulkResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return performBulk(requests, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest performBulk(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Request> requests, AsyncRpcResponse<PerformBulkResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["requests"] = new JsonArray(requests.Select(
          _value => (JsonValue)(_value.Encode())));
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("performBulk", _parameters,
        _result => {
          try {
            var _ret = new PerformBulkResult();
            _ret.responses = new System.Collections.Generic.List<Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Response>(_result["responses"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Response.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class PerformBulkTimeoutResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Response> responses;
    }

    public PerformBulkTimeoutResult performBulkTimeout(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Request> requests, int timeoutMs) {
      var _parameters = new LightJson.JsonObject();
      _parameters["requests"] = new JsonArray(requests.Select(
        _value => (JsonValue)(_value.Encode())));
      _parameters["timeoutMs"] = timeoutMs;

      var _result = RpcCall("performBulkTimeout", _parameters);
      var _ret = new PerformBulkTimeoutResult();
      _ret.responses = new System.Collections.Generic.List<Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Response>(_result["responses"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Response.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest performBulkTimeout(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Request> requests, int timeoutMs, AsyncRpcResponse<PerformBulkTimeoutResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return performBulkTimeout(requests, timeoutMs, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest performBulkTimeout(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Request> requests, int timeoutMs, AsyncRpcResponse<PerformBulkTimeoutResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["requests"] = new JsonArray(requests.Select(
          _value => (JsonValue)(_value.Encode())));
        _parameters["timeoutMs"] = timeoutMs;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("performBulkTimeout", _parameters,
        _result => {
          try {
            var _ret = new PerformBulkTimeoutResult();
            _ret.responses = new System.Collections.Generic.List<Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Response>(_result["responses"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.bulkrpc.BulkRequest_1_0_2.Response.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
