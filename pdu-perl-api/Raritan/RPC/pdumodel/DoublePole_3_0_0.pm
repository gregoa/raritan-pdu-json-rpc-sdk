# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Pole.idl.

use strict;

package Raritan::RPC::pdumodel::DoublePole_3_0_0;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'label'} = "$in->{'label'}";
    $encoded->{'line'} = $in->{'line'};
    $encoded->{'inNodeId'} = 1 * $in->{'inNodeId'};
    $encoded->{'outNodeId'} = 1 * $in->{'outNodeId'};
    $encoded->{'voltage'} = Raritan::RPC::ObjectCodec::encode($in->{'voltage'});
    $encoded->{'voltageLN'} = Raritan::RPC::ObjectCodec::encode($in->{'voltageLN'});
    $encoded->{'current'} = Raritan::RPC::ObjectCodec::encode($in->{'current'});
    $encoded->{'peakCurrent'} = Raritan::RPC::ObjectCodec::encode($in->{'peakCurrent'});
    $encoded->{'activePower'} = Raritan::RPC::ObjectCodec::encode($in->{'activePower'});
    $encoded->{'apparentPower'} = Raritan::RPC::ObjectCodec::encode($in->{'apparentPower'});
    $encoded->{'powerFactor'} = Raritan::RPC::ObjectCodec::encode($in->{'powerFactor'});
    $encoded->{'activeEnergy'} = Raritan::RPC::ObjectCodec::encode($in->{'activeEnergy'});
    $encoded->{'apparentEnergy'} = Raritan::RPC::ObjectCodec::encode($in->{'apparentEnergy'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'label'} = $in->{'label'};
    $decoded->{'line'} = $in->{'line'};
    $decoded->{'inNodeId'} = $in->{'inNodeId'};
    $decoded->{'outNodeId'} = $in->{'outNodeId'};
    $decoded->{'voltage'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'voltage'}, 'sensors.NumericSensor');
    $decoded->{'voltageLN'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'voltageLN'}, 'sensors.NumericSensor');
    $decoded->{'current'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'current'}, 'sensors.NumericSensor');
    $decoded->{'peakCurrent'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'peakCurrent'}, 'sensors.NumericSensor');
    $decoded->{'activePower'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'activePower'}, 'sensors.NumericSensor');
    $decoded->{'apparentPower'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'apparentPower'}, 'sensors.NumericSensor');
    $decoded->{'powerFactor'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'powerFactor'}, 'sensors.NumericSensor');
    $decoded->{'activeEnergy'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'activeEnergy'}, 'sensors.NumericSensor');
    $decoded->{'apparentEnergy'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'apparentEnergy'}, 'sensors.NumericSensor');
    return $decoded;
}

1;
