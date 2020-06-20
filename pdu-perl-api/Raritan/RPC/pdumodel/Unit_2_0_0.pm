# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Unit.idl.

use strict;

package Raritan::RPC::pdumodel::Unit_2_0_0;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "pdumodel.Unit:2.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::pdumodel::Unit_2_0_0::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant ERR_INVALID_PARAM => 1;

use Raritan::RPC::pdumodel::Unit_2_0_0::MetaData;

sub getMetaData($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getMetaData', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::pdumodel::Unit_2_0_0::MetaData::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::pdumodel::Unit_2_0_0::Settings;

sub getSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSettings', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::pdumodel::Unit_2_0_0::Settings::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::pdumodel::Unit_2_0_0::Settings;

sub setSettings($$) {
    my ($self, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'settings'} = Raritan::RPC::pdumodel::Unit_2_0_0::Settings::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub identify($$) {
    my ($self, $seconds) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'seconds'} = 1 * $seconds;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'identify', $args);
}

sub muteBuzzer($$) {
    my ($self, $mute) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'mute'} = ($mute) ? JSON::true : JSON::false;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'muteBuzzer', $args);
}


sub getDisplayOrientation($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getDisplayOrientation', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('pdumodel.Unit', 2, 0, 0, 'Raritan::RPC::pdumodel::Unit_2_0_0');
1;