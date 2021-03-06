# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from ModbusGatewayMgr.idl.

use strict;

package Raritan::RPC::modbus::GatewayMgr::Settings;

use Raritan::RPC::modbus::GatewayMgr::RtuSettings;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'rtu'} = Raritan::RPC::modbus::GatewayMgr::RtuSettings::encode($in->{'rtu'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'rtu'} = Raritan::RPC::modbus::GatewayMgr::RtuSettings::decode($agent, $in->{'rtu'});
    return $decoded;
}

1;
