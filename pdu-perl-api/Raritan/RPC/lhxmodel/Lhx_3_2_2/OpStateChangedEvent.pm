# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Lhx.idl.

use strict;

package Raritan::RPC::lhxmodel::Lhx_3_2_2::OpStateChangedEvent;

use constant typeId => "lhxmodel.Lhx_3_2_2.OpStateChangedEvent:1.0.0";
use Raritan::RPC::idl::Event;
use Raritan::RPC::lhxmodel::Lhx_3_2_2::OpState;
use Raritan::RPC::lhxmodel::Lhx_3_2_2::OpState;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'oldState'} = Raritan::RPC::lhxmodel::Lhx_3_2_2::OpState::encode($in->{'oldState'});
    $encoded->{'newState'} = Raritan::RPC::lhxmodel::Lhx_3_2_2::OpState::encode($in->{'newState'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'oldState'} = Raritan::RPC::lhxmodel::Lhx_3_2_2::OpState::decode($agent, $in->{'oldState'});
    $decoded->{'newState'} = Raritan::RPC::lhxmodel::Lhx_3_2_2::OpState::decode($agent, $in->{'newState'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('lhxmodel.Lhx_3_2_2.OpStateChangedEvent', 1, 0, 0, 'Raritan::RPC::lhxmodel::Lhx_3_2_2::OpStateChangedEvent');
1;
