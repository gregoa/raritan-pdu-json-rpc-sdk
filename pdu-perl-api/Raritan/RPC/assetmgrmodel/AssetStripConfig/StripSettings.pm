# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AssetStripConfig.idl.

use strict;

package Raritan::RPC::assetmgrmodel::AssetStripConfig::StripSettings;

use Raritan::RPC::assetmgrmodel::AssetStripConfig::LEDColor;
use Raritan::RPC::assetmgrmodel::AssetStripConfig::LEDColor;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'rackUnitCount'} = 1 * $in->{'rackUnitCount'};
    $encoded->{'name'} = "$in->{'name'}";
    $encoded->{'scanMode'} = $in->{'scanMode'};
    $encoded->{'defaultColorConnected'} = Raritan::RPC::assetmgrmodel::AssetStripConfig::LEDColor::encode($in->{'defaultColorConnected'});
    $encoded->{'defaultColorDisconnected'} = Raritan::RPC::assetmgrmodel::AssetStripConfig::LEDColor::encode($in->{'defaultColorDisconnected'});
    $encoded->{'numberingMode'} = $in->{'numberingMode'};
    $encoded->{'numberingOffset'} = 1 * $in->{'numberingOffset'};
    $encoded->{'orientation'} = $in->{'orientation'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'rackUnitCount'} = $in->{'rackUnitCount'};
    $decoded->{'name'} = $in->{'name'};
    $decoded->{'scanMode'} = $in->{'scanMode'};
    $decoded->{'defaultColorConnected'} = Raritan::RPC::assetmgrmodel::AssetStripConfig::LEDColor::decode($agent, $in->{'defaultColorConnected'});
    $decoded->{'defaultColorDisconnected'} = Raritan::RPC::assetmgrmodel::AssetStripConfig::LEDColor::decode($agent, $in->{'defaultColorDisconnected'});
    $decoded->{'numberingMode'} = $in->{'numberingMode'};
    $decoded->{'numberingOffset'} = $in->{'numberingOffset'};
    $decoded->{'orientation'} = $in->{'orientation'};
    return $decoded;
}

1;
