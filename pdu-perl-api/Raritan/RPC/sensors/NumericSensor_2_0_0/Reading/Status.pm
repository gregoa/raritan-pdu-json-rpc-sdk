# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from NumericSensor.idl.

use strict;

package Raritan::RPC::sensors::NumericSensor_2_0_0::Reading::Status;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'aboveUpperCritical'} = ($in->{'aboveUpperCritical'}) ? JSON::true : JSON::false;
    $encoded->{'aboveUpperWarning'} = ($in->{'aboveUpperWarning'}) ? JSON::true : JSON::false;
    $encoded->{'belowLowerWarning'} = ($in->{'belowLowerWarning'}) ? JSON::true : JSON::false;
    $encoded->{'belowLowerCritical'} = ($in->{'belowLowerCritical'}) ? JSON::true : JSON::false;
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'aboveUpperCritical'} = ($in->{'aboveUpperCritical'}) ? 1 : 0;
    $decoded->{'aboveUpperWarning'} = ($in->{'aboveUpperWarning'}) ? 1 : 0;
    $decoded->{'belowLowerWarning'} = ($in->{'belowLowerWarning'}) ? 1 : 0;
    $decoded->{'belowLowerCritical'} = ($in->{'belowLowerCritical'}) ? 1 : 0;
    return $decoded;
}

1;
