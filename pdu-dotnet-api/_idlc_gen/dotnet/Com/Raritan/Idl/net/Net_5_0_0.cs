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
  public class Net_5_0_0 : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("net.Net:5.0.0", null);

    public Net_5_0_0(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Net_5_0_0(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Net_5_0_0 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Net_5_0_0(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int SUCCESS = 0;

    public const int ERR_DNS_TOO_MANY_SERVERS = 100;

    public const int ERR_DNS_INVALID_SERVER = 101;

    public const int ERR_DNS_TOO_MANY_SEARCH_SUFFIXES = 102;

    public const int ERR_DNS_INVALID_SEARCH_SUFFIX = 103;

    public const int ERR_ROUTING_IPV4_INVALID_DFLT_GATEWAY_ADDR = 200;

    public const int ERR_ROUTING_IPV6_INVALID_DFLT_GATEWAY_ADDR = 201;

    public const int ERR_ROUTING_IPV4_INVALID_DEST_ADDR = 202;

    public const int ERR_ROUTING_IPV6_INVALID_DEST_ADDR = 203;

    public const int ERR_ROUTING_IPV4_INVALID_DEST_PREFIX_LEN = 204;

    public const int ERR_ROUTING_IPV6_INVALID_DEST_PREFIX_LEN = 205;

    public const int ERR_ROUTING_IPV4_INVALID_NEXTHOP_ADDR = 206;

    public const int ERR_ROUTING_IPV6_INVALID_NEXTHOP_ADDR = 207;

    public const int ERR_ROUTING_IPV4_INVALID_INTERFACE = 208;

    public const int ERR_ROUTING_IPV6_INVALID_INTERFACE = 209;

    public const int ERR_ROUTING_IPV4_DEST_IS_NO_NETWORK_ADDR = 210;

    public const int ERR_ROUTING_IPV6_DEST_IS_NO_NETWORK_ADDR = 211;

    public const int ERR_ROUTING_IPV4_DEST_IS_DUPLICATE = 212;

    public const int ERR_ROUTING_IPV6_DEST_IS_DUPLICATE = 213;

    public const int ERR_ROUTING_IPV4_NO_NEXTHOP_OR_INTERFACE = 214;

    public const int ERR_ROUTING_IPV6_NO_NEXTHOP_OR_INTERFACE = 215;

    public const int ERR_ROUTING_IPV4_NEXTHOP_AND_INTERFACE_SET = 216;

    public const int ERR_ROUTING_IPV6_NEXTHOP_AND_INTERFACE_SET = 217;

    public const int ERR_PF_INVALID_MASTER_DOWNSTREAM_INTERFACE = 300;

    public const int ERR_PF_NO_WORKING_MASTER_UPSTREAM_INTERFACE = 301;

    public const int ERR_IF_IPV4_INVALID_CONFIG_METHOD = 400;

    public const int ERR_IF_IPV6_INVALID_CONFIG_METHOD = 401;

    public const int ERR_IF_IPV4_INVALID_STATIC_ADDR = 402;

    public const int ERR_IF_IPV6_INVALID_STATIC_ADDR = 403;

    public const int ERR_IF_IPV4_INVALID_STATIC_PREFIX_LEN = 404;

    public const int ERR_IF_IPV6_INVALID_STATIC_PREFIX_LEN = 405;

    public const int ERR_IF_IPV4_INVALID_DHCP_PREF_HOSTNAME = 406;

    public const int ERR_IF_IPV6_INVALID_DHCP_PREF_HOSTNAME = 407;

    public const int ERR_IF_EAP_INVALID_IDENTITY = 408;

    public const int ERR_IF_EAP_INVALID_PASSWORD = 409;

    public const int ERR_IF_EAP_INVALID_CLIENT_CERT = 410;

    public const int ERR_IF_EAP_INVALID_CLIENT_PRIV_KEY_OR_PWD = 411;

    public const int ERR_IF_EAP_CLIENT_CERT_PRIV_KEY_MISMATCH = 412;

    public const int ERR_IF_EAP_INVALID_CA_CERT = 413;

    public const int ERR_IF_EAP_CA_CERT_VERIFY_FAILED = 414;

    public const int ERR_IF_EAP_INVALID_AUTH_SERVER_NAME = 415;

    public const int ERR_ETH_IF_UNSUPPORTED_LINKMODE = 500;

    public const int ERR_WLAN_IF_INVALID_SSID = 600;

    public const int ERR_WLAN_IF_INVALID_BSSID = 601;

    public const int ERR_WLAN_IF_INVALID_PSK = 602;

    public class GetInfoResult {
      public Com.Raritan.Idl.net.Info_1_0_1 _ret_;
    }

    public GetInfoResult getInfo() {
      JsonObject _parameters = null;
      var _result = RpcCall("getInfo", _parameters);
      var _ret = new GetInfoResult();
      _ret._ret_ = Com.Raritan.Idl.net.Info_1_0_1.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.net.Info_1_0_1.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.net.Settings_3_0_0 _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.net.Settings_3_0_0.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.net.Settings_3_0_0.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.net.Settings_3_0_0 settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.net.Settings_3_0_0 settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.net.Settings_3_0_0 settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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

    public class GetPortForwardingProtocolMappingsResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.net.PortForwardingProtocolMapping> _ret_;
    }

    public GetPortForwardingProtocolMappingsResult getPortForwardingProtocolMappings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getPortForwardingProtocolMappings", _parameters);
      var _ret = new GetPortForwardingProtocolMappingsResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.net.PortForwardingProtocolMapping>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.net.PortForwardingProtocolMapping.Decode(_value, agent)));
      return _ret;
    }

    public AsyncRequest getPortForwardingProtocolMappings(AsyncRpcResponse<GetPortForwardingProtocolMappingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getPortForwardingProtocolMappings(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getPortForwardingProtocolMappings(AsyncRpcResponse<GetPortForwardingProtocolMappingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getPortForwardingProtocolMappings", _parameters,
        _result => {
          try {
            var _ret = new GetPortForwardingProtocolMappingsResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.net.PortForwardingProtocolMapping>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.net.PortForwardingProtocolMapping.Decode(_value, agent)));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
