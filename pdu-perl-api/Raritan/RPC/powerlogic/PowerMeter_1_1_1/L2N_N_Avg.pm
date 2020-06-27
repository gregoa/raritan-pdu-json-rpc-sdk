# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PowerLogicPowerMeter.idl.

use strict;

package Raritan::RPC::powerlogic::PowerMeter_1_1_1::L2N_N_Avg;

use Raritan::RPC::powerlogic::PowerMeter_1_1_1::MinMaxReading;
use Raritan::RPC::powerlogic::PowerMeter_1_1_1::MinMaxReading;
use Raritan::RPC::powerlogic::PowerMeter_1_1_1::MinMaxReading;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'l1'} = Raritan::RPC::powerlogic::PowerMeter_1_1_1::MinMaxReading::encode($in->{'l1'});
    $encoded->{'l2'} = Raritan::RPC::powerlogic::PowerMeter_1_1_1::MinMaxReading::encode($in->{'l2'});
    $encoded->{'l3'} = Raritan::RPC::powerlogic::PowerMeter_1_1_1::MinMaxReading::encode($in->{'l3'});
    $encoded->{'n'} = Raritan::RPC::ObjectCodec::encode($in->{'n'});
    $encoded->{'average'} = Raritan::RPC::ObjectCodec::encode($in->{'average'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'l1'} = Raritan::RPC::powerlogic::PowerMeter_1_1_1::MinMaxReading::decode($agent, $in->{'l1'});
    $decoded->{'l2'} = Raritan::RPC::powerlogic::PowerMeter_1_1_1::MinMaxReading::decode($agent, $in->{'l2'});
    $decoded->{'l3'} = Raritan::RPC::powerlogic::PowerMeter_1_1_1::MinMaxReading::decode($agent, $in->{'l3'});
    $decoded->{'n'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'n'}, 'sensors.NumericSensor');
    $decoded->{'average'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'average'}, 'sensors.NumericSensor');
    return $decoded;
}

1;
