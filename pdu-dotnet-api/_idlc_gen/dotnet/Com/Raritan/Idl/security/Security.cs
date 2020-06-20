// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Security.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.security {
  public class Security : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("security.Security:1.0.0", null);

    public Security(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Security(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Security StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Security(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int ERR_INVALID_VALUE = 1;

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.http2httpsRedir = this.http2httpsRedir;
        copy.userBlockTimeout = this.userBlockTimeout;
        copy.userMaxFailedLogins = this.userMaxFailedLogins;
        copy.ipFw = this.ipFw;
        copy.roleAccessControl = this.roleAccessControl;
        copy.pwSettings = this.pwSettings;
        copy.idleTimeout = this.idleTimeout;
        copy.singleLogin = this.singleLogin;
        copy.sshSettings = this.sshSettings;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["http2httpsRedir"] = this.http2httpsRedir;
        json["userBlockTimeout"] = this.userBlockTimeout;
        json["userMaxFailedLogins"] = this.userMaxFailedLogins;
        json["ipFw"] = this.ipFw.Encode();
        json["roleAccessControl"] = this.roleAccessControl.Encode();
        json["pwSettings"] = this.pwSettings.Encode();
        json["idleTimeout"] = this.idleTimeout;
        json["singleLogin"] = this.singleLogin;
        json["sshSettings"] = this.sshSettings.Encode();
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.http2httpsRedir = (bool)json["http2httpsRedir"];
        inst.userBlockTimeout = (int)json["userBlockTimeout"];
        inst.userMaxFailedLogins = (int)json["userMaxFailedLogins"];
        inst.ipFw = Com.Raritan.Idl.security.IpFw.Decode(json["ipFw"], agent);
        inst.roleAccessControl = Com.Raritan.Idl.security.RoleAccessControl.Decode(json["roleAccessControl"], agent);
        inst.pwSettings = Com.Raritan.Idl.security.PasswordSettings.Decode(json["pwSettings"], agent);
        inst.idleTimeout = (int)json["idleTimeout"];
        inst.singleLogin = (bool)json["singleLogin"];
        inst.sshSettings = Com.Raritan.Idl.security.SSHSettings.Decode(json["sshSettings"], agent);
        return inst;
      }

      public bool http2httpsRedir = false;
      public int userBlockTimeout = 0;
      public int userMaxFailedLogins = 0;
      public Com.Raritan.Idl.security.IpFw ipFw = new Com.Raritan.Idl.security.IpFw();
      public Com.Raritan.Idl.security.RoleAccessControl roleAccessControl = new Com.Raritan.Idl.security.RoleAccessControl();
      public Com.Raritan.Idl.security.PasswordSettings pwSettings = new Com.Raritan.Idl.security.PasswordSettings();
      public int idleTimeout = 0;
      public bool singleLogin = false;
      public Com.Raritan.Idl.security.SSHSettings sshSettings = new Com.Raritan.Idl.security.SSHSettings();
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.security.Security.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.security.Security.Settings.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getSettings(AsyncRpcResponse<GetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getSettings(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getSettings(AsyncRpcResponse<GetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getSettings", _parameters,
        _result => {
          try {
            var _ret = new GetSettingsResult();
            _ret._ret_ = Com.Raritan.Idl.security.Security.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.security.Security.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.security.Security.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.security.Security.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["settings"] = settings.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setSettings", _parameters,
        _result => {
          try {
            var _ret = new SetSettingsResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetHttpRedirSettingsResult {
    }

    public SetHttpRedirSettingsResult setHttpRedirSettings(bool http2httpsRedir) {
      var _parameters = new LightJson.JsonObject();
      _parameters["http2httpsRedir"] = http2httpsRedir;

      var _result = RpcCall("setHttpRedirSettings", _parameters);
      var _ret = new SetHttpRedirSettingsResult();
      return _ret;
    }

    public AsyncRequest setHttpRedirSettings(bool http2httpsRedir, AsyncRpcResponse<SetHttpRedirSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setHttpRedirSettings(http2httpsRedir, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setHttpRedirSettings(bool http2httpsRedir, AsyncRpcResponse<SetHttpRedirSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["http2httpsRedir"] = http2httpsRedir;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setHttpRedirSettings", _parameters,
        _result => {
          try {
            var _ret = new SetHttpRedirSettingsResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetIpFwSettingsResult {
      public int _ret_;
    }

    public SetIpFwSettingsResult setIpFwSettings(Com.Raritan.Idl.security.IpFw ipFw) {
      var _parameters = new LightJson.JsonObject();
      _parameters["ipFw"] = ipFw.Encode();

      var _result = RpcCall("setIpFwSettings", _parameters);
      var _ret = new SetIpFwSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setIpFwSettings(Com.Raritan.Idl.security.IpFw ipFw, AsyncRpcResponse<SetIpFwSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setIpFwSettings(ipFw, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setIpFwSettings(Com.Raritan.Idl.security.IpFw ipFw, AsyncRpcResponse<SetIpFwSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["ipFw"] = ipFw.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setIpFwSettings", _parameters,
        _result => {
          try {
            var _ret = new SetIpFwSettingsResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetRoleAccessControlSettingsResult {
      public int _ret_;
    }

    public SetRoleAccessControlSettingsResult setRoleAccessControlSettings(Com.Raritan.Idl.security.RoleAccessControl settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setRoleAccessControlSettings", _parameters);
      var _ret = new SetRoleAccessControlSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setRoleAccessControlSettings(Com.Raritan.Idl.security.RoleAccessControl settings, AsyncRpcResponse<SetRoleAccessControlSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setRoleAccessControlSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setRoleAccessControlSettings(Com.Raritan.Idl.security.RoleAccessControl settings, AsyncRpcResponse<SetRoleAccessControlSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["settings"] = settings.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setRoleAccessControlSettings", _parameters,
        _result => {
          try {
            var _ret = new SetRoleAccessControlSettingsResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetBlockSettingsResult {
      public int _ret_;
    }

    public SetBlockSettingsResult setBlockSettings(int blockTimeout, int maxFailedLogins) {
      var _parameters = new LightJson.JsonObject();
      _parameters["blockTimeout"] = blockTimeout;
      _parameters["maxFailedLogins"] = maxFailedLogins;

      var _result = RpcCall("setBlockSettings", _parameters);
      var _ret = new SetBlockSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setBlockSettings(int blockTimeout, int maxFailedLogins, AsyncRpcResponse<SetBlockSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setBlockSettings(blockTimeout, maxFailedLogins, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setBlockSettings(int blockTimeout, int maxFailedLogins, AsyncRpcResponse<SetBlockSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["blockTimeout"] = blockTimeout;
        _parameters["maxFailedLogins"] = maxFailedLogins;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setBlockSettings", _parameters,
        _result => {
          try {
            var _ret = new SetBlockSettingsResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetPwSettingsResult {
      public int _ret_;
    }

    public SetPwSettingsResult setPwSettings(Com.Raritan.Idl.security.PasswordSettings pwSettings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["pwSettings"] = pwSettings.Encode();

      var _result = RpcCall("setPwSettings", _parameters);
      var _ret = new SetPwSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setPwSettings(Com.Raritan.Idl.security.PasswordSettings pwSettings, AsyncRpcResponse<SetPwSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setPwSettings(pwSettings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setPwSettings(Com.Raritan.Idl.security.PasswordSettings pwSettings, AsyncRpcResponse<SetPwSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["pwSettings"] = pwSettings.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setPwSettings", _parameters,
        _result => {
          try {
            var _ret = new SetPwSettingsResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetIdleTimeoutSettingsResult {
      public int _ret_;
    }

    public SetIdleTimeoutSettingsResult setIdleTimeoutSettings(int idleTimeout) {
      var _parameters = new LightJson.JsonObject();
      _parameters["idleTimeout"] = idleTimeout;

      var _result = RpcCall("setIdleTimeoutSettings", _parameters);
      var _ret = new SetIdleTimeoutSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setIdleTimeoutSettings(int idleTimeout, AsyncRpcResponse<SetIdleTimeoutSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setIdleTimeoutSettings(idleTimeout, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setIdleTimeoutSettings(int idleTimeout, AsyncRpcResponse<SetIdleTimeoutSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["idleTimeout"] = idleTimeout;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setIdleTimeoutSettings", _parameters,
        _result => {
          try {
            var _ret = new SetIdleTimeoutSettingsResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSingleLoginLimitationResult {
    }

    public SetSingleLoginLimitationResult setSingleLoginLimitation(bool singleLogin) {
      var _parameters = new LightJson.JsonObject();
      _parameters["singleLogin"] = singleLogin;

      var _result = RpcCall("setSingleLoginLimitation", _parameters);
      var _ret = new SetSingleLoginLimitationResult();
      return _ret;
    }

    public AsyncRequest setSingleLoginLimitation(bool singleLogin, AsyncRpcResponse<SetSingleLoginLimitationResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSingleLoginLimitation(singleLogin, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSingleLoginLimitation(bool singleLogin, AsyncRpcResponse<SetSingleLoginLimitationResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["singleLogin"] = singleLogin;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setSingleLoginLimitation", _parameters,
        _result => {
          try {
            var _ret = new SetSingleLoginLimitationResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetIdleTimeoutSettingsResult {
      public int _ret_;
    }

    public GetIdleTimeoutSettingsResult getIdleTimeoutSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getIdleTimeoutSettings", _parameters);
      var _ret = new GetIdleTimeoutSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest getIdleTimeoutSettings(AsyncRpcResponse<GetIdleTimeoutSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getIdleTimeoutSettings(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getIdleTimeoutSettings(AsyncRpcResponse<GetIdleTimeoutSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getIdleTimeoutSettings", _parameters,
        _result => {
          try {
            var _ret = new GetIdleTimeoutSettingsResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetHttpRedirSettingsResult {
      public bool _ret_;
    }

    public GetHttpRedirSettingsResult getHttpRedirSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getHttpRedirSettings", _parameters);
      var _ret = new GetHttpRedirSettingsResult();
      _ret._ret_ = (bool)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest getHttpRedirSettings(AsyncRpcResponse<GetHttpRedirSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getHttpRedirSettings(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getHttpRedirSettings(AsyncRpcResponse<GetHttpRedirSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getHttpRedirSettings", _parameters,
        _result => {
          try {
            var _ret = new GetHttpRedirSettingsResult();
            _ret._ret_ = (bool)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetBlockSettingsResult {
      public int blockTimeout;
      public int maxFailedLogins;
    }

    public GetBlockSettingsResult getBlockSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getBlockSettings", _parameters);
      var _ret = new GetBlockSettingsResult();
      _ret.blockTimeout = (int)_result["blockTimeout"];
      _ret.maxFailedLogins = (int)_result["maxFailedLogins"];
      return _ret;
    }

    public AsyncRequest getBlockSettings(AsyncRpcResponse<GetBlockSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getBlockSettings(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getBlockSettings(AsyncRpcResponse<GetBlockSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getBlockSettings", _parameters,
        _result => {
          try {
            var _ret = new GetBlockSettingsResult();
            _ret.blockTimeout = (int)_result["blockTimeout"];
            _ret.maxFailedLogins = (int)_result["maxFailedLogins"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSSHSettingsResult {
      public Com.Raritan.Idl.security.SSHSettings _ret_;
    }

    public GetSSHSettingsResult getSSHSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSSHSettings", _parameters);
      var _ret = new GetSSHSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.security.SSHSettings.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getSSHSettings(AsyncRpcResponse<GetSSHSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getSSHSettings(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getSSHSettings(AsyncRpcResponse<GetSSHSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getSSHSettings", _parameters,
        _result => {
          try {
            var _ret = new GetSSHSettingsResult();
            _ret._ret_ = Com.Raritan.Idl.security.SSHSettings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSSHSettingsResult {
    }

    public SetSSHSettingsResult setSSHSettings(Com.Raritan.Idl.security.SSHSettings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSSHSettings", _parameters);
      var _ret = new SetSSHSettingsResult();
      return _ret;
    }

    public AsyncRequest setSSHSettings(Com.Raritan.Idl.security.SSHSettings settings, AsyncRpcResponse<SetSSHSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSSHSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSSHSettings(Com.Raritan.Idl.security.SSHSettings settings, AsyncRpcResponse<SetSSHSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["settings"] = settings.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setSSHSettings", _parameters,
        _result => {
          try {
            var _ret = new SetSSHSettingsResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
