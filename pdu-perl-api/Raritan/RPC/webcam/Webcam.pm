# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Webcam.idl.

use strict;

package Raritan::RPC::webcam::Webcam;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "webcam.Webcam:1.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::webcam::Webcam::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use Raritan::RPC::webcam::Information;

sub getInformation($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getInformation', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::webcam::Information::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::webcam::Settings;

sub getSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSettings', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::webcam::Settings::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::webcam::Settings;

sub setSettings($$) {
    my ($self, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'settings'} = Raritan::RPC::webcam::Settings::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::webcam::Image;

sub captureImage($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'captureImage', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::webcam::Image::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

sub triggerCapture($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'triggerCapture', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('webcam.Webcam', 1, 0, 0, 'Raritan::RPC::webcam::Webcam');
1;