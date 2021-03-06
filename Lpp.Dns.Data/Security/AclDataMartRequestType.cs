﻿using Lpp.Dns.DTO;
using Lpp.Dns.DTO.Security;
using Lpp.Utilities;
using Lpp.Utilities.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lpp.Dns.Data
{
    [Table("AclDataMartRequestTypes")]
    public class AclDataMartRequestType : RequestTypeAcl
    {
        [Key, Column(Order = 4)]
        public Guid DataMartID { get; set; }
        public virtual DataMart DataMart { get; set; }

        public virtual RequestType RequestType { get; set; }
    }

    internal class AclDataMartRequestTypeSecurityConfiguration : DnsEntitySecurityConfiguration<AclDataMartRequestType>
    {
        public override IQueryable<AclDataMartRequestType> SecureList(DataContext db, IQueryable<AclDataMartRequestType> query, ApiIdentity identity, params PermissionDefinition[] permissions)
        {
            if (permissions == null || permissions.Length == 0)
                permissions = new PermissionDefinition[] {
                    PermissionIdentifiers.DataMart.ManageSecurity
                };

            return from q in query join p in db.Filter(db.DataMarts, identity, permissions) on q.DataMartID equals p.ID select q;
        }

        public override Task<bool> CanInsert(DataContext db, ApiIdentity identity, params AclDataMartRequestType[] objs)
        {
            return HasPermissions(db, identity, PermissionIdentifiers.DataMart.ManageSecurity);
        }

        public override Task<bool> CanDelete(DataContext db, ApiIdentity identity, params Guid[] keys)
        {
            return HasPermissions(db, identity, keys, PermissionIdentifiers.DataMart.ManageSecurity);
        }

        public override Task<bool> CanUpdate(DataContext db, ApiIdentity identity, params Guid[] keys)
        {
            return HasPermissions(db, identity, keys, PermissionIdentifiers.DataMart.ManageSecurity);
        }
    }

    internal class AclDataMartRequestTypeDTOMappingConfiguration : EntityMappingConfiguration<AclDataMartRequestType, AclDataMartRequestTypeDTO>
    {

        public override System.Linq.Expressions.Expression<Func<AclDataMartRequestType, AclDataMartRequestTypeDTO>> MapExpression
        {
            get
            {
                return (a) => new AclDataMartRequestTypeDTO
                {
                    DataMartID = a.DataMartID,
                    RequestTypeID = a.RequestTypeID,
                    Overridden = a.Overridden,
                    Permission = a.Permission,
                    SecurityGroup = a.SecurityGroup != null ? a.SecurityGroup.Path : null,
                    SecurityGroupID = a.SecurityGroupID
                };
            }
        }

    }
}
