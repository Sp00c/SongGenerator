using System;
using System.Collections.Generic;
using System.Text;

namespace SongGenerator
{
    public static class DataSource
    {
        public static string NoteData =>
          @"    C	    | 0	| 16.351
                C#      | 0	| 17.324
                D	    | 0	| 18.354
                D#      | 0	| 19.445
                E	    | 0	| 20.601
                F	    | 0	| 21.827
                F#      | 0	| 23.124
                G	    | 0	| 24.499
                G#      | 0	| 25.956
                A	    | 0	| 27.5
                A#      | 0	| 29.135
                B	    | 0	| 30.868
                C	    | 1	| 32.703
                C#      | 1	| 34.648
                D	    | 1	| 36.708
                D#      | 1	| 38.891
                E	    | 1	| 41.203
                F	    | 1	| 43.654
                F#      | 1	| 46.249
                G	    | 1	| 48.999
                G#      | 1	| 51.913
                A	    | 1	| 55
                A#      | 1	| 58.27
                B	    | 1	| 61.735
                C	    | 2	| 65.406
                C#      | 2	| 69.296
                D	    | 2	| 73.416
                D#      | 2	| 77.782
                E	    | 2	| 82.407
                F	    | 2	| 87.307
                F#      | 2	| 92.499
                G	    | 2	| 97.999
                G#      | 2	| 103.826
                A	    | 2	| 110
                A#      | 2	| 116.541
                B       | 2	| 123.471
                C	    | 3	| 130.813
                C#      | 3	| 138.591
                D	    | 3	| 146.832
                D#      | 3	| 155.563
                E	    | 3	| 164.814
                F	    | 3	| 174.614
                F#      | 3	| 184.997
                G	    | 3	| 195.998
                G#      | 3	| 207.652
                A	    | 3	| 220
                A#      | 3	| 233.082
                B	    | 3	| 246.942
                C	    | 4	| 261.626
                C#      | 4	| 277.183
                D	    | 4	| 293.665
                D#      | 4	| 311.127
                E	    | 4	| 329.628
                F	    | 4	| 349.228
                F#      | 4	| 369.994
                G	    | 4	| 391.995
                G#      | 4	| 415.305
                A	    | 4	| 440
                A#      | 4	| 466.164
                B	    | 4	| 493.883
                C	    | 5	| 523.251
                C#      | 5	| 554.365
                D	    | 5	| 587.33
                D#      | 5	| 622.254
                E	    | 5	| 659.255
                F	    | 5	| 698.456
                F#      | 5	| 739.989
                G	    | 5	| 783.991
                G#      | 5	| 830.609
                A	    | 5	| 880
                A#      | 5	| 932.328
                B	    | 5	| 987.767
                C	    | 6	| 1046.502
                C#      | 6	| 1108.731
                D	    | 6	| 1174.659
                D#      | 6	| 1244.508
                E	    | 6	| 1318.51
                F	    | 6	| 1396.913
                F#      | 6	| 1479.978
                G	    | 6	| 1567.982
                G#      | 6	| 1661.219
                A	    | 6	| 1760
                A#      | 6	| 1864.655
                B	    | 6	| 1975.533
                C	    | 7	| 2093.005
                C#      | 7	| 2217.461
                D	    | 7	| 2349.318
                D#      | 7	| 2489.016
                E	    | 7	| 2637.021
                F	    | 7	| 2793.826
                F#      | 7	| 2959.955
                G	    | 7	| 3135.964
                G#      | 7	| 3322.438
                A	    | 7	| 3520
                A#      | 7	| 3729.31
                B	    | 7	| 3951.066
                C	    | 8	| 4186.009
                C#      | 8	| 4434.922
                D	    | 8	| 4698.636
                D#      | 8	| 4978.032
                E	    | 8	| 5274.042
                F	    | 8	| 5587.652
                F#      | 8	| 5919.91
                G	    | 8	| 6271.928
                G#      | 8	| 6644.876
                A	    | 8	| 7040
                A#      | 8	| 7458.62
                B	    | 8	| 7902.132
                C	    | 9	| 8372.018
                C#      | 9	| 8869.844
                D	    | 9	| 9397.272
                D#      | 9	| 9956.064
                E	    | 9	| 10548.084
                F	    | 9	| 11175.304
                F#      | 9	| 11839.82
                G	    | 9	| 12543.856
                G#      | 9	| 13289.752
                A	    | 9 | 14080
                A#      | 9	| 14917.24
                B	    | 9	| 15804.264
                ";
        //public static string NoteData =>
        //    @"  C	    | 0	| 16.351
        //        C# / Db | 0	| 17.324
        //        D	    | 0	| 18.354
        //        D# / Eb | 0	| 19.445
        //        E	    | 0	| 20.601
        //        F	    | 0	| 21.827
        //        F# / Gb | 0	| 23.124
        //        G	    | 0	| 24.499
        //        G# / Ab | 0	| 25.956
        //        A	    | 0	| 27.5
        //        A# / Bb | 0	| 29.135
        //        B	    | 0	| 30.868
        //        C	    | 1	| 32.703
        //        C# / Db | 1	| 34.648
        //        D	    | 1	| 36.708
        //        D# / Eb | 1	| 38.891
        //        E	    | 1	| 41.203
        //        F	    | 1	| 43.654
        //        F# / Gb | 1	| 46.249
        //        G	    | 1	| 48.999
        //        G# / Ab | 1	| 51.913
        //        A	    | 1	| 55
        //        A# / Bb | 1	| 58.27
        //        B	    | 1	| 61.735
        //        C	    | 2	| 65.406
        //        C# / Db | 2	| 69.296
        //        D	    | 2	| 73.416
        //        D# / Eb | 2	| 77.782
        //        E	    | 2	| 82.407
        //        F	    | 2	| 87.307
        //        F# / Gb | 2	| 92.499
        //        G	    | 2	| 97.999
        //        G# / Ab | 2	| 103.826
        //        A	    | 2	| 110
        //        A# / Bb | 2	| 116.541
        //        B       | 2	| 123.471
        //        C	    | 3	| 130.813
        //        C# / Db | 3	| 138.591
        //        D	    | 3	| 146.832
        //        D# / Eb | 3	| 155.563
        //        E	    | 3	| 164.814
        //        F	    | 3	| 174.614
        //        F# / Gb | 3	| 184.997
        //        G	    | 3	| 195.998
        //        G# / Ab | 3	| 207.652
        //        A	    | 3	| 220
        //        A# / Bb | 3	| 233.082
        //        B	    | 3	| 246.942
        //        C	    | 4	| 261.626
        //        C# / Db | 4	| 277.183
        //        D	    | 4	| 293.665
        //        D# / Eb | 4	| 311.127
        //        E	    | 4	| 329.628
        //        F	    | 4	| 349.228
        //        F# / Gb | 4	| 369.994
        //        G	    | 4	| 391.995
        //        G# / Ab | 4	| 415.305
        //        A	    | 4	| 440
        //        A# / Bb | 4	| 466.164
        //        B	    | 4	| 493.883
        //        C	    | 5	| 523.251
        //        C# / Db | 5	| 554.365
        //        D	    | 5	| 587.33
        //        D# / Eb | 5	| 622.254
        //        E	    | 5	| 659.255
        //        F	    | 5	| 698.456
        //        F# / Gb | 5	| 739.989
        //        G	    | 5	| 783.991
        //        G# / Ab | 5	| 830.609
        //        A	    | 5	| 880
        //        A# / Bb | 5	| 932.328
        //        B	    | 5	| 987.767
        //        C	    | 6	| 1046.502
        //        C# / Db | 6	| 1108.731
        //        D	    | 6	| 1174.659
        //        D# / Eb | 6	| 1244.508
        //        E	    | 6	| 1318.51
        //        F	    | 6	| 1396.913
        //        F# / Gb | 6	| 1479.978
        //        G	    | 6	| 1567.982
        //        G# / Ab | 6	| 1661.219
        //        A	    | 6	| 1760
        //        A# / Bb | 6	| 1864.655
        //        B	    | 6	| 1975.533
        //        C	    | 7	| 2093.005
        //        C# / Db | 7	| 2217.461
        //        D	    | 7	| 2349.318
        //        D# / Eb | 7	| 2489.016
        //        E	    | 7	| 2637.021
        //        F	    | 7	| 2793.826
        //        F# / Gb | 7	| 2959.955
        //        G	    | 7	| 3135.964
        //        G# / Ab | 7	| 3322.438
        //        A	    | 7	| 3520
        //        A# / Bb | 7	| 3729.31
        //        B	    | 7	| 3951.066
        //        C	    | 8	| 4186.009
        //        C# / Db | 8	| 4434.922
        //        D	    | 8	| 4698.636
        //        D# / Eb | 8	| 4978.032
        //        E	    | 8	| 5274.042
        //        F	    | 8	| 5587.652
        //        F# / Gb | 8	| 5919.91
        //        G	    | 8	| 6271.928
        //        G# / Ab | 8	| 6644.876
        //        A	    | 8	| 7040
        //        A# / Bb | 8	| 7458.62
        //        B	    | 8	| 7902.132
        //        C	    | 9	| 8372.018
        //        C# / Db | 9	| 8869.844
        //        D	    | 9	| 9397.272
        //        D# / Eb | 9	| 9956.064
        //        E	    | 9	| 10548.084
        //        F	    | 9	| 11175.304
        //        F# / Gb | 9	| 11839.82
        //        G	    | 9	| 12543.856
        //        G# / Ab | 9	| 13289.752
        //        A	    | 9 | 14080
        //        A# / Bb | 9	| 14917.24
        //        B	    | 9	| 15804.264
        //        ";
    }
}
