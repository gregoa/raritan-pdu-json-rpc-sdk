# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from LdapManager.idl.

use strict;

package Raritan::RPC::auth::LdapManager_1_0_1;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "auth.LdapManager:1.0.1";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::auth::LdapManager_1_0_1::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use Raritan::RPC::auth::ldapsrv::ServerSettings;

sub getLdapServers($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getLdapServers', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::auth::ldapsrv::ServerSettings::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use constant ERR_CYCLIC_DEP => 1;

use constant ERR_INVALID_CFG => 2;

use Raritan::RPC::auth::ldapsrv::ServerSettings;

sub setLdapServers($$) {
    my ($self, $serverList) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'serverList'} = [];
    for (my $i0 = 0; $i0 <= $#{$serverList}; $i0++) {
        $args->{'serverList'}->[$i0] = Raritan::RPC::auth::ldapsrv::ServerSettings::encode($serverList->[$i0]);
    }
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setLdapServers', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use constant ERR_SERVER_UNSPECIFIED => 1;

use constant ERR_SERVER_UNREACHABLE => 3;

use constant ERR_AUTHENTICATION_FAILED => 4;

use constant ERR_NO_ROLES => 5;

use constant ERR_NO_KNOWN_ROLES => 6;

use Raritan::RPC::auth::ldapsrv::ServerSettings;

sub testLdapServer($$$$) {
    my ($self, $username, $password, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'username'} = "$username";
    $args->{'password'} = "$password";
    $args->{'settings'} = Raritan::RPC::auth::ldapsrv::ServerSettings::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'testLdapServer', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('auth.LdapManager', 1, 0, 1, 'Raritan::RPC::auth::LdapManager_1_0_1');
1;
