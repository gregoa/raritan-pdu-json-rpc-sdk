# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from TransferSwitch.idl.

use strict;

package Raritan::RPC::pdumodel::TransferSwitch_4_0_2;

use parent qw(Raritan::RPC::pdumodel::EDevice);

use constant typeId => "pdumodel.TransferSwitch:4.0.2";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::pdumodel::TransferSwitch_4_0_2::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant ERR_INVALID_PARAM => 1;

use constant ERR_SWITCH_PREVENTED => 2;

use constant ERR_SWITCH_FAILED => 3;

use constant OPERATIONAL_STATE_OFF => 0;

use constant OPERATIONAL_STATE_NORMAL => 1;

use constant OPERATIONAL_STATE_STANDBY => 2;

use constant OPERATIONAL_STATE_NON_REDUNDANT => 3;

use constant SWITCH_FAULT_I1_SHORT => 1;

use constant SWITCH_FAULT_I1_OPEN => 2;

use constant SWITCH_FAULT_I2_SHORT => 4;

use constant SWITCH_FAULT_I2_OPEN => 8;

use Raritan::RPC::pdumodel::TransferSwitch_4_0_2::MetaData;

sub getMetaData($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getMetaData', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::pdumodel::TransferSwitch_4_0_2::MetaData::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::pdumodel::TransferSwitch_4_0_2::Sensors;

sub getSensors($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSensors', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::pdumodel::TransferSwitch_4_0_2::Sensors::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::pdumodel::ThrowPole_2_0_0;

sub getPoles($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getPoles', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::pdumodel::ThrowPole_2_0_0::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::pdumodel::TransferSwitch_4_0_2::Settings;

sub getSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSettings', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::pdumodel::TransferSwitch_4_0_2::Settings::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::pdumodel::TransferSwitch_4_0_2::Settings;

sub setSettings($$) {
    my ($self, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'settings'} = Raritan::RPC::pdumodel::TransferSwitch_4_0_2::Settings::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::pdumodel::TransferSwitch_4_0_2::Statistics;

sub getStatistics($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getStatistics', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::pdumodel::TransferSwitch_4_0_2::Statistics::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

sub transferToSource($$$) {
    my ($self, $source, $faultOverride) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'source'} = 1 * $source;
    $args->{'faultOverride'} = ($faultOverride) ? JSON::true : JSON::false;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'transferToSource', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}


sub getLastTransferReason($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getLastTransferReason', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::pdumodel::TransferSwitch_4_0_2::WaveformSample;

sub getLastTransferWaveform($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getLastTransferWaveform', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::pdumodel::TransferSwitch_4_0_2::WaveformSample::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::pdumodel::TransferSwitch_4_0_2::TransferLogEntry;

sub getTransferLog($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getTransferLog', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::pdumodel::TransferSwitch_4_0_2::TransferLogEntry::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}


sub getParameters($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getParameters', $args);
    my $_ret_;
    $_ret_ = {};
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        my $key0 = $rsp->{'_ret_'}->[$i0]->{'key'};
        my $value0 = $rsp->{'_ret_'}->[$i0]->{'value'};
        $_ret_->{$key0} = $value0;
    }
    return $_ret_;
}


sub setParameters($$) {
    my ($self, $parameters) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'parameters'} = [];
    foreach my $key0 (keys %{$parameters}) {
        my $value0 = $parameters->{$key0};
        my $elem0 = {};
        $elem0->{'key'} = "$key0";
        $elem0->{'value'} = 1 * $value0;
        push(@{$args->{'parameters'}}, $elem0);
    }
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setParameters', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('pdumodel.TransferSwitch', 4, 0, 2, 'Raritan::RPC::pdumodel::TransferSwitch_4_0_2');
1;
