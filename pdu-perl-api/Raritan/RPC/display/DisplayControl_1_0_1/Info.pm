# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from DisplayControl.idl.

use strict;

package Raritan::RPC::display::DisplayControl_1_0_1::Info;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'fwAppVersion'} = 1 * $in->{'fwAppVersion'};
    $encoded->{'fwBootVersion'} = 1 * $in->{'fwBootVersion'};
    $encoded->{'orientation'} = 1 * $in->{'orientation'};
    $encoded->{'width'} = 1 * $in->{'width'};
    $encoded->{'height'} = 1 * $in->{'height'};
    $encoded->{'versionAvailable'} = ($in->{'versionAvailable'}) ? JSON::true : JSON::false;
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'fwAppVersion'} = $in->{'fwAppVersion'};
    $decoded->{'fwBootVersion'} = $in->{'fwBootVersion'};
    $decoded->{'orientation'} = $in->{'orientation'};
    $decoded->{'width'} = $in->{'width'};
    $decoded->{'height'} = $in->{'height'};
    $decoded->{'versionAvailable'} = ($in->{'versionAvailable'}) ? 1 : 0;
    return $decoded;
}

1;
