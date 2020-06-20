# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from ServerMonitor.idl.

use strict;

package Raritan::RPC::servermon::ServerMonitor_2_0_1::ServerPowerControlCompletedEvent;

use constant typeId => "servermon.ServerMonitor_2_0_1.ServerPowerControlCompletedEvent:1.0.0";
use Raritan::RPC::idl::Event;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'id'} = 1 * $in->{'id'};
    $encoded->{'host'} = "$in->{'host'}";
    $encoded->{'result'} = $in->{'result'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'id'} = $in->{'id'};
    $decoded->{'host'} = $in->{'host'};
    $decoded->{'result'} = $in->{'result'};
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('servermon.ServerMonitor_2_0_1.ServerPowerControlCompletedEvent', 1, 0, 0, 'Raritan::RPC::servermon::ServerMonitor_2_0_1::ServerPowerControlCompletedEvent');
1;
