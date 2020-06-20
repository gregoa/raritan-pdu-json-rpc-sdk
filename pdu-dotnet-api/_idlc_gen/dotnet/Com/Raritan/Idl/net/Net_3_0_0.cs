// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Net.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.net {
  public class Net_3_0_0 : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("net.Net:3.0.0", null);

    public Net_3_0_0(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Net_3_0_0(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Net_3_0_0 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Net_3_0_0(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int ERR_INVALID_PARAMS = 1;

    public class SetNetworkConfigIPResult {
      public int _ret_;
    }

    public SetNetworkConfigIPResult setNetworkConfigIP(Com.Raritan.Idl.net.NetworkConfigIP cfg) {
      var _parameters = new LightJson.JsonObject();
      _parameters["cfg"] = cfg.Encode();

      var _result = RpcCall("setNetworkConfigIP", _parameters);
      var _ret = new SetNetworkConfigIPResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setNetworkConfigIP(Com.Raritan.Idl.net.NetworkConfigIP cfg, AsyncRpcResponse<SetNetworkConfigIPResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setNetworkConfigIP(cfg, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setNetworkConfigIP(Com.Raritan.Idl.net.NetworkConfigIP cfg, AsyncRpcResponse<SetNetworkConfigIPResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["cfg"] = cfg.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setNetworkConfigIP", _parameters,
        _result => {
          try {
            var _ret = new SetNetworkConfigIPResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetNetworkConfigIPResult {
      public Com.Raritan.Idl.net.NetworkConfigIP cfg;
    }

    public GetNetworkConfigIPResult getNetworkConfigIP() {
      JsonObject _parameters = null;
      var _result = RpcCall("getNetworkConfigIP", _parameters);
      var _ret = new GetNetworkConfigIPResult();
      _ret.cfg = Com.Raritan.Idl.net.NetworkConfigIP.Decode(_result["cfg"], agent);
      return _ret;
    }

    public AsyncRequest getNetworkConfigIP(AsyncRpcResponse<GetNetworkConfigIPResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getNetworkConfigIP(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getNetworkConfigIP(AsyncRpcResponse<GetNetworkConfigIPResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getNetworkConfigIP", _parameters,
        _result => {
          try {
            var _ret = new GetNetworkConfigIPResult();
            _ret.cfg = Com.Raritan.Idl.net.NetworkConfigIP.Decode(_result["cfg"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetNetworkConfigIPv4Result {
      public int _ret_;
    }

    public SetNetworkConfigIPv4Result setNetworkConfigIPv4(Com.Raritan.Idl.net.NetworkConfigIPv4 cfg4) {
      var _parameters = new LightJson.JsonObject();
      _parameters["cfg4"] = cfg4.Encode();

      var _result = RpcCall("setNetworkConfigIPv4", _parameters);
      var _ret = new SetNetworkConfigIPv4Result();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setNetworkConfigIPv4(Com.Raritan.Idl.net.NetworkConfigIPv4 cfg4, AsyncRpcResponse<SetNetworkConfigIPv4Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setNetworkConfigIPv4(cfg4, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setNetworkConfigIPv4(Com.Raritan.Idl.net.NetworkConfigIPv4 cfg4, AsyncRpcResponse<SetNetworkConfigIPv4Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["cfg4"] = cfg4.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setNetworkConfigIPv4", _parameters,
        _result => {
          try {
            var _ret = new SetNetworkConfigIPv4Result();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetNetworkConfigIPv4Result {
      public Com.Raritan.Idl.net.NetworkConfigIPv4 cfg4;
      public Com.Raritan.Idl.net.NetworkConfigIPv4 cfg4current;
    }

    public GetNetworkConfigIPv4Result getNetworkConfigIPv4() {
      JsonObject _parameters = null;
      var _result = RpcCall("getNetworkConfigIPv4", _parameters);
      var _ret = new GetNetworkConfigIPv4Result();
      _ret.cfg4 = Com.Raritan.Idl.net.NetworkConfigIPv4.Decode(_result["cfg4"], agent);
      _ret.cfg4current = Com.Raritan.Idl.net.NetworkConfigIPv4.Decode(_result["cfg4current"], agent);
      return _ret;
    }

    public AsyncRequest getNetworkConfigIPv4(AsyncRpcResponse<GetNetworkConfigIPv4Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getNetworkConfigIPv4(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getNetworkConfigIPv4(AsyncRpcResponse<GetNetworkConfigIPv4Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getNetworkConfigIPv4", _parameters,
        _result => {
          try {
            var _ret = new GetNetworkConfigIPv4Result();
            _ret.cfg4 = Com.Raritan.Idl.net.NetworkConfigIPv4.Decode(_result["cfg4"], agent);
            _ret.cfg4current = Com.Raritan.Idl.net.NetworkConfigIPv4.Decode(_result["cfg4current"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetNetworkConfigRoutesIPv4Result {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.IPv4RoutingEntry> static_routes;
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.IPv4RoutingEntry> active_routes;
    }

    public GetNetworkConfigRoutesIPv4Result getNetworkConfigRoutesIPv4() {
      JsonObject _parameters = null;
      var _result = RpcCall("getNetworkConfigRoutesIPv4", _parameters);
      var _ret = new GetNetworkConfigRoutesIPv4Result();
      _ret.static_routes = new System.Collections.Generic.List<Com.Raritan.Idl.net.IPv4RoutingEntry>(_result["static_routes"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.net.IPv4RoutingEntry.Decode(_value, agent)));
      _ret.active_routes = new System.Collections.Generic.List<Com.Raritan.Idl.net.IPv4RoutingEntry>(_result["active_routes"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.net.IPv4RoutingEntry.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getNetworkConfigRoutesIPv4(AsyncRpcResponse<GetNetworkConfigRoutesIPv4Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getNetworkConfigRoutesIPv4(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getNetworkConfigRoutesIPv4(AsyncRpcResponse<GetNetworkConfigRoutesIPv4Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getNetworkConfigRoutesIPv4", _parameters,
        _result => {
          try {
            var _ret = new GetNetworkConfigRoutesIPv4Result();
            _ret.static_routes = new System.Collections.Generic.List<Com.Raritan.Idl.net.IPv4RoutingEntry>(_result["static_routes"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.net.IPv4RoutingEntry.Decode(_value, agent)));
            _ret.active_routes = new System.Collections.Generic.List<Com.Raritan.Idl.net.IPv4RoutingEntry>(_result["active_routes"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.net.IPv4RoutingEntry.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetNetworkConfigRoutesIPv4Result {
      public int _ret_;
    }

    public SetNetworkConfigRoutesIPv4Result setNetworkConfigRoutesIPv4(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.IPv4RoutingEntry> static_routes) {
      var _parameters = new LightJson.JsonObject();
      _parameters["static_routes"] = new JsonArray(static_routes.Select(
        _value => (JsonValue)(_value.Encode())));

      var _result = RpcCall("setNetworkConfigRoutesIPv4", _parameters);
      var _ret = new SetNetworkConfigRoutesIPv4Result();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setNetworkConfigRoutesIPv4(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.IPv4RoutingEntry> static_routes, AsyncRpcResponse<SetNetworkConfigRoutesIPv4Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setNetworkConfigRoutesIPv4(static_routes, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setNetworkConfigRoutesIPv4(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.IPv4RoutingEntry> static_routes, AsyncRpcResponse<SetNetworkConfigRoutesIPv4Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["static_routes"] = new JsonArray(static_routes.Select(
          _value => (JsonValue)(_value.Encode())));
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setNetworkConfigRoutesIPv4", _parameters,
        _result => {
          try {
            var _ret = new SetNetworkConfigRoutesIPv4Result();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetNetworkConfigRoutesIPv6Result {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.IPv6RoutingEntry> static_routes;
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.IPv6RoutingEntry> active_routes;
    }

    public GetNetworkConfigRoutesIPv6Result getNetworkConfigRoutesIPv6() {
      JsonObject _parameters = null;
      var _result = RpcCall("getNetworkConfigRoutesIPv6", _parameters);
      var _ret = new GetNetworkConfigRoutesIPv6Result();
      _ret.static_routes = new System.Collections.Generic.List<Com.Raritan.Idl.net.IPv6RoutingEntry>(_result["static_routes"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.net.IPv6RoutingEntry.Decode(_value, agent)));
      _ret.active_routes = new System.Collections.Generic.List<Com.Raritan.Idl.net.IPv6RoutingEntry>(_result["active_routes"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.net.IPv6RoutingEntry.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getNetworkConfigRoutesIPv6(AsyncRpcResponse<GetNetworkConfigRoutesIPv6Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getNetworkConfigRoutesIPv6(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getNetworkConfigRoutesIPv6(AsyncRpcResponse<GetNetworkConfigRoutesIPv6Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getNetworkConfigRoutesIPv6", _parameters,
        _result => {
          try {
            var _ret = new GetNetworkConfigRoutesIPv6Result();
            _ret.static_routes = new System.Collections.Generic.List<Com.Raritan.Idl.net.IPv6RoutingEntry>(_result["static_routes"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.net.IPv6RoutingEntry.Decode(_value, agent)));
            _ret.active_routes = new System.Collections.Generic.List<Com.Raritan.Idl.net.IPv6RoutingEntry>(_result["active_routes"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.net.IPv6RoutingEntry.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetNetworkConfigRoutesIPv6Result {
      public int _ret_;
    }

    public SetNetworkConfigRoutesIPv6Result setNetworkConfigRoutesIPv6(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.IPv6RoutingEntry> static_routes) {
      var _parameters = new LightJson.JsonObject();
      _parameters["static_routes"] = new JsonArray(static_routes.Select(
        _value => (JsonValue)(_value.Encode())));

      var _result = RpcCall("setNetworkConfigRoutesIPv6", _parameters);
      var _ret = new SetNetworkConfigRoutesIPv6Result();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setNetworkConfigRoutesIPv6(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.IPv6RoutingEntry> static_routes, AsyncRpcResponse<SetNetworkConfigRoutesIPv6Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setNetworkConfigRoutesIPv6(static_routes, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setNetworkConfigRoutesIPv6(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.IPv6RoutingEntry> static_routes, AsyncRpcResponse<SetNetworkConfigRoutesIPv6Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["static_routes"] = new JsonArray(static_routes.Select(
          _value => (JsonValue)(_value.Encode())));
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setNetworkConfigRoutesIPv6", _parameters,
        _result => {
          try {
            var _ret = new SetNetworkConfigRoutesIPv6Result();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetNetworkConfigIPv6Result {
      public int _ret_;
    }

    public SetNetworkConfigIPv6Result setNetworkConfigIPv6(Com.Raritan.Idl.net.NetworkConfigIPv6 cfg6) {
      var _parameters = new LightJson.JsonObject();
      _parameters["cfg6"] = cfg6.Encode();

      var _result = RpcCall("setNetworkConfigIPv6", _parameters);
      var _ret = new SetNetworkConfigIPv6Result();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setNetworkConfigIPv6(Com.Raritan.Idl.net.NetworkConfigIPv6 cfg6, AsyncRpcResponse<SetNetworkConfigIPv6Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setNetworkConfigIPv6(cfg6, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setNetworkConfigIPv6(Com.Raritan.Idl.net.NetworkConfigIPv6 cfg6, AsyncRpcResponse<SetNetworkConfigIPv6Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["cfg6"] = cfg6.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setNetworkConfigIPv6", _parameters,
        _result => {
          try {
            var _ret = new SetNetworkConfigIPv6Result();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetNetworkConfigIPv6Result {
      public Com.Raritan.Idl.net.NetworkConfigIPv6 cfg6;
      public Com.Raritan.Idl.net.NetworkActiveValuesIPv6 ipv6current;
    }

    public GetNetworkConfigIPv6Result getNetworkConfigIPv6() {
      JsonObject _parameters = null;
      var _result = RpcCall("getNetworkConfigIPv6", _parameters);
      var _ret = new GetNetworkConfigIPv6Result();
      _ret.cfg6 = Com.Raritan.Idl.net.NetworkConfigIPv6.Decode(_result["cfg6"], agent);
      _ret.ipv6current = Com.Raritan.Idl.net.NetworkActiveValuesIPv6.Decode(_result["ipv6current"], agent);
      return _ret;
    }

    public AsyncRequest getNetworkConfigIPv6(AsyncRpcResponse<GetNetworkConfigIPv6Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getNetworkConfigIPv6(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getNetworkConfigIPv6(AsyncRpcResponse<GetNetworkConfigIPv6Result>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getNetworkConfigIPv6", _parameters,
        _result => {
          try {
            var _ret = new GetNetworkConfigIPv6Result();
            _ret.cfg6 = Com.Raritan.Idl.net.NetworkConfigIPv6.Decode(_result["cfg6"], agent);
            _ret.ipv6current = Com.Raritan.Idl.net.NetworkActiveValuesIPv6.Decode(_result["ipv6current"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetNetworkConfigServicesResult {
      public int _ret_;
    }

    public SetNetworkConfigServicesResult setNetworkConfigServices(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.ServiceConfig> services) {
      var _parameters = new LightJson.JsonObject();
      _parameters["services"] = new JsonArray(services.Select(
        _value => (JsonValue)(_value.Encode())));

      var _result = RpcCall("setNetworkConfigServices", _parameters);
      var _ret = new SetNetworkConfigServicesResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setNetworkConfigServices(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.ServiceConfig> services, AsyncRpcResponse<SetNetworkConfigServicesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setNetworkConfigServices(services, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setNetworkConfigServices(System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.ServiceConfig> services, AsyncRpcResponse<SetNetworkConfigServicesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["services"] = new JsonArray(services.Select(
          _value => (JsonValue)(_value.Encode())));
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setNetworkConfigServices", _parameters,
        _result => {
          try {
            var _ret = new SetNetworkConfigServicesResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetNetworkConfigServicesResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.ServiceConfig> services;
    }

    public GetNetworkConfigServicesResult getNetworkConfigServices() {
      JsonObject _parameters = null;
      var _result = RpcCall("getNetworkConfigServices", _parameters);
      var _ret = new GetNetworkConfigServicesResult();
      _ret.services = new System.Collections.Generic.List<Com.Raritan.Idl.net.ServiceConfig>(_result["services"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.net.ServiceConfig.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getNetworkConfigServices(AsyncRpcResponse<GetNetworkConfigServicesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getNetworkConfigServices(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getNetworkConfigServices(AsyncRpcResponse<GetNetworkConfigServicesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getNetworkConfigServices", _parameters,
        _result => {
          try {
            var _ret = new GetNetworkConfigServicesResult();
            _ret.services = new System.Collections.Generic.List<Com.Raritan.Idl.net.ServiceConfig>(_result["services"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.net.ServiceConfig.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetNetworkConfigInterfaceResult {
      public Com.Raritan.Idl.net.InterfaceState_2_0_0 state;
      public Com.Raritan.Idl.net.LanInterfaceSettings lan;
      public Com.Raritan.Idl.net.LanInterfaceParameters_2_0_0 lancurrent;
      public Com.Raritan.Idl.net.WirelessInterfaceSettings_2_0_0 wlan;
    }

    public GetNetworkConfigInterfaceResult getNetworkConfigInterface() {
      JsonObject _parameters = null;
      var _result = RpcCall("getNetworkConfigInterface", _parameters);
      var _ret = new GetNetworkConfigInterfaceResult();
      _ret.state = Com.Raritan.Idl.net.InterfaceState_2_0_0.Decode(_result["state"], agent);
      _ret.lan = Com.Raritan.Idl.net.LanInterfaceSettings.Decode(_result["lan"], agent);
      _ret.lancurrent = Com.Raritan.Idl.net.LanInterfaceParameters_2_0_0.Decode(_result["lancurrent"], agent);
      _ret.wlan = Com.Raritan.Idl.net.WirelessInterfaceSettings_2_0_0.Decode(_result["wlan"], agent);
      return _ret;
    }

    public AsyncRequest getNetworkConfigInterface(AsyncRpcResponse<GetNetworkConfigInterfaceResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getNetworkConfigInterface(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getNetworkConfigInterface(AsyncRpcResponse<GetNetworkConfigInterfaceResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getNetworkConfigInterface", _parameters,
        _result => {
          try {
            var _ret = new GetNetworkConfigInterfaceResult();
            _ret.state = Com.Raritan.Idl.net.InterfaceState_2_0_0.Decode(_result["state"], agent);
            _ret.lan = Com.Raritan.Idl.net.LanInterfaceSettings.Decode(_result["lan"], agent);
            _ret.lancurrent = Com.Raritan.Idl.net.LanInterfaceParameters_2_0_0.Decode(_result["lancurrent"], agent);
            _ret.wlan = Com.Raritan.Idl.net.WirelessInterfaceSettings_2_0_0.Decode(_result["wlan"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetMACsResult {
      public Com.Raritan.Idl.net.InterfaceState_2_0_0 state;
      public string ethmac;
      public string wlanmac;
    }

    public GetMACsResult getMACs() {
      JsonObject _parameters = null;
      var _result = RpcCall("getMACs", _parameters);
      var _ret = new GetMACsResult();
      _ret.state = Com.Raritan.Idl.net.InterfaceState_2_0_0.Decode(_result["state"], agent);
      _ret.ethmac = (string)_result["ethmac"];
      _ret.wlanmac = (string)_result["wlanmac"];
      return _ret;
    }

    public AsyncRequest getMACs(AsyncRpcResponse<GetMACsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getMACs(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getMACs(AsyncRpcResponse<GetMACsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getMACs", _parameters,
        _result => {
          try {
            var _ret = new GetMACsResult();
            _ret.state = Com.Raritan.Idl.net.InterfaceState_2_0_0.Decode(_result["state"], agent);
            _ret.ethmac = (string)_result["ethmac"];
            _ret.wlanmac = (string)_result["wlanmac"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetNetworkConfigLanResult {
      public int _ret_;
    }

    public SetNetworkConfigLanResult setNetworkConfigLan(Com.Raritan.Idl.net.LanInterfaceSettings lancfg) {
      var _parameters = new LightJson.JsonObject();
      _parameters["lancfg"] = lancfg.Encode();

      var _result = RpcCall("setNetworkConfigLan", _parameters);
      var _ret = new SetNetworkConfigLanResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setNetworkConfigLan(Com.Raritan.Idl.net.LanInterfaceSettings lancfg, AsyncRpcResponse<SetNetworkConfigLanResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setNetworkConfigLan(lancfg, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setNetworkConfigLan(Com.Raritan.Idl.net.LanInterfaceSettings lancfg, AsyncRpcResponse<SetNetworkConfigLanResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["lancfg"] = lancfg.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setNetworkConfigLan", _parameters,
        _result => {
          try {
            var _ret = new SetNetworkConfigLanResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetNetworkConfigWLanResult {
      public int _ret_;
    }

    public SetNetworkConfigWLanResult setNetworkConfigWLan(Com.Raritan.Idl.net.WirelessInterfaceSettings_2_0_0 wlancfg) {
      var _parameters = new LightJson.JsonObject();
      _parameters["wlancfg"] = wlancfg.Encode();

      var _result = RpcCall("setNetworkConfigWLan", _parameters);
      var _ret = new SetNetworkConfigWLanResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setNetworkConfigWLan(Com.Raritan.Idl.net.WirelessInterfaceSettings_2_0_0 wlancfg, AsyncRpcResponse<SetNetworkConfigWLanResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setNetworkConfigWLan(wlancfg, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setNetworkConfigWLan(Com.Raritan.Idl.net.WirelessInterfaceSettings_2_0_0 wlancfg, AsyncRpcResponse<SetNetworkConfigWLanResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      var _parameters = new LightJson.JsonObject();
      try {
        _parameters["wlancfg"] = wlancfg.Encode();
      } catch (Exception e) {
        if (fail != null) fail(e);
      }

      return RpcCall("setNetworkConfigWLan", _parameters,
        _result => {
          try {
            var _ret = new SetNetworkConfigWLanResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetBridgeSlaveCountResult {
      public int _ret_;
    }

    public GetBridgeSlaveCountResult getBridgeSlaveCount() {
      JsonObject _parameters = null;
      var _result = RpcCall("getBridgeSlaveCount", _parameters);
      var _ret = new GetBridgeSlaveCountResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest getBridgeSlaveCount(AsyncRpcResponse<GetBridgeSlaveCountResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getBridgeSlaveCount(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getBridgeSlaveCount(AsyncRpcResponse<GetBridgeSlaveCountResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getBridgeSlaveCount", _parameters,
        _result => {
          try {
            var _ret = new GetBridgeSlaveCountResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
