# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PeripheralDeviceManager.idl.

use strict;

package Raritan::RPC::peripheral::DeviceManager_3_0_2::FirmwareUpdateStateChangedEvent;

use constant typeId => "peripheral.DeviceManager_3_0_2.FirmwareUpdateStateChangedEvent:1.0.0";
use Raritan::RPC::idl::Event;
use Raritan::RPC::peripheral::DeviceManager_3_0_2::FirmwareUpdateState;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'newState'} = Raritan::RPC::peripheral::DeviceManager_3_0_2::FirmwareUpdateState::encode($in->{'newState'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'newState'} = Raritan::RPC::peripheral::DeviceManager_3_0_2::FirmwareUpdateState::decode($agent, $in->{'newState'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('peripheral.DeviceManager_3_0_2.FirmwareUpdateStateChangedEvent', 1, 0, 0, 'Raritan::RPC::peripheral::DeviceManager_3_0_2::FirmwareUpdateStateChangedEvent');
1;
