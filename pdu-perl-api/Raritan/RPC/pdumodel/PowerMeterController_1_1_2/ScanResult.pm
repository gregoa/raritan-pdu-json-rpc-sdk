# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PowerMeterController.idl.

use strict;

package Raritan::RPC::pdumodel::PowerMeterController_1_1_2::ScanResult;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'present'} = ($in->{'present'}) ? JSON::true : JSON::false;
    $encoded->{'meterCount'} = 1 * $in->{'meterCount'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'present'} = ($in->{'present'}) ? 1 : 0;
    $decoded->{'meterCount'} = $in->{'meterCount'};
    return $decoded;
}

1;
