// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from UserManager.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.usermgmt {

  public class AccountEvent : Com.Raritan.Idl._event.UserEvent {
    static public readonly new TypeInfo typeInfo = new TypeInfo("usermgmt.AccountEvent:1.0.0", Com.Raritan.Idl._event.UserEvent.typeInfo);

    public string username = "";
  }
}
