using System;
using System.Collections.Generic;

namespace azure_data_migration_v1.Entities;

public partial class MimBusiness001
{
    public Guid MimBusinessId { get; set; }

    public DateTimeOffset MimBusinessCdate { get; set; }

    public bool MimBusinessExpired { get; set; }

    public Guid? CciLogId { get; set; }

    public Guid MimControlId { get; set; }

    public DateTimeOffset MimBusinessExpiryDate { get; set; }

    public string MimBusinessTradingName { get; set; } = null!;

    public string MimBusinessLegalName { get; set; } = null!;

    public string? MimBusinessLegalRegistrationNo { get; set; }

    public string? MimBusinessLegalRegistrationOffice { get; set; }

    public string? CcgCountryScodeIsoCode2Registration { get; set; }

    public string? CcgTenantScode { get; set; }

    public DateTimeOffset? MimBusinessLegalRegistrationDate { get; set; }

    public string? MimBusinessTaxationRegistrationNo { get; set; }

    public string? MimBusinessWww { get; set; }

    public string? MimBusinessSwiftCode { get; set; }

    public string? MimBusinessRoutingCode { get; set; }

    public decimal? MimBusinessEstTurnover { get; set; }

    public bool? MimBusinessPartOfGroupCompanies { get; set; }

    public string? MimBusinessLegalNamePrevious { get; set; }

    public bool? MimBusinessCashIntensive { get; set; }

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
