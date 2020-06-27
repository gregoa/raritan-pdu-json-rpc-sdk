# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from OverCurrentProtector.idl.

use strict;

package Raritan::RPC::pdumodel::OverCurrentProtector_1_2_2::Sensors;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'trip'} = Raritan::RPC::ObjectCodec::encode($in->{'trip'});
    $encoded->{'current'} = Raritan::RPC::ObjectCodec::encode($in->{'current'});
    $encoded->{'peakCurrent'} = Raritan::RPC::ObjectCodec::encode($in->{'peakCurrent'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'trip'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'trip'}, 'sensors.StateSensor');
    $decoded->{'current'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'current'}, 'sensors.NumericSensor');
    $decoded->{'peakCurrent'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'peakCurrent'}, 'sensors.NumericSensor');
    return $decoded;
}

1;
