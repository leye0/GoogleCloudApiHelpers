namespace GoogleCloudApiHelper.NaturalLanguageApi
{
    public class PartOfSpeech
    {
        public string Mood { get; set; }
        public string Gender { get; set; }
        public string Form { get; set; }
        public string Case { get; set; }
        public string Aspect { get; set; }
        public string Tag { get; set; }
        public string Person { get; set; }
        public string Number { get; set; }
        public string Reciprocity { get; set; }
        public string Tense { get; set; }
        public string Voice { get; set; }
        public string Proper { get; set; }

        //public Types.Mood Mood { get; set; }
        //public Types.Gender Gender { get; set; }
        //public Types.Form Form { get; set; }
        //public Types.Case Case { get; set; }
        //public Types.Aspect Aspect { get; set; }
        //public Types.Tag Tag { get; set; }
        //public Types.Person Person { get; set; }
        //public Types.Number Number { get; set; }
        //public Types.Reciprocity Reciprocity { get; set; }
        //public Types.Tense Tense { get; set; }
        //public Types.Voice Voice { get; set; }
        //public Types.Proper Proper { get; set; }

        //public static class Types
        //{
        //    //
        //    // Summary:
        //    //     The part of speech tags enum.
        //    public enum Tag
        //    {
        //        //
        //        // Summary:
        //        //     Unknown
        //        Unknown = 0,
        //        //
        //        // Summary:
        //        //     Adjective
        //        Adj = 1,
        //        //
        //        // Summary:
        //        //     Adposition (preposition and postposition)
        //        Adp = 2,
        //        //
        //        // Summary:
        //        //     Adverb
        //        Adv = 3,
        //        //
        //        // Summary:
        //        //     Conjunction
        //        Conj = 4,
        //        //
        //        // Summary:
        //        //     Determiner
        //        Det = 5,
        //        //
        //        // Summary:
        //        //     Noun (common and proper)
        //        Noun = 6,
        //        //
        //        // Summary:
        //        //     Cardinal number
        //        Num = 7,
        //        //
        //        // Summary:
        //        //     Pronoun
        //        Pron = 8,
        //        //
        //        // Summary:
        //        //     Particle or other function word
        //        Prt = 9,
        //        //
        //        // Summary:
        //        //     Punctuation
        //        Punct = 10,
        //        //
        //        // Summary:
        //        //     Verb (all tenses and modes)
        //        Verb = 11,
        //        //
        //        // Summary:
        //        //     Other: foreign words, typos, abbreviations
        //        X = 12,
        //        //
        //        // Summary:
        //        //     Affix
        //        Affix = 13
        //    }
        //    //
        //    // Summary:
        //    //     The characteristic of a verb that expresses time flow during an event.
        //    public enum Aspect
        //    {
        //        //
        //        // Summary:
        //        //     Aspect is not applicable in the analyzed language or is not predicted.
        //        Unknown = 0,
        //        //
        //        // Summary:
        //        //     Perfective
        //        Perfective = 1,
        //        //
        //        // Summary:
        //        //     Imperfective
        //        Imperfective = 2,
        //        //
        //        // Summary:
        //        //     Progressive
        //        Progressive = 3
        //    }
        //    //
        //    // Summary:
        //    //     The grammatical function performed by a noun or pronoun in a phrase, clause,
        //    //     or sentence. In some languages, other parts of speech, such as adjective and
        //    //     determiner, take case inflection in agreement with the noun.
        //    public enum Case
        //    {
        //        //
        //        // Summary:
        //        //     Case is not applicable in the analyzed language or is not predicted.
        //        Unknown = 0,
        //        //
        //        // Summary:
        //        //     Accusative
        //        Accusative = 1,
        //        //
        //        // Summary:
        //        //     Adverbial
        //        Adverbial = 2,
        //        //
        //        // Summary:
        //        //     Complementive
        //        Complementive = 3,
        //        //
        //        // Summary:
        //        //     Dative
        //        Dative = 4,
        //        //
        //        // Summary:
        //        //     Genitive
        //        Genitive = 5,
        //        //
        //        // Summary:
        //        //     Instrumental
        //        Instrumental = 6,
        //        //
        //        // Summary:
        //        //     Locative
        //        Locative = 7,
        //        //
        //        // Summary:
        //        //     Nominative
        //        Nominative = 8,
        //        //
        //        // Summary:
        //        //     Oblique
        //        Oblique = 9,
        //        //
        //        // Summary:
        //        //     Partitive
        //        Partitive = 10,
        //        //
        //        // Summary:
        //        //     Prepositional
        //        Prepositional = 11,
        //        //
        //        // Summary:
        //        //     Reflexive
        //        ReflexiveCase = 12,
        //        //
        //        // Summary:
        //        //     Relative
        //        RelativeCase = 13,
        //        //
        //        // Summary:
        //        //     Vocative
        //        Vocative = 14
        //    }
        //    //
        //    // Summary:
        //    //     Depending on the language, Form can be categorizing different forms of verbs,
        //    //     adjectives, adverbs, etc. For example, categorizing inflected endings of verbs
        //    //     and adjectives or distinguishing between short and long forms of adjectives and
        //    //     participles
        //    public enum Form
        //    {
        //        //
        //        // Summary:
        //        //     Form is not applicable in the analyzed language or is not predicted.
        //        Unknown = 0,
        //        //
        //        // Summary:
        //        //     Adnomial
        //        Adnomial = 1,
        //        //
        //        // Summary:
        //        //     Auxiliary
        //        Auxiliary = 2,
        //        //
        //        // Summary:
        //        //     Complementizer
        //        Complementizer = 3,
        //        //
        //        // Summary:
        //        //     Final ending
        //        FinalEnding = 4,
        //        //
        //        // Summary:
        //        //     Gerund
        //        Gerund = 5,
        //        //
        //        // Summary:
        //        //     Realis
        //        Realis = 6,
        //        //
        //        // Summary:
        //        //     Irrealis
        //        Irrealis = 7,
        //        //
        //        // Summary:
        //        //     Short form
        //        Short = 8,
        //        //
        //        // Summary:
        //        //     Long form
        //        Long = 9,
        //        //
        //        // Summary:
        //        //     Order form
        //        Order = 10,
        //        //
        //        // Summary:
        //        //     Specific form
        //        Specific = 11
        //    }
        //    //
        //    // Summary:
        //    //     Gender classes of nouns reflected in the behaviour of associated words.
        //    public enum Gender
        //    {
        //        //
        //        // Summary:
        //        //     Gender is not applicable in the analyzed language or is not predicted.
        //        Unknown = 0,
        //        //
        //        // Summary:
        //        //     Feminine
        //        Feminine = 1,
        //        //
        //        // Summary:
        //        //     Masculine
        //        Masculine = 2,
        //        //
        //        // Summary:
        //        //     Neuter
        //        Neuter = 3
        //    }
        //    //
        //    // Summary:
        //    //     The grammatical feature of verbs, used for showing modality and attitude.
        //    public enum Mood
        //    {
        //        //
        //        // Summary:
        //        //     Mood is not applicable in the analyzed language or is not predicted.
        //        Unknown = 0,
        //        //
        //        // Summary:
        //        //     Conditional
        //        ConditionalMood = 1,
        //        //
        //        // Summary:
        //        //     Imperative
        //        Imperative = 2,
        //        //
        //        // Summary:
        //        //     Indicative
        //        Indicative = 3,
        //        //
        //        // Summary:
        //        //     Interrogative
        //        Interrogative = 4,
        //        //
        //        // Summary:
        //        //     Jussive
        //        Jussive = 5,
        //        //
        //        // Summary:
        //        //     Subjunctive
        //        Subjunctive = 6
        //    }
        //    //
        //    // Summary:
        //    //     Count distinctions.
        //    public enum Number
        //    {
        //        //
        //        // Summary:
        //        //     Number is not applicable in the analyzed language or is not predicted.
        //        Unknown = 0,
        //        //
        //        // Summary:
        //        //     Singular
        //        Singular = 1,
        //        //
        //        // Summary:
        //        //     Plural
        //        Plural = 2,
        //        //
        //        // Summary:
        //        //     Dual
        //        Dual = 3
        //    }
        //    //
        //    // Summary:
        //    //     The distinction between the speaker, second person, third person, etc.
        //    public enum Person
        //    {
        //        //
        //        // Summary:
        //        //     Person is not applicable in the analyzed language or is not predicted.
        //        Unknown = 0,
        //        //
        //        // Summary:
        //        //     First
        //        First = 1,
        //        //
        //        // Summary:
        //        //     Second
        //        Second = 2,
        //        //
        //        // Summary:
        //        //     Third
        //        Third = 3,
        //        //
        //        // Summary:
        //        //     Reflexive
        //        ReflexivePerson = 4
        //    }
        //    //
        //    // Summary:
        //    //     This category shows if the token is part of a proper name.
        //    public enum Proper
        //    {
        //        //
        //        // Summary:
        //        //     Proper is not applicable in the analyzed language or is not predicted.
        //        Unknown = 0,
        //        //
        //        // Summary:
        //        //     Proper
        //        Proper = 1,
        //        //
        //        // Summary:
        //        //     Not proper
        //        NotProper = 2
        //    }
        //    //
        //    // Summary:
        //    //     Reciprocal features of a pronoun.
        //    public enum Reciprocity
        //    {
        //        //
        //        // Summary:
        //        //     Reciprocity is not applicable in the analyzed language or is not predicted.
        //        Unknown = 0,
        //        //
        //        // Summary:
        //        //     Reciprocal
        //        Reciprocal = 1,
        //        //
        //        // Summary:
        //        //     Non-reciprocal
        //        NonReciprocal = 2
        //    }
        //    //
        //    // Summary:
        //    //     Time reference.
        //    public enum Tense
        //    {
        //        //
        //        // Summary:
        //        //     Tense is not applicable in the analyzed language or is not predicted.
        //        Unknown = 0,
        //        //
        //        // Summary:
        //        //     Conditional
        //        ConditionalTense = 1,
        //        //
        //        // Summary:
        //        //     Future
        //        Future = 2,
        //        //
        //        // Summary:
        //        //     Past
        //        Past = 3,
        //        //
        //        // Summary:
        //        //     Present
        //        Present = 4,
        //        //
        //        // Summary:
        //        //     Imperfect
        //        Imperfect = 5,
        //        //
        //        // Summary:
        //        //     Pluperfect
        //        Pluperfect = 6
        //    }
        //    //
        //    // Summary:
        //    //     The relationship between the action that a verb expresses and the participants
        //    //     identified by its arguments.
        //    public enum Voice
        //    {
        //        //
        //        // Summary:
        //        //     Voice is not applicable in the analyzed language or is not predicted.
        //        Unknown = 0,
        //        //
        //        // Summary:
        //        //     Active
        //        Active = 1,
        //        //
        //        // Summary:
        //        //     Causative
        //        Causative = 2,
        //        //
        //        // Summary:
        //        //     Passive
        //        Passive = 3
        //    }
        //}
    }
}
