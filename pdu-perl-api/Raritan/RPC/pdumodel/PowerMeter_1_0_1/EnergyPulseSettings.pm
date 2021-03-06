# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PowerMeter.idl.

use strict;

package Raritan::RPC::pdumodel::PowerMeter_1_0_1::EnergyPulseSettings;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'pulseEnabled'} = ($in->{'pulseEnabled'}) ? JSON::true : JSON::false;
    $encoded->{'poles'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'poles'}}; $i0++) {
        $encoded->{'poles'}->[$i0] = 1 * $in->{'poles'}->[$i0];
    }
    $encoded->{'pulsesPerKWh'} = 1 * $in->{'pulsesPerKWh'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'pulseEnabled'} = ($in->{'pulseEnabled'}) ? 1 : 0;
    $decoded->{'poles'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'poles'}}; $i0++) {
        $decoded->{'poles'}->[$i0] = $in->{'poles'}->[$i0];
    }
    $decoded->{'pulsesPerKWh'} = $in->{'pulsesPerKWh'};
    return $decoded;
}

1;
