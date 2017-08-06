﻿#if !RX_BRIDGE
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information. 

using System;

#if SIGNED

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.Debugger, PublicKey=00240000048000009400000006020000002400005253413100040000010001008f5cff058631087031f8350f30a36fa078027e5df2316b564352dc9eb7af7ce856016d3c5e9d058036fe73bb5c83987bd3fc0793fbe25d633cc4f37c2bd5f1d717cd2a81661bec08f0971dc6078e17bde372b89005e7738a0ebd501b896ca3e8315270ff64df7809dd912c372df61785a5085b3553b7872e39b1b1cc0ff5a6bc")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.Experimental, PublicKey=00240000048000009400000006020000002400005253413100040000010001008f5cff058631087031f8350f30a36fa078027e5df2316b564352dc9eb7af7ce856016d3c5e9d058036fe73bb5c83987bd3fc0793fbe25d633cc4f37c2bd5f1d717cd2a81661bec08f0971dc6078e17bde372b89005e7738a0ebd501b896ca3e8315270ff64df7809dd912c372df61785a5085b3553b7872e39b1b1cc0ff5a6bc")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.PlatformServices, PublicKey=00240000048000009400000006020000002400005253413100040000010001008f5cff058631087031f8350f30a36fa078027e5df2316b564352dc9eb7af7ce856016d3c5e9d058036fe73bb5c83987bd3fc0793fbe25d633cc4f37c2bd5f1d717cd2a81661bec08f0971dc6078e17bde372b89005e7738a0ebd501b896ca3e8315270ff64df7809dd912c372df61785a5085b3553b7872e39b1b1cc0ff5a6bc")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Tests.System.Reactive, PublicKey=00240000048000009400000006020000002400005253413100040000010001008f5cff058631087031f8350f30a36fa078027e5df2316b564352dc9eb7af7ce856016d3c5e9d058036fe73bb5c83987bd3fc0793fbe25d633cc4f37c2bd5f1d717cd2a81661bec08f0971dc6078e17bde372b89005e7738a0ebd501b896ca3e8315270ff64df7809dd912c372df61785a5085b3553b7872e39b1b1cc0ff5a6bc")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Tests.System.Reactive.Uwp.DeviceRunner, PublicKey=00240000048000009400000006020000002400005253413100040000010001008f5cff058631087031f8350f30a36fa078027e5df2316b564352dc9eb7af7ce856016d3c5e9d058036fe73bb5c83987bd3fc0793fbe25d633cc4f37c2bd5f1d717cd2a81661bec08f0971dc6078e17bde372b89005e7738a0ebd501b896ca3e8315270ff64df7809dd912c372df61785a5085b3553b7872e39b1b1cc0ff5a6bc")]
#else

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.Debugger")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.Experimental")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.PlatformServices")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Tests.System.Reactive")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Tests.System.Reactive.Uwp.DeviceRunner")]

#endif
#endif