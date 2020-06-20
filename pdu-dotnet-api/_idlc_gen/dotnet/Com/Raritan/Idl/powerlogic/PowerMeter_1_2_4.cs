// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from PowerLogicPowerMeter.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.powerlogic {
  public class PowerMeter_1_2_4 : Com.Raritan.Idl.modbus.Device {

    static public readonly new TypeInfo typeInfo = new TypeInfo("powerlogic.PowerMeter:1.2.4", null);

    public PowerMeter_1_2_4(Agent agent, string rid, TypeInfo ti) : base(agent, rid, ti) {}
    public PowerMeter_1_2_4(Agent agent, string rid) : this(agent, rid, typeInfo) {}

    public static new PowerMeter_1_2_4 StaticCast(ObjectProxy proxy) {
      return proxy == null ? null : new PowerMeter_1_2_4(proxy.Agent, proxy.Rid, proxy.StaticTypeInfo);
    }

    public class MinMaxReading : ICloneable {
      public object Clone() {
        MinMaxReading copy = new MinMaxReading();
        copy.min = this.min;
        copy.max = this.max;
        copy.reading = this.reading;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["min"] = this.min != null ? this.min.Encode() : JsonValue.Null;
        json["max"] = this.max != null ? this.max.Encode() : JsonValue.Null;
        json["reading"] = this.reading != null ? this.reading.Encode() : JsonValue.Null;
        return json;
      }

      public static MinMaxReading Decode(LightJson.JsonObject json, Agent agent) {
        MinMaxReading inst = new MinMaxReading();
        inst.min = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["min"], agent));
        inst.max = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["max"], agent));
        inst.reading = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["reading"], agent));
        return inst;
      }

      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 min = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 max = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 reading = null;
    }

    public class L2N_N_Avg : ICloneable {
      public object Clone() {
        L2N_N_Avg copy = new L2N_N_Avg();
        copy.l1 = this.l1;
        copy.l2 = this.l2;
        copy.l3 = this.l3;
        copy.n = this.n;
        copy.average = this.average;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["l1"] = this.l1.Encode();
        json["l2"] = this.l2.Encode();
        json["l3"] = this.l3.Encode();
        json["n"] = this.n != null ? this.n.Encode() : JsonValue.Null;
        json["average"] = this.average != null ? this.average.Encode() : JsonValue.Null;
        return json;
      }

      public static L2N_N_Avg Decode(LightJson.JsonObject json, Agent agent) {
        L2N_N_Avg inst = new L2N_N_Avg();
        inst.l1 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l1"], agent);
        inst.l2 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l2"], agent);
        inst.l3 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l3"], agent);
        inst.n = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["n"], agent));
        inst.average = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["average"], agent));
        return inst;
      }

      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l1 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l2 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l3 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 n = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 average = null;
    }

    public class L2L_Avg : ICloneable {
      public object Clone() {
        L2L_Avg copy = new L2L_Avg();
        copy.l1l2 = this.l1l2;
        copy.l2l3 = this.l2l3;
        copy.l3l1 = this.l3l1;
        copy.average = this.average;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["l1l2"] = this.l1l2.Encode();
        json["l2l3"] = this.l2l3.Encode();
        json["l3l1"] = this.l3l1.Encode();
        json["average"] = this.average != null ? this.average.Encode() : JsonValue.Null;
        return json;
      }

      public static L2L_Avg Decode(LightJson.JsonObject json, Agent agent) {
        L2L_Avg inst = new L2L_Avg();
        inst.l1l2 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l1l2"], agent);
        inst.l2l3 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l2l3"], agent);
        inst.l3l1 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l3l1"], agent);
        inst.average = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["average"], agent));
        return inst;
      }

      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l1l2 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l2l3 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l3l1 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 average = null;
    }

    public class L2N_Avg : ICloneable {
      public object Clone() {
        L2N_Avg copy = new L2N_Avg();
        copy.l1 = this.l1;
        copy.l2 = this.l2;
        copy.l3 = this.l3;
        copy.average = this.average;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["l1"] = this.l1.Encode();
        json["l2"] = this.l2.Encode();
        json["l3"] = this.l3.Encode();
        json["average"] = this.average != null ? this.average.Encode() : JsonValue.Null;
        return json;
      }

      public static L2N_Avg Decode(LightJson.JsonObject json, Agent agent) {
        L2N_Avg inst = new L2N_Avg();
        inst.l1 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l1"], agent);
        inst.l2 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l2"], agent);
        inst.l3 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l3"], agent);
        inst.average = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["average"], agent));
        return inst;
      }

      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l1 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l2 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l3 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 average = null;
    }

    public class L2N : ICloneable {
      public object Clone() {
        L2N copy = new L2N();
        copy.l1 = this.l1;
        copy.l2 = this.l2;
        copy.l3 = this.l3;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["l1"] = this.l1.Encode();
        json["l2"] = this.l2.Encode();
        json["l3"] = this.l3.Encode();
        return json;
      }

      public static L2N Decode(LightJson.JsonObject json, Agent agent) {
        L2N inst = new L2N();
        inst.l1 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l1"], agent);
        inst.l2 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l2"], agent);
        inst.l3 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l3"], agent);
        return inst;
      }

      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l1 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l2 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l3 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
    }

    public class L2L : ICloneable {
      public object Clone() {
        L2L copy = new L2L();
        copy.l1l2 = this.l1l2;
        copy.l2l3 = this.l2l3;
        copy.l3l1 = this.l3l1;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["l1l2"] = this.l1l2.Encode();
        json["l2l3"] = this.l2l3.Encode();
        json["l3l1"] = this.l3l1.Encode();
        return json;
      }

      public static L2L Decode(LightJson.JsonObject json, Agent agent) {
        L2L inst = new L2L();
        inst.l1l2 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l1l2"], agent);
        inst.l2l3 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l2l3"], agent);
        inst.l3l1 = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["l3l1"], agent);
        return inst;
      }

      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l1l2 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l2l3 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading l3l1 = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
    }

    public class L2N_plain_total : ICloneable {
      public object Clone() {
        L2N_plain_total copy = new L2N_plain_total();
        copy.l1 = this.l1;
        copy.l2 = this.l2;
        copy.l3 = this.l3;
        copy.total = this.total;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["l1"] = this.l1 != null ? this.l1.Encode() : JsonValue.Null;
        json["l2"] = this.l2 != null ? this.l2.Encode() : JsonValue.Null;
        json["l3"] = this.l3 != null ? this.l3.Encode() : JsonValue.Null;
        json["total"] = this.total.Encode();
        return json;
      }

      public static L2N_plain_total Decode(LightJson.JsonObject json, Agent agent) {
        L2N_plain_total inst = new L2N_plain_total();
        inst.l1 = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["l1"], agent));
        inst.l2 = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["l2"], agent));
        inst.l3 = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["l3"], agent));
        inst.total = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["total"], agent);
        return inst;
      }

      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 l1 = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 l2 = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 l3 = null;
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading total = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
    }

    public class Sensors : ICloneable {
      public object Clone() {
        Sensors copy = new Sensors();
        copy.current = this.current;
        copy.voltageL2L = this.voltageL2L;
        copy.voltageL2N = this.voltageL2N;
        copy.frequency = this.frequency;
        copy.activePower = this.activePower;
        copy.reactivePower = this.reactivePower;
        copy.apparentPower = this.apparentPower;
        copy.powerFactor = this.powerFactor;
        copy.activeEnergy = this.activeEnergy;
        copy.reactiveEnergy = this.reactiveEnergy;
        copy.apparentEnergy = this.apparentEnergy;
        copy.thdCurrent = this.thdCurrent;
        copy.thdVoltageL2L = this.thdVoltageL2L;
        copy.thdVoltageL2N = this.thdVoltageL2N;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["current"] = this.current.Encode();
        json["voltageL2L"] = this.voltageL2L.Encode();
        json["voltageL2N"] = this.voltageL2N.Encode();
        json["frequency"] = this.frequency != null ? this.frequency.Encode() : JsonValue.Null;
        json["activePower"] = this.activePower.Encode();
        json["reactivePower"] = this.reactivePower.Encode();
        json["apparentPower"] = this.apparentPower.Encode();
        json["powerFactor"] = this.powerFactor.Encode();
        json["activeEnergy"] = this.activeEnergy != null ? this.activeEnergy.Encode() : JsonValue.Null;
        json["reactiveEnergy"] = this.reactiveEnergy != null ? this.reactiveEnergy.Encode() : JsonValue.Null;
        json["apparentEnergy"] = this.apparentEnergy != null ? this.apparentEnergy.Encode() : JsonValue.Null;
        json["thdCurrent"] = this.thdCurrent.Encode();
        json["thdVoltageL2L"] = this.thdVoltageL2L.Encode();
        json["thdVoltageL2N"] = this.thdVoltageL2N.Encode();
        return json;
      }

      public static Sensors Decode(LightJson.JsonObject json, Agent agent) {
        Sensors inst = new Sensors();
        inst.current = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_N_Avg.Decode(json["current"], agent);
        inst.voltageL2L = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2L_Avg.Decode(json["voltageL2L"], agent);
        inst.voltageL2N = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_Avg.Decode(json["voltageL2N"], agent);
        inst.frequency = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["frequency"], agent));
        inst.activePower = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_plain_total.Decode(json["activePower"], agent);
        inst.reactivePower = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_plain_total.Decode(json["reactivePower"], agent);
        inst.apparentPower = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_plain_total.Decode(json["apparentPower"], agent);
        inst.powerFactor = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading.Decode(json["powerFactor"], agent);
        inst.activeEnergy = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["activeEnergy"], agent));
        inst.reactiveEnergy = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["reactiveEnergy"], agent));
        inst.apparentEnergy = Com.Raritan.Idl.sensors.NumericSensor_4_0_2.StaticCast(ObjectProxy.Decode(json["apparentEnergy"], agent));
        inst.thdCurrent = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N.Decode(json["thdCurrent"], agent);
        inst.thdVoltageL2L = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2L.Decode(json["thdVoltageL2L"], agent);
        inst.thdVoltageL2N = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N.Decode(json["thdVoltageL2N"], agent);
        return inst;
      }

      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_N_Avg current = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_N_Avg();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2L_Avg voltageL2L = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2L_Avg();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_Avg voltageL2N = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_Avg();
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 frequency = null;
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_plain_total activePower = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_plain_total();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_plain_total reactivePower = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_plain_total();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_plain_total apparentPower = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N_plain_total();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading powerFactor = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.MinMaxReading();
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 activeEnergy = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 reactiveEnergy = null;
      public Com.Raritan.Idl.sensors.NumericSensor_4_0_2 apparentEnergy = null;
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N thdCurrent = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2L thdVoltageL2L = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2L();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N thdVoltageL2N = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.L2N();
    }

    public class Setup : ICloneable {
      public object Clone() {
        Setup copy = new Setup();
        copy.systemType = this.systemType;
        copy.displayMode = this.displayMode;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["systemType"] = this.systemType;
        json["displayMode"] = this.displayMode;
        return json;
      }

      public static Setup Decode(LightJson.JsonObject json, Agent agent) {
        Setup inst = new Setup();
        inst.systemType = (int)json["systemType"];
        inst.displayMode = (int)json["displayMode"];
        return inst;
      }

      public int systemType = 0;
      public int displayMode = 0;
    }

    public class ErrorStatus : ICloneable {
      public object Clone() {
        ErrorStatus copy = new ErrorStatus();
        copy.vL1saturation = this.vL1saturation;
        copy.vL2saturation = this.vL2saturation;
        copy.vL3saturation = this.vL3saturation;
        copy.cL1saturation = this.cL1saturation;
        copy.cL2saturation = this.cL2saturation;
        copy.cL3saturation = this.cL3saturation;
        copy.freqInvalid = this.freqInvalid;
        return copy;
      }

      public LightJson.JsonObject Encode() {
        LightJson.JsonObject json = new LightJson.JsonObject();
        json["vL1saturation"] = this.vL1saturation;
        json["vL2saturation"] = this.vL2saturation;
        json["vL3saturation"] = this.vL3saturation;
        json["cL1saturation"] = this.cL1saturation;
        json["cL2saturation"] = this.cL2saturation;
        json["cL3saturation"] = this.cL3saturation;
        json["freqInvalid"] = this.freqInvalid;
        return json;
      }

      public static ErrorStatus Decode(LightJson.JsonObject json, Agent agent) {
        ErrorStatus inst = new ErrorStatus();
        inst.vL1saturation = (bool)json["vL1saturation"];
        inst.vL2saturation = (bool)json["vL2saturation"];
        inst.vL3saturation = (bool)json["vL3saturation"];
        inst.cL1saturation = (bool)json["cL1saturation"];
        inst.cL2saturation = (bool)json["cL2saturation"];
        inst.cL3saturation = (bool)json["cL3saturation"];
        inst.freqInvalid = (bool)json["freqInvalid"];
        return inst;
      }

      public bool vL1saturation = false;
      public bool vL2saturation = false;
      public bool vL3saturation = false;
      public bool cL1saturation = false;
      public bool cL2saturation = false;
      public bool cL3saturation = false;
      public bool freqInvalid = false;
    }

    public class SetupChangedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("powerlogic.PowerMeter_1_2_4.SetupChangedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.Setup oldSetup = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.Setup();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.Setup newSetup = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.Setup();
    }

    public class ErrorStatusChangedEvent : Com.Raritan.Idl.idl.Event {
      static public readonly new TypeInfo typeInfo = new TypeInfo("powerlogic.PowerMeter_1_2_4.ErrorStatusChangedEvent:1.0.0", Com.Raritan.Idl.idl.Event.typeInfo);

      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.ErrorStatus oldStatus = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.ErrorStatus();
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.ErrorStatus newStatus = new Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.ErrorStatus();
    }

    public class GetSensorsResult {
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.Sensors _ret_;
    }

    public GetSensorsResult getSensors() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSensors", _parameters);
      var _ret = new GetSensorsResult();
      _ret._ret_ = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.Sensors.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getSensors(AsyncRpcResponse<GetSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getSensors(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getSensors(AsyncRpcResponse<GetSensorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getSensors", _parameters,
        _result => {
          try {
            var _ret = new GetSensorsResult();
            _ret._ret_ = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.Sensors.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetSetupResult {
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.Setup _ret_;
    }

    public GetSetupResult getSetup() {
      JsonObject _parameters = null;
      var _result = RpcCall("getSetup", _parameters);
      var _ret = new GetSetupResult();
      _ret._ret_ = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.Setup.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getSetup(AsyncRpcResponse<GetSetupResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getSetup(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getSetup(AsyncRpcResponse<GetSetupResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getSetup", _parameters,
        _result => {
          try {
            var _ret = new GetSetupResult();
            _ret._ret_ = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.Setup.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class GetErrorStatusResult {
      public Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.ErrorStatus _ret_;
    }

    public GetErrorStatusResult getErrorStatus() {
      JsonObject _parameters = null;
      var _result = RpcCall("getErrorStatus", _parameters);
      var _ret = new GetErrorStatusResult();
      _ret._ret_ = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.ErrorStatus.Decode(_result["_ret_"], agent);
      return _ret;
    }

    public AsyncRequest getErrorStatus(AsyncRpcResponse<GetErrorStatusResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return getErrorStatus(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest getErrorStatus(AsyncRpcResponse<GetErrorStatusResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("getErrorStatus", _parameters,
        _result => {
          try {
            var _ret = new GetErrorStatusResult();
            _ret._ret_ = Com.Raritan.Idl.powerlogic.PowerMeter_1_2_4.ErrorStatus.Decode(_result["_ret_"], agent);
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class ResetAllMinMaxValuesResult {
    }

    public ResetAllMinMaxValuesResult resetAllMinMaxValues() {
      JsonObject _parameters = null;
      var _result = RpcCall("resetAllMinMaxValues", _parameters);
      var _ret = new ResetAllMinMaxValuesResult();
      return _ret;
    }

    public AsyncRequest resetAllMinMaxValues(AsyncRpcResponse<ResetAllMinMaxValuesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return resetAllMinMaxValues(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest resetAllMinMaxValues(AsyncRpcResponse<ResetAllMinMaxValuesResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("resetAllMinMaxValues", _parameters,
        _result => {
          try {
            var _ret = new ResetAllMinMaxValuesResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

    public class ClearAllEnergyAccumulatorsResult {
    }

    public ClearAllEnergyAccumulatorsResult clearAllEnergyAccumulators() {
      JsonObject _parameters = null;
      var _result = RpcCall("clearAllEnergyAccumulators", _parameters);
      var _ret = new ClearAllEnergyAccumulatorsResult();
      return _ret;
    }

    public AsyncRequest clearAllEnergyAccumulators(AsyncRpcResponse<ClearAllEnergyAccumulatorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail) {
      return clearAllEnergyAccumulators(rsp, fail, RpcCtrl.Default);
    }

    public AsyncRequest clearAllEnergyAccumulators(AsyncRpcResponse<ClearAllEnergyAccumulatorsResult>.SuccessHandler rsp, AsyncRpcResponse.FailureHandler fail, RpcCtrl rpcCtrl) {
      JsonObject _parameters = null;
      return RpcCall("clearAllEnergyAccumulators", _parameters,
        _result => {
          try {
            var _ret = new ClearAllEnergyAccumulatorsResult();
            rsp(_ret);
          } catch (Exception e) {
            if (fail != null) fail(e);
          }
        }, fail, rpcCtrl);
    }

  }
}