# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from StorageManager.idl.

use strict;

package Raritan::RPC::webcam::StorageManager_1_0_1::StorageMetaData;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'index'} = 1 * $in->{'index'};
    $encoded->{'webcam'} = Raritan::RPC::ObjectCodec::encode($in->{'webcam'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'index'} = $in->{'index'};
    $decoded->{'webcam'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'webcam'}, 'webcam.Webcam');
    return $decoded;
}

1;
