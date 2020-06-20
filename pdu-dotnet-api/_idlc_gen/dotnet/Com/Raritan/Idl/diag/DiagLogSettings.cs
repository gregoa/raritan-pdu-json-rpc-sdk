// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from DiagLogSettings.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.diag {
  public class DiagLogSettings : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("diag.DiagLogSettings:1.0.0", null);

    public DiagLogSettings(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public DiagLogSettings(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new DiagLogSettings StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new DiagLogSettings(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public enum LogLevel {
      LOG_LEVEL_NONE,
      LOG_LEVEL_ERR,
      LOG_LEVEL_WARN,
      LOG_LEVEL_INFO,
      LOG_LEVEL_DEBUG,
      LOG_LEVEL_TRACE,
    }

    public class LogLevelEntry : ICloneable {
      public object Clone() {
        LogLevelEntry copy = new LogLevelEntry();
        copy.ctxName = this.ctxName;
        copy.logLevel = this.logLevel;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["ctxName"] = this.ctxName;
        json["logLevel"] = (int)this.logLevel;
        return json;
      }

      public static LogLevelEntry Decode(LightJson.JsonObject json, Agent agent) {
        LogLevelEntry inst = new LogLevelEntry();
        inst.ctxName = (string)json["ctxName"];
        inst.logLevel = (Com.Raritan.Idl.diag.DiagLogSettings.LogLevel)(int)json["logLevel"];
        return inst;
      }

      public string ctxName = "";
      public Com.Raritan.Idl.diag.DiagLogSettings.LogLevel logLevel = Com.Raritan.Idl.diag.DiagLogSettings.LogLevel.LOG_LEVEL_NONE;
    }

    public const int ERR_NONE = 0;

    public const int ERR_UNKNOWN_LOG_CONTEXT_NAME = 1;

    public const int ERR_UNKNOWN_LOG_LEVEL = 2;

    public class ResetLogLevelsForAllCtxNamesResult {
    }

    public ResetLogLevelsForAllCtxNamesResult resetLogLevelsForAllCtxNames() {
      JsonObject _parameters = null;
      var _result = RpcCall("resetLogLevelsForAllCtxNames", _parameters);
      var _ret = new ResetLogLevelsForAllCtxNamesResult();
      return _ret;
    }

    public AsyncRequest resetLogLevelsForAllCtxNames(AsyncRpcResponse<ResetLogLevelsForAllCtxNamesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return resetLogLevelsForAllCtxNames(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest resetLogLevelsForAllCtxNames(AsyncRpcResponse<ResetLogLevelsForAllCtxNamesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("resetLogLevelsForAllCtxNames", _parameters,
        _result => {
          try {
            var _ret = new ResetLogLevelsForAllCtxNamesResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetLogLevelsForAllCtxNamesResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.diag.DiagLogSettings.LogLevelEntry> _ret_;
    }

    public GetLogLevelsForAllCtxNamesResult getLogLevelsForAllCtxNames() {
      JsonObject _parameters = null;
      var _result = RpcCall("getLogLevelsForAllCtxNames", _parameters);
      var _ret = new GetLogLevelsForAllCtxNamesResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.diag.DiagLogSettings.LogLevelEntry>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.diag.DiagLogSettings.LogLevelEntry.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getLogLevelsForAllCtxNames(AsyncRpcResponse<GetLogLevelsForAllCtxNamesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getLogLevelsForAllCtxNames(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getLogLevelsForAllCtxNames(AsyncRpcResponse<GetLogLevelsForAllCtxNamesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getLogLevelsForAllCtxNames", _parameters,
        _result => {
          try {
            var _ret = new GetLogLevelsForAllCtxNamesResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.diag.DiagLogSettings.LogLevelEntry>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.diag.DiagLogSettings.LogLevelEntry.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetLogLevelForAllCtxNamesResult {
      public int _ret_;
    }

    public SetLogLevelForAllCtxNamesResult setLogLevelForAllCtxNames(Com.Raritan.Idl.diag.DiagLogSettings.LogLevel logLevel) {
      var _parameters = new LightJson.JsonObject();
      _parameters["logLevel"] = (int)logLevel;

      var _result = RpcCall("setLogLevelForAllCtxNames", _parameters);
      var _ret = new SetLogLevelForAllCtxNamesResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setLogLevelForAllCtxNames(Com.Raritan.Idl.diag.DiagLogSettings.LogLevel logLevel, AsyncRpcResponse<SetLogLevelForAllCtxNamesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setLogLevelForAllCtxNames(logLevel, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setLogLevelForAllCtxNames(Com.Raritan.Idl.diag.DiagLogSettings.LogLevel logLevel, AsyncRpcResponse<SetLogLevelForAllCtxNamesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["logLevel"] = (int)logLevel;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setLogLevelForAllCtxNames", _parameters,
        _result => {
          try {
            var _ret = new SetLogLevelForAllCtxNamesResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetLogLevelByCtxNameResult {
      public int _ret_;
      public Com.Raritan.Idl.diag.DiagLogSettings.LogLevel logLevel;
    }

    public GetLogLevelByCtxNameResult getLogLevelByCtxName(string ctxName) {
      var _parameters = new LightJson.JsonObject();
      _parameters["ctxName"] = ctxName;

      var _result = RpcCall("getLogLevelByCtxName", _parameters);
      var _ret = new GetLogLevelByCtxNameResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.logLevel = (Com.Raritan.Idl.diag.DiagLogSettings.LogLevel)(int)_result["logLevel"];
      return _ret;
    }

    public AsyncRequest getLogLevelByCtxName(string ctxName, AsyncRpcResponse<GetLogLevelByCtxNameResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getLogLevelByCtxName(ctxName, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getLogLevelByCtxName(string ctxName, AsyncRpcResponse<GetLogLevelByCtxNameResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["ctxName"] = ctxName;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("getLogLevelByCtxName", _parameters,
        _result => {
          try {
            var _ret = new GetLogLevelByCtxNameResult();
            _ret._ret_ = (int)_result["_ret_"];
            _ret.logLevel = (Com.Raritan.Idl.diag.DiagLogSettings.LogLevel)(int)_result["logLevel"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetLogLevelByCtxNameResult {
      public int _ret_;
    }

    public SetLogLevelByCtxNameResult setLogLevelByCtxName(string ctxName, Com.Raritan.Idl.diag.DiagLogSettings.LogLevel logLevel) {
      var _parameters = new LightJson.JsonObject();
      _parameters["ctxName"] = ctxName;
      _parameters["logLevel"] = (int)logLevel;

      var _result = RpcCall("setLogLevelByCtxName", _parameters);
      var _ret = new SetLogLevelByCtxNameResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setLogLevelByCtxName(string ctxName, Com.Raritan.Idl.diag.DiagLogSettings.LogLevel logLevel, AsyncRpcResponse<SetLogLevelByCtxNameResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setLogLevelByCtxName(ctxName, logLevel, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setLogLevelByCtxName(string ctxName, Com.Raritan.Idl.diag.DiagLogSettings.LogLevel logLevel, AsyncRpcResponse<SetLogLevelByCtxNameResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["ctxName"] = ctxName;
        _parameters["logLevel"] = (int)logLevel;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setLogLevelByCtxName", _parameters,
        _result => {
          try {
            var _ret = new SetLogLevelByCtxNameResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}