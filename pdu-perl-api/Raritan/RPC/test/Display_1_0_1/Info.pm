# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from TestDisplay.idl.

use strict;

package Raritan::RPC::test::Display_1_0_1::Info;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'type'} = "$in->{'type'}";
    $encoded->{'address'} = "$in->{'address'}";
    $encoded->{'options'} = [];
    foreach my $key0 (keys %{$in->{'options'}}) {
        my $value0 = $in->{'options'}->{$key0};
        my $elem0 = {};
        $elem0->{'key'} = "$key0";
        $elem0->{'value'} = "$value0";
        push(@{$encoded->{'options'}}, $elem0);
    }
    $encoded->{'orientation'} = $in->{'orientation'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'type'} = $in->{'type'};
    $decoded->{'address'} = $in->{'address'};
    $decoded->{'options'} = {};
    for (my $i0 = 0; $i0 <= $#{$in->{'options'}}; $i0++) {
        my $key0 = $in->{'options'}->[$i0]->{'key'};
        my $value0 = $in->{'options'}->[$i0]->{'value'};
        $decoded->{'options'}->{$key0} = $value0;
    }
    $decoded->{'orientation'} = $in->{'orientation'};
    return $decoded;
}

1;
