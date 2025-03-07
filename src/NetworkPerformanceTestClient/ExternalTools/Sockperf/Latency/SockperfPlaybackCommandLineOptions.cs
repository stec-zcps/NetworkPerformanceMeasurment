﻿// <copyright file="SockperfPlaybackCommandLineOptions.cs" company="Fraunhofer Institute for Manufacturing Engineering and Automation IPA">
// Copyright 2021 Fraunhofer Institute for Manufacturing Engineering and Automation IPA
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

namespace NetworkPerformanceTestClient.ExternalTools.Sockperf
{
    using System.Collections.Generic;
    using CommandLine;

    /// <summary>
    /// Command line options specific to external tool Sockperf (playback mode).
    /// </summary>
    [Verb("playback", HelpText = "Run Sockperf in ping-pong mode")]
    public class SockperfPlaybackCommandLineOptions : SockperfCommandLineOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SockperfPlaybackCommandLineOptions"/> class.
        /// </summary>
        public SockperfPlaybackCommandLineOptions()
        {
        }

        /// <summary>
        /// Gets or sets a comma-separated list for Sockperf playback files.
        /// </summary>
        [Option('f', "files", Required = true, Separator = ',', HelpText = "List of Sockperf playback data files")]
        public IEnumerable<string> PlaybackDataFiles { get; set; }
    }
}
