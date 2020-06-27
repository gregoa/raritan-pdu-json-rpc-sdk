# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PeripheralDeviceSlot.idl.

use strict;

package Raritan::RPC::peripheral::DeviceSlot;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "peripheral.DeviceSlot:1.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::peripheral::DeviceSlot::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant ERR_INVALID_PARAMS => 1;

use constant ERR_NOT_SUPPORTED => 2;

use constant CHANNEL_INVALID => -1;

use Raritan::RPC::peripheral::Device;

sub getDevice($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getDevice', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::ValObjCodec::decode($agent, $rsp->{'_ret_'}, 'peripheral.Device');
    return $_ret_;
}

use Raritan::RPC::peripheral::DeviceID;

sub assign($$) {
    my ($self, $devid) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'devid'} = Raritan::RPC::peripheral::DeviceID::encode($devid);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'assign', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::peripheral::Address;

sub assignAddress($$$) {
    my ($self, $packageClass, $address) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'packageClass'} = "$packageClass";
    $args->{'address'} = Raritan::RPC::peripheral::Address::encode($address);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'assignAddress', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub unassign($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'unassign', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::peripheral::DeviceSlot::Settings;

sub getSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSettings', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::peripheral::DeviceSlot::Settings::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::peripheral::DeviceSlot::Settings;

sub setSettings($$) {
    my ($self, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'settings'} = Raritan::RPC::peripheral::DeviceSlot::Settings::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('peripheral.DeviceSlot', 1, 0, 0, 'Raritan::RPC::peripheral::DeviceSlot');
1;
