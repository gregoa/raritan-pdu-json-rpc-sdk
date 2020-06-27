# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This is an auto-generated file.

#
# Section generated by IdlC from "ScannerCtrl.idl"
#

import raritan.rpc
from raritan.rpc import Interface, Structure, ValueObject, Enumeration, typecheck, DecodeException

# interface
class ScannerCtrl(Interface):
    idlType = "tfw.ScannerCtrl:1.0.0"

    class _getScanInterval(Interface.Method):
        name = 'getScanInterval'

        @staticmethod
        def encode():
            args = {}
            return args

        @staticmethod
        def decode(rsp, agent):
            _ret_ = rsp['_ret_']
            typecheck.is_int(_ret_, DecodeException)
            return _ret_

    class _setScanInterval(Interface.Method):
        name = 'setScanInterval'

        @staticmethod
        def encode(interval):
            typecheck.is_int(interval, AssertionError)
            args = {}
            args['interval'] = interval
            return args

        @staticmethod
        def decode(rsp, agent):
            return None
    def __init__(self, target, agent):
        super(ScannerCtrl, self).__init__(target, agent)
        self.getScanInterval = ScannerCtrl._getScanInterval(self)
        self.setScanInterval = ScannerCtrl._setScanInterval(self)

#
# Section generated by IdlC from "CoreCtrl.idl"
#

import raritan.rpc
from raritan.rpc import Interface, Structure, ValueObject, Enumeration, typecheck, DecodeException
import raritan.rpc.tfw


# interface
class CoreCtrl(Interface):
    idlType = "tfw.CoreCtrl:1.0.0"

    class _getScanner(Interface.Method):
        name = 'getScanner'

        @staticmethod
        def encode(name):
            typecheck.is_string(name, AssertionError)
            args = {}
            args['name'] = name
            return args

        @staticmethod
        def decode(rsp, agent):
            _ret_ = Interface.decode(rsp['_ret_'], agent)
            typecheck.is_interface(_ret_, raritan.rpc.tfw.ScannerCtrl, DecodeException)
            return _ret_

    class _startAllScanners(Interface.Method):
        name = 'startAllScanners'

        @staticmethod
        def encode():
            args = {}
            return args

        @staticmethod
        def decode(rsp, agent):
            return None

    class _stopAllScanners(Interface.Method):
        name = 'stopAllScanners'

        @staticmethod
        def encode():
            args = {}
            return args

        @staticmethod
        def decode(rsp, agent):
            return None

    class _startAllBackWorkers(Interface.Method):
        name = 'startAllBackWorkers'

        @staticmethod
        def encode():
            args = {}
            return args

        @staticmethod
        def decode(rsp, agent):
            return None

    class _stopAllBackWorkers(Interface.Method):
        name = 'stopAllBackWorkers'

        @staticmethod
        def encode():
            args = {}
            return args

        @staticmethod
        def decode(rsp, agent):
            return None
    def __init__(self, target, agent):
        super(CoreCtrl, self).__init__(target, agent)
        self.getScanner = CoreCtrl._getScanner(self)
        self.startAllScanners = CoreCtrl._startAllScanners(self)
        self.stopAllScanners = CoreCtrl._stopAllScanners(self)
        self.startAllBackWorkers = CoreCtrl._startAllBackWorkers(self)
        self.stopAllBackWorkers = CoreCtrl._stopAllBackWorkers(self)
