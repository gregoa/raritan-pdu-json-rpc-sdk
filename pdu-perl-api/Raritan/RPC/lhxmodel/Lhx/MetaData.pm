# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Lhx.idl.

use strict;

package Raritan::RPC::lhxmodel::Lhx::MetaData;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'model'} = "$in->{'model'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'model'} = $in->{'model'};
    return $decoded;
}

1;
