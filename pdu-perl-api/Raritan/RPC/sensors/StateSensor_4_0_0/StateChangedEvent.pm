# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from StateSensor.idl.

use strict;

package Raritan::RPC::sensors::StateSensor_4_0_0::StateChangedEvent;

use constant typeId => "sensors.StateSensor_4_0_0.StateChangedEvent:1.0.0";
use Raritan::RPC::idl::Event;
use Raritan::RPC::sensors::StateSensor_4_0_0::State;
use Raritan::RPC::sensors::StateSensor_4_0_0::State;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'oldState'} = Raritan::RPC::sensors::StateSensor_4_0_0::State::encode($in->{'oldState'});
    $encoded->{'newState'} = Raritan::RPC::sensors::StateSensor_4_0_0::State::encode($in->{'newState'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'oldState'} = Raritan::RPC::sensors::StateSensor_4_0_0::State::decode($agent, $in->{'oldState'});
    $decoded->{'newState'} = Raritan::RPC::sensors::StateSensor_4_0_0::State::decode($agent, $in->{'newState'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('sensors.StateSensor_4_0_0.StateChangedEvent', 1, 0, 0, 'Raritan::RPC::sensors::StateSensor_4_0_0::StateChangedEvent');
1;
