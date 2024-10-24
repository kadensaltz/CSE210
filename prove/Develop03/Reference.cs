using System;

public class Reference
{
    private string[] _references;
    private string[] _verses;
    private int _index;
    private string _currentReference;
    private string _currentVerse;

    public Reference()
    {
        _references = new string[] { "John 3:16", "1 Nephi 3:7", "D&C 130:22", "D&C 58:42", "D&C 82:10" };
        _verses = new string[] {
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",

            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",

            "The Father has a body of flesh and bones as tangible as man’s; the Son also; but the Holy Ghost has not a body of flesh and bones, but is a personage of Spirit. Were it not so, the Holy Ghost could not dwell in us.",

            "Behold, he who has repented of his sins, the same is forgiven, and I, the Lord, remember them no more.",
            
            "I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise."
        };
        _index = -1;
    }

    private void AssignRandomReferenceAndVerse()
    {
        if (_index == -1)
        {
            Random random = new Random();
            _index = random.Next(_references.Length);
            _currentReference = _references[_index];
            _currentVerse = _verses[_index];
        }
    }

    public string GetRef()
    {
        AssignRandomReferenceAndVerse();
        return _currentReference;
    }

    public string GetVerse()
    {
        AssignRandomReferenceAndVerse();
        return _currentVerse;
    }
}
