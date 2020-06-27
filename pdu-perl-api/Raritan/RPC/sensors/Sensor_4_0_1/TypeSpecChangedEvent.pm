# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Sensor.idl.

use strict;

package Raritan::RPC::sensors::Sensor_4_0_1::TypeSpecChangedEvent;

use constant typeId => "sensors.Sensor_4_0_1.TypeSpecChangedEvent:1.0.0";
use Raritan::RPC::sensors::Sensor_4_0_1::TypeSpec;
use Raritan::RPC::idl::Event;
use Raritan::RPC::sensors::Sensor_4_0_1::TypeSpec;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'oldTypeSpec'} = Raritan::RPC::sensors::Sensor_4_0_1::TypeSpec::encode($in->{'oldTypeSpec'});
    $encoded->{'newTypeSpec'} = Raritan::RPC::sensors::Sensor_4_0_1::TypeSpec::encode($in->{'newTypeSpec'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'oldTypeSpec'} = Raritan::RPC::sensors::Sensor_4_0_1::TypeSpec::decode($agent, $in->{'oldTypeSpec'});
    $decoded->{'newTypeSpec'} = Raritan::RPC::sensors::Sensor_4_0_1::TypeSpec::decode($agent, $in->{'newTypeSpec'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('sensors.Sensor_4_0_1.TypeSpecChangedEvent', 1, 0, 0, 'Raritan::RPC::sensors::Sensor_4_0_1::TypeSpecChangedEvent');
1;
