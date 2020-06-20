# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Net.idl.

use strict;

package Raritan::RPC::net::IpRoutingSettings;

use Raritan::RPC::net::IpRoute;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'defaultGatewayAddr'} = "$in->{'defaultGatewayAddr'}";
    $encoded->{'staticRoutes'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'staticRoutes'}}; $i0++) {
        $encoded->{'staticRoutes'}->[$i0] = Raritan::RPC::net::IpRoute::encode($in->{'staticRoutes'}->[$i0]);
    }
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'defaultGatewayAddr'} = $in->{'defaultGatewayAddr'};
    $decoded->{'staticRoutes'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'staticRoutes'}}; $i0++) {
        $decoded->{'staticRoutes'}->[$i0] = Raritan::RPC::net::IpRoute::decode($agent, $in->{'staticRoutes'}->[$i0]);
    }
    return $decoded;
}

1;
