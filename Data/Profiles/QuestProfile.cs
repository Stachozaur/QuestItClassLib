using AutoMapper;
using Job.it_classes.Data.DTO;
using Job.it_classes.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.it_classes.Data.Profiles
{
    public class QuestProfile : Profile
    {
        public QuestProfile()
        {
            this.CreateMap<Quest, QuestDTO>()
                .ReverseMap();
        }
    }
}
