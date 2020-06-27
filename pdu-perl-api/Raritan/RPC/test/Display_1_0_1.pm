# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from TestDisplay.idl.

use strict;

package Raritan::RPC::test::Display_1_0_1;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "test.Display:1.0.1";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::test::Display_1_0_1::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use Raritan::RPC::test::Display_1_0_1::Info;

sub getInfo($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getInfo', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::test::Display_1_0_1::Info::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

sub testSequence($$) {
    my ($self, $cycleTime_ms) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'cycleTime_ms'} = 1 * $cycleTime_ms;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'testSequence', $args);
}

sub enterTestMode($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'enterTestMode', $args);
}


sub getTestStatus($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getTestStatus', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('test.Display', 1, 0, 1, 'Raritan::RPC::test::Display_1_0_1');
1;
