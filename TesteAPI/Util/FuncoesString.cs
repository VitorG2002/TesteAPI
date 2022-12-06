namespace TesteAPI.Util
{
    public class FuncoesString
    {
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);

        }
        public static string TirarPontosBarrasCNPJCPF(string _valor)
        {
            if (string.IsNullOrEmpty(_valor))
                return _valor;

            _valor = _valor.Replace(" ", "");
            _valor = _valor.Replace("'", "");
            _valor = _valor.Replace("-", "");
            _valor = _valor.Replace("(", "");
            _valor = _valor.Replace(")", "");
            _valor = _valor.Replace(".", "");
            _valor = _valor.Replace(",", "");
            _valor = _valor.Replace("/", "");
            _valor = _valor.Replace("\"", "");
            return _valor;
        }
    }
}
