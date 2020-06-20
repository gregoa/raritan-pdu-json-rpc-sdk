# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Sensor.idl.

use strict;

package Raritan::RPC::sensors::Sensor_3_0_0::TypeSpec;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'readingtype'} = $in->{'readingtype'};
    $encoded->{'type'} = $in->{'type'};
    $encoded->{'unit'} = $in->{'unit'};
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
