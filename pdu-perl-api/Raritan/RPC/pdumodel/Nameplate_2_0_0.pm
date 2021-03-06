# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Nameplate.idl.

use strict;

package Raritan::RPC::pdumodel::Nameplate_2_0_0;

use Raritan::RPC::pdumodel::Nameplate_2_0_0::Rating;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'manufacturer'} = "$in->{'manufacturer'}";
    $encoded->{'brand'} = "$in->{'brand'}";
    $encoded->{'model'} = "$in->{'model'}";
    $encoded->{'partNumber'} = "$in->{'partNumber'}";
    $encoded->{'serialNumber'} = "$in->{'serialNumber'}";
    $encoded->{'rating'} = Raritan::RPC::pdumodel::Nameplate_2_0_0::Rating::encode($in->{'rating'});
    $encoded->{'imageFileURL'} = "$in->{'imageFileURL'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'manufacturer'} = $in->{'manufacturer'};
    $decoded->{'brand'} = $in->{'brand'};
    $decoded->{'model'} = $in->{'model'};
    $decoded->{'partNumber'} = $in->{'partNumber'};
    $decoded->{'serialNumber'} = $in->{'serialNumber'};
    $decoded->{'rating'} = Raritan::RPC::pdumodel::Nameplate_2_0_0::Rating::decode($agent, $in->{'rating'});
    $decoded->{'imageFileURL'} = $in->{'imageFileURL'};
    return $decoded;
}

1;
