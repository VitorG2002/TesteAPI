using System.IO.Compression;
using System.Text.RegularExpressions;

namespace TesteAPI.Util
{
    public class FuncoesArquivos
    {
        private static Regex ALL_Z_REGEX = new Regex("^[zZ]+$");
        public const string EXTENSAO_EXE = "exe";
        public const string EXTENSAO_COM = "com";
        public const string EXTENSAO_DLL = "dll";
        public const string EXTENSAO_SCR = "scr";
        public const string EXTENSAO_CMB = "cmb";
        public const string EXTENSAO_BAT = "bat";
        public const string EXTENSAO_DAT = "dat";
        public const string EXTENSAO_ZIP = "zip";
        public const string EXTENSAO_VBS = "vbs";
        public const string EXTENSAO_WS = "ws";
        public const string EXTENSAO_SYS = "sys";
        public const string EXTENSAO_BIN = "bin";
        public const string EXTENSAO_PFX = "pfx";
        public const string EXTENSAO_CER = "cer";
        public const string EXTENSAO_TBB = "tbb";
        public const string EXTENSAO_XLS = "xls";
        public const string EXTENSAO_XLSX = "xlsx";
        public const string EXTENSAO_XML = "xml";
        public const string EXTENSAO_PDF = "pdf";
        public const string EXTENSAO_HTML = "html";
        public const string EXTENSAO_TXT = "txt";
        public const string EXTENSAO_DOC = "doc";
        public const string EXTENSAO_DOCX = "docx";
        public const string EXTENSAO_CSV = "csv";
        public const string EXTENSAO_RPT = "rpt";
        public const string EXTENSAO_JPG = "jpg";
        public const string EXTENSAO_JPEG = "jpeg";
        public const string EXTENSAO_PNG = "png";
        public const string EXTENSAO_GIF = "gif";
        public const string EXTENSAO_TIF = "tif";
        public const string EXTENSAO_BMP = "bmp";
        public const string EXTENSAO_PPT = "ppt";
        public const string EXTENSAO_PPTX = "pptx";
        public const string EXTENSAO_JSON = "json";



        public static string prepararNomeArquivo(string _valor)
        {
            string valor = _valor;
            valor = valor.Replace("\\", "");
            valor = valor.Replace("/", "");
            valor = valor.Replace(":", "");
            valor = valor.Replace("*", "");
            valor = valor.Replace("?", "");
            valor = valor.Replace("&", "");
            valor = valor.Replace("'", "");
            valor = valor.Replace("\"", "");
            valor = valor.Replace("<", "");
            valor = valor.Replace(">", "");
            valor = valor.Replace("|", "");
            valor = valor.Replace("+", "");
            return valor;
        }

        public static string GerarNomeArquivoTemporario(string _identificacao, string _extensao, string _codigoUsuario = "0")
        {
            return GerarNomeArquivoTemporarioGuid(_identificacao, _extensao, _codigoUsuario);
        }

        public static string GerarNomeArquivoTemporarioGuid(string _identificacao, string _extensao, string _codigoUsuario = "0")
        {
            if (string.IsNullOrEmpty(_codigoUsuario))
            {
                _codigoUsuario = "";
            }

            Random rnd = new Random();
            _codigoUsuario = _codigoUsuario + "_" + rnd.Next().ToString();


            if (_extensao.StartsWith("."))
                return prepararNomeArquivo(_identificacao + _codigoUsuario + Guid.NewGuid()) + _extensao;
            else
                return prepararNomeArquivo(_identificacao + _codigoUsuario + Guid.NewGuid()) + "." + _extensao;

        }


        public static string VerificarSeArquivoExiste(string _arquivo)
        {
            if (File.Exists(_arquivo))
                return _arquivo;
            return "";
        }

        public static string GetProximaColunaExcel(string _currentColumn)
        {
            if (string.IsNullOrEmpty(_currentColumn))
                return "A";

            char lastPosition = _currentColumn[_currentColumn.Length - 1];

            if (ALL_Z_REGEX.IsMatch(_currentColumn))
            {
                string result = string.Empty;
                for (int i = 0; i < _currentColumn.Length; i++)
                    result += "A";
                return result + "A";
            }
            else if (lastPosition == 'Z')
                return GetProximaColunaExcel(_currentColumn.Remove(_currentColumn.Length - 1, 1)) + "A";
            else
                return _currentColumn.Remove(_currentColumn.Length - 1, 1) + (++lastPosition).ToString();
        }

        public static string Descompactar(byte[] conteudo)
        {
            using (var memory = new MemoryStream(conteudo))
            using (var compression = new GZipStream(memory, CompressionMode.Decompress))
            using (var reader = new StreamReader(compression))
            {
                return reader.ReadToEnd();
            }
        }

    }
}
