# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PeripheralDeviceManager.idl.

use strict;

package Raritan::RPC::peripheral::DeviceManager_1_0_3::Settings;

use Raritan::RPC::sensors::NumericSensor_3_0_1::Thresholds;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'zCoordMode'} = $in->{'zCoordMode'};
    $encoded->{'autoManageNewDevices'} = ($in->{'autoManageNewDevices'}) ? JSON::true : JSON::false;
    $encoded->{'deviceAltitude'} = 1 * $in->{'deviceAltitude'};
    $encoded->{'presenceDetectionTimeout'} = 1 * $in->{'presenceDetectionTimeout'};
    $encoded->{'defaultThresholdsMap'} = [];
    foreach my $key0 (keys %{$in->{'defaultThresholdsMap'}}) {
        my $value0 = $in->{'defaultThresholdsMap'}->{$key0};
        my $elem0 = {};
        $elem0->{'key'} = "$key0";
        $elem0->{'value'} = Raritan::RPC::sensors::NumericSensor_3_0_1::Thresholds::encode($value0);
        push(@{$encoded->{'defaultThresholdsMap'}}, $elem0);
    }
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'zCoordMode'} = $in->{'zCoordMode'};
    $decoded->{'autoManageNewDevices'} = ($in->{'autoManageNewDevices'}) ? 1 : 0;
    $decoded->{'deviceAltitude'} = $in->{'deviceAltitude'};
    $decoded->{'presenceDetectionTimeout'} = $in->{'presenceDetectionTimeout'};
    $decoded->{'defaultThresholdsMap'} = {};
    for (my $i0 = 0; $i0 <= $#{$in->{'defaultThresholdsMap'}}; $i0++) {
        my $key0 = $in->{'defaultThresholdsMap'}->[$i0]->{'key'};
        my $value0 = Raritan::RPC::sensors::NumericSensor_3_0_1::Thresholds::decode($agent, $in->{'defaultThresholdsMap'}->[$i0]->{'value'});
        $decoded->{'defaultThresholdsMap'}->{$key0} = $value0;
    }
    return $decoded;
}

1;
