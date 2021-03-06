# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from sensorpush.idl.

use strict;

package Raritan::RPC::datapush::Sensor;

use Raritan::RPC::sensors::NumericSensor_4_0_3::MetaData;
use Raritan::RPC::datapush::Device;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'device'} = Raritan::RPC::datapush::Device::encode($in->{'device'});
    $encoded->{'id'} = "$in->{'id'}";
    $encoded->{'readingtype'} = 1 * $in->{'readingtype'};
    $encoded->{'metadata'} = Raritan::RPC::sensors::NumericSensor_4_0_3::MetaData::encode($in->{'metadata'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'device'} = Raritan::RPC::datapush::Device::decode($agent, $in->{'device'});
    $decoded->{'id'} = $in->{'id'};
    $decoded->{'readingtype'} = $in->{'readingtype'};
    $decoded->{'metadata'} = Raritan::RPC::sensors::NumericSensor_4_0_3::MetaData::decode($agent, $in->{'metadata'});
    return $decoded;
}

1;
