# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Net.idl.

use strict;

package Raritan::RPC::net::WirelessInterfaceSettings;

use Raritan::RPC::net::EapSettings;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'ssid'} = "$in->{'ssid'}";
    $encoded->{'authentication'} = $in->{'authentication'};
    $encoded->{'psk'} = "$in->{'psk'}";
    $encoded->{'eap'} = Raritan::RPC::net::EapSettings::encode($in->{'eap'});
    $encoded->{'bssid'} = "$in->{'bssid'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'ssid'} = $in->{'ssid'};
    $decoded->{'authentication'} = $in->{'authentication'};
    $decoded->{'psk'} = $in->{'psk'};
    $decoded->{'eap'} = Raritan::RPC::net::EapSettings::decode($agent, $in->{'eap'});
    $decoded->{'bssid'} = $in->{'bssid'};
    return $decoded;
}

1;
