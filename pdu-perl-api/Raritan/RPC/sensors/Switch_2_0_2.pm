# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Switch.idl.

use strict;

package Raritan::RPC::sensors::Switch_2_0_2;

use parent qw(Raritan::RPC::sensors::StateSensor_4_0_1);

use constant typeId => "sensors.Switch:2.0.2";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::sensors::Switch_2_0_2::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant ERR_INVALID_PARAMETER => 1;

use constant ERR_NOT_AVAILABLE => 2;

use constant ERR_PDC_POWER_LIMIT => 3;

sub setState($$) {
    my ($self, $newState) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'newState'} = 1 * $newState;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setState', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('sensors.Switch', 2, 0, 2, 'Raritan::RPC::sensors::Switch_2_0_2');
1;
