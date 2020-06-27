# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Net.idl.

use strict;

package Raritan::RPC::net::WlanSettings_2_0_0;

use Raritan::RPC::net::EapAuthSettings_2_0_0;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'enableHT'} = ($in->{'enableHT'}) ? JSON::true : JSON::false;
    $encoded->{'ssid'} = "$in->{'ssid'}";
    $encoded->{'bssid'} = "$in->{'bssid'}";
    $encoded->{'secProtocol'} = $in->{'secProtocol'};
    $encoded->{'authType'} = $in->{'authType'};
    $encoded->{'psk'} = "$in->{'psk'}";
    $encoded->{'clearPsk'} = ($in->{'clearPsk'}) ? JSON::true : JSON::false;
    $encoded->{'eap'} = Raritan::RPC::net::EapAuthSettings_2_0_0::encode($in->{'eap'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'enableHT'} = ($in->{'enableHT'}) ? 1 : 0;
    $decoded->{'ssid'} = $in->{'ssid'};
    $decoded->{'bssid'} = $in->{'bssid'};
    $decoded->{'secProtocol'} = $in->{'secProtocol'};
    $decoded->{'authType'} = $in->{'authType'};
    $decoded->{'psk'} = $in->{'psk'};
    $decoded->{'clearPsk'} = ($in->{'clearPsk'}) ? 1 : 0;
    $decoded->{'eap'} = Raritan::RPC::net::EapAuthSettings_2_0_0::decode($agent, $in->{'eap'});
    return $decoded;
}

1;
