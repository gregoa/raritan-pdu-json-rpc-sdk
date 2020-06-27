# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from sensorpush.idl.

use strict;

package Raritan::RPC::datapush::Device;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'type'} = $in->{'type'};
    $encoded->{'label'} = "$in->{'label'}";
    $encoded->{'line'} = $in->{'line'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'type'} = $in->{'type'};
    $decoded->{'label'} = $in->{'label'};
    $decoded->{'line'} = $in->{'line'};
    return $decoded;
}

1;
