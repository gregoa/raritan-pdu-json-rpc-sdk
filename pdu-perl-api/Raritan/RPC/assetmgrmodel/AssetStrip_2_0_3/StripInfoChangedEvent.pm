# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AssetStrip.idl.

use strict;

package Raritan::RPC::assetmgrmodel::AssetStrip_2_0_3::StripInfoChangedEvent;

use constant typeId => "assetmgrmodel.AssetStrip_2_0_3.StripInfoChangedEvent:1.0.0";
use Raritan::RPC::idl::Event;
use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_3::StripInfo;
use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_3::StripInfo;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'oldInfo'} = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_3::StripInfo::encode($in->{'oldInfo'});
    $encoded->{'newInfo'} = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_3::StripInfo::encode($in->{'newInfo'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'oldInfo'} = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_3::StripInfo::decode($agent, $in->{'oldInfo'});
    $decoded->{'newInfo'} = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_3::StripInfo::decode($agent, $in->{'newInfo'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('assetmgrmodel.AssetStrip_2_0_3.StripInfoChangedEvent', 1, 0, 0, 'Raritan::RPC::assetmgrmodel::AssetStrip_2_0_3::StripInfoChangedEvent');
1;
