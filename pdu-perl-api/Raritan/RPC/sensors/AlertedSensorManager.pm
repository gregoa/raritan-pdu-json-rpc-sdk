# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AlertedSensorManager.idl.

use strict;

package Raritan::RPC::sensors::AlertedSensorManager;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "sensors.AlertedSensorManager:1.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::sensors::AlertedSensorManager::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use Raritan::RPC::sensors::AlertedSensorManager::SensorCounts;

sub getSensorCounts($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSensorCounts', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::sensors::AlertedSensorManager::SensorCounts::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::sensors::AlertedSensorManager::SensorData;

sub getAllSensors($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getAllSensors', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::sensors::AlertedSensorManager::SensorData::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::sensors::AlertedSensorManager::SensorData;

sub getAlertedSensors($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getAlertedSensors', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::sensors::AlertedSensorManager::SensorData::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('sensors.AlertedSensorManager', 1, 0, 0, 'Raritan::RPC::sensors::AlertedSensorManager');
1;
