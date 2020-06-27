# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Ade.idl.

use strict;

package Raritan::RPC::pdumodel::Ade::Sample;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'vrms'} = 1 * $in->{'vrms'};
    $encoded->{'irms'} = 1 * $in->{'irms'};
    $encoded->{'watt'} = 1 * $in->{'watt'};
    $encoded->{'va'} = 1 * $in->{'va'};
    $encoded->{'wh'} = 1 * $in->{'wh'};
    $encoded->{'vah'} = 1 * $in->{'vah'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'vrms'} = $in->{'vrms'};
    $decoded->{'irms'} = $in->{'irms'};
    $decoded->{'watt'} = $in->{'watt'};
    $decoded->{'va'} = $in->{'va'};
    $decoded->{'wh'} = $in->{'wh'};
    $decoded->{'vah'} = $in->{'vah'};
    return $decoded;
}

1;
