# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from SensorLogger.idl.

use strict;

package Raritan::RPC::sensors::Logger_2_1_6::LoggedSensorsChangedEvent;

use constant typeId => "sensors.Logger_2_1_6.LoggedSensorsChangedEvent:1.0.0";
use Raritan::RPC::event::UserEvent;
use Raritan::RPC::sensors::Logger_2_1_6::SensorSet;
use Raritan::RPC::sensors::Logger_2_1_6::SensorSet;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::event::UserEvent::encode($in);
    $encoded->{'oldSensors'} = Raritan::RPC::sensors::Logger_2_1_6::SensorSet::encode($in->{'oldSensors'});
    $encoded->{'newSensors'} = Raritan::RPC::sensors::Logger_2_1_6::SensorSet::encode($in->{'newSensors'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::event::UserEvent::decode($agent, $in);
    $decoded->{'oldSensors'} = Raritan::RPC::sensors::Logger_2_1_6::SensorSet::decode($agent, $in->{'oldSensors'});
    $decoded->{'newSensors'} = Raritan::RPC::sensors::Logger_2_1_6::SensorSet::decode($agent, $in->{'newSensors'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('sensors.Logger_2_1_6.LoggedSensorsChangedEvent', 1, 0, 0, 'Raritan::RPC::sensors::Logger_2_1_6::LoggedSensorsChangedEvent');
1;
