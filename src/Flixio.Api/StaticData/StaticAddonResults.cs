namespace Flixio.Api.StaticData;

public static class StaticAddonResults
{
    public static string DefaultAddonCollectionResult(DateTime lastModified) => 
        $$"""
         {
             "result": {
                 "addons": [
                     {
                         "transportUrl": "https://v3-cinemeta.strem.io/manifest.json",
                         "transportName": "http",
                         "manifest": {
                             "id": "com.linvo.cinemeta",
                             "version": "3.0.11",
                             "description": "The official addon for movie and series catalogs",
                             "name": "Cinemeta",
                             "resources": [
                                 "catalog",
                                 "meta",
                                 "addon_catalog"
                             ],
                             "types": [
                                 "movie",
                                 "series"
                             ],
                             "idPrefixes": [
                                 "tt"
                             ],
                             "addonCatalogs": [
                                 {
                                     "type": "all",
                                     "id": "official",
                                     "name": "Official"
                                 },
                                 {
                                     "type": "movie",
                                     "id": "official",
                                     "name": "Official"
                                 },
                                 {
                                     "type": "series",
                                     "id": "official",
                                     "name": "Official"
                                 },
                                 {
                                     "type": "channel",
                                     "id": "official",
                                     "name": "Official"
                                 },
                                 {
                                     "type": "all",
                                     "id": "community",
                                     "name": "Community"
                                 },
                                 {
                                     "type": "movie",
                                     "id": "community",
                                     "name": "Community"
                                 },
                                 {
                                     "type": "series",
                                     "id": "community",
                                     "name": "Community"
                                 },
                                 {
                                     "type": "channel",
                                     "id": "community",
                                     "name": "Community"
                                 },
                                 {
                                     "type": "tv",
                                     "id": "community",
                                     "name": "Community"
                                 },
                                 {
                                     "type": "Podcasts",
                                     "id": "community",
                                     "name": "Community"
                                 },
                                 {
                                     "type": "other",
                                     "id": "community",
                                     "name": "Community"
                                 }
                             ],
                             "catalogs": [
                                 {
                                     "type": "movie",
                                     "id": "top",
                                     "genres": [
                                         "Action",
                                         "Adventure",
                                         "Animation",
                                         "Biography",
                                         "Comedy",
                                         "Crime",
                                         "Documentary",
                                         "Drama",
                                         "Family",
                                         "Fantasy",
                                         "History",
                                         "Horror",
                                         "Mystery",
                                         "Romance",
                                         "Sci-Fi",
                                         "Sport",
                                         "Thriller",
                                         "War",
                                         "Western"
                                     ],
                                     "extra": [
                                         {
                                             "name": "genre",
                                             "options": [
                                                 "Action",
                                                 "Adventure",
                                                 "Animation",
                                                 "Biography",
                                                 "Comedy",
                                                 "Crime",
                                                 "Documentary",
                                                 "Drama",
                                                 "Family",
                                                 "Fantasy",
                                                 "History",
                                                 "Horror",
                                                 "Mystery",
                                                 "Romance",
                                                 "Sci-Fi",
                                                 "Sport",
                                                 "Thriller",
                                                 "War",
                                                 "Western"
                                             ]
                                         },
                                         {
                                             "name": "search"
                                         },
                                         {
                                             "name": "skip"
                                         }
                                     ],
                                     "extraSupported": [
                                         "search",
                                         "genre",
                                         "skip"
                                     ],
                                     "name": "Popular"
                                 },
                                 {
                                     "type": "series",
                                     "id": "top",
                                     "genres": [
                                         "Action",
                                         "Adventure",
                                         "Animation",
                                         "Biography",
                                         "Comedy",
                                         "Crime",
                                         "Documentary",
                                         "Drama",
                                         "Family",
                                         "Fantasy",
                                         "History",
                                         "Horror",
                                         "Mystery",
                                         "Romance",
                                         "Sci-Fi",
                                         "Sport",
                                         "Thriller",
                                         "War",
                                         "Western",
                                         "Reality-TV",
                                         "Talk-Show",
                                         "Game-Show"
                                     ],
                                     "extra": [
                                         {
                                             "name": "genre",
                                             "options": [
                                                 "Action",
                                                 "Adventure",
                                                 "Animation",
                                                 "Biography",
                                                 "Comedy",
                                                 "Crime",
                                                 "Documentary",
                                                 "Drama",
                                                 "Family",
                                                 "Fantasy",
                                                 "History",
                                                 "Horror",
                                                 "Mystery",
                                                 "Romance",
                                                 "Sci-Fi",
                                                 "Sport",
                                                 "Thriller",
                                                 "War",
                                                 "Western",
                                                 "Reality-TV",
                                                 "Talk-Show",
                                                 "Game-Show"
                                             ]
                                         },
                                         {
                                             "name": "search"
                                         },
                                         {
                                             "name": "skip"
                                         }
                                     ],
                                     "extraSupported": [
                                         "search",
                                         "genre",
                                         "skip"
                                     ],
                                     "name": "Popular"
                                 },
                                 {
                                     "type": "movie",
                                     "id": "year",
                                     "genres": [
                                         "2024",
                                         "2023",
                                         "2022",
                                         "2021",
                                         "2020",
                                         "2019",
                                         "2018",
                                         "2017",
                                         "2016",
                                         "2015",
                                         "2014",
                                         "2013",
                                         "2012",
                                         "2011",
                                         "2010",
                                         "2009",
                                         "2008",
                                         "2007",
                                         "2006",
                                         "2005",
                                         "2004",
                                         "2003",
                                         "2002",
                                         "2001",
                                         "2000",
                                         "1999",
                                         "1998",
                                         "1997",
                                         "1996",
                                         "1995",
                                         "1994",
                                         "1993",
                                         "1992",
                                         "1991",
                                         "1990",
                                         "1989",
                                         "1988",
                                         "1987",
                                         "1986",
                                         "1985",
                                         "1984",
                                         "1983",
                                         "1982",
                                         "1981",
                                         "1980",
                                         "1979",
                                         "1978",
                                         "1977",
                                         "1976",
                                         "1975",
                                         "1974",
                                         "1973",
                                         "1972",
                                         "1971",
                                         "1970",
                                         "1969",
                                         "1968",
                                         "1967",
                                         "1966",
                                         "1965",
                                         "1964",
                                         "1963",
                                         "1962",
                                         "1961",
                                         "1960",
                                         "1959",
                                         "1958",
                                         "1957",
                                         "1956",
                                         "1955",
                                         "1954",
                                         "1953",
                                         "1952",
                                         "1951",
                                         "1950",
                                         "1949",
                                         "1948",
                                         "1947",
                                         "1946",
                                         "1945",
                                         "1944",
                                         "1943",
                                         "1942",
                                         "1941",
                                         "1940",
                                         "1939",
                                         "1938",
                                         "1937",
                                         "1936",
                                         "1935",
                                         "1934",
                                         "1933",
                                         "1932",
                                         "1931",
                                         "1930",
                                         "1929",
                                         "1928",
                                         "1927",
                                         "1926",
                                         "1925",
                                         "1924",
                                         "1923",
                                         "1922",
                                         "1921",
                                         "1920"
                                     ],
                                     "extra": [
                                         {
                                             "name": "genre",
                                             "options": [
                                                 "2024",
                                                 "2023",
                                                 "2022",
                                                 "2021",
                                                 "2020",
                                                 "2019",
                                                 "2018",
                                                 "2017",
                                                 "2016",
                                                 "2015",
                                                 "2014",
                                                 "2013",
                                                 "2012",
                                                 "2011",
                                                 "2010",
                                                 "2009",
                                                 "2008",
                                                 "2007",
                                                 "2006",
                                                 "2005",
                                                 "2004",
                                                 "2003",
                                                 "2002",
                                                 "2001",
                                                 "2000",
                                                 "1999",
                                                 "1998",
                                                 "1997",
                                                 "1996",
                                                 "1995",
                                                 "1994",
                                                 "1993",
                                                 "1992",
                                                 "1991",
                                                 "1990",
                                                 "1989",
                                                 "1988",
                                                 "1987",
                                                 "1986",
                                                 "1985",
                                                 "1984",
                                                 "1983",
                                                 "1982",
                                                 "1981",
                                                 "1980",
                                                 "1979",
                                                 "1978",
                                                 "1977",
                                                 "1976",
                                                 "1975",
                                                 "1974",
                                                 "1973",
                                                 "1972",
                                                 "1971",
                                                 "1970",
                                                 "1969",
                                                 "1968",
                                                 "1967",
                                                 "1966",
                                                 "1965",
                                                 "1964",
                                                 "1963",
                                                 "1962",
                                                 "1961",
                                                 "1960",
                                                 "1959",
                                                 "1958",
                                                 "1957",
                                                 "1956",
                                                 "1955",
                                                 "1954",
                                                 "1953",
                                                 "1952",
                                                 "1951",
                                                 "1950",
                                                 "1949",
                                                 "1948",
                                                 "1947",
                                                 "1946",
                                                 "1945",
                                                 "1944",
                                                 "1943",
                                                 "1942",
                                                 "1941",
                                                 "1940",
                                                 "1939",
                                                 "1938",
                                                 "1937",
                                                 "1936",
                                                 "1935",
                                                 "1934",
                                                 "1933",
                                                 "1932",
                                                 "1931",
                                                 "1930",
                                                 "1929",
                                                 "1928",
                                                 "1927",
                                                 "1926",
                                                 "1925",
                                                 "1924",
                                                 "1923",
                                                 "1922",
                                                 "1921",
                                                 "1920"
                                             ],
                                             "isRequired": true
                                         },
                                         {
                                             "name": "skip"
                                         }
                                     ],
                                     "extraSupported": [
                                         "genre",
                                         "skip"
                                     ],
                                     "extraRequired": [
                                         "genre"
                                     ],
                                     "name": "New"
                                 },
                                 {
                                     "type": "series",
                                     "id": "year",
                                     "genres": [
                                         "2024",
                                         "2023",
                                         "2022",
                                         "2021",
                                         "2020",
                                         "2019",
                                         "2018",
                                         "2017",
                                         "2016",
                                         "2015",
                                         "2014",
                                         "2013",
                                         "2012",
                                         "2011",
                                         "2010",
                                         "2009",
                                         "2008",
                                         "2007",
                                         "2006",
                                         "2005",
                                         "2004",
                                         "2003",
                                         "2002",
                                         "2001",
                                         "2000",
                                         "1999",
                                         "1998",
                                         "1997",
                                         "1996",
                                         "1995",
                                         "1994",
                                         "1993",
                                         "1992",
                                         "1991",
                                         "1990",
                                         "1989",
                                         "1988",
                                         "1987",
                                         "1986",
                                         "1985",
                                         "1984",
                                         "1983",
                                         "1982",
                                         "1981",
                                         "1980",
                                         "1979",
                                         "1978",
                                         "1977",
                                         "1976",
                                         "1975",
                                         "1974",
                                         "1973",
                                         "1972",
                                         "1971",
                                         "1970",
                                         "1969",
                                         "1968",
                                         "1967",
                                         "1966",
                                         "1965",
                                         "1964",
                                         "1963",
                                         "1962",
                                         "1961",
                                         "1960"
                                     ],
                                     "extra": [
                                         {
                                             "name": "genre",
                                             "options": [
                                                 "2024",
                                                 "2023",
                                                 "2022",
                                                 "2021",
                                                 "2020",
                                                 "2019",
                                                 "2018",
                                                 "2017",
                                                 "2016",
                                                 "2015",
                                                 "2014",
                                                 "2013",
                                                 "2012",
                                                 "2011",
                                                 "2010",
                                                 "2009",
                                                 "2008",
                                                 "2007",
                                                 "2006",
                                                 "2005",
                                                 "2004",
                                                 "2003",
                                                 "2002",
                                                 "2001",
                                                 "2000",
                                                 "1999",
                                                 "1998",
                                                 "1997",
                                                 "1996",
                                                 "1995",
                                                 "1994",
                                                 "1993",
                                                 "1992",
                                                 "1991",
                                                 "1990",
                                                 "1989",
                                                 "1988",
                                                 "1987",
                                                 "1986",
                                                 "1985",
                                                 "1984",
                                                 "1983",
                                                 "1982",
                                                 "1981",
                                                 "1980",
                                                 "1979",
                                                 "1978",
                                                 "1977",
                                                 "1976",
                                                 "1975",
                                                 "1974",
                                                 "1973",
                                                 "1972",
                                                 "1971",
                                                 "1970",
                                                 "1969",
                                                 "1968",
                                                 "1967",
                                                 "1966",
                                                 "1965",
                                                 "1964",
                                                 "1963",
                                                 "1962",
                                                 "1961",
                                                 "1960"
                                             ],
                                             "isRequired": true
                                         },
                                         {
                                             "name": "skip"
                                         }
                                     ],
                                     "extraSupported": [
                                         "genre",
                                         "skip"
                                     ],
                                     "extraRequired": [
                                         "genre"
                                     ],
                                     "name": "New"
                                 },
                                 {
                                     "type": "movie",
                                     "id": "imdbRating",
                                     "genres": [
                                         "Action",
                                         "Adventure",
                                         "Animation",
                                         "Biography",
                                         "Comedy",
                                         "Crime",
                                         "Documentary",
                                         "Drama",
                                         "Family",
                                         "Fantasy",
                                         "History",
                                         "Horror",
                                         "Mystery",
                                         "Romance",
                                         "Sci-Fi",
                                         "Sport",
                                         "Thriller",
                                         "War",
                                         "Western"
                                     ],
                                     "extra": [
                                         {
                                             "name": "genre",
                                             "options": [
                                                 "Action",
                                                 "Adventure",
                                                 "Animation",
                                                 "Biography",
                                                 "Comedy",
                                                 "Crime",
                                                 "Documentary",
                                                 "Drama",
                                                 "Family",
                                                 "Fantasy",
                                                 "History",
                                                 "Horror",
                                                 "Mystery",
                                                 "Romance",
                                                 "Sci-Fi",
                                                 "Sport",
                                                 "Thriller",
                                                 "War",
                                                 "Western"
                                             ]
                                         },
                                         {
                                             "name": "skip"
                                         }
                                     ],
                                     "extraSupported": [
                                         "genre",
                                         "skip"
                                     ],
                                     "name": "Featured"
                                 },
                                 {
                                     "type": "series",
                                     "id": "imdbRating",
                                     "genres": [
                                         "Action",
                                         "Adventure",
                                         "Animation",
                                         "Biography",
                                         "Comedy",
                                         "Crime",
                                         "Documentary",
                                         "Drama",
                                         "Family",
                                         "Fantasy",
                                         "History",
                                         "Horror",
                                         "Mystery",
                                         "Romance",
                                         "Sci-Fi",
                                         "Sport",
                                         "Thriller",
                                         "War",
                                         "Western",
                                         "Reality-TV",
                                         "Talk-Show",
                                         "Game-Show"
                                     ],
                                     "extra": [
                                         {
                                             "name": "genre",
                                             "options": [
                                                 "Action",
                                                 "Adventure",
                                                 "Animation",
                                                 "Biography",
                                                 "Comedy",
                                                 "Crime",
                                                 "Documentary",
                                                 "Drama",
                                                 "Family",
                                                 "Fantasy",
                                                 "History",
                                                 "Horror",
                                                 "Mystery",
                                                 "Romance",
                                                 "Sci-Fi",
                                                 "Sport",
                                                 "Thriller",
                                                 "War",
                                                 "Western",
                                                 "Reality-TV",
                                                 "Talk-Show",
                                                 "Game-Show"
                                             ]
                                         },
                                         {
                                             "name": "skip"
                                         }
                                     ],
                                     "extraSupported": [
                                         "genre",
                                         "skip"
                                     ],
                                     "name": "Featured"
                                 },
                                 {
                                     "type": "series",
                                     "id": "last-videos",
                                     "extra": [
                                         {
                                             "name": "lastVideosIds",
                                             "isRequired": true,
                                             "optionsLimit": 100
                                         }
                                     ],
                                     "extraSupported": [
                                         "lastVideosIds"
                                     ],
                                     "extraRequired": [
                                         "lastVideosIds"
                                     ],
                                     "name": "Last videos"
                                 }
                             ],
                             "behaviorHints": {
                                 "newEpisodeNotifications": true
                             }
                         },
                         "flags": {
                             "official": true,
                             "protected": true
                         }
                     },
                     {
                         "transportUrl": "https://v3-channels.strem.io/manifest.json",
                         "transportName": "http",
                         "manifest": {
                             "id": "com.linvo.stremiochannels",
                             "version": "1.30.7",
                             "description": "Watch your favourite YouTube channels ad-free and get notified when they upload new videos.",
                             "name": "YouTube",
                             "resources": [
                                 "catalog",
                                 "meta"
                             ],
                             "types": [
                                 "channel"
                             ],
                             "idPrefixes": [
                                 "yt_id:"
                             ],
                             "catalogs": [
                                 {
                                     "type": "channel",
                                     "id": "top",
                                     "extra": [
                                         {
                                             "name": "search",
                                             "isRequired": false
                                         },
                                         {
                                             "name": "genre",
                                             "options": [
                                                 "Animation",
                                                 "Automotive",
                                                 "Beauty \u0026 Fashion",
                                                 "Causes \u0026 Non-profits",
                                                 "Comedy",
                                                 "Cooking \u0026 Health",
                                                 "Film \u0026 Entertainment",
                                                 "From TV",
                                                 "Gaming",
                                                 "Lifestyle",
                                                 "Music",
                                                 "News \u0026 Politics",
                                                 "Sports"
                                             ],
                                             "isRequired": false
                                         },
                                         {
                                             "name": "skip",
                                             "isRequired": false
                                         }
                                     ]
                                 },
                                 {
                                     "type": "channel",
                                     "id": "videos",
                                     "extra": [
                                         {
                                             "name": "search",
                                             "isRequired": true
                                         }
                                     ]
                                 }
                             ]
                         },
                         "flags": {
                             "official": true
                         }
                     },
                     {
                         "transportUrl": "https://watchhub.strem.io/manifest.json",
                         "transportName": "http",
                         "manifest": {
                             "id": "org.stremio.watchhub",
                             "logo": "https://www.strem.io/images/watchhub-logo.png",
                             "version": "1.15.0",
                             "name": "WatchHub",
                             "description": "Find where to stream your favorite movies and shows amongst Netflix, iTunes, Hulu, Amazon, HBO GO and many others. Supports many countries.",
                             "resources": [
                                 "stream"
                             ],
                             "types": [
                                 "movie",
                                 "series"
                             ],
                             "catalogs": [],
                             "idPrefixes": [
                                 "tt"
                             ]
                         },
                         "flags": {
                             "official": true
                         }
                     },
                     {
                         "transportUrl": "https://caching.stremio.net/publicdomainmovies.now.sh/manifest.json",
                         "transportName": "http",
                         "manifest": {
                             "id": "org.stremio.pubdomainmovies",
                             "version": "1.0.0",
                             "logo": "https://johnserv531.github.io/gh-images/1586344884.jpg",
                             "name": "Public Domain Movies",
                             "description": "Torrents for public domain movies. Includes a collection of more then 500 public domain movies.",
                             "resources": [
                                 "catalog",
                                 "stream"
                             ],
                             "types": [
                                 "movie"
                             ],
                             "catalogs": [
                                 {
                                     "type": "movie",
                                     "id": "publicdomainmovies",
                                     "extra": [
                                         {
                                             "name": "skip"
                                         },
                                         {
                                             "name": "search"
                                         }
                                     ]
                                 }
                             ],
                             "idPrefixes": [
                                 "tt"
                             ]
                         },
                         "flags": {
                             "official": true
                         }
                     },
                     {
                         "transportUrl": "https://opensubtitles-v3.strem.io/manifest.json",
                         "transportName": "http",
                         "manifest": {
                             "id": "org.stremio.opensubtitlesv3",
                             "version": "1.0.0",
                             "name": "OpenSubtitles v3",
                             "description": "OpenSubtitles v3 Addon for Stremio",
                             "catalogs": [],
                             "resources": [
                                 "subtitles"
                             ],
                             "types": [
                                 "movie",
                                 "series"
                             ],
                             "idPrefixes": [
                                 "tt"
                             ],
                             "logo": "http://www.strem.io/images/addons/opensubtitles-logo.png"
                         },
                         "flags": {
                             "official": true
                         }
                     },
                     {
                         "transportUrl": "https://opensubtitles.strem.io/stremio/v1",
                         "transportName": "legacy",
                         "manifest": {
                             "id": "org.stremio.opensubtitles",
                             "version": "0.24.0",
                             "name": "OpenSubtitles",
                             "description": "The official add-on for subtitles from OpenSubtitles",
                             "logo": "http://www.strem.io/images/addons/opensubtitles-logo.png",
                             "resources": [
                                 "subtitles"
                             ],
                             "types": [
                                 "series",
                                 "movie",
                                 "other"
                             ],
                             "catalogs": []
                         },
                         "flags": {
                             "official": true
                         }
                     },
                     {
                         "transportUrl": "http://127.0.0.1:11470/local-addon/manifest.json",
                         "transportName": "http",
                         "manifest": {
                             "id": "org.stremio.local",
                             "version": "1.10.0",
                             "description": "Local add-on to find playable files: .torrent, .mp4, .mkv and .avi",
                             "name": "Local Files (without catalog support)",
                             "resources": [
                                 {
                                     "name": "meta",
                                     "types": [
                                         "other"
                                     ],
                                     "idPrefixes": [
                                         "local:",
                                         "bt:"
                                     ]
                                 },
                                 {
                                     "name": "stream",
                                     "types": [
                                         "movie",
                                         "series"
                                     ],
                                     "idPrefixes": [
                                         "tt"
                                     ]
                                 }
                             ],
                             "types": [
                                 "movie",
                                 "series",
                                 "other"
                             ],
                             "catalogs": []
                         },
                         "flags": {
                             "official": true,
                             "protected": false
                         }
                     }
                 ],
                 "isInitial": true,
                 "lastModified": "{{lastModified:yyyy-MM-ddTHH:mm:ssZ}}"
             }
         }
         """;
}