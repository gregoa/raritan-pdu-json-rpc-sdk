# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Net.idl.

use strict;

package Raritan::RPC::net::RoutingSettings_2_0_0;

use Raritan::RPC::net::IpRoutingSettings_2_0_0;
use Raritan::RPC::net::IpRoutingSettings_2_0_0;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'ipv4'} = Raritan::RPC::net::IpRoutingSettings_2_0_0::encode($in->{'ipv4'});
    $encoded->{'ipv6'} = Raritan::RPC::net::IpRoutingSettings_2_0_0::encode($in->{'ipv6'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'ipv4'} = Raritan::RPC::net::IpRoutingSettings_2_0_0::decode($agent, $in->{'ipv4'});
    $decoded->{'ipv6'} = Raritan::RPC::net::IpRoutingSettings_2_0_0::decode($agent, $in->{'ipv6'});
    return $decoded;
}

1;
