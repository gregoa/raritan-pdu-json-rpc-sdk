# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Snmp.idl.

use strict;

package Raritan::RPC::devsettings::Snmp_1_0_1::Configuration;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'v2enable'} = ($in->{'v2enable'}) ? JSON::true : JSON::false;
    $encoded->{'v3enable'} = ($in->{'v3enable'}) ? JSON::true : JSON::false;
    $encoded->{'readComm'} = "$in->{'readComm'}";
    $encoded->{'writeComm'} = "$in->{'writeComm'}";
    $encoded->{'sysContact'} = "$in->{'sysContact'}";
    $encoded->{'sysName'} = "$in->{'sysName'}";
    $encoded->{'sysLocation'} = "$in->{'sysLocation'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'v2enable'} = ($in->{'v2enable'}) ? 1 : 0;
    $decoded->{'v3enable'} = ($in->{'v3enable'}) ? 1 : 0;
    $decoded->{'readComm'} = $in->{'readComm'};
    $decoded->{'writeComm'} = $in->{'writeComm'};
    $decoded->{'sysContact'} = $in->{'sysContact'};
    $decoded->{'sysName'} = $in->{'sysName'};
    $decoded->{'sysLocation'} = $in->{'sysLocation'};
    return $decoded;
}

1;
