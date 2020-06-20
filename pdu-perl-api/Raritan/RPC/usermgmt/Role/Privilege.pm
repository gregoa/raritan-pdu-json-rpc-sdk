# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Role.idl.

use strict;

package Raritan::RPC::usermgmt::Role::Privilege;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'name'} = "$in->{'name'}";
    $encoded->{'args'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'args'}}; $i0++) {
        $encoded->{'args'}->[$i0] = "$in->{'args'}->[$i0]";
    }
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'name'} = $in->{'name'};
    $decoded->{'args'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'args'}}; $i0++) {
        $decoded->{'args'}->[$i0] = $in->{'args'}->[$i0];
    }
    return $decoded;
}

1;