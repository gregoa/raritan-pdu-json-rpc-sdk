// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from AssetManager.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.assetmgrmodel {
  public class AssetManager : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("assetmgrmodel.AssetManager:1.0.0", null);

    public AssetManager(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public AssetManager(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new AssetManager StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new AssetManager(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public const int ERR_NO_ERROR = 0;

    public const int ERR_INVALID_PARAM = 1;

    public const int ERR_NO_ASSET_STRIPS = 2;

    public enum Events {
      EVT_KEY_STATE_CHANGED,
    }

    public class Settings : ICloneable {
      public object Clone() {
        Settings copy = new Settings();
        copy.defaultColorConnected = this.defaultColorConnected;
        copy.defaultColorDisconnected = this.defaultColorDisconnected;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["defaultColorConnected"] = this.defaultColorConnected.Encode();
        json["defaultColorDisconnected"] = this.defaultColorDisconnected.Encode();
        return json;
      }

      public static Settings Decode(LightJson.JsonObject json, Agent agent) {
        Settings inst = new Settings();
        inst.defaultColorConnected = Com.Raritan.Idl.assetmgrmodel.AssetStrip.LEDColor.Decode(json["defaultColorConnected"], agent);
        inst.defaultColorDisconnected = Com.Raritan.Idl.assetmgrmodel.AssetStrip.LEDColor.Decode(json["defaultColorDisconnected"], agent);
        return inst;
      }

      public Com.Raritan.Idl.assetmgrmodel.AssetStrip.LEDColor defaultColorConnected = new Com.Raritan.Idl.assetmgrmodel.AssetStrip.LEDColor();
      public Com.Raritan.Idl.assetmgrmodel.AssetStrip.LEDColor defaultColorDisconnected = new Com.Raritan.Idl.assetmgrmodel.AssetStrip.LEDColor();
    }

    public class GetSettingsResult {
      public int _ret_;
      public Com.Raritan.Idl.assetmgrmodel.AssetManager.Settings settings;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      _ret.settings = Com.Raritan.Idl.assetmgrmodel.AssetManager.Settings.Decode(_result["settings"], agent);
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
            _ret._ret_ = (int)_result["_ret_"];
            _ret.settings = Com.Raritan.Idl.assetmgrmodel.AssetManager.Settings.Decode(_result["settings"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.assetmgrmodel.AssetManager.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.assetmgrmodel.AssetManager.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.assetmgrmodel.AssetManager.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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

    public class GetAssetStripsResult {
      public System.Collections.Generic.IEnumerable<Com.Raritan.Idl.assetmgrmodel.AssetStrip> _ret_;
    }

    public GetAssetStripsResult getAssetStrips() {
      JsonObject _parameters = null;
      var _result = RpcCall("getAssetStrips", _parameters);
      var _ret = new GetAssetStripsResult();
      _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.assetmgrmodel.AssetStrip>(_result["_ret_"].AsJsonArray.Select(
        _value => Com.Raritan.Idl.assetmgrmodel.AssetStrip.StaticCast(ObjectProxy.Decode(_value, agent))));
      return _ret;
    }

    public AsyncRequest getAssetStrips(AsyncRpcResponse<GetAssetStripsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getAssetStrips(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getAssetStrips(AsyncRpcResponse<GetAssetStripsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getAssetStrips", _parameters,
        _result => {
          try {
            var _ret = new GetAssetStripsResult();
            _ret._ret_ = new System.Collections.Generic.List<Com.Raritan.Idl.assetmgrmodel.AssetStrip>(_result["_ret_"].AsJsonArray.Select(
              _value => Com.Raritan.Idl.assetmgrmodel.AssetStrip.StaticCast(ObjectProxy.Decode(_value, agent))));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
