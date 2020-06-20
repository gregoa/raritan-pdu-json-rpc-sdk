# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Emd.idl.

use strict;

package Raritan::RPC::emdmodel::Emd_2_2_7::MetaData;

use Raritan::RPC::pdumodel::Nameplate;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'nameplate'} = Raritan::RPC::pdumodel::Nameplate::encode($in->{'nameplate'});
    $encoded->{'ctrlBoardSerial'} = "$in->{'ctrlBoardSerial'}";
    $encoded->{'hwRevision'} = "$in->{'hwRevision'}";
    $encoded->{'fwRevision'} = "$in->{'fwRevision'}";
    $encoded->{'macAddress'} = "$in->{'macAddress'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'nameplate'} = Raritan::RPC::pdumodel::Nameplate::decode($agent, $in->{'nameplate'});
    $decoded->{'ctrlBoardSerial'} = $in->{'ctrlBoardSerial'};
    $decoded->{'hwRevision'} = $in->{'hwRevision'};
    $decoded->{'fwRevision'} = $in->{'fwRevision'};
    $decoded->{'macAddress'} = $in->{'macAddress'};
    return $decoded;
}

1;
