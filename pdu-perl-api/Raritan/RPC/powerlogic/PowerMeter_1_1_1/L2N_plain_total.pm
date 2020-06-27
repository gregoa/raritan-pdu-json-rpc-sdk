# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PowerLogicPowerMeter.idl.

use strict;

package Raritan::RPC::powerlogic::PowerMeter_1_1_1::L2N_plain_total;

use Raritan::RPC::powerlogic::PowerMeter_1_1_1::MinMaxReading;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'l1'} = Raritan::RPC::ObjectCodec::encode($in->{'l1'});
    $encoded->{'l2'} = Raritan::RPC::ObjectCodec::encode($in->{'l2'});
    $encoded->{'l3'} = Raritan::RPC::ObjectCodec::encode($in->{'l3'});
    $encoded->{'total'} = Raritan::RPC::powerlogic::PowerMeter_1_1_1::MinMaxReading::encode($in->{'total'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'l1'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'l1'}, 'sensors.NumericSensor');
    $decoded->{'l2'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'l2'}, 'sensors.NumericSensor');
    $decoded->{'l3'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'l3'}, 'sensors.NumericSensor');
    $decoded->{'total'} = Raritan::RPC::powerlogic::PowerMeter_1_1_1::MinMaxReading::decode($agent, $in->{'total'});
    return $decoded;
}

1;