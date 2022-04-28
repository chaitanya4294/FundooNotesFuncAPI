﻿using FundooNotesAPI.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooNotesAPI.Shared.Interfaces
{
    public interface INotesService
    {
        Task<List<FundooNote>> GetAllFundooNotes(string email);

        Task<FundooNote> GetFundooNoteById(string email, string id);

        Task<FundooNote> CreateFundooNote(string email, FundooNote newFundooNote);

        Task<FundooNote> UpdateFundooNoteById(string id, FundooNote updatedFundooNote);

        Task<FundooNote> DeleteFundooNoteById(string id);
    }
}
