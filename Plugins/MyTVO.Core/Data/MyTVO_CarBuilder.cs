using FluentMigrator.Builders.Create.Table;
using MyTVO.Core.Domain;
using Nop.Data.Mapping.Builders;

namespace MyTVO.Core.Data
{
    public partial class MyTVO_CarBuilder : NopEntityBuilder<MyTVO_Car>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            //table
            //    .WithColumn(nameof(MyTVO_Car.Code))
            //    .AsString(400)
            //    .WithColumn(nameof(MyTVO_Car.Manufacturer))
            //    .AsString(400)
            //    .WithColumn(nameof(MyTVO_Car.Model))
            //    .AsString(400)
            //    .WithColumn(nameof(MyTVO_Car.Engine))
            //    .AsString(400)
            //    .WithColumn(nameof(MyTVO_Car.Description))
            //    .AsString(400)
            //    .WithColumn(nameof(MyTVO_Car.ModelYearFrom))
            //    .AsDateTime()
            //    .WithColumn(nameof(MyTVO_Car.ModelYearTo))
            //    .AsDateTime();
        }

        #endregion
    }
}
