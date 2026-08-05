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
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, PPKJWPQRQAZ resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, PPKJWPQRQAZ resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface QOSEDTIGXHN
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface HNMCAPHXUKI<a> : QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, PPKJWPQRQAZ formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface TEPLNOGQIKJ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GUGLKONFZJV(JsonWriter a, a b, PPKJWPQRQAZ c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b);
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
	public static class HRBOKZCBFJW
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x36609C0", Offset = "0x365FDC0", VA = "0x1836609C0")]
		public static string ToJsonString<T>(this HNMCAPHXUKI<T> formatter, T value, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		HNMCAPHXUKI<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class TCLPTUBFFJY
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3AA3AC0", Offset = "0x3AA2EC0", VA = "0x183AA3AC0")]
		public static HNMCAPHXUKI<a> GQIUEYWNPLH<a>(this PPKJWPQRQAZ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC570", Offset = "0x8DEB970", VA = "0x188DEC570")]
		public static object OXBYLSOEGKR(this PPKJWPQRQAZ a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1650", Offset = "0x8DE0A50", VA = "0x188DE1650")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class WNKHSRHWCFF
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] BWAVKBSGINI;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] IUXNADNZIJJ;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] IYLGYODTMBG;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] BQTJUPGQQKX;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] VSZANFTAIAO;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] QYAZKNTBOOR;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] LVHMMEDBHWR;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] XJZBGFLBBIY;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class IABPMIFNSZG : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x8DE3CE0", Offset = "0x8DE30E0", VA = "0x188DE3CE0")]
				public IABPMIFNSZG(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x8DE3BC0", Offset = "0x8DE2FC0", VA = "0x188DE3BC0")]
				public IABPMIFNSZG KFJONBROKIC(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class QWKBWPRCAFR
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] HHUGYHOGCLS;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] BRDNEITBDWX;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private IABPMIFNSZG start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private IABPMIFNSZG end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8DEBF90", Offset = "0x8DEB390", VA = "0x188DEBF90")]
			public void KFJONBROKIC([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8DEBE50", Offset = "0x8DEB250", VA = "0x188DEBE50")]
			public void KFJONBROKIC(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8DEC440", Offset = "0x8DEB840", VA = "0x188DEC440")]
			public ReadOnlySequence<byte> OFTMQUEQEVX()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8DEC290", Offset = "0x8DEB690", VA = "0x188DEC290")]
			private void NMRLJFCHLKR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8DEC0A0", Offset = "0x8DEB4A0", VA = "0x188DEC0A0")]
			private void KJTBVSZIWCL([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8DE70F0", Offset = "0x8DE64F0", VA = "0x188DE70F0")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8DE69C0", Offset = "0x8DE5DC0", VA = "0x188DE69C0")]
		private JsonParsingException XQMHCMGRPQL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5700", Offset = "0x8DE4B00", VA = "0x188DE5700")]
		private JsonParsingException KTGMRWUKZKW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8DE60C0", Offset = "0x8DE54C0", VA = "0x188DE60C0")]
		public JsonToken QFHQDAEADBY()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5180", Offset = "0x8DE4580", VA = "0x188DE5180")]
		public void ISZRYCFLETK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7090", Offset = "0x8DE6490", VA = "0x188DE7090")]
		private bool ZVXFIVERZBU(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7030", Offset = "0x8DE6430", VA = "0x188DE7030")]
		private bool ZVXFIVERZBU(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8DE50D0", Offset = "0x8DE44D0", VA = "0x188DE50D0")]
		private void IRRPTCQUUSD(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4F60", Offset = "0x8DE4360", VA = "0x188DE4F60")]
		public bool HOITQNYWLBV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE66C0", Offset = "0x8DE5AC0", VA = "0x188DE66C0")]
		public void USNQEXIKDDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4790", Offset = "0x8DE3B90", VA = "0x188DE4790")]
		public bool FDKCHBTXROM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE62D0", Offset = "0x8DE56D0", VA = "0x188DE62D0")]
		public void QNVMPSDTAEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE46D0", Offset = "0x8DE3AD0", VA = "0x188DE46D0")]
		public void CNEKRRKVGMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE59F0", Offset = "0x8DE4DF0", VA = "0x188DE59F0")]
		public bool MANVKRTWOEE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4A80", Offset = "0x8DE3E80", VA = "0x188DE4A80")]
		public void FLOICDICYGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8DE56F0", Offset = "0x8DE4AF0", VA = "0x188DE56F0")]
		public void KIATYKGCVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5960", Offset = "0x8DE4D60", VA = "0x188DE5960")]
		public bool LSQGPTMRQGT(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8DE64A0", Offset = "0x8DE58A0", VA = "0x188DE64A0")]
		public bool SWBQYRUAQYH(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8DE65E0", Offset = "0x8DE59E0", VA = "0x188DE65E0")]
		public bool TVIUXNESYMS(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3F30", Offset = "0x8DE3330", VA = "0x188DE3F30")]
		private ReadOnlySequence<byte> ACPBXEGTCQX()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6750", Offset = "0x8DE5B50", VA = "0x188DE6750")]
		private ReadOnlySequence<byte> XCRYXYHKCFU()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8DE44E0", Offset = "0x8DE38E0", VA = "0x188DE44E0")]
		private void BZIDHIZZNWW(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5C80", Offset = "0x8DE5080", VA = "0x188DE5C80")]
		private void MURXEBJBCAJ(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4A90", Offset = "0x8DE3E90", VA = "0x188DE4A90")]
		private void FWGVOHPXBSU(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6390", Offset = "0x8DE5790", VA = "0x188DE6390")]
		private void RMJOCSTHFLV(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8DDE0B0", Offset = "0x8DDD4B0", VA = "0x188DDE0B0")]
		private static int PIVFHGSPGRY(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4410", Offset = "0x8DE3810", VA = "0x188DE4410")]
		public ReadOnlySequence<byte> BADXRGAPNPU()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE66D0", Offset = "0x8DE5AD0", VA = "0x188DE66D0")]
		public string WBYJXZJWBNR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5FD0", Offset = "0x8DE53D0", VA = "0x188DE5FD0")]
		public string OQMRJLXPRGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5F00", Offset = "0x8DE5300", VA = "0x188DE5F00")]
		public ReadOnlySequence<byte> OOFGHYIKUKK()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8DE54C0", Offset = "0x8DE48C0", VA = "0x188DE54C0")]
		public ReadOnlySequence<byte> JNQTTAFWCGB()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8DE55A0", Offset = "0x8DE49A0", VA = "0x188DE55A0")]
		public bool KGGQQVHBWUG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6EC0", Offset = "0x8DE62C0", VA = "0x188DE6EC0")]
		private void XWLSHRNGLAU(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5EF0", Offset = "0x8DE52F0", VA = "0x188DE5EF0")]
		public void OEWNDRYZSSA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5A40", Offset = "0x8DE4E40", VA = "0x188DE5A40")]
		private void MMYJMREYIUL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5810", Offset = "0x8DE4C10", VA = "0x188DE5810")]
		public sbyte KYRDWXXJSIN()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8DE62E0", Offset = "0x8DE56E0", VA = "0x188DE62E0")]
		public short QZFDMLNDEDG()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8DE46E0", Offset = "0x8DE3AE0", VA = "0x188DE46E0")]
		public int EEHESRISANY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8DE53B0", Offset = "0x8DE47B0", VA = "0x188DE53B0")]
		public long JCSDRBYEYHP()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6010", Offset = "0x8DE5410", VA = "0x188DE6010")]
		public byte ORYMSJMTMGY()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5020", Offset = "0x8DE4420", VA = "0x188DE5020")]
		public ushort HPTPVQTNLEJ()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6530", Offset = "0x8DE5930", VA = "0x188DE6530")]
		public uint TTHPKMMWYFZ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5E80", Offset = "0x8DE5280", VA = "0x188DE5E80")]
		public ulong NOMFILLPYQY()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5420", Offset = "0x8DE4820", VA = "0x188DE5420")]
		public float JDXUEVMSABU()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE58C0", Offset = "0x8DE4CC0", VA = "0x188DE58C0")]
		public double LDREDBQSZDZ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4D80", Offset = "0x8DE4180", VA = "0x188DE4D80")]
		public ReadOnlySequence<byte> HIMYJRRKCVC()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8DE47E0", Offset = "0x8DE3BE0", VA = "0x188DE47E0")]
		private void FGYWPHDSKRM()
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
			[Cpp2IlInjected.Address(RVA = "0xCA6670", Offset = "0xCA5A70", VA = "0x180CA6670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3ED0", Offset = "0x8DE32D0", VA = "0x188DE3ED0")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3E50", Offset = "0x8DE3250", VA = "0x188DE3E50")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class DBQDIIRVHYA
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class HHXHMXTKKHR
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] HHUGYHOGCLS;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8DE3B20", Offset = "0x8DE2F20", VA = "0x188DE3B20")]
			public static byte[] GPZMGVVNMKI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static PPKJWPQRQAZ DOPMRSZTWLP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] IHMTOAEXZUY;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] COZRZZZBGGG;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static PPKJWPQRQAZ ILOAAQVYMGR
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8DE0F40", Offset = "0x8DE0340", VA = "0x188DE0F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1030", Offset = "0x8DE0430", VA = "0x188DE1030")]
		public static void UWBVPBCRRWN(PPKJWPQRQAZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x34FF2B0", Offset = "0x34FE6B0", VA = "0x1834FF2B0")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x34FF470", Offset = "0x34FE870", VA = "0x1834FF470")]
		public static byte[] Serialize<T>(T value, PPKJWPQRQAZ resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x34FFC90", Offset = "0x34FF090", VA = "0x1834FFC90")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x34FFB20", Offset = "0x34FEF20", VA = "0x1834FFB20")]
		public static string ToJsonString<T>(T value, PPKJWPQRQAZ resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x34FEBB0", Offset = "0x34FDFB0", VA = "0x1834FEBB0")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x34FEE00", Offset = "0x34FE200", VA = "0x1834FEE00")]
		public static T Deserialize<T>(string json, PPKJWPQRQAZ resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x34FEA10", Offset = "0x34FDE10", VA = "0x1834FEA10")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x34FEAE0", Offset = "0x34FDEE0", VA = "0x1834FEAE0")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, PPKJWPQRQAZ resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x34FE230", Offset = "0x34FD630", VA = "0x1834FE230")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x34FE450", Offset = "0x34FD850", VA = "0x1834FE450")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, PPKJWPQRQAZ resolver)
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
		public int DHKSNDKDODO
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xC6C580", Offset = "0xC6B980", VA = "0x180C6C580")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8540", Offset = "0x8DE7940", VA = "0x188DE8540")]
		public void WRFUFVPMPVF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7E30", Offset = "0x8DE7230", VA = "0x188DE7E30")]
		public static byte[] JIUBAMPGJIK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8340", Offset = "0x8DE7740", VA = "0x188DE8340")]
		public static byte[] TYWHMSFSAHE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8DE73D0", Offset = "0x8DE67D0", VA = "0x188DE73D0")]
		public static byte[] DJUREQQNEVS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8DE74F0", Offset = "0x8DE68F0", VA = "0x188DE74F0")]
		public static byte[] DVGDJUELJIM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x27BBDB0", Offset = "0x27BB1B0", VA = "0x1827BBDB0")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7C70", Offset = "0x8DE7070", VA = "0x188DE7C70")]
		public ArraySegment<byte> GPZMGVVNMKI()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7FB0", Offset = "0x8DE73B0", VA = "0x188DE7FB0")]
		public byte[] LLVFNMDFKXJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8460", Offset = "0x8DE7860", VA = "0x188DE8460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8590", Offset = "0x8DE7990", VA = "0x188DE8590")]
		public void YQUAQDORTFG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8DE85A0", Offset = "0x8DE79A0", VA = "0x188DE85A0")]
		public void ZDFLEGSBJER(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8550", Offset = "0x8DE7950", VA = "0x188DE8550")]
		public void WRRFHCUXRXF(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3F00B30", Offset = "0x3EFFF30", VA = "0x183F00B30")]
		public void DSZVYPMRKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3F00B80", Offset = "0x3EFFF80", VA = "0x183F00B80")]
		public void UARDLDOQLPV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE81B0", Offset = "0x8DE75B0", VA = "0x188DE81B0")]
		public void OFJEWUCSNCR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE82F0", Offset = "0x8DE76F0", VA = "0x188DE82F0")]
		public void RRIXQPZOXJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3F00BD0", Offset = "0x3EFFFD0", VA = "0x183F00BD0")]
		public void YMSWYCOWGOV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4EA9190", Offset = "0x4EA8590", VA = "0x184EA9190")]
		public void BNHSZEBKBJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7F10", Offset = "0x8DE7310", VA = "0x188DE7F10")]
		public void KAVITFQURCX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8DE84C0", Offset = "0x8DE78C0", VA = "0x188DE84C0")]
		public void VGTUEUSDJBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3D8BEC0", Offset = "0x3D8B2C0", VA = "0x183D8BEC0")]
		public void WFJUDMZGMHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7724D10", Offset = "0x7724110", VA = "0x187724D10")]
		public void UEITRTPVWPN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8200", Offset = "0x8DE7600", VA = "0x188DE8200")]
		public void PKNTPIXLPSV(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7670", Offset = "0x8DE6A70", VA = "0x188DE7670")]
		public void EEGUPEJGPKU(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7260", Offset = "0x8DE6660", VA = "0x188DE7260")]
		public void BLEKFKOXARR(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7340", Offset = "0x8DE6740", VA = "0x188DE7340")]
		public void CRRLXLUTEMW(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8280", Offset = "0x8DE7680", VA = "0x188DE8280")]
		public void PTBXHOLXYBG(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8510", Offset = "0x8DE7910", VA = "0x188DE8510")]
		public void VSFWIICATKP(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7D90", Offset = "0x8DE7190", VA = "0x188DE7D90")]
		public void HTNXQRWXZXC(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE72D0", Offset = "0x8DE66D0", VA = "0x188DE72D0")]
		public void BYREVRZFNFH(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8140", Offset = "0x8DE7540", VA = "0x188DE8140")]
		public void OCFEKNSPAGX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7E00", Offset = "0x8DE7200", VA = "0x188DE7E00")]
		public void IXHSVUQIMOE(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE76F0", Offset = "0x8DE6AF0", VA = "0x188DE76F0")]
		public void EPWFMYEBYWQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7D10", Offset = "0x8DE7110", VA = "0x188DE7D10")]
		private static bool HEYAICICULU(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8DE73B0", Offset = "0x8DE67B0", VA = "0x188DE73B0")]
		private static byte DDSXOPTYPFG(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8DDE170", Offset = "0x8DDD570", VA = "0x188DDE170")]
		private static void KGAGZECYJJL(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class RCHLRQPIQBU : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x3DC2F00", Offset = "0x3DC2300", VA = "0x183DC2F00")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private RCHLRQPIQBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class LQLROTITYRN : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x3DD0CA0", Offset = "0x3DD00A0", VA = "0x183DD0CA0")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class RGFHKEDYIAR
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> WJNYLXNTIKC;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8DE92B0", Offset = "0x8DE86B0", VA = "0x188DE92B0")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private LQLROTITYRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class TFHNLMRVRIH : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x3DD3B90", Offset = "0x3DD2F90", VA = "0x183DD3B90")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly TFHNLMRVRIH LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool DVZAZGTKKGT;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static QOSEDTIGXHN[] DNXWYMHFKQR;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static PPKJWPQRQAZ[] BIRRPTWIGPX;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private TFHNLMRVRIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC6C0", Offset = "0x8DEBAC0", VA = "0x188DEC6C0")]
		public static void SHWXSEAJSCT(params PPKJWPQRQAZ[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC790", Offset = "0x8DEBB90", VA = "0x188DEC790")]
		public static void SHWXSEAJSCT(params QOSEDTIGXHN[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC860", Offset = "0x8DEBC60", VA = "0x188DEC860")]
		public static void USMOTJXSOAV(QOSEDTIGXHN[] a, PPKJWPQRQAZ[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class ZYEAIBGKUHA : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x3DD1A70", Offset = "0x3DD0E70", VA = "0x183DD1A70")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private ZYEAIBGKUHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class BAMDMNDKOEB
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly PPKJWPQRQAZ VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly PPKJWPQRQAZ VYNKAFGXSTI;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class BPHEKOAERNL
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly PPKJWPQRQAZ VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly PPKJWPQRQAZ WTHVXBTAJWA;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly PPKJWPQRQAZ AGECBTHSDSS;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly PPKJWPQRQAZ YFFYKGKZSCR;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly PPKJWPQRQAZ SWJOCCERWZX;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly PPKJWPQRQAZ ZZGUZIAGTNZ;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly PPKJWPQRQAZ LEWZLJKZBAC;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly PPKJWPQRQAZ RVDUVSYFXIM;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly PPKJWPQRQAZ ESFFXMCUQVA;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly PPKJWPQRQAZ LLAVHEZQKJD;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly PPKJWPQRQAZ JVQDNAHPJGJ;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly PPKJWPQRQAZ PXPRLJJIIQH;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class XGLDSQLTVDC
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> WJNYLXNTIKC;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8DEEE10", Offset = "0x8DEE210", VA = "0x188DEEE10")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0A10", Offset = "0x8DEFE10", VA = "0x188DF0A10")]
		private static object HWRQWVZIZQR(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class IGLYMOOZUDM : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x3DC7DF0", Offset = "0x3DC71F0", VA = "0x183DC7DF0")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private IGLYMOOZUDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class GIHOPGZHNTB : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x3DD6900", Offset = "0x3DD5D00", VA = "0x183DD6900")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private GIHOPGZHNTB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class UPFETTTRCGV
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly PPKJWPQRQAZ[] TPUFCGNUBNY;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class SFWMYOCUWFG : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x3DC5280", Offset = "0x3DC4680", VA = "0x183DC5280")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class TYVEDUYQSLO : PPKJWPQRQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class YGJOQEDINNP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x3DCDD40", Offset = "0x3DCD140", VA = "0x183DCDD40")]
				static YGJOQEDINNP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly PPKJWPQRQAZ[] BIRRPTWIGPX;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			private TYVEDUYQSLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
			public HNMCAPHXUKI<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly HNMCAPHXUKI<object> KIGIQMXHAZA;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private SFWMYOCUWFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class OVCRCTUNXJF : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x3DD7CC0", Offset = "0x3DD70C0", VA = "0x183DD7CC0")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class TYVEDUYQSLO : PPKJWPQRQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class YGJOQEDINNP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x3DD6EB0", Offset = "0x3DD62B0", VA = "0x183DD6EB0")]
				static YGJOQEDINNP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly PPKJWPQRQAZ[] BIRRPTWIGPX;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			private TYVEDUYQSLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
			public HNMCAPHXUKI<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly HNMCAPHXUKI<object> KIGIQMXHAZA;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private OVCRCTUNXJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class FXVDTGVWHBX : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x3DCCBD0", Offset = "0x3DCBFD0", VA = "0x183DCCBD0")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class TYVEDUYQSLO : PPKJWPQRQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class YGJOQEDINNP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x3DDD4A0", Offset = "0x3DDC8A0", VA = "0x183DDD4A0")]
				static YGJOQEDINNP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly PPKJWPQRQAZ[] BIRRPTWIGPX;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			private TYVEDUYQSLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
			public HNMCAPHXUKI<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly HNMCAPHXUKI<object> KIGIQMXHAZA;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private FXVDTGVWHBX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class ZXDZSEILZDI : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x3DD0860", Offset = "0x3DCFC60", VA = "0x183DD0860")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class TYVEDUYQSLO : PPKJWPQRQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class YGJOQEDINNP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x3DE1370", Offset = "0x3DE0770", VA = "0x183DE1370")]
				static YGJOQEDINNP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly PPKJWPQRQAZ[] BIRRPTWIGPX;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			private TYVEDUYQSLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
			public HNMCAPHXUKI<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly HNMCAPHXUKI<object> KIGIQMXHAZA;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private ZXDZSEILZDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class LWQJQLUCQDI : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x3DDE420", Offset = "0x3DDD820", VA = "0x183DDE420")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class TYVEDUYQSLO : PPKJWPQRQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class YGJOQEDINNP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x3DE1FB0", Offset = "0x3DE13B0", VA = "0x183DE1FB0")]
				static YGJOQEDINNP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly PPKJWPQRQAZ[] BIRRPTWIGPX;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			private TYVEDUYQSLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
			public HNMCAPHXUKI<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly HNMCAPHXUKI<object> KIGIQMXHAZA;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private LWQJQLUCQDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class ASERXAKIPPK : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x3DD5A50", Offset = "0x3DD4E50", VA = "0x183DD5A50")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class TYVEDUYQSLO : PPKJWPQRQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class YGJOQEDINNP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x3DD38F0", Offset = "0x3DD2CF0", VA = "0x183DD38F0")]
				static YGJOQEDINNP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly PPKJWPQRQAZ[] BIRRPTWIGPX;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			private TYVEDUYQSLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
			public HNMCAPHXUKI<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly HNMCAPHXUKI<object> KIGIQMXHAZA;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private ASERXAKIPPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class CYJOXFJWSVH : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x3DD9F80", Offset = "0x3DD9380", VA = "0x183DD9F80")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class TYVEDUYQSLO : PPKJWPQRQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class YGJOQEDINNP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x3DDB9D0", Offset = "0x3DDADD0", VA = "0x183DDB9D0")]
				static YGJOQEDINNP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly PPKJWPQRQAZ[] BIRRPTWIGPX;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			private TYVEDUYQSLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
			public HNMCAPHXUKI<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly HNMCAPHXUKI<object> KIGIQMXHAZA;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private CYJOXFJWSVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class ICCYITXWWLN : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x3DC9640", Offset = "0x3DC8A40", VA = "0x183DC9640")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class TYVEDUYQSLO : PPKJWPQRQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class YGJOQEDINNP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0x3DDB550", Offset = "0x3DDA950", VA = "0x183DDB550")]
				static YGJOQEDINNP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly PPKJWPQRQAZ[] BIRRPTWIGPX;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			private TYVEDUYQSLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
			public HNMCAPHXUKI<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly HNMCAPHXUKI<object> KIGIQMXHAZA;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private ICCYITXWWLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class NZQINUAACTH : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3DC7520", Offset = "0x3DC6920", VA = "0x183DC7520")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class TYVEDUYQSLO : PPKJWPQRQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class YGJOQEDINNP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x3DDDBD0", Offset = "0x3DDCFD0", VA = "0x183DDDBD0")]
				static YGJOQEDINNP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly PPKJWPQRQAZ[] BIRRPTWIGPX;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			private TYVEDUYQSLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
			public HNMCAPHXUKI<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly HNMCAPHXUKI<object> KIGIQMXHAZA;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private NZQINUAACTH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class BVDFLIWFHIO : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x3DC9A80", Offset = "0x3DC8E80", VA = "0x183DC9A80")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class TYVEDUYQSLO : PPKJWPQRQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class YGJOQEDINNP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x3DCC550", Offset = "0x3DCB950", VA = "0x183DCC550")]
				static YGJOQEDINNP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly PPKJWPQRQAZ[] BIRRPTWIGPX;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			private TYVEDUYQSLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
			public HNMCAPHXUKI<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly HNMCAPHXUKI<object> KIGIQMXHAZA;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private BVDFLIWFHIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class CQMYBINOVHM : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0B50", Offset = "0x3DDFF50", VA = "0x183DE0B50")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class TYVEDUYQSLO : PPKJWPQRQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class YGJOQEDINNP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x3DE2F00", Offset = "0x3DE2300", VA = "0x183DE2F00")]
				static YGJOQEDINNP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly PPKJWPQRQAZ[] BIRRPTWIGPX;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			private TYVEDUYQSLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
			public HNMCAPHXUKI<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly HNMCAPHXUKI<object> KIGIQMXHAZA;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private CQMYBINOVHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class GTBEDZECVOM : PPKJWPQRQAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class YGJOQEDINNP<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x3DC2C10", Offset = "0x3DC2010", VA = "0x183DC2C10")]
			static YGJOQEDINNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class TYVEDUYQSLO : PPKJWPQRQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class YGJOQEDINNP<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly HNMCAPHXUKI<a> COLDPJMYMYY;

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x3DC49D0", Offset = "0x3DC3DD0", VA = "0x183DC49D0")]
				static YGJOQEDINNP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly PPKJWPQRQAZ[] BIRRPTWIGPX;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			private TYVEDUYQSLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
			public HNMCAPHXUKI<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly PPKJWPQRQAZ LVYKDVFRYUJ;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly HNMCAPHXUKI<object> KIGIQMXHAZA;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		private GTBEDZECVOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3025CE0", Offset = "0x30250E0", VA = "0x183025CE0", Slot = "4")]
		public HNMCAPHXUKI<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x572D560", Offset = "0x572C960", VA = "0x18572D560")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x572D270", Offset = "0x572C670", VA = "0x18572D270")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x572D4D0", Offset = "0x572C8D0", VA = "0x18572D4D0")]
		public T[] GIRNOEINUDS()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class EQHEMBIEMSO<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int FMHCRWORCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object CKVUFPLORHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int LJHVHRDBFNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] MTAVJJLHQMB;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4770670", Offset = "0x476FA70", VA = "0x184770670")]
		public EQHEMBIEMSO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4770380", Offset = "0x476F780", VA = "0x184770380")]
		public a[] ZFUVRQXTJNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x476FFC0", Offset = "0x476F3C0", VA = "0x18476FFC0")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class UNXSDLXDJCU : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class HETIWXXLLLK : IComparable<HETIWXXLLLK>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class OZFSASITQVW : IEnumerable<HETIWXXLLLK>, IEnumerable, IEnumerator<HETIWXXLLLK>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int JIPOOQUWCIC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private HETIWXXLLLK JOTWNIKQVJT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int PLMFUAHXCWL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public HETIWXXLLLK MXVWDMPVVWS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int TSYGMCBXPQU;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private HETIWXXLLLK IBEJSMDZQUF
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object MSIUOYXLJXG
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xD06FE0", Offset = "0xD063E0", VA = "0x180D06FE0")]
				[DebuggerHidden]
				public OZFSASITQVW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "7")]
				[DebuggerHidden]
				private void AEBWHPMOWJR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x8DE91C0", Offset = "0x8DE85C0", VA = "0x188DE91C0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x8DE9180", Offset = "0x8DE8580", VA = "0x188DE9180", Slot = "10")]
				[DebuggerHidden]
				private void MJTKPUASZVA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x8DE90E0", Offset = "0x8DE84E0", VA = "0x188DE90E0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<HETIWXXLLLK> CSOMRXZAJVE()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x8DE90E0", Offset = "0x8DE84E0", VA = "0x188DE90E0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator CQMSCGRISCD()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly HETIWXXLLLK[] OSLHDUBLZCQ;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] GIHZGGTSQIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong HHRNDMXWTMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int QEMSNQIEONV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string KMGTCXKCEHW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private HETIWXXLLLK[] KXGTLRJXTBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] PNFNSHDPVYP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int ZFMABEAVVQB;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8DE3A70", Offset = "0x8DE2E70", VA = "0x188DE3A70")]
			public HETIWXXLLLK(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8DE34C0", Offset = "0x8DE28C0", VA = "0x188DE34C0")]
			public HETIWXXLLLK Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8DE36C0", Offset = "0x8DE2AC0", VA = "0x188DE36C0")]
			public HETIWXXLLLK Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8DE37D0", Offset = "0x8DE2BD0", VA = "0x188DE37D0")]
			public HETIWXXLLLK GBYNNRBHQCS(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8DE3940", Offset = "0x8DE2D40", VA = "0x188DE3940")]
			internal static int GKATWNPQNBJ(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8DE3720", Offset = "0x8DE2B20", VA = "0x188DE3720", Slot = "4")]
			public int CompareTo(HETIWXXLLLK other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8DE3750", Offset = "0x8DE2B50", VA = "0x188DE3750")]
			[IteratorStateMachine(typeof(OZFSASITQVW))]
			public IEnumerable<HETIWXXLLLK> EAJWQHQMXEQ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class TVXQMGVRUDI : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<HETIWXXLLLK> KXGTLRJXTBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<HETIWXXLLLK> NHRRKASFIXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<HETIWXXLLLK> BPMZBLFMONE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private HETIWXXLLLK ENWRILMDAET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> BPCLGXRRVQM;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> NDAFTCQGWQP
			{
				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x8DED240", Offset = "0x8DEC640", VA = "0x188DED240", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x19C1760", Offset = "0x19C0B60", VA = "0x1819C1760")]
			[DebuggerHidden]
			public TVXQMGVRUDI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8DECBB0", Offset = "0x8DEBFB0", VA = "0x188DECBB0", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8DECDE0", Offset = "0x8DEC1E0", VA = "0x188DECDE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8DED290", Offset = "0x8DEC690", VA = "0x188DED290")]
			private void RYZDNTQONZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8DED2E0", Offset = "0x8DEC6E0", VA = "0x188DED2E0")]
			private void RZEKLAKLXKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8DECDA0", Offset = "0x8DEC1A0", VA = "0x188DECDA0", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8DECD00", Offset = "0x8DEC100", VA = "0x188DECD00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> OTVOGZFUZSI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8DECD00", Offset = "0x8DEC100", VA = "0x188DECD00", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly HETIWXXLLLK XUVHPHBAVDY;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE780", Offset = "0x8DEDB80", VA = "0x188DEE780")]
		public UNXSDLXDJCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8DEDF30", Offset = "0x8DED330", VA = "0x188DEDF30")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE560", Offset = "0x8DED960", VA = "0x188DEE560")]
		public bool NCIRIRZXKOC(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE170", Offset = "0x8DED570", VA = "0x188DEE170")]
		public bool EDYEPGEHALV([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE6F0", Offset = "0x8DEDAF0", VA = "0x188DEE6F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE280", Offset = "0x8DED680", VA = "0x188DEE280")]
		private static void HJDYGOTHEBH(IEnumerable<HETIWXXLLLK> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE110", Offset = "0x8DED510", VA = "0x188DEE110", Slot = "5")]
		private IEnumerator CQMSCGRISCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE110", Offset = "0x8DED510", VA = "0x188DEE110", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE670", Offset = "0x8DEDA70", VA = "0x188DEE670")]
		[IteratorStateMachine(typeof(TVXQMGVRUDI))]
		private static IEnumerable<KeyValuePair<string, int>> OWWUSQRRPZC(IEnumerable<HETIWXXLLLK> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class MQYDCVRUGLF
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo GRTATUFBLIQ;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8C20", Offset = "0x8DE8020", VA = "0x188DE8C20")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8DE87C0", Offset = "0x8DE7BC0", VA = "0x188DE87C0")]
		public static ulong DDOMPTMVYTO(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class DQPRFFRBDCL
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1480", Offset = "0x8DE0880", VA = "0x188DE1480")]
		public static void YQUAQDORTFG(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1360", Offset = "0x8DE0760", VA = "0x188DE1360")]
		public static void VKGSKZTWMCI(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1220", Offset = "0x8DE0620", VA = "0x188DE1220")]
		public static byte[] ICWRXVLJLVT(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class RBYINCSWVZN<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x477E1F0", Offset = "0x477D5F0", VA = "0x18477E1F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class ODGDDHOLUMX : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public RBYINCSWVZN<a> MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] BPMZBLFMONE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int BPHSEELPFBV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] BPCLGXRRVQM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int BQNHNTAZJRX;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> VJWPLSLVZLE
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xC66740", Offset = "0xC65B40", VA = "0x180C66740", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0x4E4B580", Offset = "0x4E4A980", VA = "0x184E4B580", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public ODGDDHOLUMX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x5985080", Offset = "0x5984480", VA = "0x185985080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3D27BC0", Offset = "0x3D26FC0", VA = "0x183D27BC0", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] CJOHSQANUXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong BFPSNTSQKKF;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool QRWTBXTFFWW;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5B2D010", Offset = "0x5B2C410", VA = "0x185B2D010")]
		public RBYINCSWVZN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5B2D100", Offset = "0x5B2C500", VA = "0x185B2D100")]
		public RBYINCSWVZN(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5B1A7D0", Offset = "0x5B19BD0", VA = "0x185B1A7D0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5B266A0", Offset = "0x5B25AA0", VA = "0x185B266A0")]
		private bool OKYROCUYJET(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E860", Offset = "0x5B1DC60", VA = "0x185B1E860")]
		public bool NCIRIRZXKOC([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5B2B240", Offset = "0x5B2A640", VA = "0x185B2B240")]
		private static ulong VUQPYQBDOFQ([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5B299E0", Offset = "0x5B28DE0", VA = "0x185B299E0")]
		private static ulong VUQPYQBDOFQ([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5B2CF80", Offset = "0x5B2C380", VA = "0x185B2CF80")]
		private static int ZSOXHQVEWXM(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5B1B4E0", Offset = "0x5B1A8E0", VA = "0x185B1B4E0", Slot = "4")]
		[IteratorStateMachine(typeof(RBYINCSWVZN<>.ODGDDHOLUMX))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5B1B330", Offset = "0x5B1A730", VA = "0x185B1B330", Slot = "5")]
		private IEnumerator CQMSCGRISCD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class AFMPXEVDFSS
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3023A00", Offset = "0x3022E00", VA = "0x183023A00")]
		public static Func<a> YUXWWUHKHWU<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3023940", Offset = "0x3022D40", VA = "0x183023940")]
		private static c SVAMDJWAEWF<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0x8DE2130", Offset = "0x8DE1530", VA = "0x188DE2130")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2140", Offset = "0x8DE1540", VA = "0x188DE2140")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8DE17B0", Offset = "0x8DE0BB0", VA = "0x188DE17B0")]
		private static byte IWYMAMBRLMF(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8DDDD70", Offset = "0x8DDD170", VA = "0x188DDDD70")]
		private static byte LJOVKUZJLGZ(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1850", Offset = "0x8DE0C50", VA = "0x188DE1850")]
		public void MXOKRHSTACN(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class ZODFVNCUWYZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1710", Offset = "0x8DF0B10", VA = "0x188DF1710")]
		public static bool HRGWWGTLILZ(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1430", Offset = "0x8DF0830", VA = "0x188DF1430")]
		public static bool CGXYWYVJLFM(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1C20", Offset = "0x8DF1020", VA = "0x188DF1C20")]
		public static sbyte KYRDWXXJSIN([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1F20", Offset = "0x8DF1320", VA = "0x188DF1F20")]
		public static short QZFDMLNDEDG([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF15F0", Offset = "0x8DF09F0", VA = "0x188DF15F0")]
		public static int EEHESRISANY([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1720", Offset = "0x8DF0B20", VA = "0x188DF1720")]
		public static long JCSDRBYEYHP([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8DF18C0", Offset = "0x8DF0CC0", VA = "0x188DF18C0")]
		public static bool JIRLCUZRVDM(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1E20", Offset = "0x8DF1220", VA = "0x188DF1E20")]
		public static byte ORYMSJMTMGY([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF16B0", Offset = "0x8DF0AB0", VA = "0x188DF16B0")]
		public static ushort HPTPVQTNLEJ([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2090", Offset = "0x8DF1490", VA = "0x188DF2090")]
		public static uint TTHPKMMWYFZ([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1D70", Offset = "0x8DF1170", VA = "0x188DF1D70")]
		public static ulong NOMFILLPYQY([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8DF14A0", Offset = "0x8DF08A0", VA = "0x188DF14A0")]
		public static bool DFWSFDOHDEV(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8DF20F0", Offset = "0x8DF14F0", VA = "0x188DF20F0")]
		public static bool WCMFRCFJQAR(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1F80", Offset = "0x8DF1380", VA = "0x188DF1F80")]
		public static bool TGFMZIILWJT(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1E80", Offset = "0x8DF1280", VA = "0x188DF1E80")]
		public static bool QEZYVGPLJHV(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8DF17D0", Offset = "0x8DF0BD0", VA = "0x188DF17D0")]
		public static float JDXUEVMSABU([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1650", Offset = "0x8DF0A50", VA = "0x188DF1650")]
		public static bool HDKGBIBTBRN(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1C80", Offset = "0x8DF1080", VA = "0x188DF1C80")]
		public static double LDREDBQSZDZ([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8DF13D0", Offset = "0x8DF07D0", VA = "0x188DF13D0")]
		public static bool BVWTNPUNXVQ(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF2E0", Offset = "0x8DDE6E0", VA = "0x188DDF2E0")]
		public static int VSFWIICATKP(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8DDE7C0", Offset = "0x8DDDBC0", VA = "0x188DDE7C0")]
		public static int IXHSVUQIMOE(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1A50", Offset = "0x8DF0E50", VA = "0x188DF1A50")]
		public static bool KGGQQVHBWUG([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class XCLGSLXXSXT
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8DEED60", Offset = "0x8DEE160", VA = "0x188DEED60")]
		public static bool JJHNTXFQQSL(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class XHIFWGZEWJM
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding VTZCJXKGXUF;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class SUYZGTJFLHM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFF20", Offset = "0x8DDF320", VA = "0x188DDFF20")]
		public static void OUBULSRMAAT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFEB0", Offset = "0x8DDF2B0", VA = "0x188DDFEB0")]
		public static void OTWNOLXOQPK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0000", Offset = "0x8DDF400", VA = "0x188DE0000")]
		public static void OUMIGGFGSXL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFF90", Offset = "0x8DDF390", VA = "0x188DDFF90")]
		public static void OUHBIZLJJMC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB770", Offset = "0x8DEAB70", VA = "0x188DEB770")]
		public static void OWMZEVWGJGX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB700", Offset = "0x8DEAB00", VA = "0x188DEB700")]
		public static void OWHSHPCIZVO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB530", Offset = "0x8DEA930", VA = "0x188DEB530")]
		public static void EPARRVAXDIQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB5A0", Offset = "0x8DEA9A0", VA = "0x188DEB5A0")]
		public static void EPFYPBUUMTZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB610", Offset = "0x8DEAA10", VA = "0x188DEB610")]
		public static void EPLFMIORWFI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB680", Offset = "0x8DEAA80", VA = "0x188DEB680")]
		public static void EPQMJPIPFQR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB330", Offset = "0x8DEA730", VA = "0x188DEB330")]
		public static void EOFQCTZHRPG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB3B0", Offset = "0x8DEA7B0", VA = "0x188DEB3B0")]
		public static void EOKXAATFBAP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB430", Offset = "0x8DEA830", VA = "0x188DEB430")]
		public static void EOQDXHNCKLY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB4B0", Offset = "0x8DEA8B0", VA = "0x188DEB4B0")]
		public static void EOVKUOGZTXH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB230", Offset = "0x8DEA630", VA = "0x188DEB230")]
		public static void ENKONSXSFVW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB2B0", Offset = "0x8DEA6B0", VA = "0x188DEB2B0")]
		public static void ENPVKZRPPHF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBBB0", Offset = "0x8DEAFB0", VA = "0x188DEBBB0")]
		public static void YKPVKHNKWQH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBB30", Offset = "0x8DEAF30", VA = "0x188DEBB30")]
		public static void YKKONATNNEY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBCB0", Offset = "0x8DEB0B0", VA = "0x188DEBCB0")]
		public static void YLAJEVBFPMZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBC30", Offset = "0x8DEB030", VA = "0x188DEBC30")]
		public static void YKVCHOHIGBQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB990", Offset = "0x8DEAD90", VA = "0x188DEB990")]
		public static void YJUTVGLVKWX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB900", Offset = "0x8DEAD00", VA = "0x188DEB900")]
		public static void YJPMXZRYBLO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBAA0", Offset = "0x8DEAEA0", VA = "0x188DEBAA0")]
		public static void YKFHPTZQDTP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBA10", Offset = "0x8DEAE10", VA = "0x188DEBA10")]
		public static void YKAASNFSUIG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBDC0", Offset = "0x8DEB1C0", VA = "0x188DEBDC0")]
		public static void YMFYOJQPUDB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBD30", Offset = "0x8DEB130", VA = "0x188DEBD30")]
		public static void YMARRCWSKRS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB7E0", Offset = "0x8DEABE0", VA = "0x188DEB7E0")]
		public static void SJWOYXEISUG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB870", Offset = "0x8DEAC70", VA = "0x188DEB870")]
		public static void SKBVWDYGCFP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0070", Offset = "0x8DDF470", VA = "0x188DE0070")]
		public static void OURPDMZECIU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0150", Offset = "0x8DDF550", VA = "0x188DE0150")]
		public static void OVHJVHGWEQV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE00E0", Offset = "0x8DDF4E0", VA = "0x188DE00E0")]
		public static void OVCCYAMYVFM(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class AXDKDKJHVIV
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0230", Offset = "0x8DDF630", VA = "0x188DE0230")]
		public static void OWMZEVWGJGX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE01C0", Offset = "0x8DDF5C0", VA = "0x188DE01C0")]
		public static void OWHSHPCIZVO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFCF0", Offset = "0x8DDF0F0", VA = "0x188DDFCF0")]
		public static void EPARRVAXDIQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFD60", Offset = "0x8DDF160", VA = "0x188DDFD60")]
		public static void EPFYPBUUMTZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFDD0", Offset = "0x8DDF1D0", VA = "0x188DDFDD0")]
		public static void EPLFMIORWFI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFE40", Offset = "0x8DDF240", VA = "0x188DDFE40")]
		public static void EPQMJPIPFQR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFB20", Offset = "0x8DDEF20", VA = "0x188DDFB20")]
		public static void EOFQCTZHRPG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFB90", Offset = "0x8DDEF90", VA = "0x188DDFB90")]
		public static void EOKXAATFBAP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFC00", Offset = "0x8DDF000", VA = "0x188DDFC00")]
		public static void EOQDXHNCKLY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFC70", Offset = "0x8DDF070", VA = "0x188DDFC70")]
		public static void EOVKUOGZTXH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFA20", Offset = "0x8DDEE20", VA = "0x188DDFA20")]
		public static void ENKONSXSFVW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFAA0", Offset = "0x8DDEEA0", VA = "0x188DDFAA0")]
		public static void ENPVKZRPPHF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0620", Offset = "0x8DDFA20", VA = "0x188DE0620")]
		public static void YKPVKHNKWQH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8DE05A0", Offset = "0x8DDF9A0", VA = "0x188DE05A0")]
		public static void YKKONATNNEY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0720", Offset = "0x8DDFB20", VA = "0x188DE0720")]
		public static void YLAJEVBFPMZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE06A0", Offset = "0x8DDFAA0", VA = "0x188DE06A0")]
		public static void YKVCHOHIGBQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0420", Offset = "0x8DDF820", VA = "0x188DE0420")]
		public static void YJUTVGLVKWX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8DE03A0", Offset = "0x8DDF7A0", VA = "0x188DE03A0")]
		public static void YJPMXZRYBLO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0520", Offset = "0x8DDF920", VA = "0x188DE0520")]
		public static void YKFHPTZQDTP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8DE04A0", Offset = "0x8DDF8A0", VA = "0x188DE04A0")]
		public static void YKAASNFSUIG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0820", Offset = "0x8DDFC20", VA = "0x188DE0820")]
		public static void YMFYOJQPUDB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8DE07A0", Offset = "0x8DDFBA0", VA = "0x188DE07A0")]
		public static void YMARRCWSKRS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8DE02A0", Offset = "0x8DDF6A0", VA = "0x188DE02A0")]
		public static void SJWOYXEISUG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0320", Offset = "0x8DDF720", VA = "0x188DE0320")]
		public static void SKBVWDYGCFP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0070", Offset = "0x8DDF470", VA = "0x188DE0070")]
		public static void OURPDMZECIU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0150", Offset = "0x8DDF550", VA = "0x188DE0150")]
		public static void OVHJVHGWEQV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8DE00E0", Offset = "0x8DDF4E0", VA = "0x188DE00E0")]
		public static void OVCCYAMYVFM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFF20", Offset = "0x8DDF320", VA = "0x188DDFF20")]
		public static void OUBULSRMAAT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFEB0", Offset = "0x8DDF2B0", VA = "0x188DDFEB0")]
		public static void OTWNOLXOQPK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0000", Offset = "0x8DDF400", VA = "0x188DE0000")]
		public static void OUMIGGFGSXL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8DDFF90", Offset = "0x8DDF390", VA = "0x188DDFF90")]
		public static void OUHBIZLJJMC(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class IEYPQUYZUZB
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool QRWTBXTFFWW;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8410", Offset = "0x8DF7810", VA = "0x188DF8410")]
		public static void ZDFLEGSBJER(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8380", Offset = "0x8DF7780", VA = "0x188DF8380")]
		public static void EYEDZXKOXQU(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x285F9D0", Offset = "0x285EDD0", VA = "0x18285F9D0")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5240", Offset = "0x8DF4640", VA = "0x188DF5240")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5070", Offset = "0x8DF4470", VA = "0x188DF5070")]
		public static DiyFp DFBCGTAYBVU(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5110", Offset = "0x8DF4510", VA = "0x188DF5110")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8DF51A0", Offset = "0x8DF45A0", VA = "0x188DF51A0")]
		public static DiyFp NEMLOXLKKMM(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8DF50D0", Offset = "0x8DF44D0", VA = "0x188DF50D0")]
		public void FVMQJUVRXPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5080", Offset = "0x8DF4480", VA = "0x188DF5080")]
		public static DiyFp FVMQJUVRXPL(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xBF6FA0", Offset = "0xBF63A0", VA = "0x180BF6FA0")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8E061B0", Offset = "0x8E055B0", VA = "0x188E061B0")]
		public void QIFJFDXVEUY(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8E05E90", Offset = "0x8E05290", VA = "0x188E05E90")]
		public void EBZCTHDVXIM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8E05F10", Offset = "0x8E05310", VA = "0x188E05F10")]
		public void GGPHRKHPBIU(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8E05F90", Offset = "0x8E05390", VA = "0x188E05F90")]
		public void GGPHRKHPBIU(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8E06030", Offset = "0x8E05430", VA = "0x188E06030")]
		public void IDJSSLWBPCG(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8E060B0", Offset = "0x8E054B0", VA = "0x188E060B0")]
		public void LXQYMZAMSQN(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class LQFDSRMWYSJ
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
		private static byte[] ZDTBUYAVIRQ;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] OZIFSCQWVHQ;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] EIZWLDEAHMA;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] QRGBTLUMJKB;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags TKYIMIAYCHU;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char XDMETPKHZZQ;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int UKTSNUUOKEO;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int ZNHWRKUFNEO;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] VPXUMNWQKZC;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8DFCA60", Offset = "0x8DFBE60", VA = "0x188DFCA60")]
		private static byte[] EYQPGBCFKMO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8DFDA30", Offset = "0x8DFCE30", VA = "0x188DFDA30")]
		private static byte[] LUSCYOUEZMK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8DFE050", Offset = "0x8DFD450", VA = "0x188DFE050")]
		public static int PSBKLPCBUVP(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8DFE170", Offset = "0x8DFD570", VA = "0x188DFE170")]
		public static int PSBKLPCBUVP(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8DFE290", Offset = "0x8DFD690", VA = "0x188DFE290")]
		private static bool RJRAEAOTQPF(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8DFC970", Offset = "0x8DFBD70", VA = "0x188DFC970")]
		private static void APAQYWIXZFJ(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8DFCB30", Offset = "0x8DFBF30", VA = "0x188DFCB30")]
		private static bool GOATKOGRUMX(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD3C0", Offset = "0x8DFC7C0", VA = "0x188DFD3C0")]
		private static bool KHNXHCKQZZZ(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8DFDF50", Offset = "0x8DFD350", VA = "0x188DFDF50")]
		private static bool OWSQRENURCA(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8DFE710", Offset = "0x8DFDB10", VA = "0x188DFE710")]
		private static bool UCDKDIRRPQF(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8DFCEF0", Offset = "0x8DFC2F0", VA = "0x188DFCEF0")]
		private static bool JNFPNNAVDYM(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8DFE380", Offset = "0x8DFD780", VA = "0x188DFE380")]
		private static void RKMBIWVFJIQ(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8DFDB10", Offset = "0x8DFCF10", VA = "0x188DFDB10")]
		private static void MRRNPMAJDDK(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD840", Offset = "0x8DFCC40", VA = "0x188DFD840")]
		private static bool KYXWOYKYCGZ(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0x8DF5870", Offset = "0x8DF4C70", VA = "0x188DF5870")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8DF57D0", Offset = "0x8DF4BD0", VA = "0x188DF57D0")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8DF55D0", Offset = "0x8DF49D0", VA = "0x188DF55D0")]
		public DiyFp LICCXIRVAYO()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5430", Offset = "0x8DF4830", VA = "0x188DF5430")]
		public DiyFp GYLJFFAIFSV()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xBB8550", Offset = "0xBB7950", VA = "0x180BB8550")]
		public ulong TLUOSKDPDCE()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5540", Offset = "0x8DF4940", VA = "0x188DF5540")]
		public double HCARWJYJIVU()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5640", Offset = "0x8DF4A40", VA = "0x188DF5640")]
		public double MIFATSUZKFM()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8DF53B0", Offset = "0x8DF47B0", VA = "0x188DF53B0")]
		public int CHMNGPAMDFT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8DF57A0", Offset = "0x8DF4BA0", VA = "0x188DF57A0")]
		public ulong ZWESVZWQMIR()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5250", Offset = "0x8DF4650", VA = "0x188DF5250")]
		public bool ACXAPZCSBIO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5730", Offset = "0x8DF4B30", VA = "0x188DF5730")]
		public bool RDNOGFYKYVH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5700", Offset = "0x8DF4B00", VA = "0x188DF5700")]
		public bool QRRWQXTVECX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5400", Offset = "0x8DF4800", VA = "0x188DF5400")]
		public bool FJQKKHKBAAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8DF56E0", Offset = "0x8DF4AE0", VA = "0x188DF56E0")]
		public int QKVFBEOTRQP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5270", Offset = "0x8DF4670", VA = "0x188DF5270")]
		public void BOCWYDLGIYJ([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5750", Offset = "0x8DF4B50", VA = "0x188DF5750")]
		public bool TRDZQACZQNZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3BB50D0", Offset = "0x3BB44D0", VA = "0x183BB50D0")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8DF53E0", Offset = "0x8DF47E0", VA = "0x188DF53E0")]
		public static int CHVQPPBGJYO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8DF55C0", Offset = "0x8DF49C0", VA = "0x188DF55C0")]
		public static double JXIVAMADXGO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8DF54B0", Offset = "0x8DF48B0", VA = "0x188DF54B0")]
		public static ulong HACPMTZQPZP(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x2AC92B0", Offset = "0x2AC86B0", VA = "0x182AC92B0")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8E05DD0", Offset = "0x8E051D0", VA = "0x188E05DD0")]
		public DiyFp LICCXIRVAYO()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xC6C430", Offset = "0xC6B830", VA = "0x180C6C430")]
		public uint BNYZPBDRNDN()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8E05DB0", Offset = "0x8E051B0", VA = "0x188E05DB0")]
		public int CHMNGPAMDFT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8E05E70", Offset = "0x8E05270", VA = "0x188E05E70")]
		public uint ZWESVZWQMIR()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8E05C70", Offset = "0x8E05070", VA = "0x188E05C70")]
		public bool ACXAPZCSBIO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8E05C80", Offset = "0x8E05080", VA = "0x188E05C80")]
		public void BOCWYDLGIYJ([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8E05E30", Offset = "0x8E05230", VA = "0x188E05E30")]
		public bool TRDZQACZQNZ()
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
		[Cpp2IlInjected.Address(RVA = "0x8DF3710", Offset = "0x8DF2B10", VA = "0x188DF3710")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class UCWDCQNEVFI
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] SOKMENOHPMD;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8E08890", Offset = "0x8E07C90", VA = "0x188E08890")]
		public static void KDMPDTFVXMP(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8E087C0", Offset = "0x8E07BC0", VA = "0x188E087C0")]
		public static void DAMPZPFOLTS(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0x8E09D60", Offset = "0x8E09160", VA = "0x188E09D60")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5833C10", Offset = "0x5833010", VA = "0x185833C10")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2A8EBF0", Offset = "0x2A8DFF0", VA = "0x182A8EBF0")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8E09D00", Offset = "0x8E09100", VA = "0x188E09D00")]
		public Vector CUZBROJTSSX(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class JPTCHVHOCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] HOOFBZWEUTL;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] ZKPQULNCHKM;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int FOEIOXHARZP;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBD60", Offset = "0x8DFB160", VA = "0x188DFBD60")]
		private static byte[] ZHPGUVPZIGZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB9D0", Offset = "0x8DFADD0", VA = "0x188DFB9D0")]
		private static Vector WRQSRPZOIJV(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8DFAB80", Offset = "0x8DF9F80", VA = "0x188DFAB80")]
		private static Vector JWQQMFPYESB(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8DFAAF0", Offset = "0x8DF9EF0", VA = "0x188DFAAF0")]
		private static void EJXUEFXKVRW(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB2A0", Offset = "0x8DFA6A0", VA = "0x188DFB2A0")]
		private static void MRSNMKIZWZD(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB940", Offset = "0x8DFAD40", VA = "0x188DFB940")]
		private static ulong UDFLGVFZAKE(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA5C0", Offset = "0x8DF99C0", VA = "0x188DFA5C0")]
		private static void BJYSVSEHVJE(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB590", Offset = "0x8DFA990", VA = "0x188DFB590")]
		private static bool NRXIFIUHCSN(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBAB0", Offset = "0x8DFAEB0", VA = "0x188DFBAB0")]
		private static DiyFp WRVISOOCYUO(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8DFAC60", Offset = "0x8DFA060", VA = "0x188DFAC60")]
		private static bool MKQBVPPKJOA(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBC40", Offset = "0x8DFB040", VA = "0x188DFBC40")]
		private static bool ZCAGUCHTDJK(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA700", Offset = "0x8DF9B00", VA = "0x188DFA700")]
		public static double? BTGCJXCVDVG(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA820", Offset = "0x8DF9C20", VA = "0x188DFA820")]
		public static float? BTQQEKQPWRY(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class HFOALQJFKWZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] SHJHTODPNHT;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] EIZWLDEAHMA;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] QRGBTLUMJKB;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] JYJMIRRNWZF;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int TMIKAUGRHFJ;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] HKYQZMYWBSV;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int KAOBYFGFHON;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6250", Offset = "0x8DF5650", VA = "0x188DF6250")]
		private static byte[] GPZMGVVNMKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6330", Offset = "0x8DF5730", VA = "0x188DF6330")]
		public static bool HDKGBIBTBRN(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6110", Offset = "0x8DF5510", VA = "0x188DF6110")]
		public static bool BVWTNPUNXVQ(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8DF77A0", Offset = "0x8DF6BA0", VA = "0x188DF77A0")]
		private static bool YCRANLGXPLZ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6490", Offset = "0x8DF5890", VA = "0x188DF6490")]
		private static bool SPPGNULYCJU(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6030", Offset = "0x8DF5430", VA = "0x188DF6030")]
		private static bool BSBZCTYBPUH(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6750", Offset = "0x8DF5B50", VA = "0x188DF6750")]
		private static bool TZGCERZDJTH(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6470", Offset = "0x8DF5870", VA = "0x188DF6470")]
		private static double RAFLVZPCYII(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8DF67C0", Offset = "0x8DF5BC0", VA = "0x188DF67C0")]
		private static double XOYIQFMSDLY(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class KTERXTCHXKY<a> : HNMCAPHXUKI<a[]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly EQHEMBIEMSO<a> QVHCLQJSKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour RMZLZZHYOQH;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x163BEE0", Offset = "0x163B2E0", VA = "0x18163BEE0")]
		public KTERXTCHXKY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
		public KTERXTCHXKY(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x52516F0", Offset = "0x5250AF0", VA = "0x1852516F0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x52513C0", Offset = "0x52507C0", VA = "0x1852513C0", Slot = "5")]
		public a[] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class UCTXBMIAYUZ<a> : HNMCAPHXUKI<ArraySegment<a>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly EQHEMBIEMSO<a> QVHCLQJSKKB;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6122A30", Offset = "0x6121E30", VA = "0x186122A30", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x61225F0", Offset = "0x61219F0", VA = "0x1861225F0", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class SNDXBHLIURF<a> : HNMCAPHXUKI<List<a>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour RMZLZZHYOQH;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x163BEE0", Offset = "0x163B2E0", VA = "0x18163BEE0")]
		public SNDXBHLIURF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
		public SNDXBHLIURF(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9020", Offset = "0x5DE8420", VA = "0x185DE9020", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x5DE5770", Offset = "0x5DE4B70", VA = "0x185DE5770", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class RDQVODDALZL<a, b, c, d> : HNMCAPHXUKI<d>, QOSEDTIGXHN where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5B31C70", Offset = "0x5B31070", VA = "0x185B31C70", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5B30A30", Offset = "0x5B2FE30", VA = "0x185B30A30", Slot = "5")]
		public d Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c PXPNJJPOQIJ(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected RDQVODDALZL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class RDWCLJWXVKU<a, b, c> : RDQVODDALZL<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x50F7580", Offset = "0x50F6980", VA = "0x1850F7580", Slot = "6")]
		protected override IEnumerator<a> PXPNJJPOQIJ(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected RDWCLJWXVKU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class REBJIQQVEWD<a, b> : RDWCLJWXVKU<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xB04600", Offset = "0xB03A00", VA = "0x180B04600", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class YEMJYXWOMFP<a, b> : REBJIQQVEWD<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC06C0", Offset = "0x3DBFAC0", VA = "0x183DC06C0", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0560", Offset = "0x3DBF960", VA = "0x183DC0560", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class UXBFLYZIYSU<a> : RDQVODDALZL<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x614C200", Offset = "0x614B600", VA = "0x18614C200", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xB04600", Offset = "0xB03A00", VA = "0x180B04600", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5254470", Offset = "0x5253870", VA = "0x185254470", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x468CBB0", Offset = "0x468BFB0", VA = "0x18468CBB0", Slot = "6")]
		protected override LinkedList<a>.Enumerator PXPNJJPOQIJ(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class DWUJNOOJJVX<a> : RDQVODDALZL<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D050", Offset = "0x3D2C450", VA = "0x183D2D050", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D130", Offset = "0x3D2C530", VA = "0x183D2D130", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x41536F0", Offset = "0x4152AF0", VA = "0x1841536F0", Slot = "6")]
		protected override Queue<a>.Enumerator PXPNJJPOQIJ(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xB04600", Offset = "0xB03A00", VA = "0x180B04600", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class VXUKMYGWRXB<a> : RDQVODDALZL<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A5E0", Offset = "0x3F099E0", VA = "0x183F0A5E0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4FF5E90", Offset = "0x4FF5290", VA = "0x184FF5E90", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x625BD30", Offset = "0x625B130", VA = "0x18625BD30", Slot = "6")]
		protected override Stack<a>.Enumerator PXPNJJPOQIJ(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x625BBD0", Offset = "0x625AFD0", VA = "0x18625BBD0", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class MKYVZVSZVOP<a> : RDQVODDALZL<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x57D20A0", Offset = "0x57D14A0", VA = "0x1857D20A0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xB04600", Offset = "0xB03A00", VA = "0x180B04600", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x57D20E0", Offset = "0x57D14E0", VA = "0x1857D20E0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x57D2140", Offset = "0x57D1540", VA = "0x1857D2140", Slot = "6")]
		protected override HashSet<a>.Enumerator PXPNJJPOQIJ(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x57D2190", Offset = "0x57D1590", VA = "0x1857D2190")]
		public MKYVZVSZVOP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class ZMXOTGMWCTH<a> : RDWCLJWXVKU<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A5E0", Offset = "0x3F099E0", VA = "0x183F0A5E0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A6C0", Offset = "0x3F09AC0", VA = "0x183F0A6C0", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A750", Offset = "0x3F09B50", VA = "0x183F0A750", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class CKRVYCBJQLI<a> : RDWCLJWXVKU<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D050", Offset = "0x3D2C450", VA = "0x183D2D050", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D130", Offset = "0x3D2C530", VA = "0x183D2D130", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB04600", Offset = "0xB03A00", VA = "0x180B04600", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class PIBQPUIYMZU<a> : RDWCLJWXVKU<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D050", Offset = "0x3D2C450", VA = "0x183D2D050", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D130", Offset = "0x3D2C530", VA = "0x183D2D130", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB04600", Offset = "0xB03A00", VA = "0x180B04600", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class PFHHSCBKLQI<a> : RDWCLJWXVKU<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5A4C7C0", Offset = "0x5A4BBC0", VA = "0x185A4C7C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x4FF5E90", Offset = "0x4FF5290", VA = "0x184FF5E90", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5A4C7E0", Offset = "0x5A4BBE0", VA = "0x185A4C7E0", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x4FEEE10", Offset = "0x4FEE210", VA = "0x184FEEE10")]
		public PFHHSCBKLQI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class COFNTMBLNFW<a, b> : HNMCAPHXUKI<IGrouping<a, b>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3DA0460", Offset = "0x3D9F860", VA = "0x183DA0460", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3DA0110", Offset = "0x3D9F510", VA = "0x183DA0110", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class EAJTDFFVNMR<a, b> : HNMCAPHXUKI<ILookup<a, b>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x4756960", Offset = "0x4755D60", VA = "0x184756960", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x4756610", Offset = "0x4755A10", VA = "0x184756610", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class LXJUAXIPOWR<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a RJWUJQXIPUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> BXZQJLNMPID;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x3D2BFA0", Offset = "0x3D2B3A0", VA = "0x183D2BFA0", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5308D10", Offset = "0x5308110", VA = "0x185308D10")]
		public LXJUAXIPOWR(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5308CA0", Offset = "0x53080A0", VA = "0x185308CA0", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x50EE880", Offset = "0x50EDC80", VA = "0x1850EE880", Slot = "6")]
		private IEnumerator CQMSCGRISCD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class PRDHGTCOEVE<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> MTZLHHRBKQU;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x5A59F70", Offset = "0x5A59370", VA = "0x185A59F70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public PRDHGTCOEVE(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5A59E80", Offset = "0x5A59280", VA = "0x185A59E80", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x5A59DE0", Offset = "0x5A591E0", VA = "0x185A59DE0", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5A59DE0", Offset = "0x5A591E0", VA = "0x185A59DE0", Slot = "7")]
		private IEnumerator CQMSCGRISCD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class SASHLTNTRKH<a> : HNMCAPHXUKI<a>, QOSEDTIGXHN where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB460", Offset = "0x5DBA860", VA = "0x185DBB460", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5DBB250", Offset = "0x5DBA650", VA = "0x185DBB250", Slot = "5")]
		public a Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public SASHLTNTRKH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class QREMIILTDBJ : HNMCAPHXUKI<IEnumerable>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly HNMCAPHXUKI<IEnumerable> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8E03890", Offset = "0x8E02C90", VA = "0x188E03890", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8E03680", Offset = "0x8E02A80", VA = "0x188E03680", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public QREMIILTDBJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class OWUIGTUCYTT : HNMCAPHXUKI<ICollection>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly HNMCAPHXUKI<ICollection> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8E01690", Offset = "0x8E00A90", VA = "0x188E01690", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8E01480", Offset = "0x8E00880", VA = "0x188E01480", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public OWUIGTUCYTT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class SZZRJEHMNBD : HNMCAPHXUKI<IList>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly HNMCAPHXUKI<IList> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8E05860", Offset = "0x8E04C60", VA = "0x188E05860", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8E05650", Offset = "0x8E04A50", VA = "0x188E05650", Slot = "5")]
		public IList Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public SZZRJEHMNBD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class GWWSLPDQXBC<a> : REBJIQQVEWD<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D050", Offset = "0x3D2C450", VA = "0x183D2D050", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD8E0", Offset = "0x4EDCCE0", VA = "0x184EDD8E0", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class QWXEWHQSVCC<a> : RDWCLJWXVKU<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D050", Offset = "0x3D2C450", VA = "0x183D2D050", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD8E0", Offset = "0x4EDCCE0", VA = "0x184EDD8E0", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2340", Offset = "0x5AF1740", VA = "0x185AF2340", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class VNYXVCGCSGU<a> : RDWCLJWXVKU<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6131730", Offset = "0x6130B30", VA = "0x186131730", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x4FF5E90", Offset = "0x4FF5290", VA = "0x184FF5E90", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6252230", Offset = "0x6251630", VA = "0x186252230", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x62522D0", Offset = "0x62516D0", VA = "0x1862522D0")]
		public VNYXVCGCSGU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class UOMDDSJCCRO<a> : RDWCLJWXVKU<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6131730", Offset = "0x6130B30", VA = "0x186131730", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x4FF5E90", Offset = "0x4FF5290", VA = "0x184FF5E90", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5A4C7E0", Offset = "0x5A4BBE0", VA = "0x185A4C7E0", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x4FEEE10", Offset = "0x4FEE210", VA = "0x184FEEE10")]
		public UOMDDSJCCRO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class KYUAZNNXACI<a> : RDWCLJWXVKU<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x5254380", Offset = "0x5253780", VA = "0x185254380", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xB04600", Offset = "0xB03A00", VA = "0x180B04600", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5254470", Offset = "0x5253870", VA = "0x185254470", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class BBXZIUVPXOE<a> : REBJIQQVEWD<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D050", Offset = "0x3D2C450", VA = "0x183D2D050", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D130", Offset = "0x3D2C530", VA = "0x183D2D130", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class GJWUURWWKWT<a> : REBJIQQVEWD<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D050", Offset = "0x3D2C450", VA = "0x183D2D050", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D130", Offset = "0x3D2C530", VA = "0x183D2D130", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class IJOKIRGYYJQ<a> : RDWCLJWXVKU<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A5E0", Offset = "0x3F099E0", VA = "0x183F0A5E0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x4FF5E90", Offset = "0x4FF5290", VA = "0x184FF5E90", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4FF5D30", Offset = "0x4FF5130", VA = "0x184FF5D30", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class UCFBFYCWHJN
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
		[Cpp2IlInjected.Address(RVA = "0x8E08700", Offset = "0x8E07B00", VA = "0x188E08700")]
		public static DateTime OBVHIJEEHYT(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8E08320", Offset = "0x8E07720", VA = "0x188E08320")]
		public static bool JBRFKVQFXXU(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8E07E80", Offset = "0x8E07280", VA = "0x188E07E80")]
		public static bool ESPZSMFRMTM(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8E08110", Offset = "0x8E07510", VA = "0x188E08110")]
		public static bool ESPZSMFRMTM(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8E084D0", Offset = "0x8E078D0", VA = "0x188E084D0")]
		public static bool NTSTGEILLOY(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class TDRDMGPIXEL : HNMCAPHXUKI<DateTime>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly HNMCAPHXUKI<DateTime> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8E06930", Offset = "0x8E05D30", VA = "0x188E06930", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8E063B0", Offset = "0x8E057B0", VA = "0x188E063B0", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8E06530", Offset = "0x8E05930", VA = "0x188E06530")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public TDRDMGPIXEL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class WAUVROVOXCG : HNMCAPHXUKI<DateTimeOffset>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly HNMCAPHXUKI<DateTimeOffset> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8E0A1F0", Offset = "0x8E095F0", VA = "0x188E0A1F0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8E0A180", Offset = "0x8E09580", VA = "0x188E0A180", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8E09DA0", Offset = "0x8E091A0", VA = "0x188E09DA0")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public WAUVROVOXCG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class MAETYPLANBJ : HNMCAPHXUKI<TimeSpan>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly HNMCAPHXUKI<TimeSpan> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] ZHADWXCBWTF;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8DFEF70", Offset = "0x8DFE370", VA = "0x188DFEF70", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8DFEEF0", Offset = "0x8DFE2F0", VA = "0x188DFEEF0", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8DFEB00", Offset = "0x8DFDF00", VA = "0x188DFEB00")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public MAETYPLANBJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class JFYCWKBFBDI<a, b, c, d, e> : HNMCAPHXUKI<e>, QOSEDTIGXHN where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x50F2970", Offset = "0x50F1D70", VA = "0x1850F2970", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x50F0930", Offset = "0x50EFD30", VA = "0x1850F0930", Slot = "5")]
		public e Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d PXPNJJPOQIJ(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected JFYCWKBFBDI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class JGDJTQVCKOR<a, b, c, d> : JFYCWKBFBDI<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x50F7580", Offset = "0x50F6980", VA = "0x1850F7580", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> PXPNJJPOQIJ(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected JGDJTQVCKOR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class JESNMVLUWNG<a, b, c> : JGDJTQVCKOR<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xB04600", Offset = "0xB03A00", VA = "0x180B04600", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class NSBPDFGWDAO<a, b> : JFYCWKBFBDI<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5858320", Offset = "0x5857720", VA = "0x185858320", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xB04600", Offset = "0xB03A00", VA = "0x180B04600", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5858580", Offset = "0x5857980", VA = "0x185858580", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x5858750", Offset = "0x5857B50", VA = "0x185858750", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator PXPNJJPOQIJ(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x5357100", Offset = "0x5356500", VA = "0x185357100")]
		public NSBPDFGWDAO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class XMVXRDWGACS<a, b, c> : JESNMVLUWNG<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3DB0F80", Offset = "0x3DB0380", VA = "0x183DB0F80", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3DB1170", Offset = "0x3DB0570", VA = "0x183DB1170", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class QJXRNCYZNYL<a, b> : JGDJTQVCKOR<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x4770A30", Offset = "0x476FE30", VA = "0x184770A30", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x4EBFF50", Offset = "0x4EBF350", VA = "0x184EBFF50", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB04600", Offset = "0xB03A00", VA = "0x180B04600", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class RPSAIYBHMQB<a, b> : JESNMVLUWNG<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x4770A30", Offset = "0x476FE30", VA = "0x184770A30", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x4EBFF50", Offset = "0x4EBF350", VA = "0x184EBFF50", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class OCODPNTRQBH<a, b> : JFYCWKBFBDI<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x4770A30", Offset = "0x476FE30", VA = "0x184770A30", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB04600", Offset = "0xB03A00", VA = "0x180B04600", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x4EBFF50", Offset = "0x4EBF350", VA = "0x184EBFF50", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x59845D0", Offset = "0x59839D0", VA = "0x1859845D0", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator PXPNJJPOQIJ(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class EXQJEOVSIHW<a, b> : JGDJTQVCKOR<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x4770A30", Offset = "0x476FE30", VA = "0x184770A30", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x4770BA0", Offset = "0x476FFA0", VA = "0x184770BA0", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x4770C10", Offset = "0x4770010", VA = "0x184770C10", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class OIFSFWEOMFP<a, b> : JGDJTQVCKOR<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x5988800", Offset = "0x5987C00", VA = "0x185988800", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xB04600", Offset = "0xB03A00", VA = "0x180B04600", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x59888A0", Offset = "0x5987CA0", VA = "0x1859888A0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x57D2190", Offset = "0x57D1590", VA = "0x1857D2190")]
		public OIFSFWEOMFP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class GHANVXEPNPT<a, b> : JESNMVLUWNG<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x4EBFDE0", Offset = "0x4EBF1E0", VA = "0x184EBFDE0", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x4EBFF50", Offset = "0x4EBF350", VA = "0x184EBFF50", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class GCGJGEELJWH<a> : HNMCAPHXUKI<a>, QOSEDTIGXHN where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x4EB9140", Offset = "0x4EB8540", VA = "0x184EB9140", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8F00", Offset = "0x4EB8300", VA = "0x184EB8F00", Slot = "5")]
		public a Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GCGJGEELJWH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class RHQONKCRNJX : HNMCAPHXUKI<IDictionary>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly HNMCAPHXUKI<IDictionary> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8E041D0", Offset = "0x8E035D0", VA = "0x188E041D0", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8E03FF0", Offset = "0x8E033F0", VA = "0x188E03FF0", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RHQONKCRNJX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class DWBBEIANMWT
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8DF40B0", Offset = "0x8DF34B0", VA = "0x188DF40B0")]
		public static object GWXFAZNLMPR(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4890", Offset = "0x8DF3C90", VA = "0x188DF4890")]
		public static object LCZITLDELUS(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class IMSJUJJKDDO<a> : HNMCAPHXUKI<a>, QOSEDTIGXHN, TEPLNOGQIKJ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class OBPSGXVZRRC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type UCRFZIXSQJU;

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OBPSGXVZRRC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x5982DC0", Offset = "0x59821C0", VA = "0x185982DC0")]
			internal bool NSPTPOMMYKL(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class OBUZEEPXBCL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string JJOELMUYTHK;

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OBUZEEPXBCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x59831E0", Offset = "0x59825E0", VA = "0x1859831E0")]
			internal bool NSKMSHSPOZC(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class OCAGBLJUKNU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> TLAZLQVLBGP;

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OCAGBLJUKNU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x5983800", Offset = "0x5982C00", VA = "0x185983800")]
			internal void NTAHKCAHRHD(JsonWriter a, a b, PPKJWPQRQAZ c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class OCFMYSDRTZD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> BFXAZWRRCRU;

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OCFMYSDRTZD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x5983DB0", Offset = "0x59831B0", VA = "0x185983DB0")]
			internal a NSVAMVGKHVU(JsonReader a, PPKJWPQRQAZ b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly RBYINCSWVZN<a> VIRGSGEFWLG;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> XLALAGNSOMK;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> SLOTEGPVOSO;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> LYHEYEBSBRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool TLNACWIMTTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> LKPXKDRNEIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> NQYVOHOYALG;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5004C70", Offset = "0x5004070", VA = "0x185004C70")]
		static IMSJUJJKDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x5009D60", Offset = "0x5009160", VA = "0x185009D60")]
		public IMSJUJJKDDO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x4FFF820", Offset = "0x4FFEC20", VA = "0x184FFF820", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x4FFD190", Offset = "0x4FFC590", VA = "0x184FFD190", Slot = "5")]
		public a Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x4FFEBB0", Offset = "0x4FFDFB0", VA = "0x184FFEBB0", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, a b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x4FFC7E0", Offset = "0x4FFBBE0", VA = "0x184FFC7E0", Slot = "7")]
		public a ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class EYEJIYXMUJG<a> : HNMCAPHXUKI<a[,]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x4771580", Offset = "0x4770980", VA = "0x184771580", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x47711F0", Offset = "0x47705F0", VA = "0x1847711F0", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public EYEJIYXMUJG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class DCLQCPBUVSK<a> : HNMCAPHXUKI<a[,,]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x413AE00", Offset = "0x413A200", VA = "0x18413AE00", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x413A930", Offset = "0x4139D30", VA = "0x18413A930", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public DCLQCPBUVSK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class KKQKATVIIXU<a> : HNMCAPHXUKI<a[,,,]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x521B810", Offset = "0x521AC10", VA = "0x18521B810", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x521B210", Offset = "0x521A610", VA = "0x18521B210", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public KKQKATVIIXU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class JOWDTTUNEPO<a> : HNMCAPHXUKI<a?>, QOSEDTIGXHN where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x510DD40", Offset = "0x510D140", VA = "0x18510DD40", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x510D8D0", Offset = "0x510CCD0", VA = "0x18510D8D0", Slot = "5")]
		public a? Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public JOWDTTUNEPO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class GXEJXKXSLJA<a> : HNMCAPHXUKI<a?>, QOSEDTIGXHN where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly HNMCAPHXUKI<a> DDNXFZQXOQR;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public GXEJXKXSLJA(HNMCAPHXUKI<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE6B0", Offset = "0x4EDDAB0", VA = "0x184EDE6B0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE290", Offset = "0x4EDD690", VA = "0x184EDE290", Slot = "5")]
		public a? Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class NJBWFIXUKPH : HNMCAPHXUKI<sbyte>, QOSEDTIGXHN, TEPLNOGQIKJ<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly NJBWFIXUKPH VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8E00420", Offset = "0x8DFF820", VA = "0x188E00420", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8E00300", Offset = "0x8DFF700", VA = "0x188E00300", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8E00310", Offset = "0x8DFF710", VA = "0x188E00310", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, sbyte b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8E00280", Offset = "0x8DFF680", VA = "0x188E00280", Slot = "7")]
		public sbyte ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public NJBWFIXUKPH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class MHQKOASUJWU : HNMCAPHXUKI<sbyte?>, QOSEDTIGXHN, TEPLNOGQIKJ<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly MHQKOASUJWU VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8DFF920", Offset = "0x8DFED20", VA = "0x188DFF920", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8DFF750", Offset = "0x8DFEB50", VA = "0x188DFF750", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8DFF7C0", Offset = "0x8DFEBC0", VA = "0x188DFF7C0", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, sbyte? b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8DFF680", Offset = "0x8DFEA80", VA = "0x188DFF680", Slot = "7")]
		public sbyte? ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public MHQKOASUJWU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class SDSUTWMLMXS : HNMCAPHXUKI<sbyte[]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly SDSUTWMLMXS VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8E053B0", Offset = "0x8E047B0", VA = "0x188E053B0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8E05270", Offset = "0x8E04670", VA = "0x188E05270", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public SDSUTWMLMXS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class PWZFOKIDFWK : HNMCAPHXUKI<short>, QOSEDTIGXHN, TEPLNOGQIKJ<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly PWZFOKIDFWK VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8E02360", Offset = "0x8E01760", VA = "0x188E02360", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8E02240", Offset = "0x8E01640", VA = "0x188E02240", Slot = "5")]
		public short Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8E02250", Offset = "0x8E01650", VA = "0x188E02250", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, short b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8E021C0", Offset = "0x8E015C0", VA = "0x188E021C0", Slot = "7")]
		public short ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public PWZFOKIDFWK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class UJNOVQCEMNF : HNMCAPHXUKI<short?>, QOSEDTIGXHN, TEPLNOGQIKJ<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly UJNOVQCEMNF VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8E09BA0", Offset = "0x8E08FA0", VA = "0x188E09BA0", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8E099D0", Offset = "0x8E08DD0", VA = "0x188E099D0", Slot = "5")]
		public short? Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8E09A40", Offset = "0x8E08E40", VA = "0x188E09A40", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, short? b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8E09900", Offset = "0x8E08D00", VA = "0x188E09900", Slot = "7")]
		public short? ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public UJNOVQCEMNF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class RHJBYYATAQZ : HNMCAPHXUKI<short[]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly RHJBYYATAQZ VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8E03D50", Offset = "0x8E03150", VA = "0x188E03D50", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8E03C10", Offset = "0x8E03010", VA = "0x188E03C10", Slot = "5")]
		public short[] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RHJBYYATAQZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class RYFFMBBMVVO : HNMCAPHXUKI<int>, QOSEDTIGXHN, TEPLNOGQIKJ<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly RYFFMBBMVVO VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8E04D40", Offset = "0x8E04140", VA = "0x188E04D40", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8E04C20", Offset = "0x8E04020", VA = "0x188E04C20", Slot = "5")]
		public int Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8E04C30", Offset = "0x8E04030", VA = "0x188E04C30", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, int b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8E04BA0", Offset = "0x8E03FA0", VA = "0x188E04BA0", Slot = "7")]
		public int ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RYFFMBBMVVO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class IEDCFOSRPEZ : HNMCAPHXUKI<int?>, QOSEDTIGXHN, TEPLNOGQIKJ<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly IEDCFOSRPEZ VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8220", Offset = "0x8DF7620", VA = "0x188DF8220", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8DF8050", Offset = "0x8DF7450", VA = "0x188DF8050", Slot = "5")]
		public int? Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8DF80C0", Offset = "0x8DF74C0", VA = "0x188DF80C0", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, int? b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7F80", Offset = "0x8DF7380", VA = "0x188DF7F80", Slot = "7")]
		public int? ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public IEDCFOSRPEZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class CLIEYHNNIYH : HNMCAPHXUKI<int[]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly CLIEYHNNIYH VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3470", Offset = "0x8DF2870", VA = "0x188DF3470", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3330", Offset = "0x8DF2730", VA = "0x188DF3330", Slot = "5")]
		public int[] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CLIEYHNNIYH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class MSPLUAIQSGJ : HNMCAPHXUKI<long>, QOSEDTIGXHN, TEPLNOGQIKJ<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly MSPLUAIQSGJ VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFD90", Offset = "0x8DFF190", VA = "0x188DFFD90", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFCB0", Offset = "0x8DFF0B0", VA = "0x188DFFCB0", Slot = "5")]
		public long Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFCC0", Offset = "0x8DFF0C0", VA = "0x188DFFCC0", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, long b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFC70", Offset = "0x8DFF070", VA = "0x188DFFC70", Slot = "7")]
		public long ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public MSPLUAIQSGJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class YSPBNUSSDQU : HNMCAPHXUKI<long?>, QOSEDTIGXHN, TEPLNOGQIKJ<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly YSPBNUSSDQU VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C160", Offset = "0x8E0B560", VA = "0x188E0C160", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BFA0", Offset = "0x8E0B3A0", VA = "0x188E0BFA0", Slot = "5")]
		public long? Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C030", Offset = "0x8E0B430", VA = "0x188E0C030", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, long? b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BEF0", Offset = "0x8E0B2F0", VA = "0x188E0BEF0", Slot = "7")]
		public long? ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public YSPBNUSSDQU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class RQBUDPMMLWQ : HNMCAPHXUKI<long[]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly RQBUDPMMLWQ VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8E04970", Offset = "0x8E03D70", VA = "0x188E04970", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8E04830", Offset = "0x8E03C30", VA = "0x188E04830", Slot = "5")]
		public long[] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RQBUDPMMLWQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class QHIUDFJFTSK : HNMCAPHXUKI<byte>, QOSEDTIGXHN, TEPLNOGQIKJ<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly QHIUDFJFTSK VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8E02600", Offset = "0x8E01A00", VA = "0x188E02600", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8E024E0", Offset = "0x8E018E0", VA = "0x188E024E0", Slot = "5")]
		public byte Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8E024F0", Offset = "0x8E018F0", VA = "0x188E024F0", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, byte b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8E02460", Offset = "0x8E01860", VA = "0x188E02460", Slot = "7")]
		public byte ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public QHIUDFJFTSK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class JYZMXEWRPWR : HNMCAPHXUKI<byte?>, QOSEDTIGXHN, TEPLNOGQIKJ<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly JYZMXEWRPWR VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8DFC190", Offset = "0x8DFB590", VA = "0x188DFC190", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBFC0", Offset = "0x8DFB3C0", VA = "0x188DFBFC0", Slot = "5")]
		public byte? Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8DFC030", Offset = "0x8DFB430", VA = "0x188DFC030", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, byte? b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBEF0", Offset = "0x8DFB2F0", VA = "0x188DFBEF0", Slot = "7")]
		public byte? ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public JYZMXEWRPWR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class BFISMHVXJUZ : HNMCAPHXUKI<ushort>, QOSEDTIGXHN, TEPLNOGQIKJ<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly BFISMHVXJUZ VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3230", Offset = "0x8DF2630", VA = "0x188DF3230", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3110", Offset = "0x8DF2510", VA = "0x188DF3110", Slot = "5")]
		public ushort Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3120", Offset = "0x8DF2520", VA = "0x188DF3120", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, ushort b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3090", Offset = "0x8DF2490", VA = "0x188DF3090", Slot = "7")]
		public ushort ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public BFISMHVXJUZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class DMHBZBZZWXA : HNMCAPHXUKI<ushort?>, QOSEDTIGXHN, TEPLNOGQIKJ<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly DMHBZBZZWXA VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3F50", Offset = "0x8DF3350", VA = "0x188DF3F50", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3D80", Offset = "0x8DF3180", VA = "0x188DF3D80", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3DF0", Offset = "0x8DF31F0", VA = "0x188DF3DF0", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, ushort? b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3CB0", Offset = "0x8DF30B0", VA = "0x188DF3CB0", Slot = "7")]
		public ushort? ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public DMHBZBZZWXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class XDGAKDEKHOA : HNMCAPHXUKI<ushort[]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly XDGAKDEKHOA VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B6B0", Offset = "0x8E0AAB0", VA = "0x188E0B6B0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B570", Offset = "0x8E0A970", VA = "0x188E0B570", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public XDGAKDEKHOA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class NKGJOBYMYGT : HNMCAPHXUKI<uint>, QOSEDTIGXHN, TEPLNOGQIKJ<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly NKGJOBYMYGT VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8E006C0", Offset = "0x8DFFAC0", VA = "0x188E006C0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8E005A0", Offset = "0x8DFF9A0", VA = "0x188E005A0", Slot = "5")]
		public uint Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8E005B0", Offset = "0x8DFF9B0", VA = "0x188E005B0", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, uint b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8E00520", Offset = "0x8DFF920", VA = "0x188E00520", Slot = "7")]
		public uint ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public NKGJOBYMYGT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class AHJJFNRQRWA : HNMCAPHXUKI<uint?>, QOSEDTIGXHN, TEPLNOGQIKJ<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly AHJJFNRQRWA VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2BD0", Offset = "0x8DF1FD0", VA = "0x188DF2BD0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2A00", Offset = "0x8DF1E00", VA = "0x188DF2A00", Slot = "5")]
		public uint? Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2A70", Offset = "0x8DF1E70", VA = "0x188DF2A70", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, uint? b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2930", Offset = "0x8DF1D30", VA = "0x188DF2930", Slot = "7")]
		public uint? ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public AHJJFNRQRWA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class DLBNLOILFWW : HNMCAPHXUKI<uint[]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly DLBNLOILFWW VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3A10", Offset = "0x8DF2E10", VA = "0x188DF3A10", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF38D0", Offset = "0x8DF2CD0", VA = "0x188DF38D0", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public DLBNLOILFWW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class MMWYYYNYRAK : HNMCAPHXUKI<ulong>, QOSEDTIGXHN, TEPLNOGQIKJ<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly MMWYYYNYRAK VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFBA0", Offset = "0x8DFEFA0", VA = "0x188DFFBA0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFAC0", Offset = "0x8DFEEC0", VA = "0x188DFFAC0", Slot = "5")]
		public ulong Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFAD0", Offset = "0x8DFEED0", VA = "0x188DFFAD0", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, ulong b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFA80", Offset = "0x8DFEE80", VA = "0x188DFFA80", Slot = "7")]
		public ulong ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public MMWYYYNYRAK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class NYCNALLFTCR : HNMCAPHXUKI<ulong?>, QOSEDTIGXHN, TEPLNOGQIKJ<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly NYCNALLFTCR VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8E00C20", Offset = "0x8E00020", VA = "0x188E00C20", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x8E00A60", Offset = "0x8DFFE60", VA = "0x188E00A60", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8E00AF0", Offset = "0x8DFFEF0", VA = "0x188E00AF0", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, ulong? b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8E009B0", Offset = "0x8DFFDB0", VA = "0x188E009B0", Slot = "7")]
		public ulong? ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public NYCNALLFTCR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class KVGMNYIHMPX : HNMCAPHXUKI<ulong[]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly KVGMNYIHMPX VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8DFC430", Offset = "0x8DFB830", VA = "0x188DFC430", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8DFC2F0", Offset = "0x8DFB6F0", VA = "0x188DFC2F0", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public KVGMNYIHMPX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class OAIIEBQRLQM : HNMCAPHXUKI<float>, QOSEDTIGXHN, TEPLNOGQIKJ<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly OAIIEBQRLQM VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8E00E70", Offset = "0x8E00270", VA = "0x188E00E70", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8E00D90", Offset = "0x8E00190", VA = "0x188E00D90", Slot = "5")]
		public float Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8E00DA0", Offset = "0x8E001A0", VA = "0x188E00DA0", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, float b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x8E00D50", Offset = "0x8E00150", VA = "0x188E00D50", Slot = "7")]
		public float ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public OAIIEBQRLQM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class AXGVFQKLMCT : HNMCAPHXUKI<float?>, QOSEDTIGXHN, TEPLNOGQIKJ<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly AXGVFQKLMCT VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2F60", Offset = "0x8DF2360", VA = "0x188DF2F60", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2DD0", Offset = "0x8DF21D0", VA = "0x188DF2DD0", Slot = "5")]
		public float? Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2E40", Offset = "0x8DF2240", VA = "0x188DF2E40", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, float? b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2D30", Offset = "0x8DF2130", VA = "0x188DF2D30", Slot = "7")]
		public float? ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public AXGVFQKLMCT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class ZZYFBFMSPFV : HNMCAPHXUKI<float[]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly ZZYFBFMSPFV VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C960", Offset = "0x8E0BD60", VA = "0x188E0C960", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C820", Offset = "0x8E0BC20", VA = "0x188E0C820", Slot = "5")]
		public float[] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ZZYFBFMSPFV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class XXOWYBFMKMP : HNMCAPHXUKI<double>, QOSEDTIGXHN, TEPLNOGQIKJ<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly XXOWYBFMKMP VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BA70", Offset = "0x8E0AE70", VA = "0x188E0BA70", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B990", Offset = "0x8E0AD90", VA = "0x188E0B990", Slot = "5")]
		public double Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B9A0", Offset = "0x8E0ADA0", VA = "0x188E0B9A0", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, double b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B950", Offset = "0x8E0AD50", VA = "0x188E0B950", Slot = "7")]
		public double ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public XXOWYBFMKMP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class OBPYIGZLCGU : HNMCAPHXUKI<double?>, QOSEDTIGXHN, TEPLNOGQIKJ<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly OBPYIGZLCGU VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8E011B0", Offset = "0x8E005B0", VA = "0x188E011B0", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8E00FF0", Offset = "0x8E003F0", VA = "0x188E00FF0", Slot = "5")]
		public double? Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8E01080", Offset = "0x8E00480", VA = "0x188E01080", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, double? b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8E00F40", Offset = "0x8E00340", VA = "0x188E00F40", Slot = "7")]
		public double? ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public OBPYIGZLCGU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class WHIHZHZIHCO : HNMCAPHXUKI<double[]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly WHIHZHZIHCO VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8E0AE30", Offset = "0x8E0A230", VA = "0x188E0AE30", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8E0ACF0", Offset = "0x8E0A0F0", VA = "0x188E0ACF0", Slot = "5")]
		public double[] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public WHIHZHZIHCO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class WKTPKAEOJQM : HNMCAPHXUKI<bool>, QOSEDTIGXHN, TEPLNOGQIKJ<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly WKTPKAEOJQM VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B2D0", Offset = "0x8E0A6D0", VA = "0x188E0B2D0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B1F0", Offset = "0x8E0A5F0", VA = "0x188E0B1F0", Slot = "5")]
		public bool Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B200", Offset = "0x8E0A600", VA = "0x188E0B200", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, bool b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B1B0", Offset = "0x8E0A5B0", VA = "0x188E0B1B0", Slot = "7")]
		public bool ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public WKTPKAEOJQM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class ZWWYCDJQFLP : HNMCAPHXUKI<bool?>, QOSEDTIGXHN, TEPLNOGQIKJ<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly ZWWYCDJQFLP VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C6F0", Offset = "0x8E0BAF0", VA = "0x188E0C6F0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C560", Offset = "0x8E0B960", VA = "0x188E0C560", Slot = "5")]
		public bool? Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C5D0", Offset = "0x8E0B9D0", VA = "0x188E0C5D0", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, bool? b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C4C0", Offset = "0x8E0B8C0", VA = "0x188E0C4C0", Slot = "7")]
		public bool? ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ZWWYCDJQFLP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class EVEZDXTGZYP : HNMCAPHXUKI<bool[]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly EVEZDXTGZYP VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x8DF59C0", Offset = "0x8DF4DC0", VA = "0x188DF59C0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5880", Offset = "0x8DF4C80", VA = "0x188DF5880", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public EVEZDXTGZYP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class UBVOGVJQONH : HNMCAPHXUKI<byte[]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly HNMCAPHXUKI<byte[]> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x8E07D50", Offset = "0x8E07150", VA = "0x188E07D50", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x8E07CE0", Offset = "0x8E070E0", VA = "0x188E07CE0", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public UBVOGVJQONH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class YRGJEVEYFNO : HNMCAPHXUKI<ArraySegment<byte>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly HNMCAPHXUKI<ArraySegment<byte>> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BD50", Offset = "0x8E0B150", VA = "0x188E0BD50", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BC80", Offset = "0x8E0B080", VA = "0x188E0BC80", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public YRGJEVEYFNO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class YQVDSSWOHRC : HNMCAPHXUKI<string>, QOSEDTIGXHN, TEPLNOGQIKJ<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly HNMCAPHXUKI<string> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BBB0", Offset = "0x8E0AFB0", VA = "0x188E0BBB0", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BB40", Offset = "0x8E0AF40", VA = "0x188E0BB40", Slot = "5")]
		public string Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BB50", Offset = "0x8E0AF50", VA = "0x188E0BB50", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, string b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8E0BB40", Offset = "0x8E0AF40", VA = "0x188E0BB40", Slot = "7")]
		public string ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public YQVDSSWOHRC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class PDOJRQTCPVN : HNMCAPHXUKI<string[]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly PDOJRQTCPVN VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8E01C90", Offset = "0x8E01090", VA = "0x188E01C90", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x8E01B40", Offset = "0x8E00F40", VA = "0x188E01B40", Slot = "5")]
		public string[] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public PDOJRQTCPVN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class FWRJXKMMFXK : HNMCAPHXUKI<char>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly FWRJXKMMFXK VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5F10", Offset = "0x8DF5310", VA = "0x188DF5F10", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5EE0", Offset = "0x8DF52E0", VA = "0x188DF5EE0", Slot = "5")]
		public char Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public FWRJXKMMFXK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class ZPYJMQNMAGT : HNMCAPHXUKI<char?>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly ZPYJMQNMAGT VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C350", Offset = "0x8E0B750", VA = "0x188E0C350", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x8E0C290", Offset = "0x8E0B690", VA = "0x188E0C290", Slot = "5")]
		public char? Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public ZPYJMQNMAGT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class IVPUEGTGWDJ : HNMCAPHXUKI<char[]>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly IVPUEGTGWDJ VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA310", Offset = "0x8DF9710", VA = "0x188DFA310", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA180", Offset = "0x8DF9580", VA = "0x188DFA180", Slot = "5")]
		public char[] Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public IVPUEGTGWDJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class RZUXLMMJUML : HNMCAPHXUKI<Guid>, QOSEDTIGXHN, TEPLNOGQIKJ<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly HNMCAPHXUKI<Guid> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8E05090", Offset = "0x8E04490", VA = "0x188E05090", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8E04EB0", Offset = "0x8E042B0", VA = "0x188E04EB0", Slot = "5")]
		public Guid Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8E04F10", Offset = "0x8E04310", VA = "0x188E04F10", Slot = "6")]
		public void GUGLKONFZJV(JsonWriter a, Guid b, PPKJWPQRQAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8E04E40", Offset = "0x8E04240", VA = "0x188E04E40", Slot = "7")]
		public Guid ACJODJRXOWH(JsonReader a, PPKJWPQRQAZ b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public RZUXLMMJUML()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class MWIEQBDAPEJ : HNMCAPHXUKI<decimal>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly HNMCAPHXUKI<decimal> VDDQACCVTOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool GDCSBRFWKPP;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x715A460", Offset = "0x7159860", VA = "0x18715A460")]
		public MWIEQBDAPEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xD94200", Offset = "0xD93600", VA = "0x180D94200")]
		public MWIEQBDAPEJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8E00030", Offset = "0x8DFF430", VA = "0x188E00030", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFE60", Offset = "0x8DFF260", VA = "0x188DFFE60", Slot = "5")]
		public decimal Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class WVEYOUVZYZU : HNMCAPHXUKI<Uri>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly HNMCAPHXUKI<Uri> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B420", Offset = "0x8E0A820", VA = "0x188E0B420", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B3A0", Offset = "0x8E0A7A0", VA = "0x188E0B3A0", Slot = "5")]
		public Uri Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public WVEYOUVZYZU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class DARHKNSFZDK : HNMCAPHXUKI<Version>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly HNMCAPHXUKI<Version> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8DF37A0", Offset = "0x8DF2BA0", VA = "0x188DF37A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3720", Offset = "0x8DF2B20", VA = "0x188DF3720", Slot = "5")]
		public Version Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public DARHKNSFZDK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class LVRAVYMKZNM<a, b> : HNMCAPHXUKI<KeyValuePair<a, b>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5307F80", Offset = "0x5307380", VA = "0x185307F80", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5307AB0", Offset = "0x5306EB0", VA = "0x185307AB0", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class FNJBCZYUTIE : HNMCAPHXUKI<StringBuilder>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly HNMCAPHXUKI<StringBuilder> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5DD0", Offset = "0x8DF51D0", VA = "0x188DF5DD0", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5D50", Offset = "0x8DF5150", VA = "0x188DF5D50", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public FNJBCZYUTIE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class KWGNUIVVHHK : HNMCAPHXUKI<BitArray>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly HNMCAPHXUKI<BitArray> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8DFC780", Offset = "0x8DFBB80", VA = "0x188DFC780", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8DFC660", Offset = "0x8DFBA60", VA = "0x188DFC660", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public KWGNUIVVHHK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class PESMYWSLDWY : HNMCAPHXUKI<Type>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly PESMYWSLDWY VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex MDVWGSHUYZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool EVIATIZTEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool LAJHDUYGODQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool VSKAKRFVANN;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8E021A0", Offset = "0x8E015A0", VA = "0x188E021A0")]
		public PESMYWSLDWY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8144680", Offset = "0x8143A80", VA = "0x188144680")]
		public PESMYWSLDWY(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8E01FD0", Offset = "0x8E013D0", VA = "0x188E01FD0", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x8E01EC0", Offset = "0x8E012C0", VA = "0x188E01EC0", Slot = "5")]
		public Type Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class HPOJGJMPFWE : HNMCAPHXUKI<BigInteger>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly HNMCAPHXUKI<BigInteger> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7E40", Offset = "0x8DF7240", VA = "0x188DF7E40", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7D90", Offset = "0x8DF7190", VA = "0x188DF7D90", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public HPOJGJMPFWE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class HJZSSQVGTOQ : HNMCAPHXUKI<Complex>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly HNMCAPHXUKI<Complex> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7BF0", Offset = "0x8DF6FF0", VA = "0x188DF7BF0", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8DF7B60", Offset = "0x8DF6F60", VA = "0x188DF7B60", Slot = "5")]
		public Complex Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public HJZSSQVGTOQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class IHFQHXRFOIK : HNMCAPHXUKI<ExpandoObject>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly HNMCAPHXUKI<ExpandoObject> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA080", Offset = "0x8DF9480", VA = "0x188DFA080", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9E50", Offset = "0x8DF9250", VA = "0x188DF9E50", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public IHFQHXRFOIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class HZJDXEXHXNH<a> : HNMCAPHXUKI<Lazy<a>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x4F4CA10", Offset = "0x4F4BE10", VA = "0x184F4CA10", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x4F4C810", Offset = "0x4F4BC10", VA = "0x184F4C810", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class NTBTTNHZPRD : HNMCAPHXUKI<Task>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly HNMCAPHXUKI<Task> VDDQACCVTOD;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task PNSXRSSOXRM;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8E00870", Offset = "0x8DFFC70", VA = "0x188E00870", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8E007C0", Offset = "0x8DFFBC0", VA = "0x188E007C0", Slot = "5")]
		public Task Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public NTBTTNHZPRD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class JQCAJUEMFIV<a> : HNMCAPHXUKI<Task<a>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x5111960", Offset = "0x5110D60", VA = "0x185111960", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x51117F0", Offset = "0x5110BF0", VA = "0x1851117F0", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class IRVAEWJTEED<a> : HNMCAPHXUKI<ValueTask<a>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5026D20", Offset = "0x5026120", VA = "0x185026D20", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5026B00", Offset = "0x5025F00", VA = "0x185026B00", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class RFGSMFXKCVX<a> : HNMCAPHXUKI<Tuple<a>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x5B347C0", Offset = "0x5B33BC0", VA = "0x185B347C0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x5B344F0", Offset = "0x5B338F0", VA = "0x185B344F0", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class REQXULPSANW<a, b> : HNMCAPHXUKI<Tuple<a, b>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x5B32950", Offset = "0x5B31D50", VA = "0x185B32950", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x5B32530", Offset = "0x5B31930", VA = "0x185B32530", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class REWERSJPJZF<a, b, c> : HNMCAPHXUKI<Tuple<a, b, c>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x5B33E80", Offset = "0x5B33280", VA = "0x185B33E80", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x5B33920", Offset = "0x5B32D20", VA = "0x185B33920", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class RFWNEAFCFDY<a, b, c, d> : HNMCAPHXUKI<Tuple<a, b, c, d>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x5B39670", Offset = "0x5B38A70", VA = "0x185B39670", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x5B38FB0", Offset = "0x5B383B0", VA = "0x185B38FB0", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class RGBUBGYZOPH<a, b, c, d, e> : HNMCAPHXUKI<Tuple<a, b, c, d, e>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5B3A660", Offset = "0x5B39A60", VA = "0x185B3A660", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5B39E50", Offset = "0x5B39250", VA = "0x185B39E50", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class RFLZJMRHMHG<a, b, c, d, e, f> : HNMCAPHXUKI<Tuple<a, b, c, d, e, f>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5B35610", Offset = "0x5B34A10", VA = "0x185B35610", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5B34C80", Offset = "0x5B34080", VA = "0x185B34C80", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class RFRGGTLEVSP<a, b, c, d, e, f, g> : HNMCAPHXUKI<Tuple<a, b, c, d, e, f, g>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x5B36C80", Offset = "0x5B36080", VA = "0x185B36C80", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x5B36160", Offset = "0x5B35560", VA = "0x185B36160", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class RDLIKXAHVXU<a, b, c, d, e, f, g, h> : HNMCAPHXUKI<Tuple<a, b, c, d, e, f, g, h>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x5B2F640", Offset = "0x5B2EA40", VA = "0x185B2F640", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x5B2E9B0", Offset = "0x5B2DDB0", VA = "0x185B2E9B0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class JWTOOLSFJUM<a> : HNMCAPHXUKI<ValueTuple<a>>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x511F0A0", Offset = "0x511E4A0", VA = "0x18511F0A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x511EC80", Offset = "0x511E080", VA = "0x18511EC80", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class JXJJGFZXMCN<a, b> : HNMCAPHXUKI<(a, b)>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x51206F0", Offset = "0x511FAF0", VA = "0x1851206F0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5120200", Offset = "0x511F600", VA = "0x185120200", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class JXECIZGACRE<a, b, c> : HNMCAPHXUKI<(a, b, c)>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x511FAF0", Offset = "0x511EEF0", VA = "0x18511FAF0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x511F480", Offset = "0x511E880", VA = "0x18511F480", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class JXTXATNSEZF<a, b, c, d> : HNMCAPHXUKI<(a, b, c, d)>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x51228E0", Offset = "0x5121CE0", VA = "0x1851228E0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x51220A0", Offset = "0x51214A0", VA = "0x1851220A0", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class JXOQDMTUVNW<a, b, c, d, e> : HNMCAPHXUKI<(a, b, c, d, e)>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x5121620", Offset = "0x5120A20", VA = "0x185121620", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x5120C60", Offset = "0x5120060", VA = "0x185120C60", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class JYEKVHBMXVX<a, b, c, d, e, f> : HNMCAPHXUKI<(a, b, c, d, e, f)>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x51258D0", Offset = "0x5124CD0", VA = "0x1851258D0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5124D00", Offset = "0x5124100", VA = "0x185124D00", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class JXZDYAHPOKO<a, b, c, d, e, f, g> : HNMCAPHXUKI<(a, b, c, d, e, f, g)>, QOSEDTIGXHN
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x5123F30", Offset = "0x5123330", VA = "0x185123F30", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x51231C0", Offset = "0x51225C0", VA = "0x1851231C0", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class JYOYPUPHQSP<a, b, c, d, e, f, g, h> : HNMCAPHXUKI<ValueTuple<a, b, c, d, e, f, g, h>>, QOSEDTIGXHN where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] XBCANOZZEIE;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly UNXSDLXDJCU YTDGYJHFVFE;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x5127430", Offset = "0x5126830", VA = "0x185127430", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, PPKJWPQRQAZ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x5126500", Offset = "0x5125900", VA = "0x185126500", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, PPKJWPQRQAZ formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class TBXUABWNFLW
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] PITCCXCAYHW;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly UNXSDLXDJCU UQQDVVZCQWZ;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8E06210", Offset = "0x8E05610", VA = "0x188E06210")]
		static TBXUABWNFLW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class OSDEYZASZOO
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] AORMCUFCFXH;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly UNXSDLXDJCU ZYLWMGNMVZG;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x8E012E0", Offset = "0x8E006E0", VA = "0x188E012E0")]
		static OSDEYZASZOO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class QLZZLLZWXMW
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] ZVXXSLLGHWM;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly UNXSDLXDJCU RTHIDXJANCB;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] ZWNSKFSYKEN;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly UNXSDLXDJCU RSRNMDBIKUA;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] ZWILMYZBATE;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly UNXSDLXDJCU RSWUJJVFUFJ;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] ZVIDARDOFOL;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly UNXSDLXDJCU RTXCVRQSPKC;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] ZVCWDKJQWDC;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly UNXSDLXDJCU RUCJSYKPYVL;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] ZVSQVERIYLD;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly UNXSDLXDJCU RTMPBECXWNK;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] ZVNJXXXLOZU;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly UNXSDLXDJCU RTRVYKWVFYT;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] ZUNBLQBYTVB;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly UNXSDLXDJCU RUSEKSSIBDM;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x8E02700", Offset = "0x8E01B00", VA = "0x188E02700")]
		static QLZZLLZWXMW()
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
