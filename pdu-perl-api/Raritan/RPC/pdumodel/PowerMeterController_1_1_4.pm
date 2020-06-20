# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PowerMeterController.idl.

use strict;

package Raritan::RPC::pdumodel::PowerMeterController_1_1_4;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "pdumodel.PowerMeterController:1.1.4";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::pdumodel::PowerMeterController_1_1_4::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant ERR_INVALID_PARAM => 1;

use constant ERR_METER_BOARD_BUSY => 2;

use Raritan::RPC::pdumodel::PowerMeterController_1_1_4::ScanResult;

sub scanMeterBoard($$$) {
    my ($self, $powerMeterId, $result) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'powerMeterId'} = 1 * $powerMeterId;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'scanMeterBoard', $args);
    $$result = Raritan::RPC::pdumodel::PowerMeterController_1_1_4::ScanResult::decode($agent, $rsp->{'result'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}


sub getPowerMeters($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getPowerMeters', $args);
    my $_ret_;
    $_ret_ = {};
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        my $key0 = $rsp->{'_ret_'}->[$i0]->{'key'};
        my $value0 = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'_ret_'}->[$i0]->{'value'}, 'pdumodel.PowerMeter');
        $_ret_->{$key0} = $value0;
    }
    return $_ret_;
}

use Raritan::RPC::pdumodel::PowerMeter_1_1_4::Config;
use Raritan::RPC::pdumodel::PowerMeter_1_1_4::Settings;

sub createPowerMeter($$$$) {
    my ($self, $powerMeter, $config, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'config'} = Raritan::RPC::pdumodel::PowerMeter_1_1_4::Config::encode($config);
    $args->{'settings'} = Raritan::RPC::pdumodel::PowerMeter_1_1_4::Settings::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'createPowerMeter', $args);
    $$powerMeter = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'powerMeter'}, 'pdumodel.PowerMeter');
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::pdumodel::Panel_1_1_4::PanelSettings;
use Raritan::RPC::pdumodel::PowerMeter_1_1_4::Config;
use Raritan::RPC::pdumodel::PowerMeter_1_1_4::Settings;

sub createPanel($$$$$) {
    my ($self, $panel, $config, $powerMeterSettings, $panelSettings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'config'} = Raritan::RPC::pdumodel::PowerMeter_1_1_4::Config::encode($config);
    $args->{'powerMeterSettings'} = Raritan::RPC::pdumodel::PowerMeter_1_1_4::Settings::encode($powerMeterSettings);
    $args->{'panelSettings'} = Raritan::RPC::pdumodel::Panel_1_1_4::PanelSettings::encode($panelSettings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'createPanel', $args);
    $$panel = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'panel'}, 'pdumodel.Panel');
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub deletePowerMeter($$) {
    my ($self, $powerMeterId) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'powerMeterId'} = 1 * $powerMeterId;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'deletePowerMeter', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('pdumodel.PowerMeterController', 1, 1, 4, 'Raritan::RPC::pdumodel::PowerMeterController_1_1_4');
1;
