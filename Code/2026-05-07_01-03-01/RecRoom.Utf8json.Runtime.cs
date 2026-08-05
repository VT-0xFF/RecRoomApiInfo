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
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, FSNHROPLCPN resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, FSNHROPLCPN resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface DUMZRUHETBP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface TIJSSGKTKZA<a> : DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, FSNHROPLCPN formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LBAAVWLCNTR<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JMNZTZEYTGV(JsonWriter a, a b, FSNHROPLCPN c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b);
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
	public static class PTLQDOFYYLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3D802E0", Offset = "0x3D7ECE0", VA = "0x183D802E0")]
		public static string ToJsonString<T>(this TIJSSGKTKZA<T> formatter, T value, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		TIJSSGKTKZA<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class JVQQUXTKHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5920", Offset = "0x3BC4320", VA = "0x183BC5920")]
		public static TIJSSGKTKZA<a> QOHJAUYNKKH<a>(this FSNHROPLCPN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB570", Offset = "0xA3B9F70", VA = "0x18A3BB570")]
		public static object UYPXUSPBJVV(this FSNHROPLCPN a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA3B7D10", Offset = "0xA3B6710", VA = "0x18A3B7D10")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class BEADBIKACYB
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] JJKOSRKWQRC;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] XNFBBLUSAND;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] DZENJVWLXRU;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] PSPLKHJKPDD;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] YTYUNCCWRRC;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] LYEAHJTEAIH;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] JIFQMCCQDJV;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] XTMIJCKXYGK;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class OCGUJKQGLKC : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0xA3C7480", Offset = "0xA3C5E80", VA = "0x18A3C7480")]
				public OCGUJKQGLKC(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xA3C7360", Offset = "0xA3C5D60", VA = "0x18A3C7360")]
				public OCGUJKQGLKC HSHRCEPTJZO(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class NRVJTJCJOCZ
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] CUDBJAWILYC;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] ZOWRXUIHQUB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private OCGUJKQGLKC start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private OCGUJKQGLKC end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA3C8240", Offset = "0xA3C6C40", VA = "0x18A3C8240")]
			public void HSHRCEPTJZO([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA3C8100", Offset = "0xA3C6B00", VA = "0x18A3C8100")]
			public void HSHRCEPTJZO(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA3C8350", Offset = "0xA3C6D50", VA = "0x18A3C8350")]
			public ReadOnlySequence<byte> OLMVNCYNJKD()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA3C8670", Offset = "0xA3C7070", VA = "0x18A3C8670")]
			private void YYSMOLJRMIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA3C8480", Offset = "0xA3C6E80", VA = "0x18A3C8480")]
			private void QINFCFSHENT([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA3BF200", Offset = "0xA3BDC00", VA = "0x18A3BF200")]
		public JsonReader([In] ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA3BF090", Offset = "0xA3BDA90", VA = "0x18A3BF090")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA3BD1C0", Offset = "0xA3BBBC0", VA = "0x18A3BD1C0")]
		private JsonParsingException HLHHOROMZVD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA3BD510", Offset = "0xA3BBF10", VA = "0x18A3BD510")]
		private JsonParsingException HXIJANHAIRW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA3BDF30", Offset = "0xA3BC930", VA = "0x18A3BDF30")]
		public JsonToken NINAITQQYQA()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA3BD750", Offset = "0xA3BC150", VA = "0x18A3BD750")]
		public void JRJAPBNSHBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC0B0", Offset = "0xA3BAAB0", VA = "0x18A3BC0B0")]
		private bool BBPQOISWLQU(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC050", Offset = "0xA3BAA50", VA = "0x18A3BC050")]
		private bool BBPQOISWLQU(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC5F0", Offset = "0xA3BAFF0", VA = "0x18A3BC5F0")]
		private void CJLPSZMYGAN(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA3BD980", Offset = "0xA3BC380", VA = "0x18A3BD980")]
		public bool KKLKLRLWGGJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE9F0", Offset = "0xA3BD3F0", VA = "0x18A3BE9F0")]
		public void UCKHTGQUVNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA3BEEB0", Offset = "0xA3BD8B0", VA = "0x18A3BEEB0")]
		public bool YMIDNVOZERE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA3BEF10", Offset = "0xA3BD910", VA = "0x18A3BEF10")]
		public void ZITJAWLOSRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA3BD620", Offset = "0xA3BC020", VA = "0x18A3BD620")]
		public void IDIIQOMHLBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA3BDA40", Offset = "0xA3BC440", VA = "0x18A3BDA40")]
		public bool KMTQGEAVNZE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC950", Offset = "0xA3BB350", VA = "0x18A3BC950")]
		public void FFZFWSQGAVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA3BEF00", Offset = "0xA3BD900", VA = "0x18A3BEF00")]
		public void YOREZSZGZFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC960", Offset = "0xA3BB360", VA = "0x18A3BC960")]
		public bool FHLROLDDTGZ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE510", Offset = "0xA3BCF10", VA = "0x18A3BE510")]
		public bool OWREXCRAHDS(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE5F0", Offset = "0xA3BCFF0", VA = "0x18A3BE5F0")]
		public bool PEPQTDIXVGN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA3BEDD0", Offset = "0xA3BD7D0", VA = "0x18A3BEDD0")]
		public bool XPYQKTCXBDC(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA3BCCE0", Offset = "0xA3BB6E0", VA = "0x18A3BCCE0")]
		private ReadOnlySequence<byte> HCUWGPKVJYB()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA3BEAB0", Offset = "0xA3BD4B0", VA = "0x18A3BEAB0")]
		private ReadOnlySequence<byte> VJUNIBAQZKY()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA3BDA90", Offset = "0xA3BC490", VA = "0x18A3BDA90")]
		private void LYMREQZDALG(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA3BDD30", Offset = "0xA3BC730", VA = "0x18A3BDD30")]
		private void MPOHMSNHAED(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC9F0", Offset = "0xA3BB3F0", VA = "0x18A3BC9F0")]
		private void GIWPAQCWUVM(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE750", Offset = "0xA3BD150", VA = "0x18A3BE750")]
		private void RDXLMSCGFHH(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA3B5C70", Offset = "0xA3B4670", VA = "0x18A3B5C70")]
		private static int CNMSWXWSCMY(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE680", Offset = "0xA3BD080", VA = "0x18A3BE680")]
		public ReadOnlySequence<byte> PYUAYUOXAAU()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE140", Offset = "0xA3BCB40", VA = "0x18A3BE140")]
		public string NLHWEPYTRLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC860", Offset = "0xA3BB260", VA = "0x18A3BC860")]
		public string ECZRLSJXSGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE260", Offset = "0xA3BCC60", VA = "0x18A3BE260")]
		public ReadOnlySequence<byte> OLMLJVVDIDO()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE860", Offset = "0xA3BD260", VA = "0x18A3BE860")]
		public ReadOnlySequence<byte> SHBUZRTYEAL()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC6A0", Offset = "0xA3BB0A0", VA = "0x18A3BC6A0")]
		public bool CWXSSJUZOIU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA3BEF20", Offset = "0xA3BD920", VA = "0x18A3BEF20")]
		private void ZKTBUKDFQVY(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC8A0", Offset = "0xA3BB2A0", VA = "0x18A3BC8A0")]
		public void ELXFUEMKCGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC3B0", Offset = "0xA3BADB0", VA = "0x18A3BC3B0")]
		private void BTLVMDHLFMN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA3BEA00", Offset = "0xA3BD400", VA = "0x18A3BEA00")]
		public sbyte UKJUKOQRNZF()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA3BDC80", Offset = "0xA3BC680", VA = "0x18A3BDC80")]
		public short MOHCYIANYNQ()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA3BBFA0", Offset = "0xA3BA9A0", VA = "0x18A3BBFA0")]
		public int ANZJRQNOGLO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA3BD630", Offset = "0xA3BC030", VA = "0x18A3BD630")]
		public long IKMJNACMMHF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE940", Offset = "0xA3BD340", VA = "0x18A3BE940")]
		public byte TLNBTBVWCVY()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA3BED20", Offset = "0xA3BD720", VA = "0x18A3BED20")]
		public ushort WCXTYBUSHRB()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA3BD6A0", Offset = "0xA3BC0A0", VA = "0x18A3BD6A0")]
		public uint IXVSRVZDLGJ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC7F0", Offset = "0xA3BB1F0", VA = "0x18A3BC7F0")]
		public ulong EAFVIMLFZGC()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE1C0", Offset = "0xA3BCBC0", VA = "0x18A3BE1C0")]
		public float OBBNZURVPHK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC8B0", Offset = "0xA3BB2B0", VA = "0x18A3BC8B0")]
		public double FFMYMLIAOHX()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE330", Offset = "0xA3BCD30", VA = "0x18A3BE330")]
		public ReadOnlySequence<byte> OQCCZOFQMGW()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC110", Offset = "0xA3BAB10", VA = "0x18A3BC110")]
		private void BKASJHATVSM()
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
			[Cpp2IlInjected.Address(RVA = "0xF8F1C0", Offset = "0xF8DBC0", VA = "0x180F8F1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA3BBF40", Offset = "0xA3BA940", VA = "0x18A3BBF40")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA3BBEC0", Offset = "0xA3BA8C0", VA = "0x18A3BBEC0")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class KOUNRTVGDYG
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class YPEKJEQJLZP
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] CUDBJAWILYC;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA3CB0D0", Offset = "0xA3C9AD0", VA = "0x18A3CB0D0")]
			public static byte[] CYKYGZUZNIO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static FSNHROPLCPN ZYDTMNEAJFZ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] OMCXWVQWYZI;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] JIOWAOCCHNS;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static FSNHROPLCPN FSVEELUTAPB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA3C0780", Offset = "0xA3BF180", VA = "0x18A3C0780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C11E0", Offset = "0xA3BFBE0", VA = "0x18A3C11E0")]
		public static void PCBRQSPPRIL(FSNHROPLCPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE020", Offset = "0x3BFCA20", VA = "0x183BFE020")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE0A0", Offset = "0x3BFCAA0", VA = "0x183BFE0A0")]
		public static byte[] Serialize<T>(T value, FSNHROPLCPN resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE610", Offset = "0x3BFD010", VA = "0x183BFE610")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE690", Offset = "0x3BFD090", VA = "0x183BFE690")]
		public static string ToJsonString<T>(T value, FSNHROPLCPN resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3BFD780", Offset = "0x3BFC180", VA = "0x183BFD780")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDAA0", Offset = "0x3BFC4A0", VA = "0x183BFDAA0")]
		public static T Deserialize<T>(string json, FSNHROPLCPN resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDC20", Offset = "0x3BFC620", VA = "0x183BFDC20")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3BFD950", Offset = "0x3BFC350", VA = "0x183BFD950")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, FSNHROPLCPN resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3BFCFB0", Offset = "0x3BFB9B0", VA = "0x183BFCFB0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3BFD1D0", Offset = "0x3BFBBD0", VA = "0x183BFD1D0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, FSNHROPLCPN resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1250", Offset = "0xA3BFC50", VA = "0x18A3C1250")]
		public static byte[] YAMCBPMCIXW(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0880", Offset = "0xA3BF280", VA = "0x18A3C0880")]
		private static void FAXBDZSZSOU(JsonReader a, JsonWriter b, int c)
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
		public int RUXJAZGXNRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xF53740", Offset = "0xF52140", VA = "0x180F53740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA3BFE30", Offset = "0xA3BE830", VA = "0x18A3BFE30")]
		public void MRZDTJCLBZD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0230", Offset = "0xA3BEC30", VA = "0x18A3C0230")]
		public static byte[] SLCZBRUVAWI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA3BFD10", Offset = "0xA3BE710", VA = "0x18A3BFD10")]
		public static byte[] MJTSYBXTLQE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA3C04D0", Offset = "0xA3BEED0", VA = "0x18A3C04D0")]
		public static byte[] XOUELGBMHBQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA3BFE40", Offset = "0xA3BE840", VA = "0x18A3BFE40")]
		public static byte[] MZSUSKVNQCO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2AB6F10", Offset = "0x2AB5910", VA = "0x182AB6F10")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA3BFA20", Offset = "0xA3BE420", VA = "0x18A3BFA20")]
		public ArraySegment<byte> CYKYGZUZNIO()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA3C00A0", Offset = "0xA3BEAA0", VA = "0x18A3C00A0")]
		public byte[] QZZOGMXGEWR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0380", Offset = "0xA3BED80", VA = "0x18A3C0380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0450", Offset = "0xA3BEE50", VA = "0x18A3C0450")]
		public void WPSJPYLSEAG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA3B6000", Offset = "0xA3B4A00", VA = "0x18A3B6000")]
		public void IFJICBPWHOL(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA3BFC00", Offset = "0xA3BE600", VA = "0x18A3BFC00")]
		public void IFJICBPWHOL(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA3BFFF0", Offset = "0xA3BE9F0", VA = "0x18A3BFFF0")]
		public void NLEQBGDBIAJ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5470860", Offset = "0x546F260", VA = "0x185470860")]
		public void PALNSPMBHDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x54707C0", Offset = "0x546F1C0", VA = "0x1854707C0")]
		public void GSXOLZCLWSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7632C50", Offset = "0x7631650", VA = "0x187632C50")]
		public void RNDBWXFFTIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5096930", Offset = "0x5095330", VA = "0x185096930")]
		public void QHXSICVEUJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5470810", Offset = "0x546F210", VA = "0x185470810")]
		public void HKXOFEDORNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7632CA0", Offset = "0x76316A0", VA = "0x187632CA0")]
		public void XLAUEGTCFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0610", Offset = "0xA3BF010", VA = "0x18A3C0610")]
		public void ZTXATQTIMRH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA3BFB40", Offset = "0xA3BE540", VA = "0x18A3BFB40")]
		public void HLARBWFNEDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5096890", Offset = "0x5095290", VA = "0x185096890")]
		public void OCYAFJMXBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8C82EE0", Offset = "0x8C818E0", VA = "0x188C82EE0")]
		public void QWTSEXIQNEV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA3BFC90", Offset = "0xA3BE690", VA = "0x18A3BFC90")]
		public void IXDDQCXZTLJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA3BFAC0", Offset = "0xA3BE4C0", VA = "0x18A3BFAC0")]
		public void EJDLZOAETNA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0310", Offset = "0xA3BED10", VA = "0x18A3C0310")]
		public void TTVKZADJMAJ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0030", Offset = "0xA3BEA30", VA = "0x18A3C0030")]
		public void OSPQXHWCWMI(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA3BF430", Offset = "0xA3BDE30", VA = "0x18A3BF430")]
		public void ASXKDZJCOOK(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA3BFC60", Offset = "0xA3BE660", VA = "0x18A3BFC60")]
		public void IOPIKHWLIQR(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0460", Offset = "0xA3BEE60", VA = "0x18A3C0460")]
		public void XJOVWQNAYNY(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA3BFB90", Offset = "0xA3BE590", VA = "0x18A3BFB90")]
		public void HYNMISEMHQX(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA3C03E0", Offset = "0xA3BEDE0", VA = "0x18A3C03E0")]
		public void VBOAWWYVYSB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA3BFFC0", Offset = "0xA3BE9C0", VA = "0x18A3BFFC0")]
		public void NDKXXLGSVJQ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA3BF4A0", Offset = "0xA3BDEA0", VA = "0x18A3BF4A0")]
		public void BAGGSQHWUKC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA3BF3B0", Offset = "0xA3BDDB0", VA = "0x18A3BF3B0")]
		private static bool ABZFXQGABTK(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA3C05F0", Offset = "0xA3BEFF0", VA = "0x18A3C05F0")]
		private static byte ZPWJVJWNTWK(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA3B5F60", Offset = "0xA3B4960", VA = "0x18A3B5F60")]
		private static void DVCRTBWMTGX(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class UTGCZKGOKGM : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x50AA680", Offset = "0x50A9080", VA = "0x1850AA680")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private UTGCZKGOKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class ISWXCMNVVSF : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x50B8C90", Offset = "0x50B7690", VA = "0x1850B8C90")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class MLKTRWCYOMP
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> GSQEBHFSKGY;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA3C2CC0", Offset = "0xA3C16C0", VA = "0x18A3C2CC0")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private ISWXCMNVVSF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class JHQQOABRIGF : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x50BDBE0", Offset = "0x50BC5E0", VA = "0x1850BDBE0")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly JHQQOABRIGF IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool PROHEBXJNJT;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static DUMZRUHETBP[] YUZSUPCJNLZ;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static FSNHROPLCPN[] EJSWYEEFPLN;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private JHQQOABRIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB020", Offset = "0xA3B9A20", VA = "0x18A3BB020")]
		public static void QCIVJGOFOSZ(params FSNHROPLCPN[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB100", Offset = "0xA3B9B00", VA = "0x18A3BB100")]
		public static void QCIVJGOFOSZ(params DUMZRUHETBP[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB1E0", Offset = "0xA3B9BE0", VA = "0x18A3BB1E0")]
		public static void ZDJFRZKFUPB(DUMZRUHETBP[] a, FSNHROPLCPN[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class EDKCNZAQDUU : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x50BA190", Offset = "0x50B8B90", VA = "0x1850BA190")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private EDKCNZAQDUU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class IUXFSWELTAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly FSNHROPLCPN KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly FSNHROPLCPN VSQVMZXMBAY;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class LZBFBYNGFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly FSNHROPLCPN KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly FSNHROPLCPN IVULLMYZWYG;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly FSNHROPLCPN NPIRTZCBSEY;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly FSNHROPLCPN BATSVCTUWRN;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly FSNHROPLCPN TLCEUREUXIX;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly FSNHROPLCPN PWMQRDIJIMR;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly FSNHROPLCPN SFRKJJMBGFK;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly FSNHROPLCPN RISKYMHKEBE;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly FSNHROPLCPN LQOWSHFARAU;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly FSNHROPLCPN QCNKUONYFVR;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly FSNHROPLCPN MPIAMJLXJOD;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly FSNHROPLCPN ALTGLOQUGTD;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class NLXRZMLQPHU
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> GSQEBHFSKGY;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4D10", Offset = "0xA3C3710", VA = "0x18A3C4D10")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6960", Offset = "0xA3C5360", VA = "0x18A3C6960")]
		private static object QCLTRZWEPGT(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class AENVFJVLGEY : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x50A8340", Offset = "0x50A6D40", VA = "0x1850A8340")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private AENVFJVLGEY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class YFLEZXDYMFH : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x50A7480", Offset = "0x50A5E80", VA = "0x1850A7480")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private YFLEZXDYMFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class YJMQTKDUMGP
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly FSNHROPLCPN[] CVFHGPDVKAE;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class TUBRHDQOFUC : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x50A7A40", Offset = "0x50A6440", VA = "0x1850A7A40")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class ULFZXYQUZCO : FSNHROPLCPN
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class XZFBBAGBFUP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x50B4410", Offset = "0x50B2E10", VA = "0x1850B4410")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
			public TIJSSGKTKZA<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly TIJSSGKTKZA<object> BDYNDBSUITW;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private TUBRHDQOFUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class VBRQZUMDJUF : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x50B0690", Offset = "0x50AF090", VA = "0x1850B0690")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class ULFZXYQUZCO : FSNHROPLCPN
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class XZFBBAGBFUP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x50BB860", Offset = "0x50BA260", VA = "0x1850BB860")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
			public TIJSSGKTKZA<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly TIJSSGKTKZA<object> BDYNDBSUITW;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private VBRQZUMDJUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class WBQJVDNWGCH : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x50BD5A0", Offset = "0x50BBFA0", VA = "0x1850BD5A0")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class ULFZXYQUZCO : FSNHROPLCPN
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class XZFBBAGBFUP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x50C0F10", Offset = "0x50BF910", VA = "0x1850C0F10")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
			public TIJSSGKTKZA<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly TIJSSGKTKZA<object> BDYNDBSUITW;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private WBQJVDNWGCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class XYRNGBXCNOE : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x50BB9C0", Offset = "0x50BA3C0", VA = "0x1850BB9C0")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class ULFZXYQUZCO : FSNHROPLCPN
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class XZFBBAGBFUP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x50AF4E0", Offset = "0x50ADEE0", VA = "0x1850AF4E0")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
			public TIJSSGKTKZA<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly TIJSSGKTKZA<object> BDYNDBSUITW;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private XYRNGBXCNOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class NGWUNIVUUTS : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x50B4CD0", Offset = "0x50B36D0", VA = "0x1850B4CD0")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class ULFZXYQUZCO : FSNHROPLCPN
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class XZFBBAGBFUP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x50BA370", Offset = "0x50B8D70", VA = "0x1850BA370")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
			public TIJSSGKTKZA<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly TIJSSGKTKZA<object> BDYNDBSUITW;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private NGWUNIVUUTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class CJLFUXXSDSW : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x50B0C90", Offset = "0x50AF690", VA = "0x1850B0C90")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class ULFZXYQUZCO : FSNHROPLCPN
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class XZFBBAGBFUP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x50C6D30", Offset = "0x50C5730", VA = "0x1850C6D30")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
			public TIJSSGKTKZA<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly TIJSSGKTKZA<object> BDYNDBSUITW;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private CJLFUXXSDSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class SJUEERLJCQH : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x50C1070", Offset = "0x50BFA70", VA = "0x1850C1070")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class ULFZXYQUZCO : FSNHROPLCPN
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class XZFBBAGBFUP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x50B3A30", Offset = "0x50B2430", VA = "0x1850B3A30")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
			public TIJSSGKTKZA<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly TIJSSGKTKZA<object> BDYNDBSUITW;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private SJUEERLJCQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class NWPPBOCXVAF : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x50C1EF0", Offset = "0x50C08F0", VA = "0x1850C1EF0")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class ULFZXYQUZCO : FSNHROPLCPN
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class XZFBBAGBFUP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x50C3250", Offset = "0x50C1C50", VA = "0x1850C3250")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
			public TIJSSGKTKZA<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly TIJSSGKTKZA<object> BDYNDBSUITW;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private NWPPBOCXVAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class MDYWQLVGJKT : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x50AB930", Offset = "0x50AA330", VA = "0x1850AB930")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class ULFZXYQUZCO : FSNHROPLCPN
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class XZFBBAGBFUP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x50C4D60", Offset = "0x50C3760", VA = "0x1850C4D60")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
			public TIJSSGKTKZA<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly TIJSSGKTKZA<object> BDYNDBSUITW;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private MDYWQLVGJKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class WTXHQYOUEAM : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x50ABF70", Offset = "0x50AA970", VA = "0x1850ABF70")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class ULFZXYQUZCO : FSNHROPLCPN
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class XZFBBAGBFUP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x50AD070", Offset = "0x50ABA70", VA = "0x1850AD070")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
			public TIJSSGKTKZA<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly TIJSSGKTKZA<object> BDYNDBSUITW;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private WTXHQYOUEAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class KRURJNEUDDO : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x50A9320", Offset = "0x50A7D20", VA = "0x1850A9320")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class ULFZXYQUZCO : FSNHROPLCPN
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class XZFBBAGBFUP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x50C1D90", Offset = "0x50C0790", VA = "0x1850C1D90")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
			public TIJSSGKTKZA<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly TIJSSGKTKZA<object> BDYNDBSUITW;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private KRURJNEUDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class ZLQUPCXHWZU : FSNHROPLCPN
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class XZFBBAGBFUP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x50B00D0", Offset = "0x50AEAD0", VA = "0x1850B00D0")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class ULFZXYQUZCO : FSNHROPLCPN
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class XZFBBAGBFUP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly TIJSSGKTKZA<a> APAMJWNJDAO;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x50ACBD0", Offset = "0x50AB5D0", VA = "0x1850ACBD0")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
			public TIJSSGKTKZA<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly TIJSSGKTKZA<object> BDYNDBSUITW;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		private ZLQUPCXHWZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3362580", Offset = "0x3360F80", VA = "0x183362580", Slot = "4")]
		public TIJSSGKTKZA<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x73F9770", Offset = "0x73F8170", VA = "0x1873F9770")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x73F9480", Offset = "0x73F7E80", VA = "0x1873F9480")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x73F96E0", Offset = "0x73F80E0", VA = "0x1873F96E0")]
		public T[] QUXLCTIMAMW()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class UVEBVBACRPK<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int KYSCFWYLERY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object WWCPUNAIVDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int OYCHLVRRQHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] XZQMWUGRRFJ;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7DB90B0", Offset = "0x7DB7AB0", VA = "0x187DB90B0")]
		public UVEBVBACRPK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7DB8B80", Offset = "0x7DB7580", VA = "0x187DB8B80")]
		public a[] XZUYFBJJCDR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7DB8A00", Offset = "0x7DB7400", VA = "0x187DB8A00")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class IYMRTTJUVFY : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class XXSOLSHZRNI : IComparable<XXSOLSHZRNI>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class ZKOMXEXJWBY : IEnumerable<XXSOLSHZRNI>, IEnumerable, IEnumerator<XXSOLSHZRNI>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int KPYKIUTJAWU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private XXSOLSHZRNI AGGTFEUSTML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int TCMGCAWGCHD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public XXSOLSHZRNI AFKVCRAYCVS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int OTWUEUFXKSW;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private XXSOLSHZRNI YSJFTFTSDOX
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object KXFWSOWDLDQ
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x1007340", Offset = "0x1005D40", VA = "0x181007340")]
				[DebuggerHidden]
				public ZKOMXEXJWBY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "7")]
				[DebuggerHidden]
				private void EAMCGMHRBWN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xA3CB210", Offset = "0xA3C9C10", VA = "0x18A3CB210", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xA3CB290", Offset = "0xA3C9C90", VA = "0x18A3CB290", Slot = "10")]
				[DebuggerHidden]
				private void VVBIBJOVTIU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xA3CB170", Offset = "0xA3C9B70", VA = "0x18A3CB170", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<XXSOLSHZRNI> GIKAWABIAOA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0xA3CB170", Offset = "0xA3C9B70", VA = "0x18A3CB170", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator DKFMUHWUXGJ()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly XXSOLSHZRNI[] UKNFWCUZSPE;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] BAKZQCEUDIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong AZSKTLMZSBZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int YSLRVNQQVPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string BEPGUZALRIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private XXSOLSHZRNI[] NHEGQWKQJMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] YZJAHNDLGGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int AOLTEBSKBQH;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA3CAC80", Offset = "0xA3C9680", VA = "0x18A3CAC80")]
			public XXSOLSHZRNI(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA3CA720", Offset = "0xA3C9120", VA = "0x18A3CA720")]
			public XXSOLSHZRNI Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA3CA6C0", Offset = "0xA3C90C0", VA = "0x18A3CA6C0")]
			public XXSOLSHZRNI Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA3CA920", Offset = "0xA3C9320", VA = "0x18A3CA920")]
			public XXSOLSHZRNI CMYKQFYGUMU(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA3CAAC0", Offset = "0xA3C94C0", VA = "0x18A3CAAC0")]
			internal static int DILLCZEIOVT(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA3CAA90", Offset = "0xA3C9490", VA = "0x18A3CAA90", Slot = "4")]
			public int CompareTo(XXSOLSHZRNI other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xA3CAB50", Offset = "0xA3C9550", VA = "0x18A3CAB50")]
			[IteratorStateMachine(typeof(ZKOMXEXJWBY))]
			public IEnumerable<XXSOLSHZRNI> STXFKUDNUWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class GVTGOFRMGNC : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<XXSOLSHZRNI> NHEGQWKQJMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<XXSOLSHZRNI> ZCSUUAOWIJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<XXSOLSHZRNI> ONPYAFUWWYM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private XXSOLSHZRNI OKKWJOWOFAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> OOALUTIRPVE;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> EEESIGTXDSV
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0xD6A2B0", Offset = "0xD68CB0", VA = "0x180D6A2B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000139")]
				[Cpp2IlInjected.Address(RVA = "0xA3B83C0", Offset = "0xA3B6DC0", VA = "0x18A3B83C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1D13410", Offset = "0x1D11E10", VA = "0x181D13410")]
			[DebuggerHidden]
			public GVTGOFRMGNC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xA3B7E10", Offset = "0xA3B6810", VA = "0x18A3B7E10", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xA3B7F60", Offset = "0xA3B6960", VA = "0x18A3B7F60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xA3B8460", Offset = "0xA3B6E60", VA = "0x18A3B8460")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA3B8410", Offset = "0xA3B6E10", VA = "0x18A3B8410")]
			private void SMGDSKUDEQA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA3B84B0", Offset = "0xA3B6EB0", VA = "0x18A3B84B0", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xA3B7D70", Offset = "0xA3B6770", VA = "0x18A3B7D70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> ESKQBWROPFQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xA3B7D70", Offset = "0xA3B6770", VA = "0x18A3B7D70", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly XXSOLSHZRNI XBKNLMWAWOQ;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA3BAFB0", Offset = "0xA3B99B0", VA = "0x18A3BAFB0")]
		public IYMRTTJUVFY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA3BA760", Offset = "0xA3B9160", VA = "0x18A3BA760")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA3BAD00", Offset = "0xA3B9700", VA = "0x18A3BAD00")]
		public bool IAMPTCAGJIA(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA3BAE10", Offset = "0xA3B9810", VA = "0x18A3BAE10")]
		public bool MMPFYCSKCAZ([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA3BAF20", Offset = "0xA3B9920", VA = "0x18A3BAF20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA3BA940", Offset = "0xA3B9340", VA = "0x18A3BA940")]
		private static void BPQDDIHAUHZ(IEnumerable<XXSOLSHZRNI> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA3BACA0", Offset = "0xA3B96A0", VA = "0x18A3BACA0", Slot = "5")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA3BACA0", Offset = "0xA3B96A0", VA = "0x18A3BACA0", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA3BAC20", Offset = "0xA3B9620", VA = "0x18A3BAC20")]
		[IteratorStateMachine(typeof(GVTGOFRMGNC))]
		private static IEnumerable<KeyValuePair<string, int>> BZYNHWUGMDQ(IEnumerable<XXSOLSHZRNI> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class JZXAKVSIITD
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo RAVOCTYYDJA;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB6C0", Offset = "0xA3BA0C0", VA = "0x18A3BB6C0")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA3BB870", Offset = "0xA3BA270", VA = "0x18A3BB870")]
		public static ulong OJITFABCFAG(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class GZQFSCIPSMV
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8750", Offset = "0xA3B7150", VA = "0x18A3B8750")]
		public static void WPSJPYLSEAG(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8630", Offset = "0xA3B7030", VA = "0x18A3B8630")]
		public static void LGDRHUIEQCS(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA3B84F0", Offset = "0xA3B6EF0", VA = "0x18A3B84F0")]
		public static byte[] JHNDDQFHSVV(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class QEGFMNKZJQR<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x5C0AAB0", Offset = "0x5C094B0", VA = "0x185C0AAB0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class NCLAYAIREWF : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public QEGFMNKZJQR<a> AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] ONPYAFUWWYM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int OOFSSACOZGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] OOALUTIRPVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int ONADILNEUQL;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> HGAKVPYHZDG
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xD6A2B0", Offset = "0xD68CB0", VA = "0x180D6A2B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0x650EAA0", Offset = "0x650D4A0", VA = "0x18650EAA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
			[DebuggerHidden]
			public NCLAYAIREWF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x71A20F0", Offset = "0x71A0AF0", VA = "0x1871A20F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4EAEBC0", Offset = "0x4EAD5C0", VA = "0x184EAEBC0", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] NCUUZLHWXMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong TQCLLHUTTSX;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool IBIXAWSVMSM;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x76327B0", Offset = "0x76311B0", VA = "0x1876327B0")]
		public QEGFMNKZJQR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x76328A0", Offset = "0x76312A0", VA = "0x1876328A0")]
		public QEGFMNKZJQR(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x76227B0", Offset = "0x76211B0", VA = "0x1876227B0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x762A8A0", Offset = "0x76292A0", VA = "0x18762A8A0")]
		private bool NTERVCVLIGR(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7625870", Offset = "0x7624270", VA = "0x187625870")]
		public bool IAMPTCAGJIA([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x762F3B0", Offset = "0x762DDB0", VA = "0x18762F3B0")]
		private static ulong VWRTRYUQEUU([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x762FB30", Offset = "0x762E530", VA = "0x18762FB30")]
		private static ulong VWRTRYUQEUU([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x76234B0", Offset = "0x7621EB0", VA = "0x1876234B0")]
		private static int EFEFYFKCMQM(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x76234E0", Offset = "0x7621EE0", VA = "0x1876234E0", Slot = "4")]
		[IteratorStateMachine(typeof(QEGFMNKZJQR<>.NCLAYAIREWF))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7623300", Offset = "0x7621D00", VA = "0x187623300", Slot = "5")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class OHFWEKRMFHW
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3D522B0", Offset = "0x3D50CB0", VA = "0x183D522B0")]
		public static Func<a> THHRIBJNSYC<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3D523A0", Offset = "0x3D50DA0", VA = "0x183D523A0")]
		private static c TXLMQQGJAMH<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0xA3B9280", Offset = "0xA3B7C80", VA = "0x18A3B9280")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA3B9290", Offset = "0xA3B7C90", VA = "0x18A3B9290")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA3B90F0", Offset = "0xA3B7AF0", VA = "0x18A3B90F0")]
		private static byte KCLNZMAQWZB(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA3B5B60", Offset = "0xA3B4560", VA = "0x18A3B5B60")]
		private static byte QXCSQGDUEXJ(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8890", Offset = "0xA3B7290", VA = "0x18A3B8890")]
		public void HHMSAAQYDCT(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class WEIIJSEBQLZ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C9800", Offset = "0xA3C8200", VA = "0x18A3C9800")]
		public static bool AUWWKAOYQXH(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C9730", Offset = "0xA3C8130", VA = "0x18A3C9730")]
		public static bool AAVKJIDDMIA(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA560", Offset = "0xA3C8F60", VA = "0x18A3CA560")]
		public static sbyte UKJUKOQRNZF([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA140", Offset = "0xA3C8B40", VA = "0x18A3CA140")]
		public static short MOHCYIANYNQ([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA3C97A0", Offset = "0xA3C81A0", VA = "0x18A3C97A0")]
		public static int ANZJRQNOGLO([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA3C9EE0", Offset = "0xA3C88E0", VA = "0x18A3C9EE0")]
		public static long IKMJNACMMHF([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA3C99E0", Offset = "0xA3C83E0", VA = "0x18A3C99E0")]
		public static bool DSLHQQXHQYE(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA500", Offset = "0xA3C8F00", VA = "0x18A3CA500")]
		public static byte TLNBTBVWCVY([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA5C0", Offset = "0xA3C8FC0", VA = "0x18A3CA5C0")]
		public static ushort WCXTYBUSHRB([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA0E0", Offset = "0xA3C8AE0", VA = "0x18A3CA0E0")]
		public static uint IXVSRVZDLGJ([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA3C9B70", Offset = "0xA3C8570", VA = "0x18A3C9B70")]
		public static ulong EAFVIMLFZGC([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA3C9F90", Offset = "0xA3C8990", VA = "0x18A3C9F90")]
		public static bool ISSRTKZBYAD(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA330", Offset = "0xA3C8D30", VA = "0x18A3CA330")]
		public static bool SMBDGBWFYHN(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA3C9DD0", Offset = "0xA3C87D0", VA = "0x18A3C9DD0")]
		public static bool IATXRDGCNXF(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA290", Offset = "0xA3C8C90", VA = "0x18A3CA290")]
		public static bool OEATHFQJJDX(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA1A0", Offset = "0xA3C8BA0", VA = "0x18A3CA1A0")]
		public static float OBBNZURVPHK([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C9C20", Offset = "0xA3C8620", VA = "0x18A3C9C20")]
		public static bool EBIAXXAFVOZ(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C9CE0", Offset = "0xA3C86E0", VA = "0x18A3C9CE0")]
		public static double FFMYMLIAOHX([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C9C80", Offset = "0xA3C8680", VA = "0x18A3C9C80")]
		public static bool ESMIPZDJXTO(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA3B6620", Offset = "0xA3B5020", VA = "0x18A3B6620")]
		public static int IOPIKHWLIQR(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA3B6E20", Offset = "0xA3B5820", VA = "0x18A3B6E20")]
		public static int NDKXXLGSVJQ(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA3C9810", Offset = "0xA3C8210", VA = "0x18A3C9810")]
		public static bool CWXSSJUZOIU([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class KWZMFNDNBDV
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA3C26E0", Offset = "0xA3C10E0", VA = "0x18A3C26E0")]
		public static bool WWRDUBECBAF(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class AGPTJWSTBZK
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding WVXZWWXNDOT;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class KVWTPRJJKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1F20", Offset = "0xA3C0920", VA = "0x18A3C1F20")]
		public static void FIEREXPMNZX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1EB0", Offset = "0xA3C08B0", VA = "0x18A3C1EB0")]
		public static void FHZKHQVPEOO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1E40", Offset = "0xA3C0840", VA = "0x18A3C1E40")]
		public static void FHUDKKBRVDF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1DD0", Offset = "0xA3C07D0", VA = "0x18A3C1DD0")]
		public static void FHOWNDHULRW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2000", Offset = "0xA3C0A00", VA = "0x18A3C2000")]
		public static void FIZSTYRBZTH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1F90", Offset = "0xA3C0990", VA = "0x18A3C1F90")]
		public static void FIULWRXEQHY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1AA0", Offset = "0xA3C04A0", VA = "0x18A3C1AA0")]
		public static void ECSFCOQUINQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1B10", Offset = "0xA3C0510", VA = "0x18A3C1B10")]
		public static void ECXLZVKRRYZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C19B0", Offset = "0xA3C03B0", VA = "0x18A3C19B0")]
		public static void ECHRIBCZPQY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1A20", Offset = "0xA3C0420", VA = "0x18A3C1A20")]
		public static void ECMYFHWWZCH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C18B0", Offset = "0xA3C02B0", VA = "0x18A3C18B0")]
		public static void EBXDNNPEWUG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1930", Offset = "0xA3C0330", VA = "0x18A3C1930")]
		public static void ECCKKUJCGFP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA3C17B0", Offset = "0xA3C01B0", VA = "0x18A3C17B0")]
		public static void EBMPTABKDXO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1830", Offset = "0xA3C0230", VA = "0x18A3C1830")]
		public static void EBRWQGVHNIX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1B80", Offset = "0xA3C0580", VA = "0x18A3C1B80")]
		public static void EEIIGQTZGAK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1C00", Offset = "0xA3C0600", VA = "0x18A3C1C00")]
		public static void EENPDXNWPLT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2310", Offset = "0xA3C0D10", VA = "0x18A3C2310")]
		public static void XCBADWIRSVH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2290", Offset = "0xA3C0C90", VA = "0x18A3C2290")]
		public static void XBVTGPOUJJY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2210", Offset = "0xA3C0C10", VA = "0x18A3C2210")]
		public static void XBQMJIUWZYP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2190", Offset = "0xA3C0B90", VA = "0x18A3C2190")]
		public static void XBLFMCAZQNG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2540", Offset = "0xA3C0F40", VA = "0x18A3C2540")]
		public static void XCWBSXKHEOR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA3C24B0", Offset = "0xA3C0EB0", VA = "0x18A3C24B0")]
		public static void XCQUVQQJVDI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2420", Offset = "0xA3C0E20", VA = "0x18A3C2420")]
		public static void XCLNYJWMLRZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2390", Offset = "0xA3C0D90", VA = "0x18A3C2390")]
		public static void XCGHBDCPCGQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2650", Offset = "0xA3C1050", VA = "0x18A3C2650")]
		public static void XDRDHYLWQIB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C25C0", Offset = "0xA3C0FC0", VA = "0x18A3C25C0")]
		public static void XDLWKRRZGWS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2070", Offset = "0xA3C0A70", VA = "0x18A3C2070")]
		public static void RBHTSLZPOZG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2100", Offset = "0xA3C0B00", VA = "0x18A3C2100")]
		public static void RBNAPSTMYKP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1D60", Offset = "0xA3C0760", VA = "0x18A3C1D60")]
		public static void FHEISPTZSVE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1CF0", Offset = "0xA3C06F0", VA = "0x18A3C1CF0")]
		public static void FGZBVJACJJV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1C80", Offset = "0xA3C0680", VA = "0x18A3C1C80")]
		public static void FGTUYCGEZYM(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class QVASQKZMFJR
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA3C79F0", Offset = "0xA3C63F0", VA = "0x18A3C79F0")]
		public static void FIZSTYRBZTH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7980", Offset = "0xA3C6380", VA = "0x18A3C7980")]
		public static void FIULWRXEQHY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA3C77A0", Offset = "0xA3C61A0", VA = "0x18A3C77A0")]
		public static void ECSFCOQUINQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7810", Offset = "0xA3C6210", VA = "0x18A3C7810")]
		public static void ECXLZVKRRYZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA3C76C0", Offset = "0xA3C60C0", VA = "0x18A3C76C0")]
		public static void ECHRIBCZPQY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7730", Offset = "0xA3C6130", VA = "0x18A3C7730")]
		public static void ECMYFHWWZCH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA3C75E0", Offset = "0xA3C5FE0", VA = "0x18A3C75E0")]
		public static void EBXDNNPEWUG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7650", Offset = "0xA3C6050", VA = "0x18A3C7650")]
		public static void ECCKKUJCGFP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C74F0", Offset = "0xA3C5EF0", VA = "0x18A3C74F0")]
		public static void EBMPTABKDXO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7560", Offset = "0xA3C5F60", VA = "0x18A3C7560")]
		public static void EBRWQGVHNIX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7880", Offset = "0xA3C6280", VA = "0x18A3C7880")]
		public static void EEIIGQTZGAK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7900", Offset = "0xA3C6300", VA = "0x18A3C7900")]
		public static void EENPDXNWPLT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7CE0", Offset = "0xA3C66E0", VA = "0x18A3C7CE0")]
		public static void XCBADWIRSVH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7C60", Offset = "0xA3C6660", VA = "0x18A3C7C60")]
		public static void XBVTGPOUJJY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7BE0", Offset = "0xA3C65E0", VA = "0x18A3C7BE0")]
		public static void XBQMJIUWZYP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7B60", Offset = "0xA3C6560", VA = "0x18A3C7B60")]
		public static void XBLFMCAZQNG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7EE0", Offset = "0xA3C68E0", VA = "0x18A3C7EE0")]
		public static void XCWBSXKHEOR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7E60", Offset = "0xA3C6860", VA = "0x18A3C7E60")]
		public static void XCQUVQQJVDI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7DE0", Offset = "0xA3C67E0", VA = "0x18A3C7DE0")]
		public static void XCLNYJWMLRZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7D60", Offset = "0xA3C6760", VA = "0x18A3C7D60")]
		public static void XCGHBDCPCGQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7FE0", Offset = "0xA3C69E0", VA = "0x18A3C7FE0")]
		public static void XDRDHYLWQIB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7F60", Offset = "0xA3C6960", VA = "0x18A3C7F60")]
		public static void XDLWKRRZGWS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7A60", Offset = "0xA3C6460", VA = "0x18A3C7A60")]
		public static void RBHTSLZPOZG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA3C7AE0", Offset = "0xA3C64E0", VA = "0x18A3C7AE0")]
		public static void RBNAPSTMYKP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1D60", Offset = "0xA3C0760", VA = "0x18A3C1D60")]
		public static void FHEISPTZSVE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1CF0", Offset = "0xA3C06F0", VA = "0x18A3C1CF0")]
		public static void FGZBVJACJJV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1C80", Offset = "0xA3C0680", VA = "0x18A3C1C80")]
		public static void FGTUYCGEZYM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1F20", Offset = "0xA3C0920", VA = "0x18A3C1F20")]
		public static void FIEREXPMNZX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1EB0", Offset = "0xA3C08B0", VA = "0x18A3C1EB0")]
		public static void FHZKHQVPEOO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1E40", Offset = "0xA3C0840", VA = "0x18A3C1E40")]
		public static void FHUDKKBRVDF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1DD0", Offset = "0xA3C07D0", VA = "0x18A3C1DD0")]
		public static void FHOWNDHULRW(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class TMLQDXQITFP
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool IBIXAWSVMSM;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC280", Offset = "0xA3DAC80", VA = "0x18A3DC280")]
		public static void IFJICBPWHOL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC1F0", Offset = "0xA3DABF0", VA = "0x18A3DC1F0")]
		public static void ABUEBDATWMO(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x2B651F0", Offset = "0x2B63BF0", VA = "0x182B651F0")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDE90", Offset = "0xA3CC890", VA = "0x18A3CDE90")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDDF0", Offset = "0xA3CC7F0", VA = "0x18A3CDDF0")]
		public static DiyFp MZFYADVTRLC(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDE00", Offset = "0xA3CC800", VA = "0x18A3CDE00")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDF30", Offset = "0xA3CC930", VA = "0x18A3CDF30")]
		public static DiyFp ZZVASTYZAUS(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDEF0", Offset = "0xA3CC8F0", VA = "0x18A3CDEF0")]
		public void XMFVZFUJJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDEA0", Offset = "0xA3CC8A0", VA = "0x18A3CDEA0")]
		public static DiyFp XMFVZFUJJHN(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xD8A3D0", Offset = "0xD88DD0", VA = "0x180D8A3D0")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA3B6000", Offset = "0xA3B4A00", VA = "0x18A3B6000")]
		public void FMYQPDLKDMC(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAB20", Offset = "0xA3D9520", VA = "0x18A3DAB20")]
		public void MKILRABTAHM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA3DACC0", Offset = "0xA3D96C0", VA = "0x18A3DACC0")]
		public void YUKIWVODLGW(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAC20", Offset = "0xA3D9620", VA = "0x18A3DAC20")]
		public void YUKIWVODLGW(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA3DABA0", Offset = "0xA3D95A0", VA = "0x18A3DABA0")]
		public void QVSDQSYPCGA(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAA20", Offset = "0xA3D9420", VA = "0x18A3DAA20")]
		public void KAUGSFGFQAT(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class WTZNSYSNALN
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
		private static byte[] GMBMLJDAMXK;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] WNMEANWHDPO;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] ZSHWYRYQJWK;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] FAUBKQNDYJV;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags QDWYKDFYBSQ;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char CIKMUGHIPQY;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int SCRGDZLTXCM;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int YUSYLJLKIKM;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] ILYDJJEPSCO;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0A00", Offset = "0xA3DF400", VA = "0x18A3E0A00")]
		private static byte[] MTATZZZCYYE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA3E21B0", Offset = "0xA3E0BB0", VA = "0x18A3E21B0")]
		private static byte[] XDCWQTFDDLC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA3E05F0", Offset = "0xA3DEFF0", VA = "0x18A3E05F0")]
		public static int GMMDUBYWKNB(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0710", Offset = "0xA3DF110", VA = "0x18A3E0710")]
		public static int GMMDUBYWKNB(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0400", Offset = "0xA3DEE00", VA = "0x18A3E0400")]
		private static bool CXXOZHWPTNP(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2290", Offset = "0xA3E0C90", VA = "0x18A3E2290")]
		private static void XGQTJOOQWMZ(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0AD0", Offset = "0xA3DF4D0", VA = "0x18A3E0AD0")]
		private static bool NRLIIUVQUFX(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1660", Offset = "0xA3E0060", VA = "0x18A3E1660")]
		private static bool QDGUISUCKAF(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA3E04F0", Offset = "0xA3DEEF0", VA = "0x18A3E04F0")]
		private static bool FDELBKHRRHA(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0830", Offset = "0xA3DF230", VA = "0x18A3E0830")]
		private static bool LBTZNWCEALJ(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1AE0", Offset = "0xA3E04E0", VA = "0x18A3E1AE0")]
		private static bool RKJWFNAWIPI(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA3E12C0", Offset = "0xA3DFCC0", VA = "0x18A3E12C0")]
		private static void OPQPHFQMNJM(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0E90", Offset = "0xA3DF890", VA = "0x18A3E0E90")]
		private static void OLCPKTASKJI(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1FC0", Offset = "0xA3E09C0", VA = "0x18A3E1FC0")]
		private static bool UWLXKRQYNHJ(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0xA3CE5F0", Offset = "0xA3CCFF0", VA = "0x18A3CE5F0")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE550", Offset = "0xA3CCF50", VA = "0x18A3CE550")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE400", Offset = "0xA3CCE00", VA = "0x18A3CE400")]
		public DiyFp WJEVNSZTNFC()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE2D0", Offset = "0xA3CCCD0", VA = "0x18A3CE2D0")]
		public DiyFp REYEBRQGGEP()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xEBA990", Offset = "0xEB9390", VA = "0x180EBA990")]
		public ulong STLDGSSFZOW()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE160", Offset = "0xA3CCB60", VA = "0x18A3CE160")]
		public double FXCAEOFTGOU()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE4B0", Offset = "0xA3CCEB0", VA = "0x18A3CE4B0")]
		public double YROHQYZTOSA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE380", Offset = "0xA3CCD80", VA = "0x18A3CE380")]
		public int TFCCLGZEQXV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE130", Offset = "0xA3CCB30", VA = "0x18A3CE130")]
		public ulong EHVJAYNUGPN()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE470", Offset = "0xA3CCE70", VA = "0x18A3CE470")]
		public bool XYQDNKMNWRW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDFD0", Offset = "0xA3CC9D0", VA = "0x18A3CDFD0")]
		public bool BTXWEPGAEHJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE290", Offset = "0xA3CCC90", VA = "0x18A3CE290")]
		public bool OUGXDPTEOEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE350", Offset = "0xA3CCD50", VA = "0x18A3CE350")]
		public bool SGBMKSIZUOQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE490", Offset = "0xA3CCE90", VA = "0x18A3CE490")]
		public int YEXRFOBGNOF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDFF0", Offset = "0xA3CC9F0", VA = "0x18A3CDFF0")]
		public void DSZWKBHYRDB([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE3B0", Offset = "0xA3CCDB0", VA = "0x18A3CE3B0")]
		public bool VJTOATMSSGZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4087D60", Offset = "0x4086760", VA = "0x184087D60")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE270", Offset = "0xA3CCC70", VA = "0x18A3CE270")]
		public static int OPUVWTCHXNC(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE2C0", Offset = "0xA3CCCC0", VA = "0x18A3CE2C0")]
		public static double QCJPIKBMIFG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE1E0", Offset = "0xA3CCBE0", VA = "0x18A3CE1E0")]
		public static ulong GJZWMWRVBUL(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x1850E70", Offset = "0x184F870", VA = "0x181850E70")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA9B0", Offset = "0xA3D93B0", VA = "0x18A3DA9B0")]
		public DiyFp WJEVNSZTNFC()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xF535F0", Offset = "0xF51FF0", VA = "0x180F535F0")]
		public uint AROGGEKJCXH()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA950", Offset = "0xA3D9350", VA = "0x18A3DA950")]
		public int TFCCLGZEQXV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA930", Offset = "0xA3D9330", VA = "0x18A3DA930")]
		public uint EHVJAYNUGPN()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAA10", Offset = "0xA3D9410", VA = "0x18A3DAA10")]
		public bool XYQDNKMNWRW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA800", Offset = "0xA3D9200", VA = "0x18A3DA800")]
		public void DSZWKBHYRDB([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA970", Offset = "0xA3D9370", VA = "0x18A3DA970")]
		public bool VJTOATMSSGZ()
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
		[Cpp2IlInjected.Address(RVA = "0xA3CD950", Offset = "0xA3CC350", VA = "0x18A3CD950")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class TGCGGSNNRQE
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] ITCQQWVELZH;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAE10", Offset = "0xA3D9810", VA = "0x18A3DAE10")]
		public static void RDGYUTDXEAR(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAD40", Offset = "0xA3D9740", VA = "0x18A3DAD40")]
		public static void JBMPOVMMPDU(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0xA3E00B0", Offset = "0xA3DEAB0", VA = "0x18A3E00B0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0010", Offset = "0x4E9EA10", VA = "0x184EA0010")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D9B6E0", Offset = "0x2D9A0E0", VA = "0x182D9B6E0")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0050", Offset = "0xA3DEA50", VA = "0x18A3E0050")]
		public Vector HFGXGVNTUSB(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class CACXYXUGXAN
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] DKFBQKBZLDN;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] CNVBYHXEGRI;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int ECVDWDDNLNN;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC1B0", Offset = "0xA3CABB0", VA = "0x18A3CC1B0")]
		private static byte[] FRRRPHKWFTB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA3CBFF0", Offset = "0xA3CA9F0", VA = "0x18A3CBFF0")]
		private static Vector ETEMOTJKTSR(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC0D0", Offset = "0xA3CAAD0", VA = "0x18A3CC0D0")]
		private static Vector EWOMPLRZRRB(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCA50", Offset = "0xA3CB450", VA = "0x18A3CCA50")]
		private static void PCDFSAJNIRM(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD5A0", Offset = "0xA3CBFA0", VA = "0x18A3CD5A0")]
		private static void ZSCSVNHQUDR(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD510", Offset = "0xA3CBF10", VA = "0x18A3CD510")]
		private static ulong XLMPKCQWXMW(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC910", Offset = "0xA3CB310", VA = "0x18A3CC910")]
		private static void NKDDZFLLJZW(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC420", Offset = "0xA3CAE20", VA = "0x18A3CC420")]
		private static bool KYLPPURVWPV(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC290", Offset = "0xA3CAC90", VA = "0x18A3CC290")]
		private static DiyFp GSGGKBOGLDW(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCED0", Offset = "0xA3CB8D0", VA = "0x18A3CCED0")]
		private static bool TKMTRHPOAJA(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC7F0", Offset = "0xA3CB1F0", VA = "0x18A3CC7F0")]
		private static bool LDIGLLXAEPE(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCDB0", Offset = "0xA3CB7B0", VA = "0x18A3CCDB0")]
		public static double? RPFOAZTPDJQ(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCAE0", Offset = "0xA3CB4E0", VA = "0x18A3CCAE0")]
		public static float? ROVAGMFUKMY(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class QLEEBZABKFZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] JVRZYBUHWQD;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] ZSHWYRYQJWK;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] FAUBKQNDYJV;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] BNBWSEWNYUB;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int VNQNTRQZOWN;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] GLMIFQLJREP;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int EKQAQJBLXAX;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6790", Offset = "0xA3D5190", VA = "0x18A3D6790")]
		private static byte[] CYKYGZUZNIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA3D68E0", Offset = "0xA3D52E0", VA = "0x18A3D68E0")]
		public static bool EBIAXXAFVOZ(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6A20", Offset = "0xA3D5420", VA = "0x18A3D6A20")]
		public static bool ESMIPZDJXTO(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7F20", Offset = "0xA3D6920", VA = "0x18A3D7F20")]
		private static bool YVTSRTSVTRL(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6C60", Offset = "0xA3D5660", VA = "0x18A3D6C60")]
		private static bool UYCXLXHBXAI(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6B60", Offset = "0xA3D5560", VA = "0x18A3D6B60")]
		private static bool EYPZEFWSWHD(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6870", Offset = "0xA3D5270", VA = "0x18A3D6870")]
		private static bool DAVPAUNCYEH(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6C40", Offset = "0xA3D5640", VA = "0x18A3D6C40")]
		private static double FOFFAKWFZIS(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6F30", Offset = "0xA3D5930", VA = "0x18A3D6F30")]
		private static double XZLKGFLGEEM(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class FWYZWVLLKFE<a> : TIJSSGKTKZA<a[]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly UVEBVBACRPK<a> MTYGCDUGHTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour QHDWRFSBILP;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1940990", Offset = "0x193F390", VA = "0x181940990")]
		public FWYZWVLLKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
		public FWYZWVLLKFE(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6360920", Offset = "0x635F320", VA = "0x186360920", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6360200", Offset = "0x635EC00", VA = "0x186360200", Slot = "5")]
		public a[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class MMYJGQWNCTJ<a> : TIJSSGKTKZA<ArraySegment<a>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly UVEBVBACRPK<a> MTYGCDUGHTV;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6F79E70", Offset = "0x6F78870", VA = "0x186F79E70", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6F79A20", Offset = "0x6F78420", VA = "0x186F79A20", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class MNYDQEFCKDH<a> : TIJSSGKTKZA<List<a>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour QHDWRFSBILP;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1940990", Offset = "0x193F390", VA = "0x181940990")]
		public MNYDQEFCKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
		public MNYDQEFCKDH(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6F8C090", Offset = "0x6F8AA90", VA = "0x186F8C090", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6F881B0", Offset = "0x6F86BB0", VA = "0x186F881B0", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class EARDSEGKBIT<a, b, c, d> : TIJSSGKTKZA<d>, DUMZRUHETBP where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x5BDCA10", Offset = "0x5BDB410", VA = "0x185BDCA10", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x5BDB3D0", Offset = "0x5BD9DD0", VA = "0x185BDB3D0", Slot = "5")]
		public d Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c JIYABPAHYXR(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		protected EARDSEGKBIT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class EABJAJYRZAS<a, b, c> : EARDSEGKBIT<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5BDB380", Offset = "0x5BD9D80", VA = "0x185BDB380", Slot = "6")]
		protected override IEnumerator<a> JIYABPAHYXR(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		protected EABJAJYRZAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class EAGPXQSPIMB<a, b> : EABJAJYRZAS<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD36260", Offset = "0xD34C60", VA = "0x180D36260", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class AAFWAGEPUZN<a, b> : EAGPXQSPIMB<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7215720", Offset = "0x7214120", VA = "0x187215720", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x72155C0", Offset = "0x7213FC0", VA = "0x1872155C0", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class YYUDKLSTCRU<a> : EARDSEGKBIT<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x516D1E0", Offset = "0x516BBE0", VA = "0x18516D1E0", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD36260", Offset = "0xD34C60", VA = "0x180D36260", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x516D2D0", Offset = "0x516BCD0", VA = "0x18516D2D0", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x516D330", Offset = "0x516BD30", VA = "0x18516D330", Slot = "6")]
		protected override LinkedList<a>.Enumerator JIYABPAHYXR(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class JKRLEPTANSH<a> : EARDSEGKBIT<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x51613C0", Offset = "0x515FDC0", VA = "0x1851613C0", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x51614A0", Offset = "0x515FEA0", VA = "0x1851614A0", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x516D570", Offset = "0x516BF70", VA = "0x18516D570", Slot = "6")]
		protected override Queue<a>.Enumerator JIYABPAHYXR(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xD36260", Offset = "0xD34C60", VA = "0x180D36260", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class UNWXPIQLRLD<a> : EARDSEGKBIT<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x516B6C0", Offset = "0x516A0C0", VA = "0x18516B6C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x516B980", Offset = "0x516A380", VA = "0x18516B980", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7DB4A40", Offset = "0x7DB3440", VA = "0x187DB4A40", Slot = "6")]
		protected override Stack<a>.Enumerator JIYABPAHYXR(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7DB48E0", Offset = "0x7DB32E0", VA = "0x187DB48E0", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class YZBFLKURVGF<a> : EARDSEGKBIT<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x516D4D0", Offset = "0x516BED0", VA = "0x18516D4D0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xD36260", Offset = "0xD34C60", VA = "0x180D36260", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x516D510", Offset = "0x516BF10", VA = "0x18516D510", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x516D620", Offset = "0x516C020", VA = "0x18516D620", Slot = "6")]
		protected override HashSet<a>.Enumerator JIYABPAHYXR(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x516D670", Offset = "0x516C070", VA = "0x18516D670")]
		public YZBFLKURVGF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class IHLNSBNZXIL<a> : EABJAJYRZAS<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x516B6C0", Offset = "0x516A0C0", VA = "0x18516B6C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x65F8D20", Offset = "0x65F7720", VA = "0x1865F8D20", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x65F8DB0", Offset = "0x65F77B0", VA = "0x1865F8DB0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class CJHUSLXHYVO<a> : EABJAJYRZAS<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x51613C0", Offset = "0x515FDC0", VA = "0x1851613C0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x51614A0", Offset = "0x515FEA0", VA = "0x1851614A0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xD36260", Offset = "0xD34C60", VA = "0x180D36260", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class JYGHAUEPIGM<a> : EABJAJYRZAS<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x51613C0", Offset = "0x515FDC0", VA = "0x1851613C0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x51614A0", Offset = "0x515FEA0", VA = "0x1851614A0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xD36260", Offset = "0xD34C60", VA = "0x180D36260", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class DEZBHPGBARU<a> : EABJAJYRZAS<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x516B680", Offset = "0x516A080", VA = "0x18516B680", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x516B980", Offset = "0x516A380", VA = "0x18516B980", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x547EEF0", Offset = "0x547D8F0", VA = "0x18547EEF0", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x547EF10", Offset = "0x547D910", VA = "0x18547EF10")]
		public DEZBHPGBARU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class XUPFXUWGTOC<a, b> : TIJSSGKTKZA<IGrouping<a, b>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5097BF0", Offset = "0x50965F0", VA = "0x185097BF0", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x50978A0", Offset = "0x50962A0", VA = "0x1850978A0", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class YQBSKIXNUOH<a, b> : TIJSSGKTKZA<ILookup<a, b>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x516A370", Offset = "0x5168D70", VA = "0x18516A370", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x516A030", Offset = "0x5168A30", VA = "0x18516A030", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class AUPVPZQSDXB<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a OXRGMRPMYAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> GMVNKMTWSLH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x4E9E020", Offset = "0x4E9CA20", VA = "0x184E9E020", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x722AE10", Offset = "0x7229810", VA = "0x18722AE10")]
		public AUPVPZQSDXB(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x722ADA0", Offset = "0x72297A0", VA = "0x18722ADA0", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x66C30D0", Offset = "0x66C1AD0", VA = "0x1866C30D0", Slot = "6")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class OWWDXDXMCAM<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> EBIVOEYGQTY;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x730D340", Offset = "0x730BD40", VA = "0x18730D340", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		public OWWDXDXMCAM(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x730D1B0", Offset = "0x730BBB0", VA = "0x18730D1B0", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x730D2A0", Offset = "0x730BCA0", VA = "0x18730D2A0", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x730D2A0", Offset = "0x730BCA0", VA = "0x18730D2A0", Slot = "7")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class DPMLDPNYVTX<a> : TIJSSGKTKZA<a>, DUMZRUHETBP where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5489570", Offset = "0x5487F70", VA = "0x185489570", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5489360", Offset = "0x5487D60", VA = "0x185489360", Slot = "5")]
		public a Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public DPMLDPNYVTX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class ZYOUUSKBQMV : TIJSSGKTKZA<IEnumerable>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly TIJSSGKTKZA<IEnumerable> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA3E59D0", Offset = "0xA3E43D0", VA = "0x18A3E59D0", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA3E57D0", Offset = "0xA3E41D0", VA = "0x18A3E57D0", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public ZYOUUSKBQMV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class FPAFTDMFWTB : TIJSSGKTKZA<ICollection>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly TIJSSGKTKZA<ICollection> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE9F0", Offset = "0xA3CD3F0", VA = "0x18A3CE9F0", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE7F0", Offset = "0xA3CD1F0", VA = "0x18A3CE7F0", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public FPAFTDMFWTB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class YBHNNCIPBXN : TIJSSGKTKZA<IList>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly TIJSSGKTKZA<IList> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E44D0", Offset = "0xA3E2ED0", VA = "0x18A3E44D0", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E42D0", Offset = "0xA3E2CD0", VA = "0x18A3E42D0", Slot = "5")]
		public IList Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public YBHNNCIPBXN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class SXLDSNFVIUG<a> : EAGPXQSPIMB<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x51613C0", Offset = "0x515FDC0", VA = "0x1851613C0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6547AB0", Offset = "0x65464B0", VA = "0x186547AB0", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class HVTPSBPWQSI<a> : EABJAJYRZAS<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x51613C0", Offset = "0x515FDC0", VA = "0x1851613C0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6547AB0", Offset = "0x65464B0", VA = "0x186547AB0", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6547A40", Offset = "0x6546440", VA = "0x186547A40", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class YVVFDGVTFXM<a> : EABJAJYRZAS<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x516B7A0", Offset = "0x516A1A0", VA = "0x18516B7A0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x516B980", Offset = "0x516A380", VA = "0x18516B980", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x516B840", Offset = "0x516A240", VA = "0x18516B840", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x516B9B0", Offset = "0x516A3B0", VA = "0x18516B9B0")]
		public YVVFDGVTFXM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class RGCZRTKJIHQ<a> : EABJAJYRZAS<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x516B7A0", Offset = "0x516A1A0", VA = "0x18516B7A0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x516B980", Offset = "0x516A380", VA = "0x18516B980", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x547EEF0", Offset = "0x547D8F0", VA = "0x18547EEF0", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x547EF10", Offset = "0x547D910", VA = "0x18547EF10")]
		public RGCZRTKJIHQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class CKPYOQEHIAK<a> : EABJAJYRZAS<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x516D3E0", Offset = "0x516BDE0", VA = "0x18516D3E0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xD36260", Offset = "0xD34C60", VA = "0x180D36260", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x516D2D0", Offset = "0x516BCD0", VA = "0x18516D2D0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class DWXYHWYUXAS<a> : EAGPXQSPIMB<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x51613C0", Offset = "0x515FDC0", VA = "0x1851613C0", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x51614A0", Offset = "0x515FEA0", VA = "0x1851614A0", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class YHEISEUMOZP<a> : EAGPXQSPIMB<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x51613C0", Offset = "0x515FDC0", VA = "0x1851613C0", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x51614A0", Offset = "0x515FEA0", VA = "0x1851614A0", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class GTIKNRDAAVW<a> : EABJAJYRZAS<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x516B6C0", Offset = "0x516A0C0", VA = "0x18516B6C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x516B980", Offset = "0x516A380", VA = "0x18516B980", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x64493D0", Offset = "0x6447DD0", VA = "0x1864493D0", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class XMMFHRLQIWJ
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
		[Cpp2IlInjected.Address(RVA = "0xA3E25D0", Offset = "0xA3E0FD0", VA = "0x18A3E25D0")]
		public static DateTime LNMYXXNOISJ(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2D60", Offset = "0xA3E1760", VA = "0x18A3E2D60")]
		public static bool UTKOQXLQDME(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA3E28A0", Offset = "0xA3E12A0", VA = "0x18A3E28A0")]
		public static bool SEJFRTYSXSM(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2690", Offset = "0xA3E1090", VA = "0x18A3E2690")]
		public static bool SEJFRTYSXSM(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2B30", Offset = "0xA3E1530", VA = "0x18A3E2B30")]
		public static bool UGYTYMVHLVM(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class IFDXASJKPIF : TIJSSGKTKZA<DateTime>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly TIJSSGKTKZA<DateTime> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0F70", Offset = "0xA3CF970", VA = "0x18A3D0F70", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0DF0", Offset = "0xA3CF7F0", VA = "0x18A3D0DF0", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D09F0", Offset = "0xA3CF3F0", VA = "0x18A3D09F0")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public IFDXASJKPIF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class QWXIIUELDBS : TIJSSGKTKZA<DateTimeOffset>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly TIJSSGKTKZA<DateTimeOffset> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8760", Offset = "0xA3D7160", VA = "0x18A3D8760", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA3D86F0", Offset = "0xA3D70F0", VA = "0x18A3D86F0", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8310", Offset = "0xA3D6D10", VA = "0x18A3D8310")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public QWXIIUELDBS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class ZCOZMVBHVOB : TIJSSGKTKZA<TimeSpan>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly TIJSSGKTKZA<TimeSpan> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] TWQRVLPRQGV;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4D50", Offset = "0xA3E3750", VA = "0x18A3E4D50", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA3E48E0", Offset = "0xA3E32E0", VA = "0x18A3E48E0", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4960", Offset = "0xA3E3360", VA = "0x18A3E4960")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public ZCOZMVBHVOB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class QFVKEBWACSI<a, b, c, d, e> : TIJSSGKTKZA<e>, DUMZRUHETBP where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x763C940", Offset = "0x763B340", VA = "0x18763C940", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7637030", Offset = "0x7635A30", VA = "0x187637030", Slot = "5")]
		public e Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d JIYABPAHYXR(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		protected QFVKEBWACSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class QGARBIPXMDR<a, b, c, d> : QFVKEBWACSI<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5BDB380", Offset = "0x5BD9D80", VA = "0x185BDB380", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> JIYABPAHYXR(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		protected QGARBIPXMDR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class QFKWJOIFJVQ<a, b, c> : QGARBIPXMDR<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xD36260", Offset = "0xD34C60", VA = "0x180D36260", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class RXARDRXNOKE<a, b> : QFVKEBWACSI<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7703B00", Offset = "0x7702500", VA = "0x187703B00", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xD36260", Offset = "0xD34C60", VA = "0x180D36260", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7703C60", Offset = "0x7702660", VA = "0x187703C60", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7703D80", Offset = "0x7702780", VA = "0x187703D80", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator JIYABPAHYXR(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x69F2160", Offset = "0x69F0B60", VA = "0x1869F2160")]
		public RXARDRXNOKE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class GAMRXHDMWBO<a, b, c> : QFKWJOIFJVQ<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x6430B20", Offset = "0x642F520", VA = "0x186430B20", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6430D00", Offset = "0x642F700", VA = "0x186430D00", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class JAXBXCWPSNP<a, b> : QGARBIPXMDR<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x635C8B0", Offset = "0x635B2B0", VA = "0x18635C8B0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x516B3F0", Offset = "0x5169DF0", VA = "0x18516B3F0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xD36260", Offset = "0xD34C60", VA = "0x180D36260", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class KLQOVHFISFV<a, b> : QFKWJOIFJVQ<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x635C8B0", Offset = "0x635B2B0", VA = "0x18635C8B0", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x516B3F0", Offset = "0x5169DF0", VA = "0x18516B3F0", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class URTNZNUXJTR<a, b> : QFVKEBWACSI<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x635C8B0", Offset = "0x635B2B0", VA = "0x18635C8B0", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xD36260", Offset = "0xD34C60", VA = "0x180D36260", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x516B3F0", Offset = "0x5169DF0", VA = "0x18516B3F0", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6E00", Offset = "0x7DB5800", VA = "0x187DB6E00", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator JIYABPAHYXR(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class PYCTTWHUSYW<a, b> : QGARBIPXMDR<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x635C8B0", Offset = "0x635B2B0", VA = "0x18635C8B0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7427680", Offset = "0x7426080", VA = "0x187427680", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x74276F0", Offset = "0x74260F0", VA = "0x1874276F0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class FOWMLYOQQZN<a, b> : QGARBIPXMDR<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x635C870", Offset = "0x635B270", VA = "0x18635C870", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD36260", Offset = "0xD34C60", VA = "0x180D36260", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x635CA20", Offset = "0x635B420", VA = "0x18635CA20", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x516D670", Offset = "0x516C070", VA = "0x18516D670")]
		public FOWMLYOQQZN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class YSWNZCUWTMD<a, b> : QFKWJOIFJVQ<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x516B280", Offset = "0x5169C80", VA = "0x18516B280", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x516B3F0", Offset = "0x5169DF0", VA = "0x18516B3F0", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class VODHDSACNYZ<a> : TIJSSGKTKZA<a>, DUMZRUHETBP where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7ECCF60", Offset = "0x7ECB960", VA = "0x187ECCF60", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7ECCD30", Offset = "0x7ECB730", VA = "0x187ECCD30", Slot = "5")]
		public a Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public VODHDSACNYZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class PQQPRLBWWXB : TIJSSGKTKZA<IDictionary>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly TIJSSGKTKZA<IDictionary> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3D57D0", Offset = "0xA3D41D0", VA = "0x18A3D57D0", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA3D55F0", Offset = "0xA3D3FF0", VA = "0x18A3D55F0", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public PQQPRLBWWXB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class SSEFMMDATPX
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9400", Offset = "0xA3D7E00", VA = "0x18A3D9400")]
		public static object FIHZAWKSEGV(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9C40", Offset = "0xA3D8640", VA = "0x18A3D9C40")]
		public static object HPQLEUFWEWE(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class JNNNEYSAILQ<a> : TIJSSGKTKZA<a>, DUMZRUHETBP, LBAAVWLCNTR<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class ZBRDALKAYGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type XWYJJROIJCU;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ZBRDALKAYGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x5170DE0", Offset = "0x516F7E0", VA = "0x185170DE0")]
			internal bool VIDLTJTRRZL(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class ZBWJXSDYHRX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string OHCHHMYWYKG;

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ZBWJXSDYHRX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x5170FC0", Offset = "0x516F9C0", VA = "0x185170FC0")]
			internal bool VHYEWCZUIOC(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class ZBGPFXWGFJW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> UTZWSTBMQPD;

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ZBGPFXWGFJW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x516E700", Offset = "0x516D100", VA = "0x18516E700")]
			internal void VHSXYWFWZCT(JsonWriter a, a b, FSNHROPLCPN c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class ZBLWDEQDOVF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> XDVMTRGQAXS;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public ZBLWDEQDOVF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x516F350", Offset = "0x516DD50", VA = "0x18516F350")]
			internal a VHNRBPLZPRK(JsonReader a, FSNHROPLCPN b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly QEGFMNKZJQR<a> CJZWWGYJZLI;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> IRMGWUHPJYU;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> RFZZZIFPKUE;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> QMDSHXYUHKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool ZCLJZUBMSXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> VDDXZPYLAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> DIIMUBRRWJE;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x66F1A00", Offset = "0x66F0400", VA = "0x1866F1A00")]
		static JNNNEYSAILQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x66F5B80", Offset = "0x66F4580", VA = "0x1866F5B80")]
		public JNNNEYSAILQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x66DE7D0", Offset = "0x66DD1D0", VA = "0x1866DE7D0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x66DC6F0", Offset = "0x66DB0F0", VA = "0x1866DC6F0", Slot = "5")]
		public a Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x66DDDC0", Offset = "0x66DC7C0", VA = "0x1866DDDC0", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, a b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x66DE470", Offset = "0x66DCE70", VA = "0x1866DE470", Slot = "7")]
		public a QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class KYDYKYKBTHY<a> : TIJSSGKTKZA<a[,]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x687F210", Offset = "0x687DC10", VA = "0x18687F210", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x687EE80", Offset = "0x687D880", VA = "0x18687EE80", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public KYDYKYKBTHY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class KDPKKTGEXRK<a> : TIJSSGKTKZA<a[,,]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6838A60", Offset = "0x6837460", VA = "0x186838A60", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6838590", Offset = "0x6836F90", VA = "0x186838590", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public KDPKKTGEXRK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class WQWSYHSIUQE<a> : TIJSSGKTKZA<a[,,,]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x85A8280", Offset = "0x85A6C80", VA = "0x1885A8280", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x85A7C80", Offset = "0x85A6680", VA = "0x1885A7C80", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public WQWSYHSIUQE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class SWNZCGJIDCO<a> : TIJSSGKTKZA<a?>, DUMZRUHETBP where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7991800", Offset = "0x7990200", VA = "0x187991800", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7990FE0", Offset = "0x798F9E0", VA = "0x187990FE0", Slot = "5")]
		public a? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public SWNZCGJIDCO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class OAZEZNCIXOY<a> : TIJSSGKTKZA<a?>, DUMZRUHETBP where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly TIJSSGKTKZA<a> UZNYBZPRHYH;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		public OAZEZNCIXOY(TIJSSGKTKZA<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x72E7470", Offset = "0x72E5E70", VA = "0x1872E7470", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x72E65E0", Offset = "0x72E4FE0", VA = "0x1872E65E0", Slot = "5")]
		public a? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class TPFONRXTCVB : TIJSSGKTKZA<sbyte>, DUMZRUHETBP, LBAAVWLCNTR<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly TPFONRXTCVB KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA3DDEC0", Offset = "0xA3DC8C0", VA = "0x18A3DDEC0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA3DDD20", Offset = "0xA3DC720", VA = "0x18A3DDD20", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA3DDD30", Offset = "0xA3DC730", VA = "0x18A3DDD30", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, sbyte b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA3DDE40", Offset = "0xA3DC840", VA = "0x18A3DDE40", Slot = "7")]
		public sbyte QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public TPFONRXTCVB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class GSRSMWGVNHY : TIJSSGKTKZA<sbyte?>, DUMZRUHETBP, LBAAVWLCNTR<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly GSRSMWGVNHY KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF140", Offset = "0xA3CDB40", VA = "0x18A3CF140", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA3CEEA0", Offset = "0xA3CD8A0", VA = "0x18A3CEEA0", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA3CEF10", Offset = "0xA3CD910", VA = "0x18A3CEF10", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, sbyte? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF070", Offset = "0xA3CDA70", VA = "0x18A3CF070", Slot = "7")]
		public sbyte? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public GSRSMWGVNHY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class TTFNTUFDWCW : TIJSSGKTKZA<sbyte[]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly TTFNTUFDWCW KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA3DE100", Offset = "0xA3DCB00", VA = "0x18A3DE100", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA3DDFC0", Offset = "0xA3DC9C0", VA = "0x18A3DDFC0", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public TTFNTUFDWCW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class DDYRNRDTUNW : TIJSSGKTKZA<short>, DUMZRUHETBP, LBAAVWLCNTR<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly DDYRNRDTUNW KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDB00", Offset = "0xA3CC500", VA = "0x18A3CDB00", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD960", Offset = "0xA3CC360", VA = "0x18A3CD960", Slot = "5")]
		public short Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD970", Offset = "0xA3CC370", VA = "0x18A3CD970", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, short b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDA80", Offset = "0xA3CC480", VA = "0x18A3CDA80", Slot = "7")]
		public short QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public DDYRNRDTUNW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class HPXGNGKCYCJ : TIJSSGKTKZA<short?>, DUMZRUHETBP, LBAAVWLCNTR<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly HPXGNGKCYCJ KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0240", Offset = "0xA3CEC40", VA = "0x18A3D0240", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFFA0", Offset = "0xA3CE9A0", VA = "0x18A3CFFA0", Slot = "5")]
		public short? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0010", Offset = "0xA3CEA10", VA = "0x18A3D0010", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, short? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0170", Offset = "0xA3CEB70", VA = "0x18A3D0170", Slot = "7")]
		public short? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public HPXGNGKCYCJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class XWXWJNSIJIP : TIJSSGKTKZA<short[]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly XWXWJNSIJIP KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4030", Offset = "0xA3E2A30", VA = "0x18A3E4030", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA3E3EF0", Offset = "0xA3E28F0", VA = "0x18A3E3EF0", Slot = "5")]
		public short[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public XWXWJNSIJIP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class GWQFGPRAECK : TIJSSGKTKZA<int>, DUMZRUHETBP, LBAAVWLCNTR<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly GWQFGPRAECK KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF440", Offset = "0xA3CDE40", VA = "0x18A3CF440", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF2A0", Offset = "0xA3CDCA0", VA = "0x18A3CF2A0", Slot = "5")]
		public int Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF2B0", Offset = "0xA3CDCB0", VA = "0x18A3CF2B0", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, int b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF3C0", Offset = "0xA3CDDC0", VA = "0x18A3CF3C0", Slot = "7")]
		public int QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public GWQFGPRAECK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class PHFLTGVCCAH : TIJSSGKTKZA<int?>, DUMZRUHETBP, LBAAVWLCNTR<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly PHFLTGVCCAH KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5160", Offset = "0xA3D3B60", VA = "0x18A3D5160", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4EC0", Offset = "0xA3D38C0", VA = "0x18A3D4EC0", Slot = "5")]
		public int? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4F30", Offset = "0xA3D3930", VA = "0x18A3D4F30", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, int? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5090", Offset = "0xA3D3A90", VA = "0x18A3D5090", Slot = "7")]
		public int? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public PHFLTGVCCAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class IZSVIIERYBD : TIJSSGKTKZA<int[]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly IZSVIIERYBD KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2880", Offset = "0xA3D1280", VA = "0x18A3D2880", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2740", Offset = "0xA3D1140", VA = "0x18A3D2740", Slot = "5")]
		public int[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public IZSVIIERYBD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class DKQRUSCRODV : TIJSSGKTKZA<long>, DUMZRUHETBP, LBAAVWLCNTR<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly DKQRUSCRODV KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDD20", Offset = "0xA3CC720", VA = "0x18A3CDD20", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDC00", Offset = "0xA3CC600", VA = "0x18A3CDC00", Slot = "5")]
		public long Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDC10", Offset = "0xA3CC610", VA = "0x18A3CDC10", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, long b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDCE0", Offset = "0xA3CC6E0", VA = "0x18A3CDCE0", Slot = "7")]
		public long QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public DKQRUSCRODV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class QGXZBLSMCJM : TIJSSGKTKZA<long?>, DUMZRUHETBP, LBAAVWLCNTR<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly QGXZBLSMCJM KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6660", Offset = "0xA3D5060", VA = "0x18A3D6660", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D63F0", Offset = "0xA3D4DF0", VA = "0x18A3D63F0", Slot = "5")]
		public long? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6480", Offset = "0xA3D4E80", VA = "0x18A3D6480", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, long? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D65B0", Offset = "0xA3D4FB0", VA = "0x18A3D65B0", Slot = "7")]
		public long? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public QGXZBLSMCJM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class JGJZMLSJZLQ : TIJSSGKTKZA<long[]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly JGJZMLSJZLQ KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2C60", Offset = "0xA3D1660", VA = "0x18A3D2C60", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2B20", Offset = "0xA3D1520", VA = "0x18A3D2B20", Slot = "5")]
		public long[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public JGJZMLSJZLQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class NTVQODSLBXW : TIJSSGKTKZA<byte>, DUMZRUHETBP, LBAAVWLCNTR<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly NTVQODSLBXW KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA3D42E0", Offset = "0xA3D2CE0", VA = "0x18A3D42E0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4140", Offset = "0xA3D2B40", VA = "0x18A3D4140", Slot = "5")]
		public byte Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4150", Offset = "0xA3D2B50", VA = "0x18A3D4150", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, byte b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4260", Offset = "0xA3D2C60", VA = "0x18A3D4260", Slot = "7")]
		public byte QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public NTVQODSLBXW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class HPIHDJGDTRZ : TIJSSGKTKZA<byte?>, DUMZRUHETBP, LBAAVWLCNTR<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly HPIHDJGDTRZ KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFCB0", Offset = "0xA3CE6B0", VA = "0x18A3CFCB0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFA10", Offset = "0xA3CE410", VA = "0x18A3CFA10", Slot = "5")]
		public byte? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFA80", Offset = "0xA3CE480", VA = "0x18A3CFA80", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, byte? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFBE0", Offset = "0xA3CE5E0", VA = "0x18A3CFBE0", Slot = "7")]
		public byte? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public HPIHDJGDTRZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class USHTKNZPQKT : TIJSSGKTKZA<ushort>, DUMZRUHETBP, LBAAVWLCNTR<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly USHTKNZPQKT KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA3DF6B0", Offset = "0xA3DE0B0", VA = "0x18A3DF6B0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA3DF510", Offset = "0xA3DDF10", VA = "0x18A3DF510", Slot = "5")]
		public ushort Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA3DF520", Offset = "0xA3DDF20", VA = "0x18A3DF520", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, ushort b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA3DF630", Offset = "0xA3DE030", VA = "0x18A3DF630", Slot = "7")]
		public ushort QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public USHTKNZPQKT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class QCUYPQBSFAU : TIJSSGKTKZA<ushort?>, DUMZRUHETBP, LBAAVWLCNTR<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly QCUYPQBSFAU KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6290", Offset = "0xA3D4C90", VA = "0x18A3D6290", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5FF0", Offset = "0xA3D49F0", VA = "0x18A3D5FF0", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6060", Offset = "0xA3D4A60", VA = "0x18A3D6060", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, ushort? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D61C0", Offset = "0xA3D4BC0", VA = "0x18A3D61C0", Slot = "7")]
		public ushort? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public QCUYPQBSFAU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class OAQYZVHCQJE : TIJSSGKTKZA<ushort[]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly OAQYZVHCQJE KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4520", Offset = "0xA3D2F20", VA = "0x18A3D4520", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D43E0", Offset = "0xA3D2DE0", VA = "0x18A3D43E0", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public OAQYZVHCQJE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class MKDJZPBSJQZ : TIJSSGKTKZA<uint>, DUMZRUHETBP, LBAAVWLCNTR<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly MKDJZPBSJQZ KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA3D39A0", Offset = "0xA3D23A0", VA = "0x18A3D39A0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3800", Offset = "0xA3D2200", VA = "0x18A3D3800", Slot = "5")]
		public uint Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3810", Offset = "0xA3D2210", VA = "0x18A3D3810", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, uint b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3920", Offset = "0xA3D2320", VA = "0x18A3D3920", Slot = "7")]
		public uint QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public MKDJZPBSJQZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class BBLMPDZCTHE : TIJSSGKTKZA<uint?>, DUMZRUHETBP, LBAAVWLCNTR<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly BBLMPDZCTHE KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA3CBB80", Offset = "0xA3CA580", VA = "0x18A3CBB80", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA3CB8E0", Offset = "0xA3CA2E0", VA = "0x18A3CB8E0", Slot = "5")]
		public uint? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA3CB950", Offset = "0xA3CA350", VA = "0x18A3CB950", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, uint? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA3CBAB0", Offset = "0xA3CA4B0", VA = "0x18A3CBAB0", Slot = "7")]
		public uint? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public BBLMPDZCTHE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class LZVOYNLULQM : TIJSSGKTKZA<uint[]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly LZVOYNLULQM KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3560", Offset = "0xA3D1F60", VA = "0x18A3D3560", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3420", Offset = "0xA3D1E20", VA = "0x18A3D3420", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public LZVOYNLULQM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class EEFYBXSPYFO : TIJSSGKTKZA<ulong>, DUMZRUHETBP, LBAAVWLCNTR<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly EEFYBXSPYFO KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE720", Offset = "0xA3CD120", VA = "0x18A3CE720", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE600", Offset = "0xA3CD000", VA = "0x18A3CE600", Slot = "5")]
		public ulong Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE610", Offset = "0xA3CD010", VA = "0x18A3CE610", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, ulong b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE6E0", Offset = "0xA3CD0E0", VA = "0x18A3CE6E0", Slot = "7")]
		public ulong QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public EEFYBXSPYFO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class PGHRFKBDANR : TIJSSGKTKZA<ulong?>, DUMZRUHETBP, LBAAVWLCNTR<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly PGHRFKBDANR KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4D90", Offset = "0xA3D3790", VA = "0x18A3D4D90", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4B20", Offset = "0xA3D3520", VA = "0x18A3D4B20", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4BB0", Offset = "0xA3D35B0", VA = "0x18A3D4BB0", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, ulong? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4CE0", Offset = "0xA3D36E0", VA = "0x18A3D4CE0", Slot = "7")]
		public ulong? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public PGHRFKBDANR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class TLOZOLQICVB : TIJSSGKTKZA<ulong[]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly TLOZOLQICVB KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBFC0", Offset = "0xA3DA9C0", VA = "0x18A3DBFC0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBE80", Offset = "0xA3DA880", VA = "0x18A3DBE80", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public TLOZOLQICVB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class VNPFNGDOSSK : TIJSSGKTKZA<float>, DUMZRUHETBP, LBAAVWLCNTR<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly VNPFNGDOSSK KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFF80", Offset = "0xA3DE980", VA = "0x18A3DFF80", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFE60", Offset = "0xA3DE860", VA = "0x18A3DFE60", Slot = "5")]
		public float Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFE70", Offset = "0xA3DE870", VA = "0x18A3DFE70", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, float b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFF40", Offset = "0xA3DE940", VA = "0x18A3DFF40", Slot = "7")]
		public float QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public VNPFNGDOSSK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class ZICWDSQLSFT : TIJSSGKTKZA<float?>, DUMZRUHETBP, LBAAVWLCNTR<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly ZICWDSQLSFT KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xA3E56A0", Offset = "0xA3E40A0", VA = "0x18A3E56A0", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5470", Offset = "0xA3E3E70", VA = "0x18A3E5470", Slot = "5")]
		public float? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E54E0", Offset = "0xA3E3EE0", VA = "0x18A3E54E0", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, float? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5600", Offset = "0xA3E4000", VA = "0x18A3E5600", Slot = "7")]
		public float? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public ZICWDSQLSFT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class IWWHLEWFDAZ : TIJSSGKTKZA<float[]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly IWWHLEWFDAZ KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2050", Offset = "0xA3D0A50", VA = "0x18A3D2050", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1F10", Offset = "0xA3D0910", VA = "0x18A3D1F10", Slot = "5")]
		public float[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public IWWHLEWFDAZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class JQRQZHVWLWJ : TIJSSGKTKZA<double>, DUMZRUHETBP, LBAAVWLCNTR<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly JQRQZHVWLWJ KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2FB0", Offset = "0xA3D19B0", VA = "0x18A3D2FB0", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2E90", Offset = "0xA3D1890", VA = "0x18A3D2E90", Slot = "5")]
		public double Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2EA0", Offset = "0xA3D18A0", VA = "0x18A3D2EA0", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, double b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2F70", Offset = "0xA3D1970", VA = "0x18A3D2F70", Slot = "7")]
		public double QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public JQRQZHVWLWJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class UGTPUFMGRIG : TIJSSGKTKZA<double?>, DUMZRUHETBP, LBAAVWLCNTR<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly UGTPUFMGRIG KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA3DEDA0", Offset = "0xA3DD7A0", VA = "0x18A3DEDA0", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA3DEB30", Offset = "0xA3DD530", VA = "0x18A3DEB30", Slot = "5")]
		public double? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DEBC0", Offset = "0xA3DD5C0", VA = "0x18A3DEBC0", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, double? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DECF0", Offset = "0xA3DD6F0", VA = "0x18A3DECF0", Slot = "7")]
		public double? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public UGTPUFMGRIG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class UTCKVKKASYM : TIJSSGKTKZA<double[]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly UTCKVKKASYM KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA3DF8F0", Offset = "0xA3DE2F0", VA = "0x18A3DF8F0", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DF7B0", Offset = "0xA3DE1B0", VA = "0x18A3DF7B0", Slot = "5")]
		public double[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public UTCKVKKASYM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class VLLJXDZTSOK : TIJSSGKTKZA<bool>, DUMZRUHETBP, LBAAVWLCNTR<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly VLLJXDZTSOK KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFD90", Offset = "0xA3DE790", VA = "0x18A3DFD90", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFC70", Offset = "0xA3DE670", VA = "0x18A3DFC70", Slot = "5")]
		public bool Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFC80", Offset = "0xA3DE680", VA = "0x18A3DFC80", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, bool b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFD50", Offset = "0xA3DE750", VA = "0x18A3DFD50", Slot = "7")]
		public bool QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public VLLJXDZTSOK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class IZJHBECBGLZ : TIJSSGKTKZA<bool?>, DUMZRUHETBP, LBAAVWLCNTR<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly IZJHBECBGLZ KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2610", Offset = "0xA3D1010", VA = "0x18A3D2610", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA3D23E0", Offset = "0xA3D0DE0", VA = "0x18A3D23E0", Slot = "5")]
		public bool? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2450", Offset = "0xA3D0E50", VA = "0x18A3D2450", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, bool? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2570", Offset = "0xA3D0F70", VA = "0x18A3D2570", Slot = "7")]
		public bool? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public IZJHBECBGLZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class HJSLTKSHWHH : TIJSSGKTKZA<bool[]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly HJSLTKSHWHH KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF680", Offset = "0xA3CE080", VA = "0x18A3CF680", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF540", Offset = "0xA3CDF40", VA = "0x18A3CF540", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public HJSLTKSHWHH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class RXYGKVZWKRJ : TIJSSGKTKZA<byte[]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly TIJSSGKTKZA<byte[]> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA3D92D0", Offset = "0xA3D7CD0", VA = "0x18A3D92D0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9260", Offset = "0xA3D7C60", VA = "0x18A3D9260", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public RXYGKVZWKRJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class MSTLVGXJIXQ : TIJSSGKTKZA<ArraySegment<byte>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly TIJSSGKTKZA<ArraySegment<byte>> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3B70", Offset = "0xA3D2570", VA = "0x18A3D3B70", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3AA0", Offset = "0xA3D24A0", VA = "0x18A3D3AA0", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public MSTLVGXJIXQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class ZYWRFUUQQUC : TIJSSGKTKZA<string>, DUMZRUHETBP, LBAAVWLCNTR<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly TIJSSGKTKZA<string> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5DC0", Offset = "0xA3E47C0", VA = "0x18A3E5DC0", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5D50", Offset = "0xA3E4750", VA = "0x18A3E5D50", Slot = "5")]
		public string Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5D60", Offset = "0xA3E4760", VA = "0x18A3E5D60", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, string b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5D50", Offset = "0xA3E4750", VA = "0x18A3E5D50", Slot = "7")]
		public string QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public ZYWRFUUQQUC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class IJLMMBTEOMJ : TIJSSGKTKZA<string[]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly IJLMMBTEOMJ KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1CE0", Offset = "0xA3D06E0", VA = "0x18A3D1CE0", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1B90", Offset = "0xA3D0590", VA = "0x18A3D1B90", Slot = "5")]
		public string[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public IJLMMBTEOMJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class SUXIPRDWIOK : TIJSSGKTKZA<char>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly SUXIPRDWIOK KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA4B0", Offset = "0xA3D8EB0", VA = "0x18A3DA4B0", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA480", Offset = "0xA3D8E80", VA = "0x18A3DA480", Slot = "5")]
		public char Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public SUXIPRDWIOK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class IBTMEHBGIRH : TIJSSGKTKZA<char?>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly IBTMEHBGIRH KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0880", Offset = "0xA3CF280", VA = "0x18A3D0880", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA3D07C0", Offset = "0xA3CF1C0", VA = "0x18A3D07C0", Slot = "5")]
		public char? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public IBTMEHBGIRH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class UKLPHACGXGV : TIJSSGKTKZA<char[]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly UKLPHACGXGV KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA3DF060", Offset = "0xA3DDA60", VA = "0x18A3DF060", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA3DEED0", Offset = "0xA3DD8D0", VA = "0x18A3DEED0", Slot = "5")]
		public char[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public UKLPHACGXGV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class NFCJKJOOEOV : TIJSSGKTKZA<Guid>, DUMZRUHETBP, LBAAVWLCNTR<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly TIJSSGKTKZA<Guid> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3F60", Offset = "0xA3D2960", VA = "0x18A3D3F60", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3D10", Offset = "0xA3D2710", VA = "0x18A3D3D10", Slot = "5")]
		public Guid Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3D70", Offset = "0xA3D2770", VA = "0x18A3D3D70", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, Guid b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3EF0", Offset = "0xA3D28F0", VA = "0x18A3D3EF0", Slot = "7")]
		public Guid QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public NFCJKJOOEOV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class IBIHLEMQDNR : TIJSSGKTKZA<decimal>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly TIJSSGKTKZA<decimal> KLCPKUHGTRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool GYGYNGCFWTJ;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8720020", Offset = "0x871EA20", VA = "0x188720020")]
		public IBIHLEMQDNR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xFC1AA0", Offset = "0xFC04A0", VA = "0x180FC1AA0")]
		public IBIHLEMQDNR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0570", Offset = "0xA3CEF70", VA = "0x18A3D0570", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA3D03A0", Offset = "0xA3CEDA0", VA = "0x18A3D03A0", Slot = "5")]
		public decimal Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class QBXUPHTDZSY : TIJSSGKTKZA<Uri>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly TIJSSGKTKZA<Uri> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5EA0", Offset = "0xA3D48A0", VA = "0x18A3D5EA0", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5E20", Offset = "0xA3D4820", VA = "0x18A3D5E20", Slot = "5")]
		public Uri Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public QBXUPHTDZSY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class LYZWSVOHGZU : TIJSSGKTKZA<Version>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly TIJSSGKTKZA<Version> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA3D32F0", Offset = "0xA3D1CF0", VA = "0x18A3D32F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3270", Offset = "0xA3D1C70", VA = "0x18A3D3270", Slot = "5")]
		public Version Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public LYZWSVOHGZU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class WKNVSGTQDEI<a, b> : TIJSSGKTKZA<KeyValuePair<a, b>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x859EE00", Offset = "0x859D800", VA = "0x18859EE00", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x859E930", Offset = "0x859D330", VA = "0x18859E930", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class HPIYJFRJPGW : TIJSSGKTKZA<StringBuilder>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly TIJSSGKTKZA<StringBuilder> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFE90", Offset = "0xA3CE890", VA = "0x18A3CFE90", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFE10", Offset = "0xA3CE810", VA = "0x18A3CFE10", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public HPIYJFRJPGW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class WFFLGCLHYGG : TIJSSGKTKZA<BitArray>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly TIJSSGKTKZA<BitArray> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0210", Offset = "0xA3DEC10", VA = "0x18A3E0210", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3E00F0", Offset = "0xA3DEAF0", VA = "0x18A3E00F0", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public WFFLGCLHYGG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class BYLXKFQCJZM : TIJSSGKTKZA<Type>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly BYLXKFQCJZM KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex GMEEUMVAYKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool YHEMLVEWYLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool UFNSXZDYALW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool YMIEDAENSIB;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA3CBFD0", Offset = "0xA3CA9D0", VA = "0x18A3CBFD0")]
		public BYLXKFQCJZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x96E74C0", Offset = "0x96E5EC0", VA = "0x1896E74C0")]
		public BYLXKFQCJZM(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA3CBDF0", Offset = "0xA3CA7F0", VA = "0x18A3CBDF0", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA3CBCE0", Offset = "0xA3CA6E0", VA = "0x18A3CBCE0", Slot = "5")]
		public Type Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class LFZJCDPXVVM : TIJSSGKTKZA<BigInteger>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly TIJSSGKTKZA<BigInteger> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3130", Offset = "0xA3D1B30", VA = "0x18A3D3130", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3080", Offset = "0xA3D1A80", VA = "0x18A3D3080", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public LFZJCDPXVVM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class SZPGGWNECHA : TIJSSGKTKZA<Complex>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly TIJSSGKTKZA<Complex> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA660", Offset = "0xA3D9060", VA = "0x18A3DA660", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA5D0", Offset = "0xA3D8FD0", VA = "0x18A3DA5D0", Slot = "5")]
		public Complex Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public SZPGGWNECHA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class PLBEURGEHZC : TIJSSGKTKZA<ExpandoObject>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly TIJSSGKTKZA<ExpandoObject> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA3D54F0", Offset = "0xA3D3EF0", VA = "0x18A3D54F0", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA3D52C0", Offset = "0xA3D3CC0", VA = "0x18A3D52C0", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public PLBEURGEHZC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class TFAXRPBNCTN<a> : TIJSSGKTKZA<Lazy<a>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B03890", Offset = "0x7B02290", VA = "0x187B03890", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B036A0", Offset = "0x7B020A0", VA = "0x187B036A0", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class ULQYUSIHHDF : TIJSSGKTKZA<Task>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly TIJSSGKTKZA<Task> KLCPKUHGTRT;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task EYTFISLKDCU;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA3DF3D0", Offset = "0xA3DDDD0", VA = "0x18A3DF3D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA3DF320", Offset = "0xA3DDD20", VA = "0x18A3DF320", Slot = "5")]
		public Task Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public ULQYUSIHHDF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class YNXEZVLLPNV<a> : TIJSSGKTKZA<Task<a>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x5169880", Offset = "0x5168280", VA = "0x185169880", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x5169690", Offset = "0x5168090", VA = "0x185169690", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class JAHSEWHWMLH<a> : TIJSSGKTKZA<ValueTask<a>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x66D1D10", Offset = "0x66D0710", VA = "0x1866D1D10", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x66D1AF0", Offset = "0x66D04F0", VA = "0x1866D1AF0", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class SHMSGFIKBVB<a> : TIJSSGKTKZA<Tuple<a>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7978900", Offset = "0x7977300", VA = "0x187978900", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x7978630", Offset = "0x7977030", VA = "0x187978630", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class SHRZDMCHLGK<a, b> : TIJSSGKTKZA<Tuple<a, b>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x79790F0", Offset = "0x7977AF0", VA = "0x1879790F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7978CD0", Offset = "0x79776D0", VA = "0x187978CD0", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class SHXGASWEURT<a, b, c> : TIJSSGKTKZA<Tuple<a, b, c>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7979B80", Offset = "0x7978580", VA = "0x187979B80", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7979610", Offset = "0x7978010", VA = "0x187979610", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class SGMJTXMXGQI<a, b, c, d> : TIJSSGKTKZA<Tuple<a, b, c, d>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x79739B0", Offset = "0x79723B0", VA = "0x1879739B0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x79732F0", Offset = "0x7971CF0", VA = "0x1879732F0", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class SGRQREGUQBR<a, b, c, d, e> : TIJSSGKTKZA<Tuple<a, b, c, d, e>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x79749B0", Offset = "0x79733B0", VA = "0x1879749B0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x79741A0", Offset = "0x7972BA0", VA = "0x1879741A0", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class SGWXOLARZNA<a, b, c, d, e, f> : TIJSSGKTKZA<Tuple<a, b, c, d, e, f>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7976400", Offset = "0x7974E00", VA = "0x187976400", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7975A60", Offset = "0x7974460", VA = "0x187975A60", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class SHCELRUPIYJ<a, b, c, d, e, f, g> : TIJSSGKTKZA<Tuple<a, b, c, d, e, f, g>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x79779F0", Offset = "0x79763F0", VA = "0x1879779F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7976ED0", Offset = "0x79758D0", VA = "0x187976ED0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class SFRIEWLHUWY<a, b, c, d, e, f, g, h> : TIJSSGKTKZA<Tuple<a, b, c, d, e, f, g, h>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7972250", Offset = "0x7970C50", VA = "0x187972250", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x79715C0", Offset = "0x796FFC0", VA = "0x1879715C0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class LRZNOHURKFU<a> : TIJSSGKTKZA<ValueTuple<a>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x6950260", Offset = "0x694EC60", VA = "0x186950260", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x694FE40", Offset = "0x694E840", VA = "0x18694FE40", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class LRUGRBAUAUL<a, b> : TIJSSGKTKZA<(a, b)>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x694F8F0", Offset = "0x694E2F0", VA = "0x18694F8F0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x694F400", Offset = "0x694DE00", VA = "0x18694F400", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class LROZTUGWRJC<a, b, c> : TIJSSGKTKZA<(a, b, c)>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x694D6A0", Offset = "0x694C0A0", VA = "0x18694D6A0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x694D030", Offset = "0x694BA30", VA = "0x18694D030", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class LSZWAPQEFKN<a, b, c, d> : TIJSSGKTKZA<(a, b, c, d)>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x69557F0", Offset = "0x69541F0", VA = "0x1869557F0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x6954FB0", Offset = "0x69539B0", VA = "0x186954FB0", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class LSUPDIWGVZE<a, b, c, d, e> : TIJSSGKTKZA<(a, b, c, d, e)>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x6954540", Offset = "0x6952F40", VA = "0x186954540", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6953B80", Offset = "0x6952580", VA = "0x186953B80", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class LSPIGCCJMNV<a, b, c, d, e, f> : TIJSSGKTKZA<(a, b, c, d, e, f)>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x6952F60", Offset = "0x6951960", VA = "0x186952F60", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x6952390", Offset = "0x6950D90", VA = "0x186952390", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class LSKBIVIMDCM<a, b, c, d, e, f, g> : TIJSSGKTKZA<(a, b, c, d, e, f, g)>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x69515C0", Offset = "0x694FFC0", VA = "0x1869515C0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6950840", Offset = "0x694F240", VA = "0x186950840", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class LTUXPQRTRDX<a, b, c, d, e, f, g, h> : TIJSSGKTKZA<ValueTuple<a, b, c, d, e, f, g, h>>, DUMZRUHETBP where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] JWAUSAXMNPU;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly IYMRTTJUVFY MPTXVNMLVXG;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6956FE0", Offset = "0x69559E0", VA = "0x186956FE0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x69560B0", Offset = "0x6954AB0", VA = "0x1869560B0", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class PEVZKQKLCPU
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] DMHBXJTHCXU;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly IYMRTTJUVFY OVUIELOHJXZ;

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4970", Offset = "0xA3D3370", VA = "0x18A3D4970")]
		static PEVZKQKLCPU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class OUEPYCFZLXG
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] IYNHHBZQXDF;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly IYMRTTJUVFY JPFNZQYSAVI;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xA3D47C0", Offset = "0xA3D31C0", VA = "0x18A3D47C0")]
		static OUEPYCFZLXG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class XSNFPGYOTAQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] ZGZUEXVJPYC;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly IYMRTTJUVFY SFUGUVAOXTB;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] ZGUNHRBMGMT;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly IYMRTTJUVFY SFZNSBUMHEK;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] ZGPGKKHOXBK;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly IYMRTTJUVFY SGEUPIOJQPT;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] ZIACRFQWLCV;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly IYMRTTJUVFY SGKBMPIHABC;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] ZHUVTYWZBRM;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly IYMRTTJUVFY SGPIJWCEJML;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] ZHPOWSDBSGD;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly IYMRTTJUVFY SGUPHCWBSXU;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] ZHKHZLJEIUU;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly IYMRTTJUVFY SGZWEJPZCJD;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] ZIVEGGSLWWF;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly IYMRTTJUVFY SDYWTMDMQUY;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2F10", Offset = "0xA3E1910", VA = "0x18A3E2F10")]
		static XSNFPGYOTAQ()
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
