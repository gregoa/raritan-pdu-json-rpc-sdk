# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from RoleManager.idl.

use strict;

package Raritan::RPC::usermgmt::RoleManager::RoleAccount;

use Raritan::RPC::usermgmt::Role::Info;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'id'} = 1 * $in->{'id'};
    $encoded->{'name'} = "$in->{'name'}";
    $encoded->{'info'} = Raritan::RPC::usermgmt::Role::Info::encode($in->{'info'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'id'} = $in->{'id'};
    $decoded->{'name'} = $in->{'name'};
    $decoded->{'info'} = Raritan::RPC::usermgmt::Role::Info::decode($agent, $in->{'info'});
    return $decoded;
}

1;
