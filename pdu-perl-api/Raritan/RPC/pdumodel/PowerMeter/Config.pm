# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PowerMeter.idl.

use strict;

package Raritan::RPC::pdumodel::PowerMeter::Config;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'powerMeterId'} = 1 * $in->{'powerMeterId'};
    $encoded->{'type'} = $in->{'type'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'powerMeterId'} = $in->{'powerMeterId'};
    $decoded->{'type'} = $in->{'type'};
    return $decoded;
}

1;
