# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Lhx.idl.

use strict;

package Raritan::RPC::lhxmodel::Lhx_3_2_4::SettingsChangedEvent;

use constant typeId => "lhxmodel.Lhx_3_2_4.SettingsChangedEvent:1.0.0";
use Raritan::RPC::lhxmodel::Lhx_3_2_4::Settings;
use Raritan::RPC::lhxmodel::Lhx_3_2_4::Settings;
use Raritan::RPC::event::UserEvent;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::event::UserEvent::encode($in);
    $encoded->{'oldSettings'} = Raritan::RPC::lhxmodel::Lhx_3_2_4::Settings::encode($in->{'oldSettings'});
    $encoded->{'newSettings'} = Raritan::RPC::lhxmodel::Lhx_3_2_4::Settings::encode($in->{'newSettings'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::event::UserEvent::decode($agent, $in);
    $decoded->{'oldSettings'} = Raritan::RPC::lhxmodel::Lhx_3_2_4::Settings::decode($agent, $in->{'oldSettings'});
    $decoded->{'newSettings'} = Raritan::RPC::lhxmodel::Lhx_3_2_4::Settings::decode($agent, $in->{'newSettings'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('lhxmodel.Lhx_3_2_4.SettingsChangedEvent', 1, 0, 0, 'Raritan::RPC::lhxmodel::Lhx_3_2_4::SettingsChangedEvent');
1;
