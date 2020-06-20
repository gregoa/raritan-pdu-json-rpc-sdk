# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from DateTime.idl.

use strict;

package Raritan::RPC::datetime::DateTime_3_0_1::NtpCfg;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'server1'} = "$in->{'server1'}";
    $encoded->{'server2'} = "$in->{'server2'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'server1'} = $in->{'server1'};
    $decoded->{'server2'} = $in->{'server2'};
    return $decoded;
}

1;