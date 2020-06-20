# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Emd.idl.

use strict;

package Raritan::RPC::emdmodel::Emd_2_2_5::SettingsChangedEvent;

use constant typeId => "emdmodel.Emd_2_2_5.SettingsChangedEvent:1.0.0";
use Raritan::RPC::emdmodel::Emd_2_2_5::Settings;
use Raritan::RPC::event::UserEvent;
use Raritan::RPC::emdmodel::Emd_2_2_5::Settings;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::event::UserEvent::encode($in);
    $encoded->{'oldSettings'} = Raritan::RPC::emdmodel::Emd_2_2_5::Settings::encode($in->{'oldSettings'});
    $encoded->{'newSettings'} = Raritan::RPC::emdmodel::Emd_2_2_5::Settings::encode($in->{'newSettings'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::event::UserEvent::decode($agent, $in);
    $decoded->{'oldSettings'} = Raritan::RPC::emdmodel::Emd_2_2_5::Settings::decode($agent, $in->{'oldSettings'});
    $decoded->{'newSettings'} = Raritan::RPC::emdmodel::Emd_2_2_5::Settings::decode($agent, $in->{'newSettings'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('emdmodel.Emd_2_2_5.SettingsChangedEvent', 1, 0, 0, 'Raritan::RPC::emdmodel::Emd_2_2_5::SettingsChangedEvent');
1;