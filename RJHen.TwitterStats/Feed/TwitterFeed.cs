using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Net.NetworkInformation;
using System.Windows.Forms;


//========================================================================
// Main class that connects to and starts the twitter stream. Used some 
// portions from SocialOpinion sdk.
// 
// - https://developer.twitter.com/en/docs/twitter-api/tools-and-libraries
// - https://github.com/jamiemaguiredotnet/SocialOpinion-Public
//========================================================================

namespace RJHen.TwitterStats.Feed
{
    public class TwitterFeed
    {
        //========================================================================
        // REPLACE the BearerToken which is all that's needed to authenticate.
        //========================================================================
        private static string _BearerToken  = "AAAAAAAAAAAAAAAAAAAAAFeBKQEAAAAABCYWuoEPdrQfQ%2BK%2BIBv7Nxq22n8%3DLJWmGoiNNPEyumj6Wd8DOBcVOJNTOFLFWFMrHMs2S652tIagYN";
        private string _streamEndpoint      = "https://api.twitter.com/2/tweets/sample/stream?expansions=attachments.media_keys,entities.mentions.username&user.fields=created_at&media.fields=duration_ms,height,media_key,preview_image_url,type,url,width,public_metrics&place.fields=contained_within,country,country_code,full_name,geo,id,name,place_type&poll.fields=duration_minutes,end_datetime,id,options,voting_status&tweet.fields=attachments,author_id,context_annotations,conversation_id,created_at,entities,geo,id,in_reply_to_user_id,lang,public_metrics,possibly_sensitive,referenced_tweets,reply_settings,source,text,withheld";

        //===========================================================================
        // Setup hooks for Event Handling
        //===========================================================================
        public event EventHandler StreamDataReceivedEvent;
        public class TweetReceivedEventArgs : EventArgs
        {
            public string StreamDataResponse { get; set; }
        }

        /// <summary>
        /// Used to raise the Data Received Event as new Tweets stream in.
        /// </summary>
        /// <param name="dataReceivedEventArgs"></param>
        protected void OnStreamDataReceivedEvent(TweetReceivedEventArgs dataReceivedEventArgs)
        {
            if (StreamDataReceivedEvent == null) { return; }
            StreamDataReceivedEvent(this, dataReceivedEventArgs); 
        }

        /// <summary>
        /// Kicks off the process connecting to Twitter Sample Stream and raises events for every Tweet Received. 
        /// </summary>
        /// <param name="maxTweets"></param>
        /// <param name="maxConnectionAttempts"></param>
        public void StartStream(int maxTweets, int maxConnectionAttempts)
        {
            int intMaxTries = maxConnectionAttempts;
            int intTried = 0;
            int intRequestCount = 0;

            //===========================================================================
            // Let's try to excute everything as many times as we're instructed to do so. 
            //===========================================================================
            while (intTried < intMaxTries)
            {
                intTried++;
                try
                {
                    //===========================================================================
                    // Setup the web request with correct header, url and token for auth.  
                    //===========================================================================
                    int recordsFetch = 0;
                    WebRequest req = WebRequest.Create(_streamEndpoint);
                    req.Headers.Add("Authorization", "Bearer " + _BearerToken);
                    req.Method = "GET";
                    req.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";

                    try
                    {
                        //===========================================================================
                        // Let's get the response now and if the response is cool process payload and 
                        // raise the event to the caller. 
                        //===========================================================================
                        HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

                        intRequestCount++;
                        if (resp.StatusCode == HttpStatusCode.OK)
                        {

                            //===========================================================================
                            // Stream is now open so let's loop through each item/tweet in this filtered
                            // sample stream from Twitter as long we havent hit our MaxTweet limit set by
                            // the client calling us.
                            //===========================================================================
                            using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
                            {
                                do
                                {
                                    if (recordsFetch == maxTweets) { break; }

                                    //===========================================================================
                                    // Grab the JSON payload and as long as it's not empty or null let's raise
                                    // the event for our client to work with.
                                    //===========================================================================
                                    string json = sr.ReadLine();
                                    
                                    if (string.IsNullOrEmpty(json) == false)
                                    {
                                        OnStreamDataReceivedEvent(new TweetReceivedEventArgs { StreamDataResponse = json });
                                        recordsFetch++;
                                    }
                                } while (NetworkInterface.GetIsNetworkAvailable() && !sr.EndOfStream && recordsFetch <= maxTweets);
                            }
                        }
                        else
                        {
                            //===========================================================================
                            // We didn't get an OK from the Twitter Response. 
                            //===========================================================================
                            MessageBox.Show("Twitter API Response StatusCode not HttpStatusCode.OK. Currently: " + resp.StatusCode + " " + resp.StatusDescription);
                        }
                    }
                    catch (WebException ex)
                    {
                        //===========================================================================
                        // Something went wrong here so let's raise a MessageBox. Would be better to 
                        // raise an event for errors that the client subscribes to to keep this more
                        // loosely coupled. 
                        //===========================================================================
                        MessageBox.Show("Web Exception Error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        //===========================================================================
                        // Something more serious happened here like we dont have network access and 
                        // the server cant be reached. 
                        //===========================================================================
                        MessageBox.Show("Critical Error: " + ex.Message);
                    }

                    //===========================================================================
                    // Check to make sure we're good on MaxTries and wait 10 seconds between
                    // tries. 
                    //===========================================================================
                    if (intTried < intMaxTries) { Thread.Sleep(TimeSpan.FromSeconds(10)); }
                }
                catch (Exception ex)
                {
                    //===========================================================================
                    // Can't image an error getting raised here but if it does we'll throw a 
                    // generic error message after sleeping for 10 seconds. 
                    //===========================================================================
                    if (intTried < intMaxTries) { Thread.Sleep(TimeSpan.FromSeconds(10)); }
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
