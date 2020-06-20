# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from NumericSensor.idl.

use strict;

package Raritan::RPC::sensors::NumericSensor_4_0_3::Thresholds;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'upperCriticalActive'} = ($in->{'upperCriticalActive'}) ? JSON::true : JSON::false;
    $encoded->{'upperCritical'} = 1 * $in->{'upperCritical'};
    $encoded->{'upperWarningActive'} = ($in->{'upperWarningActive'}) ? JSON::true : JSON::false;
    $encoded->{'upperWarning'} = 1 * $in->{'upperWarning'};
    $encoded->{'lowerWarningActive'} = ($in->{'lowerWarningActive'}) ? JSON::true : JSON::false;
    $encoded->{'lowerWarning'} = 1 * $in->{'lowerWarning'};
    $encoded->{'lowerCriticalActive'} = ($in->{'lowerCriticalActive'}) ? JSON::true : JSON::false;
    $encoded->{'lowerCritical'} = 1 * $in->{'lowerCritical'};
    $encoded->{'assertionTimeout'} = 1 * $in->{'assertionTimeout'};
    $encoded->{'deassertionHysteresis'} = 1 * $in->{'deassertionHysteresis'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'upperCriticalActive'} = ($in->{'upperCriticalActive'}) ? 1 : 0;
    $decoded->{'upperCritical'} = $in->{'upperCritical'};
    $decoded->{'upperWarningActive'} = ($in->{'upperWarningActive'}) ? 1 : 0;
    $decoded->{'upperWarning'} = $in->{'upperWarning'};
    $decoded->{'lowerWarningActive'} = ($in->{'lowerWarningActive'}) ? 1 : 0;
    $decoded->{'lowerWarning'} = $in->{'lowerWarning'};
    $decoded->{'lowerCriticalActive'} = ($in->{'lowerCriticalActive'}) ? 1 : 0;
    $decoded->{'lowerCritical'} = $in->{'lowerCritical'};
    $decoded->{'assertionTimeout'} = $in->{'assertionTimeout'};
    $decoded->{'deassertionHysteresis'} = $in->{'deassertionHysteresis'};
    return $decoded;
}

1;
