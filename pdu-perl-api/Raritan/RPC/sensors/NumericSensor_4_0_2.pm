# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from NumericSensor.idl.

use strict;

package Raritan::RPC::sensors::NumericSensor_4_0_2;

use parent qw(Raritan::RPC::sensors::Sensor_4_0_2);

use constant typeId => "sensors.NumericSensor:4.0.2";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::sensors::NumericSensor_4_0_2::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant THRESHOLD_OUT_OF_RANGE => 1;

use constant THRESHOLD_INVALID => 2;

use constant THRESHOLD_NOT_SUPPORTED => 3;

use Raritan::RPC::sensors::NumericSensor_4_0_2::MetaData;

sub getMetaData($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getMetaData', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::sensors::NumericSensor_4_0_2::MetaData::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::sensors::NumericSensor_4_0_2::Thresholds;

sub getDefaultThresholds($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getDefaultThresholds', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::sensors::NumericSensor_4_0_2::Thresholds::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::sensors::NumericSensor_4_0_2::Thresholds;

sub getThresholds($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getThresholds', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::sensors::NumericSensor_4_0_2::Thresholds::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::sensors::NumericSensor_4_0_2::Thresholds;

sub setThresholds($$) {
    my ($self, $thresh) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'thresh'} = Raritan::RPC::sensors::NumericSensor_4_0_2::Thresholds::encode($thresh);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setThresholds', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::sensors::NumericSensor_4_0_2::Reading;

sub getReading($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getReading', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::sensors::NumericSensor_4_0_2::Reading::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('sensors.NumericSensor', 4, 0, 2, 'Raritan::RPC::sensors::NumericSensor_4_0_2');
1;
