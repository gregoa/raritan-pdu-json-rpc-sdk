// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from SessionManager.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.session {
  public class SessionManager : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("session.SessionManager:1.0.0", null);

    public SessionManager(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public SessionManager(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new SessionManager StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new SessionManager(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int ERR_ACTIVE_SESSION_EXCLUSIVE_FOR_USER = 1;

    public enum CloseReason {
      CLOSE_REASON_LOGOUT,
      CLOSE_REASON_TIMEOUT,
      CLOSE_REASON_BROWSER_CLOSED,
      CLOSE_REASON_FORCED_DISCONNECT,
    }

    public class NewSessionResult {
      public int _ret_;
      public Com.Raritan.Idl.session.Session session;
    }

    public NewSessionResult newSession() {
      JsonObject _parameters = null;
      var _result = RpcCall("newSession", _parameters);
      var _ret = new NewSessionResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.session = Com.Raritan.Idl.session.Session.Decode(_result["session"], agent);
      return _ret;
    }

    public AsyncRequest newSession(AsyncRpcResponse<NewSessionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return newSession(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest newSession(AsyncRpcResponse<NewSessionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("newSession", _parameters,
        _result => {
          try {
            var _ret = new NewSessionResult();
            _ret._ret_ = (int)_result["_ret_"];
            _ret.session = Com.Raritan.Idl.session.Session.Decode(_result["session"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSessionResult {
      public Com.Raritan.Idl.session.Session _ret_;
    }

    public GetSessionResult getSession(string token) {
      var _parameters = new LightJson.JsonObject();
      _parameters["token"] = token;

      var _result = RpcCall("getSession", _parameters);
      var _ret = new GetSessionResult();
      _ret._ret_ = Com.Raritan.Idl.session.Session.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getSession(string token, AsyncRpcResponse<GetSessionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getSession(token, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getSession(string token, AsyncRpcResponse<GetSessionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["token"] = token;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("getSession", _parameters,
        _result => {
          try {
            var _ret = new GetSessionResult();
            _ret._ret_ = Com.Raritan.Idl.session.Session.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetCurrentSessionResult {
      public Com.Raritan.Idl.session.Session _ret_;
    }

    public GetCurrentSessionResult getCurrentSession() {
      JsonObject _parameters = null;
      var _result = RpcCall("getCurrentSession", _parameters);
      var _ret = new GetCurrentSessionResult();
      _ret._ret_ = Com.Raritan.Idl.session.Session.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getCurrentSession(AsyncRpcResponse<GetCurrentSessionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getCurrentSession(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getCurrentSession(AsyncRpcResponse<GetCurrentSessionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getCurrentSession", _parameters,
        _result => {
          try {
            var _ret = new GetCurrentSessionResult();
            _ret._ret_ = Com.Raritan.Idl.session.Session.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSessionsResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.session.Session> _ret_;
    }

    public GetSessionsResult getSessions() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSessions", _parameters);
      var _ret = new GetSessionsResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.session.Session>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.session.Session.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getSessions(AsyncRpcResponse<GetSessionsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getSessions(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getSessions(AsyncRpcResponse<GetSessionsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getSessions", _parameters,
        _result => {
          try {
            var _ret = new GetSessionsResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.session.Session>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.session.Session.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class CloseSessionResult {
    }

    public CloseSessionResult closeSession(string token, Com.Raritan.Idl.session.SessionManager.CloseReason reason) {
      var _parameters = new LightJson.JsonObject();
      _parameters["token"] = token;
      _parameters["reason"] = (int)reason;

      var _result = RpcCall("closeSession", _parameters);
      var _ret = new CloseSessionResult();
      return _ret;
    }

    public AsyncRequest closeSession(string token, Com.Raritan.Idl.session.SessionManager.CloseReason reason, AsyncRpcResponse<CloseSessionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return closeSession(token, reason, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest closeSession(string token, Com.Raritan.Idl.session.SessionManager.CloseReason reason, AsyncRpcResponse<CloseSessionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["token"] = token;
        _parameters["reason"] = (int)reason;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("closeSession", _parameters,
        _result => {
          try {
            var _ret = new CloseSessionResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class CloseCurrentSessionResult {
    }

    public CloseCurrentSessionResult closeCurrentSession(Com.Raritan.Idl.session.SessionManager.CloseReason reason) {
      var _parameters = new LightJson.JsonObject();
      _parameters["reason"] = (int)reason;

      var _result = RpcCall("closeCurrentSession", _parameters);
      var _ret = new CloseCurrentSessionResult();
      return _ret;
    }

    public AsyncRequest closeCurrentSession(Com.Raritan.Idl.session.SessionManager.CloseReason reason, AsyncRpcResponse<CloseCurrentSessionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return closeCurrentSession(reason, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest closeCurrentSession(Com.Raritan.Idl.session.SessionManager.CloseReason reason, AsyncRpcResponse<CloseCurrentSessionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["reason"] = (int)reason;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("closeCurrentSession", _parameters,
        _result => {
          try {
            var _ret = new CloseCurrentSessionResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class TouchSessionResult {
    }

    public TouchSessionResult touchSession(string token) {
      var _parameters = new LightJson.JsonObject();
      _parameters["token"] = token;

      var _result = RpcCall("touchSession", _parameters);
      var _ret = new TouchSessionResult();
      return _ret;
    }

    public AsyncRequest touchSession(string token, AsyncRpcResponse<TouchSessionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return touchSession(token, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest touchSession(string token, AsyncRpcResponse<TouchSessionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["token"] = token;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("touchSession", _parameters,
        _result => {
          try {
            var _ret = new TouchSessionResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class TouchCurrentSessionResult {
    }

    public TouchCurrentSessionResult touchCurrentSession(bool userActivity) {
      var _parameters = new LightJson.JsonObject();
      _parameters["userActivity"] = userActivity;

      var _result = RpcCall("touchCurrentSession", _parameters);
      var _ret = new TouchCurrentSessionResult();
      return _ret;
    }

    public AsyncRequest touchCurrentSession(bool userActivity, AsyncRpcResponse<TouchCurrentSessionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return touchCurrentSession(userActivity, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest touchCurrentSession(bool userActivity, AsyncRpcResponse<TouchCurrentSessionResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["userActivity"] = userActivity;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("touchCurrentSession", _parameters,
        _result => {
          try {
            var _ret = new TouchCurrentSessionResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSessionHistoryResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.session.HistoryEntry> _ret_;
    }

    public GetSessionHistoryResult getSessionHistory() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSessionHistory", _parameters);
      var _ret = new GetSessionHistoryResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.session.HistoryEntry>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.session.HistoryEntry.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getSessionHistory(AsyncRpcResponse<GetSessionHistoryResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getSessionHistory(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getSessionHistory(AsyncRpcResponse<GetSessionHistoryResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getSessionHistory", _parameters,
        _result => {
          try {
            var _ret = new GetSessionHistoryResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.session.HistoryEntry>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.session.HistoryEntry.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
