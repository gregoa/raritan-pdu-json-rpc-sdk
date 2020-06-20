# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from SerialPort.idl.

use strict;

package Raritan::RPC::serial::SerialPort_3_0_1::ModemEvent;

use constant typeId => "serial.SerialPort_3_0_1.ModemEvent:1.0.0";
use Raritan::RPC::idl::Event;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'modem'} = Raritan::RPC::ObjectCodec::encode($in->{'modem'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'modem'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'modem'}, 'idl.Object');
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('serial.SerialPort_3_0_1.ModemEvent', 1, 0, 0, 'Raritan::RPC::serial::SerialPort_3_0_1::ModemEvent');
1;
