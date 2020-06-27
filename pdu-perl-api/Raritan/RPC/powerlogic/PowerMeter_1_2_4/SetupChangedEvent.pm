# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PowerLogicPowerMeter.idl.

use strict;

package Raritan::RPC::powerlogic::PowerMeter_1_2_4::SetupChangedEvent;

use constant typeId => "powerlogic.PowerMeter_1_2_4.SetupChangedEvent:1.0.0";
use Raritan::RPC::powerlogic::PowerMeter_1_2_4::Setup;
use Raritan::RPC::idl::Event;
use Raritan::RPC::powerlogic::PowerMeter_1_2_4::Setup;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'oldSetup'} = Raritan::RPC::powerlogic::PowerMeter_1_2_4::Setup::encode($in->{'oldSetup'});
    $encoded->{'newSetup'} = Raritan::RPC::powerlogic::PowerMeter_1_2_4::Setup::encode($in->{'newSetup'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'oldSetup'} = Raritan::RPC::powerlogic::PowerMeter_1_2_4::Setup::decode($agent, $in->{'oldSetup'});
    $decoded->{'newSetup'} = Raritan::RPC::powerlogic::PowerMeter_1_2_4::Setup::decode($agent, $in->{'newSetup'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('powerlogic.PowerMeter_1_2_4.SetupChangedEvent', 1, 0, 0, 'Raritan::RPC::powerlogic::PowerMeter_1_2_4::SetupChangedEvent');
1;
