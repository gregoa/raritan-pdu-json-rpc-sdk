# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AssetStrip.idl.

use strict;

package Raritan::RPC::assetmgrmodel::AssetStrip::RackUnitInfo;

use Raritan::RPC::assetmgrmodel::AssetStrip::RackUnitSettings;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'channel'} = 1 * $in->{'channel'};
    $encoded->{'rackUnitPosition'} = 1 * $in->{'rackUnitPosition'};
    $encoded->{'settings'} = Raritan::RPC::assetmgrmodel::AssetStrip::RackUnitSettings::encode($in->{'settings'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'channel'} = $in->{'channel'};
    $decoded->{'rackUnitPosition'} = $in->{'rackUnitPosition'};
    $decoded->{'settings'} = Raritan::RPC::assetmgrmodel::AssetStrip::RackUnitSettings::decode($agent, $in->{'settings'});
    return $decoded;
}

1;