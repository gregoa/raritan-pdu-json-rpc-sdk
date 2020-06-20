# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Firmware.idl.

use strict;

package Raritan::RPC::firmware::FirmwareUpdateStartedEvent;

use constant typeId => "firmware.FirmwareUpdateStartedEvent:1.0.0";
use Raritan::RPC::firmware::FirmwareUpdateEvent;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::firmware::FirmwareUpdateEvent::encode($in);
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::firmware::FirmwareUpdateEvent::decode($agent, $in);
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('firmware.FirmwareUpdateStartedEvent', 1, 0, 0, 'Raritan::RPC::firmware::FirmwareUpdateStartedEvent');
1;
