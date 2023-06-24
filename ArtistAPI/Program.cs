var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddXmlDataContractSerializerFormatters();

ArtistServiceReference1.ArtistSoapClient servis1 = new ArtistServiceReference1.ArtistSoapClient(ArtistServiceReference1.ArtistSoapClient.EndpointConfiguration.ArtistSoap);

builder.Services.AddSingleton(servis1);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//string res = servis1.GetAll();
//string res1 = servis1.FindByName("Ivan");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Urls.Add("http://0.0.0.0:5071");

app.UseAuthorization();

app.MapControllers();

app.Run();
