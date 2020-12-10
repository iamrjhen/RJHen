using NeoSmart.Unicode;
using Newtonsoft.Json;
using RJHen.TwitterStats.Feed;
using RJHen.TwitterStats.Feed.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace RJHen.TwitterStats
{
    public partial class MainStats : Form
    {
        Dictionary<string, int> dicTopEmojis        = new Dictionary<string, int>();
        Dictionary<string, int> dicTopHashTags      = new Dictionary<string, int>();
        Dictionary<string, int> dicTopUrlDomains    = new Dictionary<string, int>();

        private int intTweetCount   = 0;
        private int intUrlCount     = 0;
        private int intHashTagCount = 0;
        private int intEmojiCount   = 0;
        private int intPhotoCount   = 0;
        private int intTotalSeconds = 0;
        private int intAvgPerSec    = 0;
        private int intAvgPerMin    = 0;
        private int intAvgPerHr     = 0;

        private DateTime dtStart;
        private Tweet tweet;

        public MainStats()
        {
            InitializeComponent();

            try
            {
                //========================================================================
                // Setup Emojis ListView
                //========================================================================
                lvEmojis.View = View.Details;
                lvEmojis.GridLines = true;
                lvEmojis.Sorting = SortOrder.Ascending;

                lvEmojis.Columns.Add("Count", 50, HorizontalAlignment.Left);
                lvEmojis.Columns.Add("Emoji", 70, HorizontalAlignment.Left);
                lvEmojis.Columns.Add("Code", 70, HorizontalAlignment.Left);

                lvEmojis.Columns[0].Tag = "Numeric";
                lvEmojis.ListViewItemSorter = new Sorter();

                //========================================================================
                // Setup HastTags ListView
                //========================================================================
                lvHastTags.View = View.Details;
                lvHastTags.GridLines = true;
                lvHastTags.Sorting = SortOrder.Ascending;

                lvHastTags.Columns.Add("Count", 40, HorizontalAlignment.Left);
                lvHastTags.Columns.Add("Hashtag", 130, HorizontalAlignment.Left);

                lvHastTags.Columns[0].Tag = "Numeric";
                lvHastTags.ListViewItemSorter = new Sorter();

                //========================================================================
                // Setup Url Domains ListView
                //========================================================================
                lvTopUrlDomains.View = View.Details;
                lvTopUrlDomains.GridLines = true;
                lvTopUrlDomains.Sorting = SortOrder.Ascending;

                lvTopUrlDomains.Columns.Add("Count", 40, HorizontalAlignment.Left);
                lvTopUrlDomains.Columns.Add("Domain", 130, HorizontalAlignment.Left);

                lvTopUrlDomains.Columns[0].Tag = "Numeric";
                lvTopUrlDomains.ListViewItemSorter = new Sorter();
            }
            catch (Exception e)
            {
                MessageBox.Show("On Load Exception: " + e.Message);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //========================================================================
                // Let's start this puppy up. Do the wait cursor thing, let users know
                // we're doing and loading important stuff.
                //
                // Load all the emojis into an ImageList for the ListView. This takes more
                // time than I'd like so it's definitely something I'd rework if I had
                // more time to optimize things. 
                //========================================================================
                if (Regex.IsMatch(txtMaxTweets.Text, @"^\d+$") == false)
                {
                    txtMaxTweets.Text = "1000";
                }

                Cursor.Current = Cursors.WaitCursor;
                btnStart.Enabled = false;
                lblElapsedTime.Text = "Loading Emojis...";
                Application.DoEvents();

                string emojiDir = string.Format("{0}Resources\\emojis", Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")));
                var imageList = new ImageList();

                try
                {
                    foreach (var item in Directory.GetFiles(emojiDir))
                    {
                        FileInfo fi = new FileInfo(item);
                        imageList.Images.Add(fi.Name, System.Drawing.Image.FromFile(item));
                    }
                }
                catch (Exception eImages)
                {
                    MessageBox.Show("Emoji Images Error. Exception: " + eImages.Message);
                    return;
                }

                //========================================================================
                // Let's hide the wait cursor now and start connecting as it should only
                // take a second or two. 
                //========================================================================
                lvEmojis.SmallImageList = imageList;
                Cursor.Current = Cursors.Default;
                lblElapsedTime.Text = "Connecting...";
                Application.DoEvents();

                try
                {
                    //========================================================================
                    // Setup the stream object, events and start the start datetime clock.
                    //========================================================================
                    TwitterFeed ssc = new TwitterFeed();
                    ssc.StreamDataReceivedEvent += Ssc_StreamDataReceivedEvent;

                    dtStart = DateTime.Now;
                    ssc.StartStream(Convert.ToInt32(txtMaxTweets.Text), 1);
                }
                catch (Exception eStream)
                {
                    MessageBox.Show("Twitter Stream Connection Error. Exception: " + eStream.Message);
                }
            }
            catch (Exception eStart)
            {
                MessageBox.Show("Start Exception: " + eStart.Message);
            }
        }

        /// <summary>
        /// StreamDataReceivedEvent is where we'll grab all the tweets incoming and perform counts and calculations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ssc_StreamDataReceivedEvent(object sender, EventArgs e)
        {
            try
            {
                //========================================================================
                // Let's start out by grabbing the stream and using our strongly type
                // object to transform the payload to something more usable.
                //========================================================================
                TwitterFeed.TweetReceivedEventArgs eventArgs = e as TwitterFeed.TweetReceivedEventArgs;
                tweet = Tweet.FromJson(eventArgs.StreamDataResponse);

                //========================================================================
                // Let's get the total amount of seconds and increment our tweet counter.
                //========================================================================
                intTotalSeconds = Convert.ToInt32(DateTime.Now.Subtract(dtStart).TotalSeconds);
                intTweetCount++;
                if (intTotalSeconds < 1) { return; }
                if (tweet.Includes != null) { if (tweet.Includes.Media != null) { intPhotoCount++; } }

                //========================================================================
                // Now check to see if we got Entities which could be Hashtags or Url's.
                //========================================================================
                if (tweet.Data.Entities != null)
                {
                    //========================================================================
                    // Check to see if we got some HashTags. If so let's add them to the 
                    // dictionary and increment our HashTag counter.
                    //========================================================================
                    if (tweet.Data.Entities.Hashtags != null)
                    {
                        bool blnHasHashTags = false;
                        foreach (var item in tweet.Data.Entities.Hashtags)
                        {
                            blnHasHashTags = true;

                            if (dicTopHashTags.ContainsKey(item.Tag) == true)
                            { dicTopHashTags[item.Tag]++; }
                            else
                            { dicTopHashTags.Add(item.Tag, 1); }
                        }

                        if (blnHasHashTags == true) { intHashTagCount++; }
                    }

                    //========================================================================
                    // Check to see if we got some Url's. If so let's add them to the 
                    // dictionary and increment our Url counter.
                    //========================================================================
                    if (tweet.Data.Entities.Urls != null)
                    {
                        bool blnHasUrls = false;
                        foreach (var item in tweet.Data.Entities.Urls)
                        {
                            blnHasUrls = true;

                            if (dicTopUrlDomains.ContainsKey(item.ExpandedUrl.Host) == true)
                            { dicTopUrlDomains[item.ExpandedUrl.Host]++; }
                            else
                            { dicTopUrlDomains.Add(item.ExpandedUrl.Host, 1); }
                        }

                        if (blnHasUrls == true) { intUrlCount++; }
                    }
                }

                //========================================================================
                // Now let's grab just the actual Tweet text and create a codepoint for 
                // each char to test for emoji's. If char is emoji let's increment our
                // emoji counter and add emoji to dictionary. 
                //========================================================================
                var tweetText = tweet.Data.Text.Codepoints().ToList();
                bool blnHasEmojis = false;
                foreach (var item in tweetText)
                {
                    if (Emoji.IsEmoji(item.AsString()))
                    {
                        blnHasEmojis = true;

                        if (dicTopEmojis.ContainsKey(item.ToString()) == true)
                        { dicTopEmojis[item.ToString()]++; }
                        else
                        { dicTopEmojis.Add(item.ToString(), 1); }
                    }
                }

                if (blnHasEmojis == true) { intEmojiCount++; }

                try
                {
                    //========================================================================
                    // Let's update the interface with all calculations, statistics and top
                    // totals for each ListView. Force the app to paint. 
                    //========================================================================
                    if ((intTweetCount % 50) == 0)
                    {
                        intAvgPerSec = intTweetCount / intTotalSeconds;
                        intAvgPerMin = intAvgPerSec * 60;
                        intAvgPerHr = intAvgPerMin * 60;

                        lblCount.Text = intTweetCount.ToString();
                        lblUrlCount.Text = intUrlCount.ToString();
                        lblPhotoCount.Text = intPhotoCount.ToString();
                        lblEmojiCount.Text = intEmojiCount.ToString();
                        lblHashTagCount.Text = intHashTagCount.ToString();
                        lblUrlPercentage.Text = string.Format("{0:0.0%}", ((double)intUrlCount / intTweetCount));
                        lblPhotoPercentage.Text = string.Format("{0:0.0%}", ((double)intPhotoCount / intTweetCount));
                        lblEmojiPercentage.Text = string.Format("{0:0.0%}", ((double)intEmojiCount / intTweetCount));
                        lblHashTagPercentage.Text = string.Format("{0:0.0%}", ((double)intHashTagCount / intTweetCount));
                        lblElapsedTime.Text = string.Format("{0:hh\\:mm\\:ss}", DateTime.Now.Subtract(dtStart));
                        lblAvgPerSec.Text = intAvgPerSec.ToString("n0");
                        lblAvgPerMin.Text = intAvgPerMin.ToString("n0");
                        lblAvgPerHr.Text = intAvgPerHr.ToString("n0");

                        LoadEmojis();
                        LoadHashtags();
                        LoadTopUrlDomains();

                        //========================================================================
                        // Used moreless for visibility to show sample tweets and payloads. 
                        // Showing the RAW JSON payload is more for debug purposes. 
                        //========================================================================
                        txtTweet.Text = tweet.Data.Text;
                        txtJson.Text = JsonConvert.SerializeObject(JsonConvert.DeserializeObject(eventArgs.StreamDataResponse), Formatting.Indented);
                        Application.DoEvents();
                    }
                }
                catch (Exception eUICalc)
                {
                    MessageBox.Show("Error Calculating and Updating Interface. Exception: " + eUICalc.Message);
                }
            }
            catch (Exception eGeneral)
            {
                MessageBox.Show("Tweet Received Error. Exception: " + eGeneral.Message);
            }

        }

        /// <summary>
        /// Used to Load all Emojis in the ListView control and sort based on most frequently used Emojis.
        /// </summary>
        private void LoadEmojis()
        {
            try
            {
                lvEmojis.Items.Clear();
                foreach (var item in dicTopEmojis)
                {
                    //========================================================================
                    // TODO: If had more time I'd update the Emoji Name column with the
                    //       correct name of the emoji instead of the code.
                    //
                    // TODO: If had more time I'd update the logic to pull in complex emojis
                    //       such as color tone etc which requires combining multiple emojis.
                    //       For now some emoji images might be missing from the ListView.
                    //========================================================================
                    ListViewItem lvi = new ListViewItem(item.Value.ToString());
                    lvi.SubItems.Add(item.Key);
                    lvi.SubItems.Add(item.Key);
                    lvi.ImageKey = item.Key.Replace("U+", "") + ".png";
                    lvEmojis.Items.Add(lvi);
                }

                        ((Sorter)lvEmojis.ListViewItemSorter).Order = SortOrder.Descending;
                lvEmojis.Sort();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading Emojis into ListView Control. Exception: " + e.Message);
            }

        }

        /// <summary>
        /// Used to Load all Hashtags in the ListView control and sort based on most frequently used Hashtag.
        /// </summary>
        private void LoadHashtags()
        {
            try
            {
                lvHastTags.Items.Clear();
                foreach (var item in dicTopHashTags)
                {
                    ListViewItem lvi = new ListViewItem(item.Value.ToString());
                    lvi.SubItems.Add(item.Key);
                    lvHastTags.Items.Add(lvi);
                }

                        ((Sorter)lvHastTags.ListViewItemSorter).Order = SortOrder.Descending;
                lvHastTags.Sort();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading Hashtags into ListView Control. Exception: " + e.Message);
            }
        }

        /// <summary>
        /// Used to Load all Top Url Domains in the ListView control and sort based on most frequently used Url Domains.
        /// </summary>
        private void LoadTopUrlDomains()
        {
            try
            {
                lvTopUrlDomains.Items.Clear();
                foreach (var item in dicTopUrlDomains)
                {
                    ListViewItem lvi = new ListViewItem(item.Value.ToString());
                    lvi.SubItems.Add(item.Key);
                    lvTopUrlDomains.Items.Add(lvi);
                }

                        ((Sorter)lvTopUrlDomains.ListViewItemSorter).Order = SortOrder.Descending;
                lvTopUrlDomains.Sort();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading Top Url Domains into ListView Control. Exception: " + e.Message);
            }
        }


    }

    //===========================================================================================
    // Scoped this code to help with sorting for ListView's.
    // https://stackoverflow.com/questions/1214289/how-do-i-sort-integers-in-a-listview
    // http://www.nullskull.com/q/10332201/listview-sorting-in-numeric-intfloat--format.aspx
    //===========================================================================================
    /// <summary>
    /// Used to help with sorting ListViews
    /// </summary>
    class Sorter : System.Collections.IComparer
    {
        public int Column = 0;
        public System.Windows.Forms.SortOrder Order = SortOrder.Ascending;
        public int Compare(object x, object y) // IComparer Member
        {
            try
            {
                if (!(x is ListViewItem))
                    return (0);
                if (!(y is ListViewItem))
                    return (0);

                ListViewItem l1 = (ListViewItem)x;
                ListViewItem l2 = (ListViewItem)y;

                if (l1.ListView.Columns[Column].Tag == null)
                {
                    l1.ListView.Columns[Column].Tag = "Text";
                }

                if (l1.ListView.Columns[Column].Tag.ToString() == "Numeric")
                {
                    float fl1 = float.Parse(l1.SubItems[Column].Text);
                    float fl2 = float.Parse(l2.SubItems[Column].Text);

                    if (Order == SortOrder.Ascending)
                    {
                        return fl1.CompareTo(fl2);
                    }
                    else
                    {
                        return fl2.CompareTo(fl1);
                    }
                }
                else
                {
                    string str1 = l1.SubItems[Column].Text;
                    string str2 = l2.SubItems[Column].Text;

                    if (Order == SortOrder.Ascending)
                    {
                        return str1.CompareTo(str2);
                    }
                    else
                    {
                        return str2.CompareTo(str1);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error sorting for ListView Control. Exception: " + e.Message);
                return 0;
            }
        }
    }


}
