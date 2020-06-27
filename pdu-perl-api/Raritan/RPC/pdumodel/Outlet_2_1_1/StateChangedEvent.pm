# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Outlet.idl.

use strict;

package Raritan::RPC::pdumodel::Outlet_2_1_1::StateChangedEvent;

use constant typeId => "pdumodel.Outlet_2_1_1.StateChangedEvent:1.0.0";
use Raritan::RPC::idl::Event;
use Raritan::RPC::pdumodel::Outlet_2_1_1::State;
use Raritan::RPC::pdumodel::Outlet_2_1_1::State;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'oldState'} = Raritan::RPC::pdumodel::Outlet_2_1_1::State::encode($in->{'oldState'});
    $encoded->{'newState'} = Raritan::RPC::pdumodel::Outlet_2_1_1::State::encode($in->{'newState'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'oldState'} = Raritan::RPC::pdumodel::Outlet_2_1_1::State::decode($agent, $in->{'oldState'});
    $decoded->{'newState'} = Raritan::RPC::pdumodel::Outlet_2_1_1::State::decode($agent, $in->{'newState'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('pdumodel.Outlet_2_1_1.StateChangedEvent', 1, 0, 0, 'Raritan::RPC::pdumodel::Outlet_2_1_1::StateChangedEvent');
1;
