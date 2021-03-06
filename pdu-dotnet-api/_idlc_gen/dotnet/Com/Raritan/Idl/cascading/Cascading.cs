// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Cascading.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.cascading {
  public class Cascading : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("cascading.Cascading:1.0.0", null);

    public Cascading(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Cascading(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Cascading StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Cascading(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int ERR_NOT_AVAILABLE = 1;

    public const int ERR_NOT_SUPPORTED_ON_SLAVE = 2;

    public enum Type {
      USB_MULTI_IP,
      USB_SINGLE_IP_NAT,
    }

    public class ProtocolMapping : ICloneable {
      public object Clone() {
        ProtocolMapping copy = new ProtocolMapping();
        copy.appProtoId = this.appProtoId;
        copy.appProtoName = this.appProtoName;
        copy.transportProtoName = this.transportProtoName;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["appProtoId"] = this.appProtoId;
        json["appProtoName"] = this.appProtoName;
        json["transportProtoName"] = this.transportProtoName;
        return json;
      }

      public static ProtocolMapping Decode(LightJson.JsonObject json, Agent agent) {
        ProtocolMapping inst = new ProtocolMapping();
        inst.appProtoId = (int)json["appProtoId"];
        inst.appProtoName = (string)json["appProtoName"];
        inst.transportProtoName = (string)json["transportProtoName"];
        return inst;
      }

      public int appProtoId = 0;
      public string appProtoName = "";
      public string transportProtoName = "";
    }

    public class SetTypeResult {
      public int _ret_;
    }

    public SetTypeResult setType(Com.Raritan.Idl.cascading.Cascading.Type type) {
      var _parameters = new LightJson.JsonObject();
      _parameters["type"] = (int)type;

      var _result = RpcCall("setType", _parameters);
      var _ret = new SetTypeResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setType(Com.Raritan.Idl.cascading.Cascading.Type type, AsyncRpcResponse<SetTypeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setType(type, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setType(Com.Raritan.Idl.cascading.Cascading.Type type, AsyncRpcResponse<SetTypeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["type"] = (int)type;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setType", _parameters,
        _result => {
          try {
            var _ret = new SetTypeResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetTypeResult {
      public int _ret_;
      public Com.Raritan.Idl.cascading.Cascading.Type type;
    }

    public GetTypeResult getType() {
      JsonObject _parameters = null;
      var _result = RpcCall("getType", _parameters);
      var _ret = new GetTypeResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.type = (Com.Raritan.Idl.cascading.Cascading.Type)(int)_result["type"];
      return _ret;
    }

    public AsyncRequest getType(AsyncRpcResponse<GetTypeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getType(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getType(AsyncRpcResponse<GetTypeResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getType", _parameters,
        _result => {
          try {
            var _ret = new GetTypeResult();
            _ret._ret_ = (int)_result["_ret_"];
            _ret.type = (Com.Raritan.Idl.cascading.Cascading.Type)(int)_result["type"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetIndexResult {
      public int idx;
    }

    public GetIndexResult getIndex() {
      JsonObject _parameters = null;
      var _result = RpcCall("getIndex", _parameters);
      var _ret = new GetIndexResult();
      _ret.idx = (int)_result["idx"];
      return _ret;
    }

    public AsyncRequest getIndex(AsyncRpcResponse<GetIndexResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getIndex(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getIndex(AsyncRpcResponse<GetIndexResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getIndex", _parameters,
        _result => {
          try {
            var _ret = new GetIndexResult();
            _ret.idx = (int)_result["idx"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetMasterIpAddressResult {
      public string masterIpAddress;
    }

    public GetMasterIpAddressResult getMasterIpAddress() {
      JsonObject _parameters = null;
      var _result = RpcCall("getMasterIpAddress", _parameters);
      var _ret = new GetMasterIpAddressResult();
      _ret.masterIpAddress = (string)_result["masterIpAddress"];
      return _ret;
    }

    public AsyncRequest getMasterIpAddress(AsyncRpcResponse<GetMasterIpAddressResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getMasterIpAddress(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getMasterIpAddress(AsyncRpcResponse<GetMasterIpAddressResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getMasterIpAddress", _parameters,
        _result => {
          try {
            var _ret = new GetMasterIpAddressResult();
            _ret.masterIpAddress = (string)_result["masterIpAddress"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetProtocolMappingsResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.cascading.Cascading.ProtocolMapping> mappings;
    }

    public GetProtocolMappingsResult getProtocolMappings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getProtocolMappings", _parameters);
      var _ret = new GetProtocolMappingsResult();
      _ret.mappings = new System.Collections.Generic.List<Com.Raritan.Idl.cascading.Cascading.ProtocolMapping>(_result["mappings"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.cascading.Cascading.ProtocolMapping.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getProtocolMappings(AsyncRpcResponse<GetProtocolMappingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getProtocolMappings(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getProtocolMappings(AsyncRpcResponse<GetProtocolMappingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getProtocolMappings", _parameters,
        _result => {
          try {
            var _ret = new GetProtocolMappingsResult();
            _ret.mappings = new System.Collections.Generic.List<Com.Raritan.Idl.cascading.Cascading.ProtocolMapping>(_result["mappings"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.cascading.Cascading.ProtocolMapping.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
