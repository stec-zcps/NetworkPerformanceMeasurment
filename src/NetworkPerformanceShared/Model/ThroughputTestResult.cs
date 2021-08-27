﻿// <copyright file="ThroughputTestResult.cs" company="Fraunhofer Institute for Manufacturing Engineering and Automation IPA">
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

namespace NetworkPerformanceShared.Model
{
    /// <summary>
    /// Represtens the results of a throughput test.
    /// </summary>
    public class ThroughputTestResult
    {
        /// <summary>Gets or sets id of the the <see cref="LatencyTestResult"/>.</summary>
        public long Id { get; set; }

        /// <summary>Gets or sets  label for this results (e.g. for use in dashboard).</summary>
        public string Label { get; set; }

        /// <summary>Gets or sets  measured bandwidth.</summary>
        public float Bandwidth { get; set; }

        /// <summary>Gets or sets  message rate during throughput test.</summary>
        public double MessageRate { get; set; }

        /// <summary>Gets or sets  the parameters used for this test.</summary>
        public ThroughputTestParameters TestParameters { get; set; }
    }
}