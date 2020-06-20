# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Pdu.idl.

use strict;

package Raritan::RPC::pdumodel::Pdu_2_2_2::Statistic;

use Raritan::RPC::pdumodel::CtrlStatistic;
use Raritan::RPC::pdumodel::CircuitBreakerStatistic;
use Raritan::RPC::pdumodel::OutletStatistic;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'cbStats'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'cbStats'}}; $i0++) {
        $encoded->{'cbStats'}->[$i0] = Raritan::RPC::pdumodel::CircuitBreakerStatistic::encode($in->{'cbStats'}->[$i0]);
    }
    $encoded->{'ctrlStats'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'ctrlStats'}}; $i0++) {
        $encoded->{'ctrlStats'}->[$i0] = Raritan::RPC::pdumodel::CtrlStatistic::encode($in->{'ctrlStats'}->[$i0]);
    }
    $encoded->{'outletStats'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'outletStats'}}; $i0++) {
        $encoded->{'outletStats'}->[$i0] = Raritan::RPC::pdumodel::OutletStatistic::encode($in->{'outletStats'}->[$i0]);
    }
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'cbStats'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'cbStats'}}; $i0++) {
        $decoded->{'cbStats'}->[$i0] = Raritan::RPC::pdumodel::CircuitBreakerStatistic::decode($agent, $in->{'cbStats'}->[$i0]);
    }
    $decoded->{'ctrlStats'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'ctrlStats'}}; $i0++) {
        $decoded->{'ctrlStats'}->[$i0] = Raritan::RPC::pdumodel::CtrlStatistic::decode($agent, $in->{'ctrlStats'}->[$i0]);
    }
    $decoded->{'outletStats'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'outletStats'}}; $i0++) {
        $decoded->{'outletStats'}->[$i0] = Raritan::RPC::pdumodel::OutletStatistic::decode($agent, $in->{'outletStats'}->[$i0]);
    }
    return $decoded;
}

1;
