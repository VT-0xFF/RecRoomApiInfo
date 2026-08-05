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
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, ICATWVBKUQB resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, ICATWVBKUQB resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface SJEGVGTDTHV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface QCTFQCWJWUM<a> : SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, ICATWVBKUQB formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface PARBLNNFTUR<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RPLCMDUYFUP(JsonWriter a, a b, ICATWVBKUQB c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b);
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
	public static class TEBSGRHQFWM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3F6F5D0", Offset = "0x3F6DFD0", VA = "0x183F6F5D0")]
		public static string ToJsonString<T>(this QCTFQCWJWUM<T> formatter, T value, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		QCTFQCWJWUM<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class XBUVYHKVXCG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4120A20", Offset = "0x411F420", VA = "0x184120A20")]
		public static QCTFQCWJWUM<a> LEFHCOLMBLH<a>(this ICATWVBKUQB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA556CF0", Offset = "0xA5556F0", VA = "0x18A556CF0")]
		public static object MEZIZEENOEV(this ICATWVBKUQB a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA547FD0", Offset = "0xA5469D0", VA = "0x18A547FD0")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class DEAMHVOICPR
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] ICGFRAKFDRM;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] GVIPVDUBSMT;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] OFBXNVOESLC;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] MLYGJJJHRNN;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] POOLOCSUUXI;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] FOYLTPDOWXP;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] RPZLOSZYAJX;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] NDZYDEIMBKM;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class XLCJJSGBHXG : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0xA556F60", Offset = "0xA555960", VA = "0x18A556F60")]
				public XLCJJSGBHXG(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xA556E40", Offset = "0xA555840", VA = "0x18A556E40")]
				public XLCJJSGBHXG TTAWVIMBXXQ(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class RNHSXYBQGMD
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] JEPXGEAYSMY;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] XAFNQZUFYHJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private XLCJJSGBHXG start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private XLCJJSGBHXG end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA554660", Offset = "0xA553060", VA = "0x18A554660")]
			public void TTAWVIMBXXQ([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA554770", Offset = "0xA553170", VA = "0x18A554770")]
			public void TTAWVIMBXXQ(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA554190", Offset = "0xA552B90", VA = "0x18A554190")]
			public ReadOnlySequence<byte> EJHTALTWMIZ()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA5542C0", Offset = "0xA552CC0", VA = "0x18A5542C0")]
			private void KVIFTSNVTRL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA554470", Offset = "0xA552E70", VA = "0x18A554470")]
			private void POMBJLYPWCT([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA54D740", Offset = "0xA54C140", VA = "0x18A54D740")]
		public JsonReader([In] ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA54D5D0", Offset = "0xA54BFD0", VA = "0x18A54D5D0")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA54CC50", Offset = "0xA54B650", VA = "0x18A54CC50")]
		private JsonParsingException WRYLXBUBYUP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA54B120", Offset = "0xA549B20", VA = "0x18A54B120")]
		private JsonParsingException JJGEJSRPCAO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA54BE40", Offset = "0xA54A840", VA = "0x18A54BE40")]
		public JsonToken OCSXUQRBKOC()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA54C2D0", Offset = "0xA54ACD0", VA = "0x18A54C2D0")]
		public void QXYUHIOYQSM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA54D520", Offset = "0xA54BF20", VA = "0x18A54D520")]
		private bool XWBPIRRVBZE(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA54D4C0", Offset = "0xA54BEC0", VA = "0x18A54D4C0")]
		private bool XWBPIRRVBZE(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA54C900", Offset = "0xA54B300", VA = "0x18A54C900")]
		private void TLTRLZWCHCX(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA54C9B0", Offset = "0xA54B3B0", VA = "0x18A54C9B0")]
		public bool TTYMXEHWGBJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA54AF10", Offset = "0xA549910", VA = "0x18A54AF10")]
		public void HUDNPURFKQJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA54B230", Offset = "0xA549C30", VA = "0x18A54B230")]
		public bool JOKJXFNHRNW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA54D5C0", Offset = "0xA54BFC0", VA = "0x18A54D5C0")]
		public void ZOBZWXAECYJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA54AF00", Offset = "0xA549900", VA = "0x18A54AF00")]
		public void HHARBLHRCSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA54C280", Offset = "0xA54AC80", VA = "0x18A54C280")]
		public bool QSGAFMZZBMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA54BE30", Offset = "0xA54A830", VA = "0x18A54BE30")]
		public void NNYBPTSMQPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA54A780", Offset = "0xA549180", VA = "0x18A54A780")]
		public void DBDKRVZCXWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA54C0C0", Offset = "0xA54AAC0", VA = "0x18A54C0C0")]
		public bool OXZJINHDFBR(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA54A540", Offset = "0xA548F40", VA = "0x18A54A540")]
		public bool BLSNWFCUVNQ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA54C150", Offset = "0xA54AB50", VA = "0x18A54C150")]
		public bool QIGKLTDQLZB(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA54B280", Offset = "0xA549C80", VA = "0x18A54B280")]
		public bool KDVXTEJBNBE(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA54B600", Offset = "0xA54A000", VA = "0x18A54B600")]
		private ReadOnlySequence<byte> KVJWBZWMDJR()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA54BAF0", Offset = "0xA54A4F0", VA = "0x18A54BAF0")]
		private ReadOnlySequence<byte> LWCXWVJUGPA()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA54AD10", Offset = "0xA549710", VA = "0x18A54AD10")]
		private void GZTZKCQAKGK(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA54D2C0", Offset = "0xA54BCC0", VA = "0x18A54D2C0")]
		private void XSCDDDVJIQB(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA54AA20", Offset = "0xA549420", VA = "0x18A54AA20")]
		private void FJXYWXLBEXG(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA54C7F0", Offset = "0xA54B1F0", VA = "0x18A54C7F0")]
		private void TFHXYZYLCRF(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA542500", Offset = "0xA540F00", VA = "0x18A542500")]
		private static int YIXHZOBZHOS(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA54C670", Offset = "0xA54B070", VA = "0x18A54C670")]
		public ReadOnlySequence<byte> RSCQYDSFQPI()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA54CA70", Offset = "0xA54B470", VA = "0x18A54CA70")]
		public string UAXORWQATJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA54D580", Offset = "0xA54BF80", VA = "0x18A54D580")]
		public string ZMTGYGHBTQU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA54BD60", Offset = "0xA54A760", VA = "0x18A54BD60")]
		public ReadOnlySequence<byte> MDTTQTEGVZQ()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA54D1E0", Offset = "0xA54BBE0", VA = "0x18A54D1E0")]
		public ReadOnlySequence<byte> WWPIPLWPCKR()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA54AF20", Offset = "0xA549920", VA = "0x18A54AF20")]
		public bool HZAYCSAAZMS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA54C500", Offset = "0xA54AF00", VA = "0x18A54C500")]
		private void RGICRKKSKPS(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA54A770", Offset = "0xA549170", VA = "0x18A54A770")]
		public void CPZUEMNUYKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA54CFA0", Offset = "0xA54B9A0", VA = "0x18A54CFA0")]
		private void WTHCYUKCOET(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA54A6C0", Offset = "0xA5490C0", VA = "0x18A54A6C0")]
		public sbyte CKZBUFAZHNX()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA54CBA0", Offset = "0xA54B5A0", VA = "0x18A54CBA0")]
		public short WGKXLEKYQHG()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA54B070", Offset = "0xA549A70", VA = "0x18A54B070")]
		public int ILPAECHNAVQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA54C050", Offset = "0xA54AA50", VA = "0x18A54C050")]
		public long OJXXPUWAKLP()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA54CAF0", Offset = "0xA54B4F0", VA = "0x18A54CAF0")]
		public byte VFHRMKHLQLG()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA54C740", Offset = "0xA54B140", VA = "0x18A54C740")]
		public ushort TDQSBWDYUKB()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA54A970", Offset = "0xA549370", VA = "0x18A54A970")]
		public uint FHERQRXIHLR()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA54A4D0", Offset = "0xA548ED0", VA = "0x18A54A4D0")]
		public ulong ACHGBYVBTSY()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA54C1E0", Offset = "0xA54ABE0", VA = "0x18A54C1E0")]
		public float QNLXWFYPFNQ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA54A620", Offset = "0xA549020", VA = "0x18A54A620")]
		public double BPEWPJAWWDV()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA54A790", Offset = "0xA549190", VA = "0x18A54A790")]
		public ReadOnlySequence<byte> EKIXMXYWLAA()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA54B360", Offset = "0xA549D60", VA = "0x18A54B360")]
		private void KIVQYLUAKEO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class JsonParsingException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string ActualChar
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xFCEB50", Offset = "0xFCD550", VA = "0x180FCEB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA54A470", Offset = "0xA548E70", VA = "0x18A54A470")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA54A3F0", Offset = "0xA548DF0", VA = "0x18A54A3F0")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class FBUAEDXPLXK
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class QEASCCONSQP
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] JEPXGEAYSMY;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA5530C0", Offset = "0xA551AC0", VA = "0x18A5530C0")]
			public static byte[] CNHLQPVYBIA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static ICATWVBKUQB BOYKWUJUWZL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] QSEQVNFRMKA;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] EYKUBKAVPPY;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static ICATWVBKUQB IYCLUXDOFYZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA547370", Offset = "0xA545D70", VA = "0x18A547370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA547DD0", Offset = "0xA5467D0", VA = "0x18A547DD0")]
		public static void TECBSAYGDVH(ICATWVBKUQB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6DA0", Offset = "0x3AD57A0", VA = "0x183AD6DA0")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6C20", Offset = "0x3AD5620", VA = "0x183AD6C20")]
		public static byte[] Serialize<T>(T value, ICATWVBKUQB resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3AD73A0", Offset = "0x3AD5DA0", VA = "0x183AD73A0")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3AD7220", Offset = "0x3AD5C20", VA = "0x183AD7220")]
		public static string ToJsonString<T>(T value, ICATWVBKUQB resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6460", Offset = "0x3AD4E60", VA = "0x183AD6460")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3AD66B0", Offset = "0x3AD50B0", VA = "0x183AD66B0")]
		public static T Deserialize<T>(string json, ICATWVBKUQB resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6830", Offset = "0x3AD5230", VA = "0x183AD6830")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3AD6390", Offset = "0x3AD4D90", VA = "0x183AD6390")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, ICATWVBKUQB resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5BC0", Offset = "0x3AD45C0", VA = "0x183AD5BC0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3AD5DE0", Offset = "0x3AD47E0", VA = "0x183AD5DE0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, ICATWVBKUQB resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA547040", Offset = "0xA545A40", VA = "0x18A547040")]
		public static byte[] JFWBCIRIPUG(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA547470", Offset = "0xA545E70", VA = "0x18A547470")]
		private static void PAHKEJWUGOW(JsonReader a, JsonWriter b, int c)
		{
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
		public int CRDWRUUXOZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xF8BE60", Offset = "0xF8A860", VA = "0x180F8BE60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA54E690", Offset = "0xA54D090", VA = "0x18A54E690")]
		public void NSZXKPTMCNZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA54EA10", Offset = "0xA54D410", VA = "0x18A54EA10")]
		public static byte[] ZBLRGLHHUDI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA54E880", Offset = "0xA54D280", VA = "0x18A54E880")]
		public static byte[] XNRZNALPZSK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA54DBB0", Offset = "0xA54C5B0", VA = "0x18A54DBB0")]
		public static byte[] DVGBAUPLBPK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA54E420", Offset = "0xA54CE20", VA = "0x18A54E420")]
		public static byte[] LSZQGGFMVRK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2AF0670", Offset = "0x2AEF070", VA = "0x182AF0670")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA54DB10", Offset = "0xA54C510", VA = "0x18A54DB10")]
		public ArraySegment<byte> CNHLQPVYBIA()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA54D8F0", Offset = "0xA54C2F0", VA = "0x18A54D8F0")]
		public byte[] AOZSGJEORVZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA54E7B0", Offset = "0xA54D1B0", VA = "0x18A54E7B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA54EAF0", Offset = "0xA54D4F0", VA = "0x18A54EAF0")]
		public void ZGUKVPQUPVO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA5425C0", Offset = "0xA540FC0", VA = "0x18A5425C0")]
		public void CDENAUQDNFH(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA54DAB0", Offset = "0xA54C4B0", VA = "0x18A54DAB0")]
		public void CDENAUQDNFH(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA54E6F0", Offset = "0xA54D0F0", VA = "0x18A54E6F0")]
		public void TAJTSRPOXVJ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4F26E60", Offset = "0x4F25860", VA = "0x184F26E60")]
		public void LZDJZGFIRQP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4F26E10", Offset = "0x4F25810", VA = "0x184F26E10")]
		public void IORNWZKBWVV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5B7C0C0", Offset = "0x5B7AAC0", VA = "0x185B7C0C0")]
		public void BIJJVURWRFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x514DC00", Offset = "0x514C600", VA = "0x18514DC00")]
		public void NGFGCJDVWSJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4F26F50", Offset = "0x4F25950", VA = "0x184F26F50")]
		public void VRHIFDJNMRX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5B7C1B0", Offset = "0x5B7ABB0", VA = "0x185B7C1B0")]
		public void RDLMRBHGIHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA54E380", Offset = "0xA54CD80", VA = "0x18A54E380")]
		public void LRUVBHAFFOX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA54E2C0", Offset = "0xA54CCC0", VA = "0x18A54E2C0")]
		public void LMRGODPWNRD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4F26EB0", Offset = "0x4F258B0", VA = "0x184F26EB0")]
		public void NGPIVGWQQLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8E10250", Offset = "0x8E0EC50", VA = "0x188E10250")]
		public void YEYMGZHAIQD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA54EB70", Offset = "0xA54D570", VA = "0x18A54EB70")]
		public void ZYZUMXDBCTP(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA54E730", Offset = "0xA54D130", VA = "0x18A54E730")]
		public void TESTKRWEPKE(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA54EB00", Offset = "0xA54D500", VA = "0x18A54EB00")]
		public void ZVLQXZDUBDR(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA54DCD0", Offset = "0xA54C6D0", VA = "0x18A54DCD0")]
		public void HNUSVLNKZGG(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA54E810", Offset = "0xA54D210", VA = "0x18A54E810")]
		public void VPDCSWDQEQY(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA54DA80", Offset = "0xA54C480", VA = "0x18A54DA80")]
		public void BOHBTPTTAAH(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA54E620", Offset = "0xA54D020", VA = "0x18A54E620")]
		public void MXGALBDWYWI(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA54E310", Offset = "0xA54CD10", VA = "0x18A54E310")]
		public void LPEGMKZAYFT(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA54E9A0", Offset = "0xA54D3A0", VA = "0x18A54E9A0")]
		public void XSSGBGSKLHJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA54E6A0", Offset = "0xA54D0A0", VA = "0x18A54E6A0")]
		public void SNUUMNQDXOQ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA54DD40", Offset = "0xA54C740", VA = "0x18A54DD40")]
		public void IWKWHQNHCTG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA54E5A0", Offset = "0xA54CFA0", VA = "0x18A54E5A0")]
		private static bool MLJNTYZWSZQ(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA54E6D0", Offset = "0xA54D0D0", VA = "0x18A54E6D0")]
		private static byte SQGIKKCRVMQ(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA542620", Offset = "0xA541020", VA = "0x18A542620")]
		private static void GBQYQVMIRWJ(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class KPXQYXVRASC : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7EDC6C0", Offset = "0x7EDB0C0", VA = "0x187EDC6C0")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private KPXQYXVRASC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class XVXZQXCTQZN : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7EEECC0", Offset = "0x7EED6C0", VA = "0x187EEECC0")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class CLXXLPXKXTH
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> ASSWFMWBEYW;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA544C50", Offset = "0xA543650", VA = "0x18A544C50")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private XVXZQXCTQZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class PERDPJQIMYD : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7EE1610", Offset = "0x7EE0010", VA = "0x187EE1610")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly PERDPJQIMYD UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool NAQVYVMZJJR;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static SJEGVGTDTHV[] XPARCCUBMAJ;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static ICATWVBKUQB[] RHZMHBJAVCN;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private PERDPJQIMYD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA551EC0", Offset = "0xA5508C0", VA = "0x18A551EC0")]
		public static void WSFSWRIEDET(params ICATWVBKUQB[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA551FA0", Offset = "0xA5509A0", VA = "0x18A551FA0")]
		public static void WSFSWRIEDET(params SJEGVGTDTHV[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA551C40", Offset = "0xA550640", VA = "0x18A551C40")]
		public static void FDXMEMWXVLT(SJEGVGTDTHV[] a, ICATWVBKUQB[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class LRQCXNMGYUO : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7EE7F60", Offset = "0x7EE6960", VA = "0x187EE7F60")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private LRQCXNMGYUO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class JQUYKQZPOBX
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly ICATWVBKUQB FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly ICATWVBKUQB UDJHOMYSMPA;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class WWAJSHJJOBH
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly ICATWVBKUQB FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly ICATWVBKUQB VHCHXXEVWEY;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly ICATWVBKUQB PMRZFFUWWFY;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly ICATWVBKUQB AXVNYHVDQPX;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly ICATWVBKUQB HZAIOYQMZJD;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly ICATWVBKUQB HDOZFWSCMLZ;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly ICATWVBKUQB BPXHJWIKWOK;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly ICATWVBKUQB KTFMDOKIKNW;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly ICATWVBKUQB YRNEIVDQRLA;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly ICATWVBKUQB SHBCQPGUGJT;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly ICATWVBKUQB NYWZRVLOVHX;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly ICATWVBKUQB BQCUFARDBET;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class PAWRWQFNHBO
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> ASSWFMWBEYW;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA54F660", Offset = "0xA54E060", VA = "0x18A54F660")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA5512E0", Offset = "0xA54FCE0", VA = "0x18A5512E0")]
		private static object ZYABVEMSRUZ(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class ZQSMFADVPHY : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7EEADC0", Offset = "0x7EE97C0", VA = "0x187EEADC0")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private ZQSMFADVPHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class BQFMBIWEQCH : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7EDEEE0", Offset = "0x7EDD8E0", VA = "0x187EDEEE0")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private BQFMBIWEQCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class BPEBTCXUJXX
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly ICATWVBKUQB[] YNYINWBWFIK;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class EHOTHRDVQTK : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7EFB1B0", Offset = "0x7EF9BB0", VA = "0x187EFB1B0")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class CAMKOHUADSE : ICATWVBKUQB
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class VMCVOGELZHD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x7EF72A0", Offset = "0x7EF5CA0", VA = "0x187EF72A0")]
				static VMCVOGELZHD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly ICATWVBKUQB UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly ICATWVBKUQB[] RHZMHBJAVCN;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private CAMKOHUADSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
			public QCTFQCWJWUM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly QCTFQCWJWUM<object> ICOAFLBXQXE;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private EHOTHRDVQTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class ELKNLIRWHQH : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7EFFB80", Offset = "0x7EFE580", VA = "0x187EFFB80")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class CAMKOHUADSE : ICATWVBKUQB
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class VMCVOGELZHD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x7EDED70", Offset = "0x7EDD770", VA = "0x187EDED70")]
				static VMCVOGELZHD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly ICATWVBKUQB UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly ICATWVBKUQB[] RHZMHBJAVCN;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private CAMKOHUADSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
			public QCTFQCWJWUM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly QCTFQCWJWUM<object> ICOAFLBXQXE;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private ELKNLIRWHQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class MWBVYLSLOBT : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7ED8670", Offset = "0x7ED7070", VA = "0x187ED8670")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class CAMKOHUADSE : ICATWVBKUQB
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class VMCVOGELZHD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x7EE5550", Offset = "0x7EE3F50", VA = "0x187EE5550")]
				static VMCVOGELZHD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly ICATWVBKUQB UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly ICATWVBKUQB[] RHZMHBJAVCN;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private CAMKOHUADSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
			public QCTFQCWJWUM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly QCTFQCWJWUM<object> ICOAFLBXQXE;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private MWBVYLSLOBT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class YRDBPCPBIEC : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7EEEEB0", Offset = "0x7EED8B0", VA = "0x187EEEEB0")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class CAMKOHUADSE : ICATWVBKUQB
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class VMCVOGELZHD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x7ED29A0", Offset = "0x7ED13A0", VA = "0x187ED29A0")]
				static VMCVOGELZHD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly ICATWVBKUQB UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly ICATWVBKUQB[] RHZMHBJAVCN;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private CAMKOHUADSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
			public QCTFQCWJWUM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly QCTFQCWJWUM<object> ICOAFLBXQXE;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private YRDBPCPBIEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class TLARWXYWUVU : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7EF45C0", Offset = "0x7EF2FC0", VA = "0x187EF45C0")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class CAMKOHUADSE : ICATWVBKUQB
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class VMCVOGELZHD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x7EEFDA0", Offset = "0x7EEE7A0", VA = "0x187EEFDA0")]
				static VMCVOGELZHD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly ICATWVBKUQB UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly ICATWVBKUQB[] RHZMHBJAVCN;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private CAMKOHUADSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
			public QCTFQCWJWUM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly QCTFQCWJWUM<object> ICOAFLBXQXE;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private TLARWXYWUVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class ODHRPDDVXXS : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7F01EE0", Offset = "0x7F008E0", VA = "0x187F01EE0")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class CAMKOHUADSE : ICATWVBKUQB
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class VMCVOGELZHD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x7EF3320", Offset = "0x7EF1D20", VA = "0x187EF3320")]
				static VMCVOGELZHD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly ICATWVBKUQB UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly ICATWVBKUQB[] RHZMHBJAVCN;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private CAMKOHUADSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
			public QCTFQCWJWUM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly QCTFQCWJWUM<object> ICOAFLBXQXE;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private ODHRPDDVXXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class QJZYSNYMDSB : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7EF64A0", Offset = "0x7EF4EA0", VA = "0x187EF64A0")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class CAMKOHUADSE : ICATWVBKUQB
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class VMCVOGELZHD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x7EFDCE0", Offset = "0x7EFC6E0", VA = "0x187EFDCE0")]
				static VMCVOGELZHD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly ICATWVBKUQB UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly ICATWVBKUQB[] RHZMHBJAVCN;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private CAMKOHUADSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
			public QCTFQCWJWUM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly QCTFQCWJWUM<object> ICOAFLBXQXE;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private QJZYSNYMDSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class YTLJYYNWSBR : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7ED3B70", Offset = "0x7ED2570", VA = "0x187ED3B70")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class CAMKOHUADSE : ICATWVBKUQB
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class VMCVOGELZHD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x7EDDFA0", Offset = "0x7EDC9A0", VA = "0x187EDDFA0")]
				static VMCVOGELZHD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly ICATWVBKUQB UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly ICATWVBKUQB[] RHZMHBJAVCN;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private CAMKOHUADSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
			public QCTFQCWJWUM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly QCTFQCWJWUM<object> ICOAFLBXQXE;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private YTLJYYNWSBR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class BNKMOSIJVOF : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7EE5B40", Offset = "0x7EE4540", VA = "0x187EE5B40")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class CAMKOHUADSE : ICATWVBKUQB
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class VMCVOGELZHD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x7EDA8E0", Offset = "0x7ED92E0", VA = "0x187EDA8E0")]
				static VMCVOGELZHD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly ICATWVBKUQB UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly ICATWVBKUQB[] RHZMHBJAVCN;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private CAMKOHUADSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
			public QCTFQCWJWUM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly QCTFQCWJWUM<object> ICOAFLBXQXE;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private BNKMOSIJVOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class HKIPVSSQFDQ : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7EF3E30", Offset = "0x7EF2830", VA = "0x187EF3E30")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class CAMKOHUADSE : ICATWVBKUQB
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class VMCVOGELZHD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x7EE24E0", Offset = "0x7EE0EE0", VA = "0x187EE24E0")]
				static VMCVOGELZHD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly ICATWVBKUQB UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly ICATWVBKUQB[] RHZMHBJAVCN;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private CAMKOHUADSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
			public QCTFQCWJWUM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly QCTFQCWJWUM<object> ICOAFLBXQXE;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private HKIPVSSQFDQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class RGINWRUSNLE : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7EF0A50", Offset = "0x7EEF450", VA = "0x187EF0A50")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class CAMKOHUADSE : ICATWVBKUQB
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class VMCVOGELZHD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x7EE2020", Offset = "0x7EE0A20", VA = "0x187EE2020")]
				static VMCVOGELZHD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly ICATWVBKUQB UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly ICATWVBKUQB[] RHZMHBJAVCN;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private CAMKOHUADSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
			public QCTFQCWJWUM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly QCTFQCWJWUM<object> ICOAFLBXQXE;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private RGINWRUSNLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class GFLHEDSBXFG : ICATWVBKUQB
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class VMCVOGELZHD<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7EDCC00", Offset = "0x7EDB600", VA = "0x187EDCC00")]
			static VMCVOGELZHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class CAMKOHUADSE : ICATWVBKUQB
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class VMCVOGELZHD<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly QCTFQCWJWUM<a> DDOHOITQCYA;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x7EED8C0", Offset = "0x7EEC2C0", VA = "0x187EED8C0")]
				static VMCVOGELZHD()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly ICATWVBKUQB UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly ICATWVBKUQB[] RHZMHBJAVCN;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private CAMKOHUADSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
			public QCTFQCWJWUM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly ICATWVBKUQB UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly QCTFQCWJWUM<object> ICOAFLBXQXE;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		private GFLHEDSBXFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3765880", Offset = "0x3764280", VA = "0x183765880", Slot = "4")]
		public QCTFQCWJWUM<T> GetFormatter<T>()
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

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x74507F0", Offset = "0x744F1F0", VA = "0x1874507F0")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x74504F0", Offset = "0x744EEF0", VA = "0x1874504F0")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7450760", Offset = "0x744F160", VA = "0x187450760")]
		public T[] NOFLPDFIHKY()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class OIZQEOBWFWS<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int ANFDAGHPYUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object RKZJLBLHOQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int SCOEDYFFAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] RFZLLRFLEIJ;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x72D88D0", Offset = "0x72D72D0", VA = "0x1872D88D0")]
		public OIZQEOBWFWS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x72D85D0", Offset = "0x72D6FD0", VA = "0x1872D85D0")]
		public a[] VOEQLMHSLBT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x72D8200", Offset = "0x72D6C00", VA = "0x1872D8200")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class VOGIGHBMNXK : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class TLESVYNAVWM : IComparable<TLESVYNAVWM>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class WUFOVWHTUBO : IEnumerable<TLESVYNAVWM>, IEnumerable, IEnumerator<TLESVYNAVWM>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int EQRCVSNPEJY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private TLESVYNAVWM RIDNXCOLQWN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int QBMVXUNSGXZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public TLESVYNAVWM TICTAVAJHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int XBQBCVFOHLO;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private TLESVYNAVWM SRXNGABFBON
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object IFKDFAMTOCU
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
				[DebuggerHidden]
				public WUFOVWHTUBO(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
				[DebuggerHidden]
				private void GWJQUAHXPBV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xA5567E0", Offset = "0xA5551E0", VA = "0x18A5567E0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xA5567A0", Offset = "0xA5551A0", VA = "0x18A5567A0", Slot = "10")]
				[DebuggerHidden]
				private void JNSYTSSCILY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xA556700", Offset = "0xA555100", VA = "0x18A556700", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<TLESVYNAVWM> EZIZXNCYKIS()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0xA556700", Offset = "0xA555100", VA = "0x18A556700", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator XDTPACFLBGX()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly TLESVYNAVWM[] MVDPSQLIAUI;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] MFDAYRBJXCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong PMSYNPVRYWB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int BPERYPXGUEX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string XZQNLANKSKQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TLESVYNAVWM[] AYFXYIPLCXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] YBNLTWZXRYP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int XUYKWNJGNYJ;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA554F10", Offset = "0xA553910", VA = "0x18A554F10")]
			public TLESVYNAVWM(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA554AC0", Offset = "0xA5534C0", VA = "0x18A554AC0")]
			public TLESVYNAVWM Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA554CC0", Offset = "0xA5536C0", VA = "0x18A554CC0")]
			public TLESVYNAVWM Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA554950", Offset = "0xA553350", VA = "0x18A554950")]
			public TLESVYNAVWM AWPBTNKBMMO(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA554DD0", Offset = "0xA5537D0", VA = "0x18A554DD0")]
			internal static int XLKMIWMWPLN(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA554D20", Offset = "0xA553720", VA = "0x18A554D20", Slot = "4")]
			public int CompareTo(TLESVYNAVWM other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xA554D50", Offset = "0xA553750", VA = "0x18A554D50")]
			[IteratorStateMachine(typeof(WUFOVWHTUBO))]
			public IEnumerable<TLESVYNAVWM> NZLTHVYDGDG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class LXSFXRJACPQ : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<TLESVYNAVWM> AYFXYIPLCXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<TLESVYNAVWM> UUETMSEZPLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<TLESVYNAVWM> IRFNBWFCZWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private TLESVYNAVWM MSFXWXPAVSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> IQUZHIRIGZW;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> GOPOCUMYVOH
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0xDAA5C0", Offset = "0xDA8FC0", VA = "0x180DAA5C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000139")]
				[Cpp2IlInjected.Address(RVA = "0xA54F430", Offset = "0xA54DE30", VA = "0x18A54F430", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1D4B650", Offset = "0x1D4A050", VA = "0x181D4B650")]
			[DebuggerHidden]
			public LXSFXRJACPQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xA54EE40", Offset = "0xA54D840", VA = "0x18A54EE40", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xA54EFD0", Offset = "0xA54D9D0", VA = "0x18A54EFD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xA54F480", Offset = "0xA54DE80", VA = "0x18A54F480")]
			private void XNJKRYGWMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA54F4D0", Offset = "0xA54DED0", VA = "0x18A54F4D0")]
			private void XNORPFATVNY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA54EF90", Offset = "0xA54D990", VA = "0x18A54EF90", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xA54EDA0", Offset = "0xA54D7A0", VA = "0x18A54EDA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> DAYWRTZTDQM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xA54EDA0", Offset = "0xA54D7A0", VA = "0x18A54EDA0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly TLESVYNAVWM VQTHZPRYINY;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA555B20", Offset = "0xA554520", VA = "0x18A555B20")]
		public VOGIGHBMNXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA5552D0", Offset = "0xA553CD0", VA = "0x18A5552D0")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA555590", Offset = "0xA553F90", VA = "0x18A555590")]
		public bool MAVXVFMPMHQ(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA555730", Offset = "0xA554130", VA = "0x18A555730")]
		public bool WQQNIKQZUOX([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA5556A0", Offset = "0xA5540A0", VA = "0x18A5556A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA555840", Offset = "0xA554240", VA = "0x18A555840")]
		private static void WXDDAUQHMYR(IEnumerable<TLESVYNAVWM> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA555530", Offset = "0xA553F30", VA = "0x18A555530", Slot = "5")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA555530", Offset = "0xA553F30", VA = "0x18A555530", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA5554B0", Offset = "0xA553EB0", VA = "0x18A5554B0")]
		[IteratorStateMachine(typeof(LXSFXRJACPQ))]
		private static IEnumerable<KeyValuePair<string, int>> GDNHDEUAPSA(IEnumerable<TLESVYNAVWM> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class ZOPMZKFELYP
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo BPXFDWWPIGA;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA5575E0", Offset = "0xA555FE0", VA = "0x18A5575E0")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA557180", Offset = "0xA555B80", VA = "0x18A557180")]
		public static ulong FFUQBMQERZG(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class HAMGRRTDNFV
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA54A130", Offset = "0xA548B30", VA = "0x18A54A130")]
		public static void ZGUKVPQUPVO(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA549ED0", Offset = "0xA5488D0", VA = "0x18A549ED0")]
		public static void PGCXJYNETXK(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA549FF0", Offset = "0xA5489F0", VA = "0x18A549FF0")]
		public static byte[] PXVNPBBRMIR(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class NPPSUDYOKJJ<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x5BB7BC0", Offset = "0x5BB65C0", VA = "0x185BB7BC0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class WZXDBZGNJSH : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public NPPSUDYOKJJ<a> TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] IRFNBWFCZWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int IRAGEPLFQLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] IQUZHIRIGZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int ISFVOEAPVBH;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> UAUBPKEVMCC
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xDAA5C0", Offset = "0xDA8FC0", VA = "0x180DAA5C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0x6563710", Offset = "0x6562110", VA = "0x186563710", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public WZXDBZGNJSH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x874ED30", Offset = "0x874D730", VA = "0x18874ED30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4F33510", Offset = "0x4F31F10", VA = "0x184F33510", Slot = "8")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] MNWPWFHAUWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong XVMXIHWYUUJ;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool KALWZIPDBNQ;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x715E3E0", Offset = "0x715CDE0", VA = "0x18715E3E0")]
		public NPPSUDYOKJJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x715E4D0", Offset = "0x715CED0", VA = "0x18715E4D0")]
		public NPPSUDYOKJJ(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x71532B0", Offset = "0x7151CB0", VA = "0x1871532B0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7156500", Offset = "0x7154F00", VA = "0x187156500")]
		private bool UVDYSPFQADR(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x71554C0", Offset = "0x7153EC0", VA = "0x1871554C0")]
		public bool MAVXVFMPMHQ([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x715B550", Offset = "0x7159F50", VA = "0x18715B550")]
		private static ulong ZQSSCRIYTNE([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x715C310", Offset = "0x715AD10", VA = "0x18715C310")]
		private static ulong ZQSSCRIYTNE([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7153BE0", Offset = "0x71525E0", VA = "0x187153BE0")]
		private static int GZJJEHSWMHE(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7153D30", Offset = "0x7152730", VA = "0x187153D30", Slot = "4")]
		[IteratorStateMachine(typeof(NPPSUDYOKJJ<>.WZXDBZGNJSH))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x715B4B0", Offset = "0x7159EB0", VA = "0x18715B4B0", Slot = "5")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class LOZOPEDHVVU
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3C0CCC0", Offset = "0x3C0B6C0", VA = "0x183C0CCC0")]
		public static Func<a> COIORWEDXWM<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3C0CDB0", Offset = "0x3C0B7B0", VA = "0x183C0CDB0")]
		private static c GQYRZQUXQLL<c>(this object a)
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

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA548B40", Offset = "0xA547540", VA = "0x18A548B40")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA548B50", Offset = "0xA547550", VA = "0x18A548B50")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA5489B0", Offset = "0xA5473B0", VA = "0x18A5489B0")]
		private static byte UDFKUPIDUPD(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA542120", Offset = "0xA540B20", VA = "0x18A542120")]
		private static byte ESFCSRBMVMN(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA548150", Offset = "0xA546B50", VA = "0x18A548150")]
		public void RSXNQYUMOFP(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class STRILRMOQTT
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA553A70", Offset = "0xA552470", VA = "0x18A553A70")]
		public static bool PMKUKLVHFAT(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA553B70", Offset = "0xA552570", VA = "0x18A553B70")]
		public static bool RWDJFDMGNWC(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA553440", Offset = "0xA551E40", VA = "0x18A553440")]
		public static sbyte CKZBUFAZHNX([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA553DB0", Offset = "0xA5527B0", VA = "0x18A553DB0")]
		public static short WGKXLEKYQHG([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA553960", Offset = "0xA552360", VA = "0x18A553960")]
		public static int ILPAECHNAVQ([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA5539C0", Offset = "0xA5523C0", VA = "0x18A5539C0")]
		public static long OJXXPUWAKLP([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA553E10", Offset = "0xA552810", VA = "0x18A553E10")]
		public static bool WWDWBXPCLJA(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA553D50", Offset = "0xA552750", VA = "0x18A553D50")]
		public static byte VFHRMKHLQLG([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA553BE0", Offset = "0xA5525E0", VA = "0x18A553BE0")]
		public static ushort TDQSBWDYUKB([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA553500", Offset = "0xA551F00", VA = "0x18A553500")]
		public static uint FHERQRXIHLR([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA5532A0", Offset = "0xA551CA0", VA = "0x18A5532A0")]
		public static ulong ACHGBYVBTSY([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA553FA0", Offset = "0xA5529A0", VA = "0x18A553FA0")]
		public static bool WYTMNQHNLCZ(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA5535C0", Offset = "0xA551FC0", VA = "0x18A5535C0")]
		public static bool HNIDLTXYZHP(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA553C40", Offset = "0xA552640", VA = "0x18A553C40")]
		public static bool UDINAMKRZLT(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA5540F0", Offset = "0xA552AF0", VA = "0x18A5540F0")]
		public static bool ZVJSHEAURIT(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA553A80", Offset = "0xA552480", VA = "0x18A553A80")]
		public static float QNLXWFYPFNQ([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA553560", Offset = "0xA551F60", VA = "0x18A553560")]
		public static bool HAPJXIAFYVZ(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA553350", Offset = "0xA551D50", VA = "0x18A553350")]
		public static double BPEWPJAWWDV([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA5534A0", Offset = "0xA551EA0", VA = "0x18A5534A0")]
		public static bool EZFKSLAEAWK(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA542770", Offset = "0xA541170", VA = "0x18A542770")]
		public static int BOHBTPTTAAH(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA542ED0", Offset = "0xA5418D0", VA = "0x18A542ED0")]
		public static int SNUUMNQDXOQ(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA553790", Offset = "0xA552190", VA = "0x18A553790")]
		public static bool HZAYCSAAZMS([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class APJALNEWNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA543E40", Offset = "0xA542840", VA = "0x18A543E40")]
		public static bool CXTVKHJZJSP(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class GEFKQUZKDYS
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding TWYQJGZEVNT;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class PPOTFBIULBQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA552320", Offset = "0xA550D20", VA = "0x18A552320")]
		public static void EUQCKIENSOX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA5522B0", Offset = "0xA550CB0", VA = "0x18A5522B0")]
		public static void EUKVNBKQJDO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA552400", Offset = "0xA550E00", VA = "0x18A552400")]
		public static void EVAQEVSILLP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA552390", Offset = "0xA550D90", VA = "0x18A552390")]
		public static void EUVJHOYLCAG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA552630", Offset = "0xA551030", VA = "0x18A552630")]
		public static void EXBHDLJIBVB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA5525C0", Offset = "0xA550FC0", VA = "0x18A5525C0")]
		public static void EWWAGEPKSJS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA552EF0", Offset = "0xA5518F0", VA = "0x18A552EF0")]
		public static void QXINRIUVQWQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA552F60", Offset = "0xA551960", VA = "0x18A552F60")]
		public static void QXNUOPOTAHZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA552FD0", Offset = "0xA5519D0", VA = "0x18A552FD0")]
		public static void QXTBLWIQJTI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA553040", Offset = "0xA551A40", VA = "0x18A553040")]
		public static void QXYIJDCNTER(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA552CF0", Offset = "0xA5516F0", VA = "0x18A552CF0")]
		public static void QWNMCHTGFDG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA552D70", Offset = "0xA551770", VA = "0x18A552D70")]
		public static void QWSSZONDOOP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA552DF0", Offset = "0xA5517F0", VA = "0x18A552DF0")]
		public static void QWXZWVHAXZY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA552E70", Offset = "0xA551870", VA = "0x18A552E70")]
		public static void QXDGUCAYHLH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA552BF0", Offset = "0xA5515F0", VA = "0x18A552BF0")]
		public static void QVSKNGRQTJW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA552C70", Offset = "0xA551670", VA = "0x18A552C70")]
		public static void QVXRKNLOCVF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA552950", Offset = "0xA551350", VA = "0x18A552950")]
		public static void LSVPXDGJWAP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA5528D0", Offset = "0xA5512D0", VA = "0x18A5528D0")]
		public static void LSQIZWMMMPG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA552A50", Offset = "0xA551450", VA = "0x18A552A50")]
		public static void LTGDRQUEOXH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA5529D0", Offset = "0xA5513D0", VA = "0x18A5529D0")]
		public static void LTAWUKAHFLY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA552730", Offset = "0xA551130", VA = "0x18A552730")]
		public static void LSAOICEUKHF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA5526A0", Offset = "0xA5510A0", VA = "0x18A5526A0")]
		public static void LRVHKVKXAVW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA552840", Offset = "0xA551240", VA = "0x18A552840")]
		public static void LSLCCPSPDDX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA5527B0", Offset = "0xA5511B0", VA = "0x18A5527B0")]
		public static void LSFVFIYRTSO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA552B60", Offset = "0xA551560", VA = "0x18A552B60")]
		public static void LULTBFJOTNJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA552AD0", Offset = "0xA5514D0", VA = "0x18A552AD0")]
		public static void LUGMDYPRKCA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA552190", Offset = "0xA550B90", VA = "0x18A552190")]
		public static void ESEKYKYHGIG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA552220", Offset = "0xA550C20", VA = "0x18A552220")]
		public static void ESJRVRSEPTP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA552470", Offset = "0xA550E70", VA = "0x18A552470")]
		public static void EVFXCCMFUWY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA552550", Offset = "0xA550F50", VA = "0x18A552550")]
		public static void EVVRTWTXXEZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA5524E0", Offset = "0xA550EE0", VA = "0x18A5524E0")]
		public static void EVQKWQAANTQ(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class WRVFOKJWJGR
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA555D00", Offset = "0xA554700", VA = "0x18A555D00")]
		public static void EXBHDLJIBVB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA555C90", Offset = "0xA554690", VA = "0x18A555C90")]
		public static void EWWAGEPKSJS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA556540", Offset = "0xA554F40", VA = "0x18A556540")]
		public static void QXINRIUVQWQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA5565B0", Offset = "0xA554FB0", VA = "0x18A5565B0")]
		public static void QXNUOPOTAHZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA556620", Offset = "0xA555020", VA = "0x18A556620")]
		public static void QXTBLWIQJTI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA556690", Offset = "0xA555090", VA = "0x18A556690")]
		public static void QXYIJDCNTER(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA556370", Offset = "0xA554D70", VA = "0x18A556370")]
		public static void QWNMCHTGFDG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA5563E0", Offset = "0xA554DE0", VA = "0x18A5563E0")]
		public static void QWSSZONDOOP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA556450", Offset = "0xA554E50", VA = "0x18A556450")]
		public static void QWXZWVHAXZY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA5564C0", Offset = "0xA554EC0", VA = "0x18A5564C0")]
		public static void QXDGUCAYHLH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA556270", Offset = "0xA554C70", VA = "0x18A556270")]
		public static void QVSKNGRQTJW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA5562F0", Offset = "0xA554CF0", VA = "0x18A5562F0")]
		public static void QVXRKNLOCVF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA555FF0", Offset = "0xA5549F0", VA = "0x18A555FF0")]
		public static void LSVPXDGJWAP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA555F70", Offset = "0xA554970", VA = "0x18A555F70")]
		public static void LSQIZWMMMPG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA5560F0", Offset = "0xA554AF0", VA = "0x18A5560F0")]
		public static void LTGDRQUEOXH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA556070", Offset = "0xA554A70", VA = "0x18A556070")]
		public static void LTAWUKAHFLY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA555DF0", Offset = "0xA5547F0", VA = "0x18A555DF0")]
		public static void LSAOICEUKHF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA555D70", Offset = "0xA554770", VA = "0x18A555D70")]
		public static void LRVHKVKXAVW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA555EF0", Offset = "0xA5548F0", VA = "0x18A555EF0")]
		public static void LSLCCPSPDDX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA555E70", Offset = "0xA554870", VA = "0x18A555E70")]
		public static void LSFVFIYRTSO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA5561F0", Offset = "0xA554BF0", VA = "0x18A5561F0")]
		public static void LULTBFJOTNJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA556170", Offset = "0xA554B70", VA = "0x18A556170")]
		public static void LUGMDYPRKCA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA555B90", Offset = "0xA554590", VA = "0x18A555B90")]
		public static void ESEKYKYHGIG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA555C10", Offset = "0xA554610", VA = "0x18A555C10")]
		public static void ESJRVRSEPTP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA552470", Offset = "0xA550E70", VA = "0x18A552470")]
		public static void EVFXCCMFUWY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA552550", Offset = "0xA550F50", VA = "0x18A552550")]
		public static void EVVRTWTXXEZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5524E0", Offset = "0xA550EE0", VA = "0x18A5524E0")]
		public static void EVQKWQAANTQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA552320", Offset = "0xA550D20", VA = "0x18A552320")]
		public static void EUQCKIENSOX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA5522B0", Offset = "0xA550CB0", VA = "0x18A5522B0")]
		public static void EUKVNBKQJDO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA552400", Offset = "0xA550E00", VA = "0x18A552400")]
		public static void EVAQEVSILLP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA552390", Offset = "0xA550D90", VA = "0x18A552390")]
		public static void EUVJHOYLCAG(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class YFOFIAVIERZ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool KALWZIPDBNQ;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA56FD00", Offset = "0xA56E700", VA = "0x18A56FD00")]
		public static void CDENAUQDNFH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA571750", Offset = "0xA570150", VA = "0x18A571750")]
		public static void FURTBDEDNDW(JsonWriter a, byte[] b)
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

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D430", Offset = "0x2B9BE30", VA = "0x182B9D430")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA55A400", Offset = "0xA558E00", VA = "0x18A55A400")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA55A360", Offset = "0xA558D60", VA = "0x18A55A360")]
		public static DiyFp QRNSGXWDHSC(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA55A2D0", Offset = "0xA558CD0", VA = "0x18A55A2D0")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA55A230", Offset = "0xA558C30", VA = "0x18A55A230")]
		public static DiyFp JRHIYXSIVNW(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA55A3C0", Offset = "0xA558DC0", VA = "0x18A55A3C0")]
		public void QZMJZJRERLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA55A370", Offset = "0xA558D70", VA = "0x18A55A370")]
		public static DiyFp QZMJZJRERLD(DiyFp a)
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

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xDCA1F0", Offset = "0xDC8BF0", VA = "0x180DCA1F0")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA5425C0", Offset = "0xA540FC0", VA = "0x18A5425C0")]
		public void ODRVBICQBKQ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA56B470", Offset = "0xA569E70", VA = "0x18A56B470")]
		public void LAFSDWXSJBC(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA56B3F0", Offset = "0xA569DF0", VA = "0x18A56B3F0")]
		public void HTMSWPTQYYA(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA56B350", Offset = "0xA569D50", VA = "0x18A56B350")]
		public void HTMSWPTQYYA(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA56B5F0", Offset = "0xA569FF0", VA = "0x18A56B5F0")]
		public void RCHNRTXUALA(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA56B4F0", Offset = "0xA569EF0", VA = "0x18A56B4F0")]
		public void MZUUDJHIUWJ(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class FNMVAWDHQLX
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
		private static byte[] HNQVKYKYFKK;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] NFQBQAMUUWO;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] UEDVEFWKUIU;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] RNBOOGSXIEZ;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags FHLOBXQVNKC;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char PQCCAOPSKUW;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int ZYOXDQZPGOS;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int MPTIEKQCBRU;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] XASNHQQPZBO;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA55CB90", Offset = "0xA55B590", VA = "0x18A55CB90")]
		private static byte[] IAGKCNPWCNM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA55CD50", Offset = "0xA55B750", VA = "0x18A55CD50")]
		private static byte[] KHLMJKLCISC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA55D870", Offset = "0xA55C270", VA = "0x18A55D870")]
		public static int WGWXBTQLXAF(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA55D990", Offset = "0xA55C390", VA = "0x18A55D990")]
		public static int WGWXBTQLXAF(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA55CE30", Offset = "0xA55B830", VA = "0x18A55CE30")]
		private static bool NGFARIBKSGP(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA55CC60", Offset = "0xA55B660", VA = "0x18A55CC60")]
		private static void KFQAPZZZNHV(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA55D2C0", Offset = "0xA55BCC0", VA = "0x18A55D2C0")]
		private static bool SCEXSIOKMFV(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA55C1E0", Offset = "0xA55ABE0", VA = "0x18A55C1E0")]
		private static bool AAWWBKESTJR(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA55CA90", Offset = "0xA55B490", VA = "0x18A55CA90")]
		private static bool BIAXNVOOZDW(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA55DF90", Offset = "0xA55C990", VA = "0x18A55DF90")]
		private static bool YFCCQZNFXJL(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA55DAB0", Offset = "0xA55C4B0", VA = "0x18A55DAB0")]
		private static bool XHQZZMDHUNW(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA55CF20", Offset = "0xA55B920", VA = "0x18A55CF20")]
		private static void PWCGKGOXPOM(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA55C660", Offset = "0xA55B060", VA = "0x18A55C660")]
		private static void AGZNDTMMEFK(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA55D680", Offset = "0xA55C080", VA = "0x18A55D680")]
		private static bool UQRSJSFQWSR(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA55AA30", Offset = "0xA559430", VA = "0x18A55AA30")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA55A990", Offset = "0xA559390", VA = "0x18A55A990")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA55A4B0", Offset = "0xA558EB0", VA = "0x18A55A4B0")]
		public DiyFp HMPNZGCAIYW()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA55A8F0", Offset = "0xA5592F0", VA = "0x18A55A8F0")]
		public DiyFp YMLLCUGKAWB()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560")]
		public ulong LVAKUVLEPOE()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA55A650", Offset = "0xA559050", VA = "0x18A55A650")]
		public double TPBMRWPPSNM()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA55A850", Offset = "0xA559250", VA = "0x18A55A850")]
		public double XYVQLEFVMRM()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA55A520", Offset = "0xA558F20", VA = "0x18A55A520")]
		public int JSSHCHTQUJH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA55A610", Offset = "0xA559010", VA = "0x18A55A610")]
		public ulong OYDJDJPMJMV()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA55A6F0", Offset = "0xA5590F0", VA = "0x18A55A6F0")]
		public bool VKDOLWHZEBA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA55A970", Offset = "0xA559370", VA = "0x18A55A970")]
		public bool ZCSYFBWTGUR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA55A410", Offset = "0xA558E10", VA = "0x18A55A410")]
		public bool CUENNUJREDN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xA55A5E0", Offset = "0xA558FE0", VA = "0x18A55A5E0")]
		public bool MGYKXUVGAUW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA55A440", Offset = "0xA558E40", VA = "0x18A55A440")]
		public int DJUOBLTWXCL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA55A710", Offset = "0xA559110", VA = "0x18A55A710")]
		public void WAKGWOLQQHD([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA55A460", Offset = "0xA558E60", VA = "0x18A55A460")]
		public bool EKWKIBDVCDV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x40A7C00", Offset = "0x40A6600", VA = "0x1840A7C00")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA55A6D0", Offset = "0xA5590D0", VA = "0x18A55A6D0")]
		public static int TXWEFHWBCBI(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA55A640", Offset = "0xA559040", VA = "0x18A55A640")]
		public static double THDVWOEVHUC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA55A550", Offset = "0xA558F50", VA = "0x18A55A550")]
		public static ulong MCUPXDWJWFT(DiyFp a)
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

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x188D340", Offset = "0x188BD40", VA = "0x18188D340")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA56B170", Offset = "0xA569B70", VA = "0x18A56B170")]
		public DiyFp HMPNZGCAIYW()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xF8BD10", Offset = "0xF8A710", VA = "0x180F8BD10")]
		public uint TXEVRMLGZPN()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA56B1D0", Offset = "0xA569BD0", VA = "0x18A56B1D0")]
		public int JSSHCHTQUJH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA56B1F0", Offset = "0xA569BF0", VA = "0x18A56B1F0")]
		public uint OYDJDJPMJMV()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA56B210", Offset = "0xA569C10", VA = "0x18A56B210")]
		public bool VKDOLWHZEBA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA56B220", Offset = "0xA569C20", VA = "0x18A56B220")]
		public void WAKGWOLQQHD([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA56B130", Offset = "0xA569B30", VA = "0x18A56B130")]
		public bool EKWKIBDVCDV()
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

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0xA5597E0", Offset = "0xA5581E0", VA = "0x18A5597E0")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class TJHXZGLPMWK
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] DELLJWXUVHF;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA56BC90", Offset = "0xA56A690", VA = "0x18A56BC90")]
		public static void WKILVWSDNSL(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA56BBC0", Offset = "0xA56A5C0", VA = "0x18A56BBC0")]
		public static void GEEREWLWQTO(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0xA56DF00", Offset = "0xA56C900", VA = "0x18A56DF00")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4EF9B80", Offset = "0x4EF8580", VA = "0x184EF9B80")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2DD3540", Offset = "0x2DD1F40", VA = "0x182DD3540")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA56DEA0", Offset = "0xA56C8A0", VA = "0x18A56DEA0")]
		public Vector GEKDFJVFCVJ(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class PLGWAYTSMHB
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] ONOITYQYCMZ;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] FHGTGJTDWHG;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int LPEYJVZPQQV;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA569B30", Offset = "0xA568530", VA = "0x18A569B30")]
		private static byte[] RBUBZDKXHVH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA569830", Offset = "0xA568230", VA = "0x18A569830")]
		private static Vector GXSTKOXPECD(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA569C10", Offset = "0xA568610", VA = "0x18A569C10")]
		private static Vector UDIXQXDAZIB(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA568820", Offset = "0xA567220", VA = "0x18A568820")]
		private static void ANCJKJSCPYY(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA569540", Offset = "0xA567F40", VA = "0x18A569540")]
		private static void FLSFGKJOPLD(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA569910", Offset = "0xA568310", VA = "0x18A569910")]
		private static ulong KEJUXFYLZDG(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA568CA0", Offset = "0xA5676A0", VA = "0x18A568CA0")]
		private static void EVPZCPZRXZM(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA569CF0", Offset = "0xA5686F0", VA = "0x18A569CF0")]
		private static bool YHCYTQHWVJT(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA5699A0", Offset = "0xA5683A0", VA = "0x18A5699A0")]
		private static DiyFp LRVNWERKQCC(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA568F00", Offset = "0xA567900", VA = "0x18A568F00")]
		private static bool FJZQZMPBFKQ(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA568DE0", Offset = "0xA5677E0", VA = "0x18A568DE0")]
		private static bool FBYGZCNAUII(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA5688B0", Offset = "0xA5672B0", VA = "0x18A5688B0")]
		public static double? CKVGAJXZCFK(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA5689D0", Offset = "0xA5673D0", VA = "0x18A5689D0")]
		public static float? CLFTUXLTVCC(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class JOATYYWNWRL
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] ZUAQQOMZLMJ;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] UEDVEFWKUIU;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] RNBOOGSXIEZ;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] ITGRRITHVGX;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int SCGPBLHCTVR;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] WAABLAUWSWZ;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int QPLLVLIGTTD;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA561EF0", Offset = "0xA5608F0", VA = "0x18A561EF0")]
		private static byte[] CNHLQPVYBIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA562110", Offset = "0xA560B10", VA = "0x18A562110")]
		public static bool HAPJXIAFYVZ(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA561FD0", Offset = "0xA5609D0", VA = "0x18A561FD0")]
		public static bool EZFKSLAEAWK(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA562250", Offset = "0xA560C50", VA = "0x18A562250")]
		private static bool HHYBSIISZIX(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA562500", Offset = "0xA560F00", VA = "0x18A562500")]
		private static bool QKJQQOLQEHQ(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA562400", Offset = "0xA560E00", VA = "0x18A562400")]
		private static bool NBWBXHQNQBB(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA562390", Offset = "0xA560D90", VA = "0x18A562390")]
		private static bool LXWXWBPLIWN(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA5624E0", Offset = "0xA560EE0", VA = "0x18A5624E0")]
		private static double PBOUHMFKJCQ(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA5627D0", Offset = "0xA5611D0", VA = "0x18A5627D0")]
		private static double ZUYVOXAORZE(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class HROTNKWVPUU<a> : QCTFQCWJWUM<a[]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly OIZQEOBWFWS<a> VYVRUTUQCCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour FTERTSNQPNB;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1997FB0", Offset = "0x19969B0", VA = "0x181997FB0")]
		public HROTNKWVPUU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
		public HROTNKWVPUU(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x652BBA0", Offset = "0x652A5A0", VA = "0x18652BBA0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x652B860", Offset = "0x652A260", VA = "0x18652B860", Slot = "5")]
		public a[] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class LTOQNTWWBMF<a> : QCTFQCWJWUM<ArraySegment<a>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly OIZQEOBWFWS<a> VYVRUTUQCCB;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x68EF540", Offset = "0x68EDF40", VA = "0x1868EF540", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x68EF0D0", Offset = "0x68EDAD0", VA = "0x1868EF0D0", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class FTYVJZVSBLN<a> : QCTFQCWJWUM<List<a>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour FTERTSNQPNB;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1997FB0", Offset = "0x19969B0", VA = "0x181997FB0")]
		public FTYVJZVSBLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
		public FTYVJZVSBLN(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x634AD40", Offset = "0x6349740", VA = "0x18634AD40", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x63496A0", Offset = "0x63480A0", VA = "0x1863496A0", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class OUQSDVITAPD<a, b, c, d> : QCTFQCWJWUM<d>, SJEGVGTDTHV where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x72EEDC0", Offset = "0x72ED7C0", VA = "0x1872EEDC0", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x72EDFD0", Offset = "0x72EC9D0", VA = "0x1872EDFD0", Slot = "5")]
		public d Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c TDBMHKRQEUB(d a);

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract b Create();

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void Add(b collection, int index, a value);

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract d Complete(b intermediateCollection);

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected OUQSDVITAPD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class OUVZBCCQKAM<a, b, c> : OUQSDVITAPD<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x72EFC40", Offset = "0x72EE640", VA = "0x1872EFC40", Slot = "6")]
		protected override IEnumerator<a> TDBMHKRQEUB(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected OUVZBCCQKAM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class OVBFYIWNTLV<a, b> : OUVZBCCQKAM<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD76EE0", Offset = "0xD758E0", VA = "0x180D76EE0", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class LMOYSSJBGJH<a, b> : OVBFYIWNTLV<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x68CE820", Offset = "0x68CD220", VA = "0x1868CE820", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x68CE6B0", Offset = "0x68CD0B0", VA = "0x1868CE6B0", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class GOMUVYCCEPC<a> : OUQSDVITAPD<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x64691C0", Offset = "0x6467BC0", VA = "0x1864691C0", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD76EE0", Offset = "0xD758E0", VA = "0x180D76EE0", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x64692B0", Offset = "0x6467CB0", VA = "0x1864692B0", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x571A910", Offset = "0x5719310", VA = "0x18571A910", Slot = "6")]
		protected override LinkedList<a>.Enumerator TDBMHKRQEUB(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class PUVZOLEWRSN<a> : OUQSDVITAPD<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4F37C90", Offset = "0x4F36690", VA = "0x184F37C90", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4F37D80", Offset = "0x4F36780", VA = "0x184F37D80", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6F45520", Offset = "0x6F43F20", VA = "0x186F45520", Slot = "6")]
		protected override Queue<a>.Enumerator TDBMHKRQEUB(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xD76EE0", Offset = "0xD758E0", VA = "0x180D76EE0", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class LGBBVRQVNIP<a> : OUQSDVITAPD<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4F411E0", Offset = "0x4F3FBE0", VA = "0x184F411E0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x4F41420", Offset = "0x4F3FE20", VA = "0x184F41420", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x68C0030", Offset = "0x68BEA30", VA = "0x1868C0030", Slot = "6")]
		protected override Stack<a>.Enumerator TDBMHKRQEUB(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x68BFEC0", Offset = "0x68BE8C0", VA = "0x1868BFEC0", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class MZZVYNHAVYT<a> : OUQSDVITAPD<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6F45430", Offset = "0x6F43E30", VA = "0x186F45430", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xD76EE0", Offset = "0xD758E0", VA = "0x180D76EE0", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6F45470", Offset = "0x6F43E70", VA = "0x186F45470", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6F454D0", Offset = "0x6F43ED0", VA = "0x186F454D0", Slot = "6")]
		protected override HashSet<a>.Enumerator TDBMHKRQEUB(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6F455D0", Offset = "0x6F43FD0", VA = "0x186F455D0")]
		public MZZVYNHAVYT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class TDLJHXQBIAV<a> : OUVZBCCQKAM<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x4F411E0", Offset = "0x4F3FBE0", VA = "0x184F411E0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7A42A20", Offset = "0x7A41420", VA = "0x187A42A20", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7A42AC0", Offset = "0x7A414C0", VA = "0x187A42AC0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class UTYGHDIGKVU<a> : OUVZBCCQKAM<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x4F37C90", Offset = "0x4F36690", VA = "0x184F37C90", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x4F37D80", Offset = "0x4F36780", VA = "0x184F37D80", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xD76EE0", Offset = "0xD758E0", VA = "0x180D76EE0", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class BSQRYCNEMPY<a> : OUVZBCCQKAM<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x4F37C90", Offset = "0x4F36690", VA = "0x184F37C90", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x4F37D80", Offset = "0x4F36780", VA = "0x184F37D80", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xD76EE0", Offset = "0xD758E0", VA = "0x180D76EE0", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class UNRCVAYKNMI<a> : OUVZBCCQKAM<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x652C960", Offset = "0x652B360", VA = "0x18652C960", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x4F41420", Offset = "0x4F3FE20", VA = "0x184F41420", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6F319B0", Offset = "0x6F303B0", VA = "0x186F319B0", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6F319D0", Offset = "0x6F303D0", VA = "0x186F319D0")]
		public UNRCVAYKNMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class ZTDRWRICOYM<a, b> : QCTFQCWJWUM<IGrouping<a, b>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5162470", Offset = "0x5160E70", VA = "0x185162470", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5162100", Offset = "0x5160B00", VA = "0x185162100", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class LZXBGPBKDHD<a, b> : QCTFQCWJWUM<ILookup<a, b>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6900370", Offset = "0x68FED70", VA = "0x186900370", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6900010", Offset = "0x68FEA10", VA = "0x186900010", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class FLCNLVNGYJD<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a ZOYFTTVDVER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> GAZJONTSFSH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x4EF73B0", Offset = "0x4EF5DB0", VA = "0x184EF73B0", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6304D50", Offset = "0x6303750", VA = "0x186304D50")]
		public FLCNLVNGYJD(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x6304C40", Offset = "0x6303640", VA = "0x186304C40", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6304D20", Offset = "0x6303720", VA = "0x186304D20", Slot = "6")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class PBDWEBDEBIS<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> IPZDVRDFGUM;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x73DEB00", Offset = "0x73DD500", VA = "0x1873DEB00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public PBDWEBDEBIS(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x73DE960", Offset = "0x73DD360", VA = "0x1873DE960", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x73DEA50", Offset = "0x73DD450", VA = "0x1873DEA50", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x73DEA50", Offset = "0x73DD450", VA = "0x1873DEA50", Slot = "7")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class DPDJXBSUATZ<a> : QCTFQCWJWUM<a>, SJEGVGTDTHV where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x53B6A00", Offset = "0x53B5400", VA = "0x1853B6A00", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x53B67D0", Offset = "0x53B51D0", VA = "0x1853B67D0", Slot = "5")]
		public a Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public DPDJXBSUATZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class LKBZZHJZCST : QCTFQCWJWUM<IEnumerable>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly QCTFQCWJWUM<IEnumerable> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA564AF0", Offset = "0xA5634F0", VA = "0x18A564AF0", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA5648E0", Offset = "0xA5632E0", VA = "0x18A5648E0", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public LKBZZHJZCST()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class HRMXIQXEEUZ : QCTFQCWJWUM<ICollection>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly QCTFQCWJWUM<ICollection> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA560510", Offset = "0xA55EF10", VA = "0x18A560510", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA560300", Offset = "0xA55ED00", VA = "0x18A560300", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public HRMXIQXEEUZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class HVLXCHXDIIZ : QCTFQCWJWUM<IList>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly QCTFQCWJWUM<IList> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA560BD0", Offset = "0xA55F5D0", VA = "0x18A560BD0", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA5609C0", Offset = "0xA55F3C0", VA = "0x18A5609C0", Slot = "5")]
		public IList Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public HVLXCHXDIIZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class UQKDCTVCBLW<a> : OVBFYIWNTLV<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x4F37C90", Offset = "0x4F36690", VA = "0x184F37C90", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7D28C70", Offset = "0x7D27670", VA = "0x187D28C70", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class VCTMAHJLKCG<a> : OUVZBCCQKAM<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x4F37C90", Offset = "0x4F36690", VA = "0x184F37C90", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7D28C70", Offset = "0x7D27670", VA = "0x187D28C70", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7E38170", Offset = "0x7E36B70", VA = "0x187E38170", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class HWSQBEFNXDW<a> : OUVZBCCQKAM<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x652C8F0", Offset = "0x652B2F0", VA = "0x18652C8F0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x4F41420", Offset = "0x4F3FE20", VA = "0x184F41420", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x652CA10", Offset = "0x652B410", VA = "0x18652CA10", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x652CB40", Offset = "0x652B540", VA = "0x18652CB40")]
		public HWSQBEFNXDW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class MOTMNNQIKZO<a> : OUVZBCCQKAM<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x652C8F0", Offset = "0x652B2F0", VA = "0x18652C8F0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x4F41420", Offset = "0x4F3FE20", VA = "0x184F41420", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6F319B0", Offset = "0x6F303B0", VA = "0x186F319B0", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6F319D0", Offset = "0x6F303D0", VA = "0x186F319D0")]
		public MOTMNNQIKZO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class IUUNXYATXEY<a> : OUVZBCCQKAM<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6609810", Offset = "0x6608210", VA = "0x186609810", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xD76EE0", Offset = "0xD758E0", VA = "0x180D76EE0", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x64692B0", Offset = "0x6467CB0", VA = "0x1864692B0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class ZALNVINEOJS<a> : OVBFYIWNTLV<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x4F37C90", Offset = "0x4F36690", VA = "0x184F37C90", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4F37D80", Offset = "0x4F36780", VA = "0x184F37D80", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class MAEXCKIITSX<a> : OVBFYIWNTLV<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x4F37C90", Offset = "0x4F36690", VA = "0x184F37C90", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x4F37D80", Offset = "0x4F36780", VA = "0x184F37D80", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class BWUEQCJLSZQ<a> : OUVZBCCQKAM<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x4F411E0", Offset = "0x4F3FBE0", VA = "0x184F411E0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x4F41420", Offset = "0x4F3FE20", VA = "0x184F41420", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x4F412C0", Offset = "0x4F3FCC0", VA = "0x184F412C0", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class MGDLHZDSDLJ
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

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA565D70", Offset = "0xA564770", VA = "0x18A565D70")]
		public static DateTime PJMUKRJMANN(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA565BC0", Offset = "0xA5645C0", VA = "0x18A565BC0")]
		public static bool LYELKXWAWAG(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA566040", Offset = "0xA564A40", VA = "0x18A566040")]
		public static bool SCGPALXJZUO(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA565E30", Offset = "0xA564830", VA = "0x18A565E30")]
		public static bool SCGPALXJZUO(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA565990", Offset = "0xA564390", VA = "0x18A565990")]
		public static bool GAHJBVTOFDW(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class OVRFIBPOUXJ : QCTFQCWJWUM<DateTime>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly QCTFQCWJWUM<DateTime> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xA567C00", Offset = "0xA566600", VA = "0x18A567C00", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA567680", Offset = "0xA566080", VA = "0x18A567680", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA567800", Offset = "0xA566200", VA = "0x18A567800")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public OVRFIBPOUXJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class GTUOYOYFZTM : QCTFQCWJWUM<DateTimeOffset>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly QCTFQCWJWUM<DateTimeOffset> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA55F490", Offset = "0xA55DE90", VA = "0x18A55F490", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA55F420", Offset = "0xA55DE20", VA = "0x18A55F420", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA55F040", Offset = "0xA55DA40", VA = "0x18A55F040")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public GTUOYOYFZTM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class QEWLJRJXIPJ : QCTFQCWJWUM<TimeSpan>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly QCTFQCWJWUM<TimeSpan> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] IPEEHSKVDPJ;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA56A5F0", Offset = "0xA568FF0", VA = "0x18A56A5F0", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA56A570", Offset = "0xA568F70", VA = "0x18A56A570", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA56A180", Offset = "0xA568B80", VA = "0x18A56A180")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public QEWLJRJXIPJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class UCWFBWUZAFY<a, b, c, d, e> : QCTFQCWJWUM<e>, SJEGVGTDTHV where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7D1A400", Offset = "0x7D18E00", VA = "0x187D1A400", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7D133E0", Offset = "0x7D11DE0", VA = "0x187D133E0", Slot = "5")]
		public e Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d TDBMHKRQEUB(e a);

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract c Create();

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void Add(c collection, int index, a key, b value);

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract e Complete(c intermediateCollection);

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected UCWFBWUZAFY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class UDBLZDOWJRH<a, b, c, d> : UCWFBWUZAFY<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x72EFC40", Offset = "0x72EE640", VA = "0x1872EFC40", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> TDBMHKRQEUB(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected UDBLZDOWJRH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class UBQPSIFOVPW<a, b, c> : UDBLZDOWJRH<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xD76EE0", Offset = "0xD758E0", VA = "0x180D76EE0", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class ANGKVHTPZWS<a, b> : UCWFBWUZAFY<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x721F000", Offset = "0x721DA00", VA = "0x18721F000", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xD76EE0", Offset = "0xD758E0", VA = "0x180D76EE0", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x721F1A0", Offset = "0x721DBA0", VA = "0x18721F1A0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x721F310", Offset = "0x721DD10", VA = "0x18721F310", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator TDBMHKRQEUB(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6976FC0", Offset = "0x69759C0", VA = "0x186976FC0")]
		public ANGKVHTPZWS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class XHPUSVZMGIO<a, b, c> : UBQPSIFOVPW<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x511B930", Offset = "0x511A330", VA = "0x18511B930", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x511BB20", Offset = "0x511A520", VA = "0x18511BB20", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class MCHUXLGNLDF<a, b> : UDBLZDOWJRH<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x51510A0", Offset = "0x514FAA0", VA = "0x1851510A0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x5151210", Offset = "0x514FC10", VA = "0x185151210", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xD76EE0", Offset = "0xD758E0", VA = "0x180D76EE0", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class YVQJTSBGJHP<a, b> : UBQPSIFOVPW<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x51510A0", Offset = "0x514FAA0", VA = "0x1851510A0", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x5151210", Offset = "0x514FC10", VA = "0x185151210", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class OTRBJNJEHTP<a, b> : UCWFBWUZAFY<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x51510A0", Offset = "0x514FAA0", VA = "0x1851510A0", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xD76EE0", Offset = "0xD758E0", VA = "0x180D76EE0", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x5151210", Offset = "0x514FC10", VA = "0x185151210", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x72EDAA0", Offset = "0x72EC4A0", VA = "0x1872EDAA0", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator TDBMHKRQEUB(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class FEZZOUOBLYY<a, b> : UDBLZDOWJRH<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x51510A0", Offset = "0x514FAA0", VA = "0x1851510A0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x62FC0A0", Offset = "0x62FAAA0", VA = "0x1862FC0A0", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x62FC110", Offset = "0x62FAB10", VA = "0x1862FC110", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class SGPXXTSRATL<a, b> : UDBLZDOWJRH<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x78F00D0", Offset = "0x78EEAD0", VA = "0x1878F00D0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD76EE0", Offset = "0xD758E0", VA = "0x180D76EE0", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x78F0170", Offset = "0x78EEB70", VA = "0x1878F0170", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F455D0", Offset = "0x6F43FD0", VA = "0x186F455D0")]
		public SGPXXTSRATL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class RDBSMNJHBRP<a, b> : UBQPSIFOVPW<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7644140", Offset = "0x7642B40", VA = "0x187644140", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5151210", Offset = "0x514FC10", VA = "0x185151210", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class EZVNZCCMXYD<a> : QCTFQCWJWUM<a>, SJEGVGTDTHV where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x5B9B740", Offset = "0x5B9A140", VA = "0x185B9B740", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x5B9B510", Offset = "0x5B99F10", VA = "0x185B9B510", Slot = "5")]
		public a Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public EZVNZCCMXYD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class ODPWFTSTQPP : QCTFQCWJWUM<IDictionary>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly QCTFQCWJWUM<IDictionary> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA566C20", Offset = "0xA565620", VA = "0x18A566C20", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA566A40", Offset = "0xA565440", VA = "0x18A566A40", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public ODPWFTSTQPP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class WKSRVETHJED
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA56DF40", Offset = "0xA56C940", VA = "0x18A56DF40")]
		public static object BQEOJKMMTEL(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA56E760", Offset = "0xA56D160", VA = "0x18A56E760")]
		public static object DWEGXPKVCZM(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class CGWOBANNYNO<a> : QCTFQCWJWUM<a>, SJEGVGTDTHV, PARBLNNFTUR<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class WKDUFJUPYFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type ONBAXEIQBBQ;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WKDUFJUPYFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x872B380", Offset = "0x8729D80", VA = "0x18872B380")]
			internal bool SRMUOBYLHFJ(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class WKJBCQONHQX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string YBTEBSDVYSQ;

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WKJBCQONHQX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x872C670", Offset = "0x872B070", VA = "0x18872C670")]
			internal bool SRHNQVENXUA(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class WKOHZXIKRCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> AWJEKKBICXZ;

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WKOHZXIKRCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x8734CF0", Offset = "0x87336F0", VA = "0x188734CF0")]
			internal void SRXIIPMGACB(JsonWriter a, a b, ICATWVBKUQB c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class WKTOXECIANP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> CPDHQHXPVNQ;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WKTOXECIANP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x8735180", Offset = "0x8733B80", VA = "0x188735180")]
			internal a SRSBLISIQQS(JsonReader a, ICATWVBKUQB b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly NPPSUDYOKJJ<a> JLNULOSTCWY;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> ZKVEFGLYUZA;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> VEKHNSNMLPA;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> FFZKPHSMVXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool MZIKYBRBGQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> BDYEQERINRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> PFPZCOHOKSY;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x506D980", Offset = "0x506C380", VA = "0x18506D980")]
		static CGWOBANNYNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x506EA70", Offset = "0x506D470", VA = "0x18506EA70")]
		public CGWOBANNYNO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x506A520", Offset = "0x5068F20", VA = "0x18506A520", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5069200", Offset = "0x5067C00", VA = "0x185069200", Slot = "5")]
		public a Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5069DE0", Offset = "0x50687E0", VA = "0x185069DE0", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, a b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5069CE0", Offset = "0x50686E0", VA = "0x185069CE0", Slot = "7")]
		public a MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class KAWZPIDLBDG<a> : QCTFQCWJWUM<a[,]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x67DD640", Offset = "0x67DC040", VA = "0x1867DD640", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x67DD290", Offset = "0x67DBC90", VA = "0x1867DD290", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KAWZPIDLBDG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class BJHEFAMFKWG<a> : QCTFQCWJWUM<a[,,]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x4F347F0", Offset = "0x4F331F0", VA = "0x184F347F0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x4F342F0", Offset = "0x4F32CF0", VA = "0x184F342F0", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public BJHEFAMFKWG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class SHEUGTMYWBY<a> : QCTFQCWJWUM<a[,,,]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x78F0810", Offset = "0x78EF210", VA = "0x1878F0810", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x78F01D0", Offset = "0x78EEBD0", VA = "0x1878F01D0", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public SHEUGTMYWBY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class CYUTRWMNKGQ<a> : QCTFQCWJWUM<a?>, SJEGVGTDTHV where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x50B4190", Offset = "0x50B2B90", VA = "0x1850B4190", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x50B4050", Offset = "0x50B2A50", VA = "0x1850B4050", Slot = "5")]
		public a? Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public CYUTRWMNKGQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class OTHULLPRSIW<a> : QCTFQCWJWUM<a?>, SJEGVGTDTHV where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly QCTFQCWJWUM<a> WMPGPOGSLPP;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public OTHULLPRSIW(QCTFQCWJWUM<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x72EA730", Offset = "0x72E9130", VA = "0x1872EA730", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x72EA5B0", Offset = "0x72E8FB0", VA = "0x1872EA5B0", Slot = "5")]
		public a? Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class OBMBATKDLUJ : QCTFQCWJWUM<sbyte>, SJEGVGTDTHV, PARBLNNFTUR<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly OBMBATKDLUJ FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA566940", Offset = "0xA565340", VA = "0x18A566940", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA5667A0", Offset = "0xA5651A0", VA = "0x18A5667A0", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA566830", Offset = "0xA565230", VA = "0x18A566830", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, sbyte b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5667B0", Offset = "0xA5651B0", VA = "0x18A5667B0", Slot = "7")]
		public sbyte MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public OBMBATKDLUJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class ZZGODPQIKME : QCTFQCWJWUM<sbyte?>, SJEGVGTDTHV, PARBLNNFTUR<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly ZZGODPQIKME FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA572420", Offset = "0xA570E20", VA = "0x18A572420", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA572180", Offset = "0xA570B80", VA = "0x18A572180", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA5722C0", Offset = "0xA570CC0", VA = "0x18A5722C0", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, sbyte? b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA5721F0", Offset = "0xA570BF0", VA = "0x18A5721F0", Slot = "7")]
		public sbyte? MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public ZZGODPQIKME()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class EATIUIVLQUQ : QCTFQCWJWUM<sbyte[]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly EATIUIVLQUQ FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA55AB80", Offset = "0xA559580", VA = "0x18A55AB80", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA55AA40", Offset = "0xA559440", VA = "0x18A55AA40", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public EATIUIVLQUQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class XIXDXGTKQYS : QCTFQCWJWUM<short>, SJEGVGTDTHV, PARBLNNFTUR<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly XIXDXGTKQYS FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xA56F730", Offset = "0xA56E130", VA = "0x18A56F730", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA56F590", Offset = "0xA56DF90", VA = "0x18A56F590", Slot = "5")]
		public short Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA56F620", Offset = "0xA56E020", VA = "0x18A56F620", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, short b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA56F5A0", Offset = "0xA56DFA0", VA = "0x18A56F5A0", Slot = "7")]
		public short MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public XIXDXGTKQYS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class UFLGYITIDIL : QCTFQCWJWUM<short?>, SJEGVGTDTHV, PARBLNNFTUR<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly UFLGYITIDIL FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA56DB50", Offset = "0xA56C550", VA = "0x18A56DB50", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA56D8B0", Offset = "0xA56C2B0", VA = "0x18A56D8B0", Slot = "5")]
		public short? Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA56D9F0", Offset = "0xA56C3F0", VA = "0x18A56D9F0", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, short? b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA56D920", Offset = "0xA56C320", VA = "0x18A56D920", Slot = "7")]
		public short? MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public UFLGYITIDIL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class BGKWYZYLBRL : QCTFQCWJWUM<short[]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly BGKWYZYLBRL FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA558840", Offset = "0xA557240", VA = "0x18A558840", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA558700", Offset = "0xA557100", VA = "0x18A558700", Slot = "5")]
		public short[] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public BGKWYZYLBRL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class ZDPZIDFNDSM : QCTFQCWJWUM<int>, SJEGVGTDTHV, PARBLNNFTUR<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly ZDPZIDFNDSM FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA572080", Offset = "0xA570A80", VA = "0x18A572080", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA571EE0", Offset = "0xA5708E0", VA = "0x18A571EE0", Slot = "5")]
		public int Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA571F70", Offset = "0xA570970", VA = "0x18A571F70", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, int b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA571EF0", Offset = "0xA5708F0", VA = "0x18A571EF0", Slot = "7")]
		public int MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public ZDPZIDFNDSM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class JCIJAVEDZYJ : QCTFQCWJWUM<int?>, SJEGVGTDTHV, PARBLNNFTUR<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly JCIJAVEDZYJ FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xA561D90", Offset = "0xA560790", VA = "0x18A561D90", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA561AF0", Offset = "0xA5604F0", VA = "0x18A561AF0", Slot = "5")]
		public int? Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA561C30", Offset = "0xA560630", VA = "0x18A561C30", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, int? b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA561B60", Offset = "0xA560560", VA = "0x18A561B60", Slot = "7")]
		public int? MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public JCIJAVEDZYJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class LVDKIGIIBCH : QCTFQCWJWUM<int[]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly LVDKIGIIBCH FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA5656F0", Offset = "0xA5640F0", VA = "0x18A5656F0", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA5655B0", Offset = "0xA563FB0", VA = "0x18A5655B0", Slot = "5")]
		public int[] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public LVDKIGIIBCH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class FWMSHHWQDUJ : QCTFQCWJWUM<long>, SJEGVGTDTHV, PARBLNNFTUR<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly FWMSHHWQDUJ FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA55E740", Offset = "0xA55D140", VA = "0x18A55E740", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA55E620", Offset = "0xA55D020", VA = "0x18A55E620", Slot = "5")]
		public long Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA55E670", Offset = "0xA55D070", VA = "0x18A55E670", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, long b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA55E630", Offset = "0xA55D030", VA = "0x18A55E630", Slot = "7")]
		public long MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public FWMSHHWQDUJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class BBTNDCHIKBO : QCTFQCWJWUM<long?>, SJEGVGTDTHV, PARBLNNFTUR<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly BBTNDCHIKBO FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xA5585D0", Offset = "0xA556FD0", VA = "0x18A5585D0", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA558360", Offset = "0xA556D60", VA = "0x18A558360", Slot = "5")]
		public long? Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA5584A0", Offset = "0xA556EA0", VA = "0x18A5584A0", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, long? b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA5583F0", Offset = "0xA556DF0", VA = "0x18A5583F0", Slot = "7")]
		public long? MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public BBTNDCHIKBO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class GATMFHEYLYM : QCTFQCWJWUM<long[]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly GATMFHEYLYM FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA55EE10", Offset = "0xA55D810", VA = "0x18A55EE10", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA55ECD0", Offset = "0xA55D6D0", VA = "0x18A55ECD0", Slot = "5")]
		public long[] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public GATMFHEYLYM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class IDTSWCWPROK : QCTFQCWJWUM<byte>, SJEGVGTDTHV, PARBLNNFTUR<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly IDTSWCWPROK FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA561190", Offset = "0xA55FB90", VA = "0x18A561190", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA560FF0", Offset = "0xA55F9F0", VA = "0x18A560FF0", Slot = "5")]
		public byte Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA561080", Offset = "0xA55FA80", VA = "0x18A561080", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, byte b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA561000", Offset = "0xA55FA00", VA = "0x18A561000", Slot = "7")]
		public byte MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public IDTSWCWPROK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class BAQVWSYXQMR : QCTFQCWJWUM<byte?>, SJEGVGTDTHV, PARBLNNFTUR<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly BAQVWSYXQMR FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA558200", Offset = "0xA556C00", VA = "0x18A558200", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA557F60", Offset = "0xA556960", VA = "0x18A557F60", Slot = "5")]
		public byte? Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA5580A0", Offset = "0xA556AA0", VA = "0x18A5580A0", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, byte? b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA557FD0", Offset = "0xA5569D0", VA = "0x18A557FD0", Slot = "7")]
		public byte? MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public BAQVWSYXQMR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class CBQLGWULCYN : QCTFQCWJWUM<ushort>, SJEGVGTDTHV, PARBLNNFTUR<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly CBQLGWULCYN FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA558C80", Offset = "0xA557680", VA = "0x18A558C80", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA558AE0", Offset = "0xA5574E0", VA = "0x18A558AE0", Slot = "5")]
		public ushort Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA558B70", Offset = "0xA557570", VA = "0x18A558B70", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, ushort b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA558AF0", Offset = "0xA5574F0", VA = "0x18A558AF0", Slot = "7")]
		public ushort MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public CBQLGWULCYN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class KDOQQGXXVES : QCTFQCWJWUM<ushort?>, SJEGVGTDTHV, PARBLNNFTUR<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly KDOQQGXXVES FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA564040", Offset = "0xA562A40", VA = "0x18A564040", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA563DA0", Offset = "0xA5627A0", VA = "0x18A563DA0", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA563EE0", Offset = "0xA5628E0", VA = "0x18A563EE0", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, ushort? b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA563E10", Offset = "0xA562810", VA = "0x18A563E10", Slot = "7")]
		public ushort? MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KDOQQGXXVES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class CBRQDSGQDDO : QCTFQCWJWUM<ushort[]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly CBRQDSGQDDO FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA558EC0", Offset = "0xA5578C0", VA = "0x18A558EC0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA558D80", Offset = "0xA557780", VA = "0x18A558D80", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public CBRQDSGQDDO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class KJUURVSIJSH : QCTFQCWJWUM<uint>, SJEGVGTDTHV, PARBLNNFTUR<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly KJUURVSIJSH FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA564340", Offset = "0xA562D40", VA = "0x18A564340", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA5641A0", Offset = "0xA562BA0", VA = "0x18A5641A0", Slot = "5")]
		public uint Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA564230", Offset = "0xA562C30", VA = "0x18A564230", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, uint b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA5641B0", Offset = "0xA562BB0", VA = "0x18A5641B0", Slot = "7")]
		public uint MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KJUURVSIJSH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class OPBHCCONOBG : QCTFQCWJWUM<uint?>, SJEGVGTDTHV, PARBLNNFTUR<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly OPBHCCONOBG FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA567520", Offset = "0xA565F20", VA = "0x18A567520", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA567280", Offset = "0xA565C80", VA = "0x18A567280", Slot = "5")]
		public uint? Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA5673C0", Offset = "0xA565DC0", VA = "0x18A5673C0", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, uint? b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA5672F0", Offset = "0xA565CF0", VA = "0x18A5672F0", Slot = "7")]
		public uint? MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public OPBHCCONOBG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class ECNAFABYHWG : QCTFQCWJWUM<uint[]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly ECNAFABYHWG FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA55AF60", Offset = "0xA559960", VA = "0x18A55AF60", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA55AE20", Offset = "0xA559820", VA = "0x18A55AE20", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public ECNAFABYHWG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class UDACEOJMFGO : QCTFQCWJWUM<ulong>, SJEGVGTDTHV, PARBLNNFTUR<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly UDACEOJMFGO FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xA56D7E0", Offset = "0xA56C1E0", VA = "0x18A56D7E0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA56D6C0", Offset = "0xA56C0C0", VA = "0x18A56D6C0", Slot = "5")]
		public ulong Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA56D710", Offset = "0xA56C110", VA = "0x18A56D710", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, ulong b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xA56D6D0", Offset = "0xA56C0D0", VA = "0x18A56D6D0", Slot = "7")]
		public ulong MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public UDACEOJMFGO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class IQOSLAGYOUZ : QCTFQCWJWUM<ulong?>, SJEGVGTDTHV, PARBLNNFTUR<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly IQOSLAGYOUZ FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xA5616B0", Offset = "0xA5600B0", VA = "0x18A5616B0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA561440", Offset = "0xA55FE40", VA = "0x18A561440", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA561580", Offset = "0xA55FF80", VA = "0x18A561580", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, ulong? b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA5614D0", Offset = "0xA55FED0", VA = "0x18A5614D0", Slot = "7")]
		public ulong? MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public IQOSLAGYOUZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class HRJAGZZAELX : QCTFQCWJWUM<ulong[]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly HRJAGZZAELX FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xA5600D0", Offset = "0xA55EAD0", VA = "0x18A5600D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA55FF90", Offset = "0xA55E990", VA = "0x18A55FF90", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public HRJAGZZAELX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class DWUDECXYOCU : QCTFQCWJWUM<float>, SJEGVGTDTHV, PARBLNNFTUR<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly DWUDECXYOCU FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA55A160", Offset = "0xA558B60", VA = "0x18A55A160", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA55A040", Offset = "0xA558A40", VA = "0x18A55A040", Slot = "5")]
		public float Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA55A090", Offset = "0xA558A90", VA = "0x18A55A090", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, float b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA55A050", Offset = "0xA558A50", VA = "0x18A55A050", Slot = "7")]
		public float MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public DWUDECXYOCU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class LHVSSLKYPCP : QCTFQCWJWUM<float?>, SJEGVGTDTHV, PARBLNNFTUR<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly LHVSSLKYPCP FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xA5647B0", Offset = "0xA5631B0", VA = "0x18A5647B0", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA564580", Offset = "0xA562F80", VA = "0x18A564580", Slot = "5")]
		public float? Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA564690", Offset = "0xA563090", VA = "0x18A564690", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, float? b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA5645F0", Offset = "0xA562FF0", VA = "0x18A5645F0", Slot = "7")]
		public float? MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public LHVSSLKYPCP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class YBRZNKKGOMT : QCTFQCWJWUM<float[]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly YBRZNKKGOMT FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xA56F970", Offset = "0xA56E370", VA = "0x18A56F970", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA56F830", Offset = "0xA56E230", VA = "0x18A56F830", Slot = "5")]
		public float[] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public YBRZNKKGOMT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class LOVMGHRFYNF : QCTFQCWJWUM<double>, SJEGVGTDTHV, PARBLNNFTUR<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly LOVMGHRFYNF FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xA5654E0", Offset = "0xA563EE0", VA = "0x18A5654E0", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA5653C0", Offset = "0xA563DC0", VA = "0x18A5653C0", Slot = "5")]
		public double Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA565410", Offset = "0xA563E10", VA = "0x18A565410", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, double b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA5653D0", Offset = "0xA563DD0", VA = "0x18A5653D0", Slot = "7")]
		public double MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public LOVMGHRFYNF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class TJHTRQPDKHK : QCTFQCWJWUM<double?>, SJEGVGTDTHV, PARBLNNFTUR<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly TJHTRQPDKHK FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA56BA90", Offset = "0xA56A490", VA = "0x18A56BA90", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA56B820", Offset = "0xA56A220", VA = "0x18A56B820", Slot = "5")]
		public double? Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA56B960", Offset = "0xA56A360", VA = "0x18A56B960", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, double? b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA56B8B0", Offset = "0xA56A2B0", VA = "0x18A56B8B0", Slot = "7")]
		public double? MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public TJHTRQPDKHK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class GAQZAQKKCNU : QCTFQCWJWUM<double[]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly GAQZAQKKCNU FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA55E950", Offset = "0xA55D350", VA = "0x18A55E950", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA55E810", Offset = "0xA55D210", VA = "0x18A55E810", Slot = "5")]
		public double[] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public GAQZAQKKCNU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class LMRDSORDBDW : QCTFQCWJWUM<bool>, SJEGVGTDTHV, PARBLNNFTUR<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly LMRDSORDBDW FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA564F90", Offset = "0xA563990", VA = "0x18A564F90", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA564E70", Offset = "0xA563870", VA = "0x18A564E70", Slot = "5")]
		public bool Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA564EC0", Offset = "0xA5638C0", VA = "0x18A564EC0", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, bool b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA564E80", Offset = "0xA563880", VA = "0x18A564E80", Slot = "7")]
		public bool MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public LMRDSORDBDW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class LOSWQRHOEAR : QCTFQCWJWUM<bool?>, SJEGVGTDTHV, PARBLNNFTUR<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly LOSWQRHOEAR FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA565290", Offset = "0xA563C90", VA = "0x18A565290", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA565060", Offset = "0xA563A60", VA = "0x18A565060", Slot = "5")]
		public bool? Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xA565170", Offset = "0xA563B70", VA = "0x18A565170", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, bool? b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA5650D0", Offset = "0xA563AD0", VA = "0x18A5650D0", Slot = "7")]
		public bool? MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public LOSWQRHOEAR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class MYDTAUQEEAD : QCTFQCWJWUM<bool[]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly MYDTAUQEEAD FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA566410", Offset = "0xA564E10", VA = "0x18A566410", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA5662D0", Offset = "0xA564CD0", VA = "0x18A5662D0", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public MYDTAUQEEAD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class KBPLUAORTDP : QCTFQCWJWUM<byte[]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly QCTFQCWJWUM<byte[]> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA563C70", Offset = "0xA562670", VA = "0x18A563C70", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA563C00", Offset = "0xA562600", VA = "0x18A563C00", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KBPLUAORTDP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class FTGJEOAASDO : QCTFQCWJWUM<ArraySegment<byte>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly QCTFQCWJWUM<ArraySegment<byte>> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA55E480", Offset = "0xA55CE80", VA = "0x18A55E480", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA55E3B0", Offset = "0xA55CDB0", VA = "0x18A55E3B0", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public FTGJEOAASDO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class LFAGNPANPNC : QCTFQCWJWUM<string>, SJEGVGTDTHV, PARBLNNFTUR<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly QCTFQCWJWUM<string> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xA5644B0", Offset = "0xA562EB0", VA = "0x18A5644B0", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA564440", Offset = "0xA562E40", VA = "0x18A564440", Slot = "5")]
		public string Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA564450", Offset = "0xA562E50", VA = "0x18A564450", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, string b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA564440", Offset = "0xA562E40", VA = "0x18A564440", Slot = "7")]
		public string MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public LFAGNPANPNC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class YTIYOZPWSAT : QCTFQCWJWUM<string[]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly YTIYOZPWSAT FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA571CB0", Offset = "0xA5706B0", VA = "0x18A571CB0", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA571B60", Offset = "0xA570560", VA = "0x18A571B60", Slot = "5")]
		public string[] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public YTIYOZPWSAT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class XDAPQDDTGYU : QCTFQCWJWUM<char>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly XDAPQDDTGYU FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA56F2C0", Offset = "0xA56DCC0", VA = "0x18A56F2C0", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA56F290", Offset = "0xA56DC90", VA = "0x18A56F290", Slot = "5")]
		public char Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public XDAPQDDTGYU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class CIEJUVGFIKD : QCTFQCWJWUM<char?>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly CIEJUVGFIKD FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA559220", Offset = "0xA557C20", VA = "0x18A559220", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA559160", Offset = "0xA557B60", VA = "0x18A559160", Slot = "5")]
		public char? Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public CIEJUVGFIKD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class CMDDGTFPXVZ : QCTFQCWJWUM<char[]>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly CMDDGTFPXVZ FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA559520", Offset = "0xA557F20", VA = "0x18A559520", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA559390", Offset = "0xA557D90", VA = "0x18A559390", Slot = "5")]
		public char[] Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public CMDDGTFPXVZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class DKYQJKLGEOP : QCTFQCWJWUM<Guid>, SJEGVGTDTHV, PARBLNNFTUR<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly QCTFQCWJWUM<Guid> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA559E60", Offset = "0xA558860", VA = "0x18A559E60", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA559C10", Offset = "0xA558610", VA = "0x18A559C10", Slot = "5")]
		public Guid Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA559CE0", Offset = "0xA5586E0", VA = "0x18A559CE0", Slot = "6")]
		public void RPLCMDUYFUP(JsonWriter a, Guid b, ICATWVBKUQB c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA559C70", Offset = "0xA558670", VA = "0x18A559C70", Slot = "7")]
		public Guid MQJWDVVVYVZ(JsonReader a, ICATWVBKUQB b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public DKYQJKLGEOP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class QXAPULAXFUZ : QCTFQCWJWUM<decimal>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly QCTFQCWJWUM<decimal> FYBGHSPAYRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool MIPIEIYOKJL;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x88AD5E0", Offset = "0x88ABFE0", VA = "0x1888AD5E0")]
		public QXAPULAXFUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xFFD930", Offset = "0xFFC330", VA = "0x180FFD930")]
		public QXAPULAXFUZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA56AEE0", Offset = "0xA5698E0", VA = "0x18A56AEE0", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA56AD10", Offset = "0xA569710", VA = "0x18A56AD10", Slot = "5")]
		public decimal Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class TQJCQVPKEYG : QCTFQCWJWUM<Uri>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly QCTFQCWJWUM<Uri> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA56CD80", Offset = "0xA56B780", VA = "0x18A56CD80", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA56CD00", Offset = "0xA56B700", VA = "0x18A56CD00", Slot = "5")]
		public Uri Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public TQJCQVPKEYG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class XDAYXVXOLVG : QCTFQCWJWUM<Version>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly QCTFQCWJWUM<Version> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA56F460", Offset = "0xA56DE60", VA = "0x18A56F460", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA56F3E0", Offset = "0xA56DDE0", VA = "0x18A56F3E0", Slot = "5")]
		public Version Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public XDAYXVXOLVG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class VNLUNLPJTPY<a, b> : QCTFQCWJWUM<KeyValuePair<a, b>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F71C20", Offset = "0x7F70620", VA = "0x187F71C20", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F71720", Offset = "0x7F70120", VA = "0x187F71720", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class JSPRDRLLYQI : QCTFQCWJWUM<StringBuilder>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly QCTFQCWJWUM<StringBuilder> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA563AF0", Offset = "0xA5624F0", VA = "0x18A563AF0", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA563A70", Offset = "0xA562470", VA = "0x18A563A70", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public JSPRDRLLYQI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class WRNYNXRIIIE : QCTFQCWJWUM<BitArray>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly QCTFQCWJWUM<BitArray> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA56F0A0", Offset = "0xA56DAA0", VA = "0x18A56F0A0", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA56EF80", Offset = "0xA56D980", VA = "0x18A56EF80", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public WRNYNXRIIIE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class JALAVBVECQQ : QCTFQCWJWUM<Type>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly JALAVBVECQQ FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex UDVJXDIMRGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool FKQJSBITVVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool FSMEOWUMDZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool JBGCEXQSREL;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA561AD0", Offset = "0xA5604D0", VA = "0x18A561AD0")]
		public JALAVBVECQQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x98759D0", Offset = "0x98743D0", VA = "0x1898759D0")]
		public JALAVBVECQQ(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5618F0", Offset = "0xA5602F0", VA = "0x18A5618F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5617E0", Offset = "0xA5601E0", VA = "0x18A5617E0", Slot = "5")]
		public Type Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class DJOHDEEODNO : QCTFQCWJWUM<BigInteger>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly QCTFQCWJWUM<BigInteger> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5598A0", Offset = "0xA5582A0", VA = "0x18A5598A0", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5597F0", Offset = "0xA5581F0", VA = "0x18A5597F0", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public DJOHDEEODNO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class DKYDYAIPRUU : QCTFQCWJWUM<Complex>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly QCTFQCWJWUM<Complex> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA559A70", Offset = "0xA558470", VA = "0x18A559A70", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5599E0", Offset = "0xA5583E0", VA = "0x18A5599E0", Slot = "5")]
		public Complex Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public DKYDYAIPRUU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class YHEVRRVLRDA : QCTFQCWJWUM<ExpandoObject>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly QCTFQCWJWUM<ExpandoObject> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA571A60", Offset = "0xA570460", VA = "0x18A571A60", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA571830", Offset = "0xA570230", VA = "0x18A571830", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public YHEVRRVLRDA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class EQECUTLJZRX<a> : QCTFQCWJWUM<Lazy<a>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F9F0", Offset = "0x5B4E3F0", VA = "0x185B4F9F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F7E0", Offset = "0x5B4E1E0", VA = "0x185B4F7E0", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class USBFQVKADVT : QCTFQCWJWUM<Task>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly QCTFQCWJWUM<Task> FYBGHSPAYRJ;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task BLINDHDYIVQ;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA56DD60", Offset = "0xA56C760", VA = "0x18A56DD60", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA56DCB0", Offset = "0xA56C6B0", VA = "0x18A56DCB0", Slot = "5")]
		public Task Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public USBFQVKADVT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class FTQWYAQSFWJ<a> : QCTFQCWJWUM<Task<a>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x6348E40", Offset = "0x6347840", VA = "0x186348E40", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x6348CC0", Offset = "0x63476C0", VA = "0x186348CC0", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class GKGJGKSLZQX<a> : QCTFQCWJWUM<ValueTask<a>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x64637C0", Offset = "0x64621C0", VA = "0x1864637C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x6463590", Offset = "0x6461F90", VA = "0x186463590", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class OFVVKZTIQEZ<a> : QCTFQCWJWUM<Tuple<a>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x72CE6A0", Offset = "0x72CD0A0", VA = "0x1872CE6A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x72CE3B0", Offset = "0x72CCDB0", VA = "0x1872CE3B0", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class OFGATFLQNWY<a, b> : QCTFQCWJWUM<Tuple<a, b>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x72CD1F0", Offset = "0x72CBBF0", VA = "0x1872CD1F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x72CCDA0", Offset = "0x72CB7A0", VA = "0x1872CCDA0", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class OFLHQMFNXIH<a, b, c> : QCTFQCWJWUM<Tuple<a, b, c>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x72CDCE0", Offset = "0x72CC6E0", VA = "0x1872CDCE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x72CD750", Offset = "0x72CC150", VA = "0x1872CD750", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class OGLQCUBASNA<a, b, c, d> : QCTFQCWJWUM<Tuple<a, b, c, d>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x72D1F10", Offset = "0x72D0910", VA = "0x1872D1F10", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x72D1820", Offset = "0x72D0220", VA = "0x1872D1820", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class OGQXAAUYBYJ<a, b, c, d, e> : QCTFQCWJWUM<Tuple<a, b, c, d, e>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x72D2FC0", Offset = "0x72D19C0", VA = "0x1872D2FC0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x72D2760", Offset = "0x72D1160", VA = "0x1872D2760", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class OGBCIGNFZQI<a, b, c, d, e, f> : QCTFQCWJWUM<Tuple<a, b, c, d, e, f>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x72CF480", Offset = "0x72CDE80", VA = "0x1872CF480", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x72CEA90", Offset = "0x72CD490", VA = "0x1872CEA90", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class OGGJFNHDJBR<a, b, c, d, e, f, g> : QCTFQCWJWUM<Tuple<a, b, c, d, e, f, g>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x72D0B50", Offset = "0x72CF550", VA = "0x1872D0B50", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x72CFFD0", Offset = "0x72CE9D0", VA = "0x1872CFFD0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class OEALJQWGJGW<a, b, c, d, e, f, g, h> : QCTFQCWJWUM<Tuple<a, b, c, d, e, f, g, h>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x72CBED0", Offset = "0x72CA8D0", VA = "0x1872CBED0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x72CB1E0", Offset = "0x72C9BE0", VA = "0x1872CB1E0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class MPBRNCDSGUQ<a> : QCTFQCWJWUM<ValueTuple<a>>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x6F31E20", Offset = "0x6F30820", VA = "0x186F31E20", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x6F319F0", Offset = "0x6F303F0", VA = "0x186F319F0", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class MPRMEWLKJCR<a, b> : QCTFQCWJWUM<(a, b)>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x6F33510", Offset = "0x6F31F10", VA = "0x186F33510", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x6F33000", Offset = "0x6F31A00", VA = "0x186F33000", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class MPMFHPRMZRI<a, b, c> : QCTFQCWJWUM<(a, b, c)>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x6F328B0", Offset = "0x6F312B0", VA = "0x186F328B0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x6F32210", Offset = "0x6F30C10", VA = "0x186F32210", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class MQBZZJZFBZJ<a, b, c, d> : QCTFQCWJWUM<(a, b, c, d)>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x6F37240", Offset = "0x6F35C40", VA = "0x186F37240", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x6F369D0", Offset = "0x6F353D0", VA = "0x186F369D0", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class MPWTCDFHSOA<a, b, c, d, e> : QCTFQCWJWUM<(a, b, c, d, e)>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x6F35EF0", Offset = "0x6F348F0", VA = "0x186F35EF0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6F354F0", Offset = "0x6F33EF0", VA = "0x186F354F0", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class MQMNTXMZUWB<a, b, c, d, e, f> : QCTFQCWJWUM<(a, b, c, d, e, f)>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x6F3A3C0", Offset = "0x6F38DC0", VA = "0x186F3A3C0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x6F397A0", Offset = "0x6F381A0", VA = "0x186F397A0", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class MQHGWQTCLKS<a, b, c, d, e, f, g> : QCTFQCWJWUM<(a, b, c, d, e, f, g)>, SJEGVGTDTHV
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x6F38940", Offset = "0x6F37340", VA = "0x186F38940", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6F37B60", Offset = "0x6F36560", VA = "0x186F37B60", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class MQXBOLAUNST<a, b, c, d, e, f, g, h> : QCTFQCWJWUM<ValueTuple<a, b, c, d, e, f, g, h>>, SJEGVGTDTHV where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] BAUUENJLLQY;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly VOGIGHBMNXK FBYXNPGHACW;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C340", Offset = "0x6F3AD40", VA = "0x186F3C340", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, ICATWVBKUQB formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x6F3B3B0", Offset = "0x6F39DB0", VA = "0x186F3B3B0", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, ICATWVBKUQB formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class IFYGNWHNZGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] WBHRPRWWYQM;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly VOGIGHBMNXK VVIUMQAXMHH;

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xA561290", Offset = "0xA55FC90", VA = "0x18A561290")]
		static IFYGNWHNZGI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class TEVIUZZRGFM
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] SOWDZCEGGER;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly VOGIGHBMNXK JAZLNRRHGFC;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xA56B670", Offset = "0xA56A070", VA = "0x18A56B670")]
		static TEVIUZZRGFM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class FFHGVRWWSAC
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] RONNFBURCTW;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly VOGIGHBMNXK IKUFWZETSVH;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] RPDHWWCJFBX;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly VOGIGHBMNXK IKELFEXBQNG;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] ROYAZPILVQO;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly VOGIGHBMNXK IKJSCLQYZYP;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] RNXSNHMZALV;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly VOGIGHBMNXK ILKAOTMLVDI;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] RNSLQATBRAM;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly VOGIGHBMNXK ILPHMAGJEOR;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] ROIGHVATTIN;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly VOGIGHBMNXK IKZMUFYRCGQ;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] ROCZKOGWJXE;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly VOGIGHBMNXK ILETRMSOLRZ;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] RNCQYGLJOSL;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly VOGIGHBMNXK IMFCDUOBGWS;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xA55B200", Offset = "0xA559C00", VA = "0x18A55B200")]
		static FFHGVRWWSAC()
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
