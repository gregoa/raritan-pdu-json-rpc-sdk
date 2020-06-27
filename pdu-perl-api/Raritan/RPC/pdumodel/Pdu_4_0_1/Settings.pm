# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Pdu.idl.

use strict;

package Raritan::RPC::pdumodel::Pdu_4_0_1::Settings;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'name'} = "$in->{'name'}";
    $encoded->{'startupState'} = $in->{'startupState'};
    $encoded->{'cycleDelay'} = 1 * $in->{'cycleDelay'};
    $encoded->{'inRushGuardDelay'} = 1 * $in->{'inRushGuardDelay'};
    $encoded->{'outletPowerStateSequence'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'outletPowerStateSequence'}}; $i0++) {
        $encoded->{'outletPowerStateSequence'}->[$i0] = 1 * $in->{'outletPowerStateSequence'}->[$i0];
    }
    $encoded->{'powerOnDelay'} = 1 * $in->{'powerOnDelay'};
    $encoded->{'latchingRelays'} = ($in->{'latchingRelays'}) ? JSON::true : JSON::false;
    $encoded->{'energyPulseEnabled'} = ($in->{'energyPulseEnabled'}) ? JSON::true : JSON::false;
    $encoded->{'energyPulsesPerKWh'} = 1 * $in->{'energyPulsesPerKWh'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'name'} = $in->{'name'};
    $decoded->{'startupState'} = $in->{'startupState'};
    $decoded->{'cycleDelay'} = $in->{'cycleDelay'};
    $decoded->{'inRushGuardDelay'} = $in->{'inRushGuardDelay'};
    $decoded->{'outletPowerStateSequence'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'outletPowerStateSequence'}}; $i0++) {
        $decoded->{'outletPowerStateSequence'}->[$i0] = $in->{'outletPowerStateSequence'}->[$i0];
    }
    $decoded->{'powerOnDelay'} = $in->{'powerOnDelay'};
    $decoded->{'latchingRelays'} = ($in->{'latchingRelays'}) ? 1 : 0;
    $decoded->{'energyPulseEnabled'} = ($in->{'energyPulseEnabled'}) ? 1 : 0;
    $decoded->{'energyPulsesPerKWh'} = $in->{'energyPulsesPerKWh'};
    return $decoded;
}

1;
