# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PeripheralDeviceManager.idl.

use strict;

package Raritan::RPC::peripheral::DeviceManager_2_0_0::PackageAddedEvent;

use constant typeId => "peripheral.DeviceManager_2_0_0.PackageAddedEvent:1.0.0";
use Raritan::RPC::peripheral::DeviceManager_2_0_0::PackageEvent;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::peripheral::DeviceManager_2_0_0::PackageEvent::encode($in);
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::peripheral::DeviceManager_2_0_0::PackageEvent::decode($agent, $in);
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('peripheral.DeviceManager_2_0_0.PackageAddedEvent', 1, 0, 0, 'Raritan::RPC::peripheral::DeviceManager_2_0_0::PackageAddedEvent');
1;
