# Hello World in RabbitMQ

- [ ] Docker 
- [ ] Laravel
- [ ] Express / Hono


## 2026-09-27 - C# dot net

service 4 ကို dot net core နဲ့ ရေးမယ်။

ရိုးရိုး CRUD API Endpoint ပဲ ထုတ်ပေး။

person
phone
email
address
descritpion

ဒီလောက်ဆို ရပြီ။

```bash
mkdir service-4-dotnet
cd service-4-dotnet
dotnet new webapi --use-controllers
dotnet run
# hot reload ရအောင်လို့။

dotnet watch run

# git ignore file ရဖို့
dotnet new gitignore


http://localhost:5238/WeatherForecast 
ဒီကို သွားကြည့်ရင်
JSON ရပါမယ်။

[
{
"date": "2026-09-28",
"temperatureC": 46,
"temperatureF": 114,
"summary": "Balmy"
},
{
"date": "2026-09-29",
"temperatureC": -8,
"temperatureF": 18,
"summary": "Balmy"
},
{
"date": "2026-09-30",
"temperatureC": 35,
"temperatureF": 94,
"summary": "Scorching"
},
{
"date": "2026-10-01",
"temperatureC": 15,
"temperatureF": 58,
"summary": "Balmy"
},
{
"date": "2026-10-02",
"temperatureC": 33,
"temperatureF": 91,
"summary": "Sweltering"
}
]




PS D:\Cisco\Code\RabbitMQ\service-4-dotnet> dotnet --version
The command could not be loaded, possibly because:
  * You intended to execute a .NET application:
      The application '--version' does not exist.
  * You intended to execute a .NET SDK command:
      No .NET SDKs were found.

Download a .NET SDK:
https://aka.ms/dotnet/download

Learn about SDK resolution:
https://aka.ms/dotnet/sdk-not-found


```


dotnet က ထည့်ကို မထားရသေးတာ။
အရင်က ထည့်ထားတာ ဘယ်ရောက်သွားလဲမသိ။
Uninstall လုပ်တာ လက်လွန်သွားတာ ဖြစ်မယ်။


https://dotnet.microsoft.com/en-us/download/dotnet/

ဒီမှာ ပြန်သွားဒေါင်း။
.NET 10.0 SDK တဲ့။
dotnet-sdk-10.0.401-win-x64.exe

200 MB လောက်ရှိတယ်။


PS D:\Cisco\Code\RabbitMQ> dotnet --version
10.0.401

အဆင်ပြေသွားပြီ။

## 2026-09-26 Sat - Hello World
ဘာစနစ်လုပ်မလဲ?

User Management
- Personal Graph


Let create personal graph, that we can store 
Person Information (Name, and others basic info )

Another Service will be handle about
Relationship? 
or self? 

Currently I don't have strong resons to used Microservice and RabbitMQ.
Let's start with Hello World.

Service 1 - Laravel
Service 2 - Express.js
Service 3 - Hono

All Deployed via Docker.

let's start.

--

For quick setup,
let's use expres and hono

```bash
docker-compose up --build
```

let's test the api

```bash
http://localhost:3001/add-person/AungKo


http://localhost:15672
```


RabbitMQ ရဲ့ Management UI ကို ကြည့်ချင်ရင် Browser မှာ http://localhost:15672 ကို ဝင်ပါ။ (Username: guest , Password: guest) ဆိုပြီး ဝင်ကြည့်လို့ရပါတယ်။

Very nice,
Hello on publishing and listening is ok.

နောက်တစ်ခုက load balancing လိုမျိုးမျိုး event တစ်ခုကို service (၂) ခု (၃) ခုက တစ်လှည့်စီယူပြီး လုပ်ကြတာလည်း ရှိမယ်။

ဘာတွေ စစမ်းရမလဲ?

သက်ဆိုင်ရာ service က ပဲ pick လုပ်ပြီး အလုပ်လုပ်ရမယ်။ ack ပြန်ပို့ရမယ်။
ဒါမှ publisher က status ကို သိရမှာ။

ဒါကို အရင် စမ်းကြည့်ကြမယ်။

ဆိုကြပါစို့။

Email ပို့မယ်။

Service 1 -> api ဘက်က ဝင်လာပြီ။ ဒီ လိပ်စာကို email ပို့ပေးပါ။
ဒါနဲ့ လိုတဲ့ အချက်အလက်တွေကို Event တစ်ခု ဖန်တီးပြီး Email Notification Channel မှာ ပို့လိုက်မယ်။

Service 2 က Email ပို့ပေးတဲ့ ဝန်ဆောင်မှု ပေးနေတယ် ဆိုကြပါစို့။
သူက pick လုပ်မယ်။ 
သူ pick လုပ်ပြီး processing လုပ်နေပါတယ် ဆိုတာကိုလည်း service 1 က သိသင့်တယ်။ ဒါမှ ဒီ Job အတွက် track , status update လုပ်ရမယ်။
email ပို့ရင် ပို့ပြီးပြီ၊
ပို့လို့် မရရင်လည်း လိပ်စာက deliveryable မဖြစ်ပါဘူး ဘာညာကို ပြန်ပြောသင့်တယ်။

ဘယ်လို ပြောမလဲ?

service 1 က listen ပြန်လုပ်ရမယ့် အနေအထားမျိုး ဖြစ်မယ်။
Rabbit MQ ကတော့  api server လိုမျိုး ပြန်ပြောနေမလား?

ဒါမှ မဟုတ်။

service 1 ကနေ service 2 ကို api to api ပဲ တိုက်ရိုက်လှမ်းမေးကြမလား?
service 2 ကပဲ service 1 ကို web hook နဲ့ ပြန်ပြောမလား/

ရှည်လျားလှတဲ့ မေးခွန်းတွေပါပဲ။

တစ်နည်းချင်းစီ လုပ်ကြည့်ကြမယ်။
လက်ရှိ point က အကောင်းဆုံး solution ကို ရှာဖို့ မဟုတ်ပဲ
သင်ယူဖို့
how things work ကို သင်ယူဖို့။



1. API to API ( Long Polling ပုံစံ)
2. Webhook ( ဒါကတော့ callback ပြန်ခေါ်ပေးတာ)
3. RabbitMQ RPC Pattern 


မိုက်သွားပြီဟေ့။

```bash
http://localhost:3001/send-email/cisco@mail.com
```

```json

{
    "message": "Email request accepted and is processing in background.",
    "jobId": "7bd6d8a9-3568-4774-94f7-e5cf2267ada9",
    "trackUrl": "http://localhost:3001/track/7bd6d8a9-3568-4774-94f7-e5cf2267ada9"
}

```

```bash
http://localhost:3001/track/7bd6d8a9-3568-4774-94f7-e5cf2267ada9
```

```json

{
    "jobId": "7bd6d8a9-3568-4774-94f7-e5cf2267ada9",
    "data": {
        "status": "PENDING",
        "details": null
    }
}
```


```bash
http://localhost:3001/track/7bd6d8a9-3568-4774-94f7-e5cf2267ada9
```

```json

{
    "jobId": "7bd6d8a9-3568-4774-94f7-e5cf2267ada9",
    "data": {
        "status": "COMPLETED",
        "details": {
            "target": "cisco@mail.com",
            "status": "DELIVERED",
            "reason": "Sent successfully to Mail server",
            "timestamp": "2026-09-26T15:14:09.404Z"
        }
    }
}
```

