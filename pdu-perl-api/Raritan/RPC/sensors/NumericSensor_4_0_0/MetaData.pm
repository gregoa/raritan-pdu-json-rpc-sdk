# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from NumericSensor.idl.

use strict;

package Raritan::RPC::sensors::NumericSensor_4_0_0::MetaData;

use Raritan::RPC::sensors::Sensor_4_0_0::TypeSpec;
use Raritan::RPC::sensors::NumericSensor_4_0_0::Range;
use Raritan::RPC::sensors::NumericSensor_4_0_0::ThresholdCapabilities;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'type'} = Raritan::RPC::sensors::Sensor_4_0_0::TypeSpec::encode($in->{'type'});
    $encoded->{'decdigits'} = 1 * $in->{'decdigits'};
    $encoded->{'accuracy'} = 1 * $in->{'accuracy'};
    $encoded->{'resolution'} = 1 * $in->{'resolution'};
    $encoded->{'tolerance'} = 1 * $in->{'tolerance'};
    $encoded->{'noiseThreshold'} = 1 * $in->{'noiseThreshold'};
    $encoded->{'range'} = Raritan::RPC::sensors::NumericSensor_4_0_0::Range::encode($in->{'range'});
    $encoded->{'thresholdCaps'} = Raritan::RPC::sensors::NumericSensor_4_0_0::ThresholdCapabilities::encode($in->{'thresholdCaps'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'type'} = Raritan::RPC::sensors::Sensor_4_0_0::TypeSpec::decode($agent, $in->{'type'});
    $decoded->{'decdigits'} = $in->{'decdigits'};
    $decoded->{'accuracy'} = $in->{'accuracy'};
    $decoded->{'resolution'} = $in->{'resolution'};
    $decoded->{'tolerance'} = $in->{'tolerance'};
    $decoded->{'noiseThreshold'} = $in->{'noiseThreshold'};
    $decoded->{'range'} = Raritan::RPC::sensors::NumericSensor_4_0_0::Range::decode($agent, $in->{'range'});
    $decoded->{'thresholdCaps'} = Raritan::RPC::sensors::NumericSensor_4_0_0::ThresholdCapabilities::decode($agent, $in->{'thresholdCaps'});
    return $decoded;
}

1;
