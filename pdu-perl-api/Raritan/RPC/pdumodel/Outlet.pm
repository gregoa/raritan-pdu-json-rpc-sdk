# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Outlet.idl.

use strict;

package Raritan::RPC::pdumodel::Outlet;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "pdumodel.Outlet:1.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::pdumodel::Outlet::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant ERR_OUTLET_NOT_SWITCHABLE => 1;

use constant ERR_LOAD_SHEDDING_ACTIVE => 2;

use constant ERR_INVALID_PARAM => 1;

use Raritan::RPC::pdumodel::Outlet::MetaData;

sub getMetaData($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getMetaData', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::pdumodel::Outlet::MetaData::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::pdumodel::Outlet::Sensors;

sub getSensors($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSensors', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::pdumodel::Outlet::Sensors::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::pdumodel::Outlet::State;

sub getState($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getState', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::pdumodel::Outlet::State::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}


sub setPowerState($$) {
    my ($self, $pstate) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'pstate'} = $pstate;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setPowerState', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub cyclePowerState($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'cyclePowerState', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::pdumodel::Outlet::Settings;

sub getSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSettings', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::pdumodel::Outlet::Settings::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::pdumodel::Outlet::Settings;

sub setSettings($$) {
    my ($self, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'settings'} = Raritan::RPC::pdumodel::Outlet::Settings::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::pdumodel::Pole;

sub getIOP($$$$) {
    my ($self, $i, $o, $p) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getIOP', $args);
    $$i = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'i'}, 'pdumodel.Inlet');
    $$o = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'o'}, 'pdumodel.OverCurrentProtector');
    $$p = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'p'}}; $i0++) {
        $$p->[$i0] = Raritan::RPC::pdumodel::Pole::decode($agent, $rsp->{'p'}->[$i0]);
    }
}


sub getController($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getController', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'_ret_'}, 'pdumodel.Controller');
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('pdumodel.Outlet', 1, 0, 0, 'Raritan::RPC::pdumodel::Outlet');
1;