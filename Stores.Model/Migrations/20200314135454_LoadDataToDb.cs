using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stores.Model.Migrations
{
    public partial class LoadDataToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_stores_store_id",
                table: "orders");

            migrationBuilder.AlterColumn<int>(
                name: "store_id",
                table: "orders",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "brand_id", "brand_name" },
                values: new object[,]
                {
                    { 1, "Electra" },
                    { 2, "Haro" },
                    { 3, "Heller" },
                    { 4, "Pure Cycles" },
                    { 5, "Ritchey" }
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "category_id", "category_name" },
                values: new object[,]
                {
                    { 6, "Mountain Bikes" },
                    { 5, "Electric Bikes" },
                    { 4, "Cyclocross Bicycles" },
                    { 2, "Comfort Bicycles" },
                    { 1, "Children Bicycles" },
                    { 3, "Cruisers Bicycles" }
                });

            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "customer_id", "city", "email", "first_name", "last_name", "phone", "state", "street", "zip_code" },
                values: new object[,]
                {
                    { 5, "Sacramento", "charolette.rice@msn.com", "Charolette", "Rice", "(916) 381-6003", "CA", "107 River Dr.", "95820" },
                    { 1, "Orchard Park", "debra.burks@yahoo.com", "Debra", "Burks", "(516) 583-7761", "NY", "9273 Thorne Ave.", "14127" },
                    { 2, "Campbell", "kasha.todd@yahoo.com", "Kasha", "Todd", "(212) 945-8823", "CA", "910 Vine Street", "95008" },
                    { 3, "Redondo Beach", "tameka.fisher@aol.com", "Tameka", "Fisher", "(562) 215-2907", "CA", "769C Honey Creek St.", "90278" },
                    { 4, "Uniondale", "daryl.spence@aol.com", "Daryl", "Spence", "(510) 246-8375", "NY", "988 Pearl Lane", "11553" }
                });

            migrationBuilder.InsertData(
                table: "stores",
                columns: new[] { "store_id", "city", "email", "phone", "state", "store_name", "street", "zip_code" },
                values: new object[] { 1, "Santa Cruz", "santacruz@bikes.shop", "(831) 476-4321", "CA", "Santa Cruz Bikes", "3700 Portola Drive", "95060" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "product_id", "brand_id", "category_id", "list_price", "model_year", "product_name" },
                values: new object[,]
                {
                    { 3, 2, 1, 330m, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haro Downtown 16 - 2017" },
                    { 4, 2, 1, 210m, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haro Shredder 20 - 2017" },
                    { 1, 1, 3, 550m, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electra Townie Original 21D - 2016" },
                    { 2, 4, 3, 430m, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pure Cycles Vine 8-Speed - 2016" },
                    { 5, 5, 6, 380m, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ritchey Timberwolf Frameset - 2016" }
                });

            migrationBuilder.InsertData(
                table: "staffs",
                columns: new[] { "staff_id", "active", "email", "first_name", "last_name", "manager_id", "MangerStaffId", "phone", "store_id" },
                values: new object[,]
                {
                    { 1, true, "fabiola.jackson@bikes.shop", "Fabiola", "Jackson", 0, null, "(831) 555-5554", 1 },
                    { 2, true, "mireya.copeland@bikes.shop", "Mireya", "Copeland", 1, null, "(831) 555-5555", 1 },
                    { 3, true, "genna.serrano@bikes.shop", "Genna", "Serrano", 1, null, "(831) 555-5556", 1 }
                });

            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "order_id", "customer_id", "order_date", "order_status", "required_date", "shipped_date", "staff_id", "store_id" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, 2, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", new DateTime(2016, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 3, 3, new DateTime(2016, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", new DateTime(2016, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 4, 4, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", new DateTime(2016, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 5, 5, new DateTime(2016, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shipped", new DateTime(2016, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "stocks",
                columns: new[] { "store_id", "product_id", "quantity" },
                values: new object[,]
                {
                    { 1, 3, 20 },
                    { 1, 4, 1 },
                    { 1, 1, 5 },
                    { 1, 2, 15 },
                    { 1, 5, 10 }
                });

            migrationBuilder.InsertData(
                table: "order_itmes",
                columns: new[] { "order_id", "item_id", "discount", "list_price", "product_id", "quantity" },
                values: new object[,]
                {
                    { 1, 1, 0.20000000000000001, 600m, 1, 1 },
                    { 1, 2, 0.070000000000000007, 860m, 3, 2 },
                    { 2, 3, 0.20000000000000001, 330m, 2, 1 },
                    { 3, 4, 0.20000000000000001, 210m, 4, 1 },
                    { 4, 5, 0.20000000000000001, 380m, 5, 1 },
                    { 5, 5, 0.20000000000000001, 380m, 5, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_orders_stores_store_id",
                table: "orders",
                column: "store_id",
                principalTable: "stores",
                principalColumn: "store_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_stores_store_id",
                table: "orders");

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "order_itmes",
                keyColumns: new[] { "order_id", "item_id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "order_itmes",
                keyColumns: new[] { "order_id", "item_id" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "order_itmes",
                keyColumns: new[] { "order_id", "item_id" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "order_itmes",
                keyColumns: new[] { "order_id", "item_id" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "order_itmes",
                keyColumns: new[] { "order_id", "item_id" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "order_itmes",
                keyColumns: new[] { "order_id", "item_id" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumns: new[] { "store_id", "product_id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumns: new[] { "store_id", "product_id" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumns: new[] { "store_id", "product_id" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumns: new[] { "store_id", "product_id" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "stocks",
                keyColumns: new[] { "store_id", "product_id" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "order_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "order_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "order_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "order_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "order_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "product_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "category_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "customer_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "staffs",
                keyColumn: "staff_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "staffs",
                keyColumn: "staff_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "staffs",
                keyColumn: "staff_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "stores",
                keyColumn: "store_id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "store_id",
                table: "orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_stores_store_id",
                table: "orders",
                column: "store_id",
                principalTable: "stores",
                principalColumn: "store_id");
        }
    }
}
