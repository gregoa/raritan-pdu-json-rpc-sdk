# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PeripheralDevicePackage.idl.

use strict;

package Raritan::RPC::peripheral::PackageInfo_2_0_0::HardwareInfo;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'serial'} = "$in->{'serial'}";
    $encoded->{'packageClass'} = "$in->{'packageClass'}";
    $encoded->{'model'} = "$in->{'model'}";
    $encoded->{'minDowngradeVersion'} = 1 * $in->{'minDowngradeVersion'};
    $encoded->{'revision'} = "$in->{'revision'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'serial'} = $in->{'serial'};
    $decoded->{'packageClass'} = $in->{'packageClass'};
    $decoded->{'model'} = $in->{'model'};
    $decoded->{'minDowngradeVersion'} = $in->{'minDowngradeVersion'};
    $decoded->{'revision'} = $in->{'revision'};
    return $decoded;
}

1;
