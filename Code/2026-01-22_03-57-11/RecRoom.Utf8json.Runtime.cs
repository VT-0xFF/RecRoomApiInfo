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
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, QCUUQNTWJRO resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, QCUUQNTWJRO resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface SIQNGTGRNUC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface ZYLVUXEUPGB<a> : SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, QCUUQNTWJRO formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LUUIWFVVYKQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ULWLNFSULXC(JsonWriter a, a b, QCUUQNTWJRO c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b);
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
	public static class AOWJIKFERYD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x308E160", Offset = "0x308C960", VA = "0x18308E160")]
		public static string ToJsonString<T>(this ZYLVUXEUPGB<T> formatter, T value, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ZYLVUXEUPGB<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class XILTVKEWSXL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C199E0", Offset = "0x3C181E0", VA = "0x183C199E0")]
		public static ZYLVUXEUPGB<a> SYOIKILXRCQ<a>(this QCUUQNTWJRO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8E665E0", Offset = "0x8E64DE0", VA = "0x188E665E0")]
		public static object RGYGCVPHEHA(this QCUUQNTWJRO a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8E55F10", Offset = "0x8E54710", VA = "0x188E55F10")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class KTCTGADXKJK
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] KDFZJWCPQXR;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] FPBQRBSMIRI;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] WANQDSLLPZF;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] GTRXJSCGJEW;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] SZUDCEKVTOR;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] DRNWKDWRUJO;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] GYMYGLPYHDQ;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] MQVTOXBGBLR;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class QXLBBXTOHOD : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x8E61B30", Offset = "0x8E60330", VA = "0x188E61B30")]
				public QXLBBXTOHOD(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x8E61A10", Offset = "0x8E60210", VA = "0x188E61A10")]
				public QXLBBXTOHOD XGYHIGFBSWP(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class IVMPVECOJEI
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] HSPCCOZCDPP;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] KDBRLUFSPSK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private QXLBBXTOHOD start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private QXLBBXTOHOD end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8E64710", Offset = "0x8E62F10", VA = "0x188E64710")]
			public void XGYHIGFBSWP([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8E64820", Offset = "0x8E63020", VA = "0x188E64820")]
			public void XGYHIGFBSWP(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8E64240", Offset = "0x8E62A40", VA = "0x188E64240")]
			public ReadOnlySequence<byte> ODCBNWFURXK()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8E64370", Offset = "0x8E62B70", VA = "0x188E64370")]
			private void PRKDPFRTVSW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8E64520", Offset = "0x8E62D20", VA = "0x188E64520")]
			private void WBVVPCVMNJM([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8E5C170", Offset = "0x8E5A970", VA = "0x188E5C170")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8E5A460", Offset = "0x8E58C60", VA = "0x188E5A460")]
		private JsonParsingException IOHJGBLQLHY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8E5B340", Offset = "0x8E59B40", VA = "0x188E5B340")]
		private JsonParsingException QGZVCSLIJXH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8E5B450", Offset = "0x8E59C50", VA = "0x188E5B450")]
		public JsonToken QTJUJOIXAVH()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8E59680", Offset = "0x8E57E80", VA = "0x188E59680")]
		public void BXYAHLEKHKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8E5A200", Offset = "0x8E58A00", VA = "0x188E5A200")]
		private bool FLXGHCMQJGD(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8E5A1A0", Offset = "0x8E589A0", VA = "0x188E5A1A0")]
		private bool FLXGHCMQJGD(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8E59E90", Offset = "0x8E58690", VA = "0x188E59E90")]
		private void EIOAMMLRIRE(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8E59950", Offset = "0x8E58150", VA = "0x188E59950")]
		public bool DDXEIFIJJAK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8E58FB0", Offset = "0x8E577B0", VA = "0x188E58FB0")]
		public void AYINQKCAHFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8E5ADF0", Offset = "0x8E595F0", VA = "0x188E5ADF0")]
		public bool OQBDRGBYOKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8E5ADE0", Offset = "0x8E595E0", VA = "0x188E5ADE0")]
		public void OFIPEHBNILC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8E5BF40", Offset = "0x8E5A740", VA = "0x188E5BF40")]
		public void XSPCMCIDBRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8E59630", Offset = "0x8E57E30", VA = "0x188E59630")]
		public bool BXMTDITHCAX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8E5AD60", Offset = "0x8E59560", VA = "0x188E5AD60")]
		public void NWYRZBAFPHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8E5B8F0", Offset = "0x8E5A0F0", VA = "0x188E5B8F0")]
		public void UJPZCEFYJRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8E5BF50", Offset = "0x8E5A750", VA = "0x188E5BF50")]
		public bool YHGGTZSFVLA(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8E5B7B0", Offset = "0x8E59FB0", VA = "0x188E5B7B0")]
		public bool SWTPRPWMHUA(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8E59550", Offset = "0x8E57D50", VA = "0x188E59550")]
		public bool BSHHBOTASKL(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8E5B9D0", Offset = "0x8E5A1D0", VA = "0x188E5B9D0")]
		private ReadOnlySequence<byte> WDEJPXEEJOQ()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8E5AEF0", Offset = "0x8E596F0", VA = "0x188E5AEF0")]
		private ReadOnlySequence<byte> PRPPYTLUFQD()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8E59FB0", Offset = "0x8E587B0", VA = "0x188E59FB0")]
		private void EWJMRLMGSMD(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8E5A960", Offset = "0x8E59160", VA = "0x188E5A960")]
		private void JSXWDRWCOGO(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8E59260", Offset = "0x8E57A60", VA = "0x188E59260")]
		private void BOTEVPHRVEV(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8E5A350", Offset = "0x8E58B50", VA = "0x188E5A350")]
		private void HFXQJPXZRVW(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8E524B0", Offset = "0x8E50CB0", VA = "0x188E524B0")]
		private static int KIRJCQPODIX(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8E5B900", Offset = "0x8E5A100", VA = "0x188E5B900")]
		public ReadOnlySequence<byte> VJPUZPAMHUF()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8E5BEB0", Offset = "0x8E5A6B0", VA = "0x188E5BEB0")]
		public string WKENXSJRKKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8E5A310", Offset = "0x8E58B10", VA = "0x188E5A310")]
		public string GYLVOZGFEPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8E59C50", Offset = "0x8E58450", VA = "0x188E59C50")]
		public ReadOnlySequence<byte> DUDBOZOPHNV()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8E5BFE0", Offset = "0x8E5A7E0", VA = "0x188E5BFE0")]
		public ReadOnlySequence<byte> YXYFOJEMMPC()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8E5AB60", Offset = "0x8E59360", VA = "0x188E5AB60")]
		public bool KVBKXLHEPKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8E59D20", Offset = "0x8E58520", VA = "0x188E59D20")]
		private void EHNFFMOOHJL(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8E5BF30", Offset = "0x8E5A730", VA = "0x188E5BF30")]
		public void WYXHQXMOXPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8E59A10", Offset = "0x8E58210", VA = "0x188E59A10")]
		private void DLUHABAMAYA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8E5AE40", Offset = "0x8E59640", VA = "0x188E5AE40")]
		public sbyte PPZELUZEWWK()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8E5A260", Offset = "0x8E58A60", VA = "0x188E5A260")]
		public short GDTHUAZVRAD()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8E5B840", Offset = "0x8E5A040", VA = "0x188E5B840")]
		public int UFBRRLQAWKV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8E5AD70", Offset = "0x8E59570", VA = "0x188E5AD70")]
		public long OBBJELQJIPE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8E5B700", Offset = "0x8E59F00", VA = "0x188E5B700")]
		public byte RZDWHWTZJBH()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8E5ACB0", Offset = "0x8E594B0", VA = "0x188E5ACB0")]
		public ushort MROFFRAYTFW()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8E5C0C0", Offset = "0x8E5A8C0", VA = "0x188E5C0C0")]
		public uint ZQDTVOJTZRM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8E59F40", Offset = "0x8E58740", VA = "0x188E59F40")]
		public ulong EVBFKHMANKF()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8E598B0", Offset = "0x8E580B0", VA = "0x188E598B0")]
		public float CFQTWDOLFCX()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8E5B660", Offset = "0x8E59E60", VA = "0x188E5B660")]
		public double QVAZRPILARA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8E5B160", Offset = "0x8E59960", VA = "0x188E5B160")]
		public ReadOnlySequence<byte> PVBBROSDZNZ()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8E58FC0", Offset = "0x8E577C0", VA = "0x188E58FC0")]
		private void BBOHNMZZWWZ()
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
			[Cpp2IlInjected.Address(RVA = "0xD0CB00", Offset = "0xD0B300", VA = "0x180D0CB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8E58F50", Offset = "0x8E57750", VA = "0x188E58F50")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8E58ED0", Offset = "0x8E576D0", VA = "0x188E58ED0")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class FLYQGSBSRQB
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class FXAQZXTUURA
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] HSPCCOZCDPP;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8E55E70", Offset = "0x8E54670", VA = "0x188E55E70")]
			public static byte[] XCSRIKXKEBR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static QCUUQNTWJRO XQMAATTBZDU;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] NJHHSWMZTLH;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] PUFVTYICMWV;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static QCUUQNTWJRO DWYRFJNRAXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8E55B90", Offset = "0x8E54390", VA = "0x188E55B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8E55C80", Offset = "0x8E54480", VA = "0x188E55C80")]
		public static void MZZHBGNHMQA(QCUUQNTWJRO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x36ABA40", Offset = "0x36AA240", VA = "0x1836ABA40")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x36ABAB0", Offset = "0x36AA2B0", VA = "0x1836ABAB0")]
		public static byte[] Serialize<T>(T value, QCUUQNTWJRO resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x36AC1C0", Offset = "0x36AA9C0", VA = "0x1836AC1C0")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x36AC040", Offset = "0x36AA840", VA = "0x1836AC040")]
		public static string ToJsonString<T>(T value, QCUUQNTWJRO resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x36AB470", Offset = "0x36A9C70", VA = "0x1836AB470")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x36AB2F0", Offset = "0x36A9AF0", VA = "0x1836AB2F0")]
		public static T Deserialize<T>(string json, QCUUQNTWJRO resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x36AB640", Offset = "0x36A9E40", VA = "0x1836AB640")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x36AB220", Offset = "0x36A9A20", VA = "0x1836AB220")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, QCUUQNTWJRO resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x36AABA0", Offset = "0x36A93A0", VA = "0x1836AABA0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x36AA9D0", Offset = "0x36A91D0", VA = "0x1836AA9D0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, QCUUQNTWJRO resolver)
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
		public int QKPOCMIOFQL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCCA130", Offset = "0xCC8930", VA = "0x180CCA130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8E5CB20", Offset = "0x8E5B320", VA = "0x188E5CB20")]
		public void HWRUAMAOFOA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8E5CF40", Offset = "0x8E5B740", VA = "0x188E5CF40")]
		public static byte[] LYRXMAJOLML(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8E5C390", Offset = "0x8E5AB90", VA = "0x188E5C390")]
		public static byte[] BWHGBEQGQGD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8E5CD80", Offset = "0x8E5B580", VA = "0x188E5CD80")]
		public static byte[] JYJLZGCQELR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8E5CB30", Offset = "0x8E5B330", VA = "0x188E5CB30")]
		public static byte[] IOKBGVKSJZT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2820E60", Offset = "0x281F660", VA = "0x182820E60")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8E5D390", Offset = "0x8E5BB90", VA = "0x188E5D390")]
		public ArraySegment<byte> XCSRIKXKEBR()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8E5D4A0", Offset = "0x8E5BCA0", VA = "0x188E5D4A0")]
		public byte[] YFBWGVNSJWA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8E5D300", Offset = "0x8E5BB00", VA = "0x188E5D300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8E5D380", Offset = "0x8E5BB80", VA = "0x188E5D380")]
		public void WZRHSUXKKKB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8E5CD20", Offset = "0x8E5B520", VA = "0x188E5CD20")]
		public void JMZGOIXNARG(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8E5C350", Offset = "0x8E5AB50", VA = "0x188E5C350")]
		public void BLHJEEYAGRU(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A160", Offset = "0x3E28960", VA = "0x183E2A160")]
		public void UGPQPUIYFWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A110", Offset = "0x3E28910", VA = "0x183E2A110")]
		public void JIPULJMCAEY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8E5C4B0", Offset = "0x8E5ACB0", VA = "0x188E5C4B0")]
		public void DEXKWLZRQMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8E5D2B0", Offset = "0x8E5BAB0", VA = "0x188E5D2B0")]
		public void STEBFPFAMMY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A250", Offset = "0x3E28A50", VA = "0x183E2A250")]
		public void YUOPUCBJROS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x52EEF00", Offset = "0x52ED700", VA = "0x1852EEF00")]
		public void UIHXTCSFHOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8E5CEA0", Offset = "0x8E5B6A0", VA = "0x188E5CEA0")]
		public void LTIVDMYJBBK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3E7BB60", Offset = "0x3E7A360", VA = "0x183E7BB60")]
		public void JTCQQMQOVFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A1B0", Offset = "0x3E289B0", VA = "0x183E2A1B0")]
		public void VMWMBOKBXRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7787320", Offset = "0x7785B20", VA = "0x187787320")]
		public void GAFSCEZOVSO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8E5D140", Offset = "0x8E5B940", VA = "0x188E5D140")]
		public void PTUWVLJIBIS(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8E5D1C0", Offset = "0x8E5B9C0", VA = "0x188E5D1C0")]
		public void SEKRBSQGXYH(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8E5D430", Offset = "0x8E5BC30", VA = "0x188E5D430")]
		public void XQREVLYGQWI(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8E5CA80", Offset = "0x8E5B280", VA = "0x188E5CA80")]
		public void FLPLPQTWTOF(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8E5D240", Offset = "0x8E5BA40", VA = "0x188E5D240")]
		public void SIOXBLZNCNB(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8E5D020", Offset = "0x8E5B820", VA = "0x188E5D020")]
		public void MKFZPTKZSXC(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8E5CCB0", Offset = "0x8E5B4B0", VA = "0x188E5CCB0")]
		public void JBDPRTCUZXL(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8E5D050", Offset = "0x8E5B850", VA = "0x188E5D050")]
		public void NNEXSGMTCGI(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8E5C2E0", Offset = "0x8E5AAE0", VA = "0x188E5C2E0")]
		public void ALUMIDVOIRY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8E5CAF0", Offset = "0x8E5B2F0", VA = "0x188E5CAF0")]
		public void FQRXWWXUWKR(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8E5C500", Offset = "0x8E5AD00", VA = "0x188E5C500")]
		public void EZGUIMGOKOL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8E5D0C0", Offset = "0x8E5B8C0", VA = "0x188E5D0C0")]
		private static bool OFKDWRXYLZV(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8E5D360", Offset = "0x8E5BB60", VA = "0x188E5D360")]
		private static byte VCMVKWORBHP(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8E52570", Offset = "0x8E50D70", VA = "0x188E52570")]
		private static void FFJMZLFECCW(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class GCSNSOBQNUT : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5B68AA0", Offset = "0x5B672A0", VA = "0x185B68AA0")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private GCSNSOBQNUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class WHLGZSDMURG : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5B394B0", Offset = "0x5B37CB0", VA = "0x185B394B0")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class MKHSNYREYLA
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> KFAYWMUDALB;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8E5E3F0", Offset = "0x8E5CBF0", VA = "0x188E5E3F0")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private WHLGZSDMURG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class CGMLBNELOGI : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x5B3F620", Offset = "0x5B3DE20", VA = "0x185B3F620")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly CGMLBNELOGI QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool BREYHLZGMFK;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static SIQNGTGRNUC[] HAUSJPUJKYM;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static QCUUQNTWJRO[] RHNZPWSLVGK;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private CGMLBNELOGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8E54E90", Offset = "0x8E53690", VA = "0x188E54E90")]
		public static void JPLRKQDWIBU(params QCUUQNTWJRO[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8E54DC0", Offset = "0x8E535C0", VA = "0x188E54DC0")]
		public static void JPLRKQDWIBU(params SIQNGTGRNUC[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8E54F60", Offset = "0x8E53760", VA = "0x188E54F60")]
		public static void JUORMLUUQUG(SIQNGTGRNUC[] a, QCUUQNTWJRO[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class WQZCEBVDTIH : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x5B3E600", Offset = "0x5B3CE00", VA = "0x185B3E600")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private WQZCEBVDTIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class VQNQSRADZPO
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly QCUUQNTWJRO BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly QCUUQNTWJRO RDQMMBMVYLD;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class NNSHCWWDEFO
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly QCUUQNTWJRO BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly QCUUQNTWJRO PVEULNMPOSD;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly QCUUQNTWJRO XSMNQIMPJIR;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly QCUUQNTWJRO BCRVXFUYDAG;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly QCUUQNTWJRO HOFJAZVBWOA;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly QCUUQNTWJRO DGEUTOBMSPI;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly QCUUQNTWJRO DBZTRMIWRPN;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly QCUUQNTWJRO GBAOVRTFOCH;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly QCUUQNTWJRO BWPAVVHYUAZ;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly QCUUQNTWJRO YVPYKBSZMQW;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly QCUUQNTWJRO KNWXPFGAIYQ;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly QCUUQNTWJRO UNXVORJJPBU;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class SEXQVKOMAGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> KFAYWMUDALB;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8E61C30", Offset = "0x8E60430", VA = "0x188E61C30")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8E63860", Offset = "0x8E62060", VA = "0x188E63860")]
		private static object QBSEJWJEMNW(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class YGFLXEVZYNX : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5B48E70", Offset = "0x5B47670", VA = "0x185B48E70")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private YGFLXEVZYNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class MDIYOSAQFNC : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5B3C930", Offset = "0x5B3B130", VA = "0x185B3C930")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private MDIYOSAQFNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class QNMWFCJGXFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly QCUUQNTWJRO[] FMIKKFCBGUZ;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class BPJMPAHZVBR : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x5B28E90", Offset = "0x5B27690", VA = "0x185B28E90")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class MBAAVLNBDVN : QCUUQNTWJRO
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class QDGKJFIHAQI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x5B6C170", Offset = "0x5B6A970", VA = "0x185B6C170")]
				static QDGKJFIHAQI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly QCUUQNTWJRO QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly QCUUQNTWJRO[] RHNZPWSLVGK;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			private MBAAVLNBDVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
			public ZYLVUXEUPGB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly ZYLVUXEUPGB<object> WKGHXFFERVD;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private BPJMPAHZVBR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class KUPGTWRYLYA : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x5B5DBC0", Offset = "0x5B5C3C0", VA = "0x185B5DBC0")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class MBAAVLNBDVN : QCUUQNTWJRO
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class QDGKJFIHAQI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x5B35460", Offset = "0x5B33C60", VA = "0x185B35460")]
				static QDGKJFIHAQI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly QCUUQNTWJRO QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly QCUUQNTWJRO[] RHNZPWSLVGK;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			private MBAAVLNBDVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
			public ZYLVUXEUPGB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly ZYLVUXEUPGB<object> WKGHXFFERVD;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private KUPGTWRYLYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class PUJWZDMRYAC : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x5B34F90", Offset = "0x5B33790", VA = "0x185B34F90")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class MBAAVLNBDVN : QCUUQNTWJRO
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class QDGKJFIHAQI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x5B5CA80", Offset = "0x5B5B280", VA = "0x185B5CA80")]
				static QDGKJFIHAQI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly QCUUQNTWJRO QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly QCUUQNTWJRO[] RHNZPWSLVGK;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			private MBAAVLNBDVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
			public ZYLVUXEUPGB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly ZYLVUXEUPGB<object> WKGHXFFERVD;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private PUJWZDMRYAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class TIXNKCTJTUB : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x5B6F9E0", Offset = "0x5B6E1E0", VA = "0x185B6F9E0")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class MBAAVLNBDVN : QCUUQNTWJRO
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class QDGKJFIHAQI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x5B65E10", Offset = "0x5B64610", VA = "0x185B65E10")]
				static QDGKJFIHAQI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly QCUUQNTWJRO QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly QCUUQNTWJRO[] RHNZPWSLVGK;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			private MBAAVLNBDVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
			public ZYLVUXEUPGB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly ZYLVUXEUPGB<object> WKGHXFFERVD;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private TIXNKCTJTUB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class UOASFGZKJRZ : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x5B67C40", Offset = "0x5B66440", VA = "0x185B67C40")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class MBAAVLNBDVN : QCUUQNTWJRO
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class QDGKJFIHAQI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x5B65410", Offset = "0x5B63C10", VA = "0x185B65410")]
				static QDGKJFIHAQI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly QCUUQNTWJRO QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly QCUUQNTWJRO[] RHNZPWSLVGK;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			private MBAAVLNBDVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
			public ZYLVUXEUPGB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly ZYLVUXEUPGB<object> WKGHXFFERVD;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private UOASFGZKJRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class SQNDXRUJDTX : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x5B63CC0", Offset = "0x5B624C0", VA = "0x185B63CC0")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class MBAAVLNBDVN : QCUUQNTWJRO
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class QDGKJFIHAQI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x5B58950", Offset = "0x5B57150", VA = "0x185B58950")]
				static QDGKJFIHAQI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly QCUUQNTWJRO QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly QCUUQNTWJRO[] RHNZPWSLVGK;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			private MBAAVLNBDVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
			public ZYLVUXEUPGB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly ZYLVUXEUPGB<object> WKGHXFFERVD;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private SQNDXRUJDTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class OQJXYDKYGKQ : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x5B56EE0", Offset = "0x5B556E0", VA = "0x185B56EE0")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class MBAAVLNBDVN : QCUUQNTWJRO
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class QDGKJFIHAQI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x5B3BB70", Offset = "0x5B3A370", VA = "0x185B3BB70")]
				static QDGKJFIHAQI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly QCUUQNTWJRO QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly QCUUQNTWJRO[] RHNZPWSLVGK;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			private MBAAVLNBDVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
			public ZYLVUXEUPGB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly ZYLVUXEUPGB<object> WKGHXFFERVD;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private OQJXYDKYGKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class JWCGODFDGFW : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x5B42240", Offset = "0x5B40A40", VA = "0x185B42240")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class MBAAVLNBDVN : QCUUQNTWJRO
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class QDGKJFIHAQI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0x5B3AED0", Offset = "0x5B396D0", VA = "0x185B3AED0")]
				static QDGKJFIHAQI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly QCUUQNTWJRO QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly QCUUQNTWJRO[] RHNZPWSLVGK;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			private MBAAVLNBDVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
			public ZYLVUXEUPGB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly ZYLVUXEUPGB<object> WKGHXFFERVD;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private JWCGODFDGFW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class HHEUZGGSHFA : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x5B37C60", Offset = "0x5B36460", VA = "0x185B37C60")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class MBAAVLNBDVN : QCUUQNTWJRO
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class QDGKJFIHAQI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x5B5D5F0", Offset = "0x5B5BDF0", VA = "0x185B5D5F0")]
				static QDGKJFIHAQI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly QCUUQNTWJRO QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly QCUUQNTWJRO[] RHNZPWSLVGK;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			private MBAAVLNBDVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
			public ZYLVUXEUPGB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly ZYLVUXEUPGB<object> WKGHXFFERVD;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private HHEUZGGSHFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class PRGZYDFRYIJ : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x5B45840", Offset = "0x5B44040", VA = "0x185B45840")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class MBAAVLNBDVN : QCUUQNTWJRO
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class QDGKJFIHAQI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x5B4DCF0", Offset = "0x5B4C4F0", VA = "0x185B4DCF0")]
				static QDGKJFIHAQI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly QCUUQNTWJRO QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly QCUUQNTWJRO[] RHNZPWSLVGK;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			private MBAAVLNBDVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
			public ZYLVUXEUPGB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly ZYLVUXEUPGB<object> WKGHXFFERVD;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private PRGZYDFRYIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class RIHDAUBLRDJ : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x5B51D10", Offset = "0x5B50510", VA = "0x185B51D10")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class MBAAVLNBDVN : QCUUQNTWJRO
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class QDGKJFIHAQI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x5B6FCD0", Offset = "0x5B6E4D0", VA = "0x185B6FCD0")]
				static QDGKJFIHAQI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly QCUUQNTWJRO QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly QCUUQNTWJRO[] RHNZPWSLVGK;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			private MBAAVLNBDVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
			public ZYLVUXEUPGB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly ZYLVUXEUPGB<object> WKGHXFFERVD;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private RIHDAUBLRDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class UIUADNCJKBT : QCUUQNTWJRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class QDGKJFIHAQI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5B66FC0", Offset = "0x5B657C0", VA = "0x185B66FC0")]
			static QDGKJFIHAQI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class MBAAVLNBDVN : QCUUQNTWJRO
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class QDGKJFIHAQI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly ZYLVUXEUPGB<a> USEBFHEHNPF;

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x5B407F0", Offset = "0x5B3EFF0", VA = "0x185B407F0")]
				static QDGKJFIHAQI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly QCUUQNTWJRO QIBVUYLFYAA;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly QCUUQNTWJRO[] RHNZPWSLVGK;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			private MBAAVLNBDVN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
			public ZYLVUXEUPGB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly QCUUQNTWJRO QIBVUYLFYAA;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly ZYLVUXEUPGB<object> WKGHXFFERVD;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		private UIUADNCJKBT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x33E34A0", Offset = "0x33E1CA0", VA = "0x1833E34A0", Slot = "4")]
		public ZYLVUXEUPGB<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x571DA70", Offset = "0x571C270", VA = "0x18571DA70")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x571D950", Offset = "0x571C150", VA = "0x18571D950")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x571D9E0", Offset = "0x571C1E0", VA = "0x18571D9E0")]
		public T[] MUUABBZGGOL()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class IYLXXLEYFZT<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int GGAKAIJIMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object VPSKFVISBQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int DWACUWIQEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] AYPSAMUFDIS;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5011A40", Offset = "0x5010240", VA = "0x185011A40")]
		public IYLXXLEYFZT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5011390", Offset = "0x500FB90", VA = "0x185011390")]
		public a[] CVTXKICRPNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5011800", Offset = "0x5010000", VA = "0x185011800")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class GVPVDVWNZVL : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class UNBEWCWEKWN : IComparable<UNBEWCWEKWN>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class CNIYMFCZQMV : IEnumerable<UNBEWCWEKWN>, IEnumerable, IEnumerator<UNBEWCWEKWN>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int RXIHLDXPFTB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private UNBEWCWEKWN VMXRQLYYOUI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int AWPKGSEYDWO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public UNBEWCWEKWN BDLWXAGXLOZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int BWHCZIMPJCX;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private UNBEWCWEKWN ECTEGSYTEQC
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object BXTOFOKJAZT
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xD7D9E0", Offset = "0xD7C1E0", VA = "0x180D7D9E0")]
				[DebuggerHidden]
				public CNIYMFCZQMV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
				[DebuggerHidden]
				private void QMTXDIUIKRI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x8E55390", Offset = "0x8E53B90", VA = "0x188E55390", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x8E552B0", Offset = "0x8E53AB0", VA = "0x188E552B0", Slot = "10")]
				[DebuggerHidden]
				private void FKDUCXAGPJJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x8E552F0", Offset = "0x8E53AF0", VA = "0x188E552F0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<UNBEWCWEKWN> TAWCUCINGNX()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x8E552F0", Offset = "0x8E53AF0", VA = "0x188E552F0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator LRASTPXJBWO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly UNBEWCWEKWN[] XWPRXCDLSTH;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] HTULZFDGHWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong JTDQMXNDCYS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int ZBQGWKFCAQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string IMPLMBEAOHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private UNBEWCWEKWN[] RZSMCKSFPGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] GITYYUZCGYG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int ZYPFAWHWWWG;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8E653E0", Offset = "0x8E63BE0", VA = "0x188E653E0")]
			public UNBEWCWEKWN(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8E64E90", Offset = "0x8E63690", VA = "0x188E64E90")]
			public UNBEWCWEKWN Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8E64E30", Offset = "0x8E63630", VA = "0x188E64E30")]
			public UNBEWCWEKWN Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8E651D0", Offset = "0x8E639D0", VA = "0x188E651D0")]
			public UNBEWCWEKWN YYYJMWJOFVR(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8E65140", Offset = "0x8E63940", VA = "0x188E65140")]
			internal static int YCKKGBDPDTU(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8E65090", Offset = "0x8E63890", VA = "0x188E65090", Slot = "4")]
			public int CompareTo(UNBEWCWEKWN other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8E650C0", Offset = "0x8E638C0", VA = "0x188E650C0")]
			[IteratorStateMachine(typeof(CNIYMFCZQMV))]
			public IEnumerable<UNBEWCWEKWN> UEKSFOYIHRR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class EWLCTAOCBJN : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<UNBEWCWEKWN> RZSMCKSFPGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<UNBEWCWEKWN> VCTMUGHSGGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<UNBEWCWEKWN> YLHXGKHQDKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private UNBEWCWEKWN BKROJUHUNPY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> YLSLAXVKWGZ;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> BQPCILYNVVG
			{
				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0xCD79C0", Offset = "0xCD61C0", VA = "0x180CD79C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x8E55950", Offset = "0x8E54150", VA = "0x188E55950", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x1A4F060", Offset = "0x1A4D860", VA = "0x181A4F060")]
			[DebuggerHidden]
			public EWLCTAOCBJN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8E559A0", Offset = "0x8E541A0", VA = "0x188E559A0", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8E554F0", Offset = "0x8E53CF0", VA = "0x188E554F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8E55AF0", Offset = "0x8E542F0", VA = "0x188E55AF0")]
			private void YQEVNPXUUBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8E55B40", Offset = "0x8E54340", VA = "0x188E55B40")]
			private void YQUQFKFMWJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8E55410", Offset = "0x8E53C10", VA = "0x188E55410", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8E55450", Offset = "0x8E53C50", VA = "0x188E55450", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> JEXJOYKIRJB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8E55450", Offset = "0x8E53C50", VA = "0x188E55450", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly UNBEWCWEKWN GCIIEAQCVVB;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8E56830", Offset = "0x8E55030", VA = "0x188E56830")]
		public GVPVDVWNZVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8E55FE0", Offset = "0x8E547E0", VA = "0x188E55FE0")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8E56330", Offset = "0x8E54B30", VA = "0x188E56330")]
		public bool LHRMMYTLGSF(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8E56220", Offset = "0x8E54A20", VA = "0x188E56220")]
		public bool IRCBWQUTGBS([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8E567A0", Offset = "0x8E54FA0", VA = "0x188E567A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8E564C0", Offset = "0x8E54CC0", VA = "0x188E564C0")]
		private static void QBIFWTPLDII(IEnumerable<UNBEWCWEKWN> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8E561C0", Offset = "0x8E549C0", VA = "0x188E561C0", Slot = "5")]
		private IEnumerator LRASTPXJBWO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8E561C0", Offset = "0x8E549C0", VA = "0x188E561C0", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8E56440", Offset = "0x8E54C40", VA = "0x188E56440")]
		[IteratorStateMachine(typeof(EWLCTAOCBJN))]
		private static IEnumerable<KeyValuePair<string, int>> MWFLGKQIWEH(IEnumerable<UNBEWCWEKWN> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class JDJMZNWVWSW
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo LUGCNXJFFUR;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8E58640", Offset = "0x8E56E40", VA = "0x188E58640")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8E587F0", Offset = "0x8E56FF0", VA = "0x188E587F0")]
		public static ulong JSHMAJAFLKB(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class XDDUYCETUKW
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8E664A0", Offset = "0x8E64CA0", VA = "0x188E664A0")]
		public static void WZRHSUXKKKB(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8E66380", Offset = "0x8E64B80", VA = "0x188E66380")]
		public static void JVKLNDBWGPT(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8E66240", Offset = "0x8E64A40", VA = "0x188E66240")]
		public static byte[] CSDPHBXSQBY(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class ZIBDEUNUIAS<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x4793F50", Offset = "0x4792750", VA = "0x184793F50", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class LZHFKYQNYRU : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public ZIBDEUNUIAS<a> BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] YLHXGKHQDKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int YLNEDRBNMVQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] YLSLAXVKWGZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int YKHOUCMDIFO;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> CZKBFKKKFHR
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xCD79C0", Offset = "0xCD61C0", VA = "0x180CD79C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0x4E36CF0", Offset = "0x4E354F0", VA = "0x184E36CF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public LZHFKYQNYRU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x533A4C0", Offset = "0x5338CC0", VA = "0x18533A4C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3D66D30", Offset = "0x3D65530", VA = "0x183D66D30", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] WGVAKKXBDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong XVZKXLCAIDW;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool HIRMGRZMZMR;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3E762E0", Offset = "0x3E74AE0", VA = "0x183E762E0")]
		public ZIBDEUNUIAS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3E761F0", Offset = "0x3E749F0", VA = "0x183E761F0")]
		public ZIBDEUNUIAS(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3E63FC0", Offset = "0x3E627C0", VA = "0x183E63FC0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3E72E60", Offset = "0x3E71660", VA = "0x183E72E60")]
		private bool ZMKEECOQQPY(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3E6CBA0", Offset = "0x3E6B3A0", VA = "0x183E6CBA0")]
		public bool LHRMMYTLGSF([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3E66E70", Offset = "0x3E65670", VA = "0x183E66E70")]
		private static ulong GEMWVIUAHWH([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3E69110", Offset = "0x3E67910", VA = "0x183E69110")]
		private static ulong GEMWVIUAHWH([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D330", Offset = "0x3E6BB30", VA = "0x183E6D330")]
		private static int TYKBSAWAMGB(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3E692B0", Offset = "0x3E67AB0", VA = "0x183E692B0", Slot = "4")]
		[IteratorStateMachine(typeof(ZIBDEUNUIAS<>.LZHFKYQNYRU))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D150", Offset = "0x3E6B950", VA = "0x183E6D150", Slot = "5")]
		private IEnumerator LRASTPXJBWO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class NTJJNRZOJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x38AB2C0", Offset = "0x38A9AC0", VA = "0x1838AB2C0")]
		public static Func<a> ENYZQKMWXDL<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x38AB3B0", Offset = "0x38A9BB0", VA = "0x1838AB3B0")]
		private static c MGYBDFPGGBE<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0x8E57220", Offset = "0x8E55A20", VA = "0x188E57220")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8E57230", Offset = "0x8E55A30", VA = "0x188E57230")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8E570A0", Offset = "0x8E558A0", VA = "0x188E570A0")]
		private static byte PGXYYDRPUEO(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8E520D0", Offset = "0x8E508D0", VA = "0x188E520D0")]
		private static byte ECHGFZFEGCC(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8E568A0", Offset = "0x8E550A0", VA = "0x188E568A0")]
		public void NRKQGERBRVA(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class QACCCUSBFVE
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8E60F10", Offset = "0x8E5F710", VA = "0x188E60F10")]
		public static bool NJRFYAHGAOC(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8E611A0", Offset = "0x8E5F9A0", VA = "0x188E611A0")]
		public static bool QPCLAVYMLST(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8E61140", Offset = "0x8E5F940", VA = "0x188E61140")]
		public static sbyte PPZELUZEWWK([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8E60BE0", Offset = "0x8E5F3E0", VA = "0x188E60BE0")]
		public static short GDTHUAZVRAD([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8E613C0", Offset = "0x8E5FBC0", VA = "0x188E613C0")]
		public static int UFBRRLQAWKV([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8E60F80", Offset = "0x8E5F780", VA = "0x188E60F80")]
		public static long OBBJELQJIPE([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8E608B0", Offset = "0x8E5F0B0", VA = "0x188E608B0")]
		public static bool BXZMKALXVHB(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8E61360", Offset = "0x8E5FB60", VA = "0x188E61360")]
		public static byte RZDWHWTZJBH([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8E60EB0", Offset = "0x8E5F6B0", VA = "0x188E60EB0")]
		public static ushort MROFFRAYTFW([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8E61740", Offset = "0x8E5FF40", VA = "0x188E61740")]
		public static uint ZQDTVOJTZRM([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8E60B30", Offset = "0x8E5F330", VA = "0x188E60B30")]
		public static ulong EVBFKHMANKF([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8E61420", Offset = "0x8E5FC20", VA = "0x188E61420")]
		public static bool XMDVVRGPBJM(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8E61570", Offset = "0x8E5FD70", VA = "0x188E61570")]
		public static bool ZDVOAAWVBWE(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8E61030", Offset = "0x8E5F830", VA = "0x188E61030")]
		public static bool ODZXMUORXDU(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8E60C40", Offset = "0x8E5F440", VA = "0x188E60C40")]
		public static bool HUJGRHXPYEE(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8E60A40", Offset = "0x8E5F240", VA = "0x188E60A40")]
		public static float CFQTWDOLFCX([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8E60F20", Offset = "0x8E5F720", VA = "0x188E60F20")]
		public static bool NNHWOUIJNLC(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8E61210", Offset = "0x8E5FA10", VA = "0x188E61210")]
		public static double QVAZRPILARA([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8E61300", Offset = "0x8E5FB00", VA = "0x188E61300")]
		public static bool RCKRGOLBDQZ(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8E53080", Offset = "0x8E51880", VA = "0x188E53080")]
		public static int MKFZPTKZSXC(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8E526C0", Offset = "0x8E50EC0", VA = "0x188E526C0")]
		public static int FQRXWWXUWKR(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8E60CE0", Offset = "0x8E5F4E0", VA = "0x188E60CE0")]
		public static bool KVBKXLHEPKN([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class TKKXCQJDTAI
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8E649F0", Offset = "0x8E631F0", VA = "0x188E649F0")]
		public static bool XGXTTLEUZNA(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class CCEBEHMGKMP
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding DZQVSMONOCA;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class BFIDCMMAZIP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8E540E0", Offset = "0x8E528E0", VA = "0x188E540E0")]
		public static void LCSCROPONTC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8E54150", Offset = "0x8E52950", VA = "0x188E54150")]
		public static void LCXJOVJLXEL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8E541C0", Offset = "0x8E529C0", VA = "0x188E541C0")]
		public static void LDCQMCDJGPU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8E54230", Offset = "0x8E52A30", VA = "0x188E54230")]
		public static void LDHXJIXGQBD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8E53EB0", Offset = "0x8E526B0", VA = "0x188E53EB0")]
		public static void LAGXYLKUEMY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8E53F20", Offset = "0x8E52720", VA = "0x188E53F20")]
		public static void LAMEVSERNYH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8E54500", Offset = "0x8E52D00", VA = "0x188E54500")]
		public static void OQNEHGGMCJP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8E54490", Offset = "0x8E52C90", VA = "0x188E54490")]
		public static void OQHXJZMOSYG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8E54420", Offset = "0x8E52C20", VA = "0x188E54420")]
		public static void OQCQMSSRJMX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8E543A0", Offset = "0x8E52BA0", VA = "0x188E543A0")]
		public static void OPXJPLYUABO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8E546F0", Offset = "0x8E52EF0", VA = "0x188E546F0")]
		public static void ORIFWHIBOCZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8E54670", Offset = "0x8E52E70", VA = "0x188E54670")]
		public static void ORCYZAOEERQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8E545F0", Offset = "0x8E52DF0", VA = "0x188E545F0")]
		public static void OQXSBTUGVGH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8E54570", Offset = "0x8E52D70", VA = "0x188E54570")]
		public static void OQSLENAJLUY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8E54320", Offset = "0x8E52B20", VA = "0x188E54320")]
		public static void OOXBDEDHEWV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8E542A0", Offset = "0x8E52AA0", VA = "0x188E542A0")]
		public static void OORUFXJJVLM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8E54BC0", Offset = "0x8E533C0", VA = "0x188E54BC0")]
		public static void URGKSQPOGFQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8E54C40", Offset = "0x8E53440", VA = "0x188E54C40")]
		public static void URLRPXJLPQZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8E54AC0", Offset = "0x8E532C0", VA = "0x188E54AC0")]
		public static void UQVWYDBTNIY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8E54B40", Offset = "0x8E53340", VA = "0x188E54B40")]
		public static void URBDVJVQWUH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8E549B0", Offset = "0x8E531B0", VA = "0x188E549B0")]
		public static void UQLJDPNYUMG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8E54A30", Offset = "0x8E53230", VA = "0x188E54A30")]
		public static void UQQQAWHWDXP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8E54890", Offset = "0x8E53090", VA = "0x188E54890")]
		public static void UQAVJCAEBPO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8E54920", Offset = "0x8E53120", VA = "0x188E54920")]
		public static void UQGCGIUBLAX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8E54770", Offset = "0x8E52F70", VA = "0x188E54770")]
		public static void UPQHOOMJISW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8E54800", Offset = "0x8E53000", VA = "0x188E54800")]
		public static void UPVOLVGGSEF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8E53E20", Offset = "0x8E52620", VA = "0x188E53E20")]
		public static void BLLDBAKXFYX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8E53D90", Offset = "0x8E52590", VA = "0x188E53D90")]
		public static void BLFWDTQZWNO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8E53F90", Offset = "0x8E52790", VA = "0x188E53F90")]
		public static void LCCHZUHWLLB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8E54000", Offset = "0x8E52800", VA = "0x188E54000")]
		public static void LCHOXBBTUWK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8E54070", Offset = "0x8E52870", VA = "0x188E54070")]
		public static void LCMVUHVREHT(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class VGZFQTXNPSQ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8E65620", Offset = "0x8E63E20", VA = "0x188E65620")]
		public static void LAGXYLKUEMY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8E65690", Offset = "0x8E63E90", VA = "0x188E65690")]
		public static void LAMEVSERNYH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8E65950", Offset = "0x8E64150", VA = "0x188E65950")]
		public static void OQNEHGGMCJP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8E658E0", Offset = "0x8E640E0", VA = "0x188E658E0")]
		public static void OQHXJZMOSYG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8E65870", Offset = "0x8E64070", VA = "0x188E65870")]
		public static void OQCQMSSRJMX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8E65800", Offset = "0x8E64000", VA = "0x188E65800")]
		public static void OPXJPLYUABO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8E65B20", Offset = "0x8E64320", VA = "0x188E65B20")]
		public static void ORIFWHIBOCZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8E65AB0", Offset = "0x8E642B0", VA = "0x188E65AB0")]
		public static void ORCYZAOEERQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8E65A40", Offset = "0x8E64240", VA = "0x188E65A40")]
		public static void OQXSBTUGVGH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8E659C0", Offset = "0x8E641C0", VA = "0x188E659C0")]
		public static void OQSLENAJLUY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8E65780", Offset = "0x8E63F80", VA = "0x188E65780")]
		public static void OOXBDEDHEWV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8E65700", Offset = "0x8E63F00", VA = "0x188E65700")]
		public static void OORUFXJJVLM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8E65F90", Offset = "0x8E64790", VA = "0x188E65F90")]
		public static void URGKSQPOGFQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8E66010", Offset = "0x8E64810", VA = "0x188E66010")]
		public static void URLRPXJLPQZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8E65E90", Offset = "0x8E64690", VA = "0x188E65E90")]
		public static void UQVWYDBTNIY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8E65F10", Offset = "0x8E64710", VA = "0x188E65F10")]
		public static void URBDVJVQWUH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8E65D90", Offset = "0x8E64590", VA = "0x188E65D90")]
		public static void UQLJDPNYUMG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8E65E10", Offset = "0x8E64610", VA = "0x188E65E10")]
		public static void UQQQAWHWDXP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8E65C90", Offset = "0x8E64490", VA = "0x188E65C90")]
		public static void UQAVJCAEBPO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8E65D10", Offset = "0x8E64510", VA = "0x188E65D10")]
		public static void UQGCGIUBLAX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8E65B90", Offset = "0x8E64390", VA = "0x188E65B90")]
		public static void UPQHOOMJISW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8E65C10", Offset = "0x8E64410", VA = "0x188E65C10")]
		public static void UPVOLVGGSEF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8E655A0", Offset = "0x8E63DA0", VA = "0x188E655A0")]
		public static void BLLDBAKXFYX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8E65520", Offset = "0x8E63D20", VA = "0x188E65520")]
		public static void BLFWDTQZWNO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8E53F90", Offset = "0x8E52790", VA = "0x188E53F90")]
		public static void LCCHZUHWLLB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8E54000", Offset = "0x8E52800", VA = "0x188E54000")]
		public static void LCHOXBBTUWK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8E54070", Offset = "0x8E52870", VA = "0x188E54070")]
		public static void LCMVUHVREHT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8E540E0", Offset = "0x8E528E0", VA = "0x188E540E0")]
		public static void LCSCROPONTC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8E54150", Offset = "0x8E52950", VA = "0x188E54150")]
		public static void LCXJOVJLXEL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8E541C0", Offset = "0x8E529C0", VA = "0x188E541C0")]
		public static void LDCQMCDJGPU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8E54230", Offset = "0x8E52A30", VA = "0x188E54230")]
		public static void LDHXJIXGQBD(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class UPZYFQMROJY
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool HIRMGRZMZMR;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8E76F70", Offset = "0x8E75770", VA = "0x188E76F70")]
		public static void JMZGOIXNARG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8E76EE0", Offset = "0x8E756E0", VA = "0x188E76EE0")]
		public static void BONSBSIADZT(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x28CA750", Offset = "0x28C8F50", VA = "0x1828CA750")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A270", Offset = "0x8E68A70", VA = "0x188E6A270")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A140", Offset = "0x8E68940", VA = "0x188E6A140")]
		public static DiyFp AZIDVNZOSFH(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A150", Offset = "0x8E68950", VA = "0x188E6A150")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A280", Offset = "0x8E68A80", VA = "0x188E6A280")]
		public static DiyFp YHGFAGCXEDN(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A1E0", Offset = "0x8E689E0", VA = "0x188E6A1E0")]
		public void QEMBISWJHGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A220", Offset = "0x8E68A20", VA = "0x188E6A220")]
		public static DiyFp QEMBISWJHGG(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xB22B30", Offset = "0xB21330", VA = "0x180B22B30")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8E734B0", Offset = "0x8E71CB0", VA = "0x188E734B0")]
		public void IROGDMEQWWV(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8E73630", Offset = "0x8E71E30", VA = "0x188E73630")]
		public void RCLFCYXWGAX(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8E735B0", Offset = "0x8E71DB0", VA = "0x188E735B0")]
		public void PVWFSCYPWMF(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8E73510", Offset = "0x8E71D10", VA = "0x188E73510")]
		public void PVWFSCYPWMF(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8E736B0", Offset = "0x8E71EB0", VA = "0x188E736B0")]
		public void THTIMYEASLJ(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8E733B0", Offset = "0x8E71BB0", VA = "0x188E733B0")]
		public void DPGIRGJKDFI(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class WUASAVFUAZU
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
		private static byte[] WFTRAZEGSWP;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] YPOLXHEXGRV;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] SYFJVTRTERT;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] APFOGLTISJU;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags QUHNGXGJBXF;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char INTXHKIGPOV;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int OPLHAVQRVQX;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int ZQESDGGIXDD;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] NXJHDSBDRXR;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8E7C5C0", Offset = "0x8E7ADC0", VA = "0x188E7C5C0")]
		private static byte[] YKXVQKPIILP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8E7C150", Offset = "0x8E7A950", VA = "0x188E7C150")]
		private static byte[] TWIOTFCFZXH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8E7B360", Offset = "0x8E79B60", VA = "0x188E7B360")]
		public static int OKOJWAXODFW(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8E7B240", Offset = "0x8E79A40", VA = "0x188E7B240")]
		public static int OKOJWAXODFW(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8E7B050", Offset = "0x8E79850", VA = "0x188E7B050")]
		private static bool EIKQUMNCJSU(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8E7A730", Offset = "0x8E78F30", VA = "0x188E7A730")]
		private static void BJBFZTVSCTG(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8E7BD90", Offset = "0x8E7A590", VA = "0x188E7BD90")]
		private static bool SXMXRGVGJAK(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8E7A820", Offset = "0x8E79020", VA = "0x188E7A820")]
		private static bool BJCFKLLHBIS(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8E7B140", Offset = "0x8E79940", VA = "0x188E7B140")]
		private static bool GSAXYAZSKAV(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8E7ACA0", Offset = "0x8E794A0", VA = "0x188E7ACA0")]
		private static bool DEGTARDYQCK(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8E7B8C0", Offset = "0x8E7A0C0", VA = "0x188E7B8C0")]
		private static bool SCAXLEMRNNL(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8E7C230", Offset = "0x8E7AA30", VA = "0x188E7C230")]
		private static void WXXHPWBEJBZ(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8E7B480", Offset = "0x8E79C80", VA = "0x188E7B480")]
		private static void PDFFKTMSYID(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8E7AE60", Offset = "0x8E79660", VA = "0x188E7AE60")]
		private static bool DRCXYOWSHDY(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0x8E6A940", Offset = "0x8E69140", VA = "0x188E6A940")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A8A0", Offset = "0x8E690A0", VA = "0x188E6A8A0")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A4D0", Offset = "0x8E68CD0", VA = "0x188E6A4D0")]
		public DiyFp HZGISKACLZP()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A350", Offset = "0x8E68B50", VA = "0x188E6A350")]
		public DiyFp AUWXKUUGVXU()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xC21660", Offset = "0xC1FE60", VA = "0x180C21660")]
		public ulong QPBSEJMEVTT()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A760", Offset = "0x8E68F60", VA = "0x188E6A760")]
		public double SLTNKDEPOHJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A3D0", Offset = "0x8E68BD0", VA = "0x188E6A3D0")]
		public double CKGEUBZVKNB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A680", Offset = "0x8E68E80", VA = "0x188E6A680")]
		public int NXZBGKTKPUE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A800", Offset = "0x8E69000", VA = "0x188E6A800")]
		public ulong UYFHUVCTYGG()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A7E0", Offset = "0x8E68FE0", VA = "0x188E6A7E0")]
		public bool TASNRSEKWYH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A6B0", Offset = "0x8E68EB0", VA = "0x188E6A6B0")]
		public bool PWNPLWSKTLE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A320", Offset = "0x8E68B20", VA = "0x188E6A320")]
		public bool AKFIUTZQLGQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A4A0", Offset = "0x8E68CA0", VA = "0x188E6A4A0")]
		public bool HSIQUAHMIDN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A480", Offset = "0x8E68C80", VA = "0x188E6A480")]
		public int FGIYHKFMKMG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A540", Offset = "0x8E68D40", VA = "0x188E6A540")]
		public void IMLFBLUAHKY([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A830", Offset = "0x8E69030", VA = "0x188E6A830")]
		public bool XBVJOISRVPS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3BB3930", Offset = "0x3BB2130", VA = "0x183BB3930")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A880", Offset = "0x8E69080", VA = "0x188E6A880")]
		public static int ZTYAWMSCOJJ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A470", Offset = "0x8E68C70", VA = "0x188E6A470")]
		public static double EVUKBFEALJV()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A6D0", Offset = "0x8E68ED0", VA = "0x188E6A6D0")]
		public static ulong RSAGVTBPLIO(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x15BF9C0", Offset = "0x15BE1C0", VA = "0x1815BF9C0")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8E73190", Offset = "0x8E71990", VA = "0x188E73190")]
		public DiyFp HZGISKACLZP()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xCC9230", Offset = "0xCC7A30", VA = "0x180CC9230")]
		public uint KQSUSQXRMDU()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8E73320", Offset = "0x8E71B20", VA = "0x188E73320")]
		public int NXZBGKTKPUE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8E73350", Offset = "0x8E71B50", VA = "0x188E73350")]
		public uint UYFHUVCTYGG()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8E73340", Offset = "0x8E71B40", VA = "0x188E73340")]
		public bool TASNRSEKWYH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8E731F0", Offset = "0x8E719F0", VA = "0x188E731F0")]
		public void IMLFBLUAHKY([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8E73370", Offset = "0x8E71B70", VA = "0x188E73370")]
		public bool XBVJOISRVPS()
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
		[Cpp2IlInjected.Address(RVA = "0x8E69910", Offset = "0x8E68110", VA = "0x188E69910")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class PAJFSCSOTOL
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] CACNJONKFQU;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8E70200", Offset = "0x8E6EA00", VA = "0x188E70200")]
		public static void OSBUEAKXYTQ(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8E70130", Offset = "0x8E6E930", VA = "0x188E70130")]
		public static void IHAPOMBWJUZ(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0x8E7A2B0", Offset = "0x8E78AB0", VA = "0x188E7A2B0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x585FDA0", Offset = "0x585E5A0", VA = "0x18585FDA0")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2AFE2E0", Offset = "0x2AFCAE0", VA = "0x182AFE2E0")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8E7A250", Offset = "0x8E78A50", VA = "0x188E7A250")]
		public Vector LJHBDHEZMXO(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class TEJJFZKSSYW
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] PCVHNRDPVNO;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] RZUPWZCMKKP;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int LOIMEGHQHMS;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8E74C40", Offset = "0x8E73440", VA = "0x188E74C40")]
		private static byte[] WBTVZFYAKAW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8E745E0", Offset = "0x8E72DE0", VA = "0x188E745E0")]
		private static Vector OEEAJRHOXMO(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8E74E40", Offset = "0x8E73640", VA = "0x188E74E40")]
		private static Vector YLUNXIYVJMK(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8E74060", Offset = "0x8E72860", VA = "0x188E74060")]
		private static void AQFHUSBESGX(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8E73730", Offset = "0x8E71F30", VA = "0x188E73730")]
		private static void AEIVESBNNLC(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8E74F20", Offset = "0x8E73720", VA = "0x188E74F20")]
		private static ulong ZGFXZFQRXNH(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8E740F0", Offset = "0x8E728F0", VA = "0x188E740F0")]
		private static void GBFQUAWJPMR(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8E74230", Offset = "0x8E72A30", VA = "0x188E74230")]
		private static bool KJNRDSQHCQE(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8E74AB0", Offset = "0x8E732B0", VA = "0x188E74AB0")]
		private static DiyFp TGXMQTRVSJJ(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8E73A20", Offset = "0x8E72220", VA = "0x188E73A20")]
		private static bool AGTLGEEOJHJ(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8E74D20", Offset = "0x8E73520", VA = "0x188E74D20")]
		private static bool WZBTVBKTBBT(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8E74990", Offset = "0x8E73190", VA = "0x188E74990")]
		public static double? QFNXUVMBLFD(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8E746C0", Offset = "0x8E72EC0", VA = "0x188E746C0")]
		public static float? QFDKAHYGSIL(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class XJSBXKTNZOW
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] EFPFBNDMCOW;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] SYFJVTRTERT;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] APFOGLTISJU;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] LXCEGNGTXBS;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int AHZKOCMAZAY;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] IPOVETEULSM;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int YQROLCOCWHC;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8E7E8F0", Offset = "0x8E7D0F0", VA = "0x188E7E8F0")]
		private static byte[] XCSRIKXKEBR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8E7E340", Offset = "0x8E7CB40", VA = "0x188E7E340")]
		public static bool NNHWOUIJNLC(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8E7E7B0", Offset = "0x8E7CFB0", VA = "0x188E7E7B0")]
		public static bool RCKRGOLBDQZ(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8E7E9D0", Offset = "0x8E7D1D0", VA = "0x188E7E9D0")]
		private static bool ZPCDHWBPLZA(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8E7E480", Offset = "0x8E7CC80", VA = "0x188E7E480")]
		private static bool OWZZFPZDFXH(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8E7EB00", Offset = "0x8E7D300", VA = "0x188E7EB00")]
		private static bool ZPRCMNQWTPY(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8E7E740", Offset = "0x8E7CF40", VA = "0x188E7E740")]
		private static bool PGHJBJAABDE(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8E7D340", Offset = "0x8E7BB40", VA = "0x188E7D340")]
		private static double AGOYTWFWDFL(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8E7D360", Offset = "0x8E7BB60", VA = "0x188E7D360")]
		private static double FQYEMBBSQSH(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class MNEGWZNBZCJ<a> : ZYLVUXEUPGB<a[]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly IYLXXLEYFZT<a> EPWNDRVUQDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour ICGFCBUJWAW;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x16B7A60", Offset = "0x16B6260", VA = "0x1816B7A60")]
		public MNEGWZNBZCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
		public MNEGWZNBZCJ(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x57F4680", Offset = "0x57F2E80", VA = "0x1857F4680", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x57F3C40", Offset = "0x57F2440", VA = "0x1857F3C40", Slot = "5")]
		public a[] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class EGQNSYRPELY<a> : ZYLVUXEUPGB<ArraySegment<a>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly IYLXXLEYFZT<a> EPWNDRVUQDA;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4766580", Offset = "0x4764D80", VA = "0x184766580", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4766140", Offset = "0x4764940", VA = "0x184766140", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class DDCTQAXCSZS<a> : ZYLVUXEUPGB<List<a>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour ICGFCBUJWAW;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x16B7A60", Offset = "0x16B6260", VA = "0x1816B7A60")]
		public DDCTQAXCSZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
		public DDCTQAXCSZS(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x4112D70", Offset = "0x4111570", VA = "0x184112D70", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x4112290", Offset = "0x4110A90", VA = "0x184112290", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class XERMSUVPYOC<a, b, c, d> : ZYLVUXEUPGB<d>, SIQNGTGRNUC where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3E30200", Offset = "0x3E2EA00", VA = "0x183E30200", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3E2ECA0", Offset = "0x3E2D4A0", VA = "0x183E2ECA0", Slot = "5")]
		public d Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c MCTBORJIEIS(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		protected XERMSUVPYOC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class XFHHKPDIAWD<a, b, c> : XERMSUVPYOC<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3E304F0", Offset = "0x3E2ECF0", VA = "0x183E304F0", Slot = "6")]
		protected override IEnumerator<a> MCTBORJIEIS(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		protected XFHHKPDIAWD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class XFCANIJKRKU<a, b> : XFHHKPDIAWD<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xB105D0", Offset = "0xB0EDD0", VA = "0x180B105D0", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class UKTVSIAWBYU<a, b> : XFCANIJKRKU<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x61A1420", Offset = "0x619FC20", VA = "0x1861A1420", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x61A1330", Offset = "0x619FB30", VA = "0x1861A1330", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class UIKBKOBCARV<a> : XERMSUVPYOC<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x619E690", Offset = "0x619CE90", VA = "0x18619E690", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xB105D0", Offset = "0xB0EDD0", VA = "0x180B105D0", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x58810E0", Offset = "0x587F8E0", VA = "0x1858810E0", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x45E5970", Offset = "0x45E4170", VA = "0x1845E5970", Slot = "6")]
		protected override LinkedList<a>.Enumerator MCTBORJIEIS(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class QIJAJEYKMQC<a> : XERMSUVPYOC<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4127610", Offset = "0x4125E10", VA = "0x184127610", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x41276F0", Offset = "0x4125EF0", VA = "0x1841276F0", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5BD15A0", Offset = "0x5BCFDA0", VA = "0x185BD15A0", Slot = "6")]
		protected override Queue<a>.Enumerator MCTBORJIEIS(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xB105D0", Offset = "0xB0EDD0", VA = "0x180B105D0", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class FKXHAMMLVHQ<a> : XERMSUVPYOC<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E120", Offset = "0x3E2C920", VA = "0x183E2E120", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E3A0", Offset = "0x3E2CBA0", VA = "0x183E2E3A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4D7D820", Offset = "0x4D7C020", VA = "0x184D7D820", Slot = "6")]
		protected override Stack<a>.Enumerator MCTBORJIEIS(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4D7D6C0", Offset = "0x4D7BEC0", VA = "0x184D7D6C0", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class TDUPFOEEPTM<a> : XERMSUVPYOC<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9ABB0", Offset = "0x5F993B0", VA = "0x185F9ABB0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xB105D0", Offset = "0xB0EDD0", VA = "0x180B105D0", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5F9ABF0", Offset = "0x5F993F0", VA = "0x185F9ABF0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x5F9AC50", Offset = "0x5F99450", VA = "0x185F9AC50", Slot = "6")]
		protected override HashSet<a>.Enumerator MCTBORJIEIS(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x59AAC80", Offset = "0x59A9480", VA = "0x1859AAC80")]
		public TDUPFOEEPTM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class FYCPTANJGRQ<a> : XFHHKPDIAWD<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E120", Offset = "0x3E2C920", VA = "0x183E2E120", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x4D844D0", Offset = "0x4D82CD0", VA = "0x184D844D0", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x4D84560", Offset = "0x4D82D60", VA = "0x184D84560", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class DVLVITPBXWD<a> : XFHHKPDIAWD<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x4127610", Offset = "0x4125E10", VA = "0x184127610", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x41276F0", Offset = "0x4125EF0", VA = "0x1841276F0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB105D0", Offset = "0xB0EDD0", VA = "0x180B105D0", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class GZFJUXSCZTN<a> : XFHHKPDIAWD<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x4127610", Offset = "0x4125E10", VA = "0x184127610", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x41276F0", Offset = "0x4125EF0", VA = "0x1841276F0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB105D0", Offset = "0xB0EDD0", VA = "0x180B105D0", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class PAPFIRFMYIJ<a> : XFHHKPDIAWD<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E0E0", Offset = "0x3E2C8E0", VA = "0x183E2E0E0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E3A0", Offset = "0x3E2CBA0", VA = "0x183E2E3A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x4F49E60", Offset = "0x4F48660", VA = "0x184F49E60", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x4F49E80", Offset = "0x4F48680", VA = "0x184F49E80")]
		public PAPFIRFMYIJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class AJSPDZDCSYV<a, b> : ZYLVUXEUPGB<IGrouping<a, b>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x544BE70", Offset = "0x544A670", VA = "0x18544BE70", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x544BB20", Offset = "0x544A320", VA = "0x18544BB20", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class LCHVCJVRJUA<a, b> : ZYLVUXEUPGB<ILookup<a, b>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x52EADF0", Offset = "0x52E95F0", VA = "0x1852EADF0", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x52EAAA0", Offset = "0x52E92A0", VA = "0x1852EAAA0", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class HOXRFBPXSLK<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a TVIXTBMOZHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> GQQBYZZTZGC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x4F4AD40", Offset = "0x4F49540", VA = "0x184F4AD40", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x4F4AC30", Offset = "0x4F49430", VA = "0x184F4AC30")]
		public HOXRFBPXSLK(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x4F4ABA0", Offset = "0x4F493A0", VA = "0x184F4ABA0", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x4F4AC10", Offset = "0x4F49410", VA = "0x184F4AC10", Slot = "6")]
		private IEnumerator LRASTPXJBWO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class NDICPBFMGDB<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> BCJUSDRLVDN;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x58825B0", Offset = "0x5880DB0", VA = "0x1858825B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public NDICPBFMGDB(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5882420", Offset = "0x5880C20", VA = "0x185882420", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x5882510", Offset = "0x5880D10", VA = "0x185882510", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5882510", Offset = "0x5880D10", VA = "0x185882510", Slot = "7")]
		private IEnumerator LRASTPXJBWO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class ADPYPKGLZVO<a> : ZYLVUXEUPGB<a>, SIQNGTGRNUC where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5448E10", Offset = "0x5447610", VA = "0x185448E10", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5448BF0", Offset = "0x54473F0", VA = "0x185448BF0", Slot = "5")]
		public a Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public ADPYPKGLZVO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class ACVPSYGDZSO : ZYLVUXEUPGB<IEnumerable>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly ZYLVUXEUPGB<IEnumerable> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8E66F20", Offset = "0x8E65720", VA = "0x188E66F20", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8E66D10", Offset = "0x8E65510", VA = "0x188E66D10", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public ACVPSYGDZSO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class HNBNXQULKXO : ZYLVUXEUPGB<ICollection>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly ZYLVUXEUPGB<ICollection> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8E6B1E0", Offset = "0x8E699E0", VA = "0x188E6B1E0", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8E6AFD0", Offset = "0x8E697D0", VA = "0x188E6AFD0", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public HNBNXQULKXO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class TQQYWKAROUA : ZYLVUXEUPGB<IList>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly ZYLVUXEUPGB<IList> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8E753C0", Offset = "0x8E73BC0", VA = "0x188E753C0", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8E751B0", Offset = "0x8E739B0", VA = "0x188E751B0", Slot = "5")]
		public IList Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public TQQYWKAROUA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class AQTLODZNVTZ<a> : XFCANIJKRKU<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x4127610", Offset = "0x4125E10", VA = "0x184127610", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x5239830", Offset = "0x5238030", VA = "0x185239830", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class KKVWLRDUWWF<a> : XFHHKPDIAWD<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x4127610", Offset = "0x4125E10", VA = "0x184127610", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x5239830", Offset = "0x5238030", VA = "0x185239830", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x52397C0", Offset = "0x5237FC0", VA = "0x1852397C0", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class XDNCMNAJRQB<a> : XFHHKPDIAWD<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E0A0", Offset = "0x3E2C8A0", VA = "0x183E2E0A0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E3A0", Offset = "0x3E2CBA0", VA = "0x183E2E3A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E2C0", Offset = "0x3E2CAC0", VA = "0x183E2E2C0", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public XDNCMNAJRQB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class HLNDWHXXQHD<a> : XFHHKPDIAWD<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E0A0", Offset = "0x3E2C8A0", VA = "0x183E2E0A0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E3A0", Offset = "0x3E2CBA0", VA = "0x183E2E3A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x4F49E60", Offset = "0x4F48660", VA = "0x184F49E60", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x4F49E80", Offset = "0x4F48680", VA = "0x184F49E80")]
		public HLNDWHXXQHD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class NCRECAFPJVR<a> : XFHHKPDIAWD<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x5880FF0", Offset = "0x587F7F0", VA = "0x185880FF0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xB105D0", Offset = "0xB0EDD0", VA = "0x180B105D0", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x58810E0", Offset = "0x587F8E0", VA = "0x1858810E0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class HRCWXLQYAHL<a> : XFCANIJKRKU<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x4127610", Offset = "0x4125E10", VA = "0x184127610", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x41276F0", Offset = "0x4125EF0", VA = "0x1841276F0", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class UAVHIRGJZTM<a> : XFCANIJKRKU<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4127610", Offset = "0x4125E10", VA = "0x184127610", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x41276F0", Offset = "0x4125EF0", VA = "0x1841276F0", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class WYNYILQTDDZ<a> : XFHHKPDIAWD<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E120", Offset = "0x3E2C920", VA = "0x183E2E120", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E3A0", Offset = "0x3E2CBA0", VA = "0x183E2E3A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x66CB6F0", Offset = "0x66C9EF0", VA = "0x1866CB6F0", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class KNVKSKKAAOC
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
		[Cpp2IlInjected.Address(RVA = "0x8E6D000", Offset = "0x8E6B800", VA = "0x188E6D000")]
		public static DateTime WVYEGMSAMIW(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8E6CE50", Offset = "0x8E6B650", VA = "0x188E6CE50")]
		public static bool UGRVFQOTVDL(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8E6D2D0", Offset = "0x8E6BAD0", VA = "0x188E6D2D0")]
		public static bool WZVGORGKKQR(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8E6D0C0", Offset = "0x8E6B8C0", VA = "0x188E6D0C0")]
		public static bool WZVGORGKKQR(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8E6D560", Offset = "0x8E6BD60", VA = "0x188E6D560")]
		public static bool ZVPMNRMPWAD(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class VMJIUBMXXQK : ZYLVUXEUPGB<DateTime>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly ZYLVUXEUPGB<DateTime> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8E79160", Offset = "0x8E77960", VA = "0x188E79160", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8E78BE0", Offset = "0x8E773E0", VA = "0x188E78BE0", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8E78D60", Offset = "0x8E77560", VA = "0x188E78D60")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public VMJIUBMXXQK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class CIQYVHEMWHZ : ZYLVUXEUPGB<DateTimeOffset>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly ZYLVUXEUPGB<DateTimeOffset> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8E68E10", Offset = "0x8E67610", VA = "0x188E68E10", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8E689C0", Offset = "0x8E671C0", VA = "0x188E689C0", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8E68A30", Offset = "0x8E67230", VA = "0x188E68A30")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public CIQYVHEMWHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class ANPBGBZOUSO : ZYLVUXEUPGB<TimeSpan>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly ZYLVUXEUPGB<TimeSpan> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] JPOYRAHGLYG;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8E67AB0", Offset = "0x8E662B0", VA = "0x188E67AB0", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8E67640", Offset = "0x8E65E40", VA = "0x188E67640", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8E676C0", Offset = "0x8E65EC0", VA = "0x188E676C0")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public ANPBGBZOUSO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class LMYYZTUTNUV<a, b, c, d, e> : ZYLVUXEUPGB<e>, SIQNGTGRNUC where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x52F2040", Offset = "0x52F0840", VA = "0x1852F2040", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x52F0520", Offset = "0x52EED20", VA = "0x1852F0520", Slot = "5")]
		public e Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d MCTBORJIEIS(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		protected LMYYZTUTNUV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class LMTSCNAWEJM<a, b, c, d> : LMYYZTUTNUV<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3E304F0", Offset = "0x3E2ECF0", VA = "0x183E304F0", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> MCTBORJIEIS(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		protected LMTSCNAWEJM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class LNJMUHIOGRN<a, b, c> : LMTSCNAWEJM<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xB105D0", Offset = "0xB0EDD0", VA = "0x180B105D0", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class ALFZKQQQGDH<a, b> : LMYYZTUTNUV<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x544C3A0", Offset = "0x544ABA0", VA = "0x18544C3A0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xB105D0", Offset = "0xB0EDD0", VA = "0x180B105D0", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x544C680", Offset = "0x544AE80", VA = "0x18544C680", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x544C740", Offset = "0x544AF40", VA = "0x18544C740", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator MCTBORJIEIS(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x536BEB0", Offset = "0x536A6B0", VA = "0x18536BEB0")]
		public ALFZKQQQGDH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class JNNFPPUAPXZ<a, b, c> : LNJMUHIOGRN<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x50D4240", Offset = "0x50D2A40", VA = "0x1850D4240", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x50D4420", Offset = "0x50D2C20", VA = "0x1850D4420", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class TJTKZNYJALY<a, b> : LMTSCNAWEJM<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x4128410", Offset = "0x4126C10", VA = "0x184128410", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x4F4CFB0", Offset = "0x4F4B7B0", VA = "0x184F4CFB0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB105D0", Offset = "0xB0EDD0", VA = "0x180B105D0", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class HUOIZKVTTGO<a, b> : LNJMUHIOGRN<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x4128410", Offset = "0x4126C10", VA = "0x184128410", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x4F4CFB0", Offset = "0x4F4B7B0", VA = "0x184F4CFB0", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class ICSNJEBYNXM<a, b> : LMYYZTUTNUV<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x4128410", Offset = "0x4126C10", VA = "0x184128410", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB105D0", Offset = "0xB0EDD0", VA = "0x180B105D0", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x4F4CFB0", Offset = "0x4F4B7B0", VA = "0x184F4CFB0", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x4FF8B50", Offset = "0x4FF7350", VA = "0x184FF8B50", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator MCTBORJIEIS(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class DWVVVLDDFBF<a, b> : LMTSCNAWEJM<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x4128410", Offset = "0x4126C10", VA = "0x184128410", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x4128580", Offset = "0x4126D80", VA = "0x184128580", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x41285F0", Offset = "0x4126DF0", VA = "0x1841285F0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class BLOTVQYDSQI<a, b> : LMTSCNAWEJM<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C660", Offset = "0x6F6AE60", VA = "0x186F6C660", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xB105D0", Offset = "0xB0EDD0", VA = "0x180B105D0", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F6C6A0", Offset = "0x6F6AEA0", VA = "0x186F6C6A0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x59AAC80", Offset = "0x59A9480", VA = "0x1859AAC80")]
		public BLOTVQYDSQI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class IDMVMSMCMCW<a, b> : LNJMUHIOGRN<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x4FF9560", Offset = "0x4FF7D60", VA = "0x184FF9560", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x4F4CFB0", Offset = "0x4F4B7B0", VA = "0x184F4CFB0", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class PHEMPXOFMEM<a> : ZYLVUXEUPGB<a>, SIQNGTGRNUC where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x5AB10C0", Offset = "0x5AAF8C0", VA = "0x185AB10C0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0E90", Offset = "0x5AAF690", VA = "0x185AB0E90", Slot = "5")]
		public a Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public PHEMPXOFMEM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class MCPNSKVLTZS : ZYLVUXEUPGB<IDictionary>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly ZYLVUXEUPGB<IDictionary> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8E6E550", Offset = "0x8E6CD50", VA = "0x188E6E550", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8E6E370", Offset = "0x8E6CB70", VA = "0x188E6E370", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public MCPNSKVLTZS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class RQMZGDEWXAQ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8E727C0", Offset = "0x8E70FC0", VA = "0x188E727C0")]
		public static object XVDLAGBSKAW(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8E71FE0", Offset = "0x8E707E0", VA = "0x188E71FE0")]
		public static object PKSJSUHYDSX(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class ZZCQBNXRBGP<a> : ZYLVUXEUPGB<a>, SIQNGTGRNUC, LUUIWFVVYKQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class OVYXGTZWSNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type FDULPSXRSFR;

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public OVYXGTZWSNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x59F1E70", Offset = "0x59F0670", VA = "0x1859F1E70")]
			internal bool WMIRYNFTCJI(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class OVTQJNFZJCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string PAOJDCVZNCJ;

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public OVTQJNFZJCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x59F03C0", Offset = "0x59EEBC0", VA = "0x1859F03C0")]
			internal bool WMNYVTZQLUR(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class OVOJMGMBZQT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> HUHGMOLKTDY;

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public OVOJMGMBZQT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x59EF8C0", Offset = "0x59EE0C0", VA = "0x1859EF8C0")]
			internal void WLYEDZRYJMQ(JsonWriter a, a b, QCUUQNTWJRO c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class OVJCOZSEQFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> GKECGRBLJFF;

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public OVJCOZSEQFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x59EF2E0", Offset = "0x59EDAE0", VA = "0x1859EF2E0")]
			internal a WMDLBGLVSXZ(JsonReader a, QCUUQNTWJRO b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly ZIBDEUNUIAS<a> YHAHFQZGWVH;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> UJKNXANDSEX;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> PLPVEKSUTNL;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> TAKKZNSHIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool DRPQGPPNBKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> OTGPBGCWRQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> QOXOZVWOEMN;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x3E914B0", Offset = "0x3E8FCB0", VA = "0x183E914B0")]
		static ZZCQBNXRBGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5930", Offset = "0x3EA4130", VA = "0x183EA5930")]
		public ZZCQBNXRBGP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x3E8A0E0", Offset = "0x3E888E0", VA = "0x183E8A0E0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x3E874F0", Offset = "0x3E85CF0", VA = "0x183E874F0", Slot = "5")]
		public a Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x3E8C730", Offset = "0x3E8AF30", VA = "0x183E8C730", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, a b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x3E8D1D0", Offset = "0x3E8B9D0", VA = "0x183E8D1D0", Slot = "7")]
		public a VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class GQFJEXUBABP<a> : ZYLVUXEUPGB<a[,]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x4EA1CA0", Offset = "0x4EA04A0", VA = "0x184EA1CA0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x4EA1910", Offset = "0x4EA0110", VA = "0x184EA1910", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public GQFJEXUBABP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class SGGMBWNZHYT<a> : ZYLVUXEUPGB<a[,,]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E62FF0", Offset = "0x5E617F0", VA = "0x185E62FF0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E62B20", Offset = "0x5E61320", VA = "0x185E62B20", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public SGGMBWNZHYT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class MHGKPKWRRXD<a> : ZYLVUXEUPGB<a[,,,]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x57EDE50", Offset = "0x57EC650", VA = "0x1857EDE50", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x57ED850", Offset = "0x57EC050", VA = "0x1857ED850", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public MHGKPKWRRXD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class ZXSBUCNYXFZ<a> : ZYLVUXEUPGB<a?>, SIQNGTGRNUC where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x3E84D40", Offset = "0x3E83540", VA = "0x183E84D40", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x3E84860", Offset = "0x3E83060", VA = "0x183E84860", Slot = "5")]
		public a? Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public ZXSBUCNYXFZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class WERQEFCNZGZ<a> : ZYLVUXEUPGB<a?>, SIQNGTGRNUC where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly ZYLVUXEUPGB<a> FXKEWONMIJU;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		public WERQEFCNZGZ(ZYLVUXEUPGB<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x66AF320", Offset = "0x66ADB20", VA = "0x1866AF320", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x66AEDB0", Offset = "0x66AD5B0", VA = "0x1866AEDB0", Slot = "5")]
		public a? Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class OQYUJWTHSNS : ZYLVUXEUPGB<sbyte>, SIQNGTGRNUC, LUUIWFVVYKQ<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly OQYUJWTHSNS BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8E6FEA0", Offset = "0x8E6E6A0", VA = "0x188E6FEA0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8E6FE90", Offset = "0x8E6E690", VA = "0x188E6FE90", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8E6FF30", Offset = "0x8E6E730", VA = "0x188E6FF30", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, sbyte b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8E70040", Offset = "0x8E6E840", VA = "0x188E70040", Slot = "7")]
		public sbyte VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public OQYUJWTHSNS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class UOVUYGJIRND : ZYLVUXEUPGB<sbyte?>, SIQNGTGRNUC, LUUIWFVVYKQ<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly UOVUYGJIRND BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8E767E0", Offset = "0x8E74FE0", VA = "0x188E767E0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8E76770", Offset = "0x8E74F70", VA = "0x188E76770", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8E768D0", Offset = "0x8E750D0", VA = "0x188E768D0", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, sbyte? b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8E76A30", Offset = "0x8E75230", VA = "0x188E76A30", Slot = "7")]
		public sbyte? VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public UOVUYGJIRND()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class GTCMCIDLUPR : ZYLVUXEUPGB<sbyte[]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly GTCMCIDLUPR BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8E6AD30", Offset = "0x8E69530", VA = "0x188E6AD30", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8E6ABF0", Offset = "0x8E693F0", VA = "0x188E6ABF0", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public GTCMCIDLUPR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class UCFTIXFPQNN : ZYLVUXEUPGB<short>, SIQNGTGRNUC, LUUIWFVVYKQ<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly UCFTIXFPQNN BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8E764E0", Offset = "0x8E74CE0", VA = "0x188E764E0", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8E764D0", Offset = "0x8E74CD0", VA = "0x188E764D0", Slot = "5")]
		public short Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8E76570", Offset = "0x8E74D70", VA = "0x188E76570", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, short b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8E76680", Offset = "0x8E74E80", VA = "0x188E76680", Slot = "7")]
		public short VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public UCFTIXFPQNN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class AQEDZQMJOJE : ZYLVUXEUPGB<short?>, SIQNGTGRNUC, LUUIWFVVYKQ<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly AQEDZQMJOJE BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8E68230", Offset = "0x8E66A30", VA = "0x188E68230", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8E681C0", Offset = "0x8E669C0", VA = "0x188E681C0", Slot = "5")]
		public short? Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8E68320", Offset = "0x8E66B20", VA = "0x188E68320", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, short? b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8E68480", Offset = "0x8E66C80", VA = "0x188E68480", Slot = "7")]
		public short? VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public AQEDZQMJOJE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class DPCZYILPBEC : ZYLVUXEUPGB<short[]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly DPCZYILPBEC BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8E69A60", Offset = "0x8E68260", VA = "0x188E69A60", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8E69920", Offset = "0x8E68120", VA = "0x188E69920", Slot = "5")]
		public short[] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public DPCZYILPBEC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class GGZNJYMJEUF : ZYLVUXEUPGB<int>, SIQNGTGRNUC, LUUIWFVVYKQ<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly GGZNJYMJEUF BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A960", Offset = "0x8E69160", VA = "0x188E6A960", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A950", Offset = "0x8E69150", VA = "0x188E6A950", Slot = "5")]
		public int Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8E6A9F0", Offset = "0x8E691F0", VA = "0x188E6A9F0", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, int b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8E6AB00", Offset = "0x8E69300", VA = "0x188E6AB00", Slot = "7")]
		public int VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public GGZNJYMJEUF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class XDTLBEUIUEA : ZYLVUXEUPGB<int?>, SIQNGTGRNUC, LUUIWFVVYKQ<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly XDTLBEUIUEA BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8E7CBD0", Offset = "0x8E7B3D0", VA = "0x188E7CBD0", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8E7CB60", Offset = "0x8E7B360", VA = "0x188E7CB60", Slot = "5")]
		public int? Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8E7CCC0", Offset = "0x8E7B4C0", VA = "0x188E7CCC0", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, int? b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8E7CE20", Offset = "0x8E7B620", VA = "0x188E7CE20", Slot = "7")]
		public int? VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public XDTLBEUIUEA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class XGULQZSTPOQ : ZYLVUXEUPGB<int[]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly XGULQZSTPOQ BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8E7D0A0", Offset = "0x8E7B8A0", VA = "0x188E7D0A0", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8E7CF60", Offset = "0x8E7B760", VA = "0x188E7CF60", Slot = "5")]
		public int[] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public XGULQZSTPOQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class LUIVDPIQKXS : ZYLVUXEUPGB<long>, SIQNGTGRNUC, LUUIWFVVYKQ<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly LUIVDPIQKXS BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8E6DE60", Offset = "0x8E6C660", VA = "0x188E6DE60", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8E6DE50", Offset = "0x8E6C650", VA = "0x188E6DE50", Slot = "5")]
		public long Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8E6DEC0", Offset = "0x8E6C6C0", VA = "0x188E6DEC0", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, long b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8E6DF90", Offset = "0x8E6C790", VA = "0x188E6DF90", Slot = "7")]
		public long VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public LUIVDPIQKXS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class ZKJBTKGRSSN : ZYLVUXEUPGB<long?>, SIQNGTGRNUC, LUUIWFVVYKQ<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly ZKJBTKGRSSN BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x8E80020", Offset = "0x8E7E820", VA = "0x188E80020", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8E7FF90", Offset = "0x8E7E790", VA = "0x188E7FF90", Slot = "5")]
		public long? Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8E800E0", Offset = "0x8E7E8E0", VA = "0x188E800E0", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, long? b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8E80210", Offset = "0x8E7EA10", VA = "0x188E80210", Slot = "7")]
		public long? VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public ZKJBTKGRSSN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class QARHIHPGIBZ : ZYLVUXEUPGB<long[]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly QARHIHPGIBZ BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8E71B10", Offset = "0x8E70310", VA = "0x188E71B10", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8E719D0", Offset = "0x8E701D0", VA = "0x188E719D0", Slot = "5")]
		public long[] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public QARHIHPGIBZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class LLBKQGXQLAV : ZYLVUXEUPGB<byte>, SIQNGTGRNUC, LUUIWFVVYKQ<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly LLBKQGXQLAV BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8E6D9D0", Offset = "0x8E6C1D0", VA = "0x188E6D9D0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8E6D9C0", Offset = "0x8E6C1C0", VA = "0x188E6D9C0", Slot = "5")]
		public byte Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8E6DA60", Offset = "0x8E6C260", VA = "0x188E6DA60", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, byte b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8E6DB70", Offset = "0x8E6C370", VA = "0x188E6DB70", Slot = "7")]
		public byte VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public LLBKQGXQLAV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class JAJIBOOAYWC : ZYLVUXEUPGB<byte?>, SIQNGTGRNUC, LUUIWFVVYKQ<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly JAJIBOOAYWC BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8E6BF80", Offset = "0x8E6A780", VA = "0x188E6BF80", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8E6BF10", Offset = "0x8E6A710", VA = "0x188E6BF10", Slot = "5")]
		public byte? Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8E6C070", Offset = "0x8E6A870", VA = "0x188E6C070", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, byte? b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8E6C1D0", Offset = "0x8E6A9D0", VA = "0x188E6C1D0", Slot = "7")]
		public byte? VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public JAJIBOOAYWC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class REQALWMENTE : ZYLVUXEUPGB<ushort>, SIQNGTGRNUC, LUUIWFVVYKQ<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly REQALWMENTE BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8E71D50", Offset = "0x8E70550", VA = "0x188E71D50", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8E71D40", Offset = "0x8E70540", VA = "0x188E71D40", Slot = "5")]
		public ushort Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8E71DE0", Offset = "0x8E705E0", VA = "0x188E71DE0", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, ushort b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8E71EF0", Offset = "0x8E706F0", VA = "0x188E71EF0", Slot = "7")]
		public ushort VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public REQALWMENTE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class BXSZWZDMYVX : ZYLVUXEUPGB<ushort?>, SIQNGTGRNUC, LUUIWFVVYKQ<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly BXSZWZDMYVX BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8E68630", Offset = "0x8E66E30", VA = "0x188E68630", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8E685C0", Offset = "0x8E66DC0", VA = "0x188E685C0", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8E68720", Offset = "0x8E66F20", VA = "0x188E68720", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, ushort? b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8E68880", Offset = "0x8E67080", VA = "0x188E68880", Slot = "7")]
		public ushort? VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public BXSZWZDMYVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class HPAEZTTWWLX : ZYLVUXEUPGB<ushort[]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly HPAEZTTWWLX BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x8E6B7D0", Offset = "0x8E69FD0", VA = "0x188E6B7D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8E6B690", Offset = "0x8E69E90", VA = "0x188E6B690", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public HPAEZTTWWLX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class XDNBRQASQQA : ZYLVUXEUPGB<uint>, SIQNGTGRNUC, LUUIWFVVYKQ<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly XDNBRQASQQA BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8E7C8D0", Offset = "0x8E7B0D0", VA = "0x188E7C8D0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8E7C8C0", Offset = "0x8E7B0C0", VA = "0x188E7C8C0", Slot = "5")]
		public uint Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8E7C960", Offset = "0x8E7B160", VA = "0x188E7C960", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, uint b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8E7CA70", Offset = "0x8E7B270", VA = "0x188E7CA70", Slot = "7")]
		public uint VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public XDNBRQASQQA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class ZTGKPUOBQLN : ZYLVUXEUPGB<uint?>, SIQNGTGRNUC, LUUIWFVVYKQ<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly ZTGKPUOBQLN BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8E803A0", Offset = "0x8E7EBA0", VA = "0x188E803A0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8E80330", Offset = "0x8E7EB30", VA = "0x188E80330", Slot = "5")]
		public uint? Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x8E80490", Offset = "0x8E7EC90", VA = "0x188E80490", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, uint? b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8E805F0", Offset = "0x8E7EDF0", VA = "0x188E805F0", Slot = "7")]
		public uint? VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public ZTGKPUOBQLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class PVCLUHCLHNN : ZYLVUXEUPGB<uint[]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly PVCLUHCLHNN BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x8E71730", Offset = "0x8E6FF30", VA = "0x188E71730", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8E715F0", Offset = "0x8E6FDF0", VA = "0x188E715F0", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public PVCLUHCLHNN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class JWOZLNGGKZH : ZYLVUXEUPGB<ulong>, SIQNGTGRNUC, LUUIWFVVYKQ<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly JWOZLNGGKZH BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8E6C650", Offset = "0x8E6AE50", VA = "0x188E6C650", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8E6C640", Offset = "0x8E6AE40", VA = "0x188E6C640", Slot = "5")]
		public ulong Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8E6C6B0", Offset = "0x8E6AEB0", VA = "0x188E6C6B0", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, ulong b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8E6C780", Offset = "0x8E6AF80", VA = "0x188E6C780", Slot = "7")]
		public ulong VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public JWOZLNGGKZH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class ZVFTTKTSYHM : ZYLVUXEUPGB<ulong?>, SIQNGTGRNUC, LUUIWFVVYKQ<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly ZVFTTKTSYHM BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8E807C0", Offset = "0x8E7EFC0", VA = "0x188E807C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x8E80730", Offset = "0x8E7EF30", VA = "0x188E80730", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8E80880", Offset = "0x8E7F080", VA = "0x188E80880", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, ulong? b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8E809B0", Offset = "0x8E7F1B0", VA = "0x188E809B0", Slot = "7")]
		public ulong? VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public ZVFTTKTSYHM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class UPSUWNZYVXC : ZYLVUXEUPGB<ulong[]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly UPSUWNZYVXC BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8E76CB0", Offset = "0x8E754B0", VA = "0x188E76CB0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8E76B70", Offset = "0x8E75370", VA = "0x188E76B70", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public UPSUWNZYVXC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class MCOGDCZCCPB : ZYLVUXEUPGB<float>, SIQNGTGRNUC, LUUIWFVVYKQ<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly MCOGDCZCCPB BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8E6E190", Offset = "0x8E6C990", VA = "0x188E6E190", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8E6E180", Offset = "0x8E6C980", VA = "0x188E6E180", Slot = "5")]
		public float Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8E6E1F0", Offset = "0x8E6C9F0", VA = "0x188E6E1F0", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, float b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x8E6E2C0", Offset = "0x8E6CAC0", VA = "0x188E6E2C0", Slot = "7")]
		public float VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public MCOGDCZCCPB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class TVRLVPGNZCM : ZYLVUXEUPGB<float?>, SIQNGTGRNUC, LUUIWFVVYKQ<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly TVRLVPGNZCM BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x8E75850", Offset = "0x8E74050", VA = "0x188E75850", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8E757E0", Offset = "0x8E73FE0", VA = "0x188E757E0", Slot = "5")]
		public float? Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x8E75910", Offset = "0x8E74110", VA = "0x188E75910", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, float? b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8E75A30", Offset = "0x8E74230", VA = "0x188E75A30", Slot = "7")]
		public float? VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public TVRLVPGNZCM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class VRGTKTOGJQK : ZYLVUXEUPGB<float[]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly VRGTKTOGJQK BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8E79EC0", Offset = "0x8E786C0", VA = "0x188E79EC0", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8E79D80", Offset = "0x8E78580", VA = "0x188E79D80", Slot = "5")]
		public float[] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public VRGTKTOGJQK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class NHSLRIJSDAU : ZYLVUXEUPGB<double>, SIQNGTGRNUC, LUUIWFVVYKQ<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly NHSLRIJSDAU BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8E6F9A0", Offset = "0x8E6E1A0", VA = "0x188E6F9A0", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8E6F990", Offset = "0x8E6E190", VA = "0x188E6F990", Slot = "5")]
		public double Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8E6FA00", Offset = "0x8E6E200", VA = "0x188E6FA00", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, double b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8E6FAD0", Offset = "0x8E6E2D0", VA = "0x188E6FAD0", Slot = "7")]
		public double VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public NHSLRIJSDAU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class ANIEKVQSARJ : ZYLVUXEUPGB<double?>, SIQNGTGRNUC, LUUIWFVVYKQ<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly ANIEKVQSARJ BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8E67330", Offset = "0x8E65B30", VA = "0x188E67330", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8E672A0", Offset = "0x8E65AA0", VA = "0x188E672A0", Slot = "5")]
		public double? Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8E673F0", Offset = "0x8E65BF0", VA = "0x188E673F0", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, double? b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8E67520", Offset = "0x8E65D20", VA = "0x188E67520", Slot = "7")]
		public double? VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public ANIEKVQSARJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class ZZANIPQGQEL : ZYLVUXEUPGB<double[]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly ZZANIPQGQEL BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8E80DC0", Offset = "0x8E7F5C0", VA = "0x188E80DC0", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8E80C80", Offset = "0x8E7F480", VA = "0x188E80C80", Slot = "5")]
		public double[] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public ZZANIPQGQEL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class KBTVMNCUSYZ : ZYLVUXEUPGB<bool>, SIQNGTGRNUC, LUUIWFVVYKQ<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly KBTVMNCUSYZ BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8E6C840", Offset = "0x8E6B040", VA = "0x188E6C840", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8E6C830", Offset = "0x8E6B030", VA = "0x188E6C830", Slot = "5")]
		public bool Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8E6C8A0", Offset = "0x8E6B0A0", VA = "0x188E6C8A0", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, bool b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8E6C970", Offset = "0x8E6B170", VA = "0x188E6C970", Slot = "7")]
		public bool VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public KBTVMNCUSYZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class MDIXPYKTJPK : ZYLVUXEUPGB<bool?>, SIQNGTGRNUC, LUUIWFVVYKQ<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly MDIXPYKTJPK BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8E6EC20", Offset = "0x8E6D420", VA = "0x188E6EC20", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8E6EBB0", Offset = "0x8E6D3B0", VA = "0x188E6EBB0", Slot = "5")]
		public bool? Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8E6ECE0", Offset = "0x8E6D4E0", VA = "0x188E6ECE0", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, bool? b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x8E6EE00", Offset = "0x8E6D600", VA = "0x188E6EE00", Slot = "7")]
		public bool? VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public MDIXPYKTJPK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class MPHTQGGBPYQ : ZYLVUXEUPGB<bool[]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly MPHTQGGBPYQ BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x8E6F600", Offset = "0x8E6DE00", VA = "0x188E6F600", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x8E6F4C0", Offset = "0x8E6DCC0", VA = "0x188E6F4C0", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public MPHTQGGBPYQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class UAQWTLIJKZK : ZYLVUXEUPGB<byte[]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly ZYLVUXEUPGB<byte[]> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x8E763A0", Offset = "0x8E74BA0", VA = "0x188E763A0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x8E76330", Offset = "0x8E74B30", VA = "0x188E76330", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public UAQWTLIJKZK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class WSUKNSFPLMD : ZYLVUXEUPGB<ArraySegment<byte>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly ZYLVUXEUPGB<ArraySegment<byte>> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x8E7A590", Offset = "0x8E78D90", VA = "0x188E7A590", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x8E7A4C0", Offset = "0x8E78CC0", VA = "0x188E7A4C0", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public WSUKNSFPLMD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class LWAODQICNWH : ZYLVUXEUPGB<string>, SIQNGTGRNUC, LUUIWFVVYKQ<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly ZYLVUXEUPGB<string> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8E6E050", Offset = "0x8E6C850", VA = "0x188E6E050", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8E6E040", Offset = "0x8E6C840", VA = "0x188E6E040", Slot = "5")]
		public string Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8E6E0B0", Offset = "0x8E6C8B0", VA = "0x188E6E0B0", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, string b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8E6E040", Offset = "0x8E6C840", VA = "0x188E6E040", Slot = "7")]
		public string VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public LWAODQICNWH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class PUCXNNHEQXQ : ZYLVUXEUPGB<string[]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly PUCXNNHEQXQ BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8E713C0", Offset = "0x8E6FBC0", VA = "0x188E713C0", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x8E71270", Offset = "0x8E6FA70", VA = "0x188E71270", Slot = "5")]
		public string[] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public PUCXNNHEQXQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class TGYTCGRTVCP : ZYLVUXEUPGB<char>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly TGYTCGRTVCP BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8E75090", Offset = "0x8E73890", VA = "0x188E75090", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8E75060", Offset = "0x8E73860", VA = "0x188E75060", Slot = "5")]
		public char Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public TGYTCGRTVCP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class VHGMNEIPLCI : ZYLVUXEUPGB<char?>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly VHGMNEIPLCI BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8E78A70", Offset = "0x8E77270", VA = "0x188E78A70", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x8E789B0", Offset = "0x8E771B0", VA = "0x188E789B0", Slot = "5")]
		public char? Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public VHGMNEIPLCI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class DZKGOMSPZVQ : ZYLVUXEUPGB<char[]>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly DZKGOMSPZVQ BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8E69E90", Offset = "0x8E68690", VA = "0x188E69E90", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8E69D00", Offset = "0x8E68500", VA = "0x188E69D00", Slot = "5")]
		public char[] Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public DZKGOMSPZVQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class KCYBZJZZJCY : ZYLVUXEUPGB<Guid>, SIQNGTGRNUC, LUUIWFVVYKQ<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly ZYLVUXEUPGB<Guid> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8E6CA80", Offset = "0x8E6B280", VA = "0x188E6CA80", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8E6CA20", Offset = "0x8E6B220", VA = "0x188E6CA20", Slot = "5")]
		public Guid Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8E6CBF0", Offset = "0x8E6B3F0", VA = "0x188E6CBF0", Slot = "6")]
		public void ULWLNFSULXC(JsonWriter a, Guid b, QCUUQNTWJRO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8E6CD70", Offset = "0x8E6B570", VA = "0x188E6CD70", Slot = "7")]
		public Guid VHSJIIQBZJW(JsonReader a, QCUUQNTWJRO b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public KCYBZJZZJCY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class MIBOZZQIUKQ : ZYLVUXEUPGB<decimal>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly ZYLVUXEUPGB<decimal> BIGUOPIZRYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool BPQWUUEXOXQ;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7256610", Offset = "0x7254E10", VA = "0x187256610")]
		public MIBOZZQIUKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xD904D0", Offset = "0xD8ECD0", VA = "0x180D904D0")]
		public MIBOZZQIUKQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8E6F0E0", Offset = "0x8E6D8E0", VA = "0x188E6F0E0", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x8E6EF10", Offset = "0x8E6D710", VA = "0x188E6EF10", Slot = "5")]
		public decimal Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class WPTIDIYEVNZ : ZYLVUXEUPGB<Uri>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly ZYLVUXEUPGB<Uri> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8E7A370", Offset = "0x8E78B70", VA = "0x188E7A370", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8E7A2F0", Offset = "0x8E78AF0", VA = "0x188E7A2F0", Slot = "5")]
		public Uri Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public WPTIDIYEVNZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class ZVXFEAHBYKJ : ZYLVUXEUPGB<Version>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly ZYLVUXEUPGB<Version> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8E80B50", Offset = "0x8E7F350", VA = "0x188E80B50", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x8E80AD0", Offset = "0x8E7F2D0", VA = "0x188E80AD0", Slot = "5")]
		public Version Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public ZVXFEAHBYKJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class MCIXKHYGQWZ<a, b> : ZYLVUXEUPGB<KeyValuePair<a, b>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x57E61E0", Offset = "0x57E49E0", VA = "0x1857E61E0", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x57E5D10", Offset = "0x57E4510", VA = "0x1857E5D10", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class MLGHCNJGAYZ : ZYLVUXEUPGB<StringBuilder>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly ZYLVUXEUPGB<StringBuilder> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8E6F3B0", Offset = "0x8E6DBB0", VA = "0x188E6F3B0", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8E6F330", Offset = "0x8E6DB30", VA = "0x188E6F330", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public MLGHCNJGAYZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class OCNRYBIFRCD : ZYLVUXEUPGB<BitArray>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly ZYLVUXEUPGB<BitArray> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8E6FCA0", Offset = "0x8E6E4A0", VA = "0x188E6FCA0", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8E6FB80", Offset = "0x8E6E380", VA = "0x188E6FB80", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public OCNRYBIFRCD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class IMBTGBMTZLV : ZYLVUXEUPGB<Type>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly IMBTGBMTZLV BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex OJYJNFBXEQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool KICAYGMUUGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool KCYGXOEKRKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool DDINJHYYJZQ;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8E6BD50", Offset = "0x8E6A550", VA = "0x188E6BD50")]
		public IMBTGBMTZLV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x81BC6E0", Offset = "0x81BAEE0", VA = "0x1881BC6E0")]
		public IMBTGBMTZLV(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8E6BB80", Offset = "0x8E6A380", VA = "0x188E6BB80", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x8E6BA70", Offset = "0x8E6A270", VA = "0x188E6BA70", Slot = "5")]
		public Type Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class SIWXVGCGLML : ZYLVUXEUPGB<BigInteger>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ZYLVUXEUPGB<BigInteger> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8E73050", Offset = "0x8E71850", VA = "0x188E73050", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8E72FA0", Offset = "0x8E717A0", VA = "0x188E72FA0", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public SIWXVGCGLML()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class KVAIKFQKIUJ : ZYLVUXEUPGB<Complex>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly ZYLVUXEUPGB<Complex> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8E6D820", Offset = "0x8E6C020", VA = "0x188E6D820", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8E6D790", Offset = "0x8E6BF90", VA = "0x188E6D790", Slot = "5")]
		public Complex Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public KVAIKFQKIUJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class JJPSQMFKYJV : ZYLVUXEUPGB<ExpandoObject>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly ZYLVUXEUPGB<ExpandoObject> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8E6C540", Offset = "0x8E6AD40", VA = "0x188E6C540", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8E6C310", Offset = "0x8E6AB10", VA = "0x188E6C310", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public JJPSQMFKYJV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class AIWNWYCUVVY<a> : ZYLVUXEUPGB<Lazy<a>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x544B8F0", Offset = "0x544A0F0", VA = "0x18544B8F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x544B770", Offset = "0x5449F70", VA = "0x18544B770", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class LRZQQNMFVWC : ZYLVUXEUPGB<Task>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly ZYLVUXEUPGB<Task> BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task JKDGAFCOPQF;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8E6DD10", Offset = "0x8E6C510", VA = "0x188E6DD10", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8E6DC60", Offset = "0x8E6C460", VA = "0x188E6DC60", Slot = "5")]
		public Task Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public LRZQQNMFVWC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class FKHMQKMKBOU<a> : ZYLVUXEUPGB<Task<a>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x4D7D4E0", Offset = "0x4D7BCE0", VA = "0x184D7D4E0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x4D7D2F0", Offset = "0x4D7BAF0", VA = "0x184D7D2F0", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class SGDPVAXNPTA<a> : ZYLVUXEUPGB<ValueTask<a>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E620C0", Offset = "0x5E608C0", VA = "0x185E620C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5E61F20", Offset = "0x5E60720", VA = "0x185E61F20", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class SFOSWIUREIE<a> : ZYLVUXEUPGB<Tuple<a>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E60C10", Offset = "0x5E5F410", VA = "0x185E60C10", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E60940", Offset = "0x5E5F140", VA = "0x185E60940", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class SGENODCJGQF<a, b> : ZYLVUXEUPGB<Tuple<a, b>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E62610", Offset = "0x5E60E10", VA = "0x185E62610", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E621F0", Offset = "0x5E609F0", VA = "0x185E621F0", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class SFZGQWILXEW<a, b, c> : ZYLVUXEUPGB<Tuple<a, b, c>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E618B0", Offset = "0x5E600B0", VA = "0x185E618B0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E61350", Offset = "0x5E5FB50", VA = "0x185E61350", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class SEYYEOMZCAD<a, b, c, d> : ZYLVUXEUPGB<Tuple<a, b, c, d>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D5E0", Offset = "0x5E5BDE0", VA = "0x185E5D5E0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CF20", Offset = "0x5E5B720", VA = "0x185E5CF20", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class SETRHHTBSOU<a, b, c, d, e> : ZYLVUXEUPGB<Tuple<a, b, c, d, e>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C5E0", Offset = "0x5E5ADE0", VA = "0x185E5C5E0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E5BDD0", Offset = "0x5E5A5D0", VA = "0x185E5BDD0", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class SFJLZCATUWV<a, b, c, d, e, f> : ZYLVUXEUPGB<Tuple<a, b, c, d, e, f>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FE90", Offset = "0x5E5E690", VA = "0x185E5FE90", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F500", Offset = "0x5E5DD00", VA = "0x185E5F500", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class SFEFBVGWLLM<a, b, c, d, e, f, g> : ZYLVUXEUPGB<Tuple<a, b, c, d, e, f, g>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E8E0", Offset = "0x5E5D0E0", VA = "0x185E5E8E0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5DDC0", Offset = "0x5E5C5C0", VA = "0x185E5DDC0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class SHKCXRRTLGH<a, b, c, d, e, f, g, h> : ZYLVUXEUPGB<Tuple<a, b, c, d, e, f, g, h>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E65370", Offset = "0x5E63B70", VA = "0x185E65370", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E646E0", Offset = "0x5E62EE0", VA = "0x185E646E0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class KHXDAGURBHZ<a> : ZYLVUXEUPGB<ValueTuple<a>>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x5216FD0", Offset = "0x52157D0", VA = "0x185216FD0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x5216BB0", Offset = "0x52153B0", VA = "0x185216BB0", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class KICJXNOOKTI<a, b> : ZYLVUXEUPGB<(a, b)>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5217870", Offset = "0x5216070", VA = "0x185217870", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5217380", Offset = "0x5215B80", VA = "0x185217380", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class KIHQUUILUER<a, b, c> : ZYLVUXEUPGB<(a, b, c)>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x5218420", Offset = "0x5216C20", VA = "0x185218420", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x5217DB0", Offset = "0x52165B0", VA = "0x185217DB0", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class KIMXSBCJDQA<a, b, c, d> : ZYLVUXEUPGB<(a, b, c, d)>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5219340", Offset = "0x5217B40", VA = "0x185219340", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x5218B00", Offset = "0x5217300", VA = "0x185218B00", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class KISEPHWGNBJ<a, b, c, d, e> : ZYLVUXEUPGB<(a, b, c, d, e)>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x521A5A0", Offset = "0x5218DA0", VA = "0x18521A5A0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x5219BE0", Offset = "0x52183E0", VA = "0x185219BE0", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class KIXLMOQDWMS<a, b, c, d, e, f> : ZYLVUXEUPGB<(a, b, c, d, e, f)>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x521BD00", Offset = "0x521A500", VA = "0x18521BD00", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x521B130", Offset = "0x5219930", VA = "0x18521B130", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class KJCSJVKBFYB<a, b, c, d, e, f, g> : ZYLVUXEUPGB<(a, b, c, d, e, f, g)>, SIQNGTGRNUC
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x5238630", Offset = "0x5236E30", VA = "0x185238630", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x52378C0", Offset = "0x52360C0", VA = "0x1852378C0", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class KGBSYXXOUJW<a, b, c, d, e, f, g, h> : ZYLVUXEUPGB<ValueTuple<a, b, c, d, e, f, g, h>>, SIQNGTGRNUC where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] FIOKNKFNOPJ;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly GVPVDVWNZVL QZVARSESNPZ;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x5212F60", Offset = "0x5211760", VA = "0x185212F60", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, QCUUQNTWJRO formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x5212030", Offset = "0x5210830", VA = "0x185212030", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, QCUUQNTWJRO formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class YCAHKNFSYIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] DVFAAZLKLGV;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly GVPVDVWNZVL SCNAHUNUGVG;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8E7FDF0", Offset = "0x8E7E5F0", VA = "0x188E7FDF0")]
		static YCAHKNFSYIL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class IRXRRKNZRYJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] NWHOSTXWJBS;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly GVPVDVWNZVL EBHGIELGJVD;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x8E6BD70", Offset = "0x8E6A570", VA = "0x188E6BD70")]
		static IRXRRKNZRYJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class XSFGFMBARXJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] APNQIBQMNRT;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly GVPVDVWNZVL GTLKZSCNZCW;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] AOXVQHIULJS;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly GVPVDVWNZVL GTGECLIQPRN;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] APDCNOCRUVB;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly GVPVDVWNZVL GTAXFEOTGGE;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] AQDKZVYEPZU;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly GVPVDVWNZVL GULTLZYAUHP;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] AQIRXCSBZLD;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly GVPVDVWNZVL GUGMOTEDKWG;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] APSXFIKJXDC;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly GVPVDVWNZVL GUBFRMKGBKX;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] APYECPEHGOL;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly GVPVDVWNZVL GTVYUFQIRZO;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] ANSGGSTKGTQ;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly GVPVDVWNZVL GVGVBAZQGAZ;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x8E7EE70", Offset = "0x8E7D670", VA = "0x188E7EE70")]
		static XSFGFMBARXJ()
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
