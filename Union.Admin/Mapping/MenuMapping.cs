﻿using System.ComponentModel.Composition;
using Union.Admin.Entities;

namespace Union.Admin.Mapping
{
    [Export("MenuMapping")]
    internal class MenuMapping : Mapping<Menu>
    {
        public MenuMapping()
        {
            //this.HasMany(p=>p.Operations);
        }
    }
}