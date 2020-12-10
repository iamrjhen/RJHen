using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RJHen.TwitterStats.Feed.Model;

namespace RJHen.TwitterStats.Tests
{
    [TestClass]
    public class TwitterFeedModelTest
    {
        private string strJsonPayload = "{\"data\":{\"possibly_sensitive\":false,\"id\":\"1336476876945174529\",\"author_id\":\"1312601524967792640\",\"entities\":{\"mentions\":[{\"start\":3,\"end\":11,\"username\":\"Fruko58\"},{\"start\":69,\"end\":79,\"username\":\"livexlive\"}],\"hashtags\":[{\"start\":29,\"end\":43,\"tag\":\"QuaranteamBTS\"},{\"start\":47,\"end\":65,\"tag\":\"TheLockdownAwards\"}]},\"reply_settings\":\"everyone\",\"text\":\"RT @Fruko58: Im voting for #QuaranteamBTS in #TheLockdownAwards on @LiveXLive \n\nRetweet to vote 😘\n20 times per day possible 💜 https://t.…\",\"created_at\":\"2020-12-09T01:04:52.000Z\",\"lang\":\"en\",\"source\":\"Twitter for Android\",\"conversation_id\":\"1336476876945174529\",\"referenced_tweets\":[{\"type\":\"retweeted\",\"id\":\"1336387148849815552\"}],\"public_metrics\":{\"retweet_count\":159,\"reply_count\":0,\"like_count\":0,\"quote_count\":0}},\"includes\":{\"users\":[{\"created_at\":\"2019-06-10T11:36:00.000Z\",\"id\":\"1138047155401383936\",\"username\":\"Fruko58\",\"name\":\"Fruko ⁷ 💜 Happy Birthday Jin 💜\"},{\"created_at\":\"2015-04-10T21:29:37.000Z\",\"id\":\"3148559064\",\"username\":\"livexlive\",\"name\":\"LiveXLive\"}]}}";

        [TestMethod]
        public void TransformJsonPayload_HasCorrectText()
        {
            string strExpected = "RT @Fruko58: Im voting for #QuaranteamBTS in #TheLockdownAwards on @LiveXLive \n\nRetweet to vote 😘\n20 times per day possible 💜 https://t.…";
            // Act
            Tweet tweet = Tweet.FromJson(strJsonPayload);

            // Assert
            string strActual = tweet.Data.Text;
            Assert.AreEqual(strExpected, strActual, true, "Json Payload Not Transformed Correctly");
        }

        [TestMethod]
        public void TransformJsonPayload_HasHashTags()
        {
            // Act
            Tweet tweet = Tweet.FromJson(strJsonPayload);

            // Assert
            Assert.IsTrue(tweet.Data.Entities.Hashtags != null, "Json Payload does Not Include HashTags");
        }

        [TestMethod]
        public void TransformJsonPayload_HasCorrectAuthorId()
        {
            string strExpected = "1312601524967792640";
            // Act
            Tweet tweet = Tweet.FromJson(strJsonPayload);

            // Assert
            string strActual = tweet.Data.AuthorId;
            Assert.AreEqual(strExpected, strActual, true, "Json Payload Does Not have the Correct Author Id");
        }

        [TestMethod]
        public void TransformJsonPayload_HasEntities()
        {
            // Act
            Tweet tweet = Tweet.FromJson(strJsonPayload);

            // Assert
            Assert.IsTrue(tweet.Data.Entities != null, "Json Payload does Not Include Entities");

        }


    }
}
