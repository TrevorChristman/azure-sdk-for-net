// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    internal static partial class MonthOfYearExtensions
    {
        public static string ToSerialString(this MonthOfYear value) => value switch
        {
            MonthOfYear.Invalid => "Invalid",
            MonthOfYear.January => "January",
            MonthOfYear.February => "February",
            MonthOfYear.March => "March",
            MonthOfYear.April => "April",
            MonthOfYear.May => "May",
            MonthOfYear.June => "June",
            MonthOfYear.July => "July",
            MonthOfYear.August => "August",
            MonthOfYear.September => "September",
            MonthOfYear.October => "October",
            MonthOfYear.November => "November",
            MonthOfYear.December => "December",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MonthOfYear value.")
        };

        public static MonthOfYear ToMonthOfYear(this string value)
        {
            if (string.Equals(value, "Invalid", StringComparison.InvariantCultureIgnoreCase)) return MonthOfYear.Invalid;
            if (string.Equals(value, "January", StringComparison.InvariantCultureIgnoreCase)) return MonthOfYear.January;
            if (string.Equals(value, "February", StringComparison.InvariantCultureIgnoreCase)) return MonthOfYear.February;
            if (string.Equals(value, "March", StringComparison.InvariantCultureIgnoreCase)) return MonthOfYear.March;
            if (string.Equals(value, "April", StringComparison.InvariantCultureIgnoreCase)) return MonthOfYear.April;
            if (string.Equals(value, "May", StringComparison.InvariantCultureIgnoreCase)) return MonthOfYear.May;
            if (string.Equals(value, "June", StringComparison.InvariantCultureIgnoreCase)) return MonthOfYear.June;
            if (string.Equals(value, "July", StringComparison.InvariantCultureIgnoreCase)) return MonthOfYear.July;
            if (string.Equals(value, "August", StringComparison.InvariantCultureIgnoreCase)) return MonthOfYear.August;
            if (string.Equals(value, "September", StringComparison.InvariantCultureIgnoreCase)) return MonthOfYear.September;
            if (string.Equals(value, "October", StringComparison.InvariantCultureIgnoreCase)) return MonthOfYear.October;
            if (string.Equals(value, "November", StringComparison.InvariantCultureIgnoreCase)) return MonthOfYear.November;
            if (string.Equals(value, "December", StringComparison.InvariantCultureIgnoreCase)) return MonthOfYear.December;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MonthOfYear value.");
        }
    }
}
