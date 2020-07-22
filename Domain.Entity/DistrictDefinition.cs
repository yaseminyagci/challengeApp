using Domain.Entity.BaseEntity;

namespace Domain.Entity
{
    public class DistrictDefinition : EntityBase
    {
        public DistrictDefinition()
        {
            this.IsActive = true;
        }

        public int CityId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

        public virtual CityDefinition CityDefinition { get; set; }
    }
}