# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from TransferSwitch.idl.

use strict;

package Raritan::RPC::pdumodel::TransferSwitch_4_0_1::Sensors;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'selectedSource'} = Raritan::RPC::ObjectCodec::encode($in->{'selectedSource'});
    $encoded->{'operationalState'} = Raritan::RPC::ObjectCodec::encode($in->{'operationalState'});
    $encoded->{'sourceVoltagePhaseSyncAngle'} = Raritan::RPC::ObjectCodec::encode($in->{'sourceVoltagePhaseSyncAngle'});
    $encoded->{'overloadAlarm'} = Raritan::RPC::ObjectCodec::encode($in->{'overloadAlarm'});
    $encoded->{'phaseSyncAlarm'} = Raritan::RPC::ObjectCodec::encode($in->{'phaseSyncAlarm'});
    $encoded->{'switchFault'} = Raritan::RPC::ObjectCodec::encode($in->{'switchFault'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'selectedSource'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'selectedSource'}, 'sensors.StateSensor');
    $decoded->{'operationalState'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'operationalState'}, 'sensors.StateSensor');
    $decoded->{'sourceVoltagePhaseSyncAngle'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'sourceVoltagePhaseSyncAngle'}, 'sensors.NumericSensor');
    $decoded->{'overloadAlarm'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'overloadAlarm'}, 'sensors.StateSensor');
    $decoded->{'phaseSyncAlarm'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'phaseSyncAlarm'}, 'sensors.StateSensor');
    $decoded->{'switchFault'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'switchFault'}, 'sensors.StateSensor');
    return $decoded;
}

1;
