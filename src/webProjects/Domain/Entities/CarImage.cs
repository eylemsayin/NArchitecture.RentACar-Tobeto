using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class CarImage : BaseEntity<int>
{
    public int CarId { get; set; }
    public string ImagePath { get; set; }


    public virtual Car Car { get; set; }

    public CarImage()
    {

    }

    public CarImage(int id, int carId, string imagePath) : this()
    {
        Id = id;
        CarId = carId;
        ImagePath = imagePath;
    }
}
