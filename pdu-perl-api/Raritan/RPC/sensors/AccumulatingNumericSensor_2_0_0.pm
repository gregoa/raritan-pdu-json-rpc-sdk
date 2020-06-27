# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AccumulatingNumericSensor.idl.

use strict;

package Raritan::RPC::sensors::AccumulatingNumericSensor_2_0_0;

use parent qw(Raritan::RPC::sensors::NumericSensor_4_0_0);

use constant typeId => "sensors.AccumulatingNumericSensor:2.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::sensors::AccumulatingNumericSensor_2_0_0::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

sub resetValue($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'resetValue', $args);
}

Raritan::RPC::Registry::registerProxyClass('sensors.AccumulatingNumericSensor', 2, 0, 0, 'Raritan::RPC::sensors::AccumulatingNumericSensor_2_0_0');
1;
