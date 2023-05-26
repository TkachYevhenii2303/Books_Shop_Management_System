using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Books_Shop_Management_System_Migrations.Migrations
{
    /// <inheritdoc />
    public partial class SeedingWithBogusAndChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("09ad2752-cd81-4b9f-b05a-91b6addbfacd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("42607bce-6b81-4389-8835-57c786eecb37"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("6adf5ee7-3b92-4c6c-b924-1c62f5b5ae0e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("7718d2e3-69ba-423c-8ba1-796bd0724445"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("a3115d9d-c861-4c0c-9afb-0f079908f088"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("de628d22-27de-4238-b07a-cb076b5cc7d5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("f0bdcf19-f0f5-40de-bb2b-b9cc4e566e16"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("f431b7e1-fa6d-4098-b256-199ca62be890"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("04065260-91ee-4465-8a13-a9f6787b2feb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("07d86398-a711-49b4-9ec3-eeeedad78f33"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0aa2e142-8f57-4d4e-8773-b014d18ec9d5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0b1f65b6-8e83-4c0d-9f0e-e73ac3670b48"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0ed2d9cf-c7b0-4ddc-aa3c-eddb0c3eddb7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("103ad585-61d2-4722-8bc9-d6a713d52b6d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("119da433-7534-4299-8446-8883183e0d9c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("12302ee6-f193-478d-9718-95d25aea314c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("13813308-327a-432d-97e0-16a95af85c33"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("18bffbe9-4bdb-4a81-aa1f-301112474607"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("197e7b84-2f69-41dd-8365-030580d2f264"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("1ca97a38-ef2f-494f-b762-dbabc3e0f23d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("1e972521-4439-41e5-a1e5-458592ab91dc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2299cc58-c0e6-433c-a1a4-0d634c8a908c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("25b68fae-d8b5-4ae4-9ebd-58da009246ce"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("263f4f0e-8040-4674-8d79-cc81133e88f4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2a948059-ef59-442b-a320-b0f24e18588f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2ed719c1-5d33-4809-b340-005d9b3caaf1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2f0bfcd9-6f47-4a20-86a6-90e40014ccc6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("34cc86bc-d52d-40d4-b090-85c9ccbfd9ed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("46cc9f0a-d86c-4742-81f0-a1619c045b19"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("4d2fb3da-32e3-4ead-8446-21f0dc1d4aad"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("4df549a4-9a10-4233-ac08-4b79c85933a4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("5172f43f-ca95-44c1-bbb9-8c9f8168e316"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("51c5c779-21e2-41ac-a18c-68f406237bf4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("5353ef20-1ca6-448c-b2f7-6724147d29fb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("59a1d996-8707-4839-acc7-0e5ccb319959"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("5e4069e5-e978-442d-b124-53c833cb76cd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("629f5880-651a-4b4a-9d12-09c814757928"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("689f136b-5f2c-4cd4-8d15-9416a16e9f35"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("69933e81-2ea8-48dd-b07e-a0951045fb99"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("69f663e8-f1c1-41e0-a1f2-1fa66b3a2c31"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("6c0f98a4-4fde-4c31-b0a6-f96a4edb88dc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("703bbfdf-c2ee-4706-9c44-c2b418d78315"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("70af0855-0be2-4778-bccc-45d55efc0cfb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("71edd655-80ee-4680-975f-5b03734c48c8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("72e1c8b6-b5e1-48bc-b8bf-c50fd04f73b2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("7341f100-eadf-43ab-9494-465c8230493c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("73eb5892-47e9-44e9-9fec-50ba9251e778"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("764f1709-a2c6-466e-b066-2684ad125ea2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("7c4b3bb6-ebe7-4989-8dfc-2c5c02b55c7f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("7cc8fbac-684e-4170-b2c7-7e3a9d4f8586"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("7e8bf01b-1dd1-4d90-8d64-f26a2e547667"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("80d1832e-1209-46bc-92e7-306b476d8303"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("823f9bdb-9fc3-46e9-8488-331144370e21"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("86c9f6f8-eb06-4972-8a34-4cddc01df960"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("8783f5ad-70c3-4bf0-a960-665bd91de1e7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("8bc2cec5-9e0d-4954-9e67-c9195e1bd2df"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("8e86dd6a-b92b-4bfe-8ecd-49936737c1c3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("9022bc43-b584-4168-89d9-f3bbf1c99ba4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("90c1a7f8-dadd-457d-9dbd-73068798068a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("93b015f3-831e-40f5-9b41-ca381a4816f6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("9ac90744-7739-4f54-998f-0844172737cb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("9d82fa44-d144-4a49-aa88-9bf535262b53"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("a02bc3f6-585e-4a6f-8342-acb0a398af58"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("a05b5c06-9c69-42a5-b8ac-a2925e721199"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("a18412c6-8a2c-4013-b3bd-46892f4e0e2a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("a8460d2c-6a1e-4479-99c7-89b21e4042ac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ab21539b-e524-4fc4-9ea3-5a91a1698194"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ab344bd4-24e1-46a7-88c0-ac3d43479dc7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ac8ebda5-9581-4a8c-af58-6cf21e1be1fe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("aeda74dc-cc80-4f12-b80c-ad785b663af4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("af7f3cd9-e80f-4c6c-b0ba-2309381a26b8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b094290a-9cfb-45ab-bff6-b22847c32606"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b0cdc87d-f6a9-4429-b74d-43e48544dd43"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b4f103de-78a6-46c3-b392-0f2e56f3dd60"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b7a32110-9c9a-4817-ae62-a8618a7ef99e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("bc14458c-6c06-45dc-9424-500d7a0086e0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c107ef54-bd5b-4c9d-9e8c-4309451aa6f3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c19747a8-af1c-4122-8506-201037492e62"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c8c8830e-2558-41d1-aa87-cfb1f59341d1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c966fb92-0bea-47f4-b88c-81a0169ad148"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("cb428323-7b4c-410c-8f7c-b09dbfe39b47"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d4928727-2855-45f7-b6f6-918063e480f0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d7809fd5-b9a7-4e51-b8f7-e2a04013629c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("da4323e3-fa54-4a79-8b41-f9fdf3cdbf25"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("dbe4bd19-ff94-4459-bcb5-f05e45d6e623"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("e3cf1ab0-b3ac-4303-89c5-ed803213a5b8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("e5965ef6-b606-46ca-a3e8-33ff18984a10"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("e8747217-091d-4cb0-81f4-365221f2cd6f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ea538cd1-0b9b-494f-867a-e831a45761a5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ec6ce5af-5449-4af1-85a6-71d90c39aa0d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("eec2d6c2-721d-40ff-a903-cb7c6367d4dd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ef1ae74f-aa37-4afe-b886-76ae7d836d79"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f10db490-6572-4bbb-a9bc-41905651e6c0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f10ee352-dec1-4428-ad43-9e5e504c832e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f167efb8-24a6-441f-9396-2faf008306c5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f2300129-b825-4d06-b526-d7132dc75232"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f9c81da5-53bb-45e8-9cad-1373b0a38db7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("fd33b82e-3d32-444d-8d3b-1f3b75e387b8"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("01f131d1-f172-4bfa-9497-40c7e698798e"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("0207dda9-376a-43ed-9a4b-735b0c1c8a54"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("03987ab8-252d-446a-8552-5ef82a54d38c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("03e353df-9d3f-4366-bfe2-3abd21053c98"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("04dd8f93-6c91-42cc-9ed0-8111a5eb3156"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("060ae4bf-87ce-4344-9d52-7af9364dde2c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("086b994c-e6d6-4161-92c1-5e59ef07cba4"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("0914b2d9-6902-4934-b1c8-db0dc3b9ec4a"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("0a73de98-adf3-4424-9207-188c8a047660"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("0c9dab4b-532c-4993-975b-bcef65313d81"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("0ecf2973-1352-40a6-b1f9-156bcea7a28c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("11a00768-b45c-4ae7-af97-280a410eb732"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("13b2acf7-02d0-4915-94f7-eefb4c15ac94"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("14477e6b-7164-49da-ae8b-0348dc301779"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("14d66710-c1e5-4675-9101-e0695ae52d96"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("155030df-de20-468f-9d81-8e04edb09bc8"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("1585aa0b-bab1-4ddd-aac9-ca72ed39d518"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("1588f916-5fdc-4ce9-8175-ebb751e0b313"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("17a9d924-72ea-4f0a-b0c6-dd4123984dcb"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("187e6ad4-0c78-49a9-bacc-e87faada2bc0"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("1f640d9f-ec83-4efc-a693-57982b864ef2"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("1f78dc9c-bbc7-48f5-a1e0-11c50d28a30c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("204477aa-265e-43ac-9755-7c3f5e7a8c13"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("214f497f-9fa7-4e4f-89c8-fd5ba5eb03c6"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("23b6a071-4b35-4444-a0e6-9770a70c8223"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("2566e07f-9fa4-4fdb-99da-862786112bfe"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("265e698c-6743-4e77-9386-0c0216749088"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("26774121-87ec-4646-b86c-5458b4a083f6"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("2831f466-5d36-4b1b-aa25-63e02da30b9c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("2bfc0e68-f283-449d-a4fe-41a296f2fca1"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("2cc2a185-09a4-4839-a725-c93f4da3b33e"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("2cd553a1-be85-47ea-b12d-aaad16952e05"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("30b32bc1-1993-4c80-9b37-0dcb2c802bdb"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("3181640d-f7cf-46fd-ba08-ec0983db1720"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("31b04cee-6bb2-4f77-a1e1-bea34d855329"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("33497919-02b7-4470-824b-9791a6b2cd23"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("34b35b65-defb-44ed-b17f-8af09d1b5f07"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("36f40896-a172-45ea-a2ed-b251b375f475"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("37e082b5-6e25-4e16-94e9-7575318b1fbb"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("3de18d84-3f92-4d8d-9d20-9d92dac6cb1d"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("3fe9f558-cc8a-4100-8385-d064aa1083bc"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("43e7f626-a47f-4a06-97db-05752c215ac2"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("47b8c39a-2208-4a39-b806-1610ac6e5e5b"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("49d99895-e7cd-4ca4-afca-c718bc845981"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("4cd3932e-6cd8-49a4-a657-e3173cb6bf78"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("50bb8b31-c865-4b75-9045-d12976b32df7"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("51daab15-6489-4b3d-83b3-0ce23d035b23"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("5388bb2e-a1bb-4047-8ab7-13d541c71cb4"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("566c81b9-d029-4e26-86bc-69fb21a4fb6a"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("568b7513-f670-4fa8-add9-2d4521fa5cf8"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("58c87b9f-4049-46ac-ba4f-9d3f246cdc70"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("58d8d875-8f05-40fb-bdbd-18fe17a16f68"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("5b17b4ae-8de4-4a1a-b8a6-4823b036a63c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("61cf78e5-54f7-4843-a398-5747c2bcb0fe"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("63577e5c-c494-49a6-b122-8a853ffe6264"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("6b62e670-1db6-452a-8227-919ec4787f00"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("6c78e887-66b3-4bae-a63d-32353d57898b"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("6e1cca59-a631-45dd-8cd5-a4d6145c4d70"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("70b99e9b-8ad6-4ec0-b077-cf83632ddaf0"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("72b1f1bc-e065-4c77-8e43-af4b0ba90872"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("7354e5b1-40ea-45a9-b5a6-55996d755cc9"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("75063f9a-224c-4320-84f9-dbb0d1032673"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("78288f35-a073-4d1e-a9a1-d9bb3ea8d02e"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("79fda08d-1f5c-4b16-8d52-5e9544ad6cef"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("7ddad99a-9aed-4319-a451-eb446fe64230"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("8037b7c2-2bac-430f-aa15-027856d1ec51"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("80cf51ae-c162-4cb4-977a-b3fe1d615e29"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("861c82aa-b5c3-448f-944a-84997751292f"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("88078bd5-f7b5-4892-bfe4-7fcab38db95b"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("890e2f6f-6ee9-4b07-8803-d57467863ffb"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("8a51879d-cae4-4235-b557-572a7e53e36f"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("8bf73868-0f95-43ec-9fd6-1fc3779368f8"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("8f32fa46-760b-47f9-900e-d28d3e4fbb8e"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("9246c107-eb08-4ec1-9522-1f3d01e0b647"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("928dda5b-ee4d-4065-9f33-59fa703ba76d"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("9316b52f-b133-44a6-b868-939c1c299507"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("941bef02-03fe-46d5-8b6d-469e7207e0ff"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("94fe1192-9df6-47d2-965b-fa279898ece0"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("95648c03-70ff-4c03-aeb5-c5a148665226"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("98035d5b-3915-4f26-b07f-e49784f5a752"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("9884a1ef-b405-4357-8257-c482ea82074b"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("99056437-9b04-4c4e-95b0-a155aa834a5e"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("99bed7e7-1c31-4bb6-ad17-7305aeb34385"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("9c30aaf0-228e-4d53-98ee-5ed9a55bba37"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("9ca1ebc7-898a-4668-8ace-97ee5a5381b6"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("9f13b96b-b8de-4e74-aa43-032547fdcc07"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a0a48e5b-a287-4106-86cf-53ad73e0a20c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a1487b31-283a-4c29-8981-72154d29e970"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a52a8ddf-77c9-4cc2-9cbc-2a857a6a1ab1"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a57a81aa-801d-44e9-987c-8b83d7f6b6db"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a66c368f-b903-43b7-8c5c-4084daac5725"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a6b2d555-7890-419a-a02f-cc4844145b6d"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a783021b-8aa0-4a35-b590-67e4ecff7137"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a7fcfd23-9706-490c-a4ad-0faa0654ca5e"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a83c449b-b004-430f-a74e-770d6a7bc3d0"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("aba7eec8-1acc-41de-a9da-fb1bb31f54b6"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("aeae07b6-305c-4bff-9be5-b991521ae6b1"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("b165d99e-c6a3-4ed9-bfb4-b53b07378481"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("b3661edd-2d9c-4552-9835-5a49b1250675"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("b37d2e00-ddf0-4ce7-aa12-a579706d248a"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("b4324f82-a546-440b-86e9-15a1d7cb7590"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("b81ce3b9-544d-4d3f-89a3-79f4b423cc72"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("b93ee472-cb97-42a6-90e7-46afdcd1b9e5"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("bae16683-1bf0-417d-9991-59b04218b42a"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("bb0f9238-460e-47d4-9b61-da7fd677fffd"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("bf7c516e-9950-4bc7-919a-b8270e934a03"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("bfc822fb-69ac-4971-8c0f-cacdac8a510b"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c0fcd4bc-e0dd-4d92-9e65-9009aa028993"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c408036d-4a52-4a77-96f4-f3d43f47042d"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c4c71157-7059-4016-896c-9d06563fd8d3"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c51e81c4-a26d-4d37-a086-f0bdbd350d28"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c575f57a-8323-4620-899c-7c6c886b3734"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c67a432e-ba45-44c9-ac89-2a3f6c429f95"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c8342e08-d884-47e2-a638-ff2a4c8fe610"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c905961c-ca04-47d7-8228-0893d5e63f16"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("ca5f491b-e9db-4bfd-bfa1-de9ab9b00475"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("cc234c99-02e0-4279-901e-497f6e8859d1"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("ccd77a61-7866-47e4-b0b9-a47d80f806d8"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("cce7ef87-84d6-4b0d-b2b8-8116fbc5e0b5"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("cd3d917b-bcb6-497c-be87-facb4f129e44"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("cff1b065-9ac3-4c46-ad96-171e8567455e"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("d024720d-aa53-430f-ad4f-537369492dde"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("d1484a51-44dc-489e-8693-98b0807016f9"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("d5947c56-fb2e-4584-803c-0354eb2e703c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("d6e9ecfa-0126-4bf5-82a0-2f8d97648cb7"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("d7adbddf-b933-4a62-aacc-6492e4b328e3"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("d7f529ce-5253-42fa-b567-0a4d74f0cfdf"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("dbc1d823-4440-4e66-9467-b904831cec37"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("dddb4ea9-2730-499f-945c-aaf4934fe257"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("dfb1e0cf-cdd5-4f41-b6df-52423b64e51d"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("e03d0934-6f02-4413-a023-ad8f30bd52ab"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("e0647488-53ef-4b1a-8f9e-35f7cd85912f"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("e21f6232-b964-4a50-a6ce-ada6e5a2ba4c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("e2b7a726-37b3-48e0-b766-7f2b97795d69"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("e924225b-6b17-43c4-8637-6405f2fa495c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("e9b689e8-6daa-465a-827f-ee7ae401bbf5"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("e9fe3770-b565-42d3-89cc-21af0db81aa7"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("eaf5ef79-0013-48aa-b9c2-7fe7ebaa4b33"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("ec073edd-e65d-4ec0-b130-20d1d2b06ed1"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("ed4e0949-780a-4236-b11a-30eed25aeefe"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("ee88e4cd-66e1-4e32-9e30-5c5f8f345b5f"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("ef102dfa-12d5-4e55-b498-0ef17609eb87"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("f176a641-e69e-4f7a-9426-daf2e44664f3"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("f17d1161-8219-4a0a-92f2-c95451449054"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("f61cecb3-9852-4224-a048-ceb696c580e3"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("f64dbb19-ac4d-4043-8b50-86d7311dcd42"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("f6a181ce-8b79-4e92-8063-ad733f2f7e03"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("f892041a-a574-4ca3-acd2-698a44063c6d"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("f966cae8-ae2a-4a1e-8d2c-d27a74fdc286"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("fb4faf63-476d-4b68-b679-e855bdf4a3d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("07bfc904-0589-4b13-92c8-a336cf07370a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("26c5fc7d-748b-4363-ae79-ae3001ed9c89"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("4e41098f-93ec-4b13-9ffa-dfcbdfa9a14c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("acfe15ba-0527-4803-8582-d5dcac37a03b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("b48c3ad9-257b-4521-a410-cfbf8dbf4e2e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("d8b31e2b-5c27-4a01-8fb3-185e9a159f72"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("1e0dd338-b92c-42f8-b93b-c83c8b47927a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("1ec2d558-a707-4d7e-b326-1bf3eaf779d0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("24bc6580-7dbb-4db3-9660-cfbf64bafc91"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("505ffe33-5ac9-4b92-82e5-408fe2eff2ee"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("55868b4d-b7b2-4a30-b83c-3d7239d4cf0f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("63bc964d-721d-4c43-ab85-171b770c9c2d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("90357598-f0cb-4538-8d0c-56b7202da1e8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("ac38031a-defc-4959-bbeb-cbc756dd8cf5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("00c932ad-4f84-4a9e-affd-3af56c233df7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("03778631-6dee-4b50-8b97-7b541be41b35"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("056275e5-7e82-4502-84d2-5bd694d91664"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("066a0b51-772a-4da5-a0ec-f72d32fb491e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("09b39016-0fa7-439d-8c94-0690dabecf7d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0d60b3f0-100f-4b8c-84d8-3b5c4e97f86b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0e58f760-cd6f-4529-900c-7a72faded70f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0ea3a09a-cd05-477e-94cf-a68d053edddf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("10468d37-414b-43b1-8370-105386965d9c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("108cd72b-9307-43c9-9974-c6fb4726ed78"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("10b8352e-b8d6-4a93-9965-85995888b2b8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("11f211a1-b1d9-46ae-83f4-0f0736bb5973"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("11f8d160-fab5-49cb-abd9-5b3c0098dc80"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("1a05140b-6537-42c6-8170-8c63337213ae"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("1c5c9173-d8a0-423c-8f23-4520e4d6eb4f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("1ca32809-812d-462b-9290-cef6314d3f53"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("23486d58-ca9d-4dcb-8943-eb989c3e22f2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("24e8a2a2-bada-454d-85d8-57b99d6bbbcc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2730a781-85cc-4bc0-9f3f-236aa0fe0d47"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("28949b30-600e-416f-9186-fb802e2325e4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("291a9e51-c0ee-4100-8e5b-a314456a54e7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2b6040ff-9a06-40dc-ac0a-00cc18682f03"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2c6ce7a3-6f78-493b-ba85-acdafbfb8364"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2ee4c8d8-a774-4193-9062-799f96077618"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2f872c93-9bd3-4354-81a5-e93d251f12c0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("30cae8a7-61a6-4efd-b24b-6a46fbce9130"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("31ab896f-9857-4048-818a-6224f133907f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("340a30eb-48e8-4ca5-b94c-25c8f3d830aa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("360eb8d6-226e-4418-8487-f32050fad936"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("409b82f4-97ce-4eb5-88dc-bbfd30c0cc6f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("48358f7b-cf83-4c99-a228-9ad4c4537cf1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("48d22703-3da2-49d5-83ec-dc467cda9355"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("4bbef38c-0311-403a-a2c7-9f605ac159fd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("4c9528be-6f9f-4755-b443-b6ca3c7d817d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("4e3ceb35-e02c-4508-93cd-2182558d298c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("4ed2b14c-a136-4cd7-a35d-cf68c49966bf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("51fc3130-13a0-448c-a2b5-40b42030972b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("52b3e668-05de-42dc-934e-7e7fb0b57ac7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("55b05bd5-6d3b-4576-9b95-9b242e56a7a9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("585acfc7-b45d-423b-a88e-34ef19de0ff6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("58714022-2947-4e34-bd52-c547afb59daf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("5c9ccfe2-a6dc-40f1-9035-c857a1769be6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("5ce9bf91-3f0f-42cb-91fa-48dfaaf5b442"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("64e61c2c-06a9-485f-80b9-f0ef2ee44597"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("677e0b2e-36ff-4da0-aa6b-07cfae1e12c4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("69433bf0-fc4a-471f-b1d7-268a131e3ad4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("6d42e309-ad7a-4659-bc5b-2da1eee45e67"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("7631ddc8-33e9-4990-985b-d0b45867c041"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("795765f5-155e-4061-9597-ea4fd8e8fe92"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("7b0f7691-ca17-4900-a292-7c17a6057a77"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("7b70d60d-1ce6-4d24-8e8c-b74a1a9a754f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("839da5ca-9e9b-4543-adae-717c33459aad"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("85f019f7-7433-4924-a283-ce8f67fd35d8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("871d010c-c538-41cd-9325-ac1eeeb10e6a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("8ab18e2f-41dc-4200-8888-71b526de99e1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("8c434c8f-769d-4eaf-8504-23fb064631bf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("8d3d9c9c-e761-42f3-adfe-7fd10af6416e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("90e75ae1-88b0-4817-9131-297e0366d7f1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("93a533ef-a869-425d-8678-3aa3805ae2d2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("93a93bd3-3d9e-4051-85aa-651fc6da8110"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("94acf787-c999-4a29-b58f-5487692ef03f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("9596ba26-312d-4848-98e3-21ac02a85449"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("95bc042d-bd93-4b48-9925-94dc8a87b123"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("96406142-2c9c-4bc6-9bc6-f3ec34a73d9b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("9654b37d-e4e0-4f4d-b77c-24fb558e2560"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("995a4228-a065-4b77-9539-57d16fa48c28"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("9b272776-eec1-417d-996a-1c2d6e9d0dc1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("9f03838c-c10f-4de9-a177-51fcc6ddf603"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("a127cf02-7c43-49bb-8ff2-973daf877f17"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("a14bdbea-6129-44c5-8d19-9507034b3a1c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("a7965963-621c-4e8f-821e-bb8eeb7543e4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ac01968d-18f7-4183-b96b-ee83c0dc39de"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ac47fe49-ef25-414a-88a0-3635db678558"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("acfc5322-52de-4136-994b-cf1fd9cf4e84"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ada7be1d-897e-4775-8e00-66c4604dc7c9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ae6b5414-bc28-4db5-a650-8550cabd8ffb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("afcb4b3f-0c20-4939-9bfa-dc20befbe091"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b19f0613-f4fb-49a6-b5d9-0a8c8f5e234b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b3ed2045-e2b2-4efa-b7f1-eecb1666dd1b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b785ef47-2f7a-4c89-8b05-0a12a1568ee2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b863791b-8079-49b5-8cdb-cb7b198344cf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("bd7f1161-7d7d-4ebe-8dbc-f2490805fb73"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("bf5faa9c-1e9f-4879-a66d-341e526a22ed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c443085c-4158-4baf-8e27-6e2e7b841cf0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c51ef219-08ee-45d4-a56e-e86c5e3b62ee"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("cb8e796b-4d1c-42e3-8d51-b2dc9ea348f1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d0eadaf3-fb10-4bf1-aa63-8cf5af448c5b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d681d0b2-d7fe-4937-8aab-d2f644cd61b9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d6e19d29-1a65-4547-90e5-e96fda18f289"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d887cb46-300b-4810-808f-0a8845a8cd12"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d9bb9b63-3d3a-4d48-b107-610acf06726b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("da81a0d1-23f7-40fd-9bb3-c8480d88739a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("de2f9f61-b80c-4e18-80a4-253ef1c2eaf0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("dfb2a5b3-db25-47e4-a336-4c3c6ef93d88"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("e0ed6f4b-22ae-40b6-ae3f-b59e56f00391"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("e10eb8ad-77f4-4f24-b856-192b24ba1684"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("e298f4ee-ea09-4f70-87a2-bd895c2919f9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("e86ee355-5d97-427b-b1a7-3d53dac700a8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("eee28c5d-4251-49e5-b9fd-8f17c5e47b2f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("efe0851b-4656-4767-9019-a7e53584c6cd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f01d2771-8072-41ea-886d-c9ccb1e85b2f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f0a15012-8aae-4ddd-a72e-8f1bbdade4a7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f1cc25b1-0c73-4051-8983-6c4a14dcb613"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f32fa088-3743-44c2-88bb-b6039179dfd2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f7f732f4-419c-4171-8d3d-74176cbfe331"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f9da077e-861d-4e38-9d32-576c35bb5fff"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("fb7a1b15-3234-4f42-b063-2c0e799eb28b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("fb987643-d6d6-45f1-9899-433b71348b00"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("fbfc5621-ab97-4bca-ab60-9dbc2d4ccddd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("fd355bbe-71dd-499d-bf02-266ba2cff511"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("08b0af99-cbbd-48a0-af1e-2a6364e65a10"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("0901235a-4929-4001-83f3-4dc6fc4c91b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("0efa878f-95f0-4ec1-8b55-739869105146"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("191b6c17-50ca-414b-8ce8-f717a7147d82"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("243d2a88-befd-486a-8056-e77c9918556b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("2b7b655e-2a55-4871-b7ce-9eea7aa8e8bd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("2ddf5340-95cd-4b4d-bbb5-513cb5a98978"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("324acb0b-616b-4a90-92fa-a1af1a4fda44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("32f84807-bac5-40ca-9304-9296f8498555"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("3dda5049-d3da-4d81-a755-bc51c96a4296"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("4340af6f-b3ae-44cc-a751-41ffc606bafc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("4627831d-bab8-43da-b895-2763db534c22"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("474be3f3-8c47-4b39-909e-945aed13b954"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("4b877a03-2cbe-4867-a3b7-47947d8d1a69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("55721b5d-fb9c-4f51-8a4d-f89b229e15f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("58c651bf-d232-488c-bdd7-e00f6d782709"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("5aa5aefd-8799-4758-a1de-f674f09d120f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("6af3aa61-e3d8-4a30-b714-6f42c8907f9f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("6b86c90c-c9e4-441b-867e-dca5d8970979"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("6e8d70d5-1701-459d-b972-c968f01e6982"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("7064397d-7d0c-40cc-9ec0-202a2ce149cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("77095b7b-83d6-41df-a14e-3d4b9672bb85"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("79212cae-4f6c-4ea0-a52a-632bd6615152"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("87aa25a6-e526-4db3-b98c-fefdaf6bb4a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("8a72f418-32b4-491a-a785-c794ec863ac3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("8f88c931-ec6f-422e-bb08-baf0f45ebee0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("9a3b5391-1845-4fe6-a2ee-4d4635d57eae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("a4ddabf8-80f2-427d-9eaf-cca7ce9ba586"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("a9404063-aaa8-43d3-8197-0d1b8147c715"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("a9ad3768-aa7e-40de-93c6-7b086609f3d0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("aa28398f-e35e-4985-a653-b4092068b296"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("bba8001d-d7db-49e6-883e-618e1a168421"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("bf5b22ee-95d1-43de-9e12-4c7b546a0ad3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("bfac342a-bef6-4eef-a99f-497f6b577878"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("c0268d5a-82ae-404a-b5c5-1d4e18a453d7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("c1a2ea7b-b45d-45fe-8bf2-0a2cd23849c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("c50c3ec8-4cd6-4e0b-b6e3-93d5e34e6c16"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("cd013daf-4c1e-4101-887f-736f48a44de5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("d0dfbe89-5d75-4c4f-86cc-006695e70000"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("d76c463f-7a82-4767-b6c6-e34c0e9a994c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("e082a350-1045-4ace-9f4d-9f7168271c28"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("e4386634-3511-4c82-9856-3881c6ea41ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("eb0deb9d-cdfc-4ef7-b429-5fab7ea2dc9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("f3f5216b-2862-4489-8c9f-d6183389d31e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("0179a996-12da-4ab9-a061-fc5522682ba0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("051a76bf-d39e-42b9-abde-e368be575958"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("066710b3-9460-4e81-a086-42eb03d36f30"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("0906c38c-03b5-429c-81fb-48f83537bed2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("0a027160-afe0-4c41-b60a-b743e7e5384d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("0d263711-2385-4035-9fab-15fb5a644ab7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("0fd42dd8-4a25-41e9-b135-522849af300c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("108ee869-1851-4290-b3e9-9924afdf3769"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("11b31cc2-3df4-43fc-8226-9e5551f48730"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("159f915b-baaa-4f89-996a-6773d02ba278"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("1867ee2b-5953-470e-b2c7-97f8203b5e59"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("213baca9-217b-4e91-ba0a-d36da2249931"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("239abe78-fbbe-4174-8147-52b5bc89b88f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("24fede50-f56f-43f9-95ea-77ef82cadc0b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("25f0acab-897a-410b-83a2-af005c31ead9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("28de0484-8f41-43e5-9836-a0d74fe78a66"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("29cd46bd-3f89-4d22-911d-aae5be748d82"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("2bbe32a1-82fe-4243-8c02-6df149dfcd1a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("2f7a09d3-9df6-4dfd-af04-e15c5a8d65e4"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("328b9cd5-a71a-4f48-877f-229925b3d090"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("36a7431f-c62f-44a0-8558-ee3c31d4b09b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("405e81da-1f0b-498c-8335-0b71e82e8538"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("4e5f53d2-34c2-442e-bb19-74f7a3cb4406"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("50681485-14d9-450d-b2e6-2643d251ab8a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("5a4618c4-1d9b-4754-b694-2f9c47ba107a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("6296317f-55b5-461d-9958-2111e9acca3c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("69123db0-013e-468b-9b0b-a739921dfd2b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("69556c96-0676-411e-a391-e12f060f1f02"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("6ab3918c-623b-4521-99f2-dde6f0195044"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("70146ef7-491f-4d55-bbbd-8c83f5255f4a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("71a1603e-8f57-49a5-be43-22bdc8157264"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("7471b94c-de3a-4622-bd6d-cd5a10111641"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("753e53da-7278-495c-a264-d76250b07ed9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("758125a1-855b-42f4-aaf3-53adc00d6fc8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("7ebcbe6e-ba17-4672-afb7-413722c0335f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("7f0bbe55-4495-4dff-8ce3-e6b3b7b17232"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("83a373c4-3acd-494f-949a-d6f3db4c37bd"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("8aa5d51c-0cd3-464e-8c45-906de52acb4f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("97d97933-2755-4986-bdc9-ba19d5c7d21f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("9878d865-2300-4b82-879c-f4d9861202b2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("9eb178d7-31ea-4fe6-b28e-8be923833201"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("a013f08b-9974-485a-ba14-7b246db17d9e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("a8f59154-3dce-4cfd-83d6-b03e23899d4d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("ad5a7d28-9f5a-4a95-8fef-8e10df49e683"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("b4b5fd94-c38d-4f89-bdf0-91b51fa4fb1b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("b5e6a311-be2a-403c-b821-d04406aabb25"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("baa866f0-cf27-4eb1-9848-fa7333f4114f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("cad92ffc-845e-4fa7-9ae7-e9c414a0a962"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("cbb386cf-80b3-4c3c-aee9-d30c20bf9b06"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("ce4466a1-a40f-4b50-bc0d-745ec4971776"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("cea363af-7638-4c56-8847-cb1bcf46f0e0"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("cfb062ac-b80b-4b4c-8313-0c32c16ac91d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("d7a75598-b77f-41e7-9ed0-71a9651c4e2e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("e6464331-4865-4d45-9ef8-f744cc45ce0c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("e762be0d-e256-4f6c-b628-bbb1807adb14"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("e87cb78c-2508-44db-bfc1-fa458be0a03a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("edfe5fee-490d-420e-a77d-32eb99e8e153"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("eef15fa8-e309-4135-b7b4-367e6871a0b6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("fc874fde-341a-48c7-9d81-fd18e8aba820"));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "ID", "CreatedDateTime", "FirstName", "LastName", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("00928cb2-85df-4ef6-936c-b472b08a5b25"), new DateTime(2023, 5, 26, 23, 25, 2, 606, DateTimeKind.Local).AddTicks(6327), "Perry", "Reilly", null },
                    { new Guid("03bd8fff-a187-4221-add8-8ef5a1f2a812"), new DateTime(2023, 5, 26, 23, 25, 2, 609, DateTimeKind.Local).AddTicks(7414), "Wilbur", "Welch", null },
                    { new Guid("04f85738-2b5e-49c0-99d3-75fb56d43b65"), new DateTime(2023, 5, 26, 23, 25, 2, 607, DateTimeKind.Local).AddTicks(8406), "Enrique", "Hessel", null },
                    { new Guid("0986a770-5c7e-4174-ae7e-a51f766125ff"), new DateTime(2023, 5, 26, 23, 25, 2, 608, DateTimeKind.Local).AddTicks(3228), "Tammy", "Marquardt", null },
                    { new Guid("0ae56f23-dbc4-4328-bd37-7f1d368e13d5"), new DateTime(2023, 5, 26, 23, 25, 2, 609, DateTimeKind.Local).AddTicks(6682), "Amos", "Larson", null },
                    { new Guid("0bf1d7b8-5519-4189-aa4e-b05d3f15e023"), new DateTime(2023, 5, 26, 23, 25, 2, 605, DateTimeKind.Local).AddTicks(8282), "Louis", "Swift", null },
                    { new Guid("0c233fb2-4c9c-49f8-b0db-b24f41b8a6f8"), new DateTime(2023, 5, 26, 23, 25, 2, 606, DateTimeKind.Local).AddTicks(1482), "Veronica", "Klein", null },
                    { new Guid("0c49b46e-dbbe-4ab8-a534-453dc978e05b"), new DateTime(2023, 5, 26, 23, 25, 2, 610, DateTimeKind.Local).AddTicks(2173), "Mathew", "Murray", null },
                    { new Guid("0cde1a77-cd18-4050-8ac4-d6876130d0bb"), new DateTime(2023, 5, 26, 23, 25, 2, 608, DateTimeKind.Local).AddTicks(9540), "Craig", "Langosh", null },
                    { new Guid("0e779553-638b-4c1c-b603-d345a2bcb7ee"), new DateTime(2023, 5, 26, 23, 25, 2, 607, DateTimeKind.Local).AddTicks(271), "Al", "Dietrich", null },
                    { new Guid("11c7d492-c74e-4b89-a188-d81d276d668e"), new DateTime(2023, 5, 26, 23, 25, 2, 608, DateTimeKind.Local).AddTicks(774), "Doyle", "Dickinson", null },
                    { new Guid("1a5cdc9a-87a4-4857-a0b9-6320e4bb416c"), new DateTime(2023, 5, 26, 23, 25, 2, 605, DateTimeKind.Local).AddTicks(4260), "Darin", "Hackett", null },
                    { new Guid("288fb03e-6db0-46aa-b89c-23601cf11b03"), new DateTime(2023, 5, 26, 23, 25, 2, 605, DateTimeKind.Local).AddTicks(3449), "Lora", "Kuhic", null },
                    { new Guid("295d4de8-6461-404e-b30e-63a5e924b0eb"), new DateTime(2023, 5, 26, 23, 25, 2, 606, DateTimeKind.Local).AddTicks(8741), "Orlando", "Sauer", null },
                    { new Guid("2aefbbd3-c4e7-4f92-9b67-6267ddebe85f"), new DateTime(2023, 5, 26, 23, 25, 2, 610, DateTimeKind.Local).AddTicks(3065), "Brandon", "Kshlerin", null },
                    { new Guid("2eda534d-2129-41c1-a75e-9ecabd9237c6"), new DateTime(2023, 5, 26, 23, 25, 2, 604, DateTimeKind.Local).AddTicks(9948), "Christine", "Kutch", null },
                    { new Guid("359525c7-4640-4805-ba56-7733d5bfe825"), new DateTime(2023, 5, 26, 23, 25, 2, 610, DateTimeKind.Local).AddTicks(5493), "Carlos", "Ullrich", null },
                    { new Guid("39dd1203-928b-40ae-a55a-f3daa9f463ae"), new DateTime(2023, 5, 26, 23, 25, 2, 606, DateTimeKind.Local).AddTicks(3154), "Andre", "Wilkinson", null },
                    { new Guid("3ef679f4-7f15-466a-af52-d9497bb48f4a"), new DateTime(2023, 5, 26, 23, 25, 2, 608, DateTimeKind.Local).AddTicks(8741), "Angelica", "Sipes", null },
                    { new Guid("49c4c0c9-e91b-4cf5-90d2-fc3bbef3a9f6"), new DateTime(2023, 5, 26, 23, 25, 2, 606, DateTimeKind.Local).AddTicks(9507), "Peter", "Terry", null },
                    { new Guid("49eb8cea-5f30-448c-a7b7-2ac55e2b9ab2"), new DateTime(2023, 5, 26, 23, 25, 2, 607, DateTimeKind.Local).AddTicks(3582), "Virginia", "Von", null },
                    { new Guid("4cabe2e7-41a9-4d29-b3e5-fea41737b8bc"), new DateTime(2023, 5, 26, 23, 25, 2, 607, DateTimeKind.Local).AddTicks(1027), "Dominick", "Oberbrunner", null },
                    { new Guid("4f6b6b17-2277-4dbe-b377-873878974d05"), new DateTime(2023, 5, 26, 23, 25, 2, 608, DateTimeKind.Local).AddTicks(4014), "Sherry", "Wiza", null },
                    { new Guid("569d2cee-4715-4a2c-8cb0-e99f8596180c"), new DateTime(2023, 5, 26, 23, 25, 2, 609, DateTimeKind.Local).AddTicks(315), "Elmer", "Crooks", null },
                    { new Guid("570485de-66aa-4c14-af7b-d16b04c4482d"), new DateTime(2023, 5, 26, 23, 25, 2, 610, DateTimeKind.Local).AddTicks(6319), "Catherine", "Considine", null },
                    { new Guid("596ce2c7-1adf-41f4-88fc-a3a42d04c9a3"), new DateTime(2023, 5, 26, 23, 25, 2, 607, DateTimeKind.Local).AddTicks(5150), "Hector", "Moen", null },
                    { new Guid("645311ea-aa9d-4cae-b93f-498ed2d1096f"), new DateTime(2023, 5, 26, 23, 25, 2, 608, DateTimeKind.Local).AddTicks(6357), "Ignacio", "Rippin", null },
                    { new Guid("6723c5a7-dec1-4637-bacc-1cc50e07cf30"), new DateTime(2023, 5, 26, 23, 25, 2, 610, DateTimeKind.Local).AddTicks(8637), "Christopher", "Ward", null },
                    { new Guid("69d0cb4b-4544-42c8-8c5f-1ad4d96e8a23"), new DateTime(2023, 5, 26, 23, 25, 2, 606, DateTimeKind.Local).AddTicks(5561), "Bridget", "Kuhic", null },
                    { new Guid("6c0f492f-81f0-4187-bfba-6fb4e159a67b"), new DateTime(2023, 5, 26, 23, 25, 2, 607, DateTimeKind.Local).AddTicks(5981), "Shane", "Abshire", null },
                    { new Guid("6cc7736f-9d5f-49de-a246-b6824902e1ea"), new DateTime(2023, 5, 26, 23, 25, 2, 608, DateTimeKind.Local).AddTicks(4772), "Rosie", "Bashirian", null },
                    { new Guid("6f36ca4e-4249-484d-82d5-c8e1148138e5"), new DateTime(2023, 5, 26, 23, 25, 2, 608, DateTimeKind.Local).AddTicks(2377), "Chris", "Gleichner", null },
                    { new Guid("7563f48f-fe9f-4f5f-b9e3-db3401605773"), new DateTime(2023, 5, 26, 23, 25, 2, 608, DateTimeKind.Local).AddTicks(1589), "Julius", "Kassulke", null },
                    { new Guid("76243127-6c70-4fa8-81a6-a01a27ff8f9b"), new DateTime(2023, 5, 26, 23, 25, 2, 610, DateTimeKind.Local).AddTicks(7078), "Ernest", "Kovacek", null },
                    { new Guid("76d06899-cfb2-4a95-9718-12800f36d1e6"), new DateTime(2023, 5, 26, 23, 25, 2, 609, DateTimeKind.Local).AddTicks(5846), "Tricia", "Quitzon", null },
                    { new Guid("77f044e8-8a3c-4be7-b927-d894468b2693"), new DateTime(2023, 5, 26, 23, 25, 2, 607, DateTimeKind.Local).AddTicks(2722), "Kristine", "Schneider", null },
                    { new Guid("7973bf28-20a5-4d56-9101-3ababb74178f"), new DateTime(2023, 5, 26, 23, 25, 2, 610, DateTimeKind.Local).AddTicks(3903), "Ellen", "Howe", null },
                    { new Guid("7ac18a11-b1d9-42b9-bb81-19a83aafd5bf"), new DateTime(2023, 5, 26, 23, 25, 2, 607, DateTimeKind.Local).AddTicks(1868), "Wayne", "Murazik", null },
                    { new Guid("7c2c7cf7-138c-45a9-92f1-39c1cfd1a5e5"), new DateTime(2023, 5, 26, 23, 25, 2, 608, DateTimeKind.Local).AddTicks(5532), "Ed", "Wiza", null },
                    { new Guid("7c8b17c4-8943-484b-9b06-c97acce7756e"), new DateTime(2023, 5, 26, 23, 25, 2, 605, DateTimeKind.Local).AddTicks(5846), "Erik", "Koch", null },
                    { new Guid("7de6f4ed-9e9c-4718-9839-b3e8de8428bf"), new DateTime(2023, 5, 26, 23, 25, 2, 610, DateTimeKind.Local).AddTicks(4703), "Tabitha", "Wuckert", null },
                    { new Guid("7ebae05a-e45e-4aa6-847d-f26e8330053c"), new DateTime(2023, 5, 26, 23, 25, 2, 608, DateTimeKind.Local).AddTicks(7981), "James", "Jones", null },
                    { new Guid("81f674cf-da03-4593-881e-d4eb7fb2bec1"), new DateTime(2023, 5, 26, 23, 25, 2, 606, DateTimeKind.Local).AddTicks(690), "Verna", "Collier", null },
                    { new Guid("859dc25b-d52f-4fae-9db5-1e2018d8f139"), new DateTime(2023, 5, 26, 23, 25, 2, 605, DateTimeKind.Local).AddTicks(7445), "Rosalie", "Schiller", null },
                    { new Guid("8cea83b8-56d0-4f1d-9853-fbbc83bc77c6"), new DateTime(2023, 5, 26, 23, 25, 2, 607, DateTimeKind.Local).AddTicks(4370), "Herman", "Shanahan", null },
                    { new Guid("90532c0f-4a8e-41b8-a4df-1bba53edd1f1"), new DateTime(2023, 5, 26, 23, 25, 2, 608, DateTimeKind.Local).AddTicks(7), "Janis", "Botsford", null },
                    { new Guid("91f80af1-00b9-47ad-9780-a236d3e0f1a3"), new DateTime(2023, 5, 26, 23, 25, 2, 606, DateTimeKind.Local).AddTicks(4760), "Candice", "Stroman", null },
                    { new Guid("92c55e3e-c44a-470b-9628-9ffa24236459"), new DateTime(2023, 5, 26, 23, 25, 2, 605, DateTimeKind.Local).AddTicks(5041), "Nina", "Hermiston", null },
                    { new Guid("9329bb4b-7626-4091-be5d-d46d5f7ed3d1"), new DateTime(2023, 5, 26, 23, 25, 2, 610, DateTimeKind.Local).AddTicks(1429), "Jane", "Ledner", null },
                    { new Guid("9f165e0a-f59d-45f4-a9d2-bc7845d5e097"), new DateTime(2023, 5, 26, 23, 25, 2, 609, DateTimeKind.Local).AddTicks(9121), "Marcos", "Reinger", null },
                    { new Guid("a2894ab4-3454-4114-b889-5013ef80cacb"), new DateTime(2023, 5, 26, 23, 25, 2, 605, DateTimeKind.Local).AddTicks(9100), "Kerry", "Russel", null },
                    { new Guid("a50e9cd6-e1b6-44cd-9dd2-50530ab00a37"), new DateTime(2023, 5, 26, 23, 25, 2, 605, DateTimeKind.Local).AddTicks(9890), "Nelson", "Kirlin", null },
                    { new Guid("a59310cb-532c-4326-905c-7ddeb822dde3"), new DateTime(2023, 5, 26, 23, 25, 2, 609, DateTimeKind.Local).AddTicks(4290), "Rosie", "Johnson", null },
                    { new Guid("ad7847c0-45a1-4b18-8744-80995c47683c"), new DateTime(2023, 5, 26, 23, 25, 2, 609, DateTimeKind.Local).AddTicks(9877), "Phil", "Schoen", null },
                    { new Guid("adf51bb9-dbf6-4040-b82b-5167365248ab"), new DateTime(2023, 5, 26, 23, 25, 2, 609, DateTimeKind.Local).AddTicks(1068), "Frances", "Keeling", null },
                    { new Guid("ae0c04c3-436b-4a34-a9e9-e5f90f6a4874"), new DateTime(2023, 5, 26, 23, 25, 2, 606, DateTimeKind.Local).AddTicks(7966), "Doyle", "Keeling", null },
                    { new Guid("b0bf864a-da5b-453d-a830-b189b93b6813"), new DateTime(2023, 5, 26, 23, 25, 2, 605, DateTimeKind.Local).AddTicks(2599), "Emily", "Boyer", null },
                    { new Guid("b0ebd007-80c6-412b-8301-bf0876f11d3d"), new DateTime(2023, 5, 26, 23, 25, 2, 609, DateTimeKind.Local).AddTicks(5110), "Gloria", "Rohan", null },
                    { new Guid("b3fa7c31-12b9-4092-908b-c4a10a81f7de"), new DateTime(2023, 5, 26, 23, 25, 2, 610, DateTimeKind.Local).AddTicks(7869), "Jody", "Ullrich", null },
                    { new Guid("b4ea8a85-9f35-4da0-881c-ce5d4a503997"), new DateTime(2023, 5, 26, 23, 25, 2, 609, DateTimeKind.Local).AddTicks(3516), "Sharon", "Spinka", null },
                    { new Guid("c64ce4c7-a794-420d-b9fa-812befcf9788"), new DateTime(2023, 5, 26, 23, 25, 2, 606, DateTimeKind.Local).AddTicks(3988), "Cathy", "Reichert", null },
                    { new Guid("ca2e16c9-b1b5-448c-baf2-56dfa1595221"), new DateTime(2023, 5, 26, 23, 25, 2, 609, DateTimeKind.Local).AddTicks(8258), "Roberto", "Gaylord", null },
                    { new Guid("cae3d1f4-0049-49e0-b439-c18397f390c9"), new DateTime(2023, 5, 26, 23, 25, 2, 605, DateTimeKind.Local).AddTicks(837), "Kelli", "McDermott", null },
                    { new Guid("cf4d319a-fd1f-4f9e-af11-092cd69b31ab"), new DateTime(2023, 5, 26, 23, 25, 2, 609, DateTimeKind.Local).AddTicks(2736), "Joe", "Klocko", null },
                    { new Guid("d4482cc3-cc41-4014-9b72-dd535f308882"), new DateTime(2023, 5, 26, 23, 25, 2, 605, DateTimeKind.Local).AddTicks(6670), "Lamar", "Schroeder", null },
                    { new Guid("d9479b41-a2e2-4d26-aa63-fdc93a659ab1"), new DateTime(2023, 5, 26, 23, 25, 2, 605, DateTimeKind.Local).AddTicks(1717), "Suzanne", "Botsford", null },
                    { new Guid("df450115-04cd-48b2-a360-b298981135c7"), new DateTime(2023, 5, 26, 23, 25, 2, 607, DateTimeKind.Local).AddTicks(9244), "Shaun", "Price", null },
                    { new Guid("e81e2108-4d79-4e3f-b105-4bc286ef5a1e"), new DateTime(2023, 5, 26, 23, 25, 2, 604, DateTimeKind.Local).AddTicks(8011), "Virgil", "Crona", null },
                    { new Guid("ecccf595-4430-4569-bddd-59eb3ed1d07e"), new DateTime(2023, 5, 26, 23, 25, 2, 607, DateTimeKind.Local).AddTicks(7600), "Harriet", "Renner", null },
                    { new Guid("f238d74f-0c49-409d-b4a0-edec9c7311aa"), new DateTime(2023, 5, 26, 23, 25, 2, 608, DateTimeKind.Local).AddTicks(7194), "Sherman", "Lueilwitz", null },
                    { new Guid("f5b4538c-952e-4d7a-aaa6-d55df156f211"), new DateTime(2023, 5, 26, 23, 25, 2, 607, DateTimeKind.Local).AddTicks(6833), "Marcella", "Smith", null },
                    { new Guid("f62bd7ad-0315-447d-867a-9b79056b3172"), new DateTime(2023, 5, 26, 23, 25, 2, 610, DateTimeKind.Local).AddTicks(666), "Anthony", "Nader", null },
                    { new Guid("f83d797b-ee74-46e9-b7af-8d821faa9229"), new DateTime(2023, 5, 26, 23, 25, 2, 609, DateTimeKind.Local).AddTicks(1922), "Christine", "Osinski", null },
                    { new Guid("fc44d48e-119a-4cd2-86dd-3d14537917f8"), new DateTime(2023, 5, 26, 23, 25, 2, 606, DateTimeKind.Local).AddTicks(2359), "Carrie", "Von", null },
                    { new Guid("ff947f18-b883-4062-b4b5-8402df934d01"), new DateTime(2023, 5, 26, 23, 25, 2, 606, DateTimeKind.Local).AddTicks(7171), "Yvette", "Murphy", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedDateTime", "Title", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("003b12d7-d5e1-47fb-bcc2-19c8880448ef"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(8942), "HistoricalFiction", null },
                    { new Guid("0992565e-52a3-4143-b4c0-1fc29adb0825"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9247), "DetectiveAndMystery", null },
                    { new Guid("0ddd25d5-959f-4cef-abb7-7cea490a5f95"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9462), "LiteraryFiction", null },
                    { new Guid("104b63ec-1103-4b64-9665-f919e7139efc"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9287), "Classics", null },
                    { new Guid("131152c5-88c1-4e4c-8f13-3b8006018a0c"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9328), "HistoricalFiction", null },
                    { new Guid("1b57e35a-c0f5-4c8c-a8fd-3d735507291d"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9301), "Horror", null },
                    { new Guid("1e822901-32ea-4f2a-b051-ae23ddb1b8f2"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(8928), "Fantasy", null },
                    { new Guid("200d2f07-a903-4d2f-a48f-c91c5b94f417"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9421), "LiteraryFiction", null },
                    { new Guid("26f54e6c-b868-405b-bf06-35daf0a494ab"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9435), "Horror", null },
                    { new Guid("28f113e5-e9e0-4b57-b798-f227c0ac3987"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9053), "DetectiveAndMystery", null },
                    { new Guid("3751a36f-8c48-4d61-a033-1f2c60f70b89"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(8839), "LiteraryFiction", null },
                    { new Guid("405e3f64-5abc-4753-be5b-77c7a880fc60"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(8997), "Fantasy", null },
                    { new Guid("41065de1-75c8-4a9b-9231-3d48f9f7db4e"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9274), "HistoricalFiction", null },
                    { new Guid("4fa81b78-d716-41a3-a5d5-6d2a99bcbb71"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9357), "Classics", null },
                    { new Guid("6168a226-9a80-4862-a22e-8526d4cf7afe"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9218), "LiteraryFiction", null },
                    { new Guid("63766c80-b097-48d2-8612-cc6087f3df23"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9123), "ActionAndAdventure", null },
                    { new Guid("6d7f60f6-e4ba-41a1-869d-1cdb03ee4d41"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9178), "Fantasy", null },
                    { new Guid("710d83bf-82dc-4b89-9c53-4876a49a720c"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9150), "Horror", null },
                    { new Guid("715898e4-4eb7-4b3f-b22d-5e6750e38f8e"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9067), "ComicBookGraphicNovel", null },
                    { new Guid("7661ba0b-bdb9-4efd-a009-5f37aa5c8801"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9191), "DetectiveAndMystery", null },
                    { new Guid("781962bb-269f-4bc5-af85-3f1a9043a006"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9518), "Horror", null },
                    { new Guid("7b0b01ac-7206-4af7-9024-d9881ee0cd87"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9164), "ActionAndAdventure", null },
                    { new Guid("7caa2882-4f82-415b-b2a9-ca90cbdcf889"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(8969), "DetectiveAndMystery", null },
                    { new Guid("87b17700-5c38-4eda-acf5-8ead729cddf2"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(8309), "Classics", null },
                    { new Guid("90486ec3-28e3-45d7-8cb7-98824f23eb1c"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(8983), "HistoricalFiction", null },
                    { new Guid("94252978-44b4-4c0b-83bd-23ebc0a543c5"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(8901), "HistoricalFiction", null },
                    { new Guid("967e66b3-ed8d-4478-95a1-89606eaa9717"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9531), "HistoricalFiction", null },
                    { new Guid("98076a64-f35f-44d5-8433-6a882046f134"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9504), "HistoricalFiction", null },
                    { new Guid("99cc61e2-a465-4aa9-80d3-782088f99f86"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(8956), "LiteraryFiction", null },
                    { new Guid("9f58f57b-d9fd-4c8b-bfe5-1ec55ed3bcc9"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9261), "Horror", null },
                    { new Guid("9fae6a0d-b9ac-4692-b0c4-2f98108b66e4"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9080), "ActionAndAdventure", null },
                    { new Guid("a1b2557c-b811-4d4b-bd55-2eabb9b01f2a"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9491), "DetectiveAndMystery", null },
                    { new Guid("a7ab7720-fef8-4987-a56a-499a2d50e573"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9094), "LiteraryFiction", null },
                    { new Guid("b14c1a71-1add-4fe0-8cf7-fe470f21ba63"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9040), "ComicBookGraphicNovel", null },
                    { new Guid("b51fd10f-09a1-433d-b08f-e8488d322818"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9344), "HistoricalFiction", null },
                    { new Guid("bbfe1d7f-6fbd-46ae-9c0a-7b73927c84ce"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9315), "Fantasy", null },
                    { new Guid("bdfe3804-0dca-4cb6-a37c-ed5366769e22"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(8868), "LiteraryFiction", null },
                    { new Guid("c07024db-a9ba-40e4-8781-c619d72e8eef"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9233), "HistoricalFiction", null },
                    { new Guid("c1d330ad-819c-4622-9e8b-9c2098fddd75"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9108), "Fantasy", null },
                    { new Guid("c34aa2ee-f087-4ec0-a580-b101ac6b74c3"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9204), "ComicBookGraphicNovel", null },
                    { new Guid("cea3ec76-e9c0-456a-be54-2d416b0d44ec"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9448), "ActionAndAdventure", null },
                    { new Guid("dce233b7-8767-431b-aee1-42b050ff96c2"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9371), "Horror", null },
                    { new Guid("de0c159f-44ce-4555-89af-f398a15295ed"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9012), "Fantasy", null },
                    { new Guid("e8aedad4-b02e-4d80-bca1-1b0560848bce"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(8854), "HistoricalFiction", null },
                    { new Guid("ecf20367-1ed3-46b6-85e1-cc028f4d842a"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9137), "DetectiveAndMystery", null },
                    { new Guid("eda506b9-318f-4084-9ae2-897d84dec076"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(8915), "HistoricalFiction", null },
                    { new Guid("edd7e8bf-f3fd-4cfc-9652-38eb6f8f5b22"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9407), "HistoricalFiction", null },
                    { new Guid("f16d6878-d203-4fbd-ad28-003a33929f56"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(8819), "DetectiveAndMystery", null },
                    { new Guid("f3b47a28-589d-4bdf-9b4f-e978f991bb86"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9477), "Horror", null },
                    { new Guid("f90b083d-a4f6-4034-b84f-875b30d1413b"), new DateTime(2023, 5, 26, 23, 25, 2, 617, DateTimeKind.Local).AddTicks(9026), "ComicBookGraphicNovel", null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AgeRestriction", "AuthorsID", "Copies", "CreatedDateTime", "Description", "EditionType", "Price", "ReleaseDate", "Title", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("0044637e-26e9-4e4e-b34e-60785301839d"), 2, new Guid("570485de-66aa-4c14-af7b-d16b04c4482d"), 789, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1377), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, 176.30m, new DateTime(2023, 8, 17, 22, 55, 17, 430, DateTimeKind.Local).AddTicks(525), "Pizza", null },
                    { new Guid("009da4da-b590-4b46-8d38-e05f70e96be4"), 2, new Guid("f238d74f-0c49-409d-b4a0-edec9c7311aa"), 895, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4719), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, 769.59m, new DateTime(2023, 12, 3, 20, 28, 41, 982, DateTimeKind.Local).AddTicks(329), "Ball", null },
                    { new Guid("011f4a18-55bc-4dc1-b962-e1c736b5be95"), 2, new Guid("91f80af1-00b9-47ad-9780-a236d3e0f1a3"), 457, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9746), "The Football Is Good For Training And Recreational Purposes", 5, 145.38m, new DateTime(2023, 9, 23, 16, 27, 30, 233, DateTimeKind.Local).AddTicks(8570), "Shirt", null },
                    { new Guid("01614b9a-18a0-456e-b453-4cdaece6861c"), 2, new Guid("7de6f4ed-9e9c-4718-9839-b3e8de8428bf"), 144, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5140), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 5, 489.43m, new DateTime(2024, 3, 18, 5, 0, 7, 953, DateTimeKind.Local).AddTicks(9430), "Chair", null },
                    { new Guid("01db5738-41e5-4635-9ee0-f98f044358af"), 0, new Guid("b0bf864a-da5b-453d-a830-b189b93b6813"), 515, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3530), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 4, 769.31m, new DateTime(2024, 4, 6, 12, 19, 2, 901, DateTimeKind.Local).AddTicks(558), "Car", null },
                    { new Guid("03d8b1f0-0038-47f3-a93a-cd9e3a964668"), 1, new Guid("7de6f4ed-9e9c-4718-9839-b3e8de8428bf"), 816, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2558), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, 326.51m, new DateTime(2023, 11, 26, 2, 38, 27, 797, DateTimeKind.Local).AddTicks(8802), "Table", null },
                    { new Guid("04453134-eec1-4fe6-90b0-f3fe07b5a9c8"), 1, new Guid("ad7847c0-45a1-4b18-8744-80995c47683c"), 752, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7495), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, 468.53m, new DateTime(2023, 11, 9, 7, 46, 15, 641, DateTimeKind.Local).AddTicks(2131), "Shirt", null },
                    { new Guid("0518a7da-6714-42dd-82b2-3d0eb848027f"), 0, new Guid("ff947f18-b883-4062-b4b5-8402df934d01"), 421, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1240), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, 849.78m, new DateTime(2024, 1, 1, 3, 28, 1, 324, DateTimeKind.Local).AddTicks(1064), "Pizza", null },
                    { new Guid("0519d360-3d87-434c-8384-ece9971adb5f"), 0, new Guid("a59310cb-532c-4326-905c-7ddeb822dde3"), 71, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(151), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5, 847.98m, new DateTime(2023, 12, 2, 13, 48, 25, 626, DateTimeKind.Local).AddTicks(7799), "Shoes", null },
                    { new Guid("0574d830-83b0-4c52-8464-9141e785b32f"), 2, new Guid("f83d797b-ee74-46e9-b7af-8d821faa9229"), 851, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5007), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2, 504.91m, new DateTime(2023, 12, 16, 13, 4, 13, 104, DateTimeKind.Local).AddTicks(6416), "Gloves", null },
                    { new Guid("05d60c33-7e7c-4379-ad33-d93826c3e97a"), 0, new Guid("c64ce4c7-a794-420d-b9fa-812befcf9788"), 961, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9023), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, 95.01m, new DateTime(2024, 4, 30, 14, 5, 10, 205, DateTimeKind.Local).AddTicks(8722), "Gloves", null },
                    { new Guid("06799635-cfa4-4aa8-877a-51272a5641b5"), 0, new Guid("f62bd7ad-0315-447d-867a-9b79056b3172"), 257, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3823), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, 525.90m, new DateTime(2023, 9, 13, 5, 39, 36, 479, DateTimeKind.Local).AddTicks(6588), "Car", null },
                    { new Guid("083935c5-1177-478c-baf1-18beb096799a"), 0, new Guid("6723c5a7-dec1-4637-bacc-1cc50e07cf30"), 351, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7067), "The Football Is Good For Training And Recreational Purposes", 4, 609.59m, new DateTime(2023, 9, 24, 17, 3, 46, 142, DateTimeKind.Local).AddTicks(5922), "Shoes", null },
                    { new Guid("0a9f76b3-b4eb-4988-acb2-29a40734b90d"), 0, new Guid("cf4d319a-fd1f-4f9e-af11-092cd69b31ab"), 191, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1149), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, 382.73m, new DateTime(2023, 10, 14, 17, 15, 0, 861, DateTimeKind.Local).AddTicks(4668), "Cheese", null },
                    { new Guid("0ab2d3c2-df76-48ea-8c8c-b22c4f6b1676"), 2, new Guid("90532c0f-4a8e-41b8-a4df-1bba53edd1f1"), 312, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7663), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 6, 788.42m, new DateTime(2023, 9, 21, 13, 28, 33, 113, DateTimeKind.Local).AddTicks(115), "Shoes", null },
                    { new Guid("0d539f3c-3e32-4add-b7a5-90a85bd72be7"), 1, new Guid("a50e9cd6-e1b6-44cd-9dd2-50530ab00a37"), 283, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2311), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, 630.50m, new DateTime(2024, 4, 3, 0, 18, 22, 49, DateTimeKind.Local).AddTicks(9167), "Tuna", null },
                    { new Guid("0da710f0-522b-4b16-9644-b9164ba168d5"), 2, new Guid("a59310cb-532c-4326-905c-7ddeb822dde3"), 587, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(241), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 0, 375.41m, new DateTime(2024, 3, 31, 19, 42, 19, 947, DateTimeKind.Local).AddTicks(4452), "Fish", null },
                    { new Guid("0fc14c6a-646d-43f5-b00c-d87014ff70d9"), 0, new Guid("c64ce4c7-a794-420d-b9fa-812befcf9788"), 822, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8257), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, 829.25m, new DateTime(2024, 5, 26, 0, 24, 12, 957, DateTimeKind.Local).AddTicks(9068), "Hat", null },
                    { new Guid("1142d5a8-d638-4a0b-af78-b1287b1936da"), 0, new Guid("e81e2108-4d79-4e3f-b105-4bc286ef5a1e"), 47, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6295), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 5, 252.69m, new DateTime(2024, 2, 5, 12, 33, 42, 297, DateTimeKind.Local).AddTicks(3759), "Pants", null },
                    { new Guid("11e21c96-3c27-4531-88f5-2c3f95cf8e6c"), 0, new Guid("7c2c7cf7-138c-45a9-92f1-39c1cfd1a5e5"), 93, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7711), "The Football Is Good For Training And Recreational Purposes", 0, 332.36m, new DateTime(2024, 5, 7, 7, 3, 30, 228, DateTimeKind.Local).AddTicks(4548), "Shirt", null },
                    { new Guid("142fcf67-5229-43e7-af5d-5002516c963c"), 2, new Guid("9f165e0a-f59d-45f4-a9d2-bc7845d5e097"), 781, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(106), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4, 345.70m, new DateTime(2023, 10, 9, 14, 16, 46, 270, DateTimeKind.Local).AddTicks(1821), "Bike", null },
                    { new Guid("15446c87-008a-478d-99cb-f32a17c39218"), 0, new Guid("7ebae05a-e45e-4aa6-847d-f26e8330053c"), 669, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4070), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2, 888.57m, new DateTime(2024, 3, 6, 5, 58, 32, 384, DateTimeKind.Local).AddTicks(131), "Towels", null },
                    { new Guid("15b45918-780d-41d0-8be4-02875b9befa6"), 0, new Guid("ff947f18-b883-4062-b4b5-8402df934d01"), 235, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1690), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 3, 237.23m, new DateTime(2023, 11, 19, 17, 53, 32, 579, DateTimeKind.Local).AddTicks(8173), "Hat", null },
                    { new Guid("1729c8d7-0f1d-4ff8-9d6e-b563d4838bdb"), 1, new Guid("3ef679f4-7f15-466a-af52-d9497bb48f4a"), 658, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1196), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 6, 702.03m, new DateTime(2024, 3, 9, 10, 17, 7, 858, DateTimeKind.Local).AddTicks(6423), "Chair", null },
                    { new Guid("175071e2-c74e-4fc4-9b14-d8119e7d4c32"), 2, new Guid("81f674cf-da03-4593-881e-d4eb7fb2bec1"), 968, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(825), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, 152.48m, new DateTime(2024, 5, 7, 2, 9, 44, 728, DateTimeKind.Local).AddTicks(9839), "Chips", null },
                    { new Guid("1a835623-8895-4a8b-a61a-57f4fd756be4"), 2, new Guid("7973bf28-20a5-4d56-9101-3ababb74178f"), 60, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4476), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 5, 593.20m, new DateTime(2024, 1, 24, 9, 21, 35, 580, DateTimeKind.Local).AddTicks(8568), "Chicken", null },
                    { new Guid("1ab239d5-3d2e-4b7f-a143-660c6e232a72"), 0, new Guid("f238d74f-0c49-409d-b4a0-edec9c7311aa"), 895, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6008), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 4, 552.98m, new DateTime(2023, 12, 15, 19, 30, 5, 787, DateTimeKind.Local).AddTicks(3649), "Bacon", null },
                    { new Guid("1b84c89f-b02b-4cf7-a403-cd4bb1e31f6e"), 0, new Guid("a50e9cd6-e1b6-44cd-9dd2-50530ab00a37"), 425, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7356), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, 185.61m, new DateTime(2023, 12, 26, 10, 36, 17, 899, DateTimeKind.Local).AddTicks(3687), "Car", null },
                    { new Guid("1e0f0bd6-b52a-4780-97db-f5915279799d"), 1, new Guid("7ac18a11-b1d9-42b9-bb81-19a83aafd5bf"), 469, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8169), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, 677.09m, new DateTime(2023, 10, 21, 10, 19, 34, 441, DateTimeKind.Local).AddTicks(8373), "Cheese", null },
                    { new Guid("1f98c13e-10c7-4412-9ea7-ee04fdfd645d"), 0, new Guid("77f044e8-8a3c-4be7-b927-d894468b2693"), 623, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9204), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2, 472.85m, new DateTime(2023, 9, 10, 20, 25, 31, 741, DateTimeKind.Local).AddTicks(3691), "Cheese", null },
                    { new Guid("2015b0b3-7f9f-4dc1-90b5-f2b9added7ba"), 1, new Guid("9329bb4b-7626-4091-be5d-d46d5f7ed3d1"), 498, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4808), "The Football Is Good For Training And Recreational Purposes", 0, 467.84m, new DateTime(2023, 7, 15, 6, 0, 28, 116, DateTimeKind.Local).AddTicks(4350), "Bacon", null },
                    { new Guid("20d29621-f50c-4dbe-8840-65a8af4bbfda"), 2, new Guid("f62bd7ad-0315-447d-867a-9b79056b3172"), 454, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3576), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, 733.15m, new DateTime(2023, 10, 14, 7, 53, 2, 734, DateTimeKind.Local).AddTicks(1328), "Sausages", null },
                    { new Guid("217d5d21-c070-446f-9002-6f8a1aa48939"), 1, new Guid("0bf1d7b8-5519-4189-aa4e-b05d3f15e023"), 698, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8416), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0, 37.86m, new DateTime(2024, 5, 10, 0, 32, 52, 66, DateTimeKind.Local).AddTicks(3965), "Pants", null },
                    { new Guid("21907147-3215-48d8-99c8-4ae251c35749"), 0, new Guid("0bf1d7b8-5519-4189-aa4e-b05d3f15e023"), 543, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2024), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 0, 134.28m, new DateTime(2023, 9, 7, 0, 26, 14, 703, DateTimeKind.Local).AddTicks(9793), "Bike", null },
                    { new Guid("23f2ff19-3b2d-4907-8cad-6da99a71ff4f"), 2, new Guid("4cabe2e7-41a9-4d29-b3e5-fea41737b8bc"), 332, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(733), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5, 998.12m, new DateTime(2024, 1, 9, 0, 37, 48, 745, DateTimeKind.Local).AddTicks(3917), "Tuna", null },
                    { new Guid("26d5c0e6-5967-496c-ab7c-0eb092477c7a"), 1, new Guid("1a5cdc9a-87a4-4857-a0b9-6320e4bb416c"), 350, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6209), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0, 157.71m, new DateTime(2024, 3, 14, 11, 42, 30, 213, DateTimeKind.Local).AddTicks(5657), "Gloves", null },
                    { new Guid("2793fe5e-0723-46c7-8cad-ed151169e612"), 0, new Guid("03bd8fff-a187-4221-add8-8ef5a1f2a812"), 724, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(196), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 6, 225.54m, new DateTime(2024, 1, 23, 11, 35, 48, 847, DateTimeKind.Local).AddTicks(3680), "Computer", null },
                    { new Guid("28baa94f-074a-4dba-8173-d9561ac1e5f4"), 1, new Guid("91f80af1-00b9-47ad-9780-a236d3e0f1a3"), 632, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5630), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, 301.08m, new DateTime(2023, 9, 8, 15, 39, 38, 7, DateTimeKind.Local).AddTicks(3935), "Car", null },
                    { new Guid("295ca84a-95a6-44bb-8662-a5349296b333"), 0, new Guid("3ef679f4-7f15-466a-af52-d9497bb48f4a"), 81, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3736), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 3, 773.30m, new DateTime(2024, 3, 31, 12, 29, 10, 929, DateTimeKind.Local).AddTicks(6658), "Chair", null },
                    { new Guid("2adfbcde-46d0-49e3-9e34-df693fe036fa"), 0, new Guid("76d06899-cfb2-4a95-9718-12800f36d1e6"), 339, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1579), "The Football Is Good For Training And Recreational Purposes", 5, 372.20m, new DateTime(2023, 8, 5, 0, 27, 33, 671, DateTimeKind.Local).AddTicks(8038), "Pants", null },
                    { new Guid("2cca9a2d-01ca-4e3c-80d4-99541c62e330"), 0, new Guid("91f80af1-00b9-47ad-9780-a236d3e0f1a3"), 259, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2602), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 4, 944.94m, new DateTime(2023, 7, 28, 4, 21, 30, 377, DateTimeKind.Local).AddTicks(6158), "Fish", null },
                    { new Guid("2ea785fd-42b4-4787-9eb5-a6d050ed9a49"), 0, new Guid("7973bf28-20a5-4d56-9101-3ababb74178f"), 429, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5962), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 4, 403.36m, new DateTime(2024, 5, 5, 7, 33, 4, 175, DateTimeKind.Local).AddTicks(7276), "Chair", null },
                    { new Guid("30fff4ad-9a5f-4764-b67a-9f80813fd41e"), 0, new Guid("f238d74f-0c49-409d-b4a0-edec9c7311aa"), 346, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9409), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, 182.77m, new DateTime(2023, 10, 28, 13, 11, 45, 269, DateTimeKind.Local).AddTicks(9305), "Soap", null },
                    { new Guid("316f494d-9b64-4186-a0b5-df533e142a48"), 1, new Guid("e81e2108-4d79-4e3f-b105-4bc286ef5a1e"), 239, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(491), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, 53.67m, new DateTime(2024, 1, 18, 12, 7, 24, 254, DateTimeKind.Local).AddTicks(1174), "Tuna", null },
                    { new Guid("3212e312-08c2-4be2-b6cc-9101fe8b3cb6"), 0, new Guid("ca2e16c9-b1b5-448c-baf2-56dfa1595221"), 246, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9658), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 3, 282.09m, new DateTime(2023, 10, 18, 10, 6, 33, 276, DateTimeKind.Local).AddTicks(4141), "Pizza", null },
                    { new Guid("3330627d-493b-4d38-9680-462ad3956f30"), 0, new Guid("7ac18a11-b1d9-42b9-bb81-19a83aafd5bf"), 782, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9322), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, 85.11m, new DateTime(2024, 2, 5, 16, 33, 53, 677, DateTimeKind.Local).AddTicks(2784), "Chicken", null },
                    { new Guid("33b3433b-02b1-4c3b-89f6-890f9fe50e1b"), 1, new Guid("ad7847c0-45a1-4b18-8744-80995c47683c"), 348, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6165), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, 898.18m, new DateTime(2023, 11, 7, 23, 54, 45, 133, DateTimeKind.Local).AddTicks(7188), "Soap", null },
                    { new Guid("33d80ba0-a88f-4609-aac4-bafca56f204f"), 2, new Guid("6723c5a7-dec1-4637-bacc-1cc50e07cf30"), 918, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9948), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3, 605.77m, new DateTime(2024, 1, 26, 18, 10, 56, 798, DateTimeKind.Local).AddTicks(3865), "Mouse", null },
                    { new Guid("36631ae1-f552-4aae-a6a7-dc2e5b0b5567"), 0, new Guid("645311ea-aa9d-4cae-b93f-498ed2d1096f"), 662, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(937), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, 859.25m, new DateTime(2024, 4, 25, 15, 24, 47, 754, DateTimeKind.Local).AddTicks(2588), "Shirt", null },
                    { new Guid("3687def0-5ea3-4732-8d47-25606f90a726"), 1, new Guid("8cea83b8-56d0-4f1d-9853-fbbc83bc77c6"), 157, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(601), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, 895.09m, new DateTime(2024, 3, 21, 9, 29, 43, 47, DateTimeKind.Local).AddTicks(5049), "Table", null },
                    { new Guid("36baf1e0-8c72-4a34-adea-af42cffcc482"), 2, new Guid("ad7847c0-45a1-4b18-8744-80995c47683c"), 94, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(355), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, 367.83m, new DateTime(2024, 5, 9, 17, 31, 2, 850, DateTimeKind.Local).AddTicks(2281), "Pants", null },
                    { new Guid("37091e8e-b35e-45bb-8f95-6f52713ef8f7"), 1, new Guid("0986a770-5c7e-4174-ae7e-a51f766125ff"), 631, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5918), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 4, 143.41m, new DateTime(2023, 12, 23, 8, 13, 2, 618, DateTimeKind.Local).AddTicks(8995), "Fish", null },
                    { new Guid("375a5c60-a3cc-437d-bf08-bc63faf6022e"), 1, new Guid("6723c5a7-dec1-4637-bacc-1cc50e07cf30"), 378, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5875), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, 539.82m, new DateTime(2023, 9, 5, 3, 14, 1, 689, DateTimeKind.Local).AddTicks(4281), "Shoes", null },
                    { new Guid("383e638c-3616-435f-83f4-662c3b780709"), 2, new Guid("0c233fb2-4c9c-49f8-b0db-b24f41b8a6f8"), 463, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(982), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, 486.73m, new DateTime(2023, 7, 27, 2, 30, 54, 122, DateTimeKind.Local).AddTicks(6095), "Pizza", null },
                    { new Guid("3fcc7259-ebf1-4b22-a704-2c4d2b51e24e"), 1, new Guid("f5b4538c-952e-4d7a-aaa6-d55df156f211"), 251, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6789), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 5, 33.50m, new DateTime(2023, 12, 4, 7, 9, 22, 457, DateTimeKind.Local).AddTicks(580), "Chair", null },
                    { new Guid("41bc0619-8e68-406a-bd64-a1a07631a3a9"), 1, new Guid("11c7d492-c74e-4b89-a188-d81d276d668e"), 469, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1778), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 5, 287.19m, new DateTime(2023, 6, 1, 15, 45, 42, 205, DateTimeKind.Local).AddTicks(5535), "Hat", null },
                    { new Guid("42741e60-4845-4f31-b9b3-0708e394c1cf"), 2, new Guid("645311ea-aa9d-4cae-b93f-498ed2d1096f"), 200, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4188), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 6, 776.74m, new DateTime(2023, 10, 7, 8, 51, 47, 150, DateTimeKind.Local).AddTicks(6850), "Soap", null },
                    { new Guid("439432fe-8cbe-4a31-83e4-9c0c792aa189"), 0, new Guid("49c4c0c9-e91b-4cf5-90d2-fc3bbef3a9f6"), 722, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3096), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, 51.55m, new DateTime(2024, 1, 10, 13, 28, 34, 155, DateTimeKind.Local).AddTicks(9556), "Tuna", null },
                    { new Guid("452a937a-e28a-44a4-8aef-773d1e6601be"), 0, new Guid("cae3d1f4-0049-49e0-b439-c18397f390c9"), 389, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6743), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 4, 431.83m, new DateTime(2023, 10, 6, 1, 29, 10, 193, DateTimeKind.Local).AddTicks(4140), "Car", null },
                    { new Guid("45eeebe5-16a3-487b-99d3-34eb58fe2a0a"), 0, new Guid("7973bf28-20a5-4d56-9101-3ababb74178f"), 696, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9903), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, 317.74m, new DateTime(2024, 4, 17, 20, 9, 39, 542, DateTimeKind.Local).AddTicks(6660), "Chicken", null },
                    { new Guid("4944b8ea-ab81-4453-b49f-fb9ab505d04d"), 2, new Guid("92c55e3e-c44a-470b-9628-9ffa24236459"), 88, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(446), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, 443.81m, new DateTime(2024, 3, 16, 23, 5, 10, 26, DateTimeKind.Local).AddTicks(3018), "Chicken", null },
                    { new Guid("4aae659b-3aa3-49d3-9939-4b20ba96459e"), 2, new Guid("0c233fb2-4c9c-49f8-b0db-b24f41b8a6f8"), 863, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4319), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, 452.58m, new DateTime(2024, 5, 10, 16, 29, 21, 242, DateTimeKind.Local).AddTicks(2863), "Bike", null },
                    { new Guid("4afe959c-4523-4562-8e01-3afcf4384a45"), 1, new Guid("9329bb4b-7626-4091-be5d-d46d5f7ed3d1"), 286, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9993), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, 594.62m, new DateTime(2023, 8, 30, 23, 25, 48, 292, DateTimeKind.Local).AddTicks(440), "Mouse", null },
                    { new Guid("4d324351-8d0e-4bb9-a5bf-198b8e8e97ff"), 2, new Guid("6cc7736f-9d5f-49de-a246-b6824902e1ea"), 874, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6052), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, 68.70m, new DateTime(2023, 6, 1, 2, 13, 1, 478, DateTimeKind.Local).AddTicks(1811), "Pizza", null },
                    { new Guid("4ec7d2a3-01fb-446d-b14e-86cf6969f110"), 1, new Guid("39dd1203-928b-40ae-a55a-f3daa9f463ae"), 768, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5719), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, 579.27m, new DateTime(2023, 12, 23, 7, 12, 15, 876, DateTimeKind.Local).AddTicks(8230), "Chair", null },
                    { new Guid("4f09b4f7-b500-413c-940f-c43bd99b32be"), 2, new Guid("0c49b46e-dbbe-4ab8-a534-453dc978e05b"), 182, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1284), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 4, 756.16m, new DateTime(2024, 3, 2, 11, 15, 47, 904, DateTimeKind.Local).AddTicks(3161), "Pizza", null },
                    { new Guid("4f2c6d8c-2b09-4954-8cc0-04f87ac38668"), 1, new Guid("f83d797b-ee74-46e9-b7af-8d821faa9229"), 672, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2646), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, 352.67m, new DateTime(2023, 6, 30, 2, 26, 21, 839, DateTimeKind.Local).AddTicks(1442), "Table", null },
                    { new Guid("517c5bb1-8e43-49e7-8392-3a84bc4a0e6b"), 1, new Guid("2eda534d-2129-41c1-a75e-9ecabd9237c6"), 85, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8896), "The Football Is Good For Training And Recreational Purposes", 5, 385.32m, new DateTime(2023, 10, 22, 12, 47, 24, 806, DateTimeKind.Local).AddTicks(3957), "Chips", null },
                    { new Guid("52a7d9c9-a148-4f80-afe4-4e7e00dbd32f"), 0, new Guid("d4482cc3-cc41-4014-9b72-dd535f308882"), 713, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7118), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 5, 107.26m, new DateTime(2023, 11, 7, 21, 9, 3, 562, DateTimeKind.Local).AddTicks(6173), "Gloves", null },
                    { new Guid("532a6028-187e-4da3-a833-c904fc0e880b"), 2, new Guid("cae3d1f4-0049-49e0-b439-c18397f390c9"), 366, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4765), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, 697.00m, new DateTime(2023, 11, 3, 11, 31, 56, 481, DateTimeKind.Local).AddTicks(6655), "Ball", null },
                    { new Guid("536df0b7-9778-4b63-8e0b-9cdf99566abc"), 2, new Guid("69d0cb4b-4544-42c8-8c5f-1ad4d96e8a23"), 338, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7916), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 4, 825.26m, new DateTime(2024, 3, 15, 0, 6, 19, 980, DateTimeKind.Local).AddTicks(2794), "Keyboard", null },
                    { new Guid("556abbb8-b3c5-49c7-8972-c45c86114d40"), 0, new Guid("f62bd7ad-0315-447d-867a-9b79056b3172"), 86, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8214), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4, 626.96m, new DateTime(2024, 4, 1, 8, 59, 40, 886, DateTimeKind.Local).AddTicks(7007), "Car", null },
                    { new Guid("559f004f-7d59-4efc-a120-425bd3531d67"), 0, new Guid("7c2c7cf7-138c-45a9-92f1-39c1cfd1a5e5"), 265, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2222), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, 648.66m, new DateTime(2023, 9, 24, 3, 57, 6, 765, DateTimeKind.Local).AddTicks(7380), "Soap", null },
                    { new Guid("56adaa5d-6041-4359-91f8-b1c69295629b"), 1, new Guid("f238d74f-0c49-409d-b4a0-edec9c7311aa"), 418, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9113), "The Football Is Good For Training And Recreational Purposes", 6, 179.80m, new DateTime(2023, 11, 26, 9, 52, 9, 331, DateTimeKind.Local).AddTicks(8296), "Tuna", null },
                    { new Guid("573e37dc-ac9b-43ad-8fdd-64c650cb6135"), 1, new Guid("f83d797b-ee74-46e9-b7af-8d821faa9229"), 752, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2356), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, 705.34m, new DateTime(2023, 12, 4, 9, 37, 15, 345, DateTimeKind.Local).AddTicks(1747), "Bacon", null },
                    { new Guid("57ab244e-5f9e-4d45-974e-58866a9beb12"), 0, new Guid("76243127-6c70-4fa8-81a6-a01a27ff8f9b"), 217, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5339), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, 253.18m, new DateTime(2024, 1, 31, 10, 59, 32, 628, DateTimeKind.Local).AddTicks(9555), "Cheese", null },
                    { new Guid("5b9a87c2-3120-4961-9f65-f82d357b161c"), 0, new Guid("7973bf28-20a5-4d56-9101-3ababb74178f"), 971, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8006), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, 729.51m, new DateTime(2023, 7, 12, 8, 36, 23, 631, DateTimeKind.Local).AddTicks(4920), "Bike", null },
                    { new Guid("5d870074-48ca-4ec2-8c4e-4785cca4071a"), 0, new Guid("6c0f492f-81f0-4187-bfba-6fb4e159a67b"), 247, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9157), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4, 479.27m, new DateTime(2023, 6, 26, 10, 22, 46, 563, DateTimeKind.Local).AddTicks(230), "Tuna", null },
                    { new Guid("5fbe6f53-9fc0-4af8-a6c4-2cf14fd132ce"), 0, new Guid("03bd8fff-a187-4221-add8-8ef5a1f2a812"), 932, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4026), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, 597.78m, new DateTime(2024, 2, 4, 21, 28, 40, 20, DateTimeKind.Local).AddTicks(4803), "Keyboard", null },
                    { new Guid("6010ad4b-6bb3-4aab-9691-a492b10a2055"), 1, new Guid("00928cb2-85df-4ef6-936c-b472b08a5b25"), 939, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5675), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 0, 31.64m, new DateTime(2024, 3, 20, 1, 45, 25, 166, DateTimeKind.Local).AddTicks(5064), "Shoes", null },
                    { new Guid("6051f9f7-1010-403e-85b0-18d71b913b69"), 0, new Guid("b0bf864a-da5b-453d-a830-b189b93b6813"), 180, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2803), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, 756.66m, new DateTime(2024, 5, 2, 13, 30, 30, 661, DateTimeKind.Local).AddTicks(2751), "Salad", null },
                    { new Guid("609d74a5-10e0-4bc3-ac07-640755ef2d1c"), 1, new Guid("569d2cee-4715-4a2c-8cb0-e99f8596180c"), 671, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3980), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, 379.35m, new DateTime(2024, 4, 4, 18, 56, 43, 373, DateTimeKind.Local).AddTicks(8853), "Computer", null },
                    { new Guid("6104f605-63bd-4f9a-b4e4-b800b2f7c29a"), 0, new Guid("0bf1d7b8-5519-4189-aa4e-b05d3f15e023"), 547, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8346), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, 444.79m, new DateTime(2023, 12, 19, 22, 25, 41, 477, DateTimeKind.Local).AddTicks(9956), "Sausages", null },
                    { new Guid("61132708-e2f1-4ee4-b682-80d61bdcd490"), 1, new Guid("77f044e8-8a3c-4be7-b927-d894468b2693"), 561, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3025), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, 979.49m, new DateTime(2023, 10, 28, 14, 46, 21, 260, DateTimeKind.Local).AddTicks(1818), "Pizza", null },
                    { new Guid("61e061f1-2611-444c-926b-8216adab1559"), 2, new Guid("f62bd7ad-0315-447d-867a-9b79056b3172"), 988, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8979), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 0, 523.34m, new DateTime(2023, 9, 3, 5, 46, 40, 609, DateTimeKind.Local).AddTicks(6102), "Gloves", null },
                    { new Guid("62ec4e58-7a4e-4a42-be69-2e9a20df3207"), 0, new Guid("11c7d492-c74e-4b89-a188-d81d276d668e"), 13, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3443), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 4, 981.64m, new DateTime(2023, 11, 10, 5, 59, 26, 362, DateTimeKind.Local).AddTicks(8387), "Ball", null },
                    { new Guid("636687d2-52f1-459f-b801-88bf2f6a1baa"), 0, new Guid("d9479b41-a2e2-4d26-aa63-fdc93a659ab1"), 449, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9815), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, 367.39m, new DateTime(2024, 5, 26, 22, 17, 11, 929, DateTimeKind.Local).AddTicks(9375), "Chicken", null },
                    { new Guid("65e1076b-63d9-4db4-8e4e-bb5870f71585"), 0, new Guid("a59310cb-532c-4326-905c-7ddeb822dde3"), 19, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(645), "The Football Is Good For Training And Recreational Purposes", 1, 710.91m, new DateTime(2023, 11, 24, 23, 51, 45, 813, DateTimeKind.Local).AddTicks(3115), "Chair", null },
                    { new Guid("66dcc28c-0bf6-4ff1-a9f3-e7a0170e309b"), 0, new Guid("7ebae05a-e45e-4aa6-847d-f26e8330053c"), 462, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4433), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, 746.15m, new DateTime(2024, 5, 22, 22, 44, 18, 153, DateTimeKind.Local).AddTicks(5442), "Gloves", null },
                    { new Guid("672db99c-f5e1-4b30-8705-5b9186ab208f"), 0, new Guid("d9479b41-a2e2-4d26-aa63-fdc93a659ab1"), 101, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9702), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, 641.80m, new DateTime(2023, 6, 19, 11, 45, 48, 968, DateTimeKind.Local).AddTicks(2261), "Soap", null },
                    { new Guid("67db66b0-7bdf-4d3b-9ecc-558bd7a75b76"), 0, new Guid("7ebae05a-e45e-4aa6-847d-f26e8330053c"), 975, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2892), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 4, 695.79m, new DateTime(2024, 2, 22, 13, 14, 58, 893, DateTimeKind.Local).AddTicks(2035), "Bike", null },
                    { new Guid("6849d389-ee10-4b7f-a082-fe262b01a2c4"), 2, new Guid("859dc25b-d52f-4fae-9db5-1e2018d8f139"), 400, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(689), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, 876.91m, new DateTime(2023, 9, 9, 3, 11, 2, 764, DateTimeKind.Local).AddTicks(4843), "Bacon", null },
                    { new Guid("69b6e0b4-278d-4e41-bc4c-0dde5646526d"), 2, new Guid("ca2e16c9-b1b5-448c-baf2-56dfa1595221"), 722, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5583), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, 601.96m, new DateTime(2023, 8, 8, 9, 9, 59, 815, DateTimeKind.Local).AddTicks(1467), "Table", null },
                    { new Guid("6a8c7a70-3e05-42a1-89c9-1939ad9232fd"), 1, new Guid("d4482cc3-cc41-4014-9b72-dd535f308882"), 742, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2112), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 0, 836.60m, new DateTime(2024, 1, 24, 10, 48, 21, 898, DateTimeKind.Local).AddTicks(2809), "Keyboard", null },
                    { new Guid("6d05a557-b17f-4f95-8f4f-b3d9e9285de0"), 1, new Guid("596ce2c7-1adf-41f4-88fc-a3a42d04c9a3"), 878, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8709), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, 874.63m, new DateTime(2023, 6, 27, 7, 3, 33, 692, DateTimeKind.Local).AddTicks(1414), "Cheese", null },
                    { new Guid("6ed9e6ff-a131-45ab-a916-cdb706de0c02"), 1, new Guid("0bf1d7b8-5519-4189-aa4e-b05d3f15e023"), 636, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5251), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, 262.56m, new DateTime(2024, 5, 17, 2, 26, 49, 875, DateTimeKind.Local).AddTicks(7990), "Table", null },
                    { new Guid("6f3251bb-8b33-47ca-b0dd-6de2af9f18e0"), 2, new Guid("ca2e16c9-b1b5-448c-baf2-56dfa1595221"), 687, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4114), "The Football Is Good For Training And Recreational Purposes", 6, 713.05m, new DateTime(2023, 7, 30, 1, 35, 4, 249, DateTimeKind.Local).AddTicks(1800), "Mouse", null },
                    { new Guid("6f6aa030-a68e-4815-9817-612c9995776a"), 1, new Guid("0e779553-638b-4c1c-b603-d345a2bcb7ee"), 508, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7402), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 4, 962.71m, new DateTime(2024, 2, 26, 2, 39, 39, 839, DateTimeKind.Local).AddTicks(9148), "Towels", null },
                    { new Guid("7075efdf-40f4-425b-979f-8a604a9feaed"), 0, new Guid("69d0cb4b-4544-42c8-8c5f-1ad4d96e8a23"), 59, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5051), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, 933.96m, new DateTime(2024, 2, 10, 17, 52, 53, 772, DateTimeKind.Local).AddTicks(8098), "Salad", null },
                    { new Guid("708967e1-29d4-48a9-84f8-29b7abbe494a"), 1, new Guid("91f80af1-00b9-47ad-9780-a236d3e0f1a3"), 823, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5383), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, 469.51m, new DateTime(2023, 7, 30, 19, 12, 28, 337, DateTimeKind.Local).AddTicks(7239), "Gloves", null },
                    { new Guid("7451dc9f-6dc9-4659-9d1f-bb1527115246"), 2, new Guid("d9479b41-a2e2-4d26-aa63-fdc93a659ab1"), 677, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2266), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, 281.42m, new DateTime(2024, 5, 25, 20, 34, 55, 21, DateTimeKind.Local).AddTicks(9605), "Table", null },
                    { new Guid("783693df-fd34-4dff-8dfe-a121e8403399"), 0, new Guid("6c0f492f-81f0-4187-bfba-6fb4e159a67b"), 773, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1911), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 6, 730.50m, new DateTime(2023, 7, 17, 18, 23, 19, 836, DateTimeKind.Local).AddTicks(5906), "Soap", null },
                    { new Guid("788f64e4-4109-404d-bbc7-a0a8e2064d8c"), 0, new Guid("1a5cdc9a-87a4-4857-a0b9-6320e4bb416c"), 218, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1734), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, 893.22m, new DateTime(2023, 8, 25, 2, 44, 46, 620, DateTimeKind.Local).AddTicks(7609), "Towels", null },
                    { new Guid("79a2ad9e-d453-4093-8152-6d95d59f33d6"), 2, new Guid("0ae56f23-dbc4-4328-bd37-7f1d368e13d5"), 478, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7617), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2, 655.39m, new DateTime(2024, 3, 17, 14, 28, 19, 420, DateTimeKind.Local).AddTicks(8679), "Computer", null },
                    { new Guid("7a9e0b9a-bd15-4fd5-93a3-89f8121c5546"), 0, new Guid("859dc25b-d52f-4fae-9db5-1e2018d8f139"), 428, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3890), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, 611.55m, new DateTime(2024, 4, 20, 4, 13, 22, 522, DateTimeKind.Local).AddTicks(7340), "Soap", null },
                    { new Guid("7c372056-e40e-4e17-8ada-5686e0018a23"), 2, new Guid("92c55e3e-c44a-470b-9628-9ffa24236459"), 162, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6539), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, 987.13m, new DateTime(2023, 7, 7, 3, 42, 52, 637, DateTimeKind.Local).AddTicks(8849), "Shoes", null },
                    { new Guid("7c8bc50b-d71e-4e3c-9686-3c6468b7cb83"), 0, new Guid("92c55e3e-c44a-470b-9628-9ffa24236459"), 38, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3934), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, 348.02m, new DateTime(2023, 10, 5, 13, 52, 21, 667, DateTimeKind.Local).AddTicks(8395), "Mouse", null },
                    { new Guid("8156c3a6-9608-4586-a495-4cbfd1927724"), 2, new Guid("49eb8cea-5f30-448c-a7b7-2ac55e2b9ab2"), 54, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3141), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 6, 950.94m, new DateTime(2024, 3, 6, 2, 3, 40, 514, DateTimeKind.Local).AddTicks(767), "Table", null },
                    { new Guid("83a6b74d-3783-4287-a039-46358d8bbd51"), 2, new Guid("0cde1a77-cd18-4050-8ac4-d6876130d0bb"), 771, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7303), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, 131.71m, new DateTime(2023, 8, 11, 4, 9, 33, 100, DateTimeKind.Local).AddTicks(6534), "Hat", null },
                    { new Guid("8460aa96-7a0b-41a9-863d-8d9caf2e49a3"), 0, new Guid("b0bf864a-da5b-453d-a830-b189b93b6813"), 361, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9278), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, 202.62m, new DateTime(2024, 5, 22, 9, 24, 9, 341, DateTimeKind.Local).AddTicks(8786), "Chair", null },
                    { new Guid("84d93dfe-1905-447f-847a-784c6efc6eb9"), 2, new Guid("7973bf28-20a5-4d56-9101-3ababb74178f"), 542, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3276), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, 905.08m, new DateTime(2023, 7, 30, 22, 43, 59, 409, DateTimeKind.Local).AddTicks(4488), "Tuna", null },
                    { new Guid("859e29bb-7de6-4d93-85ca-cbd25d0f72a4"), 2, new Guid("91f80af1-00b9-47ad-9780-a236d3e0f1a3"), 414, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1026), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 5, 28.38m, new DateTime(2023, 8, 28, 6, 26, 21, 546, DateTimeKind.Local).AddTicks(7934), "Keyboard", null },
                    { new Guid("8854b0cf-8d22-4441-b87e-bf4f36819c7c"), 1, new Guid("0986a770-5c7e-4174-ae7e-a51f766125ff"), 533, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9523), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 3, 231.63m, new DateTime(2024, 1, 28, 16, 40, 21, 807, DateTimeKind.Local).AddTicks(8105), "Chair", null },
                    { new Guid("88ed3235-e7aa-43b2-aead-117eec18ecab"), 0, new Guid("fc44d48e-119a-4cd2-86dd-3d14537917f8"), 205, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9067), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, 634.15m, new DateTime(2023, 6, 17, 7, 26, 7, 733, DateTimeKind.Local).AddTicks(6064), "Soap", null },
                    { new Guid("88fb2d99-200d-4f18-8059-a5ce48d64ab0"), 1, new Guid("9f165e0a-f59d-45f4-a9d2-bc7845d5e097"), 892, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4232), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4, 104.08m, new DateTime(2024, 4, 5, 12, 3, 8, 423, DateTimeKind.Local).AddTicks(178), "Bacon", null },
                    { new Guid("8ab7b769-eaf7-44ee-a98c-4ebc436866bf"), 1, new Guid("0bf1d7b8-5519-4189-aa4e-b05d3f15e023"), 372, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7231), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, 529.46m, new DateTime(2023, 10, 27, 3, 47, 40, 887, DateTimeKind.Local).AddTicks(8485), "Bike", null },
                    { new Guid("8ad38a97-b1b5-4bb6-893d-c61c4588300e"), 2, new Guid("df450115-04cd-48b2-a360-b298981135c7"), 441, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4275), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, 98.04m, new DateTime(2023, 10, 28, 12, 45, 12, 490, DateTimeKind.Local).AddTicks(3439), "Sausages", null },
                    { new Guid("8cd80fb8-9795-48e1-a253-4be9d4e0c1ae"), 2, new Guid("6c0f492f-81f0-4187-bfba-6fb4e159a67b"), 299, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1533), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, 723.56m, new DateTime(2023, 7, 19, 23, 14, 18, 727, DateTimeKind.Local).AddTicks(1129), "Salad", null },
                    { new Guid("8ed8ad62-d6aa-4ddc-8a9c-4aa9e29eeaca"), 0, new Guid("69d0cb4b-4544-42c8-8c5f-1ad4d96e8a23"), 29, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7016), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, 887.90m, new DateTime(2024, 2, 12, 13, 33, 46, 654, DateTimeKind.Local).AddTicks(705), "Soap", null },
                    { new Guid("926fb879-b51f-4b30-a01d-bbba4abd1d31"), 2, new Guid("7563f48f-fe9f-4f5f-b9e3-db3401605773"), 473, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6252), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, 528.98m, new DateTime(2024, 3, 20, 20, 50, 38, 264, DateTimeKind.Local).AddTicks(7189), "Chips", null },
                    { new Guid("936b5fa3-d1cf-4129-ad8d-ae92ef6b3269"), 2, new Guid("4f6b6b17-2277-4dbe-b377-873878974d05"), 886, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8852), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 0, 960.50m, new DateTime(2023, 9, 26, 18, 46, 14, 326, DateTimeKind.Local).AddTicks(1211), "Cheese", null },
                    { new Guid("93a5872d-b9ff-40cf-8d8a-25942a19c57d"), 2, new Guid("b0bf864a-da5b-453d-a830-b189b93b6813"), 766, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7184), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, 776.36m, new DateTime(2024, 2, 21, 2, 32, 3, 689, DateTimeKind.Local).AddTicks(7701), "Cheese", null },
                    { new Guid("949d80f2-f062-4a7a-9261-d3e84cef91d7"), 2, new Guid("6cc7736f-9d5f-49de-a246-b6824902e1ea"), 584, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8301), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, 584.22m, new DateTime(2024, 2, 13, 4, 1, 33, 788, DateTimeKind.Local).AddTicks(737), "Soap", null },
                    { new Guid("95badf0f-31dc-4b7c-afe5-549b7108f307"), 0, new Guid("7ac18a11-b1d9-42b9-bb81-19a83aafd5bf"), 736, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4652), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, 241.63m, new DateTime(2024, 2, 10, 7, 29, 58, 103, DateTimeKind.Local).AddTicks(9824), "Pants", null },
                    { new Guid("968f1c8b-4f28-456b-be3e-5466c935a9cf"), 2, new Guid("295d4de8-6461-404e-b30e-63a5e924b0eb"), 618, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4563), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0, 301.42m, new DateTime(2023, 12, 6, 21, 27, 58, 62, DateTimeKind.Local).AddTicks(2636), "Hat", null },
                    { new Guid("97ba17b3-a61f-4ce2-a72e-dffbc4d28e66"), 1, new Guid("df450115-04cd-48b2-a360-b298981135c7"), 370, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6699), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, 347.21m, new DateTime(2023, 9, 2, 20, 47, 33, 898, DateTimeKind.Local).AddTicks(1425), "Soap", null },
                    { new Guid("99675fff-d707-4133-9e3a-d33a7e50709a"), 1, new Guid("0c233fb2-4c9c-49f8-b0db-b24f41b8a6f8"), 926, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7871), "The Football Is Good For Training And Recreational Purposes", 4, 938.26m, new DateTime(2024, 4, 24, 10, 45, 5, 556, DateTimeKind.Local).AddTicks(3351), "Fish", null },
                    { new Guid("99c296b0-f772-41bf-a684-16f265f27bb0"), 0, new Guid("0cde1a77-cd18-4050-8ac4-d6876130d0bb"), 146, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6408), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 6, 530.62m, new DateTime(2024, 2, 24, 2, 44, 23, 130, DateTimeKind.Local).AddTicks(7983), "Towels", null },
                    { new Guid("99e5d360-6fb3-4988-b5fa-4615170c1889"), 2, new Guid("0e779553-638b-4c1c-b603-d345a2bcb7ee"), 554, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3779), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 6, 666.81m, new DateTime(2023, 10, 31, 10, 12, 0, 180, DateTimeKind.Local).AddTicks(6662), "Bike", null },
                    { new Guid("9af750f8-55bf-4050-9eb3-d0f8142eb01b"), 1, new Guid("b4ea8a85-9f35-4da0-881c-ce5d4a503997"), 95, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9614), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, 77.32m, new DateTime(2023, 11, 10, 22, 44, 9, 560, DateTimeKind.Local).AddTicks(9773), "Shirt", null },
                    { new Guid("9bda237b-730d-47c1-8662-bdcb20fa8c63"), 1, new Guid("76243127-6c70-4fa8-81a6-a01a27ff8f9b"), 123, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5763), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, 688.46m, new DateTime(2023, 10, 28, 19, 45, 29, 531, DateTimeKind.Local).AddTicks(6710), "Tuna", null },
                    { new Guid("9c33c950-85a0-4a5f-92d9-46ee96bd062e"), 2, new Guid("9f165e0a-f59d-45f4-a9d2-bc7845d5e097"), 134, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(893), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, 75.77m, new DateTime(2023, 11, 4, 19, 45, 38, 419, DateTimeKind.Local).AddTicks(7621), "Fish", null },
                    { new Guid("9cda9c7b-f223-4fdf-af20-c18f8e63fc76"), 0, new Guid("49c4c0c9-e91b-4cf5-90d2-fc3bbef3a9f6"), 561, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3486), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, 886.71m, new DateTime(2023, 9, 6, 5, 52, 27, 94, DateTimeKind.Local).AddTicks(8954), "Chips", null },
                    { new Guid("9fa74d77-df93-492a-9414-ce1ce84520f1"), 0, new Guid("b0bf864a-da5b-453d-a830-b189b93b6813"), 531, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4897), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, 250.21m, new DateTime(2023, 7, 12, 18, 22, 13, 164, DateTimeKind.Local).AddTicks(1420), "Pants", null },
                    { new Guid("a2d6fc51-22d8-4c16-b83c-a26737c9f3a7"), 0, new Guid("90532c0f-4a8e-41b8-a4df-1bba53edd1f1"), 919, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6495), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, 626.77m, new DateTime(2023, 10, 18, 21, 1, 43, 89, DateTimeKind.Local).AddTicks(2560), "Pants", null },
                    { new Guid("a3c70461-f27e-4d11-806b-c98b62f8b651"), 1, new Guid("9329bb4b-7626-4091-be5d-d46d5f7ed3d1"), 268, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1623), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, 585.29m, new DateTime(2024, 2, 21, 8, 5, 11, 101, DateTimeKind.Local).AddTicks(8993), "Bike", null },
                    { new Guid("a3de4e85-8fc4-42cb-96b6-0965f7449e10"), 1, new Guid("570485de-66aa-4c14-af7b-d16b04c4482d"), 767, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8507), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 6, 154.54m, new DateTime(2023, 11, 26, 14, 20, 55, 377, DateTimeKind.Local).AddTicks(4606), "Pants", null },
                    { new Guid("a6a15b9c-f439-4d18-a8cb-b71c7274eab4"), 0, new Guid("92c55e3e-c44a-470b-9628-9ffa24236459"), 463, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6583), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, 344.40m, new DateTime(2023, 9, 12, 14, 37, 50, 784, DateTimeKind.Local).AddTicks(5878), "Fish", null },
                    { new Guid("a9269dfb-9f3e-49c7-a71f-d3fbe00184a9"), 2, new Guid("ae0c04c3-436b-4a34-a9e9-e5f90f6a4874"), 646, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6878), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, 776.17m, new DateTime(2024, 4, 20, 3, 17, 38, 287, DateTimeKind.Local).AddTicks(1223), "Mouse", null },
                    { new Guid("ab4036bb-3704-4550-ab80-f8070e25d4a9"), 2, new Guid("7ebae05a-e45e-4aa6-847d-f26e8330053c"), 849, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2847), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 5, 465.65m, new DateTime(2023, 11, 18, 10, 58, 13, 891, DateTimeKind.Local).AddTicks(3994), "Bacon", null },
                    { new Guid("b06e7e58-9d6e-4ef2-a9bf-bab18df7789b"), 2, new Guid("ae0c04c3-436b-4a34-a9e9-e5f90f6a4874"), 839, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7448), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, 262.40m, new DateTime(2023, 12, 12, 18, 15, 45, 964, DateTimeKind.Local).AddTicks(9839), "Chicken", null },
                    { new Guid("b0f77dd2-f473-4d7b-b0db-d45ab8f8e8f5"), 1, new Guid("d4482cc3-cc41-4014-9b72-dd535f308882"), 182, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3647), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, 439.27m, new DateTime(2024, 2, 15, 4, 17, 35, 624, DateTimeKind.Local).AddTicks(5635), "Sausages", null },
                    { new Guid("b29cd53d-ff7c-40c6-91ee-bffe979ce2ca"), 0, new Guid("7563f48f-fe9f-4f5f-b9e3-db3401605773"), 468, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6834), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, 393.98m, new DateTime(2024, 5, 22, 10, 32, 5, 74, DateTimeKind.Local).AddTicks(262), "Gloves", null },
                    { new Guid("b315b941-de1e-4152-bbc7-3376e4063b1c"), 1, new Guid("3ef679f4-7f15-466a-af52-d9497bb48f4a"), 879, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(5967), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 4, 616.67m, new DateTime(2023, 9, 16, 11, 12, 19, 9, DateTimeKind.Local).AddTicks(6683), "Bike", null },
                    { new Guid("b446db28-d830-4cbc-abd1-8bc31334ee67"), 1, new Guid("49c4c0c9-e91b-4cf5-90d2-fc3bbef3a9f6"), 208, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8802), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 4, 612.24m, new DateTime(2024, 2, 23, 9, 49, 5, 370, DateTimeKind.Local).AddTicks(8600), "Table", null },
                    { new Guid("b85c8d06-4c6d-4e7d-a96a-42ebc1a45b82"), 0, new Guid("1a5cdc9a-87a4-4857-a0b9-6320e4bb416c"), 592, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7960), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 5, 168.91m, new DateTime(2023, 11, 9, 21, 43, 3, 987, DateTimeKind.Local).AddTicks(4118), "Cheese", null },
                    { new Guid("b9da60d2-579e-4d3a-a1a8-f02524bd8c5d"), 2, new Guid("ecccf595-4430-4569-bddd-59eb3ed1d07e"), 929, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2980), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 0, 614.78m, new DateTime(2023, 7, 19, 14, 41, 23, 649, DateTimeKind.Local).AddTicks(4674), "Shirt", null },
                    { new Guid("ba0fc35c-80ce-4f6c-b6ac-1a3f6257d8fb"), 0, new Guid("90532c0f-4a8e-41b8-a4df-1bba53edd1f1"), 189, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2936), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, 885.39m, new DateTime(2024, 3, 10, 23, 43, 21, 946, DateTimeKind.Local).AddTicks(3297), "Hat", null },
                    { new Guid("bb105a75-0a86-4a27-bffa-d638d03db31b"), 1, new Guid("76243127-6c70-4fa8-81a6-a01a27ff8f9b"), 20, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7541), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0, 485.44m, new DateTime(2023, 10, 31, 17, 55, 14, 172, DateTimeKind.Local).AddTicks(4744), "Shirt", null },
                    { new Guid("bb50fc31-f241-4dd5-af5e-b607daa39ab7"), 1, new Guid("a59310cb-532c-4326-905c-7ddeb822dde3"), 842, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6452), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0, 682.47m, new DateTime(2023, 7, 11, 17, 8, 27, 422, DateTimeKind.Local).AddTicks(3785), "Tuna", null },
                    { new Guid("bc65d441-51f9-422b-8647-c85fa3229336"), 0, new Guid("cae3d1f4-0049-49e0-b439-c18397f390c9"), 451, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9366), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, 231.78m, new DateTime(2024, 5, 21, 17, 32, 34, 427, DateTimeKind.Local).AddTicks(3200), "Shirt", null },
                    { new Guid("bf96be20-f03b-4cc0-b4e1-35d7dfc23fed"), 2, new Guid("8cea83b8-56d0-4f1d-9853-fbbc83bc77c6"), 978, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(61), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, 163.81m, new DateTime(2023, 9, 11, 12, 9, 28, 753, DateTimeKind.Local).AddTicks(9447), "Computer", null },
                    { new Guid("c0b870eb-e3df-4b23-a515-5edcb0c6ac7a"), 0, new Guid("0e779553-638b-4c1c-b603-d345a2bcb7ee"), 627, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8640), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, 460.51m, new DateTime(2024, 5, 23, 8, 3, 41, 964, DateTimeKind.Local).AddTicks(9254), "Shirt", null },
                    { new Guid("c1e28769-86bd-485c-98bd-9663b30cc7ab"), 2, new Guid("fc44d48e-119a-4cd2-86dd-3d14537917f8"), 285, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2156), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, 758.05m, new DateTime(2023, 7, 5, 15, 49, 0, 283, DateTimeKind.Local).AddTicks(7605), "Hat", null },
                    { new Guid("c282b1bf-fd37-44f5-a5a9-fbb52e770f58"), 0, new Guid("04f85738-2b5e-49c0-99d3-75fb56d43b65"), 644, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(6946), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 4, 600.17m, new DateTime(2024, 1, 30, 20, 45, 37, 862, DateTimeKind.Local).AddTicks(3101), "Cheese", null },
                    { new Guid("c3af7d7b-ac0f-494b-b6c2-4b065c335f95"), 2, new Guid("81f674cf-da03-4593-881e-d4eb7fb2bec1"), 38, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2514), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 0, 109.48m, new DateTime(2024, 4, 9, 9, 28, 52, 246, DateTimeKind.Local).AddTicks(7710), "Chair", null },
                    { new Guid("c49884f9-519f-4cae-b6d4-f3d69917d30d"), 0, new Guid("859dc25b-d52f-4fae-9db5-1e2018d8f139"), 423, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3399), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 0, 502.97m, new DateTime(2024, 3, 17, 22, 54, 36, 226, DateTimeKind.Local).AddTicks(9764), "Tuna", null },
                    { new Guid("c845ba4c-9cbb-47d6-a623-dfc636c36fbe"), 1, new Guid("7c2c7cf7-138c-45a9-92f1-39c1cfd1a5e5"), 292, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1333), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, 518.05m, new DateTime(2023, 9, 16, 21, 43, 6, 975, DateTimeKind.Local).AddTicks(5687), "Cheese", null },
                    { new Guid("c8e4f862-996d-41e4-8f81-3340b360b5ac"), 0, new Guid("df450115-04cd-48b2-a360-b298981135c7"), 743, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(285), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2, 647.02m, new DateTime(2023, 10, 12, 0, 17, 51, 738, DateTimeKind.Local).AddTicks(9617), "Pizza", null },
                    { new Guid("c8f306a7-2516-43b7-9816-3787fb99901b"), 2, new Guid("c64ce4c7-a794-420d-b9fa-812befcf9788"), 510, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7802), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, 643.36m, new DateTime(2024, 3, 12, 6, 2, 49, 111, DateTimeKind.Local).AddTicks(5879), "Chips", null },
                    { new Guid("ca8112c3-885b-48af-b5e7-dfd6b2f435bd"), 1, new Guid("7563f48f-fe9f-4f5f-b9e3-db3401605773"), 787, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5094), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, 103.92m, new DateTime(2023, 10, 22, 9, 13, 39, 34, DateTimeKind.Local).AddTicks(2608), "Mouse", null },
                    { new Guid("ca854e29-3b98-45a4-a23d-f9ca582c7e46"), 1, new Guid("0c49b46e-dbbe-4ab8-a534-453dc978e05b"), 158, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1980), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0, 914.66m, new DateTime(2024, 3, 25, 23, 8, 50, 550, DateTimeKind.Local).AddTicks(8754), "Keyboard", null },
                    { new Guid("cb48f747-18e7-41fb-98f7-ddd188456199"), 1, new Guid("b0bf864a-da5b-453d-a830-b189b93b6813"), 818, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2068), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 4, 327.77m, new DateTime(2023, 11, 29, 22, 48, 6, 339, DateTimeKind.Local).AddTicks(9511), "Salad", null },
                    { new Guid("cc31dc5c-6c09-40cf-b5bc-d97b95de93b0"), 0, new Guid("b4ea8a85-9f35-4da0-881c-ce5d4a503997"), 334, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3355), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 3, 73.13m, new DateTime(2024, 4, 28, 5, 41, 31, 265, DateTimeKind.Local).AddTicks(7582), "Ball", null },
                    { new Guid("d2b2062e-4b6c-4a79-921b-e3bba8316cfe"), 2, new Guid("a2894ab4-3454-4114-b889-5013ef80cacb"), 645, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1822), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 3, 81.80m, new DateTime(2023, 10, 10, 12, 39, 5, 958, DateTimeKind.Local).AddTicks(2864), "Bike", null },
                    { new Guid("d4a58d36-1568-4283-923a-1c461bd3a51a"), 1, new Guid("359525c7-4640-4805-ba56-7733d5bfe825"), 774, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9859), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2, 661.34m, new DateTime(2023, 9, 7, 20, 35, 6, 249, DateTimeKind.Local).AddTicks(9345), "Pants", null },
                    { new Guid("d56e24cd-be5a-4037-8eae-250c8ac9f39a"), 0, new Guid("76243127-6c70-4fa8-81a6-a01a27ff8f9b"), 70, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8596), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 0, 25.90m, new DateTime(2024, 2, 26, 19, 19, 52, 292, DateTimeKind.Local).AddTicks(467), "Computer", null },
                    { new Guid("d64e69c2-7766-486c-b8bd-1e278c39a9b2"), 2, new Guid("ca2e16c9-b1b5-448c-baf2-56dfa1595221"), 636, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9453), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, 750.26m, new DateTime(2024, 2, 20, 12, 33, 10, 777, DateTimeKind.Local).AddTicks(9129), "Fish", null },
                    { new Guid("d6769135-4f13-43be-a3a5-62188051413f"), 1, new Guid("8cea83b8-56d0-4f1d-9853-fbbc83bc77c6"), 483, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3692), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, 238.59m, new DateTime(2023, 8, 16, 23, 17, 29, 626, DateTimeKind.Local).AddTicks(6915), "Chicken", null },
                    { new Guid("d6df5b9a-7896-4b40-b41d-e0b9bc637434"), 2, new Guid("f83d797b-ee74-46e9-b7af-8d821faa9229"), 63, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1866), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, 260.79m, new DateTime(2023, 7, 3, 5, 12, 26, 552, DateTimeKind.Local).AddTicks(1406), "Ball", null },
                    { new Guid("d8cef5dd-5002-44e8-9566-5e5cb32df90d"), 2, new Guid("859dc25b-d52f-4fae-9db5-1e2018d8f139"), 706, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5428), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 4, 757.33m, new DateTime(2024, 1, 11, 18, 28, 27, 22, DateTimeKind.Local).AddTicks(7919), "Fish", null },
                    { new Guid("d955f460-872d-469c-8934-214dc6b34ce0"), 1, new Guid("91f80af1-00b9-47ad-9780-a236d3e0f1a3"), 501, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4365), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, 544.45m, new DateTime(2023, 12, 21, 7, 18, 18, 707, DateTimeKind.Local).AddTicks(6619), "Shoes", null },
                    { new Guid("d95def22-014e-4f2b-a255-a46114db6143"), 1, new Guid("fc44d48e-119a-4cd2-86dd-3d14537917f8"), 576, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1489), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2, 354.67m, new DateTime(2023, 10, 13, 17, 13, 39, 582, DateTimeKind.Local).AddTicks(1952), "Pizza", null },
                    { new Guid("d9a5bda1-0cde-429a-969e-06e14e25f477"), 1, new Guid("4f6b6b17-2277-4dbe-b377-873878974d05"), 370, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(9568), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, 157.99m, new DateTime(2024, 1, 18, 15, 53, 23, 305, DateTimeKind.Local).AddTicks(1753), "Pizza", null },
                    { new Guid("d9c9bd55-d64b-44de-a49c-8611dfe77595"), 0, new Guid("6cc7736f-9d5f-49de-a246-b6824902e1ea"), 503, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4520), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, 97.59m, new DateTime(2023, 6, 5, 8, 24, 22, 653, DateTimeKind.Local).AddTicks(6659), "Bacon", null },
                    { new Guid("daad2231-4fa2-4056-971e-46599c3f7ffa"), 2, new Guid("4cabe2e7-41a9-4d29-b3e5-fea41737b8bc"), 127, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(401), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, 192.54m, new DateTime(2024, 5, 26, 3, 37, 59, 687, DateTimeKind.Local).AddTicks(7172), "Chair", null },
                    { new Guid("dc00e22c-3b1e-42f9-8b46-3ff73141d2f2"), 2, new Guid("a50e9cd6-e1b6-44cd-9dd2-50530ab00a37"), 571, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6626), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 6, 561.33m, new DateTime(2024, 1, 26, 4, 45, 49, 656, DateTimeKind.Local).AddTicks(7793), "Fish", null },
                    { new Guid("dcb128c3-81af-4757-996a-acb597962c30"), 0, new Guid("00928cb2-85df-4ef6-936c-b472b08a5b25"), 155, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2444), "The Football Is Good For Training And Recreational Purposes", 4, 797.17m, new DateTime(2024, 1, 10, 7, 27, 44, 71, DateTimeKind.Local).AddTicks(5445), "Table", null },
                    { new Guid("dd2da866-1c70-4395-99c9-98703d5419b9"), 0, new Guid("b0ebd007-80c6-412b-8301-bf0876f11d3d"), 717, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(780), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0, 392.46m, new DateTime(2023, 10, 13, 19, 14, 58, 174, DateTimeKind.Local).AddTicks(8141), "Shirt", null },
                    { new Guid("dddad4e1-7445-4120-95ab-609b64f13cb1"), 1, new Guid("c64ce4c7-a794-420d-b9fa-812befcf9788"), 23, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4852), "The Football Is Good For Training And Recreational Purposes", 6, 544.08m, new DateTime(2023, 10, 24, 2, 44, 32, 953, DateTimeKind.Local).AddTicks(5254), "Computer", null },
                    { new Guid("de1efad9-302f-4353-96b3-221c083eb8f7"), 1, new Guid("4f6b6b17-2277-4dbe-b377-873878974d05"), 584, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8460), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, 276.22m, new DateTime(2023, 9, 29, 0, 15, 47, 573, DateTimeKind.Local).AddTicks(1801), "Shoes", null },
                    { new Guid("dfc5b601-9ff7-4f5a-a4a8-2c46263d8e95"), 2, new Guid("b0ebd007-80c6-412b-8301-bf0876f11d3d"), 854, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4608), "The Football Is Good For Training And Recreational Purposes", 1, 578.56m, new DateTime(2024, 2, 14, 2, 17, 33, 123, DateTimeKind.Local).AddTicks(6187), "Hat", null },
                    { new Guid("e3af5a64-7115-4aa9-bc3e-924341141780"), 0, new Guid("859dc25b-d52f-4fae-9db5-1e2018d8f139"), 264, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8051), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, 843.94m, new DateTime(2023, 7, 22, 15, 55, 54, 987, DateTimeKind.Local).AddTicks(8408), "Bacon", null },
                    { new Guid("e44c648b-20bc-4a96-9f08-e91e1cc2b986"), 2, new Guid("7de6f4ed-9e9c-4718-9839-b3e8de8428bf"), 430, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(535), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 4, 209.81m, new DateTime(2024, 4, 15, 5, 46, 12, 129, DateTimeKind.Local).AddTicks(5495), "Pants", null },
                    { new Guid("e54715af-5a70-4555-bb3d-5c8d2fa00069"), 2, new Guid("ff947f18-b883-4062-b4b5-8402df934d01"), 610, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6339), "The Football Is Good For Training And Recreational Purposes", 2, 668.17m, new DateTime(2024, 1, 16, 8, 53, 30, 201, DateTimeKind.Local).AddTicks(7293), "Chair", null },
                    { new Guid("e657f57f-59e4-4e05-8047-b0d93fb0427d"), 1, new Guid("7ebae05a-e45e-4aa6-847d-f26e8330053c"), 556, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(6121), "The Football Is Good For Training And Recreational Purposes", 0, 484.47m, new DateTime(2024, 5, 10, 14, 9, 44, 236, DateTimeKind.Local).AddTicks(6347), "Shoes", null },
                    { new Guid("e7bc23b2-4d1b-46de-88cc-98765f0dbf2e"), 0, new Guid("ca2e16c9-b1b5-448c-baf2-56dfa1595221"), 559, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5807), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, 285.20m, new DateTime(2023, 6, 21, 10, 2, 54, 572, DateTimeKind.Local).AddTicks(5143), "Hat", null },
                    { new Guid("e9f374e9-7db1-4918-b592-0e67122b1fb6"), 2, new Guid("a2894ab4-3454-4114-b889-5013ef80cacb"), 269, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(4963), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 6, 951.64m, new DateTime(2023, 11, 19, 16, 2, 52, 109, DateTimeKind.Local).AddTicks(9753), "Bike", null },
                    { new Guid("ebb962e2-a526-4879-8d1d-d6a9a356179e"), 2, new Guid("3ef679f4-7f15-466a-af52-d9497bb48f4a"), 60, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2732), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, 169.77m, new DateTime(2024, 3, 29, 15, 11, 38, 529, DateTimeKind.Local).AddTicks(4534), "Sausages", null },
                    { new Guid("ed593aa8-63fe-4b21-9779-0a693d593200"), 1, new Guid("7c2c7cf7-138c-45a9-92f1-39c1cfd1a5e5"), 536, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(7758), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4, 877.92m, new DateTime(2024, 3, 7, 19, 55, 52, 638, DateTimeKind.Local).AddTicks(7492), "Ball", null },
                    { new Guid("edde274f-f1cc-453f-a09f-38f475878892"), 0, new Guid("cae3d1f4-0049-49e0-b439-c18397f390c9"), 967, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8753), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, 756.94m, new DateTime(2024, 5, 24, 23, 14, 55, 152, DateTimeKind.Local).AddTicks(5589), "Chips", null },
                    { new Guid("f32f8221-199c-4b55-83a5-fc3f90341263"), 0, new Guid("4cabe2e7-41a9-4d29-b3e5-fea41737b8bc"), 908, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(2401), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, 339.60m, new DateTime(2023, 11, 24, 1, 39, 55, 527, DateTimeKind.Local).AddTicks(2916), "Computer", null },
                    { new Guid("f3e8808e-27c9-4499-bf3c-ca18e92e03d2"), 0, new Guid("b4ea8a85-9f35-4da0-881c-ce5d4a503997"), 159, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8096), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, 11.78m, new DateTime(2023, 7, 12, 16, 50, 44, 253, DateTimeKind.Local).AddTicks(7062), "Chicken", null },
                    { new Guid("f50c6caf-9d4e-4cad-9976-438049111e2f"), 1, new Guid("596ce2c7-1adf-41f4-88fc-a3a42d04c9a3"), 412, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3232), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, 965.03m, new DateTime(2023, 9, 24, 8, 49, 11, 420, DateTimeKind.Local).AddTicks(4880), "Cheese", null },
                    { new Guid("f5fde8c7-9a01-4f3d-be16-2e14ba7301c1"), 0, new Guid("c64ce4c7-a794-420d-b9fa-812befcf9788"), 714, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5184), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6, 879.66m, new DateTime(2024, 2, 27, 18, 59, 44, 46, DateTimeKind.Local).AddTicks(1764), "Mouse", null },
                    { new Guid("f6aaa741-1743-432e-9b77-8a88959cfe0c"), 1, new Guid("11c7d492-c74e-4b89-a188-d81d276d668e"), 408, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1069), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 0, 683.93m, new DateTime(2024, 3, 1, 6, 52, 32, 351, DateTimeKind.Local).AddTicks(2177), "Shoes", null },
                    { new Guid("f8029739-5ca1-4eb0-957c-e634cb4f2318"), 1, new Guid("596ce2c7-1adf-41f4-88fc-a3a42d04c9a3"), 774, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(3188), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 5, 82.43m, new DateTime(2024, 4, 6, 8, 59, 0, 175, DateTimeKind.Local).AddTicks(8848), "Keyboard", null },
                    { new Guid("f8baac52-4762-4b81-8252-b10b117b0761"), 2, new Guid("cf4d319a-fd1f-4f9e-af11-092cd69b31ab"), 660, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(5295), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 6, 845.77m, new DateTime(2024, 5, 13, 7, 31, 34, 288, DateTimeKind.Local).AddTicks(1697), "Shirt", null },
                    { new Guid("fe7b2af4-cc31-462f-86bd-dd24c366a3ef"), 2, new Guid("859dc25b-d52f-4fae-9db5-1e2018d8f139"), 589, new DateTime(2023, 5, 26, 23, 25, 2, 613, DateTimeKind.Local).AddTicks(8552), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6, 181.03m, new DateTime(2023, 10, 14, 3, 15, 55, 441, DateTimeKind.Local).AddTicks(5652), "Car", null },
                    { new Guid("fe8f8feb-cfcc-4787-bb1a-cab352581737"), 0, new Guid("7c2c7cf7-138c-45a9-92f1-39c1cfd1a5e5"), 103, new DateTime(2023, 5, 26, 23, 25, 2, 614, DateTimeKind.Local).AddTicks(1445), "The Football Is Good For Training And Recreational Purposes", 4, 47.63m, new DateTime(2023, 12, 26, 19, 39, 30, 495, DateTimeKind.Local).AddTicks(6256), "Bike", null }
                });

            migrationBuilder.InsertData(
                table: "BooksCategories",
                columns: new[] { "ID", "BooksID", "CategoriesID", "CreatedDateTime", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("016d7292-5ea0-4d48-832c-c84dfd643693"), new Guid("536df0b7-9778-4b63-8e0b-9cdf99566abc"), new Guid("f90b083d-a4f6-4034-b84f-875b30d1413b"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8227), null },
                    { new Guid("0390ddc0-2fbd-4a53-9666-291e95978cf8"), new Guid("1729c8d7-0f1d-4ff8-9d6e-b563d4838bdb"), new Guid("9fae6a0d-b9ac-4692-b0c4-2f98108b66e4"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5810), null },
                    { new Guid("05922d2a-e697-45ab-994c-f9f1ebdaaeea"), new Guid("9cda9c7b-f223-4fdf-af20-c18f8e63fc76"), new Guid("3751a36f-8c48-4d61-a033-1f2c60f70b89"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6975), null },
                    { new Guid("0618eaac-3bcc-4305-80f3-ee4b6aac8d7d"), new Guid("99675fff-d707-4133-9e3a-d33a7e50709a"), new Guid("ecf20367-1ed3-46b6-85e1-cc028f4d842a"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6493), null },
                    { new Guid("072f8559-bcb0-49ca-8b5f-f035e7851aed"), new Guid("7451dc9f-6dc9-4659-9d1f-bb1527115246"), new Guid("c1d330ad-819c-4622-9e8b-9c2098fddd75"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8146), null },
                    { new Guid("07b1f343-798f-41d1-ba9d-6fd0a796b7c6"), new Guid("ebb962e2-a526-4879-8d1d-d6a9a356179e"), new Guid("63766c80-b097-48d2-8612-cc6087f3df23"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8635), null },
                    { new Guid("080f4bc6-984f-46f4-aa99-af97d66d018f"), new Guid("84d93dfe-1905-447f-847a-784c6efc6eb9"), new Guid("de0c159f-44ce-4555-89af-f398a15295ed"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8491), null },
                    { new Guid("09194d4f-2ac5-45df-b0b2-eada36347d8f"), new Guid("c282b1bf-fd37-44f5-a5a9-fbb52e770f58"), new Guid("e8aedad4-b02e-4d80-bca1-1b0560848bce"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6138), null },
                    { new Guid("0e414476-1cff-40aa-96c9-9af22e33a518"), new Guid("67db66b0-7bdf-4d3b-9ecc-558bd7a75b76"), new Guid("405e3f64-5abc-4753-be5b-77c7a880fc60"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6176), null },
                    { new Guid("0e5ebcca-2283-4c9c-bee6-564ec99fb22b"), new Guid("a3c70461-f27e-4d11-806b-c98b62f8b651"), new Guid("003b12d7-d5e1-47fb-bcc2-19c8880448ef"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6655), null },
                    { new Guid("1144b8d0-69a2-4d9b-ad7a-89823a31b52e"), new Guid("7c8bc50b-d71e-4e3c-9686-3c6468b7cb83"), new Guid("f90b083d-a4f6-4034-b84f-875b30d1413b"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8120), null },
                    { new Guid("123c42ef-baa0-47d5-8587-3d1ee0f703fc"), new Guid("30fff4ad-9a5f-4764-b67a-9f80813fd41e"), new Guid("7b0b01ac-7206-4af7-9024-d9881ee0cd87"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8159), null },
                    { new Guid("13c10bc1-e71a-40cc-ab7d-f7735f4650f1"), new Guid("175071e2-c74e-4fc4-9b14-d8119e7d4c32"), new Guid("dce233b7-8767-431b-aee1-42b050ff96c2"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7038), null },
                    { new Guid("15590de9-2df5-4cdf-8687-3a8d2aef1c4a"), new Guid("36baf1e0-8c72-4a34-adea-af42cffcc482"), new Guid("bdfe3804-0dca-4cb6-a37c-ed5366769e22"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7768), null },
                    { new Guid("1d5f0149-22bb-4b1e-9eda-6121e8b73c9c"), new Guid("dcb128c3-81af-4757-996a-acb597962c30"), new Guid("200d2f07-a903-4d2f-a48f-c91c5b94f417"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6886), null },
                    { new Guid("2032a93a-de35-4284-80ce-1f949d53521c"), new Guid("33d80ba0-a88f-4609-aac4-bafca56f204f"), new Guid("9f58f57b-d9fd-4c8b-bfe5-1ec55ed3bcc9"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8561), null },
                    { new Guid("20d4614a-1d70-4fc0-ac57-5ec3651b2cda"), new Guid("33b3433b-02b1-4c3b-89f6-890f9fe50e1b"), new Guid("41065de1-75c8-4a9b-9231-3d48f9f7db4e"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6191), null },
                    { new Guid("250e471b-8c1b-4a62-bc8f-b2c8a4da7bd1"), new Guid("36631ae1-f552-4aae-a6a7-dc2e5b0b5567"), new Guid("710d83bf-82dc-4b89-9c53-4876a49a720c"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6331), null },
                    { new Guid("2620544b-319a-4961-90eb-cfe56b24673c"), new Guid("f8029739-5ca1-4eb0-957c-e634cb4f2318"), new Guid("710d83bf-82dc-4b89-9c53-4876a49a720c"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7982), null },
                    { new Guid("2a9d9a71-6af5-4d0d-9d00-439caad32ac0"), new Guid("f3e8808e-27c9-4499-bf3c-ca18e92e03d2"), new Guid("131152c5-88c1-4e4c-8f13-3b8006018a0c"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6204), null },
                    { new Guid("2aa0d83b-23d6-4ca2-8570-e7099ca66326"), new Guid("672db99c-f5e1-4b30-8705-5b9186ab208f"), new Guid("0992565e-52a3-4143-b4c0-1fc29adb0825"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7564), null },
                    { new Guid("2aa884b6-fbcc-442a-9f40-1ae8cd1e3aa6"), new Guid("95badf0f-31dc-4b7c-afe5-549b7108f307"), new Guid("c34aa2ee-f087-4ec0-a580-b101ac6b74c3"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6370), null },
                    { new Guid("2dfcc361-a3bb-427e-a0c5-1b7b813daeef"), new Guid("36631ae1-f552-4aae-a6a7-dc2e5b0b5567"), new Guid("94252978-44b4-4c0b-83bd-23ebc0a543c5"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8709), null },
                    { new Guid("30bc402c-9044-4b0e-bf51-7818412cc85f"), new Guid("7451dc9f-6dc9-4659-9d1f-bb1527115246"), new Guid("781962bb-269f-4bc5-af85-3f1a9043a006"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6344), null },
                    { new Guid("32394655-8df6-4a59-a6c4-c299673601c8"), new Guid("52a7d9c9-a148-4f80-afe4-4e7e00dbd32f"), new Guid("f3b47a28-589d-4bdf-9b4f-e978f991bb86"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6629), null },
                    { new Guid("32bf695d-33d9-4b81-a11a-4cb6b5836e82"), new Guid("ca854e29-3b98-45a4-a23d-f9ca582c7e46"), new Guid("1b57e35a-c0f5-4c8c-a8fd-3d735507291d"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7390), null },
                    { new Guid("35012c54-9dbe-438f-9e28-8ca7d082080b"), new Guid("93a5872d-b9ff-40cf-8d8a-25942a19c57d"), new Guid("7661ba0b-bdb9-4efd-a009-5f37aa5c8801"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8275), null },
                    { new Guid("389ff1ed-8162-43a8-b9fc-f2e33c1f7826"), new Guid("20d29621-f50c-4dbe-8840-65a8af4bbfda"), new Guid("26f54e6c-b868-405b-bf06-35daf0a494ab"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8444), null },
                    { new Guid("3b049fbc-2ab2-45bc-b034-ab13526b155e"), new Guid("009da4da-b590-4b46-8d38-e05f70e96be4"), new Guid("710d83bf-82dc-4b89-9c53-4876a49a720c"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6253), null },
                    { new Guid("3daadbc0-8a79-4081-a924-90668780994f"), new Guid("0518a7da-6714-42dd-82b2-3d0eb848027f"), new Guid("003b12d7-d5e1-47fb-bcc2-19c8880448ef"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7628), null },
                    { new Guid("3dac13ec-b6db-49db-8114-1cadba59abee"), new Guid("5b9a87c2-3120-4961-9f65-f82d357b161c"), new Guid("bbfe1d7f-6fbd-46ae-9c0a-7b73927c84ce"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6520), null },
                    { new Guid("41f0e70d-aebf-490d-8a1e-aea595f3d34b"), new Guid("e657f57f-59e4-4e05-8047-b0d93fb0427d"), new Guid("de0c159f-44ce-4555-89af-f398a15295ed"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6268), null },
                    { new Guid("43e25b97-83ee-4578-b3d9-510831b2e132"), new Guid("573e37dc-ac9b-43ad-8fdd-64c650cb6135"), new Guid("bbfe1d7f-6fbd-46ae-9c0a-7b73927c84ce"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5698), null },
                    { new Guid("47ea981a-6150-4ef9-9ce8-21161b549d5d"), new Guid("0da710f0-522b-4b16-9644-b9164ba168d5"), new Guid("b51fd10f-09a1-433d-b08f-e8488d322818"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7914), null },
                    { new Guid("4b8dea09-3356-499d-93bb-f9d68b272f68"), new Guid("636687d2-52f1-459f-b801-88bf2f6a1baa"), new Guid("98076a64-f35f-44d5-8433-6a882046f134"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6506), null },
                    { new Guid("4dcceb2f-f7eb-4f5b-9e42-646fd40a94d5"), new Guid("99675fff-d707-4133-9e3a-d33a7e50709a"), new Guid("edd7e8bf-f3fd-4cfc-9652-38eb6f8f5b22"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6962), null },
                    { new Guid("50f90950-5836-4a64-b5ad-36ec966dec99"), new Guid("2015b0b3-7f9f-4dc1-90b5-f2b9added7ba"), new Guid("7b0b01ac-7206-4af7-9024-d9881ee0cd87"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7677), null },
                    { new Guid("52859651-bbc6-432b-bd57-af5c30776549"), new Guid("6f6aa030-a68e-4815-9817-612c9995776a"), new Guid("0992565e-52a3-4143-b4c0-1fc29adb0825"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5851), null },
                    { new Guid("57e3d12c-3513-4252-82c5-5a0dd5fca35c"), new Guid("99675fff-d707-4133-9e3a-d33a7e50709a"), new Guid("6d7f60f6-e4ba-41a1-869d-1cdb03ee4d41"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7756), null },
                    { new Guid("58773404-1cdf-4d47-9a8c-37a1dfb8b2b8"), new Guid("ca854e29-3b98-45a4-a23d-f9ca582c7e46"), new Guid("3751a36f-8c48-4d61-a033-1f2c60f70b89"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8134), null },
                    { new Guid("59e7ae52-f2ee-4e1d-a26d-e761c52f6aa7"), new Guid("7a9e0b9a-bd15-4fd5-93a3-89f8121c5546"), new Guid("967e66b3-ed8d-4478-95a1-89606eaa9717"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8300), null },
                    { new Guid("5cb0683c-5fa6-469c-a362-767f03bacc15"), new Guid("4ec7d2a3-01fb-446d-b14e-86cf6969f110"), new Guid("cea3ec76-e9c0-456a-be54-2d416b0d44ec"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5781), null },
                    { new Guid("5cd49d59-0816-4ccf-9ebf-1221eb34c6e2"), new Guid("3212e312-08c2-4be2-b6cc-9101fe8b3cb6"), new Guid("a1b2557c-b811-4d4b-bd55-2eabb9b01f2a"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5727), null },
                    { new Guid("5ce323e7-24ba-4e58-b563-7e41f1dda11c"), new Guid("b29cd53d-ff7c-40c6-91ee-bffe979ce2ca"), new Guid("710d83bf-82dc-4b89-9c53-4876a49a720c"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7333), null },
                    { new Guid("5ea78705-fa2c-4537-a306-258732f0290f"), new Guid("33d80ba0-a88f-4609-aac4-bafca56f204f"), new Guid("87b17700-5c38-4eda-acf5-8ead729cddf2"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6421), null },
                    { new Guid("5f2a91b6-6308-4de1-b6a6-c4790371cad7"), new Guid("083935c5-1177-478c-baf1-18beb096799a"), new Guid("bdfe3804-0dca-4cb6-a37c-ed5366769e22"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8504), null },
                    { new Guid("639a66d1-d828-4946-b4f3-738998346cb1"), new Guid("57ab244e-5f9e-4d45-974e-58866a9beb12"), new Guid("7661ba0b-bdb9-4efd-a009-5f37aa5c8801"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5638), null },
                    { new Guid("63b881a3-427a-431b-ac00-6473e09a2c15"), new Guid("0a9f76b3-b4eb-4988-acb2-29a40734b90d"), new Guid("94252978-44b4-4c0b-83bd-23ebc0a543c5"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5898), null },
                    { new Guid("64c37d30-8b9f-497c-b14c-6d689dfd3731"), new Guid("2015b0b3-7f9f-4dc1-90b5-f2b9added7ba"), new Guid("c07024db-a9ba-40e4-8781-c619d72e8eef"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7132), null },
                    { new Guid("6612f045-4605-4a8d-bc99-3e6d5769dda0"), new Guid("452a937a-e28a-44a4-8aef-773d1e6601be"), new Guid("0992565e-52a3-4143-b4c0-1fc29adb0825"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7321), null },
                    { new Guid("682e2ae7-d53d-40d6-a8aa-76a0f1b61071"), new Guid("e3af5a64-7115-4aa9-bc3e-924341141780"), new Guid("a7ab7720-fef8-4987-a56a-499a2d50e573"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7492), null },
                    { new Guid("68eb1c68-bf03-48eb-a7c9-d842fd8d760b"), new Guid("97ba17b3-a61f-4ce2-a72e-dffbc4d28e66"), new Guid("28f113e5-e9e0-4b57-b798-f227c0ac3987"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6779), null },
                    { new Guid("69e5a628-bcff-4b9e-aacb-da8d58ad27f6"), new Guid("d2b2062e-4b6c-4a79-921b-e3bba8316cfe"), new Guid("7b0b01ac-7206-4af7-9024-d9881ee0cd87"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5962), null },
                    { new Guid("6a8fc72b-1cfb-49a7-b83e-e581450fdf4d"), new Guid("0ab2d3c2-df76-48ea-8c8c-b22c4f6b1676"), new Guid("4fa81b78-d716-41a3-a5d5-6d2a99bcbb71"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7024), null },
                    { new Guid("6afa0964-e314-4528-bfeb-2c990a753bac"), new Guid("c845ba4c-9cbb-47d6-a623-dfc636c36fbe"), new Guid("b51fd10f-09a1-433d-b08f-e8488d322818"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7433), null },
                    { new Guid("6c12a0e7-8445-4fd1-91f9-036d08ce91ba"), new Guid("439432fe-8cbe-4a31-83e4-9c0c792aa189"), new Guid("bdfe3804-0dca-4cb6-a37c-ed5366769e22"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8200), null },
                    { new Guid("6efa683f-380f-47fe-a910-3c20d37ce42a"), new Guid("217d5d21-c070-446f-9002-6f8a1aa48939"), new Guid("715898e4-4eb7-4b3f-b22d-5e6750e38f8e"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6717), null },
                    { new Guid("71968ed5-b5de-4540-922c-3e953672f75e"), new Guid("9af750f8-55bf-4050-9eb3-d0f8142eb01b"), new Guid("c07024db-a9ba-40e4-8781-c619d72e8eef"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7701), null },
                    { new Guid("730d0583-a5bf-49ae-8138-3d5a66ecef8c"), new Guid("30fff4ad-9a5f-4764-b67a-9f80813fd41e"), new Guid("28f113e5-e9e0-4b57-b798-f227c0ac3987"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8372), null },
                    { new Guid("74a8f517-aa46-409f-8e36-7ac008a54001"), new Guid("217d5d21-c070-446f-9002-6f8a1aa48939"), new Guid("405e3f64-5abc-4753-be5b-77c7a880fc60"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6555), null },
                    { new Guid("75af3c01-097b-43b7-8da8-d4e0cb60949a"), new Guid("dcb128c3-81af-4757-996a-acb597962c30"), new Guid("94252978-44b4-4c0b-83bd-23ebc0a543c5"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6125), null },
                    { new Guid("7611645f-5914-46fb-9586-050b903a2b61"), new Guid("452a937a-e28a-44a4-8aef-773d1e6601be"), new Guid("7b0b01ac-7206-4af7-9024-d9881ee0cd87"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8085), null },
                    { new Guid("77e87db5-ddb1-40bf-9a10-62026c51dc09"), new Guid("d2b2062e-4b6c-4a79-921b-e3bba8316cfe"), new Guid("131152c5-88c1-4e4c-8f13-3b8006018a0c"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5713), null },
                    { new Guid("7910ba3a-6699-442c-8dbf-1c90609b77ac"), new Guid("95badf0f-31dc-4b7c-afe5-549b7108f307"), new Guid("7661ba0b-bdb9-4efd-a009-5f37aa5c8801"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6568), null },
                    { new Guid("7accf910-d848-4cfc-8e44-5449038a57be"), new Guid("11e21c96-3c27-4531-88f5-2c3f95cf8e6c"), new Guid("1e822901-32ea-4f2a-b051-ae23ddb1b8f2"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8346), null },
                    { new Guid("7c0bb222-d578-45b1-9c90-ceb023a4b6c9"), new Guid("4f2c6d8c-2b09-4954-8cc0-04f87ac38668"), new Guid("41065de1-75c8-4a9b-9231-3d48f9f7db4e"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7196), null },
                    { new Guid("7cff4bd4-f4a4-46d2-8013-b1c1e53237c3"), new Guid("3fcc7259-ebf1-4b22-a704-2c4d2b51e24e"), new Guid("6d7f60f6-e4ba-41a1-869d-1cdb03ee4d41"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7052), null },
                    { new Guid("7d201a29-c29d-4765-8299-1e5983942fd6"), new Guid("2cca9a2d-01ca-4e3c-80d4-99541c62e330"), new Guid("ecf20367-1ed3-46b6-85e1-cc028f4d842a"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5934), null },
                    { new Guid("7d41b428-48c4-4628-a52e-63af9642e2d9"), new Guid("61132708-e2f1-4ee4-b682-80d61bdcd490"), new Guid("781962bb-269f-4bc5-af85-3f1a9043a006"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6218), null },
                    { new Guid("7e3f1f07-f1f6-4e9a-88db-9810bd327312"), new Guid("0d539f3c-3e32-4add-b7a5-90a85bd72be7"), new Guid("7661ba0b-bdb9-4efd-a009-5f37aa5c8801"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8418), null },
                    { new Guid("802d6487-1a9f-4f48-a27b-9e9c74371157"), new Guid("ba0fc35c-80ce-4f6c-b6ac-1a3f6257d8fb"), new Guid("405e3f64-5abc-4753-be5b-77c7a880fc60"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5741), null },
                    { new Guid("82bbec8e-d77e-4d15-8e14-3bdf0b518840"), new Guid("8ad38a97-b1b5-4bb6-893d-c61c4588300e"), new Guid("26f54e6c-b868-405b-bf06-35daf0a494ab"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8548), null },
                    { new Guid("838fd4c7-df34-4c73-9c11-c2bd54c7e5da"), new Guid("79a2ad9e-d453-4093-8152-6d95d59f33d6"), new Guid("dce233b7-8767-431b-aee1-42b050ff96c2"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8585), null },
                    { new Guid("8661c3fe-f632-461f-a8cf-9aeaf7bd92c4"), new Guid("c8f306a7-2516-43b7-9816-3787fb99901b"), new Guid("dce233b7-8767-431b-aee1-42b050ff96c2"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7850), null },
                    { new Guid("8704b82d-b782-4d0b-a445-cebb96ca398d"), new Guid("97ba17b3-a61f-4ce2-a72e-dffbc4d28e66"), new Guid("131152c5-88c1-4e4c-8f13-3b8006018a0c"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7552), null },
                    { new Guid("8986ec52-d431-4ab0-b278-b0176e2b2c65"), new Guid("57ab244e-5f9e-4d45-974e-58866a9beb12"), new Guid("7661ba0b-bdb9-4efd-a009-5f37aa5c8801"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6408), null },
                    { new Guid("8a9abdf3-1bea-4912-b4cb-eaa832256fc0"), new Guid("06799635-cfa4-4aa8-877a-51272a5641b5"), new Guid("b51fd10f-09a1-433d-b08f-e8488d322818"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6989), null },
                    { new Guid("8ad01a9b-c030-4ba2-a57f-0dd8143437e4"), new Guid("f8baac52-4762-4b81-8252-b10b117b0761"), new Guid("28f113e5-e9e0-4b57-b798-f227c0ac3987"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6283), null },
                    { new Guid("8d340a44-73e0-49ed-bad2-35f3e95d8e13"), new Guid("2ea785fd-42b4-4787-9eb5-a6d050ed9a49"), new Guid("41065de1-75c8-4a9b-9231-3d48f9f7db4e"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8478), null },
                    { new Guid("91787711-e213-4ade-ba54-d1878418a09a"), new Guid("7451dc9f-6dc9-4659-9d1f-bb1527115246"), new Guid("4fa81b78-d716-41a3-a5d5-6d2a99bcbb71"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7862), null },
                    { new Guid("933bb4ed-8b18-4b4d-837a-2cce2d0f0e38"), new Guid("142fcf67-5229-43e7-af5d-5002516c963c"), new Guid("99cc61e2-a465-4aa9-80d3-782088f99f86"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8431), null },
                    { new Guid("93d176c3-c92b-415a-a371-ca64f5ebce37"), new Guid("c845ba4c-9cbb-47d6-a623-dfc636c36fbe"), new Guid("edd7e8bf-f3fd-4cfc-9652-38eb6f8f5b22"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6109), null },
                    { new Guid("93db5beb-5332-4726-9a4d-4a1f5f91b3ef"), new Guid("61e061f1-2611-444c-926b-8216adab1559"), new Guid("710d83bf-82dc-4b89-9c53-4876a49a720c"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8696), null },
                    { new Guid("93e06c58-37c8-4c62-8820-bea75d82f4a0"), new Guid("0ab2d3c2-df76-48ea-8c8c-b22c4f6b1676"), new Guid("28f113e5-e9e0-4b57-b798-f227c0ac3987"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8008), null },
                    { new Guid("940db7ff-20b1-4579-bbc8-3a78bab24dfe"), new Guid("01614b9a-18a0-456e-b453-4cdaece6861c"), new Guid("405e3f64-5abc-4753-be5b-77c7a880fc60"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8240), null },
                    { new Guid("946a78a7-6cd0-4f88-a1e3-48dd60382c40"), new Guid("b315b941-de1e-4152-bbc7-3376e4063b1c"), new Guid("edd7e8bf-f3fd-4cfc-9652-38eb6f8f5b22"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8358), null },
                    { new Guid("970bfae7-24bd-4fee-9700-fcf0bd9e964d"), new Guid("d9c9bd55-d64b-44de-a49c-8611dfe77595"), new Guid("1e822901-32ea-4f2a-b051-ae23ddb1b8f2"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8333), null },
                    { new Guid("9795328b-7dec-416a-9bb0-82bbd3646bb2"), new Guid("11e21c96-3c27-4531-88f5-2c3f95cf8e6c"), new Guid("7661ba0b-bdb9-4efd-a009-5f37aa5c8801"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7118), null },
                    { new Guid("980fe5ef-4c10-4727-b9ca-f9e96f049812"), new Guid("36631ae1-f552-4aae-a6a7-dc2e5b0b5567"), new Guid("26f54e6c-b868-405b-bf06-35daf0a494ab"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8623), null },
                    { new Guid("982a63df-52ec-4698-805b-f4eb2dd20169"), new Guid("8460aa96-7a0b-41a9-863d-8d9caf2e49a3"), new Guid("edd7e8bf-f3fd-4cfc-9652-38eb6f8f5b22"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7505), null },
                    { new Guid("9bd5aada-f2b6-49ec-98cf-b8003df280f7"), new Guid("6849d389-ee10-4b7f-a082-fe262b01a2c4"), new Guid("710d83bf-82dc-4b89-9c53-4876a49a720c"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6437), null },
                    { new Guid("9c9bb019-b43a-4b83-b949-6ef1088b50a0"), new Guid("4f09b4f7-b500-413c-940f-c43bd99b32be"), new Guid("6168a226-9a80-4862-a22e-8526d4cf7afe"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6297), null },
                    { new Guid("9d256b56-393a-4080-83ff-1af530b68ea9"), new Guid("23f2ff19-3b2d-4907-8cad-6da99a71ff4f"), new Guid("715898e4-4eb7-4b3f-b22d-5e6750e38f8e"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7170), null },
                    { new Guid("9e4cc526-3066-488e-9b4f-315b36f9dfa7"), new Guid("609d74a5-10e0-4bc3-ac07-640755ef2d1c"), new Guid("99cc61e2-a465-4aa9-80d3-782088f99f86"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5867), null },
                    { new Guid("a0888590-ac50-459b-9cdf-ee77d0a9745a"), new Guid("0a9f76b3-b4eb-4988-acb2-29a40734b90d"), new Guid("7b0b01ac-7206-4af7-9024-d9881ee0cd87"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5796), null },
                    { new Guid("a26a5b71-b500-416d-a2fb-4ead48ffe7f3"), new Guid("01db5738-41e5-4635-9ee0-f98f044358af"), new Guid("dce233b7-8767-431b-aee1-42b050ff96c2"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7824), null },
                    { new Guid("a33f50c9-3853-464f-9a5e-01dbfe193002"), new Guid("708967e1-29d4-48a9-84f8-29b7abbe494a"), new Guid("715898e4-4eb7-4b3f-b22d-5e6750e38f8e"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7714), null },
                    { new Guid("a464bf29-c6ca-4eff-93c5-a34e351bc562"), new Guid("1a835623-8895-4a8b-a61a-57f4fd756be4"), new Guid("200d2f07-a903-4d2f-a48f-c91c5b94f417"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8573), null },
                    { new Guid("a47edab7-3dda-402a-9bcf-a1ddcd722e5e"), new Guid("52a7d9c9-a148-4f80-afe4-4e7e00dbd32f"), new Guid("715898e4-4eb7-4b3f-b22d-5e6750e38f8e"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7689), null },
                    { new Guid("a6f82a75-ad33-46a2-9637-646bd7bda1be"), new Guid("61e061f1-2611-444c-926b-8216adab1559"), new Guid("a1b2557c-b811-4d4b-bd55-2eabb9b01f2a"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8648), null },
                    { new Guid("a8080c1f-143e-4713-a6ce-2df0a21558ae"), new Guid("0ab2d3c2-df76-48ea-8c8c-b22c4f6b1676"), new Guid("26f54e6c-b868-405b-bf06-35daf0a494ab"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8057), null },
                    { new Guid("ac2b6e03-9fd9-4560-a082-0c3576943878"), new Guid("dd2da866-1c70-4395-99c9-98703d5419b9"), new Guid("63766c80-b097-48d2-8612-cc6087f3df23"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7258), null },
                    { new Guid("ac86c839-37bc-4796-8820-88c7f7834f3e"), new Guid("3687def0-5ea3-4732-8d47-25606f90a726"), new Guid("4fa81b78-d716-41a3-a5d5-6d2a99bcbb71"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7273), null },
                    { new Guid("aeaa33fd-d813-4a85-9f11-359efa7d5814"), new Guid("d95def22-014e-4f2b-a255-a46114db6143"), new Guid("a7ab7720-fef8-4987-a56a-499a2d50e573"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6357), null },
                    { new Guid("aed80b5c-b87b-44bb-aa5a-a2bf3bfa0d17"), new Guid("cc31dc5c-6c09-40cf-b5bc-d97b95de93b0"), new Guid("94252978-44b4-4c0b-83bd-23ebc0a543c5"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6595), null },
                    { new Guid("b1372b20-aac2-4036-9a85-b187aa92821f"), new Guid("375a5c60-a3cc-437d-bf08-bc63faf6022e"), new Guid("967e66b3-ed8d-4478-95a1-89606eaa9717"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6730), null },
                    { new Guid("b4228ae0-3cef-43f3-8c22-9f6449f72e3b"), new Guid("c8f306a7-2516-43b7-9816-3787fb99901b"), new Guid("b14c1a71-1add-4fe0-8cf7-fe470f21ba63"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7467), null },
                    { new Guid("b847eccf-3ac1-4b29-9b9d-14910bae3cfb"), new Guid("968f1c8b-4f28-456b-be3e-5466c935a9cf"), new Guid("405e3f64-5abc-4753-be5b-77c7a880fc60"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6480), null },
                    { new Guid("bbc9a30c-63bc-457b-a3d6-eedf5880054d"), new Guid("4aae659b-3aa3-49d3-9939-4b20ba96459e"), new Guid("edd7e8bf-f3fd-4cfc-9652-38eb6f8f5b22"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6804), null },
                    { new Guid("bd5ba1a5-bece-4371-8096-758b060c2b3c"), new Guid("452a937a-e28a-44a4-8aef-773d1e6601be"), new Guid("a1b2557c-b811-4d4b-bd55-2eabb9b01f2a"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6947), null },
                    { new Guid("bdb5a037-b54b-4ef4-8c06-3767dc69c611"), new Guid("83a6b74d-3783-4287-a039-46358d8bbd51"), new Guid("99cc61e2-a465-4aa9-80d3-782088f99f86"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5171), null },
                    { new Guid("bdbdf3c7-54fd-4246-8950-ab6be95e633c"), new Guid("2015b0b3-7f9f-4dc1-90b5-f2b9added7ba"), new Guid("a7ab7720-fef8-4987-a56a-499a2d50e573"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8288), null },
                    { new Guid("be46ebdd-0da0-467d-a7cf-a8ff2b5efc15"), new Guid("1a835623-8895-4a8b-a61a-57f4fd756be4"), new Guid("c34aa2ee-f087-4ec0-a580-b101ac6b74c3"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7996), null },
                    { new Guid("be4e436f-662a-4462-b20d-3d4be3401042"), new Guid("37091e8e-b35e-45bb-8f95-6f52713ef8f7"), new Guid("f16d6878-d203-4fbd-ad28-003a33929f56"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6579), null },
                    { new Guid("c10ccee5-d3cb-4efa-b849-7684985945ec"), new Guid("f6aaa741-1743-432e-9b77-8a88959cfe0c"), new Guid("9fae6a0d-b9ac-4692-b0c4-2f98108b66e4"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8072), null },
                    { new Guid("c346ee44-0e0d-457b-a467-4ce8c7b0fb8e"), new Guid("41bc0619-8e68-406a-bd64-a1a07631a3a9"), new Guid("104b63ec-1103-4b64-9665-f919e7139efc"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6703), null },
                    { new Guid("c47e20e2-be05-498b-9520-61a860186466"), new Guid("03d8b1f0-0038-47f3-a93a-cd9e3a964668"), new Guid("003b12d7-d5e1-47fb-bcc2-19c8880448ef"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7540), null },
                    { new Guid("c604f10b-61b9-4201-8728-f9819f79c144"), new Guid("4d324351-8d0e-4bb9-a5bf-198b8e8e97ff"), new Guid("1b57e35a-c0f5-4c8c-a8fd-3d735507291d"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8721), null },
                    { new Guid("c6d6b06b-8cf4-461c-bf3d-2ccd2e4b9b4a"), new Guid("2cca9a2d-01ca-4e3c-80d4-99541c62e330"), new Guid("781962bb-269f-4bc5-af85-3f1a9043a006"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7419), null },
                    { new Guid("c850198e-4471-4365-90e9-4cc9ab81e40f"), new Guid("f32f8221-199c-4b55-83a5-fc3f90341263"), new Guid("a7ab7720-fef8-4987-a56a-499a2d50e573"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8212), null },
                    { new Guid("c93be422-05f1-48b8-b195-2a17c825faf0"), new Guid("609d74a5-10e0-4bc3-ac07-640755ef2d1c"), new Guid("94252978-44b4-4c0b-83bd-23ebc0a543c5"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7246), null },
                    { new Guid("c95a2d59-0584-4c48-bebc-691276876563"), new Guid("edde274f-f1cc-453f-a09f-38f475878892"), new Guid("1e822901-32ea-4f2a-b051-ae23ddb1b8f2"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5882), null },
                    { new Guid("cc1a92a2-576e-42e1-b68a-aef06fed727f"), new Guid("a9269dfb-9f3e-49c7-a71f-d3fbe00184a9"), new Guid("28f113e5-e9e0-4b57-b798-f227c0ac3987"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7640), null },
                    { new Guid("cfb61a49-e71e-45b9-a6fb-d9989f82a9fb"), new Guid("609d74a5-10e0-4bc3-ac07-640755ef2d1c"), new Guid("28f113e5-e9e0-4b57-b798-f227c0ac3987"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8406), null },
                    { new Guid("d1c42748-8c93-4070-8ab4-8fb08143a7b7"), new Guid("009da4da-b590-4b46-8d38-e05f70e96be4"), new Guid("63766c80-b097-48d2-8612-cc6087f3df23"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7781), null },
                    { new Guid("d317ca52-1c20-4857-a35f-894cdd679f13"), new Guid("083935c5-1177-478c-baf1-18beb096799a"), new Guid("710d83bf-82dc-4b89-9c53-4876a49a720c"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7939), null },
                    { new Guid("d4586381-87bd-47e1-861a-ffdee79600c1"), new Guid("95badf0f-31dc-4b7c-afe5-549b7108f307"), new Guid("bbfe1d7f-6fbd-46ae-9c0a-7b73927c84ce"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8044), null },
                    { new Guid("d4bfe2ba-facf-45fe-a0b4-40fa7d1daaf6"), new Guid("23f2ff19-3b2d-4907-8cad-6da99a71ff4f"), new Guid("28f113e5-e9e0-4b57-b798-f227c0ac3987"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7616), null },
                    { new Guid("d62a625a-62d6-494b-b65a-2b51627fa6c1"), new Guid("95badf0f-31dc-4b7c-afe5-549b7108f307"), new Guid("f3b47a28-589d-4bdf-9b4f-e978f991bb86"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7480), null },
                    { new Guid("d6b959e2-0c30-409f-b865-2e95ed3df171"), new Guid("b85c8d06-4c6d-4e7d-a96a-42ebc1a45b82"), new Guid("cea3ec76-e9c0-456a-be54-2d416b0d44ec"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6817), null },
                    { new Guid("da1d797b-d2de-4f36-9f5b-423a56d95ead"), new Guid("636687d2-52f1-459f-b801-88bf2f6a1baa"), new Guid("b51fd10f-09a1-433d-b08f-e8488d322818"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7927), null },
                    { new Guid("da6101ae-05f7-4973-a94f-939f273a94a1"), new Guid("d9a5bda1-0cde-429a-969e-06e14e25f477"), new Guid("1e822901-32ea-4f2a-b051-ae23ddb1b8f2"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7837), null },
                    { new Guid("df4ebbfd-cd82-43a2-ba58-21231bc431cc"), new Guid("d64e69c2-7766-486c-b8bd-1e278c39a9b2"), new Guid("781962bb-269f-4bc5-af85-3f1a9043a006"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(8661), null },
                    { new Guid("e0e84abb-ff48-409a-b92d-9d208168161d"), new Guid("6849d389-ee10-4b7f-a082-fe262b01a2c4"), new Guid("99cc61e2-a465-4aa9-80d3-782088f99f86"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6643), null },
                    { new Guid("e64e0e6a-c7d1-4f86-9676-cc5ac689eb7b"), new Guid("375a5c60-a3cc-437d-bf08-bc63faf6022e"), new Guid("f16d6878-d203-4fbd-ad28-003a33929f56"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6743), null },
                    { new Guid("e6a00563-075e-432f-87e5-246fe5aabedd"), new Guid("d8cef5dd-5002-44e8-9566-5e5cb32df90d"), new Guid("c07024db-a9ba-40e4-8781-c619d72e8eef"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7184), null },
                    { new Guid("ed18a280-6cfa-47c2-8757-40483fdfa654"), new Guid("21907147-3215-48d8-99c8-4ae251c35749"), new Guid("4fa81b78-d716-41a3-a5d5-6d2a99bcbb71"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7103), null },
                    { new Guid("ef98dcf5-45ad-47b8-958c-be19a9ea4a4f"), new Guid("93a5872d-b9ff-40cf-8d8a-25942a19c57d"), new Guid("6168a226-9a80-4862-a22e-8526d4cf7afe"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6912), null },
                    { new Guid("efb17b72-d95f-4c2b-8015-ea16778334a1"), new Guid("2cca9a2d-01ca-4e3c-80d4-99541c62e330"), new Guid("63766c80-b097-48d2-8612-cc6087f3df23"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7407), null },
                    { new Guid("f36f9005-f207-4df6-9f99-0131c795f29f"), new Guid("8cd80fb8-9795-48e1-a253-4be9d4e0c1ae"), new Guid("a7ab7720-fef8-4987-a56a-499a2d50e573"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5619), null },
                    { new Guid("f45c06ea-c484-49cf-bee8-77d92ab3fda6"), new Guid("1a835623-8895-4a8b-a61a-57f4fd756be4"), new Guid("bdfe3804-0dca-4cb6-a37c-ed5366769e22"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7210), null },
                    { new Guid("f489fb99-17e5-4c55-936d-7d5b963757cd"), new Guid("439432fe-8cbe-4a31-83e4-9c0c792aa189"), new Guid("1e822901-32ea-4f2a-b051-ae23ddb1b8f2"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5949), null },
                    { new Guid("f4bbb70e-1ceb-42c3-98a5-b2581c80ebdd"), new Guid("8156c3a6-9608-4586-a495-4cbfd1927724"), new Guid("f3b47a28-589d-4bdf-9b4f-e978f991bb86"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7602), null },
                    { new Guid("f8116b94-6b01-44bf-938e-1dee1d2bdf41"), new Guid("559f004f-7d59-4efc-a120-425bd3531d67"), new Guid("1b57e35a-c0f5-4c8c-a8fd-3d735507291d"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7346), null },
                    { new Guid("f9198fb9-d5db-49b0-a37a-2046c56d37d6"), new Guid("4d324351-8d0e-4bb9-a5bf-198b8e8e97ff"), new Guid("131152c5-88c1-4e4c-8f13-3b8006018a0c"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7286), null },
                    { new Guid("fb2a2915-2c7b-409c-8fb6-c5e6c37d1ae8"), new Guid("9fa74d77-df93-492a-9414-ce1ce84520f1"), new Guid("ecf20367-1ed3-46b6-85e1-cc028f4d842a"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7066), null },
                    { new Guid("fc4f1846-bcf6-4d21-9539-36b4f8666ba6"), new Guid("03d8b1f0-0038-47f3-a93a-cd9e3a964668"), new Guid("87b17700-5c38-4eda-acf5-8ead729cddf2"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6792), null },
                    { new Guid("fc9bdd22-2a6b-472a-85ec-e15e27789610"), new Guid("66dcc28c-0bf6-4ff1-a9f3-e7a0170e309b"), new Guid("a7ab7720-fef8-4987-a56a-499a2d50e573"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(7899), null },
                    { new Guid("fcb14572-3173-4a4c-a757-eb3dfcf4d448"), new Guid("37091e8e-b35e-45bb-8f95-6f52713ef8f7"), new Guid("c34aa2ee-f087-4ec0-a580-b101ac6b74c3"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(6899), null },
                    { new Guid("fe37e7a5-1577-48dd-b785-17057b1b9f17"), new Guid("5fbe6f53-9fc0-4af8-a6c4-2cf14fd132ce"), new Guid("cea3ec76-e9c0-456a-be54-2d416b0d44ec"), new DateTime(2023, 5, 26, 23, 25, 2, 620, DateTimeKind.Local).AddTicks(5974), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("288fb03e-6db0-46aa-b89c-23601cf11b03"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("2aefbbd3-c4e7-4f92-9b67-6267ddebe85f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("6f36ca4e-4249-484d-82d5-c8e1148138e5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("7c8b17c4-8943-484b-9b06-c97acce7756e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("adf51bb9-dbf6-4040-b82b-5167365248ab"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("b3fa7c31-12b9-4092-908b-c4a10a81f7de"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0044637e-26e9-4e4e-b34e-60785301839d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("011f4a18-55bc-4dc1-b962-e1c736b5be95"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("04453134-eec1-4fe6-90b0-f3fe07b5a9c8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0519d360-3d87-434c-8384-ece9971adb5f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0574d830-83b0-4c52-8464-9141e785b32f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("05d60c33-7e7c-4379-ad33-d93826c3e97a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0fc14c6a-646d-43f5-b00c-d87014ff70d9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("1142d5a8-d638-4a0b-af78-b1287b1936da"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("15446c87-008a-478d-99cb-f32a17c39218"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("15b45918-780d-41d0-8be4-02875b9befa6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("1ab239d5-3d2e-4b7f-a143-660c6e232a72"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("1b84c89f-b02b-4cf7-a403-cd4bb1e31f6e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("1e0f0bd6-b52a-4780-97db-f5915279799d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("1f98c13e-10c7-4412-9ea7-ee04fdfd645d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("26d5c0e6-5967-496c-ab7c-0eb092477c7a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2793fe5e-0723-46c7-8cad-ed151169e612"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("28baa94f-074a-4dba-8173-d9561ac1e5f4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("295ca84a-95a6-44bb-8662-a5349296b333"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2adfbcde-46d0-49e3-9e34-df693fe036fa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("316f494d-9b64-4186-a0b5-df533e142a48"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("3330627d-493b-4d38-9680-462ad3956f30"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("383e638c-3616-435f-83f4-662c3b780709"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("42741e60-4845-4f31-b9b3-0708e394c1cf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("45eeebe5-16a3-487b-99d3-34eb58fe2a0a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("4944b8ea-ab81-4453-b49f-fb9ab505d04d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("4afe959c-4523-4562-8e01-3afcf4384a45"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("517c5bb1-8e43-49e7-8392-3a84bc4a0e6b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("532a6028-187e-4da3-a833-c904fc0e880b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("556abbb8-b3c5-49c7-8972-c45c86114d40"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("56adaa5d-6041-4359-91f8-b1c69295629b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("5d870074-48ca-4ec2-8c4e-4785cca4071a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("6010ad4b-6bb3-4aab-9691-a492b10a2055"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("6051f9f7-1010-403e-85b0-18d71b913b69"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("6104f605-63bd-4f9a-b4e4-b800b2f7c29a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("62ec4e58-7a4e-4a42-be69-2e9a20df3207"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("65e1076b-63d9-4db4-8e4e-bb5870f71585"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("69b6e0b4-278d-4e41-bc4c-0dde5646526d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("6a8c7a70-3e05-42a1-89c9-1939ad9232fd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("6d05a557-b17f-4f95-8f4f-b3d9e9285de0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("6ed9e6ff-a131-45ab-a916-cdb706de0c02"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("6f3251bb-8b33-47ca-b0dd-6de2af9f18e0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("7075efdf-40f4-425b-979f-8a604a9feaed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("783693df-fd34-4dff-8dfe-a121e8403399"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("788f64e4-4109-404d-bbc7-a0a8e2064d8c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("7c372056-e40e-4e17-8ada-5686e0018a23"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("859e29bb-7de6-4d93-85ca-cbd25d0f72a4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("8854b0cf-8d22-4441-b87e-bf4f36819c7c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("88ed3235-e7aa-43b2-aead-117eec18ecab"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("88fb2d99-200d-4f18-8059-a5ce48d64ab0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("8ab7b769-eaf7-44ee-a98c-4ebc436866bf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("8ed8ad62-d6aa-4ddc-8a9c-4aa9e29eeaca"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("926fb879-b51f-4b30-a01d-bbba4abd1d31"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("936b5fa3-d1cf-4129-ad8d-ae92ef6b3269"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("949d80f2-f062-4a7a-9261-d3e84cef91d7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("99c296b0-f772-41bf-a684-16f265f27bb0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("99e5d360-6fb3-4988-b5fa-4615170c1889"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("9bda237b-730d-47c1-8662-bdcb20fa8c63"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("9c33c950-85a0-4a5f-92d9-46ee96bd062e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("a2d6fc51-22d8-4c16-b83c-a26737c9f3a7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("a3de4e85-8fc4-42cb-96b6-0965f7449e10"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("a6a15b9c-f439-4d18-a8cb-b71c7274eab4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ab4036bb-3704-4550-ab80-f8070e25d4a9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b06e7e58-9d6e-4ef2-a9bf-bab18df7789b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b0f77dd2-f473-4d7b-b0db-d45ab8f8e8f5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b446db28-d830-4cbc-abd1-8bc31334ee67"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b9da60d2-579e-4d3a-a1a8-f02524bd8c5d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("bb105a75-0a86-4a27-bffa-d638d03db31b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("bb50fc31-f241-4dd5-af5e-b607daa39ab7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("bc65d441-51f9-422b-8647-c85fa3229336"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("bf96be20-f03b-4cc0-b4e1-35d7dfc23fed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c0b870eb-e3df-4b23-a515-5edcb0c6ac7a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c1e28769-86bd-485c-98bd-9663b30cc7ab"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c3af7d7b-ac0f-494b-b6c2-4b065c335f95"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c49884f9-519f-4cae-b6d4-f3d69917d30d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c8e4f862-996d-41e4-8f81-3340b360b5ac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ca8112c3-885b-48af-b5e7-dfd6b2f435bd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("cb48f747-18e7-41fb-98f7-ddd188456199"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d4a58d36-1568-4283-923a-1c461bd3a51a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d56e24cd-be5a-4037-8eae-250c8ac9f39a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d6769135-4f13-43be-a3a5-62188051413f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d6df5b9a-7896-4b40-b41d-e0b9bc637434"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d955f460-872d-469c-8934-214dc6b34ce0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("daad2231-4fa2-4056-971e-46599c3f7ffa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("dc00e22c-3b1e-42f9-8b46-3ff73141d2f2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("dddad4e1-7445-4120-95ab-609b64f13cb1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("de1efad9-302f-4353-96b3-221c083eb8f7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("dfc5b601-9ff7-4f5a-a4a8-2c46263d8e95"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("e44c648b-20bc-4a96-9f08-e91e1cc2b986"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("e54715af-5a70-4555-bb3d-5c8d2fa00069"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("e7bc23b2-4d1b-46de-88cc-98765f0dbf2e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("e9f374e9-7db1-4918-b592-0e67122b1fb6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ed593aa8-63fe-4b21-9779-0a693d593200"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f50c6caf-9d4e-4cad-9976-438049111e2f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f5fde8c7-9a01-4f3d-be16-2e14ba7301c1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("fe7b2af4-cc31-462f-86bd-dd24c366a3ef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("fe8f8feb-cfcc-4787-bb1a-cab352581737"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("016d7292-5ea0-4d48-832c-c84dfd643693"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("0390ddc0-2fbd-4a53-9666-291e95978cf8"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("05922d2a-e697-45ab-994c-f9f1ebdaaeea"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("0618eaac-3bcc-4305-80f3-ee4b6aac8d7d"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("072f8559-bcb0-49ca-8b5f-f035e7851aed"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("07b1f343-798f-41d1-ba9d-6fd0a796b7c6"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("080f4bc6-984f-46f4-aa99-af97d66d018f"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("09194d4f-2ac5-45df-b0b2-eada36347d8f"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("0e414476-1cff-40aa-96c9-9af22e33a518"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("0e5ebcca-2283-4c9c-bee6-564ec99fb22b"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("1144b8d0-69a2-4d9b-ad7a-89823a31b52e"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("123c42ef-baa0-47d5-8587-3d1ee0f703fc"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("13c10bc1-e71a-40cc-ab7d-f7735f4650f1"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("15590de9-2df5-4cdf-8687-3a8d2aef1c4a"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("1d5f0149-22bb-4b1e-9eda-6121e8b73c9c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("2032a93a-de35-4284-80ce-1f949d53521c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("20d4614a-1d70-4fc0-ac57-5ec3651b2cda"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("250e471b-8c1b-4a62-bc8f-b2c8a4da7bd1"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("2620544b-319a-4961-90eb-cfe56b24673c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("2a9d9a71-6af5-4d0d-9d00-439caad32ac0"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("2aa0d83b-23d6-4ca2-8570-e7099ca66326"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("2aa884b6-fbcc-442a-9f40-1ae8cd1e3aa6"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("2dfcc361-a3bb-427e-a0c5-1b7b813daeef"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("30bc402c-9044-4b0e-bf51-7818412cc85f"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("32394655-8df6-4a59-a6c4-c299673601c8"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("32bf695d-33d9-4b81-a11a-4cb6b5836e82"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("35012c54-9dbe-438f-9e28-8ca7d082080b"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("389ff1ed-8162-43a8-b9fc-f2e33c1f7826"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("3b049fbc-2ab2-45bc-b034-ab13526b155e"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("3daadbc0-8a79-4081-a924-90668780994f"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("3dac13ec-b6db-49db-8114-1cadba59abee"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("41f0e70d-aebf-490d-8a1e-aea595f3d34b"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("43e25b97-83ee-4578-b3d9-510831b2e132"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("47ea981a-6150-4ef9-9ce8-21161b549d5d"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("4b8dea09-3356-499d-93bb-f9d68b272f68"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("4dcceb2f-f7eb-4f5b-9e42-646fd40a94d5"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("50f90950-5836-4a64-b5ad-36ec966dec99"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("52859651-bbc6-432b-bd57-af5c30776549"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("57e3d12c-3513-4252-82c5-5a0dd5fca35c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("58773404-1cdf-4d47-9a8c-37a1dfb8b2b8"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("59e7ae52-f2ee-4e1d-a26d-e761c52f6aa7"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("5cb0683c-5fa6-469c-a362-767f03bacc15"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("5cd49d59-0816-4ccf-9ebf-1221eb34c6e2"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("5ce323e7-24ba-4e58-b563-7e41f1dda11c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("5ea78705-fa2c-4537-a306-258732f0290f"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("5f2a91b6-6308-4de1-b6a6-c4790371cad7"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("639a66d1-d828-4946-b4f3-738998346cb1"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("63b881a3-427a-431b-ac00-6473e09a2c15"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("64c37d30-8b9f-497c-b14c-6d689dfd3731"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("6612f045-4605-4a8d-bc99-3e6d5769dda0"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("682e2ae7-d53d-40d6-a8aa-76a0f1b61071"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("68eb1c68-bf03-48eb-a7c9-d842fd8d760b"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("69e5a628-bcff-4b9e-aacb-da8d58ad27f6"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("6a8fc72b-1cfb-49a7-b83e-e581450fdf4d"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("6afa0964-e314-4528-bfeb-2c990a753bac"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("6c12a0e7-8445-4fd1-91f9-036d08ce91ba"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("6efa683f-380f-47fe-a910-3c20d37ce42a"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("71968ed5-b5de-4540-922c-3e953672f75e"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("730d0583-a5bf-49ae-8138-3d5a66ecef8c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("74a8f517-aa46-409f-8e36-7ac008a54001"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("75af3c01-097b-43b7-8da8-d4e0cb60949a"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("7611645f-5914-46fb-9586-050b903a2b61"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("77e87db5-ddb1-40bf-9a10-62026c51dc09"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("7910ba3a-6699-442c-8dbf-1c90609b77ac"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("7accf910-d848-4cfc-8e44-5449038a57be"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("7c0bb222-d578-45b1-9c90-ceb023a4b6c9"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("7cff4bd4-f4a4-46d2-8013-b1c1e53237c3"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("7d201a29-c29d-4765-8299-1e5983942fd6"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("7d41b428-48c4-4628-a52e-63af9642e2d9"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("7e3f1f07-f1f6-4e9a-88db-9810bd327312"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("802d6487-1a9f-4f48-a27b-9e9c74371157"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("82bbec8e-d77e-4d15-8e14-3bdf0b518840"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("838fd4c7-df34-4c73-9c11-c2bd54c7e5da"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("8661c3fe-f632-461f-a8cf-9aeaf7bd92c4"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("8704b82d-b782-4d0b-a445-cebb96ca398d"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("8986ec52-d431-4ab0-b278-b0176e2b2c65"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("8a9abdf3-1bea-4912-b4cb-eaa832256fc0"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("8ad01a9b-c030-4ba2-a57f-0dd8143437e4"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("8d340a44-73e0-49ed-bad2-35f3e95d8e13"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("91787711-e213-4ade-ba54-d1878418a09a"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("933bb4ed-8b18-4b4d-837a-2cce2d0f0e38"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("93d176c3-c92b-415a-a371-ca64f5ebce37"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("93db5beb-5332-4726-9a4d-4a1f5f91b3ef"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("93e06c58-37c8-4c62-8820-bea75d82f4a0"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("940db7ff-20b1-4579-bbc8-3a78bab24dfe"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("946a78a7-6cd0-4f88-a1e3-48dd60382c40"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("970bfae7-24bd-4fee-9700-fcf0bd9e964d"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("9795328b-7dec-416a-9bb0-82bbd3646bb2"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("980fe5ef-4c10-4727-b9ca-f9e96f049812"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("982a63df-52ec-4698-805b-f4eb2dd20169"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("9bd5aada-f2b6-49ec-98cf-b8003df280f7"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("9c9bb019-b43a-4b83-b949-6ef1088b50a0"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("9d256b56-393a-4080-83ff-1af530b68ea9"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("9e4cc526-3066-488e-9b4f-315b36f9dfa7"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a0888590-ac50-459b-9cdf-ee77d0a9745a"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a26a5b71-b500-416d-a2fb-4ead48ffe7f3"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a33f50c9-3853-464f-9a5e-01dbfe193002"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a464bf29-c6ca-4eff-93c5-a34e351bc562"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a47edab7-3dda-402a-9bcf-a1ddcd722e5e"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a6f82a75-ad33-46a2-9637-646bd7bda1be"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("a8080c1f-143e-4713-a6ce-2df0a21558ae"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("ac2b6e03-9fd9-4560-a082-0c3576943878"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("ac86c839-37bc-4796-8820-88c7f7834f3e"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("aeaa33fd-d813-4a85-9f11-359efa7d5814"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("aed80b5c-b87b-44bb-aa5a-a2bf3bfa0d17"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("b1372b20-aac2-4036-9a85-b187aa92821f"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("b4228ae0-3cef-43f3-8c22-9f6449f72e3b"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("b847eccf-3ac1-4b29-9b9d-14910bae3cfb"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("bbc9a30c-63bc-457b-a3d6-eedf5880054d"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("bd5ba1a5-bece-4371-8096-758b060c2b3c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("bdb5a037-b54b-4ef4-8c06-3767dc69c611"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("bdbdf3c7-54fd-4246-8950-ab6be95e633c"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("be46ebdd-0da0-467d-a7cf-a8ff2b5efc15"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("be4e436f-662a-4462-b20d-3d4be3401042"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c10ccee5-d3cb-4efa-b849-7684985945ec"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c346ee44-0e0d-457b-a467-4ce8c7b0fb8e"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c47e20e2-be05-498b-9520-61a860186466"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c604f10b-61b9-4201-8728-f9819f79c144"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c6d6b06b-8cf4-461c-bf3d-2ccd2e4b9b4a"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c850198e-4471-4365-90e9-4cc9ab81e40f"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c93be422-05f1-48b8-b195-2a17c825faf0"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("c95a2d59-0584-4c48-bebc-691276876563"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("cc1a92a2-576e-42e1-b68a-aef06fed727f"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("cfb61a49-e71e-45b9-a6fb-d9989f82a9fb"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("d1c42748-8c93-4070-8ab4-8fb08143a7b7"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("d317ca52-1c20-4857-a35f-894cdd679f13"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("d4586381-87bd-47e1-861a-ffdee79600c1"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("d4bfe2ba-facf-45fe-a0b4-40fa7d1daaf6"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("d62a625a-62d6-494b-b65a-2b51627fa6c1"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("d6b959e2-0c30-409f-b865-2e95ed3df171"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("da1d797b-d2de-4f36-9f5b-423a56d95ead"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("da6101ae-05f7-4973-a94f-939f273a94a1"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("df4ebbfd-cd82-43a2-ba58-21231bc431cc"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("e0e84abb-ff48-409a-b92d-9d208168161d"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("e64e0e6a-c7d1-4f86-9676-cc5ac689eb7b"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("e6a00563-075e-432f-87e5-246fe5aabedd"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("ed18a280-6cfa-47c2-8757-40483fdfa654"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("ef98dcf5-45ad-47b8-958c-be19a9ea4a4f"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("efb17b72-d95f-4c2b-8015-ea16778334a1"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("f36f9005-f207-4df6-9f99-0131c795f29f"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("f45c06ea-c484-49cf-bee8-77d92ab3fda6"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("f489fb99-17e5-4c55-936d-7d5b963757cd"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("f4bbb70e-1ceb-42c3-98a5-b2581c80ebdd"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("f8116b94-6b01-44bf-938e-1dee1d2bdf41"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("f9198fb9-d5db-49b0-a37a-2046c56d37d6"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("fb2a2915-2c7b-409c-8fb6-c5e6c37d1ae8"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("fc4f1846-bcf6-4d21-9539-36b4f8666ba6"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("fc9bdd22-2a6b-472a-85ec-e15e27789610"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("fcb14572-3173-4a4c-a757-eb3dfcf4d448"));

            migrationBuilder.DeleteData(
                table: "BooksCategories",
                keyColumn: "ID",
                keyValue: new Guid("fe37e7a5-1577-48dd-b785-17057b1b9f17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("0ddd25d5-959f-4cef-abb7-7cea490a5f95"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("7caa2882-4f82-415b-b2a9-ca90cbdcf889"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("90486ec3-28e3-45d7-8cb7-98824f23eb1c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("eda506b9-318f-4084-9ae2-897d84dec076"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("2eda534d-2129-41c1-a75e-9ecabd9237c6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("359525c7-4640-4805-ba56-7733d5bfe825"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("570485de-66aa-4c14-af7b-d16b04c4482d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("76d06899-cfb2-4a95-9718-12800f36d1e6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("e81e2108-4d79-4e3f-b105-4bc286ef5a1e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("ecccf595-4430-4569-bddd-59eb3ed1d07e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("009da4da-b590-4b46-8d38-e05f70e96be4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("01614b9a-18a0-456e-b453-4cdaece6861c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("01db5738-41e5-4635-9ee0-f98f044358af"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("03d8b1f0-0038-47f3-a93a-cd9e3a964668"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0518a7da-6714-42dd-82b2-3d0eb848027f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("06799635-cfa4-4aa8-877a-51272a5641b5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("083935c5-1177-478c-baf1-18beb096799a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0a9f76b3-b4eb-4988-acb2-29a40734b90d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0ab2d3c2-df76-48ea-8c8c-b22c4f6b1676"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0d539f3c-3e32-4add-b7a5-90a85bd72be7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("0da710f0-522b-4b16-9644-b9164ba168d5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("11e21c96-3c27-4531-88f5-2c3f95cf8e6c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("142fcf67-5229-43e7-af5d-5002516c963c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("1729c8d7-0f1d-4ff8-9d6e-b563d4838bdb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("175071e2-c74e-4fc4-9b14-d8119e7d4c32"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("1a835623-8895-4a8b-a61a-57f4fd756be4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2015b0b3-7f9f-4dc1-90b5-f2b9added7ba"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("20d29621-f50c-4dbe-8840-65a8af4bbfda"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("217d5d21-c070-446f-9002-6f8a1aa48939"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("21907147-3215-48d8-99c8-4ae251c35749"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("23f2ff19-3b2d-4907-8cad-6da99a71ff4f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2cca9a2d-01ca-4e3c-80d4-99541c62e330"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("2ea785fd-42b4-4787-9eb5-a6d050ed9a49"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("30fff4ad-9a5f-4764-b67a-9f80813fd41e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("3212e312-08c2-4be2-b6cc-9101fe8b3cb6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("33b3433b-02b1-4c3b-89f6-890f9fe50e1b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("33d80ba0-a88f-4609-aac4-bafca56f204f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("36631ae1-f552-4aae-a6a7-dc2e5b0b5567"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("3687def0-5ea3-4732-8d47-25606f90a726"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("36baf1e0-8c72-4a34-adea-af42cffcc482"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("37091e8e-b35e-45bb-8f95-6f52713ef8f7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("375a5c60-a3cc-437d-bf08-bc63faf6022e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("3fcc7259-ebf1-4b22-a704-2c4d2b51e24e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("41bc0619-8e68-406a-bd64-a1a07631a3a9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("439432fe-8cbe-4a31-83e4-9c0c792aa189"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("452a937a-e28a-44a4-8aef-773d1e6601be"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("4aae659b-3aa3-49d3-9939-4b20ba96459e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("4d324351-8d0e-4bb9-a5bf-198b8e8e97ff"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("4ec7d2a3-01fb-446d-b14e-86cf6969f110"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("4f09b4f7-b500-413c-940f-c43bd99b32be"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("4f2c6d8c-2b09-4954-8cc0-04f87ac38668"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("52a7d9c9-a148-4f80-afe4-4e7e00dbd32f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("536df0b7-9778-4b63-8e0b-9cdf99566abc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("559f004f-7d59-4efc-a120-425bd3531d67"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("573e37dc-ac9b-43ad-8fdd-64c650cb6135"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("57ab244e-5f9e-4d45-974e-58866a9beb12"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("5b9a87c2-3120-4961-9f65-f82d357b161c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("5fbe6f53-9fc0-4af8-a6c4-2cf14fd132ce"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("609d74a5-10e0-4bc3-ac07-640755ef2d1c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("61132708-e2f1-4ee4-b682-80d61bdcd490"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("61e061f1-2611-444c-926b-8216adab1559"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("636687d2-52f1-459f-b801-88bf2f6a1baa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("66dcc28c-0bf6-4ff1-a9f3-e7a0170e309b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("672db99c-f5e1-4b30-8705-5b9186ab208f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("67db66b0-7bdf-4d3b-9ecc-558bd7a75b76"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("6849d389-ee10-4b7f-a082-fe262b01a2c4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("6f6aa030-a68e-4815-9817-612c9995776a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("708967e1-29d4-48a9-84f8-29b7abbe494a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("7451dc9f-6dc9-4659-9d1f-bb1527115246"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("79a2ad9e-d453-4093-8152-6d95d59f33d6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("7a9e0b9a-bd15-4fd5-93a3-89f8121c5546"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("7c8bc50b-d71e-4e3c-9686-3c6468b7cb83"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("8156c3a6-9608-4586-a495-4cbfd1927724"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("83a6b74d-3783-4287-a039-46358d8bbd51"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("8460aa96-7a0b-41a9-863d-8d9caf2e49a3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("84d93dfe-1905-447f-847a-784c6efc6eb9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("8ad38a97-b1b5-4bb6-893d-c61c4588300e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("8cd80fb8-9795-48e1-a253-4be9d4e0c1ae"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("93a5872d-b9ff-40cf-8d8a-25942a19c57d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("95badf0f-31dc-4b7c-afe5-549b7108f307"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("968f1c8b-4f28-456b-be3e-5466c935a9cf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("97ba17b3-a61f-4ce2-a72e-dffbc4d28e66"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("99675fff-d707-4133-9e3a-d33a7e50709a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("9af750f8-55bf-4050-9eb3-d0f8142eb01b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("9cda9c7b-f223-4fdf-af20-c18f8e63fc76"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("9fa74d77-df93-492a-9414-ce1ce84520f1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("a3c70461-f27e-4d11-806b-c98b62f8b651"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("a9269dfb-9f3e-49c7-a71f-d3fbe00184a9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b29cd53d-ff7c-40c6-91ee-bffe979ce2ca"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b315b941-de1e-4152-bbc7-3376e4063b1c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("b85c8d06-4c6d-4e7d-a96a-42ebc1a45b82"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ba0fc35c-80ce-4f6c-b6ac-1a3f6257d8fb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c282b1bf-fd37-44f5-a5a9-fbb52e770f58"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c845ba4c-9cbb-47d6-a623-dfc636c36fbe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("c8f306a7-2516-43b7-9816-3787fb99901b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ca854e29-3b98-45a4-a23d-f9ca582c7e46"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("cc31dc5c-6c09-40cf-b5bc-d97b95de93b0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d2b2062e-4b6c-4a79-921b-e3bba8316cfe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d64e69c2-7766-486c-b8bd-1e278c39a9b2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d8cef5dd-5002-44e8-9566-5e5cb32df90d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d95def22-014e-4f2b-a255-a46114db6143"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d9a5bda1-0cde-429a-969e-06e14e25f477"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("d9c9bd55-d64b-44de-a49c-8611dfe77595"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("dcb128c3-81af-4757-996a-acb597962c30"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("dd2da866-1c70-4395-99c9-98703d5419b9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("e3af5a64-7115-4aa9-bc3e-924341141780"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("e657f57f-59e4-4e05-8047-b0d93fb0427d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("ebb962e2-a526-4879-8d1d-d6a9a356179e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("edde274f-f1cc-453f-a09f-38f475878892"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f32f8221-199c-4b55-83a5-fc3f90341263"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f3e8808e-27c9-4499-bf3c-ca18e92e03d2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f6aaa741-1743-432e-9b77-8a88959cfe0c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f8029739-5ca1-4eb0-957c-e634cb4f2318"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ID",
                keyValue: new Guid("f8baac52-4762-4b81-8252-b10b117b0761"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("003b12d7-d5e1-47fb-bcc2-19c8880448ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("0992565e-52a3-4143-b4c0-1fc29adb0825"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("104b63ec-1103-4b64-9665-f919e7139efc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("131152c5-88c1-4e4c-8f13-3b8006018a0c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("1b57e35a-c0f5-4c8c-a8fd-3d735507291d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("1e822901-32ea-4f2a-b051-ae23ddb1b8f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("200d2f07-a903-4d2f-a48f-c91c5b94f417"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("26f54e6c-b868-405b-bf06-35daf0a494ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("28f113e5-e9e0-4b57-b798-f227c0ac3987"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("3751a36f-8c48-4d61-a033-1f2c60f70b89"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("405e3f64-5abc-4753-be5b-77c7a880fc60"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("41065de1-75c8-4a9b-9231-3d48f9f7db4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("4fa81b78-d716-41a3-a5d5-6d2a99bcbb71"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("6168a226-9a80-4862-a22e-8526d4cf7afe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("63766c80-b097-48d2-8612-cc6087f3df23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("6d7f60f6-e4ba-41a1-869d-1cdb03ee4d41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("710d83bf-82dc-4b89-9c53-4876a49a720c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("715898e4-4eb7-4b3f-b22d-5e6750e38f8e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("7661ba0b-bdb9-4efd-a009-5f37aa5c8801"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("781962bb-269f-4bc5-af85-3f1a9043a006"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("7b0b01ac-7206-4af7-9024-d9881ee0cd87"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("87b17700-5c38-4eda-acf5-8ead729cddf2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("94252978-44b4-4c0b-83bd-23ebc0a543c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("967e66b3-ed8d-4478-95a1-89606eaa9717"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("98076a64-f35f-44d5-8433-6a882046f134"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("99cc61e2-a465-4aa9-80d3-782088f99f86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("9f58f57b-d9fd-4c8b-bfe5-1ec55ed3bcc9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("9fae6a0d-b9ac-4692-b0c4-2f98108b66e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("a1b2557c-b811-4d4b-bd55-2eabb9b01f2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("a7ab7720-fef8-4987-a56a-499a2d50e573"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("b14c1a71-1add-4fe0-8cf7-fe470f21ba63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("b51fd10f-09a1-433d-b08f-e8488d322818"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("bbfe1d7f-6fbd-46ae-9c0a-7b73927c84ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("bdfe3804-0dca-4cb6-a37c-ed5366769e22"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("c07024db-a9ba-40e4-8781-c619d72e8eef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("c1d330ad-819c-4622-9e8b-9c2098fddd75"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("c34aa2ee-f087-4ec0-a580-b101ac6b74c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("cea3ec76-e9c0-456a-be54-2d416b0d44ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("dce233b7-8767-431b-aee1-42b050ff96c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("de0c159f-44ce-4555-89af-f398a15295ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("e8aedad4-b02e-4d80-bca1-1b0560848bce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("ecf20367-1ed3-46b6-85e1-cc028f4d842a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("edd7e8bf-f3fd-4cfc-9652-38eb6f8f5b22"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("f16d6878-d203-4fbd-ad28-003a33929f56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("f3b47a28-589d-4bdf-9b4f-e978f991bb86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: new Guid("f90b083d-a4f6-4034-b84f-875b30d1413b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("00928cb2-85df-4ef6-936c-b472b08a5b25"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("03bd8fff-a187-4221-add8-8ef5a1f2a812"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("04f85738-2b5e-49c0-99d3-75fb56d43b65"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("0986a770-5c7e-4174-ae7e-a51f766125ff"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("0ae56f23-dbc4-4328-bd37-7f1d368e13d5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("0bf1d7b8-5519-4189-aa4e-b05d3f15e023"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("0c233fb2-4c9c-49f8-b0db-b24f41b8a6f8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("0c49b46e-dbbe-4ab8-a534-453dc978e05b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("0cde1a77-cd18-4050-8ac4-d6876130d0bb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("0e779553-638b-4c1c-b603-d345a2bcb7ee"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("11c7d492-c74e-4b89-a188-d81d276d668e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("1a5cdc9a-87a4-4857-a0b9-6320e4bb416c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("295d4de8-6461-404e-b30e-63a5e924b0eb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("39dd1203-928b-40ae-a55a-f3daa9f463ae"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("3ef679f4-7f15-466a-af52-d9497bb48f4a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("49c4c0c9-e91b-4cf5-90d2-fc3bbef3a9f6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("49eb8cea-5f30-448c-a7b7-2ac55e2b9ab2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("4cabe2e7-41a9-4d29-b3e5-fea41737b8bc"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("4f6b6b17-2277-4dbe-b377-873878974d05"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("569d2cee-4715-4a2c-8cb0-e99f8596180c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("596ce2c7-1adf-41f4-88fc-a3a42d04c9a3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("645311ea-aa9d-4cae-b93f-498ed2d1096f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("6723c5a7-dec1-4637-bacc-1cc50e07cf30"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("69d0cb4b-4544-42c8-8c5f-1ad4d96e8a23"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("6c0f492f-81f0-4187-bfba-6fb4e159a67b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("6cc7736f-9d5f-49de-a246-b6824902e1ea"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("7563f48f-fe9f-4f5f-b9e3-db3401605773"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("76243127-6c70-4fa8-81a6-a01a27ff8f9b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("77f044e8-8a3c-4be7-b927-d894468b2693"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("7973bf28-20a5-4d56-9101-3ababb74178f"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("7ac18a11-b1d9-42b9-bb81-19a83aafd5bf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("7c2c7cf7-138c-45a9-92f1-39c1cfd1a5e5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("7de6f4ed-9e9c-4718-9839-b3e8de8428bf"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("7ebae05a-e45e-4aa6-847d-f26e8330053c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("81f674cf-da03-4593-881e-d4eb7fb2bec1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("859dc25b-d52f-4fae-9db5-1e2018d8f139"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("8cea83b8-56d0-4f1d-9853-fbbc83bc77c6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("90532c0f-4a8e-41b8-a4df-1bba53edd1f1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("91f80af1-00b9-47ad-9780-a236d3e0f1a3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("92c55e3e-c44a-470b-9628-9ffa24236459"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("9329bb4b-7626-4091-be5d-d46d5f7ed3d1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("9f165e0a-f59d-45f4-a9d2-bc7845d5e097"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("a2894ab4-3454-4114-b889-5013ef80cacb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("a50e9cd6-e1b6-44cd-9dd2-50530ab00a37"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("a59310cb-532c-4326-905c-7ddeb822dde3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("ad7847c0-45a1-4b18-8744-80995c47683c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("ae0c04c3-436b-4a34-a9e9-e5f90f6a4874"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("b0bf864a-da5b-453d-a830-b189b93b6813"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("b0ebd007-80c6-412b-8301-bf0876f11d3d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("b4ea8a85-9f35-4da0-881c-ce5d4a503997"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("c64ce4c7-a794-420d-b9fa-812befcf9788"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("ca2e16c9-b1b5-448c-baf2-56dfa1595221"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("cae3d1f4-0049-49e0-b439-c18397f390c9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("cf4d319a-fd1f-4f9e-af11-092cd69b31ab"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("d4482cc3-cc41-4014-9b72-dd535f308882"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("d9479b41-a2e2-4d26-aa63-fdc93a659ab1"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("df450115-04cd-48b2-a360-b298981135c7"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("f238d74f-0c49-409d-b4a0-edec9c7311aa"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("f5b4538c-952e-4d7a-aaa6-d55df156f211"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("f62bd7ad-0315-447d-867a-9b79056b3172"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("f83d797b-ee74-46e9-b7af-8d821faa9229"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("fc44d48e-119a-4cd2-86dd-3d14537917f8"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "ID",
                keyValue: new Guid("ff947f18-b883-4062-b4b5-8402df934d01"));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "ID", "CreatedDateTime", "FirstName", "LastName", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("0179a996-12da-4ab9-a061-fc5522682ba0"), new DateTime(2023, 5, 26, 20, 40, 50, 604, DateTimeKind.Local).AddTicks(6099), "Stewart", "Champlin", null },
                    { new Guid("051a76bf-d39e-42b9-abde-e368be575958"), new DateTime(2023, 5, 26, 20, 40, 50, 600, DateTimeKind.Local).AddTicks(6315), "Henry", "Terry", null },
                    { new Guid("066710b3-9460-4e81-a086-42eb03d36f30"), new DateTime(2023, 5, 26, 20, 40, 50, 601, DateTimeKind.Local).AddTicks(6101), "Jay", "Smitham", null },
                    { new Guid("0906c38c-03b5-429c-81fb-48f83537bed2"), new DateTime(2023, 5, 26, 20, 40, 50, 602, DateTimeKind.Local).AddTicks(1991), "Marcos", "Cormier", null },
                    { new Guid("09ad2752-cd81-4b9f-b05a-91b6addbfacd"), new DateTime(2023, 5, 26, 20, 40, 50, 599, DateTimeKind.Local).AddTicks(9533), "Darryl", "King", null },
                    { new Guid("0a027160-afe0-4c41-b60a-b743e7e5384d"), new DateTime(2023, 5, 26, 20, 40, 50, 601, DateTimeKind.Local).AddTicks(2197), "Brandon", "Parker", null },
                    { new Guid("0d263711-2385-4035-9fab-15fb5a644ab7"), new DateTime(2023, 5, 26, 20, 40, 50, 601, DateTimeKind.Local).AddTicks(7569), "Edna", "Moore", null },
                    { new Guid("0fd42dd8-4a25-41e9-b135-522849af300c"), new DateTime(2023, 5, 26, 20, 40, 50, 599, DateTimeKind.Local).AddTicks(4979), "Gene", "Veum", null },
                    { new Guid("108ee869-1851-4290-b3e9-9924afdf3769"), new DateTime(2023, 5, 26, 20, 40, 50, 604, DateTimeKind.Local).AddTicks(8701), "Ida", "Goyette", null },
                    { new Guid("11b31cc2-3df4-43fc-8226-9e5551f48730"), new DateTime(2023, 5, 26, 20, 40, 50, 604, DateTimeKind.Local).AddTicks(7310), "Joyce", "Lynch", null },
                    { new Guid("159f915b-baaa-4f89-996a-6773d02ba278"), new DateTime(2023, 5, 26, 20, 40, 50, 604, DateTimeKind.Local).AddTicks(3400), "Jo", "Rogahn", null },
                    { new Guid("1867ee2b-5953-470e-b2c7-97f8203b5e59"), new DateTime(2023, 5, 26, 20, 40, 50, 600, DateTimeKind.Local).AddTicks(2437), "Bradley", "Rutherford", null },
                    { new Guid("1e0dd338-b92c-42f8-b93b-c83c8b47927a"), new DateTime(2023, 5, 26, 20, 40, 50, 599, DateTimeKind.Local).AddTicks(3283), "Marc", "Haley", null },
                    { new Guid("1ec2d558-a707-4d7e-b326-1bf3eaf779d0"), new DateTime(2023, 5, 26, 20, 40, 50, 603, DateTimeKind.Local).AddTicks(9094), "Wilfred", "Thompson", null },
                    { new Guid("213baca9-217b-4e91-ba0a-d36da2249931"), new DateTime(2023, 5, 26, 20, 40, 50, 601, DateTimeKind.Local).AddTicks(744), "Janis", "Dietrich", null },
                    { new Guid("239abe78-fbbe-4174-8147-52b5bc89b88f"), new DateTime(2023, 5, 26, 20, 40, 50, 601, DateTimeKind.Local).AddTicks(3836), "Jerald", "Boehm", null },
                    { new Guid("24bc6580-7dbb-4db3-9660-cfbf64bafc91"), new DateTime(2023, 5, 26, 20, 40, 50, 599, DateTimeKind.Local).AddTicks(2457), "Terry", "Sporer", null },
                    { new Guid("24fede50-f56f-43f9-95ea-77ef82cadc0b"), new DateTime(2023, 5, 26, 20, 40, 50, 601, DateTimeKind.Local).AddTicks(6879), "Jacob", "Block", null },
                    { new Guid("25f0acab-897a-410b-83a2-af005c31ead9"), new DateTime(2023, 5, 26, 20, 40, 50, 602, DateTimeKind.Local).AddTicks(4262), "Allison", "Dach", null },
                    { new Guid("28de0484-8f41-43e5-9836-a0d74fe78a66"), new DateTime(2023, 5, 26, 20, 40, 50, 600, DateTimeKind.Local).AddTicks(949), "Catherine", "Stiedemann", null },
                    { new Guid("29cd46bd-3f89-4d22-911d-aae5be748d82"), new DateTime(2023, 5, 26, 20, 40, 50, 599, DateTimeKind.Local).AddTicks(8028), "Nichole", "Halvorson", null },
                    { new Guid("2bbe32a1-82fe-4243-8c02-6df149dfcd1a"), new DateTime(2023, 5, 26, 20, 40, 50, 600, DateTimeKind.Local).AddTicks(9273), "Zachary", "Wuckert", null },
                    { new Guid("2f7a09d3-9df6-4dfd-af04-e15c5a8d65e4"), new DateTime(2023, 5, 26, 20, 40, 50, 603, DateTimeKind.Local).AddTicks(360), "Jack", "Ebert", null },
                    { new Guid("328b9cd5-a71a-4f48-877f-229925b3d090"), new DateTime(2023, 5, 26, 20, 40, 50, 602, DateTimeKind.Local).AddTicks(5843), "Miguel", "Torp", null },
                    { new Guid("36a7431f-c62f-44a0-8558-ee3c31d4b09b"), new DateTime(2023, 5, 26, 20, 40, 50, 603, DateTimeKind.Local).AddTicks(4008), "Israel", "Hodkiewicz", null },
                    { new Guid("405e81da-1f0b-498c-8335-0b71e82e8538"), new DateTime(2023, 5, 26, 20, 40, 50, 600, DateTimeKind.Local).AddTicks(225), "Rudolph", "Hilll", null },
                    { new Guid("42607bce-6b81-4389-8835-57c786eecb37"), new DateTime(2023, 5, 26, 20, 40, 50, 603, DateTimeKind.Local).AddTicks(2495), "Brad", "Walker", null },
                    { new Guid("4e5f53d2-34c2-442e-bb19-74f7a3cb4406"), new DateTime(2023, 5, 26, 20, 40, 50, 600, DateTimeKind.Local).AddTicks(4117), "Aaron", "Prohaska", null },
                    { new Guid("505ffe33-5ac9-4b92-82e5-408fe2eff2ee"), new DateTime(2023, 5, 26, 20, 40, 50, 600, DateTimeKind.Local).AddTicks(7788), "Wilbur", "Wilderman", null },
                    { new Guid("50681485-14d9-450d-b2e6-2643d251ab8a"), new DateTime(2023, 5, 26, 20, 40, 50, 604, DateTimeKind.Local).AddTicks(2636), "Stanley", "Harber", null },
                    { new Guid("55868b4d-b7b2-4a30-b83c-3d7239d4cf0f"), new DateTime(2023, 5, 26, 20, 40, 50, 601, DateTimeKind.Local).AddTicks(5271), "Eddie", "Heathcote", null },
                    { new Guid("5a4618c4-1d9b-4754-b694-2f9c47ba107a"), new DateTime(2023, 5, 26, 20, 40, 50, 602, DateTimeKind.Local).AddTicks(9527), "Pete", "Koepp", null },
                    { new Guid("6296317f-55b5-461d-9958-2111e9acca3c"), new DateTime(2023, 5, 26, 20, 40, 50, 600, DateTimeKind.Local).AddTicks(5532), "Susie", "Mohr", null },
                    { new Guid("63bc964d-721d-4c43-ab85-171b770c9c2d"), new DateTime(2023, 5, 26, 20, 40, 50, 603, DateTimeKind.Local).AddTicks(5458), "Pam", "Boehm", null },
                    { new Guid("69123db0-013e-468b-9b0b-a739921dfd2b"), new DateTime(2023, 5, 26, 20, 40, 50, 599, DateTimeKind.Local).AddTicks(5719), "Horace", "Hayes", null },
                    { new Guid("69556c96-0676-411e-a391-e12f060f1f02"), new DateTime(2023, 5, 26, 20, 40, 50, 603, DateTimeKind.Local).AddTicks(6187), "Gabriel", "McCullough", null },
                    { new Guid("6ab3918c-623b-4521-99f2-dde6f0195044"), new DateTime(2023, 5, 26, 20, 40, 50, 601, DateTimeKind.Local).AddTicks(9827), "Dorothy", "Lang", null },
                    { new Guid("6adf5ee7-3b92-4c6c-b924-1c62f5b5ae0e"), new DateTime(2023, 5, 26, 20, 40, 50, 603, DateTimeKind.Local).AddTicks(8331), "Arthur", "Thompson", null },
                    { new Guid("70146ef7-491f-4d55-bbbd-8c83f5255f4a"), new DateTime(2023, 5, 26, 20, 40, 50, 601, DateTimeKind.Local).AddTicks(8317), "Leticia", "Schuster", null },
                    { new Guid("71a1603e-8f57-49a5-be43-22bdc8157264"), new DateTime(2023, 5, 26, 20, 40, 50, 602, DateTimeKind.Local).AddTicks(553), "Joey", "Dach", null },
                    { new Guid("7471b94c-de3a-4622-bd6d-cd5a10111641"), new DateTime(2023, 5, 26, 20, 40, 50, 603, DateTimeKind.Local).AddTicks(9842), "Michele", "Koss", null },
                    { new Guid("753e53da-7278-495c-a264-d76250b07ed9"), new DateTime(2023, 5, 26, 20, 40, 50, 601, DateTimeKind.Local).AddTicks(4525), "Miriam", "Cummings", null },
                    { new Guid("758125a1-855b-42f4-aaf3-53adc00d6fc8"), new DateTime(2023, 5, 26, 20, 40, 50, 601, DateTimeKind.Local).AddTicks(2986), "Jessica", "Rice", null },
                    { new Guid("7718d2e3-69ba-423c-8ba1-796bd0724445"), new DateTime(2023, 5, 26, 20, 40, 50, 603, DateTimeKind.Local).AddTicks(1049), "Marshall", "Schimmel", null },
                    { new Guid("7ebcbe6e-ba17-4672-afb7-413722c0335f"), new DateTime(2023, 5, 26, 20, 40, 50, 600, DateTimeKind.Local).AddTicks(3241), "Stewart", "Cartwright", null },
                    { new Guid("7f0bbe55-4495-4dff-8ce3-e6b3b7b17232"), new DateTime(2023, 5, 26, 20, 40, 50, 602, DateTimeKind.Local).AddTicks(5038), "Marc", "Schultz", null },
                    { new Guid("83a373c4-3acd-494f-949a-d6f3db4c37bd"), new DateTime(2023, 5, 26, 20, 40, 50, 600, DateTimeKind.Local).AddTicks(8537), "Tom", "White", null },
                    { new Guid("8aa5d51c-0cd3-464e-8c45-906de52acb4f"), new DateTime(2023, 5, 26, 20, 40, 50, 602, DateTimeKind.Local).AddTicks(2736), "Nina", "Kris", null },
                    { new Guid("90357598-f0cb-4538-8d0c-56b7202da1e8"), new DateTime(2023, 5, 26, 20, 40, 50, 603, DateTimeKind.Local).AddTicks(4750), "Phil", "Wisozk", null },
                    { new Guid("97d97933-2755-4986-bdc9-ba19d5c7d21f"), new DateTime(2023, 5, 26, 20, 40, 50, 604, DateTimeKind.Local).AddTicks(1975), "Camille", "Tremblay", null },
                    { new Guid("9878d865-2300-4b82-879c-f4d9861202b2"), new DateTime(2023, 5, 26, 20, 40, 50, 604, DateTimeKind.Local).AddTicks(574), "Donnie", "Moen", null },
                    { new Guid("9eb178d7-31ea-4fe6-b28e-8be923833201"), new DateTime(2023, 5, 26, 20, 40, 50, 599, DateTimeKind.Local).AddTicks(7281), "Patty", "Hirthe", null },
                    { new Guid("a013f08b-9974-485a-ba14-7b246db17d9e"), new DateTime(2023, 5, 26, 20, 40, 50, 599, DateTimeKind.Local).AddTicks(6530), "Randall", "Fritsch", null },
                    { new Guid("a3115d9d-c861-4c0c-9afb-0f079908f088"), new DateTime(2023, 5, 26, 20, 40, 50, 600, DateTimeKind.Local).AddTicks(4803), "May", "Crona", null },
                    { new Guid("a8f59154-3dce-4cfd-83d6-b03e23899d4d"), new DateTime(2023, 5, 26, 20, 40, 50, 602, DateTimeKind.Local).AddTicks(8707), "Joan", "Blick", null },
                    { new Guid("ac38031a-defc-4959-bbeb-cbc756dd8cf5"), new DateTime(2023, 5, 26, 20, 40, 50, 602, DateTimeKind.Local).AddTicks(3492), "Erma", "Considine", null },
                    { new Guid("ad5a7d28-9f5a-4a95-8fef-8e10df49e683"), new DateTime(2023, 5, 26, 20, 40, 50, 603, DateTimeKind.Local).AddTicks(7611), "Loretta", "Bogan", null },
                    { new Guid("b4b5fd94-c38d-4f89-bdf0-91b51fa4fb1b"), new DateTime(2023, 5, 26, 20, 40, 50, 600, DateTimeKind.Local).AddTicks(9950), "Sheryl", "Rempel", null },
                    { new Guid("b5e6a311-be2a-403c-b821-d04406aabb25"), new DateTime(2023, 5, 26, 20, 40, 50, 602, DateTimeKind.Local).AddTicks(6526), "Karl", "Lemke", null },
                    { new Guid("baa866f0-cf27-4eb1-9848-fa7333f4114f"), new DateTime(2023, 5, 26, 20, 40, 50, 604, DateTimeKind.Local).AddTicks(4920), "Stacey", "Douglas", null },
                    { new Guid("cad92ffc-845e-4fa7-9ae7-e9c414a0a962"), new DateTime(2023, 5, 26, 20, 40, 50, 604, DateTimeKind.Local).AddTicks(4211), "Christy", "Roob", null },
                    { new Guid("cbb386cf-80b3-4c3c-aee9-d30c20bf9b06"), new DateTime(2023, 5, 26, 20, 40, 50, 602, DateTimeKind.Local).AddTicks(1240), "Ruby", "Baumbach", null },
                    { new Guid("ce4466a1-a40f-4b50-bc0d-745ec4971776"), new DateTime(2023, 5, 26, 20, 40, 50, 603, DateTimeKind.Local).AddTicks(6873), "Jonathon", "Keebler", null },
                    { new Guid("cea363af-7638-4c56-8847-cb1bcf46f0e0"), new DateTime(2023, 5, 26, 20, 40, 50, 601, DateTimeKind.Local).AddTicks(9040), "Jaime", "Nikolaus", null },
                    { new Guid("cfb062ac-b80b-4b4c-8313-0c32c16ac91d"), new DateTime(2023, 5, 26, 20, 40, 50, 599, DateTimeKind.Local).AddTicks(4201), "May", "Muller", null },
                    { new Guid("d7a75598-b77f-41e7-9ed0-71a9651c4e2e"), new DateTime(2023, 5, 26, 20, 40, 50, 600, DateTimeKind.Local).AddTicks(7091), "Jennifer", "Daniel", null },
                    { new Guid("de628d22-27de-4238-b07a-cb076b5cc7d5"), new DateTime(2023, 5, 26, 20, 40, 50, 599, DateTimeKind.Local).AddTicks(8749), "Vickie", "Donnelly", null },
                    { new Guid("e6464331-4865-4d45-9ef8-f744cc45ce0c"), new DateTime(2023, 5, 26, 20, 40, 50, 600, DateTimeKind.Local).AddTicks(1707), "Kendra", "Koch", null },
                    { new Guid("e762be0d-e256-4f6c-b628-bbb1807adb14"), new DateTime(2023, 5, 26, 20, 40, 50, 602, DateTimeKind.Local).AddTicks(7223), "Raul", "Morar", null },
                    { new Guid("e87cb78c-2508-44db-bfc1-fa458be0a03a"), new DateTime(2023, 5, 26, 20, 40, 50, 599, DateTimeKind.Local).AddTicks(628), "Darrel", "Bartell", null },
                    { new Guid("edfe5fee-490d-420e-a77d-32eb99e8e153"), new DateTime(2023, 5, 26, 20, 40, 50, 604, DateTimeKind.Local).AddTicks(1317), "Ed", "Corkery", null },
                    { new Guid("eef15fa8-e309-4135-b7b4-367e6871a0b6"), new DateTime(2023, 5, 26, 20, 40, 50, 603, DateTimeKind.Local).AddTicks(1790), "Christy", "Nicolas", null },
                    { new Guid("f0bdcf19-f0f5-40de-bb2b-b9cc4e566e16"), new DateTime(2023, 5, 26, 20, 40, 50, 602, DateTimeKind.Local).AddTicks(7967), "Olga", "Strosin", null },
                    { new Guid("f431b7e1-fa6d-4098-b256-199ca62be890"), new DateTime(2023, 5, 26, 20, 40, 50, 601, DateTimeKind.Local).AddTicks(1485), "Verna", "Feest", null },
                    { new Guid("fc874fde-341a-48c7-9d81-fd18e8aba820"), new DateTime(2023, 5, 26, 20, 40, 50, 603, DateTimeKind.Local).AddTicks(3220), "Irene", "Schmidt", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedDateTime", "Title", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("07bfc904-0589-4b13-92c8-a336cf07370a"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(425), "HistoricalFiction", null },
                    { new Guid("08b0af99-cbbd-48a0-af1e-2a6364e65a10"), new DateTime(2023, 5, 26, 20, 40, 50, 612, DateTimeKind.Local).AddTicks(9949), "Fantasy", null },
                    { new Guid("0901235a-4929-4001-83f3-4dc6fc4c91b3"), new DateTime(2023, 5, 26, 20, 40, 50, 612, DateTimeKind.Local).AddTicks(9965), "Horror", null },
                    { new Guid("0efa878f-95f0-4ec1-8b55-739869105146"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(222), "Classics", null },
                    { new Guid("191b6c17-50ca-414b-8ce8-f717a7147d82"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(452), "Classics", null },
                    { new Guid("243d2a88-befd-486a-8056-e77c9918556b"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(95), "Classics", null },
                    { new Guid("26c5fc7d-748b-4363-ae79-ae3001ed9c89"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(464), "ActionAndAdventure", null },
                    { new Guid("2b7b655e-2a55-4871-b7ce-9eea7aa8e8bd"), new DateTime(2023, 5, 26, 20, 40, 50, 612, DateTimeKind.Local).AddTicks(9530), "Fantasy", null },
                    { new Guid("2ddf5340-95cd-4b4d-bbb5-513cb5a98978"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(439), "ComicBookGraphicNovel", null },
                    { new Guid("324acb0b-616b-4a90-92fa-a1af1a4fda44"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(159), "ComicBookGraphicNovel", null },
                    { new Guid("32f84807-bac5-40ca-9304-9296f8498555"), new DateTime(2023, 5, 26, 20, 40, 50, 612, DateTimeKind.Local).AddTicks(9979), "Classics", null },
                    { new Guid("3dda5049-d3da-4d81-a755-bc51c96a4296"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(375), "Classics", null },
                    { new Guid("4340af6f-b3ae-44cc-a751-41ffc606bafc"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(172), "DetectiveAndMystery", null },
                    { new Guid("4627831d-bab8-43da-b895-2763db534c22"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(350), "LiteraryFiction", null },
                    { new Guid("474be3f3-8c47-4b39-909e-945aed13b954"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(262), "ComicBookGraphicNovel", null },
                    { new Guid("4b877a03-2cbe-4867-a3b7-47947d8d1a69"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(209), "LiteraryFiction", null },
                    { new Guid("4e41098f-93ec-4b13-9ffa-dfcbdfa9a14c"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(387), "DetectiveAndMystery", null },
                    { new Guid("55721b5d-fb9c-4f51-8a4d-f89b229e15f6"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(602), "HistoricalFiction", null },
                    { new Guid("58c651bf-d232-488c-bdd7-e00f6d782709"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(551), "LiteraryFiction", null },
                    { new Guid("5aa5aefd-8799-4758-a1de-f674f09d120f"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(501), "LiteraryFiction", null },
                    { new Guid("6af3aa61-e3d8-4a30-b714-6f42c8907f9f"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(578), "DetectiveAndMystery", null },
                    { new Guid("6b86c90c-c9e4-441b-867e-dca5d8970979"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(82), "ActionAndAdventure", null },
                    { new Guid("6e8d70d5-1701-459d-b972-c968f01e6982"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(400), "ActionAndAdventure", null },
                    { new Guid("7064397d-7d0c-40cc-9ec0-202a2ce149cc"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(147), "Fantasy", null },
                    { new Guid("77095b7b-83d6-41df-a14e-3d4b9672bb85"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(513), "ActionAndAdventure", null },
                    { new Guid("79212cae-4f6c-4ea0-a52a-632bd6615152"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(311), "Fantasy", null },
                    { new Guid("87aa25a6-e526-4db3-b98c-fefdaf6bb4a4"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(134), "DetectiveAndMystery", null },
                    { new Guid("8a72f418-32b4-491a-a785-c794ec863ac3"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(274), "Fantasy", null },
                    { new Guid("8f88c931-ec6f-422e-bb08-baf0f45ebee0"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(299), "Fantasy", null },
                    { new Guid("9a3b5391-1845-4fe6-a2ee-4d4635d57eae"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(31), "Classics", null },
                    { new Guid("a4ddabf8-80f2-427d-9eaf-cca7ce9ba586"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(197), "Fantasy", null },
                    { new Guid("a9404063-aaa8-43d3-8197-0d1b8147c715"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(286), "ComicBookGraphicNovel", null },
                    { new Guid("a9ad3768-aa7e-40de-93c6-7b086609f3d0"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(107), "ActionAndAdventure", null },
                    { new Guid("aa28398f-e35e-4985-a653-b4092068b296"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(526), "Classics", null },
                    { new Guid("acfe15ba-0527-4803-8582-d5dcac37a03b"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(412), "HistoricalFiction", null },
                    { new Guid("b48c3ad9-257b-4521-a410-cfbf8dbf4e2e"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(565), "ComicBookGraphicNovel", null },
                    { new Guid("bba8001d-d7db-49e6-883e-618e1a168421"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(249), "Horror", null },
                    { new Guid("bf5b22ee-95d1-43de-9e12-4c7b546a0ad3"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(69), "HistoricalFiction", null },
                    { new Guid("bfac342a-bef6-4eef-a99f-497f6b577878"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(323), "ComicBookGraphicNovel", null },
                    { new Guid("c0268d5a-82ae-404a-b5c5-1d4e18a453d7"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(44), "Fantasy", null },
                    { new Guid("c1a2ea7b-b45d-45fe-8bf2-0a2cd23849c9"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(590), "Horror", null },
                    { new Guid("c50c3ec8-4cd6-4e0b-b6e3-93d5e34e6c16"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(363), "Classics", null },
                    { new Guid("cd013daf-4c1e-4101-887f-736f48a44de5"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(4), "Fantasy", null },
                    { new Guid("d0dfbe89-5d75-4c4f-86cc-006695e70000"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(338), "Horror", null },
                    { new Guid("d76c463f-7a82-4767-b6c6-e34c0e9a994c"), new DateTime(2023, 5, 26, 20, 40, 50, 612, DateTimeKind.Local).AddTicks(9992), "Horror", null },
                    { new Guid("d8b31e2b-5c27-4a01-8fb3-185e9a159f72"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(184), "ActionAndAdventure", null },
                    { new Guid("e082a350-1045-4ace-9f4d-9f7168271c28"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(236), "LiteraryFiction", null },
                    { new Guid("e4386634-3511-4c82-9856-3881c6ea41ca"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(119), "Fantasy", null },
                    { new Guid("eb0deb9d-cdfc-4ef7-b429-5fab7ea2dc9e"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(538), "DetectiveAndMystery", null },
                    { new Guid("f3f5216b-2862-4489-8c9f-d6183389d31e"), new DateTime(2023, 5, 26, 20, 40, 50, 613, DateTimeKind.Local).AddTicks(56), "ActionAndAdventure", null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "AgeRestriction", "AuthorsID", "Copies", "CreatedDateTime", "Description", "EditionType", "Price", "ReleaseDate", "Title", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("00c932ad-4f84-4a9e-affd-3af56c233df7"), 22, new Guid("e762be0d-e256-4f6c-b628-bbb1807adb14"), 393, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2387), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 0, 729.39m, new DateTime(2023, 11, 7, 21, 40, 40, 294, DateTimeKind.Local).AddTicks(483), "Mouse", null },
                    { new Guid("03778631-6dee-4b50-8b97-7b541be41b35"), 10, new Guid("a013f08b-9974-485a-ba14-7b246db17d9e"), 619, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1167), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, 539.31m, new DateTime(2024, 4, 17, 13, 57, 39, 848, DateTimeKind.Local).AddTicks(7770), "Mouse", null },
                    { new Guid("04065260-91ee-4465-8a13-a9f6787b2feb"), 19, new Guid("70146ef7-491f-4d55-bbbd-8c83f5255f4a"), 780, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7973), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 6, 994.68m, new DateTime(2023, 12, 6, 1, 1, 22, 84, DateTimeKind.Local).AddTicks(7783), "Pants", null },
                    { new Guid("056275e5-7e82-4502-84d2-5bd694d91664"), 25, new Guid("50681485-14d9-450d-b2e6-2643d251ab8a"), 387, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(4765), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, 260.68m, new DateTime(2023, 10, 20, 9, 59, 29, 586, DateTimeKind.Local).AddTicks(2552), "Bacon", null },
                    { new Guid("066a0b51-772a-4da5-a0ec-f72d32fb491e"), 19, new Guid("e762be0d-e256-4f6c-b628-bbb1807adb14"), 224, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2677), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, 671.03m, new DateTime(2023, 12, 26, 23, 24, 19, 536, DateTimeKind.Local).AddTicks(425), "Sausages", null },
                    { new Guid("07d86398-a711-49b4-9ec3-eeeedad78f33"), 24, new Guid("edfe5fee-490d-420e-a77d-32eb99e8e153"), 672, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(3907), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 1, 378.96m, new DateTime(2023, 11, 9, 3, 16, 50, 433, DateTimeKind.Local).AddTicks(6626), "Hat", null },
                    { new Guid("09b39016-0fa7-439d-8c94-0690dabecf7d"), 22, new Guid("50681485-14d9-450d-b2e6-2643d251ab8a"), 545, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1567), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, 523.32m, new DateTime(2024, 3, 15, 18, 0, 3, 228, DateTimeKind.Local).AddTicks(562), "Pizza", null },
                    { new Guid("0aa2e142-8f57-4d4e-8773-b014d18ec9d5"), 14, new Guid("11b31cc2-3df4-43fc-8226-9e5551f48730"), 281, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(34), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, 239.49m, new DateTime(2023, 10, 2, 1, 55, 43, 757, DateTimeKind.Local).AddTicks(6938), "Mouse", null },
                    { new Guid("0b1f65b6-8e83-4c0d-9f0e-e73ac3670b48"), 23, new Guid("328b9cd5-a71a-4f48-877f-229925b3d090"), 824, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7265), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, 913.98m, new DateTime(2024, 2, 5, 17, 13, 29, 491, DateTimeKind.Local).AddTicks(8371), "Fish", null },
                    { new Guid("0d60b3f0-100f-4b8c-84d8-3b5c4e97f86b"), 22, new Guid("0d263711-2385-4035-9fab-15fb5a644ab7"), 934, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9102), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, 753.74m, new DateTime(2024, 3, 13, 7, 7, 45, 404, DateTimeKind.Local).AddTicks(7865), "Ball", null },
                    { new Guid("0e58f760-cd6f-4529-900c-7a72faded70f"), 25, new Guid("71a1603e-8f57-49a5-be43-22bdc8157264"), 270, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8328), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, 655.44m, new DateTime(2023, 7, 6, 22, 7, 50, 295, DateTimeKind.Local).AddTicks(7403), "Table", null },
                    { new Guid("0ea3a09a-cd05-477e-94cf-a68d053edddf"), 13, new Guid("cfb062ac-b80b-4b4c-8313-0c32c16ac91d"), 971, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5850), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 5, 952.11m, new DateTime(2023, 10, 30, 5, 18, 4, 441, DateTimeKind.Local).AddTicks(2565), "Table", null },
                    { new Guid("0ed2d9cf-c7b0-4ddc-aa3c-eddb0c3eddb7"), 24, new Guid("b5e6a311-be2a-403c-b821-d04406aabb25"), 217, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9528), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 5, 922.17m, new DateTime(2023, 6, 28, 22, 53, 43, 634, DateTimeKind.Local).AddTicks(7743), "Sausages", null },
                    { new Guid("103ad585-61d2-4722-8bc9-d6a713d52b6d"), 18, new Guid("e6464331-4865-4d45-9ef8-f744cc45ce0c"), 57, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8586), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 5, 875.06m, new DateTime(2024, 5, 13, 14, 57, 22, 262, DateTimeKind.Local).AddTicks(975), "Tuna", null },
                    { new Guid("10468d37-414b-43b1-8370-105386965d9c"), 13, new Guid("d7a75598-b77f-41e7-9ed0-71a9651c4e2e"), 370, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7423), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, 374.97m, new DateTime(2024, 1, 12, 18, 15, 41, 935, DateTimeKind.Local).AddTicks(2171), "Pizza", null },
                    { new Guid("108cd72b-9307-43c9-9974-c6fb4726ed78"), 13, new Guid("405e81da-1f0b-498c-8335-0b71e82e8538"), 832, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1134), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2, 871.91m, new DateTime(2024, 5, 21, 12, 7, 56, 69, DateTimeKind.Local).AddTicks(231), "Shirt", null },
                    { new Guid("10b8352e-b8d6-4a93-9965-85995888b2b8"), 23, new Guid("b4b5fd94-c38d-4f89-bdf0-91b51fa4fb1b"), 198, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6456), "The Football Is Good For Training And Recreational Purposes", 2, 867.91m, new DateTime(2023, 12, 23, 21, 1, 51, 871, DateTimeKind.Local).AddTicks(132), "Gloves", null },
                    { new Guid("119da433-7534-4299-8446-8883183e0d9c"), 21, new Guid("6ab3918c-623b-4521-99f2-dde6f0195044"), 225, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6081), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, 24.84m, new DateTime(2023, 5, 30, 2, 33, 55, 593, DateTimeKind.Local).AddTicks(505), "Shoes", null },
                    { new Guid("11f211a1-b1d9-46ae-83f4-0f0736bb5973"), 20, new Guid("ce4466a1-a40f-4b50-bc0d-745ec4971776"), 725, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(4462), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, 22.86m, new DateTime(2024, 3, 13, 11, 11, 6, 663, DateTimeKind.Local).AddTicks(4002), "Chips", null },
                    { new Guid("11f8d160-fab5-49cb-abd9-5b3c0098dc80"), 18, new Guid("066710b3-9460-4e81-a086-42eb03d36f30"), 476, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7874), "The Football Is Good For Training And Recreational Purposes", 2, 548.30m, new DateTime(2024, 1, 9, 12, 35, 4, 85, DateTimeKind.Local).AddTicks(4448), "Keyboard", null },
                    { new Guid("12302ee6-f193-478d-9718-95d25aea314c"), 23, new Guid("69123db0-013e-468b-9b0b-a739921dfd2b"), 98, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9426), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, 623.61m, new DateTime(2024, 2, 24, 19, 6, 37, 45, DateTimeKind.Local).AddTicks(2905), "Fish", null },
                    { new Guid("13813308-327a-432d-97e0-16a95af85c33"), 17, new Guid("b4b5fd94-c38d-4f89-bdf0-91b51fa4fb1b"), 427, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6848), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3, 484.10m, new DateTime(2023, 10, 5, 22, 22, 2, 487, DateTimeKind.Local).AddTicks(7222), "Towels", null },
                    { new Guid("18bffbe9-4bdb-4a81-aa1f-301112474607"), 19, new Guid("505ffe33-5ac9-4b92-82e5-408fe2eff2ee"), 524, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7766), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 5, 370.61m, new DateTime(2024, 4, 15, 16, 58, 40, 552, DateTimeKind.Local).AddTicks(3313), "Towels", null },
                    { new Guid("197e7b84-2f69-41dd-8365-030580d2f264"), 19, new Guid("cea363af-7638-4c56-8847-cb1bcf46f0e0"), 819, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8912), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, 286.03m, new DateTime(2023, 12, 20, 22, 50, 30, 811, DateTimeKind.Local).AddTicks(9415), "Shirt", null },
                    { new Guid("1a05140b-6537-42c6-8170-8c63337213ae"), 12, new Guid("cbb386cf-80b3-4c3c-aee9-d30c20bf9b06"), 435, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9299), "The Football Is Good For Training And Recreational Purposes", 6, 432.90m, new DateTime(2024, 2, 6, 8, 3, 13, 39, DateTimeKind.Local).AddTicks(9754), "Bike", null },
                    { new Guid("1c5c9173-d8a0-423c-8f23-4520e4d6eb4f"), 21, new Guid("69123db0-013e-468b-9b0b-a739921dfd2b"), 232, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8040), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, 341.92m, new DateTime(2024, 2, 22, 6, 23, 20, 563, DateTimeKind.Local).AddTicks(4185), "Shoes", null },
                    { new Guid("1ca32809-812d-462b-9290-cef6314d3f53"), 13, new Guid("69556c96-0676-411e-a391-e12f060f1f02"), 268, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5388), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, 198.80m, new DateTime(2024, 1, 25, 2, 44, 59, 728, DateTimeKind.Local).AddTicks(5673), "Tuna", null },
                    { new Guid("1ca97a38-ef2f-494f-b762-dbabc3e0f23d"), 21, new Guid("cfb062ac-b80b-4b4c-8313-0c32c16ac91d"), 618, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8621), "The Football Is Good For Training And Recreational Purposes", 4, 233.87m, new DateTime(2023, 7, 13, 19, 40, 50, 945, DateTimeKind.Local).AddTicks(7029), "Soap", null },
                    { new Guid("1e972521-4439-41e5-a1e5-458592ab91dc"), 18, new Guid("69556c96-0676-411e-a391-e12f060f1f02"), 693, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5559), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, 826.50m, new DateTime(2023, 10, 24, 7, 15, 4, 432, DateTimeKind.Local).AddTicks(1946), "Computer", null },
                    { new Guid("2299cc58-c0e6-433c-a1a4-0d634c8a908c"), 24, new Guid("0a027160-afe0-4c41-b60a-b743e7e5384d"), 912, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1392), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 5, 431.56m, new DateTime(2023, 7, 28, 9, 10, 24, 461, DateTimeKind.Local).AddTicks(6793), "Chicken", null },
                    { new Guid("23486d58-ca9d-4dcb-8943-eb989c3e22f2"), 23, new Guid("6ab3918c-623b-4521-99f2-dde6f0195044"), 931, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6937), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3, 233.44m, new DateTime(2024, 5, 19, 8, 20, 13, 933, DateTimeKind.Local).AddTicks(4222), "Pizza", null },
                    { new Guid("24e8a2a2-bada-454d-85d8-57b99d6bbbcc"), 14, new Guid("97d97933-2755-4986-bdc9-ba19d5c7d21f"), 118, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8007), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5, 531.85m, new DateTime(2024, 2, 3, 21, 1, 12, 112, DateTimeKind.Local).AddTicks(5836), "Mouse", null },
                    { new Guid("25b68fae-d8b5-4ae4-9ebd-58da009246ce"), 10, new Guid("758125a1-855b-42f4-aaf3-53adc00d6fc8"), 428, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(2914), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2, 938.23m, new DateTime(2024, 4, 1, 17, 12, 59, 941, DateTimeKind.Local).AddTicks(7198), "Soap", null },
                    { new Guid("263f4f0e-8040-4674-8d79-cc81133e88f4"), 16, new Guid("eef15fa8-e309-4135-b7b4-367e6871a0b6"), 991, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5920), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4, 405.77m, new DateTime(2024, 4, 13, 22, 3, 38, 47, DateTimeKind.Local).AddTicks(5632), "Shoes", null },
                    { new Guid("2730a781-85cc-4bc0-9f3f-236aa0fe0d47"), 18, new Guid("28de0484-8f41-43e5-9836-a0d74fe78a66"), 508, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8492), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, 441.86m, new DateTime(2024, 5, 6, 7, 46, 2, 382, DateTimeKind.Local).AddTicks(6919), "Hat", null },
                    { new Guid("28949b30-600e-416f-9186-fb802e2325e4"), 15, new Guid("8aa5d51c-0cd3-464e-8c45-906de52acb4f"), 983, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1199), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, 59.17m, new DateTime(2023, 10, 11, 5, 48, 5, 533, DateTimeKind.Local).AddTicks(618), "Towels", null },
                    { new Guid("291a9e51-c0ee-4100-8e5b-a314456a54e7"), 19, new Guid("1867ee2b-5953-470e-b2c7-97f8203b5e59"), 634, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1667), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 6, 46.53m, new DateTime(2024, 4, 16, 12, 44, 48, 7, DateTimeKind.Local).AddTicks(3074), "Towels", null },
                    { new Guid("2a948059-ef59-442b-a320-b0f24e18588f"), 18, new Guid("328b9cd5-a71a-4f48-877f-229925b3d090"), 639, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(3843), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 0, 536.21m, new DateTime(2024, 3, 23, 1, 39, 30, 618, DateTimeKind.Local).AddTicks(5187), "Ball", null },
                    { new Guid("2b6040ff-9a06-40dc-ac0a-00cc18682f03"), 21, new Guid("6296317f-55b5-461d-9958-2111e9acca3c"), 450, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8810), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 1, 781.07m, new DateTime(2023, 9, 12, 9, 23, 9, 95, DateTimeKind.Local).AddTicks(9609), "Car", null },
                    { new Guid("2c6ce7a3-6f78-493b-ba85-acdafbfb8364"), 15, new Guid("753e53da-7278-495c-a264-d76250b07ed9"), 91, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8687), "The Football Is Good For Training And Recreational Purposes", 4, 126.11m, new DateTime(2023, 9, 29, 3, 0, 36, 401, DateTimeKind.Local).AddTicks(5891), "Pants", null },
                    { new Guid("2ed719c1-5d33-4809-b340-005d9b3caaf1"), 15, new Guid("edfe5fee-490d-420e-a77d-32eb99e8e153"), 153, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9070), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 0, 289.96m, new DateTime(2024, 1, 26, 12, 41, 18, 731, DateTimeKind.Local).AddTicks(8200), "Shirt", null },
                    { new Guid("2ee4c8d8-a774-4193-9062-799f96077618"), 19, new Guid("11b31cc2-3df4-43fc-8226-9e5551f48730"), 551, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6620), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 6, 560.15m, new DateTime(2023, 12, 26, 2, 34, 1, 47, DateTimeKind.Local).AddTicks(2440), "Keyboard", null },
                    { new Guid("2f0bfcd9-6f47-4a20-86a6-90e40014ccc6"), 18, new Guid("e6464331-4865-4d45-9ef8-f744cc45ce0c"), 698, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5246), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, 598.89m, new DateTime(2023, 12, 6, 22, 11, 42, 242, DateTimeKind.Local).AddTicks(502), "Fish", null },
                    { new Guid("2f872c93-9bd3-4354-81a5-e93d251f12c0"), 15, new Guid("0179a996-12da-4ab9-a061-fc5522682ba0"), 665, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7698), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 0, 408.41m, new DateTime(2024, 1, 21, 9, 19, 34, 271, DateTimeKind.Local).AddTicks(4543), "Salad", null },
                    { new Guid("30cae8a7-61a6-4efd-b24b-6a46fbce9130"), 17, new Guid("7471b94c-de3a-4622-bd6d-cd5a10111641"), 786, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2354), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4, 203.22m, new DateTime(2023, 9, 11, 13, 32, 20, 336, DateTimeKind.Local).AddTicks(4653), "Hat", null },
                    { new Guid("31ab896f-9857-4048-818a-6224f133907f"), 23, new Guid("edfe5fee-490d-420e-a77d-32eb99e8e153"), 935, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6588), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, 315.46m, new DateTime(2023, 10, 1, 3, 16, 17, 457, DateTimeKind.Local).AddTicks(9557), "Shirt", null },
                    { new Guid("340a30eb-48e8-4ca5-b94c-25c8f3d830aa"), 13, new Guid("9eb178d7-31ea-4fe6-b28e-8be923833201"), 186, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6224), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 0, 60.28m, new DateTime(2024, 3, 3, 17, 40, 27, 369, DateTimeKind.Local).AddTicks(2519), "Chips", null },
                    { new Guid("34cc86bc-d52d-40d4-b090-85c9ccbfd9ed"), 13, new Guid("71a1603e-8f57-49a5-be43-22bdc8157264"), 922, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2232), "The Football Is Good For Training And Recreational Purposes", 4, 928.38m, new DateTime(2023, 6, 28, 10, 47, 12, 495, DateTimeKind.Local).AddTicks(1410), "Shoes", null },
                    { new Guid("360eb8d6-226e-4418-8487-f32050fad936"), 19, new Guid("051a76bf-d39e-42b9-abde-e368be575958"), 156, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(4974), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, 987.13m, new DateTime(2023, 8, 26, 1, 10, 11, 294, DateTimeKind.Local).AddTicks(619), "Car", null },
                    { new Guid("409b82f4-97ce-4eb5-88dc-bbfd30c0cc6f"), 11, new Guid("a8f59154-3dce-4cfd-83d6-b03e23899d4d"), 206, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6971), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3, 190.69m, new DateTime(2023, 8, 16, 14, 21, 54, 325, DateTimeKind.Local).AddTicks(160), "Tuna", null },
                    { new Guid("46cc9f0a-d86c-4742-81f0-a1619c045b19"), 10, new Guid("cad92ffc-845e-4fa7-9ae7-e9c414a0a962"), 381, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5773), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 0, 129.16m, new DateTime(2024, 4, 23, 4, 34, 22, 411, DateTimeKind.Local).AddTicks(9228), "Tuna", null },
                    { new Guid("48358f7b-cf83-4c99-a228-9ad4c4537cf1"), 17, new Guid("051a76bf-d39e-42b9-abde-e368be575958"), 258, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9560), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, 889.90m, new DateTime(2023, 9, 3, 18, 22, 46, 8, DateTimeKind.Local).AddTicks(3743), "Soap", null },
                    { new Guid("48d22703-3da2-49d5-83ec-dc467cda9355"), 24, new Guid("a013f08b-9974-485a-ba14-7b246db17d9e"), 369, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7390), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 4, 889.38m, new DateTime(2024, 2, 18, 10, 11, 35, 359, DateTimeKind.Local).AddTicks(8556), "Computer", null },
                    { new Guid("4bbef38c-0311-403a-a2c7-9f605ac159fd"), 16, new Guid("9eb178d7-31ea-4fe6-b28e-8be923833201"), 624, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(414), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 6, 862.59m, new DateTime(2024, 4, 4, 18, 6, 10, 730, DateTimeKind.Local).AddTicks(2841), "Shirt", null },
                    { new Guid("4c9528be-6f9f-4755-b443-b6ca3c7d817d"), 21, new Guid("a8f59154-3dce-4cfd-83d6-b03e23899d4d"), 724, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6748), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, 812.43m, new DateTime(2024, 5, 19, 22, 44, 45, 358, DateTimeKind.Local).AddTicks(9128), "Tuna", null },
                    { new Guid("4d2fb3da-32e3-4ead-8446-21f0dc1d4aad"), 11, new Guid("55868b4d-b7b2-4a30-b83c-3d7239d4cf0f"), 434, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7037), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, 713.78m, new DateTime(2023, 6, 27, 1, 55, 41, 810, DateTimeKind.Local).AddTicks(439), "Fish", null },
                    { new Guid("4df549a4-9a10-4233-ac08-4b79c85933a4"), 19, new Guid("7471b94c-de3a-4622-bd6d-cd5a10111641"), 304, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7629), "The Football Is Good For Training And Recreational Purposes", 6, 346.02m, new DateTime(2023, 12, 28, 10, 46, 53, 806, DateTimeKind.Local).AddTicks(4078), "Pizza", null },
                    { new Guid("4e3ceb35-e02c-4508-93cd-2182558d298c"), 15, new Guid("71a1603e-8f57-49a5-be43-22bdc8157264"), 111, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6116), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, 563.41m, new DateTime(2023, 8, 14, 1, 20, 10, 421, DateTimeKind.Local).AddTicks(8752), "Car", null },
                    { new Guid("4ed2b14c-a136-4cd7-a35d-cf68c49966bf"), 11, new Guid("0906c38c-03b5-429c-81fb-48f83537bed2"), 473, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6189), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 6, 780.64m, new DateTime(2023, 12, 9, 15, 20, 11, 196, DateTimeKind.Local).AddTicks(311), "Bike", null },
                    { new Guid("5172f43f-ca95-44c1-bbb9-8c9f8168e316"), 19, new Guid("4e5f53d2-34c2-442e-bb19-74f7a3cb4406"), 981, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5317), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, 409.61m, new DateTime(2023, 11, 4, 19, 51, 43, 752, DateTimeKind.Local).AddTicks(7912), "Car", null },
                    { new Guid("51c5c779-21e2-41ac-a18c-68f406237bf4"), 13, new Guid("8aa5d51c-0cd3-464e-8c45-906de52acb4f"), 733, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9037), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, 540.90m, new DateTime(2023, 7, 13, 16, 48, 22, 7, DateTimeKind.Local).AddTicks(3610), "Gloves", null },
                    { new Guid("51fc3130-13a0-448c-a2b5-40b42030972b"), 15, new Guid("0a027160-afe0-4c41-b60a-b743e7e5384d"), 503, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9968), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 0, 884.67m, new DateTime(2023, 8, 8, 9, 2, 58, 437, DateTimeKind.Local).AddTicks(4245), "Fish", null },
                    { new Guid("52b3e668-05de-42dc-934e-7e7fb0b57ac7"), 18, new Guid("36a7431f-c62f-44a0-8558-ee3c31d4b09b"), 490, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2165), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, 46.37m, new DateTime(2023, 11, 9, 5, 20, 17, 257, DateTimeKind.Local).AddTicks(4942), "Gloves", null },
                    { new Guid("5353ef20-1ca6-448c-b2f7-6724147d29fb"), 20, new Guid("83a373c4-3acd-494f-949a-d6f3db4c37bd"), 820, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9935), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, 258.23m, new DateTime(2023, 11, 24, 10, 47, 36, 126, DateTimeKind.Local).AddTicks(4660), "Tuna", null },
                    { new Guid("55b05bd5-6d3b-4576-9b95-9b242e56a7a9"), 13, new Guid("405e81da-1f0b-498c-8335-0b71e82e8538"), 422, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1599), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, 276.41m, new DateTime(2024, 4, 23, 8, 39, 36, 820, DateTimeKind.Local).AddTicks(2348), "Shirt", null },
                    { new Guid("585acfc7-b45d-423b-a88e-34ef19de0ff6"), 20, new Guid("a013f08b-9974-485a-ba14-7b246db17d9e"), 312, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2298), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 3, 451.38m, new DateTime(2024, 1, 20, 22, 58, 45, 403, DateTimeKind.Local).AddTicks(3799), "Soap", null },
                    { new Guid("58714022-2947-4e34-bd52-c547afb59daf"), 17, new Guid("11b31cc2-3df4-43fc-8226-9e5551f48730"), 558, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9705), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 6, 287.00m, new DateTime(2023, 7, 29, 15, 7, 53, 311, DateTimeKind.Local).AddTicks(7245), "Mouse", null },
                    { new Guid("59a1d996-8707-4839-acc7-0e5ccb319959"), 23, new Guid("24fede50-f56f-43f9-95ea-77ef82cadc0b"), 255, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7731), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 0, 562.66m, new DateTime(2024, 2, 18, 9, 40, 10, 440, DateTimeKind.Local).AddTicks(5430), "Mouse", null },
                    { new Guid("5c9ccfe2-a6dc-40f1-9035-c857a1769be6"), 16, new Guid("753e53da-7278-495c-a264-d76250b07ed9"), 570, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9199), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0, 222.63m, new DateTime(2023, 11, 30, 0, 49, 53, 242, DateTimeKind.Local).AddTicks(8925), "Pants", null },
                    { new Guid("5ce9bf91-3f0f-42cb-91fa-48dfaaf5b442"), 13, new Guid("9eb178d7-31ea-4fe6-b28e-8be923833201"), 989, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2805), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3, 449.77m, new DateTime(2023, 11, 21, 18, 19, 50, 226, DateTimeKind.Local).AddTicks(2581), "Towels", null },
                    { new Guid("5e4069e5-e978-442d-b124-53c833cb76cd"), 23, new Guid("e6464331-4865-4d45-9ef8-f744cc45ce0c"), 467, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2017), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 6, 907.80m, new DateTime(2023, 7, 21, 8, 34, 55, 481, DateTimeKind.Local).AddTicks(4599), "Bike", null },
                    { new Guid("629f5880-651a-4b4a-9d12-09c814757928"), 14, new Guid("cad92ffc-845e-4fa7-9ae7-e9c414a0a962"), 688, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2577), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0, 661.36m, new DateTime(2024, 4, 27, 3, 31, 20, 716, DateTimeKind.Local).AddTicks(4607), "Pizza", null },
                    { new Guid("64e61c2c-06a9-485f-80b9-f0ef2ee44597"), 20, new Guid("7ebcbe6e-ba17-4672-afb7-413722c0335f"), 544, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1318), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, 597.88m, new DateTime(2024, 4, 11, 4, 56, 33, 411, DateTimeKind.Local).AddTicks(9654), "Shirt", null },
                    { new Guid("677e0b2e-36ff-4da0-aa6b-07cfae1e12c4"), 25, new Guid("b5e6a311-be2a-403c-b821-d04406aabb25"), 763, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7003), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 4, 666.38m, new DateTime(2023, 6, 28, 5, 34, 13, 157, DateTimeKind.Local).AddTicks(6940), "Chicken", null },
                    { new Guid("689f136b-5f2c-4cd4-8d15-9416a16e9f35"), 18, new Guid("7471b94c-de3a-4622-bd6d-cd5a10111641"), 646, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2520), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, 239.49m, new DateTime(2023, 7, 18, 7, 48, 39, 217, DateTimeKind.Local).AddTicks(6), "Ball", null },
                    { new Guid("69433bf0-fc4a-471f-b1d7-268a131e3ad4"), 23, new Guid("0d263711-2385-4035-9fab-15fb5a644ab7"), 361, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2487), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 4, 873.14m, new DateTime(2024, 2, 17, 1, 31, 36, 867, DateTimeKind.Local).AddTicks(354), "Cheese", null },
                    { new Guid("69933e81-2ea8-48dd-b07e-a0951045fb99"), 23, new Guid("e6464331-4865-4d45-9ef8-f744cc45ce0c"), 584, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(4405), "The Football Is Good For Training And Recreational Purposes", 4, 968.04m, new DateTime(2024, 2, 6, 12, 44, 4, 223, DateTimeKind.Local).AddTicks(195), "Pants", null },
                    { new Guid("69f663e8-f1c1-41e0-a1f2-1fa66b3a2c31"), 13, new Guid("753e53da-7278-495c-a264-d76250b07ed9"), 842, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2709), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, 694.07m, new DateTime(2023, 6, 10, 6, 30, 31, 529, DateTimeKind.Local).AddTicks(5326), "Sausages", null },
                    { new Guid("6c0f98a4-4fde-4c31-b0a6-f96a4edb88dc"), 25, new Guid("29cd46bd-3f89-4d22-911d-aae5be748d82"), 747, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7198), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, 396.82m, new DateTime(2024, 2, 20, 7, 13, 13, 188, DateTimeKind.Local).AddTicks(2644), "Soap", null },
                    { new Guid("6d42e309-ad7a-4659-bc5b-2da1eee45e67"), 22, new Guid("edfe5fee-490d-420e-a77d-32eb99e8e153"), 781, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9493), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, 394.86m, new DateTime(2024, 1, 23, 22, 9, 48, 478, DateTimeKind.Local).AddTicks(5790), "Shoes", null },
                    { new Guid("703bbfdf-c2ee-4706-9c44-c2b418d78315"), 25, new Guid("25f0acab-897a-410b-83a2-af005c31ead9"), 36, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7297), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, 404.40m, new DateTime(2023, 11, 5, 2, 24, 25, 577, DateTimeKind.Local).AddTicks(8063), "Table", null },
                    { new Guid("70af0855-0be2-4778-bccc-45d55efc0cfb"), 22, new Guid("159f915b-baaa-4f89-996a-6773d02ba278"), 588, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1359), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 6, 466.88m, new DateTime(2024, 3, 4, 19, 31, 14, 988, DateTimeKind.Local).AddTicks(183), "Soap", null },
                    { new Guid("71edd655-80ee-4680-975f-5b03734c48c8"), 18, new Guid("baa866f0-cf27-4eb1-9848-fa7333f4114f"), 970, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9837), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, 338.37m, new DateTime(2023, 7, 7, 1, 19, 6, 266, DateTimeKind.Local).AddTicks(5715), "Salad", null },
                    { new Guid("72e1c8b6-b5e1-48bc-b8bf-c50fd04f73b2"), 21, new Guid("051a76bf-d39e-42b9-abde-e368be575958"), 32, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5283), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, 977.58m, new DateTime(2024, 3, 17, 4, 15, 9, 846, DateTimeKind.Local).AddTicks(5863), "Pants", null },
                    { new Guid("7341f100-eadf-43ab-9494-465c8230493c"), 13, new Guid("ad5a7d28-9f5a-4a95-8fef-8e10df49e683"), 846, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2454), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 6, 772.66m, new DateTime(2024, 3, 24, 20, 19, 6, 711, DateTimeKind.Local).AddTicks(2581), "Cheese", null },
                    { new Guid("73eb5892-47e9-44e9-9fec-50ba9251e778"), 17, new Guid("2f7a09d3-9df6-4dfd-af04-e15c5a8d65e4"), 333, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2771), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, 102.14m, new DateTime(2023, 6, 16, 2, 48, 7, 903, DateTimeKind.Local).AddTicks(6105), "Bacon", null },
                    { new Guid("7631ddc8-33e9-4990-985b-d0b45867c041"), 20, new Guid("2bbe32a1-82fe-4243-8c02-6df149dfcd1a"), 708, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5524), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, 631.82m, new DateTime(2024, 5, 14, 11, 56, 4, 980, DateTimeKind.Local).AddTicks(6259), "Chair", null },
                    { new Guid("764f1709-a2c6-466e-b066-2684ad125ea2"), 25, new Guid("d7a75598-b77f-41e7-9ed0-71a9651c4e2e"), 564, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1501), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, 731.45m, new DateTime(2023, 7, 15, 16, 0, 6, 415, DateTimeKind.Local).AddTicks(1753), "Computer", null },
                    { new Guid("795765f5-155e-4061-9597-ea4fd8e8fe92"), 25, new Guid("5a4618c4-1d9b-4754-b694-2f9c47ba107a"), 946, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(874), "The Football Is Good For Training And Recreational Purposes", 2, 963.41m, new DateTime(2023, 9, 14, 3, 18, 20, 417, DateTimeKind.Local).AddTicks(5563), "Cheese", null },
                    { new Guid("7b0f7691-ca17-4900-a292-7c17a6057a77"), 11, new Guid("328b9cd5-a71a-4f48-877f-229925b3d090"), 706, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5591), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, 813.72m, new DateTime(2024, 1, 24, 23, 28, 42, 112, DateTimeKind.Local).AddTicks(9259), "Chair", null },
                    { new Guid("7b70d60d-1ce6-4d24-8e8c-b74a1a9a754f"), 14, new Guid("9eb178d7-31ea-4fe6-b28e-8be923833201"), 817, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8199), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, 713.57m, new DateTime(2023, 10, 26, 17, 38, 24, 199, DateTimeKind.Local).AddTicks(3120), "Fish", null },
                    { new Guid("7c4b3bb6-ebe7-4989-8dfc-2c5c02b55c7f"), 10, new Guid("0a027160-afe0-4c41-b60a-b743e7e5384d"), 727, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5658), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, 317.88m, new DateTime(2023, 7, 16, 7, 59, 7, 923, DateTimeKind.Local).AddTicks(1861), "Chicken", null },
                    { new Guid("7cc8fbac-684e-4170-b2c7-7e3a9d4f8586"), 14, new Guid("2bbe32a1-82fe-4243-8c02-6df149dfcd1a"), 541, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(121), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, 723.35m, new DateTime(2023, 9, 1, 16, 23, 5, 690, DateTimeKind.Local).AddTicks(3249), "Keyboard", null },
                    { new Guid("7e8bf01b-1dd1-4d90-8d64-f26a2e547667"), 12, new Guid("24fede50-f56f-43f9-95ea-77ef82cadc0b"), 435, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(939), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, 688.00m, new DateTime(2023, 9, 16, 2, 31, 35, 440, DateTimeKind.Local).AddTicks(3655), "Mouse", null },
                    { new Guid("80d1832e-1209-46bc-92e7-306b476d8303"), 23, new Guid("2bbe32a1-82fe-4243-8c02-6df149dfcd1a"), 928, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6355), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 6, 271.51m, new DateTime(2023, 9, 6, 0, 34, 19, 755, DateTimeKind.Local).AddTicks(9566), "Shirt", null },
                    { new Guid("823f9bdb-9fc3-46e9-8488-331144370e21"), 17, new Guid("63bc964d-721d-4c43-ab85-171b770c9c2d"), 304, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2265), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 0, 49.05m, new DateTime(2023, 7, 7, 2, 37, 3, 731, DateTimeKind.Local).AddTicks(141), "Shirt", null },
                    { new Guid("839da5ca-9e9b-4543-adae-717c33459aad"), 24, new Guid("edfe5fee-490d-420e-a77d-32eb99e8e153"), 136, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1868), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, 549.22m, new DateTime(2023, 9, 10, 12, 5, 10, 391, DateTimeKind.Local).AddTicks(3123), "Table", null },
                    { new Guid("85f019f7-7433-4924-a283-ce8f67fd35d8"), 11, new Guid("b5e6a311-be2a-403c-b821-d04406aabb25"), 663, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(841), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, 418.19m, new DateTime(2024, 5, 23, 21, 45, 34, 95, DateTimeKind.Local).AddTicks(8767), "Bike", null },
                    { new Guid("86c9f6f8-eb06-4972-8a34-4cddc01df960"), 19, new Guid("a013f08b-9974-485a-ba14-7b246db17d9e"), 154, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8232), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 3, 784.02m, new DateTime(2023, 10, 9, 0, 52, 34, 922, DateTimeKind.Local).AddTicks(1621), "Table", null },
                    { new Guid("871d010c-c538-41cd-9325-ac1eeeb10e6a"), 16, new Guid("066710b3-9460-4e81-a086-42eb03d36f30"), 534, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5355), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 4, 96.59m, new DateTime(2024, 5, 8, 11, 46, 46, 425, DateTimeKind.Local).AddTicks(4676), "Ball", null },
                    { new Guid("8783f5ad-70c3-4bf0-a960-665bd91de1e7"), 10, new Guid("b4b5fd94-c38d-4f89-bdf0-91b51fa4fb1b"), 540, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1950), "The Football Is Good For Training And Recreational Purposes", 2, 173.01m, new DateTime(2024, 1, 29, 15, 2, 47, 493, DateTimeKind.Local).AddTicks(625), "Pants", null },
                    { new Guid("8ab18e2f-41dc-4200-8888-71b526de99e1"), 14, new Guid("25f0acab-897a-410b-83a2-af005c31ead9"), 886, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6322), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 6, 989.84m, new DateTime(2024, 2, 10, 1, 50, 30, 637, DateTimeKind.Local).AddTicks(1035), "Soap", null },
                    { new Guid("8bc2cec5-9e0d-4954-9e67-c9195e1bd2df"), 17, new Guid("7471b94c-de3a-4622-bd6d-cd5a10111641"), 395, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8427), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, 592.14m, new DateTime(2024, 1, 29, 4, 12, 2, 35, DateTimeKind.Local).AddTicks(3213), "Car", null },
                    { new Guid("8c434c8f-769d-4eaf-8504-23fb064631bf"), 17, new Guid("70146ef7-491f-4d55-bbbd-8c83f5255f4a"), 895, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7073), "The Football Is Good For Training And Recreational Purposes", 4, 490.21m, new DateTime(2023, 12, 1, 13, 22, 34, 569, DateTimeKind.Local).AddTicks(1467), "Soap", null },
                    { new Guid("8d3d9c9c-e761-42f3-adfe-7fd10af6416e"), 14, new Guid("ad5a7d28-9f5a-4a95-8fef-8e10df49e683"), 422, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8720), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 0, 188.77m, new DateTime(2023, 6, 24, 13, 31, 53, 605, DateTimeKind.Local).AddTicks(204), "Salad", null },
                    { new Guid("8e86dd6a-b92b-4bfe-8ecd-49936737c1c3"), 20, new Guid("fc874fde-341a-48c7-9d81-fd18e8aba820"), 718, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(4061), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, 437.81m, new DateTime(2023, 12, 6, 1, 43, 37, 32, DateTimeKind.Local).AddTicks(5404), "Soap", null },
                    { new Guid("9022bc43-b584-4168-89d9-f3bbf1c99ba4"), 17, new Guid("159f915b-baaa-4f89-996a-6773d02ba278"), 347, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8100), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 3, 272.20m, new DateTime(2024, 5, 14, 1, 30, 46, 979, DateTimeKind.Local).AddTicks(6145), "Shoes", null },
                    { new Guid("90c1a7f8-dadd-457d-9dbd-73068798068a"), 22, new Guid("fc874fde-341a-48c7-9d81-fd18e8aba820"), 215, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8970), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 0, 801.62m, new DateTime(2024, 4, 19, 13, 34, 22, 210, DateTimeKind.Local).AddTicks(9354), "Shoes", null },
                    { new Guid("90e75ae1-88b0-4817-9131-297e0366d7f1"), 10, new Guid("051a76bf-d39e-42b9-abde-e368be575958"), 113, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6421), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 5, 407.59m, new DateTime(2024, 2, 8, 1, 21, 23, 338, DateTimeKind.Local).AddTicks(7301), "Chicken", null },
                    { new Guid("93a533ef-a869-425d-8678-3aa3805ae2d2"), 17, new Guid("2f7a09d3-9df6-4dfd-af04-e15c5a8d65e4"), 259, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8876), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, 593.39m, new DateTime(2024, 2, 6, 13, 2, 17, 293, DateTimeKind.Local).AddTicks(1981), "Bacon", null },
                    { new Guid("93a93bd3-3d9e-4051-85aa-651fc6da8110"), 18, new Guid("e87cb78c-2508-44db-bfc1-fa458be0a03a"), 565, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, 316.58m, new DateTime(2023, 7, 19, 6, 11, 39, 800, DateTimeKind.Local).AddTicks(2663), "Shirt", null },
                    { new Guid("93b015f3-831e-40f5-9b41-ca381a4816f6"), 20, new Guid("cad92ffc-845e-4fa7-9ae7-e9c414a0a962"), 328, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5734), "The Football Is Good For Training And Recreational Purposes", 6, 983.37m, new DateTime(2023, 8, 20, 8, 28, 4, 907, DateTimeKind.Local).AddTicks(8787), "Sausages", null },
                    { new Guid("94acf787-c999-4a29-b58f-5487692ef03f"), 20, new Guid("108ee869-1851-4290-b3e9-9924afdf3769"), 85, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(715), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, 183.19m, new DateTime(2024, 4, 18, 6, 18, 56, 129, DateTimeKind.Local).AddTicks(8376), "Pants", null },
                    { new Guid("9596ba26-312d-4848-98e3-21ac02a85449"), 20, new Guid("a013f08b-9974-485a-ba14-7b246db17d9e"), 453, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(67), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, 341.10m, new DateTime(2023, 7, 14, 14, 51, 1, 525, DateTimeKind.Local).AddTicks(3146), "Computer", null },
                    { new Guid("95bc042d-bd93-4b48-9925-94dc8a87b123"), 10, new Guid("4e5f53d2-34c2-442e-bb19-74f7a3cb4406"), 747, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2609), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, 320.17m, new DateTime(2024, 2, 15, 15, 15, 10, 531, DateTimeKind.Local).AddTicks(3074), "Tuna", null },
                    { new Guid("96406142-2c9c-4bc6-9bc6-f3ec34a73d9b"), 10, new Guid("29cd46bd-3f89-4d22-911d-aae5be748d82"), 66, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(517), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 3, 625.28m, new DateTime(2023, 6, 4, 19, 9, 28, 116, DateTimeKind.Local).AddTicks(9664), "Shoes", null },
                    { new Guid("9654b37d-e4e0-4f4d-b77c-24fb558e2560"), 15, new Guid("eef15fa8-e309-4135-b7b4-367e6871a0b6"), 859, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(154), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5, 134.12m, new DateTime(2023, 8, 16, 8, 20, 58, 506, DateTimeKind.Local).AddTicks(4628), "Table", null },
                    { new Guid("995a4228-a065-4b77-9539-57d16fa48c28"), 24, new Guid("25f0acab-897a-410b-83a2-af005c31ead9"), 243, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(3962), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, 379.62m, new DateTime(2023, 8, 6, 23, 1, 34, 298, DateTimeKind.Local).AddTicks(6624), "Mouse", null },
                    { new Guid("9ac90744-7739-4f54-998f-0844172737cb"), 25, new Guid("159f915b-baaa-4f89-996a-6773d02ba278"), 247, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1101), "The Football Is Good For Training And Recreational Purposes", 4, 975.93m, new DateTime(2023, 7, 15, 10, 45, 55, 520, DateTimeKind.Local).AddTicks(9514), "Keyboard", null },
                    { new Guid("9b272776-eec1-417d-996a-1c2d6e9d0dc1"), 24, new Guid("24fede50-f56f-43f9-95ea-77ef82cadc0b"), 646, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9739), "The Football Is Good For Training And Recreational Purposes", 1, 226.15m, new DateTime(2023, 7, 4, 13, 44, 41, 144, DateTimeKind.Local).AddTicks(951), "Chips", null },
                    { new Guid("9d82fa44-d144-4a49-aa88-9bf535262b53"), 22, new Guid("1ec2d558-a707-4d7e-b326-1bf3eaf779d0"), 852, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1534), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 0, 278.41m, new DateTime(2024, 5, 20, 8, 4, 17, 561, DateTimeKind.Local).AddTicks(4312), "Table", null },
                    { new Guid("9f03838c-c10f-4de9-a177-51fcc6ddf603"), 10, new Guid("159f915b-baaa-4f89-996a-6773d02ba278"), 783, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(4927), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, 315.65m, new DateTime(2023, 10, 15, 16, 6, 12, 190, DateTimeKind.Local).AddTicks(8544), "Towels", null },
                    { new Guid("a02bc3f6-585e-4a6f-8342-acb0a398af58"), 25, new Guid("ac38031a-defc-4959-bbeb-cbc756dd8cf5"), 590, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(4270), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, 364.71m, new DateTime(2023, 7, 8, 20, 2, 33, 954, DateTimeKind.Local).AddTicks(5892), "Bike", null },
                    { new Guid("a05b5c06-9c69-42a5-b8ac-a2925e721199"), 19, new Guid("a013f08b-9974-485a-ba14-7b246db17d9e"), 97, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6154), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, 778.37m, new DateTime(2023, 12, 21, 8, 23, 26, 759, DateTimeKind.Local).AddTicks(2693), "Gloves", null },
                    { new Guid("a127cf02-7c43-49bb-8ff2-973daf877f17"), 21, new Guid("758125a1-855b-42f4-aaf3-53adc00d6fc8"), 875, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9460), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, 671.14m, new DateTime(2024, 3, 22, 16, 7, 22, 851, DateTimeKind.Local).AddTicks(2162), "Gloves", null },
                    { new Guid("a14bdbea-6129-44c5-8d19-9507034b3a1c"), 24, new Guid("0fd42dd8-4a25-41e9-b135-522849af300c"), 573, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(4607), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, 263.25m, new DateTime(2023, 7, 2, 18, 41, 25, 536, DateTimeKind.Local).AddTicks(9810), "Sausages", null },
                    { new Guid("a18412c6-8a2c-4013-b3bd-46892f4e0e2a"), 24, new Guid("239abe78-fbbe-4174-8147-52b5bc89b88f"), 361, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6287), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, 467.42m, new DateTime(2024, 5, 17, 5, 41, 17, 853, DateTimeKind.Local).AddTicks(6283), "Chips", null },
                    { new Guid("a7965963-621c-4e8f-821e-bb8eeb7543e4"), 15, new Guid("6ab3918c-623b-4521-99f2-dde6f0195044"), 616, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7907), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, 599.84m, new DateTime(2024, 5, 22, 6, 45, 45, 852, DateTimeKind.Local).AddTicks(2135), "Towels", null },
                    { new Guid("a8460d2c-6a1e-4479-99c7-89b21e4042ac"), 14, new Guid("55868b4d-b7b2-4a30-b83c-3d7239d4cf0f"), 403, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7330), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, 385.24m, new DateTime(2023, 9, 22, 13, 10, 21, 60, DateTimeKind.Local).AddTicks(3431), "Cheese", null },
                    { new Guid("ab21539b-e524-4fc4-9ea3-5a91a1698194"), 11, new Guid("ac38031a-defc-4959-bbeb-cbc756dd8cf5"), 40, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(4315), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 0, 547.33m, new DateTime(2024, 5, 13, 14, 12, 54, 91, DateTimeKind.Local).AddTicks(1393), "Towels", null },
                    { new Guid("ab344bd4-24e1-46a7-88c0-ac3d43479dc7"), 16, new Guid("505ffe33-5ac9-4b92-82e5-408fe2eff2ee"), 905, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7663), "The Football Is Good For Training And Recreational Purposes", 0, 778.52m, new DateTime(2023, 9, 25, 3, 10, 53, 991, DateTimeKind.Local).AddTicks(9722), "Salad", null },
                    { new Guid("ac01968d-18f7-4183-b96b-ee83c0dc39de"), 12, new Guid("213baca9-217b-4e91-ba0a-d36da2249931"), 817, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7456), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 6, 679.94m, new DateTime(2023, 7, 21, 23, 16, 37, 22, DateTimeKind.Local).AddTicks(3544), "Fish", null },
                    { new Guid("ac47fe49-ef25-414a-88a0-3635db678558"), 16, new Guid("6296317f-55b5-461d-9958-2111e9acca3c"), 231, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1917), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, 400.16m, new DateTime(2023, 10, 25, 10, 2, 58, 480, DateTimeKind.Local).AddTicks(8005), "Mouse", null },
                    { new Guid("ac8ebda5-9581-4a8c-af58-6cf21e1be1fe"), 20, new Guid("ad5a7d28-9f5a-4a95-8fef-8e10df49e683"), 167, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7555), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, 855.92m, new DateTime(2024, 1, 20, 17, 10, 13, 724, DateTimeKind.Local).AddTicks(8028), "Gloves", null },
                    { new Guid("acfc5322-52de-4136-994b-cf1fd9cf4e84"), 19, new Guid("9eb178d7-31ea-4fe6-b28e-8be923833201"), 78, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6555), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 6, 744.36m, new DateTime(2023, 8, 7, 4, 1, 0, 761, DateTimeKind.Local).AddTicks(469), "Towels", null },
                    { new Guid("ada7be1d-897e-4775-8e00-66c4604dc7c9"), 22, new Guid("0d263711-2385-4035-9fab-15fb5a644ab7"), 400, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9901), "The Football Is Good For Training And Recreational Purposes", 4, 650.16m, new DateTime(2024, 4, 20, 11, 40, 57, 917, DateTimeKind.Local).AddTicks(4266), "Tuna", null },
                    { new Guid("ae6b5414-bc28-4db5-a650-8550cabd8ffb"), 22, new Guid("36a7431f-c62f-44a0-8558-ee3c31d4b09b"), 543, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(222), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 4, 431.47m, new DateTime(2024, 2, 23, 23, 45, 10, 57, DateTimeKind.Local).AddTicks(5236), "Gloves", null },
                    { new Guid("aeda74dc-cc80-4f12-b80c-ad785b663af4"), 19, new Guid("4e5f53d2-34c2-442e-bb19-74f7a3cb4406"), 652, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(4358), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, 473.13m, new DateTime(2024, 2, 7, 12, 27, 31, 986, DateTimeKind.Local).AddTicks(1319), "Shirt", null },
                    { new Guid("af7f3cd9-e80f-4c6c-b0ba-2309381a26b8"), 17, new Guid("cea363af-7638-4c56-8847-cb1bcf46f0e0"), 165, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1425), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 4, 909.15m, new DateTime(2024, 3, 6, 8, 30, 7, 415, DateTimeKind.Local).AddTicks(7540), "Sausages", null },
                    { new Guid("afcb4b3f-0c20-4939-9bfa-dc20befbe091"), 13, new Guid("ad5a7d28-9f5a-4a95-8fef-8e10df49e683"), 722, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(603), "The Football Is Good For Training And Recreational Purposes", 1, 372.82m, new DateTime(2023, 11, 22, 0, 10, 58, 114, DateTimeKind.Local).AddTicks(8258), "Mouse", null },
                    { new Guid("b094290a-9cfb-45ab-bff6-b22847c32606"), 12, new Guid("a8f59154-3dce-4cfd-83d6-b03e23899d4d"), 731, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9332), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4, 507.58m, new DateTime(2023, 9, 2, 7, 43, 47, 277, DateTimeKind.Local).AddTicks(8474), "Bike", null },
                    { new Guid("b0cdc87d-f6a9-4429-b74d-43e48544dd43"), 15, new Guid("cfb062ac-b80b-4b4c-8313-0c32c16ac91d"), 241, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1004), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, 418.09m, new DateTime(2023, 12, 23, 9, 34, 29, 392, DateTimeKind.Local).AddTicks(6322), "Chips", null },
                    { new Guid("b19f0613-f4fb-49a6-b5d9-0a8c8f5e234b"), 11, new Guid("405e81da-1f0b-498c-8335-0b71e82e8538"), 582, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5122), "The Football Is Good For Training And Recreational Purposes", 3, 171.62m, new DateTime(2024, 1, 17, 7, 38, 54, 65, DateTimeKind.Local).AddTicks(9549), "Fish", null },
                    { new Guid("b3ed2045-e2b2-4efa-b7f1-eecb1666dd1b"), 17, new Guid("0d263711-2385-4035-9fab-15fb5a644ab7"), 937, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9593), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2, 137.03m, new DateTime(2023, 7, 1, 2, 7, 32, 796, DateTimeKind.Local).AddTicks(2216), "Table", null },
                    { new Guid("b4f103de-78a6-46c3-b392-0f2e56f3dd60"), 12, new Guid("1ec2d558-a707-4d7e-b326-1bf3eaf779d0"), 133, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6881), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 0, 426.58m, new DateTime(2024, 3, 17, 8, 2, 33, 680, DateTimeKind.Local).AddTicks(6535), "Computer", null },
                    { new Guid("b785ef47-2f7a-4c89-8b05-0a12a1568ee2"), 17, new Guid("7f0bbe55-4495-4dff-8ce3-e6b3b7b17232"), 843, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7939), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 4, 67.99m, new DateTime(2023, 9, 8, 20, 35, 40, 561, DateTimeKind.Local).AddTicks(5186), "Salad", null },
                    { new Guid("b7a32110-9c9a-4817-ae62-a8618a7ef99e"), 23, new Guid("1e0dd338-b92c-42f8-b93b-c83c8b47927a"), 843, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(4710), "The Football Is Good For Training And Recreational Purposes", 1, 632.04m, new DateTime(2023, 6, 7, 13, 4, 6, 463, DateTimeKind.Local).AddTicks(7140), "Pizza", null },
                    { new Guid("b863791b-8079-49b5-8cdb-cb7b198344cf"), 25, new Guid("066710b3-9460-4e81-a086-42eb03d36f30"), 373, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(4827), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, 404.76m, new DateTime(2023, 11, 4, 22, 54, 29, 75, DateTimeKind.Local).AddTicks(2801), "Soap", null },
                    { new Guid("bc14458c-6c06-45dc-9424-500d7a0086e0"), 23, new Guid("24fede50-f56f-43f9-95ea-77ef82cadc0b"), 105, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1253), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, 555.42m, new DateTime(2023, 6, 22, 18, 12, 4, 87, DateTimeKind.Local).AddTicks(9911), "Chair", null },
                    { new Guid("bd7f1161-7d7d-4ebe-8dbc-f2490805fb73"), 10, new Guid("29cd46bd-3f89-4d22-911d-aae5be748d82"), 155, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(907), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2, 879.40m, new DateTime(2023, 11, 17, 17, 5, 10, 249, DateTimeKind.Local).AddTicks(1234), "Salad", null },
                    { new Guid("bf5faa9c-1e9f-4879-a66d-341e526a22ed"), 10, new Guid("0179a996-12da-4ab9-a061-fc5522682ba0"), 939, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7799), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5, 613.01m, new DateTime(2024, 4, 26, 21, 22, 24, 695, DateTimeKind.Local).AddTicks(1322), "Chicken", null },
                    { new Guid("c107ef54-bd5b-4c9d-9e8c-4309451aa6f3"), 15, new Guid("213baca9-217b-4e91-ba0a-d36da2249931"), 912, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(189), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, 819.62m, new DateTime(2023, 11, 10, 20, 34, 11, 152, DateTimeKind.Local).AddTicks(8796), "Chicken", null },
                    { new Guid("c19747a8-af1c-4122-8506-201037492e62"), 12, new Guid("11b31cc2-3df4-43fc-8226-9e5551f48730"), 723, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6783), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2, 228.79m, new DateTime(2023, 9, 8, 22, 21, 25, 311, DateTimeKind.Local).AddTicks(8731), "Shirt", null },
                    { new Guid("c443085c-4158-4baf-8e27-6e2e7b841cf0"), 15, new Guid("a8f59154-3dce-4cfd-83d6-b03e23899d4d"), 223, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9772), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, 690.89m, new DateTime(2023, 9, 25, 2, 23, 46, 927, DateTimeKind.Local).AddTicks(8392), "Computer", null },
                    { new Guid("c51ef219-08ee-45d4-a56e-e86c5e3b62ee"), 20, new Guid("36a7431f-c62f-44a0-8558-ee3c31d4b09b"), 84, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(288), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3, 516.30m, new DateTime(2024, 2, 15, 15, 5, 52, 171, DateTimeKind.Local).AddTicks(9213), "Table", null },
                    { new Guid("c8c8830e-2558-41d1-aa87-cfb1f59341d1"), 16, new Guid("cea363af-7638-4c56-8847-cb1bcf46f0e0"), 587, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8460), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, 798.48m, new DateTime(2023, 10, 9, 15, 21, 27, 850, DateTimeKind.Local).AddTicks(2337), "Keyboard", null },
                    { new Guid("c966fb92-0bea-47f4-b88c-81a0169ad148"), 10, new Guid("e87cb78c-2508-44db-bfc1-fa458be0a03a"), 591, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2050), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, 239.30m, new DateTime(2023, 12, 2, 18, 50, 31, 327, DateTimeKind.Local).AddTicks(8580), "Shirt", null },
                    { new Guid("cb428323-7b4c-410c-8f7c-b09dbfe39b47"), 17, new Guid("213baca9-217b-4e91-ba0a-d36da2249931"), 408, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(972), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2, 284.47m, new DateTime(2024, 2, 9, 13, 3, 22, 971, DateTimeKind.Local).AddTicks(9520), "Hat", null },
                    { new Guid("cb8e796b-4d1c-42e3-8d51-b2dc9ea348f1"), 22, new Guid("fc874fde-341a-48c7-9d81-fd18e8aba820"), 884, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8165), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 4, 617.18m, new DateTime(2024, 2, 2, 7, 39, 42, 387, DateTimeKind.Local).AddTicks(8356), "Pizza", null },
                    { new Guid("d0eadaf3-fb10-4bf1-aa63-8cf5af448c5b"), 17, new Guid("97d97933-2755-4986-bdc9-ba19d5c7d21f"), 349, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8264), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 5, 275.98m, new DateTime(2023, 10, 4, 7, 52, 20, 790, DateTimeKind.Local).AddTicks(9531), "Mouse", null },
                    { new Guid("d4928727-2855-45f7-b6f6-918063e480f0"), 22, new Guid("e762be0d-e256-4f6c-b628-bbb1807adb14"), 236, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6047), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, 630.99m, new DateTime(2023, 6, 26, 7, 2, 41, 748, DateTimeKind.Local).AddTicks(4335), "Keyboard", null },
                    { new Guid("d681d0b2-d7fe-4937-8aab-d2f644cd61b9"), 17, new Guid("7f0bbe55-4495-4dff-8ce3-e6b3b7b17232"), 964, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1286), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, 852.01m, new DateTime(2023, 6, 4, 21, 7, 45, 149, DateTimeKind.Local).AddTicks(222), "Ball", null },
                    { new Guid("d6e19d29-1a65-4547-90e5-e96fda18f289"), 24, new Guid("50681485-14d9-450d-b2e6-2643d251ab8a"), 911, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7522), "The Football Is Good For Training And Recreational Purposes", 2, 670.16m, new DateTime(2023, 10, 19, 14, 51, 32, 460, DateTimeKind.Local).AddTicks(5366), "Sausages", null },
                    { new Guid("d7809fd5-b9a7-4e51-b8f7-e2a04013629c"), 10, new Guid("55868b4d-b7b2-4a30-b83c-3d7239d4cf0f"), 906, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9804), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, 543.22m, new DateTime(2023, 8, 20, 15, 4, 17, 322, DateTimeKind.Local).AddTicks(487), "Pizza", null },
                    { new Guid("d887cb46-300b-4810-808f-0a8845a8cd12"), 16, new Guid("baa866f0-cf27-4eb1-9848-fa7333f4114f"), 47, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1984), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, 88.09m, new DateTime(2024, 3, 8, 19, 19, 2, 975, DateTimeKind.Local).AddTicks(5666), "Ball", null },
                    { new Guid("d9bb9b63-3d3a-4d48-b107-610acf06726b"), 17, new Guid("cad92ffc-845e-4fa7-9ae7-e9c414a0a962"), 869, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8654), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, 775.54m, new DateTime(2024, 5, 6, 6, 9, 27, 914, DateTimeKind.Local).AddTicks(5895), "Fish", null },
                    { new Guid("da4323e3-fa54-4a79-8b41-f9fdf3cdbf25"), 21, new Guid("159f915b-baaa-4f89-996a-6773d02ba278"), 303, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2130), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5, 427.97m, new DateTime(2023, 11, 20, 4, 36, 51, 837, DateTimeKind.Local).AddTicks(3789), "Sausages", null },
                    { new Guid("da81a0d1-23f7-40fd-9bb3-c8480d88739a"), 17, new Guid("4e5f53d2-34c2-442e-bb19-74f7a3cb4406"), 216, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6654), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, 214.01m, new DateTime(2023, 8, 24, 23, 37, 32, 651, DateTimeKind.Local).AddTicks(7333), "Shoes", null },
                    { new Guid("dbe4bd19-ff94-4459-bcb5-f05e45d6e623"), 22, new Guid("edfe5fee-490d-420e-a77d-32eb99e8e153"), 987, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1068), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, 950.09m, new DateTime(2024, 4, 30, 17, 20, 0, 373, DateTimeKind.Local).AddTicks(9209), "Hat", null },
                    { new Guid("de2f9f61-b80c-4e18-80a4-253ef1c2eaf0"), 17, new Guid("239abe78-fbbe-4174-8147-52b5bc89b88f"), 782, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(1632), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, 84.39m, new DateTime(2023, 7, 25, 8, 33, 1, 935, DateTimeKind.Local).AddTicks(1121), "Shoes", null },
                    { new Guid("dfb2a5b3-db25-47e4-a336-4c3c6ef93d88"), 21, new Guid("83a373c4-3acd-494f-949a-d6f3db4c37bd"), 605, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6687), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, 357.07m, new DateTime(2024, 4, 8, 3, 50, 46, 197, DateTimeKind.Local).AddTicks(6264), "Pants", null },
                    { new Guid("e0ed6f4b-22ae-40b6-ae3f-b59e56f00391"), 25, new Guid("5a4618c4-1d9b-4754-b694-2f9c47ba107a"), 959, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8553), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, 254.60m, new DateTime(2023, 6, 11, 21, 46, 28, 539, DateTimeKind.Local).AddTicks(7436), "Chips", null },
                    { new Guid("e10eb8ad-77f4-4f24-b856-192b24ba1684"), 21, new Guid("cea363af-7638-4c56-8847-cb1bcf46f0e0"), 1000, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7164), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 6, 407.23m, new DateTime(2023, 7, 16, 21, 42, 30, 497, DateTimeKind.Local).AddTicks(5817), "Bike", null },
                    { new Guid("e298f4ee-ea09-4f70-87a2-bd895c2919f9"), 15, new Guid("a8f59154-3dce-4cfd-83d6-b03e23899d4d"), 696, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(4211), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 5, 15.79m, new DateTime(2023, 10, 6, 1, 19, 51, 645, DateTimeKind.Local).AddTicks(6389), "Chair", null },
                    { new Guid("e3cf1ab0-b3ac-4303-89c5-ed803213a5b8"), 11, new Guid("24bc6580-7dbb-4db3-9660-cfbf64bafc91"), 945, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7231), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2, 300.43m, new DateTime(2024, 5, 4, 20, 59, 31, 513, DateTimeKind.Local).AddTicks(7310), "Soap", null },
                    { new Guid("e5965ef6-b606-46ca-a3e8-33ff18984a10"), 12, new Guid("90357598-f0cb-4538-8d0c-56b7202da1e8"), 793, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9365), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 4, 270.57m, new DateTime(2024, 1, 13, 21, 58, 44, 22, DateTimeKind.Local).AddTicks(1575), "Hat", null },
                    { new Guid("e86ee355-5d97-427b-b1a7-3d53dac700a8"), 10, new Guid("69123db0-013e-468b-9b0b-a739921dfd2b"), 290, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(466), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, 524.78m, new DateTime(2023, 6, 20, 11, 49, 26, 86, DateTimeKind.Local).AddTicks(5778), "Table", null },
                    { new Guid("e8747217-091d-4cb0-81f4-365221f2cd6f"), 18, new Guid("8aa5d51c-0cd3-464e-8c45-906de52acb4f"), 826, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2420), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 3, 808.61m, new DateTime(2023, 10, 26, 23, 29, 11, 767, DateTimeKind.Local).AddTicks(8602), "Soap", null },
                    { new Guid("ea538cd1-0b9b-494f-867a-e831a45761a5"), 25, new Guid("71a1603e-8f57-49a5-be43-22bdc8157264"), 705, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8361), "The Football Is Good For Training And Recreational Purposes", 6, 546.22m, new DateTime(2023, 8, 15, 18, 22, 55, 59, DateTimeKind.Local).AddTicks(2477), "Fish", null },
                    { new Guid("ec6ce5af-5449-4af1-85a6-71d90c39aa0d"), 11, new Guid("b4b5fd94-c38d-4f89-bdf0-91b51fa4fb1b"), 161, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(4014), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3, 640.25m, new DateTime(2024, 5, 10, 15, 25, 19, 89, DateTimeKind.Local).AddTicks(3057), "Hat", null },
                    { new Guid("eec2d6c2-721d-40ff-a903-cb7c6367d4dd"), 16, new Guid("0906c38c-03b5-429c-81fb-48f83537bed2"), 492, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6388), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 0, 450.84m, new DateTime(2024, 2, 18, 19, 55, 50, 133, DateTimeKind.Local).AddTicks(863), "Table", null },
                    { new Guid("eee28c5d-4251-49e5-b9fd-8f17c5e47b2f"), 12, new Guid("7471b94c-de3a-4622-bd6d-cd5a10111641"), 478, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8844), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, 903.51m, new DateTime(2023, 10, 3, 16, 38, 31, 945, DateTimeKind.Local).AddTicks(993), "Cheese", null },
                    { new Guid("ef1ae74f-aa37-4afe-b886-76ae7d836d79"), 15, new Guid("28de0484-8f41-43e5-9836-a0d74fe78a66"), 125, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9267), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, 197.50m, new DateTime(2023, 8, 31, 14, 16, 26, 970, DateTimeKind.Local).AddTicks(787), "Pizza", null },
                    { new Guid("efe0851b-4656-4767-9019-a7e53584c6cd"), 21, new Guid("cad92ffc-845e-4fa7-9ae7-e9c414a0a962"), 120, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(255), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, 363.43m, new DateTime(2024, 1, 30, 6, 55, 11, 973, DateTimeKind.Local).AddTicks(7712), "Salad", null },
                    { new Guid("f01d2771-8072-41ea-886d-c9ccb1e85b2f"), 17, new Guid("9878d865-2300-4b82-879c-f4d9861202b2"), 218, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7108), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 0, 255.69m, new DateTime(2024, 5, 25, 14, 4, 48, 831, DateTimeKind.Local).AddTicks(8474), "Tuna", null },
                    { new Guid("f0a15012-8aae-4ddd-a72e-8f1bbdade4a7"), 23, new Guid("e6464331-4865-4d45-9ef8-f744cc45ce0c"), 373, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9234), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, 264.42m, new DateTime(2024, 1, 8, 12, 51, 57, 129, DateTimeKind.Local).AddTicks(9423), "Shoes", null },
                    { new Guid("f10db490-6572-4bbb-a9bc-41905651e6c0"), 17, new Guid("066710b3-9460-4e81-a086-42eb03d36f30"), 962, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9004), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, 165.02m, new DateTime(2023, 10, 3, 13, 26, 35, 695, DateTimeKind.Local).AddTicks(2135), "Shirt", null },
                    { new Guid("f10ee352-dec1-4428-ad43-9e5e504c832e"), 21, new Guid("5a4618c4-1d9b-4754-b694-2f9c47ba107a"), 665, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5887), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 0, 855.20m, new DateTime(2023, 8, 19, 23, 24, 7, 773, DateTimeKind.Local).AddTicks(3681), "Hat", null },
                    { new Guid("f167efb8-24a6-441f-9396-2faf008306c5"), 25, new Guid("e87cb78c-2508-44db-bfc1-fa458be0a03a"), 362, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5809), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, 486.99m, new DateTime(2023, 6, 19, 1, 18, 54, 544, DateTimeKind.Local).AddTicks(3369), "Table", null },
                    { new Guid("f1cc25b1-0c73-4051-8983-6c4a14dcb613"), 18, new Guid("83a373c4-3acd-494f-949a-d6f3db4c37bd"), 92, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2642), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 4, 622.91m, new DateTime(2024, 5, 2, 23, 18, 16, 924, DateTimeKind.Local).AddTicks(6940), "Chicken", null },
                    { new Guid("f2300129-b825-4d06-b526-d7132dc75232"), 25, new Guid("b4b5fd94-c38d-4f89-bdf0-91b51fa4fb1b"), 326, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(9136), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 6, 847.09m, new DateTime(2023, 7, 21, 13, 56, 32, 982, DateTimeKind.Local).AddTicks(9358), "Sausages", null },
                    { new Guid("f32fa088-3743-44c2-88bb-b6039179dfd2"), 23, new Guid("25f0acab-897a-410b-83a2-af005c31ead9"), 740, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(365), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 0, 707.18m, new DateTime(2024, 3, 20, 22, 46, 48, 316, DateTimeKind.Local).AddTicks(7813), "Cheese", null },
                    { new Guid("f7f732f4-419c-4171-8d3d-74176cbfe331"), 17, new Guid("25f0acab-897a-410b-83a2-af005c31ead9"), 46, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8394), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, 911.51m, new DateTime(2024, 5, 25, 8, 52, 28, 489, DateTimeKind.Local).AddTicks(5809), "Fish", null },
                    { new Guid("f9c81da5-53bb-45e8-9cad-1373b0a38db7"), 11, new Guid("e762be0d-e256-4f6c-b628-bbb1807adb14"), 299, new DateTime(2023, 5, 26, 20, 40, 50, 609, DateTimeKind.Local).AddTicks(2198), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 4, 655.62m, new DateTime(2024, 2, 17, 7, 40, 58, 731, DateTimeKind.Local).AddTicks(2704), "Ball", null },
                    { new Guid("f9da077e-861d-4e38-9d32-576c35bb5fff"), 11, new Guid("b4b5fd94-c38d-4f89-bdf0-91b51fa4fb1b"), 557, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8777), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 6, 267.10m, new DateTime(2023, 6, 23, 13, 34, 42, 851, DateTimeKind.Local).AddTicks(8735), "Gloves", null },
                    { new Guid("fb7a1b15-3234-4f42-b063-2c0e799eb28b"), 10, new Guid("e6464331-4865-4d45-9ef8-f744cc45ce0c"), 128, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(5624), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, 688.89m, new DateTime(2023, 7, 5, 18, 58, 47, 669, DateTimeKind.Local).AddTicks(7127), "Computer", null },
                    { new Guid("fb987643-d6d6-45f1-9899-433b71348b00"), 18, new Guid("edfe5fee-490d-420e-a77d-32eb99e8e153"), 339, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(8133), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 5, 89.43m, new DateTime(2023, 6, 19, 20, 25, 27, 566, DateTimeKind.Local).AddTicks(8183), "Ball", null },
                    { new Guid("fbfc5621-ab97-4bca-ab60-9dbc2d4ccddd"), 21, new Guid("a013f08b-9974-485a-ba14-7b246db17d9e"), 769, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(7489), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5, 554.38m, new DateTime(2024, 5, 15, 12, 18, 9, 651, DateTimeKind.Local).AddTicks(7096), "Car", null },
                    { new Guid("fd33b82e-3d32-444d-8d3b-1f3b75e387b8"), 14, new Guid("36a7431f-c62f-44a0-8558-ee3c31d4b09b"), 693, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6519), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, 956.99m, new DateTime(2023, 6, 1, 19, 46, 23, 943, DateTimeKind.Local).AddTicks(7112), "Cheese", null },
                    { new Guid("fd355bbe-71dd-499d-bf02-266ba2cff511"), 19, new Guid("a013f08b-9974-485a-ba14-7b246db17d9e"), 457, new DateTime(2023, 5, 26, 20, 40, 50, 608, DateTimeKind.Local).AddTicks(6816), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 3, 211.93m, new DateTime(2024, 1, 10, 0, 43, 21, 522, DateTimeKind.Local).AddTicks(220), "Mouse", null }
                });

            migrationBuilder.InsertData(
                table: "BooksCategories",
                columns: new[] { "ID", "BooksID", "CategoriesID", "CreatedDateTime", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("01f131d1-f172-4bfa-9497-40c7e698798e"), new Guid("8c434c8f-769d-4eaf-8504-23fb064631bf"), new Guid("324acb0b-616b-4a90-92fa-a1af1a4fda44"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9608), null },
                    { new Guid("0207dda9-376a-43ed-9a4b-735b0c1c8a54"), new Guid("11f8d160-fab5-49cb-abd9-5b3c0098dc80"), new Guid("e082a350-1045-4ace-9f4d-9f7168271c28"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1093), null },
                    { new Guid("03987ab8-252d-446a-8552-5ef82a54d38c"), new Guid("85f019f7-7433-4924-a283-ce8f67fd35d8"), new Guid("aa28398f-e35e-4985-a653-b4092068b296"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(45), null },
                    { new Guid("03e353df-9d3f-4366-bfe2-3abd21053c98"), new Guid("c443085c-4158-4baf-8e27-6e2e7b841cf0"), new Guid("87aa25a6-e526-4db3-b98c-fefdaf6bb4a4"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(489), null },
                    { new Guid("04dd8f93-6c91-42cc-9ed0-8111a5eb3156"), new Guid("291a9e51-c0ee-4100-8e5b-a314456a54e7"), new Guid("2b7b655e-2a55-4871-b7ce-9eea7aa8e8bd"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9411), null },
                    { new Guid("060ae4bf-87ce-4344-9d52-7af9364dde2c"), new Guid("9596ba26-312d-4848-98e3-21ac02a85449"), new Guid("4b877a03-2cbe-4867-a3b7-47947d8d1a69"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(622), null },
                    { new Guid("086b994c-e6d6-4161-92c1-5e59ef07cba4"), new Guid("ada7be1d-897e-4775-8e00-66c4604dc7c9"), new Guid("d0dfbe89-5d75-4c4f-86cc-006695e70000"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1231), null },
                    { new Guid("0914b2d9-6902-4934-b1c8-db0dc3b9ec4a"), new Guid("69433bf0-fc4a-471f-b1d7-268a131e3ad4"), new Guid("a4ddabf8-80f2-427d-9eaf-cca7ce9ba586"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1843), null },
                    { new Guid("0a73de98-adf3-4424-9207-188c8a047660"), new Guid("acfc5322-52de-4136-994b-cf1fd9cf4e84"), new Guid("3dda5049-d3da-4d81-a755-bc51c96a4296"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9889), null },
                    { new Guid("0c9dab4b-532c-4993-975b-bcef65313d81"), new Guid("f7f732f4-419c-4171-8d3d-74176cbfe331"), new Guid("4b877a03-2cbe-4867-a3b7-47947d8d1a69"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9373), null },
                    { new Guid("0ecf2973-1352-40a6-b1f9-156bcea7a28c"), new Guid("dfb2a5b3-db25-47e4-a336-4c3c6ef93d88"), new Guid("c1a2ea7b-b45d-45fe-8bf2-0a2cd23849c9"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1471), null },
                    { new Guid("11a00768-b45c-4ae7-af97-280a410eb732"), new Guid("55b05bd5-6d3b-4576-9b95-9b242e56a7a9"), new Guid("4340af6f-b3ae-44cc-a751-41ffc606bafc"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1291), null },
                    { new Guid("13b2acf7-02d0-4915-94f7-eefb4c15ac94"), new Guid("e10eb8ad-77f4-4f24-b856-192b24ba1684"), new Guid("cd013daf-4c1e-4101-887f-736f48a44de5"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(399), null },
                    { new Guid("14477e6b-7164-49da-ae8b-0348dc301779"), new Guid("871d010c-c538-41cd-9325-ac1eeeb10e6a"), new Guid("8a72f418-32b4-491a-a785-c794ec863ac3"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(2006), null },
                    { new Guid("14d66710-c1e5-4675-9101-e0695ae52d96"), new Guid("7631ddc8-33e9-4990-985b-d0b45867c041"), new Guid("79212cae-4f6c-4ea0-a52a-632bd6615152"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9202), null },
                    { new Guid("155030df-de20-468f-9d81-8e04edb09bc8"), new Guid("03778631-6dee-4b50-8b97-7b541be41b35"), new Guid("4b877a03-2cbe-4867-a3b7-47947d8d1a69"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(104), null },
                    { new Guid("1585aa0b-bab1-4ddd-aac9-ca72ed39d518"), new Guid("0e58f760-cd6f-4529-900c-7a72faded70f"), new Guid("c50c3ec8-4cd6-4e0b-b6e3-93d5e34e6c16"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9620), null },
                    { new Guid("1588f916-5fdc-4ce9-8175-ebb751e0b313"), new Guid("2730a781-85cc-4bc0-9f3f-236aa0fe0d47"), new Guid("6b86c90c-c9e4-441b-867e-dca5d8970979"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1918), null },
                    { new Guid("17a9d924-72ea-4f0a-b0c6-dd4123984dcb"), new Guid("795765f5-155e-4061-9597-ea4fd8e8fe92"), new Guid("e082a350-1045-4ace-9f4d-9f7168271c28"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1664), null },
                    { new Guid("187e6ad4-0c78-49a9-bacc-e87faada2bc0"), new Guid("24e8a2a2-bada-454d-85d8-57b99d6bbbcc"), new Guid("79212cae-4f6c-4ea0-a52a-632bd6615152"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9510), null },
                    { new Guid("1f640d9f-ec83-4efc-a693-57982b864ef2"), new Guid("8c434c8f-769d-4eaf-8504-23fb064631bf"), new Guid("0901235a-4929-4001-83f3-4dc6fc4c91b3"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(67), null },
                    { new Guid("1f78dc9c-bbc7-48f5-a1e0-11c50d28a30c"), new Guid("d6e19d29-1a65-4547-90e5-e96fda18f289"), new Guid("79212cae-4f6c-4ea0-a52a-632bd6615152"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1403), null },
                    { new Guid("204477aa-265e-43ac-9755-7c3f5e7a8c13"), new Guid("f0a15012-8aae-4ddd-a72e-8f1bbdade4a7"), new Guid("d76c463f-7a82-4767-b6c6-e34c0e9a994c"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9582), null },
                    { new Guid("214f497f-9fa7-4e4f-89c8-fd5ba5eb03c6"), new Guid("52b3e668-05de-42dc-934e-7e7fb0b57ac7"), new Guid("77095b7b-83d6-41df-a14e-3d4b9672bb85"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1572), null },
                    { new Guid("23b6a071-4b35-4444-a0e6-9770a70c8223"), new Guid("93a93bd3-3d9e-4051-85aa-651fc6da8110"), new Guid("d76c463f-7a82-4767-b6c6-e34c0e9a994c"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(2138), null },
                    { new Guid("2566e07f-9fa4-4fdb-99da-862786112bfe"), new Guid("9b272776-eec1-417d-996a-1c2d6e9d0dc1"), new Guid("55721b5d-fb9c-4f51-8a4d-f89b229e15f6"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1506), null },
                    { new Guid("265e698c-6743-4e77-9386-0c0216749088"), new Guid("409b82f4-97ce-4eb5-88dc-bbfd30c0cc6f"), new Guid("4627831d-bab8-43da-b895-2763db534c22"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9535), null },
                    { new Guid("26774121-87ec-4646-b86c-5458b4a083f6"), new Guid("f9da077e-861d-4e38-9d32-576c35bb5fff"), new Guid("9a3b5391-1845-4fe6-a2ee-4d4635d57eae"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(716), null },
                    { new Guid("2831f466-5d36-4b1b-aa25-63e02da30b9c"), new Guid("2f872c93-9bd3-4354-81a5-e93d251f12c0"), new Guid("bba8001d-d7db-49e6-883e-618e1a168421"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9314), null },
                    { new Guid("2bfc0e68-f283-449d-a4fe-41a296f2fca1"), new Guid("eee28c5d-4251-49e5-b9fd-8f17c5e47b2f"), new Guid("191b6c17-50ca-414b-8ce8-f717a7147d82"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1163), null },
                    { new Guid("2cc2a185-09a4-4839-a725-c93f4da3b33e"), new Guid("d681d0b2-d7fe-4937-8aab-d2f644cd61b9"), new Guid("4340af6f-b3ae-44cc-a751-41ffc606bafc"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1449), null },
                    { new Guid("2cd553a1-be85-47ea-b12d-aaad16952e05"), new Guid("28949b30-600e-416f-9186-fb802e2325e4"), new Guid("324acb0b-616b-4a90-92fa-a1af1a4fda44"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(2019), null },
                    { new Guid("30b32bc1-1993-4c80-9b37-0dcb2c802bdb"), new Guid("cb8e796b-4d1c-42e3-8d51-b2dc9ea348f1"), new Guid("cd013daf-4c1e-4101-887f-736f48a44de5"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9678), null },
                    { new Guid("3181640d-f7cf-46fd-ba08-ec0983db1720"), new Guid("48d22703-3da2-49d5-83ec-dc467cda9355"), new Guid("cd013daf-4c1e-4101-887f-736f48a44de5"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9803), null },
                    { new Guid("31b04cee-6bb2-4f77-a1e1-bea34d855329"), new Guid("108cd72b-9307-43c9-9974-c6fb4726ed78"), new Guid("0efa878f-95f0-4ec1-8b55-739869105146"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1060), null },
                    { new Guid("33497919-02b7-4470-824b-9791a6b2cd23"), new Guid("d0eadaf3-fb10-4bf1-aa63-8cf5af448c5b"), new Guid("191b6c17-50ca-414b-8ce8-f717a7147d82"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9221), null },
                    { new Guid("34b35b65-defb-44ed-b17f-8af09d1b5f07"), new Guid("9596ba26-312d-4848-98e3-21ac02a85449"), new Guid("a9ad3768-aa7e-40de-93c6-7b086609f3d0"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(177), null },
                    { new Guid("36f40896-a172-45ea-a2ed-b251b375f475"), new Guid("afcb4b3f-0c20-4939-9bfa-dc20befbe091"), new Guid("58c651bf-d232-488c-bdd7-e00f6d782709"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1119), null },
                    { new Guid("37e082b5-6e25-4e16-94e9-7575318b1fbb"), new Guid("03778631-6dee-4b50-8b97-7b541be41b35"), new Guid("eb0deb9d-cdfc-4ef7-b429-5fab7ea2dc9e"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(2125), null },
                    { new Guid("3de18d84-3f92-4d8d-9d20-9d92dac6cb1d"), new Guid("056275e5-7e82-4502-84d2-5bd694d91664"), new Guid("0901235a-4929-4001-83f3-4dc6fc4c91b3"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1186), null },
                    { new Guid("3fe9f558-cc8a-4100-8385-d064aa1083bc"), new Guid("8c434c8f-769d-4eaf-8504-23fb064631bf"), new Guid("d76c463f-7a82-4767-b6c6-e34c0e9a994c"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1736), null },
                    { new Guid("43e7f626-a47f-4a06-97db-05752c215ac2"), new Guid("de2f9f61-b80c-4e18-80a4-253ef1c2eaf0"), new Guid("243d2a88-befd-486a-8056-e77c9918556b"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(848), null },
                    { new Guid("47b8c39a-2208-4a39-b806-1610ac6e5e5b"), new Guid("fbfc5621-ab97-4bca-ab60-9dbc2d4ccddd"), new Guid("bf5b22ee-95d1-43de-9e12-4c7b546a0ad3"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(568), null },
                    { new Guid("49d99895-e7cd-4ca4-afca-c718bc845981"), new Guid("c51ef219-08ee-45d4-a56e-e86c5e3b62ee"), new Guid("bf5b22ee-95d1-43de-9e12-4c7b546a0ad3"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1391), null },
                    { new Guid("4cd3932e-6cd8-49a4-a657-e3173cb6bf78"), new Guid("e0ed6f4b-22ae-40b6-ae3f-b59e56f00391"), new Guid("87aa25a6-e526-4db3-b98c-fefdaf6bb4a4"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1585), null },
                    { new Guid("50bb8b31-c865-4b75-9045-d12976b32df7"), new Guid("5ce9bf91-3f0f-42cb-91fa-48dfaaf5b442"), new Guid("4b877a03-2cbe-4867-a3b7-47947d8d1a69"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1640), null },
                    { new Guid("51daab15-6489-4b3d-83b3-0ce23d035b23"), new Guid("bd7f1161-7d7d-4ebe-8dbc-f2490805fb73"), new Guid("c0268d5a-82ae-404a-b5c5-1d4e18a453d7"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1710), null },
                    { new Guid("5388bb2e-a1bb-4047-8ab7-13d541c71cb4"), new Guid("e86ee355-5d97-427b-b1a7-3d53dac700a8"), new Guid("bba8001d-d7db-49e6-883e-618e1a168421"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9826), null },
                    { new Guid("566c81b9-d029-4e26-86bc-69fb21a4fb6a"), new Guid("51fc3130-13a0-448c-a2b5-40b42030972b"), new Guid("cd013daf-4c1e-4101-887f-736f48a44de5"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1532), null },
                    { new Guid("568b7513-f670-4fa8-add9-2d4521fa5cf8"), new Guid("11f211a1-b1d9-46ae-83f4-0f0736bb5973"), new Guid("08b0af99-cbbd-48a0-af1e-2a6364e65a10"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9446), null },
                    { new Guid("58c87b9f-4049-46ac-ba4f-9d3f246cdc70"), new Guid("48d22703-3da2-49d5-83ec-dc467cda9355"), new Guid("08b0af99-cbbd-48a0-af1e-2a6364e65a10"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(979), null },
                    { new Guid("58d8d875-8f05-40fb-bdbd-18fe17a16f68"), new Guid("ac47fe49-ef25-414a-88a0-3635db678558"), new Guid("2ddf5340-95cd-4b4d-bbb5-513cb5a98978"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1596), null },
                    { new Guid("5b17b4ae-8de4-4a1a-b8a6-4823b036a63c"), new Guid("48d22703-3da2-49d5-83ec-dc467cda9355"), new Guid("c50c3ec8-4cd6-4e0b-b6e3-93d5e34e6c16"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9739), null },
                    { new Guid("61cf78e5-54f7-4843-a398-5747c2bcb0fe"), new Guid("93a533ef-a869-425d-8678-3aa3805ae2d2"), new Guid("f3f5216b-2862-4489-8c9f-d6183389d31e"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9593), null },
                    { new Guid("63577e5c-c494-49a6-b122-8a853ffe6264"), new Guid("e86ee355-5d97-427b-b1a7-3d53dac700a8"), new Guid("7064397d-7d0c-40cc-9ec0-202a2ce149cc"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(501), null },
                    { new Guid("6b62e670-1db6-452a-8227-919ec4787f00"), new Guid("00c932ad-4f84-4a9e-affd-3af56c233df7"), new Guid("f3f5216b-2862-4489-8c9f-d6183389d31e"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1867), null },
                    { new Guid("6c78e887-66b3-4bae-a63d-32353d57898b"), new Guid("00c932ad-4f84-4a9e-affd-3af56c233df7"), new Guid("191b6c17-50ca-414b-8ce8-f717a7147d82"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(921), null },
                    { new Guid("6e1cca59-a631-45dd-8cd5-a4d6145c4d70"), new Guid("58714022-2947-4e34-bd52-c547afb59daf"), new Guid("f3f5216b-2862-4489-8c9f-d6183389d31e"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(682), null },
                    { new Guid("70b99e9b-8ad6-4ec0-b077-cf83632ddaf0"), new Guid("2ee4c8d8-a774-4193-9062-799f96077618"), new Guid("bfac342a-bef6-4eef-a99f-497f6b577878"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9753), null },
                    { new Guid("72b1f1bc-e065-4c77-8e43-af4b0ba90872"), new Guid("d681d0b2-d7fe-4937-8aab-d2f644cd61b9"), new Guid("55721b5d-fb9c-4f51-8a4d-f89b229e15f6"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(791), null },
                    { new Guid("7354e5b1-40ea-45a9-b5a6-55996d755cc9"), new Guid("839da5ca-9e9b-4543-adae-717c33459aad"), new Guid("9a3b5391-1845-4fe6-a2ee-4d4635d57eae"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1805), null },
                    { new Guid("75063f9a-224c-4320-84f9-dbb0d1032673"), new Guid("4bbef38c-0311-403a-a2c7-9f605ac159fd"), new Guid("cd013daf-4c1e-4101-887f-736f48a44de5"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1608), null },
                    { new Guid("78288f35-a073-4d1e-a9a1-d9bb3ea8d02e"), new Guid("95bc042d-bd93-4b48-9925-94dc8a87b123"), new Guid("474be3f3-8c47-4b39-909e-945aed13b954"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1518), null },
                    { new Guid("79fda08d-1f5c-4b16-8d52-5e9544ad6cef"), new Guid("7b0f7691-ca17-4900-a292-7c17a6057a77"), new Guid("6af3aa61-e3d8-4a30-b714-6f42c8907f9f"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9814), null },
                    { new Guid("7ddad99a-9aed-4319-a451-eb446fe64230"), new Guid("31ab896f-9857-4048-818a-6224f133907f"), new Guid("a9404063-aaa8-43d3-8197-0d1b8147c715"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(909), null },
                    { new Guid("8037b7c2-2bac-430f-aa15-027856d1ec51"), new Guid("f0a15012-8aae-4ddd-a72e-8f1bbdade4a7"), new Guid("d76c463f-7a82-4767-b6c6-e34c0e9a994c"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9522), null },
                    { new Guid("80cf51ae-c162-4cb4-977a-b3fe1d615e29"), new Guid("64e61c2c-06a9-485f-80b9-f0ef2ee44597"), new Guid("bf5b22ee-95d1-43de-9e12-4c7b546a0ad3"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(2057), null },
                    { new Guid("861c82aa-b5c3-448f-944a-84997751292f"), new Guid("b785ef47-2f7a-4c89-8b05-0a12a1568ee2"), new Guid("4b877a03-2cbe-4867-a3b7-47947d8d1a69"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1460), null },
                    { new Guid("88078bd5-f7b5-4892-bfe4-7fcab38db95b"), new Guid("585acfc7-b45d-423b-a88e-34ef19de0ff6"), new Guid("a4ddabf8-80f2-427d-9eaf-cca7ce9ba586"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1930), null },
                    { new Guid("890e2f6f-6ee9-4b07-8803-d57467863ffb"), new Guid("f01d2771-8072-41ea-886d-c9ccb1e85b2f"), new Guid("4b877a03-2cbe-4867-a3b7-47947d8d1a69"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1001), null },
                    { new Guid("8a51879d-cae4-4235-b557-572a7e53e36f"), new Guid("1ca32809-812d-462b-9290-cef6314d3f53"), new Guid("c1a2ea7b-b45d-45fe-8bf2-0a2cd23849c9"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(775), null },
                    { new Guid("8bf73868-0f95-43ec-9fd6-1fc3779368f8"), new Guid("d9bb9b63-3d3a-4d48-b107-610acf06726b"), new Guid("a9ad3768-aa7e-40de-93c6-7b086609f3d0"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(2069), null },
                    { new Guid("8f32fa46-760b-47f9-900e-d28d3e4fbb8e"), new Guid("a7965963-621c-4e8f-821e-bb8eeb7543e4"), new Guid("c50c3ec8-4cd6-4e0b-b6e3-93d5e34e6c16"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1378), null },
                    { new Guid("9246c107-eb08-4ec1-9522-1f3d01e0b647"), new Guid("1a05140b-6537-42c6-8170-8c63337213ae"), new Guid("e4386634-3511-4c82-9856-3881c6ea41ca"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(56), null },
                    { new Guid("928dda5b-ee4d-4065-9f33-59fa703ba76d"), new Guid("e86ee355-5d97-427b-b1a7-3d53dac700a8"), new Guid("c1a2ea7b-b45d-45fe-8bf2-0a2cd23849c9"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1438), null },
                    { new Guid("9316b52f-b133-44a6-b868-939c1c299507"), new Guid("f0a15012-8aae-4ddd-a72e-8f1bbdade4a7"), new Guid("e082a350-1045-4ace-9f4d-9f7168271c28"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(201), null },
                    { new Guid("941bef02-03fe-46d5-8b6d-469e7207e0ff"), new Guid("2f872c93-9bd3-4354-81a5-e93d251f12c0"), new Guid("0efa878f-95f0-4ec1-8b55-739869105146"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1038), null },
                    { new Guid("94fe1192-9df6-47d2-965b-fa279898ece0"), new Guid("ae6b5414-bc28-4db5-a650-8550cabd8ffb"), new Guid("bba8001d-d7db-49e6-883e-618e1a168421"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1980), null },
                    { new Guid("95648c03-70ff-4c03-aeb5-c5a148665226"), new Guid("360eb8d6-226e-4418-8487-f32050fad936"), new Guid("d0dfbe89-5d75-4c4f-86cc-006695e70000"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(933), null },
                    { new Guid("98035d5b-3915-4f26-b07f-e49784f5a752"), new Guid("f32fa088-3743-44c2-88bb-b6039179dfd2"), new Guid("4b877a03-2cbe-4867-a3b7-47947d8d1a69"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1793), null },
                    { new Guid("9884a1ef-b405-4357-8257-c482ea82074b"), new Guid("e0ed6f4b-22ae-40b6-ae3f-b59e56f00391"), new Guid("d0dfbe89-5d75-4c4f-86cc-006695e70000"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9302), null },
                    { new Guid("99056437-9b04-4c4e-95b0-a155aa834a5e"), new Guid("4e3ceb35-e02c-4508-93cd-2182558d298c"), new Guid("bfac342a-bef6-4eef-a99f-497f6b577878"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(308), null },
                    { new Guid("99bed7e7-1c31-4bb6-ad17-7305aeb34385"), new Guid("0ea3a09a-cd05-477e-94cf-a68d053edddf"), new Guid("0efa878f-95f0-4ec1-8b55-739869105146"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1782), null },
                    { new Guid("9c30aaf0-228e-4d53-98ee-5ed9a55bba37"), new Guid("9654b37d-e4e0-4f4d-b77c-24fb558e2560"), new Guid("4340af6f-b3ae-44cc-a751-41ffc606bafc"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1652), null },
                    { new Guid("9ca1ebc7-898a-4668-8ace-97ee5a5381b6"), new Guid("b3ed2045-e2b2-4efa-b7f1-eecb1666dd1b"), new Guid("6e8d70d5-1701-459d-b972-c968f01e6982"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9287), null },
                    { new Guid("9f13b96b-b8de-4e74-aa43-032547fdcc07"), new Guid("5c9ccfe2-a6dc-40f1-9035-c857a1769be6"), new Guid("a9ad3768-aa7e-40de-93c6-7b086609f3d0"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1131), null },
                    { new Guid("a0a48e5b-a287-4106-86cf-53ad73e0a20c"), new Guid("2f872c93-9bd3-4354-81a5-e93d251f12c0"), new Guid("6e8d70d5-1701-459d-b972-c968f01e6982"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(388), null },
                    { new Guid("a1487b31-283a-4c29-8981-72154d29e970"), new Guid("8ab18e2f-41dc-4200-8888-71b526de99e1"), new Guid("f3f5216b-2862-4489-8c9f-d6183389d31e"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(512), null },
                    { new Guid("a52a8ddf-77c9-4cc2-9cbc-2a857a6a1ab1"), new Guid("d887cb46-300b-4810-808f-0a8845a8cd12"), new Guid("4627831d-bab8-43da-b895-2763db534c22"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1995), null },
                    { new Guid("a57a81aa-801d-44e9-987c-8b83d7f6b6db"), new Guid("066a0b51-772a-4da5-a0ec-f72d32fb491e"), new Guid("4627831d-bab8-43da-b895-2763db534c22"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1769), null },
                    { new Guid("a66c368f-b903-43b7-8c5c-4084daac5725"), new Guid("1c5c9173-d8a0-423c-8f23-4520e4d6eb4f"), new Guid("08b0af99-cbbd-48a0-af1e-2a6364e65a10"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9653), null },
                    { new Guid("a6b2d555-7890-419a-a02f-cc4844145b6d"), new Guid("fb7a1b15-3234-4f42-b063-2c0e799eb28b"), new Guid("4b877a03-2cbe-4867-a3b7-47947d8d1a69"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(263), null },
                    { new Guid("a783021b-8aa0-4a35-b590-67e4ecff7137"), new Guid("0d60b3f0-100f-4b8c-84d8-3b5c4e97f86b"), new Guid("c50c3ec8-4cd6-4e0b-b6e3-93d5e34e6c16"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(704), null },
                    { new Guid("a7fcfd23-9706-490c-a4ad-0faa0654ca5e"), new Guid("b19f0613-f4fb-49a6-b5d9-0a8c8f5e234b"), new Guid("d76c463f-7a82-4767-b6c6-e34c0e9a994c"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9462), null },
                    { new Guid("a83c449b-b004-430f-a74e-770d6a7bc3d0"), new Guid("409b82f4-97ce-4eb5-88dc-bbfd30c0cc6f"), new Guid("79212cae-4f6c-4ea0-a52a-632bd6615152"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(968), null },
                    { new Guid("aba7eec8-1acc-41de-a9da-fb1bb31f54b6"), new Guid("409b82f4-97ce-4eb5-88dc-bbfd30c0cc6f"), new Guid("55721b5d-fb9c-4f51-8a4d-f89b229e15f6"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1245), null },
                    { new Guid("aeae07b6-305c-4bff-9be5-b991521ae6b1"), new Guid("cb8e796b-4d1c-42e3-8d51-b2dc9ea348f1"), new Guid("c50c3ec8-4cd6-4e0b-b6e3-93d5e34e6c16"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9398), null },
                    { new Guid("b165d99e-c6a3-4ed9-bfb4-b53b07378481"), new Guid("28949b30-600e-416f-9186-fb802e2325e4"), new Guid("bba8001d-d7db-49e6-883e-618e1a168421"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1878), null },
                    { new Guid("b3661edd-2d9c-4552-9835-5a49b1250675"), new Guid("7b70d60d-1ce6-4d24-8e8c-b74a1a9a754f"), new Guid("9a3b5391-1845-4fe6-a2ee-4d4635d57eae"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(126), null },
                    { new Guid("b37d2e00-ddf0-4ce7-aa12-a579706d248a"), new Guid("96406142-2c9c-4bc6-9bc6-f3ec34a73d9b"), new Guid("6b86c90c-c9e4-441b-867e-dca5d8970979"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9475), null },
                    { new Guid("b4324f82-a546-440b-86e9-15a1d7cb7590"), new Guid("e0ed6f4b-22ae-40b6-ae3f-b59e56f00391"), new Guid("7064397d-7d0c-40cc-9ec0-202a2ce149cc"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(557), null },
                    { new Guid("b81ce3b9-544d-4d3f-89a3-79f4b423cc72"), new Guid("a14bdbea-6129-44c5-8d19-9507034b3a1c"), new Guid("c0268d5a-82ae-404a-b5c5-1d4e18a453d7"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1049), null },
                    { new Guid("b93ee472-cb97-42a6-90e7-46afdcd1b9e5"), new Guid("b863791b-8079-49b5-8cdb-cb7b198344cf"), new Guid("bba8001d-d7db-49e6-883e-618e1a168421"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(752), null },
                    { new Guid("bae16683-1bf0-417d-9991-59b04218b42a"), new Guid("995a4228-a065-4b77-9539-57d16fa48c28"), new Guid("55721b5d-fb9c-4f51-8a4d-f89b229e15f6"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9386), null },
                    { new Guid("bb0f9238-460e-47d4-9b61-da7fd677fffd"), new Guid("90e75ae1-88b0-4817-9131-297e0366d7f1"), new Guid("bba8001d-d7db-49e6-883e-618e1a168421"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1326), null },
                    { new Guid("bf7c516e-9950-4bc7-919a-b8270e934a03"), new Guid("48358f7b-cf83-4c99-a228-9ad4c4537cf1"), new Guid("6b86c90c-c9e4-441b-867e-dca5d8970979"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1315), null },
                    { new Guid("bfc822fb-69ac-4971-8c0f-cacdac8a510b"), new Guid("48358f7b-cf83-4c99-a228-9ad4c4537cf1"), new Guid("79212cae-4f6c-4ea0-a52a-632bd6615152"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(138), null },
                    { new Guid("c0fcd4bc-e0dd-4d92-9e65-9009aa028993"), new Guid("bf5faa9c-1e9f-4879-a66d-341e526a22ed"), new Guid("c0268d5a-82ae-404a-b5c5-1d4e18a453d7"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9864), null },
                    { new Guid("c408036d-4a52-4a77-96f4-f3d43f47042d"), new Guid("fd355bbe-71dd-499d-bf02-266ba2cff511"), new Guid("79212cae-4f6c-4ea0-a52a-632bd6615152"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(2091), null },
                    { new Guid("c4c71157-7059-4016-896c-9d06563fd8d3"), new Guid("9f03838c-c10f-4de9-a177-51fcc6ddf603"), new Guid("0efa878f-95f0-4ec1-8b55-739869105146"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9665), null },
                    { new Guid("c51e81c4-a26d-4d37-a086-f0bdbd350d28"), new Guid("360eb8d6-226e-4418-8487-f32050fad936"), new Guid("32f84807-bac5-40ca-9304-9296f8498555"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(189), null },
                    { new Guid("c575f57a-8323-4620-899c-7c6c886b3734"), new Guid("bf5faa9c-1e9f-4879-a66d-341e526a22ed"), new Guid("cd013daf-4c1e-4101-887f-736f48a44de5"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(344), null },
                    { new Guid("c67a432e-ba45-44c9-ac89-2a3f6c429f95"), new Guid("2b6040ff-9a06-40dc-ac0a-00cc18682f03"), new Guid("3dda5049-d3da-4d81-a755-bc51c96a4296"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1942), null },
                    { new Guid("c8342e08-d884-47e2-a638-ff2a4c8fe610"), new Guid("c443085c-4158-4baf-8e27-6e2e7b841cf0"), new Guid("6e8d70d5-1701-459d-b972-c968f01e6982"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(2080), null },
                    { new Guid("c905961c-ca04-47d7-8228-0893d5e63f16"), new Guid("677e0b2e-36ff-4da0-aa6b-07cfae1e12c4"), new Guid("87aa25a6-e526-4db3-b98c-fefdaf6bb4a4"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(633), null },
                    { new Guid("ca5f491b-e9db-4bfd-bfa1-de9ab9b00475"), new Guid("23486d58-ca9d-4dcb-8943-eb989c3e22f2"), new Guid("55721b5d-fb9c-4f51-8a4d-f89b229e15f6"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(377), null },
                    { new Guid("cc234c99-02e0-4279-901e-497f6e8859d1"), new Guid("efe0851b-4656-4767-9019-a7e53584c6cd"), new Guid("32f84807-bac5-40ca-9304-9296f8498555"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(476), null },
                    { new Guid("ccd77a61-7866-47e4-b0b9-a47d80f806d8"), new Guid("fb987643-d6d6-45f1-9899-433b71348b00"), new Guid("2ddf5340-95cd-4b4d-bbb5-513cb5a98978"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1174), null },
                    { new Guid("cce7ef87-84d6-4b0d-b2b8-8116fbc5e0b5"), new Guid("4c9528be-6f9f-4755-b443-b6ca3c7d817d"), new Guid("9a3b5391-1845-4fe6-a2ee-4d4635d57eae"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1107), null },
                    { new Guid("cd3d917b-bcb6-497c-be87-facb4f129e44"), new Guid("10b8352e-b8d6-4a93-9965-85995888b2b8"), new Guid("2b7b655e-2a55-4871-b7ce-9eea7aa8e8bd"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(545), null },
                    { new Guid("cff1b065-9ac3-4c46-ad96-171e8567455e"), new Guid("d9bb9b63-3d3a-4d48-b107-610acf06726b"), new Guid("2ddf5340-95cd-4b4d-bbb5-513cb5a98978"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9262), null },
                    { new Guid("d024720d-aa53-430f-ad4f-537369492dde"), new Guid("23486d58-ca9d-4dcb-8943-eb989c3e22f2"), new Guid("9a3b5391-1845-4fe6-a2ee-4d4635d57eae"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9714), null },
                    { new Guid("d1484a51-44dc-489e-8693-98b0807016f9"), new Guid("6d42e309-ad7a-4659-bc5b-2da1eee45e67"), new Guid("e4386634-3511-4c82-9856-3881c6ea41ca"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(239), null },
                    { new Guid("d5947c56-fb2e-4584-803c-0354eb2e703c"), new Guid("93a93bd3-3d9e-4051-85aa-651fc6da8110"), new Guid("4340af6f-b3ae-44cc-a751-41ffc606bafc"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(763), null },
                    { new Guid("d6e9ecfa-0126-4bf5-82a0-2f8d97648cb7"), new Guid("839da5ca-9e9b-4543-adae-717c33459aad"), new Guid("32f84807-bac5-40ca-9304-9296f8498555"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(252), null },
                    { new Guid("d7adbddf-b933-4a62-aacc-6492e4b328e3"), new Guid("2b6040ff-9a06-40dc-ac0a-00cc18682f03"), new Guid("8f88c931-ec6f-422e-bb08-baf0f45ebee0"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1855), null },
                    { new Guid("d7f529ce-5253-42fa-b567-0a4d74f0cfdf"), new Guid("c443085c-4158-4baf-8e27-6e2e7b841cf0"), new Guid("4340af6f-b3ae-44cc-a751-41ffc606bafc"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9726), null },
                    { new Guid("dbc1d823-4440-4e66-9467-b904831cec37"), new Guid("b863791b-8079-49b5-8cdb-cb7b198344cf"), new Guid("f3f5216b-2862-4489-8c9f-d6183389d31e"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(333), null },
                    { new Guid("dddb4ea9-2730-499f-945c-aaf4934fe257"), new Guid("10468d37-414b-43b1-8370-105386965d9c"), new Guid("a9404063-aaa8-43d3-8197-0d1b8147c715"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(2149), null },
                    { new Guid("dfb1e0cf-cdd5-4f41-b6df-52423b64e51d"), new Guid("9596ba26-312d-4848-98e3-21ac02a85449"), new Guid("c0268d5a-82ae-404a-b5c5-1d4e18a453d7"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1304), null },
                    { new Guid("e03d0934-6f02-4413-a023-ad8f30bd52ab"), new Guid("a14bdbea-6129-44c5-8d19-9507034b3a1c"), new Guid("aa28398f-e35e-4985-a653-b4092068b296"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9548), null },
                    { new Guid("e0647488-53ef-4b1a-8f9e-35f7cd85912f"), new Guid("b19f0613-f4fb-49a6-b5d9-0a8c8f5e234b"), new Guid("0efa878f-95f0-4ec1-8b55-739869105146"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(322), null },
                    { new Guid("e21f6232-b964-4a50-a6ce-ada6e5a2ba4c"), new Guid("09b39016-0fa7-439d-8c94-0690dabecf7d"), new Guid("32f84807-bac5-40ca-9304-9296f8498555"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(836), null },
                    { new Guid("e2b7a726-37b3-48e0-b766-7f2b97795d69"), new Guid("da81a0d1-23f7-40fd-9bb3-c8480d88739a"), new Guid("bfac342a-bef6-4eef-a99f-497f6b577878"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(32), null },
                    { new Guid("e924225b-6b17-43c4-8637-6405f2fa495c"), new Guid("b863791b-8079-49b5-8cdb-cb7b198344cf"), new Guid("e082a350-1045-4ace-9f4d-9f7168271c28"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1678), null },
                    { new Guid("e9b689e8-6daa-465a-827f-ee7ae401bbf5"), new Guid("30cae8a7-61a6-4efd-b24b-6a46fbce9130"), new Guid("58c651bf-d232-488c-bdd7-e00f6d782709"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(861), null },
                    { new Guid("e9fe3770-b565-42d3-89cc-21af0db81aa7"), new Guid("4ed2b14c-a136-4cd7-a35d-cf68c49966bf"), new Guid("87aa25a6-e526-4db3-b98c-fefdaf6bb4a4"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(275), null },
                    { new Guid("eaf5ef79-0013-48aa-b9c2-7fe7ebaa4b33"), new Guid("8d3d9c9c-e761-42f3-adfe-7fd10af6416e"), new Guid("cd013daf-4c1e-4101-887f-736f48a44de5"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1724), null },
                    { new Guid("ec073edd-e65d-4ec0-b130-20d1d2b06ed1"), new Guid("90e75ae1-88b0-4817-9131-297e0366d7f1"), new Guid("58c651bf-d232-488c-bdd7-e00f6d782709"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(647), null },
                    { new Guid("ed4e0949-780a-4236-b11a-30eed25aeefe"), new Guid("23486d58-ca9d-4dcb-8943-eb989c3e22f2"), new Guid("474be3f3-8c47-4b39-909e-945aed13b954"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(582), null },
                    { new Guid("ee88e4cd-66e1-4e32-9e30-5c5f8f345b5f"), new Guid("340a30eb-48e8-4ca5-b94c-25c8f3d830aa"), new Guid("e4386634-3511-4c82-9856-3881c6ea41ca"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9876), null },
                    { new Guid("ef102dfa-12d5-4e55-b498-0ef17609eb87"), new Guid("f1cc25b1-0c73-4051-8983-6c4a14dcb613"), new Guid("8f88c931-ec6f-422e-bb08-baf0f45ebee0"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(896), null },
                    { new Guid("f176a641-e69e-4f7a-9426-daf2e44664f3"), new Guid("94acf787-c999-4a29-b58f-5487692ef03f"), new Guid("5aa5aefd-8799-4758-a1de-f674f09d120f"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1197), null },
                    { new Guid("f17d1161-8219-4a0a-92f2-c95451449054"), new Guid("e298f4ee-ea09-4f70-87a2-bd895c2919f9"), new Guid("55721b5d-fb9c-4f51-8a4d-f89b229e15f6"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(989), null },
                    { new Guid("f61cecb3-9852-4224-a048-ceb696c580e3"), new Guid("7b0f7691-ca17-4900-a292-7c17a6057a77"), new Guid("474be3f3-8c47-4b39-909e-945aed13b954"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(694), null },
                    { new Guid("f64dbb19-ac4d-4043-8b50-86d7311dcd42"), new Guid("ac01968d-18f7-4183-b96b-ee83c0dc39de"), new Guid("6af3aa61-e3d8-4a30-b714-6f42c8907f9f"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1257), null },
                    { new Guid("f6a181ce-8b79-4e92-8063-ad733f2f7e03"), new Guid("a127cf02-7c43-49bb-8ff2-973daf877f17"), new Guid("4340af6f-b3ae-44cc-a751-41ffc606bafc"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(9791), null },
                    { new Guid("f892041a-a574-4ca3-acd2-698a44063c6d"), new Guid("85f019f7-7433-4924-a283-ce8f67fd35d8"), new Guid("55721b5d-fb9c-4f51-8a4d-f89b229e15f6"), new DateTime(2023, 5, 26, 20, 40, 50, 615, DateTimeKind.Local).AddTicks(8848), null },
                    { new Guid("f966cae8-ae2a-4a1e-8d2c-d27a74fdc286"), new Guid("2c6ce7a3-6f78-493b-ba85-acdafbfb8364"), new Guid("cd013daf-4c1e-4101-887f-736f48a44de5"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(1366), null },
                    { new Guid("fb4faf63-476d-4b68-b679-e855bdf4a3d8"), new Guid("995a4228-a065-4b77-9539-57d16fa48c28"), new Guid("4627831d-bab8-43da-b895-2763db534c22"), new DateTime(2023, 5, 26, 20, 40, 50, 616, DateTimeKind.Local).AddTicks(116), null }
                });
        }
    }
}
