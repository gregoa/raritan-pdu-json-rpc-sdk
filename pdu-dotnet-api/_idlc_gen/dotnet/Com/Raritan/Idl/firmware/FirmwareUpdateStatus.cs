// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from FirmwareUpdateStatus.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.firmware {
  public class FirmwareUpdateStatus : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("firmware.FirmwareUpdateStatus:1.0.0", null);

    public FirmwareUpdateStatus(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public FirmwareUpdateStatus(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new FirmwareUpdateStatus StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new FirmwareUpdateStatus(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class GetStatusResult {
      public Com.Raritan.Idl.firmware.UpdateStatus _ret_;
    }

    public GetStatusResult getStatus() {
      JsonObject _parameters = null;
      var _result = RpcCall("getStatus", _parameters);
      var _ret = new GetStatusResult();
      _ret._ret_ = Com.Raritan.Idl.firmware.UpdateStatus.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getStatus(AsyncRpcResponse<GetStatusResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getStatus(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getStatus(AsyncRpcResponse<GetStatusResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getStatus", _parameters,
        _result => {
          try {
            var _ret = new GetStatusResult();
            _ret._ret_ = Com.Raritan.Idl.firmware.UpdateStatus.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
