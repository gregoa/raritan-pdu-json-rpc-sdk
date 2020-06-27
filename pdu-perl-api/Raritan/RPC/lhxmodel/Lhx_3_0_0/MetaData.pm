# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from Lhx.idl.

use strict;

package Raritan::RPC::lhxmodel::Lhx_3_0_0::MetaData;

use Raritan::RPC::lhxmodel::Lhx_3_0_0::ParamCfg;
use Raritan::RPC::lhxmodel::Lhx_3_0_0::ParamCfg;
use Raritan::RPC::lhxmodel::Lhx_3_0_0::ParamCfg;

sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'model'} = "$in->{'model'}";
    $encoded->{'version'} = "$in->{'version'}";
    $encoded->{'setpointWaterValveCfg'} = Raritan::RPC::lhxmodel::Lhx_3_0_0::ParamCfg::encode($in->{'setpointWaterValveCfg'});
    $encoded->{'setpointVentilatorsCfg'} = Raritan::RPC::lhxmodel::Lhx_3_0_0::ParamCfg::encode($in->{'setpointVentilatorsCfg'});
    $encoded->{'defaultFanSpeedCfg'} = Raritan::RPC::lhxmodel::Lhx_3_0_0::ParamCfg::encode($in->{'defaultFanSpeedCfg'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'model'} = $in->{'model'};
    $decoded->{'version'} = $in->{'version'};
    $decoded->{'setpointWaterValveCfg'} = Raritan::RPC::lhxmodel::Lhx_3_0_0::ParamCfg::decode($agent, $in->{'setpointWaterValveCfg'});
    $decoded->{'setpointVentilatorsCfg'} = Raritan::RPC::lhxmodel::Lhx_3_0_0::ParamCfg::decode($agent, $in->{'setpointVentilatorsCfg'});
    $decoded->{'defaultFanSpeedCfg'} = Raritan::RPC::lhxmodel::Lhx_3_0_0::ParamCfg::decode($agent, $in->{'defaultFanSpeedCfg'});
    return $decoded;
}

1;
