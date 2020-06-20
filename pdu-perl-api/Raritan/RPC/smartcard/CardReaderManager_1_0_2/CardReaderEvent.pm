# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from CardReaderManager.idl.

use strict;

package Raritan::RPC::smartcard::CardReaderManager_1_0_2::CardReaderEvent;

use constant typeId => "smartcard.CardReaderManager_1_0_2.CardReaderEvent:1.0.0";
use Raritan::RPC::idl::Event;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'cardReader'} = Raritan::RPC::ObjectCodec::encode($in->{'cardReader'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'cardReader'} = Raritan::RPC::ObjectCodec::decode($agent, $in->{'cardReader'}, 'smartcard.CardReader');
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('smartcard.CardReaderManager_1_0_2.CardReaderEvent', 1, 0, 0, 'Raritan::RPC::smartcard::CardReaderManager_1_0_2::CardReaderEvent');
1;
