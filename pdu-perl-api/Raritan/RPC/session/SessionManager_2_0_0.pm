# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from SessionManager.idl.

use strict;

package Raritan::RPC::session::SessionManager_2_0_0;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "session.SessionManager:2.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::session::SessionManager_2_0_0::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant ERR_ACTIVE_SESSION_EXCLUSIVE_FOR_USER => 1;

use Raritan::RPC::session::Session_2_0_0;

sub newSession($$$) {
    my ($self, $session, $token) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'newSession', $args);
    $$session = Raritan::RPC::session::Session_2_0_0::decode($agent, $rsp->{'session'});
    $$token = $rsp->{'token'};
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::session::Session_2_0_0;

sub getCurrentSession($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getCurrentSession', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::session::Session_2_0_0::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::session::Session_2_0_0;

sub getSessions($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSessions', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::session::Session_2_0_0::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}


sub closeSession($$$) {
    my ($self, $sessionId, $reason) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'sessionId'} = 1 * $sessionId;
    $args->{'reason'} = $reason;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'closeSession', $args);
}


sub closeCurrentSession($$) {
    my ($self, $reason) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'reason'} = $reason;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'closeCurrentSession', $args);
}

sub touchCurrentSession($$) {
    my ($self, $userActivity) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'userActivity'} = ($userActivity) ? JSON::true : JSON::false;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'touchCurrentSession', $args);
}

use Raritan::RPC::session::HistoryEntry;

sub getSessionHistory($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSessionHistory', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::session::HistoryEntry::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('session.SessionManager', 2, 0, 0, 'Raritan::RPC::session::SessionManager_2_0_0');
1;
