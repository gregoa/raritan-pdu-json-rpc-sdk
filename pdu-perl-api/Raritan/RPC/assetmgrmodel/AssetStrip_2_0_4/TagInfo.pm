# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AssetStrip.idl.

use strict;

package Raritan::RPC::assetmgrmodel::AssetStrip_2_0_4::TagInfo;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'rackUnitNumber'} = 1 * $in->{'rackUnitNumber'};
    $encoded->{'slotNumber'} = 1 * $in->{'slotNumber'};
    $encoded->{'familyDesc'} = "$in->{'familyDesc'}";
    $encoded->{'rawId'} = "$in->{'rawId'}";
    $encoded->{'programmable'} = ($in->{'programmable'}) ? JSON::true : JSON::false;
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'rackUnitNumber'} = $in->{'rackUnitNumber'};
    $decoded->{'slotNumber'} = $in->{'slotNumber'};
    $decoded->{'familyDesc'} = $in->{'familyDesc'};
    $decoded->{'rawId'} = $in->{'rawId'};
    $decoded->{'programmable'} = ($in->{'programmable'}) ? 1 : 0;
    return $decoded;
}

1;
