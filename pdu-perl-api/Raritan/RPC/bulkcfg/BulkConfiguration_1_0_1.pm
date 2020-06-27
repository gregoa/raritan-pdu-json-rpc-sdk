# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from BulkConfiguration.idl.

use strict;

package Raritan::RPC::bulkcfg::BulkConfiguration_1_0_1;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "bulkcfg.BulkConfiguration:1.0.1";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::bulkcfg::BulkConfiguration_1_0_1::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}


sub getStatus($$$) {
    my ($self, $status, $timeStamp) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getStatus', $args);
    $$status = $rsp->{'status'};
    $$timeStamp = $rsp->{'timeStamp'};
}

use constant SUCCESS => 0;

use constant ERR_FILTER_NAME_UNKNOWN => 1;

use constant ERR_FILTER_TYPE_READONLY => 2;

use constant ERR_PROFILE_ALREADY_EXISTS => 3;

use constant ERR_PROFILE_DOES_NOT_EXIST => 4;

use constant ERR_PROFILE_IS_DEFAULT => 5;

use constant ERR_PROFILE_IS_BUILTIN => 6;

use constant ERR_PROFILE_NAME_TOO_LONG => 7;

use constant ERR_PROFILE_NAME_INVALID => 8;

use constant ERR_PROFILE_TOO_MANY => 9;

use Raritan::RPC::bulkcfg::BulkConfiguration_1_0_1::Filter;

sub getFilters($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getFilters', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::bulkcfg::BulkConfiguration_1_0_1::Filter::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::bulkcfg::BulkConfiguration_1_0_1::FilterProfile;

sub getFilterProfiles($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getFilterProfiles', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::bulkcfg::BulkConfiguration_1_0_1::FilterProfile::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::bulkcfg::BulkConfiguration_1_0_1::FilterProfile;

sub addFilterProfile($$) {
    my ($self, $profile) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'profile'} = Raritan::RPC::bulkcfg::BulkConfiguration_1_0_1::FilterProfile::encode($profile);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'addFilterProfile', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::bulkcfg::BulkConfiguration_1_0_1::FilterProfile;

sub modifyFilterProfile($$) {
    my ($self, $profile) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'profile'} = Raritan::RPC::bulkcfg::BulkConfiguration_1_0_1::FilterProfile::encode($profile);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'modifyFilterProfile', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub deleteFilterProfile($$) {
    my ($self, $profileName) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'profileName'} = "$profileName";
    my $rsp = $agent->json_rpc($self->{'rid'}, 'deleteFilterProfile', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub getDefaultFilterProfileName($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getDefaultFilterProfileName', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub selectDefaultFilterProfile($$) {
    my ($self, $profileName) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'profileName'} = "$profileName";
    my $rsp = $agent->json_rpc($self->{'rid'}, 'selectDefaultFilterProfile', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('bulkcfg.BulkConfiguration', 1, 0, 1, 'Raritan::RPC::bulkcfg::BulkConfiguration_1_0_1');
1;