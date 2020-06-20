# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PeripheralDeviceManager.idl.

use strict;

package Raritan::RPC::peripheral::DeviceManager_3_0_1;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "peripheral.DeviceManager:3.0.1";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::peripheral::DeviceManager_3_0_1::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant ERR_INVALID_PARAMS => 1;


sub getDeviceSlots($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getDeviceSlots', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'_ret_'}->[$i0], 'peripheral.DeviceSlot');
    }
    return $_ret_;
}


sub getDeviceSlot($$) {
    my ($self, $idx) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'idx'} = 1 * $idx;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getDeviceSlot', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'_ret_'}, 'peripheral.DeviceSlot');
    return $_ret_;
}

use Raritan::RPC::peripheral::Device_3_0_1;

sub getDiscoveredDevices($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getDiscoveredDevices', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::ValObjCodec::decode($agent, $rsp->{'_ret_'}->[$i0], 'peripheral.Device');
    }
    return $_ret_;
}

use Raritan::RPC::peripheral::PackageInfo_2_0_1;

sub getDiscoveredPackageInfos($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getDiscoveredPackageInfos', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::peripheral::PackageInfo_2_0_1::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::peripheral::DeviceManager_3_0_1::Settings;

sub getSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSettings', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::peripheral::DeviceManager_3_0_1::Settings::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::peripheral::DeviceManager_3_0_1::Settings;

sub setSettings($$) {
    my ($self, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'settings'} = Raritan::RPC::peripheral::DeviceManager_3_0_1::Settings::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::peripheral::DeviceManager_3_0_1::MetaData;

sub getMetaData($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getMetaData', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::peripheral::DeviceManager_3_0_1::MetaData::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::peripheral::DeviceManager_3_0_1::DeviceTypeInfo;

sub getDeviceTypeInfos($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getDeviceTypeInfos', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::peripheral::DeviceManager_3_0_1::DeviceTypeInfo::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::peripheral::DeviceManager_3_0_1::FirmwareUpdateState;

sub getFirmwareUpdateState($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getFirmwareUpdateState', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::peripheral::DeviceManager_3_0_1::FirmwareUpdateState::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::peripheral::DeviceManager_3_0_1::Statistics;

sub getStatistics($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getStatistics', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::peripheral::DeviceManager_3_0_1::Statistics::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}


sub getDiscoveredPackages($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getDiscoveredPackages', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'_ret_'}->[$i0], 'peripheral.Package');
    }
    return $_ret_;
}


sub getPortFuse($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getPortFuse', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'_ret_'}, 'portsmodel.PortFuse');
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('peripheral.DeviceManager', 3, 0, 1, 'Raritan::RPC::peripheral::DeviceManager_3_0_1');
1;
