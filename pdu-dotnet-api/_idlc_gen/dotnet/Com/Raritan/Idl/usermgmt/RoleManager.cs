// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from RoleManager.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.usermgmt {
  public class RoleManager : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("usermgmt.RoleManager:1.0.0", null);

    public RoleManager(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public RoleManager(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new RoleManager StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new RoleManager(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int ERR_ROLE_ALREADY_EXISTS = 1;

    public const int ERR_MAX_ROLES_REACHED = 2;

    public const int ERR_INVALID_VALUE = 3;

    public const int ERR_ROLE_DOESNT_EXIST = 1;

    public const int ERR_ROLE_NOT_DELETABLE = 2;

    public class ArgumentDesc : ICloneable {
      public object Clone() {
        ArgumentDesc copy = new ArgumentDesc();
        copy.name = this.name;
        copy.desc = this.desc;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["name"] = this.name;
        json["desc"] = this.desc;
        return json;
      }

      public static ArgumentDesc Decode(LightJson.JsonObject json, Agent agent) {
        ArgumentDesc inst = new ArgumentDesc();
        inst.name = (string)json["name"];
        inst.desc = (string)json["desc"];
        return inst;
      }

      public string name = "";
      public string desc = "";
    }

    public class PrivilegeDesc : ICloneable {
      public object Clone() {
        PrivilegeDesc copy = new PrivilegeDesc();
        copy.name = this.name;
        copy.desc = this.desc;
        copy.args = this.args;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["name"] = this.name;
        json["desc"] = this.desc;
        json["args"] = new JsonArray(this.args.Select(
          _value => (JsonValue)(_value.Encode())));
        return json;
      }

      public static PrivilegeDesc Decode(LightJson.JsonObject json, Agent agent) {
        PrivilegeDesc inst = new PrivilegeDesc();
        inst.name = (string)json["name"];
        inst.desc = (string)json["desc"];
        inst.args = new System.Collections.Generic.List<Com.Raritan.Idl.usermgmt.RoleManager.ArgumentDesc>(json["args"].AsJsonArray.Select(
          _value => Com.Raritan.Idl.usermgmt.RoleManager.ArgumentDesc.Decode(_value, agent)));
        return inst;
      }

      public string name = "";
      public string desc = "";
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.usermgmt.RoleManager.ArgumentDesc> args = new System.Collections.Generic.List<Com.Raritan.Idl.usermgmt.RoleManager.ArgumentDesc>();
    }

    public class RoleAccount : ICloneable {
      public object Clone() {
        RoleAccount copy = new RoleAccount();
        copy.id = this.id;
        copy.name = this.name;
        copy.info = this.info;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["id"] = this.id;
        json["name"] = this.name;
        json["info"] = this.info.Encode();
        return json;
      }

      public static RoleAccount Decode(LightJson.JsonObject json, Agent agent) {
        RoleAccount inst = new RoleAccount();
        inst.id = (int)json["id"];
        inst.name = (string)json["name"];
        inst.info = Com.Raritan.Idl.usermgmt.Role.Info.Decode(json["info"], agent);
        return inst;
      }

      public int id = 0;
      public string name = "";
      public Com.Raritan.Idl.usermgmt.Role.Info info = new Com.Raritan.Idl.usermgmt.Role.Info();
    }

    public class Info : ICloneable {
      public object Clone() {
        Info copy = new Info();
        copy.privileges = this.privileges;
        copy.roles = this.roles;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["privileges"] = new JsonArray(this.privileges.Select(
          _value => (JsonValue)(_value.Encode())));
        json["roles"] = new JsonArray(this.roles.Select(
          _value => (JsonValue)(_value.Encode())));
        return json;
      }

      public static Info Decode(LightJson.JsonObject json, Agent agent) {
        Info inst = new Info();
        inst.privileges = new System.Collections.Generic.List<Com.Raritan.Idl.usermgmt.RoleManager.PrivilegeDesc>(json["privileges"].AsJsonArray.Select(
          _value => Com.Raritan.Idl.usermgmt.RoleManager.PrivilegeDesc.Decode(_value, agent)));
        inst.roles = new System.Collections.Generic.List<Com.Raritan.Idl.usermgmt.RoleManager.RoleAccount>(json["roles"].AsJsonArray.Select(
          _value => Com.Raritan.Idl.usermgmt.RoleManager.RoleAccount.Decode(_value, agent)));
        return inst;
      }

      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.usermgmt.RoleManager.PrivilegeDesc> privileges = new System.Collections.Generic.List<Com.Raritan.Idl.usermgmt.RoleManager.PrivilegeDesc>();
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.usermgmt.RoleManager.RoleAccount> roles = new System.Collections.Generic.List<Com.Raritan.Idl.usermgmt.RoleManager.RoleAccount>();
    }

    public class CreateRoleFullResult {
      public int _ret_;
    }

    public CreateRoleFullResult createRoleFull(string name, Com.Raritan.Idl.usermgmt.Role.Info info) {
      var _parameters = new LightJson.JsonObject();
      _parameters["name"] = name;
      _parameters["info"] = info.Encode();

      var _result = RpcCall("createRoleFull", _parameters);
      var _ret = new CreateRoleFullResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest createRoleFull(string name, Com.Raritan.Idl.usermgmt.Role.Info info, AsyncRpcResponse<CreateRoleFullResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return createRoleFull(name, info, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest createRoleFull(string name, Com.Raritan.Idl.usermgmt.Role.Info info, AsyncRpcResponse<CreateRoleFullResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["name"] = name;
        _parameters["info"] = info.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("createRoleFull", _parameters,
        _result => {
          try {
            var _ret = new CreateRoleFullResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class DeleteRoleResult {
      public int _ret_;
    }

    public DeleteRoleResult deleteRole(string name) {
      var _parameters = new LightJson.JsonObject();
      _parameters["name"] = name;

      var _result = RpcCall("deleteRole", _parameters);
      var _ret = new DeleteRoleResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest deleteRole(string name, AsyncRpcResponse<DeleteRoleResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return deleteRole(name, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest deleteRole(string name, AsyncRpcResponse<DeleteRoleResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["name"] = name;
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("deleteRole", _parameters,
        _result => {
          try {
            var _ret = new DeleteRoleResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetAllRoleNamesResult {
      public System.Collections.Generic.IEnumerable<string> _ret_;
    }

    public GetAllRoleNamesResult getAllRoleNames() {
      JsonObject _parameters = null;
      var _result = RpcCall("getAllRoleNames", _parameters);
      var _ret = new GetAllRoleNamesResult();
      _ret._ret_ = new System.Collections.Generic.List<string>(_result["_ret_"].AsJsonArray.Select(
        _value => (string)_value));
      return _ret;
    }

    public AsyncRequest getAllRoleNames(AsyncRpcResponse<GetAllRoleNamesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getAllRoleNames(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getAllRoleNames(AsyncRpcResponse<GetAllRoleNamesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getAllRoleNames", _parameters,
        _result => {
          try {
            var _ret = new GetAllRoleNamesResult();
            _ret._ret_ = new System.Collections.Generic.List<string>(_result["_ret_"].AsJsonArray.Select(
              _value => (string)_value));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetAllRolesResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.usermgmt.RoleManager.RoleAccount> _ret_;
    }

    public GetAllRolesResult getAllRoles() {
      JsonObject _parameters = null;
      var _result = RpcCall("getAllRoles", _parameters);
      var _ret = new GetAllRolesResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.usermgmt.RoleManager.RoleAccount>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.usermgmt.RoleManager.RoleAccount.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getAllRoles(AsyncRpcResponse<GetAllRolesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getAllRoles(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getAllRoles(AsyncRpcResponse<GetAllRolesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getAllRoles", _parameters,
        _result => {
          try {
            var _ret = new GetAllRolesResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.usermgmt.RoleManager.RoleAccount>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.usermgmt.RoleManager.RoleAccount.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetAllPrivilegesResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.usermgmt.RoleManager.PrivilegeDesc> _ret_;
    }

    public GetAllPrivilegesResult getAllPrivileges() {
      JsonObject _parameters = null;
      var _result = RpcCall("getAllPrivileges", _parameters);
      var _ret = new GetAllPrivilegesResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.usermgmt.RoleManager.PrivilegeDesc>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.usermgmt.RoleManager.PrivilegeDesc.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getAllPrivileges(AsyncRpcResponse<GetAllPrivilegesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getAllPrivileges(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getAllPrivileges(AsyncRpcResponse<GetAllPrivilegesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getAllPrivileges", _parameters,
        _result => {
          try {
            var _ret = new GetAllPrivilegesResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.usermgmt.RoleManager.PrivilegeDesc>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.usermgmt.RoleManager.PrivilegeDesc.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetInfoResult {
      public Com.Raritan.Idl.usermgmt.RoleManager.Info _ret_;
    }

    public GetInfoResult getInfo() {
      JsonObject _parameters = null;
      var _result = RpcCall("getInfo", _parameters);
      var _ret = new GetInfoResult();
      _ret._ret_ = Com.Raritan.Idl.usermgmt.RoleManager.Info.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getInfo(AsyncRpcResponse<GetInfoResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getInfo(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getInfo(AsyncRpcResponse<GetInfoResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getInfo", _parameters,
        _result => {
          try {
            var _ret = new GetInfoResult();
            _ret._ret_ = Com.Raritan.Idl.usermgmt.RoleManager.Info.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
