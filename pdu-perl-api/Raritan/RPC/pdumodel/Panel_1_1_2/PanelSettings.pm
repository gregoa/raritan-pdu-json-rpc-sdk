# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Panel.idl.

use strict;

package Raritan::RPC::pdumodel::Panel_1_1_2::PanelSettings;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'meterCount'} = 1 * $in->{'meterCount'};
    $encoded->{'panelSize'} = 1 * $in->{'panelSize'};
    $encoded->{'columns'} = 1 * $in->{'columns'};
    $encoded->{'labelingScheme'} = $in->{'labelingScheme'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'meterCount'} = $in->{'meterCount'};
    $decoded->{'panelSize'} = $in->{'panelSize'};
    $decoded->{'columns'} = $in->{'columns'};
    $decoded->{'labelingScheme'} = $in->{'labelingScheme'};
    return $decoded;
}

1;
