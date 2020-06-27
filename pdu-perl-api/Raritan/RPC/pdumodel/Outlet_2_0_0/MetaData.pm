# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Outlet.idl.

use strict;

package Raritan::RPC::pdumodel::Outlet_2_0_0::MetaData;

use Raritan::RPC::pdumodel::Rating;
use Raritan::RPC::pdumodel::Nameplate;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'label'} = "$in->{'label'}";
    $encoded->{'receptacleType'} = "$in->{'receptacleType'}";
    $encoded->{'namePlate'} = Raritan::RPC::pdumodel::Nameplate::encode($in->{'namePlate'});
    $encoded->{'rating'} = Raritan::RPC::pdumodel::Rating::encode($in->{'rating'});
    $encoded->{'isSwitchable'} = ($in->{'isSwitchable'}) ? JSON::true : JSON::false;
    $encoded->{'isLatching'} = ($in->{'isLatching'}) ? JSON::true : JSON::false;
    $encoded->{'maxRelayCycleCnt'} = 1 * $in->{'maxRelayCycleCnt'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'label'} = $in->{'label'};
    $decoded->{'receptacleType'} = $in->{'receptacleType'};
    $decoded->{'namePlate'} = Raritan::RPC::pdumodel::Nameplate::decode($agent, $in->{'namePlate'});
    $decoded->{'rating'} = Raritan::RPC::pdumodel::Rating::decode($agent, $in->{'rating'});
    $decoded->{'isSwitchable'} = ($in->{'isSwitchable'}) ? 1 : 0;
    $decoded->{'isLatching'} = ($in->{'isLatching'}) ? 1 : 0;
    $decoded->{'maxRelayCycleCnt'} = $in->{'maxRelayCycleCnt'};
    return $decoded;
}

1;
