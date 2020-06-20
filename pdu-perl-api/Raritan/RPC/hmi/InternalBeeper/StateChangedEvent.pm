# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from InternalBeeper.idl.

use strict;

package Raritan::RPC::hmi::InternalBeeper::StateChangedEvent;

use constant typeId => "hmi.InternalBeeper.StateChangedEvent:1.0.0";
use Raritan::RPC::idl::Event;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'state'} = $in->{'state'};
    $encoded->{'reason'} = "$in->{'reason'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'state'} = $in->{'state'};
    $decoded->{'reason'} = $in->{'reason'};
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('hmi.InternalBeeper.StateChangedEvent', 1, 0, 0, 'Raritan::RPC::hmi::InternalBeeper::StateChangedEvent');
1;
