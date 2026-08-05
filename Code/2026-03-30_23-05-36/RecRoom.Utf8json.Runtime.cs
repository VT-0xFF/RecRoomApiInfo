using System;
using System.Buffers;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Utf8Json.Internal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Utf8Json
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	public class JsonFormatterAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Type FormatterType
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, YUWSCVCXGIP resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, YUWSCVCXGIP resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface SIODVFPODKZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface CQMBENHOHVQ<a> : SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, YUWSCVCXGIP formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface ZUVGKIZOTUL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JWFZHJFHCGF(JsonWriter a, a b, YUWSCVCXGIP c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum CollectionDeserializeToBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Add,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		OverwriteReplace
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class IXVSYKLYZTU
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x37E51B0", Offset = "0x37E3FB0", VA = "0x1837E51B0")]
		public static string ToJsonString<T>(this CQMBENHOHVQ<T> formatter, T value, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CQMBENHOHVQ<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class ISRDKVNVXFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x37E4BF0", Offset = "0x37E39F0", VA = "0x1837E4BF0")]
		public static CQMBENHOHVQ<a> OSYFWHOFRAD<a>(this YUWSCVCXGIP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x909D840", Offset = "0x909C640", VA = "0x18909D840")]
		public static object PLEGRRZZEVV(this YUWSCVCXGIP a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x909B910", Offset = "0x909A710", VA = "0x18909B910")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class MJYGDBFVCAN
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] CRHYSFNVYHK;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] XUABPXTTJTP;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] SWUPUSRXGRE;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] GJYEUXWXEEJ;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] QPMHYHGLLOU;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] OCJWMRPIYHF;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] ORGJOXXLTBZ;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] LZRORCOGPNM;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class XMYMTMQNBXU : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x90A9390", Offset = "0x90A8190", VA = "0x1890A9390")]
				public XMYMTMQNBXU(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x90A9270", Offset = "0x90A8070", VA = "0x1890A9270")]
				public XMYMTMQNBXU TOTPUJODERO(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class UEVSSSINGNP
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] JBQTEIFHIBA;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] XMTDRWQQXLD;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private XMYMTMQNBXU start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private XMYMTMQNBXU end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x90A68F0", Offset = "0x90A56F0", VA = "0x1890A68F0")]
			public void TOTPUJODERO([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x90A67B0", Offset = "0x90A55B0", VA = "0x1890A67B0")]
			public void TOTPUJODERO(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x90A6A00", Offset = "0x90A5800", VA = "0x1890A6A00")]
			public ReadOnlySequence<byte> XLOOWROFVJR()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x90A6410", Offset = "0x90A5210", VA = "0x1890A6410")]
			private void FFFKDZPDBTB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x90A65C0", Offset = "0x90A53C0", VA = "0x1890A65C0")]
			private void ODCDPFWOUEJ([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x90A0D60", Offset = "0x909FB60", VA = "0x1890A0D60")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x909DFF0", Offset = "0x909CDF0", VA = "0x18909DFF0")]
		private JsonParsingException DRVPGTWBITX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x909DEE0", Offset = "0x909CCE0", VA = "0x18909DEE0")]
		private JsonParsingException CTUJKOUEZGM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x90A0880", Offset = "0x909F680", VA = "0x1890A0880")]
		public JsonToken VFOPNQBCMCA()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x909FA60", Offset = "0x909E860", VA = "0x18909FA60")]
		public void PTHKEEEVHEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x90A03F0", Offset = "0x909F1F0", VA = "0x1890A03F0")]
		private bool SZEERATUTII(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x90A0390", Offset = "0x909F190", VA = "0x1890A0390")]
		private bool SZEERATUTII(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x909FDC0", Offset = "0x909EBC0", VA = "0x18909FDC0")]
		private void QLVIXJTBMXD(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x909F450", Offset = "0x909E250", VA = "0x18909F450")]
		public bool LSISFISOKFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x909F440", Offset = "0x909E240", VA = "0x18909F440")]
		public void KSTANVDEPDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x909F620", Offset = "0x909E420", VA = "0x18909F620")]
		public bool MHXHPEGTQKW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x909F800", Offset = "0x909E600", VA = "0x18909F800")]
		public void OVIVWRUCWLZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x90A0870", Offset = "0x909F670", VA = "0x1890A0870")]
		public void UPIVIOMWYKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x909FE70", Offset = "0x909EC70", VA = "0x18909FE70")]
		public bool QQIWFJEANGW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x909ED90", Offset = "0x909DB90", VA = "0x18909ED90")]
		public void JGGACPAEOHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x90A0B40", Offset = "0x909F940", VA = "0x1890A0B40")]
		public void WITTQDCTIBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x909FD30", Offset = "0x909EB30", VA = "0x18909FD30")]
		public bool QHZGBXQZZFP(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x909F810", Offset = "0x909E610", VA = "0x18909F810")]
		public bool PBZNWTWVNIN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x909F670", Offset = "0x909E470", VA = "0x18909F670")]
		public bool MVZYNOBXRWY(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x909EF10", Offset = "0x909DD10", VA = "0x18909EF10")]
		private ReadOnlySequence<byte> KBPFZKAKITT()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x90A0120", Offset = "0x909EF20", VA = "0x1890A0120")]
		private ReadOnlySequence<byte> RVVSXCZGJII()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x909EAF0", Offset = "0x909D8F0", VA = "0x18909EAF0")]
		private void IWBOENTKBFK(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x90A0B50", Offset = "0x909F950", VA = "0x1890A0B50")]
		private void WIXVNWOKIQX(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x909E560", Offset = "0x909D360", VA = "0x18909E560")]
		private void HLITBFHCXVU(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x909F510", Offset = "0x909E310", VA = "0x18909F510")]
		private void LXWBJOIIPOF(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9095E80", Offset = "0x9094C80", VA = "0x189095E80")]
		private static int PJUUTFNUJVW(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x909FEC0", Offset = "0x909ECC0", VA = "0x18909FEC0")]
		public ReadOnlySequence<byte> QYYEVKWCFCY()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x909DE60", Offset = "0x909CC60", VA = "0x18909DE60")]
		public string CLYXLJVVRWF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x909F400", Offset = "0x909E200", VA = "0x18909F400")]
		public string KRIUZWJBYUO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x909DCF0", Offset = "0x909CAF0", VA = "0x18909DCF0")]
		public ReadOnlySequence<byte> BAFYMVUSMAI()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x90A0040", Offset = "0x909EE40", VA = "0x1890A0040")]
		public ReadOnlySequence<byte> ROXNXVFFTUL()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x909F910", Offset = "0x909E710", VA = "0x18909F910")]
		public bool PJWZPSZZMQA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x909EDA0", Offset = "0x909DBA0", VA = "0x18909EDA0")]
		private void JKZWLILIURU(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x90A0D50", Offset = "0x909FB50", VA = "0x1890A0D50")]
		public void XIXSTTCCGBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x90A0450", Offset = "0x909F250", VA = "0x1890A0450")]
		private void TVWOSSDMQKR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x909DB90", Offset = "0x909C990", VA = "0x18909DB90")]
		public sbyte AHTIUPJXNSX()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x90A0A90", Offset = "0x909F890", VA = "0x1890A0A90")]
		public short VGYYLDZUAJE()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x909ECE0", Offset = "0x909DAE0", VA = "0x18909ECE0")]
		public int JBUVSGDFPUU()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x909F8A0", Offset = "0x909E6A0", VA = "0x18909F8A0")]
		public long PHLHJIGCBDF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x909FF90", Offset = "0x909ED90", VA = "0x18909FF90")]
		public byte RGIZLSEMPNI()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x909DC40", Offset = "0x909CA40", VA = "0x18909DC40")]
		public ushort ANYZPWJQLOT()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x909F750", Offset = "0x909E550", VA = "0x18909F750")]
		public uint NKNBNSRGMQV()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x909E4F0", Offset = "0x909D2F0", VA = "0x18909E4F0")]
		public ulong FMJYOGZDJIK()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x909FC90", Offset = "0x909EA90", VA = "0x18909FC90")]
		public float QGKUWBUAFPO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x909DDC0", Offset = "0x909CBC0", VA = "0x18909DDC0")]
		public double BMCPBOEQVRD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x90A0690", Offset = "0x909F490", VA = "0x1890A0690")]
		public ReadOnlySequence<byte> UIWKPUAAUJE()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x909E850", Offset = "0x909D650", VA = "0x18909E850")]
		private void IGUQEJRRVGA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class JsonParsingException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string ActualChar
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xD6CDC0", Offset = "0xD6BBC0", VA = "0x180D6CDC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x909DB30", Offset = "0x909C930", VA = "0x18909DB30")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x909DAB0", Offset = "0x909C8B0", VA = "0x18909DAB0")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class DOXDJJOZXVI
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class HLRJJLCXFBD
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] JBQTEIFHIBA;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x909D7A0", Offset = "0x909C5A0", VA = "0x18909D7A0")]
			public static byte[] HMVRGCMUZSW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static YUWSCVCXGIP YUGOQGVBEUT;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] FHZXFJVFMBM;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] KMIRTWSZBRG;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static YUWSCVCXGIP HDVOSDGBGWH
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x909A540", Offset = "0x9099340", VA = "0x18909A540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x909A640", Offset = "0x9099440", VA = "0x18909A640")]
		public static void TNAJYIPFASX(YUWSCVCXGIP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x361FDA0", Offset = "0x361EBA0", VA = "0x18361FDA0")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x361FC30", Offset = "0x361EA30", VA = "0x18361FC30")]
		public static byte[] Serialize<T>(T value, YUWSCVCXGIP resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3620210", Offset = "0x361F010", VA = "0x183620210")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3620290", Offset = "0x361F090", VA = "0x183620290")]
		public static string ToJsonString<T>(T value, YUWSCVCXGIP resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x361F420", Offset = "0x361E220", VA = "0x18361F420")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x361F5F0", Offset = "0x361E3F0", VA = "0x18361F5F0")]
		public static T Deserialize<T>(string json, YUWSCVCXGIP resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x361F840", Offset = "0x361E640", VA = "0x18361F840")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x361F770", Offset = "0x361E570", VA = "0x18361F770")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, YUWSCVCXGIP resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x361EDA0", Offset = "0x361DBA0", VA = "0x18361EDA0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x361EBD0", Offset = "0x361D9D0", VA = "0x18361EBD0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, YUWSCVCXGIP resolver)
		{
			return (T)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum JsonToken : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		BeginObject,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		EndObject,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		BeginArray,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		EndArray,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Number,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		String,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		True,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		False,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Null,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		ValueSeparator,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		NameSeparator
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct JsonWriter
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly byte[] emptyBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal byte[] buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal int offset;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly byte[] AllowList;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int IOZAHQRFQEC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD2D370", Offset = "0xD2C170", VA = "0x180D2D370")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x90A20D0", Offset = "0x90A0ED0", VA = "0x1890A20D0")]
		public void WPYAYVNWASZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x90A1370", Offset = "0x90A0170", VA = "0x1890A1370")]
		public static byte[] MMHTLXUHVYM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x90A20E0", Offset = "0x90A0EE0", VA = "0x1890A20E0")]
		public static byte[] XNTVZVUAUTO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x90A1B50", Offset = "0x90A0950", VA = "0x1890A1B50")]
		public static byte[] QUDUOMKPCOO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x90A0ED0", Offset = "0x909FCD0", VA = "0x1890A0ED0")]
		public static byte[] AEMWYKPKUWC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x287CFA0", Offset = "0x287BDA0", VA = "0x18287CFA0")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x90A11A0", Offset = "0x909FFA0", VA = "0x1890A11A0")]
		public ArraySegment<byte> HMVRGCMUZSW()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x90A1D60", Offset = "0x90A0B60", VA = "0x1890A1D60")]
		public byte[] TJXODFEGWMB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x90A1F50", Offset = "0x90A0D50", VA = "0x1890A1F50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x90A1EF0", Offset = "0x90A0CF0", VA = "0x1890A1EF0")]
		public void TTGZNIJUGSW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x90A1050", Offset = "0x909FE50", VA = "0x1890A1050")]
		public void CRBBVXUVWTJ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x90A2020", Offset = "0x90A0E20", VA = "0x1890A2020")]
		public void UJUJVEHLDIB(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3FCA970", Offset = "0x3FC9770", VA = "0x183FCA970")]
		public void PYMGJISMQLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3FCA920", Offset = "0x3FC9720", VA = "0x183FCA920")]
		public void PRWWNWJFTEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x90A1240", Offset = "0x90A0040", VA = "0x1890A1240")]
		public void IBSWDYWMKCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x90A1F00", Offset = "0x90A0D00", VA = "0x1890A1F00")]
		public void TUKXRVNRXDR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3FCA8D0", Offset = "0x3FC96D0", VA = "0x183FCA8D0")]
		public void BMPSGOVHQUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4FFAB50", Offset = "0x4FF9950", VA = "0x184FFAB50")]
		public void EDJLIBFQJXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x90A1100", Offset = "0x909FF00", VA = "0x1890A1100")]
		public void GQPULBJSPKF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x90A10B0", Offset = "0x909FEB0", VA = "0x1890A10B0")]
		public void DMYDYCFNOXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3FCA9C0", Offset = "0x3FC97C0", VA = "0x183FCA9C0")]
		public void SIOEUCQWWEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x797ACA0", Offset = "0x7979AA0", VA = "0x18797ACA0")]
		public void AWJXWHUTZXT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x90A19D0", Offset = "0x90A07D0", VA = "0x1890A19D0")]
		public void NVOQWIQUKOL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x90A1CE0", Offset = "0x90A0AE0", VA = "0x1890A1CE0")]
		public void RSBLGBGPNMG(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x90A1FB0", Offset = "0x90A0DB0", VA = "0x1890A1FB0")]
		public void UIVMSRRFFPT(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x90A2200", Offset = "0x90A1000", VA = "0x1890A2200")]
		public void XXXONUBQKWI(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x90A1300", Offset = "0x90A0100", VA = "0x1890A1300")]
		public void KDBRGRYEVKS(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x90A1AF0", Offset = "0x90A08F0", VA = "0x1890A1AF0")]
		public void QBKOSKMSFAR(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x90A1C70", Offset = "0x90A0A70", VA = "0x1890A1C70")]
		public void RQHNXVPKDZQ(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x90A1290", Offset = "0x90A0090", VA = "0x1890A1290")]
		public void IVZVCXXYHNJ(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x90A2060", Offset = "0x90A0E60", VA = "0x1890A2060")]
		public void VQXTWSCJLCR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x90A1B20", Offset = "0x90A0920", VA = "0x1890A1B20")]
		public void QTHWNIOLZCK(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x90A1450", Offset = "0x90A0250", VA = "0x1890A1450")]
		public void NQSIGELESNY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x90A1A50", Offset = "0x90A0850", VA = "0x1890A1A50")]
		private static bool PVKRAUAYTCA(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x90A1AD0", Offset = "0x90A08D0", VA = "0x1890A1AD0")]
		private static byte PXARJHJCVTU(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9096170", Offset = "0x9094F70", VA = "0x189096170")]
		private static void VNVODEWUJFF(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class WHJMOMZDLFO : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3EFDC30", Offset = "0x3EFCA30", VA = "0x183EFDC30")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private WHJMOMZDLFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class FFEDUUFTXVT : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3F03310", Offset = "0x3F02110", VA = "0x183F03310")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class CXEYEFLTVAH
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> JCWLPCSCBSQ;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x9098090", Offset = "0x9096E90", VA = "0x189098090")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private FFEDUUFTXVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class UDGZDIIQGPX : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3F26A60", Offset = "0x3F25860", VA = "0x183F26A60")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly UDGZDIIQGPX PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool NGOPVZTQEGR;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static SIODVFPODKZ[] IODUBMQGGPJ;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static YUWSCVCXGIP[] CWNLTUYOCJB;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private UDGZDIIQGPX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x90A7710", Offset = "0x90A6510", VA = "0x1890A7710")]
		public static void DELFABVRANX(params YUWSCVCXGIP[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x90A7630", Offset = "0x90A6430", VA = "0x1890A7630")]
		public static void DELFABVRANX(params SIODVFPODKZ[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x90A77F0", Offset = "0x90A65F0", VA = "0x1890A77F0")]
		public static void TCUNSLJWHLR(SIODVFPODKZ[] a, YUWSCVCXGIP[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class SZBVQKJSSLG : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x3EFFAF0", Offset = "0x3EFE8F0", VA = "0x183EFFAF0")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private SZBVQKJSSLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class SLEOPYSPNNF
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly YUWSCVCXGIP CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly YUWSCVCXGIP OAJFZUARLKY;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class DGXZMJTLQTF
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly YUWSCVCXGIP CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly YUWSCVCXGIP HNGDQXBUSWO;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly YUWSCVCXGIP EQBTRHPOFEI;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly YUWSCVCXGIP QFJWEQMYGOP;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly YUWSCVCXGIP GKKAYOQFPUT;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly YUWSCVCXGIP CSEQLBDBVPD;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly YUWSCVCXGIP FSQVNVNHHAE;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly YUWSCVCXGIP EKFZRPHMDXQ;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly YUWSCVCXGIP RYGLGFIEATW;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly YUWSCVCXGIP YSJYCPDMXYX;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly YUWSCVCXGIP TJDREAVTYYH;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly YUWSCVCXGIP LLWROSJGPHD;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class KXHQAXRWJQG
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> JCWLPCSCBSQ;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x90A2A00", Offset = "0x90A1800", VA = "0x1890A2A00")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x90A29C0", Offset = "0x90A17C0", VA = "0x1890A29C0")]
		private static object DLKZDPONLYT(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class YSWFBPXVDDS : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3EFE5B0", Offset = "0x3EFD3B0", VA = "0x183EFE5B0")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private YSWFBPXVDDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class BCVKXMATJQJ : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x3F20B90", Offset = "0x3F1F990", VA = "0x183F20B90")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private BCVKXMATJQJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class RINBCHJHZRJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly YUWSCVCXGIP[] ZIXVCAJVFTO;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class NBFPAIELXKK : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3F06970", Offset = "0x3F05770", VA = "0x183F06970")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class UQZSDPCDUNI : YUWSCVCXGIP
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class YEMPHQMWTQD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x3EFA700", Offset = "0x3EF9500", VA = "0x183EFA700")]
				static YEMPHQMWTQD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly YUWSCVCXGIP PKFRARWZTTR;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly YUWSCVCXGIP[] CWNLTUYOCJB;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			private UQZSDPCDUNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
			public CQMBENHOHVQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly CQMBENHOHVQ<object> TBUDEHITKOM;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private NBFPAIELXKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class CUHQTZYZHHD : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x3F01320", Offset = "0x3F00120", VA = "0x183F01320")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class UQZSDPCDUNI : YUWSCVCXGIP
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class YEMPHQMWTQD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x3F1CF00", Offset = "0x3F1BD00", VA = "0x183F1CF00")]
				static YEMPHQMWTQD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly YUWSCVCXGIP PKFRARWZTTR;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly YUWSCVCXGIP[] CWNLTUYOCJB;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			private UQZSDPCDUNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
			public CQMBENHOHVQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly CQMBENHOHVQ<object> TBUDEHITKOM;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private CUHQTZYZHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class NIZFJZDERNJ : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x3F15400", Offset = "0x3F14200", VA = "0x183F15400")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class UQZSDPCDUNI : YUWSCVCXGIP
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class YEMPHQMWTQD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x3F0A5A0", Offset = "0x3F093A0", VA = "0x183F0A5A0")]
				static YEMPHQMWTQD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly YUWSCVCXGIP PKFRARWZTTR;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly YUWSCVCXGIP[] CWNLTUYOCJB;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			private UQZSDPCDUNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
			public CQMBENHOHVQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly CQMBENHOHVQ<object> TBUDEHITKOM;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private NIZFJZDERNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class JNANMYFDHPG : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x3F07790", Offset = "0x3F06590", VA = "0x183F07790")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class UQZSDPCDUNI : YUWSCVCXGIP
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class YEMPHQMWTQD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x3F0D4D0", Offset = "0x3F0C2D0", VA = "0x183F0D4D0")]
				static YEMPHQMWTQD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly YUWSCVCXGIP PKFRARWZTTR;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly YUWSCVCXGIP[] CWNLTUYOCJB;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			private UQZSDPCDUNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
			public CQMBENHOHVQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly CQMBENHOHVQ<object> TBUDEHITKOM;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private JNANMYFDHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class UPKVJCVNZEQ : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x3F21350", Offset = "0x3F20150", VA = "0x183F21350")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class UQZSDPCDUNI : YUWSCVCXGIP
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class YEMPHQMWTQD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x3EFBC40", Offset = "0x3EFAA40", VA = "0x183EFBC40")]
				static YEMPHQMWTQD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly YUWSCVCXGIP PKFRARWZTTR;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly YUWSCVCXGIP[] CWNLTUYOCJB;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			private UQZSDPCDUNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
			public CQMBENHOHVQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly CQMBENHOHVQ<object> TBUDEHITKOM;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private UPKVJCVNZEQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class ZUYQMHMUMRI : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9F70", Offset = "0x3EF8D70", VA = "0x183EF9F70")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class UQZSDPCDUNI : YUWSCVCXGIP
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class YEMPHQMWTQD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x3EFD7B0", Offset = "0x3EFC5B0", VA = "0x183EFD7B0")]
				static YEMPHQMWTQD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly YUWSCVCXGIP PKFRARWZTTR;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly YUWSCVCXGIP[] CWNLTUYOCJB;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			private UQZSDPCDUNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
			public CQMBENHOHVQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly CQMBENHOHVQ<object> TBUDEHITKOM;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private ZUYQMHMUMRI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class FTTCBKKOCAD : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x3F205A0", Offset = "0x3F1F3A0", VA = "0x183F205A0")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class UQZSDPCDUNI : YUWSCVCXGIP
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class YEMPHQMWTQD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x3F14130", Offset = "0x3F12F30", VA = "0x183F14130")]
				static YEMPHQMWTQD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly YUWSCVCXGIP PKFRARWZTTR;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly YUWSCVCXGIP[] CWNLTUYOCJB;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			private UQZSDPCDUNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
			public CQMBENHOHVQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly CQMBENHOHVQ<object> TBUDEHITKOM;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private FTTCBKKOCAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class DJTWBXFBLHD : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x3F195B0", Offset = "0x3F183B0", VA = "0x183F195B0")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class UQZSDPCDUNI : YUWSCVCXGIP
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class YEMPHQMWTQD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0x3F1A210", Offset = "0x3F19010", VA = "0x183F1A210")]
				static YEMPHQMWTQD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly YUWSCVCXGIP PKFRARWZTTR;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly YUWSCVCXGIP[] CWNLTUYOCJB;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			private UQZSDPCDUNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
			public CQMBENHOHVQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly CQMBENHOHVQ<object> TBUDEHITKOM;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private DJTWBXFBLHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class LWAARBCRJDV : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3F1C340", Offset = "0x3F1B140", VA = "0x183F1C340")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class UQZSDPCDUNI : YUWSCVCXGIP
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class YEMPHQMWTQD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x3F1F890", Offset = "0x3F1E690", VA = "0x183F1F890")]
				static YEMPHQMWTQD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly YUWSCVCXGIP PKFRARWZTTR;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly YUWSCVCXGIP[] CWNLTUYOCJB;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			private UQZSDPCDUNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
			public CQMBENHOHVQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly CQMBENHOHVQ<object> TBUDEHITKOM;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private LWAARBCRJDV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class FZKCRANHZYU : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x3F126A0", Offset = "0x3F114A0", VA = "0x183F126A0")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class UQZSDPCDUNI : YUWSCVCXGIP
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class YEMPHQMWTQD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x3F16FF0", Offset = "0x3F15DF0", VA = "0x183F16FF0")]
				static YEMPHQMWTQD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly YUWSCVCXGIP PKFRARWZTTR;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly YUWSCVCXGIP[] CWNLTUYOCJB;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			private UQZSDPCDUNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
			public CQMBENHOHVQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly CQMBENHOHVQ<object> TBUDEHITKOM;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private FZKCRANHZYU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class EKXDTSMKTVW : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x3EF9AF0", Offset = "0x3EF88F0", VA = "0x183EF9AF0")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class UQZSDPCDUNI : YUWSCVCXGIP
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class YEMPHQMWTQD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x3F06690", Offset = "0x3F05490", VA = "0x183F06690")]
				static YEMPHQMWTQD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly YUWSCVCXGIP PKFRARWZTTR;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly YUWSCVCXGIP[] CWNLTUYOCJB;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			private UQZSDPCDUNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
			public CQMBENHOHVQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly CQMBENHOHVQ<object> TBUDEHITKOM;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private EKXDTSMKTVW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class LULQVQFHJQG : YUWSCVCXGIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class YEMPHQMWTQD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x3F26250", Offset = "0x3F25050", VA = "0x183F26250")]
			static YEMPHQMWTQD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class UQZSDPCDUNI : YUWSCVCXGIP
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class YEMPHQMWTQD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly CQMBENHOHVQ<a> VVLJMNHBNOG;

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x3F17EE0", Offset = "0x3F16CE0", VA = "0x183F17EE0")]
				static YEMPHQMWTQD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly YUWSCVCXGIP PKFRARWZTTR;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly YUWSCVCXGIP[] CWNLTUYOCJB;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			private UQZSDPCDUNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
			public CQMBENHOHVQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly YUWSCVCXGIP PKFRARWZTTR;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly CQMBENHOHVQ<object> TBUDEHITKOM;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		private LULQVQFHJQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3444120", Offset = "0x3442F20", VA = "0x183444120", Slot = "4")]
		public CQMBENHOHVQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
}
namespace Utf8Json.Internal
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct ArrayBuffer<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public T[] Buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public int Size;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x58A0BF0", Offset = "0x589F9F0", VA = "0x1858A0BF0")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x58A08F0", Offset = "0x589F6F0", VA = "0x1858A08F0")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x58A0B60", Offset = "0x589F960", VA = "0x1858A0B60")]
		public T[] IIRRLYITOVY()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class HURFYNVHETS<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int ERJULSPSEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object FQLXCPDMCPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int WCXSKSYEYFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] CEOWNCQUSTN;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x50108E0", Offset = "0x500F6E0", VA = "0x1850108E0")]
		public HURFYNVHETS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5010520", Offset = "0x500F320", VA = "0x185010520")]
		public a[] HULSODXTHXB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5010760", Offset = "0x500F560", VA = "0x185010760")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class AZJODAGNXIG : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class KLCODALSDYG : IComparable<KLCODALSDYG>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class BFCQONUWNYK : IEnumerable<KLCODALSDYG>, IEnumerable, IEnumerator<KLCODALSDYG>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int GTWEEXJFPKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private KLCODALSDYG LBVZGXVZPSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int DGBKDPSSRXL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public KLCODALSDYG FNBWZDPUGEI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int QZMPRZMGFLM;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private KLCODALSDYG ZBELTTRWODV
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object UUTAULZFDNA
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
				[DebuggerHidden]
				public BFCQONUWNYK(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
				[DebuggerHidden]
				private void NFYYAPEFSFX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x9097040", Offset = "0x9095E40", VA = "0x189097040", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x90970C0", Offset = "0x9095EC0", VA = "0x1890970C0", Slot = "10")]
				[DebuggerHidden]
				private void USEBYPNATQY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x9096FA0", Offset = "0x9095DA0", VA = "0x189096FA0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<KLCODALSDYG> HQBDXSVWEGM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x9096FA0", Offset = "0x9095DA0", VA = "0x189096FA0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator HTHYFOXNRHD()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly KLCODALSDYG[] FHAGEUMSKLQ;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] DPUTMZUVJXH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong FGOXRCFRNED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int JMWYIQGMJFT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string DZODQURGROO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private KLCODALSDYG[] JEVVRUQERDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] WKPRZHZNZSJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int VQDVFZSZBDN;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x90A2900", Offset = "0x90A1700", VA = "0x1890A2900")]
			public KLCODALSDYG(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x90A23A0", Offset = "0x90A11A0", VA = "0x1890A23A0")]
			public KLCODALSDYG Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x90A2340", Offset = "0x90A1140", VA = "0x1890A2340")]
			public KLCODALSDYG Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x90A25D0", Offset = "0x90A13D0", VA = "0x1890A25D0")]
			public KLCODALSDYG IGKCKJEDOLS(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x90A27C0", Offset = "0x90A15C0", VA = "0x1890A27C0")]
			internal static int YPCBLNUJXMV(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x90A25A0", Offset = "0x90A13A0", VA = "0x1890A25A0", Slot = "4")]
			public int CompareTo(KLCODALSDYG other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x90A2740", Offset = "0x90A1540", VA = "0x1890A2740")]
			[IteratorStateMachine(typeof(BFCQONUWNYK))]
			public IEnumerable<KLCODALSDYG> YDMSHBGTIMG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class OWJIHNXDHKY : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<KLCODALSDYG> JEVVRUQERDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<KLCODALSDYG> NLXTHQCRLAV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<KLCODALSDYG> NUQJCBGEMQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private KLCODALSDYG YDPBNUKPPHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> NVAWWOTZFNA;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> KGFRCTUTHJD
			{
				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0xB611B0", Offset = "0xB5FFB0", VA = "0x180B611B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x90A5FB0", Offset = "0x90A4DB0", VA = "0x1890A5FB0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x1AD5000", Offset = "0x1AD3E00", VA = "0x181AD5000")]
			[DebuggerHidden]
			public OWJIHNXDHKY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x90A5E60", Offset = "0x90A4C60", VA = "0x1890A5E60", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x90A5A00", Offset = "0x90A4800", VA = "0x1890A5A00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x90A5910", Offset = "0x90A4710", VA = "0x1890A5910")]
			private void GWSJMPTZZMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x90A58C0", Offset = "0x90A46C0", VA = "0x1890A58C0")]
			private void GWCOUVMHXEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x90A6000", Offset = "0x90A4E00", VA = "0x1890A6000", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x90A5960", Offset = "0x90A4760", VA = "0x1890A5960", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> XMOFTSWWENA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x90A5960", Offset = "0x90A4760", VA = "0x1890A5960", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly KLCODALSDYG WYBQGJRULHO;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9096EC0", Offset = "0x9095CC0", VA = "0x189096EC0")]
		public AZJODAGNXIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9096670", Offset = "0x9095470", VA = "0x189096670")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9096A40", Offset = "0x9095840", VA = "0x189096A40")]
		public bool KJZUPXKVGOU(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9096930", Offset = "0x9095730", VA = "0x189096930")]
		public bool JRPATTRRPPT([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9096E30", Offset = "0x9095C30", VA = "0x189096E30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9096B50", Offset = "0x9095950", VA = "0x189096B50")]
		private static void SOUTBGKIIUT(IEnumerable<KLCODALSDYG> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9096850", Offset = "0x9095650", VA = "0x189096850", Slot = "5")]
		private IEnumerator HTHYFOXNRHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9096850", Offset = "0x9095650", VA = "0x189096850", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x90968B0", Offset = "0x90956B0", VA = "0x1890968B0")]
		[IteratorStateMachine(typeof(OWJIHNXDHKY))]
		private static IEnumerable<KeyValuePair<string, int>> HZOJRXTDHXY(IEnumerable<KLCODALSDYG> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class TKVDOQHNIAF
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo MCUVKVSLQCW;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x90A6B30", Offset = "0x90A5930", VA = "0x1890A6B30")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x90A6CE0", Offset = "0x90A5AE0", VA = "0x1890A6CE0")]
		public static ulong ZIBOZHJPZRY(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class OEJSCJGYINP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x90A5780", Offset = "0x90A4580", VA = "0x1890A5780")]
		public static void TTGZNIJUGSW(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x90A5660", Offset = "0x90A4460", VA = "0x1890A5660")]
		public static void LTZEHNPKQBQ(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x90A5520", Offset = "0x90A4320", VA = "0x1890A5520")]
		public static byte[] HDZZORZCBLR(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class MLIMDPCQPLH<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		private struct Entry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public byte[] Key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public a Value;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x4870F00", Offset = "0x486FD00", VA = "0x184870F00", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class DFHFVMBOXAZ : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public MLIMDPCQPLH<a> FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] NUQJCBGEMQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int NVGDTVNWOYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] NVAWWOTZFNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int NVQROJBRHVB;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> INZXPJZYPUQ
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xB611B0", Offset = "0xB5FFB0", VA = "0x180B611B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0x41853F0", Offset = "0x41841F0", VA = "0x1841853F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
			[DebuggerHidden]
			public DFHFVMBOXAZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x4183930", Offset = "0x4182730", VA = "0x184183930", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3DD1D80", Offset = "0x3DD0B80", VA = "0x183DD1D80", Slot = "8")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] QZBYTYZMFYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong CXUHEYCELUH;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool XYKXJDYCPDS;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5968190", Offset = "0x5966F90", VA = "0x185968190")]
		public MLIMDPCQPLH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x59680A0", Offset = "0x5966EA0", VA = "0x1859680A0")]
		public MLIMDPCQPLH(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5955240", Offset = "0x5954040", VA = "0x185955240")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5967BA0", Offset = "0x59669A0", VA = "0x185967BA0")]
		private bool TFWTUYMJKKV(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5956E10", Offset = "0x5955C10", VA = "0x185956E10")]
		public bool KJZUPXKVGOU([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x595C970", Offset = "0x595B770", VA = "0x18595C970")]
		private static ulong SITLZOFMXKQ([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x595ED50", Offset = "0x595DB50", VA = "0x18595ED50")]
		private static ulong SITLZOFMXKQ([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x595A020", Offset = "0x5958E20", VA = "0x18595A020")]
		private static int SCATNEMECRW(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5955E60", Offset = "0x5954C60", VA = "0x185955E60", Slot = "4")]
		[IteratorStateMachine(typeof(MLIMDPCQPLH<>.DFHFVMBOXAZ))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x59560D0", Offset = "0x5954ED0", VA = "0x1859560D0", Slot = "5")]
		private IEnumerator HTHYFOXNRHD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class ZMEQZYFHRXK
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3CC03D0", Offset = "0x3CBF1D0", VA = "0x183CC03D0")]
		public static Func<a> OBSORBHOLVA<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0310", Offset = "0x3CBF110", VA = "0x183CC0310")]
		private static c AMXDQPWJMRJ<c>(this object a)
		{
			return (c)null;
		}
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 16)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	internal struct GuidBits
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly Guid Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly byte Byte0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly byte Byte1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly byte Byte2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly byte Byte3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public readonly byte Byte4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public readonly byte Byte5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public readonly byte Byte6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly byte Byte7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly byte Byte8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly byte Byte9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly byte Byte10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public readonly byte Byte11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly byte Byte12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly byte Byte13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public readonly byte Byte14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly byte Byte15;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static byte[] byteToHexStringHigh;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static byte[] byteToHexStringLow;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x909C410", Offset = "0x909B210", VA = "0x18909C410")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x909C420", Offset = "0x909B220", VA = "0x18909C420")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x909C280", Offset = "0x909B080", VA = "0x18909C280")]
		private static byte PBDDNACPTQD(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9095D70", Offset = "0x9094B70", VA = "0x189095D70")]
		private static byte XYWKSNAULNV(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x909BA20", Offset = "0x909A820", VA = "0x18909BA20")]
		public void DOQRKGDHTJZ(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class CTBFYGOXHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9097470", Offset = "0x9096270", VA = "0x189097470")]
		public static bool IWCPFXINOUJ(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x90974E0", Offset = "0x90962E0", VA = "0x1890974E0")]
		public static bool MLARFTXEJMQ(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9097100", Offset = "0x9095F00", VA = "0x189097100")]
		public static sbyte AHTIUPJXNSX([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9097C30", Offset = "0x9096A30", VA = "0x189097C30")]
		public static short VGYYLDZUAJE([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9097480", Offset = "0x9096280", VA = "0x189097480")]
		public static int JBUVSGDFPUU([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9097800", Offset = "0x9096600", VA = "0x189097800")]
		public static long PHLHJIGCBDF([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9097E60", Offset = "0x9096C60", VA = "0x189097E60")]
		public static bool YPMMNLZPFKI(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9097B70", Offset = "0x9096970", VA = "0x189097B70")]
		public static byte RGIZLSEMPNI([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9097270", Offset = "0x9096070", VA = "0x189097270")]
		public static ushort ANYZPWJQLOT([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x90976A0", Offset = "0x90964A0", VA = "0x1890976A0")]
		public static uint NKNBNSRGMQV([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x90973C0", Offset = "0x90961C0", VA = "0x1890973C0")]
		public static ulong FMJYOGZDJIK([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9097550", Offset = "0x9096350", VA = "0x189097550")]
		public static bool MTZZVNHANJJ(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9097C90", Offset = "0x9096A90", VA = "0x189097C90")]
		public static bool YPHQGWSQUDJ(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9097160", Offset = "0x9095F60", VA = "0x189097160")]
		public static bool ANAUELXZYRB(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9097700", Offset = "0x9096500", VA = "0x189097700")]
		public static bool NMSRXEBFZMR(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9097A80", Offset = "0x9096880", VA = "0x189097A80")]
		public static float QGKUWBUAFPO([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x90977A0", Offset = "0x90965A0", VA = "0x1890977A0")]
		public static bool OJSKWCUWVOF(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x90972D0", Offset = "0x90960D0", VA = "0x1890972D0")]
		public static double BMCPBOEQVRD([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9097BD0", Offset = "0x90969D0", VA = "0x189097BD0")]
		public static bool TDVQAMKFEIE(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9094C60", Offset = "0x9093A60", VA = "0x189094C60")]
		public static int QBKOSKMSFAR(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9095310", Offset = "0x9094110", VA = "0x189095310")]
		public static int QTHWNIOLZCK(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x90978B0", Offset = "0x90966B0", VA = "0x1890978B0")]
		public static bool PJWZPSZZMQA([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class GQXGHNSDWBB
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x909B970", Offset = "0x909A770", VA = "0x18909B970")]
		public static bool NRTOXOHUVLL(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class JZPIYLEKYYM
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding IEMVROGCTHN;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class WIGIKUPFTPS
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x909AE20", Offset = "0x9099C20", VA = "0x18909AE20")]
		public static void HCVJMPHKCTD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x909ADB0", Offset = "0x9099BB0", VA = "0x18909ADB0")]
		public static void HCQCPINMTHU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x909AD40", Offset = "0x9099B40", VA = "0x18909AD40")]
		public static void HCKVSBTPJWL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x909ACD0", Offset = "0x9099AD0", VA = "0x18909ACD0")]
		public static void HCFOUUZSALC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x90A8B90", Offset = "0x90A7990", VA = "0x1890A8B90")]
		public static void HFGOFSMELZH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x90A8B20", Offset = "0x90A7920", VA = "0x1890A8B20")]
		public static void HFBHILSHCNY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x90A8740", Offset = "0x90A7540", VA = "0x1890A8740")]
		public static void GPRKSNIPQBU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x90A87B0", Offset = "0x90A75B0", VA = "0x1890A87B0")]
		public static void GPWRPUCMZND(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x90A8650", Offset = "0x90A7450", VA = "0x1890A8650")]
		public static void GPGWXZUUXFC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x90A86C0", Offset = "0x90A74C0", VA = "0x1890A86C0")]
		public static void GPMDVGOSGQL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x90A8920", Offset = "0x90A7720", VA = "0x1890A8920")]
		public static void GQMMHOKFBVE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x90A89A0", Offset = "0x90A77A0", VA = "0x1890A89A0")]
		public static void GQRTEVECLGN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x90A8820", Offset = "0x90A7620", VA = "0x1890A8820")]
		public static void GQBYNAWKIYM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x90A88A0", Offset = "0x90A76A0", VA = "0x1890A88A0")]
		public static void GQHFKHQHSJV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x90A8A20", Offset = "0x90A7820", VA = "0x1890A8A20")]
		public static void GRHNWPLUNOO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x90A8AA0", Offset = "0x90A78A0", VA = "0x1890A8AA0")]
		public static void GRMUTWFRWZX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x90A91F0", Offset = "0x90A7FF0", VA = "0x1890A91F0")]
		public static void ZVMSKDNGQIN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x90A9170", Offset = "0x90A7F70", VA = "0x1890A9170")]
		public static void ZVHLMWTJGXE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x90A90F0", Offset = "0x90A7EF0", VA = "0x1890A90F0")]
		public static void ZVCEPPZLXLV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x90A9070", Offset = "0x90A7E70", VA = "0x1890A9070")]
		public static void ZUWXSJFOOAM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x90A8FF0", Offset = "0x90A7DF0", VA = "0x1890A8FF0")]
		public static void ZURQVCLREPD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x90A8F60", Offset = "0x90A7D60", VA = "0x1890A8F60")]
		public static void ZUMJXVRTVDU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x90A8ED0", Offset = "0x90A7CD0", VA = "0x1890A8ED0")]
		public static void ZUHDAOXWLSL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x90A8E40", Offset = "0x90A7C40", VA = "0x1890A8E40")]
		public static void ZUBWDIDZCHC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x90A8DB0", Offset = "0x90A7BB0", VA = "0x1890A8DB0")]
		public static void ZTWPGBKBSVT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x90A8D20", Offset = "0x90A7B20", VA = "0x1890A8D20")]
		public static void ZTRIIUQEJKK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x90A8C00", Offset = "0x90A7A00", VA = "0x1890A8C00")]
		public static void TUTLYTEEMMM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x90A8C90", Offset = "0x90A7A90", VA = "0x1890A8C90")]
		public static void TUYSVZYBVXV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x909AF70", Offset = "0x9099D70", VA = "0x18909AF70")]
		public static void HDLEEJPCFBE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x909AF00", Offset = "0x9099D00", VA = "0x18909AF00")]
		public static void HDFXHCVEVPV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x909AE90", Offset = "0x9099C90", VA = "0x18909AE90")]
		public static void HDAQJWBHMEM(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class EETIGEEDZLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x909B050", Offset = "0x9099E50", VA = "0x18909B050")]
		public static void HFGOFSMELZH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x909AFE0", Offset = "0x9099DE0", VA = "0x18909AFE0")]
		public static void HFBHILSHCNY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x909A920", Offset = "0x9099720", VA = "0x18909A920")]
		public static void GPRKSNIPQBU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x909A990", Offset = "0x9099790", VA = "0x18909A990")]
		public static void GPWRPUCMZND(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x909A840", Offset = "0x9099640", VA = "0x18909A840")]
		public static void GPGWXZUUXFC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x909A8B0", Offset = "0x90996B0", VA = "0x18909A8B0")]
		public static void GPMDVGOSGQL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x909AAF0", Offset = "0x90998F0", VA = "0x18909AAF0")]
		public static void GQMMHOKFBVE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x909AB60", Offset = "0x9099960", VA = "0x18909AB60")]
		public static void GQRTEVECLGN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x909AA00", Offset = "0x9099800", VA = "0x18909AA00")]
		public static void GQBYNAWKIYM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x909AA70", Offset = "0x9099870", VA = "0x18909AA70")]
		public static void GQHFKHQHSJV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x909ABD0", Offset = "0x90999D0", VA = "0x18909ABD0")]
		public static void GRHNWPLUNOO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x909AC50", Offset = "0x9099A50", VA = "0x18909AC50")]
		public static void GRMUTWFRWZX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x909B640", Offset = "0x909A440", VA = "0x18909B640")]
		public static void ZVMSKDNGQIN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x909B5C0", Offset = "0x909A3C0", VA = "0x18909B5C0")]
		public static void ZVHLMWTJGXE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x909B540", Offset = "0x909A340", VA = "0x18909B540")]
		public static void ZVCEPPZLXLV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x909B4C0", Offset = "0x909A2C0", VA = "0x18909B4C0")]
		public static void ZUWXSJFOOAM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x909B440", Offset = "0x909A240", VA = "0x18909B440")]
		public static void ZURQVCLREPD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x909B3C0", Offset = "0x909A1C0", VA = "0x18909B3C0")]
		public static void ZUMJXVRTVDU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x909B340", Offset = "0x909A140", VA = "0x18909B340")]
		public static void ZUHDAOXWLSL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x909B2C0", Offset = "0x909A0C0", VA = "0x18909B2C0")]
		public static void ZUBWDIDZCHC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x909B240", Offset = "0x909A040", VA = "0x18909B240")]
		public static void ZTWPGBKBSVT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x909B1C0", Offset = "0x9099FC0", VA = "0x18909B1C0")]
		public static void ZTRIIUQEJKK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x909B0C0", Offset = "0x9099EC0", VA = "0x18909B0C0")]
		public static void TUTLYTEEMMM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x909B140", Offset = "0x9099F40", VA = "0x18909B140")]
		public static void TUYSVZYBVXV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x909AF70", Offset = "0x9099D70", VA = "0x18909AF70")]
		public static void HDLEEJPCFBE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x909AF00", Offset = "0x9099D00", VA = "0x18909AF00")]
		public static void HDFXHCVEVPV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x909AE90", Offset = "0x9099C90", VA = "0x18909AE90")]
		public static void HDAQJWBHMEM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x909AE20", Offset = "0x9099C20", VA = "0x18909AE20")]
		public static void HCVJMPHKCTD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x909ADB0", Offset = "0x9099BB0", VA = "0x18909ADB0")]
		public static void HCQCPINMTHU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x909AD40", Offset = "0x9099B40", VA = "0x18909AD40")]
		public static void HCKVSBTPJWL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x909ACD0", Offset = "0x9099AD0", VA = "0x18909ACD0")]
		public static void HCFOUUZSALC(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class RPMURCTLSTT
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool XYKXJDYCPDS;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x90BAAF0", Offset = "0x90B98F0", VA = "0x1890BAAF0")]
		public static void CRBBVXUVWTJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x90BC540", Offset = "0x90BB340", VA = "0x1890BC540")]
		public static void UXUZETVERWC(JsonWriter a, byte[] b)
		{
		}
	}
}
namespace Utf8Json.Internal.DoubleConversion
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	internal struct DiyFp
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public ulong f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public int e;

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x2924A00", Offset = "0x2923800", VA = "0x182924A00")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x90ADD50", Offset = "0x90ACB50", VA = "0x1890ADD50")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x90ADCB0", Offset = "0x90ACAB0", VA = "0x1890ADCB0")]
		public static DiyFp IAKGTALPFKQ(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x90ADCC0", Offset = "0x90ACAC0", VA = "0x1890ADCC0")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x90ADC10", Offset = "0x90ACA10", VA = "0x1890ADC10")]
		public static DiyFp DNJLNLFDHFQ(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x90ADD60", Offset = "0x90ACB60", VA = "0x1890ADD60")]
		public void UNSZZZHTNTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x90ADDA0", Offset = "0x90ACBA0", VA = "0x1890ADDA0")]
		public static DiyFp UNSZZZHTNTZ(DiyFp a)
		{
			return default(DiyFp);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal struct StringBuilder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public byte[] buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public int offset;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xB7E0C0", Offset = "0xB7CEC0", VA = "0x180B7E0C0")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x90BDE60", Offset = "0x90BCC60", VA = "0x1890BDE60")]
		public void MWOTPRMODLA(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x90BDDE0", Offset = "0x90BCBE0", VA = "0x1890BDDE0")]
		public void FDVCDUKJXVY(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x90BDB40", Offset = "0x90BC940", VA = "0x1890BDB40")]
		public void BQJEOFHZXGK(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x90BDBC0", Offset = "0x90BC9C0", VA = "0x1890BDBC0")]
		public void BQJEOFHZXGK(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x90BDD60", Offset = "0x90BCB60", VA = "0x1890BDD60")]
		public void EDWUUSAMAAA(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x90BDC60", Offset = "0x90BCA60", VA = "0x1890BDC60")]
		public void CRXOPFWWEQH(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class LPVWEECYDKP
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		private enum FastDtoaMode
		{
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			FAST_DTOA_SHORTEST,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			FAST_DTOA_SHORTEST_SINGLE
		}

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		private enum DtoaMode
		{
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			SHORTEST,
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			SHORTEST_SINGLE
		}

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			NO_FLAGS = 0,
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			EMIT_POSITIVE_EXPONENT_SIGN = 1,
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			EMIT_TRAILING_DECIMAL_POINT = 2,
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			EMIT_TRAILING_ZERO_AFTER_POINT = 4,
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			UNIQUE_ZERO = 8
		}

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[ThreadStatic]
		private static byte[] UBSRTFVEVKE;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] TMAFWQIJWYM;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] UJYHWMKZFMC;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] QQXVOVTRQWH;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags NWAOCADNDLK;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char ASPUGMIVWRW;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int UOKJDZICGUI;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int OUTSDLRSLJG;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] IZGUHWWJIOS;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x90B6B80", Offset = "0x90B5980", VA = "0x1890B6B80")]
		private static byte[] MAMTRNMZQUA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x90B7A10", Offset = "0x90B6810", VA = "0x1890B7A10")]
		private static byte[] SHUKIGZYXZS(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x90B7C10", Offset = "0x90B6A10", VA = "0x1890B7C10")]
		public static int THDCOOXVWRN(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x90B7AF0", Offset = "0x90B68F0", VA = "0x1890B7AF0")]
		public static int THDCOOXVWRN(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x90B7470", Offset = "0x90B6270", VA = "0x1890B7470")]
		private static bool PCWCEJJKCIJ(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x90B7920", Offset = "0x90B6720", VA = "0x1890B7920")]
		private static void RRMQFVTLDZH(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x90B7560", Offset = "0x90B6360", VA = "0x1890B7560")]
		private static bool RLJJFGGUPVP(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x90B6FF0", Offset = "0x90B5DF0", VA = "0x1890B6FF0")]
		private static bool OKHJYCVMKFX(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x90B6480", Offset = "0x90B5280", VA = "0x1890B6480")]
		private static bool CZDKGXMJJEK(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x90B6580", Offset = "0x90B5380", VA = "0x1890B6580")]
		private static bool GLJNAFEOVBF(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x90B7F20", Offset = "0x90B6D20", VA = "0x1890B7F20")]
		private static bool ZJPLFSGXQZY(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x90B6C50", Offset = "0x90B5A50", VA = "0x1890B6C50")]
		private static void NMYVZTIBIQG(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x90B6750", Offset = "0x90B5550", VA = "0x1890B6750")]
		private static void JXZKBRECXUS(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x90B7D30", Offset = "0x90B6B30", VA = "0x1890B7D30")]
		private static bool VYNZUTVRWDJ(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
		{
			return default(bool);
		}
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	internal struct UnionDoubleULong
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public double d;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public ulong u64;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal struct UnionFloatUInt
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public float f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public uint u32;
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal struct Double
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private ulong d64_;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x90AE410", Offset = "0x90AD210", VA = "0x1890AE410")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x90AE370", Offset = "0x90AD170", VA = "0x1890AE370")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x90ADE20", Offset = "0x90ACC20", VA = "0x1890ADE20")]
		public DiyFp CQUSJUIJSSY()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x90AE230", Offset = "0x90AD030", VA = "0x1890AE230")]
		public DiyFp VYTPBMNFPNV()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xC9F850", Offset = "0xC9E650", VA = "0x180C9F850")]
		public ulong BYZSHUUFKDM()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x90AE0C0", Offset = "0x90ACEC0", VA = "0x1890AE0C0")]
		public double MVCDUOWMTCU()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x90AE000", Offset = "0x90ACE00", VA = "0x1890AE000")]
		public double JTTZLOIGPCQ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x90AE2B0", Offset = "0x90AD0B0", VA = "0x1890AE2B0")]
		public int WCZXBPVCKNV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x90AE1D0", Offset = "0x90ACFD0", VA = "0x1890AE1D0")]
		public ulong RUYIUTVBCYP()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x90AE0A0", Offset = "0x90ACEA0", VA = "0x1890AE0A0")]
		public bool LPNSNZTPGYE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x90AE1B0", Offset = "0x90ACFB0", VA = "0x1890AE1B0")]
		public bool PTYCEGFTJEH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x90AE200", Offset = "0x90AD000", VA = "0x1890AE200")]
		public bool USFGBROCLIB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x90ADDF0", Offset = "0x90ACBF0", VA = "0x1890ADDF0")]
		public bool ALUQCLOHXQM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x90AE140", Offset = "0x90ACF40", VA = "0x1890AE140")]
		public int OQUJFVOPYNP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x90ADEB0", Offset = "0x90ACCB0", VA = "0x1890ADEB0")]
		public void EGMIIEZPOSL([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x90AE160", Offset = "0x90ACF60", VA = "0x1890AE160")]
		public bool PMRQHSJNBCR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3C4CB00", Offset = "0x3C4B900", VA = "0x183C4CB00")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x90ADE90", Offset = "0x90ACC90", VA = "0x1890ADE90")]
		public static int DIHVCNNJHSE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x90ADFF0", Offset = "0x90ACDF0", VA = "0x1890ADFF0")]
		public static double GICRPVVZUSA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x90AE2E0", Offset = "0x90AD0E0", VA = "0x1890AE2E0")]
		public static ulong ZVOYTDONYOP(DiyFp a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal struct Single
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private uint d32_;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x1631470", Offset = "0x1630270", VA = "0x181631470")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x90BD920", Offset = "0x90BC720", VA = "0x1890BD920")]
		public DiyFp CQUSJUIJSSY()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xD2C740", Offset = "0xD2B540", VA = "0x180D2C740")]
		public uint HWNOEMHDIAB()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x90BDB20", Offset = "0x90BC920", VA = "0x1890BDB20")]
		public int WCZXBPVCKNV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x90BDB00", Offset = "0x90BC900", VA = "0x1890BDB00")]
		public uint RUYIUTVBCYP()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x90BDAB0", Offset = "0x90BC8B0", VA = "0x1890BDAB0")]
		public bool LPNSNZTPGYE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x90BD980", Offset = "0x90BC780", VA = "0x1890BD980")]
		public void EGMIIEZPOSL([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x90BDAC0", Offset = "0x90BC8C0", VA = "0x1890BDAC0")]
		public bool PMRQHSJNBCR()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	internal struct CachedPower
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly ulong significand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public readonly short binary_exponent;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly short decimal_exponent;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x90AD770", Offset = "0x90AC570", VA = "0x1890AD770")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class AHJGMOGXKWA
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] DBGUMDEMJOR;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x90A9EB0", Offset = "0x90A8CB0", VA = "0x1890A9EB0")]
		public static void SCHRPDGZVYB(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x90A9DE0", Offset = "0x90A8BE0", VA = "0x1890A9DE0")]
		public static void JZUZARRVYNI(int a, [Out] DiyFp b, [Out] int c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	internal struct Vector
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public readonly byte[] bytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public readonly int start;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly int _length;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public byte this[int i]
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x90C03D0", Offset = "0x90BF1D0", VA = "0x1890C03D0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x59D2660", Offset = "0x59D1460", VA = "0x1859D2660")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B5A620", Offset = "0x2B59420", VA = "0x182B5A620")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x90C0370", Offset = "0x90BF170", VA = "0x1890C0370")]
		public Vector FABJRSADCYB(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class CAAYXGDYSLH
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] GOEKYCLJAHN;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] OEIEFJIQJTM;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int BVGSEBDECXJ;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x90ABC70", Offset = "0x90AAA70", VA = "0x1890ABC70")]
		private static byte[] FGRHMMBJEWL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x90ABA70", Offset = "0x90AA870", VA = "0x1890ABA70")]
		private static Vector BSCWOWFSZNH(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x90AC260", Offset = "0x90AB060", VA = "0x1890AC260")]
		private static Vector NEAAHGBIZJV(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x90AC1D0", Offset = "0x90AAFD0", VA = "0x1890AC1D0")]
		private static void LPZBYGWELZM(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x90AC710", Offset = "0x90AB510", VA = "0x1890AC710")]
		private static void RIXEXTXLFXR(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x90AC140", Offset = "0x90AAF40", VA = "0x1890AC140")]
		private static ulong JECRKJSGXSG(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x90AD1D0", Offset = "0x90ABFD0", VA = "0x1890AD1D0")]
		private static void WOMOHDBLLGY(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x90AC340", Offset = "0x90AB140", VA = "0x1890AC340")]
		private static bool OJAUOWPPZGP(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x90ACA00", Offset = "0x90AB800", VA = "0x1890ACA00")]
		private static DiyFp UITZLGGKQYM(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x90ACB90", Offset = "0x90AB990", VA = "0x1890ACB90")]
		private static bool UUCJTGDARIS(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x90ABB50", Offset = "0x90AA950", VA = "0x1890ABB50")]
		private static bool FEJWQUDNFBI(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x90AC020", Offset = "0x90AAE20", VA = "0x1890AC020")]
		public static double? FSSSAOTIFBE(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x90ABD50", Offset = "0x90AAB50", VA = "0x1890ABD50")]
		public static float? FSIEGBFNMEM(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class IUBSLKUWVGX
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] IQPJWWFRTRR;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] UJYHWMKZFMC;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] QQXVOVTRQWH;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] NIQRFDCUWRL;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int MIEQVBVUFVX;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] FRUENOJDHVB;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int AEMLFOPSNDF;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x90B3040", Offset = "0x90B1E40", VA = "0x1890B3040")]
		private static byte[] HMVRGCMUZSW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x90B3120", Offset = "0x90B1F20", VA = "0x1890B3120")]
		public static bool OJSKWCUWVOF(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x90B3260", Offset = "0x90B2060", VA = "0x1890B3260")]
		public static bool TDVQAMKFEIE(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x90B2EE0", Offset = "0x90B1CE0", VA = "0x1890B2EE0")]
		private static bool CWJMQRDLYWZ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x90B33A0", Offset = "0x90B21A0", VA = "0x1890B33A0")]
		private static bool WABLXOMZFWQ(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x90B3670", Offset = "0x90B2470", VA = "0x1890B3670")]
		private static bool WCHDJMHMZSF(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x90B2E70", Offset = "0x90B1C70", VA = "0x1890B2E70")]
		private static bool AWWQBVPMURJ(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x90B3020", Offset = "0x90B1E20", VA = "0x1890B3020")]
		private static double ESVRVTEOFEG(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x90B3750", Offset = "0x90B2550", VA = "0x1890B3750")]
		private static double XJRZVYYPCQY(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class JRBRQIVJJXY<a> : CQMBENHOHVQ<a[]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly HURFYNVHETS<a> EHOADOBANJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour KWFQIIBPULL;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x1721980", Offset = "0x1720780", VA = "0x181721980")]
		public JRBRQIVJJXY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
		public JRBRQIVJJXY(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x51ED780", Offset = "0x51EC580", VA = "0x1851ED780", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x51ED440", Offset = "0x51EC240", VA = "0x1851ED440", Slot = "5")]
		public a[] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class WCBTVGZDRTZ<a> : CQMBENHOHVQ<ArraySegment<a>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly HURFYNVHETS<a> EHOADOBANJV;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x68654E0", Offset = "0x68642E0", VA = "0x1868654E0", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6865070", Offset = "0x6863E70", VA = "0x186865070", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class JRQPAFGYFWZ<a> : CQMBENHOHVQ<List<a>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour KWFQIIBPULL;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1721980", Offset = "0x1720780", VA = "0x181721980")]
		public JRQPAFGYFWZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAC9210", Offset = "0xAC8010", VA = "0x180AC9210")]
		public JRQPAFGYFWZ(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x51F2BC0", Offset = "0x51F19C0", VA = "0x1851F2BC0", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x51F1F30", Offset = "0x51F0D30", VA = "0x1851F1F30", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class LUWLGLFUGFB<a, b, c, d> : CQMBENHOHVQ<d>, SIODVFPODKZ where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x547D0A0", Offset = "0x547BEA0", VA = "0x18547D0A0", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x547C410", Offset = "0x547B210", VA = "0x18547C410", Slot = "5")]
		public d Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c LKIJDWFTBAX(d a);

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract b Create();

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void Add(b collection, int index, a value);

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract d Complete(b intermediateCollection);

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		protected LUWLGLFUGFB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class LVWTSTBHBJU<a, b, c> : LUWLGLFUGFB<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x547E140", Offset = "0x547CF40", VA = "0x18547E140", Slot = "6")]
		protected override IEnumerator<a> LKIJDWFTBAX(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		protected LVWTSTBHBJU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class LWCAPZVEKVD<a, b> : LVWTSTBHBJU<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xB2CD20", Offset = "0xB2BB20", VA = "0x180B2CD20", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class RMRYBXNTOMT<a, b> : LWCAPZVEKVD<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8080", Offset = "0x5DB6E80", VA = "0x185DB8080", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7F80", Offset = "0x5DB6D80", VA = "0x185DB7F80", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class GAMBODOCFYW<a> : LUWLGLFUGFB<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4F76D50", Offset = "0x4F75B50", VA = "0x184F76D50", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xB2CD20", Offset = "0xB2BB20", VA = "0x180B2CD20", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x41C6870", Offset = "0x41C5670", VA = "0x1841C6870", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4720E50", Offset = "0x471FC50", VA = "0x184720E50", Slot = "6")]
		protected override LinkedList<a>.Enumerator LKIJDWFTBAX(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class FBFRNQGQHIH<a> : LUWLGLFUGFB<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4017D40", Offset = "0x4016B40", VA = "0x184017D40", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4185D10", Offset = "0x4184B10", VA = "0x184185D10", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x4E7F8B0", Offset = "0x4E7E6B0", VA = "0x184E7F8B0", Slot = "6")]
		protected override Queue<a>.Enumerator LKIJDWFTBAX(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xB2CD20", Offset = "0xB2BB20", VA = "0x180B2CD20", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class ZSMKKWNDZGR<a> : LUWLGLFUGFB<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB430", Offset = "0x3EDA230", VA = "0x183EDB430", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4016780", Offset = "0x4015580", VA = "0x184016780", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x40167C0", Offset = "0x40155C0", VA = "0x1840167C0", Slot = "6")]
		protected override Stack<a>.Enumerator LKIJDWFTBAX(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4016610", Offset = "0x4015410", VA = "0x184016610", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class QQUYHWSSIZH<a> : LUWLGLFUGFB<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x5D32210", Offset = "0x5D31010", VA = "0x185D32210", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xB2CD20", Offset = "0xB2BB20", VA = "0x180B2CD20", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5D32250", Offset = "0x5D31050", VA = "0x185D32250", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x5D322B0", Offset = "0x5D310B0", VA = "0x185D322B0", Slot = "6")]
		protected override HashSet<a>.Enumerator LKIJDWFTBAX(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4014F40", Offset = "0x4013D40", VA = "0x184014F40")]
		public QQUYHWSSIZH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class XROYZIYAFKT<a> : LVWTSTBHBJU<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB430", Offset = "0x3EDA230", VA = "0x183EDB430", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB510", Offset = "0x3EDA310", VA = "0x183EDB510", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB5B0", Offset = "0x3EDA3B0", VA = "0x183EDB5B0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class DJPHGQOMPYI<a> : LVWTSTBHBJU<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x4017D40", Offset = "0x4016B40", VA = "0x184017D40", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x4185D10", Offset = "0x4184B10", VA = "0x184185D10", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB2CD20", Offset = "0xB2BB20", VA = "0x180B2CD20", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class DIRJJCNPSKQ<a> : LVWTSTBHBJU<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x4017D40", Offset = "0x4016B40", VA = "0x184017D40", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x4185D10", Offset = "0x4184B10", VA = "0x184185D10", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB2CD20", Offset = "0xB2BB20", VA = "0x180B2CD20", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class ELTAJGDOSKO<a> : LVWTSTBHBJU<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x484D650", Offset = "0x484C450", VA = "0x18484D650", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x4016780", Offset = "0x4015580", VA = "0x184016780", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x484D6B0", Offset = "0x484C4B0", VA = "0x18484D6B0", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x484D6F0", Offset = "0x484C4F0", VA = "0x18484D6F0")]
		public ELTAJGDOSKO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class DZMCLUBLZDE<a, b> : CQMBENHOHVQ<IGrouping<a, b>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x41C6C40", Offset = "0x41C5A40", VA = "0x1841C6C40", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x41C68D0", Offset = "0x41C56D0", VA = "0x1841C68D0", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class NQSSZJFMZFR<a, b> : CQMBENHOHVQ<ILookup<a, b>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x59FB4E0", Offset = "0x59FA2E0", VA = "0x1859FB4E0", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x59FB180", Offset = "0x59F9F80", VA = "0x1859FB180", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class HGQHSXNUBCX<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a IBCPJYJQVFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> SXUZGQCUQZP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x5000870", Offset = "0x4FFF670", VA = "0x185000870", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5000750", Offset = "0x4FFF550", VA = "0x185000750")]
		public HGQHSXNUBCX(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x50006B0", Offset = "0x4FFF4B0", VA = "0x1850006B0", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5000720", Offset = "0x4FFF520", VA = "0x185000720", Slot = "6")]
		private IEnumerator HTHYFOXNRHD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class BPNXCIJRNAM<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> LZHRYQBQTHI;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x7145530", Offset = "0x7144330", VA = "0x187145530", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public BPNXCIJRNAM(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7145390", Offset = "0x7144190", VA = "0x187145390", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x7145480", Offset = "0x7144280", VA = "0x187145480", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7145480", Offset = "0x7144280", VA = "0x187145480", Slot = "7")]
		private IEnumerator HTHYFOXNRHD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class HHGFOKOLLHD<a> : CQMBENHOHVQ<a>, SIODVFPODKZ where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5000B40", Offset = "0x4FFF940", VA = "0x185000B40", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5000920", Offset = "0x4FFF720", VA = "0x185000920", Slot = "5")]
		public a Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public HHGFOKOLLHD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class JJVIBQKZFND : CQMBENHOHVQ<IEnumerable>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly CQMBENHOHVQ<IEnumerable> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x90B4EA0", Offset = "0x90B3CA0", VA = "0x1890B4EA0", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x90B4C90", Offset = "0x90B3A90", VA = "0x1890B4C90", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public JJVIBQKZFND()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class HKROUHVBXTJ : CQMBENHOHVQ<ICollection>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly CQMBENHOHVQ<ICollection> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x90B1990", Offset = "0x90B0790", VA = "0x1890B1990", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x90B1780", Offset = "0x90B0580", VA = "0x1890B1780", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public HKROUHVBXTJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class GSIZZCVKGJB : CQMBENHOHVQ<IList>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly CQMBENHOHVQ<IList> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x90B0780", Offset = "0x90AF580", VA = "0x1890B0780", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x90B0570", Offset = "0x90AF370", VA = "0x1890B0570", Slot = "5")]
		public IList Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public GSIZZCVKGJB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class QRBKYQPMXBM<a> : LWCAPZVEKVD<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x4017D40", Offset = "0x4016B40", VA = "0x184017D40", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x4017EA0", Offset = "0x4016CA0", VA = "0x184017EA0", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class ZUQSEQVTRBK<a> : LVWTSTBHBJU<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x4017D40", Offset = "0x4016B40", VA = "0x184017D40", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x4017EA0", Offset = "0x4016CA0", VA = "0x184017EA0", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x4017E30", Offset = "0x4016C30", VA = "0x184017E30", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class UHMQEJJOJTA<a> : LVWTSTBHBJU<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D1C0", Offset = "0x5D2BFC0", VA = "0x185D2D1C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x4016780", Offset = "0x4015580", VA = "0x184016780", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6399730", Offset = "0x6398530", VA = "0x186399730", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6399860", Offset = "0x6398660", VA = "0x186399860")]
		public UHMQEJJOJTA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class QPBNKGBXTZM<a> : LVWTSTBHBJU<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D1C0", Offset = "0x5D2BFC0", VA = "0x185D2D1C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x4016780", Offset = "0x4015580", VA = "0x184016780", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x484D6B0", Offset = "0x484C4B0", VA = "0x18484D6B0", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x484D6F0", Offset = "0x484C4F0", VA = "0x18484D6F0")]
		public QPBNKGBXTZM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class DTLPPVVVZHU<a> : LVWTSTBHBJU<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x41C6780", Offset = "0x41C5580", VA = "0x1841C6780", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xB2CD20", Offset = "0xB2BB20", VA = "0x180B2CD20", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x41C6870", Offset = "0x41C5670", VA = "0x1841C6870", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class AUMNZUPTPGK<a> : LWCAPZVEKVD<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x4017D40", Offset = "0x4016B40", VA = "0x184017D40", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x4185D10", Offset = "0x4184B10", VA = "0x184185D10", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class IRIFVLCJSCR<a> : LWCAPZVEKVD<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4017D40", Offset = "0x4016B40", VA = "0x184017D40", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x4185D10", Offset = "0x4184B10", VA = "0x184185D10", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class IJSCVDZITIY<a> : LVWTSTBHBJU<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB430", Offset = "0x3EDA230", VA = "0x183EDB430", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x4016780", Offset = "0x4015580", VA = "0x184016780", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x50FF410", Offset = "0x50FE210", VA = "0x1850FF410", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class RCETYRODQGV
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		private enum DateTimeComponents
		{
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			Unknown,
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			Year,
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			YearMonth,
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			YearMonthDay,
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			YearMonthDayTime
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x90BA880", Offset = "0x90B9680", VA = "0x1890BA880")]
		public static DateTime SYXIJJRYBQN(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x90BA940", Offset = "0x90B9740", VA = "0x1890BA940")]
		public static bool XQARRQLIHOU(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x90BA5F0", Offset = "0x90B93F0", VA = "0x1890BA5F0")]
		public static bool NXTQUWNRCPC(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x90BA3E0", Offset = "0x90B91E0", VA = "0x1890BA3E0")]
		public static bool NXTQUWNRCPC(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x90BA1B0", Offset = "0x90B8FB0", VA = "0x1890BA1B0")]
		public static bool HKUGMAGXFMK(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class WRIHWHOYOWR : CQMBENHOHVQ<DateTime>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly CQMBENHOHVQ<DateTime> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x90C0E30", Offset = "0x90BFC30", VA = "0x1890C0E30", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x90C0CB0", Offset = "0x90BFAB0", VA = "0x1890C0CB0", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x90C08B0", Offset = "0x90BF6B0", VA = "0x1890C08B0")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public WRIHWHOYOWR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class KHUUCGAMAXG : CQMBENHOHVQ<DateTimeOffset>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly CQMBENHOHVQ<DateTimeOffset> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x90B5980", Offset = "0x90B4780", VA = "0x1890B5980", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x90B5530", Offset = "0x90B4330", VA = "0x1890B5530", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x90B55A0", Offset = "0x90B43A0", VA = "0x1890B55A0")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public KHUUCGAMAXG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class PRHFUZSDVRH : CQMBENHOHVQ<TimeSpan>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly CQMBENHOHVQ<TimeSpan> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] QFIKUZHEAHX;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x90B9900", Offset = "0x90B8700", VA = "0x1890B9900", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x90B9880", Offset = "0x90B8680", VA = "0x1890B9880", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x90B9490", Offset = "0x90B8290", VA = "0x1890B9490")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public PRHFUZSDVRH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class QCJCXVPWCDK<a, b, c, d, e> : CQMBENHOHVQ<e>, SIODVFPODKZ where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5CD9CF0", Offset = "0x5CD8AF0", VA = "0x185CD9CF0", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2FE0", Offset = "0x5CD1DE0", VA = "0x185CD2FE0", Slot = "5")]
		public e Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d LKIJDWFTBAX(e a);

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract c Create();

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void Add(c collection, int index, a key, b value);

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract e Complete(c intermediateCollection);

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		protected QCJCXVPWCDK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class QCOJVCJTLOT<a, b, c, d> : QCJCXVPWCDK<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x547E140", Offset = "0x547CF40", VA = "0x18547E140", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> LKIJDWFTBAX(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		protected QCOJVCJTLOT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class QDOSHKFGGTM<a, b, c> : QCOJVCJTLOT<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xB2CD20", Offset = "0xB2BB20", VA = "0x180B2CD20", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class GPZTNEMZTGE<a, b> : QCJCXVPWCDK<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x4F91200", Offset = "0x4F90000", VA = "0x184F91200", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xB2CD20", Offset = "0xB2BB20", VA = "0x180B2CD20", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x4F913F0", Offset = "0x4F901F0", VA = "0x184F913F0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x4F91620", Offset = "0x4F90420", VA = "0x184F91620", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator LKIJDWFTBAX(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x4F916F0", Offset = "0x4F904F0", VA = "0x184F916F0")]
		public GPZTNEMZTGE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class IJUEDXBBTAQ<a, b, c> : QDOSHKFGGTM<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x50FF570", Offset = "0x50FE370", VA = "0x1850FF570", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x50FF760", Offset = "0x50FE560", VA = "0x1850FF760", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class YUWEUWZFGWR<a, b> : QCOJVCJTLOT<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3FCCA20", Offset = "0x3FCB820", VA = "0x183FCCA20", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3FCCB90", Offset = "0x3FCB990", VA = "0x183FCCB90", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB2CD20", Offset = "0xB2BB20", VA = "0x180B2CD20", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class NDFBLMJZVHZ<a, b> : QDOSHKFGGTM<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3FCCA20", Offset = "0x3FCB820", VA = "0x183FCCA20", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3FCCB90", Offset = "0x3FCB990", VA = "0x183FCCB90", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class FUEXWGEVWKD<a, b> : QCJCXVPWCDK<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3FCCA20", Offset = "0x3FCB820", VA = "0x183FCCA20", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB2CD20", Offset = "0xB2BB20", VA = "0x180B2CD20", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3FCCB90", Offset = "0x3FCB990", VA = "0x183FCCB90", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x4E8FB10", Offset = "0x4E8E910", VA = "0x184E8FB10", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator LKIJDWFTBAX(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class LDCRCBCPHHY<a, b> : QCOJVCJTLOT<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3FCCA20", Offset = "0x3FCB820", VA = "0x183FCCA20", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x544F200", Offset = "0x544E000", VA = "0x18544F200", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x544F270", Offset = "0x544E070", VA = "0x18544F270", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class ZNNMESBZOHF<a, b> : QCOJVCJTLOT<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x4014E40", Offset = "0x4013C40", VA = "0x184014E40", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xB2CD20", Offset = "0xB2BB20", VA = "0x180B2CD20", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x4014EE0", Offset = "0x4013CE0", VA = "0x184014EE0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x4014F40", Offset = "0x4013D40", VA = "0x184014F40")]
		public ZNNMESBZOHF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class UARSGBEPWDV<a, b> : QDOSHKFGGTM<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6395B70", Offset = "0x6394970", VA = "0x186395B70", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3FCCB90", Offset = "0x3FCB990", VA = "0x183FCCB90", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class HJTQJSZCIVP<a> : CQMBENHOHVQ<a>, SIODVFPODKZ where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x5004700", Offset = "0x5003500", VA = "0x185004700", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x50044D0", Offset = "0x50032D0", VA = "0x1850044D0", Slot = "5")]
		public a Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public HJTQJSZCIVP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class HYETMAWOSHF : CQMBENHOHVQ<IDictionary>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly CQMBENHOHVQ<IDictionary> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x90B2420", Offset = "0x90B1220", VA = "0x1890B2420", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x90B2240", Offset = "0x90B1040", VA = "0x1890B2240", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public HYETMAWOSHF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class YLSSVUAUNTL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x90C3010", Offset = "0x90C1E10", VA = "0x1890C3010")]
		public static object WIEVPRKTSKZ(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x90C27F0", Offset = "0x90C15F0", VA = "0x1890C27F0")]
		public static object QSSFKBYDTCU(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class DRZPPLYHKKG<a> : CQMBENHOHVQ<a>, SIODVFPODKZ, ZUVGKIZOTUL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class IRPKOOLLDLU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type QROGATZCDZK;

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IRPKOOLLDLU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x510EB50", Offset = "0x510D950", VA = "0x18510EB50")]
			internal bool SDEWHCEAJWN(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class IRURLVFIMXD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string IXKEGLOTSDY;

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IRURLVFIMXD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x510F780", Offset = "0x510E580", VA = "0x18510F780")]
			internal bool SCZPJVKDALE(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class IREWUAXQKPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> LHPMZQDLOJT;

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IREWUAXQKPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x510CAC0", Offset = "0x510B8C0", VA = "0x18510CAC0")]
			internal void SCUIMOQFQZV(JsonWriter a, a b, YUWSCVCXGIP c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class IRKDRHRNUAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> RHHMEJUSUBS;

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IRKDRHRNUAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x510D280", Offset = "0x510C080", VA = "0x18510D280")]
			internal a SCPBPHWIHOM(JsonReader a, YUWSCVCXGIP b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly MLIMDPCQPLH<a> XJAMZETWHMC;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> YAWXTOXUMPO;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> AWKEVBTATOQ;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> VKNMWFETOEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool ZEGYAYVJQPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> QXKVIXDZHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> UVNHTIGKVEW;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x41A2C60", Offset = "0x41A1A60", VA = "0x1841A2C60")]
		static DRZPPLYHKKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x41A5F20", Offset = "0x41A4D20", VA = "0x1841A5F20")]
		public DRZPPLYHKKG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x419D4C0", Offset = "0x419C2C0", VA = "0x18419D4C0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x419BA00", Offset = "0x419A800", VA = "0x18419BA00", Slot = "5")]
		public a Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x419C220", Offset = "0x419B020", VA = "0x18419C220", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, a b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x419CB30", Offset = "0x419B930", VA = "0x18419CB30", Slot = "7")]
		public a LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class LRHZAMNNGRU<a> : CQMBENHOHVQ<a[,]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x547A5C0", Offset = "0x54793C0", VA = "0x18547A5C0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x547A210", Offset = "0x5479010", VA = "0x18547A210", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public LRHZAMNNGRU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class IIKEGRJRJOU<a> : CQMBENHOHVQ<a[,,]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x50F9910", Offset = "0x50F8710", VA = "0x1850F9910", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x50F9410", Offset = "0x50F8210", VA = "0x1850F9410", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public IIKEGRJRJOU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class ZJSLRFTEOGU<a> : CQMBENHOHVQ<a[,,,]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x3FD8B70", Offset = "0x3FD7970", VA = "0x183FD8B70", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x3FD8530", Offset = "0x3FD7330", VA = "0x183FD8530", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public ZJSLRFTEOGU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class MTKVQGJAVOK<a> : CQMBENHOHVQ<a?>, SIODVFPODKZ where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5975710", Offset = "0x5974510", VA = "0x185975710", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x5975460", Offset = "0x5974260", VA = "0x185975460", Slot = "5")]
		public a? Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public MTKVQGJAVOK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class IAOROBGWYUU<a> : CQMBENHOHVQ<a?>, SIODVFPODKZ where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly CQMBENHOHVQ<a> NWYRKSRXMXB;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public IAOROBGWYUU(CQMBENHOHVQ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x50D7200", Offset = "0x50D6000", VA = "0x1850D7200", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x50D6DD0", Offset = "0x50D5BD0", VA = "0x1850D6DD0", Slot = "5")]
		public a? Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class UUVGTAVNUOT : CQMBENHOHVQ<sbyte>, SIODVFPODKZ, ZUVGKIZOTUL<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly UUVGTAVNUOT CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x90BFC00", Offset = "0x90BEA00", VA = "0x1890BFC00", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x90BFA60", Offset = "0x90BE860", VA = "0x1890BFA60", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x90BFA70", Offset = "0x90BE870", VA = "0x1890BFA70", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, sbyte b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x90BFB80", Offset = "0x90BE980", VA = "0x1890BFB80", Slot = "7")]
		public sbyte LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public UUVGTAVNUOT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class ERTRAMVHQMO : CQMBENHOHVQ<sbyte?>, SIODVFPODKZ, ZUVGKIZOTUL<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly ERTRAMVHQMO CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x90AFE60", Offset = "0x90AEC60", VA = "0x1890AFE60", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x90AFBC0", Offset = "0x90AE9C0", VA = "0x1890AFBC0", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x90AFC30", Offset = "0x90AEA30", VA = "0x1890AFC30", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, sbyte? b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x90AFD90", Offset = "0x90AEB90", VA = "0x1890AFD90", Slot = "7")]
		public sbyte? LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public ERTRAMVHQMO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class AVJLWRKHQCK : CQMBENHOHVQ<sbyte[]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly AVJLWRKHQCK CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x90AB060", Offset = "0x90A9E60", VA = "0x1890AB060", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x90AAF20", Offset = "0x90A9D20", VA = "0x1890AAF20", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public AVJLWRKHQCK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class TUECIELSDSM : CQMBENHOHVQ<short>, SIODVFPODKZ, ZUVGKIZOTUL<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly TUECIELSDSM CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x90BEB90", Offset = "0x90BD990", VA = "0x1890BEB90", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x90BE9F0", Offset = "0x90BD7F0", VA = "0x1890BE9F0", Slot = "5")]
		public short Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x90BEA00", Offset = "0x90BD800", VA = "0x1890BEA00", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, short b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x90BEB10", Offset = "0x90BD910", VA = "0x1890BEB10", Slot = "7")]
		public short LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public TUECIELSDSM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class HIDVHBRSDCJ : CQMBENHOHVQ<short?>, SIODVFPODKZ, ZUVGKIZOTUL<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly HIDVHBRSDCJ CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x90B1280", Offset = "0x90B0080", VA = "0x1890B1280", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x90B0FE0", Offset = "0x90AFDE0", VA = "0x1890B0FE0", Slot = "5")]
		public short? Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x90B1050", Offset = "0x90AFE50", VA = "0x1890B1050", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, short? b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x90B11B0", Offset = "0x90AFFB0", VA = "0x1890B11B0", Slot = "7")]
		public short? LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public HIDVHBRSDCJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class SOJSOGXYTED : CQMBENHOHVQ<short[]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly SOJSOGXYTED CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x90BD2E0", Offset = "0x90BC0E0", VA = "0x1890BD2E0", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x90BD1A0", Offset = "0x90BBFA0", VA = "0x1890BD1A0", Slot = "5")]
		public short[] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public SOJSOGXYTED()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class GTVXSSDKOEC : CQMBENHOHVQ<int>, SIODVFPODKZ, ZUVGKIZOTUL<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly GTVXSSDKOEC CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x90B0D30", Offset = "0x90AFB30", VA = "0x1890B0D30", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x90B0B90", Offset = "0x90AF990", VA = "0x1890B0B90", Slot = "5")]
		public int Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x90B0BA0", Offset = "0x90AF9A0", VA = "0x1890B0BA0", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, int b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x90B0CB0", Offset = "0x90AFAB0", VA = "0x1890B0CB0", Slot = "7")]
		public int LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public GTVXSSDKOEC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class HSTKXEGCVEH : CQMBENHOHVQ<int?>, SIODVFPODKZ, ZUVGKIZOTUL<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly HSTKXEGCVEH CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x90B20E0", Offset = "0x90B0EE0", VA = "0x1890B20E0", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x90B1E40", Offset = "0x90B0C40", VA = "0x1890B1E40", Slot = "5")]
		public int? Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x90B1EB0", Offset = "0x90B0CB0", VA = "0x1890B1EB0", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, int? b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x90B2010", Offset = "0x90B0E10", VA = "0x1890B2010", Slot = "7")]
		public int? LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public HSTKXEGCVEH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class SABIGPLPLEF : CQMBENHOHVQ<int[]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly SABIGPLPLEF CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x90BCAD0", Offset = "0x90BB8D0", VA = "0x1890BCAD0", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x90BC990", Offset = "0x90BB790", VA = "0x1890BC990", Slot = "5")]
		public int[] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public SABIGPLPLEF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class OSIORJZBOTJ : CQMBENHOHVQ<long>, SIODVFPODKZ, ZUVGKIZOTUL<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly OSIORJZBOTJ CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x90B8FA0", Offset = "0x90B7DA0", VA = "0x1890B8FA0", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x90B8E80", Offset = "0x90B7C80", VA = "0x1890B8E80", Slot = "5")]
		public long Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x90B8E90", Offset = "0x90B7C90", VA = "0x1890B8E90", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, long b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x90B8F60", Offset = "0x90B7D60", VA = "0x1890B8F60", Slot = "7")]
		public long LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public OSIORJZBOTJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class HKFWXXENYOO : CQMBENHOHVQ<long?>, SIODVFPODKZ, ZUVGKIZOTUL<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly HKFWXXENYOO CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x90B1650", Offset = "0x90B0450", VA = "0x1890B1650", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x90B13E0", Offset = "0x90B01E0", VA = "0x1890B13E0", Slot = "5")]
		public long? Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x90B1470", Offset = "0x90B0270", VA = "0x1890B1470", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, long? b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x90B15A0", Offset = "0x90B03A0", VA = "0x1890B15A0", Slot = "7")]
		public long? LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public HKFWXXENYOO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class AWROWLGYXYK : CQMBENHOHVQ<long[]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly AWROWLGYXYK CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x90AB440", Offset = "0x90AA240", VA = "0x1890AB440", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x90AB300", Offset = "0x90AA100", VA = "0x1890AB300", Slot = "5")]
		public long[] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public AWROWLGYXYK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class JELTSPRKUSQ : CQMBENHOHVQ<byte>, SIODVFPODKZ, ZUVGKIZOTUL<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly JELTSPRKUSQ CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x90B4B90", Offset = "0x90B3990", VA = "0x1890B4B90", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x90B49F0", Offset = "0x90B37F0", VA = "0x1890B49F0", Slot = "5")]
		public byte Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x90B4A00", Offset = "0x90B3800", VA = "0x1890B4A00", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, byte b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x90B4B10", Offset = "0x90B3910", VA = "0x1890B4B10", Slot = "7")]
		public byte LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public JELTSPRKUSQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class BXMVNOYMXDJ : CQMBENHOHVQ<byte?>, SIODVFPODKZ, ZUVGKIZOTUL<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly BXMVNOYMXDJ CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x90AB910", Offset = "0x90AA710", VA = "0x1890AB910", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x90AB670", Offset = "0x90AA470", VA = "0x1890AB670", Slot = "5")]
		public byte? Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x90AB6E0", Offset = "0x90AA4E0", VA = "0x1890AB6E0", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, byte? b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x90AB840", Offset = "0x90AA640", VA = "0x1890AB840", Slot = "7")]
		public byte? LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public BXMVNOYMXDJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class XSYFBZLCFYH : CQMBENHOHVQ<ushort>, SIODVFPODKZ, ZUVGKIZOTUL<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly XSYFBZLCFYH CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x90C1DC0", Offset = "0x90C0BC0", VA = "0x1890C1DC0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x90C1C20", Offset = "0x90C0A20", VA = "0x1890C1C20", Slot = "5")]
		public ushort Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x90C1C30", Offset = "0x90C0A30", VA = "0x1890C1C30", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, ushort b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x90C1D40", Offset = "0x90C0B40", VA = "0x1890C1D40", Slot = "7")]
		public ushort LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public XSYFBZLCFYH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class IBXYREPSSIM : CQMBENHOHVQ<ushort?>, SIODVFPODKZ, ZUVGKIZOTUL<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly IBXYREPSSIM CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x90B2D10", Offset = "0x90B1B10", VA = "0x1890B2D10", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x90B2A70", Offset = "0x90B1870", VA = "0x1890B2A70", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x90B2AE0", Offset = "0x90B18E0", VA = "0x1890B2AE0", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, ushort? b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x90B2C40", Offset = "0x90B1A40", VA = "0x1890B2C40", Slot = "7")]
		public ushort? LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public IBXYREPSSIM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class EAIUWXPDLEG : CQMBENHOHVQ<ushort[]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly EAIUWXPDLEG CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x90AE560", Offset = "0x90AD360", VA = "0x1890AE560", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x90AE420", Offset = "0x90AD220", VA = "0x1890AE420", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public EAIUWXPDLEG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class DIMFYTCRXGB : CQMBENHOHVQ<uint>, SIODVFPODKZ, ZUVGKIZOTUL<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly DIMFYTCRXGB CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x90AD920", Offset = "0x90AC720", VA = "0x1890AD920", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x90AD780", Offset = "0x90AC580", VA = "0x1890AD780", Slot = "5")]
		public uint Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x90AD790", Offset = "0x90AC590", VA = "0x1890AD790", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, uint b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x90AD8A0", Offset = "0x90AC6A0", VA = "0x1890AD8A0", Slot = "7")]
		public uint LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public DIMFYTCRXGB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class EWCLHOKUQZQ : CQMBENHOHVQ<uint?>, SIODVFPODKZ, ZUVGKIZOTUL<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly EWCLHOKUQZQ CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x90B0260", Offset = "0x90AF060", VA = "0x1890B0260", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x90AFFC0", Offset = "0x90AEDC0", VA = "0x1890AFFC0", Slot = "5")]
		public uint? Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x90B0030", Offset = "0x90AEE30", VA = "0x1890B0030", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, uint? b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x90B0190", Offset = "0x90AEF90", VA = "0x1890B0190", Slot = "7")]
		public uint? LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public EWCLHOKUQZQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class ELEHRSPBJDK : CQMBENHOHVQ<uint[]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly ELEHRSPBJDK CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x90AE940", Offset = "0x90AD740", VA = "0x1890AE940", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x90AE800", Offset = "0x90AD600", VA = "0x1890AE800", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public ELEHRSPBJDK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class PPSSRBRVIDW : CQMBENHOHVQ<ulong>, SIODVFPODKZ, ZUVGKIZOTUL<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly PPSSRBRVIDW CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x90B93C0", Offset = "0x90B81C0", VA = "0x1890B93C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x90B92A0", Offset = "0x90B80A0", VA = "0x1890B92A0", Slot = "5")]
		public ulong Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x90B92B0", Offset = "0x90B80B0", VA = "0x1890B92B0", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, ulong b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x90B9380", Offset = "0x90B8180", VA = "0x1890B9380", Slot = "7")]
		public ulong LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public PPSSRBRVIDW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class SPZXPSAXZWH : CQMBENHOHVQ<ulong?>, SIODVFPODKZ, ZUVGKIZOTUL<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly SPZXPSAXZWH CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x90BD7F0", Offset = "0x90BC5F0", VA = "0x1890BD7F0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x90BD580", Offset = "0x90BC380", VA = "0x1890BD580", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x90BD610", Offset = "0x90BC410", VA = "0x1890BD610", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, ulong? b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x90BD740", Offset = "0x90BC540", VA = "0x1890BD740", Slot = "7")]
		public ulong? LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public SPZXPSAXZWH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class RQQACSLSTAL : CQMBENHOHVQ<ulong[]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly RQQACSLSTAL CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x90BC760", Offset = "0x90BB560", VA = "0x1890BC760", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x90BC620", Offset = "0x90BB420", VA = "0x1890BC620", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public RQQACSLSTAL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class DYKRBZEPFDY : CQMBENHOHVQ<float>, SIODVFPODKZ, ZUVGKIZOTUL<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly DYKRBZEPFDY CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x90ADB40", Offset = "0x90AC940", VA = "0x1890ADB40", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x90ADA20", Offset = "0x90AC820", VA = "0x1890ADA20", Slot = "5")]
		public float Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x90ADA30", Offset = "0x90AC830", VA = "0x1890ADA30", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, float b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x90ADB00", Offset = "0x90AC900", VA = "0x1890ADB00", Slot = "7")]
		public float LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public DYKRBZEPFDY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class ABJURBHZEEB : CQMBENHOHVQ<float?>, SIODVFPODKZ, ZUVGKIZOTUL<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly ABJURBHZEEB CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x90A9CB0", Offset = "0x90A8AB0", VA = "0x1890A9CB0", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x90A9A80", Offset = "0x90A8880", VA = "0x1890A9A80", Slot = "5")]
		public float? Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x90A9AF0", Offset = "0x90A88F0", VA = "0x1890A9AF0", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, float? b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x90A9C10", Offset = "0x90A8A10", VA = "0x1890A9C10", Slot = "7")]
		public float? LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public ABJURBHZEEB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class ZTKYSDHMIAB : CQMBENHOHVQ<float[]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly ZTKYSDHMIAB CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x90C3CF0", Offset = "0x90C2AF0", VA = "0x1890C3CF0", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x90C3BB0", Offset = "0x90C29B0", VA = "0x1890C3BB0", Slot = "5")]
		public float[] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public ZTKYSDHMIAB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class YABDPUHRJER : CQMBENHOHVQ<double>, SIODVFPODKZ, ZUVGKIZOTUL<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly YABDPUHRJER CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x90C24B0", Offset = "0x90C12B0", VA = "0x1890C24B0", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x90C2390", Offset = "0x90C1190", VA = "0x1890C2390", Slot = "5")]
		public double Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x90C23A0", Offset = "0x90C11A0", VA = "0x1890C23A0", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, double b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x90C2470", Offset = "0x90C1270", VA = "0x1890C2470", Slot = "7")]
		public double LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public YABDPUHRJER()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class CALSCZTXXCW : CQMBENHOHVQ<double?>, SIODVFPODKZ, ZUVGKIZOTUL<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly CALSCZTXXCW CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x90AD640", Offset = "0x90AC440", VA = "0x1890AD640", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x90AD3D0", Offset = "0x90AC1D0", VA = "0x1890AD3D0", Slot = "5")]
		public double? Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x90AD460", Offset = "0x90AC260", VA = "0x1890AD460", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, double? b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x90AD590", Offset = "0x90AC390", VA = "0x1890AD590", Slot = "7")]
		public double? LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public CALSCZTXXCW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class VKIBBZRXPCI : CQMBENHOHVQ<double[]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly VKIBBZRXPCI CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x90BFE40", Offset = "0x90BEC40", VA = "0x1890BFE40", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x90BFD00", Offset = "0x90BEB00", VA = "0x1890BFD00", Slot = "5")]
		public double[] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public VKIBBZRXPCI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class NRRPPKOLACW : CQMBENHOHVQ<bool>, SIODVFPODKZ, ZUVGKIZOTUL<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly NRRPPKOLACW CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x90B8DB0", Offset = "0x90B7BB0", VA = "0x1890B8DB0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x90B8C90", Offset = "0x90B7A90", VA = "0x1890B8C90", Slot = "5")]
		public bool Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x90B8CA0", Offset = "0x90B7AA0", VA = "0x1890B8CA0", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, bool b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x90B8D70", Offset = "0x90B7B70", VA = "0x1890B8D70", Slot = "7")]
		public bool LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public NRRPPKOLACW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class WNVDABNSQWX : CQMBENHOHVQ<bool?>, SIODVFPODKZ, ZUVGKIZOTUL<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly WNVDABNSQWX CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x90C0780", Offset = "0x90BF580", VA = "0x1890C0780", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x90C0550", Offset = "0x90BF350", VA = "0x1890C0550", Slot = "5")]
		public bool? Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x90C05C0", Offset = "0x90BF3C0", VA = "0x1890C05C0", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, bool? b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x90C06E0", Offset = "0x90BF4E0", VA = "0x1890C06E0", Slot = "7")]
		public bool? LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public WNVDABNSQWX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class XYMKRDIABKZ : CQMBENHOHVQ<bool[]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly XYMKRDIABKZ CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x90C2000", Offset = "0x90C0E00", VA = "0x1890C2000", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x90C1EC0", Offset = "0x90C0CC0", VA = "0x1890C1EC0", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public XYMKRDIABKZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class TMMYRGBLQHR : CQMBENHOHVQ<byte[]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly CQMBENHOHVQ<byte[]> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x90BE8C0", Offset = "0x90BD6C0", VA = "0x1890BE8C0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x90BE850", Offset = "0x90BD650", VA = "0x1890BE850", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public TMMYRGBLQHR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class YLBPVSUWLZU : CQMBENHOHVQ<ArraySegment<byte>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly CQMBENHOHVQ<ArraySegment<byte>> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x90C2650", Offset = "0x90C1450", VA = "0x1890C2650", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x90C2580", Offset = "0x90C1380", VA = "0x1890C2580", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public YLBPVSUWLZU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class WDKWPNQWMMG : CQMBENHOHVQ<string>, SIODVFPODKZ, ZUVGKIZOTUL<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly CQMBENHOHVQ<string> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x90C0480", Offset = "0x90BF280", VA = "0x1890C0480", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x90C0410", Offset = "0x90BF210", VA = "0x1890C0410", Slot = "5")]
		public string Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x90C0420", Offset = "0x90BF220", VA = "0x1890C0420", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, string b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x90C0410", Offset = "0x90BF210", VA = "0x1890C0410", Slot = "7")]
		public string LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public WDKWPNQWMMG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class TEMEAEZWYYV : CQMBENHOHVQ<string[]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly TEMEAEZWYYV CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x90BE430", Offset = "0x90BD230", VA = "0x1890BE430", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x90BE2E0", Offset = "0x90BD0E0", VA = "0x1890BE2E0", Slot = "5")]
		public string[] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public TEMEAEZWYYV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class YPSWHHPVYSW : CQMBENHOHVQ<char>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly YPSWHHPVYSW CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x90C3860", Offset = "0x90C2660", VA = "0x1890C3860", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x90C3830", Offset = "0x90C2630", VA = "0x1890C3830", Slot = "5")]
		public char Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public YPSWHHPVYSW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class OTHXGVKEOVD : CQMBENHOHVQ<char?>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly OTHXGVKEOVD CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x90B9130", Offset = "0x90B7F30", VA = "0x1890B9130", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x90B9070", Offset = "0x90B7E70", VA = "0x1890B9070", Slot = "5")]
		public char? Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public OTHXGVKEOVD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class TWTWWZBVWFP : CQMBENHOHVQ<char[]>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly TWTWWZBVWFP CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x90BEE20", Offset = "0x90BDC20", VA = "0x1890BEE20", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x90BEC90", Offset = "0x90BDA90", VA = "0x1890BEC90", Slot = "5")]
		public char[] Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public TWTWWZBVWFP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class SBGDRGTNQOB : CQMBENHOHVQ<Guid>, SIODVFPODKZ, ZUVGKIZOTUL<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly CQMBENHOHVQ<Guid> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x90BCFC0", Offset = "0x90BBDC0", VA = "0x1890BCFC0", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x90BCD70", Offset = "0x90BBB70", VA = "0x1890BCD70", Slot = "5")]
		public Guid Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x90BCDD0", Offset = "0x90BBBD0", VA = "0x1890BCDD0", Slot = "6")]
		public void JWFZHJFHCGF(JsonWriter a, Guid b, YUWSCVCXGIP c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x90BCF50", Offset = "0x90BBD50", VA = "0x1890BCF50", Slot = "7")]
		public Guid LRJZEQRWTLX(JsonReader a, YUWSCVCXGIP b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public SBGDRGTNQOB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class TCPJIEEITNV : CQMBENHOHVQ<decimal>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly CQMBENHOHVQ<decimal> CJGYMEELLGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool OGPHIXDLBBN;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7445AF0", Offset = "0x74448F0", VA = "0x187445AF0")]
		public TCPJIEEITNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xDB9120", Offset = "0xDB7F20", VA = "0x180DB9120")]
		public TCPJIEEITNV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x90BE090", Offset = "0x90BCE90", VA = "0x1890BE090", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x90BDEC0", Offset = "0x90BCCC0", VA = "0x1890BDEC0", Slot = "5")]
		public decimal Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class XHUPTILZXTS : CQMBENHOHVQ<Uri>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly CQMBENHOHVQ<Uri> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x90C1AD0", Offset = "0x90C08D0", VA = "0x1890C1AD0", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x90C1A50", Offset = "0x90C0850", VA = "0x1890C1A50", Slot = "5")]
		public Uri Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public XHUPTILZXTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class HHYOMRZFKGG : CQMBENHOHVQ<Version>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly CQMBENHOHVQ<Version> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x90B0EB0", Offset = "0x90AFCB0", VA = "0x1890B0EB0", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x90B0E30", Offset = "0x90AFC30", VA = "0x1890B0E30", Slot = "5")]
		public Version Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public HHYOMRZFKGG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class HJQIJONZROY<a, b> : CQMBENHOHVQ<KeyValuePair<a, b>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5004150", Offset = "0x5002F50", VA = "0x185004150", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5003C50", Offset = "0x5002A50", VA = "0x185003C50", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class QYQWWZJMEZI : CQMBENHOHVQ<StringBuilder>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly CQMBENHOHVQ<StringBuilder> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x90BA0A0", Offset = "0x90B8EA0", VA = "0x1890BA0A0", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x90BA020", Offset = "0x90B8E20", VA = "0x1890BA020", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public QYQWWZJMEZI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class NKAEUUICKVE : CQMBENHOHVQ<BitArray>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly CQMBENHOHVQ<BitArray> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x90B8AA0", Offset = "0x90B78A0", VA = "0x1890B8AA0", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x90B8980", Offset = "0x90B7780", VA = "0x1890B8980", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public NKAEUUICKVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class KCEDYGOFVEC : CQMBENHOHVQ<Type>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly KCEDYGOFVEC CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex KAMNVBIVWCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool VNXYIGHEKVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool TGTPWCITDZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool HCHLIZBEYKJ;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x90B5510", Offset = "0x90B4310", VA = "0x1890B5510")]
		public KCEDYGOFVEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x83DC0B0", Offset = "0x83DAEB0", VA = "0x1883DC0B0")]
		public KCEDYGOFVEC(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x90B5330", Offset = "0x90B4130", VA = "0x1890B5330", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x90B5220", Offset = "0x90B4020", VA = "0x1890B5220", Slot = "5")]
		public Type Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class URSTEBBZPPM : CQMBENHOHVQ<BigInteger>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly CQMBENHOHVQ<BigInteger> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x90BF920", Offset = "0x90BE720", VA = "0x1890BF920", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x90BF870", Offset = "0x90BE670", VA = "0x1890BF870", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public URSTEBBZPPM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class YUJOUYIEJTQ : CQMBENHOHVQ<Complex>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly CQMBENHOHVQ<Complex> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x90C3A10", Offset = "0x90C2810", VA = "0x1890C3A10", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x90C3980", Offset = "0x90C2780", VA = "0x1890C3980", Slot = "5")]
		public Complex Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public YUJOUYIEJTQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class MKBMELSZCIU : CQMBENHOHVQ<ExpandoObject>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly CQMBENHOHVQ<ExpandoObject> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x90B8880", Offset = "0x90B7680", VA = "0x1890B8880", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x90B8650", Offset = "0x90B7450", VA = "0x1890B8650", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public MKBMELSZCIU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class DLWAGZENRUL<a> : CQMBENHOHVQ<Lazy<a>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x4189820", Offset = "0x4188620", VA = "0x184189820", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x4189680", Offset = "0x4188480", VA = "0x184189680", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class TEUTKGCQJAP : CQMBENHOHVQ<Task>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly CQMBENHOHVQ<Task> CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task RJCLJUZGRHG;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x90BE710", Offset = "0x90BD510", VA = "0x1890BE710", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x90BE660", Offset = "0x90BD460", VA = "0x1890BE660", Slot = "5")]
		public Task Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public TEUTKGCQJAP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class DHCHPNQTWGL<a> : CQMBENHOHVQ<Task<a>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x4185760", Offset = "0x4184560", VA = "0x184185760", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x41855E0", Offset = "0x41843E0", VA = "0x1841855E0", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class QILAHONRMMB<a> : CQMBENHOHVQ<ValueTask<a>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5D2AB70", Offset = "0x5D29970", VA = "0x185D2AB70", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A940", Offset = "0x5D29740", VA = "0x185D2A940", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class STRLCYVAABR<a> : CQMBENHOHVQ<Tuple<a>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x6028390", Offset = "0x6027190", VA = "0x186028390", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x60280A0", Offset = "0x6026EA0", VA = "0x1860280A0", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class STWSAFOXJNA<a, b> : CQMBENHOHVQ<Tuple<a, b>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x6028BD0", Offset = "0x60279D0", VA = "0x186028BD0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x6028780", Offset = "0x6027580", VA = "0x186028780", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class SUBYXMIUSYJ<a, b, c> : CQMBENHOHVQ<Tuple<a, b, c>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x60296C0", Offset = "0x60284C0", VA = "0x1860296C0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x6029130", Offset = "0x6027F30", VA = "0x186029130", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class SUHFUTCSCJS<a, b, c, d> : CQMBENHOHVQ<Tuple<a, b, c, d>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x602A480", Offset = "0x6029280", VA = "0x18602A480", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x6029D90", Offset = "0x6028B90", VA = "0x186029D90", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class SUMMRZWPLVB<a, b, c, d, e> : CQMBENHOHVQ<Tuple<a, b, c, d, e>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x602B530", Offset = "0x602A330", VA = "0x18602B530", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x602ACD0", Offset = "0x6029AD0", VA = "0x18602ACD0", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class SURTPGQMVGK<a, b, c, d, e, f> : CQMBENHOHVQ<Tuple<a, b, c, d, e, f>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x602C8F0", Offset = "0x602B6F0", VA = "0x18602C8F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x602BF00", Offset = "0x602AD00", VA = "0x18602BF00", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class SUXAMNKKERT<a, b, c, d, e, f, g> : CQMBENHOHVQ<Tuple<a, b, c, d, e, f, g>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x602DFC0", Offset = "0x602CDC0", VA = "0x18602DFC0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x602D440", Offset = "0x602C240", VA = "0x18602D440", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class SRWBBPXXTDO<a, b, c, d, e, f, g, h> : CQMBENHOHVQ<Tuple<a, b, c, d, e, f, g, h>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x6026CA0", Offset = "0x6025AA0", VA = "0x186026CA0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x6025FB0", Offset = "0x6024DB0", VA = "0x186025FB0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class JSAMFLPRNHQ<a> : CQMBENHOHVQ<ValueTuple<a>>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x51F69F0", Offset = "0x51F57F0", VA = "0x1851F69F0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x51F65C0", Offset = "0x51F53C0", VA = "0x1851F65C0", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class JRVFIEVUDWH<a, b> : CQMBENHOHVQ<(a, b)>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x51F6010", Offset = "0x51F4E10", VA = "0x1851F6010", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x51F5B00", Offset = "0x51F4900", VA = "0x1851F5B00", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class JRPYKYBWUKY<a, b, c> : CQMBENHOHVQ<(a, b, c)>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x51F0CF0", Offset = "0x51EFAF0", VA = "0x1851F0CF0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x51F0650", Offset = "0x51EF450", VA = "0x1851F0650", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class JRKRNRHZKZP<a, b, c, d> : CQMBENHOHVQ<(a, b, c, d)>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x51EFD10", Offset = "0x51EEB10", VA = "0x1851EFD10", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x51EF4A0", Offset = "0x51EE2A0", VA = "0x1851EF4A0", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class JRFKQKOCBOG<a, b, c, d, e> : CQMBENHOHVQ<(a, b, c, d, e)>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x51EE9A0", Offset = "0x51ED7A0", VA = "0x1851EE9A0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x51EDFA0", Offset = "0x51ECDA0", VA = "0x1851EDFA0", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class JRADTDUESCX<a, b, c, d, e, f> : CQMBENHOHVQ<(a, b, c, d, e, f)>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x51EC370", Offset = "0x51EB170", VA = "0x1851EC370", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x51EB750", Offset = "0x51EA550", VA = "0x1851EB750", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class JQUWVXAHIRO<a, b, c, d, e, f, g> : CQMBENHOHVQ<(a, b, c, d, e, f, g)>, SIODVFPODKZ
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x51EA8D0", Offset = "0x51E96D0", VA = "0x1851EA8D0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x51E9AF0", Offset = "0x51E88F0", VA = "0x1851E9AF0", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class JTVWGUMTUFT<a, b, c, d, e, f, g, h> : CQMBENHOHVQ<ValueTuple<a, b, c, d, e, f, g, h>>, SIODVFPODKZ where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] ZXRGYVNIYEK;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly AZJODAGNXIG ZUMSEXKVQLW;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x51F8B10", Offset = "0x51F7910", VA = "0x1851F8B10", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, YUWSCVCXGIP formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x51F7B80", Offset = "0x51F6980", VA = "0x1851F7B80", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, YUWSCVCXGIP formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class GGAOWYVTFFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] LBSZEGDEPSO;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly AZJODAGNXIG YNICWBWUYAP;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x90B03C0", Offset = "0x90AF1C0", VA = "0x1890B03C0")]
		static GGAOWYVTFFI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class VMBFJXBFDJW
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] ITCNPLOGYZJ;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly AZJODAGNXIG JPHYGRCRMQW;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x90C01C0", Offset = "0x90BEFC0", VA = "0x1890C01C0")]
		static VMBFJXBFDJW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class ENXEPVDNSFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] MRQBXHJUYES;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly AZJODAGNXIG QSBVDTEFKTZ;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] MRKVAAPXOTJ;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly AZJODAGNXIG QSHCAZYCUFI;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] MRFOCTWAFIA;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly AZJODAGNXIG QSMIYGSADQR;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] MRAHFNCCVWR;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly AZJODAGNXIG QRBMRLISPPG;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] MQVAIGIFMLI;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly AZJODAGNXIG QRGTOSCPZAP;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] MQPTKZOICZZ;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly AZJODAGNXIG QRMALYWNILY;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] MQKMNSUKTOQ;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly AZJODAGNXIG QRRHJFQKRXH;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] MQFFQMANKDH;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly AZJODAGNXIG QQGLCKHDDVW;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x90AEBE0", Offset = "0x90AD9E0", VA = "0x1890AEBE0")]
		static ENXEPVDNSFG()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
