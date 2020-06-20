# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PowerLogicPowerMeter.idl.

use strict;

package Raritan::RPC::powerlogic::PowerMeter_1_1_0::L2L;

use Raritan::RPC::powerlogic::PowerMeter_1_1_0::MinMaxReading;
use Raritan::RPC::powerlogic::PowerMeter_1_1_0::MinMaxReading;
use Raritan::RPC::powerlogic::PowerMeter_1_1_0::MinMaxReading;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'l1l2'} = Raritan::RPC::powerlogic::PowerMeter_1_1_0::MinMaxReading::encode($in->{'l1l2'});
    $encoded->{'l2l3'} = Raritan::RPC::powerlogic::PowerMeter_1_1_0::MinMaxReading::encode($in->{'l2l3'});
    $encoded->{'l3l1'} = Raritan::RPC::powerlogic::PowerMeter_1_1_0::MinMaxReading::encode($in->{'l3l1'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'l1l2'} = Raritan::RPC::powerlogic::PowerMeter_1_1_0::MinMaxReading::decode($agent, $in->{'l1l2'});
    $decoded->{'l2l3'} = Raritan::RPC::powerlogic::PowerMeter_1_1_0::MinMaxReading::decode($agent, $in->{'l2l3'});
    $decoded->{'l3l1'} = Raritan::RPC::powerlogic::PowerMeter_1_1_0::MinMaxReading::decode($agent, $in->{'l3l1'});
    return $decoded;
}

1;
