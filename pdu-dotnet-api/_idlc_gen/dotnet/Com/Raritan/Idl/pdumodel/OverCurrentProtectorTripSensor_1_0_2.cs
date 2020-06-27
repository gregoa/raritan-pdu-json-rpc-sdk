// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from OverCurrentProtectorTripSensor.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {
  public class OverCurrentProtectorTripSensor_1_0_2 : Com.Raritan.Idl.sensors.StateSensor_4_0_2 {

    static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.OverCurrentProtectorTripSensor:1.0.2", null);

    public OverCurrentProtectorTripSensor_1_0_2(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public OverCurrentProtectorTripSensor_1_0_2(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new OverCurrentProtectorTripSensor_1_0_2 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new OverCurrentProtectorTripSensor_1_0_2(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class TripStateChangedEvent : Com.Raritan.Idl.sensors.StateSensor_4_0_2.StateChangedEvent {
      static public readonly new TypeInfo typeInfo = new TypeInfo("pdumodel.OverCurrentProtectorTripSensor_1_0_2.TripStateChangedEvent:1.0.0", Com.Raritan.Idl.sensors.StateSensor_4_0_2.StateChangedEvent.typeInfo);

      public Com.Raritan.Idl.pdumodel.Outlet_2_1_3 tripCause = null;
    }

    public class GetTripCauseResult {
      public Com.Raritan.Idl.pdumodel.Outlet_2_1_3 _ret_;
    }

    public GetTripCauseResult getTripCause() {
      JsonObject _parameters = null;
      var _result = RpcCall("getTripCause", _parameters);
      var _ret = new GetTripCauseResult();
      _ret._ret_ = Com.Raritan.Idl.pdumodel.Outlet_2_1_3.StaticCast(ObjectProxy.Decode(_result["_ret_"], agent));
      return _ret;
    }

    public AsyncRequest getTripCause(AsyncRpcResponse<GetTripCauseResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getTripCause(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getTripCause(AsyncRpcResponse<GetTripCauseResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getTripCause", _parameters,
        _result => {
          try {
            var _ret = new GetTripCauseResult();
            _ret._ret_ = Com.Raritan.Idl.pdumodel.Outlet_2_1_3.StaticCast(ObjectProxy.Decode(_result["_ret_"], agent));
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}