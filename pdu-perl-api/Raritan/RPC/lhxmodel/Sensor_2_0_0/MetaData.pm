# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from LhxSensor.idl.

use strict;

package Raritan::RPC::lhxmodel::Sensor_2_0_0::MetaData;

use Raritan::RPC::sensors::Sensor_2_0_0::TypeSpec;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'type'} = Raritan::RPC::sensors::Sensor_2_0_0::TypeSpec::encode($in->{'type'});
    $encoded->{'numDecDigits'} = 1 * $in->{'numDecDigits'};
    $encoded->{'numRangeMin'} = 1 * $in->{'numRangeMin'};
    $encoded->{'numRangeMax'} = 1 * $in->{'numRangeMax'};
    $encoded->{'numThresholdMin'} = 1 * $in->{'numThresholdMin'};
    $encoded->{'numThresholdMax'} = 1 * $in->{'numThresholdMax'};
    $encoded->{'label'} = "$in->{'label'}";
    $encoded->{'id'} = "$in->{'id'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'type'} = Raritan::RPC::sensors::Sensor_2_0_0::TypeSpec::decode($agent, $in->{'type'});
    $decoded->{'numDecDigits'} = $in->{'numDecDigits'};
    $decoded->{'numRangeMin'} = $in->{'numRangeMin'};
    $decoded->{'numRangeMax'} = $in->{'numRangeMax'};
    $decoded->{'numThresholdMin'} = $in->{'numThresholdMin'};
    $decoded->{'numThresholdMax'} = $in->{'numThresholdMax'};
    $decoded->{'label'} = $in->{'label'};
    $decoded->{'id'} = $in->{'id'};
    return $decoded;
}

1;
