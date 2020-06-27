# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PeripheralDeviceManager.idl.

use strict;

package Raritan::RPC::peripheral::DeviceManager_3_0_0::Statistics;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'cSumErrCnt'} = 1 * $in->{'cSumErrCnt'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'cSumErrCnt'} = $in->{'cSumErrCnt'};
    return $decoded;
}

1;
