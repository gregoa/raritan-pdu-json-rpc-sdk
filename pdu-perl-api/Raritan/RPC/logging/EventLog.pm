# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from EventLog.idl.

use strict;

package Raritan::RPC::logging::EventLog;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "logging.EventLog:1.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::logging::EventLog::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

sub clear($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'clear', $args);
}

sub getFirstId($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getFirstId', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub getLastId($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getLastId', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::logging::LogEntry;

sub getEntries($$$$$) {
    my ($self, $entries, $refId, $count, $direction) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'refId'} = 1 * $refId;
    $args->{'count'} = 1 * $count;
    $args->{'direction'} = $direction;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getEntries', $args);
    $$entries = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'entries'}}; $i0++) {
        $$entries->[$i0] = Raritan::RPC::logging::LogEntry::decode($agent, $rsp->{'entries'}->[$i0]);
    }
}

Raritan::RPC::Registry::registerProxyClass('logging.EventLog', 1, 0, 0, 'Raritan::RPC::logging::EventLog');
1;
