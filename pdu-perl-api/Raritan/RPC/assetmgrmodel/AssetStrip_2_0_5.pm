# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from AssetStrip.idl.

use strict;

package Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "assetmgrmodel.AssetStrip:2.0.5";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}

use constant NO_ERROR => 0;

use constant ERR_INVALID_PARAM => 1;

use constant ERR_NO_SUCH_OBJECT => 2;

use constant ERR_NOT_SUPPORTED => 3;

use constant ERR_OPERATION_FAILED => 4;

use constant MAIN_STRIP_COLUMN => 0;


sub getState($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getState', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::DeviceInfo;

sub getDeviceInfo($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getDeviceInfo', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::DeviceInfo::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::StripInfo;

sub getStripInfo($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getStripInfo', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::StripInfo::decode($agent, $rsp->{'_ret_'});
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::RackUnitInfo;

sub getRackUnitInfo($$$) {
    my ($self, $rackUnitNumber, $info) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'rackUnitNumber'} = 1 * $rackUnitNumber;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getRackUnitInfo', $args);
    $$info = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::RackUnitInfo::decode($agent, $rsp->{'info'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::RackUnitInfo;

sub getAllRackUnitInfos($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getAllRackUnitInfos', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::RackUnitInfo::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::TagInfo;

sub getTag($$$$) {
    my ($self, $rackUnitNumber, $slotNumber, $tagInfo) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'rackUnitNumber'} = 1 * $rackUnitNumber;
    $args->{'slotNumber'} = 1 * $slotNumber;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getTag', $args);
    $$tagInfo = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::TagInfo::decode($agent, $rsp->{'tagInfo'});
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::TagInfo;

sub getAllTags($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getAllTags', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::TagInfo::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::TagInfo;

sub getMainTags($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getMainTags', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::TagInfo::decode($agent, $rsp->{'_ret_'}->[$i0]);
    }
    return $_ret_;
}

use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::TagInfo;

sub getExtensionTags($$$) {
    my ($self, $rackUnitNumber, $tags) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'rackUnitNumber'} = 1 * $rackUnitNumber;
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getExtensionTags', $args);
    $$tags = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'tags'}}; $i0++) {
        $$tags->[$i0] = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::TagInfo::decode($agent, $rsp->{'tags'}->[$i0]);
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
}

use Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::TagInfo;

sub programTagIDs($$) {
    my ($self, $tagInfos) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'tagInfos'} = [];
    for (my $i0 = 0; $i0 <= $#{$tagInfos}; $i0++) {
        $args->{'tagInfos'}->[$i0] = Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5::TagInfo::encode($tagInfos->[$i0]);
    }
    my $rsp = $agent->json_rpc($self->{'rid'}, 'programTagIDs', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}


sub getFirmwareUpdateState($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getFirmwareUpdateState', $args);
    my $_ret_;
    $_ret_ = $rsp->{'_ret_'};
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('assetmgrmodel.AssetStrip', 2, 0, 5, 'Raritan::RPC::assetmgrmodel::AssetStrip_2_0_5');
1;
