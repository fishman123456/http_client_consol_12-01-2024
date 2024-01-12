namespace http_client_consol_12_01_2024
{

    class Program
    {
        static async Task Main(string[] args)
        {
            using var client = new HttpClient();

            var result = await client.GetAsync("http://webcode.me");
            Console.WriteLine(result.StatusCode);
            var content = await client.GetStringAsync("http://webcode.me");

            Console.WriteLine(content);
        }
    }
}

/*
Задание.
1.Посмотреть лекцию: https://www.youtube.com/watch?v=PpdQQjPS0MA
Подготовить вопросы по теме лекции.
2. Выбрать открытый API с бесплатным доступом. Реализовать для него десктопный http-клиент на языке C#.
API, которые можно использовать:
1.numbers api: http://numbersapi.com/#42
2.weather api: https://openweathermap.org/api
3.github api: https://api.github.com/
4.movies: https://www.omdbapi.com/
5.quotas: https://zenquotes.io/
*/