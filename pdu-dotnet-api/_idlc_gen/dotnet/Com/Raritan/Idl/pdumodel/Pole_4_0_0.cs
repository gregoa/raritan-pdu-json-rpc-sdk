// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from Pole.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.pdumodel {

  public class Pole_4_0_0 : ICloneable {
    public object Clone() {
      Pole_4_0_0 copy = new Pole_4_0_0();
      copy.label = this.label;
      copy.line = this.line;
      copy.nodeId = this.nodeId;
      copy.voltage = this.voltage;
      copy.voltageLN = this.voltageLN;
      copy.current = this.current;
      copy.peakCurrent = this.peakCurrent;
      copy.activePower = this.activePower;
      copy.reactivePower = this.reactivePower;
      copy.apparentPower = this.apparentPower;
      copy.powerFactor = this.powerFactor;
      copy.phaseAngle = this.phaseAngle;
      copy.displacementPowerFactor = this.displacementPowerFactor;
      copy.activeEnergy = this.activeEnergy;
      copy.apparentEnergy = this.apparentEnergy;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["label"] = this.label;
      json["line"] = (int)this.line;
      json["nodeId"] = this.nodeId;
      json["voltage"] = this.voltage != null ? this.voltage.Encode() : JsonValue.Null;
      json["voltageLN"] = this.voltageLN != null ? this.voltageLN.Encode() : JsonValue.Null;
      json["current"] = this.current != null ? this.current.Encode() : JsonValue.Null;
      json["peakCurrent"] = this.peakCurrent != null ? this.peakCurrent.Encode() : JsonValue.Null;
      json["activePower"] = this.activePower != null ? this.activePower.Encode() : JsonValue.Null;
      json["reactivePower"] = this.reactivePower != null ? this.reactivePower.Encode() : JsonValue.Null;
      json["apparentPower"] = this.apparentPower != null ? this.apparentPower.Encode() : JsonValue.Null;
      json["powerFactor"] = this.powerFactor != null ? this.powerFactor.Encode() : JsonValue.Null;
      json["phaseAngle"] = this.phaseAngle != null ? this.phaseAngle.Encode() : JsonValue.Null;
      json["displacementPowerFactor"] = this.displacementPowerFactor != null ? this.displacementPowerFactor.Encode() : JsonValue.Null;
      json["activeEnergy"] = this.activeEnergy != null ? this.activeEnergy.Encode() : JsonValue.Null;
      json["apparentEnergy"] = this.apparentEnergy != null ? this.apparentEnergy.Encode() : JsonValue.Null;
      return json;
    }

    public static Pole_4_0_0 Decode(LightJson.JsonObject json, Agent agent) {
      Pole_4_0_0 inst = new Pole_4_0_0();
      inst.label = (string)json["label"];
      inst.line = (Com.Raritan.Idl.pdumodel.PowerLine_2_0_0)(int)json["line"];
      inst.nodeId = (int)json["nodeId"];
      inst.voltage = Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StaticCast(ObjectProxy.Decode(json["voltage"], agent));
      inst.voltageLN = Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StaticCast(ObjectProxy.Decode(json["voltageLN"], agent));
      inst.current = Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StaticCast(ObjectProxy.Decode(json["current"], agent));
      inst.peakCurrent = Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StaticCast(ObjectProxy.Decode(json["peakCurrent"], agent));
      inst.activePower = Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StaticCast(ObjectProxy.Decode(json["activePower"], agent));
      inst.reactivePower = Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StaticCast(ObjectProxy.Decode(json["reactivePower"], agent));
      inst.apparentPower = Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StaticCast(ObjectProxy.Decode(json["apparentPower"], agent));
      inst.powerFactor = Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StaticCast(ObjectProxy.Decode(json["powerFactor"], agent));
      inst.phaseAngle = Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StaticCast(ObjectProxy.Decode(json["phaseAngle"], agent));
      inst.displacementPowerFactor = Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StaticCast(ObjectProxy.Decode(json["displacementPowerFactor"], agent));
      inst.activeEnergy = Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StaticCast(ObjectProxy.Decode(json["activeEnergy"], agent));
      inst.apparentEnergy = Com.Raritan.Idl.sensors.NumericSensor_4_0_1.StaticCast(ObjectProxy.Decode(json["apparentEnergy"], agent));
      return inst;
    }

    public string label = "";
    public Com.Raritan.Idl.pdumodel.PowerLine_2_0_0 line = Com.Raritan.Idl.pdumodel.PowerLine_2_0_0.L1;
    public int nodeId = 0;
    public Com.Raritan.Idl.sensors.NumericSensor_4_0_1 voltage = null;
    public Com.Raritan.Idl.sensors.NumericSensor_4_0_1 voltageLN = null;
    public Com.Raritan.Idl.sensors.NumericSensor_4_0_1 current = null;
    public Com.Raritan.Idl.sensors.NumericSensor_4_0_1 peakCurrent = null;
    public Com.Raritan.Idl.sensors.NumericSensor_4_0_1 activePower = null;
    public Com.Raritan.Idl.sensors.NumericSensor_4_0_1 reactivePower = null;
    public Com.Raritan.Idl.sensors.NumericSensor_4_0_1 apparentPower = null;
    public Com.Raritan.Idl.sensors.NumericSensor_4_0_1 powerFactor = null;
    public Com.Raritan.Idl.sensors.NumericSensor_4_0_1 phaseAngle = null;
    public Com.Raritan.Idl.sensors.NumericSensor_4_0_1 displacementPowerFactor = null;
    public Com.Raritan.Idl.sensors.NumericSensor_4_0_1 activeEnergy = null;
    public Com.Raritan.Idl.sensors.NumericSensor_4_0_1 apparentEnergy = null;
  }
}
