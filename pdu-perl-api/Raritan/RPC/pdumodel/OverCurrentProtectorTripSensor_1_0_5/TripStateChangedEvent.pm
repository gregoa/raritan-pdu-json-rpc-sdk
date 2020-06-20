# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from OverCurrentProtectorTripSensor.idl.

use strict;

package Raritan::RPC::pdumodel::OverCurrentProtectorTripSensor_1_0_5::TripStateChangedEvent;

use constant typeId => "pdumodel.OverCurrentProtectorTripSensor_1_0_5.TripStateChangedEvent:1.0.0";
use Raritan::RPC::sensors::StateSensor_4_0_3::StateChangedEvent;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::sensors::StateSensor_4_0_3::StateChangedEvent::encode($in);
    $encoded->{'tripCause'} = Raritan::RPC::ObjectCodec::encode($in->{'tripCause'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::sensors::StateSensor_4_0_3::StateChangedEvent::decode($agent, $in);
    $decoded->{'tripCause'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'tripCause'}, 'pdumodel.Outlet');
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('pdumodel.OverCurrentProtectorTripSensor_1_0_5.TripStateChangedEvent', 1, 0, 0, 'Raritan::RPC::pdumodel::OverCurrentProtectorTripSensor_1_0_5::TripStateChangedEvent');
1;
