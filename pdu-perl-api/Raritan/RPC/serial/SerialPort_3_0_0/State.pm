# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from SerialPort.idl.

use strict;

package Raritan::RPC::serial::SerialPort_3_0_0::State;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'state'} = $in->{'state'};
    $encoded->{'deviceName'} = "$in->{'deviceName'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'state'} = $in->{'state'};
    $decoded->{'deviceName'} = $in->{'deviceName'};
    return $decoded;
}

1;
