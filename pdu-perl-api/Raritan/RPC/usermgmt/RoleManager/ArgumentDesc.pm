# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from RoleManager.idl.

use strict;

package Raritan::RPC::usermgmt::RoleManager::ArgumentDesc;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'name'} = "$in->{'name'}";
    $encoded->{'desc'} = "$in->{'desc'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'name'} = $in->{'name'};
    $decoded->{'desc'} = $in->{'desc'};
    return $decoded;
}

1;
