# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from TransferSwitch.idl.

use strict;

package Raritan::RPC::pdumodel::TransferSwitch_4_0_0::WaveformSample;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'voltage'} = 1 * $in->{'voltage'};
    $encoded->{'current'} = 1 * $in->{'current'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'voltage'} = $in->{'voltage'};
    $decoded->{'current'} = $in->{'current'};
    return $decoded;
}

1;
