# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PeripheralG2Production.idl.

use strict;

package Raritan::RPC::peripheral::G2Production_2_0_0::FirmwareInfo;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'crc'} = 1 * $in->{'crc'};
    $encoded->{'compiler'} = "$in->{'compiler'}";
    $encoded->{'compilerVersion'} = 1 * $in->{'compilerVersion'};
    $encoded->{'compileDate'} = "$in->{'compileDate'}";
    $encoded->{'version'} = 1 * $in->{'version'};
    $encoded->{'subVersion'} = 1 * $in->{'subVersion'};
    $encoded->{'configurationId'} = 1 * $in->{'configurationId'};
    $encoded->{'updateDate'} = "$in->{'updateDate'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'crc'} = $in->{'crc'};
    $decoded->{'compiler'} = $in->{'compiler'};
    $decoded->{'compilerVersion'} = $in->{'compilerVersion'};
    $decoded->{'compileDate'} = $in->{'compileDate'};
    $decoded->{'version'} = $in->{'version'};
    $decoded->{'subVersion'} = $in->{'subVersion'};
    $decoded->{'configurationId'} = $in->{'configurationId'};
    $decoded->{'updateDate'} = $in->{'updateDate'};
    return $decoded;
}

1;
