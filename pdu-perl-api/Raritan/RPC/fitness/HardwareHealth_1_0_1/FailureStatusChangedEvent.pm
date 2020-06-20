# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from HardwareHealth.idl.

use strict;

package Raritan::RPC::fitness::HardwareHealth_1_0_1::FailureStatusChangedEvent;

use constant typeId => "fitness.HardwareHealth_1_0_1.FailureStatusChangedEvent:1.0.0";
use Raritan::RPC::idl::Event;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'componentId'} = "$in->{'componentId'}";
    $encoded->{'failureType'} = 1 * $in->{'failureType'};
    $encoded->{'isAsserted'} = ($in->{'isAsserted'}) ? JSON::true : JSON::false;
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'componentId'} = $in->{'componentId'};
    $decoded->{'failureType'} = $in->{'failureType'};
    $decoded->{'isAsserted'} = ($in->{'isAsserted'}) ? 1 : 0;
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('fitness.HardwareHealth_1_0_1.FailureStatusChangedEvent', 1, 0, 0, 'Raritan::RPC::fitness::HardwareHealth_1_0_1::FailureStatusChangedEvent');
1;