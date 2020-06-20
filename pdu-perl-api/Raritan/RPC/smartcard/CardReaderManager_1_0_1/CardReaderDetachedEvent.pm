# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from CardReaderManager.idl.

use strict;

package Raritan::RPC::smartcard::CardReaderManager_1_0_1::CardReaderDetachedEvent;

use constant typeId => "smartcard.CardReaderManager_1_0_1.CardReaderDetachedEvent:1.0.0";
use Raritan::RPC::smartcard::CardReaderManager_1_0_1::CardReaderEvent;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::smartcard::CardReaderManager_1_0_1::CardReaderEvent::encode($in);
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::smartcard::CardReaderManager_1_0_1::CardReaderEvent::decode($agent, $in);
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('smartcard.CardReaderManager_1_0_1.CardReaderDetachedEvent', 1, 0, 0, 'Raritan::RPC::smartcard::CardReaderManager_1_0_1::CardReaderDetachedEvent');
1;