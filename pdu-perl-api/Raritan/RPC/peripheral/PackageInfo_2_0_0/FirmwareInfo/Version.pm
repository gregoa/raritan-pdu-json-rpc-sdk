# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PeripheralDevicePackage.idl.

use strict;

package Raritan::RPC::peripheral::PackageInfo_2_0_0::FirmwareInfo::Version;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'majorNumber'} = 1 * $in->{'majorNumber'};
    $encoded->{'minorNumber'} = 1 * $in->{'minorNumber'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'majorNumber'} = $in->{'majorNumber'};
    $decoded->{'minorNumber'} = $in->{'minorNumber'};
    return $decoded;
}

1;
