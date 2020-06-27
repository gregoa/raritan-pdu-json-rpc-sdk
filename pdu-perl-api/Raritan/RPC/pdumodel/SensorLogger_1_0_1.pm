# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from SensorLogger.idl.

use strict;

package Raritan::RPC::pdumodel::SensorLogger_1_0_1;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "pdumodel.SensorLogger:1.0.1";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::pdumodel::SensorLogger_1_0_1::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use Raritan::RPC::pdumodel::SensorLogger_1_0_1::Settings;

sub getSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSettings', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::pdumodel::SensorLogger_1_0_1::Settings::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

sub setSettings($$$) {
    my ($self, $isEnabled, $samplesPerRecord) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'isEnabled'} = ($isEnabled) ? JSON::true : JSON::false;
    $args->{'samplesPerRecord'} = 1 * $samplesPerRecord;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub getTimeStamps($$$$) {
    my ($self, $timestamps, $recid, $count) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'recid'} = 1 * $recid;
    $args->{'count'} = 1 * $count;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getTimeStamps', $args);
    $$timestamps = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'timestamps'}}; $i0++) {
        $$timestamps->[$i0] = $rsp->{'timestamps'}->[$i0];
    }
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::pdumodel::SensorLogger_1_0_1::Record;

sub getSensorRecords($$$$$) {
    my ($self, $recs, $sensor, $recid, $count) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'sensor'} = Raritan::RPC::ObjectCodec::encode($sensor);
    $args->{'recid'} = 1 * $recid;
    $args->{'count'} = 1 * $count;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSensorRecords', $args);
    $$recs = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'recs'}}; $i0++) {
        $$recs->[$i0] = Raritan::RPC::pdumodel::SensorLogger_1_0_1::Record::decode($agent, $rsp->{'recs'}->[$i0]);
    }
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::pdumodel::SensorLogger_1_0_1::Record;

sub getExternalSensorRecords($$$$$) {
    my ($self, $recs, $extsensor, $recid, $count) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'extsensor'} = Raritan::RPC::ObjectCodec::encode($extsensor);
    $args->{'recid'} = 1 * $recid;
    $args->{'count'} = 1 * $count;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getExternalSensorRecords', $args);
    $$recs = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'recs'}}; $i0++) {
        $$recs->[$i0] = Raritan::RPC::pdumodel::SensorLogger_1_0_1::Record::decode($agent, $rsp->{'recs'}->[$i0]);
    }
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::pdumodel::SensorLogger_1_0_1::TimedRecord;

sub getSensorTimedRecords($$$$$) {
    my ($self, $recs, $sensor, $recid, $count) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'sensor'} = Raritan::RPC::ObjectCodec::encode($sensor);
    $args->{'recid'} = 1 * $recid;
    $args->{'count'} = 1 * $count;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSensorTimedRecords', $args);
    $$recs = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'recs'}}; $i0++) {
        $$recs->[$i0] = Raritan::RPC::pdumodel::SensorLogger_1_0_1::TimedRecord::decode($agent, $rsp->{'recs'}->[$i0]);
    }
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::pdumodel::SensorLogger_1_0_1::TimedRecord;

sub getExtSensorTimedRecords($$$$$) {
    my ($self, $recs, $extsensor, $recid, $count) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'extsensor'} = Raritan::RPC::ObjectCodec::encode($extsensor);
    $args->{'recid'} = 1 * $recid;
    $args->{'count'} = 1 * $count;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getExtSensorTimedRecords', $args);
    $$recs = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'recs'}}; $i0++) {
        $$recs->[$i0] = Raritan::RPC::pdumodel::SensorLogger_1_0_1::TimedRecord::decode($agent, $rsp->{'recs'}->[$i0]);
    }
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::pdumodel::SensorLogger_1_0_1::SensorSet;

sub getLoggedSensors($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getLoggedSensors', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::pdumodel::SensorLogger_1_0_1::SensorSet::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::pdumodel::SensorLogger_1_0_1::SensorSet;

sub setLoggedSensors($$) {
    my ($self, $sensors) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'sensors'} = Raritan::RPC::pdumodel::SensorLogger_1_0_1::SensorSet::encode($sensors);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setLoggedSensors', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub enableAllSensors($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'enableAllSensors', $args);
}

sub disableAllSensors($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'disableAllSensors', $args);
}

sub getSensorSetTimestamp($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSensorSetTimestamp', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::pdumodel::SensorLogger_1_0_1::LogRow;

sub getLogRow($$$) {
    my ($self, $row, $recid) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'recid'} = 1 * $recid;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getLogRow', $args);
    $$row = Raritan::RPC::pdumodel::SensorLogger_1_0_1::LogRow::decode($agent, $rsp->{'row'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('pdumodel.SensorLogger', 1, 0, 1, 'Raritan::RPC::pdumodel::SensorLogger_1_0_1');
1;
