# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AssetStrip.idl.

use strict;

package Raritan::RPC::assetmgrmodel::AssetStrip_2_0_4::TagAddedEvent;

use constant typeId => "assetmgrmodel.AssetStrip_2_0_4.TagAddedEvent:1.0.0";
use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_4::TagEvent;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_4::TagEvent::encode($in);
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_4::TagEvent::decode($agent, $in);
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('assetmgrmodel.AssetStrip_2_0_4.TagAddedEvent', 1, 0, 0, 'Raritan::RPC::assetmgrmodel::AssetStrip_2_0_4::TagAddedEvent');
1;
