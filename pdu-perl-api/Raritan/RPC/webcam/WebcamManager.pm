# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from WebcamManager.idl.

use strict;

package Raritan::RPC::webcam::WebcamManager;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "webcam.WebcamManager:1.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::webcam::WebcamManager::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

sub getWebcamIDs($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getWebcamIDs', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = $rsp->{'_ret_'}->[$i0];
    }
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('webcam.WebcamManager', 1, 0, 0, 'Raritan::RPC::webcam::WebcamManager');
1;
