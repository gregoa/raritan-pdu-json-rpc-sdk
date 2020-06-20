# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AlertedSensorManager.idl.

use strict;

package Raritan::RPC::sensors::AlertedSensorManager::MonitoredSensorsChangedEvent;

use constant typeId => "sensors.AlertedSensorManager.MonitoredSensorsChangedEvent:1.0.0";
use Raritan::RPC::sensors::AlertedSensorManager::SensorCounts;
use Raritan::RPC::idl::Event;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'counts'} = Raritan::RPC::sensors::AlertedSensorManager::SensorCounts::encode($in->{'counts'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'counts'} = Raritan::RPC::sensors::AlertedSensorManager::SensorCounts::decode($agent, $in->{'counts'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('sensors.AlertedSensorManager.MonitoredSensorsChangedEvent', 1, 0, 0, 'Raritan::RPC::sensors::AlertedSensorManager::MonitoredSensorsChangedEvent');
1;
