// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from PeripheralDevicePackage.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.peripheral {
  public class Package : ObjectProxy {

    static public readonly new TypeInfo typeInfo = new TypeInfo("peripheral.Package:1.0.0", null);

    public Package(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public Package(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new Package StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new Package(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class GetPackageInfoResult {
      public Com.Raritan.Idl.peripheral.PackageInfo_2_0_0 _ret_;
    }

    public GetPackageInfoResult getPackageInfo() {
      JsonObject _parameters = null;
      var _result = RpcCall("getPackageInfo", _parameters);
      var _ret = new GetPackageInfoResult();
      _ret._ret_ = Com.Raritan.Idl.peripheral.PackageInfo_2_0_0.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getPackageInfo(AsyncRpcResponse<GetPackageInfoResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getPackageInfo(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getPackageInfo(AsyncRpcResponse<GetPackageInfoResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getPackageInfo", _parameters,
        _result => {
          try {
            var _ret = new GetPackageInfoResult();
            _ret._ret_ = Com.Raritan.Idl.peripheral.PackageInfo_2_0_0.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}
