# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AssetStrip.idl.

use strict;

package Raritan::RPC::assetmgrmodel::AssetStrip;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "assetmgrmodel.AssetStrip:1.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::assetmgrmodel::AssetStrip::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant NO_ERROR => 0;

use constant ERR_INVALID_PARAM => 1;

use constant ERR_NOT_AVAILABLE => 2;

use constant ERR_NO_SUCH_OBJECT => 3;


sub getState($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getState', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip::DeviceInfo;

sub getDeviceInfo($$) {
    my ($self, $info) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getDeviceInfo', $args);
    $$info = Raritan::RPC::assetmgrmodel::AssetStrip::DeviceInfo::decode($agent, $rsp->{'info'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip::StripSettings;

sub getStripSettings($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getStripSettings', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::assetmgrmodel::AssetStrip::StripSettings::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip::StripSettings;

sub setStripSettings($$) {
    my ($self, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'settings'} = Raritan::RPC::assetmgrmodel::AssetStrip::StripSettings::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setStripSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip::RackUnitSettings;

sub setRackUnitSettings($$$) {
    my ($self, $channel, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'channel'} = 1 * $channel;
    $args->{'settings'} = Raritan::RPC::assetmgrmodel::AssetStrip::RackUnitSettings::encode($settings);
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setRackUnitSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip::RackUnitSettings;

sub setMultipleRackUnitSettings($$$) {
    my ($self, $channels, $settings) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'channels'} = [];
    for (my $i0 = 0; $i0 <= $#{$channels}; $i0++) {
        $args->{'channels'}->[$i0] = 1 * $channels->[$i0];
    }
    $args->{'settings'} = [];
    for (my $i0 = 0; $i0 <= $#{$settings}; $i0++) {
        $args->{'settings'}->[$i0] = Raritan::RPC::assetmgrmodel::AssetStrip::RackUnitSettings::encode($settings->[$i0]);
    }
    my $rsp = $agent->json_rpc($self->{'rid'}, 'setMultipleRackUnitSettings', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip::RackUnitInfo;

sub getRackUnitInfo($$$) {
    my ($self, $channel, $info) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'channel'} = 1 * $channel;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getRackUnitInfo', $args);
    $$info = Raritan::RPC::assetmgrmodel::AssetStrip::RackUnitInfo::decode($agent, $rsp->{'info'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip::RackUnitInfo;

sub getAllRackUnitInfos($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getAllRackUnitInfos', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::assetmgrmodel::AssetStrip::RackUnitInfo::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip::TagInfo;

sub getTag($$$) {
    my ($self, $channel, $tagInfo) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'channel'} = 1 * $channel;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getTag', $args);
    $$tagInfo = Raritan::RPC::assetmgrmodel::AssetStrip::TagInfo::decode($agent, $rsp->{'tagInfo'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip::TagInfo;

sub getAllTags($$) {
    my ($self, $tags) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getAllTags', $args);
    $$tags = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'tags'}}; $i0++) {
        $$tags->[$i0] = Raritan::RPC::assetmgrmodel::AssetStrip::TagInfo::decode($agent, $rsp->{'tags'}->[$i0]);
    }
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

sub triggerPowercycle($$) {
    my ($self, $hard) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'hard'} = ($hard) ? JSON::true : JSON::false;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'triggerPowercycle', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('assetmgrmodel.AssetStrip', 1, 0, 0, 'Raritan::RPC::assetmgrmodel::AssetStrip');
1;
