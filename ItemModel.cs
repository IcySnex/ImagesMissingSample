using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesMissingSample;

public class ItemModel
{
    public ItemModel(string imageUrl, string title)
    {
        ImageUrl = imageUrl;
        Title = title;
    }

    public string ImageUrl { get; set; }

    public string Title { get; set; }
}