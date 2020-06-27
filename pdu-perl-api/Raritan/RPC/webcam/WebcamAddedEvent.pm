# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from WebcamManager.idl.

use strict;

package Raritan::RPC::webcam::WebcamAddedEvent;

use constant typeId => "webcam.WebcamAddedEvent:1.0.0";
use Raritan::RPC::webcam::WebcamEvent;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::webcam::WebcamEvent::encode($in);
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::webcam::WebcamEvent::decode($agent, $in);
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('webcam.WebcamAddedEvent', 1, 0, 0, 'Raritan::RPC::webcam::WebcamAddedEvent');
1;
