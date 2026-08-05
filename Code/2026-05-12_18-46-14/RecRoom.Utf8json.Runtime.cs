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
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6D0", Offset = "0xD0B0D0", VA = "0x180D0C6D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD34A80", Offset = "0xD33480", VA = "0x180D34A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D96BE0", Offset = "0x3D955E0", VA = "0x183D96BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BD94D0", Offset = "0x3BD7ED0", VA = "0x183BD94D0")]
		public static TIJSSGKTKZA<a> QOHJAUYNKKH<a>(this FSNHROPLCPN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA511210", Offset = "0xA50FC10", VA = "0x18A511210")]
		public static object UYPXUSPBJVV(this FSNHROPLCPN a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA50DA90", Offset = "0xA50C490", VA = "0x18A50DA90")]
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
				[Cpp2IlInjected.Address(RVA = "0xA51CEE0", Offset = "0xA51B8E0", VA = "0x18A51CEE0")]
				public OCGUJKQGLKC(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xA51CDC0", Offset = "0xA51B7C0", VA = "0x18A51CDC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA51DC90", Offset = "0xA51C690", VA = "0x18A51DC90")]
			public void HSHRCEPTJZO([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA51DB50", Offset = "0xA51C550", VA = "0x18A51DB50")]
			public void HSHRCEPTJZO(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA51DDA0", Offset = "0xA51C7A0", VA = "0x18A51DDA0")]
			public ReadOnlySequence<byte> OLMVNCYNJKD()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA51E0C0", Offset = "0xA51CAC0", VA = "0x18A51E0C0")]
			private void YYSMOLJRMIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA51DED0", Offset = "0xA51C8D0", VA = "0x18A51DED0")]
			private void QINFCFSHENT([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA514EA0", Offset = "0xA5138A0", VA = "0x18A514EA0")]
		public JsonReader([In] ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA514D30", Offset = "0xA513730", VA = "0x18A514D30")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA512E60", Offset = "0xA511860", VA = "0x18A512E60")]
		private JsonParsingException HLHHOROMZVD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA5131B0", Offset = "0xA511BB0", VA = "0x18A5131B0")]
		private JsonParsingException HXIJANHAIRW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA513BD0", Offset = "0xA5125D0", VA = "0x18A513BD0")]
		public JsonToken NINAITQQYQA()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA5133F0", Offset = "0xA511DF0", VA = "0x18A5133F0")]
		public void JRJAPBNSHBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA511D50", Offset = "0xA510750", VA = "0x18A511D50")]
		private bool BBPQOISWLQU(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA511CF0", Offset = "0xA5106F0", VA = "0x18A511CF0")]
		private bool BBPQOISWLQU(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA512290", Offset = "0xA510C90", VA = "0x18A512290")]
		private void CJLPSZMYGAN(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA513620", Offset = "0xA512020", VA = "0x18A513620")]
		public bool KKLKLRLWGGJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA514690", Offset = "0xA513090", VA = "0x18A514690")]
		public void UCKHTGQUVNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA514B50", Offset = "0xA513550", VA = "0x18A514B50")]
		public bool YMIDNVOZERE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA514BB0", Offset = "0xA5135B0", VA = "0x18A514BB0")]
		public void ZITJAWLOSRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA5132C0", Offset = "0xA511CC0", VA = "0x18A5132C0")]
		public void IDIIQOMHLBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA5136E0", Offset = "0xA5120E0", VA = "0x18A5136E0")]
		public bool KMTQGEAVNZE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA5125F0", Offset = "0xA510FF0", VA = "0x18A5125F0")]
		public void FFZFWSQGAVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA514BA0", Offset = "0xA5135A0", VA = "0x18A514BA0")]
		public void YOREZSZGZFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA512600", Offset = "0xA511000", VA = "0x18A512600")]
		public bool FHLROLDDTGZ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA5141B0", Offset = "0xA512BB0", VA = "0x18A5141B0")]
		public bool OWREXCRAHDS(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA514290", Offset = "0xA512C90", VA = "0x18A514290")]
		public bool PEPQTDIXVGN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA514A70", Offset = "0xA513470", VA = "0x18A514A70")]
		public bool XPYQKTCXBDC(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA512980", Offset = "0xA511380", VA = "0x18A512980")]
		private ReadOnlySequence<byte> HCUWGPKVJYB()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA514750", Offset = "0xA513150", VA = "0x18A514750")]
		private ReadOnlySequence<byte> VJUNIBAQZKY()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA513730", Offset = "0xA512130", VA = "0x18A513730")]
		private void LYMREQZDALG(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA5139D0", Offset = "0xA5123D0", VA = "0x18A5139D0")]
		private void MPOHMSNHAED(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA512690", Offset = "0xA511090", VA = "0x18A512690")]
		private void GIWPAQCWUVM(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA5143F0", Offset = "0xA512DF0", VA = "0x18A5143F0")]
		private void RDXLMSCGFHH(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA50BA40", Offset = "0xA50A440", VA = "0x18A50BA40")]
		private static int CNMSWXWSCMY(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA514320", Offset = "0xA512D20", VA = "0x18A514320")]
		public ReadOnlySequence<byte> PYUAYUOXAAU()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA513DE0", Offset = "0xA5127E0", VA = "0x18A513DE0")]
		public string NLHWEPYTRLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA512500", Offset = "0xA510F00", VA = "0x18A512500")]
		public string ECZRLSJXSGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA513F00", Offset = "0xA512900", VA = "0x18A513F00")]
		public ReadOnlySequence<byte> OLMLJVVDIDO()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA514500", Offset = "0xA512F00", VA = "0x18A514500")]
		public ReadOnlySequence<byte> SHBUZRTYEAL()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA512340", Offset = "0xA510D40", VA = "0x18A512340")]
		public bool CWXSSJUZOIU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA514BC0", Offset = "0xA5135C0", VA = "0x18A514BC0")]
		private void ZKTBUKDFQVY(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA512540", Offset = "0xA510F40", VA = "0x18A512540")]
		public void ELXFUEMKCGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA512050", Offset = "0xA510A50", VA = "0x18A512050")]
		private void BTLVMDHLFMN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA5146A0", Offset = "0xA5130A0", VA = "0x18A5146A0")]
		public sbyte UKJUKOQRNZF()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA513920", Offset = "0xA512320", VA = "0x18A513920")]
		public short MOHCYIANYNQ()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA511C40", Offset = "0xA510640", VA = "0x18A511C40")]
		public int ANZJRQNOGLO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA5132D0", Offset = "0xA511CD0", VA = "0x18A5132D0")]
		public long IKMJNACMMHF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA5145E0", Offset = "0xA512FE0", VA = "0x18A5145E0")]
		public byte TLNBTBVWCVY()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA5149C0", Offset = "0xA5133C0", VA = "0x18A5149C0")]
		public ushort WCXTYBUSHRB()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA513340", Offset = "0xA511D40", VA = "0x18A513340")]
		public uint IXVSRVZDLGJ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA512490", Offset = "0xA510E90", VA = "0x18A512490")]
		public ulong EAFVIMLFZGC()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA513E60", Offset = "0xA512860", VA = "0x18A513E60")]
		public float OBBNZURVPHK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA512550", Offset = "0xA510F50", VA = "0x18A512550")]
		public double FFMYMLIAOHX()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA513FD0", Offset = "0xA5129D0", VA = "0x18A513FD0")]
		public ReadOnlySequence<byte> OQCCZOFQMGW()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA511DB0", Offset = "0xA5107B0", VA = "0x18A511DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xFBC1A0", Offset = "0xFBABA0", VA = "0x180FBC1A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA511BE0", Offset = "0xA5105E0", VA = "0x18A511BE0")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA511B60", Offset = "0xA510560", VA = "0x18A511B60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5209E0", Offset = "0xA51F3E0", VA = "0x18A5209E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA516400", Offset = "0xA514E00", VA = "0x18A516400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA516E20", Offset = "0xA515820", VA = "0x18A516E20")]
		public static void PCBRQSPPRIL(FSNHROPLCPN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3C11820", Offset = "0x3C10220", VA = "0x183C11820")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C119E0", Offset = "0x3C103E0", VA = "0x183C119E0")]
		public static byte[] Serialize<T>(T value, FSNHROPLCPN resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3C12090", Offset = "0x3C10A90", VA = "0x183C12090")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3C12250", Offset = "0x3C10C50", VA = "0x183C12250")]
		public static string ToJsonString<T>(T value, FSNHROPLCPN resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3C10F80", Offset = "0x3C0F980", VA = "0x183C10F80")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3C112A0", Offset = "0x3C0FCA0", VA = "0x183C112A0")]
		public static T Deserialize<T>(string json, FSNHROPLCPN resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3C11420", Offset = "0x3C0FE20", VA = "0x183C11420")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3C11150", Offset = "0x3C0FB50", VA = "0x183C11150")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, FSNHROPLCPN resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3C107A0", Offset = "0x3C0F1A0", VA = "0x183C107A0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3C109C0", Offset = "0x3C0F3C0", VA = "0x183C109C0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, FSNHROPLCPN resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA516E90", Offset = "0xA515890", VA = "0x18A516E90")]
		public static byte[] YAMCBPMCIXW(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA5164F0", Offset = "0xA514EF0", VA = "0x18A5164F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF7AA50", Offset = "0xF79450", VA = "0x180F7AA50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA515AC0", Offset = "0xA5144C0", VA = "0x18A515AC0")]
		public void MRZDTJCLBZD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA515EC0", Offset = "0xA5148C0", VA = "0x18A515EC0")]
		public static byte[] SLCZBRUVAWI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA5159A0", Offset = "0xA5143A0", VA = "0x18A5159A0")]
		public static byte[] MJTSYBXTLQE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA516160", Offset = "0xA514B60", VA = "0x18A516160")]
		public static byte[] XOUELGBMHBQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA515AD0", Offset = "0xA5144D0", VA = "0x18A515AD0")]
		public static byte[] MZSUSKVNQCO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6CE0", Offset = "0x2AD56E0", VA = "0x182AD6CE0")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA5156B0", Offset = "0xA5140B0", VA = "0x18A5156B0")]
		public ArraySegment<byte> CYKYGZUZNIO()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA515D30", Offset = "0xA514730", VA = "0x18A515D30")]
		public byte[] QZZOGMXGEWR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA516010", Offset = "0xA514A10", VA = "0x18A516010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA5160E0", Offset = "0xA514AE0", VA = "0x18A5160E0")]
		public void WPSJPYLSEAG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA50BDD0", Offset = "0xA50A7D0", VA = "0x18A50BDD0")]
		public void IFJICBPWHOL(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA515890", Offset = "0xA514290", VA = "0x18A515890")]
		public void IFJICBPWHOL(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA515C80", Offset = "0xA514680", VA = "0x18A515C80")]
		public void NLEQBGDBIAJ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x54D7990", Offset = "0x54D6390", VA = "0x1854D7990")]
		public void PALNSPMBHDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x54D78F0", Offset = "0x54D62F0", VA = "0x1854D78F0")]
		public void GSXOLZCLWSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7769910", Offset = "0x7768310", VA = "0x187769910")]
		public void RNDBWXFFTIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x50C0190", Offset = "0x50BEB90", VA = "0x1850C0190")]
		public void QHXSICVEUJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x54D7940", Offset = "0x54D6340", VA = "0x1854D7940")]
		public void HKXOFEDORNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7769960", Offset = "0x7768360", VA = "0x187769960")]
		public void XLAUEGTCFPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA5162A0", Offset = "0xA514CA0", VA = "0x18A5162A0")]
		public void ZTXATQTIMRH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA5157D0", Offset = "0xA5141D0", VA = "0x18A5157D0")]
		public void HLARBWFNEDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x50C00F0", Offset = "0x50BEAF0", VA = "0x1850C00F0")]
		public void OCYAFJMXBGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8BC0", Offset = "0x8DF75C0", VA = "0x188DF8BC0")]
		public void QWTSEXIQNEV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA515920", Offset = "0xA514320", VA = "0x18A515920")]
		public void IXDDQCXZTLJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA515750", Offset = "0xA514150", VA = "0x18A515750")]
		public void EJDLZOAETNA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA515FA0", Offset = "0xA5149A0", VA = "0x18A515FA0")]
		public void TTVKZADJMAJ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA515CC0", Offset = "0xA5146C0", VA = "0x18A515CC0")]
		public void OSPQXHWCWMI(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA5150C0", Offset = "0xA513AC0", VA = "0x18A5150C0")]
		public void ASXKDZJCOOK(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA5158F0", Offset = "0xA5142F0", VA = "0x18A5158F0")]
		public void IOPIKHWLIQR(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA5160F0", Offset = "0xA514AF0", VA = "0x18A5160F0")]
		public void XJOVWQNAYNY(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA515820", Offset = "0xA514220", VA = "0x18A515820")]
		public void HYNMISEMHQX(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA516070", Offset = "0xA514A70", VA = "0x18A516070")]
		public void VBOAWWYVYSB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA515C50", Offset = "0xA514650", VA = "0x18A515C50")]
		public void NDKXXLGSVJQ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA515130", Offset = "0xA513B30", VA = "0x18A515130")]
		public void BAGGSQHWUKC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA515040", Offset = "0xA513A40", VA = "0x18A515040")]
		private static bool ABZFXQGABTK(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA516280", Offset = "0xA514C80", VA = "0x18A516280")]
		private static byte ZPWJVJWNTWK(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA50BD30", Offset = "0xA50A730", VA = "0x18A50BD30")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E0AB0", Offset = "0x50DF4B0", VA = "0x1850E0AB0")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private UTGCZKGOKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E28C0", Offset = "0x50E12C0", VA = "0x1850E28C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA518860", Offset = "0xA517260", VA = "0x18A518860")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private ISWXCMNVVSF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E3560", Offset = "0x50E1F60", VA = "0x1850E3560")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private JHQQOABRIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA510D20", Offset = "0xA50F720", VA = "0x18A510D20")]
		public static void QCIVJGOFOSZ(params FSNHROPLCPN[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA510DF0", Offset = "0xA50F7F0", VA = "0x18A510DF0")]
		public static void QCIVJGOFOSZ(params DUMZRUHETBP[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA510EC0", Offset = "0xA50F8C0", VA = "0x18A510EC0")]
		public static void ZDJFRZKFUPB(DUMZRUHETBP[] a, FSNHROPLCPN[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E2AB0", Offset = "0x50E14B0", VA = "0x1850E2AB0")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private EDKCNZAQDUU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA51A7E0", Offset = "0xA5191E0", VA = "0x18A51A7E0")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA51C3E0", Offset = "0xA51ADE0", VA = "0x18A51C3E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E01D0", Offset = "0x50DEBD0", VA = "0x1850E01D0")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private AENVFJVLGEY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50DF8F0", Offset = "0x50DE2F0", VA = "0x1850DF8F0")]
			static XZFBBAGBFUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly FSNHROPLCPN IWMDTGRRYAH;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private YFLEZXDYMFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50DFED0", Offset = "0x50DE8D0", VA = "0x1850DFED0")]
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
				[Cpp2IlInjected.Address(RVA = "0x50E2460", Offset = "0x50E0E60", VA = "0x1850E2460")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private TUBRHDQOFUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E1D00", Offset = "0x50E0700", VA = "0x1850E1D00")]
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
				[Cpp2IlInjected.Address(RVA = "0x50E2E00", Offset = "0x50E1800", VA = "0x1850E2E00")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private VBRQZUMDJUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E3260", Offset = "0x50E1C60", VA = "0x1850E3260")]
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
				[Cpp2IlInjected.Address(RVA = "0x50E3C80", Offset = "0x50E2680", VA = "0x1850E3C80")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private WBQJVDNWGCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E2F60", Offset = "0x50E1960", VA = "0x1850E2F60")]
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
				[Cpp2IlInjected.Address(RVA = "0x50E18A0", Offset = "0x50E02A0", VA = "0x1850E18A0")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private XYRNGBXCNOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E25C0", Offset = "0x50E0FC0", VA = "0x1850E25C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x50E2CA0", Offset = "0x50E16A0", VA = "0x1850E2CA0")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private NGWUNIVUUTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E2000", Offset = "0x50E0A00", VA = "0x1850E2000")]
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
				[Cpp2IlInjected.Address(RVA = "0x50E4FC0", Offset = "0x50E39C0", VA = "0x1850E4FC0")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private CJLFUXXSDSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E3DE0", Offset = "0x50E27E0", VA = "0x1850E3DE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x50E2300", Offset = "0x50E0D00", VA = "0x1850E2300")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private SJUEERLJCQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E4820", Offset = "0x50E3220", VA = "0x1850E4820")]
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
				[Cpp2IlInjected.Address(RVA = "0x50E4B20", Offset = "0x50E3520", VA = "0x1850E4B20")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private NWPPBOCXVAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E0FE0", Offset = "0x50DF9E0", VA = "0x1850E0FE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x50E4C80", Offset = "0x50E3680", VA = "0x1850E4C80")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private MDYWQLVGJKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E12E0", Offset = "0x50DFCE0", VA = "0x1850E12E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x50E1740", Offset = "0x50E0140", VA = "0x1850E1740")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private WTXHQYOUEAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E07B0", Offset = "0x50DF1B0", VA = "0x1850E07B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x50E46C0", Offset = "0x50E30C0", VA = "0x1850E46C0")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private KRURJNEUDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x50E1A00", Offset = "0x50E0400", VA = "0x1850E1A00")]
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
				[Cpp2IlInjected.Address(RVA = "0x50E15E0", Offset = "0x50DFFE0", VA = "0x1850E15E0")]
				static XZFBBAGBFUP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly FSNHROPLCPN IWMDTGRRYAH;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly FSNHROPLCPN[] EJSWYEEFPLN;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			private ULFZXYQUZCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		private ZLQUPCXHWZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3374DC0", Offset = "0x33737C0", VA = "0x183374DC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x775DA90", Offset = "0x775C490", VA = "0x18775DA90")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x775D790", Offset = "0x775C190", VA = "0x18775D790")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x775DA00", Offset = "0x775C400", VA = "0x18775DA00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F0B000", Offset = "0x7F09A00", VA = "0x187F0B000")]
		public UVEBVBACRPK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7F0AAB0", Offset = "0x7F094B0", VA = "0x187F0AAB0")]
		public a[] XZUYFBJJCDR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7F0A930", Offset = "0x7F09330", VA = "0x187F0A930")]
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
					[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x104AC00", Offset = "0x1049600", VA = "0x18104AC00")]
				[DebuggerHidden]
				public ZKOMXEXJWBY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "7")]
				[DebuggerHidden]
				private void EAMCGMHRBWN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xA520B20", Offset = "0xA51F520", VA = "0x18A520B20", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xA520BA0", Offset = "0xA51F5A0", VA = "0x18A520BA0", Slot = "10")]
				[DebuggerHidden]
				private void VVBIBJOVTIU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xA520A80", Offset = "0xA51F480", VA = "0x18A520A80", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<XXSOLSHZRNI> GIKAWABIAOA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0xA520A80", Offset = "0xA51F480", VA = "0x18A520A80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5205C0", Offset = "0xA51EFC0", VA = "0x18A5205C0")]
			public XXSOLSHZRNI(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA520070", Offset = "0xA51EA70", VA = "0x18A520070")]
			public XXSOLSHZRNI Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA520010", Offset = "0xA51EA10", VA = "0x18A520010")]
			public XXSOLSHZRNI Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA520270", Offset = "0xA51EC70", VA = "0x18A520270")]
			public XXSOLSHZRNI CMYKQFYGUMU(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA520410", Offset = "0xA51EE10", VA = "0x18A520410")]
			internal static int DILLCZEIOVT(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA5203E0", Offset = "0xA51EDE0", VA = "0x18A5203E0", Slot = "4")]
			public int CompareTo(XXSOLSHZRNI other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xA5204A0", Offset = "0xA51EEA0", VA = "0x18A5204A0")]
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
				[Cpp2IlInjected.Address(RVA = "0xDA3550", Offset = "0xDA1F50", VA = "0x180DA3550", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA50E140", Offset = "0xA50CB40", VA = "0x18A50E140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1D3DC10", Offset = "0x1D3C610", VA = "0x181D3DC10")]
			[DebuggerHidden]
			public GVTGOFRMGNC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xA50DB90", Offset = "0xA50C590", VA = "0x18A50DB90", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xA50DCE0", Offset = "0xA50C6E0", VA = "0x18A50DCE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xA50E1E0", Offset = "0xA50CBE0", VA = "0x18A50E1E0")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA50E190", Offset = "0xA50CB90", VA = "0x18A50E190")]
			private void SMGDSKUDEQA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA50E230", Offset = "0xA50CC30", VA = "0x18A50E230", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xA50DAF0", Offset = "0xA50C4F0", VA = "0x18A50DAF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> ESKQBWROPFQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xA50DAF0", Offset = "0xA50C4F0", VA = "0x18A50DAF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA510CB0", Offset = "0xA50F6B0", VA = "0x18A510CB0")]
		public IYMRTTJUVFY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA510460", Offset = "0xA50EE60", VA = "0x18A510460")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA510A00", Offset = "0xA50F400", VA = "0x18A510A00")]
		public bool IAMPTCAGJIA(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA510B10", Offset = "0xA50F510", VA = "0x18A510B10")]
		public bool MMPFYCSKCAZ([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA510C20", Offset = "0xA50F620", VA = "0x18A510C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA510640", Offset = "0xA50F040", VA = "0x18A510640")]
		private static void BPQDDIHAUHZ(IEnumerable<XXSOLSHZRNI> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA5109A0", Offset = "0xA50F3A0", VA = "0x18A5109A0", Slot = "5")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA5109A0", Offset = "0xA50F3A0", VA = "0x18A5109A0", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA510920", Offset = "0xA50F320", VA = "0x18A510920")]
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
		[Cpp2IlInjected.Address(RVA = "0xA511360", Offset = "0xA50FD60", VA = "0x18A511360")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA511510", Offset = "0xA50FF10", VA = "0x18A511510")]
		public static ulong OJITFABCFAG(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class GZQFSCIPSMV
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA50E4D0", Offset = "0xA50CED0", VA = "0x18A50E4D0")]
		public static void WPSJPYLSEAG(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA50E3B0", Offset = "0xA50CDB0", VA = "0x18A50E3B0")]
		public static void LGDRHUIEQCS(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA50E270", Offset = "0xA50CC70", VA = "0x18A50E270")]
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
			[Cpp2IlInjected.Address(RVA = "0x5C8BEE0", Offset = "0x5C8A8E0", VA = "0x185C8BEE0", Slot = "3")]
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
				[Cpp2IlInjected.Address(RVA = "0xDA3550", Offset = "0xDA1F50", VA = "0x180DA3550", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x657B1D0", Offset = "0x6579BD0", VA = "0x18657B1D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B10", Offset = "0xD10510", VA = "0x180D11B10")]
			[DebuggerHidden]
			public NCLAYAIREWF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x728DF10", Offset = "0x728C910", VA = "0x18728DF10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA810", Offset = "0x4EF9210", VA = "0x184EFA810", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x775C490", Offset = "0x775AE90", VA = "0x18775C490")]
		public QEGFMNKZJQR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x775C580", Offset = "0x775AF80", VA = "0x18775C580")]
		public QEGFMNKZJQR(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x774BFD0", Offset = "0x774A9D0", VA = "0x18774BFD0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7754300", Offset = "0x7752D00", VA = "0x187754300")]
		private bool NTERVCVLIGR(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x774F190", Offset = "0x774DB90", VA = "0x18774F190")]
		public bool IAMPTCAGJIA([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7758F50", Offset = "0x7757950", VA = "0x187758F50")]
		private static ulong VWRTRYUQEUU([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7759700", Offset = "0x7758100", VA = "0x187759700")]
		private static ulong VWRTRYUQEUU([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x774CD20", Offset = "0x774B720", VA = "0x18774CD20")]
		private static int EFEFYFKCMQM(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x774CD50", Offset = "0x774B750", VA = "0x18774CD50", Slot = "4")]
		[IteratorStateMachine(typeof(QEGFMNKZJQR<>.NCLAYAIREWF))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x774CB40", Offset = "0x774B540", VA = "0x18774CB40", Slot = "5")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class OHFWEKRMFHW
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3D68AB0", Offset = "0x3D674B0", VA = "0x183D68AB0")]
		public static Func<a> THHRIBJNSYC<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3D68BA0", Offset = "0x3D675A0", VA = "0x183D68BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA50EF90", Offset = "0xA50D990", VA = "0x18A50EF90")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA50EFA0", Offset = "0xA50D9A0", VA = "0x18A50EFA0")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA50EE10", Offset = "0xA50D810", VA = "0x18A50EE10")]
		private static byte KCLNZMAQWZB(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA50B930", Offset = "0xA50A330", VA = "0x18A50B930")]
		private static byte QXCSQGDUEXJ(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA50E610", Offset = "0xA50D010", VA = "0x18A50E610")]
		public void HHMSAAQYDCT(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class WEIIJSEBQLZ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA51F160", Offset = "0xA51DB60", VA = "0x18A51F160")]
		public static bool AUWWKAOYQXH(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA51F090", Offset = "0xA51DA90", VA = "0x18A51F090")]
		public static bool AAVKJIDDMIA(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA51FEC0", Offset = "0xA51E8C0", VA = "0x18A51FEC0")]
		public static sbyte UKJUKOQRNZF([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA51FAA0", Offset = "0xA51E4A0", VA = "0x18A51FAA0")]
		public static short MOHCYIANYNQ([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA51F100", Offset = "0xA51DB00", VA = "0x18A51F100")]
		public static int ANZJRQNOGLO([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA51F840", Offset = "0xA51E240", VA = "0x18A51F840")]
		public static long IKMJNACMMHF([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA51F340", Offset = "0xA51DD40", VA = "0x18A51F340")]
		public static bool DSLHQQXHQYE(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA51FE60", Offset = "0xA51E860", VA = "0x18A51FE60")]
		public static byte TLNBTBVWCVY([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA51FF20", Offset = "0xA51E920", VA = "0x18A51FF20")]
		public static ushort WCXTYBUSHRB([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA51FA40", Offset = "0xA51E440", VA = "0x18A51FA40")]
		public static uint IXVSRVZDLGJ([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA51F4D0", Offset = "0xA51DED0", VA = "0x18A51F4D0")]
		public static ulong EAFVIMLFZGC([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA51F8F0", Offset = "0xA51E2F0", VA = "0x18A51F8F0")]
		public static bool ISSRTKZBYAD(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA51FC90", Offset = "0xA51E690", VA = "0x18A51FC90")]
		public static bool SMBDGBWFYHN(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA51F730", Offset = "0xA51E130", VA = "0x18A51F730")]
		public static bool IATXRDGCNXF(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA51FBF0", Offset = "0xA51E5F0", VA = "0x18A51FBF0")]
		public static bool OEATHFQJJDX(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA51FB00", Offset = "0xA51E500", VA = "0x18A51FB00")]
		public static float OBBNZURVPHK([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA51F580", Offset = "0xA51DF80", VA = "0x18A51F580")]
		public static bool EBIAXXAFVOZ(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA51F640", Offset = "0xA51E040", VA = "0x18A51F640")]
		public static double FFMYMLIAOHX([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA51F5E0", Offset = "0xA51DFE0", VA = "0x18A51F5E0")]
		public static bool ESMIPZDJXTO(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA50C3F0", Offset = "0xA50ADF0", VA = "0x18A50C3F0")]
		public static int IOPIKHWLIQR(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA50CBF0", Offset = "0xA50B5F0", VA = "0x18A50CBF0")]
		public static int NDKXXLGSVJQ(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA51F170", Offset = "0xA51DB70", VA = "0x18A51F170")]
		public static bool CWXSSJUZOIU([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class KWZMFNDNBDV
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA518300", Offset = "0xA516D00", VA = "0x18A518300")]
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
		[Cpp2IlInjected.Address(RVA = "0xA517B40", Offset = "0xA516540", VA = "0x18A517B40")]
		public static void FIEREXPMNZX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA517AD0", Offset = "0xA5164D0", VA = "0x18A517AD0")]
		public static void FHZKHQVPEOO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA517A60", Offset = "0xA516460", VA = "0x18A517A60")]
		public static void FHUDKKBRVDF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA5179F0", Offset = "0xA5163F0", VA = "0x18A5179F0")]
		public static void FHOWNDHULRW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA517C20", Offset = "0xA516620", VA = "0x18A517C20")]
		public static void FIZSTYRBZTH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA517BB0", Offset = "0xA5165B0", VA = "0x18A517BB0")]
		public static void FIULWRXEQHY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA5176C0", Offset = "0xA5160C0", VA = "0x18A5176C0")]
		public static void ECSFCOQUINQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA517730", Offset = "0xA516130", VA = "0x18A517730")]
		public static void ECXLZVKRRYZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA5175D0", Offset = "0xA515FD0", VA = "0x18A5175D0")]
		public static void ECHRIBCZPQY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA517640", Offset = "0xA516040", VA = "0x18A517640")]
		public static void ECMYFHWWZCH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA5174D0", Offset = "0xA515ED0", VA = "0x18A5174D0")]
		public static void EBXDNNPEWUG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA517550", Offset = "0xA515F50", VA = "0x18A517550")]
		public static void ECCKKUJCGFP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA5173D0", Offset = "0xA515DD0", VA = "0x18A5173D0")]
		public static void EBMPTABKDXO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA517450", Offset = "0xA515E50", VA = "0x18A517450")]
		public static void EBRWQGVHNIX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA5177A0", Offset = "0xA5161A0", VA = "0x18A5177A0")]
		public static void EEIIGQTZGAK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA517820", Offset = "0xA516220", VA = "0x18A517820")]
		public static void EENPDXNWPLT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA517F30", Offset = "0xA516930", VA = "0x18A517F30")]
		public static void XCBADWIRSVH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA517EB0", Offset = "0xA5168B0", VA = "0x18A517EB0")]
		public static void XBVTGPOUJJY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA517E30", Offset = "0xA516830", VA = "0x18A517E30")]
		public static void XBQMJIUWZYP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA517DB0", Offset = "0xA5167B0", VA = "0x18A517DB0")]
		public static void XBLFMCAZQNG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA518160", Offset = "0xA516B60", VA = "0x18A518160")]
		public static void XCWBSXKHEOR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA5180D0", Offset = "0xA516AD0", VA = "0x18A5180D0")]
		public static void XCQUVQQJVDI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA518040", Offset = "0xA516A40", VA = "0x18A518040")]
		public static void XCLNYJWMLRZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA517FB0", Offset = "0xA5169B0", VA = "0x18A517FB0")]
		public static void XCGHBDCPCGQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA518270", Offset = "0xA516C70", VA = "0x18A518270")]
		public static void XDRDHYLWQIB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA5181E0", Offset = "0xA516BE0", VA = "0x18A5181E0")]
		public static void XDLWKRRZGWS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA517C90", Offset = "0xA516690", VA = "0x18A517C90")]
		public static void RBHTSLZPOZG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA517D20", Offset = "0xA516720", VA = "0x18A517D20")]
		public static void RBNAPSTMYKP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA517980", Offset = "0xA516380", VA = "0x18A517980")]
		public static void FHEISPTZSVE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA517910", Offset = "0xA516310", VA = "0x18A517910")]
		public static void FGZBVJACJJV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA5178A0", Offset = "0xA5162A0", VA = "0x18A5178A0")]
		public static void FGTUYCGEZYM(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class QVASQKZMFJR
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA51D450", Offset = "0xA51BE50", VA = "0x18A51D450")]
		public static void FIZSTYRBZTH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA51D3E0", Offset = "0xA51BDE0", VA = "0x18A51D3E0")]
		public static void FIULWRXEQHY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA51D200", Offset = "0xA51BC00", VA = "0x18A51D200")]
		public static void ECSFCOQUINQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA51D270", Offset = "0xA51BC70", VA = "0x18A51D270")]
		public static void ECXLZVKRRYZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA51D120", Offset = "0xA51BB20", VA = "0x18A51D120")]
		public static void ECHRIBCZPQY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA51D190", Offset = "0xA51BB90", VA = "0x18A51D190")]
		public static void ECMYFHWWZCH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA51D040", Offset = "0xA51BA40", VA = "0x18A51D040")]
		public static void EBXDNNPEWUG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA51D0B0", Offset = "0xA51BAB0", VA = "0x18A51D0B0")]
		public static void ECCKKUJCGFP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA51CF50", Offset = "0xA51B950", VA = "0x18A51CF50")]
		public static void EBMPTABKDXO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA51CFC0", Offset = "0xA51B9C0", VA = "0x18A51CFC0")]
		public static void EBRWQGVHNIX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA51D2E0", Offset = "0xA51BCE0", VA = "0x18A51D2E0")]
		public static void EEIIGQTZGAK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA51D360", Offset = "0xA51BD60", VA = "0x18A51D360")]
		public static void EENPDXNWPLT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA51D740", Offset = "0xA51C140", VA = "0x18A51D740")]
		public static void XCBADWIRSVH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA51D6C0", Offset = "0xA51C0C0", VA = "0x18A51D6C0")]
		public static void XBVTGPOUJJY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA51D640", Offset = "0xA51C040", VA = "0x18A51D640")]
		public static void XBQMJIUWZYP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA51D5C0", Offset = "0xA51BFC0", VA = "0x18A51D5C0")]
		public static void XBLFMCAZQNG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA51D940", Offset = "0xA51C340", VA = "0x18A51D940")]
		public static void XCWBSXKHEOR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA51D8C0", Offset = "0xA51C2C0", VA = "0x18A51D8C0")]
		public static void XCQUVQQJVDI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA51D840", Offset = "0xA51C240", VA = "0x18A51D840")]
		public static void XCLNYJWMLRZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA51D7C0", Offset = "0xA51C1C0", VA = "0x18A51D7C0")]
		public static void XCGHBDCPCGQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA51DA40", Offset = "0xA51C440", VA = "0x18A51DA40")]
		public static void XDRDHYLWQIB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA51D9C0", Offset = "0xA51C3C0", VA = "0x18A51D9C0")]
		public static void XDLWKRRZGWS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA51D4C0", Offset = "0xA51BEC0", VA = "0x18A51D4C0")]
		public static void RBHTSLZPOZG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA51D540", Offset = "0xA51BF40", VA = "0x18A51D540")]
		public static void RBNAPSTMYKP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA517980", Offset = "0xA516380", VA = "0x18A517980")]
		public static void FHEISPTZSVE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA517910", Offset = "0xA516310", VA = "0x18A517910")]
		public static void FGZBVJACJJV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5178A0", Offset = "0xA5162A0", VA = "0x18A5178A0")]
		public static void FGTUYCGEZYM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA517B40", Offset = "0xA516540", VA = "0x18A517B40")]
		public static void FIEREXPMNZX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA517AD0", Offset = "0xA5164D0", VA = "0x18A517AD0")]
		public static void FHZKHQVPEOO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA517A60", Offset = "0xA516460", VA = "0x18A517A60")]
		public static void FHUDKKBRVDF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5179F0", Offset = "0xA5163F0", VA = "0x18A5179F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA531A30", Offset = "0xA530430", VA = "0x18A531A30")]
		public static void IFJICBPWHOL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5319A0", Offset = "0xA5303A0", VA = "0x18A5319A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B84290", Offset = "0x2B82C90", VA = "0x182B84290")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA523750", Offset = "0xA522150", VA = "0x18A523750")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA5236B0", Offset = "0xA5220B0", VA = "0x18A5236B0")]
		public static DiyFp MZFYADVTRLC(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA5236C0", Offset = "0xA5220C0", VA = "0x18A5236C0")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA5237F0", Offset = "0xA5221F0", VA = "0x18A5237F0")]
		public static DiyFp ZZVASTYZAUS(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA5237B0", Offset = "0xA5221B0", VA = "0x18A5237B0")]
		public void XMFVZFUJJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA523760", Offset = "0xA522160", VA = "0x18A523760")]
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
		[Cpp2IlInjected.Address(RVA = "0xDC3640", Offset = "0xDC2040", VA = "0x180DC3640")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA50BDD0", Offset = "0xA50A7D0", VA = "0x18A50BDD0")]
		public void FMYQPDLKDMC(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA5302D0", Offset = "0xA52ECD0", VA = "0x18A5302D0")]
		public void MKILRABTAHM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA530470", Offset = "0xA52EE70", VA = "0x18A530470")]
		public void YUKIWVODLGW(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5303D0", Offset = "0xA52EDD0", VA = "0x18A5303D0")]
		public void YUKIWVODLGW(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA530350", Offset = "0xA52ED50", VA = "0x18A530350")]
		public void QVSDQSYPCGA(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA5301D0", Offset = "0xA52EBD0", VA = "0x18A5301D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA536130", Offset = "0xA534B30", VA = "0x18A536130")]
		private static byte[] MTATZZZCYYE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA5378D0", Offset = "0xA5362D0", VA = "0x18A5378D0")]
		private static byte[] XDCWQTFDDLC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA535D30", Offset = "0xA534730", VA = "0x18A535D30")]
		public static int GMMDUBYWKNB(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA535E50", Offset = "0xA534850", VA = "0x18A535E50")]
		public static int GMMDUBYWKNB(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA535B40", Offset = "0xA534540", VA = "0x18A535B40")]
		private static bool CXXOZHWPTNP(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA5379B0", Offset = "0xA5363B0", VA = "0x18A5379B0")]
		private static void XGQTJOOQWMZ(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA536200", Offset = "0xA534C00", VA = "0x18A536200")]
		private static bool NRLIIUVQUFX(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA536D90", Offset = "0xA535790", VA = "0x18A536D90")]
		private static bool QDGUISUCKAF(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA535C30", Offset = "0xA534630", VA = "0x18A535C30")]
		private static bool FDELBKHRRHA(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA535F70", Offset = "0xA534970", VA = "0x18A535F70")]
		private static bool LBTZNWCEALJ(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA537210", Offset = "0xA535C10", VA = "0x18A537210")]
		private static bool RKJWFNAWIPI(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA536A00", Offset = "0xA535400", VA = "0x18A536A00")]
		private static void OPQPHFQMNJM(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5365C0", Offset = "0xA534FC0", VA = "0x18A5365C0")]
		private static void OLCPKTASKJI(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5376E0", Offset = "0xA5360E0", VA = "0x18A5376E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA523EB0", Offset = "0xA5228B0", VA = "0x18A523EB0")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA523E10", Offset = "0xA522810", VA = "0x18A523E10")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA523CC0", Offset = "0xA5226C0", VA = "0x18A523CC0")]
		public DiyFp WJEVNSZTNFC()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA523B90", Offset = "0xA522590", VA = "0x18A523B90")]
		public DiyFp REYEBRQGGEP()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xEF0460", Offset = "0xEEEE60", VA = "0x180EF0460")]
		public ulong STLDGSSFZOW()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA523A20", Offset = "0xA522420", VA = "0x18A523A20")]
		public double FXCAEOFTGOU()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA523D70", Offset = "0xA522770", VA = "0x18A523D70")]
		public double YROHQYZTOSA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA523C40", Offset = "0xA522640", VA = "0x18A523C40")]
		public int TFCCLGZEQXV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5239F0", Offset = "0xA5223F0", VA = "0x18A5239F0")]
		public ulong EHVJAYNUGPN()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA523D30", Offset = "0xA522730", VA = "0x18A523D30")]
		public bool XYQDNKMNWRW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA523890", Offset = "0xA522290", VA = "0x18A523890")]
		public bool BTXWEPGAEHJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA523B50", Offset = "0xA522550", VA = "0x18A523B50")]
		public bool OUGXDPTEOEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xA523C10", Offset = "0xA522610", VA = "0x18A523C10")]
		public bool SGBMKSIZUOQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA523D50", Offset = "0xA522750", VA = "0x18A523D50")]
		public int YEXRFOBGNOF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA5238B0", Offset = "0xA5222B0", VA = "0x18A5238B0")]
		public void DSZWKBHYRDB([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA523C70", Offset = "0xA522670", VA = "0x18A523C70")]
		public bool VJTOATMSSGZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x40AB2E0", Offset = "0x40A9CE0", VA = "0x1840AB2E0")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA523B30", Offset = "0xA522530", VA = "0x18A523B30")]
		public static int OPUVWTCHXNC(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA523B80", Offset = "0xA522580", VA = "0x18A523B80")]
		public static double QCJPIKBMIFG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA523AA0", Offset = "0xA5224A0", VA = "0x18A523AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x189E8E0", Offset = "0x189D2E0", VA = "0x18189E8E0")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA530160", Offset = "0xA52EB60", VA = "0x18A530160")]
		public DiyFp WJEVNSZTNFC()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xF7A900", Offset = "0xF79300", VA = "0x180F7A900")]
		public uint AROGGEKJCXH()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA530100", Offset = "0xA52EB00", VA = "0x18A530100")]
		public int TFCCLGZEQXV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA5300E0", Offset = "0xA52EAE0", VA = "0x18A5300E0")]
		public uint EHVJAYNUGPN()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA5301C0", Offset = "0xA52EBC0", VA = "0x18A5301C0")]
		public bool XYQDNKMNWRW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA52FFB0", Offset = "0xA52E9B0", VA = "0x18A52FFB0")]
		public void DSZWKBHYRDB([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA530120", Offset = "0xA52EB20", VA = "0x18A530120")]
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
		[Cpp2IlInjected.Address(RVA = "0xA523210", Offset = "0xA521C10", VA = "0x18A523210")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5305C0", Offset = "0xA52EFC0", VA = "0x18A5305C0")]
		public static void RDGYUTDXEAR(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5304F0", Offset = "0xA52EEF0", VA = "0x18A5304F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5357F0", Offset = "0xA5341F0", VA = "0x18A5357F0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB8C0", Offset = "0x4EEA2C0", VA = "0x184EEB8C0")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2DB77F0", Offset = "0x2DB61F0", VA = "0x182DB77F0")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA535790", Offset = "0xA534190", VA = "0x18A535790")]
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
		[Cpp2IlInjected.Address(RVA = "0xA521AA0", Offset = "0xA5204A0", VA = "0x18A521AA0")]
		private static byte[] FRRRPHKWFTB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA5218E0", Offset = "0xA5202E0", VA = "0x18A5218E0")]
		private static Vector ETEMOTJKTSR(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA5219C0", Offset = "0xA5203C0", VA = "0x18A5219C0")]
		private static Vector EWOMPLRZRRB(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA522320", Offset = "0xA520D20", VA = "0x18A522320")]
		private static void PCDFSAJNIRM(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA522E70", Offset = "0xA521870", VA = "0x18A522E70")]
		private static void ZSCSVNHQUDR(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA522DE0", Offset = "0xA5217E0", VA = "0x18A522DE0")]
		private static ulong XLMPKCQWXMW(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA5221E0", Offset = "0xA520BE0", VA = "0x18A5221E0")]
		private static void NKDDZFLLJZW(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA521D10", Offset = "0xA520710", VA = "0x18A521D10")]
		private static bool KYLPPURVWPV(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA521B80", Offset = "0xA520580", VA = "0x18A521B80")]
		private static DiyFp GSGGKBOGLDW(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA5227A0", Offset = "0xA5211A0", VA = "0x18A5227A0")]
		private static bool TKMTRHPOAJA(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA5220C0", Offset = "0xA520AC0", VA = "0x18A5220C0")]
		private static bool LDIGLLXAEPE(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA522680", Offset = "0xA521080", VA = "0x18A522680")]
		public static double? RPFOAZTPDJQ(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA5223B0", Offset = "0xA520DB0", VA = "0x18A5223B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52C050", Offset = "0xA52AA50", VA = "0x18A52C050")]
		private static byte[] CYKYGZUZNIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA52C1A0", Offset = "0xA52ABA0", VA = "0x18A52C1A0")]
		public static bool EBIAXXAFVOZ(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA52C2E0", Offset = "0xA52ACE0", VA = "0x18A52C2E0")]
		public static bool ESMIPZDJXTO(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA52D7C0", Offset = "0xA52C1C0", VA = "0x18A52D7C0")]
		private static bool YVTSRTSVTRL(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA52C520", Offset = "0xA52AF20", VA = "0x18A52C520")]
		private static bool UYCXLXHBXAI(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA52C420", Offset = "0xA52AE20", VA = "0x18A52C420")]
		private static bool EYPZEFWSWHD(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA52C130", Offset = "0xA52AB30", VA = "0x18A52C130")]
		private static bool DAVPAUNCYEH(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA52C500", Offset = "0xA52AF00", VA = "0x18A52C500")]
		private static double FOFFAKWFZIS(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA52C7E0", Offset = "0xA52B1E0", VA = "0x18A52C7E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x196F210", Offset = "0x196DC10", VA = "0x18196F210")]
		public FWYZWVLLKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xD11B10", Offset = "0xD10510", VA = "0x180D11B10")]
		public FWYZWVLLKFE(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6401AA0", Offset = "0x64004A0", VA = "0x186401AA0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6401350", Offset = "0x63FFD50", VA = "0x186401350", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x706F080", Offset = "0x706DA80", VA = "0x18706F080", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x706EC10", Offset = "0x706D610", VA = "0x18706EC10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x196F210", Offset = "0x196DC10", VA = "0x18196F210")]
		public MNYDQEFCKDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xD11B10", Offset = "0xD10510", VA = "0x180D11B10")]
		public MNYDQEFCKDH(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7081C20", Offset = "0x7080620", VA = "0x187081C20", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x707DB00", Offset = "0x707C500", VA = "0x18707DB00", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class EARDSEGKBIT<a, b, c, d> : TIJSSGKTKZA<d>, DUMZRUHETBP where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x5C5C960", Offset = "0x5C5B360", VA = "0x185C5C960", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x5C5B310", Offset = "0x5C59D10", VA = "0x185C5B310", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		protected EARDSEGKBIT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class EABJAJYRZAS<a, b, c> : EARDSEGKBIT<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5C5B2C0", Offset = "0x5C59CC0", VA = "0x185C5B2C0", Slot = "6")]
		protected override IEnumerator<a> JIYABPAHYXR(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		protected EABJAJYRZAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class EAGPXQSPIMB<a, b> : EABJAJYRZAS<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5F0", Offset = "0xD6DFF0", VA = "0x180D6F5F0", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class AAFWAGEPUZN<a, b> : EAGPXQSPIMB<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7346E30", Offset = "0x7345830", VA = "0x187346E30", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7346CC0", Offset = "0x73456C0", VA = "0x187346CC0", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class YYUDKLSTCRU<a> : EARDSEGKBIT<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x518ED00", Offset = "0x518D700", VA = "0x18518ED00", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5F0", Offset = "0xD6DFF0", VA = "0x180D6F5F0", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x518EDF0", Offset = "0x518D7F0", VA = "0x18518EDF0", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x518EE50", Offset = "0x518D850", VA = "0x18518EE50", Slot = "6")]
		protected override LinkedList<a>.Enumerator JIYABPAHYXR(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class JKRLEPTANSH<a> : EARDSEGKBIT<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x5182C00", Offset = "0x5181600", VA = "0x185182C00", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x5182CF0", Offset = "0x51816F0", VA = "0x185182CF0", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x518F090", Offset = "0x518DA90", VA = "0x18518F090", Slot = "6")]
		protected override Queue<a>.Enumerator JIYABPAHYXR(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5F0", Offset = "0xD6DFF0", VA = "0x180D6F5F0", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class UNWXPIQLRLD<a> : EARDSEGKBIT<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x518D100", Offset = "0x518BB00", VA = "0x18518D100", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x518D3D0", Offset = "0x518BDD0", VA = "0x18518D3D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7F06810", Offset = "0x7F05210", VA = "0x187F06810", Slot = "6")]
		protected override Stack<a>.Enumerator JIYABPAHYXR(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7F06690", Offset = "0x7F05090", VA = "0x187F06690", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class YZBFLKURVGF<a> : EARDSEGKBIT<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x518EFF0", Offset = "0x518D9F0", VA = "0x18518EFF0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5F0", Offset = "0xD6DFF0", VA = "0x180D6F5F0", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x518F030", Offset = "0x518DA30", VA = "0x18518F030", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x518F140", Offset = "0x518DB40", VA = "0x18518F140", Slot = "6")]
		protected override HashSet<a>.Enumerator JIYABPAHYXR(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x518F190", Offset = "0x518DB90", VA = "0x18518F190")]
		public YZBFLKURVGF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class IHLNSBNZXIL<a> : EABJAJYRZAS<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x518D100", Offset = "0x518BB00", VA = "0x18518D100", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x66BAB40", Offset = "0x66B9540", VA = "0x1866BAB40", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x66BABE0", Offset = "0x66B95E0", VA = "0x1866BABE0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class CJHUSLXHYVO<a> : EABJAJYRZAS<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x5182C00", Offset = "0x5181600", VA = "0x185182C00", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5182CF0", Offset = "0x51816F0", VA = "0x185182CF0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5F0", Offset = "0xD6DFF0", VA = "0x180D6F5F0", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class JYGHAUEPIGM<a> : EABJAJYRZAS<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5182C00", Offset = "0x5181600", VA = "0x185182C00", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5182CF0", Offset = "0x51816F0", VA = "0x185182CF0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5F0", Offset = "0xD6DFF0", VA = "0x180D6F5F0", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class DEZBHPGBARU<a> : EABJAJYRZAS<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x518D0A0", Offset = "0x518BAA0", VA = "0x18518D0A0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x518D3D0", Offset = "0x518BDD0", VA = "0x18518D3D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x54D38C0", Offset = "0x54D22C0", VA = "0x1854D38C0", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x54D38E0", Offset = "0x54D22E0", VA = "0x1854D38E0")]
		public DEZBHPGBARU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class XUPFXUWGTOC<a, b> : TIJSSGKTKZA<IGrouping<a, b>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x50CFA40", Offset = "0x50CE440", VA = "0x1850CFA40", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x50CF6D0", Offset = "0x50CE0D0", VA = "0x1850CF6D0", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class YQBSKIXNUOH<a, b> : TIJSSGKTKZA<ILookup<a, b>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x518BD00", Offset = "0x518A700", VA = "0x18518BD00", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x518B990", Offset = "0x518A390", VA = "0x18518B990", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4EE9780", Offset = "0x4EE8180", VA = "0x184EE9780", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x735CA90", Offset = "0x735B490", VA = "0x18735CA90")]
		public AUPVPZQSDXB(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x735CA10", Offset = "0x735B410", VA = "0x18735CA10", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6782730", Offset = "0x6781130", VA = "0x186782730", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x742C1A0", Offset = "0x742ABA0", VA = "0x18742C1A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xD13870", Offset = "0xD12270", VA = "0x180D13870")]
		public OWWDXDXMCAM(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x742BFF0", Offset = "0x742A9F0", VA = "0x18742BFF0", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x742C0F0", Offset = "0x742AAF0", VA = "0x18742C0F0", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x742C0F0", Offset = "0x742AAF0", VA = "0x18742C0F0", Slot = "7")]
		private IEnumerator DKFMUHWUXGJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class DPMLDPNYVTX<a> : TIJSSGKTKZA<a>, DUMZRUHETBP where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x54DE6E0", Offset = "0x54DD0E0", VA = "0x1854DE6E0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x54DE4C0", Offset = "0x54DCEC0", VA = "0x1854DE4C0", Slot = "5")]
		public a Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53B080", Offset = "0xA539A80", VA = "0x18A53B080", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA53AE70", Offset = "0xA539870", VA = "0x18A53AE70", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5242C0", Offset = "0xA522CC0", VA = "0x18A5242C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA5240B0", Offset = "0xA522AB0", VA = "0x18A5240B0", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA539B80", Offset = "0xA538580", VA = "0x18A539B80", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA539970", Offset = "0xA538370", VA = "0x18A539970", Slot = "5")]
		public IList Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public YBHNNCIPBXN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class SXLDSNFVIUG<a> : EAGPXQSPIMB<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5182C00", Offset = "0x5181600", VA = "0x185182C00", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x65E96B0", Offset = "0x65E80B0", VA = "0x1865E96B0", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class HVTPSBPWQSI<a> : EABJAJYRZAS<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x5182C00", Offset = "0x5181600", VA = "0x185182C00", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x65E96B0", Offset = "0x65E80B0", VA = "0x1865E96B0", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x65E9640", Offset = "0x65E8040", VA = "0x1865E9640", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class YVVFDGVTFXM<a> : EABJAJYRZAS<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x518D1E0", Offset = "0x518BBE0", VA = "0x18518D1E0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x518D3D0", Offset = "0x518BDD0", VA = "0x18518D3D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x518D290", Offset = "0x518BC90", VA = "0x18518D290", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x518D410", Offset = "0x518BE10", VA = "0x18518D410")]
		public YVVFDGVTFXM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class RGCZRTKJIHQ<a> : EABJAJYRZAS<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x518D1E0", Offset = "0x518BBE0", VA = "0x18518D1E0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x518D3D0", Offset = "0x518BDD0", VA = "0x18518D3D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x54D38C0", Offset = "0x54D22C0", VA = "0x1854D38C0", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x54D38E0", Offset = "0x54D22E0", VA = "0x1854D38E0")]
		public RGCZRTKJIHQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class CKPYOQEHIAK<a> : EABJAJYRZAS<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x518EF00", Offset = "0x518D900", VA = "0x18518EF00", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5F0", Offset = "0xD6DFF0", VA = "0x180D6F5F0", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x518EDF0", Offset = "0x518D7F0", VA = "0x18518EDF0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class DWXYHWYUXAS<a> : EAGPXQSPIMB<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5182C00", Offset = "0x5181600", VA = "0x185182C00", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5182CF0", Offset = "0x51816F0", VA = "0x185182CF0", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class YHEISEUMOZP<a> : EAGPXQSPIMB<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5182C00", Offset = "0x5181600", VA = "0x185182C00", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5182CF0", Offset = "0x51816F0", VA = "0x185182CF0", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class GTIKNRDAAVW<a> : EABJAJYRZAS<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x518D100", Offset = "0x518BB00", VA = "0x18518D100", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x518D3D0", Offset = "0x518BDD0", VA = "0x18518D3D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6507C40", Offset = "0x6506640", VA = "0x186507C40", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0xA537CD0", Offset = "0xA5366D0", VA = "0x18A537CD0")]
		public static DateTime LNMYXXNOISJ(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA538460", Offset = "0xA536E60", VA = "0x18A538460")]
		public static bool UTKOQXLQDME(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA537FA0", Offset = "0xA5369A0", VA = "0x18A537FA0")]
		public static bool SEJFRTYSXSM(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA537D90", Offset = "0xA536790", VA = "0x18A537D90")]
		public static bool SEJFRTYSXSM(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA538230", Offset = "0xA536C30", VA = "0x18A538230")]
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
		[Cpp2IlInjected.Address(RVA = "0xA526840", Offset = "0xA525240", VA = "0x18A526840", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA5266C0", Offset = "0xA5250C0", VA = "0x18A5266C0", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA5262C0", Offset = "0xA524CC0", VA = "0x18A5262C0")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52DFD0", Offset = "0xA52C9D0", VA = "0x18A52DFD0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA52DF60", Offset = "0xA52C960", VA = "0x18A52DF60", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA52DB80", Offset = "0xA52C580", VA = "0x18A52DB80")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53A400", Offset = "0xA538E00", VA = "0x18A53A400", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA539F90", Offset = "0xA538990", VA = "0x18A539F90", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA53A010", Offset = "0xA538A10", VA = "0x18A53A010")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public ZCOZMVBHVOB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class QFVKEBWACSI<a, b, c, d, e> : TIJSSGKTKZA<e>, DUMZRUHETBP where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7773AD0", Offset = "0x77724D0", VA = "0x187773AD0", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x776DF70", Offset = "0x776C970", VA = "0x18776DF70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		protected QFVKEBWACSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class QGARBIPXMDR<a, b, c, d> : QFVKEBWACSI<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5C5B2C0", Offset = "0x5C59CC0", VA = "0x185C5B2C0", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> JIYABPAHYXR(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		protected QGARBIPXMDR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class QFKWJOIFJVQ<a, b, c> : QGARBIPXMDR<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5F0", Offset = "0xD6DFF0", VA = "0x180D6F5F0", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class RXARDRXNOKE<a, b> : QFVKEBWACSI<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7837620", Offset = "0x7836020", VA = "0x187837620", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5F0", Offset = "0xD6DFF0", VA = "0x180D6F5F0", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7837780", Offset = "0x7836180", VA = "0x187837780", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x78378A0", Offset = "0x78362A0", VA = "0x1878378A0", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator JIYABPAHYXR(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6AAEF50", Offset = "0x6AAD950", VA = "0x186AAEF50")]
		public RXARDRXNOKE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class GAMRXHDMWBO<a, b, c> : QFKWJOIFJVQ<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x64C0F30", Offset = "0x64BF930", VA = "0x1864C0F30", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x64C1130", Offset = "0x64BFB30", VA = "0x1864C1130", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class JAXBXCWPSNP<a, b> : QGARBIPXMDR<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x63FD5E0", Offset = "0x63FBFE0", VA = "0x1863FD5E0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x518CDF0", Offset = "0x518B7F0", VA = "0x18518CDF0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5F0", Offset = "0xD6DFF0", VA = "0x180D6F5F0", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class KLQOVHFISFV<a, b> : QFKWJOIFJVQ<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x63FD5E0", Offset = "0x63FBFE0", VA = "0x1863FD5E0", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x518CDF0", Offset = "0x518B7F0", VA = "0x18518CDF0", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class URTNZNUXJTR<a, b> : QFVKEBWACSI<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x63FD5E0", Offset = "0x63FBFE0", VA = "0x1863FD5E0", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5F0", Offset = "0xD6DFF0", VA = "0x180D6F5F0", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x518CDF0", Offset = "0x518B7F0", VA = "0x18518CDF0", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F08CA0", Offset = "0x7F076A0", VA = "0x187F08CA0", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator JIYABPAHYXR(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class PYCTTWHUSYW<a, b> : QGARBIPXMDR<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x63FD5E0", Offset = "0x63FBFE0", VA = "0x1863FD5E0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7534E90", Offset = "0x7533890", VA = "0x187534E90", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7534F00", Offset = "0x7533900", VA = "0x187534F00", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class FOWMLYOQQZN<a, b> : QGARBIPXMDR<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x63FD5A0", Offset = "0x63FBFA0", VA = "0x1863FD5A0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5F0", Offset = "0xD6DFF0", VA = "0x180D6F5F0", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x63FD760", Offset = "0x63FC160", VA = "0x1863FD760", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x518F190", Offset = "0x518DB90", VA = "0x18518F190")]
		public FOWMLYOQQZN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class YSWNZCUWTMD<a, b> : QFKWJOIFJVQ<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x518CC60", Offset = "0x518B660", VA = "0x18518CC60", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x518CDF0", Offset = "0x518B7F0", VA = "0x18518CDF0", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class VODHDSACNYZ<a> : TIJSSGKTKZA<a>, DUMZRUHETBP where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x802E750", Offset = "0x802D150", VA = "0x18802E750", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x802E510", Offset = "0x802CF10", VA = "0x18802E510", Slot = "5")]
		public a Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52B080", Offset = "0xA529A80", VA = "0x18A52B080", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA52AEA0", Offset = "0xA5298A0", VA = "0x18A52AEA0", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public PQQPRLBWWXB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class SSEFMMDATPX
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA52EC70", Offset = "0xA52D670", VA = "0x18A52EC70")]
		public static object FIHZAWKSEGV(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA52F450", Offset = "0xA52DE50", VA = "0x18A52F450")]
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
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public ZBRDALKAYGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x5192B40", Offset = "0x5191540", VA = "0x185192B40")]
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
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public ZBWJXSDYHRX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x5192D20", Offset = "0x5191720", VA = "0x185192D20")]
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
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public ZBGPFXWGFJW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x51902F0", Offset = "0x518ECF0", VA = "0x1851902F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public ZBLWDEQDOVF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x5190FA0", Offset = "0x518F9A0", VA = "0x185190FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6796D30", Offset = "0x6795730", VA = "0x186796D30")]
		static JNNNEYSAILQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6799F90", Offset = "0x6798990", VA = "0x186799F90")]
		public JNNNEYSAILQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x678D600", Offset = "0x678C000", VA = "0x18678D600", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x678C4B0", Offset = "0x678AEB0", VA = "0x18678C4B0", Slot = "5")]
		public a Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x678D220", Offset = "0x678BC20", VA = "0x18678D220", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, a b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x678D5A0", Offset = "0x678BFA0", VA = "0x18678D5A0", Slot = "7")]
		public a QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class KYDYKYKBTHY<a> : TIJSSGKTKZA<a[,]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x693E820", Offset = "0x693D220", VA = "0x18693E820", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x693E460", Offset = "0x693CE60", VA = "0x18693E460", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public KYDYKYKBTHY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class KDPKKTGEXRK<a> : TIJSSGKTKZA<a[,,]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x68F55A0", Offset = "0x68F3FA0", VA = "0x1868F55A0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x68F50A0", Offset = "0x68F3AA0", VA = "0x1868F50A0", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public KDPKKTGEXRK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class WQWSYHSIUQE<a> : TIJSSGKTKZA<a[,,,]>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x872AB00", Offset = "0x8729500", VA = "0x18872AB00", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x872A4C0", Offset = "0x8728EC0", VA = "0x18872A4C0", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public WQWSYHSIUQE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class SWNZCGJIDCO<a> : TIJSSGKTKZA<a?>, DUMZRUHETBP where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7AD63D0", Offset = "0x7AD4DD0", VA = "0x187AD63D0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5B60", Offset = "0x7AD4560", VA = "0x187AD5B60", Slot = "5")]
		public a? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xD13870", Offset = "0xD12270", VA = "0x180D13870")]
		public OAZEZNCIXOY(TIJSSGKTKZA<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7405550", Offset = "0x7403F50", VA = "0x187405550", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7404650", Offset = "0x7403050", VA = "0x187404650", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA533610", Offset = "0xA532010", VA = "0x18A533610", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA533470", Offset = "0xA531E70", VA = "0x18A533470", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA533480", Offset = "0xA531E80", VA = "0x18A533480", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, sbyte b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA533590", Offset = "0xA531F90", VA = "0x18A533590", Slot = "7")]
		public sbyte QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA524A10", Offset = "0xA523410", VA = "0x18A524A10", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA524770", Offset = "0xA523170", VA = "0x18A524770", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA5247E0", Offset = "0xA5231E0", VA = "0x18A5247E0", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, sbyte? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA524940", Offset = "0xA523340", VA = "0x18A524940", Slot = "7")]
		public sbyte? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA533850", Offset = "0xA532250", VA = "0x18A533850", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA533710", Offset = "0xA532110", VA = "0x18A533710", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5233C0", Offset = "0xA521DC0", VA = "0x18A5233C0", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA523220", Offset = "0xA521C20", VA = "0x18A523220", Slot = "5")]
		public short Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA523230", Offset = "0xA521C30", VA = "0x18A523230", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, short b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA523340", Offset = "0xA521D40", VA = "0x18A523340", Slot = "7")]
		public short QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA525B10", Offset = "0xA524510", VA = "0x18A525B10", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA525870", Offset = "0xA524270", VA = "0x18A525870", Slot = "5")]
		public short? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA5258E0", Offset = "0xA5242E0", VA = "0x18A5258E0", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, short? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA525A40", Offset = "0xA524440", VA = "0x18A525A40", Slot = "7")]
		public short? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5396D0", Offset = "0xA5380D0", VA = "0x18A5396D0", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA539590", Offset = "0xA537F90", VA = "0x18A539590", Slot = "5")]
		public short[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA524D10", Offset = "0xA523710", VA = "0x18A524D10", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA524B70", Offset = "0xA523570", VA = "0x18A524B70", Slot = "5")]
		public int Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA524B80", Offset = "0xA523580", VA = "0x18A524B80", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, int b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA524C90", Offset = "0xA523690", VA = "0x18A524C90", Slot = "7")]
		public int QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52AA10", Offset = "0xA529410", VA = "0x18A52AA10", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA52A770", Offset = "0xA529170", VA = "0x18A52A770", Slot = "5")]
		public int? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA52A7E0", Offset = "0xA5291E0", VA = "0x18A52A7E0", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, int? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA52A940", Offset = "0xA529340", VA = "0x18A52A940", Slot = "7")]
		public int? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA528150", Offset = "0xA526B50", VA = "0x18A528150", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA528010", Offset = "0xA526A10", VA = "0x18A528010", Slot = "5")]
		public int[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5235E0", Offset = "0xA521FE0", VA = "0x18A5235E0", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA5234C0", Offset = "0xA521EC0", VA = "0x18A5234C0", Slot = "5")]
		public long Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA5234D0", Offset = "0xA521ED0", VA = "0x18A5234D0", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, long b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA5235A0", Offset = "0xA521FA0", VA = "0x18A5235A0", Slot = "7")]
		public long QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52BF20", Offset = "0xA52A920", VA = "0x18A52BF20", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA52BCB0", Offset = "0xA52A6B0", VA = "0x18A52BCB0", Slot = "5")]
		public long? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA52BD40", Offset = "0xA52A740", VA = "0x18A52BD40", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, long? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA52BE70", Offset = "0xA52A870", VA = "0x18A52BE70", Slot = "7")]
		public long? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA528530", Offset = "0xA526F30", VA = "0x18A528530", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA5283F0", Offset = "0xA526DF0", VA = "0x18A5283F0", Slot = "5")]
		public long[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA529BB0", Offset = "0xA5285B0", VA = "0x18A529BB0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA529A10", Offset = "0xA528410", VA = "0x18A529A10", Slot = "5")]
		public byte Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA529A20", Offset = "0xA528420", VA = "0x18A529A20", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, byte b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA529B30", Offset = "0xA528530", VA = "0x18A529B30", Slot = "7")]
		public byte QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA525580", Offset = "0xA523F80", VA = "0x18A525580", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA5252E0", Offset = "0xA523CE0", VA = "0x18A5252E0", Slot = "5")]
		public byte? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA525350", Offset = "0xA523D50", VA = "0x18A525350", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, byte? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA5254B0", Offset = "0xA523EB0", VA = "0x18A5254B0", Slot = "7")]
		public byte? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA534DF0", Offset = "0xA5337F0", VA = "0x18A534DF0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA534C50", Offset = "0xA533650", VA = "0x18A534C50", Slot = "5")]
		public ushort Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA534C60", Offset = "0xA533660", VA = "0x18A534C60", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, ushort b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA534D70", Offset = "0xA533770", VA = "0x18A534D70", Slot = "7")]
		public ushort QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52BB50", Offset = "0xA52A550", VA = "0x18A52BB50", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA52B8B0", Offset = "0xA52A2B0", VA = "0x18A52B8B0", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA52B920", Offset = "0xA52A320", VA = "0x18A52B920", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, ushort? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA52BA80", Offset = "0xA52A480", VA = "0x18A52BA80", Slot = "7")]
		public ushort? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA529DF0", Offset = "0xA5287F0", VA = "0x18A529DF0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA529CB0", Offset = "0xA5286B0", VA = "0x18A529CB0", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA529270", Offset = "0xA527C70", VA = "0x18A529270", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA5290D0", Offset = "0xA527AD0", VA = "0x18A5290D0", Slot = "5")]
		public uint Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA5290E0", Offset = "0xA527AE0", VA = "0x18A5290E0", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, uint b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA5291F0", Offset = "0xA527BF0", VA = "0x18A5291F0", Slot = "7")]
		public uint QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA521480", Offset = "0xA51FE80", VA = "0x18A521480", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA5211E0", Offset = "0xA51FBE0", VA = "0x18A5211E0", Slot = "5")]
		public uint? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA521250", Offset = "0xA51FC50", VA = "0x18A521250", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, uint? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA5213B0", Offset = "0xA51FDB0", VA = "0x18A5213B0", Slot = "7")]
		public uint? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA528E30", Offset = "0xA527830", VA = "0x18A528E30", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA528CF0", Offset = "0xA5276F0", VA = "0x18A528CF0", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA523FE0", Offset = "0xA5229E0", VA = "0x18A523FE0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA523EC0", Offset = "0xA5228C0", VA = "0x18A523EC0", Slot = "5")]
		public ulong Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA523ED0", Offset = "0xA5228D0", VA = "0x18A523ED0", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, ulong b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xA523FA0", Offset = "0xA5229A0", VA = "0x18A523FA0", Slot = "7")]
		public ulong QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52A640", Offset = "0xA529040", VA = "0x18A52A640", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA52A3D0", Offset = "0xA528DD0", VA = "0x18A52A3D0", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA52A460", Offset = "0xA528E60", VA = "0x18A52A460", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, ulong? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA52A590", Offset = "0xA528F90", VA = "0x18A52A590", Slot = "7")]
		public ulong? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA531770", Offset = "0xA530170", VA = "0x18A531770", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA531630", Offset = "0xA530030", VA = "0x18A531630", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5356C0", Offset = "0xA5340C0", VA = "0x18A5356C0", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA5355A0", Offset = "0xA533FA0", VA = "0x18A5355A0", Slot = "5")]
		public float Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA5355B0", Offset = "0xA533FB0", VA = "0x18A5355B0", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, float b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA535680", Offset = "0xA534080", VA = "0x18A535680", Slot = "7")]
		public float QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53AD40", Offset = "0xA539740", VA = "0x18A53AD40", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA53AB10", Offset = "0xA539510", VA = "0x18A53AB10", Slot = "5")]
		public float? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA53AB80", Offset = "0xA539580", VA = "0x18A53AB80", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, float? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA53ACA0", Offset = "0xA5396A0", VA = "0x18A53ACA0", Slot = "7")]
		public float? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA527920", Offset = "0xA526320", VA = "0x18A527920", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA5277E0", Offset = "0xA5261E0", VA = "0x18A5277E0", Slot = "5")]
		public float[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA528880", Offset = "0xA527280", VA = "0x18A528880", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA528760", Offset = "0xA527160", VA = "0x18A528760", Slot = "5")]
		public double Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA528770", Offset = "0xA527170", VA = "0x18A528770", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, double b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA528840", Offset = "0xA527240", VA = "0x18A528840", Slot = "7")]
		public double QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5344F0", Offset = "0xA532EF0", VA = "0x18A5344F0", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA534280", Offset = "0xA532C80", VA = "0x18A534280", Slot = "5")]
		public double? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA534310", Offset = "0xA532D10", VA = "0x18A534310", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, double? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA534440", Offset = "0xA532E40", VA = "0x18A534440", Slot = "7")]
		public double? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA535030", Offset = "0xA533A30", VA = "0x18A535030", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA534EF0", Offset = "0xA5338F0", VA = "0x18A534EF0", Slot = "5")]
		public double[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5354D0", Offset = "0xA533ED0", VA = "0x18A5354D0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA5353B0", Offset = "0xA533DB0", VA = "0x18A5353B0", Slot = "5")]
		public bool Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA5353C0", Offset = "0xA533DC0", VA = "0x18A5353C0", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, bool b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA535490", Offset = "0xA533E90", VA = "0x18A535490", Slot = "7")]
		public bool QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA527EE0", Offset = "0xA5268E0", VA = "0x18A527EE0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA527CB0", Offset = "0xA5266B0", VA = "0x18A527CB0", Slot = "5")]
		public bool? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xA527D20", Offset = "0xA526720", VA = "0x18A527D20", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, bool? b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA527E40", Offset = "0xA526840", VA = "0x18A527E40", Slot = "7")]
		public bool? QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA524F50", Offset = "0xA523950", VA = "0x18A524F50", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA524E10", Offset = "0xA523810", VA = "0x18A524E10", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52EB40", Offset = "0xA52D540", VA = "0x18A52EB40", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA52EAD0", Offset = "0xA52D4D0", VA = "0x18A52EAD0", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA529440", Offset = "0xA527E40", VA = "0x18A529440", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA529370", Offset = "0xA527D70", VA = "0x18A529370", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53B470", Offset = "0xA539E70", VA = "0x18A53B470", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA53B400", Offset = "0xA539E00", VA = "0x18A53B400", Slot = "5")]
		public string Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA53B410", Offset = "0xA539E10", VA = "0x18A53B410", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, string b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA53B400", Offset = "0xA539E00", VA = "0x18A53B400", Slot = "7")]
		public string QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5275B0", Offset = "0xA525FB0", VA = "0x18A5275B0", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA527460", Offset = "0xA525E60", VA = "0x18A527460", Slot = "5")]
		public string[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52FC60", Offset = "0xA52E660", VA = "0x18A52FC60", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA52FC30", Offset = "0xA52E630", VA = "0x18A52FC30", Slot = "5")]
		public char Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA526150", Offset = "0xA524B50", VA = "0x18A526150", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA526090", Offset = "0xA524A90", VA = "0x18A526090", Slot = "5")]
		public char? Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5347B0", Offset = "0xA5331B0", VA = "0x18A5347B0", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA534620", Offset = "0xA533020", VA = "0x18A534620", Slot = "5")]
		public char[] Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA529830", Offset = "0xA528230", VA = "0x18A529830", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5295E0", Offset = "0xA527FE0", VA = "0x18A5295E0", Slot = "5")]
		public Guid Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA529640", Offset = "0xA528040", VA = "0x18A529640", Slot = "6")]
		public void JMNZTZEYTGV(JsonWriter a, Guid b, FSNHROPLCPN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5297C0", Offset = "0xA5281C0", VA = "0x18A5297C0", Slot = "7")]
		public Guid QIBJTXSVWLX(JsonReader a, FSNHROPLCPN b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0x889AD80", Offset = "0x8899780", VA = "0x18889AD80")]
		public IBIHLEMQDNR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xFE6B60", Offset = "0xFE5560", VA = "0x180FE6B60")]
		public IBIHLEMQDNR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA525E40", Offset = "0xA524840", VA = "0x18A525E40", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA525C70", Offset = "0xA524670", VA = "0x18A525C70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52B760", Offset = "0xA52A160", VA = "0x18A52B760", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA52B6E0", Offset = "0xA52A0E0", VA = "0x18A52B6E0", Slot = "5")]
		public Uri Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA528BC0", Offset = "0xA5275C0", VA = "0x18A528BC0", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA528B40", Offset = "0xA527540", VA = "0x18A528B40", Slot = "5")]
		public Version Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public LYZWSVOHGZU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class WKNVSGTQDEI<a, b> : TIJSSGKTKZA<KeyValuePair<a, b>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x8721270", Offset = "0x871FC70", VA = "0x188721270", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8720D70", Offset = "0x871F770", VA = "0x188720D70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA525760", Offset = "0xA524160", VA = "0x18A525760", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA5256E0", Offset = "0xA5240E0", VA = "0x18A5256E0", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA535950", Offset = "0xA534350", VA = "0x18A535950", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA535830", Offset = "0xA534230", VA = "0x18A535830", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5218C0", Offset = "0xA5202C0", VA = "0x18A5218C0")]
		public BYLXKFQCJZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x984E9F0", Offset = "0x984D3F0", VA = "0x18984E9F0")]
		public BYLXKFQCJZM(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5216F0", Offset = "0xA5200F0", VA = "0x18A5216F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5215E0", Offset = "0xA51FFE0", VA = "0x18A5215E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA528A00", Offset = "0xA527400", VA = "0x18A528A00", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA528950", Offset = "0xA527350", VA = "0x18A528950", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52FE10", Offset = "0xA52E810", VA = "0x18A52FE10", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA52FD80", Offset = "0xA52E780", VA = "0x18A52FD80", Slot = "5")]
		public Complex Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52ADA0", Offset = "0xA5297A0", VA = "0x18A52ADA0", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA52AB70", Offset = "0xA529570", VA = "0x18A52AB70", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public PLBEURGEHZC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class TFAXRPBNCTN<a> : TIJSSGKTKZA<Lazy<a>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C210", Offset = "0x7C4AC10", VA = "0x187C4C210", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C000", Offset = "0x7C4AA00", VA = "0x187C4C000", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA534B10", Offset = "0xA533510", VA = "0x18A534B10", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA534A60", Offset = "0xA533460", VA = "0x18A534A60", Slot = "5")]
		public Task Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public ULQYUSIHHDF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class YNXEZVLLPNV<a> : TIJSSGKTKZA<Task<a>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x518B180", Offset = "0x5189B80", VA = "0x18518B180", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x518AF80", Offset = "0x5189980", VA = "0x18518AF80", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, FSNHROPLCPN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class JAHSEWHWMLH<a> : TIJSSGKTKZA<ValueTask<a>>, DUMZRUHETBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x6782D30", Offset = "0x6781730", VA = "0x186782D30", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x6782AF0", Offset = "0x67814F0", VA = "0x186782AF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ABC750", Offset = "0x7ABB150", VA = "0x187ABC750", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC460", Offset = "0x7ABAE60", VA = "0x187ABC460", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ABCF80", Offset = "0x7ABB980", VA = "0x187ABCF80", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCB30", Offset = "0x7ABB530", VA = "0x187ABCB30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ABDA60", Offset = "0x7ABC460", VA = "0x187ABDA60", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7ABD4D0", Offset = "0x7ABBED0", VA = "0x187ABD4D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AB74C0", Offset = "0x7AB5EC0", VA = "0x187AB74C0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7AB6DC0", Offset = "0x7AB57C0", VA = "0x187AB6DC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AB8570", Offset = "0x7AB6F70", VA = "0x187AB8570", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7AB7D00", Offset = "0x7AB6700", VA = "0x187AB7D00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ABA0D0", Offset = "0x7AB8AD0", VA = "0x187ABA0D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7AB96D0", Offset = "0x7AB80D0", VA = "0x187AB96D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ABB7A0", Offset = "0x7ABA1A0", VA = "0x187ABB7A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7ABAC10", Offset = "0x7AB9610", VA = "0x187ABAC10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AB5C60", Offset = "0x7AB4660", VA = "0x187AB5C60", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4F50", Offset = "0x7AB3950", VA = "0x187AB4F50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A0A050", Offset = "0x6A08A50", VA = "0x186A0A050", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x6A09C20", Offset = "0x6A08620", VA = "0x186A09C20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A096A0", Offset = "0x6A080A0", VA = "0x186A096A0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x6A09190", Offset = "0x6A07B90", VA = "0x186A09190", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A07330", Offset = "0x6A05D30", VA = "0x186A07330", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x6A06C80", Offset = "0x6A05680", VA = "0x186A06C80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A0F8E0", Offset = "0x6A0E2E0", VA = "0x186A0F8E0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F060", Offset = "0x6A0DA60", VA = "0x186A0F060", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A0E580", Offset = "0x6A0CF80", VA = "0x186A0E580", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6A0DB70", Offset = "0x6A0C570", VA = "0x186A0DB70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A0CED0", Offset = "0x6A0B8D0", VA = "0x186A0CED0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x6A0C2A0", Offset = "0x6A0ACA0", VA = "0x186A0C2A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A0B440", Offset = "0x6A09E40", VA = "0x186A0B440", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6A0A650", Offset = "0x6A09050", VA = "0x186A0A650", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A111A0", Offset = "0x6A0FBA0", VA = "0x186A111A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, FSNHROPLCPN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x6A10200", Offset = "0x6A0EC00", VA = "0x186A10200", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52A230", Offset = "0xA528C30", VA = "0x18A52A230")]
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
		[Cpp2IlInjected.Address(RVA = "0xA52A090", Offset = "0xA528A90", VA = "0x18A52A090")]
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
		[Cpp2IlInjected.Address(RVA = "0xA538610", Offset = "0xA537010", VA = "0x18A538610")]
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
