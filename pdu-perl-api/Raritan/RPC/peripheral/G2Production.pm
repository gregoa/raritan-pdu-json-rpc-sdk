# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PeripheralG2Production.idl.

use strict;

package Raritan::RPC::peripheral::G2Production;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "peripheral.G2Production:1.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::peripheral::G2Production::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant ERR_INVALID_PARAMS => 1;

use constant ERR_NO_CONFIG_MODE => 2;

use constant ERR_NO_DEVICE => 3;

use constant ERR_NO_FIRMWARE_FILE => 4;

use constant ERR_FIRMWARE_INVALID => 5;

use constant ERR_PROTECTED => 6;

use Raritan::RPC::peripheral::G2Production::FirmwareInfo;

sub updateFirmware($$$) {
    my ($self, $romcode, $info) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'romcode'} = "$romcode";
    my $rsp = $agent->json_rpc($self->{'rid'}, 'updateFirmware', $args);
    $$info = Raritan::RPC::peripheral::G2Production::FirmwareInfo::decode($agent, $rsp->{'info'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::peripheral::PosElement;
use Raritan::RPC::peripheral::G2Production::FirmwareInfo;

sub updateFirmwarePos($$$) {
    my ($self, $position, $info) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'position'} = [];
    for (my $i0 = 0; $i0 <= $#{$position}; $i0++) {
        $args->{'position'}->[$i0] = Raritan::RPC::peripheral::PosElement::encode($position->[$i0]);
    }
    my $rsp = $agent->json_rpc($self->{'rid'}, 'updateFirmwarePos', $args);
    $$info = Raritan::RPC::peripheral::G2Production::FirmwareInfo::decode($agent, $rsp->{'info'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::peripheral::G2Production::FirmwareInfo;

sub getFirmwareInfo($$$) {
    my ($self, $romcode, $info) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'romcode'} = "$romcode";
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getFirmwareInfo', $args);
    $$info = Raritan::RPC::peripheral::G2Production::FirmwareInfo::decode($agent, $rsp->{'info'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::peripheral::G2Production::FirmwareInfo;
use Raritan::RPC::peripheral::PosElement;

sub getFirmwareInfoPos($$$) {
    my ($self, $position, $info) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'position'} = [];
    for (my $i0 = 0; $i0 <= $#{$position}; $i0++) {
        $args->{'position'}->[$i0] = Raritan::RPC::peripheral::PosElement::encode($position->[$i0]);
    }
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getFirmwareInfoPos', $args);
    $$info = Raritan::RPC::peripheral::G2Production::FirmwareInfo::decode($agent, $rsp->{'info'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}


sub readConfigurationSpace($$$$) {
    my ($self, $romcode, $cs, $cfg) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'romcode'} = "$romcode";
    $args->{'cs'} = $cs;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'readConfigurationSpace', $args);
    $$cfg = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'cfg'}}; $i0++) {
        $$cfg->[$i0] = $rsp->{'cfg'}->[$i0];
    }
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::peripheral::PosElement;

sub readConfigurationSpacePos($$$$) {
    my ($self, $position, $cs, $cfg) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'position'} = [];
    for (my $i0 = 0; $i0 <= $#{$position}; $i0++) {
        $args->{'position'}->[$i0] = Raritan::RPC::peripheral::PosElement::encode($position->[$i0]);
    }
    $args->{'cs'} = $cs;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'readConfigurationSpacePos', $args);
    $$cfg = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'cfg'}}; $i0++) {
        $$cfg->[$i0] = $rsp->{'cfg'}->[$i0];
    }
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}


sub writeConfigurationSpace($$$$) {
    my ($self, $romcode, $cs, $cfg) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'romcode'} = "$romcode";
    $args->{'cs'} = $cs;
    $args->{'cfg'} = [];
    for (my $i0 = 0; $i0 <= $#{$cfg}; $i0++) {
        $args->{'cfg'}->[$i0] = 1 * $cfg->[$i0];
    }
    my $rsp = $agent->json_rpc($self->{'rid'}, 'writeConfigurationSpace', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::peripheral::PosElement;

sub writeConfigurationSpacePos($$$$) {
    my ($self, $position, $cs, $cfg) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'position'} = [];
    for (my $i0 = 0; $i0 <= $#{$position}; $i0++) {
        $args->{'position'}->[$i0] = Raritan::RPC::peripheral::PosElement::encode($position->[$i0]);
    }
    $args->{'cs'} = $cs;
    $args->{'cfg'} = [];
    for (my $i0 = 0; $i0 <= $#{$cfg}; $i0++) {
        $args->{'cfg'}->[$i0] = 1 * $cfg->[$i0];
    }
    my $rsp = $agent->json_rpc($self->{'rid'}, 'writeConfigurationSpacePos', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}


sub reset($$$) {
    my ($self, $romcode, $method) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'romcode'} = "$romcode";
    $args->{'method'} = $method;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'reset', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::peripheral::PosElement;

sub resetPos($$$) {
    my ($self, $position, $method) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'position'} = [];
    for (my $i0 = 0; $i0 <= $#{$position}; $i0++) {
        $args->{'position'}->[$i0] = Raritan::RPC::peripheral::PosElement::encode($position->[$i0]);
    }
    $args->{'method'} = $method;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'resetPos', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('peripheral.G2Production', 1, 0, 0, 'Raritan::RPC::peripheral::G2Production');
1;
