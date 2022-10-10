// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Azure.AI.Personalizer.Tests
{
    public class LiveRankTests : LiveTestBase<LiveRankTestsEnvironment>
    {
        [Test]
        public async Task SingleSlotRankTests()
        {
            var thickClient = new PersonalizerClient(
                new Uri("https://payg-trevor-westeurope-personalizer-aug26.ppe.cognitiveservices.azure.com/"),
                new AzureKeyCredential(""),
                new PersonalizerClientOptions(useLocalInference: true)
            );

            IList<object> contextFeatures = new List<object>() {
                new { Features = new { day = "tuesday", time = "night", weather = "rainy" } },
                new { Features = new { userId = "1234", payingUser = true, favoriteGenre = "documentary", hoursOnSite = 0.12, lastwatchedType = "movie" } }
            };
            IList<PersonalizerRankableAction> actions = new List<PersonalizerRankableAction>();
            actions.Add(
                new PersonalizerRankableAction(
                    id: "Person1",
                    features:
                    new List<object>() { new { videoType = "documentary", videoLength = 35, director = "CarlSagan" }, new { mostWatchedByAge = "30-35" } }
            ));
            actions.Add(
                new PersonalizerRankableAction(
                    id: "Person2",
                    features:
                        new List<object>() { new { videoType = "documentary", videoLength = 35, director = "CarlSagan" }, new { mostWatchedByAge = "40-45" } }
            ));
            IList<string> excludeActions = new List<string>();
            var request = new PersonalizerRankOptions(actions, contextFeatures, excludeActions, "");

            var eventIDPrefix = $"thick_client_{ DateTime.UtcNow.Ticks}_";

            var pendingRewards = new Queue<PendingReward>();
            var numRanksSent = 0;
            var NUM_RANK_REWARDS = 500000;
            while ((numRanksSent < NUM_RANK_REWARDS) || pendingRewards.Count > 0)
            {
                if (pendingRewards.Count > 0)
                {
                    var pendingReward = pendingRewards.Peek();
                    if (pendingReward.Due < DateTime.Now)
                    {
                        var rewardResponse = await thickClient.RewardAsync(pendingReward.EventID, 0.7f);
                        pendingRewards.Dequeue();
                        continue;
                    }
                }

                if (numRanksSent < NUM_RANK_REWARDS)
                {
                    request.EventId = $"{eventIDPrefix}{numRanksSent}";
                    var rankResponse = await thickClient.RankAsync(request);
                    ++numRanksSent;
                    pendingRewards.Enqueue(new PendingReward() { EventID = request.EventId, Due = DateTime.Now.AddSeconds(10) });
                    continue;
                }
                else
                {
                    var sleepTime = DateTime.Now - pendingRewards.Peek().Due;
                    if (sleepTime.TotalMilliseconds > 0)
                    {
                        await Task.Delay(sleepTime);
                    }
                }
            }
        }

        public struct PendingReward
        {
            public string EventID { get; set; }
            public DateTime Due { get; set; }
        }
    }
}
