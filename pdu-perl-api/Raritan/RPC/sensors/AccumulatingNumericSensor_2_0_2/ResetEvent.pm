# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AccumulatingNumericSensor.idl.

use strict;

package Raritan::RPC::sensors::AccumulatingNumericSensor_2_0_2::ResetEvent;

use constant typeId => "sensors.AccumulatingNumericSensor_2_0_2.ResetEvent:1.0.0";
use Raritan::RPC::sensors::NumericSensor_4_0_2::Reading;
use Raritan::RPC::event::UserEvent;
use Raritan::RPC::sensors::NumericSensor_4_0_2::Reading;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::event::UserEvent::encode($in);
    $encoded->{'oldReading'} = Raritan::RPC::sensors::NumericSensor_4_0_2::Reading::encode($in->{'oldReading'});
    $encoded->{'newReading'} = Raritan::RPC::sensors::NumericSensor_4_0_2::Reading::encode($in->{'newReading'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::event::UserEvent::decode($agent, $in);
    $decoded->{'oldReading'} = Raritan::RPC::sensors::NumericSensor_4_0_2::Reading::decode($agent, $in->{'oldReading'});
    $decoded->{'newReading'} = Raritan::RPC::sensors::NumericSensor_4_0_2::Reading::decode($agent, $in->{'newReading'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('sensors.AccumulatingNumericSensor_2_0_2.ResetEvent', 1, 0, 0, 'Raritan::RPC::sensors::AccumulatingNumericSensor_2_0_2::ResetEvent');
1;
