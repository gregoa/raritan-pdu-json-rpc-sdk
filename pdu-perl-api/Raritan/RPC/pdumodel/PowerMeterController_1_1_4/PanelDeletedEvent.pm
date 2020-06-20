# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PowerMeterController.idl.

use strict;

package Raritan::RPC::pdumodel::PowerMeterController_1_1_4::PanelDeletedEvent;

use constant typeId => "pdumodel.PowerMeterController_1_1_4.PanelDeletedEvent:1.0.0";
use Raritan::RPC::pdumodel::PowerMeterController_1_1_4::PowerMeterDeletedEvent;
use Raritan::RPC::pdumodel::Panel_1_1_4::PanelSettings;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::pdumodel::PowerMeterController_1_1_4::PowerMeterDeletedEvent::encode($in);
    $encoded->{'panelSettings'} = Raritan::RPC::pdumodel::Panel_1_1_4::PanelSettings::encode($in->{'panelSettings'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::pdumodel::PowerMeterController_1_1_4::PowerMeterDeletedEvent::decode($agent, $in);
    $decoded->{'panelSettings'} = Raritan::RPC::pdumodel::Panel_1_1_4::PanelSettings::decode($agent, $in->{'panelSettings'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('pdumodel.PowerMeterController_1_1_4.PanelDeletedEvent', 1, 0, 0, 'Raritan::RPC::pdumodel::PowerMeterController_1_1_4::PanelDeletedEvent');
1;
