# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from CascadeManager.idl.

use strict;

package Raritan::RPC::cascading::CascadeManager::LinkUnitAddedEvent;

use constant typeId => "cascading.CascadeManager.LinkUnitAddedEvent:1.0.0";
use Raritan::RPC::event::UserEvent;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::event::UserEvent::encode($in);
    $encoded->{'linkId'} = 1 * $in->{'linkId'};
    $encoded->{'host'} = "$in->{'host'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::event::UserEvent::decode($agent, $in);
    $decoded->{'linkId'} = $in->{'linkId'};
    $decoded->{'host'} = $in->{'host'};
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('cascading.CascadeManager.LinkUnitAddedEvent', 1, 0, 0, 'Raritan::RPC::cascading::CascadeManager::LinkUnitAddedEvent');
1;
