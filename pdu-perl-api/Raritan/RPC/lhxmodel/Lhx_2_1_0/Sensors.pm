# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Lhx.idl.

use strict;

package Raritan::RPC::lhxmodel::Lhx_2_1_0::Sensors;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'airTemp'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'airTemp'}}; $i0++) {
        $encoded->{'airTemp'}->[$i0] = Raritan::RPC::ObjectCodec::encode($in->{'airTemp'}->[$i0]);
    }
    $encoded->{'waterTemp'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'waterTemp'}}; $i0++) {
        $encoded->{'waterTemp'}->[$i0] = Raritan::RPC::ObjectCodec::encode($in->{'waterTemp'}->[$i0]);
    }
    $encoded->{'fanSpeed'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'fanSpeed'}}; $i0++) {
        $encoded->{'fanSpeed'}->[$i0] = Raritan::RPC::ObjectCodec::encode($in->{'fanSpeed'}->[$i0]);
    }
    $encoded->{'doorContact'} = Raritan::RPC::ObjectCodec::encode($in->{'doorContact'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'airTemp'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'airTemp'}}; $i0++) {
        $decoded->{'airTemp'}->[$i0] = Raritan::RPC::ObjectCodec::decode($agent, $in->{'airTemp'}->[$i0], 'lhxmodel.Sensor');
    }
    $decoded->{'waterTemp'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'waterTemp'}}; $i0++) {
        $decoded->{'waterTemp'}->[$i0] = Raritan::RPC::ObjectCodec::decode($agent, $in->{'waterTemp'}->[$i0], 'lhxmodel.Sensor');
    }
    $decoded->{'fanSpeed'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'fanSpeed'}}; $i0++) {
        $decoded->{'fanSpeed'}->[$i0] = Raritan::RPC::ObjectCodec::decode($agent, $in->{'fanSpeed'}->[$i0], 'lhxmodel.Sensor');
    }
    $decoded->{'doorContact'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'doorContact'}, 'lhxmodel.Sensor');
    return $decoded;
}

1;
