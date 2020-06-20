# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PeripheralDeviceSlot.idl.

use strict;

package Raritan::RPC::peripheral::PosElement;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'portType'} = $in->{'portType'};
    $encoded->{'port'} = "$in->{'port'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'portType'} = $in->{'portType'};
    $decoded->{'port'} = $in->{'port'};
    return $decoded;
}

1;
