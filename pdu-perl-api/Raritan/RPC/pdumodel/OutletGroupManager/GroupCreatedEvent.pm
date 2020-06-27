# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from OutletGroupManager.idl.

use strict;

package Raritan::RPC::pdumodel::OutletGroupManager::GroupCreatedEvent;

use constant typeId => "pdumodel.OutletGroupManager.GroupCreatedEvent:1.0.0";
use Raritan::RPC::event::UserEvent;
use Raritan::RPC::pdumodel::OutletGroup::Settings;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::event::UserEvent::encode($in);
    $encoded->{'id'} = 1 * $in->{'id'};
    $encoded->{'uniqueId'} = 1 * $in->{'uniqueId'};
    $encoded->{'group'} = Raritan::RPC::ObjectCodec::encode($in->{'group'});
    $encoded->{'settings'} = Raritan::RPC::pdumodel::OutletGroup::Settings::encode($in->{'settings'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::event::UserEvent::decode($agent, $in);
    $decoded->{'id'} = $in->{'id'};
    $decoded->{'uniqueId'} = $in->{'uniqueId'};
    $decoded->{'group'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'group'}, 'pdumodel.OutletGroup');
    $decoded->{'settings'} = Raritan::RPC::pdumodel::OutletGroup::Settings::decode($agent, $in->{'settings'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('pdumodel.OutletGroupManager.GroupCreatedEvent', 1, 0, 0, 'Raritan::RPC::pdumodel::OutletGroupManager::GroupCreatedEvent');
1;
