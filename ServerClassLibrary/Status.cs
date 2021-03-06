﻿using System.Collections.Generic;

namespace ServerClassLibrary {
    public class Status {
        public static Dictionary<int, string> StatusDictionary
            = new Dictionary<int, string> {
                {200, "OK"},
                {204, "No Content"},
                {206, "Partial Content"},
                {302, "Found" },
                {401, "Unauthorized"},
                {404, "Not Found"},
                {405, "Method Not Allowed" }
            };
    }
}