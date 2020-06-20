# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from RoleManager.idl.

use strict;

package Raritan::RPC::usermgmt::RoleManager::PrivilegeDesc;

use Raritan::RPC::usermgmt::RoleManager::ArgumentDesc;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'name'} = "$in->{'name'}";
    $encoded->{'desc'} = "$in->{'desc'}";
    $encoded->{'args'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'args'}}; $i0++) {
        $encoded->{'args'}->[$i0] = Raritan::RPC::usermgmt::RoleManager::ArgumentDesc::encode($in->{'args'}->[$i0]);
    }
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'name'} = $in->{'name'};
    $decoded->{'desc'} = $in->{'desc'};
    $decoded->{'args'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'args'}}; $i0++) {
        $decoded->{'args'}->[$i0] = Raritan::RPC::usermgmt::RoleManager::ArgumentDesc::decode($agent, $in->{'args'}->[$i0]);
    }
    return $decoded;
}

1;
