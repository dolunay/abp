﻿using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;
using Volo.Abp.ObjectExtending;

namespace Volo.CmsKit.Admin.Menus;

[Serializable]
public class MenuItemUpdateInput : ExtensibleObject, IHasConcurrencyStamp
{
    [Required]
    public string DisplayName { get; set; }

    public bool IsActive { get; set; }

    public string Url { get; set; }

    public string Icon { get; set; }

    public string Target { get; set; }

    public string ElementId { get; set; }

    public string CssClass { get; set; }

    public Guid? PageId { get; set; }
    
    public string RequiredPermissionName { get; set; }

    public string ConcurrencyStamp { get; set; }
}
