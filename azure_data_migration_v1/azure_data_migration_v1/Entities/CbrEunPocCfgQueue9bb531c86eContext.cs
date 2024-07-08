using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace azure_data_migration_v1.Entities;

public partial class CbrEunPocCfgQueue9bb531c86eContext : DbContext
{
    public CbrEunPocCfgQueue9bb531c86eContext()
    {
    }

    public CbrEunPocCfgQueue9bb531c86eContext(DbContextOptions<CbrEunPocCfgQueue9bb531c86eContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MimBusinessVw> MimBusinessVws { get; set; }

    public virtual DbSet<MimDocumentsGaprVw> MimDocumentsGaprVws { get; set; }

    public virtual DbSet<MimDocumentsPagesGaprVw> MimDocumentsPagesGaprVws { get; set; }

    public virtual DbSet<MimDocumentsPagesVw> MimDocumentsPagesVws { get; set; }

    public virtual DbSet<MimDocumentsVw> MimDocumentsVws { get; set; }

    public virtual DbSet<MimPersonVw> MimPersonVws { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=cbr-eun-poc-fo-core.database.windows.net;Initial Catalog=cbr-eun-poc-cfg-queue9bb531c86e;User ID=cb_admin;Password=WallyWalter123!@#;Connect Timeout=0;Command Timeout=0;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MimBusinessVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("mim_business_vw");

            entity.Property(e => e.CcgCountryScodeIsoCode2Registration)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_country_scode_iso_code2_registration");
            entity.Property(e => e.CcgTenantScode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_tenant_scode");
            entity.Property(e => e.CciLogId).HasColumnName("cci_log_id");
            entity.Property(e => e.CdfCcgTimezoneScode)
                .HasMaxLength(10)
                .HasColumnName("cdf_ccg_timezone_scode");
            entity.Property(e => e.CdfCreatedMimControlId).HasColumnName("cdf_created_mim_control_id");
            entity.Property(e => e.CdfDocCnt).HasColumnName("cdf_doc_cnt");
            entity.Property(e => e.CdfEgpControlId).HasColumnName("cdf_egp_control_id");
            entity.Property(e => e.CdfModifiedMimControlId).HasColumnName("cdf_modified_mim_control_id");
            entity.Property(e => e.CdfModifiedOnDt).HasColumnName("cdf_modified_on_dt");
            entity.Property(e => e.CdfOnbehalfMimControlId).HasColumnName("cdf_onbehalf_mim_control_id");
            entity.Property(e => e.CdfOriginatingId)
                .HasMaxLength(255)
                .HasColumnName("cdf_originating_id");
            entity.Property(e => e.CdfOriginatingSystem)
                .HasMaxLength(255)
                .HasColumnName("cdf_originating_system");
            entity.Property(e => e.CdfOwnershipBu)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_bu");
            entity.Property(e => e.CdfOwnershipTeam)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_team");
            entity.Property(e => e.CdfOwnershipUser)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_user");
            entity.Property(e => e.CdfProcessId).HasColumnName("cdf_process_id");
            entity.Property(e => e.CdfSortOrder).HasColumnName("cdf_sort_order");
            entity.Property(e => e.CdfTraversedPath)
                .HasMaxLength(1024)
                .HasColumnName("cdf_traversed_path");
            entity.Property(e => e.MimBusinessCashIntensive).HasColumnName("mim_business_cash_intensive");
            entity.Property(e => e.MimBusinessCdate).HasColumnName("mim_business_cdate");
            entity.Property(e => e.MimBusinessEstTurnover)
                .HasColumnType("decimal(25, 9)")
                .HasColumnName("mim_business_est_turnover");
            entity.Property(e => e.MimBusinessExpired).HasColumnName("mim_business_expired");
            entity.Property(e => e.MimBusinessExpiryDate).HasColumnName("mim_business_expiry_date");
            entity.Property(e => e.MimBusinessId).HasColumnName("mim_business_id");
            entity.Property(e => e.MimBusinessLegalName)
                .HasMaxLength(250)
                .HasColumnName("mim_business_legal_name");
            entity.Property(e => e.MimBusinessLegalNamePrevious)
                .HasMaxLength(250)
                .HasColumnName("mim_business_legal_name_previous");
            entity.Property(e => e.MimBusinessLegalRegistrationDate).HasColumnName("mim_business_legal_registration_date");
            entity.Property(e => e.MimBusinessLegalRegistrationNo)
                .HasMaxLength(250)
                .HasColumnName("mim_business_legal_registration_no");
            entity.Property(e => e.MimBusinessLegalRegistrationOffice)
                .HasMaxLength(250)
                .HasColumnName("mim_business_legal_registration_office");
            entity.Property(e => e.MimBusinessPartOfGroupCompanies).HasColumnName("mim_business_part_of_group_companies");
            entity.Property(e => e.MimBusinessRoutingCode)
                .HasMaxLength(100)
                .HasColumnName("mim_business_routing_code");
            entity.Property(e => e.MimBusinessSwiftCode)
                .HasMaxLength(100)
                .HasColumnName("mim_business_swift_code");
            entity.Property(e => e.MimBusinessTaxationRegistrationNo)
                .HasMaxLength(100)
                .HasColumnName("mim_business_taxation_registration_no");
            entity.Property(e => e.MimBusinessTradingName)
                .HasMaxLength(250)
                .HasColumnName("mim_business_trading_name");
            entity.Property(e => e.MimBusinessWww)
                .HasMaxLength(255)
                .HasColumnName("mim_business_www");
            entity.Property(e => e.MimControlId).HasColumnName("mim_control_id");
        });

        modelBuilder.Entity<MimDocumentsGaprVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("mim_documents_gapr_vw");

            entity.Property(e => e.CcgDocTypeScode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_doc_type_scode");
            entity.Property(e => e.CcgTenantPoaDocsId).HasColumnName("ccg_tenant_poa_docs_id");
            entity.Property(e => e.CcgTenantPoiDocsId).HasColumnName("ccg_tenant_poi_docs_id");
            entity.Property(e => e.CcgTenantScode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_tenant_scode");
            entity.Property(e => e.CciLogId).HasColumnName("cci_log_id");
            entity.Property(e => e.CdfCcgTimezoneScode)
                .HasMaxLength(10)
                .HasColumnName("cdf_ccg_timezone_scode");
            entity.Property(e => e.CdfCreatedMimControlId).HasColumnName("cdf_created_mim_control_id");
            entity.Property(e => e.CdfDocCnt).HasColumnName("cdf_doc_cnt");
            entity.Property(e => e.CdfEgpControlId).HasColumnName("cdf_egp_control_id");
            entity.Property(e => e.CdfModifiedMimControlId).HasColumnName("cdf_modified_mim_control_id");
            entity.Property(e => e.CdfModifiedOnDt).HasColumnName("cdf_modified_on_dt");
            entity.Property(e => e.CdfOnbehalfMimControlId).HasColumnName("cdf_onbehalf_mim_control_id");
            entity.Property(e => e.CdfOriginatingId)
                .HasMaxLength(255)
                .HasColumnName("cdf_originating_id");
            entity.Property(e => e.CdfOriginatingSystem)
                .HasMaxLength(255)
                .HasColumnName("cdf_originating_system");
            entity.Property(e => e.CdfOwnershipBu)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_bu");
            entity.Property(e => e.CdfOwnershipTeam)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_team");
            entity.Property(e => e.CdfOwnershipUser)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_user");
            entity.Property(e => e.CdfProcessId).HasColumnName("cdf_process_id");
            entity.Property(e => e.CdfSortOrder).HasColumnName("cdf_sort_order");
            entity.Property(e => e.CdfTraversedPath)
                .HasMaxLength(1024)
                .HasColumnName("cdf_traversed_path");
            entity.Property(e => e.MimControlId).HasColumnName("mim_control_id");
            entity.Property(e => e.MimDocumentsCdate).HasColumnName("mim_documents_cdate");
            entity.Property(e => e.MimDocumentsDescription)
                .HasMaxLength(255)
                .HasColumnName("mim_documents_description");
            entity.Property(e => e.MimDocumentsDocExpiryDate).HasColumnName("mim_documents_doc_expiry_date");
            entity.Property(e => e.MimDocumentsExpired).HasColumnName("mim_documents_expired");
            entity.Property(e => e.MimDocumentsExpiryDate).HasColumnName("mim_documents_expiry_date");
            entity.Property(e => e.MimDocumentsFolder1Scode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mim_documents_folder1_scode");
            entity.Property(e => e.MimDocumentsFolder2Scode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mim_documents_folder2_scode");
            entity.Property(e => e.MimDocumentsFolder3Scode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mim_documents_folder3_scode");
            entity.Property(e => e.MimDocumentsId).HasColumnName("mim_documents_id");
            entity.Property(e => e.MimDocumentsIsImmutable).HasColumnName("mim_documents_is_immutable");
            entity.Property(e => e.MimDocumentsIsNote).HasColumnName("mim_documents_is_note");
            entity.Property(e => e.MimDocumentsLinkToFile).HasColumnName("mim_documents_link_to_file");
            entity.Property(e => e.MimDocumentsNote)
                .HasMaxLength(250)
                .HasColumnName("mim_documents_note");
            entity.Property(e => e.MimDocumentsReferenceNo)
                .HasMaxLength(100)
                .HasColumnName("mim_documents_reference_no");
            entity.Property(e => e.MimDocumentsVersion)
                .HasMaxLength(50)
                .HasColumnName("mim_documents_version");
            entity.Property(e => e.MimMatrixId).HasColumnName("mim_matrix_id");
        });

        modelBuilder.Entity<MimDocumentsPagesGaprVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("mim_documents_pages_gapr_vw");

            entity.Property(e => e.CcgDocTypeScode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_doc_type_scode");
            entity.Property(e => e.CcgPlatformRegionDcScode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_platform_region_dc_scode");
            entity.Property(e => e.CcgPlatformRegionScode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_platform_region_scode");
            entity.Property(e => e.CcgPlatformStorageBulkScode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_platform_storage_bulk_scode");
            entity.Property(e => e.CciLogId).HasColumnName("cci_log_id");
            entity.Property(e => e.CdfCcgTimezoneScode)
                .HasMaxLength(10)
                .HasColumnName("cdf_ccg_timezone_scode");
            entity.Property(e => e.CdfCreatedMimControlId).HasColumnName("cdf_created_mim_control_id");
            entity.Property(e => e.CdfDocCnt).HasColumnName("cdf_doc_cnt");
            entity.Property(e => e.CdfEgpControlId).HasColumnName("cdf_egp_control_id");
            entity.Property(e => e.CdfModifiedMimControlId).HasColumnName("cdf_modified_mim_control_id");
            entity.Property(e => e.CdfModifiedOnDt).HasColumnName("cdf_modified_on_dt");
            entity.Property(e => e.CdfOnbehalfMimControlId).HasColumnName("cdf_onbehalf_mim_control_id");
            entity.Property(e => e.CdfOriginatingId)
                .HasMaxLength(255)
                .HasColumnName("cdf_originating_id");
            entity.Property(e => e.CdfOriginatingSystem)
                .HasMaxLength(255)
                .HasColumnName("cdf_originating_system");
            entity.Property(e => e.CdfOwnershipBu)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_bu");
            entity.Property(e => e.CdfOwnershipTeam)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_team");
            entity.Property(e => e.CdfOwnershipUser)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_user");
            entity.Property(e => e.CdfProcessId).HasColumnName("cdf_process_id");
            entity.Property(e => e.CdfSortOrder).HasColumnName("cdf_sort_order");
            entity.Property(e => e.CdfTraversedPath)
                .HasMaxLength(1024)
                .HasColumnName("cdf_traversed_path");
            entity.Property(e => e.MimControlId).HasColumnName("mim_control_id");
            entity.Property(e => e.MimDocumentsId).HasColumnName("mim_documents_id");
            entity.Property(e => e.MimDocumentsPagesCdate).HasColumnName("mim_documents_pages_cdate");
            entity.Property(e => e.MimDocumentsPagesDescription)
                .HasMaxLength(255)
                .HasColumnName("mim_documents_pages_description");
            entity.Property(e => e.MimDocumentsPagesExpired).HasColumnName("mim_documents_pages_expired");
            entity.Property(e => e.MimDocumentsPagesExpiryDate).HasColumnName("mim_documents_pages_expiry_date");
            entity.Property(e => e.MimDocumentsPagesFileName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("mim_documents_pages_file_name");
            entity.Property(e => e.MimDocumentsPagesFileSizeInMb)
                .HasColumnType("decimal(25, 9)")
                .HasColumnName("mim_documents_pages_file_size_in_mb");
            entity.Property(e => e.MimDocumentsPagesId).HasColumnName("mim_documents_pages_id");
            entity.Property(e => e.MimDocumentsPagesItemNo).HasColumnName("mim_documents_pages_item_no");
            entity.Property(e => e.MimDocumentsPagesLinkToFile).HasColumnName("mim_documents_pages_link_to_file");
        });

        modelBuilder.Entity<MimDocumentsPagesVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("mim_documents_pages_vw");

            entity.Property(e => e.CcgDocTypeScode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_doc_type_scode");
            entity.Property(e => e.CcgPlatformRegionDcScode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_platform_region_dc_scode");
            entity.Property(e => e.CcgPlatformRegionScode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_platform_region_scode");
            entity.Property(e => e.CcgPlatformStorageBulkScode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_platform_storage_bulk_scode");
            entity.Property(e => e.CciLogId).HasColumnName("cci_log_id");
            entity.Property(e => e.CdfCcgTimezoneScode)
                .HasMaxLength(10)
                .HasColumnName("cdf_ccg_timezone_scode");
            entity.Property(e => e.CdfCreatedMimControlId).HasColumnName("cdf_created_mim_control_id");
            entity.Property(e => e.CdfDocCnt).HasColumnName("cdf_doc_cnt");
            entity.Property(e => e.CdfEgpControlId).HasColumnName("cdf_egp_control_id");
            entity.Property(e => e.CdfModifiedMimControlId).HasColumnName("cdf_modified_mim_control_id");
            entity.Property(e => e.CdfModifiedOnDt).HasColumnName("cdf_modified_on_dt");
            entity.Property(e => e.CdfOnbehalfMimControlId).HasColumnName("cdf_onbehalf_mim_control_id");
            entity.Property(e => e.CdfOriginatingId)
                .HasMaxLength(255)
                .HasColumnName("cdf_originating_id");
            entity.Property(e => e.CdfOriginatingSystem)
                .HasMaxLength(255)
                .HasColumnName("cdf_originating_system");
            entity.Property(e => e.CdfOwnershipBu)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_bu");
            entity.Property(e => e.CdfOwnershipTeam)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_team");
            entity.Property(e => e.CdfOwnershipUser)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_user");
            entity.Property(e => e.CdfProcessId).HasColumnName("cdf_process_id");
            entity.Property(e => e.CdfSortOrder).HasColumnName("cdf_sort_order");
            entity.Property(e => e.CdfTraversedPath)
                .HasMaxLength(1024)
                .HasColumnName("cdf_traversed_path");
            entity.Property(e => e.MimControlId).HasColumnName("mim_control_id");
            entity.Property(e => e.MimDocumentsId).HasColumnName("mim_documents_id");
            entity.Property(e => e.MimDocumentsPagesCdate).HasColumnName("mim_documents_pages_cdate");
            entity.Property(e => e.MimDocumentsPagesDescription)
                .HasMaxLength(255)
                .HasColumnName("mim_documents_pages_description");
            entity.Property(e => e.MimDocumentsPagesExpired).HasColumnName("mim_documents_pages_expired");
            entity.Property(e => e.MimDocumentsPagesExpiryDate).HasColumnName("mim_documents_pages_expiry_date");
            entity.Property(e => e.MimDocumentsPagesFileName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("mim_documents_pages_file_name");
            entity.Property(e => e.MimDocumentsPagesFileSizeInMb)
                .HasColumnType("decimal(25, 9)")
                .HasColumnName("mim_documents_pages_file_size_in_mb");
            entity.Property(e => e.MimDocumentsPagesId).HasColumnName("mim_documents_pages_id");
            entity.Property(e => e.MimDocumentsPagesItemNo).HasColumnName("mim_documents_pages_item_no");
            entity.Property(e => e.MimDocumentsPagesLinkToFile).HasColumnName("mim_documents_pages_link_to_file");
        });

        modelBuilder.Entity<MimDocumentsVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("mim_documents_vw");

            entity.Property(e => e.CcgDocTypeScode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_doc_type_scode");
            entity.Property(e => e.CcgTenantPoaDocsId).HasColumnName("ccg_tenant_poa_docs_id");
            entity.Property(e => e.CcgTenantPoiDocsId).HasColumnName("ccg_tenant_poi_docs_id");
            entity.Property(e => e.CcgTenantScode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_tenant_scode");
            entity.Property(e => e.CciLogId).HasColumnName("cci_log_id");
            entity.Property(e => e.CdfCcgTimezoneScode)
                .HasMaxLength(10)
                .HasColumnName("cdf_ccg_timezone_scode");
            entity.Property(e => e.CdfCreatedMimControlId).HasColumnName("cdf_created_mim_control_id");
            entity.Property(e => e.CdfDocCnt).HasColumnName("cdf_doc_cnt");
            entity.Property(e => e.CdfEgpControlId).HasColumnName("cdf_egp_control_id");
            entity.Property(e => e.CdfModifiedMimControlId).HasColumnName("cdf_modified_mim_control_id");
            entity.Property(e => e.CdfModifiedOnDt).HasColumnName("cdf_modified_on_dt");
            entity.Property(e => e.CdfOnbehalfMimControlId).HasColumnName("cdf_onbehalf_mim_control_id");
            entity.Property(e => e.CdfOriginatingId)
                .HasMaxLength(255)
                .HasColumnName("cdf_originating_id");
            entity.Property(e => e.CdfOriginatingSystem)
                .HasMaxLength(255)
                .HasColumnName("cdf_originating_system");
            entity.Property(e => e.CdfOwnershipBu)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_bu");
            entity.Property(e => e.CdfOwnershipTeam)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_team");
            entity.Property(e => e.CdfOwnershipUser)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_user");
            entity.Property(e => e.CdfProcessId).HasColumnName("cdf_process_id");
            entity.Property(e => e.CdfSortOrder).HasColumnName("cdf_sort_order");
            entity.Property(e => e.CdfTraversedPath)
                .HasMaxLength(1024)
                .HasColumnName("cdf_traversed_path");
            entity.Property(e => e.MimControlId).HasColumnName("mim_control_id");
            entity.Property(e => e.MimDocumentsCdate).HasColumnName("mim_documents_cdate");
            entity.Property(e => e.MimDocumentsDescription)
                .HasMaxLength(255)
                .HasColumnName("mim_documents_description");
            entity.Property(e => e.MimDocumentsDocExpiryDate).HasColumnName("mim_documents_doc_expiry_date");
            entity.Property(e => e.MimDocumentsExpired).HasColumnName("mim_documents_expired");
            entity.Property(e => e.MimDocumentsExpiryDate).HasColumnName("mim_documents_expiry_date");
            entity.Property(e => e.MimDocumentsFolder1Scode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mim_documents_folder1_scode");
            entity.Property(e => e.MimDocumentsFolder2Scode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mim_documents_folder2_scode");
            entity.Property(e => e.MimDocumentsFolder3Scode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mim_documents_folder3_scode");
            entity.Property(e => e.MimDocumentsId).HasColumnName("mim_documents_id");
            entity.Property(e => e.MimDocumentsIsImmutable).HasColumnName("mim_documents_is_immutable");
            entity.Property(e => e.MimDocumentsIsNote).HasColumnName("mim_documents_is_note");
            entity.Property(e => e.MimDocumentsLinkToFile).HasColumnName("mim_documents_link_to_file");
            entity.Property(e => e.MimDocumentsNote)
                .HasMaxLength(250)
                .HasColumnName("mim_documents_note");
            entity.Property(e => e.MimDocumentsReferenceNo)
                .HasMaxLength(100)
                .HasColumnName("mim_documents_reference_no");
            entity.Property(e => e.MimDocumentsVersion)
                .HasMaxLength(50)
                .HasColumnName("mim_documents_version");
            entity.Property(e => e.MimMatrixId).HasColumnName("mim_matrix_id");
        });

        modelBuilder.Entity<MimPersonVw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("mim_person_vw");

            entity.Property(e => e.CcgCountryOfBirth)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_country_of_birth");
            entity.Property(e => e.CcgCountryOfBirthCitizenship).HasColumnName("ccg_country_of_birth_citizenship");
            entity.Property(e => e.CcgCountryOfNationality)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_country_of_nationality");
            entity.Property(e => e.CcgCountryOfResidence)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_country_of_residence");
            entity.Property(e => e.CcgEducationalTypeScode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_educational_type_scode");
            entity.Property(e => e.CcgMaritalTypeScode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_marital_type_scode");
            entity.Property(e => e.CcgTenantScode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_tenant_scode");
            entity.Property(e => e.CcgTitlesScode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ccg_titles_scode");
            entity.Property(e => e.CciLogId).HasColumnName("cci_log_id");
            entity.Property(e => e.CdfCcgTimezoneScode)
                .HasMaxLength(10)
                .HasColumnName("cdf_ccg_timezone_scode");
            entity.Property(e => e.CdfCreatedMimControlId).HasColumnName("cdf_created_mim_control_id");
            entity.Property(e => e.CdfDocCnt).HasColumnName("cdf_doc_cnt");
            entity.Property(e => e.CdfEgpControlId).HasColumnName("cdf_egp_control_id");
            entity.Property(e => e.CdfModifiedMimControlId).HasColumnName("cdf_modified_mim_control_id");
            entity.Property(e => e.CdfModifiedOnDt).HasColumnName("cdf_modified_on_dt");
            entity.Property(e => e.CdfOnbehalfMimControlId).HasColumnName("cdf_onbehalf_mim_control_id");
            entity.Property(e => e.CdfOriginatingId)
                .HasMaxLength(255)
                .HasColumnName("cdf_originating_id");
            entity.Property(e => e.CdfOriginatingSystem)
                .HasMaxLength(255)
                .HasColumnName("cdf_originating_system");
            entity.Property(e => e.CdfOwnershipBu)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_bu");
            entity.Property(e => e.CdfOwnershipTeam)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_team");
            entity.Property(e => e.CdfOwnershipUser)
                .HasMaxLength(50)
                .HasColumnName("cdf_ownership_user");
            entity.Property(e => e.CdfProcessId).HasColumnName("cdf_process_id");
            entity.Property(e => e.CdfSortOrder).HasColumnName("cdf_sort_order");
            entity.Property(e => e.CdfTraversedPath)
                .HasMaxLength(1024)
                .HasColumnName("cdf_traversed_path");
            entity.Property(e => e.MimControlId).HasColumnName("mim_control_id");
            entity.Property(e => e.MimPersonActivityLevel).HasColumnName("mim_person_activity_level");
            entity.Property(e => e.MimPersonAge).HasColumnName("mim_person_age");
            entity.Property(e => e.MimPersonBirthCity)
                .HasMaxLength(80)
                .HasColumnName("mim_person_birth_city");
            entity.Property(e => e.MimPersonBirthDate).HasColumnName("mim_person_birth_date");
            entity.Property(e => e.MimPersonCdate).HasColumnName("mim_person_cdate");
            entity.Property(e => e.MimPersonDeceased).HasColumnName("mim_person_deceased");
            entity.Property(e => e.MimPersonDeceasedDate).HasColumnName("mim_person_deceased_date");
            entity.Property(e => e.MimPersonExpired).HasColumnName("mim_person_expired");
            entity.Property(e => e.MimPersonExpiryDate).HasColumnName("mim_person_expiry_date");
            entity.Property(e => e.MimPersonGender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mim_person_gender");
            entity.Property(e => e.MimPersonId).HasColumnName("mim_person_id");
            entity.Property(e => e.MimPersonIncomeRange)
                .HasMaxLength(50)
                .HasColumnName("mim_person_income_range");
            entity.Property(e => e.MimPersonNameFather)
                .HasMaxLength(150)
                .HasColumnName("mim_person_name_father");
            entity.Property(e => e.MimPersonNameFirst)
                .HasMaxLength(80)
                .HasColumnName("mim_person_name_first");
            entity.Property(e => e.MimPersonNameInitials)
                .HasMaxLength(10)
                .HasColumnName("mim_person_name_initials");
            entity.Property(e => e.MimPersonNameMaiden)
                .HasMaxLength(80)
                .HasColumnName("mim_person_name_maiden");
            entity.Property(e => e.MimPersonNameMother)
                .HasMaxLength(150)
                .HasColumnName("mim_person_name_mother");
            entity.Property(e => e.MimPersonNamePrefferred)
                .HasMaxLength(80)
                .HasColumnName("mim_person_name_prefferred");
            entity.Property(e => e.MimPersonNameSurname)
                .HasMaxLength(80)
                .HasColumnName("mim_person_name_surname");
            entity.Property(e => e.MimPersonNamesMiddle)
                .HasMaxLength(150)
                .HasColumnName("mim_person_names_middle");
            entity.Property(e => e.MimPersonResident).HasColumnName("mim_person_resident");
            entity.Property(e => e.MimPersonVip).HasColumnName("mim_person_vip");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
