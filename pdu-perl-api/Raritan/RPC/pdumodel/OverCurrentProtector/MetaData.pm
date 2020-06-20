# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from OverCurrentProtector.idl.

use strict;

package Raritan::RPC::pdumodel::OverCurrentProtector::MetaData;

use Raritan::RPC::pdumodel::Rating;
use Raritan::RPC::pdumodel::Nameplate;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'label'} = "$in->{'label'}";
    $encoded->{'namePlate'} = Raritan::RPC::pdumodel::Nameplate::encode($in->{'namePlate'});
    $encoded->{'rating'} = Raritan::RPC::pdumodel::Rating::encode($in->{'rating'});
    $encoded->{'type'} = $in->{'type'};
    $encoded->{'maxTripCnt'} = 1 * $in->{'maxTripCnt'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'label'} = $in->{'label'};
    $decoded->{'namePlate'} = Raritan::RPC::pdumodel::Nameplate::decode($agent, $in->{'namePlate'});
    $decoded->{'rating'} = Raritan::RPC::pdumodel::Rating::decode($agent, $in->{'rating'});
    $decoded->{'type'} = $in->{'type'};
    $decoded->{'maxTripCnt'} = $in->{'maxTripCnt'};
    return $decoded;
}

1;
