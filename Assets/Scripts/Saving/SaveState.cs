[System.Serializable]
public class SaveState 
{
    
    public int level = 1;
    public int maxLevel;

    public int levelHighScore = 1;


    public int gameCount;

    public int currency = 0;

    //Shop
    public int indexOfSelectedWheel = 0;

    public bool broughtAds;

    //Common
    public bool item0 = true;
    public bool item1;
    public bool item2;

    //Rare
    public bool item3;
    public bool item4;
    public bool item5;

    //Epic
    public bool item6;
    public bool item7;
    public bool item8;

    //Legendary
    public bool item9;
    public bool item10;
    public bool item11;


    //Mystery
    public bool item12;
    public bool item13;
    public bool item14;


    //Infinite
    public int highScore;

    //Setting
    public bool sound = true;

    //first
    public bool first = false;

    //Google Play
    public bool googleService = true;



}
