# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from LhxParameter.idl.

use strict;

package Raritan::RPC::lhxmodel::Parameter_2_0_0;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "lhxmodel.Parameter:2.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::lhxmodel::Parameter_2_0_0::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant ERR_INVALID_PARAMS => 1;

use constant ERR_READ_ONLY => 2;

use Raritan::RPC::lhxmodel::Parameter_2_0_0::MetaData;

sub getMetaData($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getMetaData', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::lhxmodel::Parameter_2_0_0::MetaData::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::lhxmodel::Parameter_2_0_0::Value;

sub getValue($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getValue', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::lhxmodel::Parameter_2_0_0::Value::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

sub getRawValue($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getRawValue', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub setRawValue($$$) {
    my ($self, $rawValue, $validateRange) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'rawValue'} = 1 * $rawValue;
    $args->{'validateRange'} = ($validateRange) ? JSON::true : JSON::false;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setRawValue', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('lhxmodel.Parameter', 2, 0, 0, 'Raritan::RPC::lhxmodel::Parameter_2_0_0');
1;
