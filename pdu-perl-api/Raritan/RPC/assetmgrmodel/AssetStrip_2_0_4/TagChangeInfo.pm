# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AssetStrip.idl.

use strict;

package Raritan::RPC::assetmgrmodel::AssetStrip_2_0_4::TagChangeInfo;

use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_4::RackUnitInfo;
use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_4::TagInfo;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'tag'} = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_4::TagInfo::encode($in->{'tag'});
    $encoded->{'info'} = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_4::RackUnitInfo::encode($in->{'info'});
    $encoded->{'parentBladeTagId'} = "$in->{'parentBladeTagId'}";
    $encoded->{'slotPosition'} = 1 * $in->{'slotPosition'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'tag'} = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_4::TagInfo::decode($agent, $in->{'tag'});
    $decoded->{'info'} = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_4::RackUnitInfo::decode($agent, $in->{'info'});
    $decoded->{'parentBladeTagId'} = $in->{'parentBladeTagId'};
    $decoded->{'slotPosition'} = $in->{'slotPosition'};
    return $decoded;
}

1;
