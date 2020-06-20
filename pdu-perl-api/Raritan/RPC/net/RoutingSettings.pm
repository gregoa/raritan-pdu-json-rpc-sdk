# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Net.idl.

use strict;

package Raritan::RPC::net::RoutingSettings;

use Raritan::RPC::net::IpRoutingSettings;
use Raritan::RPC::net::IpRoutingSettings;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'ipv4'} = Raritan::RPC::net::IpRoutingSettings::encode($in->{'ipv4'});
    $encoded->{'ipv6'} = Raritan::RPC::net::IpRoutingSettings::encode($in->{'ipv6'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'ipv4'} = Raritan::RPC::net::IpRoutingSettings::decode($agent, $in->{'ipv4'});
    $decoded->{'ipv6'} = Raritan::RPC::net::IpRoutingSettings::decode($agent, $in->{'ipv6'});
    return $decoded;
}

1;
