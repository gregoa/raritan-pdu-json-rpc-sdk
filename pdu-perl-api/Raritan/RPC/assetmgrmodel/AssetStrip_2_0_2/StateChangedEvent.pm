# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AssetStrip.idl.

use strict;

package Raritan::RPC::assetmgrmodel::AssetStrip_2_0_2::StateChangedEvent;

use constant typeId => "assetmgrmodel.AssetStrip_2_0_2.StateChangedEvent:1.0.0";
use Raritan::RPC::idl::Event;
use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_2::DeviceInfo;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'oldState'} = $in->{'oldState'};
    $encoded->{'newState'} = $in->{'newState'};
    $encoded->{'deviceInfo'} = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_2::DeviceInfo::encode($in->{'deviceInfo'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'oldState'} = $in->{'oldState'};
    $decoded->{'newState'} = $in->{'newState'};
    $decoded->{'deviceInfo'} = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_2::DeviceInfo::decode($agent, $in->{'deviceInfo'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('assetmgrmodel.AssetStrip_2_0_2.StateChangedEvent', 1, 0, 0, 'Raritan::RPC::assetmgrmodel::AssetStrip_2_0_2::StateChangedEvent');
1;
