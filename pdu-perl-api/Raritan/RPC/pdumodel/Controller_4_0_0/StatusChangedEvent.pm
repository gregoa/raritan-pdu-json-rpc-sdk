# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Controller.idl.

use strict;

package Raritan::RPC::pdumodel::Controller_4_0_0::StatusChangedEvent;

use constant typeId => "pdumodel.Controller_4_0_0.StatusChangedEvent:1.0.0";
use Raritan::RPC::idl::Event;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'oldStatus'} = $in->{'oldStatus'};
    $encoded->{'newStatus'} = $in->{'newStatus'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'oldStatus'} = $in->{'oldStatus'};
    $decoded->{'newStatus'} = $in->{'newStatus'};
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('pdumodel.Controller_4_0_0.StatusChangedEvent', 1, 0, 0, 'Raritan::RPC::pdumodel::Controller_4_0_0::StatusChangedEvent');
1;
