using System;
using System.Threading.Tasks;
using ListingScraper.Entities;
using Xunit;

namespace ListingScraper.DataAccess.Tests
{
    public class PropertyRepositoryTests:IClassFixture<BaseTestFixture>
    {
        private readonly IRepository<Property> _propertyRepository;
        public PropertyRepositoryTests(BaseTestFixture fixture)
        {
            _propertyRepository = new PropertyRepository(fixture.DbContext);
        }

        [Fact]
        public async Task ShouldWriteAndRead()
        {
            var entity = new Property
            {
                Address = new Address
                {
                    CreatedDate = DateTime.Now,
                    FullAddress = "some address",
                    Latitude = "0.0000",
                    Longitude = "180.0000",
                },
                CreatedDate = DateTime.Now,
                AreaInSquareMeters = 60,
                Price = 1200,
                Rooms = 4,

            };

            await _propertyRepository.Create(entity);
            var readEntity = await _propertyRepository.GetById(entity.Id);

            Assert.NotNull(readEntity);
            Assert.Equal(readEntity.Price, entity.Price);
            Assert.Equal(readEntity.Address.FullAddress, entity.Address.FullAddress);
        }
    }
}
