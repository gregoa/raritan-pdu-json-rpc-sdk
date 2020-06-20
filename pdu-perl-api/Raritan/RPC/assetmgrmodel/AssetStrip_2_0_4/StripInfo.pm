# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AssetStrip.idl.

use strict;

package Raritan::RPC::assetmgrmodel::AssetStrip_2_0_4::StripInfo;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'maxMainTagCount'} = 1 * $in->{'maxMainTagCount'};
    $encoded->{'maxBladeTagCount'} = 1 * $in->{'maxBladeTagCount'};
    $encoded->{'mainTagCount'} = 1 * $in->{'mainTagCount'};
    $encoded->{'bladeTagCount'} = 1 * $in->{'bladeTagCount'};
    $encoded->{'bladeOverflow'} = ($in->{'bladeOverflow'}) ? JSON::true : JSON::false;
    $encoded->{'rackUnitCount'} = 1 * $in->{'rackUnitCount'};
    $encoded->{'componentCount'} = 1 * $in->{'componentCount'};
    $encoded->{'cascadeState'} = $in->{'cascadeState'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'maxMainTagCount'} = $in->{'maxMainTagCount'};
    $decoded->{'maxBladeTagCount'} = $in->{'maxBladeTagCount'};
    $decoded->{'mainTagCount'} = $in->{'mainTagCount'};
    $decoded->{'bladeTagCount'} = $in->{'bladeTagCount'};
    $decoded->{'bladeOverflow'} = ($in->{'bladeOverflow'}) ? 1 : 0;
    $decoded->{'rackUnitCount'} = $in->{'rackUnitCount'};
    $decoded->{'componentCount'} = $in->{'componentCount'};
    $decoded->{'cascadeState'} = $in->{'cascadeState'};
    return $decoded;
}

1;
