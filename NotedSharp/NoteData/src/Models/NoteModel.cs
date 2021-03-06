﻿//------------------------------------------------------------------------------
// Solution: NotedSharp
// Project: NoteData
// File: NoteModel.cs
// Author: Tony Barbitta
//
// Created: 02-12-2021 : 10:42 PM
// Updated: 02-12-2021 : 10:42 PM
//------------------------------------------------------------------------------


using System;
using System.Collections.Generic;

namespace NoteData.Models
{
    public class NoteModel
    {
        public Guid Id { get; set; }

        public String Title { get; set; } = String.Empty;

        public String Content { get; set; } = String.Empty;

        public List<String> Tags { get; set; } = new();

        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime Updated { get; set; } = DateTime.Now;
    }
}
