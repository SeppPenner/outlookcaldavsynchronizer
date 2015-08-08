// This file is Part of CalDavSynchronizer (http://outlookcaldavsynchronizer.sourceforge.net/)
// Copyright (c) 2015 Gerhard Zehetbauer 
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using GenSync;

namespace CalDavSynchronizer.DataAccess
{
  public interface ICalDavDataAccess
  {
    bool IsCalendarAccessSupported ();
    bool IsResourceCalender ();

    IReadOnlyList<EntityIdWithVersion<Uri, string>> GetEvents (DateTime? from, DateTime? to);
    IReadOnlyList<EntityIdWithVersion<Uri, string>> GetTodos (DateTime? from, DateTime? to);

    EntityIdWithVersion<Uri, string> UpdateEntity (EntityIdWithVersion<Uri, string> evt, string iCalData);
    bool DeleteEntity (EntityIdWithVersion<Uri, string> evt);
    IReadOnlyList<EntityWithVersion<Uri, string>> GetEntities (IEnumerable<Uri> eventUrls);
    EntityIdWithVersion<Uri, string> CreateEntity (string iCalData);
    bool DeleteEntity (Uri uri);
    EntityIdWithVersion<Uri, string> UpdateEntity (Uri url, string iCalData);
  }
}