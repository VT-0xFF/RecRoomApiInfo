using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Timers;
using WebSocketSharp.Net;
using WebSocketSharp.Net.WebSockets;
using WebSocketSharp.Server;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue | DebuggableAttribute.DebuggingModes.DisableOptimizations)]
[assembly: AssemblyTitle("websocket-sharp")]
[assembly: AssemblyDescription("A C# implementation of the WebSocket protocol client and server")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("websocket-sharp.dll")]
[assembly: AssemblyCopyright("sta.blockhead")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyVersion("1.0.2.28118")]
namespace WebSocketSharp
{
	public static class Ext
	{
		private static readonly byte[] _last = new byte[1];

		private static readonly int _retry = 5;

		private const string _tspecials = "()<>@,;:\\\"/[]?={} \t";

		private static byte[] compress(this byte[] data)
		{
			if (data.LongLength == 0)
			{
				return data;
			}
			using MemoryStream stream = new MemoryStream(data);
			return stream.compressToArray();
		}

		private static MemoryStream compress(this Stream stream)
		{
			MemoryStream memoryStream = new MemoryStream();
			if (stream.Length == 0)
			{
				return memoryStream;
			}
			stream.Position = 0L;
			using DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
			stream.CopyTo(deflateStream, 1024);
			deflateStream.Close();
			memoryStream.Write(_last, 0, 1);
			memoryStream.Position = 0L;
			return memoryStream;
		}

		private static byte[] compressToArray(this Stream stream)
		{
			using MemoryStream memoryStream = stream.compress();
			memoryStream.Close();
			return memoryStream.ToArray();
		}

		private static byte[] decompress(this byte[] data)
		{
			if (data.LongLength == 0)
			{
				return data;
			}
			using MemoryStream stream = new MemoryStream(data);
			return stream.decompressToArray();
		}

		private static MemoryStream decompress(this Stream stream)
		{
			MemoryStream memoryStream = new MemoryStream();
			if (stream.Length == 0)
			{
				return memoryStream;
			}
			stream.Position = 0L;
			using DeflateStream source = new DeflateStream(stream, CompressionMode.Decompress, leaveOpen: true);
			source.CopyTo(memoryStream, 1024);
			memoryStream.Position = 0L;
			return memoryStream;
		}

		private static byte[] decompressToArray(this Stream stream)
		{
			using MemoryStream memoryStream = stream.decompress();
			memoryStream.Close();
			return memoryStream.ToArray();
		}

		private static void times(this ulong n, Action action)
		{
			for (ulong num = 0uL; num < n; num++)
			{
				action();
			}
		}

		internal static byte[] Append(this ushort code, string reason)
		{
			byte[] array = code.InternalToByteArray(ByteOrder.Big);
			if (reason != null && reason.Length > 0)
			{
				List<byte> list = new List<byte>(array);
				list.AddRange(Encoding.UTF8.GetBytes(reason));
				array = list.ToArray();
			}
			return array;
		}

		internal static string CheckIfAvailable(this ServerState state, bool ready, bool start, bool shutting)
		{
			return ((!ready && (state == ServerState.Ready || state == ServerState.Stop)) || (!start && state == ServerState.Start) || (!shutting && state == ServerState.ShuttingDown)) ? ("This operation isn't available in: " + state.ToString().ToLower()) : null;
		}

		internal static string CheckIfAvailable(this WebSocketState state, bool connecting, bool open, bool closing, bool closed)
		{
			return ((!connecting && state == WebSocketState.Connecting) || (!open && state == WebSocketState.Open) || (!closing && state == WebSocketState.Closing) || (!closed && state == WebSocketState.Closed)) ? ("This operation isn't available in: " + state.ToString().ToLower()) : null;
		}

		internal static string CheckIfValidProtocols(this string[] protocols)
		{
			return protocols.Contains((string protocol) => protocol == null || protocol.Length == 0 || !protocol.IsToken()) ? "Contains an invalid value." : (protocols.ContainsTwice() ? "Contains a value twice." : null);
		}

		internal static string CheckIfValidServicePath(this string path)
		{
			return (path == null || path.Length == 0) ? "'path' is null or empty." : ((path[0] != '/') ? "'path' isn't an absolute path." : ((path.IndexOfAny(new char[2] { '?', '#' }) > -1) ? "'path' includes either or both query and fragment components." : null));
		}

		internal static string CheckIfValidSessionID(this string id)
		{
			return (id == null || id.Length == 0) ? "'id' is null or empty." : null;
		}

		internal static string CheckIfValidWaitTime(this TimeSpan time)
		{
			return (time <= TimeSpan.Zero) ? "A wait time is zero or less." : null;
		}

		internal static bool CheckWaitTime(this TimeSpan time, out string message)
		{
			message = null;
			if (time <= TimeSpan.Zero)
			{
				message = "A wait time is zero or less.";
				return false;
			}
			return true;
		}

		internal static void Close(this WebSocketSharp.Net.HttpListenerResponse response, WebSocketSharp.Net.HttpStatusCode code)
		{
			response.StatusCode = (int)code;
			response.OutputStream.Close();
		}

		internal static void CloseWithAuthChallenge(this WebSocketSharp.Net.HttpListenerResponse response, string challenge)
		{
			response.Headers.InternalSet("WWW-Authenticate", challenge, response: true);
			response.Close(WebSocketSharp.Net.HttpStatusCode.Unauthorized);
		}

		internal static byte[] Compress(this byte[] data, CompressionMethod method)
		{
			return (method == CompressionMethod.Deflate) ? data.compress() : data;
		}

		internal static Stream Compress(this Stream stream, CompressionMethod method)
		{
			return (method == CompressionMethod.Deflate) ? stream.compress() : stream;
		}

		internal static byte[] CompressToArray(this Stream stream, CompressionMethod method)
		{
			return (method == CompressionMethod.Deflate) ? stream.compressToArray() : stream.ToByteArray();
		}

		internal static bool Contains<T>(this IEnumerable<T> source, Func<T, bool> condition)
		{
			foreach (T item in source)
			{
				if (condition(item))
				{
					return true;
				}
			}
			return false;
		}

		internal static bool ContainsTwice(this string[] values)
		{
			int len = values.Length;
			Func<int, bool> contains = null;
			contains = delegate(int idx)
			{
				if (idx < len - 1)
				{
					for (int i = idx + 1; i < len; i++)
					{
						if (values[i] == values[idx])
						{
							return true;
						}
					}
					return contains(++idx);
				}
				return false;
			};
			return contains(0);
		}

		internal static T[] Copy<T>(this T[] source, long length)
		{
			T[] array = new T[length];
			Array.Copy(source, 0L, array, 0L, length);
			return array;
		}

		internal static void CopyTo(this Stream source, Stream destination, int bufferLength)
		{
			byte[] buffer = new byte[bufferLength];
			int num = 0;
			while ((num = source.Read(buffer, 0, bufferLength)) > 0)
			{
				destination.Write(buffer, 0, num);
			}
		}

		internal static void CopyToAsync(this Stream source, Stream destination, int bufferLength, Action completed, Action<Exception> error)
		{
			byte[] buff = new byte[bufferLength];
			AsyncCallback callback = null;
			callback = delegate(IAsyncResult ar)
			{
				try
				{
					int num = source.EndRead(ar);
					if (num <= 0)
					{
						if (completed != null)
						{
							completed();
						}
					}
					else
					{
						destination.Write(buff, 0, num);
						source.BeginRead(buff, 0, bufferLength, callback, null);
					}
				}
				catch (Exception obj2)
				{
					if (error != null)
					{
						error(obj2);
					}
				}
			};
			try
			{
				source.BeginRead(buff, 0, bufferLength, callback, null);
			}
			catch (Exception obj)
			{
				if (error != null)
				{
					error(obj);
				}
			}
		}

		internal static byte[] Decompress(this byte[] data, CompressionMethod method)
		{
			return (method == CompressionMethod.Deflate) ? data.decompress() : data;
		}

		internal static Stream Decompress(this Stream stream, CompressionMethod method)
		{
			return (method == CompressionMethod.Deflate) ? stream.decompress() : stream;
		}

		internal static byte[] DecompressToArray(this Stream stream, CompressionMethod method)
		{
			return (method == CompressionMethod.Deflate) ? stream.decompressToArray() : stream.ToByteArray();
		}

		internal static bool EqualsWith(this int value, char c, Action<int> action)
		{
			action(value);
			return value == c;
		}

		internal static string GetAbsolutePath(this Uri uri)
		{
			if (uri.IsAbsoluteUri)
			{
				return uri.AbsolutePath;
			}
			string originalString = uri.OriginalString;
			if (originalString[0] != '/')
			{
				return null;
			}
			int num = originalString.IndexOfAny(new char[2] { '?', '#' });
			return (num > 0) ? originalString.Substring(0, num) : originalString;
		}

		internal static string GetMessage(this CloseStatusCode code)
		{
			return code switch
			{
				CloseStatusCode.TlsHandshakeFailure => "An error has occurred during a TLS handshake.", 
				CloseStatusCode.ServerError => "WebSocket server got an internal error.", 
				CloseStatusCode.MandatoryExtension => "WebSocket client didn't receive expected extension(s).", 
				CloseStatusCode.TooBig => "A too big message has been received.", 
				CloseStatusCode.PolicyViolation => "A policy violation has occurred.", 
				CloseStatusCode.InvalidData => "Invalid data has been received.", 
				CloseStatusCode.Abnormal => "An exception has occurred.", 
				CloseStatusCode.UnsupportedData => "Unsupported data has been received.", 
				CloseStatusCode.ProtocolError => "A WebSocket protocol error has occurred.", 
				_ => string.Empty, 
			};
		}

		internal static string GetName(this string nameAndValue, char separator)
		{
			int num = nameAndValue.IndexOf(separator);
			return (num > 0) ? nameAndValue.Substring(0, num).Trim() : null;
		}

		internal static string GetValue(this string nameAndValue, char separator)
		{
			int num = nameAndValue.IndexOf(separator);
			return (num > -1 && num < nameAndValue.Length - 1) ? nameAndValue.Substring(num + 1).Trim() : null;
		}

		internal static string GetValue(this string nameAndValue, char separator, bool unquote)
		{
			int num = nameAndValue.IndexOf(separator);
			if (num < 0 || num == nameAndValue.Length - 1)
			{
				return null;
			}
			string text = nameAndValue.Substring(num + 1).Trim();
			return unquote ? text.Unquote() : text;
		}

		internal static TcpListenerWebSocketContext GetWebSocketContext(this TcpClient tcpClient, string protocol, bool secure, ServerSslConfiguration sslConfig, Logger logger)
		{
			return new TcpListenerWebSocketContext(tcpClient, protocol, secure, sslConfig, logger);
		}

		internal static byte[] InternalToByteArray(this ushort value, ByteOrder order)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			if (!order.IsHostOrder())
			{
				Array.Reverse(bytes);
			}
			return bytes;
		}

		internal static byte[] InternalToByteArray(this ulong value, ByteOrder order)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			if (!order.IsHostOrder())
			{
				Array.Reverse(bytes);
			}
			return bytes;
		}

		internal static bool IsCompressionExtension(this string value, CompressionMethod method)
		{
			return value.StartsWith(method.ToExtensionString());
		}

		internal static bool IsControl(this byte opcode)
		{
			return opcode > 7 && opcode < 16;
		}

		internal static bool IsControl(this Opcode opcode)
		{
			return (int)opcode >= 8;
		}

		internal static bool IsData(this byte opcode)
		{
			return opcode == 1 || opcode == 2;
		}

		internal static bool IsData(this Opcode opcode)
		{
			return opcode == Opcode.Text || opcode == Opcode.Binary;
		}

		internal static bool IsPortNumber(this int value)
		{
			return value > 0 && value < 65536;
		}

		internal static bool IsReserved(this ushort code)
		{
			return code == 1004 || code == 1005 || code == 1006 || code == 1015;
		}

		internal static bool IsReserved(this CloseStatusCode code)
		{
			return code == CloseStatusCode.Undefined || code == CloseStatusCode.NoStatus || code == CloseStatusCode.Abnormal || code == CloseStatusCode.TlsHandshakeFailure;
		}

		internal static bool IsSupported(this byte opcode)
		{
			return Enum.IsDefined(typeof(Opcode), opcode);
		}

		internal static bool IsText(this string value)
		{
			int length = value.Length;
			for (int i = 0; i < length; i++)
			{
				char c = value[i];
				if (c < ' ' && !"\r\n\t".Contains(c))
				{
					return false;
				}
				switch (c)
				{
				case '\u007f':
					return false;
				case '\n':
					if (++i < length)
					{
						c = value[i];
						if (!" \t".Contains(c))
						{
							return false;
						}
					}
					break;
				}
			}
			return true;
		}

		internal static bool IsToken(this string value)
		{
			foreach (char c in value)
			{
				if (c < ' ' || c >= '\u007f' || "()<>@,;:\\\"/[]?={} \t".Contains(c))
				{
					return false;
				}
			}
			return true;
		}

		internal static string Quote(this string value)
		{
			return string.Format("\"{0}\"", value.Replace("\"", "\\\""));
		}

		internal static byte[] ReadBytes(this Stream stream, int length)
		{
			byte[] array = new byte[length];
			int num = 0;
			try
			{
				int num2 = 0;
				while (length > 0)
				{
					num2 = stream.Read(array, num, length);
					if (num2 == 0)
					{
						break;
					}
					num += num2;
					length -= num2;
				}
			}
			catch
			{
			}
			return array.SubArray(0, num);
		}

		internal static byte[] ReadBytes(this Stream stream, long length, int bufferLength)
		{
			using MemoryStream memoryStream = new MemoryStream();
			try
			{
				byte[] buffer = new byte[bufferLength];
				int num = 0;
				while (length > 0)
				{
					if (length < bufferLength)
					{
						bufferLength = (int)length;
					}
					num = stream.Read(buffer, 0, bufferLength);
					if (num == 0)
					{
						break;
					}
					memoryStream.Write(buffer, 0, num);
					length -= num;
				}
			}
			catch
			{
			}
			memoryStream.Close();
			return memoryStream.ToArray();
		}

		internal static void ReadBytesAsync(this Stream stream, int length, Action<byte[]> completed, Action<Exception> error)
		{
			byte[] buff = new byte[length];
			int offset = 0;
			int retry = 0;
			AsyncCallback callback = null;
			callback = delegate(IAsyncResult ar)
			{
				try
				{
					int num = stream.EndRead(ar);
					if (num == 0 && retry < _retry)
					{
						retry++;
						stream.BeginRead(buff, offset, length, callback, null);
					}
					else if (num == 0 || num == length)
					{
						if (completed != null)
						{
							completed(buff.SubArray(0, offset + num));
						}
					}
					else
					{
						retry = 0;
						offset += num;
						length -= num;
						stream.BeginRead(buff, offset, length, callback, null);
					}
				}
				catch (Exception obj2)
				{
					if (error != null)
					{
						error(obj2);
					}
				}
			};
			try
			{
				stream.BeginRead(buff, offset, length, callback, null);
			}
			catch (Exception obj)
			{
				if (error != null)
				{
					error(obj);
				}
			}
		}

		internal static void ReadBytesAsync(this Stream stream, long length, int bufferLength, Action<byte[]> completed, Action<Exception> error)
		{
			MemoryStream dest = new MemoryStream();
			byte[] buff = new byte[bufferLength];
			int retry = 0;
			Action<long> read = null;
			read = delegate(long len)
			{
				if (len < bufferLength)
				{
					bufferLength = (int)len;
				}
				stream.BeginRead(buff, 0, bufferLength, delegate(IAsyncResult ar)
				{
					try
					{
						int num = stream.EndRead(ar);
						if (num > 0)
						{
							dest.Write(buff, 0, num);
						}
						if (num == 0 && retry < _retry)
						{
							int num2 = retry;
							retry = num2 + 1;
							read(len);
						}
						else if (num == 0 || num == len)
						{
							if (completed != null)
							{
								dest.Close();
								completed(dest.ToArray());
							}
							dest.Dispose();
						}
						else
						{
							retry = 0;
							read(len - num);
						}
					}
					catch (Exception obj2)
					{
						dest.Dispose();
						if (error != null)
						{
							error(obj2);
						}
					}
				}, null);
			};
			try
			{
				read(length);
			}
			catch (Exception obj)
			{
				dest.Dispose();
				if (error != null)
				{
					error(obj);
				}
			}
		}

		internal static string RemovePrefix(this string value, params string[] prefixes)
		{
			int num = 0;
			foreach (string text in prefixes)
			{
				if (value.StartsWith(text))
				{
					num = text.Length;
					break;
				}
			}
			return (num > 0) ? value.Substring(num) : value;
		}

		internal static T[] Reverse<T>(this T[] array)
		{
			int num = array.Length;
			T[] array2 = new T[num];
			int num2 = num - 1;
			for (int i = 0; i <= num2; i++)
			{
				array2[i] = array[num2 - i];
			}
			return array2;
		}

		internal static IEnumerable<string> SplitHeaderValue(this string value, params char[] separators)
		{
			int len = value.Length;
			string seps = new string(separators);
			StringBuilder buff = new StringBuilder(32);
			bool escaped = false;
			bool quoted = false;
			for (int i = 0; i < len; i++)
			{
				char c = value[i];
				switch (c)
				{
				case '"':
					if (escaped)
					{
						escaped = !escaped;
					}
					else
					{
						quoted = !quoted;
					}
					break;
				case '\\':
					if (i < len - 1 && value[i + 1] == '"')
					{
						escaped = true;
					}
					break;
				default:
					if (seps.Contains(c) && !quoted)
					{
						yield return buff.ToString();
						buff.Length = 0;
						continue;
					}
					break;
				}
				buff.Append(c);
			}
			if (buff.Length > 0)
			{
				yield return buff.ToString();
			}
		}

		internal static byte[] ToByteArray(this Stream stream)
		{
			using MemoryStream memoryStream = new MemoryStream();
			stream.Position = 0L;
			stream.CopyTo(memoryStream, 1024);
			memoryStream.Close();
			return memoryStream.ToArray();
		}

		internal static CompressionMethod ToCompressionMethod(this string value)
		{
			foreach (CompressionMethod value2 in Enum.GetValues(typeof(CompressionMethod)))
			{
				if (value2.ToExtensionString() == value)
				{
					return value2;
				}
			}
			return CompressionMethod.None;
		}

		internal static string ToExtensionString(this CompressionMethod method, params string[] parameters)
		{
			if (method == CompressionMethod.None)
			{
				return string.Empty;
			}
			string text = $"permessage-{method.ToString().ToLower()}";
			if (parameters == null || parameters.Length == 0)
			{
				return text;
			}
			return string.Format("{0}; {1}", text, parameters.ToString("; "));
		}

		internal static IPAddress ToIPAddress(this string hostnameOrAddress)
		{
			if (IPAddress.TryParse(hostnameOrAddress, out var address))
			{
				return address;
			}
			try
			{
				return Dns.GetHostAddresses(hostnameOrAddress)[0];
			}
			catch
			{
				return null;
			}
		}

		internal static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			return new List<TSource>(source);
		}

		internal static ushort ToUInt16(this byte[] source, ByteOrder sourceOrder)
		{
			return BitConverter.ToUInt16(source.ToHostOrder(sourceOrder), 0);
		}

		internal static ulong ToUInt64(this byte[] source, ByteOrder sourceOrder)
		{
			return BitConverter.ToUInt64(source.ToHostOrder(sourceOrder), 0);
		}

		internal static string TrimEndSlash(this string value)
		{
			value = value.TrimEnd('/');
			return (value.Length > 0) ? value : "/";
		}

		internal static bool TryCreateWebSocketUri(this string uriString, out Uri result, out string message)
		{
			result = null;
			Uri uri = uriString.ToUri();
			if (uri == null)
			{
				message = "An invalid URI string: " + uriString;
				return false;
			}
			if (!uri.IsAbsoluteUri)
			{
				message = "Not an absolute URI: " + uriString;
				return false;
			}
			string scheme = uri.Scheme;
			if (!(scheme == "ws") && !(scheme == "wss"))
			{
				message = "The scheme part isn't 'ws' or 'wss': " + uriString;
				return false;
			}
			if (uri.Fragment.Length > 0)
			{
				message = "Includes the fragment component: " + uriString;
				return false;
			}
			int port = uri.Port;
			if (port == 0)
			{
				message = "The port part is zero: " + uriString;
				return false;
			}
			result = ((port != -1) ? uri : new Uri(string.Format("{0}://{1}:{2}{3}", scheme, uri.Host, (scheme == "ws") ? 80 : 443, uri.PathAndQuery)));
			message = string.Empty;
			return true;
		}

		internal static string Unquote(this string value)
		{
			int num = value.IndexOf('"');
			if (num < 0)
			{
				return value;
			}
			int num2 = value.LastIndexOf('"');
			int num3 = num2 - num - 1;
			return (num3 < 0) ? value : ((num3 == 0) ? string.Empty : value.Substring(num + 1, num3).Replace("\\\"", "\""));
		}

		internal static string UTF8Decode(this byte[] bytes)
		{
			try
			{
				return Encoding.UTF8.GetString(bytes);
			}
			catch
			{
				return null;
			}
		}

		internal static byte[] UTF8Encode(this string s)
		{
			return Encoding.UTF8.GetBytes(s);
		}

		internal static void WriteBytes(this Stream stream, byte[] bytes, int bufferLength)
		{
			using MemoryStream source = new MemoryStream(bytes);
			source.CopyTo(stream, bufferLength);
		}

		internal static void WriteBytesAsync(this Stream stream, byte[] bytes, int bufferLength, Action completed, Action<Exception> error)
		{
			MemoryStream input = new MemoryStream(bytes);
			input.CopyToAsync(stream, bufferLength, delegate
			{
				if (completed != null)
				{
					completed();
				}
				input.Dispose();
			}, delegate(Exception ex)
			{
				input.Dispose();
				if (error != null)
				{
					error(ex);
				}
			});
		}

		public static bool Contains(this string value, params char[] chars)
		{
			return chars == null || chars.Length == 0 || (value != null && value.Length != 0 && value.IndexOfAny(chars) > -1);
		}

		public static bool Contains(this NameValueCollection collection, string name)
		{
			return collection != null && collection.Count > 0 && collection[name] != null;
		}

		public static bool Contains(this NameValueCollection collection, string name, string value)
		{
			if (collection == null || collection.Count == 0)
			{
				return false;
			}
			string text = collection[name];
			if (text == null)
			{
				return false;
			}
			string[] array = text.Split(',');
			foreach (string text2 in array)
			{
				if (text2.Trim().Equals(value, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
			return false;
		}

		public static void Emit(this EventHandler eventHandler, object sender, EventArgs e)
		{
			eventHandler?.Invoke(sender, e);
		}

		public static void Emit<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e) where TEventArgs : EventArgs
		{
			eventHandler?.Invoke(sender, e);
		}

		public static WebSocketSharp.Net.CookieCollection GetCookies(this NameValueCollection headers, bool response)
		{
			string name = (response ? "Set-Cookie" : "Cookie");
			return (headers != null && headers.Contains(name)) ? WebSocketSharp.Net.CookieCollection.Parse(headers[name], response) : new WebSocketSharp.Net.CookieCollection();
		}

		public static string GetDescription(this WebSocketSharp.Net.HttpStatusCode code)
		{
			return ((int)code).GetStatusDescription();
		}

		public static string GetStatusDescription(this int code)
		{
			return code switch
			{
				100 => "Continue", 
				101 => "Switching Protocols", 
				102 => "Processing", 
				200 => "OK", 
				201 => "Created", 
				202 => "Accepted", 
				203 => "Non-Authoritative Information", 
				204 => "No Content", 
				205 => "Reset Content", 
				206 => "Partial Content", 
				207 => "Multi-Status", 
				300 => "Multiple Choices", 
				301 => "Moved Permanently", 
				302 => "Found", 
				303 => "See Other", 
				304 => "Not Modified", 
				305 => "Use Proxy", 
				307 => "Temporary Redirect", 
				400 => "Bad Request", 
				401 => "Unauthorized", 
				402 => "Payment Required", 
				403 => "Forbidden", 
				404 => "Not Found", 
				405 => "Method Not Allowed", 
				406 => "Not Acceptable", 
				407 => "Proxy Authentication Required", 
				408 => "Request Timeout", 
				409 => "Conflict", 
				410 => "Gone", 
				411 => "Length Required", 
				412 => "Precondition Failed", 
				413 => "Request Entity Too Large", 
				414 => "Request-Uri Too Long", 
				415 => "Unsupported Media Type", 
				416 => "Requested Range Not Satisfiable", 
				417 => "Expectation Failed", 
				422 => "Unprocessable Entity", 
				423 => "Locked", 
				424 => "Failed Dependency", 
				500 => "Internal Server Error", 
				501 => "Not Implemented", 
				502 => "Bad Gateway", 
				503 => "Service Unavailable", 
				504 => "Gateway Timeout", 
				505 => "Http Version Not Supported", 
				507 => "Insufficient Storage", 
				_ => string.Empty, 
			};
		}

		public static bool IsCloseStatusCode(this ushort value)
		{
			return value > 999 && value < 5000;
		}

		public static bool IsEnclosedIn(this string value, char c)
		{
			return value != null && value.Length > 1 && value[0] == c && value[value.Length - 1] == c;
		}

		public static bool IsHostOrder(this ByteOrder order)
		{
			return BitConverter.IsLittleEndian == (order == ByteOrder.Little);
		}

		public static bool IsLocal(this IPAddress address)
		{
			if (address == null)
			{
				return false;
			}
			if (address.Equals(IPAddress.Any))
			{
				return true;
			}
			if (address.Equals(IPAddress.Loopback))
			{
				return true;
			}
			if (Socket.OSSupportsIPv6)
			{
				if (address.Equals(IPAddress.IPv6Any))
				{
					return true;
				}
				if (address.Equals(IPAddress.IPv6Loopback))
				{
					return true;
				}
			}
			string hostName = Dns.GetHostName();
			IPAddress[] hostAddresses = Dns.GetHostAddresses(hostName);
			IPAddress[] array = hostAddresses;
			foreach (IPAddress obj in array)
			{
				if (address.Equals(obj))
				{
					return true;
				}
			}
			return false;
		}

		public static bool IsNullOrEmpty(this string value)
		{
			return value == null || value.Length == 0;
		}

		public static bool IsPredefinedScheme(this string value)
		{
			if (value == null || value.Length < 2)
			{
				return false;
			}
			char c = value[0];
			if (c == 'h')
			{
				return value == "http" || value == "https";
			}
			if (c == 'w')
			{
				return value == "ws" || value == "wss";
			}
			if (c == 'f')
			{
				return value == "file" || value == "ftp";
			}
			if (c == 'n')
			{
				c = value[1];
				return (c != 'e') ? (value == "nntp") : (value == "news" || value == "net.pipe" || value == "net.tcp");
			}
			return (c == 'g' && value == "gopher") || (c == 'm' && value == "mailto");
		}

		public static bool IsUpgradeTo(this WebSocketSharp.Net.HttpListenerRequest request, string protocol)
		{
			if (request == null)
			{
				throw new ArgumentNullException("request");
			}
			if (protocol == null)
			{
				throw new ArgumentNullException("protocol");
			}
			if (protocol.Length == 0)
			{
				throw new ArgumentException("An empty string.", "protocol");
			}
			return request.Headers.Contains("Upgrade", protocol) && request.Headers.Contains("Connection", "Upgrade");
		}

		public static bool MaybeUri(this string value)
		{
			if (value == null || value.Length == 0)
			{
				return false;
			}
			int num = value.IndexOf(':');
			if (num == -1)
			{
				return false;
			}
			if (num >= 10)
			{
				return false;
			}
			return value.Substring(0, num).IsPredefinedScheme();
		}

		public static T[] SubArray<T>(this T[] array, int startIndex, int length)
		{
			int num;
			if (array == null || (num = array.Length) == 0)
			{
				return new T[0];
			}
			if (startIndex < 0 || length <= 0 || startIndex + length > num)
			{
				return new T[0];
			}
			if (startIndex == 0 && length == num)
			{
				return array;
			}
			T[] array2 = new T[length];
			Array.Copy(array, startIndex, array2, 0, length);
			return array2;
		}

		public static T[] SubArray<T>(this T[] array, long startIndex, long length)
		{
			long num;
			if (array == null || (num = array.LongLength) == 0)
			{
				return new T[0];
			}
			if (startIndex < 0 || length <= 0 || startIndex + length > num)
			{
				return new T[0];
			}
			if (startIndex == 0L && length == num)
			{
				return array;
			}
			T[] array2 = new T[length];
			Array.Copy(array, startIndex, array2, 0L, length);
			return array2;
		}

		public static void Times(this int n, Action action)
		{
			if (n > 0 && action != null)
			{
				((ulong)n).times(action);
			}
		}

		public static void Times(this long n, Action action)
		{
			if (n > 0 && action != null)
			{
				((ulong)n).times(action);
			}
		}

		public static void Times(this uint n, Action action)
		{
			if (n != 0 && action != null)
			{
				times(n, action);
			}
		}

		public static void Times(this ulong n, Action action)
		{
			if (n != 0 && action != null)
			{
				n.times(action);
			}
		}

		public static void Times(this int n, Action<int> action)
		{
			if (n > 0 && action != null)
			{
				for (int i = 0; i < n; i++)
				{
					action(i);
				}
			}
		}

		public static void Times(this long n, Action<long> action)
		{
			if (n > 0 && action != null)
			{
				for (long num = 0L; num < n; num++)
				{
					action(num);
				}
			}
		}

		public static void Times(this uint n, Action<uint> action)
		{
			if (n != 0 && action != null)
			{
				for (uint num = 0u; num < n; num++)
				{
					action(num);
				}
			}
		}

		public static void Times(this ulong n, Action<ulong> action)
		{
			if (n != 0 && action != null)
			{
				for (ulong num = 0uL; num < n; num++)
				{
					action(num);
				}
			}
		}

		public static T To<T>(this byte[] source, ByteOrder sourceOrder) where T : struct
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (source.Length == 0)
			{
				return default(T);
			}
			Type typeFromHandle = typeof(T);
			byte[] value = source.ToHostOrder(sourceOrder);
			return (typeFromHandle == typeof(bool)) ? ((T)(object)BitConverter.ToBoolean(value, 0)) : ((typeFromHandle == typeof(char)) ? ((T)(object)BitConverter.ToChar(value, 0)) : ((typeFromHandle == typeof(double)) ? ((T)(object)BitConverter.ToDouble(value, 0)) : ((typeFromHandle == typeof(short)) ? ((T)(object)BitConverter.ToInt16(value, 0)) : ((typeFromHandle == typeof(int)) ? ((T)(object)BitConverter.ToInt32(value, 0)) : ((typeFromHandle == typeof(long)) ? ((T)(object)BitConverter.ToInt64(value, 0)) : ((typeFromHandle == typeof(float)) ? ((T)(object)BitConverter.ToSingle(value, 0)) : ((typeFromHandle == typeof(ushort)) ? ((T)(object)BitConverter.ToUInt16(value, 0)) : ((typeFromHandle == typeof(uint)) ? ((T)(object)BitConverter.ToUInt32(value, 0)) : ((typeFromHandle == typeof(ulong)) ? ((T)(object)BitConverter.ToUInt64(value, 0)) : default(T))))))))));
		}

		public static byte[] ToByteArray<T>(this T value, ByteOrder order) where T : struct
		{
			Type typeFromHandle = typeof(T);
			byte[] array = ((typeFromHandle == typeof(bool)) ? BitConverter.GetBytes((bool)(object)value) : ((typeFromHandle != typeof(byte)) ? ((typeFromHandle == typeof(char)) ? BitConverter.GetBytes((char)(object)value) : ((typeFromHandle == typeof(double)) ? BitConverter.GetBytes((double)(object)value) : ((typeFromHandle == typeof(short)) ? BitConverter.GetBytes((short)(object)value) : ((typeFromHandle == typeof(int)) ? BitConverter.GetBytes((int)(object)value) : ((typeFromHandle == typeof(long)) ? BitConverter.GetBytes((long)(object)value) : ((typeFromHandle == typeof(float)) ? BitConverter.GetBytes((float)(object)value) : ((typeFromHandle == typeof(ushort)) ? BitConverter.GetBytes((ushort)(object)value) : ((typeFromHandle == typeof(uint)) ? BitConverter.GetBytes((uint)(object)value) : ((typeFromHandle == typeof(ulong)) ? BitConverter.GetBytes((ulong)(object)value) : WebSocket.EmptyBytes))))))))) : new byte[1] { (byte)(object)value }));
			if (array.Length > 1 && !order.IsHostOrder())
			{
				Array.Reverse(array);
			}
			return array;
		}

		public static byte[] ToHostOrder(this byte[] source, ByteOrder sourceOrder)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return (source.Length > 1 && !sourceOrder.IsHostOrder()) ? source.Reverse() : source;
		}

		public static string ToString<T>(this T[] array, string separator)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			int num = array.Length;
			if (num == 0)
			{
				return string.Empty;
			}
			if (separator == null)
			{
				separator = string.Empty;
			}
			StringBuilder buff = new StringBuilder(64);
			(num - 1).Times(delegate(int i)
			{
				buff.AppendFormat("{0}{1}", array[i].ToString(), separator);
			});
			buff.Append(array[num - 1].ToString());
			return buff.ToString();
		}

		public static Uri ToUri(this string uriString)
		{
			Uri.TryCreate(uriString, uriString.MaybeUri() ? UriKind.Absolute : UriKind.Relative, out var result);
			return result;
		}

		public static string UrlDecode(this string value)
		{
			return (value != null && value.Length > 0) ? HttpUtility.UrlDecode(value) : value;
		}

		public static string UrlEncode(this string value)
		{
			return (value != null && value.Length > 0) ? HttpUtility.UrlEncode(value) : value;
		}

		public static void WriteContent(this WebSocketSharp.Net.HttpListenerResponse response, byte[] content)
		{
			if (response == null)
			{
				throw new ArgumentNullException("response");
			}
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			long num = content.LongLength;
			if (num == 0)
			{
				response.Close();
				return;
			}
			response.ContentLength64 = num;
			Stream outputStream = response.OutputStream;
			if (num <= int.MaxValue)
			{
				outputStream.Write(content, 0, (int)num);
			}
			else
			{
				outputStream.WriteBytes(content, 1024);
			}
			outputStream.Close();
		}
	}
	public class MessageEventArgs : EventArgs
	{
		private string _data;

		private bool _dataSet;

		private Opcode _opcode;

		private byte[] _rawData;

		public string Data
		{
			get
			{
				if (!_dataSet)
				{
					_data = ((_opcode != Opcode.Binary) ? _rawData.UTF8Decode() : BitConverter.ToString(_rawData));
					_dataSet = true;
				}
				return _data;
			}
		}

		public bool IsBinary => _opcode == Opcode.Binary;

		public bool IsPing => _opcode == Opcode.Ping;

		public bool IsText => _opcode == Opcode.Text;

		public byte[] RawData => _rawData;

		[Obsolete("This property will be removed. Use any of the Is properties instead.")]
		public Opcode Type => _opcode;

		internal MessageEventArgs(WebSocketFrame frame)
		{
			_opcode = frame.Opcode;
			_rawData = frame.PayloadData.ApplicationData;
		}

		internal MessageEventArgs(Opcode opcode, byte[] rawData)
		{
			if ((ulong)rawData.LongLength > PayloadData.MaxLength)
			{
				throw new WebSocketException(CloseStatusCode.TooBig);
			}
			_opcode = opcode;
			_rawData = rawData;
		}
	}
	public class CloseEventArgs : EventArgs
	{
		private bool _clean;

		private ushort _code;

		private PayloadData _payloadData;

		private string _reason;

		internal PayloadData PayloadData => _payloadData ?? (_payloadData = new PayloadData(_code.Append(_reason)));

		public ushort Code => _code;

		public string Reason => _reason ?? string.Empty;

		public bool WasClean
		{
			get
			{
				return _clean;
			}
			internal set
			{
				_clean = value;
			}
		}

		internal CloseEventArgs()
		{
			_code = 1005;
			_payloadData = PayloadData.Empty;
		}

		internal CloseEventArgs(ushort code)
		{
			_code = code;
		}

		internal CloseEventArgs(CloseStatusCode code)
			: this((ushort)code)
		{
		}

		internal CloseEventArgs(PayloadData payloadData)
		{
			_payloadData = payloadData;
			byte[] applicationData = payloadData.ApplicationData;
			int num = applicationData.Length;
			_code = (ushort)((num > 1) ? applicationData.SubArray(0, 2).ToUInt16(ByteOrder.Big) : 1005);
			_reason = ((num > 2) ? applicationData.SubArray(2, num - 2).UTF8Decode() : string.Empty);
		}

		internal CloseEventArgs(ushort code, string reason)
		{
			_code = code;
			_reason = reason;
		}

		internal CloseEventArgs(CloseStatusCode code, string reason)
			: this((ushort)code, reason)
		{
		}
	}
	public enum ByteOrder
	{
		Little,
		Big
	}
	public class ErrorEventArgs : EventArgs
	{
		private Exception _exception;

		private string _message;

		public Exception Exception => _exception;

		public string Message => _message;

		internal ErrorEventArgs(string message)
			: this(message, null)
		{
		}

		internal ErrorEventArgs(string message, Exception exception)
		{
			_message = message;
			_exception = exception;
		}
	}
	public class WebSocket : IDisposable
	{
		private AuthenticationChallenge _authChallenge;

		private string _base64Key;

		private bool _client;

		private Action _closeContext;

		private CompressionMethod _compression;

		private WebSocketContext _context;

		private WebSocketSharp.Net.CookieCollection _cookies;

		private WebSocketSharp.Net.NetworkCredential _credentials;

		private bool _emitOnPing;

		private bool _enableRedirection;

		private AutoResetEvent _exitReceiving;

		private string _extensions;

		private bool _extensionsRequested;

		private object _forMessageEventQueue;

		private object _forSend;

		private object _forState;

		private MemoryStream _fragmentsBuffer;

		private bool _fragmentsCompressed;

		private Opcode _fragmentsOpcode;

		private const string _guid = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";

		private Func<WebSocketContext, string> _handshakeRequestChecker;

		private bool _ignoreExtensions;

		private bool _inContinuation;

		private volatile bool _inMessage;

		private volatile Logger _logger;

		private Action<MessageEventArgs> _message;

		private Queue<MessageEventArgs> _messageEventQueue;

		private uint _nonceCount;

		private string _origin;

		private bool _preAuth;

		private string _protocol;

		private string[] _protocols;

		private bool _protocolsRequested;

		private WebSocketSharp.Net.NetworkCredential _proxyCredentials;

		private Uri _proxyUri;

		private volatile WebSocketState _readyState;

		private AutoResetEvent _receivePong;

		private bool _secure;

		private ClientSslConfiguration _sslConfig;

		private Stream _stream;

		private TcpClient _tcpClient;

		private Uri _uri;

		private const string _version = "13";

		private TimeSpan _waitTime;

		internal static readonly byte[] EmptyBytes;

		internal static readonly int FragmentLength;

		internal static readonly RandomNumberGenerator RandomNumber;

		internal WebSocketSharp.Net.CookieCollection CookieCollection => _cookies;

		internal Func<WebSocketContext, string> CustomHandshakeRequestChecker
		{
			get
			{
				return _handshakeRequestChecker;
			}
			set
			{
				_handshakeRequestChecker = value;
			}
		}

		internal bool HasMessage
		{
			get
			{
				lock (_forMessageEventQueue)
				{
					return _messageEventQueue.Count > 0;
				}
			}
		}

		internal bool IgnoreExtensions
		{
			get
			{
				return _ignoreExtensions;
			}
			set
			{
				_ignoreExtensions = value;
			}
		}

		internal bool IsConnected => _readyState == WebSocketState.Open || _readyState == WebSocketState.Closing;

		public CompressionMethod Compression
		{
			get
			{
				return _compression;
			}
			set
			{
				lock (_forState)
				{
					if (!checkIfAvailable(client: true, server: false, connecting: true, open: false, closing: false, closed: true, out var text))
					{
						_logger.Error(text);
						error("An error has occurred in setting the compression.", null);
					}
					else
					{
						_compression = value;
					}
				}
			}
		}

		public IEnumerable<WebSocketSharp.Net.Cookie> Cookies
		{
			get
			{
				lock (_cookies.SyncRoot)
				{
					foreach (WebSocketSharp.Net.Cookie cookie in _cookies)
					{
						yield return cookie;
					}
				}
			}
		}

		public WebSocketSharp.Net.NetworkCredential Credentials => _credentials;

		public bool EmitOnPing
		{
			get
			{
				return _emitOnPing;
			}
			set
			{
				_emitOnPing = value;
			}
		}

		public bool EnableRedirection
		{
			get
			{
				return _enableRedirection;
			}
			set
			{
				lock (_forState)
				{
					if (!checkIfAvailable(client: true, server: false, connecting: true, open: false, closing: false, closed: true, out var text))
					{
						_logger.Error(text);
						error("An error has occurred in setting the enable redirection.", null);
					}
					else
					{
						_enableRedirection = value;
					}
				}
			}
		}

		public string Extensions => _extensions ?? string.Empty;

		public bool IsAlive => Ping();

		public bool IsSecure => _secure;

		public Logger Log
		{
			get
			{
				return _logger;
			}
			internal set
			{
				_logger = value;
			}
		}

		public string Origin
		{
			get
			{
				return _origin;
			}
			set
			{
				lock (_forState)
				{
					Uri result;
					if (!checkIfAvailable(client: true, server: false, connecting: true, open: false, closing: false, closed: true, out var text))
					{
						_logger.Error(text);
						error("An error has occurred in setting the origin.", null);
					}
					else if (value.IsNullOrEmpty())
					{
						_origin = value;
					}
					else if (!Uri.TryCreate(value, UriKind.Absolute, out result) || result.Segments.Length > 1)
					{
						_logger.Error("The syntax of an origin must be '<scheme>://<host>[:<port>]'.");
						error("An error has occurred in setting the origin.", null);
					}
					else
					{
						_origin = value.TrimEnd('/');
					}
				}
			}
		}

		public string Protocol
		{
			get
			{
				return _protocol ?? string.Empty;
			}
			internal set
			{
				_protocol = value;
			}
		}

		public WebSocketState ReadyState => _readyState;

		public ClientSslConfiguration SslConfiguration
		{
			get
			{
				return _client ? (_sslConfig ?? (_sslConfig = new ClientSslConfiguration(_uri.DnsSafeHost))) : null;
			}
			set
			{
				lock (_forState)
				{
					if (!checkIfAvailable(client: true, server: false, connecting: true, open: false, closing: false, closed: true, out var text))
					{
						_logger.Error(text);
						error("An error has occurred in setting the ssl configuration.", null);
					}
					else
					{
						_sslConfig = value;
					}
				}
			}
		}

		public Uri Url => _client ? _uri : _context.RequestUri;

		public TimeSpan WaitTime
		{
			get
			{
				return _waitTime;
			}
			set
			{
				lock (_forState)
				{
					if (!checkIfAvailable(client: true, server: true, connecting: true, open: false, closing: false, closed: true, out var text) || !value.CheckWaitTime(out text))
					{
						_logger.Error(text);
						error("An error has occurred in setting the wait time.", null);
					}
					else
					{
						_waitTime = value;
					}
				}
			}
		}

		public event EventHandler<CloseEventArgs> OnClose;

		public event EventHandler<ErrorEventArgs> OnError;

		public event EventHandler<MessageEventArgs> OnMessage;

		public event EventHandler OnOpen;

		static WebSocket()
		{
			EmptyBytes = new byte[0];
			FragmentLength = 1016;
			RandomNumber = new RNGCryptoServiceProvider();
		}

		internal WebSocket(HttpListenerWebSocketContext context, string protocol)
		{
			_context = context;
			_protocol = protocol;
			_closeContext = context.Close;
			_logger = context.Log;
			_message = messages;
			_secure = context.IsSecureConnection;
			_stream = context.Stream;
			_waitTime = TimeSpan.FromSeconds(1.0);
			init();
		}

		internal WebSocket(TcpListenerWebSocketContext context, string protocol)
		{
			_context = context;
			_protocol = protocol;
			_closeContext = context.Close;
			_logger = context.Log;
			_message = messages;
			_secure = context.IsSecureConnection;
			_stream = context.Stream;
			_waitTime = TimeSpan.FromSeconds(1.0);
			init();
		}

		public WebSocket(string url, params string[] protocols)
		{
			if (url == null)
			{
				throw new ArgumentNullException("url");
			}
			if (url.Length == 0)
			{
				throw new ArgumentException("An empty string.", "url");
			}
			if (!url.TryCreateWebSocketUri(out _uri, out var text))
			{
				throw new ArgumentException(text, "url");
			}
			if (protocols != null && protocols.Length != 0)
			{
				text = protocols.CheckIfValidProtocols();
				if (text != null)
				{
					throw new ArgumentException(text, "protocols");
				}
				_protocols = protocols;
			}
			_base64Key = CreateBase64Key();
			_client = true;
			_logger = new Logger();
			_message = messagec;
			_secure = _uri.Scheme == "wss";
			_waitTime = TimeSpan.FromSeconds(5.0);
			init();
		}

		private bool accept()
		{
			lock (_forState)
			{
				if (!checkIfAvailable(connecting: true, open: false, closing: false, closed: false, out var text))
				{
					_logger.Error(text);
					error("An error has occurred in accepting.", null);
					return false;
				}
				try
				{
					if (!acceptHandshake())
					{
						return false;
					}
					_readyState = WebSocketState.Open;
				}
				catch (Exception ex)
				{
					_logger.Fatal(ex.ToString());
					fatal("An exception has occurred while accepting.", ex);
					return false;
				}
				return true;
			}
		}

		private bool acceptHandshake()
		{
			_logger.Debug($"A request from {_context.UserEndPoint}:\n{_context}");
			if (!checkHandshakeRequest(_context, out var text))
			{
				sendHttpResponse(createHandshakeFailureResponse(WebSocketSharp.Net.HttpStatusCode.BadRequest));
				_logger.Fatal(text);
				fatal("An error has occurred while accepting.", CloseStatusCode.ProtocolError);
				return false;
			}
			if (!customCheckHandshakeRequest(_context, out text))
			{
				sendHttpResponse(createHandshakeFailureResponse(WebSocketSharp.Net.HttpStatusCode.BadRequest));
				_logger.Fatal(text);
				fatal("An error has occurred while accepting.", CloseStatusCode.PolicyViolation);
				return false;
			}
			_base64Key = _context.Headers["Sec-WebSocket-Key"];
			if (_protocol != null)
			{
				processSecWebSocketProtocolHeader(_context.SecWebSocketProtocols);
			}
			if (!_ignoreExtensions)
			{
				processSecWebSocketExtensionsClientHeader(_context.Headers["Sec-WebSocket-Extensions"]);
			}
			return sendHttpResponse(createHandshakeResponse());
		}

		private bool checkHandshakeRequest(WebSocketContext context, out string message)
		{
			message = null;
			if (context.RequestUri == null)
			{
				message = "Specifies an invalid Request-URI.";
				return false;
			}
			if (!context.IsWebSocketRequest)
			{
				message = "Not a WebSocket handshake request.";
				return false;
			}
			NameValueCollection headers = context.Headers;
			if (!validateSecWebSocketKeyHeader(headers["Sec-WebSocket-Key"]))
			{
				message = "Includes no Sec-WebSocket-Key header, or it has an invalid value.";
				return false;
			}
			if (!validateSecWebSocketVersionClientHeader(headers["Sec-WebSocket-Version"]))
			{
				message = "Includes no Sec-WebSocket-Version header, or it has an invalid value.";
				return false;
			}
			if (!validateSecWebSocketProtocolClientHeader(headers["Sec-WebSocket-Protocol"]))
			{
				message = "Includes an invalid Sec-WebSocket-Protocol header.";
				return false;
			}
			if (!_ignoreExtensions && !validateSecWebSocketExtensionsClientHeader(headers["Sec-WebSocket-Extensions"]))
			{
				message = "Includes an invalid Sec-WebSocket-Extensions header.";
				return false;
			}
			return true;
		}

		private bool checkHandshakeResponse(HttpResponse response, out string message)
		{
			message = null;
			if (response.IsRedirect)
			{
				message = "Indicates the redirection.";
				return false;
			}
			if (response.IsUnauthorized)
			{
				message = "Requires the authentication.";
				return false;
			}
			if (!response.IsWebSocketResponse)
			{
				message = "Not a WebSocket handshake response.";
				return false;
			}
			NameValueCollection headers = response.Headers;
			if (!validateSecWebSocketAcceptHeader(headers["Sec-WebSocket-Accept"]))
			{
				message = "Includes no Sec-WebSocket-Accept header, or it has an invalid value.";
				return false;
			}
			if (!validateSecWebSocketProtocolServerHeader(headers["Sec-WebSocket-Protocol"]))
			{
				message = "Includes no Sec-WebSocket-Protocol header, or it has an invalid value.";
				return false;
			}
			if (!validateSecWebSocketExtensionsServerHeader(headers["Sec-WebSocket-Extensions"]))
			{
				message = "Includes an invalid Sec-WebSocket-Extensions header.";
				return false;
			}
			if (!validateSecWebSocketVersionServerHeader(headers["Sec-WebSocket-Version"]))
			{
				message = "Includes an invalid Sec-WebSocket-Version header.";
				return false;
			}
			return true;
		}

		private bool checkIfAvailable(bool connecting, bool open, bool closing, bool closed, out string message)
		{
			message = null;
			if (!connecting && _readyState == WebSocketState.Connecting)
			{
				message = "This operation isn't available in: connecting";
				return false;
			}
			if (!open && _readyState == WebSocketState.Open)
			{
				message = "This operation isn't available in: open";
				return false;
			}
			if (!closing && _readyState == WebSocketState.Closing)
			{
				message = "This operation isn't available in: closing";
				return false;
			}
			if (!closed && _readyState == WebSocketState.Closed)
			{
				message = "This operation isn't available in: closed";
				return false;
			}
			return true;
		}

		private bool checkIfAvailable(bool client, bool server, bool connecting, bool open, bool closing, bool closed, out string message)
		{
			message = null;
			if (!client && _client)
			{
				message = "This operation isn't available in: client";
				return false;
			}
			if (!server && !_client)
			{
				message = "This operation isn't available in: server";
				return false;
			}
			return checkIfAvailable(connecting, open, closing, closed, out message);
		}

		private static bool checkParametersForSetCredentials(string username, string password, out string message)
		{
			message = null;
			if (username.IsNullOrEmpty())
			{
				return true;
			}
			if (username.Contains(':') || !username.IsText())
			{
				message = "'username' contains an invalid character.";
				return false;
			}
			if (password.IsNullOrEmpty())
			{
				return true;
			}
			if (!password.IsText())
			{
				message = "'password' contains an invalid character.";
				return false;
			}
			return true;
		}

		private static bool checkParametersForSetProxy(string url, string username, string password, out string message)
		{
			message = null;
			if (url.IsNullOrEmpty())
			{
				return true;
			}
			if (!Uri.TryCreate(url, UriKind.Absolute, out var result) || result.Scheme != "http" || result.Segments.Length > 1)
			{
				message = "The syntax of 'url' must be 'http://<host>[:<port>]'.";
				return false;
			}
			if (username.IsNullOrEmpty())
			{
				return true;
			}
			if (username.Contains(':') || !username.IsText())
			{
				message = "'username' contains an invalid character.";
				return false;
			}
			if (password.IsNullOrEmpty())
			{
				return true;
			}
			if (!password.IsText())
			{
				message = "'password' contains an invalid character.";
				return false;
			}
			return true;
		}

		private bool checkReceivedFrame(WebSocketFrame frame, out string message)
		{
			message = null;
			bool isMasked = frame.IsMasked;
			if (_client && isMasked)
			{
				message = "A frame from the server is masked.";
				return false;
			}
			if (!_client && !isMasked)
			{
				message = "A frame from a client isn't masked.";
				return false;
			}
			if (_inContinuation && frame.IsData)
			{
				message = "A data frame has been received while receiving continuation frames.";
				return false;
			}
			if (frame.IsCompressed && _compression == CompressionMethod.None)
			{
				message = "A compressed frame has been received without any agreement for it.";
				return false;
			}
			if (frame.Rsv2 == Rsv.On)
			{
				message = "The RSV2 of a frame is non-zero without any negotiation for it.";
				return false;
			}
			if (frame.Rsv3 == Rsv.On)
			{
				message = "The RSV3 of a frame is non-zero without any negotiation for it.";
				return false;
			}
			return true;
		}

		private void close(CloseEventArgs e, bool send, bool receive, bool received)
		{
			lock (_forState)
			{
				if (_readyState == WebSocketState.Closing)
				{
					_logger.Info("The closing is already in progress.");
					return;
				}
				if (_readyState == WebSocketState.Closed)
				{
					_logger.Info("The connection has been closed.");
					return;
				}
				send = send && _readyState == WebSocketState.Open;
				receive = receive && send;
				_readyState = WebSocketState.Closing;
			}
			_logger.Trace("Begin closing the connection.");
			byte[] frameAsBytes = (send ? WebSocketFrame.CreateCloseFrame(e.PayloadData, _client).ToArray() : null);
			e.WasClean = closeHandshake(frameAsBytes, receive, received);
			releaseResources();
			_logger.Trace("End closing the connection.");
			_readyState = WebSocketState.Closed;
			try
			{
				this.OnClose.Emit(this, e);
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				error("An exception has occurred during the OnClose event.", ex);
			}
		}

		private void closeAsync(CloseEventArgs e, bool send, bool receive, bool received)
		{
			Action<CloseEventArgs, bool, bool, bool> closer = close;
			closer.BeginInvoke(e, send, receive, received, delegate(IAsyncResult ar)
			{
				closer.EndInvoke(ar);
			}, null);
		}

		private bool closeHandshake(byte[] frameAsBytes, bool receive, bool received)
		{
			bool flag = frameAsBytes != null && sendBytes(frameAsBytes);
			received = received || (receive && flag && _exitReceiving != null && _exitReceiving.WaitOne(_waitTime));
			bool flag2 = flag && received;
			_logger.Debug($"Was clean?: {flag2}\n  sent: {flag}\n  received: {received}");
			return flag2;
		}

		private bool connect()
		{
			lock (_forState)
			{
				if (!checkIfAvailable(connecting: true, open: false, closing: false, closed: true, out var text))
				{
					_logger.Error(text);
					error("An error has occurred in connecting.", null);
					return false;
				}
				try
				{
					_readyState = WebSocketState.Connecting;
					if (!doHandshake())
					{
						return false;
					}
					_readyState = WebSocketState.Open;
				}
				catch (Exception ex)
				{
					_logger.Fatal(ex.ToString());
					fatal("An exception has occurred while connecting.", ex);
					return false;
				}
				return true;
			}
		}

		private string createExtensions()
		{
			StringBuilder stringBuilder = new StringBuilder(80);
			if (_compression != CompressionMethod.None)
			{
				string arg = _compression.ToExtensionString("server_no_context_takeover", "client_no_context_takeover");
				stringBuilder.AppendFormat("{0}, ", arg);
			}
			int length = stringBuilder.Length;
			if (length > 2)
			{
				stringBuilder.Length = length - 2;
				return stringBuilder.ToString();
			}
			return null;
		}

		private HttpResponse createHandshakeFailureResponse(WebSocketSharp.Net.HttpStatusCode code)
		{
			HttpResponse httpResponse = HttpResponse.CreateCloseResponse(code);
			httpResponse.Headers["Sec-WebSocket-Version"] = "13";
			return httpResponse;
		}

		private HttpRequest createHandshakeRequest()
		{
			HttpRequest httpRequest = HttpRequest.CreateWebSocketRequest(_uri);
			NameValueCollection headers = httpRequest.Headers;
			if (!_origin.IsNullOrEmpty())
			{
				headers["Origin"] = _origin;
			}
			headers["Sec-WebSocket-Key"] = _base64Key;
			_protocolsRequested = _protocols != null;
			if (_protocolsRequested)
			{
				headers["Sec-WebSocket-Protocol"] = _protocols.ToString(", ");
			}
			_extensionsRequested = _compression != CompressionMethod.None;
			if (_extensionsRequested)
			{
				headers["Sec-WebSocket-Extensions"] = createExtensions();
			}
			headers["Sec-WebSocket-Version"] = "13";
			AuthenticationResponse authenticationResponse = null;
			if (_authChallenge != null && _credentials != null)
			{
				authenticationResponse = new AuthenticationResponse(_authChallenge, _credentials, _nonceCount);
				_nonceCount = authenticationResponse.NonceCount;
			}
			else if (_preAuth)
			{
				authenticationResponse = new AuthenticationResponse(_credentials);
			}
			if (authenticationResponse != null)
			{
				headers["Authorization"] = authenticationResponse.ToString();
			}
			if (_cookies.Count > 0)
			{
				httpRequest.SetCookies(_cookies);
			}
			return httpRequest;
		}

		private HttpResponse createHandshakeResponse()
		{
			HttpResponse httpResponse = HttpResponse.CreateWebSocketResponse();
			NameValueCollection headers = httpResponse.Headers;
			headers["Sec-WebSocket-Accept"] = CreateResponseKey(_base64Key);
			if (_protocol != null)
			{
				headers["Sec-WebSocket-Protocol"] = _protocol;
			}
			if (_extensions != null)
			{
				headers["Sec-WebSocket-Extensions"] = _extensions;
			}
			if (_cookies.Count > 0)
			{
				httpResponse.SetCookies(_cookies);
			}
			return httpResponse;
		}

		private bool customCheckHandshakeRequest(WebSocketContext context, out string message)
		{
			message = null;
			return _handshakeRequestChecker == null || (message = _handshakeRequestChecker(context)) == null;
		}

		private MessageEventArgs dequeueFromMessageEventQueue()
		{
			lock (_forMessageEventQueue)
			{
				return (_messageEventQueue.Count > 0) ? _messageEventQueue.Dequeue() : null;
			}
		}

		private bool doHandshake()
		{
			setClientStream();
			HttpResponse httpResponse = sendHandshakeRequest();
			if (!checkHandshakeResponse(httpResponse, out var text))
			{
				_logger.Fatal(text);
				fatal("An error has occurred while connecting.", CloseStatusCode.ProtocolError);
				return false;
			}
			if (_protocolsRequested)
			{
				_protocol = httpResponse.Headers["Sec-WebSocket-Protocol"];
			}
			if (_extensionsRequested)
			{
				processSecWebSocketExtensionsServerHeader(httpResponse.Headers["Sec-WebSocket-Extensions"]);
			}
			processCookies(httpResponse.Cookies);
			return true;
		}

		private void enqueueToMessageEventQueue(MessageEventArgs e)
		{
			lock (_forMessageEventQueue)
			{
				_messageEventQueue.Enqueue(e);
			}
		}

		private void error(string message, Exception exception)
		{
			try
			{
				this.OnError.Emit(this, new ErrorEventArgs(message, exception));
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
			}
		}

		private void fatal(string message, Exception exception)
		{
			CloseStatusCode code = ((exception is WebSocketException) ? ((WebSocketException)exception).Code : CloseStatusCode.Abnormal);
			fatal(message, code);
		}

		private void fatal(string message, CloseStatusCode code)
		{
			close(new CloseEventArgs(code, message), !code.IsReserved(), receive: false, received: false);
		}

		private void init()
		{
			_compression = CompressionMethod.None;
			_cookies = new WebSocketSharp.Net.CookieCollection();
			_forSend = new object();
			_forState = new object();
			_messageEventQueue = new Queue<MessageEventArgs>();
			_forMessageEventQueue = ((ICollection)_messageEventQueue).SyncRoot;
			_readyState = WebSocketState.Connecting;
		}

		private void message()
		{
			MessageEventArgs obj = null;
			lock (_forMessageEventQueue)
			{
				if (_inMessage || _messageEventQueue.Count == 0 || _readyState != WebSocketState.Open)
				{
					return;
				}
				_inMessage = true;
				obj = _messageEventQueue.Dequeue();
			}
			_message(obj);
		}

		private void messagec(MessageEventArgs e)
		{
			while (true)
			{
				try
				{
					this.OnMessage.Emit(this, e);
				}
				catch (Exception ex)
				{
					_logger.Error(ex.ToString());
					error("An exception has occurred during an OnMessage event.", ex);
				}
				lock (_forMessageEventQueue)
				{
					if (_messageEventQueue.Count == 0 || _readyState != WebSocketState.Open)
					{
						_inMessage = false;
						break;
					}
					e = _messageEventQueue.Dequeue();
				}
				bool flag = true;
			}
		}

		private void messages(MessageEventArgs e)
		{
			try
			{
				this.OnMessage.Emit(this, e);
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				error("An exception has occurred during an OnMessage event.", ex);
			}
			lock (_forMessageEventQueue)
			{
				if (_messageEventQueue.Count == 0 || _readyState != WebSocketState.Open)
				{
					_inMessage = false;
					return;
				}
				e = _messageEventQueue.Dequeue();
			}
			ThreadPool.QueueUserWorkItem(delegate
			{
				messages(e);
			});
		}

		private void open()
		{
			_inMessage = true;
			startReceiving();
			try
			{
				this.OnOpen.Emit(this, EventArgs.Empty);
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				error("An exception has occurred during the OnOpen event.", ex);
			}
			MessageEventArgs obj = null;
			lock (_forMessageEventQueue)
			{
				if (_messageEventQueue.Count == 0 || _readyState != WebSocketState.Open)
				{
					_inMessage = false;
					return;
				}
				obj = _messageEventQueue.Dequeue();
			}
			_message.BeginInvoke(obj, delegate(IAsyncResult ar)
			{
				_message.EndInvoke(ar);
			}, null);
		}

		private bool processCloseFrame(WebSocketFrame frame)
		{
			PayloadData payloadData = frame.PayloadData;
			close(new CloseEventArgs(payloadData), !payloadData.IncludesReservedCloseStatusCode, receive: false, received: true);
			return false;
		}

		private void processCookies(WebSocketSharp.Net.CookieCollection cookies)
		{
			if (cookies.Count != 0)
			{
				_cookies.SetOrRemove(cookies);
			}
		}

		private bool processDataFrame(WebSocketFrame frame)
		{
			enqueueToMessageEventQueue(frame.IsCompressed ? new MessageEventArgs(frame.Opcode, frame.PayloadData.ApplicationData.Decompress(_compression)) : new MessageEventArgs(frame));
			return true;
		}

		private bool processFragmentFrame(WebSocketFrame frame)
		{
			if (!_inContinuation)
			{
				if (frame.IsContinuation)
				{
					return true;
				}
				_fragmentsOpcode = frame.Opcode;
				_fragmentsCompressed = frame.IsCompressed;
				_fragmentsBuffer = new MemoryStream();
				_inContinuation = true;
			}
			_fragmentsBuffer.WriteBytes(frame.PayloadData.ApplicationData, 1024);
			if (frame.IsFinal)
			{
				using (_fragmentsBuffer)
				{
					byte[] rawData = (_fragmentsCompressed ? _fragmentsBuffer.DecompressToArray(_compression) : _fragmentsBuffer.ToArray());
					enqueueToMessageEventQueue(new MessageEventArgs(_fragmentsOpcode, rawData));
				}
				_fragmentsBuffer = null;
				_inContinuation = false;
			}
			return true;
		}

		private bool processPingFrame(WebSocketFrame frame)
		{
			if (send(new WebSocketFrame(Opcode.Pong, frame.PayloadData, _client).ToArray()))
			{
				_logger.Trace("Returned a pong.");
			}
			if (_emitOnPing)
			{
				enqueueToMessageEventQueue(new MessageEventArgs(frame));
			}
			return true;
		}

		private bool processPongFrame(WebSocketFrame frame)
		{
			_receivePong.Set();
			_logger.Trace("Received a pong.");
			return true;
		}

		private bool processReceivedFrame(WebSocketFrame frame)
		{
			if (!checkReceivedFrame(frame, out var text))
			{
				throw new WebSocketException(CloseStatusCode.ProtocolError, text);
			}
			frame.Unmask();
			return frame.IsFragment ? processFragmentFrame(frame) : (frame.IsData ? processDataFrame(frame) : (frame.IsPing ? processPingFrame(frame) : (frame.IsPong ? processPongFrame(frame) : (frame.IsClose ? processCloseFrame(frame) : processUnsupportedFrame(frame)))));
		}

		private void processSecWebSocketExtensionsClientHeader(string value)
		{
			if (value == null)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder(80);
			bool flag = false;
			foreach (string item in value.SplitHeaderValue(','))
			{
				string value2 = item.Trim();
				if (!flag && value2.IsCompressionExtension(CompressionMethod.Deflate))
				{
					_compression = CompressionMethod.Deflate;
					stringBuilder.AppendFormat("{0}, ", _compression.ToExtensionString("client_no_context_takeover", "server_no_context_takeover"));
					flag = true;
				}
			}
			int length = stringBuilder.Length;
			if (length > 2)
			{
				stringBuilder.Length = length - 2;
				_extensions = stringBuilder.ToString();
			}
		}

		private void processSecWebSocketExtensionsServerHeader(string value)
		{
			if (value == null)
			{
				_compression = CompressionMethod.None;
			}
			else
			{
				_extensions = value;
			}
		}

		private void processSecWebSocketProtocolHeader(IEnumerable<string> values)
		{
			if (!values.Contains((string p) => p == _protocol))
			{
				_protocol = null;
			}
		}

		private bool processUnsupportedFrame(WebSocketFrame frame)
		{
			_logger.Fatal("An unsupported frame:" + frame.PrintToString(dumped: false));
			fatal("There is no way to handle it.", CloseStatusCode.PolicyViolation);
			return false;
		}

		private void releaseClientResources()
		{
			if (_stream != null)
			{
				_stream.Dispose();
				_stream = null;
			}
			if (_tcpClient != null)
			{
				_tcpClient.Close();
				_tcpClient = null;
			}
		}

		private void releaseCommonResources()
		{
			if (_fragmentsBuffer != null)
			{
				_fragmentsBuffer.Dispose();
				_fragmentsBuffer = null;
				_inContinuation = false;
			}
			if (_receivePong != null)
			{
				_receivePong.Close();
				_receivePong = null;
			}
			if (_exitReceiving != null)
			{
				_exitReceiving.Close();
				_exitReceiving = null;
			}
		}

		private void releaseResources()
		{
			if (_client)
			{
				releaseClientResources();
			}
			else
			{
				releaseServerResources();
			}
			releaseCommonResources();
		}

		private void releaseServerResources()
		{
			if (_closeContext != null)
			{
				_closeContext();
				_closeContext = null;
				_stream = null;
				_context = null;
			}
		}

		private bool send(byte[] frameAsBytes)
		{
			lock (_forState)
			{
				if (_readyState != WebSocketState.Open)
				{
					_logger.Error("The sending has been interrupted.");
					return false;
				}
				return sendBytes(frameAsBytes);
			}
		}

		private bool send(Opcode opcode, Stream stream)
		{
			lock (_forSend)
			{
				Stream stream2 = stream;
				bool flag = false;
				bool flag2 = false;
				try
				{
					if (_compression != CompressionMethod.None)
					{
						stream = stream.Compress(_compression);
						flag = true;
					}
					flag2 = send(opcode, stream, flag);
					if (!flag2)
					{
						error("The sending has been interrupted.", null);
					}
				}
				catch (Exception ex)
				{
					_logger.Error(ex.ToString());
					error("An exception has occurred while sending data.", ex);
				}
				finally
				{
					if (flag)
					{
						stream.Dispose();
					}
					stream2.Dispose();
				}
				return flag2;
			}
		}

		private bool send(Opcode opcode, Stream stream, bool compressed)
		{
			long length = stream.Length;
			if (length == 0)
			{
				return send(Fin.Final, opcode, EmptyBytes, compressed);
			}
			long num = length / FragmentLength;
			int num2 = (int)(length % FragmentLength);
			byte[] array = null;
			if (num == 0)
			{
				array = new byte[num2];
				return stream.Read(array, 0, num2) == num2 && send(Fin.Final, opcode, array, compressed);
			}
			array = new byte[FragmentLength];
			if (num == 1 && num2 == 0)
			{
				return stream.Read(array, 0, FragmentLength) == FragmentLength && send(Fin.Final, opcode, array, compressed);
			}
			if (stream.Read(array, 0, FragmentLength) != FragmentLength || !send(Fin.More, opcode, array, compressed))
			{
				return false;
			}
			long num3 = ((num2 == 0) ? (num - 2) : (num - 1));
			for (long num4 = 0L; num4 < num3; num4++)
			{
				if (stream.Read(array, 0, FragmentLength) != FragmentLength || !send(Fin.More, Opcode.Cont, array, compressed))
				{
					return false;
				}
			}
			if (num2 == 0)
			{
				num2 = FragmentLength;
			}
			else
			{
				array = new byte[num2];
			}
			return stream.Read(array, 0, num2) == num2 && send(Fin.Final, Opcode.Cont, array, compressed);
		}

		private bool send(Fin fin, Opcode opcode, byte[] data, bool compressed)
		{
			lock (_forState)
			{
				if (_readyState != WebSocketState.Open)
				{
					_logger.Error("The sending has been interrupted.");
					return false;
				}
				return sendBytes(new WebSocketFrame(fin, opcode, data, compressed, _client).ToArray());
			}
		}

		private void sendAsync(Opcode opcode, Stream stream, Action<bool> completed)
		{
			Func<Opcode, Stream, bool> sender = send;
			sender.BeginInvoke(opcode, stream, delegate(IAsyncResult ar)
			{
				try
				{
					bool obj = sender.EndInvoke(ar);
					if (completed != null)
					{
						completed(obj);
					}
				}
				catch (Exception ex)
				{
					_logger.Error(ex.ToString());
					error("An exception has occurred during a send callback.", ex);
				}
			}, null);
		}

		private bool sendBytes(byte[] bytes)
		{
			try
			{
				_stream.Write(bytes, 0, bytes.Length);
				return true;
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
				return false;
			}
		}

		private HttpResponse sendHandshakeRequest()
		{
			HttpRequest httpRequest = createHandshakeRequest();
			HttpResponse httpResponse = sendHttpRequest(httpRequest, 90000);
			if (httpResponse.IsUnauthorized)
			{
				string text = httpResponse.Headers["WWW-Authenticate"];
				_logger.Warn($"Received an authentication requirement for '{text}'.");
				if (text.IsNullOrEmpty())
				{
					_logger.Error("No authentication challenge is specified.");
					return httpResponse;
				}
				_authChallenge = AuthenticationChallenge.Parse(text);
				if (_authChallenge == null)
				{
					_logger.Error("An invalid authentication challenge is specified.");
					return httpResponse;
				}
				if (_credentials != null && (!_preAuth || _authChallenge.Scheme == WebSocketSharp.Net.AuthenticationSchemes.Digest))
				{
					if (httpResponse.HasConnectionClose)
					{
						releaseClientResources();
						setClientStream();
					}
					AuthenticationResponse authenticationResponse = new AuthenticationResponse(_authChallenge, _credentials, _nonceCount);
					_nonceCount = authenticationResponse.NonceCount;
					httpRequest.Headers["Authorization"] = authenticationResponse.ToString();
					httpResponse = sendHttpRequest(httpRequest, 15000);
				}
			}
			if (httpResponse.IsRedirect)
			{
				string text2 = httpResponse.Headers["Location"];
				_logger.Warn($"Received a redirection to '{text2}'.");
				if (_enableRedirection)
				{
					if (text2.IsNullOrEmpty())
					{
						_logger.Error("No url to redirect is located.");
						return httpResponse;
					}
					if (!text2.TryCreateWebSocketUri(out var result, out var text3))
					{
						_logger.Error("An invalid url to redirect is located: " + text3);
						return httpResponse;
					}
					releaseClientResources();
					_uri = result;
					_secure = result.Scheme == "wss";
					setClientStream();
					return sendHandshakeRequest();
				}
			}
			return httpResponse;
		}

		private HttpResponse sendHttpRequest(HttpRequest request, int millisecondsTimeout)
		{
			_logger.Debug("A request to the server:\n" + request.ToString());
			HttpResponse response = request.GetResponse(_stream, millisecondsTimeout);
			_logger.Debug("A response to this request:\n" + response.ToString());
			return response;
		}

		private bool sendHttpResponse(HttpResponse response)
		{
			_logger.Debug("A response to this request:\n" + response.ToString());
			return sendBytes(response.ToByteArray());
		}

		private void sendProxyConnectRequest()
		{
			HttpRequest httpRequest = HttpRequest.CreateConnectRequest(_uri);
			HttpResponse httpResponse = sendHttpRequest(httpRequest, 90000);
			if (httpResponse.IsProxyAuthenticationRequired)
			{
				string text = httpResponse.Headers["Proxy-Authenticate"];
				_logger.Warn($"Received a proxy authentication requirement for '{text}'.");
				if (text.IsNullOrEmpty())
				{
					throw new WebSocketException("No proxy authentication challenge is specified.");
				}
				AuthenticationChallenge authenticationChallenge = AuthenticationChallenge.Parse(text);
				if (authenticationChallenge == null)
				{
					throw new WebSocketException("An invalid proxy authentication challenge is specified.");
				}
				if (_proxyCredentials != null)
				{
					if (httpResponse.HasConnectionClose)
					{
						releaseClientResources();
						_tcpClient = new TcpClient(_proxyUri.DnsSafeHost, _proxyUri.Port);
						_stream = _tcpClient.GetStream();
					}
					AuthenticationResponse authenticationResponse = new AuthenticationResponse(authenticationChallenge, _proxyCredentials, 0u);
					httpRequest.Headers["Proxy-Authorization"] = authenticationResponse.ToString();
					httpResponse = sendHttpRequest(httpRequest, 15000);
				}
				if (httpResponse.IsProxyAuthenticationRequired)
				{
					throw new WebSocketException("A proxy authentication is required.");
				}
			}
			if (httpResponse.StatusCode[0] != '2')
			{
				throw new WebSocketException("The proxy has failed a connection to the requested host and port.");
			}
		}

		private void setClientStream()
		{
			if (_proxyUri != null)
			{
				_tcpClient = new TcpClient(_proxyUri.DnsSafeHost, _proxyUri.Port);
				_stream = _tcpClient.GetStream();
				sendProxyConnectRequest();
			}
			else
			{
				_tcpClient = new TcpClient(_uri.DnsSafeHost, _uri.Port);
				_stream = _tcpClient.GetStream();
			}
			if (_secure)
			{
				ClientSslConfiguration sslConfiguration = SslConfiguration;
				string targetHost = sslConfiguration.TargetHost;
				if (targetHost != _uri.DnsSafeHost)
				{
					throw new WebSocketException(CloseStatusCode.TlsHandshakeFailure, "An invalid host name is specified.");
				}
				try
				{
					SslStream sslStream = new SslStream(_stream, leaveStreamOpen: false, sslConfiguration.ServerCertificateValidationCallback, sslConfiguration.ClientCertificateSelectionCallback);
					sslStream.AuthenticateAsClient(targetHost, sslConfiguration.ClientCertificates, sslConfiguration.EnabledSslProtocols, sslConfiguration.CheckCertificateRevocation);
					_stream = sslStream;
				}
				catch (Exception innerException)
				{
					throw new WebSocketException(CloseStatusCode.TlsHandshakeFailure, innerException);
				}
			}
		}

		private void startReceiving()
		{
			if (_messageEventQueue.Count > 0)
			{
				_messageEventQueue.Clear();
			}
			_exitReceiving = new AutoResetEvent(initialState: false);
			_receivePong = new AutoResetEvent(initialState: false);
			Action receive = null;
			receive = delegate
			{
				WebSocketFrame.ReadFrameAsync(_stream, unmask: false, delegate(WebSocketFrame frame)
				{
					if (!processReceivedFrame(frame) || _readyState == WebSocketState.Closed)
					{
						_exitReceiving?.Set();
					}
					else
					{
						receive();
						if (!_inMessage && HasMessage && _readyState == WebSocketState.Open)
						{
							message();
						}
					}
				}, delegate(Exception ex)
				{
					_logger.Fatal(ex.ToString());
					fatal("An exception has occurred while receiving.", ex);
				});
			};
			receive();
		}

		private bool validateSecWebSocketAcceptHeader(string value)
		{
			return value != null && value == CreateResponseKey(_base64Key);
		}

		private bool validateSecWebSocketExtensionsClientHeader(string value)
		{
			return value == null || value.Length > 0;
		}

		private bool validateSecWebSocketExtensionsServerHeader(string value)
		{
			if (value == null)
			{
				return true;
			}
			if (value.Length == 0)
			{
				return false;
			}
			if (!_extensionsRequested)
			{
				return false;
			}
			bool flag = _compression != CompressionMethod.None;
			foreach (string item in value.SplitHeaderValue(','))
			{
				string text = item.Trim();
				if (flag && text.IsCompressionExtension(_compression))
				{
					if (!text.Contains("server_no_context_takeover"))
					{
						_logger.Error("The server hasn't sent back 'server_no_context_takeover'.");
						return false;
					}
					if (!text.Contains("client_no_context_takeover"))
					{
						_logger.Warn("The server hasn't sent back 'client_no_context_takeover'.");
					}
					string method = _compression.ToExtensionString();
					if (text.SplitHeaderValue(';').Contains(delegate(string t)
					{
						t = t.Trim();
						return t != method && t != "server_no_context_takeover" && t != "client_no_context_takeover";
					}))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}

		private bool validateSecWebSocketKeyHeader(string value)
		{
			return value != null && value.Length > 0;
		}

		private bool validateSecWebSocketProtocolClientHeader(string value)
		{
			return value == null || value.Length > 0;
		}

		private bool validateSecWebSocketProtocolServerHeader(string value)
		{
			if (value == null)
			{
				return !_protocolsRequested;
			}
			if (value.Length == 0)
			{
				return false;
			}
			return _protocolsRequested && _protocols.Contains((string p) => p == value);
		}

		private bool validateSecWebSocketVersionClientHeader(string value)
		{
			return value != null && value == "13";
		}

		private bool validateSecWebSocketVersionServerHeader(string value)
		{
			return value == null || value == "13";
		}

		internal static string CheckCloseParameters(ushort code, string reason, bool client)
		{
			return (!code.IsCloseStatusCode()) ? "An invalid close status code." : ((code != 1005) ? ((code == 1010 && !client) ? "MandatoryExtension cannot be used by a server." : ((code == 1011 && client) ? "ServerError cannot be used by a client." : ((!reason.IsNullOrEmpty() && reason.UTF8Encode().Length > 123) ? "A reason has greater than the allowable max size." : null))) : ((!reason.IsNullOrEmpty()) ? "NoStatus cannot have a reason." : null));
		}

		internal static string CheckCloseParameters(CloseStatusCode code, string reason, bool client)
		{
			return (code != CloseStatusCode.NoStatus) ? ((code == CloseStatusCode.MandatoryExtension && !client) ? "MandatoryExtension cannot be used by a server." : ((code == CloseStatusCode.ServerError && client) ? "ServerError cannot be used by a client." : ((!reason.IsNullOrEmpty() && reason.UTF8Encode().Length > 123) ? "A reason has greater than the allowable max size." : null))) : ((!reason.IsNullOrEmpty()) ? "NoStatus cannot have a reason." : null);
		}

		internal static bool CheckParametersForClose(ushort code, string reason, bool client, out string message)
		{
			message = null;
			if (!code.IsCloseStatusCode())
			{
				message = "'code' is an invalid status code.";
				return false;
			}
			if (code == 1005 && !reason.IsNullOrEmpty())
			{
				message = "'code' cannot have a reason.";
				return false;
			}
			if (code == 1010 && !client)
			{
				message = "'code' cannot be used by a server.";
				return false;
			}
			if (code == 1011 && client)
			{
				message = "'code' cannot be used by a client.";
				return false;
			}
			if (!reason.IsNullOrEmpty() && reason.UTF8Encode().Length > 123)
			{
				message = "The size of 'reason' is greater than the allowable max size.";
				return false;
			}
			return true;
		}

		internal static string CheckPingParameter(string message, out byte[] bytes)
		{
			bytes = message.UTF8Encode();
			return (bytes.Length > 125) ? "A message has greater than the allowable max size." : null;
		}

		internal static string CheckSendParameter(byte[] data)
		{
			return (data == null) ? "'data' is null." : null;
		}

		internal static string CheckSendParameter(FileInfo file)
		{
			return (file == null) ? "'file' is null." : null;
		}

		internal static string CheckSendParameter(string data)
		{
			return (data == null) ? "'data' is null." : null;
		}

		internal static string CheckSendParameters(Stream stream, int length)
		{
			return (stream == null) ? "'stream' is null." : ((!stream.CanRead) ? "'stream' cannot be read." : ((length < 1) ? "'length' is less than 1." : null));
		}

		internal void Close(HttpResponse response)
		{
			_readyState = WebSocketState.Closing;
			sendHttpResponse(response);
			releaseServerResources();
			_readyState = WebSocketState.Closed;
		}

		internal void Close(WebSocketSharp.Net.HttpStatusCode code)
		{
			Close(createHandshakeFailureResponse(code));
		}

		internal void Close(CloseEventArgs e, byte[] frameAsBytes, bool receive)
		{
			lock (_forState)
			{
				if (_readyState == WebSocketState.Closing)
				{
					_logger.Info("The closing is already in progress.");
					return;
				}
				if (_readyState == WebSocketState.Closed)
				{
					_logger.Info("The connection has been closed.");
					return;
				}
				_readyState = WebSocketState.Closing;
			}
			e.WasClean = closeHandshake(frameAsBytes, receive, received: false);
			releaseServerResources();
			releaseCommonResources();
			_readyState = WebSocketState.Closed;
			try
			{
				this.OnClose.Emit(this, e);
			}
			catch (Exception ex)
			{
				_logger.Error(ex.ToString());
			}
		}

		internal static string CreateBase64Key()
		{
			byte[] array = new byte[16];
			RandomNumber.GetBytes(array);
			return Convert.ToBase64String(array);
		}

		internal static string CreateResponseKey(string base64Key)
		{
			StringBuilder stringBuilder = new StringBuilder(base64Key, 64);
			stringBuilder.Append("258EAFA5-E914-47DA-95CA-C5AB0DC85B11");
			SHA1 sHA = new SHA1CryptoServiceProvider();
			byte[] inArray = sHA.ComputeHash(stringBuilder.ToString().UTF8Encode());
			return Convert.ToBase64String(inArray);
		}

		internal void InternalAccept()
		{
			try
			{
				if (!acceptHandshake())
				{
					return;
				}
				_readyState = WebSocketState.Open;
			}
			catch (Exception ex)
			{
				_logger.Fatal(ex.ToString());
				fatal("An exception has occurred while accepting.", ex);
				return;
			}
			open();
		}

		internal bool Ping(byte[] frameAsBytes, TimeSpan timeout)
		{
			if (_readyState != WebSocketState.Open)
			{
				return false;
			}
			if (!send(frameAsBytes))
			{
				return false;
			}
			return _receivePong?.WaitOne(timeout) ?? false;
		}

		internal void Send(Opcode opcode, byte[] data, Dictionary<CompressionMethod, byte[]> cache)
		{
			lock (_forSend)
			{
				lock (_forState)
				{
					if (_readyState != WebSocketState.Open)
					{
						_logger.Error("The sending has been interrupted.");
						return;
					}
					try
					{
						if (!cache.TryGetValue(_compression, out var value))
						{
							value = new WebSocketFrame(Fin.Final, opcode, data.Compress(_compression), _compression != CompressionMethod.None, mask: false).ToArray();
							cache.Add(_compression, value);
						}
						sendBytes(value);
					}
					catch (Exception ex)
					{
						_logger.Error(ex.ToString());
					}
				}
			}
		}

		internal void Send(Opcode opcode, Stream stream, Dictionary<CompressionMethod, Stream> cache)
		{
			lock (_forSend)
			{
				try
				{
					if (!cache.TryGetValue(_compression, out var value))
					{
						value = stream.Compress(_compression);
						cache.Add(_compression, value);
					}
					else
					{
						value.Position = 0L;
					}
					send(opcode, value, _compression != CompressionMethod.None);
				}
				catch (Exception ex)
				{
					_logger.Error(ex.ToString());
				}
			}
		}

		public void Accept()
		{
			if (!checkIfAvailable(client: false, server: true, connecting: true, open: false, closing: false, closed: false, out var text))
			{
				_logger.Error(text);
				error("An error has occurred in accepting.", null);
			}
			else if (accept())
			{
				open();
			}
		}

		public void AcceptAsync()
		{
			if (!checkIfAvailable(client: false, server: true, connecting: true, open: false, closing: false, closed: false, out var text))
			{
				_logger.Error(text);
				error("An error has occurred in accepting.", null);
				return;
			}
			Func<bool> acceptor = accept;
			acceptor.BeginInvoke(delegate(IAsyncResult ar)
			{
				if (acceptor.EndInvoke(ar))
				{
					open();
				}
			}, null);
		}

		public void Close()
		{
			if (!checkIfAvailable(connecting: true, open: true, closing: false, closed: false, out var text))
			{
				_logger.Error(text);
				error("An error has occurred in closing the connection.", null);
			}
			else
			{
				close(new CloseEventArgs(), send: true, receive: true, received: false);
			}
		}

		public void Close(ushort code)
		{
			if (!checkIfAvailable(connecting: true, open: true, closing: false, closed: false, out var text))
			{
				_logger.Error(text);
				error("An error has occurred in closing the connection.", null);
			}
			else if (!CheckParametersForClose(code, null, _client, out text))
			{
				_logger.Error(text);
				error("An error has occurred in closing the connection.", null);
			}
			else if (code == 1005)
			{
				close(new CloseEventArgs(), send: true, receive: true, received: false);
			}
			else
			{
				bool receive = !code.IsReserved();
				close(new CloseEventArgs(code), receive, receive, received: false);
			}
		}

		public void Close(CloseStatusCode code)
		{
			string text = _readyState.CheckIfAvailable(connecting: true, open: true, closing: false, closed: false) ?? CheckCloseParameters(code, null, _client);
			if (text != null)
			{
				_logger.Error(text);
				error("An error has occurred in closing the connection.", null);
			}
			else if (code == CloseStatusCode.NoStatus)
			{
				close(new CloseEventArgs(), send: true, receive: true, received: false);
			}
			else
			{
				bool receive = !code.IsReserved();
				close(new CloseEventArgs(code), receive, receive, received: false);
			}
		}

		public void Close(ushort code, string reason)
		{
			if (!checkIfAvailable(connecting: true, open: true, closing: false, closed: false, out var text))
			{
				_logger.Error(text);
				error("An error has occurred in closing the connection.", null);
			}
			else if (!CheckParametersForClose(code, reason, _client, out text))
			{
				_logger.Error(text);
				error("An error has occurred in closing the connection.", null);
			}
			else if (code == 1005)
			{
				close(new CloseEventArgs(), send: true, receive: true, received: false);
			}
			else
			{
				bool receive = !code.IsReserved();
				close(new CloseEventArgs(code, reason), receive, receive, received: false);
			}
		}

		public void Close(CloseStatusCode code, string reason)
		{
			string text = _readyState.CheckIfAvailable(connecting: true, open: true, closing: false, closed: false) ?? CheckCloseParameters(code, reason, _client);
			if (text != null)
			{
				_logger.Error(text);
				error("An error has occurred in closing the connection.", null);
			}
			else if (code == CloseStatusCode.NoStatus)
			{
				close(new CloseEventArgs(), send: true, receive: true, received: false);
			}
			else
			{
				bool receive = !code.IsReserved();
				close(new CloseEventArgs(code, reason), receive, receive, received: false);
			}
		}

		public void CloseAsync()
		{
			if (!checkIfAvailable(connecting: true, open: true, closing: false, closed: false, out var text))
			{
				_logger.Error(text);
				error("An error has occurred in closing the connection.", null);
			}
			else
			{
				closeAsync(new CloseEventArgs(), send: true, receive: true, received: false);
			}
		}

		public void CloseAsync(ushort code)
		{
			string text = _readyState.CheckIfAvailable(connecting: true, open: true, closing: false, closed: false) ?? CheckCloseParameters(code, null, _client);
			if (text != null)
			{
				_logger.Error(text);
				error("An error has occurred in closing the connection.", null);
			}
			else if (code == 1005)
			{
				closeAsync(new CloseEventArgs(), send: true, receive: true, received: false);
			}
			else
			{
				bool receive = !code.IsReserved();
				closeAsync(new CloseEventArgs(code), receive, receive, received: false);
			}
		}

		public void CloseAsync(CloseStatusCode code)
		{
			string text = _readyState.CheckIfAvailable(connecting: true, open: true, closing: false, closed: false) ?? CheckCloseParameters(code, null, _client);
			if (text != null)
			{
				_logger.Error(text);
				error("An error has occurred in closing the connection.", null);
			}
			else if (code == CloseStatusCode.NoStatus)
			{
				closeAsync(new CloseEventArgs(), send: true, receive: true, received: false);
			}
			else
			{
				bool receive = !code.IsReserved();
				closeAsync(new CloseEventArgs(code), receive, receive, received: false);
			}
		}

		public void CloseAsync(ushort code, string reason)
		{
			string text = _readyState.CheckIfAvailable(connecting: true, open: true, closing: false, closed: false) ?? CheckCloseParameters(code, reason, _client);
			if (text != null)
			{
				_logger.Error(text);
				error("An error has occurred in closing the connection.", null);
			}
			else if (code == 1005)
			{
				closeAsync(new CloseEventArgs(), send: true, receive: true, received: false);
			}
			else
			{
				bool receive = !code.IsReserved();
				closeAsync(new CloseEventArgs(code, reason), receive, receive, received: false);
			}
		}

		public void CloseAsync(CloseStatusCode code, string reason)
		{
			string text = _readyState.CheckIfAvailable(connecting: true, open: true, closing: false, closed: false) ?? CheckCloseParameters(code, reason, _client);
			if (text != null)
			{
				_logger.Error(text);
				error("An error has occurred in closing the connection.", null);
			}
			else if (code == CloseStatusCode.NoStatus)
			{
				closeAsync(new CloseEventArgs(), send: true, receive: true, received: false);
			}
			else
			{
				bool receive = !code.IsReserved();
				closeAsync(new CloseEventArgs(code, reason), receive, receive, received: false);
			}
		}

		public void Connect()
		{
			if (!checkIfAvailable(client: true, server: false, connecting: true, open: false, closing: false, closed: true, out var text))
			{
				_logger.Error(text);
				error("An error has occurred in connecting.", null);
			}
			else if (connect())
			{
				open();
			}
		}

		public void ConnectAsync()
		{
			if (!checkIfAvailable(client: true, server: false, connecting: true, open: false, closing: false, closed: true, out var text))
			{
				_logger.Error(text);
				error("An error has occurred in connecting.", null);
				return;
			}
			Func<bool> connector = connect;
			connector.BeginInvoke(delegate(IAsyncResult ar)
			{
				if (connector.EndInvoke(ar))
				{
					open();
				}
			}, null);
		}

		public bool Ping()
		{
			byte[] frameAsBytes = (_client ? WebSocketFrame.CreatePingFrame(mask: true).ToArray() : WebSocketFrame.EmptyPingBytes);
			return Ping(frameAsBytes, _waitTime);
		}

		public bool Ping(string message)
		{
			if (message == null || message.Length == 0)
			{
				return Ping();
			}
			byte[] bytes;
			string text = CheckPingParameter(message, out bytes);
			if (text != null)
			{
				_logger.Error(text);
				error("An error has occurred in sending a ping.", null);
				return false;
			}
			return Ping(WebSocketFrame.CreatePingFrame(bytes, _client).ToArray(), _waitTime);
		}

		public void Send(byte[] data)
		{
			string text = _readyState.CheckIfAvailable(connecting: false, open: true, closing: false, closed: false) ?? CheckSendParameter(data);
			if (text != null)
			{
				_logger.Error(text);
				error("An error has occurred in sending data.", null);
			}
			else
			{
				send(Opcode.Binary, new MemoryStream(data));
			}
		}

		public void Send(FileInfo file)
		{
			string text = _readyState.CheckIfAvailable(connecting: false, open: true, closing: false, closed: false) ?? CheckSendParameter(file);
			if (text != null)
			{
				_logger.Error(text);
				error("An error has occurred in sending data.", null);
			}
			else
			{
				send(Opcode.Binary, file.OpenRead());
			}
		}

		public void Send(string data)
		{
			string text = _readyState.CheckIfAvailable(connecting: false, open: true, closing: false, closed: false) ?? CheckSendParameter(data);
			if (text != null)
			{
				_logger.Error(text);
				error("An error has occurred in sending data.", null);
			}
			else
			{
				send(Opcode.Text, new MemoryStream(data.UTF8Encode()));
			}
		}

		public void SendAsync(byte[] data, Action<bool> completed)
		{
			string text = _readyState.CheckIfAvailable(connecting: false, open: true, closing: false, closed: false) ?? CheckSendParameter(data);
			if (text != null)
			{
				_logger.Error(text);
				error("An error has occurred in sending data.", null);
			}
			else
			{
				sendAsync(Opcode.Binary, new MemoryStream(data), completed);
			}
		}

		public void SendAsync(FileInfo file, Action<bool> completed)
		{
			string text = _readyState.CheckIfAvailable(connecting: false, open: true, closing: false, closed: false) ?? CheckSendParameter(file);
			if (text != null)
			{
				_logger.Error(text);
				error("An error has occurred in sending data.", null);
			}
			else
			{
				sendAsync(Opcode.Binary, file.OpenRead(), completed);
			}
		}

		public void SendAsync(string data, Action<bool> completed)
		{
			string text = _readyState.CheckIfAvailable(connecting: false, open: true, closing: false, closed: false) ?? CheckSendParameter(data);
			if (text != null)
			{
				_logger.Error(text);
				error("An error has occurred in sending data.", null);
			}
			else
			{
				sendAsync(Opcode.Text, new MemoryStream(data.UTF8Encode()), completed);
			}
		}

		public void SendAsync(Stream stream, int length, Action<bool> completed)
		{
			string text = _readyState.CheckIfAvailable(connecting: false, open: true, closing: false, closed: false) ?? CheckSendParameters(stream, length);
			if (text != null)
			{
				_logger.Error(text);
				error("An error has occurred in sending data.", null);
				return;
			}
			stream.ReadBytesAsync(length, delegate(byte[] data)
			{
				int num = data.Length;
				if (num == 0)
				{
					_logger.Error("The data cannot be read from 'stream'.");
					error("An error has occurred in sending data.", null);
				}
				else
				{
					if (num < length)
					{
						_logger.Warn($"The length of the data is less than 'length':\n  expected: {length}\n  actual: {num}");
					}
					bool obj = send(Opcode.Binary, new MemoryStream(data));
					if (completed != null)
					{
						completed(obj);
					}
				}
			}, delegate(Exception ex)
			{
				_logger.Error(ex.ToString());
				error("An exception has occurred while sending data.", ex);
			});
		}

		public void SetCookie(WebSocketSharp.Net.Cookie cookie)
		{
			if (!checkIfAvailable(client: true, server: false, connecting: true, open: false, closing: false, closed: true, out var text))
			{
				_logger.Error(text);
				error("An error has occurred in setting a cookie.", null);
				return;
			}
			if (cookie == null)
			{
				_logger.Error("'cookie' is null.");
				error("An error has occurred in setting a cookie.", null);
				return;
			}
			lock (_forState)
			{
				if (!checkIfAvailable(connecting: true, open: false, closing: false, closed: true, out text))
				{
					_logger.Error(text);
					error("An error has occurred in setting a cookie.", null);
					return;
				}
				lock (_cookies.SyncRoot)
				{
					_cookies.SetOrRemove(cookie);
				}
			}
		}

		public void SetCredentials(string username, string password, bool preAuth)
		{
			if (!checkIfAvailable(client: true, server: false, connecting: true, open: false, closing: false, closed: true, out var text))
			{
				_logger.Error(text);
				error("An error has occurred in setting the credentials.", null);
				return;
			}
			if (!checkParametersForSetCredentials(username, password, out text))
			{
				_logger.Error(text);
				error("An error has occurred in setting the credentials.", null);
				return;
			}
			lock (_forState)
			{
				if (!checkIfAvailable(connecting: true, open: false, closing: false, closed: true, out text))
				{
					_logger.Error(text);
					error("An error has occurred in setting the credentials.", null);
				}
				else if (username.IsNullOrEmpty())
				{
					_logger.Warn("The credentials are initialized.");
					_credentials = null;
					_preAuth = false;
				}
				else
				{
					_credentials = new WebSocketSharp.Net.NetworkCredential(username, password, _uri.PathAndQuery);
					_preAuth = preAuth;
				}
			}
		}

		public void SetProxy(string url, string username, string password)
		{
			if (!checkIfAvailable(client: true, server: false, connecting: true, open: false, closing: false, closed: true, out var text))
			{
				_logger.Error(text);
				error("An error has occurred in setting the proxy.", null);
				return;
			}
			if (!checkParametersForSetProxy(url, username, password, out text))
			{
				_logger.Error(text);
				error("An error has occurred in setting the proxy.", null);
				return;
			}
			lock (_forState)
			{
				if (!checkIfAvailable(connecting: true, open: false, closing: false, closed: true, out text))
				{
					_logger.Error(text);
					error("An error has occurred in setting the proxy.", null);
					return;
				}
				if (url.IsNullOrEmpty())
				{
					_logger.Warn("The url and credentials for the proxy are initialized.");
					_proxyUri = null;
					_proxyCredentials = null;
					return;
				}
				_proxyUri = new Uri(url);
				if (username.IsNullOrEmpty())
				{
					_logger.Warn("The credentials for the proxy are initialized.");
					_proxyCredentials = null;
				}
				else
				{
					_proxyCredentials = new WebSocketSharp.Net.NetworkCredential(username, password, $"{_uri.DnsSafeHost}:{_uri.Port}");
				}
			}
		}

		void IDisposable.Dispose()
		{
			close(new CloseEventArgs(CloseStatusCode.Away), send: true, receive: true, received: false);
		}
	}
	public enum CloseStatusCode : ushort
	{
		Normal = 1000,
		Away = 1001,
		ProtocolError = 1002,
		UnsupportedData = 1003,
		Undefined = 1004,
		NoStatus = 1005,
		Abnormal = 1006,
		InvalidData = 1007,
		PolicyViolation = 1008,
		TooBig = 1009,
		MandatoryExtension = 1010,
		ServerError = 1011,
		TlsHandshakeFailure = 1015
	}
	internal enum Fin : byte
	{
		More,
		Final
	}
	internal enum Mask : byte
	{
		Off,
		On
	}
	public enum Opcode : byte
	{
		Cont = 0,
		Text = 1,
		Binary = 2,
		Close = 8,
		Ping = 9,
		Pong = 10
	}
	internal class PayloadData : IEnumerable<byte>, IEnumerable
	{
		private byte[] _data;

		private long _extDataLength;

		private long _length;

		public static readonly PayloadData Empty;

		public static readonly ulong MaxLength;

		internal long ExtensionDataLength
		{
			get
			{
				return _extDataLength;
			}
			set
			{
				_extDataLength = value;
			}
		}

		internal bool IncludesReservedCloseStatusCode => _length > 1 && _data.SubArray(0, 2).ToUInt16(ByteOrder.Big).IsReserved();

		public byte[] ApplicationData => (_extDataLength > 0) ? _data.SubArray(_extDataLength, _length - _extDataLength) : _data;

		public byte[] ExtensionData => (_extDataLength > 0) ? _data.SubArray(0L, _extDataLength) : WebSocket.EmptyBytes;

		public ulong Length => (ulong)_length;

		static PayloadData()
		{
			Empty = new PayloadData();
			MaxLength = 9223372036854775807uL;
		}

		internal PayloadData()
		{
			_data = WebSocket.EmptyBytes;
		}

		internal PayloadData(byte[] data)
			: this(data, data.LongLength)
		{
		}

		internal PayloadData(byte[] data, long length)
		{
			_data = data;
			_length = length;
		}

		internal void Mask(byte[] key)
		{
			for (long num = 0L; num < _length; num++)
			{
				_data[num] ^= key[num % 4];
			}
		}

		public IEnumerator<byte> GetEnumerator()
		{
			byte[] data = _data;
			for (int i = 0; i < data.Length; i++)
			{
				yield return data[i];
			}
		}

		public byte[] ToArray()
		{
			return _data;
		}

		public override string ToString()
		{
			return BitConverter.ToString(_data);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	internal enum Rsv : byte
	{
		Off,
		On
	}
	public enum CompressionMethod : byte
	{
		None,
		Deflate
	}
	public class WebSocketException : Exception
	{
		private CloseStatusCode _code;

		public CloseStatusCode Code => _code;

		internal WebSocketException()
			: this(CloseStatusCode.Abnormal, null, null)
		{
		}

		internal WebSocketException(Exception innerException)
			: this(CloseStatusCode.Abnormal, null, innerException)
		{
		}

		internal WebSocketException(string message)
			: this(CloseStatusCode.Abnormal, message, null)
		{
		}

		internal WebSocketException(CloseStatusCode code)
			: this(code, null, null)
		{
		}

		internal WebSocketException(string message, Exception innerException)
			: this(CloseStatusCode.Abnormal, message, innerException)
		{
		}

		internal WebSocketException(CloseStatusCode code, Exception innerException)
			: this(code, null, innerException)
		{
		}

		internal WebSocketException(CloseStatusCode code, string message)
			: this(code, message, null)
		{
		}

		internal WebSocketException(CloseStatusCode code, string message, Exception innerException)
			: base(message ?? code.GetMessage(), innerException)
		{
			_code = code;
		}
	}
	public class LogData
	{
		private StackFrame _caller;

		private DateTime _date;

		private LogLevel _level;

		private string _message;

		public StackFrame Caller => _caller;

		public DateTime Date => _date;

		public LogLevel Level => _level;

		public string Message => _message;

		internal LogData(LogLevel level, StackFrame caller, string message)
		{
			_level = level;
			_caller = caller;
			_message = message ?? string.Empty;
			_date = DateTime.Now;
		}

		public override string ToString()
		{
			string text = $"{_date}|{_level,-5}|";
			MethodBase method = _caller.GetMethod();
			Type declaringType = method.DeclaringType;
			string arg = $"{text}{declaringType.Name}.{method.Name}|";
			string[] array = _message.Replace("\r\n", "\n").TrimEnd('\n').Split('\n');
			if (array.Length <= 1)
			{
				return $"{arg}{_message}";
			}
			StringBuilder stringBuilder = new StringBuilder($"{arg}{array[0]}\n", 64);
			string format = $"{{0,{text.Length}}}{{1}}\n";
			for (int i = 1; i < array.Length; i++)
			{
				stringBuilder.AppendFormat(format, "", array[i]);
			}
			stringBuilder.Length--;
			return stringBuilder.ToString();
		}
	}
	public enum LogLevel
	{
		Trace,
		Debug,
		Info,
		Warn,
		Error,
		Fatal
	}
	public class Logger
	{
		private volatile string _file;

		private volatile LogLevel _level;

		private Action<LogData, string> _output;

		private object _sync;

		public string File
		{
			get
			{
				return _file;
			}
			set
			{
				lock (_sync)
				{
					_file = value;
					Warn($"The current path to the log file has been changed to {_file}.");
				}
			}
		}

		public LogLevel Level
		{
			get
			{
				return _level;
			}
			set
			{
				lock (_sync)
				{
					_level = value;
					Warn($"The current logging level has been changed to {_level}.");
				}
			}
		}

		public Action<LogData, string> Output
		{
			get
			{
				return _output;
			}
			set
			{
				lock (_sync)
				{
					_output = value ?? new Action<LogData, string>(defaultOutput);
					Warn("The current output action has been changed.");
				}
			}
		}

		public Logger()
			: this(LogLevel.Error, null, null)
		{
		}

		public Logger(LogLevel level)
			: this(level, null, null)
		{
		}

		public Logger(LogLevel level, string file, Action<LogData, string> output)
		{
			_level = level;
			_file = file;
			_output = output ?? new Action<LogData, string>(defaultOutput);
			_sync = new object();
		}

		private static void defaultOutput(LogData data, string path)
		{
			string value = data.ToString();
			Console.WriteLine(value);
			if (path != null && path.Length > 0)
			{
				writeToFile(value, path);
			}
		}

		private void output(string message, LogLevel level)
		{
			lock (_sync)
			{
				if (_level > level)
				{
					return;
				}
				LogData logData = null;
				try
				{
					logData = new LogData(level, new StackFrame(2, fNeedFileInfo: true), message);
					_output(logData, _file);
				}
				catch (Exception ex)
				{
					logData = new LogData(LogLevel.Fatal, new StackFrame(0, fNeedFileInfo: true), ex.Message);
					Console.WriteLine(logData.ToString());
				}
			}
		}

		private static void writeToFile(string value, string path)
		{
			using StreamWriter writer = new StreamWriter(path, append: true);
			using TextWriter textWriter = TextWriter.Synchronized(writer);
			textWriter.WriteLine(value);
		}

		public void Debug(string message)
		{
			if (_level <= LogLevel.Debug)
			{
				output(message, LogLevel.Debug);
			}
		}

		public void Error(string message)
		{
			if (_level <= LogLevel.Error)
			{
				output(message, LogLevel.Error);
			}
		}

		public void Fatal(string message)
		{
			output(message, LogLevel.Fatal);
		}

		public void Info(string message)
		{
			if (_level <= LogLevel.Info)
			{
				output(message, LogLevel.Info);
			}
		}

		public void Trace(string message)
		{
			if (_level <= LogLevel.Trace)
			{
				output(message, LogLevel.Trace);
			}
		}

		public void Warn(string message)
		{
			if (_level <= LogLevel.Warn)
			{
				output(message, LogLevel.Warn);
			}
		}
	}
	public enum WebSocketState : ushort
	{
		Connecting,
		Open,
		Closing,
		Closed
	}
	internal class WebSocketFrame : IEnumerable<byte>, IEnumerable
	{
		private byte[] _extPayloadLength;

		private Fin _fin;

		private Mask _mask;

		private byte[] _maskingKey;

		private Opcode _opcode;

		private PayloadData _payloadData;

		private byte _payloadLength;

		private Rsv _rsv1;

		private Rsv _rsv2;

		private Rsv _rsv3;

		internal static readonly byte[] EmptyPingBytes;

		internal int ExtendedPayloadLengthCount => (_payloadLength >= 126) ? ((_payloadLength == 126) ? 2 : 8) : 0;

		internal ulong FullPayloadLength => (_payloadLength < 126) ? _payloadLength : ((_payloadLength == 126) ? _extPayloadLength.ToUInt16(ByteOrder.Big) : _extPayloadLength.ToUInt64(ByteOrder.Big));

		public byte[] ExtendedPayloadLength => _extPayloadLength;

		public Fin Fin => _fin;

		public bool IsBinary => _opcode == Opcode.Binary;

		public bool IsClose => _opcode == Opcode.Close;

		public bool IsCompressed => _rsv1 == Rsv.On;

		public bool IsContinuation => _opcode == Opcode.Cont;

		public bool IsControl => (int)_opcode >= 8;

		public bool IsData => _opcode == Opcode.Text || _opcode == Opcode.Binary;

		public bool IsFinal => _fin == Fin.Final;

		public bool IsFragment => _fin == Fin.More || _opcode == Opcode.Cont;

		public bool IsMasked => _mask == Mask.On;

		public bool IsPing => _opcode == Opcode.Ping;

		public bool IsPong => _opcode == Opcode.Pong;

		public bool IsText => _opcode == Opcode.Text;

		public ulong Length => (ulong)(2L + (long)(_extPayloadLength.Length + _maskingKey.Length)) + _payloadData.Length;

		public Mask Mask => _mask;

		public byte[] MaskingKey => _maskingKey;

		public Opcode Opcode => _opcode;

		public PayloadData PayloadData => _payloadData;

		public byte PayloadLength => _payloadLength;

		public Rsv Rsv1 => _rsv1;

		public Rsv Rsv2 => _rsv2;

		public Rsv Rsv3 => _rsv3;

		static WebSocketFrame()
		{
			EmptyPingBytes = CreatePingFrame(mask: false).ToArray();
		}

		private WebSocketFrame()
		{
		}

		internal WebSocketFrame(Opcode opcode, PayloadData payloadData, bool mask)
			: this(Fin.Final, opcode, payloadData, compressed: false, mask)
		{
		}

		internal WebSocketFrame(Fin fin, Opcode opcode, byte[] data, bool compressed, bool mask)
			: this(fin, opcode, new PayloadData(data), compressed, mask)
		{
		}

		internal WebSocketFrame(Fin fin, Opcode opcode, PayloadData payloadData, bool compressed, bool mask)
		{
			_fin = fin;
			_rsv1 = ((opcode.IsData() && compressed) ? Rsv.On : Rsv.Off);
			_rsv2 = Rsv.Off;
			_rsv3 = Rsv.Off;
			_opcode = opcode;
			ulong length = payloadData.Length;
			if (length < 126)
			{
				_payloadLength = (byte)length;
				_extPayloadLength = WebSocket.EmptyBytes;
			}
			else if (length < 65536)
			{
				_payloadLength = 126;
				_extPayloadLength = ((ushort)length).InternalToByteArray(ByteOrder.Big);
			}
			else
			{
				_payloadLength = 127;
				_extPayloadLength = length.InternalToByteArray(ByteOrder.Big);
			}
			if (mask)
			{
				_mask = Mask.On;
				_maskingKey = createMaskingKey();
				payloadData.Mask(_maskingKey);
			}
			else
			{
				_mask = Mask.Off;
				_maskingKey = WebSocket.EmptyBytes;
			}
			_payloadData = payloadData;
		}

		private static byte[] createMaskingKey()
		{
			byte[] array = new byte[4];
			WebSocket.RandomNumber.GetBytes(array);
			return array;
		}

		private static string dump(WebSocketFrame frame)
		{
			ulong length = frame.Length;
			long num = (long)(length / 4);
			int num2 = (int)(length % 4);
			int num3;
			string arg;
			if (num < 10000)
			{
				num3 = 4;
				arg = "{0,4}";
			}
			else if (num < 65536)
			{
				num3 = 4;
				arg = "{0,4:X}";
			}
			else if (num < 4294967296L)
			{
				num3 = 8;
				arg = "{0,8:X}";
			}
			else
			{
				num3 = 16;
				arg = "{0,16:X}";
			}
			string arg2 = $"{{0,{num3}}}";
			string format = string.Format("\n{0} 01234567 89ABCDEF 01234567 89ABCDEF\n{0}+--------+--------+--------+--------+\\n", arg2);
			string lineFmt = $"{arg}|{{1,8}} {{2,8}} {{3,8}} {{4,8}}|\n";
			string format2 = $"{arg2}+--------+--------+--------+--------+";
			StringBuilder output = new StringBuilder(64);
			Func<Action<string, string, string, string>> func = delegate
			{
				long lineCnt = 0L;
				return delegate(string text, string text2, string text3, string text4)
				{
					output.AppendFormat(lineFmt, ++lineCnt, text, text2, text3, text4);
				};
			};
			Action<string, string, string, string> action = func();
			output.AppendFormat(format, string.Empty);
			byte[] array = frame.ToArray();
			for (long num4 = 0L; num4 <= num; num4++)
			{
				long num5 = num4 * 4;
				if (num4 < num)
				{
					action(Convert.ToString(array[num5], 2).PadLeft(8, '0'), Convert.ToString(array[num5 + 1], 2).PadLeft(8, '0'), Convert.ToString(array[num5 + 2], 2).PadLeft(8, '0'), Convert.ToString(array[num5 + 3], 2).PadLeft(8, '0'));
				}
				else if (num2 > 0)
				{
					action(Convert.ToString(array[num5], 2).PadLeft(8, '0'), (num2 >= 2) ? Convert.ToString(array[num5 + 1], 2).PadLeft(8, '0') : string.Empty, (num2 == 3) ? Convert.ToString(array[num5 + 2], 2).PadLeft(8, '0') : string.Empty, string.Empty);
				}
			}
			output.AppendFormat(format2, string.Empty);
			return output.ToString();
		}

		private static string print(WebSocketFrame frame)
		{
			byte payloadLength = frame._payloadLength;
			string text = ((payloadLength > 125) ? frame.FullPayloadLength.ToString() : string.Empty);
			string text2 = BitConverter.ToString(frame._maskingKey);
			string text3 = ((payloadLength == 0) ? string.Empty : ((payloadLength > 125) ? "---" : ((frame.IsText && !frame.IsFragment && !frame.IsMasked && !frame.IsCompressed) ? frame._payloadData.ApplicationData.UTF8Decode() : frame._payloadData.ToString())));
			string format = "\n                    FIN: {0}\n                   RSV1: {1}\n                   RSV2: {2}\n                   RSV3: {3}\n                 Opcode: {4}\n                   MASK: {5}\n         Payload Length: {6}\nExtended Payload Length: {7}\n            Masking Key: {8}\n           Payload Data: {9}";
			return string.Format(format, frame._fin, frame._rsv1, frame._rsv2, frame._rsv3, frame._opcode, frame._mask, payloadLength, text, text2, text3);
		}

		private static WebSocketFrame processHeader(byte[] header)
		{
			if (header.Length != 2)
			{
				throw new WebSocketException("The header of a frame cannot be read from the stream.");
			}
			Fin fin = (((header[0] & 0x80) == 128) ? Fin.Final : Fin.More);
			Rsv rsv = (((header[0] & 0x40) == 64) ? Rsv.On : Rsv.Off);
			Rsv rsv2 = (((header[0] & 0x20) == 32) ? Rsv.On : Rsv.Off);
			Rsv rsv3 = (((header[0] & 0x10) == 16) ? Rsv.On : Rsv.Off);
			byte opcode = (byte)(header[0] & 0xF);
			Mask mask = (((header[1] & 0x80) == 128) ? Mask.On : Mask.Off);
			byte b = (byte)(header[1] & 0x7F);
			string text = ((!opcode.IsSupported()) ? "An unsupported opcode." : ((!opcode.IsData() && rsv == Rsv.On) ? "A non data frame is compressed." : ((opcode.IsControl() && fin == Fin.More) ? "A control frame is fragmented." : ((opcode.IsControl() && b > 125) ? "A control frame has a long payload length." : null))));
			if (text != null)
			{
				throw new WebSocketException(CloseStatusCode.ProtocolError, text);
			}
			WebSocketFrame webSocketFrame = new WebSocketFrame();
			webSocketFrame._fin = fin;
			webSocketFrame._rsv1 = rsv;
			webSocketFrame._rsv2 = rsv2;
			webSocketFrame._rsv3 = rsv3;
			webSocketFrame._opcode = (Opcode)opcode;
			webSocketFrame._mask = mask;
			webSocketFrame._payloadLength = b;
			return webSocketFrame;
		}

		private static WebSocketFrame readExtendedPayloadLength(Stream stream, WebSocketFrame frame)
		{
			int extendedPayloadLengthCount = frame.ExtendedPayloadLengthCount;
			if (extendedPayloadLengthCount == 0)
			{
				frame._extPayloadLength = WebSocket.EmptyBytes;
				return frame;
			}
			byte[] array = stream.ReadBytes(extendedPayloadLengthCount);
			if (array.Length != extendedPayloadLengthCount)
			{
				throw new WebSocketException("The extended payload length of a frame cannot be read from the stream.");
			}
			frame._extPayloadLength = array;
			return frame;
		}

		private static void readExtendedPayloadLengthAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error)
		{
			int len = frame.ExtendedPayloadLengthCount;
			if (len == 0)
			{
				frame._extPayloadLength = WebSocket.EmptyBytes;
				completed(frame);
				return;
			}
			stream.ReadBytesAsync(len, delegate(byte[] bytes)
			{
				if (bytes.Length != len)
				{
					throw new WebSocketException("The extended payload length of a frame cannot be read from the stream.");
				}
				frame._extPayloadLength = bytes;
				completed(frame);
			}, error);
		}

		private static WebSocketFrame readHeader(Stream stream)
		{
			return processHeader(stream.ReadBytes(2));
		}

		private static void readHeaderAsync(Stream stream, Action<WebSocketFrame> completed, Action<Exception> error)
		{
			stream.ReadBytesAsync(2, delegate(byte[] bytes)
			{
				completed(processHeader(bytes));
			}, error);
		}

		private static WebSocketFrame readMaskingKey(Stream stream, WebSocketFrame frame)
		{
			int num = (frame.IsMasked ? 4 : 0);
			if (num == 0)
			{
				frame._maskingKey = WebSocket.EmptyBytes;
				return frame;
			}
			byte[] array = stream.ReadBytes(num);
			if (array.Length != num)
			{
				throw new WebSocketException("The masking key of a frame cannot be read from the stream.");
			}
			frame._maskingKey = array;
			return frame;
		}

		private static void readMaskingKeyAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error)
		{
			int len = (frame.IsMasked ? 4 : 0);
			if (len == 0)
			{
				frame._maskingKey = WebSocket.EmptyBytes;
				completed(frame);
				return;
			}
			stream.ReadBytesAsync(len, delegate(byte[] bytes)
			{
				if (bytes.Length != len)
				{
					throw new WebSocketException("The masking key of a frame cannot be read from the stream.");
				}
				frame._maskingKey = bytes;
				completed(frame);
			}, error);
		}

		private static WebSocketFrame readPayloadData(Stream stream, WebSocketFrame frame)
		{
			ulong fullPayloadLength = frame.FullPayloadLength;
			if (fullPayloadLength == 0)
			{
				frame._payloadData = PayloadData.Empty;
				return frame;
			}
			if (fullPayloadLength > PayloadData.MaxLength)
			{
				throw new WebSocketException(CloseStatusCode.TooBig, "A frame has a long payload length.");
			}
			long num = (long)fullPayloadLength;
			byte[] array = ((frame._payloadLength < 127) ? stream.ReadBytes((int)fullPayloadLength) : stream.ReadBytes(num, 1024));
			if (array.LongLength != num)
			{
				throw new WebSocketException("The payload data of a frame cannot be read from the stream.");
			}
			frame._payloadData = new PayloadData(array, num);
			return frame;
		}

		private static void readPayloadDataAsync(Stream stream, WebSocketFrame frame, Action<WebSocketFrame> completed, Action<Exception> error)
		{
			ulong fullPayloadLength = frame.FullPayloadLength;
			if (fullPayloadLength == 0)
			{
				frame._payloadData = PayloadData.Empty;
				completed(frame);
				return;
			}
			if (fullPayloadLength > PayloadData.MaxLength)
			{
				throw new WebSocketException(CloseStatusCode.TooBig, "A frame has a long payload length.");
			}
			long llen = (long)fullPayloadLength;
			Action<byte[]> completed2 = delegate(byte[] bytes)
			{
				if (bytes.LongLength != llen)
				{
					throw new WebSocketException("The payload data of a frame cannot be read from the stream.");
				}
				frame._payloadData = new PayloadData(bytes, llen);
				completed(frame);
			};
			if (frame._payloadLength < 127)
			{
				stream.ReadBytesAsync((int)fullPayloadLength, completed2, error);
			}
			else
			{
				stream.ReadBytesAsync(llen, 1024, completed2, error);
			}
		}

		internal static WebSocketFrame CreateCloseFrame(PayloadData payloadData, bool mask)
		{
			return new WebSocketFrame(Fin.Final, Opcode.Close, payloadData, compressed: false, mask);
		}

		internal static WebSocketFrame CreatePingFrame(bool mask)
		{
			return new WebSocketFrame(Fin.Final, Opcode.Ping, PayloadData.Empty, compressed: false, mask);
		}

		internal static WebSocketFrame CreatePingFrame(byte[] data, bool mask)
		{
			return new WebSocketFrame(Fin.Final, Opcode.Ping, new PayloadData(data), compressed: false, mask);
		}

		internal static WebSocketFrame ReadFrame(Stream stream, bool unmask)
		{
			WebSocketFrame webSocketFrame = readHeader(stream);
			readExtendedPayloadLength(stream, webSocketFrame);
			readMaskingKey(stream, webSocketFrame);
			readPayloadData(stream, webSocketFrame);
			if (unmask)
			{
				webSocketFrame.Unmask();
			}
			return webSocketFrame;
		}

		internal static void ReadFrameAsync(Stream stream, bool unmask, Action<WebSocketFrame> completed, Action<Exception> error)
		{
			readHeaderAsync(stream, delegate(WebSocketFrame frame)
			{
				readExtendedPayloadLengthAsync(stream, frame, delegate(WebSocketFrame frame2)
				{
					readMaskingKeyAsync(stream, frame2, delegate(WebSocketFrame frame3)
					{
						readPayloadDataAsync(stream, frame3, delegate(WebSocketFrame webSocketFrame)
						{
							if (unmask)
							{
								webSocketFrame.Unmask();
							}
							completed(webSocketFrame);
						}, error);
					}, error);
				}, error);
			}, error);
		}

		internal void Unmask()
		{
			if (_mask != Mask.Off)
			{
				_mask = Mask.Off;
				_payloadData.Mask(_maskingKey);
				_maskingKey = WebSocket.EmptyBytes;
			}
		}

		public IEnumerator<byte> GetEnumerator()
		{
			byte[] array = ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				yield return array[i];
			}
		}

		public void Print(bool dumped)
		{
			Console.WriteLine(dumped ? dump(this) : print(this));
		}

		public string PrintToString(bool dumped)
		{
			return dumped ? dump(this) : print(this);
		}

		public byte[] ToArray()
		{
			using MemoryStream memoryStream = new MemoryStream();
			int fin = (int)_fin;
			fin = (fin << 1) + (int)_rsv1;
			fin = (fin << 1) + (int)_rsv2;
			fin = (fin << 1) + (int)_rsv3;
			fin = (fin << 4) + (int)_opcode;
			fin = (fin << 1) + (int)_mask;
			fin = (fin << 7) + _payloadLength;
			memoryStream.Write(((ushort)fin).InternalToByteArray(ByteOrder.Big), 0, 2);
			if (_payloadLength > 125)
			{
				memoryStream.Write(_extPayloadLength, 0, (_payloadLength == 126) ? 2 : 8);
			}
			if (_mask == Mask.On)
			{
				memoryStream.Write(_maskingKey, 0, 4);
			}
			if (_payloadLength > 0)
			{
				byte[] array = _payloadData.ToArray();
				if (_payloadLength < 127)
				{
					memoryStream.Write(array, 0, array.Length);
				}
				else
				{
					memoryStream.WriteBytes(array, 1024);
				}
			}
			memoryStream.Close();
			return memoryStream.ToArray();
		}

		public override string ToString()
		{
			return BitConverter.ToString(ToArray());
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	internal abstract class HttpBase
	{
		private NameValueCollection _headers;

		private const int _headersMaxLength = 8192;

		private Version _version;

		internal byte[] EntityBodyData;

		protected const string CrLf = "\r\n";

		public string EntityBody
		{
			get
			{
				if (EntityBodyData == null || EntityBodyData.LongLength == 0)
				{
					return string.Empty;
				}
				Encoding encoding = null;
				string text = _headers["Content-Type"];
				if (text != null && text.Length > 0)
				{
					encoding = HttpUtility.GetEncoding(text);
				}
				return (encoding ?? Encoding.UTF8).GetString(EntityBodyData);
			}
		}

		public NameValueCollection Headers => _headers;

		public Version ProtocolVersion => _version;

		protected HttpBase(Version version, NameValueCollection headers)
		{
			_version = version;
			_headers = headers;
		}

		private static byte[] readEntityBody(Stream stream, string length)
		{
			if (!long.TryParse(length, out var result))
			{
				throw new ArgumentException("Cannot be parsed.", "length");
			}
			if (result < 0)
			{
				throw new ArgumentOutOfRangeException("length", "Less than zero.");
			}
			return (result > 1024) ? stream.ReadBytes(result, 1024) : ((result > 0) ? stream.ReadBytes((int)result) : null);
		}

		private static string[] readHeaders(Stream stream, int maxLength)
		{
			List<byte> buff = new List<byte>();
			int cnt = 0;
			Action<int> action = delegate(int i)
			{
				if (i == -1)
				{
					throw new EndOfStreamException("The header cannot be read from the data source.");
				}
				buff.Add((byte)i);
				cnt++;
			};
			bool flag = false;
			while (cnt < maxLength)
			{
				if (stream.ReadByte().EqualsWith('\r', action) && stream.ReadByte().EqualsWith('\n', action) && stream.ReadByte().EqualsWith('\r', action) && stream.ReadByte().EqualsWith('\n', action))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				throw new WebSocketException("The length of header part is greater than the max length.");
			}
			return Encoding.UTF8.GetString(buff.ToArray()).Replace("\r\n ", " ").Replace("\r\n\t", " ")
				.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
		}

		protected static T Read<T>(Stream stream, Func<string[], T> parser, int millisecondsTimeout) where T : HttpBase
		{
			bool timeout = false;
			System.Threading.Timer timer = new System.Threading.Timer(delegate
			{
				timeout = true;
				stream.Close();
			}, null, millisecondsTimeout, -1);
			T val = null;
			Exception ex = null;
			try
			{
				val = parser(readHeaders(stream, 8192));
				string text = val.Headers["Content-Length"];
				if (text != null && text.Length > 0)
				{
					val.EntityBodyData = readEntityBody(stream, text);
				}
			}
			catch (Exception ex2)
			{
				ex = ex2;
			}
			finally
			{
				timer.Change(-1, -1);
				timer.Dispose();
			}
			string text2 = (timeout ? "A timeout has occurred while reading an HTTP request/response." : ((ex != null) ? "An exception has occurred while reading an HTTP request/response." : null));
			if (text2 != null)
			{
				throw new WebSocketException(text2, ex);
			}
			return val;
		}

		public byte[] ToByteArray()
		{
			return Encoding.UTF8.GetBytes(ToString());
		}
	}
	internal class HttpRequest : HttpBase
	{
		private string _method;

		private string _uri;

		private bool _websocketRequest;

		private bool _websocketRequestSet;

		public AuthenticationResponse AuthenticationResponse
		{
			get
			{
				string text = base.Headers["Authorization"];
				return (text != null && text.Length > 0) ? AuthenticationResponse.Parse(text) : null;
			}
		}

		public WebSocketSharp.Net.CookieCollection Cookies => base.Headers.GetCookies(response: false);

		public string HttpMethod => _method;

		public bool IsWebSocketRequest
		{
			get
			{
				if (!_websocketRequestSet)
				{
					NameValueCollection headers = base.Headers;
					_websocketRequest = _method == "GET" && base.ProtocolVersion > WebSocketSharp.Net.HttpVersion.Version10 && headers.Contains("Upgrade", "websocket") && headers.Contains("Connection", "Upgrade");
					_websocketRequestSet = true;
				}
				return _websocketRequest;
			}
		}

		public string RequestUri => _uri;

		private HttpRequest(string method, string uri, Version version, NameValueCollection headers)
			: base(version, headers)
		{
			_method = method;
			_uri = uri;
		}

		internal HttpRequest(string method, string uri)
			: this(method, uri, WebSocketSharp.Net.HttpVersion.Version11, new NameValueCollection())
		{
			base.Headers["User-Agent"] = "websocket-sharp/1.0";
		}

		internal static HttpRequest CreateConnectRequest(Uri uri)
		{
			string dnsSafeHost = uri.DnsSafeHost;
			int port = uri.Port;
			string text = $"{dnsSafeHost}:{port}";
			HttpRequest httpRequest = new HttpRequest("CONNECT", text);
			httpRequest.Headers["Host"] = ((port == 80) ? dnsSafeHost : text);
			return httpRequest;
		}

		internal static HttpRequest CreateWebSocketRequest(Uri uri)
		{
			HttpRequest httpRequest = new HttpRequest("GET", uri.PathAndQuery);
			NameValueCollection headers = httpRequest.Headers;
			int port = uri.Port;
			string scheme = uri.Scheme;
			headers["Host"] = (((port == 80 && scheme == "ws") || (port == 443 && scheme == "wss")) ? uri.DnsSafeHost : uri.Authority);
			headers["Upgrade"] = "websocket";
			headers["Connection"] = "Upgrade";
			return httpRequest;
		}

		internal HttpResponse GetResponse(Stream stream, int millisecondsTimeout)
		{
			byte[] array = ToByteArray();
			stream.Write(array, 0, array.Length);
			return HttpBase.Read(stream, HttpResponse.Parse, millisecondsTimeout);
		}

		internal static HttpRequest Parse(string[] headerParts)
		{
			string[] array = headerParts[0].Split(new char[1] { ' ' }, 3);
			if (array.Length != 3)
			{
				throw new ArgumentException("Invalid request line: " + headerParts[0]);
			}
			WebSocketSharp.Net.WebHeaderCollection webHeaderCollection = new WebSocketSharp.Net.WebHeaderCollection();
			for (int i = 1; i < headerParts.Length; i++)
			{
				webHeaderCollection.InternalSet(headerParts[i], response: false);
			}
			return new HttpRequest(array[0], array[1], new Version(array[2].Substring(5)), webHeaderCollection);
		}

		internal static HttpRequest Read(Stream stream, int millisecondsTimeout)
		{
			return HttpBase.Read(stream, Parse, millisecondsTimeout);
		}

		public void SetCookies(WebSocketSharp.Net.CookieCollection cookies)
		{
			if (cookies == null || cookies.Count == 0)
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder(64);
			foreach (WebSocketSharp.Net.Cookie item in cookies.Sorted)
			{
				if (!item.Expired)
				{
					stringBuilder.AppendFormat("{0}; ", item.ToString());
				}
			}
			int length = stringBuilder.Length;
			if (length > 2)
			{
				stringBuilder.Length = length - 2;
				base.Headers["Cookie"] = stringBuilder.ToString();
			}
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(64);
			stringBuilder.AppendFormat("{0} {1} HTTP/{2}{3}", _method, _uri, base.ProtocolVersion, "\r\n");
			NameValueCollection headers = base.Headers;
			string[] allKeys = headers.AllKeys;
			foreach (string text in allKeys)
			{
				stringBuilder.AppendFormat("{0}: {1}{2}", text, headers[text], "\r\n");
			}
			stringBuilder.Append("\r\n");
			string entityBody = base.EntityBody;
			if (entityBody.Length > 0)
			{
				stringBuilder.Append(entityBody);
			}
			return stringBuilder.ToString();
		}
	}
	internal class HttpResponse : HttpBase
	{
		private string _code;

		private string _reason;

		public WebSocketSharp.Net.CookieCollection Cookies => base.Headers.GetCookies(response: true);

		public bool HasConnectionClose => base.Headers.Contains("Connection", "close");

		public bool IsProxyAuthenticationRequired => _code == "407";

		public bool IsRedirect => _code == "301" || _code == "302";

		public bool IsUnauthorized => _code == "401";

		public bool IsWebSocketResponse
		{
			get
			{
				NameValueCollection headers = base.Headers;
				return base.ProtocolVersion > WebSocketSharp.Net.HttpVersion.Version10 && _code == "101" && headers.Contains("Upgrade", "websocket") && headers.Contains("Connection", "Upgrade");
			}
		}

		public string Reason => _reason;

		public string StatusCode => _code;

		private HttpResponse(string code, string reason, Version version, NameValueCollection headers)
			: base(version, headers)
		{
			_code = code;
			_reason = reason;
		}

		internal HttpResponse(WebSocketSharp.Net.HttpStatusCode code)
			: this(code, code.GetDescription())
		{
		}

		internal HttpResponse(WebSocketSharp.Net.HttpStatusCode code, string reason)
			: this(((int)code).ToString(), reason, WebSocketSharp.Net.HttpVersion.Version11, new NameValueCollection())
		{
			base.Headers["Server"] = "websocket-sharp/1.0";
		}

		internal static HttpResponse CreateCloseResponse(WebSocketSharp.Net.HttpStatusCode code)
		{
			HttpResponse httpResponse = new HttpResponse(code);
			httpResponse.Headers["Connection"] = "close";
			return httpResponse;
		}

		internal static HttpResponse CreateUnauthorizedResponse(string challenge)
		{
			HttpResponse httpResponse = new HttpResponse(WebSocketSharp.Net.HttpStatusCode.Unauthorized);
			httpResponse.Headers["WWW-Authenticate"] = challenge;
			return httpResponse;
		}

		internal static HttpResponse CreateWebSocketResponse()
		{
			HttpResponse httpResponse = new HttpResponse(WebSocketSharp.Net.HttpStatusCode.SwitchingProtocols);
			NameValueCollection headers = httpResponse.Headers;
			headers["Upgrade"] = "websocket";
			headers["Connection"] = "Upgrade";
			return httpResponse;
		}

		internal static HttpResponse Parse(string[] headerParts)
		{
			string[] array = headerParts[0].Split(new char[1] { ' ' }, 3);
			if (array.Length != 3)
			{
				throw new ArgumentException("Invalid status line: " + headerParts[0]);
			}
			WebSocketSharp.Net.WebHeaderCollection webHeaderCollection = new WebSocketSharp.Net.WebHeaderCollection();
			for (int i = 1; i < headerParts.Length; i++)
			{
				webHeaderCollection.InternalSet(headerParts[i], response: true);
			}
			return new HttpResponse(array[1], array[2], new Version(array[0].Substring(5)), webHeaderCollection);
		}

		internal static HttpResponse Read(Stream stream, int millisecondsTimeout)
		{
			return HttpBase.Read(stream, Parse, millisecondsTimeout);
		}

		public void SetCookies(WebSocketSharp.Net.CookieCollection cookies)
		{
			if (cookies == null || cookies.Count == 0)
			{
				return;
			}
			NameValueCollection headers = base.Headers;
			foreach (WebSocketSharp.Net.Cookie item in cookies.Sorted)
			{
				headers.Add("Set-Cookie", item.ToResponseString());
			}
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(64);
			stringBuilder.AppendFormat("HTTP/{0} {1} {2}{3}", base.ProtocolVersion, _code, _reason, "\r\n");
			NameValueCollection headers = base.Headers;
			string[] allKeys = headers.AllKeys;
			foreach (string text in allKeys)
			{
				stringBuilder.AppendFormat("{0}: {1}{2}", text, headers[text], "\r\n");
			}
			stringBuilder.Append("\r\n");
			string entityBody = base.EntityBody;
			if (entityBody.Length > 0)
			{
				stringBuilder.Append(entityBody);
			}
			return stringBuilder.ToString();
		}
	}
}
namespace WebSocketSharp.Net
{
	public enum AuthenticationSchemes
	{
		None = 0,
		Digest = 1,
		Basic = 8,
		Anonymous = 0x8000
	}
	internal class ChunkStream
	{
		private int _chunkRead;

		private int _chunkSize;

		private List<Chunk> _chunks;

		private bool _gotIt;

		private WebHeaderCollection _headers;

		private StringBuilder _saved;

		private bool _sawCr;

		private InputChunkState _state;

		private int _trailerState;

		internal WebHeaderCollection Headers => _headers;

		public int ChunkLeft => _chunkSize - _chunkRead;

		public bool WantMore => _state != InputChunkState.End;

		public ChunkStream(WebHeaderCollection headers)
		{
			_headers = headers;
			_chunkSize = -1;
			_chunks = new List<Chunk>();
			_saved = new StringBuilder();
		}

		public ChunkStream(byte[] buffer, int offset, int count, WebHeaderCollection headers)
			: this(headers)
		{
			Write(buffer, offset, count);
		}

		private int read(byte[] buffer, int offset, int count)
		{
			int num = 0;
			int count2 = _chunks.Count;
			for (int i = 0; i < count2; i++)
			{
				Chunk chunk = _chunks[i];
				if (chunk == null)
				{
					continue;
				}
				if (chunk.ReadLeft == 0)
				{
					_chunks[i] = null;
					continue;
				}
				num += chunk.Read(buffer, offset + num, count - num);
				if (num == count)
				{
					break;
				}
			}
			return num;
		}

		private static string removeChunkExtension(string value)
		{
			int num = value.IndexOf(';');
			return (num > -1) ? value.Substring(0, num) : value;
		}

		private InputChunkState seekCrLf(byte[] buffer, ref int offset, int length)
		{
			if (!_sawCr)
			{
				if (buffer[offset++] != 13)
				{
					throwProtocolViolation("CR is expected.");
				}
				_sawCr = true;
				if (offset == length)
				{
					return InputChunkState.DataEnded;
				}
			}
			if (buffer[offset++] != 10)
			{
				throwProtocolViolation("LF is expected.");
			}
			return InputChunkState.None;
		}

		private InputChunkState setChunkSize(byte[] buffer, ref int offset, int length)
		{
			byte b = 0;
			while (offset < length)
			{
				b = buffer[offset++];
				if (_sawCr)
				{
					if (b != 10)
					{
						throwProtocolViolation("LF is expected.");
					}
					break;
				}
				switch (b)
				{
				case 13:
					_sawCr = true;
					continue;
				case 10:
					throwProtocolViolation("LF is unexpected.");
					break;
				}
				if (b == 32)
				{
					_gotIt = true;
				}
				if (!_gotIt)
				{
					_saved.Append((char)b);
				}
				if (_saved.Length > 20)
				{
					throwProtocolViolation("The chunk size is too long.");
				}
			}
			if (!_sawCr || b != 10)
			{
				return InputChunkState.None;
			}
			_chunkRead = 0;
			try
			{
				_chunkSize = int.Parse(removeChunkExtension(_saved.ToString()), NumberStyles.HexNumber);
			}
			catch
			{
				throwProtocolViolation("The chunk size cannot be parsed.");
			}
			if (_chunkSize == 0)
			{
				_trailerState = 2;
				return InputChunkState.Trailer;
			}
			return InputChunkState.Data;
		}

		private InputChunkState setTrailer(byte[] buffer, ref int offset, int length)
		{
			if (_trailerState == 2 && buffer[offset] == 13 && _saved.Length == 0)
			{
				offset++;
				if (offset < length && buffer[offset] == 10)
				{
					offset++;
					return InputChunkState.End;
				}
				offset--;
			}
			while (offset < length && _trailerState < 4)
			{
				byte b = buffer[offset++];
				_saved.Append((char)b);
				if (_saved.Length > 4196)
				{
					throwProtocolViolation("The trailer is too long.");
				}
				if (_trailerState == 1 || _trailerState == 3)
				{
					if (b != 10)
					{
						throwProtocolViolation("LF is expected.");
					}
					_trailerState++;
					continue;
				}
				switch (b)
				{
				case 13:
					_trailerState++;
					continue;
				case 10:
					throwProtocolViolation("LF is unexpected.");
					break;
				}
				_trailerState = 0;
			}
			if (_trailerState < 4)
			{
				return InputChunkState.Trailer;
			}
			_saved.Length -= 2;
			StringReader stringReader = new StringReader(_saved.ToString());
			string text;
			while ((text = stringReader.ReadLine()) != null && text.Length > 0)
			{
				_headers.Add(text);
			}
			return InputChunkState.End;
		}

		private static void throwProtocolViolation(string message)
		{
			throw new WebException(message, null, WebExceptionStatus.ServerProtocolViolation, null);
		}

		private void write(byte[] buffer, ref int offset, int length)
		{
			if (_state == InputChunkState.End)
			{
				throwProtocolViolation("The chunks were ended.");
			}
			if (_state == InputChunkState.None)
			{
				_state = setChunkSize(buffer, ref offset, length);
				if (_state == InputChunkState.None)
				{
					return;
				}
				_saved.Length = 0;
				_sawCr = false;
				_gotIt = false;
			}
			if (_state == InputChunkState.Data && offset < length)
			{
				_state = writeData(buffer, ref offset, length);
				if (_state == InputChunkState.Data)
				{
					return;
				}
			}
			if (_state == InputChunkState.DataEnded && offset < length)
			{
				_state = seekCrLf(buffer, ref offset, length);
				if (_state == InputChunkState.DataEnded)
				{
					return;
				}
				_sawCr = false;
			}
			if (_state == InputChunkState.Trailer && offset < length)
			{
				_state = setTrailer(buffer, ref offset, length);
				if (_state == InputChunkState.Trailer)
				{
					return;
				}
				_saved.Length = 0;
			}
			if (offset < length)
			{
				write(buffer, ref offset, length);
			}
		}

		private InputChunkState writeData(byte[] buffer, ref int offset, int length)
		{
			int num = length - offset;
			int num2 = _chunkSize - _chunkRead;
			if (num > num2)
			{
				num = num2;
			}
			byte[] array = new byte[num];
			Buffer.BlockCopy(buffer, offset, array, 0, num);
			_chunks.Add(new Chunk(array));
			offset += num;
			_chunkRead += num;
			return (_chunkRead != _chunkSize) ? InputChunkState.Data : InputChunkState.DataEnded;
		}

		internal void ResetBuffer()
		{
			_chunkRead = 0;
			_chunkSize = -1;
			_chunks.Clear();
		}

		internal int WriteAndReadBack(byte[] buffer, int offset, int writeCount, int readCount)
		{
			Write(buffer, offset, writeCount);
			return Read(buffer, offset, readCount);
		}

		public int Read(byte[] buffer, int offset, int count)
		{
			if (count <= 0)
			{
				return 0;
			}
			return read(buffer, offset, count);
		}

		public void Write(byte[] buffer, int offset, int count)
		{
			if (count > 0)
			{
				write(buffer, ref offset, offset + count);
			}
		}
	}
	[Serializable]
	public sealed class Cookie
	{
		private string _comment;

		private Uri _commentUri;

		private bool _discard;

		private string _domain;

		private DateTime _expires;

		private bool _httpOnly;

		private string _name;

		private string _path;

		private string _port;

		private int[] _ports;

		private static readonly char[] _reservedCharsForName;

		private static readonly char[] _reservedCharsForValue;

		private bool _secure;

		private DateTime _timestamp;

		private string _value;

		private int _version;

		internal bool ExactDomain { get; set; }

		internal int MaxAge
		{
			get
			{
				if (_expires == DateTime.MinValue)
				{
					return 0;
				}
				DateTime dateTime = ((_expires.Kind != DateTimeKind.Local) ? _expires.ToLocalTime() : _expires);
				TimeSpan timeSpan = dateTime - DateTime.Now;
				return (timeSpan > TimeSpan.Zero) ? ((int)timeSpan.TotalSeconds) : 0;
			}
		}

		internal int[] Ports => _ports;

		public string Comment
		{
			get
			{
				return _comment;
			}
			set
			{
				_comment = value ?? string.Empty;
			}
		}

		public Uri CommentUri
		{
			get
			{
				return _commentUri;
			}
			set
			{
				_commentUri = value;
			}
		}

		public bool Discard
		{
			get
			{
				return _discard;
			}
			set
			{
				_discard = value;
			}
		}

		public string Domain
		{
			get
			{
				return _domain;
			}
			set
			{
				if (value.IsNullOrEmpty())
				{
					_domain = string.Empty;
					ExactDomain = true;
				}
				else
				{
					_domain = value;
					ExactDomain = value[0] != '.';
				}
			}
		}

		public bool Expired
		{
			get
			{
				return _expires != DateTime.MinValue && _expires <= DateTime.Now;
			}
			set
			{
				_expires = (value ? DateTime.Now : DateTime.MinValue);
			}
		}

		public DateTime Expires
		{
			get
			{
				return _expires;
			}
			set
			{
				_expires = value;
			}
		}

		public bool HttpOnly
		{
			get
			{
				return _httpOnly;
			}
			set
			{
				_httpOnly = value;
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (!canSetName(value, out var message))
				{
					throw new CookieException(message);
				}
				_name = value;
			}
		}

		public string Path
		{
			get
			{
				return _path;
			}
			set
			{
				_path = value ?? string.Empty;
			}
		}

		public string Port
		{
			get
			{
				return _port;
			}
			set
			{
				if (value.IsNullOrEmpty())
				{
					_port = string.Empty;
					_ports = new int[0];
					return;
				}
				if (!value.IsEnclosedIn('"'))
				{
					throw new CookieException("The value specified for the Port attribute isn't enclosed in double quotes.");
				}
				if (!tryCreatePorts(value, out _ports, out var parseError))
				{
					throw new CookieException($"The value specified for the Port attribute contains an invalid value: {parseError}");
				}
				_port = value;
			}
		}

		public bool Secure
		{
			get
			{
				return _secure;
			}
			set
			{
				_secure = value;
			}
		}

		public DateTime TimeStamp => _timestamp;

		public string Value
		{
			get
			{
				return _value;
			}
			set
			{
				if (!canSetValue(value, out var message))
				{
					throw new CookieException(message);
				}
				_value = ((value.Length > 0) ? value : "\"\"");
			}
		}

		public int Version
		{
			get
			{
				return _version;
			}
			set
			{
				if (value < 0 || value > 1)
				{
					throw new ArgumentOutOfRangeException("value", "Not 0 or 1.");
				}
				_version = value;
			}
		}

		static Cookie()
		{
			_reservedCharsForName = new char[7] { ' ', '=', ';', ',', '\n', '\r', '\t' };
			_reservedCharsForValue = new char[2] { ';', ',' };
		}

		public Cookie()
		{
			_comment = string.Empty;
			_domain = string.Empty;
			_expires = DateTime.MinValue;
			_name = string.Empty;
			_path = string.Empty;
			_port = string.Empty;
			_ports = new int[0];
			_timestamp = DateTime.Now;
			_value = string.Empty;
			_version = 0;
		}

		public Cookie(string name, string value)
			: this()
		{
			Name = name;
			Value = value;
		}

		public Cookie(string name, string value, string path)
			: this(name, value)
		{
			Path = path;
		}

		public Cookie(string name, string value, string path, string domain)
			: this(name, value, path)
		{
			Domain = domain;
		}

		private static bool canSetName(string name, out string message)
		{
			if (name.IsNullOrEmpty())
			{
				message = "The value specified for the Name is null or empty.";
				return false;
			}
			if (name[0] == '$' || name.Contains(_reservedCharsForName))
			{
				message = "The value specified for the Name contains an invalid character.";
				return false;
			}
			message = string.Empty;
			return true;
		}

		private static bool canSetValue(string value, out string message)
		{
			if (value == null)
			{
				message = "The value specified for the Value is null.";
				return false;
			}
			if (value.Contains(_reservedCharsForValue) && !value.IsEnclosedIn('"'))
			{
				message = "The value specified for the Value contains an invalid character.";
				return false;
			}
			message = string.Empty;
			return true;
		}

		private static int hash(int i, int j, int k, int l, int m)
		{
			return i ^ ((j << 13) | (j >> 19)) ^ ((k << 26) | (k >> 6)) ^ ((l << 7) | (l >> 25)) ^ ((m << 20) | (m >> 12));
		}

		private string toResponseStringVersion0()
		{
			StringBuilder stringBuilder = new StringBuilder(64);
			stringBuilder.AppendFormat("{0}={1}", _name, _value);
			if (_expires != DateTime.MinValue)
			{
				stringBuilder.AppendFormat("; Expires={0}", _expires.ToUniversalTime().ToString("ddd, dd'-'MMM'-'yyyy HH':'mm':'ss 'GMT'", CultureInfo.CreateSpecificCulture("en-US")));
			}
			if (!_path.IsNullOrEmpty())
			{
				stringBuilder.AppendFormat("; Path={0}", _path);
			}
			if (!_domain.IsNullOrEmpty())
			{
				stringBuilder.AppendFormat("; Domain={0}", _domain);
			}
			if (_secure)
			{
				stringBuilder.Append("; Secure");
			}
			if (_httpOnly)
			{
				stringBuilder.Append("; HttpOnly");
			}
			return stringBuilder.ToString();
		}

		private string toResponseStringVersion1()
		{
			StringBuilder stringBuilder = new StringBuilder(64);
			stringBuilder.AppendFormat("{0}={1}; Version={2}", _name, _value, _version);
			if (_expires != DateTime.MinValue)
			{
				stringBuilder.AppendFormat("; Max-Age={0}", MaxAge);
			}
			if (!_path.IsNullOrEmpty())
			{
				stringBuilder.AppendFormat("; Path={0}", _path);
			}
			if (!_domain.IsNullOrEmpty())
			{
				stringBuilder.AppendFormat("; Domain={0}", _domain);
			}
			if (!_port.IsNullOrEmpty())
			{
				if (_port == "\"\"")
				{
					stringBuilder.Append("; Port");
				}
				else
				{
					stringBuilder.AppendFormat("; Port={0}", _port);
				}
			}
			if (!_comment.IsNullOrEmpty())
			{
				stringBuilder.AppendFormat("; Comment={0}", _comment.UrlEncode());
			}
			if (_commentUri != null)
			{
				string originalString = _commentUri.OriginalString;
				stringBuilder.AppendFormat("; CommentURL={0}", originalString.IsToken() ? originalString : originalString.Quote());
			}
			if (_discard)
			{
				stringBuilder.Append("; Discard");
			}
			if (_secure)
			{
				stringBuilder.Append("; Secure");
			}
			return stringBuilder.ToString();
		}

		private static bool tryCreatePorts(string value, out int[] result, out string parseError)
		{
			string[] array = value.Trim('"').Split(',');
			int num = array.Length;
			int[] array2 = new int[num];
			for (int i = 0; i < num; i++)
			{
				array2[i] = int.MinValue;
				string text = array[i].Trim();
				if (text.Length != 0 && !int.TryParse(text, out array2[i]))
				{
					result = new int[0];
					parseError = text;
					return false;
				}
			}
			result = array2;
			parseError = string.Empty;
			return true;
		}

		internal string ToRequestString(Uri uri)
		{
			if (_name.Length == 0)
			{
				return string.Empty;
			}
			if (_version == 0)
			{
				return $"{_name}={_value}";
			}
			StringBuilder stringBuilder = new StringBuilder(64);
			stringBuilder.AppendFormat("$Version={0}; {1}={2}", _version, _name, _value);
			if (!_path.IsNullOrEmpty())
			{
				stringBuilder.AppendFormat("; $Path={0}", _path);
			}
			else if (uri != null)
			{
				stringBuilder.AppendFormat("; $Path={0}", uri.GetAbsolutePath());
			}
			else
			{
				stringBuilder.Append("; $Path=/");
			}
			if ((uri == null || uri.Host != _domain) && !_domain.IsNullOrEmpty())
			{
				stringBuilder.AppendFormat("; $Domain={0}", _domain);
			}
			if (!_port.IsNullOrEmpty())
			{
				if (_port == "\"\"")
				{
					stringBuilder.Append("; $Port");
				}
				else
				{
					stringBuilder.AppendFormat("; $Port={0}", _port);
				}
			}
			return stringBuilder.ToString();
		}

		internal string ToResponseString()
		{
			return (_name.Length <= 0) ? string.Empty : ((_version == 0) ? toResponseStringVersion0() : toResponseStringVersion1());
		}

		public override bool Equals(object comparand)
		{
			return comparand is Cookie cookie && _name.Equals(cookie.Name, StringComparison.InvariantCultureIgnoreCase) && _value.Equals(cookie.Value, StringComparison.InvariantCulture) && _path.Equals(cookie.Path, StringComparison.InvariantCulture) && _domain.Equals(cookie.Domain, StringComparison.InvariantCultureIgnoreCase) && _version == cookie.Version;
		}

		public override int GetHashCode()
		{
			return hash(StringComparer.InvariantCultureIgnoreCase.GetHashCode(_name), _value.GetHashCode(), _path.GetHashCode(), StringComparer.InvariantCultureIgnoreCase.GetHashCode(_domain), _version);
		}

		public override string ToString()
		{
			return ToRequestString(null);
		}
	}
	[Serializable]
	public class CookieCollection : ICollection, IEnumerable
	{
		private List<Cookie> _list;

		private object _sync;

		internal IList<Cookie> List => _list;

		internal IEnumerable<Cookie> Sorted
		{
			get
			{
				List<Cookie> list = new List<Cookie>(_list);
				if (list.Count > 1)
				{
					list.Sort(compareCookieWithinSorted);
				}
				return list;
			}
		}

		public int Count => _list.Count;

		public bool IsReadOnly => true;

		public bool IsSynchronized => false;

		public Cookie this[int index]
		{
			get
			{
				if (index < 0 || index >= _list.Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return _list[index];
			}
		}

		public Cookie this[string name]
		{
			get
			{
				if (name == null)
				{
					throw new ArgumentNullException("name");
				}
				foreach (Cookie item in Sorted)
				{
					if (item.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
					{
						return item;
					}
				}
				return null;
			}
		}

		public object SyncRoot => _sync ?? (_sync = ((ICollection)_list).SyncRoot);

		public CookieCollection()
		{
			_list = new List<Cookie>();
		}

		private static int compareCookieWithinSort(Cookie x, Cookie y)
		{
			return x.Name.Length + x.Value.Length - (y.Name.Length + y.Value.Length);
		}

		private static int compareCookieWithinSorted(Cookie x, Cookie y)
		{
			int num = 0;
			return ((num = x.Version - y.Version) != 0) ? num : (((num = x.Name.CompareTo(y.Name)) != 0) ? num : (y.Path.Length - x.Path.Length));
		}

		private static CookieCollection parseRequest(string value)
		{
			CookieCollection cookieCollection = new CookieCollection();
			Cookie cookie = null;
			int num = 0;
			string[] array = splitCookieHeaderValue(value);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				if (text.Length == 0)
				{
					continue;
				}
				if (text.StartsWith("$version", StringComparison.InvariantCultureIgnoreCase))
				{
					num = int.Parse(text.GetValue('=', unquote: true));
					continue;
				}
				if (text.StartsWith("$path", StringComparison.InvariantCultureIgnoreCase))
				{
					if (cookie != null)
					{
						cookie.Path = text.GetValue('=');
					}
					continue;
				}
				if (text.StartsWith("$domain", StringComparison.InvariantCultureIgnoreCase))
				{
					if (cookie != null)
					{
						cookie.Domain = text.GetValue('=');
					}
					continue;
				}
				if (text.StartsWith("$port", StringComparison.InvariantCultureIgnoreCase))
				{
					string port = (text.Equals("$port", StringComparison.InvariantCultureIgnoreCase) ? "\"\"" : text.GetValue('='));
					if (cookie != null)
					{
						cookie.Port = port;
					}
					continue;
				}
				if (cookie != null)
				{
					cookieCollection.Add(cookie);
				}
				string value2 = string.Empty;
				int num2 = text.IndexOf('=');
				string name;
				if (num2 == -1)
				{
					name = text;
				}
				else if (num2 == text.Length - 1)
				{
					name = text.Substring(0, num2).TrimEnd(' ');
				}
				else
				{
					name = text.Substring(0, num2).TrimEnd(' ');
					value2 = text.Substring(num2 + 1).TrimStart(' ');
				}
				cookie = new Cookie(name, value2);
				if (num != 0)
				{
					cookie.Version = num;
				}
			}
			if (cookie != null)
			{
				cookieCollection.Add(cookie);
			}
			return cookieCollection;
		}

		private static CookieCollection parseResponse(string value)
		{
			CookieCollection cookieCollection = new CookieCollection();
			Cookie cookie = null;
			string[] array = splitCookieHeaderValue(value);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				if (text.Length == 0)
				{
					continue;
				}
				if (text.StartsWith("version", StringComparison.InvariantCultureIgnoreCase))
				{
					if (cookie != null)
					{
						cookie.Version = int.Parse(text.GetValue('=', unquote: true));
					}
					continue;
				}
				if (text.StartsWith("expires", StringComparison.InvariantCultureIgnoreCase))
				{
					StringBuilder stringBuilder = new StringBuilder(text.GetValue('='), 32);
					if (i < array.Length - 1)
					{
						stringBuilder.AppendFormat(", {0}", array[++i].Trim());
					}
					if (!DateTime.TryParseExact(stringBuilder.ToString(), new string[2] { "ddd, dd'-'MMM'-'yyyy HH':'mm':'ss 'GMT'", "r" }, CultureInfo.CreateSpecificCulture("en-US"), DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out var result))
					{
						result = DateTime.Now;
					}
					if (cookie != null && cookie.Expires == DateTime.MinValue)
					{
						cookie.Expires = result.ToLocalTime();
					}
					continue;
				}
				if (text.StartsWith("max-age", StringComparison.InvariantCultureIgnoreCase))
				{
					int num = int.Parse(text.GetValue('=', unquote: true));
					DateTime expires = DateTime.Now.AddSeconds(num);
					if (cookie != null)
					{
						cookie.Expires = expires;
					}
					continue;
				}
				if (text.StartsWith("path", StringComparison.InvariantCultureIgnoreCase))
				{
					if (cookie != null)
					{
						cookie.Path = text.GetValue('=');
					}
					continue;
				}
				if (text.StartsWith("domain", StringComparison.InvariantCultureIgnoreCase))
				{
					if (cookie != null)
					{
						cookie.Domain = text.GetValue('=');
					}
					continue;
				}
				if (text.StartsWith("port", StringComparison.InvariantCultureIgnoreCase))
				{
					string port = (text.Equals("port", StringComparison.InvariantCultureIgnoreCase) ? "\"\"" : text.GetValue('='));
					if (cookie != null)
					{
						cookie.Port = port;
					}
					continue;
				}
				if (text.StartsWith("comment", StringComparison.InvariantCultureIgnoreCase))
				{
					if (cookie != null)
					{
						cookie.Comment = text.GetValue('=').UrlDecode();
					}
					continue;
				}
				if (text.StartsWith("commenturl", StringComparison.InvariantCultureIgnoreCase))
				{
					if (cookie != null)
					{
						cookie.CommentUri = text.GetValue('=', unquote: true).ToUri();
					}
					continue;
				}
				if (text.StartsWith("discard", StringComparison.InvariantCultureIgnoreCase))
				{
					if (cookie != null)
					{
						cookie.Discard = true;
					}
					continue;
				}
				if (text.StartsWith("secure", StringComparison.InvariantCultureIgnoreCase))
				{
					if (cookie != null)
					{
						cookie.Secure = true;
					}
					continue;
				}
				if (text.StartsWith("httponly", StringComparison.InvariantCultureIgnoreCase))
				{
					if (cookie != null)
					{
						cookie.HttpOnly = true;
					}
					continue;
				}
				if (cookie != null)
				{
					cookieCollection.Add(cookie);
				}
				string value2 = string.Empty;
				int num2 = text.IndexOf('=');
				string name;
				if (num2 == -1)
				{
					name = text;
				}
				else if (num2 == text.Length - 1)
				{
					name = text.Substring(0, num2).TrimEnd(' ');
				}
				else
				{
					name = text.Substring(0, num2).TrimEnd(' ');
					value2 = text.Substring(num2 + 1).TrimStart(' ');
				}
				cookie = new Cookie(name, value2);
			}
			if (cookie != null)
			{
				cookieCollection.Add(cookie);
			}
			return cookieCollection;
		}

		private int searchCookie(Cookie cookie)
		{
			string name = cookie.Name;
			string path = cookie.Path;
			string domain = cookie.Domain;
			int version = cookie.Version;
			for (int num = _list.Count - 1; num >= 0; num--)
			{
				Cookie cookie2 = _list[num];
				if (cookie2.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase) && cookie2.Path.Equals(path, StringComparison.InvariantCulture) && cookie2.Domain.Equals(domain, StringComparison.InvariantCultureIgnoreCase) && cookie2.Version == version)
				{
					return num;
				}
			}
			return -1;
		}

		private static string[] splitCookieHeaderValue(string value)
		{
			return new List<string>(value.SplitHeaderValue(',', ';')).ToArray();
		}

		internal static CookieCollection Parse(string value, bool response)
		{
			return response ? parseResponse(value) : parseRequest(value);
		}

		internal void SetOrRemove(Cookie cookie)
		{
			int num = searchCookie(cookie);
			if (num == -1)
			{
				if (!cookie.Expired)
				{
					_list.Add(cookie);
				}
			}
			else if (!cookie.Expired)
			{
				_list[num] = cookie;
			}
			else
			{
				_list.RemoveAt(num);
			}
		}

		internal void SetOrRemove(CookieCollection cookies)
		{
			foreach (Cookie cookie in cookies)
			{
				SetOrRemove(cookie);
			}
		}

		internal void Sort()
		{
			if (_list.Count > 1)
			{
				_list.Sort(compareCookieWithinSort);
			}
		}

		public void Add(Cookie cookie)
		{
			if (cookie == null)
			{
				throw new ArgumentNullException("cookie");
			}
			int num = searchCookie(cookie);
			if (num == -1)
			{
				_list.Add(cookie);
			}
			else
			{
				_list[num] = cookie;
			}
		}

		public void Add(CookieCollection cookies)
		{
			if (cookies == null)
			{
				throw new ArgumentNullException("cookies");
			}
			foreach (Cookie cookie in cookies)
			{
				Add(cookie);
			}
		}

		public void CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Less than zero.");
			}
			if (array.Rank > 1)
			{
				throw new ArgumentException("Multidimensional.", "array");
			}
			if (array.Length - index < _list.Count)
			{
				throw new ArgumentException("The number of elements in this collection is greater than the available space of the destination array.");
			}
			if (!array.GetType().GetElementType().IsAssignableFrom(typeof(Cookie)))
			{
				throw new InvalidCastException("The elements in this collection cannot be cast automatically to the type of the destination array.");
			}
			((ICollection)_list).CopyTo(array, index);
		}

		public void CopyTo(Cookie[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Less than zero.");
			}
			if (array.Length - index < _list.Count)
			{
				throw new ArgumentException("The number of elements in this collection is greater than the available space of the destination array.");
			}
			_list.CopyTo(array, index);
		}

		public IEnumerator GetEnumerator()
		{
			return _list.GetEnumerator();
		}
	}
	[Serializable]
	public class CookieException : FormatException, ISerializable
	{
		internal CookieException(string message)
			: base(message)
		{
		}

		internal CookieException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		protected CookieException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base(serializationInfo, streamingContext)
		{
		}

		public CookieException()
		{
		}

		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}

		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter, SerializationFormatter = true)]
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}
	}
	internal sealed class EndPointListener
	{
		private List<HttpListenerPrefix> _all;

		private static readonly string _defaultCertFolderPath;

		private IPEndPoint _endpoint;

		private Dictionary<HttpListenerPrefix, HttpListener> _prefixes;

		private bool _secure;

		private Socket _socket;

		private ServerSslConfiguration _sslConfig;

		private List<HttpListenerPrefix> _unhandled;

		private Dictionary<HttpConnection, HttpConnection> _unregistered;

		private object _unregisteredSync;

		public IPAddress Address => _endpoint.Address;

		public bool IsSecure => _secure;

		public int Port => _endpoint.Port;

		public ServerSslConfiguration SslConfiguration => _sslConfig;

		static EndPointListener()
		{
			_defaultCertFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		}

		internal EndPointListener(IPEndPoint endpoint, bool secure, string certificateFolderPath, ServerSslConfiguration sslConfig, bool reuseAddress)
		{
			if (secure)
			{
				X509Certificate2 certificate = getCertificate(endpoint.Port, certificateFolderPath, sslConfig.ServerCertificate);
				if (certificate == null)
				{
					throw new ArgumentException("No server certificate could be found.");
				}
				_secure = true;
				_sslConfig = new ServerSslConfiguration(certificate, sslConfig.ClientCertificateRequired, sslConfig.EnabledSslProtocols, sslConfig.CheckCertificateRevocation);
				_sslConfig.ClientCertificateValidationCallback = sslConfig.ClientCertificateValidationCallback;
			}
			_endpoint = endpoint;
			_prefixes = new Dictionary<HttpListenerPrefix, HttpListener>();
			_unregistered = new Dictionary<HttpConnection, HttpConnection>();
			_unregisteredSync = ((ICollection)_unregistered).SyncRoot;
			_socket = new Socket(endpoint.Address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			if (reuseAddress)
			{
				_socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, optionValue: true);
			}
			_socket.Bind(endpoint);
			_socket.Listen(500);
			_socket.BeginAccept(onAccept, this);
		}

		private static void addSpecial(List<HttpListenerPrefix> prefixes, HttpListenerPrefix prefix)
		{
			string path = prefix.Path;
			foreach (HttpListenerPrefix prefix2 in prefixes)
			{
				if (prefix2.Path == path)
				{
					throw new HttpListenerException(87, "The prefix is already in use.");
				}
			}
			prefixes.Add(prefix);
		}

		private static RSACryptoServiceProvider createRSAFromFile(string filename)
		{
			byte[] array = null;
			using (FileStream fileStream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
			}
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.ImportCspBlob(array);
			return rSACryptoServiceProvider;
		}

		private static X509Certificate2 getCertificate(int port, string folderPath, X509Certificate2 defaultCertificate)
		{
			if (folderPath == null || folderPath.Length == 0)
			{
				folderPath = _defaultCertFolderPath;
			}
			try
			{
				string text = Path.Combine(folderPath, $"{port}.cer");
				string text2 = Path.Combine(folderPath, $"{port}.key");
				if (File.Exists(text) && File.Exists(text2))
				{
					X509Certificate2 x509Certificate = new X509Certificate2(text);
					x509Certificate.PrivateKey = createRSAFromFile(text2);
					return x509Certificate;
				}
			}
			catch
			{
			}
			return defaultCertificate;
		}

		private void leaveIfNoPrefix()
		{
			if (_prefixes.Count > 0)
			{
				return;
			}
			List<HttpListenerPrefix> unhandled = _unhandled;
			if (unhandled == null || unhandled.Count <= 0)
			{
				unhandled = _all;
				if (unhandled == null || unhandled.Count <= 0)
				{
					EndPointManager.RemoveEndPoint(_endpoint);
				}
			}
		}

		private static void onAccept(IAsyncResult asyncResult)
		{
			EndPointListener endPointListener = (EndPointListener)asyncResult.AsyncState;
			Socket socket = null;
			try
			{
				socket = endPointListener._socket.EndAccept(asyncResult);
			}
			catch (SocketException)
			{
			}
			catch (ObjectDisposedException)
			{
				return;
			}
			try
			{
				endPointListener._socket.BeginAccept(onAccept, endPointListener);
			}
			catch
			{
				socket?.Close();
				return;
			}
			if (socket != null)
			{
				processAccepted(socket, endPointListener);
			}
		}

		private static void processAccepted(Socket socket, EndPointListener listener)
		{
			HttpConnection httpConnection = null;
			try
			{
				httpConnection = new HttpConnection(socket, listener);
				lock (listener._unregisteredSync)
				{
					listener._unregistered[httpConnection] = httpConnection;
				}
				httpConnection.BeginReadRequest();
			}
			catch
			{
				if (httpConnection != null)
				{
					httpConnection.Close(force: true);
				}
				else
				{
					socket.Close();
				}
			}
		}

		private static bool removeSpecial(List<HttpListenerPrefix> prefixes, HttpListenerPrefix prefix)
		{
			string path = prefix.Path;
			int count = prefixes.Count;
			for (int i = 0; i < count; i++)
			{
				if (prefixes[i].Path == path)
				{
					prefixes.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		private static HttpListener searchHttpListenerFromSpecial(string path, List<HttpListenerPrefix> prefixes)
		{
			if (prefixes == null)
			{
				return null;
			}
			HttpListener result = null;
			int num = -1;
			foreach (HttpListenerPrefix prefix in prefixes)
			{
				string path2 = prefix.Path;
				int length = path2.Length;
				if (length >= num && path.StartsWith(path2))
				{
					num = length;
					result = prefix.Listener;
				}
			}
			return result;
		}

		internal static bool CertificateExists(int port, string folderPath)
		{
			if (folderPath == null || folderPath.Length == 0)
			{
				folderPath = _defaultCertFolderPath;
			}
			string path = Path.Combine(folderPath, $"{port}.cer");
			string path2 = Path.Combine(folderPath, $"{port}.key");
			return File.Exists(path) && File.Exists(path2);
		}

		internal void RemoveConnection(HttpConnection connection)
		{
			lock (_unregisteredSync)
			{
				_unregistered.Remove(connection);
			}
		}

		internal bool TrySearchHttpListener(Uri uri, out HttpListener listener)
		{
			listener = null;
			if (uri == null)
			{
				return false;
			}
			string host = uri.Host;
			bool flag = Uri.CheckHostName(host) == UriHostNameType.Dns;
			string text = uri.Port.ToString();
			string text2 = HttpUtility.UrlDecode(uri.AbsolutePath);
			string text3 = ((text2[text2.Length - 1] != '/') ? (text2 + "/") : text2);
			if (host != null && host.Length > 0)
			{
				int num = -1;
				foreach (HttpListenerPrefix key in _prefixes.Keys)
				{
					if (flag)
					{
						string host2 = key.Host;
						if (Uri.CheckHostName(host2) == UriHostNameType.Dns && host2 != host)
						{
							continue;
						}
					}
					if (!(key.Port != text))
					{
						string path = key.Path;
						int length = path.Length;
						if (length >= num && (text2.StartsWith(path) || text3.StartsWith(path)))
						{
							num = length;
							listener = _prefixes[key];
						}
					}
				}
				if (num != -1)
				{
					return true;
				}
			}
			List<HttpListenerPrefix> unhandled = _unhandled;
			listener = searchHttpListenerFromSpecial(text2, unhandled);
			if (listener == null && text3 != text2)
			{
				listener = searchHttpListenerFromSpecial(text3, unhandled);
			}
			if (listener != null)
			{
				return true;
			}
			unhandled = _all;
			listener = searchHttpListenerFromSpecial(text2, unhandled);
			if (listener == null && text3 != text2)
			{
				listener = searchHttpListenerFromSpecial(text3, unhandled);
			}
			return listener != null;
		}

		public void AddPrefix(HttpListenerPrefix prefix, HttpListener listener)
		{
			if (prefix.Host == "*")
			{
				List<HttpListenerPrefix> unhandled;
				List<HttpListenerPrefix> list;
				do
				{
					unhandled = _unhandled;
					list = ((unhandled != null) ? new List<HttpListenerPrefix>(unhandled) : new List<HttpListenerPrefix>());
					prefix.Listener = listener;
					addSpecial(list, prefix);
				}
				while (Interlocked.CompareExchange(ref _unhandled, list, unhandled) != unhandled);
				return;
			}
			if (prefix.Host == "+")
			{
				List<HttpListenerPrefix> unhandled;
				List<HttpListenerPrefix> list;
				do
				{
					unhandled = _all;
					list = ((unhandled != null) ? new List<HttpListenerPrefix>(unhandled) : new List<HttpListenerPrefix>());
					prefix.Listener = listener;
					addSpecial(list, prefix);
				}
				while (Interlocked.CompareExchange(ref _all, list, unhandled) != unhandled);
				return;
			}
			Dictionary<HttpListenerPrefix, HttpListener> prefixes;
			Dictionary<HttpListenerPrefix, HttpListener> dictionary;
			do
			{
				prefixes = _prefixes;
				if (prefixes.ContainsKey(prefix))
				{
					if (prefixes[prefix] != listener)
					{
						throw new HttpListenerException(87, $"There's another listener for {prefix}.");
					}
					break;
				}
				dictionary = new Dictionary<HttpListenerPrefix, HttpListener>(prefixes);
				dictionary[prefix] = listener;
			}
			while (Interlocked.CompareExchange(ref _prefixes, dictionary, prefixes) != prefixes);
		}

		public void Close()
		{
			_socket.Close();
			HttpConnection[] array = null;
			lock (_unregisteredSync)
			{
				if (_unregistered.Count == 0)
				{
					return;
				}
				Dictionary<HttpConnection, HttpConnection>.KeyCollection keys = _unregistered.Keys;
				array = new HttpConnection[keys.Count];
				keys.CopyTo(array, 0);
				_unregistered.Clear();
			}
			for (int num = array.Length - 1; num >= 0; num--)
			{
				array[num].Close(force: true);
			}
		}

		public void RemovePrefix(HttpListenerPrefix prefix, HttpListener listener)
		{
			if (prefix.Host == "*")
			{
				List<HttpListenerPrefix> unhandled;
				List<HttpListenerPrefix> list;
				do
				{
					unhandled = _unhandled;
					if (unhandled == null)
					{
						break;
					}
					list = new List<HttpListenerPrefix>(unhandled);
				}
				while (removeSpecial(list, prefix) && Interlocked.CompareExchange(ref _unhandled, list, unhandled) != unhandled);
				leaveIfNoPrefix();
				return;
			}
			if (prefix.Host == "+")
			{
				List<HttpListenerPrefix> unhandled;
				List<HttpListenerPrefix> list;
				do
				{
					unhandled = _all;
					if (unhandled == null)
					{
						break;
					}
					list = new List<HttpListenerPrefix>(unhandled);
				}
				while (removeSpecial(list, prefix) && Interlocked.CompareExchange(ref _all, list, unhandled) != unhandled);
				leaveIfNoPrefix();
				return;
			}
			Dictionary<HttpListenerPrefix, HttpListener> prefixes;
			Dictionary<HttpListenerPrefix, HttpListener> dictionary;
			do
			{
				prefixes = _prefixes;
				if (!prefixes.ContainsKey(prefix))
				{
					break;
				}
				dictionary = new Dictionary<HttpListenerPrefix, HttpListener>(prefixes);
				dictionary.Remove(prefix);
			}
			while (Interlocked.CompareExchange(ref _prefixes, dictionary, prefixes) != prefixes);
			leaveIfNoPrefix();
		}
	}
	internal sealed class EndPointManager
	{
		private static readonly Dictionary<IPEndPoint, EndPointListener> _endpoints;

		static EndPointManager()
		{
			_endpoints = new Dictionary<IPEndPoint, EndPointListener>();
		}

		private EndPointManager()
		{
		}

		private static void addPrefix(string uriPrefix, HttpListener listener)
		{
			HttpListenerPrefix httpListenerPrefix = new HttpListenerPrefix(uriPrefix);
			IPAddress address = convertToIPAddress(httpListenerPrefix.Host);
			if (!address.IsLocal())
			{
				throw new HttpListenerException(87, "Includes an invalid host.");
			}
			if (!int.TryParse(httpListenerPrefix.Port, out var result))
			{
				throw new HttpListenerException(87, "Includes an invalid port.");
			}
			if (!result.IsPortNumber())
			{
				throw new HttpListenerException(87, "Includes an invalid port.");
			}
			string path = httpListenerPrefix.Path;
			if (path.IndexOf('%') != -1)
			{
				throw new HttpListenerException(87, "Includes an invalid path.");
			}
			if (path.IndexOf("//", StringComparison.Ordinal) != -1)
			{
				throw new HttpListenerException(87, "Includes an invalid path.");
			}
			IPEndPoint iPEndPoint = new IPEndPoint(address, result);
			if (_endpoints.TryGetValue(iPEndPoint, out var value))
			{
				if (value.IsSecure ^ httpListenerPrefix.IsSecure)
				{
					throw new HttpListenerException(87, "Includes an invalid scheme.");
				}
			}
			else
			{
				value = new EndPointListener(iPEndPoint, httpListenerPrefix.IsSecure, listener.CertificateFolderPath, listener.SslConfiguration, listener.ReuseAddress);
				_endpoints.Add(iPEndPoint, value);
			}
			value.AddPrefix(httpListenerPrefix, listener);
		}

		private static IPAddress convertToIPAddress(string hostname)
		{
			return (hostname == "*" || hostname == "+") ? IPAddress.Any : hostname.ToIPAddress();
		}

		private static void removePrefix(string uriPrefix, HttpListener listener)
		{
			HttpListenerPrefix httpListenerPrefix = new HttpListenerPrefix(uriPrefix);
			IPAddress address = convertToIPAddress(httpListenerPrefix.Host);
			if (!address.IsLocal() || !int.TryParse(httpListenerPrefix.Port, out var result) || !result.IsPortNumber())
			{
				return;
			}
			string path = httpListenerPrefix.Path;
			if (path.IndexOf('%') == -1 && path.IndexOf("//", StringComparison.Ordinal) == -1)
			{
				IPEndPoint key = new IPEndPoint(address, result);
				if (_endpoints.TryGetValue(key, out var value) && !(value.IsSecure ^ httpListenerPrefix.IsSecure))
				{
					value.RemovePrefix(httpListenerPrefix, listener);
				}
			}
		}

		internal static bool RemoveEndPoint(IPEndPoint endpoint)
		{
			lock (((ICollection)_endpoints).SyncRoot)
			{
				if (!_endpoints.TryGetValue(endpoint, out var value))
				{
					return false;
				}
				_endpoints.Remove(endpoint);
				value.Close();
				return true;
			}
		}

		public static void AddListener(HttpListener listener)
		{
			List<string> list = new List<string>();
			lock (((ICollection)_endpoints).SyncRoot)
			{
				try
				{
					foreach (string prefix in listener.Prefixes)
					{
						addPrefix(prefix, listener);
						list.Add(prefix);
					}
				}
				catch
				{
					foreach (string item in list)
					{
						removePrefix(item, listener);
					}
					throw;
				}
			}
		}

		public static void AddPrefix(string uriPrefix, HttpListener listener)
		{
			lock (((ICollection)_endpoints).SyncRoot)
			{
				addPrefix(uriPrefix, listener);
			}
		}

		public static void RemoveListener(HttpListener listener)
		{
			lock (((ICollection)_endpoints).SyncRoot)
			{
				foreach (string prefix in listener.Prefixes)
				{
					removePrefix(prefix, listener);
				}
			}
		}

		public static void RemovePrefix(string uriPrefix, HttpListener listener)
		{
			lock (((ICollection)_endpoints).SyncRoot)
			{
				removePrefix(uriPrefix, listener);
			}
		}
	}
	internal sealed class HttpConnection
	{
		private byte[] _buffer;

		private const int _bufferLength = 8192;

		private HttpListenerContext _context;

		private bool _contextRegistered;

		private StringBuilder _currentLine;

		private InputState _inputState;

		private RequestStream _inputStream;

		private HttpListener _lastListener;

		private LineState _lineState;

		private EndPointListener _listener;

		private ResponseStream _outputStream;

		private int _position;

		private MemoryStream _requestBuffer;

		private int _reuses;

		private bool _secure;

		private Socket _socket;

		private Stream _stream;

		private object _sync;

		private int _timeout;

		private Dictionary<int, bool> _timeoutCanceled;

		private System.Threading.Timer _timer;

		public bool IsClosed => _socket == null;

		public bool IsSecure => _secure;

		public IPEndPoint LocalEndPoint => (IPEndPoint)_socket.LocalEndPoint;

		public IPEndPoint RemoteEndPoint => (IPEndPoint)_socket.RemoteEndPoint;

		public int Reuses => _reuses;

		public Stream Stream => _stream;

		internal HttpConnection(Socket socket, EndPointListener listener)
		{
			_socket = socket;
			_listener = listener;
			_secure = listener.IsSecure;
			NetworkStream networkStream = new NetworkStream(socket, owns_socket: false);
			if (_secure)
			{
				ServerSslConfiguration sslConfiguration = listener.SslConfiguration;
				SslStream sslStream = new SslStream(networkStream, leaveStreamOpen: false, sslConfiguration.ClientCertificateValidationCallback);
				sslStream.AuthenticateAsServer(sslConfiguration.ServerCertificate, sslConfiguration.ClientCertificateRequired, sslConfiguration.EnabledSslProtocols, sslConfiguration.CheckCertificateRevocation);
				_stream = sslStream;
			}
			else
			{
				_stream = networkStream;
			}
			_sync = new object();
			_timeout = 90000;
			_timeoutCanceled = new Dictionary<int, bool>();
			_timer = new System.Threading.Timer(onTimeout, this, -1, -1);
			init();
		}

		private void close()
		{
			lock (_sync)
			{
				if (_socket == null)
				{
					return;
				}
				disposeTimer();
				disposeRequestBuffer();
				disposeStream();
				closeSocket();
			}
			unregisterContext();
			removeConnection();
		}

		private void closeSocket()
		{
			try
			{
				_socket.Shutdown(SocketShutdown.Both);
			}
			catch
			{
			}
			_socket.Close();
			_socket = null;
		}

		private void disposeRequestBuffer()
		{
			if (_requestBuffer != null)
			{
				_requestBuffer.Dispose();
				_requestBuffer = null;
			}
		}

		private void disposeStream()
		{
			if (_stream != null)
			{
				_inputStream = null;
				_outputStream = null;
				_stream.Dispose();
				_stream = null;
			}
		}

		private void disposeTimer()
		{
			if (_timer != null)
			{
				try
				{
					_timer.Change(-1, -1);
				}
				catch
				{
				}
				_timer.Dispose();
				_timer = null;
			}
		}

		private void init()
		{
			_context = new HttpListenerContext(this);
			_inputState = InputState.RequestLine;
			_inputStream = null;
			_lineState = LineState.None;
			_outputStream = null;
			_position = 0;
			_requestBuffer = new MemoryStream();
		}

		private static void onRead(IAsyncResult asyncResult)
		{
			HttpConnection httpConnection = (HttpConnection)asyncResult.AsyncState;
			if (httpConnection._socket == null)
			{
				return;
			}
			lock (httpConnection._sync)
			{
				if (httpConnection._socket == null)
				{
					return;
				}
				int num = -1;
				int num2 = 0;
				try
				{
					int reuses = httpConnection._reuses;
					if (!httpConnection._timeoutCanceled[reuses])
					{
						httpConnection._timer.Change(-1, -1);
						httpConnection._timeoutCanceled[reuses] = true;
					}
					num = httpConnection._stream.EndRead(asyncResult);
					httpConnection._requestBuffer.Write(httpConnection._buffer, 0, num);
					num2 = (int)httpConnection._requestBuffer.Length;
				}
				catch (Exception ex)
				{
					if (httpConnection._requestBuffer != null && httpConnection._requestBuffer.Length > 0)
					{
						httpConnection.SendError(ex.Message, 400);
					}
					else
					{
						httpConnection.close();
					}
					return;
				}
				if (num <= 0)
				{
					httpConnection.close();
				}
				else if (httpConnection.processInput(httpConnection._requestBuffer.GetBuffer(), num2))
				{
					if (!httpConnection._context.HasError)
					{
						httpConnection._context.Request.FinishInitialization();
					}
					if (httpConnection._context.HasError)
					{
						httpConnection.SendError();
						return;
					}
					if (!httpConnection._listener.TrySearchHttpListener(httpConnection._context.Request.Url, out var listener))
					{
						httpConnection.SendError(null, 404);
						return;
					}
					if (httpConnection._lastListener != listener)
					{
						httpConnection.removeConnection();
						if (!listener.AddConnection(httpConnection))
						{
							httpConnection.close();
							return;
						}
						httpConnection._lastListener = listener;
					}
					httpConnection._context.Listener = listener;
					if (httpConnection._context.Authenticate() && httpConnection._context.Register())
					{
						httpConnection._contextRegistered = true;
					}
				}
				else
				{
					httpConnection._stream.BeginRead(httpConnection._buffer, 0, 8192, onRead, httpConnection);
				}
			}
		}

		private static void onTimeout(object state)
		{
			HttpConnection httpConnection = (HttpConnection)state;
			int reuses = httpConnection._reuses;
			if (httpConnection._socket == null)
			{
				return;
			}
			lock (httpConnection._sync)
			{
				if (httpConnection._socket != null && !httpConnection._timeoutCanceled[reuses])
				{
					httpConnection.SendError(null, 408);
				}
			}
		}

		private bool processInput(byte[] data, int length)
		{
			if (_currentLine == null)
			{
				_currentLine = new StringBuilder(64);
			}
			int read = 0;
			try
			{
				string text;
				while ((text = readLineFrom(data, _position, length, out read)) != null)
				{
					_position += read;
					if (text.Length == 0)
					{
						if (_inputState != InputState.RequestLine)
						{
							if (_position > 32768)
							{
								_context.ErrorMessage = "Headers too long";
							}
							_currentLine = null;
							return true;
						}
					}
					else
					{
						if (_inputState == InputState.RequestLine)
						{
							_context.Request.SetRequestLine(text);
							_inputState = InputState.Headers;
						}
						else
						{
							_context.Request.AddHeader(text);
						}
						if (_context.HasError)
						{
							return true;
						}
					}
				}
			}
			catch (Exception ex)
			{
				_context.ErrorMessage = ex.Message;
				return true;
			}
			_position += read;
			if (_position >= 32768)
			{
				_context.ErrorMessage = "Headers too long";
				return true;
			}
			return false;
		}

		private string readLineFrom(byte[] buffer, int offset, int length, out int read)
		{
			read = 0;
			for (int i = offset; i < length; i++)
			{
				if (_lineState == LineState.Lf)
				{
					break;
				}
				read++;
				byte b = buffer[i];
				switch (b)
				{
				case 13:
					_lineState = LineState.Cr;
					break;
				case 10:
					_lineState = LineState.Lf;
					break;
				default:
					_currentLine.Append((char)b);
					break;
				}
			}
			if (_lineState != LineState.Lf)
			{
				return null;
			}
			string result = _currentLine.ToString();
			_currentLine.Length = 0;
			_lineState = LineState.None;
			return result;
		}

		private void removeConnection()
		{
			if (_lastListener != null)
			{
				_lastListener.RemoveConnection(this);
			}
			else
			{
				_listener.RemoveConnection(this);
			}
		}

		private void unregisterContext()
		{
			if (_contextRegistered)
			{
				_context.Unregister();
				_contextRegistered = false;
			}
		}

		internal void Close(bool force)
		{
			if (_socket == null)
			{
				return;
			}
			lock (_sync)
			{
				if (_socket == null)
				{
					return;
				}
				if (!force)
				{
					GetResponseStream().Close(force: false);
					if (!_context.Response.CloseConnection && _context.Request.FlushInput())
					{
						_reuses++;
						disposeRequestBuffer();
						unregisterContext();
						init();
						BeginReadRequest();
						return;
					}
				}
				else if (_outputStream != null)
				{
					_outputStream.Close(force: true);
				}
				close();
			}
		}

		public void BeginReadRequest()
		{
			if (_buffer == null)
			{
				_buffer = new byte[8192];
			}
			if (_reuses == 1)
			{
				_timeout = 15000;
			}
			try
			{
				_timeoutCanceled.Add(_reuses, value: false);
				_timer.Change(_timeout, -1);
				_stream.BeginRead(_buffer, 0, 8192, onRead, this);
			}
			catch
			{
				close();
			}
		}

		public void Close()
		{
			Close(force: false);
		}

		public RequestStream GetRequestStream(long contentLength, bool chunked)
		{
			if (_inputStream != null || _socket == null)
			{
				return _inputStream;
			}
			lock (_sync)
			{
				if (_socket == null)
				{
					return _inputStream;
				}
				byte[] buffer = _requestBuffer.GetBuffer();
				int num = (int)_requestBuffer.Length;
				disposeRequestBuffer();
				if (chunked)
				{
					_context.Response.SendChunked = true;
					_inputStream = new ChunkedRequestStream(_stream, buffer, _position, num - _position, _context);
				}
				else
				{
					_inputStream = new RequestStream(_stream, buffer, _position, num - _position, contentLength);
				}
				return _inputStream;
			}
		}

		public ResponseStream GetResponseStream()
		{
			if (_outputStream != null || _socket == null)
			{
				return _outputStream;
			}
			lock (_sync)
			{
				if (_socket == null)
				{
					return _outputStream;
				}
				bool ignoreWriteExceptions = _context.Listener?.IgnoreWriteExceptions ?? true;
				_outputStream = new ResponseStream(_stream, _context.Response, ignoreWriteExceptions);
				return _outputStream;
			}
		}

		public void SendError()
		{
			SendError(_context.ErrorMessage, _context.ErrorStatus);
		}

		public void SendError(string message, int status)
		{
			if (_socket == null)
			{
				return;
			}
			lock (_sync)
			{
				if (_socket == null)
				{
					return;
				}
				try
				{
					HttpListenerResponse response = _context.Response;
					response.StatusCode = status;
					response.ContentType = "text/html";
					StringBuilder stringBuilder = new StringBuilder(64);
					stringBuilder.AppendFormat("<html><body><h1>{0} {1}", status, response.StatusDescription);
					if (message != null && message.Length > 0)
					{
						stringBuilder.AppendFormat(" ({0})</h1></body></html>", message);
					}
					else
					{
						stringBuilder.Append("</h1></body></html>");
					}
					Encoding uTF = Encoding.UTF8;
					byte[] bytes = uTF.GetBytes(stringBuilder.ToString());
					response.ContentEncoding = uTF;
					response.ContentLength64 = bytes.LongLength;
					response.Close(bytes, willBlock: true);
				}
				catch
				{
					Close(force: true);
				}
			}
		}
	}
	public sealed class HttpListener : IDisposable
	{
		private AuthenticationSchemes _authSchemes;

		private Func<HttpListenerRequest, AuthenticationSchemes> _authSchemeSelector;

		private string _certFolderPath;

		private Dictionary<HttpConnection, HttpConnection> _connections;

		private object _connectionsSync;

		private List<HttpListenerContext> _ctxQueue;

		private object _ctxQueueSync;

		private Dictionary<HttpListenerContext, HttpListenerContext> _ctxRegistry;

		private object _ctxRegistrySync;

		private static readonly string _defaultRealm;

		private bool _disposed;

		private bool _ignoreWriteExceptions;

		private volatile bool _listening;

		private Logger _logger;

		private HttpListenerPrefixCollection _prefixes;

		private string _realm;

		private bool _reuseAddress;

		private ServerSslConfiguration _sslConfig;

		private Func<IIdentity, NetworkCredential> _userCredFinder;

		private List<HttpListenerAsyncResult> _waitQueue;

		private object _waitQueueSync;

		internal bool IsDisposed => _disposed;

		internal bool ReuseAddress
		{
			get
			{
				return _reuseAddress;
			}
			set
			{
				_reuseAddress = value;
			}
		}

		public AuthenticationSchemes AuthenticationSchemes
		{
			get
			{
				CheckDisposed();
				return _authSchemes;
			}
			set
			{
				CheckDisposed();
				_authSchemes = value;
			}
		}

		public Func<HttpListenerRequest, AuthenticationSchemes> AuthenticationSchemeSelector
		{
			get
			{
				CheckDisposed();
				return _authSchemeSelector;
			}
			set
			{
				CheckDisposed();
				_authSchemeSelector = value;
			}
		}

		public string CertificateFolderPath
		{
			get
			{
				CheckDisposed();
				return _certFolderPath;
			}
			set
			{
				CheckDisposed();
				_certFolderPath = value;
			}
		}

		public bool IgnoreWriteExceptions
		{
			get
			{
				CheckDisposed();
				return _ignoreWriteExceptions;
			}
			set
			{
				CheckDisposed();
				_ignoreWriteExceptions = value;
			}
		}

		public bool IsListening => _listening;

		public static bool IsSupported => true;

		public Logger Log => _logger;

		public HttpListenerPrefixCollection Prefixes
		{
			get
			{
				CheckDisposed();
				return _prefixes;
			}
		}

		public string Realm
		{
			get
			{
				CheckDisposed();
				return _realm;
			}
			set
			{
				CheckDisposed();
				_realm = value;
			}
		}

		public ServerSslConfiguration SslConfiguration
		{
			get
			{
				CheckDisposed();
				return _sslConfig ?? (_sslConfig = new ServerSslConfiguration(null));
			}
			set
			{
				CheckDisposed();
				_sslConfig = value;
			}
		}

		public bool UnsafeConnectionNtlmAuthentication
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		public Func<IIdentity, NetworkCredential> UserCredentialsFinder
		{
			get
			{
				CheckDisposed();
				return _userCredFinder;
			}
			set
			{
				CheckDisposed();
				_userCredFinder = value;
			}
		}

		static HttpListener()
		{
			_defaultRealm = "SECRET AREA";
		}

		public HttpListener()
		{
			_authSchemes = AuthenticationSchemes.Anonymous;
			_connections = new Dictionary<HttpConnection, HttpConnection>();
			_connectionsSync = ((ICollection)_connections).SyncRoot;
			_ctxQueue = new List<HttpListenerContext>();
			_ctxQueueSync = ((ICollection)_ctxQueue).SyncRoot;
			_ctxRegistry = new Dictionary<HttpListenerContext, HttpListenerContext>();
			_ctxRegistrySync = ((ICollection)_ctxRegistry).SyncRoot;
			_logger = new Logger();
			_prefixes = new HttpListenerPrefixCollection(this);
			_waitQueue = new List<HttpListenerAsyncResult>();
			_waitQueueSync = ((ICollection)_waitQueue).SyncRoot;
		}

		private void cleanupConnections()
		{
			HttpConnection[] array = null;
			lock (_connectionsSync)
			{
				if (_connections.Count == 0)
				{
					return;
				}
				Dictionary<HttpConnection, HttpConnection>.KeyCollection keys = _connections.Keys;
				array = new HttpConnection[keys.Count];
				keys.CopyTo(array, 0);
				_connections.Clear();
			}
			for (int num = array.Length - 1; num >= 0; num--)
			{
				array[num].Close(force: true);
			}
		}

		private void cleanupContextQueue(bool sendServiceUnavailable)
		{
			HttpListenerContext[] array = null;
			lock (_ctxQueueSync)
			{
				if (_ctxQueue.Count == 0)
				{
					return;
				}
				array = _ctxQueue.ToArray();
				_ctxQueue.Clear();
			}
			if (sendServiceUnavailable)
			{
				HttpListenerContext[] array2 = array;
				foreach (HttpListenerContext httpListenerContext in array2)
				{
					HttpListenerResponse response = httpListenerContext.Response;
					response.StatusCode = 503;
					response.Close();
				}
			}
		}

		private void cleanupContextRegistry()
		{
			HttpListenerContext[] array = null;
			lock (_ctxRegistrySync)
			{
				if (_ctxRegistry.Count == 0)
				{
					return;
				}
				Dictionary<HttpListenerContext, HttpListenerContext>.KeyCollection keys = _ctxRegistry.Keys;
				array = new HttpListenerContext[keys.Count];
				keys.CopyTo(array, 0);
				_ctxRegistry.Clear();
			}
			for (int num = array.Length - 1; num >= 0; num--)
			{
				array[num].Connection.Close(force: true);
			}
		}

		private void cleanupWaitQueue(Exception exception)
		{
			HttpListenerAsyncResult[] array = null;
			lock (_waitQueueSync)
			{
				if (_waitQueue.Count == 0)
				{
					return;
				}
				array = _waitQueue.ToArray();
				_waitQueue.Clear();
			}
			HttpListenerAsyncResult[] array2 = array;
			foreach (HttpListenerAsyncResult httpListenerAsyncResult in array2)
			{
				httpListenerAsyncResult.Complete(exception);
			}
		}

		private void close(bool force)
		{
			if (_listening)
			{
				_listening = false;
				EndPointManager.RemoveListener(this);
			}
			lock (_ctxRegistrySync)
			{
				cleanupContextQueue(!force);
			}
			cleanupContextRegistry();
			cleanupConnections();
			cleanupWaitQueue(new ObjectDisposedException(GetType().ToString()));
			_disposed = true;
		}

		private HttpListenerAsyncResult getAsyncResultFromQueue()
		{
			if (_waitQueue.Count == 0)
			{
				return null;
			}
			HttpListenerAsyncResult result = _waitQueue[0];
			_waitQueue.RemoveAt(0);
			return result;
		}

		private HttpListenerContext getContextFromQueue()
		{
			if (_ctxQueue.Count == 0)
			{
				return null;
			}
			HttpListenerContext result = _ctxQueue[0];
			_ctxQueue.RemoveAt(0);
			return result;
		}

		internal bool AddConnection(HttpConnection connection)
		{
			if (!_listening)
			{
				return false;
			}
			lock (_connectionsSync)
			{
				if (!_listening)
				{
					return false;
				}
				_connections[connection] = connection;
				return true;
			}
		}

		internal HttpListenerAsyncResult BeginGetContext(HttpListenerAsyncResult asyncResult)
		{
			lock (_ctxRegistrySync)
			{
				if (!_listening)
				{
					throw new HttpListenerException(995);
				}
				HttpListenerContext contextFromQueue = getContextFromQueue();
				if (contextFromQueue == null)
				{
					_waitQueue.Add(asyncResult);
				}
				else
				{
					asyncResult.Complete(contextFromQueue, syncCompleted: true);
				}
				return asyncResult;
			}
		}

		internal void CheckDisposed()
		{
			if (_disposed)
			{
				throw new ObjectDisposedException(GetType().ToString());
			}
		}

		internal string GetRealm()
		{
			string realm = _realm;
			return (realm != null && realm.Length > 0) ? realm : _defaultRealm;
		}

		internal Func<IIdentity, NetworkCredential> GetUserCredentialsFinder()
		{
			return _userCredFinder;
		}

		internal bool RegisterContext(HttpListenerContext context)
		{
			if (!_listening)
			{
				return false;
			}
			lock (_ctxRegistrySync)
			{
				if (!_listening)
				{
					return false;
				}
				_ctxRegistry[context] = context;
				HttpListenerAsyncResult asyncResultFromQueue = getAsyncResultFromQueue();
				if (asyncResultFromQueue == null)
				{
					_ctxQueue.Add(context);
				}
				else
				{
					asyncResultFromQueue.Complete(context);
				}
				return true;
			}
		}

		internal void RemoveConnection(HttpConnection connection)
		{
			lock (_connectionsSync)
			{
				_connections.Remove(connection);
			}
		}

		internal AuthenticationSchemes SelectAuthenticationScheme(HttpListenerRequest request)
		{
			Func<HttpListenerRequest, AuthenticationSchemes> authSchemeSelector = _authSchemeSelector;
			if (authSchemeSelector == null)
			{
				return _authSchemes;
			}
			try
			{
				return authSchemeSelector(request);
			}
			catch
			{
				return AuthenticationSchemes.None;
			}
		}

		internal void UnregisterContext(HttpListenerContext context)
		{
			lock (_ctxRegistrySync)
			{
				_ctxRegistry.Remove(context);
			}
		}

		public void Abort()
		{
			if (!_disposed)
			{
				close(force: true);
			}
		}

		public IAsyncResult BeginGetContext(AsyncCallback callback, object state)
		{
			CheckDisposed();
			if (_prefixes.Count == 0)
			{
				throw new InvalidOperationException("The listener has no URI prefix on which listens.");
			}
			if (!_listening)
			{
				throw new InvalidOperationException("The listener hasn't been started.");
			}
			return BeginGetContext(new HttpListenerAsyncResult(callback, state));
		}

		public void Close()
		{
			if (!_disposed)
			{
				close(force: false);
			}
		}

		public HttpListenerContext EndGetContext(IAsyncResult asyncResult)
		{
			CheckDisposed();
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (!(asyncResult is HttpListenerAsyncResult httpListenerAsyncResult))
			{
				throw new ArgumentException("A wrong IAsyncResult.", "asyncResult");
			}
			if (httpListenerAsyncResult.EndCalled)
			{
				throw new InvalidOperationException("This IAsyncResult cannot be reused.");
			}
			httpListenerAsyncResult.EndCalled = true;
			if (!httpListenerAsyncResult.IsCompleted)
			{
				httpListenerAsyncResult.AsyncWaitHandle.WaitOne();
			}
			return httpListenerAsyncResult.GetContext();
		}

		public HttpListenerContext GetContext()
		{
			CheckDisposed();
			if (_prefixes.Count == 0)
			{
				throw new InvalidOperationException("The listener has no URI prefix on which listens.");
			}
			if (!_listening)
			{
				throw new InvalidOperationException("The listener hasn't been started.");
			}
			HttpListenerAsyncResult httpListenerAsyncResult = BeginGetContext(new HttpListenerAsyncResult(null, null));
			httpListenerAsyncResult.InGet = true;
			return EndGetContext(httpListenerAsyncResult);
		}

		public void Start()
		{
			CheckDisposed();
			if (!_listening)
			{
				EndPointManager.AddListener(this);
				_listening = true;
			}
		}

		public void Stop()
		{
			CheckDisposed();
			if (_listening)
			{
				_listening = false;
				EndPointManager.RemoveListener(this);
				lock (_ctxRegistrySync)
				{
					cleanupContextQueue(sendServiceUnavailable: true);
				}
				cleanupContextRegistry();
				cleanupConnections();
				cleanupWaitQueue(new HttpListenerException(995, "The listener is stopped."));
			}
		}

		void IDisposable.Dispose()
		{
			if (!_disposed)
			{
				close(force: true);
			}
		}
	}
	public sealed class HttpListenerContext
	{
		private HttpConnection _connection;

		private string _error;

		private int _errorStatus;

		private HttpListener _listener;

		private HttpListenerRequest _request;

		private HttpListenerResponse _response;

		private IPrincipal _user;

		private HttpListenerWebSocketContext _websocketContext;

		internal HttpConnection Connection => _connection;

		internal string ErrorMessage
		{
			get
			{
				return _error;
			}
			set
			{
				_error = value;
			}
		}

		internal int ErrorStatus
		{
			get
			{
				return _errorStatus;
			}
			set
			{
				_errorStatus = value;
			}
		}

		internal bool HasError => _error != null;

		internal HttpListener Listener
		{
			get
			{
				return _listener;
			}
			set
			{
				_listener = value;
			}
		}

		public HttpListenerRequest Request => _request;

		public HttpListenerResponse Response => _response;

		public IPrincipal User => _user;

		internal HttpListenerContext(HttpConnection connection)
		{
			_connection = connection;
			_errorStatus = 400;
			_request = new HttpListenerRequest(this);
			_response = new HttpListenerResponse(this);
		}

		internal bool Authenticate()
		{
			AuthenticationSchemes authenticationSchemes = _listener.SelectAuthenticationScheme(_request);
			switch (authenticationSchemes)
			{
			case AuthenticationSchemes.Anonymous:
				return true;
			case AuthenticationSchemes.None:
				_response.Close(HttpStatusCode.Forbidden);
				return false;
			default:
			{
				string realm = _listener.GetRealm();
				IPrincipal principal = HttpUtility.CreateUser(_request.Headers["Authorization"], authenticationSchemes, realm, _request.HttpMethod, _listener.GetUserCredentialsFinder());
				if (principal == null || !principal.Identity.IsAuthenticated)
				{
					_response.CloseWithAuthChallenge(new AuthenticationChallenge(authenticationSchemes, realm).ToString());
					return false;
				}
				_user = principal;
				return true;
			}
			}
		}

		internal bool Register()
		{
			return _listener.RegisterContext(this);
		}

		internal void Unregister()
		{
			_listener.UnregisterContext(this);
		}

		public HttpListenerWebSocketContext AcceptWebSocket(string protocol)
		{
			if (_websocketContext != null)
			{
				throw new InvalidOperationException("The accepting is already in progress.");
			}
			if (protocol != null)
			{
				if (protocol.Length == 0)
				{
					throw new ArgumentException("An empty string.", "protocol");
				}
				if (!protocol.IsToken())
				{
					throw new ArgumentException("Contains an invalid character.", "protocol");
				}
			}
			_websocketContext = new HttpListenerWebSocketContext(this, protocol);
			return _websocketContext;
		}
	}
	[Serializable]
	public class HttpListenerException : Win32Exception
	{
		public override int ErrorCode => base.NativeErrorCode;

		protected HttpListenerException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: base(serializationInfo, streamingContext)
		{
		}

		public HttpListenerException()
		{
		}

		public HttpListenerException(int errorCode)
			: base(errorCode)
		{
		}

		public HttpListenerException(int errorCode, string message)
			: base(errorCode, message)
		{
		}
	}
	public class HttpListenerPrefixCollection : ICollection<string>, IEnumerable<string>, IEnumerable
	{
		private HttpListener _listener;

		private List<string> _prefixes;

		public int Count => _prefixes.Count;

		public bool IsReadOnly => false;

		public bool IsSynchronized => false;

		internal HttpListenerPrefixCollection(HttpListener listener)
		{
			_listener = listener;
			_prefixes = new List<string>();
		}

		public void Add(string uriPrefix)
		{
			_listener.CheckDisposed();
			HttpListenerPrefix.CheckPrefix(uriPrefix);
			if (!_prefixes.Contains(uriPrefix))
			{
				_prefixes.Add(uriPrefix);
				if (_listener.IsListening)
				{
					EndPointManager.AddPrefix(uriPrefix, _listener);
				}
			}
		}

		public void Clear()
		{
			_listener.CheckDisposed();
			_prefixes.Clear();
			if (_listener.IsListening)
			{
				EndPointManager.RemoveListener(_listener);
			}
		}

		public bool Contains(string uriPrefix)
		{
			_listener.CheckDisposed();
			if (uriPrefix == null)
			{
				throw new ArgumentNullException("uriPrefix");
			}
			return _prefixes.Contains(uriPrefix);
		}

		public void CopyTo(Array array, int offset)
		{
			_listener.CheckDisposed();
			((ICollection)_prefixes).CopyTo(array, offset);
		}

		public void CopyTo(string[] array, int offset)
		{
			_listener.CheckDisposed();
			_prefixes.CopyTo(array, offset);
		}

		public IEnumerator<string> GetEnumerator()
		{
			return _prefixes.GetEnumerator();
		}

		public bool Remove(string uriPrefix)
		{
			_listener.CheckDisposed();
			if (uriPrefix == null)
			{
				throw new ArgumentNullException("uriPrefix");
			}
			bool flag = _prefixes.Remove(uriPrefix);
			if (flag && _listener.IsListening)
			{
				EndPointManager.RemovePrefix(uriPrefix, _listener);
			}
			return flag;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _prefixes.GetEnumerator();
		}
	}
	public sealed class HttpListenerRequest
	{
		private static readonly byte[] _100continue;

		private string[] _acceptTypes;

		private bool _chunked;

		private Encoding _contentEncoding;

		private long _contentLength;

		private bool _contentLengthSet;

		private HttpListenerContext _context;

		private CookieCollection _cookies;

		private WebHeaderCollection _headers;

		private Guid _identifier;

		private Stream _inputStream;

		private bool _keepAlive;

		private bool _keepAliveSet;

		private string _method;

		private NameValueCollection _queryString;

		private Uri _referer;

		private string _uri;

		private Uri _url;

		private string[] _userLanguages;

		private Version _version;

		private bool _websocketRequest;

		private bool _websocketRequestSet;

		public string[] AcceptTypes => _acceptTypes;

		public int ClientCertificateError => 0;

		public Encoding ContentEncoding => _contentEncoding ?? (_contentEncoding = Encoding.Default);

		public long ContentLength64 => _contentLength;

		public string ContentType => _headers["Content-Type"];

		public CookieCollection Cookies => _cookies ?? (_cookies = _headers.GetCookies(response: false));

		public bool HasEntityBody => _contentLength > 0 || _chunked;

		public NameValueCollection Headers => _headers;

		public string HttpMethod => _method;

		public Stream InputStream => _inputStream ?? (_inputStream = (HasEntityBody ? _context.Connection.GetRequestStream(_contentLength, _chunked) : Stream.Null));

		public bool IsAuthenticated => _context.User != null;

		public bool IsLocal => RemoteEndPoint.Address.IsLocal();

		public bool IsSecureConnection => _context.Connection.IsSecure;

		public bool IsWebSocketRequest
		{
			get
			{
				if (!_websocketRequestSet)
				{
					_websocketRequest = _method == "GET" && _version > HttpVersion.Version10 && _headers.Contains("Upgrade", "websocket") && _headers.Contains("Connection", "Upgrade");
					_websocketRequestSet = true;
				}
				return _websocketRequest;
			}
		}

		public bool KeepAlive
		{
			get
			{
				if (!_keepAliveSet)
				{
					string text;
					_keepAlive = _version > HttpVersion.Version10 || _headers.Contains("Connection", "keep-alive") || ((text = _headers["Keep-Alive"]) != null && text != "closed");
					_keepAliveSet = true;
				}
				return _keepAlive;
			}
		}

		public IPEndPoint LocalEndPoint => _context.Connection.LocalEndPoint;

		public Version ProtocolVersion => _version;

		public NameValueCollection QueryString => _queryString ?? (_queryString = HttpUtility.InternalParseQueryString(_url.Query, Encoding.UTF8));

		public string RawUrl => _url.PathAndQuery;

		public IPEndPoint RemoteEndPoint => _context.Connection.RemoteEndPoint;

		public Guid RequestTraceIdentifier => _identifier;

		public Uri Url => _url;

		public Uri UrlReferrer => _referer;

		public string UserAgent => _headers["User-Agent"];

		public string UserHostAddress => LocalEndPoint.ToString();

		public string UserHostName => _headers["Host"];

		public string[] UserLanguages => _userLanguages;

		static HttpListenerRequest()
		{
			_100continue = Encoding.ASCII.GetBytes("HTTP/1.1 100 Continue\r\n\r\n");
		}

		internal HttpListenerRequest(HttpListenerContext context)
		{
			_context = context;
			_contentLength = -1L;
			_headers = new WebHeaderCollection();
			_identifier = Guid.NewGuid();
		}

		private static bool tryCreateVersion(string version, out Version result)
		{
			try
			{
				result = new Version(version);
				return true;
			}
			catch
			{
				result = null;
				return false;
			}
		}

		internal void AddHeader(string header)
		{
			int num = header.IndexOf(':');
			if (num == -1)
			{
				_context.ErrorMessage = "Invalid header";
				return;
			}
			string text = header.Substring(0, num).Trim();
			string text2 = header.Substring(num + 1).Trim();
			_headers.InternalSet(text, text2, response: false);
			switch (text.ToLower(CultureInfo.InvariantCulture))
			{
			case "accept":
				_acceptTypes = new List<string>(text2.SplitHeaderValue(',')).ToArray();
				break;
			case "accept-language":
				_userLanguages = text2.Split(',');
				break;
			case "content-length":
			{
				if (long.TryParse(text2, out var result) && result >= 0)
				{
					_contentLength = result;
					_contentLengthSet = true;
				}
				else
				{
					_context.ErrorMessage = "Invalid Content-Length header";
				}
				break;
			}
			case "content-type":
				try
				{
					_contentEncoding = HttpUtility.GetEncoding(text2);
					break;
				}
				catch
				{
					_context.ErrorMessage = "Invalid Content-Type header";
					break;
				}
			case "referer":
				_referer = text2.ToUri();
				break;
			}
		}

		internal void FinishInitialization()
		{
			string text = _headers["Host"];
			bool flag = text == null || text.Length == 0;
			if (_version > HttpVersion.Version10 && flag)
			{
				_context.ErrorMessage = "Invalid Host header";
				return;
			}
			if (flag)
			{
				text = UserHostAddress;
			}
			_url = HttpUtility.CreateRequestUrl(_uri, text, IsWebSocketRequest, IsSecureConnection);
			if (_url == null)
			{
				_context.ErrorMessage = "Invalid request url";
				return;
			}
			string text2 = Headers["Transfer-Encoding"];
			if (_version > HttpVersion.Version10 && text2 != null && text2.Length > 0)
			{
				_chunked = text2.ToLower() == "chunked";
				if (!_chunked)
				{
					_context.ErrorMessage = string.Empty;
					_context.ErrorStatus = 501;
					return;
				}
			}
			if (!_chunked && !_contentLengthSet)
			{
				string text3 = _method.ToLower();
				if (text3 == "post" || text3 == "put")
				{
					_context.ErrorMessage = string.Empty;
					_context.ErrorStatus = 411;
					return;
				}
			}
			string text4 = Headers["Expect"];
			if (text4 != null && text4.Length > 0 && text4.ToLower() == "100-continue")
			{
				ResponseStream responseStream = _context.Connection.GetResponseStream();
				responseStream.InternalWrite(_100continue, 0, _100continue.Length);
			}
		}

		internal bool FlushInput()
		{
			if (!HasEntityBody)
			{
				return true;
			}
			int num = 2048;
			if (_contentLength > 0)
			{
				num = (int)Math.Min(_contentLength, num);
			}
			byte[] buffer = new byte[num];
			while (true)
			{
				try
				{
					IAsyncResult asyncResult = InputStream.BeginRead(buffer, 0, num, null, null);
					if (!asyncResult.IsCompleted && !asyncResult.AsyncWaitHandle.WaitOne(100))
					{
						return false;
					}
					if (InputStream.EndRead(asyncResult) <= 0)
					{
						return true;
					}
				}
				catch
				{
					return false;
				}
			}
		}

		internal void SetRequestLine(string requestLine)
		{
			string[] array = requestLine.Split(new char[1] { ' ' }, 3);
			if (array.Length != 3)
			{
				_context.ErrorMessage = "Invalid request line (parts)";
				return;
			}
			_method = array[0];
			if (!_method.IsToken())
			{
				_context.ErrorMessage = "Invalid request line (method)";
				return;
			}
			_uri = array[1];
			string text = array[2];
			if (text.Length != 8 || !text.StartsWith("HTTP/") || !tryCreateVersion(text.Substring(5), out _version) || _version.Major < 1)
			{
				_context.ErrorMessage = "Invalid request line (version)";
			}
		}

		public IAsyncResult BeginGetClientCertificate(AsyncCallback requestCallback, object state)
		{
			throw new NotImplementedException();
		}

		public X509Certificate2 EndGetClientCertificate(IAsyncResult asyncResult)
		{
			throw new NotImplementedException();
		}

		public X509Certificate2 GetClientCertificate()
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(64);
			stringBuilder.AppendFormat("{0} {1} HTTP/{2}\r\n", _method, _uri, _version);
			stringBuilder.Append(_headers.ToString());
			return stringBuilder.ToString();
		}
	}
	public sealed class HttpListenerResponse : IDisposable
	{
		private bool _closeConnection;

		private Encoding _contentEncoding;

		private long _contentLength;

		private string _contentType;

		private HttpListenerContext _context;

		private CookieCollection _cookies;

		private bool _disposed;

		private WebHeaderCollection _headers;

		private bool _headersSent;

		private bool _keepAlive;

		private string _location;

		private ResponseStream _outputStream;

		private bool _sendChunked;

		private int _statusCode;

		private string _statusDescription;

		private Version _version;

		internal bool CloseConnection
		{
			get
			{
				return _closeConnection;
			}
			set
			{
				_closeConnection = value;
			}
		}

		internal bool HeadersSent
		{
			get
			{
				return _headersSent;
			}
			set
			{
				_headersSent = value;
			}
		}

		public Encoding ContentEncoding
		{
			get
			{
				return _contentEncoding;
			}
			set
			{
				checkDisposed();
				_contentEncoding = value;
			}
		}

		public long ContentLength64
		{
			get
			{
				return _contentLength;
			}
			set
			{
				checkDisposedOrHeadersSent();
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("Less than zero.", "value");
				}
				_contentLength = value;
			}
		}

		public string ContentType
		{
			get
			{
				return _contentType;
			}
			set
			{
				checkDisposed();
				if (value != null && value.Length == 0)
				{
					throw new ArgumentException("An empty string.", "value");
				}
				_contentType = value;
			}
		}

		public CookieCollection Cookies
		{
			get
			{
				return _cookies ?? (_cookies = new CookieCollection());
			}
			set
			{
				_cookies = value;
			}
		}

		public WebHeaderCollection Headers
		{
			get
			{
				return _headers ?? (_headers = new WebHeaderCollection(HttpHeaderType.Response, internallyUsed: false));
			}
			set
			{
				if (value != null && value.State != HttpHeaderType.Response)
				{
					throw new InvalidOperationException("The specified headers aren't valid for a response.");
				}
				_headers = value;
			}
		}

		public bool KeepAlive
		{
			get
			{
				return _keepAlive;
			}
			set
			{
				checkDisposedOrHeadersSent();
				_keepAlive = value;
			}
		}

		public Stream OutputStream
		{
			get
			{
				checkDisposed();
				return _outputStream ?? (_outputStream = _context.Connection.GetResponseStream());
			}
		}

		public Version ProtocolVersion
		{
			get
			{
				return _version;
			}
			set
			{
				checkDisposedOrHeadersSent();
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (value.Major != 1 || (value.Minor != 0 && value.Minor != 1))
				{
					throw new ArgumentException("Not 1.0 or 1.1.", "value");
				}
				_version = value;
			}
		}

		public string RedirectLocation
		{
			get
			{
				return _location;
			}
			set
			{
				checkDisposed();
				if (value == null)
				{
					_location = null;
					return;
				}
				Uri result = null;
				if (!value.MaybeUri() || !Uri.TryCreate(value, UriKind.Absolute, out result))
				{
					throw new ArgumentException("Not an absolute URL.", "value");
				}
				_location = value;
			}
		}

		public bool SendChunked
		{
			get
			{
				return _sendChunked;
			}
			set
			{
				checkDisposedOrHeadersSent();
				_sendChunked = value;
			}
		}

		public int StatusCode
		{
			get
			{
				return _statusCode;
			}
			set
			{
				checkDisposedOrHeadersSent();
				if (value < 100 || value > 999)
				{
					throw new ProtocolViolationException("A value isn't between 100 and 999 inclusive.");
				}
				_statusCode = value;
				_statusDescription = value.GetStatusDescription();
			}
		}

		public string StatusDescription
		{
			get
			{
				return _statusDescription;
			}
			set
			{
				checkDisposedOrHeadersSent();
				if (value == null || value.Length == 0)
				{
					_statusDescription = _statusCode.GetStatusDescription();
					return;
				}
				if (!value.IsText() || value.IndexOfAny(new char[2] { '\r', '\n' }) > -1)
				{
					throw new ArgumentException("Contains invalid characters.", "value");
				}
				_statusDescription = value;
			}
		}

		internal HttpListenerResponse(HttpListenerContext context)
		{
			_context = context;
			_keepAlive = true;
			_statusCode = 200;
			_statusDescription = "OK";
			_version = HttpVersion.Version11;
		}

		private bool canAddOrUpdate(Cookie cookie)
		{
			if (_cookies == null || _cookies.Count == 0)
			{
				return true;
			}
			List<Cookie> list = findCookie(cookie).ToList();
			if (list.Count == 0)
			{
				return true;
			}
			int version = cookie.Version;
			foreach (Cookie item in list)
			{
				if (item.Version == version)
				{
					return true;
				}
			}
			return false;
		}

		private void checkDisposed()
		{
			if (_disposed)
			{
				throw new ObjectDisposedException(GetType().ToString());
			}
		}

		private void checkDisposedOrHeadersSent()
		{
			if (_disposed)
			{
				throw new ObjectDisposedException(GetType().ToString());
			}
			if (_headersSent)
			{
				throw new InvalidOperationException("Cannot be changed after the headers are sent.");
			}
		}

		private void close(bool force)
		{
			_disposed = true;
			_context.Connection.Close(force);
		}

		private IEnumerable<Cookie> findCookie(Cookie cookie)
		{
			string name = cookie.Name;
			string domain = cookie.Domain;
			string path = cookie.Path;
			if (_cookies == null)
			{
				yield break;
			}
			foreach (Cookie c in _cookies)
			{
				if (c.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && c.Domain.Equals(domain, StringComparison.OrdinalIgnoreCase) && c.Path.Equals(path, StringComparison.Ordinal))
				{
					yield return c;
				}
			}
		}

		internal WebHeaderCollection WriteHeadersTo(MemoryStream destination)
		{
			WebHeaderCollection webHeaderCollection = new WebHeaderCollection(HttpHeaderType.Response, internallyUsed: true);
			if (_headers != null)
			{
				webHeaderCollection.Add(_headers);
			}
			if (_contentType != null)
			{
				string value = ((_contentType.IndexOf("charset=", StringComparison.Ordinal) == -1 && _contentEncoding != null) ? $"{_contentType}; charset={_contentEncoding.WebName}" : _contentType);
				webHeaderCollection.InternalSet("Content-Type", value, response: true);
			}
			if (webHeaderCollection["Server"] == null)
			{
				webHeaderCollection.InternalSet("Server", "websocket-sharp/1.0", response: true);
			}
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			if (webHeaderCollection["Date"] == null)
			{
				webHeaderCollection.InternalSet("Date", DateTime.UtcNow.ToString("r", invariantCulture), response: true);
			}
			if (!_sendChunked)
			{
				webHeaderCollection.InternalSet("Content-Length", _contentLength.ToString(invariantCulture), response: true);
			}
			else
			{
				webHeaderCollection.InternalSet("Transfer-Encoding", "chunked", response: true);
			}
			bool flag = !_context.Request.KeepAlive || !_keepAlive || _statusCode == 400 || _statusCode == 408 || _statusCode == 411 || _statusCode == 413 || _statusCode == 414 || _statusCode == 500 || _statusCode == 503;
			int reuses = _context.Connection.Reuses;
			if (flag || reuses >= 100)
			{
				webHeaderCollection.InternalSet("Connection", "close", response: true);
			}
			else
			{
				webHeaderCollection.InternalSet("Keep-Alive", $"timeout=15,max={100 - reuses}", response: true);
				if (_context.Request.ProtocolVersion < HttpVersion.Version11)
				{
					webHeaderCollection.InternalSet("Connection", "keep-alive", response: true);
				}
			}
			if (_location != null)
			{
				webHeaderCollection.InternalSet("Location", _location, response: true);
			}
			if (_cookies != null)
			{
				foreach (Cookie cookie in _cookies)
				{
					webHeaderCollection.InternalSet("Set-Cookie", cookie.ToResponseString(), response: true);
				}
			}
			Encoding encoding = _contentEncoding ?? Encoding.Default;
			StreamWriter streamWriter = new StreamWriter(destination, encoding, 256);
			streamWriter.Write("HTTP/{0} {1} {2}\r\n", _version, _statusCode, _statusDescription);
			streamWriter.Write(webHeaderCollection.ToStringMultiValue(response: true));
			streamWriter.Flush();
			destination.Position = encoding.GetPreamble().Length;
			return webHeaderCollection;
		}

		public void Abort()
		{
			if (!_disposed)
			{
				close(force: true);
			}
		}

		public void AddHeader(string name, string value)
		{
			Headers.Set(name, value);
		}

		public void AppendCookie(Cookie cookie)
		{
			Cookies.Add(cookie);
		}

		public void AppendHeader(string name, string value)
		{
			Headers.Add(name, value);
		}

		public void Close()
		{
			if (!_disposed)
			{
				close(force: false);
			}
		}

		public void Close(byte[] responseEntity, bool willBlock)
		{
			checkDisposed();
			if (responseEntity == null)
			{
				throw new ArgumentNullException("responseEntity");
			}
			int count = responseEntity.Length;
			Stream output = OutputStream;
			if (willBlock)
			{
				output.Write(responseEntity, 0, count);
				close(force: false);
				return;
			}
			output.BeginWrite(responseEntity, 0, count, delegate(IAsyncResult ar)
			{
				output.EndWrite(ar);
				close(force: false);
			}, null);
		}

		public void CopyFrom(HttpListenerResponse templateResponse)
		{
			if (templateResponse == null)
			{
				throw new ArgumentNullException("templateResponse");
			}
			if (templateResponse._headers != null)
			{
				if (_headers != null)
				{
					_headers.Clear();
				}
				Headers.Add(templateResponse._headers);
			}
			else if (_headers != null)
			{
				_headers = null;
			}
			_contentLength = templateResponse._contentLength;
			_statusCode = templateResponse._statusCode;
			_statusDescription = templateResponse._statusDescription;
			_keepAlive = templateResponse._keepAlive;
			_version = templateResponse._version;
		}

		public void Redirect(string url)
		{
			checkDisposedOrHeadersSent();
			if (url == null)
			{
				throw new ArgumentNullException("url");
			}
			Uri result = null;
			if (!url.MaybeUri() || !Uri.TryCreate(url, UriKind.Absolute, out result))
			{
				throw new ArgumentException("Not an absolute URL.", "url");
			}
			_location = url;
			_statusCode = 302;
			_statusDescription = "Found";
		}

		public void SetCookie(Cookie cookie)
		{
			if (cookie == null)
			{
				throw new ArgumentNullException("cookie");
			}
			if (!canAddOrUpdate(cookie))
			{
				throw new ArgumentException("Cannot be replaced.", "cookie");
			}
			Cookies.Add(cookie);
		}

		void IDisposable.Dispose()
		{
			if (!_disposed)
			{
				close(force: true);
			}
		}
	}
	internal class HttpStreamAsyncResult : IAsyncResult
	{
		private byte[] _buffer;

		private AsyncCallback _callback;

		private bool _completed;

		private int _count;

		private Exception _exception;

		private int _offset;

		private object _state;

		private object _sync;

		private int _syncRead;

		private ManualResetEvent _waitHandle;

		internal byte[] Buffer
		{
			get
			{
				return _buffer;
			}
			set
			{
				_buffer = value;
			}
		}

		internal int Count
		{
			get
			{
				return _count;
			}
			set
			{
				_count = value;
			}
		}

		internal Exception Exception => _exception;

		internal bool HasException => _exception != null;

		internal int Offset
		{
			get
			{
				return _offset;
			}
			set
			{
				_offset = value;
			}
		}

		internal int SyncRead
		{
			get
			{
				return _syncRead;
			}
			set
			{
				_syncRead = value;
			}
		}

		public object AsyncState => _state;

		public WaitHandle AsyncWaitHandle
		{
			get
			{
				lock (_sync)
				{
					return _waitHandle ?? (_waitHandle = new ManualResetEvent(_completed));
				}
			}
		}

		public bool CompletedSynchronously => _syncRead == _count;

		public bool IsCompleted
		{
			get
			{
				lock (_sync)
				{
					return _completed;
				}
			}
		}

		internal HttpStreamAsyncResult(AsyncCallback callback, object state)
		{
			_callback = callback;
			_state = state;
			_sync = new object();
		}

		internal void Complete()
		{
			lock (_sync)
			{
				if (_completed)
				{
					return;
				}
				_completed = true;
				if (_waitHandle != null)
				{
					_waitHandle.Set();
				}
				if (_callback != null)
				{
					_callback.BeginInvoke(this, delegate(IAsyncResult ar)
					{
						_callback.EndInvoke(ar);
					}, null);
				}
			}
		}

		internal void Complete(Exception exception)
		{
			_exception = exception;
			Complete();
		}
	}
	internal sealed class HttpUtility
	{
		private static Dictionary<string, char> _entities;

		private static char[] _hexChars = "0123456789abcdef".ToCharArray();

		private static object _sync = new object();

		private static int getChar(byte[] bytes, int offset, int length)
		{
			int num = 0;
			int num2 = length + offset;
			for (int i = offset; i < num2; i++)
			{
				int num3 = getInt(bytes[i]);
				if (num3 == -1)
				{
					return -1;
				}
				num = (num << 4) + num3;
			}
			return num;
		}

		private static int getChar(string s, int offset, int length)
		{
			int num = 0;
			int num2 = length + offset;
			for (int i = offset; i < num2; i++)
			{
				char c = s[i];
				if (c > '\u007f')
				{
					return -1;
				}
				int num3 = getInt((byte)c);
				if (num3 == -1)
				{
					return -1;
				}
				num = (num << 4) + num3;
			}
			return num;
		}

		private static char[] getChars(MemoryStream buffer, Encoding encoding)
		{
			return encoding.GetChars(buffer.GetBuffer(), 0, (int)buffer.Length);
		}

		private static Dictionary<string, char> getEntities()
		{
			lock (_sync)
			{
				if (_entities == null)
				{
					initEntities();
				}
				return _entities;
			}
		}

		private static int getInt(byte b)
		{
			char c = (char)b;
			return (c >= '0' && c <= '9') ? (c - 48) : ((c >= 'a' && c <= 'f') ? (c - 97 + 10) : ((c >= 'A' && c <= 'F') ? (c - 65 + 10) : (-1)));
		}

		private static void initEntities()
		{
			_entities = new Dictionary<string, char>();
			_entities.Add("nbsp", '\u00a0');
			_entities.Add("iexcl", '¡');
			_entities.Add("cent", '¢');
			_entities.Add("pound", '£');
			_entities.Add("curren", '¤');
			_entities.Add("yen", '¥');
			_entities.Add("brvbar", '¦');
			_entities.Add("sect", '§');
			_entities.Add("uml", '\u00a8');
			_entities.Add("copy", '©');
			_entities.Add("ordf", 'ª');
			_entities.Add("laquo", '«');
			_entities.Add("not", '¬');
			_entities.Add("shy", '\u00ad');
			_entities.Add("reg", '®');
			_entities.Add("macr", '\u00af');
			_entities.Add("deg", '°');
			_entities.Add("plusmn", '±');
			_entities.Add("sup2", '²');
			_entities.Add("sup3", '³');
			_entities.Add("acute", '\u00b4');
			_entities.Add("micro", 'µ');
			_entities.Add("para", '¶');
			_entities.Add("middot", '·');
			_entities.Add("cedil", '\u00b8');
			_entities.Add("sup1", '¹');
			_entities.Add("ordm", 'º');
			_entities.Add("raquo", '»');
			_entities.Add("frac14", '¼');
			_entities.Add("frac12", '½');
			_entities.Add("frac34", '¾');
			_entities.Add("iquest", '¿');
			_entities.Add("Agrave", 'À');
			_entities.Add("Aacute", 'Á');
			_entities.Add("Acirc", 'Â');
			_entities.Add("Atilde", 'Ã');
			_entities.Add("Auml", 'Ä');
			_entities.Add("Aring", 'Å');
			_entities.Add("AElig", 'Æ');
			_entities.Add("Ccedil", 'Ç');
			_entities.Add("Egrave", 'È');
			_entities.Add("Eacute", 'É');
			_entities.Add("Ecirc", 'Ê');
			_entities.Add("Euml", 'Ë');
			_entities.Add("Igrave", 'Ì');
			_entities.Add("Iacute", 'Í');
			_entities.Add("Icirc", 'Î');
			_entities.Add("Iuml", 'Ï');
			_entities.Add("ETH", 'Ð');
			_entities.Add("Ntilde", 'Ñ');
			_entities.Add("Ograve", 'Ò');
			_entities.Add("Oacute", 'Ó');
			_entities.Add("Ocirc", 'Ô');
			_entities.Add("Otilde", 'Õ');
			_entities.Add("Ouml", 'Ö');
			_entities.Add("times", '×');
			_entities.Add("Oslash", 'Ø');
			_entities.Add("Ugrave", 'Ù');
			_entities.Add("Uacute", 'Ú');
			_entities.Add("Ucirc", 'Û');
			_entities.Add("Uuml", 'Ü');
			_entities.Add("Yacute", 'Ý');
			_entities.Add("THORN", 'Þ');
			_entities.Add("szlig", 'ß');
			_entities.Add("agrave", 'à');
			_entities.Add("aacute", 'á');
			_entities.Add("acirc", 'â');
			_entities.Add("atilde", 'ã');
			_entities.Add("auml", 'ä');
			_entities.Add("aring", 'å');
			_entities.Add("aelig", 'æ');
			_entities.Add("ccedil", 'ç');
			_entities.Add("egrave", 'è');
			_entities.Add("eacute", 'é');
			_entities.Add("ecirc", 'ê');
			_entities.Add("euml", 'ë');
			_entities.Add("igrave", 'ì');
			_entities.Add("iacute", 'í');
			_entities.Add("icirc", 'î');
			_entities.Add("iuml", 'ï');
			_entities.Add("eth", 'ð');
			_entities.Add("ntilde", 'ñ');
			_entities.Add("ograve", 'ò');
			_entities.Add("oacute", 'ó');
			_entities.Add("ocirc", 'ô');
			_entities.Add("otilde", 'õ');
			_entities.Add("ouml", 'ö');
			_entities.Add("divide", '÷');
			_entities.Add("oslash", 'ø');
			_entities.Add("ugrave", 'ù');
			_entities.Add("uacute", 'ú');
			_entities.Add("ucirc", 'û');
			_entities.Add("uuml", 'ü');
			_entities.Add("yacute", 'ý');
			_entities.Add("thorn", 'þ');
			_entities.Add("yuml", 'ÿ');
			_entities.Add("fnof", 'ƒ');
			_entities.Add("Alpha", 'Α');
			_entities.Add("Beta", 'Β');
			_entities.Add("Gamma", 'Γ');
			_entities.Add("Delta", 'Δ');
			_entities.Add("Epsilon", 'Ε');
			_entities.Add("Zeta", 'Ζ');
			_entities.Add("Eta", 'Η');
			_entities.Add("Theta", 'Θ');
			_entities.Add("Iota", 'Ι');
			_entities.Add("Kappa", 'Κ');
			_entities.Add("Lambda", 'Λ');
			_entities.Add("Mu", 'Μ');
			_entities.Add("Nu", 'Ν');
			_entities.Add("Xi", 'Ξ');
			_entities.Add("Omicron", 'Ο');
			_entities.Add("Pi", 'Π');
			_entities.Add("Rho", 'Ρ');
			_entities.Add("Sigma", 'Σ');
			_entities.Add("Tau", 'Τ');
			_entities.Add("Upsilon", 'Υ');
			_entities.Add("Phi", 'Φ');
			_entities.Add("Chi", 'Χ');
			_entities.Add("Psi", 'Ψ');
			_entities.Add("Omega", 'Ω');
			_entities.Add("alpha", 'α');
			_entities.Add("beta", 'β');
			_entities.Add("gamma", 'γ');
			_entities.Add("delta", 'δ');
			_entities.Add("epsilon", 'ε');
			_entities.Add("zeta", 'ζ');
			_entities.Add("eta", 'η');
			_entities.Add("theta", 'θ');
			_entities.Add("iota", 'ι');
			_entities.Add("kappa", 'κ');
			_entities.Add("lambda", 'λ');
			_entities.Add("mu", 'μ');
			_entities.Add("nu", 'ν');
			_entities.Add("xi", 'ξ');
			_entities.Add("omicron", 'ο');
			_entities.Add("pi", 'π');
			_entities.Add("rho", 'ρ');
			_entities.Add("sigmaf", 'ς');
			_entities.Add("sigma", 'σ');
			_entities.Add("tau", 'τ');
			_entities.Add("upsilon", 'υ');
			_entities.Add("phi", 'φ');
			_entities.Add("chi", 'χ');
			_entities.Add("psi", 'ψ');
			_entities.Add("omega", 'ω');
			_entities.Add("thetasym", 'ϑ');
			_entities.Add("upsih", 'ϒ');
			_entities.Add("piv", 'ϖ');
			_entities.Add("bull", '•');
			_entities.Add("hellip", '…');
			_entities.Add("prime", '′');
			_entities.Add("Prime", '″');
			_entities.Add("oline", '‾');
			_entities.Add("frasl", '⁄');
			_entities.Add("weierp", '℘');
			_entities.Add("image", 'ℑ');
			_entities.Add("real", 'ℜ');
			_entities.Add("trade", '™');
			_entities.Add("alefsym", 'ℵ');
			_entities.Add("larr", '←');
			_entities.Add("uarr", '↑');
			_entities.Add("rarr", '→');
			_entities.Add("darr", '↓');
			_entities.Add("harr", '↔');
			_entities.Add("crarr", '↵');
			_entities.Add("lArr", '⇐');
			_entities.Add("uArr", '⇑');
			_entities.Add("rArr", '⇒');
			_entities.Add("dArr", '⇓');
			_entities.Add("hArr", '⇔');
			_entities.Add("forall", '∀');
			_entities.Add("part", '∂');
			_entities.Add("exist", '∃');
			_entities.Add("empty", '∅');
			_entities.Add("nabla", '∇');
			_entities.Add("isin", '∈');
			_entities.Add("notin", '∉');
			_entities.Add("ni", '∋');
			_entities.Add("prod", '∏');
			_entities.Add("sum", '∑');
			_entities.Add("minus", '−');
			_entities.Add("lowast", '∗');
			_entities.Add("radic", '√');
			_entities.Add("prop", '∝');
			_entities.Add("infin", '∞');
			_entities.Add("ang", '∠');
			_entities.Add("and", '∧');
			_entities.Add("or", '∨');
			_entities.Add("cap", '∩');
			_entities.Add("cup", '∪');
			_entities.Add("int", '∫');
			_entities.Add("there4", '∴');
			_entities.Add("sim", '∼');
			_entities.Add("cong", '≅');
			_entities.Add("asymp", '≈');
			_entities.Add("ne", '≠');
			_entities.Add("equiv", '≡');
			_entities.Add("le", '≤');
			_entities.Add("ge", '≥');
			_entities.Add("sub", '⊂');
			_entities.Add("sup", '⊃');
			_entities.Add("nsub", '⊄');
			_entities.Add("sube", '⊆');
			_entities.Add("supe", '⊇');
			_entities.Add("oplus", '⊕');
			_entities.Add("otimes", '⊗');
			_entities.Add("perp", '⊥');
			_entities.Add("sdot", '⋅');
			_entities.Add("lceil", '⌈');
			_entities.Add("rceil", '⌉');
			_entities.Add("lfloor", '⌊');
			_entities.Add("rfloor", '⌋');
			_entities.Add("lang", '〈');
			_entities.Add("rang", '〉');
			_entities.Add("loz", '◊');
			_entities.Add("spades", '♠');
			_entities.Add("clubs", '♣');
			_entities.Add("hearts", '♥');
			_entities.Add("diams", '♦');
			_entities.Add("quot", '"');
			_entities.Add("amp", '&');
			_entities.Add("lt", '<');
			_entities.Add("gt", '>');
			_entities.Add("OElig", 'Œ');
			_entities.Add("oelig", 'œ');
			_entities.Add("Scaron", 'Š');
			_entities.Add("scaron", 'š');
			_entities.Add("Yuml", 'Ÿ');
			_entities.Add("circ", 'ˆ');
			_entities.Add("tilde", '\u02dc');
			_entities.Add("ensp", '\u2002');
			_entities.Add("emsp", '\u2003');
			_entities.Add("thinsp", '\u2009');
			_entities.Add("zwnj", '\u200c');
			_entities.Add("zwj", '\u200d');
			_entities.Add("lrm", '\u200e');
			_entities.Add("rlm", '\u200f');
			_entities.Add("ndash", '–');
			_entities.Add("mdash", '—');
			_entities.Add("lsquo", '‘');
			_entities.Add("rsquo", '’');
			_entities.Add("sbquo", '‚');
			_entities.Add("ldquo", '“');
			_entities.Add("rdquo", '”');
			_entities.Add("bdquo", '„');
			_entities.Add("dagger", '†');
			_entities.Add("Dagger", '‡');
			_entities.Add("permil", '‰');
			_entities.Add("lsaquo", '‹');
			_entities.Add("rsaquo", '›');
			_entities.Add("euro", '€');
		}

		private static bool notEncoded(char c)
		{
			return c == '!' || c == '\'' || c == '(' || c == ')' || c == '*' || c == '-' || c == '.' || c == '_';
		}

		private static void urlEncode(char c, Stream result, bool unicode)
		{
			if (c > 'ÿ')
			{
				result.WriteByte(37);
				result.WriteByte(117);
				int num = (int)c >> 12;
				result.WriteByte((byte)_hexChars[num]);
				num = ((int)c >> 8) & 0xF;
				result.WriteByte((byte)_hexChars[num]);
				num = ((int)c >> 4) & 0xF;
				result.WriteByte((byte)_hexChars[num]);
				num = c & 0xF;
				result.WriteByte((byte)_hexChars[num]);
			}
			else if (c > ' ' && notEncoded(c))
			{
				result.WriteByte((byte)c);
			}
			else if (c == ' ')
			{
				result.WriteByte(43);
			}
			else if (c < '0' || (c < 'A' && c > '9') || (c > 'Z' && c < 'a') || c > 'z')
			{
				if (unicode && c > '\u007f')
				{
					result.WriteByte(37);
					result.WriteByte(117);
					result.WriteByte(48);
					result.WriteByte(48);
				}
				else
				{
					result.WriteByte(37);
				}
				int num2 = (int)c >> 4;
				result.WriteByte((byte)_hexChars[num2]);
				num2 = c & 0xF;
				result.WriteByte((byte)_hexChars[num2]);
			}
			else
			{
				result.WriteByte((byte)c);
			}
		}

		private static void urlPathEncode(char c, Stream result)
		{
			if (c < '!' || c > '~')
			{
				byte[] bytes = Encoding.UTF8.GetBytes(c.ToString());
				byte[] array = bytes;
				foreach (byte b in array)
				{
					result.WriteByte(37);
					int num = b;
					int num2 = num >> 4;
					result.WriteByte((byte)_hexChars[num2]);
					num2 = num & 0xF;
					result.WriteByte((byte)_hexChars[num2]);
				}
			}
			else if (c == ' ')
			{
				result.WriteByte(37);
				result.WriteByte(50);
				result.WriteByte(48);
			}
			else
			{
				result.WriteByte((byte)c);
			}
		}

		private static void writeCharBytes(char c, IList buffer, Encoding encoding)
		{
			if (c > 'ÿ')
			{
				byte[] bytes = encoding.GetBytes(new char[1] { c });
				foreach (byte b in bytes)
				{
					buffer.Add(b);
				}
			}
			else
			{
				buffer.Add((byte)c);
			}
		}

		internal static Uri CreateRequestUrl(string requestUri, string host, bool websocketRequest, bool secure)
		{
			if (requestUri == null || requestUri.Length == 0 || host == null || host.Length == 0)
			{
				return null;
			}
			string text = null;
			string arg = null;
			if (requestUri.StartsWith("/"))
			{
				arg = requestUri;
			}
			else if (requestUri.MaybeUri())
			{
				if (!Uri.TryCreate(requestUri, UriKind.Absolute, out var result) || ((!(text = result.Scheme).StartsWith("http") || websocketRequest) && !(text.StartsWith("ws") && websocketRequest)))
				{
					return null;
				}
				host = result.Authority;
				arg = result.PathAndQuery;
			}
			else if (!(requestUri == "*"))
			{
				host = requestUri;
			}
			if (text == null)
			{
				text = (websocketRequest ? "ws" : "http") + (secure ? "s" : string.Empty);
			}
			int num = host.IndexOf(':');
			if (num == -1)
			{
				host = string.Format("{0}:{1}", host, (text == "http" || text == "ws") ? 80 : 443);
			}
			string uriString = $"{text}://{host}{arg}";
			if (!Uri.TryCreate(uriString, UriKind.Absolute, out var result2))
			{
				return null;
			}
			return result2;
		}

		internal static IPrincipal CreateUser(string response, AuthenticationSchemes scheme, string realm, string method, Func<IIdentity, NetworkCredential> credentialsFinder)
		{
			if (response == null || response.Length == 0)
			{
				return null;
			}
			if (credentialsFinder == null)
			{
				return null;
			}
			if (scheme != AuthenticationSchemes.Basic && scheme != AuthenticationSchemes.Digest)
			{
				return null;
			}
			if (scheme == AuthenticationSchemes.Digest)
			{
				if (realm == null || realm.Length == 0)
				{
					return null;
				}
				if (method == null || method.Length == 0)
				{
					return null;
				}
			}
			if (!response.StartsWith(scheme.ToString(), StringComparison.OrdinalIgnoreCase))
			{
				return null;
			}
			AuthenticationResponse authenticationResponse = AuthenticationResponse.Parse(response);
			if (authenticationResponse == null)
			{
				return null;
			}
			IIdentity identity = authenticationResponse.ToIdentity();
			if (identity == null)
			{
				return null;
			}
			NetworkCredential networkCredential = null;
			try
			{
				networkCredential = credentialsFinder(identity);
			}
			catch
			{
			}
			if (networkCredential == null)
			{
				return null;
			}
			if (scheme == AuthenticationSchemes.Basic && ((HttpBasicIdentity)identity).Password != networkCredential.Password)
			{
				return null;
			}
			if (scheme == AuthenticationSchemes.Digest && !((HttpDigestIdentity)identity).IsValid(networkCredential.Password, realm, method, null))
			{
				return null;
			}
			return new GenericPrincipal(identity, networkCredential.Roles);
		}

		internal static Encoding GetEncoding(string contentType)
		{
			string[] array = contentType.Split(';');
			string[] array2 = array;
			foreach (string text in array2)
			{
				string text2 = text.Trim();
				if (text2.StartsWith("charset", StringComparison.OrdinalIgnoreCase))
				{
					return Encoding.GetEncoding(text2.GetValue('=', unquote: true));
				}
			}
			return null;
		}

		internal static NameValueCollection InternalParseQueryString(string query, Encoding encoding)
		{
			int length;
			if (query == null || (length = query.Length) == 0 || (length == 1 && query[0] == '?'))
			{
				return new NameValueCollection(1);
			}
			if (query[0] == '?')
			{
				query = query.Substring(1);
			}
			QueryStringCollection queryStringCollection = new QueryStringCollection();
			string[] array = query.Split('&');
			string[] array2 = array;
			foreach (string text in array2)
			{
				int num = text.IndexOf('=');
				if (num > -1)
				{
					string name = UrlDecode(text.Substring(0, num), encoding);
					string val = ((text.Length > num + 1) ? UrlDecode(text.Substring(num + 1), encoding) : string.Empty);
					queryStringCollection.Add(name, val);
				}
				else
				{
					queryStringCollection.Add(null, UrlDecode(text, encoding));
				}
			}
			return queryStringCollection;
		}

		internal static string InternalUrlDecode(byte[] bytes, int offset, int count, Encoding encoding)
		{
			StringBuilder stringBuilder = new StringBuilder();
			using (MemoryStream memoryStream = new MemoryStream())
			{
				int num = count + offset;
				for (int i = offset; i < num; i++)
				{
					if (bytes[i] == 37 && i + 2 < count && bytes[i + 1] != 37)
					{
						int num2;
						if (bytes[i + 1] == 117 && i + 5 < num)
						{
							if (memoryStream.Length > 0)
							{
								stringBuilder.Append(getChars(memoryStream, encoding));
								memoryStream.SetLength(0L);
							}
							num2 = getChar(bytes, i + 2, 4);
							if (num2 != -1)
							{
								stringBuilder.Append((char)num2);
								i += 5;
								continue;
							}
						}
						else if ((num2 = getChar(bytes, i + 1, 2)) != -1)
						{
							memoryStream.WriteByte((byte)num2);
							i += 2;
							continue;
						}
					}
					if (memoryStream.Length > 0)
					{
						stringBuilder.Append(getChars(memoryStream, encoding));
						memoryStream.SetLength(0L);
					}
					if (bytes[i] == 43)
					{
						stringBuilder.Append(' ');
					}
					else
					{
						stringBuilder.Append((char)bytes[i]);
					}
				}
				if (memoryStream.Length > 0)
				{
					stringBuilder.Append(getChars(memoryStream, encoding));
				}
			}
			return stringBuilder.ToString();
		}

		internal static byte[] InternalUrlDecodeToBytes(byte[] bytes, int offset, int count)
		{
			using MemoryStream memoryStream = new MemoryStream();
			int num = offset + count;
			for (int i = offset; i < num; i++)
			{
				char c = (char)bytes[i];
				switch (c)
				{
				case '+':
					c = ' ';
					break;
				case '%':
					if (i < num - 2)
					{
						int num2 = getChar(bytes, i + 1, 2);
						if (num2 != -1)
						{
							c = (char)num2;
							i += 2;
						}
					}
					break;
				}
				memoryStream.WriteByte((byte)c);
			}
			memoryStream.Close();
			return memoryStream.ToArray();
		}

		internal static byte[] InternalUrlEncodeToBytes(byte[] bytes, int offset, int count)
		{
			using MemoryStream memoryStream = new MemoryStream();
			int num = offset + count;
			for (int i = offset; i < num; i++)
			{
				urlEncode((char)bytes[i], memoryStream, unicode: false);
			}
			memoryStream.Close();
			return memoryStream.ToArray();
		}

		internal static byte[] InternalUrlEncodeUnicodeToBytes(string s)
		{
			using MemoryStream memoryStream = new MemoryStream();
			foreach (char c in s)
			{
				urlEncode(c, memoryStream, unicode: true);
			}
			memoryStream.Close();
			return memoryStream.ToArray();
		}

		public static string HtmlAttributeEncode(string s)
		{
			if (s == null || s.Length == 0 || !s.Contains('&', '"', '<', '>'))
			{
				return s;
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < s.Length; i++)
			{
				char c = s[i];
				stringBuilder.Append(c switch
				{
					'>' => "&gt;", 
					'<' => "&lt;", 
					'"' => "&quot;", 
					'&' => "&amp;", 
					_ => c.ToString(), 
				});
			}
			return stringBuilder.ToString();
		}

		public static void HtmlAttributeEncode(string s, TextWriter output)
		{
			if (output == null)
			{
				throw new ArgumentNullException("output");
			}
			output.Write(HtmlAttributeEncode(s));
		}

		public static string HtmlDecode(string s)
		{
			if (s == null || s.Length == 0 || !s.Contains('&'))
			{
				return s;
			}
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();
			int num = 0;
			int num2 = 0;
			bool flag = false;
			foreach (char c in s)
			{
				if (num == 0)
				{
					if (c == '&')
					{
						stringBuilder.Append(c);
						num = 1;
					}
					else
					{
						stringBuilder2.Append(c);
					}
					continue;
				}
				if (c == '&')
				{
					num = 1;
					if (flag)
					{
						stringBuilder.Append(num2.ToString(CultureInfo.InvariantCulture));
						flag = false;
					}
					stringBuilder2.Append(stringBuilder.ToString());
					stringBuilder.Length = 0;
					stringBuilder.Append('&');
					continue;
				}
				switch (num)
				{
				case 1:
					if (c == ';')
					{
						num = 0;
						stringBuilder2.Append(stringBuilder.ToString());
						stringBuilder2.Append(c);
						stringBuilder.Length = 0;
					}
					else
					{
						num2 = 0;
						num = ((c == '#') ? 3 : 2);
						stringBuilder.Append(c);
					}
					break;
				case 2:
					stringBuilder.Append(c);
					if (c == ';')
					{
						string text = stringBuilder.ToString();
						Dictionary<string, char> entities = getEntities();
						if (text.Length > 1 && entities.ContainsKey(text.Substring(1, text.Length - 2)))
						{
							text = entities[text.Substring(1, text.Length - 2)].ToString();
						}
						stringBuilder2.Append(text);
						num = 0;
						stringBuilder.Length = 0;
					}
					break;
				case 3:
					if (c == ';')
					{
						if (num2 > 65535)
						{
							stringBuilder2.Append("&#");
							stringBuilder2.Append(num2.ToString(CultureInfo.InvariantCulture));
							stringBuilder2.Append(";");
						}
						else
						{
							stringBuilder2.Append((char)num2);
						}
						num = 0;
						stringBuilder.Length = 0;
						flag = false;
					}
					else if (char.IsDigit(c))
					{
						num2 = num2 * 10 + (c - 48);
						flag = true;
					}
					else
					{
						num = 2;
						if (flag)
						{
							stringBuilder.Append(num2.ToString(CultureInfo.InvariantCulture));
							flag = false;
						}
						stringBuilder.Append(c);
					}
					break;
				}
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder2.Append(stringBuilder.ToString());
			}
			else if (flag)
			{
				stringBuilder2.Append(num2.ToString(CultureInfo.InvariantCulture));
			}
			return stringBuilder2.ToString();
		}

		public static void HtmlDecode(string s, TextWriter output)
		{
			if (output == null)
			{
				throw new ArgumentNullException("output");
			}
			output.Write(HtmlDecode(s));
		}

		public static string HtmlEncode(string s)
		{
			if (s == null || s.Length == 0)
			{
				return s;
			}
			bool flag = false;
			foreach (char c in s)
			{
				if (c == '&' || c == '"' || c == '<' || c == '>' || c > '\u009f')
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return s;
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char c2 in s)
			{
				if (c2 == '&')
				{
					stringBuilder.Append("&amp;");
				}
				else if (c2 == '"')
				{
					stringBuilder.Append("&quot;");
				}
				else if (c2 == '<')
				{
					stringBuilder.Append("&lt;");
				}
				else if (c2 == '>')
				{
					stringBuilder.Append("&gt;");
				}
				else if (c2 > '\u009f')
				{
					stringBuilder.Append("&#");
					int num = c2;
					stringBuilder.Append(num.ToString(CultureInfo.InvariantCulture));
					stringBuilder.Append(";");
				}
				else
				{
					stringBuilder.Append(c2);
				}
			}
			return stringBuilder.ToString();
		}

		public static void HtmlEncode(string s, TextWriter output)
		{
			if (output == null)
			{
				throw new ArgumentNullException("output");
			}
			output.Write(HtmlEncode(s));
		}

		public static NameValueCollection ParseQueryString(string query)
		{
			return ParseQueryString(query, Encoding.UTF8);
		}

		public static NameValueCollection ParseQueryString(string query, Encoding encoding)
		{
			if (query == null)
			{
				throw new ArgumentNullException("query");
			}
			return InternalParseQueryString(query, encoding ?? Encoding.UTF8);
		}

		public static string UrlDecode(string s)
		{
			return UrlDecode(s, Encoding.UTF8);
		}

		public static string UrlDecode(string s, Encoding encoding)
		{
			if (s == null || s.Length == 0 || !s.Contains('%', '+'))
			{
				return s;
			}
			if (encoding == null)
			{
				encoding = Encoding.UTF8;
			}
			List<byte> list = new List<byte>();
			int length = s.Length;
			for (int i = 0; i < length; i++)
			{
				char c = s[i];
				if (c == '%' && i + 2 < length && s[i + 1] != '%')
				{
					int num;
					if (s[i + 1] == 'u' && i + 5 < length)
					{
						num = getChar(s, i + 2, 4);
						if (num != -1)
						{
							writeCharBytes((char)num, list, encoding);
							i += 5;
						}
						else
						{
							writeCharBytes('%', list, encoding);
						}
					}
					else if ((num = getChar(s, i + 1, 2)) != -1)
					{
						writeCharBytes((char)num, list, encoding);
						i += 2;
					}
					else
					{
						writeCharBytes('%', list, encoding);
					}
				}
				else if (c == '+')
				{
					writeCharBytes(' ', list, encoding);
				}
				else
				{
					writeCharBytes(c, list, encoding);
				}
			}
			return encoding.GetString(list.ToArray());
		}

		public static string UrlDecode(byte[] bytes, Encoding encoding)
		{
			int count;
			return (bytes == null) ? null : (((count = bytes.Length) == 0) ? string.Empty : InternalUrlDecode(bytes, 0, count, encoding ?? Encoding.UTF8));
		}

		public static string UrlDecode(byte[] bytes, int offset, int count, Encoding encoding)
		{
			if (bytes == null)
			{
				return null;
			}
			int num = bytes.Length;
			if (num == 0 || count == 0)
			{
				return string.Empty;
			}
			if (offset < 0 || offset >= num)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || count > num - offset)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			return InternalUrlDecode(bytes, offset, count, encoding ?? Encoding.UTF8);
		}

		public static byte[] UrlDecodeToBytes(byte[] bytes)
		{
			int count;
			return (bytes != null && (count = bytes.Length) > 0) ? InternalUrlDecodeToBytes(bytes, 0, count) : bytes;
		}

		public static byte[] UrlDecodeToBytes(string s)
		{
			return UrlDecodeToBytes(s, Encoding.UTF8);
		}

		public static byte[] UrlDecodeToBytes(string s, Encoding encoding)
		{
			if (s == null)
			{
				return null;
			}
			if (s.Length == 0)
			{
				return new byte[0];
			}
			byte[] bytes = (encoding ?? Encoding.UTF8).GetBytes(s);
			return InternalUrlDecodeToBytes(bytes, 0, bytes.Length);
		}

		public static byte[] UrlDecodeToBytes(byte[] bytes, int offset, int count)
		{
			int num;
			if (bytes == null || (num = bytes.Length) == 0)
			{
				return bytes;
			}
			if (count == 0)
			{
				return new byte[0];
			}
			if (offset < 0 || offset >= num)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || count > num - offset)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			return InternalUrlDecodeToBytes(bytes, offset, count);
		}

		public static string UrlEncode(byte[] bytes)
		{
			int count;
			return (bytes == null) ? null : (((count = bytes.Length) == 0) ? string.Empty : Encoding.ASCII.GetString(InternalUrlEncodeToBytes(bytes, 0, count)));
		}

		public static string UrlEncode(string s)
		{
			return UrlEncode(s, Encoding.UTF8);
		}

		public static string UrlEncode(string s, Encoding encoding)
		{
			int length;
			if (s == null || (length = s.Length) == 0)
			{
				return s;
			}
			bool flag = false;
			foreach (char c in s)
			{
				if ((c < '0' || (c < 'A' && c > '9') || (c > 'Z' && c < 'a') || c > 'z') && !notEncoded(c))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return s;
			}
			if (encoding == null)
			{
				encoding = Encoding.UTF8;
			}
			byte[] bytes = new byte[encoding.GetMaxByteCount(length)];
			int bytes2 = encoding.GetBytes(s, 0, length, bytes, 0);
			return Encoding.ASCII.GetString(InternalUrlEncodeToBytes(bytes, 0, bytes2));
		}

		public static string UrlEncode(byte[] bytes, int offset, int count)
		{
			byte[] array = UrlEncodeToBytes(bytes, offset, count);
			return (array == null) ? null : ((array.Length == 0) ? string.Empty : Encoding.ASCII.GetString(array));
		}

		public static byte[] UrlEncodeToBytes(byte[] bytes)
		{
			int count;
			return (bytes != null && (count = bytes.Length) > 0) ? InternalUrlEncodeToBytes(bytes, 0, count) : bytes;
		}

		public static byte[] UrlEncodeToBytes(string s)
		{
			return UrlEncodeToBytes(s, Encoding.UTF8);
		}

		public static byte[] UrlEncodeToBytes(string s, Encoding encoding)
		{
			if (s == null)
			{
				return null;
			}
			if (s.Length == 0)
			{
				return new byte[0];
			}
			byte[] bytes = (encoding ?? Encoding.UTF8).GetBytes(s);
			return InternalUrlEncodeToBytes(bytes, 0, bytes.Length);
		}

		public static byte[] UrlEncodeToBytes(byte[] bytes, int offset, int count)
		{
			int num;
			if (bytes == null || (num = bytes.Length) == 0)
			{
				return bytes;
			}
			if (count == 0)
			{
				return new byte[0];
			}
			if (offset < 0 || offset >= num)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || count > num - offset)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			return InternalUrlEncodeToBytes(bytes, offset, count);
		}

		public static string UrlEncodeUnicode(string s)
		{
			return (s != null && s.Length > 0) ? Encoding.ASCII.GetString(InternalUrlEncodeUnicodeToBytes(s)) : s;
		}

		public static byte[] UrlEncodeUnicodeToBytes(string s)
		{
			return (s == null) ? null : ((s.Length == 0) ? new byte[0] : InternalUrlEncodeUnicodeToBytes(s));
		}

		public static string UrlPathEncode(string s)
		{
			if (s == null || s.Length == 0)
			{
				return s;
			}
			using MemoryStream memoryStream = new MemoryStream();
			foreach (char c in s)
			{
				urlPathEncode(c, memoryStream);
			}
			memoryStream.Close();
			return Encoding.ASCII.GetString(memoryStream.ToArray());
		}
	}
	internal class RequestStream : Stream
	{
		private long _bodyLeft;

		private byte[] _buffer;

		private int _count;

		private bool _disposed;

		private int _offset;

		private Stream _stream;

		public override bool CanRead => true;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		public override long Position
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		internal RequestStream(Stream stream, byte[] buffer, int offset, int count)
			: this(stream, buffer, offset, count, -1L)
		{
		}

		internal RequestStream(Stream stream, byte[] buffer, int offset, int count, long contentLength)
		{
			_stream = stream;
			_buffer = buffer;
			_offset = offset;
			_count = count;
			_bodyLeft = contentLength;
		}

		private int fillFromBuffer(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "A negative value.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "A negative value.");
			}
			int num = buffer.Length;
			if (offset + count > num)
			{
				throw new ArgumentException("The sum of 'offset' and 'count' is greater than 'buffer' length.");
			}
			if (_bodyLeft == 0)
			{
				return -1;
			}
			if (_count == 0 || count == 0)
			{
				return 0;
			}
			if (count > _count)
			{
				count = _count;
			}
			if (_bodyLeft > 0 && count > _bodyLeft)
			{
				count = (int)_bodyLeft;
			}
			Buffer.BlockCopy(_buffer, _offset, buffer, offset, count);
			_offset += count;
			_count -= count;
			if (_bodyLeft > 0)
			{
				_bodyLeft -= count;
			}
			return count;
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (_disposed)
			{
				throw new ObjectDisposedException(GetType().ToString());
			}
			int num = fillFromBuffer(buffer, offset, count);
			if (num > 0 || num == -1)
			{
				HttpStreamAsyncResult httpStreamAsyncResult = new HttpStreamAsyncResult(callback, state);
				httpStreamAsyncResult.Buffer = buffer;
				httpStreamAsyncResult.Offset = offset;
				httpStreamAsyncResult.Count = count;
				httpStreamAsyncResult.SyncRead = ((num > 0) ? num : 0);
				httpStreamAsyncResult.Complete();
				return httpStreamAsyncResult;
			}
			if (_bodyLeft >= 0 && count > _bodyLeft)
			{
				count = (int)_bodyLeft;
			}
			return _stream.BeginRead(buffer, offset, count, callback, state);
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw new NotSupportedException();
		}

		public override void Close()
		{
			_disposed = true;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			if (_disposed)
			{
				throw new ObjectDisposedException(GetType().ToString());
			}
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (asyncResult is HttpStreamAsyncResult)
			{
				HttpStreamAsyncResult httpStreamAsyncResult = (HttpStreamAsyncResult)asyncResult;
				if (!httpStreamAsyncResult.IsCompleted)
				{
					httpStreamAsyncResult.AsyncWaitHandle.WaitOne();
				}
				return httpStreamAsyncResult.SyncRead;
			}
			int num = _stream.EndRead(asyncResult);
			if (num > 0 && _bodyLeft > 0)
			{
				_bodyLeft -= num;
			}
			return num;
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw new NotSupportedException();
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			if (_disposed)
			{
				throw new ObjectDisposedException(GetType().ToString());
			}
			int num = fillFromBuffer(buffer, offset, count);
			if (num == -1)
			{
				return 0;
			}
			if (num > 0)
			{
				return num;
			}
			num = _stream.Read(buffer, offset, count);
			if (num > 0 && _bodyLeft > 0)
			{
				_bodyLeft -= num;
			}
			return num;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}
	}
	internal class ResponseStream : Stream
	{
		private MemoryStream _body;

		private static readonly byte[] _crlf = new byte[2] { 13, 10 };

		private bool _disposed;

		private HttpListenerResponse _response;

		private bool _sendChunked;

		private Stream _stream;

		private Action<byte[], int, int> _write;

		private Action<byte[], int, int> _writeBody;

		private Action<byte[], int, int> _writeChunked;

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanWrite => !_disposed;

		public override long Length
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		public override long Position
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		internal ResponseStream(Stream stream, HttpListenerResponse response, bool ignoreWriteExceptions)
		{
			_stream = stream;
			_response = response;
			if (ignoreWriteExceptions)
			{
				_write = writeWithoutThrowingException;
				_writeChunked = writeChunkedWithoutThrowingException;
			}
			else
			{
				_write = stream.Write;
				_writeChunked = writeChunked;
			}
			_body = new MemoryStream();
		}

		private bool flush(bool closing)
		{
			if (!_response.HeadersSent)
			{
				if (!flushHeaders(closing))
				{
					if (closing)
					{
						_response.CloseConnection = true;
					}
					return false;
				}
				_sendChunked = _response.SendChunked;
				_writeBody = (_sendChunked ? _writeChunked : _write);
			}
			flushBody(closing);
			if (closing && _sendChunked)
			{
				byte[] chunkSizeBytes = getChunkSizeBytes(0, final: true);
				_write(chunkSizeBytes, 0, chunkSizeBytes.Length);
			}
			return true;
		}

		private void flushBody(bool closing)
		{
			using (_body)
			{
				long length = _body.Length;
				if (length > int.MaxValue)
				{
					_body.Position = 0L;
					int num = 1024;
					byte[] array = new byte[num];
					int num2 = 0;
					while ((num2 = _body.Read(array, 0, num)) > 0)
					{
						_writeBody(array, 0, num2);
					}
				}
				else if (length > 0)
				{
					_writeBody(_body.GetBuffer(), 0, (int)length);
				}
			}
			_body = ((!closing) ? new MemoryStream() : null);
		}

		private bool flushHeaders(bool closing)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				WebHeaderCollection webHeaderCollection = _response.WriteHeadersTo(memoryStream);
				long position = memoryStream.Position;
				long num = memoryStream.Length - position;
				if (num > 32768)
				{
					return false;
				}
				if (!_response.SendChunked && _response.ContentLength64 != _body.Length)
				{
					return false;
				}
				_write(memoryStream.GetBuffer(), (int)position, (int)num);
				_response.CloseConnection = webHeaderCollection["Connection"] == "close";
				_response.HeadersSent = true;
			}
			return true;
		}

		private static byte[] getChunkSizeBytes(int size, bool final)
		{
			return Encoding.ASCII.GetBytes(string.Format("{0:x}\r\n{1}", size, final ? "\r\n" : ""));
		}

		private void writeChunked(byte[] buffer, int offset, int count)
		{
			byte[] chunkSizeBytes = getChunkSizeBytes(count, final: false);
			_stream.Write(chunkSizeBytes, 0, chunkSizeBytes.Length);
			_stream.Write(buffer, offset, count);
			_stream.Write(_crlf, 0, 2);
		}

		private void writeChunkedWithoutThrowingException(byte[] buffer, int offset, int count)
		{
			try
			{
				writeChunked(buffer, offset, count);
			}
			catch
			{
			}
		}

		private void writeWithoutThrowingException(byte[] buffer, int offset, int count)
		{
			try
			{
				_stream.Write(buffer, offset, count);
			}
			catch
			{
			}
		}

		internal void Close(bool force)
		{
			if (_disposed)
			{
				return;
			}
			_disposed = true;
			if (!force && flush(closing: true))
			{
				_response.Close();
			}
			else
			{
				if (_sendChunked)
				{
					byte[] chunkSizeBytes = getChunkSizeBytes(0, final: true);
					_write(chunkSizeBytes, 0, chunkSizeBytes.Length);
				}
				_body.Dispose();
				_body = null;
				_response.Abort();
			}
			_response = null;
			_stream = null;
		}

		internal void InternalWrite(byte[] buffer, int offset, int count)
		{
			_write(buffer, offset, count);
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw new NotSupportedException();
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (_disposed)
			{
				throw new ObjectDisposedException(GetType().ToString());
			}
			return _body.BeginWrite(buffer, offset, count, callback, state);
		}

		public override void Close()
		{
			Close(force: false);
		}

		protected override void Dispose(bool disposing)
		{
			Close(!disposing);
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			throw new NotSupportedException();
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
			if (_disposed)
			{
				throw new ObjectDisposedException(GetType().ToString());
			}
			_body.EndWrite(asyncResult);
		}

		public override void Flush()
		{
			if (!_disposed && (_sendChunked || _response.SendChunked))
			{
				flush(closing: false);
			}
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException();
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		public override void SetLength(long value)
		{
			throw new NotSupportedException();
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			if (_disposed)
			{
				throw new ObjectDisposedException(GetType().ToString());
			}
			_body.Write(buffer, offset, count);
		}
	}
	[Serializable]
	[ComVisible(true)]
	public class WebHeaderCollection : NameValueCollection, ISerializable
	{
		private static readonly Dictionary<string, HttpHeaderInfo> _headers;

		private bool _internallyUsed;

		private HttpHeaderType _state;

		internal HttpHeaderType State => _state;

		public override string[] AllKeys => base.AllKeys;

		public override int Count => base.Count;

		public string this[HttpRequestHeader header]
		{
			get
			{
				return Get(Convert(header));
			}
			set
			{
				Add(header, value);
			}
		}

		public string this[HttpResponseHeader header]
		{
			get
			{
				return Get(Convert(header));
			}
			set
			{
				Add(header, value);
			}
		}

		public override KeysCollection Keys => base.Keys;

		static WebHeaderCollection()
		{
			_headers = new Dictionary<string, HttpHeaderInfo>(StringComparer.InvariantCultureIgnoreCase)
			{
				{
					"Accept",
					new HttpHeaderInfo("Accept", HttpHeaderType.Request | HttpHeaderType.Restricted | HttpHeaderType.MultiValue)
				},
				{
					"AcceptCharset",
					new HttpHeaderInfo("Accept-Charset", HttpHeaderType.Request | HttpHeaderType.MultiValue)
				},
				{
					"AcceptEncoding",
					new HttpHeaderInfo("Accept-Encoding", HttpHeaderType.Request | HttpHeaderType.MultiValue)
				},
				{
					"AcceptLanguage",
					new HttpHeaderInfo("Accept-Language", HttpHeaderType.Request | HttpHeaderType.MultiValue)
				},
				{
					"AcceptRanges",
					new HttpHeaderInfo("Accept-Ranges", HttpHeaderType.Response | HttpHeaderType.MultiValue)
				},
				{
					"Age",
					new HttpHeaderInfo("Age", HttpHeaderType.Response)
				},
				{
					"Allow",
					new HttpHeaderInfo("Allow", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.MultiValue)
				},
				{
					"Authorization",
					new HttpHeaderInfo("Authorization", HttpHeaderType.Request | HttpHeaderType.MultiValue)
				},
				{
					"CacheControl",
					new HttpHeaderInfo("Cache-Control", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.MultiValue)
				},
				{
					"Connection",
					new HttpHeaderInfo("Connection", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.Restricted | HttpHeaderType.MultiValue)
				},
				{
					"ContentEncoding",
					new HttpHeaderInfo("Content-Encoding", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.MultiValue)
				},
				{
					"ContentLanguage",
					new HttpHeaderInfo("Content-Language", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.MultiValue)
				},
				{
					"ContentLength",
					new HttpHeaderInfo("Content-Length", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.Restricted)
				},
				{
					"ContentLocation",
					new HttpHeaderInfo("Content-Location", HttpHeaderType.Request | HttpHeaderType.Response)
				},
				{
					"ContentMd5",
					new HttpHeaderInfo("Content-MD5", HttpHeaderType.Request | HttpHeaderType.Response)
				},
				{
					"ContentRange",
					new HttpHeaderInfo("Content-Range", HttpHeaderType.Request | HttpHeaderType.Response)
				},
				{
					"ContentType",
					new HttpHeaderInfo("Content-Type", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.Restricted)
				},
				{
					"Cookie",
					new HttpHeaderInfo("Cookie", HttpHeaderType.Request)
				},
				{
					"Cookie2",
					new HttpHeaderInfo("Cookie2", HttpHeaderType.Request)
				},
				{
					"Date",
					new HttpHeaderInfo("Date", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.Restricted)
				},
				{
					"Expect",
					new HttpHeaderInfo("Expect", HttpHeaderType.Request | HttpHeaderType.Restricted | HttpHeaderType.MultiValue)
				},
				{
					"Expires",
					new HttpHeaderInfo("Expires", HttpHeaderType.Request | HttpHeaderType.Response)
				},
				{
					"ETag",
					new HttpHeaderInfo("ETag", HttpHeaderType.Response)
				},
				{
					"From",
					new HttpHeaderInfo("From", HttpHeaderType.Request)
				},
				{
					"Host",
					new HttpHeaderInfo("Host", HttpHeaderType.Request | HttpHeaderType.Restricted)
				},
				{
					"IfMatch",
					new HttpHeaderInfo("If-Match", HttpHeaderType.Request | HttpHeaderType.MultiValue)
				},
				{
					"IfModifiedSince",
					new HttpHeaderInfo("If-Modified-Since", HttpHeaderType.Request | HttpHeaderType.Restricted)
				},
				{
					"IfNoneMatch",
					new HttpHeaderInfo("If-None-Match", HttpHeaderType.Request | HttpHeaderType.MultiValue)
				},
				{
					"IfRange",
					new HttpHeaderInfo("If-Range", HttpHeaderType.Request)
				},
				{
					"IfUnmodifiedSince",
					new HttpHeaderInfo("If-Unmodified-Since", HttpHeaderType.Request)
				},
				{
					"KeepAlive",
					new HttpHeaderInfo("Keep-Alive", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.MultiValue)
				},
				{
					"LastModified",
					new HttpHeaderInfo("Last-Modified", HttpHeaderType.Request | HttpHeaderType.Response)
				},
				{
					"Location",
					new HttpHeaderInfo("Location", HttpHeaderType.Response)
				},
				{
					"MaxForwards",
					new HttpHeaderInfo("Max-Forwards", HttpHeaderType.Request)
				},
				{
					"Pragma",
					new HttpHeaderInfo("Pragma", HttpHeaderType.Request | HttpHeaderType.Response)
				},
				{
					"ProxyAuthenticate",
					new HttpHeaderInfo("Proxy-Authenticate", HttpHeaderType.Response | HttpHeaderType.MultiValue)
				},
				{
					"ProxyAuthorization",
					new HttpHeaderInfo("Proxy-Authorization", HttpHeaderType.Request)
				},
				{
					"ProxyConnection",
					new HttpHeaderInfo("Proxy-Connection", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.Restricted)
				},
				{
					"Public",
					new HttpHeaderInfo("Public", HttpHeaderType.Response | HttpHeaderType.MultiValue)
				},
				{
					"Range",
					new HttpHeaderInfo("Range", HttpHeaderType.Request | HttpHeaderType.Restricted | HttpHeaderType.MultiValue)
				},
				{
					"Referer",
					new HttpHeaderInfo("Referer", HttpHeaderType.Request | HttpHeaderType.Restricted)
				},
				{
					"RetryAfter",
					new HttpHeaderInfo("Retry-After", HttpHeaderType.Response)
				},
				{
					"SecWebSocketAccept",
					new HttpHeaderInfo("Sec-WebSocket-Accept", HttpHeaderType.Response | HttpHeaderType.Restricted)
				},
				{
					"SecWebSocketExtensions",
					new HttpHeaderInfo("Sec-WebSocket-Extensions", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.Restricted | HttpHeaderType.MultiValueInRequest)
				},
				{
					"SecWebSocketKey",
					new HttpHeaderInfo("Sec-WebSocket-Key", HttpHeaderType.Request | HttpHeaderType.Restricted)
				},
				{
					"SecWebSocketProtocol",
					new HttpHeaderInfo("Sec-WebSocket-Protocol", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.MultiValueInRequest)
				},
				{
					"SecWebSocketVersion",
					new HttpHeaderInfo("Sec-WebSocket-Version", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.Restricted | HttpHeaderType.MultiValueInResponse)
				},
				{
					"Server",
					new HttpHeaderInfo("Server", HttpHeaderType.Response)
				},
				{
					"SetCookie",
					new HttpHeaderInfo("Set-Cookie", HttpHeaderType.Response | HttpHeaderType.MultiValue)
				},
				{
					"SetCookie2",
					new HttpHeaderInfo("Set-Cookie2", HttpHeaderType.Response | HttpHeaderType.MultiValue)
				},
				{
					"Te",
					new HttpHeaderInfo("TE", HttpHeaderType.Request)
				},
				{
					"Trailer",
					new HttpHeaderInfo("Trailer", HttpHeaderType.Request | HttpHeaderType.Response)
				},
				{
					"TransferEncoding",
					new HttpHeaderInfo("Transfer-Encoding", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.Restricted | HttpHeaderType.MultiValue)
				},
				{
					"Translate",
					new HttpHeaderInfo("Translate", HttpHeaderType.Request)
				},
				{
					"Upgrade",
					new HttpHeaderInfo("Upgrade", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.MultiValue)
				},
				{
					"UserAgent",
					new HttpHeaderInfo("User-Agent", HttpHeaderType.Request | HttpHeaderType.Restricted)
				},
				{
					"Vary",
					new HttpHeaderInfo("Vary", HttpHeaderType.Response | HttpHeaderType.MultiValue)
				},
				{
					"Via",
					new HttpHeaderInfo("Via", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.MultiValue)
				},
				{
					"Warning",
					new HttpHeaderInfo("Warning", HttpHeaderType.Request | HttpHeaderType.Response | HttpHeaderType.MultiValue)
				},
				{
					"WwwAuthenticate",
					new HttpHeaderInfo("WWW-Authenticate", HttpHeaderType.Response | HttpHeaderType.Restricted | HttpHeaderType.MultiValue)
				}
			};
		}

		internal WebHeaderCollection(HttpHeaderType state, bool internallyUsed)
		{
			_state = state;
			_internallyUsed = internallyUsed;
		}

		protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			if (serializationInfo == null)
			{
				throw new ArgumentNullException("serializationInfo");
			}
			try
			{
				_internallyUsed = serializationInfo.GetBoolean("InternallyUsed");
				_state = (HttpHeaderType)serializationInfo.GetInt32("State");
				int @int = serializationInfo.GetInt32("Count");
				for (int i = 0; i < @int; i++)
				{
					base.Add(serializationInfo.GetString(i.ToString()), serializationInfo.GetString((@int + i).ToString()));
				}
			}
			catch (SerializationException ex)
			{
				throw new ArgumentException(ex.Message, "serializationInfo", ex);
			}
		}

		public WebHeaderCollection()
		{
		}

		private void add(string name, string value, bool ignoreRestricted)
		{
			Action<string, string> action = (ignoreRestricted ? new Action<string, string>(addWithoutCheckingNameAndRestricted) : new Action<string, string>(addWithoutCheckingName));
			doWithCheckingState(action, checkName(name), value, setState: true);
		}

		private void addWithoutCheckingName(string name, string value)
		{
			doWithoutCheckingName(base.Add, name, value);
		}

		private void addWithoutCheckingNameAndRestricted(string name, string value)
		{
			base.Add(name, checkValue(value));
		}

		private static int checkColonSeparated(string header)
		{
			int num = header.IndexOf(':');
			if (num == -1)
			{
				throw new ArgumentException("No colon could be found.", "header");
			}
			return num;
		}

		private static HttpHeaderType checkHeaderType(string name)
		{
			HttpHeaderInfo headerInfo = getHeaderInfo(name);
			return (headerInfo != null) ? ((headerInfo.IsRequest && !headerInfo.IsResponse) ? HttpHeaderType.Request : ((!headerInfo.IsRequest && headerInfo.IsResponse) ? HttpHeaderType.Response : HttpHeaderType.Unspecified)) : HttpHeaderType.Unspecified;
		}

		private static string checkName(string name)
		{
			if (name == null || name.Length == 0)
			{
				throw new ArgumentNullException("name");
			}
			name = name.Trim();
			if (!IsHeaderName(name))
			{
				throw new ArgumentException("Contains invalid characters.", "name");
			}
			return name;
		}

		private void checkRestricted(string name)
		{
			if (!_internallyUsed && isRestricted(name, response: true))
			{
				throw new ArgumentException("This header must be modified with the appropiate property.");
			}
		}

		private void checkState(bool response)
		{
			if (_state != HttpHeaderType.Unspecified)
			{
				if (response && _state == HttpHeaderType.Request)
				{
					throw new InvalidOperationException("This collection has already been used to store the request headers.");
				}
				if (!response && _state == HttpHeaderType.Response)
				{
					throw new InvalidOperationException("This collection has already been used to store the response headers.");
				}
			}
		}

		private static string checkValue(string value)
		{
			if (value == null || value.Length == 0)
			{
				return string.Empty;
			}
			value = value.Trim();
			if (value.Length > 65535)
			{
				throw new ArgumentOutOfRangeException("value", "Greater than 65,535 characters.");
			}
			if (!IsHeaderValue(value))
			{
				throw new ArgumentException("Contains invalid characters.", "value");
			}
			return value;
		}

		private static string convert(string key)
		{
			HttpHeaderInfo value;
			return _headers.TryGetValue(key, out value) ? value.Name : string.Empty;
		}

		private void doWithCheckingState(Action<string, string> action, string name, string value, bool setState)
		{
			switch (checkHeaderType(name))
			{
			case HttpHeaderType.Request:
				doWithCheckingState(action, name, value, response: false, setState);
				break;
			case HttpHeaderType.Response:
				doWithCheckingState(action, name, value, response: true, setState);
				break;
			default:
				action(name, value);
				break;
			}
		}

		private void doWithCheckingState(Action<string, string> action, string name, string value, bool response, bool setState)
		{
			checkState(response);
			action(name, value);
			if (setState && _state == HttpHeaderType.Unspecified)
			{
				_state = ((!response) ? HttpHeaderType.Request : HttpHeaderType.Response);
			}
		}

		private void doWithoutCheckingName(Action<string, string> action, string name, string value)
		{
			checkRestricted(name);
			action(name, checkValue(value));
		}

		private static HttpHeaderInfo getHeaderInfo(string name)
		{
			foreach (HttpHeaderInfo value in _headers.Values)
			{
				if (value.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
				{
					return value;
				}
			}
			return null;
		}

		private static bool isRestricted(string name, bool response)
		{
			return getHeaderInfo(name)?.IsRestricted(response) ?? false;
		}

		private void removeWithoutCheckingName(string name, string unuse)
		{
			checkRestricted(name);
			base.Remove(name);
		}

		private void setWithoutCheckingName(string name, string value)
		{
			doWithoutCheckingName(base.Set, name, value);
		}

		internal static string Convert(HttpRequestHeader header)
		{
			return convert(header.ToString());
		}

		internal static string Convert(HttpResponseHeader header)
		{
			return convert(header.ToString());
		}

		internal void InternalRemove(string name)
		{
			base.Remove(name);
		}

		internal void InternalSet(string header, bool response)
		{
			int num = checkColonSeparated(header);
			InternalSet(header.Substring(0, num), header.Substring(num + 1), response);
		}

		internal void InternalSet(string name, string value, bool response)
		{
			value = checkValue(value);
			if (IsMultiValue(name, response))
			{
				base.Add(name, value);
			}
			else
			{
				base.Set(name, value);
			}
		}

		internal static bool IsHeaderName(string name)
		{
			return name != null && name.Length > 0 && name.IsToken();
		}

		internal static bool IsHeaderValue(string value)
		{
			return value.IsText();
		}

		internal static bool IsMultiValue(string headerName, bool response)
		{
			if (headerName == null || headerName.Length == 0)
			{
				return false;
			}
			return getHeaderInfo(headerName)?.IsMultiValue(response) ?? false;
		}

		internal string ToStringMultiValue(bool response)
		{
			StringBuilder buff = new StringBuilder();
			Count.Times(delegate(int i)
			{
				string key = GetKey(i);
				if (IsMultiValue(key, response))
				{
					string[] values = GetValues(i);
					foreach (string arg in values)
					{
						buff.AppendFormat("{0}: {1}\r\n", key, arg);
					}
				}
				else
				{
					buff.AppendFormat("{0}: {1}\r\n", key, Get(i));
				}
			});
			return buff.Append("\r\n").ToString();
		}

		protected void AddWithoutValidate(string headerName, string headerValue)
		{
			add(headerName, headerValue, ignoreRestricted: true);
		}

		public void Add(string header)
		{
			if (header == null || header.Length == 0)
			{
				throw new ArgumentNullException("header");
			}
			int num = checkColonSeparated(header);
			add(header.Substring(0, num), header.Substring(num + 1), ignoreRestricted: false);
		}

		public void Add(HttpRequestHeader header, string value)
		{
			doWithCheckingState(addWithoutCheckingName, Convert(header), value, response: false, setState: true);
		}

		public void Add(HttpResponseHeader header, string value)
		{
			doWithCheckingState(addWithoutCheckingName, Convert(header), value, response: true, setState: true);
		}

		public override void Add(string name, string value)
		{
			add(name, value, ignoreRestricted: false);
		}

		public override void Clear()
		{
			base.Clear();
			_state = HttpHeaderType.Unspecified;
		}

		public override string Get(int index)
		{
			return base.Get(index);
		}

		public override string Get(string name)
		{
			return base.Get(name);
		}

		public override IEnumerator GetEnumerator()
		{
			return base.GetEnumerator();
		}

		public override string GetKey(int index)
		{
			return base.GetKey(index);
		}

		public override string[] GetValues(int index)
		{
			string[] values = base.GetValues(index);
			return (values != null && values.Length != 0) ? values : null;
		}

		public override string[] GetValues(string header)
		{
			string[] values = base.GetValues(header);
			return (values != null && values.Length != 0) ? values : null;
		}

		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			if (serializationInfo == null)
			{
				throw new ArgumentNullException("serializationInfo");
			}
			serializationInfo.AddValue("InternallyUsed", _internallyUsed);
			serializationInfo.AddValue("State", (int)_state);
			int cnt = Count;
			serializationInfo.AddValue("Count", cnt);
			cnt.Times(delegate(int i)
			{
				serializationInfo.AddValue(i.ToString(), GetKey(i));
				serializationInfo.AddValue((cnt + i).ToString(), Get(i));
			});
		}

		public static bool IsRestricted(string headerName)
		{
			return isRestricted(checkName(headerName), response: false);
		}

		public static bool IsRestricted(string headerName, bool response)
		{
			return isRestricted(checkName(headerName), response);
		}

		public override void OnDeserialization(object sender)
		{
		}

		public void Remove(HttpRequestHeader header)
		{
			doWithCheckingState(removeWithoutCheckingName, Convert(header), null, response: false, setState: false);
		}

		public void Remove(HttpResponseHeader header)
		{
			doWithCheckingState(removeWithoutCheckingName, Convert(header), null, response: true, setState: false);
		}

		public override void Remove(string name)
		{
			doWithCheckingState(removeWithoutCheckingName, checkName(name), null, setState: false);
		}

		public void Set(HttpRequestHeader header, string value)
		{
			doWithCheckingState(setWithoutCheckingName, Convert(header), value, response: false, setState: true);
		}

		public void Set(HttpResponseHeader header, string value)
		{
			doWithCheckingState(setWithoutCheckingName, Convert(header), value, response: true, setState: true);
		}

		public override void Set(string name, string value)
		{
			doWithCheckingState(setWithoutCheckingName, checkName(name), value, setState: true);
		}

		public byte[] ToByteArray()
		{
			return Encoding.UTF8.GetBytes(ToString());
		}

		public override string ToString()
		{
			StringBuilder buff = new StringBuilder();
			Count.Times(delegate(int i)
			{
				buff.AppendFormat("{0}: {1}\r\n", GetKey(i), Get(i));
			});
			return buff.Append("\r\n").ToString();
		}

		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter, SerializationFormatter = true)]
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			GetObjectData(serializationInfo, streamingContext);
		}
	}
	public class HttpVersion
	{
		public static readonly Version Version10 = new Version(1, 0);

		public static readonly Version Version11 = new Version(1, 1);
	}
	public enum HttpStatusCode
	{
		Continue = 100,
		SwitchingProtocols = 101,
		OK = 200,
		Created = 201,
		Accepted = 202,
		NonAuthoritativeInformation = 203,
		NoContent = 204,
		ResetContent = 205,
		PartialContent = 206,
		MultipleChoices = 300,
		Ambiguous = 300,
		MovedPermanently = 301,
		Moved = 301,
		Found = 302,
		Redirect = 302,
		SeeOther = 303,
		RedirectMethod = 303,
		NotModified = 304,
		UseProxy = 305,
		Unused = 306,
		TemporaryRedirect = 307,
		RedirectKeepVerb = 307,
		BadRequest = 400,
		Unauthorized = 401,
		PaymentRequired = 402,
		Forbidden = 403,
		NotFound = 404,
		MethodNotAllowed = 405,
		NotAcceptable = 406,
		ProxyAuthenticationRequired = 407,
		RequestTimeout = 408,
		Conflict = 409,
		Gone = 410,
		LengthRequired = 411,
		PreconditionFailed = 412,
		RequestEntityTooLarge = 413,
		RequestUriTooLong = 414,
		UnsupportedMediaType = 415,
		RequestedRangeNotSatisfiable = 416,
		ExpectationFailed = 417,
		InternalServerError = 500,
		NotImplemented = 501,
		BadGateway = 502,
		ServiceUnavailable = 503,
		GatewayTimeout = 504,
		HttpVersionNotSupported = 505
	}
	[Flags]
	internal enum HttpHeaderType
	{
		Unspecified = 0,
		Request = 1,
		Response = 2,
		Restricted = 4,
		MultiValue = 8,
		MultiValueInRequest = 0x10,
		MultiValueInResponse = 0x20
	}
	internal class HttpHeaderInfo
	{
		private string _name;

		private HttpHeaderType _type;

		internal bool IsMultiValueInRequest => (_type & HttpHeaderType.MultiValueInRequest) == HttpHeaderType.MultiValueInRequest;

		internal bool IsMultiValueInResponse => (_type & HttpHeaderType.MultiValueInResponse) == HttpHeaderType.MultiValueInResponse;

		public bool IsRequest => (_type & HttpHeaderType.Request) == HttpHeaderType.Request;

		public bool IsResponse => (_type & HttpHeaderType.Response) == HttpHeaderType.Response;

		public string Name => _name;

		public HttpHeaderType Type => _type;

		internal HttpHeaderInfo(string name, HttpHeaderType type)
		{
			_name = name;
			_type = type;
		}

		public bool IsMultiValue(bool response)
		{
			return ((_type & HttpHeaderType.MultiValue) != HttpHeaderType.MultiValue) ? (response ? IsMultiValueInResponse : IsMultiValueInRequest) : (response ? IsResponse : IsRequest);
		}

		public bool IsRestricted(bool response)
		{
			return (_type & HttpHeaderType.Restricted) == HttpHeaderType.Restricted && (response ? IsResponse : IsRequest);
		}
	}
	public class HttpBasicIdentity : GenericIdentity
	{
		private string _password;

		public virtual string Password => _password;

		internal HttpBasicIdentity(string username, string password)
			: base(username, "Basic")
		{
			_password = password;
		}
	}
	public class HttpDigestIdentity : GenericIdentity
	{
		private NameValueCollection _parameters;

		public string Algorithm => _parameters["algorithm"];

		public string Cnonce => _parameters["cnonce"];

		public string Nc => _parameters["nc"];

		public string Nonce => _parameters["nonce"];

		public string Opaque => _parameters["opaque"];

		public string Qop => _parameters["qop"];

		public string Realm => _parameters["realm"];

		public string Response => _parameters["response"];

		public string Uri => _parameters["uri"];

		internal HttpDigestIdentity(NameValueCollection parameters)
			: base(parameters["username"], "Digest")
		{
			_parameters = parameters;
		}

		internal bool IsValid(string password, string realm, string method, string entity)
		{
			NameValueCollection nameValueCollection = new NameValueCollection(_parameters);
			nameValueCollection["password"] = password;
			nameValueCollection["realm"] = realm;
			nameValueCollection["method"] = method;
			nameValueCollection["entity"] = entity;
			return _parameters["response"] == AuthenticationResponse.CreateRequestDigest(nameValueCollection);
		}
	}
	public class NetworkCredential
	{
		private string _domain;

		private string _password;

		private string[] _roles;

		private string _userName;

		public string Domain
		{
			get
			{
				return _domain ?? string.Empty;
			}
			internal set
			{
				_domain = value;
			}
		}

		public string Password
		{
			get
			{
				return _password ?? string.Empty;
			}
			internal set
			{
				_password = value;
			}
		}

		public string[] Roles
		{
			get
			{
				return _roles ?? (_roles = new string[0]);
			}
			internal set
			{
				_roles = value;
			}
		}

		public string UserName
		{
			get
			{
				return _userName;
			}
			internal set
			{
				_userName = value;
			}
		}

		public NetworkCredential(string userName, string password)
			: this(userName, password, (string)null, (string[])null)
		{
		}

		public NetworkCredential(string userName, string password, string domain, params string[] roles)
		{
			if (userName == null)
			{
				throw new ArgumentNullException("userName");
			}
			if (userName.Length == 0)
			{
				throw new ArgumentException("An empty string.", "userName");
			}
			_userName = userName;
			_password = password;
			_domain = domain;
			_roles = roles;
		}
	}
	internal enum InputState
	{
		RequestLine,
		Headers
	}
	internal enum LineState
	{
		None,
		Cr,
		Lf
	}
	internal class ReadBufferState
	{
		private HttpStreamAsyncResult _asyncResult;

		private byte[] _buffer;

		private int _count;

		private int _initialCount;

		private int _offset;

		public HttpStreamAsyncResult AsyncResult
		{
			get
			{
				return _asyncResult;
			}
			set
			{
				_asyncResult = value;
			}
		}

		public byte[] Buffer
		{
			get
			{
				return _buffer;
			}
			set
			{
				_buffer = value;
			}
		}

		public int Count
		{
			get
			{
				return _count;
			}
			set
			{
				_count = value;
			}
		}

		public int InitialCount
		{
			get
			{
				return _initialCount;
			}
			set
			{
				_initialCount = value;
			}
		}

		public int Offset
		{
			get
			{
				return _offset;
			}
			set
			{
				_offset = value;
			}
		}

		public ReadBufferState(byte[] buffer, int offset, int count, HttpStreamAsyncResult asyncResult)
		{
			_buffer = buffer;
			_offset = offset;
			_count = count;
			_initialCount = count;
			_asyncResult = asyncResult;
		}
	}
	internal class Chunk
	{
		private byte[] _data;

		private int _offset;

		public int ReadLeft => _data.Length - _offset;

		public Chunk(byte[] data)
		{
			_data = data;
		}

		public int Read(byte[] buffer, int offset, int count)
		{
			int num = _data.Length - _offset;
			if (num == 0)
			{
				return num;
			}
			if (count > num)
			{
				count = num;
			}
			Buffer.BlockCopy(_data, _offset, buffer, offset, count);
			_offset += count;
			return count;
		}
	}
	internal enum InputChunkState
	{
		None,
		Data,
		DataEnded,
		Trailer,
		End
	}
	internal class ChunkedRequestStream : RequestStream
	{
		private const int _bufferLength = 8192;

		private HttpListenerContext _context;

		private ChunkStream _decoder;

		private bool _disposed;

		private bool _noMoreData;

		internal ChunkStream Decoder
		{
			get
			{
				return _decoder;
			}
			set
			{
				_decoder = value;
			}
		}

		internal ChunkedRequestStream(Stream stream, byte[] buffer, int offset, int count, HttpListenerContext context)
			: base(stream, buffer, offset, count)
		{
			_context = context;
			_decoder = new ChunkStream((WebHeaderCollection)context.Request.Headers);
		}

		private void onRead(IAsyncResult asyncResult)
		{
			ReadBufferState readBufferState = (ReadBufferState)asyncResult.AsyncState;
			HttpStreamAsyncResult asyncResult2 = readBufferState.AsyncResult;
			try
			{
				int count = base.EndRead(asyncResult);
				_decoder.Write(asyncResult2.Buffer, asyncResult2.Offset, count);
				count = _decoder.Read(readBufferState.Buffer, readBufferState.Offset, readBufferState.Count);
				readBufferState.Offset += count;
				readBufferState.Count -= count;
				if (readBufferState.Count == 0 || !_decoder.WantMore || count == 0)
				{
					_noMoreData = !_decoder.WantMore && count == 0;
					asyncResult2.Count = readBufferState.InitialCount - readBufferState.Count;
					asyncResult2.Complete();
				}
				else
				{
					asyncResult2.Offset = 0;
					asyncResult2.Count = Math.Min(8192, _decoder.ChunkLeft + 6);
					base.BeginRead(asyncResult2.Buffer, asyncResult2.Offset, asyncResult2.Count, (AsyncCallback)onRead, (object)readBufferState);
				}
			}
			catch (Exception ex)
			{
				_context.Connection.SendError(ex.Message, 400);
				asyncResult2.Complete(ex);
			}
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			if (_disposed)
			{
				throw new ObjectDisposedException(GetType().ToString());
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset", "A negative value.");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "A negative value.");
			}
			int num = buffer.Length;
			if (offset + count > num)
			{
				throw new ArgumentException("The sum of 'offset' and 'count' is greater than 'buffer' length.");
			}
			HttpStreamAsyncResult httpStreamAsyncResult = new HttpStreamAsyncResult(callback, state);
			if (_noMoreData)
			{
				httpStreamAsyncResult.Complete();
				return httpStreamAsyncResult;
			}
			int num2 = _decoder.Read(buffer, offset, count);
			offset += num2;
			count -= num2;
			if (count == 0)
			{
				httpStreamAsyncResult.Count = num2;
				httpStreamAsyncResult.Complete();
				return httpStreamAsyncResult;
			}
			if (!_decoder.WantMore)
			{
				_noMoreData = num2 == 0;
				httpStreamAsyncResult.Count = num2;
				httpStreamAsyncResult.Complete();
				return httpStreamAsyncResult;
			}
			httpStreamAsyncResult.Buffer = new byte[8192];
			httpStreamAsyncResult.Offset = 0;
			httpStreamAsyncResult.Count = 8192;
			ReadBufferState readBufferState = new ReadBufferState(buffer, offset, count, httpStreamAsyncResult);
			readBufferState.InitialCount += num2;
			base.BeginRead(httpStreamAsyncResult.Buffer, httpStreamAsyncResult.Offset, httpStreamAsyncResult.Count, (AsyncCallback)onRead, (object)readBufferState);
			return httpStreamAsyncResult;
		}

		public override void Close()
		{
			if (!_disposed)
			{
				_disposed = true;
				base.Close();
			}
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			if (_disposed)
			{
				throw new ObjectDisposedException(GetType().ToString());
			}
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (!(asyncResult is HttpStreamAsyncResult httpStreamAsyncResult))
			{
				throw new ArgumentException("A wrong IAsyncResult.", "asyncResult");
			}
			if (!httpStreamAsyncResult.IsCompleted)
			{
				httpStreamAsyncResult.AsyncWaitHandle.WaitOne();
			}
			if (httpStreamAsyncResult.HasException)
			{
				throw new HttpListenerException(400, "I/O operation aborted.");
			}
			return httpStreamAsyncResult.Count;
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			IAsyncResult asyncResult = BeginRead(buffer, offset, count, null, null);
			return EndRead(asyncResult);
		}
	}
	internal sealed class QueryStringCollection : NameValueCollection
	{
		public override string ToString()
		{
			if (Count == 0)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			string[] allKeys = AllKeys;
			string[] array = allKeys;
			foreach (string text in array)
			{
				stringBuilder.AppendFormat("{0}={1}&", text, base[text]);
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Length--;
			}
			return stringBuilder.ToString();
		}
	}
	internal class AuthenticationChallenge : AuthenticationBase
	{
		public string Domain => Parameters["domain"];

		public string Stale => Parameters["stale"];

		private AuthenticationChallenge(AuthenticationSchemes scheme, NameValueCollection parameters)
			: base(scheme, parameters)
		{
		}

		internal AuthenticationChallenge(AuthenticationSchemes scheme, string realm)
			: base(scheme, new NameValueCollection())
		{
			Parameters["realm"] = realm;
			if (scheme == AuthenticationSchemes.Digest)
			{
				Parameters["nonce"] = AuthenticationBase.CreateNonceValue();
				Parameters["algorithm"] = "MD5";
				Parameters["qop"] = "auth";
			}
		}

		internal static AuthenticationChallenge CreateBasicChallenge(string realm)
		{
			return new AuthenticationChallenge(AuthenticationSchemes.Basic, realm);
		}

		internal static AuthenticationChallenge CreateDigestChallenge(string realm)
		{
			return new AuthenticationChallenge(AuthenticationSchemes.Digest, realm);
		}

		internal static AuthenticationChallenge Parse(string value)
		{
			string[] array = value.Split(new char[1] { ' ' }, 2);
			if (array.Length != 2)
			{
				return null;
			}
			string text = array[0].ToLower();
			return (text == "basic") ? new AuthenticationChallenge(AuthenticationSchemes.Basic, AuthenticationBase.ParseParameters(array[1])) : ((text == "digest") ? new AuthenticationChallenge(AuthenticationSchemes.Digest, AuthenticationBase.ParseParameters(array[1])) : null);
		}

		internal override string ToBasicString()
		{
			return string.Format("Basic realm=\"{0}\"", Parameters["realm"]);
		}

		internal override string ToDigestString()
		{
			StringBuilder stringBuilder = new StringBuilder(128);
			string text = Parameters["domain"];
			if (text != null)
			{
				stringBuilder.AppendFormat("Digest realm=\"{0}\", domain=\"{1}\", nonce=\"{2}\"", Parameters["realm"], text, Parameters["nonce"]);
			}
			else
			{
				stringBuilder.AppendFormat("Digest realm=\"{0}\", nonce=\"{1}\"", Parameters["realm"], Parameters["nonce"]);
			}
			string text2 = Parameters["opaque"];
			if (text2 != null)
			{
				stringBuilder.AppendFormat(", opaque=\"{0}\"", text2);
			}
			string text3 = Parameters["stale"];
			if (text3 != null)
			{
				stringBuilder.AppendFormat(", stale={0}", text3);
			}
			string text4 = Parameters["algorithm"];
			if (text4 != null)
			{
				stringBuilder.AppendFormat(", algorithm={0}", text4);
			}
			string text5 = Parameters["qop"];
			if (text5 != null)
			{
				stringBuilder.AppendFormat(", qop=\"{0}\"", text5);
			}
			return stringBuilder.ToString();
		}
	}
	internal class AuthenticationResponse : AuthenticationBase
	{
		private uint _nonceCount;

		internal uint NonceCount => (_nonceCount < uint.MaxValue) ? _nonceCount : 0u;

		public string Cnonce => Parameters["cnonce"];

		public string Nc => Parameters["nc"];

		public string Password => Parameters["password"];

		public string Response => Parameters["response"];

		public string Uri => Parameters["uri"];

		public string UserName => Parameters["username"];

		private AuthenticationResponse(AuthenticationSchemes scheme, NameValueCollection parameters)
			: base(scheme, parameters)
		{
		}

		internal AuthenticationResponse(NetworkCredential credentials)
			: this(AuthenticationSchemes.Basic, new NameValueCollection(), credentials, 0u)
		{
		}

		internal AuthenticationResponse(AuthenticationChallenge challenge, NetworkCredential credentials, uint nonceCount)
			: this(challenge.Scheme, challenge.Parameters, credentials, nonceCount)
		{
		}

		internal AuthenticationResponse(AuthenticationSchemes scheme, NameValueCollection parameters, NetworkCredential credentials, uint nonceCount)
			: base(scheme, parameters)
		{
			Parameters["username"] = credentials.UserName;
			Parameters["password"] = credentials.Password;
			Parameters["uri"] = credentials.Domain;
			_nonceCount = nonceCount;
			if (scheme == AuthenticationSchemes.Digest)
			{
				initAsDigest();
			}
		}

		private static string createA1(string username, string password, string realm)
		{
			return $"{username}:{realm}:{password}";
		}

		private static string createA1(string username, string password, string realm, string nonce, string cnonce)
		{
			return $"{hash(createA1(username, password, realm))}:{nonce}:{cnonce}";
		}

		private static string createA2(string method, string uri)
		{
			return $"{method}:{uri}";
		}

		private static string createA2(string method, string uri, string entity)
		{
			return $"{method}:{uri}:{hash(entity)}";
		}

		private static string hash(string value)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(value);
			MD5 mD = MD5.Create();
			byte[] array = mD.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder(64);
			byte[] array2 = array;
			foreach (byte b in array2)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
			return stringBuilder.ToString();
		}

		private void initAsDigest()
		{
			string text = Parameters["qop"];
			if (text != null)
			{
				if (text.Split(',').Contains((string qop) => qop.Trim().ToLower() == "auth"))
				{
					Parameters["qop"] = "auth";
					Parameters["cnonce"] = AuthenticationBase.CreateNonceValue();
					Parameters["nc"] = $"{++_nonceCount:x8}";
				}
				else
				{
					Parameters["qop"] = null;
				}
			}
			Parameters["method"] = "GET";
			Parameters["response"] = CreateRequestDigest(Parameters);
		}

		internal static string CreateRequestDigest(NameValueCollection parameters)
		{
			string username = parameters["username"];
			string password = parameters["password"];
			string realm = parameters["realm"];
			string text = parameters["nonce"];
			string uri = parameters["uri"];
			string text2 = parameters["algorithm"];
			string text3 = parameters["qop"];
			string text4 = parameters["cnonce"];
			string text5 = parameters["nc"];
			string method = parameters["method"];
			string value = ((text2 != null && text2.ToLower() == "md5-sess") ? createA1(username, password, realm, text, text4) : createA1(username, password, realm));
			string value2 = ((text3 != null && text3.ToLower() == "auth-int") ? createA2(method, uri, parameters["entity"]) : createA2(method, uri));
			string arg = hash(value);
			string arg2 = ((text3 != null) ? $"{text}:{text5}:{text4}:{text3}:{hash(value2)}" : $"{text}:{hash(value2)}");
			return hash($"{arg}:{arg2}");
		}

		internal static AuthenticationResponse Parse(string value)
		{
			try
			{
				string[] array = value.Split(new char[1] { ' ' }, 2);
				if (array.Length != 2)
				{
					return null;
				}
				string text = array[0].ToLower();
				return (text == "basic") ? new AuthenticationResponse(AuthenticationSchemes.Basic, ParseBasicCredentials(array[1])) : ((text == "digest") ? new AuthenticationResponse(AuthenticationSchemes.Digest, AuthenticationBase.ParseParameters(array[1])) : null);
			}
			catch
			{
			}
			return null;
		}

		internal static NameValueCollection ParseBasicCredentials(string value)
		{
			string text = Encoding.Default.GetString(Convert.FromBase64String(value));
			int num = text.IndexOf(':');
			string text2 = text.Substring(0, num);
			string value2 = ((num < text.Length - 1) ? text.Substring(num + 1) : string.Empty);
			num = text2.IndexOf('\\');
			if (num > -1)
			{
				text2 = text2.Substring(num + 1);
			}
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["username"] = text2;
			nameValueCollection["password"] = value2;
			return nameValueCollection;
		}

		internal override string ToBasicString()
		{
			string s = string.Format("{0}:{1}", Parameters["username"], Parameters["password"]);
			string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
			return "Basic " + text;
		}

		internal override string ToDigestString()
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			stringBuilder.AppendFormat("Digest username=\"{0}\", realm=\"{1}\", nonce=\"{2}\", uri=\"{3}\", response=\"{4}\"", Parameters["username"], Parameters["realm"], Parameters["nonce"], Parameters["uri"], Parameters["response"]);
			string text = Parameters["opaque"];
			if (text != null)
			{
				stringBuilder.AppendFormat(", opaque=\"{0}\"", text);
			}
			string text2 = Parameters["algorithm"];
			if (text2 != null)
			{
				stringBuilder.AppendFormat(", algorithm={0}", text2);
			}
			string text3 = Parameters["qop"];
			if (text3 != null)
			{
				stringBuilder.AppendFormat(", qop={0}, cnonce=\"{1}\", nc={2}", text3, Parameters["cnonce"], Parameters["nc"]);
			}
			return stringBuilder.ToString();
		}

		public IIdentity ToIdentity()
		{
			AuthenticationSchemes scheme = base.Scheme;
			IIdentity result;
			if (scheme != AuthenticationSchemes.Basic)
			{
				IIdentity identity = ((scheme == AuthenticationSchemes.Digest) ? new HttpDigestIdentity(Parameters) : null);
				result = identity;
			}
			else
			{
				IIdentity identity = new HttpBasicIdentity(Parameters["username"], Parameters["password"]);
				result = identity;
			}
			return result;
		}
	}
	internal abstract class AuthenticationBase
	{
		private AuthenticationSchemes _scheme;

		internal NameValueCollection Parameters;

		public string Algorithm => Parameters["algorithm"];

		public string Nonce => Parameters["nonce"];

		public string Opaque => Parameters["opaque"];

		public string Qop => Parameters["qop"];

		public string Realm => Parameters["realm"];

		public AuthenticationSchemes Scheme => _scheme;

		protected AuthenticationBase(AuthenticationSchemes scheme, NameValueCollection parameters)
		{
			_scheme = scheme;
			Parameters = parameters;
		}

		internal static string CreateNonceValue()
		{
			byte[] array = new byte[16];
			Random random = new Random();
			random.NextBytes(array);
			StringBuilder stringBuilder = new StringBuilder(32);
			byte[] array2 = array;
			foreach (byte b in array2)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
			return stringBuilder.ToString();
		}

		internal static NameValueCollection ParseParameters(string value)
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			foreach (string item in value.SplitHeaderValue(','))
			{
				int num = item.IndexOf('=');
				string name = ((num > 0) ? item.Substring(0, num).Trim() : null);
				string val = ((num < 0) ? item.Trim().Trim('"') : ((num < item.Length - 1) ? item.Substring(num + 1).Trim().Trim('"') : string.Empty));
				nameValueCollection.Add(name, val);
			}
			return nameValueCollection;
		}

		internal abstract string ToBasicString();

		internal abstract string ToDigestString();

		public override string ToString()
		{
			return (_scheme == AuthenticationSchemes.Basic) ? ToBasicString() : ((_scheme == AuthenticationSchemes.Digest) ? ToDigestString() : string.Empty);
		}
	}
	internal sealed class HttpListenerPrefix
	{
		private string _host;

		private HttpListener _listener;

		private string _original;

		private string _path;

		private string _port;

		private string _prefix;

		private bool _secure;

		public string Host => _host;

		public bool IsSecure => _secure;

		public HttpListener Listener
		{
			get
			{
				return _listener;
			}
			set
			{
				_listener = value;
			}
		}

		public string Original => _original;

		public string Path => _path;

		public string Port => _port;

		internal HttpListenerPrefix(string uriPrefix)
		{
			_original = uriPrefix;
			parse(uriPrefix);
		}

		private void parse(string uriPrefix)
		{
			if (uriPrefix.StartsWith("https"))
			{
				_secure = true;
			}
			int length = uriPrefix.Length;
			int num = uriPrefix.IndexOf(':') + 3;
			int num2 = uriPrefix.IndexOf('/', num + 1, length - num - 1);
			int num3 = uriPrefix.LastIndexOf(':', num2 - 1, num2 - num - 1);
			if (uriPrefix[num2 - 1] != ']' && num3 > num)
			{
				_host = uriPrefix.Substring(num, num3 - num);
				_port = uriPrefix.Substring(num3 + 1, num2 - num3 - 1);
			}
			else
			{
				_host = uriPrefix.Substring(num, num2 - num);
				_port = (_secure ? "443" : "80");
			}
			_path = uriPrefix.Substring(num2);
			_prefix = string.Format("http{0}://{1}:{2}{3}", _secure ? "s" : "", _host, _port, _path);
		}

		public static void CheckPrefix(string uriPrefix)
		{
			if (uriPrefix == null)
			{
				throw new ArgumentNullException("uriPrefix");
			}
			int length = uriPrefix.Length;
			if (length == 0)
			{
				throw new ArgumentException("An empty string.", "uriPrefix");
			}
			if (!uriPrefix.StartsWith("http://") && !uriPrefix.StartsWith("https://"))
			{
				throw new ArgumentException("The scheme isn't 'http' or 'https'.", "uriPrefix");
			}
			int num = uriPrefix.IndexOf(':') + 3;
			if (num >= length)
			{
				throw new ArgumentException("No host is specified.", "uriPrefix");
			}
			if (uriPrefix[num] == ':')
			{
				throw new ArgumentException("No host is specified.", "uriPrefix");
			}
			int num2 = uriPrefix.IndexOf('/', num, length - num);
			if (num2 == num)
			{
				throw new ArgumentException("No host is specified.", "uriPrefix");
			}
			if (num2 == -1 || uriPrefix[length - 1] != '/')
			{
				throw new ArgumentException("Ends without '/'.", "uriPrefix");
			}
			if (uriPrefix[num2 - 1] == ':')
			{
				throw new ArgumentException("No port is specified.", "uriPrefix");
			}
			if (num2 == length - 2)
			{
				throw new ArgumentException("No path is specified.", "uriPrefix");
			}
		}

		public override bool Equals(object obj)
		{
			return obj is HttpListenerPrefix httpListenerPrefix && httpListenerPrefix._prefix == _prefix;
		}

		public override int GetHashCode()
		{
			return _prefix.GetHashCode();
		}

		public override string ToString()
		{
			return _prefix;
		}
	}
	public class ClientSslConfiguration : SslConfiguration
	{
		private X509CertificateCollection _certs;

		private string _host;

		public X509CertificateCollection ClientCertificates
		{
			get
			{
				return _certs;
			}
			set
			{
				_certs = value;
			}
		}

		public LocalCertificateSelectionCallback ClientCertificateSelectionCallback
		{
			get
			{
				return base.CertificateSelectionCallback;
			}
			set
			{
				base.CertificateSelectionCallback = value;
			}
		}

		public RemoteCertificateValidationCallback ServerCertificateValidationCallback
		{
			get
			{
				return base.CertificateValidationCallback;
			}
			set
			{
				base.CertificateValidationCallback = value;
			}
		}

		public string TargetHost
		{
			get
			{
				return _host;
			}
			set
			{
				_host = value;
			}
		}

		public ClientSslConfiguration(string targetHost)
			: this(targetHost, null, SslProtocols.Default, checkCertificateRevocation: false)
		{
		}

		public ClientSslConfiguration(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
			: base(enabledSslProtocols, checkCertificateRevocation)
		{
			_host = targetHost;
			_certs = clientCertificates;
		}
	}
	public class ServerSslConfiguration : SslConfiguration
	{
		private X509Certificate2 _cert;

		private bool _clientCertRequired;

		public bool ClientCertificateRequired
		{
			get
			{
				return _clientCertRequired;
			}
			set
			{
				_clientCertRequired = value;
			}
		}

		public RemoteCertificateValidationCallback ClientCertificateValidationCallback
		{
			get
			{
				return base.CertificateValidationCallback;
			}
			set
			{
				base.CertificateValidationCallback = value;
			}
		}

		public X509Certificate2 ServerCertificate
		{
			get
			{
				return _cert;
			}
			set
			{
				_cert = value;
			}
		}

		public ServerSslConfiguration(X509Certificate2 serverCertificate)
			: this(serverCertificate, clientCertificateRequired: false, SslProtocols.Default, checkCertificateRevocation: false)
		{
		}

		public ServerSslConfiguration(X509Certificate2 serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
			: base(enabledSslProtocols, checkCertificateRevocation)
		{
			_cert = serverCertificate;
			_clientCertRequired = clientCertificateRequired;
		}
	}
	public abstract class SslConfiguration
	{
		private LocalCertificateSelectionCallback _certSelectionCallback;

		private RemoteCertificateValidationCallback _certValidationCallback;

		private bool _checkCertRevocation;

		private SslProtocols _enabledProtocols;

		protected LocalCertificateSelectionCallback CertificateSelectionCallback
		{
			get
			{
				return (object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) => (X509Certificate)null;
			}
			set
			{
				_certSelectionCallback = value;
			}
		}

		protected RemoteCertificateValidationCallback CertificateValidationCallback
		{
			get
			{
				return (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;
			}
			set
			{
				_certValidationCallback = value;
			}
		}

		public bool CheckCertificateRevocation
		{
			get
			{
				return _checkCertRevocation;
			}
			set
			{
				_checkCertRevocation = value;
			}
		}

		public SslProtocols EnabledSslProtocols
		{
			get
			{
				return _enabledProtocols;
			}
			set
			{
				_enabledProtocols = value;
			}
		}

		protected SslConfiguration(SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			_enabledProtocols = enabledSslProtocols;
			_checkCertRevocation = checkCertificateRevocation;
		}
	}
	internal class HttpListenerAsyncResult : IAsyncResult
	{
		private AsyncCallback _callback;

		private bool _completed;

		private HttpListenerContext _context;

		private bool _endCalled;

		private Exception _exception;

		private bool _inGet;

		private object _state;

		private object _sync;

		private bool _syncCompleted;

		private ManualResetEvent _waitHandle;

		internal bool EndCalled
		{
			get
			{
				return _endCalled;
			}
			set
			{
				_endCalled = value;
			}
		}

		internal bool InGet
		{
			get
			{
				return _inGet;
			}
			set
			{
				_inGet = value;
			}
		}

		public object AsyncState => _state;

		public WaitHandle AsyncWaitHandle
		{
			get
			{
				lock (_sync)
				{
					return _waitHandle ?? (_waitHandle = new ManualResetEvent(_completed));
				}
			}
		}

		public bool CompletedSynchronously => _syncCompleted;

		public bool IsCompleted
		{
			get
			{
				lock (_sync)
				{
					return _completed;
				}
			}
		}

		internal HttpListenerAsyncResult(AsyncCallback callback, object state)
		{
			_callback = callback;
			_state = state;
			_sync = new object();
		}

		private static void complete(HttpListenerAsyncResult asyncResult)
		{
			lock (asyncResult._sync)
			{
				asyncResult._completed = true;
				asyncResult._waitHandle?.Set();
			}
			AsyncCallback callback = asyncResult._callback;
			if (callback == null)
			{
				return;
			}
			ThreadPool.QueueUserWorkItem(delegate
			{
				try
				{
					callback(asyncResult);
				}
				catch
				{
				}
			}, null);
		}

		internal void Complete(Exception exception)
		{
			_exception = ((_inGet && exception is ObjectDisposedException) ? new HttpListenerException(995, "The listener is closed.") : exception);
			complete(this);
		}

		internal void Complete(HttpListenerContext context)
		{
			Complete(context, syncCompleted: false);
		}

		internal void Complete(HttpListenerContext context, bool syncCompleted)
		{
			_context = context;
			_syncCompleted = syncCompleted;
			complete(this);
		}

		internal HttpListenerContext GetContext()
		{
			if (_exception != null)
			{
				throw _exception;
			}
			return _context;
		}
	}
	public enum HttpRequestHeader
	{
		CacheControl,
		Connection,
		Date,
		KeepAlive,
		Pragma,
		Trailer,
		TransferEncoding,
		Upgrade,
		Via,
		Warning,
		Allow,
		ContentLength,
		ContentType,
		ContentEncoding,
		ContentLanguage,
		ContentLocation,
		ContentMd5,
		ContentRange,
		Expires,
		LastModified,
		Accept,
		AcceptCharset,
		AcceptEncoding,
		AcceptLanguage,
		Authorization,
		Cookie,
		Expect,
		From,
		Host,
		IfMatch,
		IfModifiedSince,
		IfNoneMatch,
		IfRange,
		IfUnmodifiedSince,
		MaxForwards,
		ProxyAuthorization,
		Referer,
		Range,
		Te,
		Translate,
		UserAgent,
		SecWebSocketKey,
		SecWebSocketExtensions,
		SecWebSocketProtocol,
		SecWebSocketVersion
	}
	public enum HttpResponseHeader
	{
		CacheControl,
		Connection,
		Date,
		KeepAlive,
		Pragma,
		Trailer,
		TransferEncoding,
		Upgrade,
		Via,
		Warning,
		Allow,
		ContentLength,
		ContentType,
		ContentEncoding,
		ContentLanguage,
		ContentLocation,
		ContentMd5,
		ContentRange,
		Expires,
		LastModified,
		AcceptRanges,
		Age,
		ETag,
		Location,
		ProxyAuthenticate,
		RetryAfter,
		Server,
		SetCookie,
		Vary,
		WwwAuthenticate,
		SecWebSocketExtensions,
		SecWebSocketAccept,
		SecWebSocketProtocol,
		SecWebSocketVersion
	}
}
namespace WebSocketSharp.Net.WebSockets
{
	public class HttpListenerWebSocketContext : WebSocketContext
	{
		private HttpListenerContext _context;

		private WebSocket _websocket;

		internal Logger Log => _context.Listener.Log;

		internal Stream Stream => _context.Connection.Stream;

		public override CookieCollection CookieCollection => _context.Request.Cookies;

		public override NameValueCollection Headers => _context.Request.Headers;

		public override string Host => _context.Request.Headers["Host"];

		public override bool IsAuthenticated => _context.User != null;

		public override bool IsLocal => _context.Request.IsLocal;

		public override bool IsSecureConnection => _context.Connection.IsSecure;

		public override bool IsWebSocketRequest => _context.Request.IsWebSocketRequest;

		public override string Origin => _context.Request.Headers["Origin"];

		public override NameValueCollection QueryString => _context.Request.QueryString;

		public override Uri RequestUri => _context.Request.Url;

		public override string SecWebSocketKey => _context.Request.Headers["Sec-WebSocket-Key"];

		public override IEnumerable<string> SecWebSocketProtocols
		{
			get
			{
				string protocols = _context.Request.Headers["Sec-WebSocket-Protocol"];
				if (protocols != null)
				{
					string[] array = protocols.Split(',');
					foreach (string protocol in array)
					{
						yield return protocol.Trim();
					}
				}
			}
		}

		public override string SecWebSocketVersion => _context.Request.Headers["Sec-WebSocket-Version"];

		public override IPEndPoint ServerEndPoint => _context.Connection.LocalEndPoint;

		public override IPrincipal User => _context.User;

		public override IPEndPoint UserEndPoint => _context.Connection.RemoteEndPoint;

		public override WebSocket WebSocket => _websocket;

		internal HttpListenerWebSocketContext(HttpListenerContext context, string protocol)
		{
			_context = context;
			_websocket = new WebSocket(this, protocol);
		}

		internal void Close()
		{
			_context.Connection.Close(force: true);
		}

		internal void Close(HttpStatusCode code)
		{
			_context.Response.Close(code);
		}

		public override string ToString()
		{
			return _context.Request.ToString();
		}
	}
	internal class TcpListenerWebSocketContext : WebSocketContext
	{
		private CookieCollection _cookies;

		private Logger _logger;

		private NameValueCollection _queryString;

		private HttpRequest _request;

		private bool _secure;

		private Stream _stream;

		private TcpClient _tcpClient;

		private Uri _uri;

		private IPrincipal _user;

		private WebSocket _websocket;

		internal Logger Log => _logger;

		internal Stream Stream => _stream;

		public override CookieCollection CookieCollection => _cookies ?? (_cookies = _request.Cookies);

		public override NameValueCollection Headers => _request.Headers;

		public override string Host => _request.Headers["Host"];

		public override bool IsAuthenticated => _user != null;

		public override bool IsLocal => UserEndPoint.Address.IsLocal();

		public override bool IsSecureConnection => _secure;

		public override bool IsWebSocketRequest => _request.IsWebSocketRequest;

		public override string Origin => _request.Headers["Origin"];

		public override NameValueCollection QueryString => _queryString ?? (_queryString = HttpUtility.InternalParseQueryString((_uri != null) ? _uri.Query : null, Encoding.UTF8));

		public override Uri RequestUri => _uri;

		public override string SecWebSocketKey => _request.Headers["Sec-WebSocket-Key"];

		public override IEnumerable<string> SecWebSocketProtocols
		{
			get
			{
				string protocols = _request.Headers["Sec-WebSocket-Protocol"];
				if (protocols != null)
				{
					string[] array = protocols.Split(',');
					foreach (string protocol in array)
					{
						yield return protocol.Trim();
					}
				}
			}
		}

		public override string SecWebSocketVersion => _request.Headers["Sec-WebSocket-Version"];

		public override IPEndPoint ServerEndPoint => (IPEndPoint)_tcpClient.Client.LocalEndPoint;

		public override IPrincipal User => _user;

		public override IPEndPoint UserEndPoint => (IPEndPoint)_tcpClient.Client.RemoteEndPoint;

		public override WebSocket WebSocket => _websocket;

		internal TcpListenerWebSocketContext(TcpClient tcpClient, string protocol, bool secure, ServerSslConfiguration sslConfig, Logger logger)
		{
			_tcpClient = tcpClient;
			_secure = secure;
			_logger = logger;
			NetworkStream stream = tcpClient.GetStream();
			if (secure)
			{
				SslStream sslStream = new SslStream(stream, leaveStreamOpen: false, sslConfig.ClientCertificateValidationCallback);
				sslStream.AuthenticateAsServer(sslConfig.ServerCertificate, sslConfig.ClientCertificateRequired, sslConfig.EnabledSslProtocols, sslConfig.CheckCertificateRevocation);
				_stream = sslStream;
			}
			else
			{
				_stream = stream;
			}
			_request = HttpRequest.Read(_stream, 90000);
			_uri = HttpUtility.CreateRequestUrl(_request.RequestUri, _request.Headers["Host"], _request.IsWebSocketRequest, secure);
			_websocket = new WebSocket(this, protocol);
		}

		internal bool Authenticate(AuthenticationSchemes scheme, string realm, Func<IIdentity, NetworkCredential> credentialsFinder)
		{
			if (scheme == AuthenticationSchemes.Anonymous)
			{
				return true;
			}
			if (scheme == AuthenticationSchemes.None)
			{
				Close(HttpStatusCode.Forbidden);
				return false;
			}
			string chal = new AuthenticationChallenge(scheme, realm).ToString();
			int retry = -1;
			Func<bool> auth = null;
			auth = delegate
			{
				retry++;
				if (retry > 99)
				{
					Close(HttpStatusCode.Forbidden);
					return false;
				}
				IPrincipal principal = HttpUtility.CreateUser(_request.Headers["Authorization"], scheme, realm, _request.HttpMethod, credentialsFinder);
				if (principal == null || !principal.Identity.IsAuthenticated)
				{
					SendAuthenticationChallenge(chal);
					return auth();
				}
				_user = principal;
				return true;
			};
			return auth();
		}

		internal void Close()
		{
			_stream.Close();
			_tcpClient.Close();
		}

		internal void Close(HttpStatusCode code)
		{
			_websocket.Close(HttpResponse.CreateCloseResponse(code));
		}

		internal void SendAuthenticationChallenge(string challenge)
		{
			byte[] array = HttpResponse.CreateUnauthorizedResponse(challenge).ToByteArray();
			_stream.Write(array, 0, array.Length);
			_request = HttpRequest.Read(_stream, 15000);
		}

		public override string ToString()
		{
			return _request.ToString();
		}
	}
	public abstract class WebSocketContext
	{
		public abstract CookieCollection CookieCollection { get; }

		public abstract NameValueCollection Headers { get; }

		public abstract string Host { get; }

		public abstract bool IsAuthenticated { get; }

		public abstract bool IsLocal { get; }

		public abstract bool IsSecureConnection { get; }

		public abstract bool IsWebSocketRequest { get; }

		public abstract string Origin { get; }

		public abstract NameValueCollection QueryString { get; }

		public abstract Uri RequestUri { get; }

		public abstract string SecWebSocketKey { get; }

		public abstract IEnumerable<string> SecWebSocketProtocols { get; }

		public abstract string SecWebSocketVersion { get; }

		public abstract IPEndPoint ServerEndPoint { get; }

		public abstract IPrincipal User { get; }

		public abstract IPEndPoint UserEndPoint { get; }

		public abstract WebSocket WebSocket { get; }
	}
}
namespace WebSocketSharp.Server
{
	public class WebSocketServer
	{
		private IPAddress _address;

		private WebSocketSharp.Net.AuthenticationSchemes _authSchemes;

		private static readonly string _defaultRealm;

		private bool _dnsStyle;

		private string _hostname;

		private TcpListener _listener;

		private Logger _logger;

		private int _port;

		private string _realm;

		private Thread _receiveThread;

		private bool _reuseAddress;

		private bool _secure;

		private WebSocketServiceManager _services;

		private ServerSslConfiguration _sslConfig;

		private volatile ServerState _state;

		private object _sync;

		private Func<IIdentity, WebSocketSharp.Net.NetworkCredential> _userCredFinder;

		public IPAddress Address => _address;

		public WebSocketSharp.Net.AuthenticationSchemes AuthenticationSchemes
		{
			get
			{
				return _authSchemes;
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_authSchemes = value;
				}
			}
		}

		public bool IsListening => _state == ServerState.Start;

		public bool IsSecure => _secure;

		public bool KeepClean
		{
			get
			{
				return _services.KeepClean;
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_services.KeepClean = value;
				}
			}
		}

		public Logger Log => _logger;

		public int Port => _port;

		public string Realm
		{
			get
			{
				return _realm;
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_realm = value;
				}
			}
		}

		public bool ReuseAddress
		{
			get
			{
				return _reuseAddress;
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_reuseAddress = value;
				}
			}
		}

		public ServerSslConfiguration SslConfiguration
		{
			get
			{
				return _sslConfig ?? (_sslConfig = new ServerSslConfiguration(null));
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_sslConfig = value;
				}
			}
		}

		public Func<IIdentity, WebSocketSharp.Net.NetworkCredential> UserCredentialsFinder
		{
			get
			{
				return _userCredFinder;
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_userCredFinder = value;
				}
			}
		}

		public TimeSpan WaitTime
		{
			get
			{
				return _services.WaitTime;
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false) ?? value.CheckIfValidWaitTime();
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_services.WaitTime = value;
				}
			}
		}

		public WebSocketServiceManager WebSocketServices => _services;

		static WebSocketServer()
		{
			_defaultRealm = "SECRET AREA";
		}

		public WebSocketServer()
		{
			init(null, IPAddress.Any, 80, secure: false);
		}

		public WebSocketServer(int port)
			: this(port, port == 443)
		{
		}

		public WebSocketServer(string url)
		{
			if (url == null)
			{
				throw new ArgumentNullException("url");
			}
			if (url.Length == 0)
			{
				throw new ArgumentException("An empty string.", "url");
			}
			if (!tryCreateUri(url, out var result, out var message))
			{
				throw new ArgumentException(message, "url");
			}
			string dnsSafeHost = result.DnsSafeHost;
			IPAddress address = dnsSafeHost.ToIPAddress();
			if (!address.IsLocal())
			{
				throw new ArgumentException("The host part isn't a local host name: " + url, "url");
			}
			init(dnsSafeHost, address, result.Port, result.Scheme == "wss");
		}

		public WebSocketServer(int port, bool secure)
		{
			if (!port.IsPortNumber())
			{
				throw new ArgumentOutOfRangeException("port", "Not between 1 and 65535 inclusive: " + port);
			}
			init(null, IPAddress.Any, port, secure);
		}

		public WebSocketServer(IPAddress address, int port)
			: this(address, port, port == 443)
		{
		}

		public WebSocketServer(IPAddress address, int port, bool secure)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (!address.IsLocal())
			{
				throw new ArgumentException("Not a local IP address: " + address, "address");
			}
			if (!port.IsPortNumber())
			{
				throw new ArgumentOutOfRangeException("port", "Not between 1 and 65535 inclusive: " + port);
			}
			init(null, address, port, secure);
		}

		private void abort()
		{
			lock (_sync)
			{
				if (!IsListening)
				{
					return;
				}
				_state = ServerState.ShuttingDown;
			}
			_listener.Stop();
			_services.Stop(new CloseEventArgs(CloseStatusCode.ServerError), send: true, receive: false);
			_state = ServerState.Stop;
		}

		private string checkIfCertificateExists()
		{
			return (_secure && (_sslConfig == null || _sslConfig.ServerCertificate == null)) ? "The secure connection requires a server certificate." : null;
		}

		private string getRealm()
		{
			string realm = _realm;
			return (realm != null && realm.Length > 0) ? realm : _defaultRealm;
		}

		private void init(string hostname, IPAddress address, int port, bool secure)
		{
			_hostname = hostname ?? address.ToString();
			_address = address;
			_port = port;
			_secure = secure;
			_authSchemes = WebSocketSharp.Net.AuthenticationSchemes.Anonymous;
			_dnsStyle = Uri.CheckHostName(hostname) == UriHostNameType.Dns;
			_listener = new TcpListener(address, port);
			_logger = new Logger();
			_services = new WebSocketServiceManager(_logger);
			_sync = new object();
		}

		private void processRequest(TcpListenerWebSocketContext context)
		{
			Uri requestUri = context.RequestUri;
			if (requestUri == null || requestUri.Port != _port)
			{
				context.Close(WebSocketSharp.Net.HttpStatusCode.BadRequest);
				return;
			}
			if (_dnsStyle)
			{
				string dnsSafeHost = requestUri.DnsSafeHost;
				if (Uri.CheckHostName(dnsSafeHost) == UriHostNameType.Dns && dnsSafeHost != _hostname)
				{
					context.Close(WebSocketSharp.Net.HttpStatusCode.NotFound);
					return;
				}
			}
			if (!_services.InternalTryGetServiceHost(requestUri.AbsolutePath, out var host))
			{
				context.Close(WebSocketSharp.Net.HttpStatusCode.NotImplemented);
			}
			else
			{
				host.StartSession(context);
			}
		}

		private void receiveRequest()
		{
			while (true)
			{
				try
				{
					TcpClient cl = _listener.AcceptTcpClient();
					ThreadPool.QueueUserWorkItem(delegate
					{
						try
						{
							TcpListenerWebSocketContext webSocketContext = cl.GetWebSocketContext(null, _secure, _sslConfig, _logger);
							if (webSocketContext.Authenticate(_authSchemes, getRealm(), _userCredFinder))
							{
								processRequest(webSocketContext);
							}
						}
						catch (Exception ex3)
						{
							_logger.Fatal(ex3.ToString());
							cl.Close();
						}
					});
				}
				catch (SocketException ex)
				{
					_logger.Warn("Receiving has been stopped.\n  reason: " + ex.Message);
					break;
				}
				catch (Exception ex2)
				{
					_logger.Fatal(ex2.ToString());
					break;
				}
			}
			if (IsListening)
			{
				abort();
			}
		}

		private void startReceiving()
		{
			if (_reuseAddress)
			{
				_listener.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, optionValue: true);
			}
			_listener.Start();
			_receiveThread = new Thread(receiveRequest);
			_receiveThread.IsBackground = true;
			_receiveThread.Start();
		}

		private void stopReceiving(int millisecondsTimeout)
		{
			_listener.Stop();
			_receiveThread.Join(millisecondsTimeout);
		}

		private static bool tryCreateUri(string uriString, out Uri result, out string message)
		{
			if (!uriString.TryCreateWebSocketUri(out result, out message))
			{
				return false;
			}
			if (result.PathAndQuery != "/")
			{
				result = null;
				message = "Includes the path or query component: " + uriString;
				return false;
			}
			return true;
		}

		public void AddWebSocketService<TBehavior>(string path, Func<TBehavior> initializer) where TBehavior : WebSocketBehavior
		{
			string text = path.CheckIfValidServicePath() ?? ((initializer == null) ? "'initializer' is null." : null);
			if (text != null)
			{
				_logger.Error(text);
			}
			else
			{
				_services.Add(path, initializer);
			}
		}

		public void AddWebSocketService<TBehaviorWithNew>(string path) where TBehaviorWithNew : WebSocketBehavior, new()
		{
			AddWebSocketService(path, () => new TBehaviorWithNew());
		}

		public bool RemoveWebSocketService(string path)
		{
			string text = path.CheckIfValidServicePath();
			if (text != null)
			{
				_logger.Error(text);
				return false;
			}
			return _services.Remove(path);
		}

		public void Start()
		{
			lock (_sync)
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false) ?? checkIfCertificateExists();
				if (text != null)
				{
					_logger.Error(text);
					return;
				}
				_services.Start();
				startReceiving();
				_state = ServerState.Start;
			}
		}

		public void Stop()
		{
			lock (_sync)
			{
				string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
					return;
				}
				_state = ServerState.ShuttingDown;
			}
			stopReceiving(5000);
			_services.Stop(new CloseEventArgs(), send: true, receive: true);
			_state = ServerState.Stop;
		}

		public void Stop(ushort code, string reason)
		{
			lock (_sync)
			{
				string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckCloseParameters(code, reason, client: false);
				if (text != null)
				{
					_logger.Error(text);
					return;
				}
				_state = ServerState.ShuttingDown;
			}
			stopReceiving(5000);
			if (code == 1005)
			{
				_services.Stop(new CloseEventArgs(), send: true, receive: true);
			}
			else
			{
				bool flag = !code.IsReserved();
				_services.Stop(new CloseEventArgs(code, reason), flag, flag);
			}
			_state = ServerState.Stop;
		}

		public void Stop(CloseStatusCode code, string reason)
		{
			lock (_sync)
			{
				string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckCloseParameters(code, reason, client: false);
				if (text != null)
				{
					_logger.Error(text);
					return;
				}
				_state = ServerState.ShuttingDown;
			}
			stopReceiving(5000);
			if (code == CloseStatusCode.NoStatus)
			{
				_services.Stop(new CloseEventArgs(), send: true, receive: true);
			}
			else
			{
				bool flag = !code.IsReserved();
				_services.Stop(new CloseEventArgs(code, reason), flag, flag);
			}
			_state = ServerState.Stop;
		}
	}
	public class HttpServer
	{
		private IPAddress _address;

		private string _hostname;

		private WebSocketSharp.Net.HttpListener _listener;

		private Logger _logger;

		private int _port;

		private Thread _receiveThread;

		private string _rootPath;

		private bool _secure;

		private WebSocketServiceManager _services;

		private volatile ServerState _state;

		private object _sync;

		private bool _windows;

		public IPAddress Address => _address;

		public WebSocketSharp.Net.AuthenticationSchemes AuthenticationSchemes
		{
			get
			{
				return _listener.AuthenticationSchemes;
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_listener.AuthenticationSchemes = value;
				}
			}
		}

		public bool IsListening => _state == ServerState.Start;

		public bool IsSecure => _secure;

		public bool KeepClean
		{
			get
			{
				return _services.KeepClean;
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_services.KeepClean = value;
				}
			}
		}

		public Logger Log => _logger;

		public int Port => _port;

		public string Realm
		{
			get
			{
				return _listener.Realm;
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_listener.Realm = value;
				}
			}
		}

		public bool ReuseAddress
		{
			get
			{
				return _listener.ReuseAddress;
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_listener.ReuseAddress = value;
				}
			}
		}

		public string RootPath
		{
			get
			{
				return (_rootPath != null && _rootPath.Length > 0) ? _rootPath : (_rootPath = "./Public");
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_rootPath = value;
				}
			}
		}

		public ServerSslConfiguration SslConfiguration
		{
			get
			{
				return _listener.SslConfiguration;
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_listener.SslConfiguration = value;
				}
			}
		}

		public Func<IIdentity, WebSocketSharp.Net.NetworkCredential> UserCredentialsFinder
		{
			get
			{
				return _listener.UserCredentialsFinder;
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_listener.UserCredentialsFinder = value;
				}
			}
		}

		public TimeSpan WaitTime
		{
			get
			{
				return _services.WaitTime;
			}
			set
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false) ?? value.CheckIfValidWaitTime();
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_services.WaitTime = value;
				}
			}
		}

		public WebSocketServiceManager WebSocketServices => _services;

		public event EventHandler<HttpRequestEventArgs> OnConnect;

		public event EventHandler<HttpRequestEventArgs> OnDelete;

		public event EventHandler<HttpRequestEventArgs> OnGet;

		public event EventHandler<HttpRequestEventArgs> OnHead;

		public event EventHandler<HttpRequestEventArgs> OnOptions;

		public event EventHandler<HttpRequestEventArgs> OnPatch;

		public event EventHandler<HttpRequestEventArgs> OnPost;

		public event EventHandler<HttpRequestEventArgs> OnPut;

		public event EventHandler<HttpRequestEventArgs> OnTrace;

		public HttpServer()
		{
			init("*", IPAddress.Any, 80, secure: false);
		}

		public HttpServer(int port)
			: this(port, port == 443)
		{
		}

		public HttpServer(string url)
		{
			if (url == null)
			{
				throw new ArgumentNullException("url");
			}
			if (url.Length == 0)
			{
				throw new ArgumentException("An empty string.", "url");
			}
			if (!tryCreateUri(url, out var result, out var message))
			{
				throw new ArgumentException(message, "url");
			}
			string host = getHost(result);
			IPAddress address = host.ToIPAddress();
			if (!address.IsLocal())
			{
				throw new ArgumentException("The host part isn't a local host name: " + url, "url");
			}
			init(host, address, result.Port, result.Scheme == "https");
		}

		public HttpServer(int port, bool secure)
		{
			if (!port.IsPortNumber())
			{
				throw new ArgumentOutOfRangeException("port", "Not between 1 and 65535 inclusive: " + port);
			}
			init("*", IPAddress.Any, port, secure);
		}

		public HttpServer(IPAddress address, int port)
			: this(address, port, port == 443)
		{
		}

		public HttpServer(IPAddress address, int port, bool secure)
		{
			if (address == null)
			{
				throw new ArgumentNullException("address");
			}
			if (!address.IsLocal())
			{
				throw new ArgumentException("Not a local IP address: " + address, "address");
			}
			if (!port.IsPortNumber())
			{
				throw new ArgumentOutOfRangeException("port", "Not between 1 and 65535 inclusive: " + port);
			}
			init(null, address, port, secure);
		}

		private void abort()
		{
			lock (_sync)
			{
				if (!IsListening)
				{
					return;
				}
				_state = ServerState.ShuttingDown;
			}
			_services.Stop(new CloseEventArgs(CloseStatusCode.ServerError), send: true, receive: false);
			_listener.Abort();
			_state = ServerState.Stop;
		}

		private string checkIfCertificateExists()
		{
			if (!_secure)
			{
				return null;
			}
			bool flag = _listener.SslConfiguration.ServerCertificate != null;
			bool flag2 = EndPointListener.CertificateExists(_port, _listener.CertificateFolderPath);
			if (flag && flag2)
			{
				_logger.Warn("The server certificate associated with the port number already exists.");
				return null;
			}
			return (!(flag || flag2)) ? "The secure connection requires a server certificate." : null;
		}

		private static string convertToString(IPAddress address)
		{
			return (address.AddressFamily == AddressFamily.InterNetworkV6) ? $"[{address.ToString()}]" : address.ToString();
		}

		private static string getHost(Uri uri)
		{
			return (uri.HostNameType == UriHostNameType.IPv6) ? uri.Host : uri.DnsSafeHost;
		}

		private void init(string hostname, IPAddress address, int port, bool secure)
		{
			_hostname = hostname ?? convertToString(address);
			_address = address;
			_port = port;
			_secure = secure;
			_listener = new WebSocketSharp.Net.HttpListener();
			_listener.Prefixes.Add(string.Format("http{0}://{1}:{2}/", secure ? "s" : "", _hostname, port));
			_logger = _listener.Log;
			_services = new WebSocketServiceManager(_logger);
			_sync = new object();
			OperatingSystem oSVersion = Environment.OSVersion;
			_windows = oSVersion.Platform != PlatformID.Unix && oSVersion.Platform != PlatformID.MacOSX;
		}

		private void processRequest(WebSocketSharp.Net.HttpListenerContext context)
		{
			EventHandler<HttpRequestEventArgs> eventHandler = context.Request.HttpMethod switch
			{
				"PATCH" => this.OnPatch, 
				"CONNECT" => this.OnConnect, 
				"TRACE" => this.OnTrace, 
				"OPTIONS" => this.OnOptions, 
				"DELETE" => this.OnDelete, 
				"PUT" => this.OnPut, 
				"POST" => this.OnPost, 
				"HEAD" => this.OnHead, 
				"GET" => this.OnGet, 
				_ => null, 
			};
			if (eventHandler != null)
			{
				eventHandler(this, new HttpRequestEventArgs(context));
			}
			else
			{
				context.Response.StatusCode = 501;
			}
			context.Response.Close();
		}

		private void processRequest(HttpListenerWebSocketContext context)
		{
			if (!_services.InternalTryGetServiceHost(context.RequestUri.AbsolutePath, out var host))
			{
				context.Close(WebSocketSharp.Net.HttpStatusCode.NotImplemented);
			}
			else
			{
				host.StartSession(context);
			}
		}

		private void receiveRequest()
		{
			while (true)
			{
				try
				{
					WebSocketSharp.Net.HttpListenerContext ctx = _listener.GetContext();
					ThreadPool.QueueUserWorkItem(delegate
					{
						try
						{
							if (ctx.Request.IsUpgradeTo("websocket"))
							{
								processRequest(ctx.AcceptWebSocket(null));
							}
							else
							{
								processRequest(ctx);
							}
						}
						catch (Exception ex3)
						{
							_logger.Fatal(ex3.ToString());
							ctx.Connection.Close(force: true);
						}
					});
				}
				catch (WebSocketSharp.Net.HttpListenerException ex)
				{
					_logger.Warn("Receiving has been stopped.\n  reason: " + ex.Message);
					break;
				}
				catch (Exception ex2)
				{
					_logger.Fatal(ex2.ToString());
					break;
				}
			}
			if (IsListening)
			{
				abort();
			}
		}

		private void startReceiving()
		{
			_listener.Start();
			_receiveThread = new Thread(receiveRequest);
			_receiveThread.IsBackground = true;
			_receiveThread.Start();
		}

		private void stopReceiving(int millisecondsTimeout)
		{
			_listener.Close();
			_receiveThread.Join(millisecondsTimeout);
		}

		private static bool tryCreateUri(string uriString, out Uri result, out string message)
		{
			result = null;
			Uri uri = uriString.ToUri();
			if (uri == null)
			{
				message = "An invalid URI string: " + uriString;
				return false;
			}
			if (!uri.IsAbsoluteUri)
			{
				message = "Not an absolute URI: " + uriString;
				return false;
			}
			string scheme = uri.Scheme;
			if (!(scheme == "http") && !(scheme == "https"))
			{
				message = "The scheme part isn't 'http' or 'https': " + uriString;
				return false;
			}
			if (uri.PathAndQuery != "/")
			{
				message = "Includes the path or query component: " + uriString;
				return false;
			}
			if (uri.Fragment.Length > 0)
			{
				message = "Includes the fragment component: " + uriString;
				return false;
			}
			if (uri.Port == 0)
			{
				message = "The port part is zero: " + uriString;
				return false;
			}
			result = uri;
			message = string.Empty;
			return true;
		}

		public void AddWebSocketService<TBehavior>(string path, Func<TBehavior> initializer) where TBehavior : WebSocketBehavior
		{
			string text = path.CheckIfValidServicePath() ?? ((initializer == null) ? "'initializer' is null." : null);
			if (text != null)
			{
				_logger.Error(text);
			}
			else
			{
				_services.Add(path, initializer);
			}
		}

		public void AddWebSocketService<TBehaviorWithNew>(string path) where TBehaviorWithNew : WebSocketBehavior, new()
		{
			AddWebSocketService(path, () => new TBehaviorWithNew());
		}

		public byte[] GetFile(string path)
		{
			path = RootPath + path;
			if (_windows)
			{
				path = path.Replace("/", "\\");
			}
			return File.Exists(path) ? File.ReadAllBytes(path) : null;
		}

		public bool RemoveWebSocketService(string path)
		{
			string text = path.CheckIfValidServicePath();
			if (text != null)
			{
				_logger.Error(text);
				return false;
			}
			return _services.Remove(path);
		}

		public void Start()
		{
			lock (_sync)
			{
				string text = _state.CheckIfAvailable(ready: true, start: false, shutting: false) ?? checkIfCertificateExists();
				if (text != null)
				{
					_logger.Error(text);
					return;
				}
				_services.Start();
				startReceiving();
				_state = ServerState.Start;
			}
		}

		public void Stop()
		{
			lock (_sync)
			{
				string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
					return;
				}
				_state = ServerState.ShuttingDown;
			}
			_services.Stop(new CloseEventArgs(), send: true, receive: true);
			stopReceiving(5000);
			_state = ServerState.Stop;
		}

		public void Stop(ushort code, string reason)
		{
			lock (_sync)
			{
				string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckCloseParameters(code, reason, client: false);
				if (text != null)
				{
					_logger.Error(text);
					return;
				}
				_state = ServerState.ShuttingDown;
			}
			if (code == 1005)
			{
				_services.Stop(new CloseEventArgs(), send: true, receive: true);
			}
			else
			{
				bool flag = !code.IsReserved();
				_services.Stop(new CloseEventArgs(code, reason), flag, flag);
			}
			stopReceiving(5000);
			_state = ServerState.Stop;
		}

		public void Stop(CloseStatusCode code, string reason)
		{
			lock (_sync)
			{
				string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckCloseParameters(code, reason, client: false);
				if (text != null)
				{
					_logger.Error(text);
					return;
				}
				_state = ServerState.ShuttingDown;
			}
			if (code == CloseStatusCode.NoStatus)
			{
				_services.Stop(new CloseEventArgs(), send: true, receive: true);
			}
			else
			{
				bool flag = !code.IsReserved();
				_services.Stop(new CloseEventArgs(code, reason), flag, flag);
			}
			stopReceiving(5000);
			_state = ServerState.Stop;
		}
	}
	public abstract class WebSocketServiceHost
	{
		internal ServerState State => Sessions.State;

		public abstract bool KeepClean { get; set; }

		public abstract string Path { get; }

		public abstract WebSocketSessionManager Sessions { get; }

		public abstract Type Type { get; }

		public abstract TimeSpan WaitTime { get; set; }

		internal void Start()
		{
			Sessions.Start();
		}

		internal void StartSession(WebSocketContext context)
		{
			CreateSession().Start(context, Sessions);
		}

		internal void Stop(ushort code, string reason)
		{
			CloseEventArgs e = new CloseEventArgs(code, reason);
			bool flag = !code.IsReserved();
			byte[] frameAsBytes = (flag ? WebSocketFrame.CreateCloseFrame(e.PayloadData, mask: false).ToArray() : null);
			Sessions.Stop(e, frameAsBytes, flag);
		}

		protected abstract WebSocketBehavior CreateSession();
	}
	public class HttpRequestEventArgs : EventArgs
	{
		private WebSocketSharp.Net.HttpListenerRequest _request;

		private WebSocketSharp.Net.HttpListenerResponse _response;

		public WebSocketSharp.Net.HttpListenerRequest Request => _request;

		public WebSocketSharp.Net.HttpListenerResponse Response => _response;

		internal HttpRequestEventArgs(WebSocketSharp.Net.HttpListenerContext context)
		{
			_request = context.Request;
			_response = context.Response;
		}
	}
	public interface IWebSocketSession
	{
		WebSocketContext Context { get; }

		string ID { get; }

		string Protocol { get; }

		DateTime StartTime { get; }

		WebSocketState State { get; }
	}
	public class WebSocketSessionManager
	{
		private volatile bool _clean;

		private object _forSweep;

		private Logger _logger;

		private Dictionary<string, IWebSocketSession> _sessions;

		private volatile ServerState _state;

		private volatile bool _sweeping;

		private System.Timers.Timer _sweepTimer;

		private object _sync;

		private TimeSpan _waitTime;

		internal ServerState State => _state;

		public IEnumerable<string> ActiveIDs
		{
			get
			{
				foreach (KeyValuePair<string, bool> res in Broadping(WebSocketFrame.EmptyPingBytes, _waitTime))
				{
					if (res.Value)
					{
						yield return res.Key;
					}
				}
			}
		}

		public int Count
		{
			get
			{
				lock (_sync)
				{
					return _sessions.Count;
				}
			}
		}

		public IEnumerable<string> IDs
		{
			get
			{
				if (_state == ServerState.ShuttingDown)
				{
					return new string[0];
				}
				lock (_sync)
				{
					return _sessions.Keys.ToList();
				}
			}
		}

		public IEnumerable<string> InactiveIDs
		{
			get
			{
				foreach (KeyValuePair<string, bool> res in Broadping(WebSocketFrame.EmptyPingBytes, _waitTime))
				{
					if (!res.Value)
					{
						yield return res.Key;
					}
				}
			}
		}

		public IWebSocketSession this[string id]
		{
			get
			{
				TryGetSession(id, out var session);
				return session;
			}
		}

		public bool KeepClean
		{
			get
			{
				return _clean;
			}
			internal set
			{
				if (value != _clean)
				{
					_clean = value;
					if (_state == ServerState.Start)
					{
						_sweepTimer.Enabled = value;
					}
				}
			}
		}

		public IEnumerable<IWebSocketSession> Sessions
		{
			get
			{
				if (_state == ServerState.ShuttingDown)
				{
					return new IWebSocketSession[0];
				}
				lock (_sync)
				{
					return _sessions.Values.ToList();
				}
			}
		}

		public TimeSpan WaitTime
		{
			get
			{
				return _waitTime;
			}
			internal set
			{
				if (value == _waitTime)
				{
					return;
				}
				_waitTime = value;
				foreach (IWebSocketSession session in Sessions)
				{
					session.Context.WebSocket.WaitTime = value;
				}
			}
		}

		internal WebSocketSessionManager()
			: this(new Logger())
		{
		}

		internal WebSocketSessionManager(Logger logger)
		{
			_logger = logger;
			_clean = true;
			_forSweep = new object();
			_sessions = new Dictionary<string, IWebSocketSession>();
			_state = ServerState.Ready;
			_sync = ((ICollection)_sessions).SyncRoot;
			_waitTime = TimeSpan.FromSeconds(1.0);
			setSweepTimer(60000.0);
		}

		private void broadcast(Opcode opcode, byte[] data, Action completed)
		{
			Dictionary<CompressionMethod, byte[]> dictionary = new Dictionary<CompressionMethod, byte[]>();
			try
			{
				Broadcast(opcode, data, dictionary);
				completed?.Invoke();
			}
			catch (Exception ex)
			{
				_logger.Fatal(ex.ToString());
			}
			finally
			{
				dictionary.Clear();
			}
		}

		private void broadcast(Opcode opcode, Stream stream, Action completed)
		{
			Dictionary<CompressionMethod, Stream> dictionary = new Dictionary<CompressionMethod, Stream>();
			try
			{
				Broadcast(opcode, stream, dictionary);
				completed?.Invoke();
			}
			catch (Exception ex)
			{
				_logger.Fatal(ex.ToString());
			}
			finally
			{
				foreach (Stream value in dictionary.Values)
				{
					value.Dispose();
				}
				dictionary.Clear();
			}
		}

		private void broadcastAsync(Opcode opcode, byte[] data, Action completed)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				broadcast(opcode, data, completed);
			});
		}

		private void broadcastAsync(Opcode opcode, Stream stream, Action completed)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				broadcast(opcode, stream, completed);
			});
		}

		private static string createID()
		{
			return Guid.NewGuid().ToString("N");
		}

		private void setSweepTimer(double interval)
		{
			_sweepTimer = new System.Timers.Timer(interval);
			_sweepTimer.Elapsed += delegate
			{
				Sweep();
			};
		}

		private bool tryGetSession(string id, out IWebSocketSession session)
		{
			bool flag;
			lock (_sync)
			{
				flag = _sessions.TryGetValue(id, out session);
			}
			if (!flag)
			{
				_logger.Error("A session with the specified ID isn't found:\n  ID: " + id);
			}
			return flag;
		}

		internal string Add(IWebSocketSession session)
		{
			lock (_sync)
			{
				if (_state != ServerState.Start)
				{
					return null;
				}
				string text = createID();
				_sessions.Add(text, session);
				return text;
			}
		}

		internal void Broadcast(Opcode opcode, byte[] data, Dictionary<CompressionMethod, byte[]> cache)
		{
			foreach (IWebSocketSession session in Sessions)
			{
				if (_state != ServerState.Start)
				{
					break;
				}
				session.Context.WebSocket.Send(opcode, data, cache);
			}
		}

		internal void Broadcast(Opcode opcode, Stream stream, Dictionary<CompressionMethod, Stream> cache)
		{
			foreach (IWebSocketSession session in Sessions)
			{
				if (_state != ServerState.Start)
				{
					break;
				}
				session.Context.WebSocket.Send(opcode, stream, cache);
			}
		}

		internal Dictionary<string, bool> Broadping(byte[] frameAsBytes, TimeSpan timeout)
		{
			Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
			foreach (IWebSocketSession session in Sessions)
			{
				if (_state != ServerState.Start)
				{
					break;
				}
				dictionary.Add(session.ID, session.Context.WebSocket.Ping(frameAsBytes, timeout));
			}
			return dictionary;
		}

		internal bool Remove(string id)
		{
			lock (_sync)
			{
				return _sessions.Remove(id);
			}
		}

		internal void Start()
		{
			lock (_sync)
			{
				_sweepTimer.Enabled = _clean;
				_state = ServerState.Start;
			}
		}

		internal void Stop(CloseEventArgs e, byte[] frameAsBytes, bool receive)
		{
			lock (_sync)
			{
				_state = ServerState.ShuttingDown;
				_sweepTimer.Enabled = false;
				foreach (IWebSocketSession item in _sessions.Values.ToList())
				{
					item.Context.WebSocket.Close(e, frameAsBytes, receive);
				}
				_state = ServerState.Stop;
			}
		}

		public void Broadcast(byte[] data)
		{
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckSendParameter(data);
			if (text != null)
			{
				_logger.Error(text);
			}
			else if (data.LongLength <= WebSocket.FragmentLength)
			{
				broadcast(Opcode.Binary, data, null);
			}
			else
			{
				broadcast(Opcode.Binary, new MemoryStream(data), null);
			}
		}

		public void Broadcast(string data)
		{
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckSendParameter(data);
			if (text != null)
			{
				_logger.Error(text);
				return;
			}
			byte[] array = data.UTF8Encode();
			if (array.LongLength <= WebSocket.FragmentLength)
			{
				broadcast(Opcode.Text, array, null);
			}
			else
			{
				broadcast(Opcode.Text, new MemoryStream(array), null);
			}
		}

		public void BroadcastAsync(byte[] data, Action completed)
		{
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckSendParameter(data);
			if (text != null)
			{
				_logger.Error(text);
			}
			else if (data.LongLength <= WebSocket.FragmentLength)
			{
				broadcastAsync(Opcode.Binary, data, completed);
			}
			else
			{
				broadcastAsync(Opcode.Binary, new MemoryStream(data), completed);
			}
		}

		public void BroadcastAsync(string data, Action completed)
		{
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckSendParameter(data);
			if (text != null)
			{
				_logger.Error(text);
				return;
			}
			byte[] array = data.UTF8Encode();
			if (array.LongLength <= WebSocket.FragmentLength)
			{
				broadcastAsync(Opcode.Text, array, completed);
			}
			else
			{
				broadcastAsync(Opcode.Text, new MemoryStream(array), completed);
			}
		}

		public void BroadcastAsync(Stream stream, int length, Action completed)
		{
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckSendParameters(stream, length);
			if (text != null)
			{
				_logger.Error(text);
				return;
			}
			stream.ReadBytesAsync(length, delegate(byte[] data)
			{
				int num = data.Length;
				if (num == 0)
				{
					_logger.Error("The data cannot be read from 'stream'.");
				}
				else
				{
					if (num < length)
					{
						_logger.Warn($"The data with 'length' cannot be read from 'stream':\n  expected: {length}\n  actual: {num}");
					}
					if (num <= WebSocket.FragmentLength)
					{
						broadcast(Opcode.Binary, data, completed);
					}
					else
					{
						broadcast(Opcode.Binary, new MemoryStream(data), completed);
					}
				}
			}, delegate(Exception ex)
			{
				_logger.Fatal(ex.ToString());
			});
		}

		public Dictionary<string, bool> Broadping()
		{
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false);
			if (text != null)
			{
				_logger.Error(text);
				return null;
			}
			return Broadping(WebSocketFrame.EmptyPingBytes, _waitTime);
		}

		public Dictionary<string, bool> Broadping(string message)
		{
			if (message == null || message.Length == 0)
			{
				return Broadping();
			}
			byte[] bytes = null;
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckPingParameter(message, out bytes);
			if (text != null)
			{
				_logger.Error(text);
				return null;
			}
			return Broadping(WebSocketFrame.CreatePingFrame(bytes, mask: false).ToArray(), _waitTime);
		}

		public void CloseSession(string id)
		{
			if (TryGetSession(id, out var session))
			{
				session.Context.WebSocket.Close();
			}
		}

		public void CloseSession(string id, ushort code, string reason)
		{
			if (TryGetSession(id, out var session))
			{
				session.Context.WebSocket.Close(code, reason);
			}
		}

		public void CloseSession(string id, CloseStatusCode code, string reason)
		{
			if (TryGetSession(id, out var session))
			{
				session.Context.WebSocket.Close(code, reason);
			}
		}

		public bool PingTo(string id)
		{
			IWebSocketSession session;
			return TryGetSession(id, out session) && session.Context.WebSocket.Ping();
		}

		public bool PingTo(string message, string id)
		{
			IWebSocketSession session;
			return TryGetSession(id, out session) && session.Context.WebSocket.Ping(message);
		}

		public void SendTo(byte[] data, string id)
		{
			if (TryGetSession(id, out var session))
			{
				session.Context.WebSocket.Send(data);
			}
		}

		public void SendTo(string data, string id)
		{
			if (TryGetSession(id, out var session))
			{
				session.Context.WebSocket.Send(data);
			}
		}

		public void SendToAsync(byte[] data, string id, Action<bool> completed)
		{
			if (TryGetSession(id, out var session))
			{
				session.Context.WebSocket.SendAsync(data, completed);
			}
		}

		public void SendToAsync(string data, string id, Action<bool> completed)
		{
			if (TryGetSession(id, out var session))
			{
				session.Context.WebSocket.SendAsync(data, completed);
			}
		}

		public void SendToAsync(Stream stream, int length, string id, Action<bool> completed)
		{
			if (TryGetSession(id, out var session))
			{
				session.Context.WebSocket.SendAsync(stream, length, completed);
			}
		}

		public void Sweep()
		{
			if (_state != ServerState.Start || _sweeping || Count == 0)
			{
				return;
			}
			lock (_forSweep)
			{
				_sweeping = true;
				foreach (string inactiveID in InactiveIDs)
				{
					if (_state != ServerState.Start)
					{
						break;
					}
					lock (_sync)
					{
						if (_sessions.TryGetValue(inactiveID, out var value))
						{
							switch (value.State)
							{
							case WebSocketState.Open:
								value.Context.WebSocket.Close(CloseStatusCode.ProtocolError);
								break;
							case WebSocketState.Closing:
								break;
							default:
								_sessions.Remove(inactiveID);
								break;
							}
						}
					}
				}
				_sweeping = false;
			}
		}

		public bool TryGetSession(string id, out IWebSocketSession session)
		{
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? id.CheckIfValidSessionID();
			if (text != null)
			{
				_logger.Error(text);
				session = null;
				return false;
			}
			return tryGetSession(id, out session);
		}
	}
	internal enum ServerState
	{
		Ready,
		Start,
		ShuttingDown,
		Stop
	}
	public class WebSocketServiceManager
	{
		private volatile bool _clean;

		private Dictionary<string, WebSocketServiceHost> _hosts;

		private Logger _logger;

		private volatile ServerState _state;

		private object _sync;

		private TimeSpan _waitTime;

		public int Count
		{
			get
			{
				lock (_sync)
				{
					return _hosts.Count;
				}
			}
		}

		public IEnumerable<WebSocketServiceHost> Hosts
		{
			get
			{
				lock (_sync)
				{
					return _hosts.Values.ToList();
				}
			}
		}

		public WebSocketServiceHost this[string path]
		{
			get
			{
				TryGetServiceHost(path, out var host);
				return host;
			}
		}

		public bool KeepClean
		{
			get
			{
				return _clean;
			}
			internal set
			{
				lock (_sync)
				{
					if (value == _clean)
					{
						return;
					}
					_clean = value;
					foreach (WebSocketServiceHost value2 in _hosts.Values)
					{
						value2.KeepClean = value;
					}
				}
			}
		}

		public IEnumerable<string> Paths
		{
			get
			{
				lock (_sync)
				{
					return _hosts.Keys.ToList();
				}
			}
		}

		public int SessionCount
		{
			get
			{
				int num = 0;
				foreach (WebSocketServiceHost host in Hosts)
				{
					if (_state != ServerState.Start)
					{
						break;
					}
					num += host.Sessions.Count;
				}
				return num;
			}
		}

		public TimeSpan WaitTime
		{
			get
			{
				return _waitTime;
			}
			internal set
			{
				lock (_sync)
				{
					if (value == _waitTime)
					{
						return;
					}
					_waitTime = value;
					foreach (WebSocketServiceHost value2 in _hosts.Values)
					{
						value2.WaitTime = value;
					}
				}
			}
		}

		internal WebSocketServiceManager()
			: this(new Logger())
		{
		}

		internal WebSocketServiceManager(Logger logger)
		{
			_logger = logger;
			_clean = true;
			_hosts = new Dictionary<string, WebSocketServiceHost>();
			_state = ServerState.Ready;
			_sync = ((ICollection)_hosts).SyncRoot;
			_waitTime = TimeSpan.FromSeconds(1.0);
		}

		private void broadcast(Opcode opcode, byte[] data, Action completed)
		{
			Dictionary<CompressionMethod, byte[]> dictionary = new Dictionary<CompressionMethod, byte[]>();
			try
			{
				foreach (WebSocketServiceHost host in Hosts)
				{
					if (_state != ServerState.Start)
					{
						break;
					}
					host.Sessions.Broadcast(opcode, data, dictionary);
				}
				completed?.Invoke();
			}
			catch (Exception ex)
			{
				_logger.Fatal(ex.ToString());
			}
			finally
			{
				dictionary.Clear();
			}
		}

		private void broadcast(Opcode opcode, Stream stream, Action completed)
		{
			Dictionary<CompressionMethod, Stream> dictionary = new Dictionary<CompressionMethod, Stream>();
			try
			{
				foreach (WebSocketServiceHost host in Hosts)
				{
					if (_state != ServerState.Start)
					{
						break;
					}
					host.Sessions.Broadcast(opcode, stream, dictionary);
				}
				completed?.Invoke();
			}
			catch (Exception ex)
			{
				_logger.Fatal(ex.ToString());
			}
			finally
			{
				foreach (Stream value in dictionary.Values)
				{
					value.Dispose();
				}
				dictionary.Clear();
			}
		}

		private void broadcastAsync(Opcode opcode, byte[] data, Action completed)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				broadcast(opcode, data, completed);
			});
		}

		private void broadcastAsync(Opcode opcode, Stream stream, Action completed)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				broadcast(opcode, stream, completed);
			});
		}

		private Dictionary<string, Dictionary<string, bool>> broadping(byte[] frameAsBytes, TimeSpan timeout)
		{
			Dictionary<string, Dictionary<string, bool>> dictionary = new Dictionary<string, Dictionary<string, bool>>();
			foreach (WebSocketServiceHost host in Hosts)
			{
				if (_state != ServerState.Start)
				{
					break;
				}
				dictionary.Add(host.Path, host.Sessions.Broadping(frameAsBytes, timeout));
			}
			return dictionary;
		}

		internal void Add<TBehavior>(string path, Func<TBehavior> initializer) where TBehavior : WebSocketBehavior
		{
			lock (_sync)
			{
				path = HttpUtility.UrlDecode(path).TrimEndSlash();
				if (_hosts.TryGetValue(path, out var value))
				{
					_logger.Error("A WebSocket service with the specified path already exists:\n  path: " + path);
					return;
				}
				value = new WebSocketServiceHost<TBehavior>(path, initializer, _logger);
				if (!_clean)
				{
					value.KeepClean = false;
				}
				if (_waitTime != value.WaitTime)
				{
					value.WaitTime = _waitTime;
				}
				if (_state == ServerState.Start)
				{
					value.Start();
				}
				_hosts.Add(path, value);
			}
		}

		internal bool InternalTryGetServiceHost(string path, out WebSocketServiceHost host)
		{
			bool flag;
			lock (_sync)
			{
				path = HttpUtility.UrlDecode(path).TrimEndSlash();
				flag = _hosts.TryGetValue(path, out host);
			}
			if (!flag)
			{
				_logger.Error("A WebSocket service with the specified path isn't found:\n  path: " + path);
			}
			return flag;
		}

		internal bool Remove(string path)
		{
			WebSocketServiceHost value;
			lock (_sync)
			{
				path = HttpUtility.UrlDecode(path).TrimEndSlash();
				if (!_hosts.TryGetValue(path, out value))
				{
					_logger.Error("A WebSocket service with the specified path isn't found:\n  path: " + path);
					return false;
				}
				_hosts.Remove(path);
			}
			if (value.State == ServerState.Start)
			{
				value.Stop(1001, null);
			}
			return true;
		}

		internal void Start()
		{
			lock (_sync)
			{
				foreach (WebSocketServiceHost value in _hosts.Values)
				{
					value.Start();
				}
				_state = ServerState.Start;
			}
		}

		internal void Stop(CloseEventArgs e, bool send, bool receive)
		{
			lock (_sync)
			{
				_state = ServerState.ShuttingDown;
				byte[] frameAsBytes = (send ? WebSocketFrame.CreateCloseFrame(e.PayloadData, mask: false).ToArray() : null);
				foreach (WebSocketServiceHost value in _hosts.Values)
				{
					value.Sessions.Stop(e, frameAsBytes, receive);
				}
				_hosts.Clear();
				_state = ServerState.Stop;
			}
		}

		public void Broadcast(byte[] data)
		{
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckSendParameter(data);
			if (text != null)
			{
				_logger.Error(text);
			}
			else if (data.LongLength <= WebSocket.FragmentLength)
			{
				broadcast(Opcode.Binary, data, null);
			}
			else
			{
				broadcast(Opcode.Binary, new MemoryStream(data), null);
			}
		}

		public void Broadcast(string data)
		{
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckSendParameter(data);
			if (text != null)
			{
				_logger.Error(text);
				return;
			}
			byte[] array = data.UTF8Encode();
			if (array.LongLength <= WebSocket.FragmentLength)
			{
				broadcast(Opcode.Text, array, null);
			}
			else
			{
				broadcast(Opcode.Text, new MemoryStream(array), null);
			}
		}

		public void BroadcastAsync(byte[] data, Action completed)
		{
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckSendParameter(data);
			if (text != null)
			{
				_logger.Error(text);
			}
			else if (data.LongLength <= WebSocket.FragmentLength)
			{
				broadcastAsync(Opcode.Binary, data, completed);
			}
			else
			{
				broadcastAsync(Opcode.Binary, new MemoryStream(data), completed);
			}
		}

		public void BroadcastAsync(string data, Action completed)
		{
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckSendParameter(data);
			if (text != null)
			{
				_logger.Error(text);
				return;
			}
			byte[] array = data.UTF8Encode();
			if (array.LongLength <= WebSocket.FragmentLength)
			{
				broadcastAsync(Opcode.Text, array, completed);
			}
			else
			{
				broadcastAsync(Opcode.Text, new MemoryStream(array), completed);
			}
		}

		public void BroadcastAsync(Stream stream, int length, Action completed)
		{
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckSendParameters(stream, length);
			if (text != null)
			{
				_logger.Error(text);
				return;
			}
			stream.ReadBytesAsync(length, delegate(byte[] data)
			{
				int num = data.Length;
				if (num == 0)
				{
					_logger.Error("The data cannot be read from 'stream'.");
				}
				else
				{
					if (num < length)
					{
						_logger.Warn($"The data with 'length' cannot be read from 'stream':\n  expected: {length}\n  actual: {num}");
					}
					if (num <= WebSocket.FragmentLength)
					{
						broadcast(Opcode.Binary, data, completed);
					}
					else
					{
						broadcast(Opcode.Binary, new MemoryStream(data), completed);
					}
				}
			}, delegate(Exception ex)
			{
				_logger.Fatal(ex.ToString());
			});
		}

		public Dictionary<string, Dictionary<string, bool>> Broadping()
		{
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false);
			if (text != null)
			{
				_logger.Error(text);
				return null;
			}
			return broadping(WebSocketFrame.EmptyPingBytes, _waitTime);
		}

		public Dictionary<string, Dictionary<string, bool>> Broadping(string message)
		{
			if (message == null || message.Length == 0)
			{
				return Broadping();
			}
			byte[] bytes = null;
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? WebSocket.CheckPingParameter(message, out bytes);
			if (text != null)
			{
				_logger.Error(text);
				return null;
			}
			return broadping(WebSocketFrame.CreatePingFrame(bytes, mask: false).ToArray(), _waitTime);
		}

		public bool TryGetServiceHost(string path, out WebSocketServiceHost host)
		{
			string text = _state.CheckIfAvailable(ready: false, start: true, shutting: false) ?? path.CheckIfValidServicePath();
			if (text != null)
			{
				_logger.Error(text);
				host = null;
				return false;
			}
			return InternalTryGetServiceHost(path, out host);
		}
	}
	public abstract class WebSocketBehavior : IWebSocketSession
	{
		private WebSocketContext _context;

		private Func<WebSocketSharp.Net.CookieCollection, WebSocketSharp.Net.CookieCollection, bool> _cookiesValidator;

		private bool _emitOnPing;

		private string _id;

		private bool _ignoreExtensions;

		private Func<string, bool> _originValidator;

		private string _protocol;

		private WebSocketSessionManager _sessions;

		private DateTime _startTime;

		private WebSocket _websocket;

		protected Logger Log => (_websocket != null) ? _websocket.Log : null;

		protected WebSocketSessionManager Sessions => _sessions;

		public WebSocketContext Context => _context;

		public Func<WebSocketSharp.Net.CookieCollection, WebSocketSharp.Net.CookieCollection, bool> CookiesValidator
		{
			get
			{
				return _cookiesValidator;
			}
			set
			{
				_cookiesValidator = value;
			}
		}

		public bool EmitOnPing
		{
			get
			{
				return (_websocket != null) ? _websocket.EmitOnPing : _emitOnPing;
			}
			set
			{
				if (_websocket != null)
				{
					_websocket.EmitOnPing = value;
				}
				else
				{
					_emitOnPing = value;
				}
			}
		}

		public string ID => _id;

		public bool IgnoreExtensions
		{
			get
			{
				return _ignoreExtensions;
			}
			set
			{
				_ignoreExtensions = value;
			}
		}

		public Func<string, bool> OriginValidator
		{
			get
			{
				return _originValidator;
			}
			set
			{
				_originValidator = value;
			}
		}

		public string Protocol
		{
			get
			{
				return (_websocket != null) ? _websocket.Protocol : (_protocol ?? string.Empty);
			}
			set
			{
				if (State == WebSocketState.Connecting && (value == null || (value.Length != 0 && value.IsToken())))
				{
					_protocol = value;
				}
			}
		}

		public DateTime StartTime => _startTime;

		public WebSocketState State => (_websocket != null) ? _websocket.ReadyState : WebSocketState.Connecting;

		protected WebSocketBehavior()
		{
			_startTime = DateTime.MaxValue;
		}

		private string checkHandshakeRequest(WebSocketContext context)
		{
			return (_originValidator != null && !_originValidator(context.Origin)) ? "Includes no Origin header, or it has an invalid value." : ((_cookiesValidator != null && !_cookiesValidator(context.CookieCollection, context.WebSocket.CookieCollection)) ? "Includes no cookie, or an invalid cookie exists." : null);
		}

		private void onClose(object sender, CloseEventArgs e)
		{
			if (_id != null)
			{
				_sessions.Remove(_id);
				OnClose(e);
			}
		}

		private void onError(object sender, ErrorEventArgs e)
		{
			OnError(e);
		}

		private void onMessage(object sender, MessageEventArgs e)
		{
			OnMessage(e);
		}

		private void onOpen(object sender, EventArgs e)
		{
			_id = _sessions.Add(this);
			if (_id == null)
			{
				_websocket.Close(CloseStatusCode.Away);
				return;
			}
			_startTime = DateTime.Now;
			OnOpen();
		}

		internal void Start(WebSocketContext context, WebSocketSessionManager sessions)
		{
			if (_websocket != null)
			{
				_websocket.Log.Error("This session has already been started.");
				context.WebSocket.Close(WebSocketSharp.Net.HttpStatusCode.ServiceUnavailable);
				return;
			}
			_context = context;
			_sessions = sessions;
			_websocket = context.WebSocket;
			_websocket.CustomHandshakeRequestChecker = checkHandshakeRequest;
			_websocket.EmitOnPing = _emitOnPing;
			_websocket.IgnoreExtensions = _ignoreExtensions;
			_websocket.Protocol = _protocol;
			TimeSpan waitTime = sessions.WaitTime;
			if (waitTime != _websocket.WaitTime)
			{
				_websocket.WaitTime = waitTime;
			}
			_websocket.OnOpen += onOpen;
			_websocket.OnMessage += onMessage;
			_websocket.OnError += onError;
			_websocket.OnClose += onClose;
			_websocket.InternalAccept();
		}

		protected void Error(string message, Exception exception)
		{
			if (message != null && message.Length > 0)
			{
				OnError(new ErrorEventArgs(message, exception));
			}
		}

		protected virtual void OnClose(CloseEventArgs e)
		{
		}

		protected virtual void OnError(ErrorEventArgs e)
		{
		}

		protected virtual void OnMessage(MessageEventArgs e)
		{
		}

		protected virtual void OnOpen()
		{
		}

		protected void Send(byte[] data)
		{
			if (_websocket != null)
			{
				_websocket.Send(data);
			}
		}

		protected void Send(FileInfo file)
		{
			if (_websocket != null)
			{
				_websocket.Send(file);
			}
		}

		protected void Send(string data)
		{
			if (_websocket != null)
			{
				_websocket.Send(data);
			}
		}

		protected void SendAsync(byte[] data, Action<bool> completed)
		{
			if (_websocket != null)
			{
				_websocket.SendAsync(data, completed);
			}
		}

		protected void SendAsync(FileInfo file, Action<bool> completed)
		{
			if (_websocket != null)
			{
				_websocket.SendAsync(file, completed);
			}
		}

		protected void SendAsync(string data, Action<bool> completed)
		{
			if (_websocket != null)
			{
				_websocket.SendAsync(data, completed);
			}
		}

		protected void SendAsync(Stream stream, int length, Action<bool> completed)
		{
			if (_websocket != null)
			{
				_websocket.SendAsync(stream, length, completed);
			}
		}
	}
	internal class WebSocketServiceHost<TBehavior> : WebSocketServiceHost where TBehavior : WebSocketBehavior
	{
		private Func<TBehavior> _initializer;

		private Logger _logger;

		private string _path;

		private WebSocketSessionManager _sessions;

		public override bool KeepClean
		{
			get
			{
				return _sessions.KeepClean;
			}
			set
			{
				string text = _sessions.State.CheckIfAvailable(ready: true, start: false, shutting: false);
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_sessions.KeepClean = value;
				}
			}
		}

		public override string Path => _path;

		public override WebSocketSessionManager Sessions => _sessions;

		public override Type Type => typeof(TBehavior);

		public override TimeSpan WaitTime
		{
			get
			{
				return _sessions.WaitTime;
			}
			set
			{
				string text = _sessions.State.CheckIfAvailable(ready: true, start: false, shutting: false) ?? value.CheckIfValidWaitTime();
				if (text != null)
				{
					_logger.Error(text);
				}
				else
				{
					_sessions.WaitTime = value;
				}
			}
		}

		internal WebSocketServiceHost(string path, Func<TBehavior> initializer, Logger logger)
		{
			_path = path;
			_initializer = initializer;
			_logger = logger;
			_sessions = new WebSocketSessionManager(logger);
		}

		protected override WebSocketBehavior CreateSession()
		{
			return _initializer();
		}
	}
}
