# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from CardReaderManager.idl.

use strict;

package Raritan::RPC::smartcard::CardReaderManager;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "smartcard.CardReaderManager:1.0.0";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::smartcard::CardReaderManager::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}


sub getCardReaders($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getCardReaders', $args);
    my $_ret_;
    $_ret_ = [];
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        $_ret_->[$i0] = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'_ret_'}->[$i0], 'smartcard.CardReader');
    }
    return $_ret_;
}


sub getCardReaderById($$) {
    my ($self, $readerId) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    $args->{'readerId'} = "$readerId";
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getCardReaderById', $args);
    my $_ret_;
    $_ret_ = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'_ret_'}, 'smartcard.CardReader');
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('smartcard.CardReaderManager', 1, 0, 0, 'Raritan::RPC::smartcard::CardReaderManager');
1;
