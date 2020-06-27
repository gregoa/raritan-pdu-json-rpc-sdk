# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Net.idl.

use strict;

package Raritan::RPC::net::EthInfoChangedEvent_1_0_1;

use constant typeId => "net.EthInfoChangedEvent:1.0.1";
use Raritan::RPC::idl::Event;
use Raritan::RPC::net::EthInfo_1_0_1;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'ifName'} = "$in->{'ifName'}";
    $encoded->{'ifLabel'} = "$in->{'ifLabel'}";
    $encoded->{'ethInfo'} = Raritan::RPC::net::EthInfo_1_0_1::encode($in->{'ethInfo'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'ifName'} = $in->{'ifName'};
    $decoded->{'ifLabel'} = $in->{'ifLabel'};
    $decoded->{'ethInfo'} = Raritan::RPC::net::EthInfo_1_0_1::decode($agent, $in->{'ethInfo'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('net.EthInfoChangedEvent', 1, 0, 1, 'Raritan::RPC::net::EthInfoChangedEvent_1_0_1');
1;
