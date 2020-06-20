# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AssetStripConfig.idl.

use strict;

package Raritan::RPC::assetmgrmodel::AssetStripConfig_1_0_1::RackUnitSettings;

use Raritan::RPC::assetmgrmodel::AssetStripConfig_1_0_1::LEDColor;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'opmode'} = $in->{'opmode'};
    $encoded->{'mode'} = $in->{'mode'};
    $encoded->{'color'} = Raritan::RPC::assetmgrmodel::AssetStripConfig_1_0_1::LEDColor::encode($in->{'color'});
    $encoded->{'name'} = "$in->{'name'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'opmode'} = $in->{'opmode'};
    $decoded->{'mode'} = $in->{'mode'};
    $decoded->{'color'} = Raritan::RPC::assetmgrmodel::AssetStripConfig_1_0_1::LEDColor::decode($agent, $in->{'color'});
    $decoded->{'name'} = $in->{'name'};
    return $decoded;
}

1;
