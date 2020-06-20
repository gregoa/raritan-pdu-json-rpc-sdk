# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from SensorLogger.idl.

use strict;

package Raritan::RPC::pdumodel::SensorLogger_2_0_0::LogRow;

use Raritan::RPC::pdumodel::SensorLogger_2_0_0::Record;
use Raritan::RPC::pdumodel::SensorLogger_2_0_0::Record;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'sensorSetTimestamp'} = 1 * $in->{'sensorSetTimestamp'};
    $encoded->{'timestamp'} = 1 * $in->{'timestamp'};
    $encoded->{'sensorRecords'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'sensorRecords'}}; $i0++) {
        $encoded->{'sensorRecords'}->[$i0] = Raritan::RPC::pdumodel::SensorLogger_2_0_0::Record::encode($in->{'sensorRecords'}->[$i0]);
    }
    $encoded->{'extsensRecords'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'extsensRecords'}}; $i0++) {
        $encoded->{'extsensRecords'}->[$i0] = Raritan::RPC::pdumodel::SensorLogger_2_0_0::Record::encode($in->{'extsensRecords'}->[$i0]);
    }
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'sensorSetTimestamp'} = $in->{'sensorSetTimestamp'};
    $decoded->{'timestamp'} = $in->{'timestamp'};
    $decoded->{'sensorRecords'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'sensorRecords'}}; $i0++) {
        $decoded->{'sensorRecords'}->[$i0] = Raritan::RPC::pdumodel::SensorLogger_2_0_0::Record::decode($agent, $in->{'sensorRecords'}->[$i0]);
    }
    $decoded->{'extsensRecords'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'extsensRecords'}}; $i0++) {
        $decoded->{'extsensRecords'}->[$i0] = Raritan::RPC::pdumodel::SensorLogger_2_0_0::Record::decode($agent, $in->{'extsensRecords'}->[$i0]);
    }
    return $decoded;
}

1;