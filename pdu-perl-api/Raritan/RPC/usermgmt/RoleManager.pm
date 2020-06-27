# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from RoleManager.idl.

use strict;

package Raritan::RPC::usermgmt::RoleManager;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "usermgmt.RoleManager:1.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::usermgmt::RoleManager::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant ERR_ROLE_ALREADY_EXISTS => 1;

use constant ERR_MAX_ROLES_REACHED => 2;

use constant ERR_INVALID_VALUE => 3;

use constant ERR_ROLE_DOESNT_EXIST => 1;

use constant ERR_ROLE_NOT_DELETABLE => 2;

use Raritan::RPC::usermgmt::Role::Info;

sub createRoleFull($$$) {
    my ($self, $name, $info) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'name'} = "$name";
    $args->{'info'} = Raritan::RPC::usermgmt::Role::Info::encode($info);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'createRoleFull', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub deleteRole($$) {
    my ($self, $name) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'name'} = "$name";
    my $rsp = $agent->json_rpc($self->{'rid'}, 'deleteRole', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub getAllRoleNames($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getAllRoleNames', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = $rsp->{'_ret_'}->[$i0];
    }
    return $_ret_;
}

use Raritan::RPC::usermgmt::RoleManager::RoleAccount;

sub getAllRoles($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getAllRoles', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::usermgmt::RoleManager::RoleAccount::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::usermgmt::RoleManager::PrivilegeDesc;

sub getAllPrivileges($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getAllPrivileges', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::usermgmt::RoleManager::PrivilegeDesc::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::usermgmt::RoleManager::Info;

sub getInfo($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getInfo', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::usermgmt::RoleManager::Info::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('usermgmt.RoleManager', 1, 0, 0, 'Raritan::RPC::usermgmt::RoleManager');
1;