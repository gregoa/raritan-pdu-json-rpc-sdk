# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Sensor.idl.

use strict;

package Raritan::RPC::sensors::Sensor_4_0_2::TypeSpec;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'readingtype'} = 1 * $in->{'readingtype'};
    $encoded->{'type'} = 1 * $in->{'type'};
    $encoded->{'unit'} = 1 * $in->{'unit'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'readingtype'} = $in->{'readingtype'};
    $decoded->{'type'} = $in->{'type'};
    $decoded->{'unit'} = $in->{'unit'};
    return $decoded;
}

1;
