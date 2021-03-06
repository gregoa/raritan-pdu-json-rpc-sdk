# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from OverCurrentProtector.idl.

use strict;

package Raritan::RPC::pdumodel::OverCurrentProtector_3_0_4::MetaData;

use Raritan::RPC::pdumodel::Rating_2_0_0;
use Raritan::RPC::pdumodel::Nameplate_2_0_0;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'label'} = "$in->{'label'}";
    $encoded->{'namePlate'} = Raritan::RPC::pdumodel::Nameplate_2_0_0::encode($in->{'namePlate'});
    $encoded->{'rating'} = Raritan::RPC::pdumodel::Rating_2_0_0::encode($in->{'rating'});
    $encoded->{'type'} = $in->{'type'};
    $encoded->{'maxTripCnt'} = 1 * $in->{'maxTripCnt'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'label'} = $in->{'label'};
    $decoded->{'namePlate'} = Raritan::RPC::pdumodel::Nameplate_2_0_0::decode($agent, $in->{'namePlate'});
    $decoded->{'rating'} = Raritan::RPC::pdumodel::Rating_2_0_0::decode($agent, $in->{'rating'});
    $decoded->{'type'} = $in->{'type'};
    $decoded->{'maxTripCnt'} = $in->{'maxTripCnt'};
    return $decoded;
}

1;
