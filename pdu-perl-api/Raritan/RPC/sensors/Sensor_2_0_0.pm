# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Sensor.idl.

use strict;

package Raritan::RPC::sensors::Sensor_2_0_0;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "sensors.Sensor:2.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::sensors::Sensor_2_0_0::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant ERR_NOT_SUPPORTED => 1;

use Raritan::RPC::sensors::Sensor_2_0_0::TypeSpec;

sub getTypeSpec($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getTypeSpec', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::sensors::Sensor_2_0_0::TypeSpec::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}


sub setType($$$) {
    my ($self, $type, $unit) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'type'} = $type;
    $args->{'unit'} = $unit;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setType', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('sensors.Sensor', 2, 0, 0, 'Raritan::RPC::sensors::Sensor_2_0_0');
1;