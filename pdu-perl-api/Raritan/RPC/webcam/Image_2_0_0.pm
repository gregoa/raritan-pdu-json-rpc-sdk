# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Webcam.idl.

use strict;

package Raritan::RPC::webcam::Image_2_0_0;

use Raritan::RPC::webcam::ImageMetaData;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'meta'} = Raritan::RPC::webcam::ImageMetaData::encode($in->{'meta'});
    $encoded->{'data'} = "$in->{'data'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'meta'} = Raritan::RPC::webcam::ImageMetaData::decode($agent, $in->{'meta'});
    $decoded->{'data'} = $in->{'data'};
    return $decoded;
}

1;
