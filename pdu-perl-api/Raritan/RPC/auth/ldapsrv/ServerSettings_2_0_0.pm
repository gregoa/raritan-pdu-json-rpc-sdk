# SPDX-License-Identifier: BSD-3-Clause
#
# Copyright 2020 Raritan Inc. All rights reserved.
#
# This file was generated by IdlC from LdapServerSettings.idl.

use strict;

package Raritan::RPC::auth::ldapsrv::ServerSettings_2_0_0;


sub encode {
    my ($in) = @_;
    my $encoded = {};
    $encoded->{'id'} = "$in->{'id'}";
    $encoded->{'server'} = "$in->{'server'}";
    $encoded->{'adoptSettingsId'} = "$in->{'adoptSettingsId'}";
    $encoded->{'type'} = $in->{'type'};
    $encoded->{'secProto'} = $in->{'secProto'};
    $encoded->{'port'} = 1 * $in->{'port'};
    $encoded->{'sslPort'} = 1 * $in->{'sslPort'};
    $encoded->{'forceTrustedCert'} = ($in->{'forceTrustedCert'}) ? JSON::true : JSON::false;
    $encoded->{'allowOffTimeRangeCerts'} = ($in->{'allowOffTimeRangeCerts'}) ? JSON::true : JSON::false;
    $encoded->{'certificate'} = "$in->{'certificate'}";
    $encoded->{'adsDomain'} = "$in->{'adsDomain'}";
    $encoded->{'useAnonymousBind'} = ($in->{'useAnonymousBind'}) ? JSON::true : JSON::false;
    $encoded->{'bindDN'} = "$in->{'bindDN'}";
    $encoded->{'bindPwd'} = "$in->{'bindPwd'}";
    $encoded->{'searchBaseDN'} = "$in->{'searchBaseDN'}";
    $encoded->{'loginNameAttr'} = "$in->{'loginNameAttr'}";
    $encoded->{'userEntryObjClass'} = "$in->{'userEntryObjClass'}";
    $encoded->{'userSearchFilter'} = "$in->{'userSearchFilter'}";
    return $encoded;
}

sub decode {
    my ($agent, $in) = @_;
    my $decoded = {};
    $decoded->{'id'} = $in->{'id'};
    $decoded->{'server'} = $in->{'server'};
    $decoded->{'adoptSettingsId'} = $in->{'adoptSettingsId'};
    $decoded->{'type'} = $in->{'type'};
    $decoded->{'secProto'} = $in->{'secProto'};
    $decoded->{'port'} = $in->{'port'};
    $decoded->{'sslPort'} = $in->{'sslPort'};
    $decoded->{'forceTrustedCert'} = ($in->{'forceTrustedCert'}) ? 1 : 0;
    $decoded->{'allowOffTimeRangeCerts'} = ($in->{'allowOffTimeRangeCerts'}) ? 1 : 0;
    $decoded->{'certificate'} = $in->{'certificate'};
    $decoded->{'adsDomain'} = $in->{'adsDomain'};
    $decoded->{'useAnonymousBind'} = ($in->{'useAnonymousBind'}) ? 1 : 0;
    $decoded->{'bindDN'} = $in->{'bindDN'};
    $decoded->{'bindPwd'} = $in->{'bindPwd'};
    $decoded->{'searchBaseDN'} = $in->{'searchBaseDN'};
    $decoded->{'loginNameAttr'} = $in->{'loginNameAttr'};
    $decoded->{'userEntryObjClass'} = $in->{'userEntryObjClass'};
    $decoded->{'userSearchFilter'} = $in->{'userSearchFilter'};
    return $decoded;
}

1;