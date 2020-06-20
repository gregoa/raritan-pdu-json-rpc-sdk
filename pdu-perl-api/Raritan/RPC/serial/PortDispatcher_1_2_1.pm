# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from PortDispatcher.idl.

use strict;

package Raritan::RPC::serial::PortDispatcher_1_2_1;

use parent qw(Raritan::RPC::RemoteObject);

use constant typeId => "serial.PortDispatcher:1.2.1";

sub new {
    my ($class, $agent, $rid, $typeId) = @_;
    $typeId = $typeId || Raritan::RPC::serial::PortDispatcher_1_2_1::typeId;
    return $class->SUPER::new($agent, $rid, $typeId);
}


sub getPorts($) {
    my ($self) = @_;
    my $agent = $self->{'agent'};
    my $args = {};
    my $rsp = $agent->json_rpc($self->{'rid'}, 'getPorts', $args);
    my $_ret_;
    $_ret_ = {};
    for (my $i0 = 0; $i0 <= $#{$rsp->{'_ret_'}}; $i0++) {
        my $key0 = $rsp->{'_ret_'}->[$i0]->{'key'};
        my $value0 = Raritan::RPC::ObjectCodec::decode($agent, $rsp->{'_ret_'}->[$i0]->{'value'}, 'serial.SerialPort');
        $_ret_->{$key0} = $value0;
    }
    return $_ret_;
}

Raritan::RPC::Registry::registerProxyClass('serial.PortDispatcher', 1, 2, 1, 'Raritan::RPC::serial::PortDispatcher_1_2_1');
1;
