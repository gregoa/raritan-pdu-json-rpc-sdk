# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Net.idl.

use strict;

package Raritan::RPC::net::PortForwardingSlavePresenceStateChangedEvent;

use constant typeId => "net.PortForwardingSlavePresenceStateChangedEvent:1.0.0";
use Raritan::RPC::idl::Event;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'slavePresent'} = ($in->{'slavePresent'}) ? JSON::true : JSON::false;
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'slavePresent'} = ($in->{'slavePresent'}) ? 1 : 0;
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('net.PortForwardingSlavePresenceStateChangedEvent', 1, 0, 0, 'Raritan::RPC::net::PortForwardingSlavePresenceStateChangedEvent');
1;
