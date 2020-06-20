# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from TransferSwitch.idl.

use strict;

package Raritan::RPC::pdumodel::TransferSwitch_4_0_3::Settings;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'name'} = "$in->{'name'}";
    $encoded->{'preferredSource'} = 1 * $in->{'preferredSource'};
    $encoded->{'autoRetransfer'} = ($in->{'autoRetransfer'}) ? JSON::true : JSON::false;
    $encoded->{'noAutoRetransferIfPhaseFault'} = ($in->{'noAutoRetransferIfPhaseFault'}) ? JSON::true : JSON::false;
    $encoded->{'autoRetransferWaitTime'} = 1 * $in->{'autoRetransferWaitTime'};
    $encoded->{'manualTransferEnabled'} = ($in->{'manualTransferEnabled'}) ? JSON::true : JSON::false;
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'name'} = $in->{'name'};
    $decoded->{'preferredSource'} = $in->{'preferredSource'};
    $decoded->{'autoRetransfer'} = ($in->{'autoRetransfer'}) ? 1 : 0;
    $decoded->{'noAutoRetransferIfPhaseFault'} = ($in->{'noAutoRetransferIfPhaseFault'}) ? 1 : 0;
    $decoded->{'autoRetransferWaitTime'} = $in->{'autoRetransferWaitTime'};
    $decoded->{'manualTransferEnabled'} = ($in->{'manualTransferEnabled'}) ? 1 : 0;
    return $decoded;
}

1;