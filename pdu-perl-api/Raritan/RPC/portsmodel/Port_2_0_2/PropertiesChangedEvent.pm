# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Port.idl.

use strict;

package Raritan::RPC::portsmodel::Port_2_0_2::PropertiesChangedEvent;

use constant typeId => "portsmodel.Port_2_0_2.PropertiesChangedEvent:1.0.0";
use Raritan::RPC::portsmodel::Port_2_0_2::Properties;
use Raritan::RPC::portsmodel::Port_2_0_2::Properties;
use Raritan::RPC::idl::Event;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'oldProperties'} = Raritan::RPC::portsmodel::Port_2_0_2::Properties::encode($in->{'oldProperties'});
    $encoded->{'newProperties'} = Raritan::RPC::portsmodel::Port_2_0_2::Properties::encode($in->{'newProperties'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'oldProperties'} = Raritan::RPC::portsmodel::Port_2_0_2::Properties::decode($agent, $in->{'oldProperties'});
    $decoded->{'newProperties'} = Raritan::RPC::portsmodel::Port_2_0_2::Properties::decode($agent, $in->{'newProperties'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('portsmodel.Port_2_0_2.PropertiesChangedEvent', 1, 0, 0, 'Raritan::RPC::portsmodel::Port_2_0_2::PropertiesChangedEvent');
1;
