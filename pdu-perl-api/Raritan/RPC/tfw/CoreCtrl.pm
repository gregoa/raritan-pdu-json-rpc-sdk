# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from CoreCtrl.idl.

use strict;

package Raritan::RPC::tfw::CoreCtrl;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "tfw.CoreCtrl:1.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::tfw::CoreCtrl::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}


sub getScanner($$) {
    my ($self, $name) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'name'} = "$name";
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getScanner', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'_ret_'}, 'tfw.ScannerCtrl');
    return $_ret_;
}

sub startAllScanners($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'startAllScanners', $args);
}

sub stopAllScanners($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'stopAllScanners', $args);
}

sub startAllBackWorkers($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'startAllBackWorkers', $args);
}

sub stopAllBackWorkers($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'stopAllBackWorkers', $args);
}

Raritan::RPC::Registry::registerProxyClass('tfw.CoreCtrl', 1, 0, 0, 'Raritan::RPC::tfw::CoreCtrl');
1;
