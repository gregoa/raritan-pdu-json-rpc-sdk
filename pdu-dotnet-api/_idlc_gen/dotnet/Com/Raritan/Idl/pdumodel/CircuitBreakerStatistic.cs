// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from OverCurrentProtector.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {

  public class CircuitBreakerStatistic : ICloneable {
    public object Clone() {
      CircuitBreakerStatistic copy = new CircuitBreakerStatistic();
      copy.tripCnt = this.tripCnt;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["tripCnt"] = this.tripCnt;
      return json;
    }

    public static CircuitBreakerStatistic Decode(LightJson.JsonObject json, Agent agent) {
      CircuitBreakerStatistic inst = new CircuitBreakerStatistic();
      inst.tripCnt = (int)json["tripCnt"];
      return inst;
    }

    public int tripCnt = 0;
  }
}
