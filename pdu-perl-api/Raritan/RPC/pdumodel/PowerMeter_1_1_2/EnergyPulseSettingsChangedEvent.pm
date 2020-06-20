# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PowerMeter.idl.

use strict;

package Raritan::RPC::pdumodel::PowerMeter_1_1_2::EnergyPulseSettingsChangedEvent;

use constant typeId => "pdumodel.PowerMeter_1_1_2.EnergyPulseSettingsChangedEvent:1.0.0";
use Raritan::RPC::event::UserEvent;
use Raritan::RPC::pdumodel::PowerMeter_1_1_2::EnergyPulseSettings;
use Raritan::RPC::pdumodel::PowerMeter_1_1_2::EnergyPulseSettings;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::event::UserEvent::encode($in);
    $encoded->{'oldSettings'} = Raritan::RPC::pdumodel::PowerMeter_1_1_2::EnergyPulseSettings::encode($in->{'oldSettings'});
    $encoded->{'newSettings'} = Raritan::RPC::pdumodel::PowerMeter_1_1_2::EnergyPulseSettings::encode($in->{'newSettings'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::event::UserEvent::decode($agent, $in);
    $decoded->{'oldSettings'} = Raritan::RPC::pdumodel::PowerMeter_1_1_2::EnergyPulseSettings::decode($agent, $in->{'oldSettings'});
    $decoded->{'newSettings'} = Raritan::RPC::pdumodel::PowerMeter_1_1_2::EnergyPulseSettings::decode($agent, $in->{'newSettings'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('pdumodel.PowerMeter_1_1_2.EnergyPulseSettingsChangedEvent', 1, 0, 0, 'Raritan::RPC::pdumodel::PowerMeter_1_1_2::EnergyPulseSettingsChangedEvent');
1;
