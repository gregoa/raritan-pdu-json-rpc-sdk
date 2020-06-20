# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from UserManager.idl.

use strict;

package Raritan::RPC::usermgmt::UserManager_1_0_1;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "usermgmt.UserManager:1.0.1";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::usermgmt::UserManager_1_0_1::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant ERR_USER_DOESNT_EXIST => 1;

use constant ERR_USER_NOT_DELETABLE => 2;

use constant ERR_USER_ALREADY_EXISTS => 1;

use constant ERR_MAX_USERS_REACHED => 2;

use constant ERR_PASSWORD_TOO_SHORT_FOR_SNMP => 3;

use constant ERR_INVALID_VALUE => 4;

use constant ERR_INVALID_PASSWORD => 5;

sub getAccountNames($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getAccountNames', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = $rsp->{'_ret_'}->[$i0];
    }
    return $_ret_;
}

sub createAccount($$$) {
    my ($self, $username, $password) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'username'} = "$username";
    $args->{'password'} = "$password";
    my $rsp = $agent->json_rpc($self->{'rid'}, 'createAccount', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub deleteAccount($$) {
    my ($self, $username) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'username'} = "$username";
    my $rsp = $agent->json_rpc($self->{'rid'}, 'deleteAccount', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::usermgmt::Account;

sub getAllAccounts($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getAllAccounts', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::usermgmt::Account::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::usermgmt::UserInfo;

sub createAccountFull($$$$) {
    my ($self, $username, $password, $info) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'username'} = "$username";
    $args->{'password'} = "$password";
    $args->{'info'} = Raritan::RPC::usermgmt::UserInfo::encode($info);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'createAccountFull', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::usermgmt::Account;

sub getAccountsByRole($$) {
    my ($self, $roleName) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'roleName'} = "$roleName";
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getAccountsByRole', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::usermgmt::Account::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::usermgmt::Preferences;

sub getDefaultPreferences($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getDefaultPreferences', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::usermgmt::Preferences::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::usermgmt::Preferences;

sub setDefaultPreferences($$) {
    my ($self, $prefs) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'prefs'} = Raritan::RPC::usermgmt::Preferences::encode($prefs);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setDefaultPreferences', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('usermgmt.UserManager', 1, 0, 1, 'Raritan::RPC::usermgmt::UserManager_1_0_1');
1;
