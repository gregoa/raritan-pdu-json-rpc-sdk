// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Controller.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {
  public class Controller_4_0_0 : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.Controller:4.0.0", null);

    public Controller_4_0_0(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Controller_4_0_0(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Controller_4_0_0 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Controller_4_0_0(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public enum Status {
      OK,
      COMMUNICATION_UNSTABLE,
      COMMUNICATION_FAILURE,
      UNKNOWN,
      INCOMPATIBLE,
      FIRMWARE_UPDATE,
    }

    public enum Type {
      OUTLET_CTRL,
      INLET_CTRL,
      METER_CTRL,
    }

    public class MetaData : ICloneable {
      public object Clone() {
        MetaData copy = new MetaData();
        copy.type = this.type;
        copy.address = this.address;
        copy.magic = this.magic;
        copy.versionAvailable = this.versionAvailable;
        copy.fwAppVersion = this.fwAppVersion;
        copy.fwBootVersion = this.fwBootVersion;
        copy.hwVersion = this.hwVersion;
        copy.serial = this.serial;
        copy.haveResetCnt = this.haveResetCnt;
        copy.haveEmResetCnt = this.haveEmResetCnt;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["type"] = (int)this.type;
        json["address"] = this.address;
        json["magic"] = this.magic;
        json["versionAvailable"] = this.versionAvailable;
        json["fwAppVersion"] = this.fwAppVersion;
        json["fwBootVersion"] = this.fwBootVersion;
        json["hwVersion"] = this.hwVersion;
        json["serial"] = this.serial;
        json["haveResetCnt"] = this.haveResetCnt;
        json["haveEmResetCnt"] = this.haveEmResetCnt;
        return json;
      }

      public static MetaData Decode(LightJson.JsonObject json, Agent agent) {
        MetaData inst = new MetaData();
        inst.type = (Com.Raritan.Idl.pdumodel.Controller_4_0_0.Type)(int)json["type"];
        inst.address = (string)json["address"];
        inst.magic = (int)json["magic"];
        inst.versionAvailable = (bool)json["versionAvailable"];
        inst.fwAppVersion = (int)json["fwAppVersion"];
        inst.fwBootVersion = (int)json["fwBootVersion"];
        inst.hwVersion = (int)json["hwVersion"];
        inst.serial = (string)json["serial"];
        inst.haveResetCnt = (bool)json["haveResetCnt"];
        inst.haveEmResetCnt = (bool)json["haveEmResetCnt"];
        return inst;
      }

      public Com.Raritan.Idl.pdumodel.Controller_4_0_0.Type type = Com.Raritan.Idl.pdumodel.Controller_4_0_0.Type.OUTLET_CTRL;
      public string address = "";
      public int magic = 0;
      public bool versionAvailable = false;
      public int fwAppVersion = 0;
      public int fwBootVersion = 0;
      public int hwVersion = 0;
      public string serial = "";
      public bool haveResetCnt = false;
      public bool haveEmResetCnt = false;
    }

    public class StatusChangedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.Controller_4_0_0.StatusChangedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public Com.Raritan.Idl.pdumodel.Controller_4_0_0.Status oldStatus = Com.Raritan.Idl.pdumodel.Controller_4_0_0.Status.OK;
      public Com.Raritan.Idl.pdumodel.Controller_4_0_0.Status newStatus = Com.Raritan.Idl.pdumodel.Controller_4_0_0.Status.OK;
    }

    public class MetaDataChangedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.Controller_4_0_0.MetaDataChangedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public Com.Raritan.Idl.pdumodel.Controller_4_0_0.MetaData oldMetaData = new Com.Raritan.Idl.pdumodel.Controller_4_0_0.MetaData();
      public Com.Raritan.Idl.pdumodel.Controller_4_0_0.MetaData newMetaData = new Com.Raritan.Idl.pdumodel.Controller_4_0_0.MetaData();
    }

    public class GetCommunicationStatusResult {
      public Com.Raritan.Idl.pdumodel.Controller_4_0_0.Status _ret_;
    }

    public GetCommunicationStatusResult getCommunicationStatus() {
      JsonObject _parameters = null;
      var _result = RpcCall("getCommunicationStatus", _parameters);
      var _ret = new GetCommunicationStatusResult();
      _ret._ret_ = (Com.Raritan.Idl.pdumodel.Controller_4_0_0.Status)(int)_result["_ret_"];
      return _ret;
    }

    public AsyncRequest getCommunicationStatus(AsyncRpcResponse<GetCommunicationStatusResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getCommunicationStatus(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getCommunicationStatus(AsyncRpcResponse<GetCommunicationStatusResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getCommunicationStatus", _parameters,
        _result => {
          try {
            var _ret = new GetCommunicationStatusResult();
            _ret._ret_ = (Com.Raritan.Idl.pdumodel.Controller_4_0_0.Status)(int)_result["_ret_"];
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetStatisticsResult {
      public Com.Raritan.Idl.pdumodel.CtrlStatistic _ret_;
    }

    public GetStatisticsResult getStatistics() {
      JsonObject _parameters = null;
      var _result = RpcCall("getStatistics", _parameters);
      var _ret = new GetStatisticsResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.CtrlStatistic.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getStatistics(AsyncRpcResponse<GetStatisticsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getStatistics(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getStatistics(AsyncRpcResponse<GetStatisticsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getStatistics", _parameters,
        _result => {
          try {
            var _ret = new GetStatisticsResult();
            _ret._ret_ = Com.Raritan.Idl.pdumodel.CtrlStatistic.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetMetaDataResult {
      public Com.Raritan.Idl.pdumodel.Controller_4_0_0.MetaData _ret_;
    }

    public GetMetaDataResult getMetaData() {
      JsonObject _parameters = null;
      var _result = RpcCall("getMetaData", _parameters);
      var _ret = new GetMetaDataResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.Controller_4_0_0.MetaData.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getMetaData(AsyncRpcResponse<GetMetaDataResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getMetaData(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getMetaData(AsyncRpcResponse<GetMetaDataResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getMetaData", _parameters,
        _result => {
          try {
            var _ret = new GetMetaDataResult();
            _ret._ret_ = Com.Raritan.Idl.pdumodel.Controller_4_0_0.MetaData.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
