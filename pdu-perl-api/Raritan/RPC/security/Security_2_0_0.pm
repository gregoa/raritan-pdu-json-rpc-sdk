# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Security.idl.

use strict;

package Raritan::RPC::security::Security_2_0_0;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "security.Security:2.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::security::Security_2_0_0::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant ERR_INVALID_VALUE => 1;

use Raritan::RPC::security::Security_2_0_0::Settings;

sub getSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSettings', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::security::Security_2_0_0::Settings::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::security::Security_2_0_0::Settings;

sub setSettings($$) {
    my ($self, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'settings'} = Raritan::RPC::security::Security_2_0_0::Settings::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub setHttpRedirSettings($$) {
    my ($self, $http2httpsRedir) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'http2httpsRedir'} = ($http2httpsRedir) ? JSON::true : JSON::false;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setHttpRedirSettings', $args);
}

use Raritan::RPC::security::IpFw_1_0_1;

sub setIpFwSettings($$) {
    my ($self, $ipFw) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'ipFw'} = Raritan::RPC::security::IpFw_1_0_1::encode($ipFw);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setIpFwSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::security::IpFw_1_0_1;

sub setIpV6FwSettings($$) {
    my ($self, $ipV6Fw) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'ipV6Fw'} = Raritan::RPC::security::IpFw_1_0_1::encode($ipV6Fw);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setIpV6FwSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::security::RoleAccessControl;

sub setRoleAccessControlSettings($$) {
    my ($self, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'settings'} = Raritan::RPC::security::RoleAccessControl::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setRoleAccessControlSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::security::RoleAccessControl;

sub setRoleAccessControlSettingsV6($$) {
    my ($self, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'settings'} = Raritan::RPC::security::RoleAccessControl::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setRoleAccessControlSettingsV6', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub setBlockSettings($$$) {
    my ($self, $blockTimeout, $maxFailedLogins) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'blockTimeout'} = 1 * $blockTimeout;
    $args->{'maxFailedLogins'} = 1 * $maxFailedLogins;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setBlockSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::security::PasswordSettings;

sub setPwSettings($$) {
    my ($self, $pwSettings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'pwSettings'} = Raritan::RPC::security::PasswordSettings::encode($pwSettings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setPwSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub setIdleTimeoutSettings($$) {
    my ($self, $idleTimeout) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'idleTimeout'} = 1 * $idleTimeout;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setIdleTimeoutSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub setSingleLoginLimitation($$) {
    my ($self, $singleLogin) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'singleLogin'} = ($singleLogin) ? JSON::true : JSON::false;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setSingleLoginLimitation', $args);
}

sub getIdleTimeoutSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getIdleTimeoutSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub getHttpRedirSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getHttpRedirSettings', $args);
    my $_ret_;
    $_ret_ = ($rsp->{'_ret_'}) ? 1 : 0;
    return $_ret_;
}

sub getBlockSettings($$$) {
    my ($self, $blockTimeout, $maxFailedLogins) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getBlockSettings', $args);
    $$blockTimeout = $rsp->{'blockTimeout'};
    $$maxFailedLogins = $rsp->{'maxFailedLogins'};
}

use Raritan::RPC::security::SSHSettings;

sub getSSHSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSSHSettings', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::security::SSHSettings::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::security::SSHSettings;

sub setSSHSettings($$) {
    my ($self, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'settings'} = Raritan::RPC::security::SSHSettings::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setSSHSettings', $args);
}

Raritan::RPC::Registry::registerProxyClass('security.Security', 2, 0, 0, 'Raritan::RPC::security::Security_2_0_0');
1;
