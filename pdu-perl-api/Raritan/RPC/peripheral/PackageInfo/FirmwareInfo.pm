# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PeripheralDevicePackage.idl.

use strict;

package Raritan::RPC::peripheral::PackageInfo::FirmwareInfo;

use Raritan::RPC::peripheral::PackageInfo::FirmwareInfo::Version;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'compileDate'} = 1 * $in->{'compileDate'};
    $encoded->{'version'} = Raritan::RPC::peripheral::PackageInfo::FirmwareInfo::Version::encode($in->{'version'});
    $encoded->{'updateDate'} = 1 * $in->{'updateDate'};
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'compileDate'} = $in->{'compileDate'};
    $decoded->{'version'} = Raritan::RPC::peripheral::PackageInfo::FirmwareInfo::Version::decode($agent, $in->{'version'});
    $decoded->{'updateDate'} = $in->{'updateDate'};
    return $decoded;
}

1;
