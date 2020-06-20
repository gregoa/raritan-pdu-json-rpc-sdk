# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from LuaService.idl.

use strict;

package Raritan::RPC::luaservice::ScriptState;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'execState'} = $in->{'execState'};
    $encoded->{'exitType'} = $in->{'exitType'};
    $encoded->{'exitStatus'} = 1 * $in->{'exitStatus'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'execState'} = $in->{'execState'};
    $decoded->{'exitType'} = $in->{'exitType'};
    $decoded->{'exitStatus'} = $in->{'exitStatus'};
    return $decoded;
}

1;