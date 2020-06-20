# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from SensorLogger.idl.

use strict;

package Raritan::RPC::sensors::Logger_2_0_1;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "sensors.Logger:2.0.1";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::sensors::Logger_2_0_1::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use Raritan::RPC::sensors::Logger_2_0_1::Settings;

sub getSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getSettings', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::sensors::Logger_2_0_1::Settings::decode($agent, $rsp->{'_ret_'});
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

use constant STATE_UNAVAILABLE => 0;

use constant STATE_OPEN => 1;

use constant STATE_CLOSE => 2;

use constant STATE_BELOW_LOWER_CRITICAL => 3;

use constant STATE_BELOW_LOWER_WARNING => 4;

use constant STATE_NORMAL => 5;

use constant STATE_ABOVE_UPPER_WARNING => 6;

use constant STATE_ABOVE_UPPER_CRITICAL => 7;

use constant STATE_ON => 8;

use constant STATE_OFF => 9;

use constant STATE_ALARMED => 10;

use constant STATE_OK => 11;

use constant STATE_MARGINAL => 12;

use constant STATE_FAIL => 13;

use constant STATE_YES => 14;

use constant STATE_NO => 15;

use constant STATE_STANDBY => 16;

use constant STATE_ONE => 17;

use constant STATE_TWO => 18;

use constant STATE_IN_SYNC => 19;

use constant STATE_OUT_OF_SYNC => 20;

use constant STATE_FAULT => 21;

use constant STATE_SELF_TEST => 22;

use constant STATE_I1_OPEN_FAULT => 23;

use constant STATE_I1_SHORT_FAULT => 24;

use constant STATE_I2_OPEN_FAULT => 25;

use constant STATE_I2_SHORT_FAULT => 26;

use constant STATE_WARNING => 27;

use constant STATE_CRITICAL => 28;

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

use Raritan::RPC::sensors::Logger_2_0_1::Record;

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
        $$recs->[$i0] = Raritan::RPC::sensors::Logger_2_0_1::Record::decode($agent, $rsp->{'recs'}->[$i0]);
    }
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::sensors::Logger_2_0_1::Record;

sub getPeripheralDeviceRecords($$$$$) {
    my ($self, $recs, $slot, $recid, $count) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'slot'} = Raritan::RPC::ObjectCodec::encode($slot);
    $args->{'recid'} = 1 * $recid;
    $args->{'count'} = 1 * $count;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getPeripheralDeviceRecords', $args);
    $$recs = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'recs'}}; $i0++) {
        $$recs->[$i0] = Raritan::RPC::sensors::Logger_2_0_1::Record::decode($agent, $rsp->{'recs'}->[$i0]);
    }
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::sensors::Logger_2_0_1::TimedRecord;

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
        $$recs->[$i0] = Raritan::RPC::sensors::Logger_2_0_1::TimedRecord::decode($agent, $rsp->{'recs'}->[$i0]);
    }
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::sensors::Logger_2_0_1::TimedRecord;

sub getPeripheralDeviceTimedRecords($$$$$) {
    my ($self, $recs, $slot, $recid, $count) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'slot'} = Raritan::RPC::ObjectCodec::encode($slot);
    $args->{'recid'} = 1 * $recid;
    $args->{'count'} = 1 * $count;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getPeripheralDeviceTimedRecords', $args);
    $$recs = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'recs'}}; $i0++) {
        $$recs->[$i0] = Raritan::RPC::sensors::Logger_2_0_1::TimedRecord::decode($agent, $rsp->{'recs'}->[$i0]);
    }
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::sensors::Logger_2_0_1::SensorSet;

sub getLoggedSensors($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getLoggedSensors', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::sensors::Logger_2_0_1::SensorSet::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::sensors::Logger_2_0_1::SensorSet;

sub setLoggedSensors($$) {
    my ($self, $sensors) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'sensors'} = Raritan::RPC::sensors::Logger_2_0_1::SensorSet::encode($sensors);
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

use Raritan::RPC::sensors::Logger_2_0_1::LogRow;

sub getLogRow($$$) {
    my ($self, $row, $recid) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'recid'} = 1 * $recid;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getLogRow', $args);
    $$row = Raritan::RPC::sensors::Logger_2_0_1::LogRow::decode($agent, $rsp->{'row'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('sensors.Logger', 2, 0, 1, 'Raritan::RPC::sensors::Logger_2_0_1');
1;
