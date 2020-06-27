# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Unit.idl.

use strict;

package Raritan::RPC::pdumodel::Unit_2_0_0::Settings;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'buzzerMuted'} = ($in->{'buzzerMuted'}) ? JSON::true : JSON::false;
    $encoded->{'autoDisplayOrientation'} = ($in->{'autoDisplayOrientation'}) ? JSON::true : JSON::false;
    $encoded->{'displayOrientation'} = $in->{'displayOrientation'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'buzzerMuted'} = ($in->{'buzzerMuted'}) ? 1 : 0;
    $decoded->{'autoDisplayOrientation'} = ($in->{'autoDisplayOrientation'}) ? 1 : 0;
    $decoded->{'displayOrientation'} = $in->{'displayOrientation'};
    return $decoded;
}

1;
