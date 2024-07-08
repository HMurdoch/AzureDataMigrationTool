using System;
using System.Collections.Generic;

namespace azure_data_migration_v1.Entities;

public partial class MimDocumentsPagesVw
{
    public Guid MimDocumentsPagesId { get; set; }

    public DateTimeOffset MimDocumentsPagesCdate { get; set; }

    public bool MimDocumentsPagesExpired { get; set; }

    public Guid? CciLogId { get; set; }

    public Guid MimDocumentsId { get; set; }

    public string CcgDocTypeScode { get; set; } = null!;

    public Guid MimControlId { get; set; }

    public DateTimeOffset MimDocumentsPagesExpiryDate { get; set; }

    public Guid MimDocumentsPagesLinkToFile { get; set; }

    public int MimDocumentsPagesItemNo { get; set; }

    public string? MimDocumentsPagesDescription { get; set; }

    public string? CcgPlatformRegionScode { get; set; }

    public string? CcgPlatformRegionDcScode { get; set; }

    public string? CcgPlatformStorageBulkScode { get; set; }

    public string? MimDocumentsPagesFileName { get; set; }

    public decimal? MimDocumentsPagesFileSizeInMb { get; set; }

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
