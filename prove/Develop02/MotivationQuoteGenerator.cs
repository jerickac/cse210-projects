public class MotivationQuoteGenerator
{
    public List<string> _motivationQuotes = new List<string>();
    
    // int j = 0;
    int randomNumber = 0;

    public string GetRandomMotivationQuote()
    {
        _motivationQuotes.Add("'I personally believe that the writing of personal and family histories will do more to turn the hearts of the children to the fathers and the fathers to children than almost anything we can do. I am sure you will never turn your own children’s hearts more to you than you will by keeping a journal and writing your personal history. They will ultimately love to find out about your successes and your failures and your peculiarities. It will tell them a lot about themselves, too. They will get a great desire to raise a family of their own when they see what a great blessing they were to you.” (Hartman Rector, Jr.)'");
        _motivationQuotes.Add("“Sometimes we feel we just don’t have time to write in our journals. I wonder. President Kimball stood before the World Conference on Records last August and said: ‘By now, in my own personal history, I have managed to fill seventy-eight large volumes, which are my personal journal. There have been times when I have been so tired at the end of a day that the effort could hardly be managed, but I am so grateful that I have not let slip away from me and my posterity those things which needed to be recorded.’” (Hartman Rector, Jr.)");
        _motivationQuotes.Add("'When our children were very small, I started to write down a few things about what happened every day. … I wrote down a few lines every day for years. I never missed a day no matter how tired I was or how early I would have to start the next day. Before I would write, I would ponder this question: ‘Have I seen the hand of God reaching out to touch us or our children or our family today? As I kept at it, something began to happen. As I would cast my mind over the day, I would see evidence of what God had done for one of us that I had not recognized in the busy moments of the day. As that happened, and it happened often, I realized that trying to remember had allowed God to show me what He had done. More than gratitude began to grow in my heart. Testimony grew. I became ever more certain that our Heavenly Father hears and answers prayers. I felt more gratitude for the softening and refining that come because of the Atonement of the Savior, Jesus Christ. And I grew more confident that the Holy Ghost can bring all things to our remembrance—even things we did not notice or pay attention to when they happened. My point is to urge you to find ways to recognize and remember God’s kindness. It will build our testimonies. You may not keep a journal. You may not share whatever record you keep with those you love and serve. But you and they will be blessed as you remember what the Lord has done.' (Henry B. Eyring)");
        _motivationQuotes.Add("'Of course, it is the right of every father and his duty as patriarch of his own family to give a father’s blessing to his children, and it is our hope that every father will give a sacred blessing to each of his children, especially as they are leaving home to go to school or on missions or to be married, which blessing should then be noted in the individual’s private journal.' (Spencer W. Kimball)");
        _motivationQuotes.Add("'A word about personal journals and records: We urge every person in the Church to keep a diary or a journal from youth up, all through his life. Would every family, as they now hold their home evenings, train their children from young childhood to keep a journal of the important activities of their lives, and certainly when they begin to leave home for schooling and missions?' (Spencer W. Kimball)");
        _motivationQuotes.Add("'Every person should keep a journal and every person can keep a journal. It should be an enlightening one and should bring great blessings and happiness to the families. If there is anyone here who isn’t doing so, will you repent today and change—change your life?' (Spencer W. Kimball)");
        
        Random rnd = new Random(); 

        for (int j = 0; j < 1; j++);
        randomNumber = rnd.Next(5);
        // Console.WriteLine(_prompts[randomNumber]);

        return _motivationQuotes[randomNumber];
    }
}