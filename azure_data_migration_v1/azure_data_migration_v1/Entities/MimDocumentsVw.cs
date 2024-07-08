using System;
using System.Collections.Generic;

namespace azure_data_migration_v1.Entities;

public partial class MimDocumentsVw
{
    public Guid MimDocumentsId { get; set; }

    public DateTimeOffset MimDocumentsCdate { get; set; }

    public bool MimDocumentsExpired { get; set; }

    public Guid? CciLogId { get; set; }

    public string CcgDocTypeScode { get; set; } = null!;

    public Guid MimControlId { get; set; }

    public string CcgTenantScode { get; set; } = null!;

    public DateTimeOffset MimDocumentsExpiryDate { get; set; }

    public Guid MimDocumentsLinkToFile { get; set; }

    public string? MimDocumentsDescription { get; set; }

    public string? MimDocumentsReferenceNo { get; set; }

    public DateTimeOffset? MimDocumentsDocExpiryDate { get; set; }

    public Guid? MimMatrixId { get; set; }

    public Guid? CcgTenantPoiDocsId { get; set; }

    public Guid? CcgTenantPoaDocsId { get; set; }

    public string? MimDocumentsFolder1Scode { get; set; }

    public string? MimDocumentsFolder2Scode { get; set; }

    public string? MimDocumentsFolder3Scode { get; set; }

    public bool? MimDocumentsIsImmutable { get; set; }

    public string? MimDocumentsVersion { get; set; }

    public bool? MimDocumentsIsNote { get; set; }

    public string? MimDocumentsNote { get; set; }

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
