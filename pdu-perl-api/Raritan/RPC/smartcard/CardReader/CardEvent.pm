# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from CardReader.idl.

use strict;

package Raritan::RPC::smartcard::CardReader::CardEvent;

use constant typeId => "smartcard.CardReader.CardEvent:1.0.0";
use Raritan::RPC::smartcard::CardReader::CardInformation;
use Raritan::RPC::idl::Event;

sub encode {
    my ($in) = @_;
    my $encoded = Raritan::RPC::idl::Event::encode($in);
    $encoded->{'cardInfo'} = Raritan::RPC::smartcard::CardReader::CardInformation::encode($in->{'cardInfo'});
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = Raritan::RPC::idl::Event::decode($agent, $in);
    $decoded->{'cardInfo'} = Raritan::RPC::smartcard::CardReader::CardInformation::decode($agent, $in->{'cardInfo'});
    return $decoded;
}

Raritan::RPC::Registry::registerCodecClass('smartcard.CardReader.CardEvent', 1, 0, 0, 'Raritan::RPC::smartcard::CardReader::CardEvent');
1;
