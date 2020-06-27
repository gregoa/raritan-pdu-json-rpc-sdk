// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from WebcamManager.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.webcam {
  public class WebcamManager_2_0_1 : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("webcam.WebcamManager:2.0.1", null);

    public WebcamManager_2_0_1(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public WebcamManager_2_0_1(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new WebcamManager_2_0_1 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new WebcamManager_2_0_1(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int NO_ERROR = 0;

    public const int ERR_INVALID_PARAM = 1;

    public class GetWebcamsResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.webcam.Webcam_2_0_1> _ret_;
    }

    public GetWebcamsResult getWebcams() {
      JsonObject _parameters = null;
      var _result = RpcCall("getWebcams", _parameters);
      var _ret = new GetWebcamsResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.webcam.Webcam_2_0_1>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.webcam.Webcam_2_0_1.StaticCast(ObjectProxy.Decode(_value, agent))));
      return _ret;
    }

    public AsyncRequest getWebcams(AsyncRpcResponse<GetWebcamsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getWebcams(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getWebcams(AsyncRpcResponse<GetWebcamsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getWebcams", _parameters,
        _result => {
          try {
            var _ret = new GetWebcamsResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.webcam.Webcam_2_0_1>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.webcam.Webcam_2_0_1.StaticCast(ObjectProxy.Decode(_value, agent))));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetChannelResult {
      public int _ret_;
      public Com.Raritan.Idl.webcam.Channel_1_0_1 channel;
    }

    public GetChannelResult getChannel(Com.Raritan.Idl.webcam.Webcam_2_0_1 webcam, string clientType) {
      var _parameters = new LightJson.JsonObject();
      _parameters["webcam"] = webcam != null ? webcam.Encode() : JsonValue.Null;
      _parameters["clientType"] = clientType;

      var _result = RpcCall("getChannel", _parameters);
      var _ret = new GetChannelResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.channel = Com.Raritan.Idl.webcam.Channel_1_0_1.StaticCast(ObjectProxy.Decode(_result["channel"], agent));
      return _ret;
    }

    public AsyncRequest getChannel(Com.Raritan.Idl.webcam.Webcam_2_0_1 webcam, string clientType, AsyncRpcResponse<GetChannelResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getChannel(webcam, clientType, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getChannel(Com.Raritan.Idl.webcam.Webcam_2_0_1 webcam, string clientType, AsyncRpcResponse<GetChannelResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["webcam"] = webcam != null ? webcam.Encode() : JsonValue.Null;
        _parameters["clientType"] = clientType;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("getChannel", _parameters,
        _result => {
          try {
            var _ret = new GetChannelResult();
            _ret._ret_ = (int)_result["_ret_"];
            _ret.channel = Com.Raritan.Idl.webcam.Channel_1_0_1.StaticCast(ObjectProxy.Decode(_result["channel"], agent));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetChannelsResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.webcam.Channel_1_0_1> _ret_;
    }

    public GetChannelsResult getChannels() {
      JsonObject _parameters = null;
      var _result = RpcCall("getChannels", _parameters);
      var _ret = new GetChannelsResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.webcam.Channel_1_0_1>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.webcam.Channel_1_0_1.StaticCast(ObjectProxy.Decode(_value, agent))));
      return _ret;
    }

    public AsyncRequest getChannels(AsyncRpcResponse<GetChannelsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getChannels(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getChannels(AsyncRpcResponse<GetChannelsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getChannels", _parameters,
        _result => {
          try {
            var _ret = new GetChannelsResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.webcam.Channel_1_0_1>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.webcam.Channel_1_0_1.StaticCast(ObjectProxy.Decode(_value, agent))));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class RemoveClientTypeResult {
      public int _ret_;
    }

    public RemoveClientTypeResult removeClientType(string clientType) {
      var _parameters = new LightJson.JsonObject();
      _parameters["clientType"] = clientType;

      var _result = RpcCall("removeClientType", _parameters);
      var _ret = new RemoveClientTypeResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest removeClientType(string clientType, AsyncRpcResponse<RemoveClientTypeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return removeClientType(clientType, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest removeClientType(string clientType, AsyncRpcResponse<RemoveClientTypeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["clientType"] = clientType;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("removeClientType", _parameters,
        _result => {
          try {
            var _ret = new RemoveClientTypeResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetClientTypesResult {
      public System.Collections.Generic.IEnumerable<string> _ret_;
    }

    public GetClientTypesResult getClientTypes() {
      JsonObject _parameters = null;
      var _result = RpcCall("getClientTypes", _parameters);
      var _ret = new GetClientTypesResult();
      _ret._ret_ = new System.Collections.Generic.List<string>(_result["_ret_"].AsJsonArray.Select(
        _value => (string)_value));
      return _ret;
    }

    public AsyncRequest getClientTypes(AsyncRpcResponse<GetClientTypesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getClientTypes(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getClientTypes(AsyncRpcResponse<GetClientTypesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getClientTypes", _parameters,
        _result => {
          try {
            var _ret = new GetClientTypesResult();
            _ret._ret_ = new System.Collections.Generic.List<string>(_result["_ret_"].AsJsonArray.Select(
              _value => (string)_value));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetClientTypePrioritiesResult {
      public System.Collections.Generic.IDictionary<string, Com.Raritan.Idl.webcam.Priority> _ret_;
    }

    public GetClientTypePrioritiesResult getClientTypePriorities() {
      JsonObject _parameters = null;
      var _result = RpcCall("getClientTypePriorities", _parameters);
      var _ret = new GetClientTypePrioritiesResult();
      _ret._ret_ = DictionaryHelper.Create(_result["_ret_"].AsJsonArray.Select(
        _value => new System.Collections.Generic.KeyValuePair<string, Com.Raritan.Idl.webcam.Priority>(_value["key"], (Com.Raritan.Idl.webcam.Priority)(int)_value["value"])));
      return _ret;
    }

    public AsyncRequest getClientTypePriorities(AsyncRpcResponse<GetClientTypePrioritiesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getClientTypePriorities(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getClientTypePriorities(AsyncRpcResponse<GetClientTypePrioritiesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getClientTypePriorities", _parameters,
        _result => {
          try {
            var _ret = new GetClientTypePrioritiesResult();
            _ret._ret_ = DictionaryHelper.Create(_result["_ret_"].AsJsonArray.Select(
              _value => new System.Collections.Generic.KeyValuePair<string, Com.Raritan.Idl.webcam.Priority>(_value["key"], (Com.Raritan.Idl.webcam.Priority)(int)_value["value"])));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetClientTypePrioritiesResult {
      public int _ret_;
    }

    public SetClientTypePrioritiesResult setClientTypePriorities(System.Collections.Generic.IDictionary<string, Com.Raritan.Idl.webcam.Priority> priorities) {
      var _parameters = new LightJson.JsonObject();
      _parameters["priorities"] = new JsonArray(priorities.Select(_entry => (JsonValue) new JsonObject(new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, LightJson.JsonValue>> {
        new System.Collections.Generic.KeyValuePair<string, JsonValue>("key", _entry.Key),
        new System.Collections.Generic.KeyValuePair<string, JsonValue>("value", (int)_entry.Value)
      })));

      var _result = RpcCall("setClientTypePriorities", _parameters);
      var _ret = new SetClientTypePrioritiesResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setClientTypePriorities(System.Collections.Generic.IDictionary<string, Com.Raritan.Idl.webcam.Priority> priorities, AsyncRpcResponse<SetClientTypePrioritiesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setClientTypePriorities(priorities, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setClientTypePriorities(System.Collections.Generic.IDictionary<string, Com.Raritan.Idl.webcam.Priority> priorities, AsyncRpcResponse<SetClientTypePrioritiesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["priorities"] = new JsonArray(priorities.Select(_entry => (JsonValue) new JsonObject(new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, LightJson.JsonValue>> {
          new System.Collections.Generic.KeyValuePair<string, JsonValue>("key", _entry.Key),
          new System.Collections.Generic.KeyValuePair<string, JsonValue>("value", (int)_entry.Value)
        })));
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setClientTypePriorities", _parameters,
        _result => {
          try {
            var _ret = new SetClientTypePrioritiesResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetWebcamPrioritiesResult {
      public System.Collections.Generic.IDictionary<string, Com.Raritan.Idl.webcam.Priority> _ret_;
    }

    public GetWebcamPrioritiesResult getWebcamPriorities() {
      JsonObject _parameters = null;
      var _result = RpcCall("getWebcamPriorities", _parameters);
      var _ret = new GetWebcamPrioritiesResult();
      _ret._ret_ = DictionaryHelper.Create(_result["_ret_"].AsJsonArray.Select(
        _value => new System.Collections.Generic.KeyValuePair<string, Com.Raritan.Idl.webcam.Priority>(_value["key"], (Com.Raritan.Idl.webcam.Priority)(int)_value["value"])));
      return _ret;
    }

    public AsyncRequest getWebcamPriorities(AsyncRpcResponse<GetWebcamPrioritiesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getWebcamPriorities(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getWebcamPriorities(AsyncRpcResponse<GetWebcamPrioritiesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getWebcamPriorities", _parameters,
        _result => {
          try {
            var _ret = new GetWebcamPrioritiesResult();
            _ret._ret_ = DictionaryHelper.Create(_result["_ret_"].AsJsonArray.Select(
              _value => new System.Collections.Generic.KeyValuePair<string, Com.Raritan.Idl.webcam.Priority>(_value["key"], (Com.Raritan.Idl.webcam.Priority)(int)_value["value"])));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetWebcamPrioritiesResult {
      public int _ret_;
    }

    public SetWebcamPrioritiesResult setWebcamPriorities(System.Collections.Generic.IDictionary<string, Com.Raritan.Idl.webcam.Priority> priorities) {
      var _parameters = new LightJson.JsonObject();
      _parameters["priorities"] = new JsonArray(priorities.Select(_entry => (JsonValue) new JsonObject(new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, LightJson.JsonValue>> {
        new System.Collections.Generic.KeyValuePair<string, JsonValue>("key", _entry.Key),
        new System.Collections.Generic.KeyValuePair<string, JsonValue>("value", (int)_entry.Value)
      })));

      var _result = RpcCall("setWebcamPriorities", _parameters);
      var _ret = new SetWebcamPrioritiesResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setWebcamPriorities(System.Collections.Generic.IDictionary<string, Com.Raritan.Idl.webcam.Priority> priorities, AsyncRpcResponse<SetWebcamPrioritiesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setWebcamPriorities(priorities, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setWebcamPriorities(System.Collections.Generic.IDictionary<string, Com.Raritan.Idl.webcam.Priority> priorities, AsyncRpcResponse<SetWebcamPrioritiesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["priorities"] = new JsonArray(priorities.Select(_entry => (JsonValue) new JsonObject(new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, LightJson.JsonValue>> {
          new System.Collections.Generic.KeyValuePair<string, JsonValue>("key", _entry.Key),
          new System.Collections.Generic.KeyValuePair<string, JsonValue>("value", (int)_entry.Value)
        })));
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setWebcamPriorities", _parameters,
        _result => {
          try {
            var _ret = new SetWebcamPrioritiesResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
