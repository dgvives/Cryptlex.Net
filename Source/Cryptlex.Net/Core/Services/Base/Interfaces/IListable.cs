﻿namespace Cryptlex.Net.Core.Services.Base
{
    public interface IListable<T, TListData>
    {
        Task<IEnumerable<T>> GetAllAsync(TListData data);
    }
}
