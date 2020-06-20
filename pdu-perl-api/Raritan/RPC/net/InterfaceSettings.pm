# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Net.idl.

use strict;

package Raritan::RPC::net::InterfaceSettings;

use Raritan::RPC::net::InterfaceIpSettings;
use Raritan::RPC::net::InterfaceIpSettings;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'enabled'} = ($in->{'enabled'}) ? JSON::true : JSON::false;
    $encoded->{'ipv4'} = Raritan::RPC::net::InterfaceIpSettings::encode($in->{'ipv4'});
    $encoded->{'ipv6'} = Raritan::RPC::net::InterfaceIpSettings::encode($in->{'ipv6'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'enabled'} = ($in->{'enabled'}) ? 1 : 0;
    $decoded->{'ipv4'} = Raritan::RPC::net::InterfaceIpSettings::decode($agent, $in->{'ipv4'});
    $decoded->{'ipv6'} = Raritan::RPC::net::InterfaceIpSettings::decode($agent, $in->{'ipv6'});
    return $decoded;
}

1;