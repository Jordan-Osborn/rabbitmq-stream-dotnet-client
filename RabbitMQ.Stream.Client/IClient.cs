﻿// This source code is dual-licensed under the Apache License, version
// 2.0, and the Mozilla Public License, version 2.0.
// Copyright (c) 2017-2023 Broadcom. All Rights Reserved. The term "Broadcom" refers to Broadcom Inc. and/or its subsidiaries.

using System.Collections.Generic;
using System.Threading.Tasks;

namespace RabbitMQ.Stream.Client
{
    /// <summary>
    /// IClient is the Interface for the actual Client
    /// It is needed to create unit tests hard to test using
    /// Integration tests: See AddressResolver tests.
    /// </summary>
    public interface IClient
    {
        ClientParameters Parameters { get; set; }
        IDictionary<string, string> ConnectionProperties { get; }

        Task<CloseResponse> Close(string reason);

        // The ClientId is a key that is used to identify the client in an unique way
        // It is used to identify the client in the ConnectionsPool
        // by default it is a GUID
        string ClientId { get; init; }
    }
}
