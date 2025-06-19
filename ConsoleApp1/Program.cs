// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("우들 깃허브 리포지토리 Push 테스트입니다. ");
Console.WriteLine("커밋!! ");


 async Task<string> GetLatestVersionFromGitHub()
{
    using (HttpClient client = new HttpClient())
    {
        string url = "https://raw.githubusercontent.com/사용자명/저장소명/브랜치명/version.txt";
        try
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string version = await response.Content.ReadAsStringAsync();
            return version.Trim();
        }
        catch (Exception ex)
        {
            MessageBox.Show("버전 확인 실패: " + ex.Message);
            return null;
        }
    }
}