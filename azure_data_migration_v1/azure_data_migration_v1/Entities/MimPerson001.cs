using System;
using System.Collections.Generic;

namespace azure_data_migration_v1.Entities;

public partial class MimPerson001
{
    public Guid MimPersonId { get; set; }

    public DateTimeOffset MimPersonCdate { get; set; }

    public bool MimPersonExpired { get; set; }

    public Guid? CciLogId { get; set; }

    public string? CcgEducationalTypeScode { get; set; }

    public string? CcgTitlesScode { get; set; }

    public Guid MimControlId { get; set; }

    public DateTimeOffset MimPersonExpiryDate { get; set; }

    public string? MimPersonNameInitials { get; set; }

    public string? MimPersonNameFirst { get; set; }

    public string? MimPersonNamesMiddle { get; set; }

    public string? MimPersonNameSurname { get; set; }

    public string? MimPersonNamePrefferred { get; set; }

    public string? MimPersonNameMother { get; set; }

    public string? MimPersonNameFather { get; set; }

    public DateTimeOffset? MimPersonBirthDate { get; set; }

    public int? MimPersonAge { get; set; }

    public string? CcgCountryOfBirth { get; set; }

    public string? MimPersonBirthCity { get; set; }

    public string? MimPersonNameMaiden { get; set; }

    public bool? MimPersonResident { get; set; }

    public string? CcgCountryOfResidence { get; set; }

    public string? CcgTenantScode { get; set; }

    public string? MimPersonGender { get; set; }

    public string? CcgMaritalTypeScode { get; set; }

    public bool? MimPersonVip { get; set; }

    public string? MimPersonIncomeRange { get; set; }

    public bool? MimPersonDeceased { get; set; }

    public DateTimeOffset? MimPersonDeceasedDate { get; set; }

    public int? MimPersonActivityLevel { get; set; }

    public string? CcgCountryOfNationality { get; set; }

    public bool? CcgCountryOfBirthCitizenship { get; set; }

    public Guid? CdfCreatedMimControlId { get; set; }

    public Guid? CdfModifiedMimControlId { get; set; }

    public Guid? CdfOnbehalfMimControlId { get; set; }

    public DateTimeOffset? CdfModifiedOnDt { get; set; }

    public string? CdfOwnershipUser { get; set; }

    public string? CdfOwnershipTeam { get; set; }

    public string? CdfOwnershipBu { get; set; }

    public string? CdfCcgTimezoneScode { get; set; }

    public string? CdfTraversedPath { get; set; }

    public Guid? CdfProcessId { get; set; }

    public string? CdfOriginatingSystem { get; set; }

    public string? CdfOriginatingId { get; set; }

    public Guid? CdfEgpControlId { get; set; }

    public int? CdfDocCnt { get; set; }

    public int? CdfSortOrder { get; set; }
}
