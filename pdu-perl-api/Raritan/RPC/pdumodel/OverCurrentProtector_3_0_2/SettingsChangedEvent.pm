# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from OverCurrentProtector.idl.

use strict;

package Raritan::RPC::pdumodel::OverCurrentProtector_3_0_2::SettingsChangedEvent;

use constant typeId => "pdumodel.OverCurrentProtector_3_0_2.SettingsChangedEvent:1.0.0";
use Raritan::RPC::pdumodel::OverCurrentProtector_3_0_2::Settings;
use Raritan::RPC::event::UserEvent;
use Raritan::RPC::pdumodel::OverCurrentProtector_3_0_2::Settings;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::event::UserEvent::encode($in);
    $encoded->{'oldSettings'} = Raritan::RPC::pdumodel::OverCurrentProtector_3_0_2::Settings::encode($in->{'oldSettings'});
    $encoded->{'newSettings'} = Raritan::RPC::pdumodel::OverCurrentProtector_3_0_2::Settings::encode($in->{'newSettings'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::event::UserEvent::decode($agent, $in);
    $decoded->{'oldSettings'} = Raritan::RPC::pdumodel::OverCurrentProtector_3_0_2::Settings::decode($agent, $in->{'oldSettings'});
    $decoded->{'newSettings'} = Raritan::RPC::pdumodel::OverCurrentProtector_3_0_2::Settings::decode($agent, $in->{'newSettings'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('pdumodel.OverCurrentProtector_3_0_2.SettingsChangedEvent', 1, 0, 0, 'Raritan::RPC::pdumodel::OverCurrentProtector_3_0_2::SettingsChangedEvent');
1;
