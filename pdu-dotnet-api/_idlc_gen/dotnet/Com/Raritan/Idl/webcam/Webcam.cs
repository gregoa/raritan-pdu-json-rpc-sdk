// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Webcam.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.webcam {
  public class Webcam : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("webcam.Webcam:1.0.0", null);

    public Webcam(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Webcam(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Webcam StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Webcam(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class GetInformationResult {
      public Com.Raritan.Idl.webcam.Information _ret_;
    }

    public GetInformationResult getInformation() {
      JsonObject _parameters = null;
      var _result = RpcCall("getInformation", _parameters);
      var _ret = new GetInformationResult();
      _ret._ret_ = Com.Raritan.Idl.webcam.Information.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getInformation(AsyncRpcResponse<GetInformationResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getInformation(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getInformation(AsyncRpcResponse<GetInformationResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getInformation", _parameters,
        _result => {
          try {
            var _ret = new GetInformationResult();
            _ret._ret_ = Com.Raritan.Idl.webcam.Information.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSettingsResult {
      public Com.Raritan.Idl.webcam.Settings _ret_;
    }

    public GetSettingsResult getSettings() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSettings", _parameters);
      var _ret = new GetSettingsResult();
      _ret._ret_ = Com.Raritan.Idl.webcam.Settings.Decode(_result["_ret_"], agent);
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
            _ret._ret_ = Com.Raritan.Idl.webcam.Settings.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class SetSettingsResult {
      public int _ret_;
    }

    public SetSettingsResult setSettings(Com.Raritan.Idl.webcam.Settings settings) {
      var _parameters = new LightJson.JsonObject();
      _parameters["settings"] = settings.Encode();

      var _result = RpcCall("setSettings", _parameters);
      var _ret = new SetSettingsResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.webcam.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return setSettings(settings, rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest setSettings(Com.Raritan.Idl.webcam.Settings settings, AsyncRpcResponse<SetSettingsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
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

    public class CaptureImageResult {
      public Com.Raritan.Idl.webcam.Image _ret_;
    }

    public CaptureImageResult captureImage() {
      JsonObject _parameters = null;
      var _result = RpcCall("captureImage", _parameters);
      var _ret = new CaptureImageResult();
      _ret._ret_ = Com.Raritan.Idl.webcam.Image.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest captureImage(AsyncRpcResponse<CaptureImageResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return captureImage(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest captureImage(AsyncRpcResponse<CaptureImageResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("captureImage", _parameters,
        _result => {
          try {
            var _ret = new CaptureImageResult();
            _ret._ret_ = Com.Raritan.Idl.webcam.Image.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class TriggerCaptureResult {
      public int _ret_;
    }

    public TriggerCaptureResult triggerCapture() {
      JsonObject _parameters = null;
      var _result = RpcCall("triggerCapture", _parameters);
      var _ret = new TriggerCaptureResult();
      _ret._ret_ = (int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest triggerCapture(AsyncRpcResponse<TriggerCaptureResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return triggerCapture(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest triggerCapture(AsyncRpcResponse<TriggerCaptureResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("triggerCapture", _parameters,
        _result => {
          try {
            var _ret = new TriggerCaptureResult();
            _ret._ret_ = (int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}