using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using Utils;

namespace Auths.Models
{
    public enum Sex
    {
        male = 1,
        female = 0
    }

    public enum Status
    {
        enable = 1,
        disable = 0
    }
}
