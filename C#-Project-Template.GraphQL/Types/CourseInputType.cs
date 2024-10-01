﻿using C__Project_Template.DTO;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project_Template.GraphQL.Types
{
    public class CourseInputType : InputObjectGraphType
    {
        public CourseInputType()
        {
            Name = "CourseInputType";

            Field<IdGraphType>(name: "Id").Description("Id of the Course").DefaultValue(0);
            Field<StringGraphType>(name: "Name").Description("Name of the Course").DefaultValue(string.Empty);
            Field<StringGraphType>(name: "Description").Description("Description of the Course").DefaultValue(null);
            Field<StringGraphType>(name: "Link").Description("Link Url of the Course").DefaultValue(null);
            Field<StringGraphType>(name: "Image").Description("Image Url of the Course").DefaultValue(null);

        }
    }
}
