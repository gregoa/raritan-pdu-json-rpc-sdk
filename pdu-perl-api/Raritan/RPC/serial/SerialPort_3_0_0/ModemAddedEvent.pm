# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from SerialPort.idl.

use strict;

package Raritan::RPC::serial::SerialPort_3_0_0::ModemAddedEvent;

use constant typeId => "serial.SerialPort_3_0_0.ModemAddedEvent:1.0.0";
use Raritan::RPC::serial::SerialPort_3_0_0::ModemEvent;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::serial::SerialPort_3_0_0::ModemEvent::encode($in);
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::serial::SerialPort_3_0_0::ModemEvent::decode($agent, $in);
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('serial.SerialPort_3_0_0.ModemAddedEvent', 1, 0, 0, 'Raritan::RPC::serial::SerialPort_3_0_0::ModemAddedEvent');
1;
