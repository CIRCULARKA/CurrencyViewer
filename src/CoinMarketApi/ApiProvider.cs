using System.IO;

namespace CurrencyViewer.CoinMarketApi
{
	public class ApiProvider : IApiProvider
	{
		private StreamReader _reader;

		public ApiProvider(StreamReader reader) =>
			_reader = reader;

		/// <summary>
		/// Returns empty string if reader can not find target file with api
		/// </summary>
		public string GetApiKey()
		{
			try { return _reader.ReadLine(); }
			catch { return ""; }
			finally { _reader.Close(); }
		}
	}
}
