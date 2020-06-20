# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from SensorLogger.idl.

use strict;

package Raritan::RPC::pdumodel::SensorLogger::SensorState;

use constant UNAVAILABLE => 0;
use constant OPEN => 1;
use constant CLOSE => 2;
use constant BELOW_LOWER_CRITICAL => 3;
use constant BELOW_LOWER_WARNING => 4;
use constant NORMAL => 5;
use constant ABOVE_UPPER_WARNING => 6;
use constant ABOVE_UPPER_CRITICAL => 7;
use constant ON => 8;
use constant OFF => 9;
use constant ALARMED => 10;

1;