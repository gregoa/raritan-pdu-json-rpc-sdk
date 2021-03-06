# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Security.idl.

use strict;

package Raritan::RPC::security::SSHHostKey;

use Raritan::RPC::security::SSHKeyFingerprint;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'key'} = "$in->{'key'}";
    $encoded->{'type'} = $in->{'type'};
    $encoded->{'fingerprints'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'fingerprints'}}; $i0++) {
        $encoded->{'fingerprints'}->[$i0] = Raritan::RPC::security::SSHKeyFingerprint::encode($in->{'fingerprints'}->[$i0]);
    }
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'key'} = $in->{'key'};
    $decoded->{'type'} = $in->{'type'};
    $decoded->{'fingerprints'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'fingerprints'}}; $i0++) {
        $decoded->{'fingerprints'}->[$i0] = Raritan::RPC::security::SSHKeyFingerprint::decode($agent, $in->{'fingerprints'}->[$i0]);
    }
    return $decoded;
}

1;
