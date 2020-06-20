# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Outlet.idl.

use strict;

package Raritan::RPC::pdumodel::Outlet_2_1_5::State;

use Raritan::RPC::pdumodel::Outlet_2_1_5::LedState;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'available'} = ($in->{'available'}) ? JSON::true : JSON::false;
    $encoded->{'powerState'} = $in->{'powerState'};
    $encoded->{'switchOnInProgress'} = ($in->{'switchOnInProgress'}) ? JSON::true : JSON::false;
    $encoded->{'cycleInProgress'} = ($in->{'cycleInProgress'}) ? JSON::true : JSON::false;
    $encoded->{'isLoadShed'} = ($in->{'isLoadShed'}) ? JSON::true : JSON::false;
    $encoded->{'ledState'} = Raritan::RPC::pdumodel::Outlet_2_1_5::LedState::encode($in->{'ledState'});
    $encoded->{'lastPowerStateChange'} = 1 * $in->{'lastPowerStateChange'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'available'} = ($in->{'available'}) ? 1 : 0;
    $decoded->{'powerState'} = $in->{'powerState'};
    $decoded->{'switchOnInProgress'} = ($in->{'switchOnInProgress'}) ? 1 : 0;
    $decoded->{'cycleInProgress'} = ($in->{'cycleInProgress'}) ? 1 : 0;
    $decoded->{'isLoadShed'} = ($in->{'isLoadShed'}) ? 1 : 0;
    $decoded->{'ledState'} = Raritan::RPC::pdumodel::Outlet_2_1_5::LedState::decode($agent, $in->{'ledState'});
    $decoded->{'lastPowerStateChange'} = $in->{'lastPowerStateChange'};
    return $decoded;
}

1;
