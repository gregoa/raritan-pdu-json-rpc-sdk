# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Pdu.idl.

use strict;

package Raritan::RPC::pdumodel::Pdu_4_1_2::LoadSheddingModeChangedEvent;

use constant typeId => "pdumodel.Pdu_4_1_2.LoadSheddingModeChangedEvent:1.0.0";
use Raritan::RPC::event::UserEvent;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::event::UserEvent::encode($in);
    $encoded->{'enabled'} = ($in->{'enabled'}) ? JSON::true : JSON::false;
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::event::UserEvent::decode($agent, $in);
    $decoded->{'enabled'} = ($in->{'enabled'}) ? 1 : 0;
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('pdumodel.Pdu_4_1_2.LoadSheddingModeChangedEvent', 1, 0, 0, 'Raritan::RPC::pdumodel::Pdu_4_1_2::LoadSheddingModeChangedEvent');
1;
