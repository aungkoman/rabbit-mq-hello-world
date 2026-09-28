# Development အတွက် SDK ကိုပဲ သုံးပါမယ်
FROM mcr.microsoft.com/dotnet/sdk:10.0
WORKDIR /app

EXPOSE 8080

# dotnet watch ဖြင့် Hot Reload ဖွင့်ထားပါသည်
CMD ["dotnet", "watch", "run", "--urls", "http://0.0.0.0:8080"]