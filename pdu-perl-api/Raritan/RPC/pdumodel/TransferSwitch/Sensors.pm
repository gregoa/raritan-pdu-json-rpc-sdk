# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from TransferSwitch.idl.

use strict;

package Raritan::RPC::pdumodel::TransferSwitch::Sensors;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'selectedSource'} = Raritan::RPC::ObjectCodec::encode($in->{'selectedSource'});
    $encoded->{'operationalState'} = Raritan::RPC::ObjectCodec::encode($in->{'operationalState'});
    $encoded->{'sourceVoltagePhaseSyncAngle'} = Raritan::RPC::ObjectCodec::encode($in->{'sourceVoltagePhaseSyncAngle'});
    $encoded->{'temperature'} = Raritan::RPC::ObjectCodec::encode($in->{'temperature'});
    $encoded->{'fanSpeed'} = Raritan::RPC::ObjectCodec::encode($in->{'fanSpeed'});
    $encoded->{'overloadAlarm'} = Raritan::RPC::ObjectCodec::encode($in->{'overloadAlarm'});
    $encoded->{'overheatAlarm'} = Raritan::RPC::ObjectCodec::encode($in->{'overheatAlarm'});
    $encoded->{'phaseSyncAlarm'} = Raritan::RPC::ObjectCodec::encode($in->{'phaseSyncAlarm'});
    $encoded->{'movFault'} = Raritan::RPC::ObjectCodec::encode($in->{'movFault'});
    $encoded->{'scrOpenFault'} = Raritan::RPC::ObjectCodec::encode($in->{'scrOpenFault'});
    $encoded->{'scrShortFault'} = Raritan::RPC::ObjectCodec::encode($in->{'scrShortFault'});
    $encoded->{'fanFault'} = Raritan::RPC::ObjectCodec::encode($in->{'fanFault'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'selectedSource'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'selectedSource'}, 'sensors.StateSensor');
    $decoded->{'operationalState'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'operationalState'}, 'sensors.StateSensor');
    $decoded->{'sourceVoltagePhaseSyncAngle'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'sourceVoltagePhaseSyncAngle'}, 'sensors.NumericSensor');
    $decoded->{'temperature'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'temperature'}, 'sensors.NumericSensor');
    $decoded->{'fanSpeed'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'fanSpeed'}, 'sensors.NumericSensor');
    $decoded->{'overloadAlarm'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'overloadAlarm'}, 'sensors.StateSensor');
    $decoded->{'overheatAlarm'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'overheatAlarm'}, 'sensors.StateSensor');
    $decoded->{'phaseSyncAlarm'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'phaseSyncAlarm'}, 'sensors.StateSensor');
    $decoded->{'movFault'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'movFault'}, 'sensors.StateSensor');
    $decoded->{'scrOpenFault'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'scrOpenFault'}, 'sensors.StateSensor');
    $decoded->{'scrShortFault'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'scrShortFault'}, 'sensors.StateSensor');
    $decoded->{'fanFault'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'fanFault'}, 'sensors.StateSensor');
    return $decoded;
}

1;
