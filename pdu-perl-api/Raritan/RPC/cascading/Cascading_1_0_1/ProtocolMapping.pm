# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Cascading.idl.

use strict;

package Raritan::RPC::cascading::Cascading_1_0_1::ProtocolMapping;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'appProtoId'} = 1 * $in->{'appProtoId'};
    $encoded->{'appProtoName'} = "$in->{'appProtoName'}";
    $encoded->{'transportProtoName'} = "$in->{'transportProtoName'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'appProtoId'} = $in->{'appProtoId'};
    $decoded->{'appProtoName'} = $in->{'appProtoName'};
    $decoded->{'transportProtoName'} = $in->{'transportProtoName'};
    return $decoded;
}

1;
