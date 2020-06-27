# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from SensorLogger.idl.

use strict;

package Raritan::RPC::sensors::Logger_2_1_3::SensorSet;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'sensors'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'sensors'}}; $i0++) {
        $encoded->{'sensors'}->[$i0] = Raritan::RPC::ObjectCodec::encode($in->{'sensors'}->[$i0]);
    }
    $encoded->{'slots'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'slots'}}; $i0++) {
        $encoded->{'slots'}->[$i0] = Raritan::RPC::ObjectCodec::encode($in->{'slots'}->[$i0]);
    }
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'sensors'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'sensors'}}; $i0++) {
        $decoded->{'sensors'}->[$i0] = Raritan::RPC::ObjectCodec::decode($agent, $in->{'sensors'}->[$i0], 'sensors.Sensor');
    }
    $decoded->{'slots'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'slots'}}; $i0++) {
        $decoded->{'slots'}->[$i0] = Raritan::RPC::ObjectCodec::decode($agent, $in->{'slots'}->[$i0], 'peripheral.DeviceSlot');
    }
    return $decoded;
}

1;
