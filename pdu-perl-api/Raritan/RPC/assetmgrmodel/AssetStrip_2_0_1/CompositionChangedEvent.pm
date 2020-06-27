# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AssetStrip.idl.

use strict;

package Raritan::RPC::assetmgrmodel::AssetStrip_2_0_1::CompositionChangedEvent;

use constant typeId => "assetmgrmodel.AssetStrip_2_0_1.CompositionChangedEvent:1.0.0";
use Raritan::RPC::idl::Event;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'oldComponentCount'} = 1 * $in->{'oldComponentCount'};
    $encoded->{'newComponentCount'} = 1 * $in->{'newComponentCount'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'oldComponentCount'} = $in->{'oldComponentCount'};
    $decoded->{'newComponentCount'} = $in->{'newComponentCount'};
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('assetmgrmodel.AssetStrip_2_0_1.CompositionChangedEvent', 1, 0, 0, 'Raritan::RPC::assetmgrmodel::AssetStrip_2_0_1::CompositionChangedEvent');
1;
