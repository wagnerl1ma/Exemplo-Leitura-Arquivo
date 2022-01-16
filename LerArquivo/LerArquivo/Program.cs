
//Leitura de arquivos CSV usando o System.File

const string caminhoArquivoCSV = @"C:\Users\Wagner\Documents\PROJETOS\Teste Leitura de Arquivos\Teste.csv";

//var dados = File.ReadAllText(caminhoArquivoCSV);
//Console.WriteLine(dados);


//Ler arquivo linha por linha
var lines = File.ReadAllLines(caminhoArquivoCSV);
foreach (var line in lines)
    Console.WriteLine(line);


//Leitura de arquivos CSV usando o StreamReader

//antigo jeito de usar o using:
//using (var arquivoCSV2 = new StreamReader(caminhoArquivoCSV))
//{
//    string? linha2;
//    var listaProp2 = new List<string>();

//    while ((linha2 = arquivoCSV2.ReadLine()) != null)
//    {
//        listaProp2.Add(linha2);
//        Console.WriteLine(linha2);
//    }


//    arquivoCSV2.Close();

//    Console.WriteLine($"Quantidade de linhas na lista: {listaProp2.Count}");
//}

//// novo jeito de usar o using:    
using var arquivoCSV = new StreamReader(caminhoArquivoCSV);
string? linha;

var listaProp = new List<string>();

while ((linha = arquivoCSV.ReadLine()) != null)
{
    listaProp.Add(linha);
    Console.WriteLine(linha);
}


arquivoCSV.Close();


Console.WriteLine($"Quantidade de linhas na lista: {listaProp.Count}");
