# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Pdu.idl.

use strict;

package Raritan::RPC::pdumodel::Pdu_4_1_4::OutletSequenceStateChangedEvent;

use constant typeId => "pdumodel.Pdu_4_1_4.OutletSequenceStateChangedEvent:1.0.0";
use Raritan::RPC::pdumodel::Pdu_4_1_4::OutletSequenceState;
use Raritan::RPC::idl::Event;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'newState'} = Raritan::RPC::pdumodel::Pdu_4_1_4::OutletSequenceState::encode($in->{'newState'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'newState'} = Raritan::RPC::pdumodel::Pdu_4_1_4::OutletSequenceState::decode($agent, $in->{'newState'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('pdumodel.Pdu_4_1_4.OutletSequenceStateChangedEvent', 1, 0, 0, 'Raritan::RPC::pdumodel::Pdu_4_1_4::OutletSequenceStateChangedEvent');
1;
