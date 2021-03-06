# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from WebcamChannel.idl.

use strict;

package Raritan::RPC::webcam::Channel_1_0_1;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "webcam.Channel:1.0.1";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::webcam::Channel_1_0_1::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant NO_ERROR => 0;

use constant ERR_NOT_AVAILABLE => 2;

use constant ERR_NO_SUCH_OBJECT => 3;

sub getClientType($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getClientType', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}


sub getWebcam($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getWebcam', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'_ret_'}, 'webcam.Webcam');
    return $_ret_;
}

sub isAvailable($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'isAvailable', $args);
    my $_ret_;
    $_ret_ = ($rsp->{'_ret_'}) ? 1 : 0;
    return $_ret_;
}

sub release($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'release', $args);
}

use Raritan::RPC::webcam::Image_2_0_0;

sub captureImage($$) {
    my ($self, $image) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'captureImage', $args);
    $$image = Raritan::RPC::webcam::Image_2_0_0::decode($agent, $rsp->{'image'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub triggerCapture($$) {
    my ($self, $captureToken) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'triggerCapture', $args);
    $$captureToken = $rsp->{'captureToken'};
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('webcam.Channel', 1, 0, 1, 'Raritan::RPC::webcam::Channel_1_0_1');
1;
