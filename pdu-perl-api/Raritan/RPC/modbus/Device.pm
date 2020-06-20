# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from ModbusDevice.idl.

use strict;

package Raritan::RPC::modbus::Device;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "modbus.Device:1.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::modbus::Device::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use Raritan::RPC::modbus::Device::DeviceID;

sub readDeviceIdentification($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'readDeviceIdentification', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::modbus::Device::DeviceID::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('modbus.Device', 1, 0, 0, 'Raritan::RPC::modbus::Device');
1;