# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from GsmModem.idl.

use strict;

package Raritan::RPC::serial::GsmModem;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "serial.GsmModem:1.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::serial::GsmModem::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant SUCCESS => 0;

use constant ERR_INVALID_VALUE => 1;

use constant ERR_WRONG_PIN => 2;

use constant ERR_SMS_SEND_FAILED => 3;

use constant ERR_COMMUNICATION_FAILURE => 4;

use Raritan::RPC::serial::GsmModem::Settings;

sub getSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSettings', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::serial::GsmModem::Settings::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::serial::GsmModem::Settings;

sub setSettings($$) {
    my ($self, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'settings'} = Raritan::RPC::serial::GsmModem::Settings::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub sendSms($$$) {
    my ($self, $recipient, $text) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'recipient'} = "$recipient";
    $args->{'text'} = "$text";
    my $rsp = $agent->json_rpc($self->{'rid'}, 'sendSms', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::serial::GsmModem::Settings;

sub sendTestSms($$$) {
    my ($self, $recipient, $testSettings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'recipient'} = "$recipient";
    $args->{'testSettings'} = Raritan::RPC::serial::GsmModem::Settings::encode($testSettings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'sendTestSms', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::serial::GsmModem::Information;

sub getInformation($$) {
    my ($self, $info) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getInformation', $args);
    $$info = Raritan::RPC::serial::GsmModem::Information::decode($agent, $rsp->{'info'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::serial::GsmModem::Information;

sub getInformationWithPin($$$) {
    my ($self, $pin, $info) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'pin'} = "$pin";
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getInformationWithPin', $args);
    $$info = Raritan::RPC::serial::GsmModem::Information::decode($agent, $rsp->{'info'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('serial.GsmModem', 1, 0, 0, 'Raritan::RPC::serial::GsmModem');
1;
