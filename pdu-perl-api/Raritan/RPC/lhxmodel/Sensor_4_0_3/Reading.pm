# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from LhxSensor.idl.

use strict;

package Raritan::RPC::lhxmodel::Sensor_4_0_3::Reading;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'timestamp'} = 1 * $in->{'timestamp'};
    $encoded->{'state'} = 1 * $in->{'state'};
    $encoded->{'value'} = 1 * $in->{'value'};
    $encoded->{'isValid'} = ($in->{'isValid'}) ? JSON::true : JSON::false;
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'timestamp'} = $in->{'timestamp'};
    $decoded->{'state'} = $in->{'state'};
    $decoded->{'value'} = $in->{'value'};
    $decoded->{'isValid'} = ($in->{'isValid'}) ? 1 : 0;
    return $decoded;
}

1;
