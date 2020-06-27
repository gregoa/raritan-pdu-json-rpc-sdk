// SPDX-License-Identifier: BSD-3-Clause
//
// Copyright 2020 Raritan Inc. All rights reserved.
//
// This file was generated by IdlC from LdapServerSettings.idl.

using System;
using System.Linq;
using LightJson;
using Com.Raritan.Idl;
using Com.Raritan.JsonRpc;
using Com.Raritan.Util;

#pragma warning disable 0108, 0219, 0414, 1591

namespace Com.Raritan.Idl.auth.ldapsrv {

  public class ServerSettings : ICloneable {
    public object Clone() {
      ServerSettings copy = new ServerSettings();
      copy.id = this.id;
      copy.primaryServer = this.primaryServer;
      copy.secondaryServer = this.secondaryServer;
      copy.adoptSettingsId = this.adoptSettingsId;
      copy.type = this.type;
      copy.port = this.port;
      copy.sslPort = this.sslPort;
      copy.useSSL = this.useSSL;
      copy.forceTrustedCert = this.forceTrustedCert;
      copy.certificate = this.certificate;
      copy.adsDomain = this.adsDomain;
      copy.useAnonymousBind = this.useAnonymousBind;
      copy.bindDN = this.bindDN;
      copy.bindPwd = this.bindPwd;
      copy.searchBaseDN = this.searchBaseDN;
      copy.loginNameAttr = this.loginNameAttr;
      copy.userEntryObjClass = this.userEntryObjClass;
      copy.userSearchFilter = this.userSearchFilter;
      return copy;
    }

    public LightJson.JsonObject Encode() {
      LightJson.JsonObject json = new LightJson.JsonObject();
      json["id"] = this.id;
      json["primaryServer"] = this.primaryServer;
      json["secondaryServer"] = this.secondaryServer;
      json["adoptSettingsId"] = this.adoptSettingsId;
      json["type"] = (int)this.type;
      json["port"] = this.port;
      json["sslPort"] = this.sslPort;
      json["useSSL"] = this.useSSL;
      json["forceTrustedCert"] = this.forceTrustedCert;
      json["certificate"] = this.certificate;
      json["adsDomain"] = this.adsDomain;
      json["useAnonymousBind"] = this.useAnonymousBind;
      json["bindDN"] = this.bindDN;
      json["bindPwd"] = this.bindPwd;
      json["searchBaseDN"] = this.searchBaseDN;
      json["loginNameAttr"] = this.loginNameAttr;
      json["userEntryObjClass"] = this.userEntryObjClass;
      json["userSearchFilter"] = this.userSearchFilter;
      return json;
    }

    public static ServerSettings Decode(LightJson.JsonObject json, Agent agent) {
      ServerSettings inst = new ServerSettings();
      inst.id = (string)json["id"];
      inst.primaryServer = (string)json["primaryServer"];
      inst.secondaryServer = (string)json["secondaryServer"];
      inst.adoptSettingsId = (string)json["adoptSettingsId"];
      inst.type = (Com.Raritan.Idl.auth.ldapsrv.ServerType)(int)json["type"];
      inst.port = (int)json["port"];
      inst.sslPort = (int)json["sslPort"];
      inst.useSSL = (bool)json["useSSL"];
      inst.forceTrustedCert = (bool)json["forceTrustedCert"];
      inst.certificate = (string)json["certificate"];
      inst.adsDomain = (string)json["adsDomain"];
      inst.useAnonymousBind = (bool)json["useAnonymousBind"];
      inst.bindDN = (string)json["bindDN"];
      inst.bindPwd = (string)json["bindPwd"];
      inst.searchBaseDN = (string)json["searchBaseDN"];
      inst.loginNameAttr = (string)json["loginNameAttr"];
      inst.userEntryObjClass = (string)json["userEntryObjClass"];
      inst.userSearchFilter = (string)json["userSearchFilter"];
      return inst;
    }

    public string id = "";
    public string primaryServer = "";
    public string secondaryServer = "";
    public string adoptSettingsId = "";
    public Com.Raritan.Idl.auth.ldapsrv.ServerType type = Com.Raritan.Idl.auth.ldapsrv.ServerType.ACTIVE_DIRECTORY;
    public int port = 0;
    public int sslPort = 0;
    public bool useSSL = false;
    public bool forceTrustedCert = false;
    public string certificate = "";
    public string adsDomain = "";
    public bool useAnonymousBind = false;
    public string bindDN = "";
    public string bindPwd = "";
    public string searchBaseDN = "";
    public string loginNameAttr = "";
    public string userEntryObjClass = "";
    public string userSearchFilter = "";
  }
}
