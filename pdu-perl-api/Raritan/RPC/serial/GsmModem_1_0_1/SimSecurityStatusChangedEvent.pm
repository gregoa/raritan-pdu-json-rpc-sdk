# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from GsmModem.idl.

use strict;

package Raritan::RPC::serial::GsmModem_1_0_1::SimSecurityStatusChangedEvent;

use constant typeId => "serial.GsmModem_1_0_1.SimSecurityStatusChangedEvent:1.0.0";
use Raritan::RPC::idl::Event;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'newSimStatus'} = $in->{'newSimStatus'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'newSimStatus'} = $in->{'newSimStatus'};
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('serial.GsmModem_1_0_1.SimSecurityStatusChangedEvent', 1, 0, 0, 'Raritan::RPC::serial::GsmModem_1_0_1::SimSecurityStatusChangedEvent');
1;
