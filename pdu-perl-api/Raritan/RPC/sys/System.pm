# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from System.idl.

use strict;

package Raritan::RPC::sys::System;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "sys.System:1.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::sys::System::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

sub isDaemonRunning($$) {
    my ($self, $name) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'name'} = "$name";
    my $rsp = $agent->json_rpc($self->{'rid'}, 'isDaemonRunning', $args);
    my $_ret_;
    $_ret_ = ($rsp->{'_ret_'}) ? 1 : 0;
    return $_ret_;
}

sub restartDaemon($$) {
    my ($self, $name) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'name'} = "$name";
    my $rsp = $agent->json_rpc($self->{'rid'}, 'restartDaemon', $args);
}

Raritan::RPC::Registry::registerProxyClass('sys.System', 1, 0, 0, 'Raritan::RPC::sys::System');
1;
