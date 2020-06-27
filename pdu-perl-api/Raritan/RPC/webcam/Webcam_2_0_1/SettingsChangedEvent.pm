# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Webcam.idl.

use strict;

package Raritan::RPC::webcam::Webcam_2_0_1::SettingsChangedEvent;

use constant typeId => "webcam.Webcam_2_0_1.SettingsChangedEvent:1.0.0";
use Raritan::RPC::webcam::Settings_2_0_0;
use Raritan::RPC::webcam::Settings_2_0_0;
use Raritan::RPC::event::UserEvent;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::event::UserEvent::encode($in);
    $encoded->{'oldSettings'} = Raritan::RPC::webcam::Settings_2_0_0::encode($in->{'oldSettings'});
    $encoded->{'newSettings'} = Raritan::RPC::webcam::Settings_2_0_0::encode($in->{'newSettings'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::event::UserEvent::decode($agent, $in);
    $decoded->{'oldSettings'} = Raritan::RPC::webcam::Settings_2_0_0::decode($agent, $in->{'oldSettings'});
    $decoded->{'newSettings'} = Raritan::RPC::webcam::Settings_2_0_0::decode($agent, $in->{'newSettings'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('webcam.Webcam_2_0_1.SettingsChangedEvent', 1, 0, 0, 'Raritan::RPC::webcam::Webcam_2_0_1::SettingsChangedEvent');
1;
