
namespace RJHen.TwitterStats
{
    partial class MainStats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainStats));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxTweets = new System.Windows.Forms.TextBox();
            this.lvTopUrlDomains = new System.Windows.Forms.ListView();
            this.lblEmojiPercentage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmojiCount = new System.Windows.Forms.Label();
            this.lvHastTags = new System.Windows.Forms.ListView();
            this.lvEmojis = new System.Windows.Forms.ListView();
            this.lblPhotoPercentage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPhotoCount = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtJson = new System.Windows.Forms.RichTextBox();
            this.lblHashTagPercentage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHashTagCount = new System.Windows.Forms.Label();
            this.lblUrlPercentage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUrlCount = new System.Windows.Forms.Label();
            this.txtTweet = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAvgPerHr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAvgPerMin = new System.Windows.Forms.Label();
            this.lblTweetsPerSecLabel = new System.Windows.Forms.Label();
            this.lblAvgPerSec = new System.Windows.Forms.Label();
            this.lblCountLabel = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::RJHen.TwitterStats.Properties.Resources.hen;
            this.pictureBox1.InitialImage = global::RJHen.TwitterStats.Properties.Resources.hen;
            this.pictureBox1.Location = new System.Drawing.Point(1055, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(484, 58);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "RJ Hen Twitter Stats";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaxTweets);
            this.panel1.Controls.Add(this.lvTopUrlDomains);
            this.panel1.Controls.Add(this.lblEmojiPercentage);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblEmojiCount);
            this.panel1.Controls.Add(this.lvHastTags);
            this.panel1.Controls.Add(this.lvEmojis);
            this.panel1.Controls.Add(this.lblPhotoPercentage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblPhotoCount);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtJson);
            this.panel1.Controls.Add(this.lblHashTagPercentage);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblHashTagCount);
            this.panel1.Controls.Add(this.lblUrlPercentage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblUrlCount);
            this.panel1.Controls.Add(this.txtTweet);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblAvgPerHr);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAvgPerMin);
            this.panel1.Controls.Add(this.lblTweetsPerSecLabel);
            this.panel1.Controls.Add(this.lblAvgPerSec);
            this.panel1.Controls.Add(this.lblCountLabel);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 575);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Max Tweets:";
            // 
            // txtMaxTweets
            // 
            this.txtMaxTweets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaxTweets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxTweets.Location = new System.Drawing.Point(189, 486);
            this.txtMaxTweets.Name = "txtMaxTweets";
            this.txtMaxTweets.Size = new System.Drawing.Size(100, 24);
            this.txtMaxTweets.TabIndex = 36;
            this.txtMaxTweets.Text = "1000";
            // 
            // lvTopUrlDomains
            // 
            this.lvTopUrlDomains.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvTopUrlDomains.GridLines = true;
            this.lvTopUrlDomains.HideSelection = false;
            this.lvTopUrlDomains.Location = new System.Drawing.Point(770, 70);
            this.lvTopUrlDomains.Name = "lvTopUrlDomains";
            this.lvTopUrlDomains.Size = new System.Drawing.Size(221, 488);
            this.lvTopUrlDomains.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvTopUrlDomains.TabIndex = 35;
            this.lvTopUrlDomains.UseCompatibleStateImageBehavior = false;
            this.lvTopUrlDomains.View = System.Windows.Forms.View.Details;
            // 
            // lblEmojiPercentage
            // 
            this.lblEmojiPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmojiPercentage.Location = new System.Drawing.Point(230, 136);
            this.lblEmojiPercentage.Name = "lblEmojiPercentage";
            this.lblEmojiPercentage.Size = new System.Drawing.Size(70, 23);
            this.lblEmojiPercentage.TabIndex = 34;
            this.lblEmojiPercentage.Text = "0";
            this.lblEmojiPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-10, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Emoji Count:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmojiCount
            // 
            this.lblEmojiCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmojiCount.Location = new System.Drawing.Point(159, 136);
            this.lblEmojiCount.Name = "lblEmojiCount";
            this.lblEmojiCount.Size = new System.Drawing.Size(62, 23);
            this.lblEmojiCount.TabIndex = 32;
            this.lblEmojiCount.Text = "0";
            this.lblEmojiCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvHastTags
            // 
            this.lvHastTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvHastTags.GridLines = true;
            this.lvHastTags.HideSelection = false;
            this.lvHastTags.Location = new System.Drawing.Point(331, 70);
            this.lvHastTags.Name = "lvHastTags";
            this.lvHastTags.Size = new System.Drawing.Size(206, 488);
            this.lvHastTags.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvHastTags.TabIndex = 31;
            this.lvHastTags.UseCompatibleStateImageBehavior = false;
            this.lvHastTags.View = System.Windows.Forms.View.Details;
            // 
            // lvEmojis
            // 
            this.lvEmojis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvEmojis.GridLines = true;
            this.lvEmojis.HideSelection = false;
            this.lvEmojis.Location = new System.Drawing.Point(543, 70);
            this.lvEmojis.Name = "lvEmojis";
            this.lvEmojis.Size = new System.Drawing.Size(221, 488);
            this.lvEmojis.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvEmojis.TabIndex = 30;
            this.lvEmojis.UseCompatibleStateImageBehavior = false;
            this.lvEmojis.View = System.Windows.Forms.View.Details;
            // 
            // lblPhotoPercentage
            // 
            this.lblPhotoPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoPercentage.Location = new System.Drawing.Point(230, 108);
            this.lblPhotoPercentage.Name = "lblPhotoPercentage";
            this.lblPhotoPercentage.Size = new System.Drawing.Size(70, 23);
            this.lblPhotoPercentage.TabIndex = 28;
            this.lblPhotoPercentage.Text = "0";
            this.lblPhotoPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-10, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Photo Count:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPhotoCount
            // 
            this.lblPhotoCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhotoCount.Location = new System.Drawing.Point(159, 108);
            this.lblPhotoCount.Name = "lblPhotoCount";
            this.lblPhotoCount.Size = new System.Drawing.Size(62, 23);
            this.lblPhotoCount.TabIndex = 26;
            this.lblPhotoCount.Text = "0";
            this.lblPhotoCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(13, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 2);
            this.panel4.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(13, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 2);
            this.panel3.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(319, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 540);
            this.panel2.TabIndex = 23;
            // 
            // txtJson
            // 
            this.txtJson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJson.Location = new System.Drawing.Point(997, 70);
            this.txtJson.Name = "txtJson";
            this.txtJson.Size = new System.Drawing.Size(89, 488);
            this.txtJson.TabIndex = 22;
            this.txtJson.Text = "";
            // 
            // lblHashTagPercentage
            // 
            this.lblHashTagPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHashTagPercentage.Location = new System.Drawing.Point(230, 81);
            this.lblHashTagPercentage.Name = "lblHashTagPercentage";
            this.lblHashTagPercentage.Size = new System.Drawing.Size(70, 23);
            this.lblHashTagPercentage.TabIndex = 21;
            this.lblHashTagPercentage.Text = "0";
            this.lblHashTagPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-10, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "HashTag Count:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHashTagCount
            // 
            this.lblHashTagCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHashTagCount.Location = new System.Drawing.Point(159, 81);
            this.lblHashTagCount.Name = "lblHashTagCount";
            this.lblHashTagCount.Size = new System.Drawing.Size(62, 23);
            this.lblHashTagCount.TabIndex = 19;
            this.lblHashTagCount.Text = "0";
            this.lblHashTagCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUrlPercentage
            // 
            this.lblUrlPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlPercentage.Location = new System.Drawing.Point(226, 53);
            this.lblUrlPercentage.Name = "lblUrlPercentage";
            this.lblUrlPercentage.Size = new System.Drawing.Size(74, 23);
            this.lblUrlPercentage.TabIndex = 17;
            this.lblUrlPercentage.Text = "0";
            this.lblUrlPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "URL Count:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUrlCount
            // 
            this.lblUrlCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlCount.Location = new System.Drawing.Point(152, 53);
            this.lblUrlCount.Name = "lblUrlCount";
            this.lblUrlCount.Size = new System.Drawing.Size(69, 23);
            this.lblUrlCount.TabIndex = 15;
            this.lblUrlCount.Text = "0";
            this.lblUrlCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTweet
            // 
            this.txtTweet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTweet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTweet.Location = new System.Drawing.Point(331, 20);
            this.txtTweet.Name = "txtTweet";
            this.txtTweet.Size = new System.Drawing.Size(755, 44);
            this.txtTweet.TabIndex = 14;
            this.txtTweet.Text = "";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-18, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Avg Per Hour:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvgPerHr
            // 
            this.lblAvgPerHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPerHr.Location = new System.Drawing.Point(145, 247);
            this.lblAvgPerHr.Name = "lblAvgPerHr";
            this.lblAvgPerHr.Size = new System.Drawing.Size(76, 23);
            this.lblAvgPerHr.TabIndex = 10;
            this.lblAvgPerHr.Text = "0";
            this.lblAvgPerHr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-18, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Avg Per Minute:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvgPerMin
            // 
            this.lblAvgPerMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPerMin.Location = new System.Drawing.Point(145, 220);
            this.lblAvgPerMin.Name = "lblAvgPerMin";
            this.lblAvgPerMin.Size = new System.Drawing.Size(76, 23);
            this.lblAvgPerMin.TabIndex = 8;
            this.lblAvgPerMin.Text = "0";
            this.lblAvgPerMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTweetsPerSecLabel
            // 
            this.lblTweetsPerSecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTweetsPerSecLabel.Location = new System.Drawing.Point(-18, 193);
            this.lblTweetsPerSecLabel.Name = "lblTweetsPerSecLabel";
            this.lblTweetsPerSecLabel.Size = new System.Drawing.Size(163, 23);
            this.lblTweetsPerSecLabel.TabIndex = 7;
            this.lblTweetsPerSecLabel.Text = "Avg Per Second:";
            this.lblTweetsPerSecLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvgPerSec
            // 
            this.lblAvgPerSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPerSec.Location = new System.Drawing.Point(145, 193);
            this.lblAvgPerSec.Name = "lblAvgPerSec";
            this.lblAvgPerSec.Size = new System.Drawing.Size(76, 23);
            this.lblAvgPerSec.TabIndex = 6;
            this.lblAvgPerSec.Text = "0";
            this.lblAvgPerSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCountLabel
            // 
            this.lblCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountLabel.Location = new System.Drawing.Point(12, 25);
            this.lblCountLabel.Name = "lblCountLabel";
            this.lblCountLabel.Size = new System.Drawing.Size(133, 23);
            this.lblCountLabel.TabIndex = 2;
            this.lblCountLabel.Text = "Count:";
            this.lblCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(152, 25);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(69, 23);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(33, 516);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(256, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsedTime.Location = new System.Drawing.Point(502, 9);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(547, 58);
            this.lblElapsedTime.TabIndex = 3;
            this.lblElapsedTime.Text = "00:00:00";
            this.lblElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblElapsedTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainStats";
            this.Text = "RJ Hen - Twitter Stats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblCountLabel;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Label lblTweetsPerSecLabel;
        private System.Windows.Forms.Label lblAvgPerSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAvgPerHr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAvgPerMin;
        private System.Windows.Forms.RichTextBox txtTweet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUrlCount;
        private System.Windows.Forms.Label lblUrlPercentage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHashTagCount;
        private System.Windows.Forms.Label lblHashTagPercentage;
        private System.Windows.Forms.RichTextBox txtJson;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPhotoPercentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPhotoCount;
        private System.Windows.Forms.ListView lvEmojis;
        private System.Windows.Forms.ListView lvHastTags;
        private System.Windows.Forms.Label lblEmojiPercentage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEmojiCount;
        private System.Windows.Forms.ListView lvTopUrlDomains;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxTweets;
    }
}

