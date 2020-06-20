# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from StorageManager.idl.

use strict;

package Raritan::RPC::webcam::StorageManager_1_0_2::StorageInformation;

use Raritan::RPC::webcam::StorageManager_1_0_2::WebcamStorageInfo;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'status'} = $in->{'status'};
    $encoded->{'capacity'} = 1 * $in->{'capacity'};
    $encoded->{'used'} = 1 * $in->{'used'};
    $encoded->{'webcamStorageInfo'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'webcamStorageInfo'}}; $i0++) {
        $encoded->{'webcamStorageInfo'}->[$i0] = Raritan::RPC::webcam::StorageManager_1_0_2::WebcamStorageInfo::encode($in->{'webcamStorageInfo'}->[$i0]);
    }
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'status'} = $in->{'status'};
    $decoded->{'capacity'} = $in->{'capacity'};
    $decoded->{'used'} = $in->{'used'};
    $decoded->{'webcamStorageInfo'} = [];
    for (my $i0 = 0; $i0 <= $#{$in->{'webcamStorageInfo'}}; $i0++) {
        $decoded->{'webcamStorageInfo'}->[$i0] = Raritan::RPC::webcam::StorageManager_1_0_2::WebcamStorageInfo::decode($agent, $in->{'webcamStorageInfo'}->[$i0]);
    }
    return $decoded;
}

1;
