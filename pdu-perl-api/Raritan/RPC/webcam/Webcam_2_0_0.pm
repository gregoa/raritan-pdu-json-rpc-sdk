# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Webcam.idl.

use strict;

package Raritan::RPC::webcam::Webcam_2_0_0;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "webcam.Webcam:2.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::webcam::Webcam_2_0_0::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use Raritan::RPC::webcam::Information_2_0_0;

sub getInformation($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getInformation', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::webcam::Information_2_0_0::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::webcam::Settings_2_0_0;

sub getSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSettings', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::webcam::Settings_2_0_0::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::webcam::Settings_2_0_0;

sub setSettings($$) {
    my ($self, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'settings'} = Raritan::RPC::webcam::Settings_2_0_0::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::webcam::Controls;

sub setControls($$) {
    my ($self, $controls) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'controls'} = Raritan::RPC::webcam::Controls::encode($controls);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setControls', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::webcam::Controls;

sub getControlDefaults($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getControlDefaults', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::webcam::Controls::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('webcam.Webcam', 2, 0, 0, 'Raritan::RPC::webcam::Webcam_2_0_0');
1;
