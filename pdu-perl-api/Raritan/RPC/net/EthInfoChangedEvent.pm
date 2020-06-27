# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Net.idl.

use strict;

package Raritan::RPC::net::EthInfoChangedEvent;

use constant typeId => "net.EthInfoChangedEvent:1.0.0";
use Raritan::RPC::net::EthInfo;
use Raritan::RPC::idl::Event;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'ifName'} = "$in->{'ifName'}";
    $encoded->{'ethInfo'} = Raritan::RPC::net::EthInfo::encode($in->{'ethInfo'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'ifName'} = $in->{'ifName'};
    $decoded->{'ethInfo'} = Raritan::RPC::net::EthInfo::decode($agent, $in->{'ethInfo'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('net.EthInfoChangedEvent', 1, 0, 0, 'Raritan::RPC::net::EthInfoChangedEvent');
1;
