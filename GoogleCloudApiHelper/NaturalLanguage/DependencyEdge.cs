namespace GoogleCloudApiHelper.NaturalLanguageApi
{
    public class DependencyEdge
    {
        public Types.Label Label { get; set; }
        public int HeadTokenIndex { get; set; }
        public static class Types
        {
            //
            // Summary:
            //     The parse label enum for the token.
            public enum Label
            {
                //
                // Summary:
                //     Unknown
                Unknown = 0,
                //
                // Summary:
                //     Abbreviation modifier
                Abbrev = 1,
                //
                // Summary:
                //     Adjectival complement
                Acomp = 2,
                //
                // Summary:
                //     Adverbial clause modifier
                Advcl = 3,
                //
                // Summary:
                //     Adverbial modifier
                Advmod = 4,
                //
                // Summary:
                //     Adjectival modifier of an NP
                Amod = 5,
                //
                // Summary:
                //     Appositional modifier of an NP
                Appos = 6,
                //
                // Summary:
                //     Attribute dependent of a copular verb
                Attr = 7,
                //
                // Summary:
                //     Auxiliary (non-main) verb
                Aux = 8,
                //
                // Summary:
                //     Passive auxiliary
                Auxpass = 9,
                //
                // Summary:
                //     Coordinating conjunction
                Cc = 10,
                //
                // Summary:
                //     Clausal complement of a verb or adjective
                Ccomp = 11,
                //
                // Summary:
                //     Conjunct
                Conj = 12,
                //
                // Summary:
                //     Clausal subject
                Csubj = 13,
                //
                // Summary:
                //     Clausal passive subject
                Csubjpass = 14,
                //
                // Summary:
                //     Dependency (unable to determine)
                Dep = 15,
                //
                // Summary:
                //     Determiner
                Det = 16,
                //
                // Summary:
                //     Discourse
                Discourse = 17,
                //
                // Summary:
                //     Direct object
                Dobj = 18,
                //
                // Summary:
                //     Expletive
                Expl = 19,
                //
                // Summary:
                //     Goes with (part of a word in a text not well edited)
                Goeswith = 20,
                //
                // Summary:
                //     Indirect object
                Iobj = 21,
                //
                // Summary:
                //     Marker (word introducing a subordinate clause)
                Mark = 22,
                //
                // Summary:
                //     Multi-word expression
                Mwe = 23,
                //
                // Summary:
                //     Multi-word verbal expression
                Mwv = 24,
                //
                // Summary:
                //     Negation modifier
                Neg = 25,
                //
                // Summary:
                //     Noun compound modifier
                Nn = 26,
                //
                // Summary:
                //     Noun phrase used as an adverbial modifier
                Npadvmod = 27,
                //
                // Summary:
                //     Nominal subject
                Nsubj = 28,
                //
                // Summary:
                //     Passive nominal subject
                Nsubjpass = 29,
                //
                // Summary:
                //     Numeric modifier of a noun
                Num = 30,
                //
                // Summary:
                //     Element of compound number
                Number = 31,
                //
                // Summary:
                //     Punctuation mark
                P = 32,
                //
                // Summary:
                //     Parataxis relation
                Parataxis = 33,
                //
                // Summary:
                //     Participial modifier
                Partmod = 34,
                //
                // Summary:
                //     The complement of a preposition is a clause
                Pcomp = 35,
                //
                // Summary:
                //     Object of a preposition
                Pobj = 36,
                //
                // Summary:
                //     Possession modifier
                Poss = 37,
                //
                // Summary:
                //     Postverbal negative particle
                Postneg = 38,
                //
                // Summary:
                //     Predicate complement
                Precomp = 39,
                //
                // Summary:
                //     Preconjunt
                Preconj = 40,
                //
                // Summary:
                //     Predeterminer
                Predet = 41,
                //
                // Summary:
                //     Prefix
                Pref = 42,
                //
                // Summary:
                //     Prepositional modifier
                Prep = 43,
                //
                // Summary:
                //     The relationship between a verb and verbal morpheme
                Pronl = 44,
                //
                // Summary:
                //     Particle
                Prt = 45,
                //
                // Summary:
                //     Associative or possessive marker
                Ps = 46,
                //
                // Summary:
                //     Quantifier phrase modifier
                Quantmod = 47,
                //
                // Summary:
                //     Relative clause modifier
                Rcmod = 48,
                //
                // Summary:
                //     Complementizer in relative clause
                Rcmodrel = 49,
                //
                // Summary:
                //     Ellipsis without a preceding predicate
                Rdrop = 50,
                //
                // Summary:
                //     Referent
                Ref = 51,
                //
                // Summary:
                //     Remnant
                Remnant = 52,
                //
                // Summary:
                //     Reparandum
                Reparandum = 53,
                //
                // Summary:
                //     Root
                Root = 54,
                //
                // Summary:
                //     Suffix specifying a unit of number
                Snum = 55,
                //
                // Summary:
                //     Suffix
                Suff = 56,
                //
                // Summary:
                //     Temporal modifier
                Tmod = 57,
                //
                // Summary:
                //     Topic marker
                Topic = 58,
                //
                // Summary:
                //     Clause headed by an infinite form of the verb that modifies a noun
                Vmod = 59,
                //
                // Summary:
                //     Vocative
                Vocative = 60,
                //
                // Summary:
                //     Open clausal complement
                Xcomp = 61,
                //
                // Summary:
                //     Name suffix
                Suffix = 62,
                //
                // Summary:
                //     Name title
                Title = 63,
                //
                // Summary:
                //     Adverbial phrase modifier
                Advphmod = 64,
                //
                // Summary:
                //     Causative auxiliary
                Auxcaus = 65,
                //
                // Summary:
                //     Helper auxiliary
                Auxvv = 66,
                //
                // Summary:
                //     Rentaishi (Prenominal modifier)
                Dtmod = 67,
                //
                // Summary:
                //     Foreign words
                Foreign = 68,
                //
                // Summary:
                //     Keyword
                Kw = 69,
                //
                // Summary:
                //     List for chains of comparable items
                List = 70,
                //
                // Summary:
                //     Nominalized clause
                Nomc = 71,
                //
                // Summary:
                //     Nominalized clausal subject
                Nomcsubj = 72,
                //
                // Summary:
                //     Nominalized clausal passive
                Nomcsubjpass = 73,
                //
                // Summary:
                //     Compound of numeric modifier
                Numc = 74,
                //
                // Summary:
                //     Copula
                Cop = 75,
                //
                // Summary:
                //     Dislocated relation (for fronted/topicalized elements)
                Dislocated = 76,
                //
                // Summary:
                //     Aspect marker
                Asp = 77,
                //
                // Summary:
                //     Genitive modifier
                Gmod = 78,
                //
                // Summary:
                //     Genitive object
                Gobj = 79,
                //
                // Summary:
                //     Infinitival modifier
                Infmod = 80,
                //
                // Summary:
                //     Measure
                Mes = 81,
                //
                // Summary:
                //     Nominal complement of a noun
                Ncomp = 82
            }
        }
    }
}
