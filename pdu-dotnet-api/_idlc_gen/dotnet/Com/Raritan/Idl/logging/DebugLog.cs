// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from DebugLog.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.logging {
  public class DebugLog : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("logging.DebugLog:1.0.0", null);

    public DebugLog(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public DebugLog(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new DebugLog StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new DebugLog(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class ClearResult {
    }

    public ClearResult clear() {
      JsonObject _parameters = null;
      var _result = RpcCall("clear", _parameters);
      var _ret = new ClearResult();
      return _ret;
    }

    public AsyncRequest clear(AsyncRpcResponse<ClearResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return clear(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest clear(AsyncRpcResponse<ClearResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("clear", _parameters,
        _result => {
          try {
            var _ret = new ClearResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetFirstIdResult {
      public int _ret_;
    }

    public GetFirstIdResult getFirstId() {
      JsonObject _parameters = null;
      var _result = RpcCall("getFirstId", _parameters);
      var _ret = new GetFirstIdResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest getFirstId(AsyncRpcResponse<GetFirstIdResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getFirstId(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getFirstId(AsyncRpcResponse<GetFirstIdResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getFirstId", _parameters,
        _result => {
          try {
            var _ret = new GetFirstIdResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetLastIdResult {
      public int _ret_;
    }

    public GetLastIdResult getLastId() {
      JsonObject _parameters = null;
      var _result = RpcCall("getLastId", _parameters);
      var _ret = new GetLastIdResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest getLastId(AsyncRpcResponse<GetLastIdResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getLastId(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getLastId(AsyncRpcResponse<GetLastIdResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getLastId", _parameters,
        _result => {
          try {
            var _ret = new GetLastIdResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetEntriesResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.logging.LogEntry> entries;
    }

    public GetEntriesResult getEntries(int refId, int count, Com.Raritan.Idl.logging.RangeDirection direction) {
      var _parameters = new LightJson.JsonObject();
      _parameters["refId"] = refId;
      _parameters["count"] = count;
      _parameters["direction"] = (int)direction;

      var _result = RpcCall("getEntries", _parameters);
      var _ret = new GetEntriesResult();
      _ret.entries = new System.Collections.Generic.List<Com.Raritan.Idl.logging.LogEntry>(_result["entries"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.logging.LogEntry.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getEntries(int refId, int count, Com.Raritan.Idl.logging.RangeDirection direction, AsyncRpcResponse<GetEntriesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getEntries(refId, count, direction, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getEntries(int refId, int count, Com.Raritan.Idl.logging.RangeDirection direction, AsyncRpcResponse<GetEntriesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["refId"] = refId;
        _parameters["count"] = count;
        _parameters["direction"] = (int)direction;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("getEntries", _parameters,
        _result => {
          try {
            var _ret = new GetEntriesResult();
            _ret.entries = new System.Collections.Generic.List<Com.Raritan.Idl.logging.LogEntry>(_result["entries"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.logging.LogEntry.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
