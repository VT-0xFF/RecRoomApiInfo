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
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, BBOFZKRFCTL resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, BBOFZKRFCTL resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface YRUEVOCAGJF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface KHJXOJJZUWY<a> : YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, BBOFZKRFCTL formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface SFXMQQMLSQV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IBXPUAGTWZZ(JsonWriter a, a b, BBOFZKRFCTL c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b);
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
	public static class XDMUYGUHDIQ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x410FD30", Offset = "0x410E730", VA = "0x18410FD30")]
		public static string ToJsonString<T>(this KHJXOJJZUWY<T> formatter, T value, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KHJXOJJZUWY<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class ASKVBTRCTEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x336CFA0", Offset = "0x336B9A0", VA = "0x18336CFA0")]
		public static KHJXOJJZUWY<a> HQIIMSREBOB<a>(this BBOFZKRFCTL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA3DF120", Offset = "0xA3DDB20", VA = "0x18A3DF120")]
		public static object CASZIFWNLNP(this BBOFZKRFCTL a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1A50", Offset = "0xA3E0450", VA = "0x18A3E1A50")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class YFWYNRHANOX
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] BMYYZYDOXQW;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] YQRGXMVBSYT;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] FPSAJTWFJQE;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] JXNATGXREHV;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] UBPYDIQMNAS;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] CGESPSUGEFT;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] SBHQMACFOAJ;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] MZCTQMENKSI;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class QKTIFDDASGU : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0xA3EE7D0", Offset = "0xA3ED1D0", VA = "0x18A3EE7D0")]
				public QKTIFDDASGU(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xA3EE6B0", Offset = "0xA3ED0B0", VA = "0x18A3EE6B0")]
				public QKTIFDDASGU TCOTXYHTDFM(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class CIVHGBHJBBF
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] JWZWLJNYGII;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] OILMAVXTOAP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private QKTIFDDASGU start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private QKTIFDDASGU end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA3EF570", Offset = "0xA3EDF70", VA = "0x18A3EF570")]
			public void TCOTXYHTDFM([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA3EF430", Offset = "0xA3EDE30", VA = "0x18A3EF430")]
			public void TCOTXYHTDFM(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA3EEF60", Offset = "0xA3ED960", VA = "0x18A3EEF60")]
			public ReadOnlySequence<byte> MKGNZJAONTP()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA3EF090", Offset = "0xA3EDA90", VA = "0x18A3EF090")]
			private void RIOHSKTYUJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA3EF240", Offset = "0xA3EDC40", VA = "0x18A3EF240")]
			private void SAYJAXKESST([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7CF0", Offset = "0xA3E66F0", VA = "0x18A3E7CF0")]
		public JsonReader([In] ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7B80", Offset = "0xA3E6580", VA = "0x18A3E7B80")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5900", Offset = "0xA3E4300", VA = "0x18A3E5900")]
		private JsonParsingException HVHGPVKNFMT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4C10", Offset = "0xA3E3610", VA = "0x18A3E4C10")]
		private JsonParsingException BQJLSBCCAPQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6440", Offset = "0xA3E4E40", VA = "0x18A3E6440")]
		public JsonToken KGWWVGEFKGK()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4FB0", Offset = "0xA3E39B0", VA = "0x18A3E4FB0")]
		public void DYXAZNKYLRC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA3E74A0", Offset = "0xA3E5EA0", VA = "0x18A3E74A0")]
		private bool TGWPCYGAPRM(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7500", Offset = "0xA3E5F00", VA = "0x18A3E7500")]
		private bool TGWPCYGAPRM(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6130", Offset = "0xA3E4B30", VA = "0x18A3E6130")]
		private void ITGCKEYFRCP(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6D40", Offset = "0xA3E5740", VA = "0x18A3E6D40")]
		public bool NQZOYZLBVYH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7AC0", Offset = "0xA3E64C0", VA = "0x18A3E7AC0")]
		public void XMVNLNNUDKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6650", Offset = "0xA3E5050", VA = "0x18A3E6650")]
		public bool KIALSIHKSVC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6230", Offset = "0xA3E4C30", VA = "0x18A3E6230")]
		public void JEPAKFSPAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E67D0", Offset = "0xA3E51D0", VA = "0x18A3E67D0")]
		public void MDUDCQEMKXT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA3E61E0", Offset = "0xA3E4BE0", VA = "0x18A3E61E0")]
		public bool JDFLXXNULGU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5420", Offset = "0xA3E3E20", VA = "0x18A3E5420")]
		public void FEBUAPAFVVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA3E67C0", Offset = "0xA3E51C0", VA = "0x18A3E67C0")]
		public void LWVIYVJMDCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5430", Offset = "0xA3E3E30", VA = "0x18A3E5430")]
		public bool FMHROJPDSLR(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7220", Offset = "0xA3E5C20", VA = "0x18A3E7220")]
		public bool RVWEBFDYFCW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6E00", Offset = "0xA3E5800", VA = "0x18A3E6E00")]
		public bool OQHSDFNMCTZ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA3E79E0", Offset = "0xA3E63E0", VA = "0x18A3E79E0")]
		public bool VPPCUQEVJVU(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5C50", Offset = "0xA3E4650", VA = "0x18A3E5C50")]
		private ReadOnlySequence<byte> IKIKTBNAUKL()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA3E67E0", Offset = "0xA3E51E0", VA = "0x18A3E67E0")]
		private ReadOnlySequence<byte> MNBZDLABGXA()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4D20", Offset = "0xA3E3720", VA = "0x18A3E4D20")]
		private void DCOMRGBMYHQ(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6240", Offset = "0xA3E4C40", VA = "0x18A3E6240")]
		private void JKGWKJBJTHX(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6A50", Offset = "0xA3E5450", VA = "0x18A3E6A50")]
		private void MNUWSGSKMDO(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7820", Offset = "0xA3E6220", VA = "0x18A3E7820")]
		private void UTMEMHPDHYT(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DE410", Offset = "0xA3DCE10", VA = "0x18A3DE410")]
		private static int YGOKVREKVCS(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7150", Offset = "0xA3E5B50", VA = "0x18A3E7150")]
		public ReadOnlySequence<byte> QZCFTBAHOVM()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7300", Offset = "0xA3E5D00", VA = "0x18A3E7300")]
		public string SARWKHTQHVR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA3E58C0", Offset = "0xA3E42C0", VA = "0x18A3E58C0")]
		public string GKONBEFNHCY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4B30", Offset = "0xA3E3530", VA = "0x18A3E4B30")]
		public ReadOnlySequence<byte> AWUDVCLUWWC()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6E90", Offset = "0xA3E5890", VA = "0x18A3E6E90")]
		public ReadOnlySequence<byte> QEQPYTEYWMN()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA3E76D0", Offset = "0xA3E60D0", VA = "0x18A3E76D0")]
		public bool UNOBMIKSSXY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7560", Offset = "0xA3E5F60", VA = "0x18A3E7560")]
		private void TJGQGHLHLFS(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4C00", Offset = "0xA3E3600", VA = "0x18A3E4C00")]
		public void BEYNSYJDNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA3E51E0", Offset = "0xA3E3BE0", VA = "0x18A3E51E0")]
		private void EENENVJIURB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7930", Offset = "0xA3E6330", VA = "0x18A3E7930")]
		public sbyte UXKNHRRFQCJ()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7380", Offset = "0xA3E5D80", VA = "0x18A3E7380")]
		public short SOGCTMUBASY()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA3E54C0", Offset = "0xA3E3EC0", VA = "0x18A3E54C0")]
		public int FMVRJKCWHEO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E66A0", Offset = "0xA3E50A0", VA = "0x18A3E66A0")]
		public long KRTCYDFCUXH()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5570", Offset = "0xA3E3F70", VA = "0x18A3E5570")]
		public byte FVGXJXOJVLK()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6710", Offset = "0xA3E5110", VA = "0x18A3E6710")]
		public ushort LTSYWKVBGBD()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7AD0", Offset = "0xA3E64D0", VA = "0x18A3E7AD0")]
		public uint YQSKIGAROZZ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7430", Offset = "0xA3E5E30", VA = "0x18A3E7430")]
		public ulong SSJMWNMEFKA()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4F10", Offset = "0xA3E3910", VA = "0x18A3E4F10")]
		public float DEYAYOROVAS()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4A90", Offset = "0xA3E3490", VA = "0x18A3E4A90")]
		public double ACUJHINNUHV()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6F70", Offset = "0xA3E5970", VA = "0x18A3E6F70")]
		public ReadOnlySequence<byte> QFHVIHPQOJC()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5620", Offset = "0xA3E4020", VA = "0x18A3E5620")]
		private void GFWTJZVOCLQ()
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
			[Cpp2IlInjected.Address(RVA = "0xF93F00", Offset = "0xF92900", VA = "0x180F93F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4A30", Offset = "0xA3E3430", VA = "0x18A3E4A30")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E49B0", Offset = "0xA3E33B0", VA = "0x18A3E49B0")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class HUCGRHEJKKY
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class MICQQCIYZFR
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] JWZWLJNYGII;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA3EE390", Offset = "0xA3ECD90", VA = "0x18A3EE390")]
			public static byte[] AIAQCRDLMMM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static BBOFZKRFCTL WLKLBTGEAAF;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] XEQJXJDYUFC;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] GRGWALDEMPU;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static BBOFZKRFCTL ZMTUJSCHBGN
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA3E4640", Offset = "0xA3E3040", VA = "0x18A3E4640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E3C70", Offset = "0xA3E2670", VA = "0x18A3E3C70")]
		public static void NQGGOCCYGFD(BBOFZKRFCTL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC3C0", Offset = "0x3AEADC0", VA = "0x183AEC3C0")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC250", Offset = "0x3AEAC50", VA = "0x183AEC250")]
		public static byte[] Serialize<T>(T value, BBOFZKRFCTL resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC9B0", Offset = "0x3AEB3B0", VA = "0x183AEC9B0")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC840", Offset = "0x3AEB240", VA = "0x183AEC840")]
		public static string ToJsonString<T>(T value, BBOFZKRFCTL resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBC80", Offset = "0x3AEA680", VA = "0x183AEBC80")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBB00", Offset = "0x3AEA500", VA = "0x183AEBB00")]
		public static T Deserialize<T>(string json, BBOFZKRFCTL resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3AEBE50", Offset = "0x3AEA850", VA = "0x183AEBE50")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB9B0", Offset = "0x3AEA3B0", VA = "0x183AEB9B0")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, BBOFZKRFCTL resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB3B0", Offset = "0x3AE9DB0", VA = "0x183AEB3B0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3AEB1E0", Offset = "0x3AE9BE0", VA = "0x183AEB1E0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, BBOFZKRFCTL resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E3940", Offset = "0xA3E2340", VA = "0x18A3E3940")]
		public static byte[] CIIQWQXIYLU(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E3CE0", Offset = "0xA3E26E0", VA = "0x18A3E3CE0")]
		private static void QVVDTSQELBM(JsonReader a, JsonWriter b, int c)
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
		public int WSDYMYLQBBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xF55CA0", Offset = "0xF546A0", VA = "0x180F55CA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9190", Offset = "0xA3E7B90", VA = "0x18A3E9190")]
		public void ZQWHXLDSJZN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8920", Offset = "0xA3E7320", VA = "0x18A3E8920")]
		public static byte[] IAJYMHXJCVU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9070", Offset = "0xA3E7A70", VA = "0x18A3E9070")]
		public static byte[] XAEWUWPRQKW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8AF0", Offset = "0xA3E74F0", VA = "0x18A3E8AF0")]
		public static byte[] JPKHYMZDOVS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8730", Offset = "0xA3E7130", VA = "0x18A3E8730")]
		public static byte[] HPIYQUXQDXO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2ABED60", Offset = "0x2ABD760", VA = "0x182ABED60")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7EA0", Offset = "0xA3E68A0", VA = "0x18A3E7EA0")]
		public ArraySegment<byte> AIAQCRDLMMM()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8D30", Offset = "0xA3E7730", VA = "0x18A3E8D30")]
		public byte[] NXARAOZDGDZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8F30", Offset = "0xA3E7930", VA = "0x18A3E8F30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8C30", Offset = "0xA3E7630", VA = "0x18A3E8C30")]
		public void KSSRCICPRRO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA3DE4D0", Offset = "0xA3DCED0", VA = "0x18A3DE4D0")]
		public void DUHBVEJWTDT(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8060", Offset = "0xA3E6A60", VA = "0x18A3E8060")]
		public void DUHBVEJWTDT(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8EF0", Offset = "0xA3E78F0", VA = "0x18A3E8EF0")]
		public void SZLCZSFYUPJ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5095A90", Offset = "0x5094490", VA = "0x185095A90")]
		public void CVVKTHGDRUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5095A40", Offset = "0x5094440", VA = "0x185095A40")]
		public void CBKVIWDKQYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7275210", Offset = "0x7273C10", VA = "0x187275210")]
		public void JHQVKKTDZKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x539BB40", Offset = "0x539A540", VA = "0x18539BB40")]
		public void RFDUQDINQGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5095B80", Offset = "0x5094580", VA = "0x185095B80")]
		public void QQDMFDZSCER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7275260", Offset = "0x7273C60", VA = "0x187275260")]
		public void VRHHJPGWRFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7F40", Offset = "0xA3E6940", VA = "0x18A3E7F40")]
		public void CGUTRMPFHJJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7FE0", Offset = "0xA3E69E0", VA = "0x18A3E7FE0")]
		public void CTXKZUUKUNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5095AE0", Offset = "0x50944E0", VA = "0x185095AE0")]
		public void OSUMYHCHQMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8CAA000", Offset = "0x8CA8A00", VA = "0x188CAA000")]
		public void LPQVPAHYEPF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA3E80C0", Offset = "0xA3E6AC0", VA = "0x18A3E80C0")]
		public void DZUBEJNOEKB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8C40", Offset = "0xA3E7640", VA = "0x18A3E8C40")]
		public void MCLKLRKFKOQ(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E86C0", Offset = "0xA3E70C0", VA = "0x18A3E86C0")]
		public void HHKUVERYKOH(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9000", Offset = "0xA3E7A00", VA = "0x18A3E9000")]
		public void WKWVGBKUFTM(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8A80", Offset = "0xA3E7480", VA = "0x18A3E8A80")]
		public void JFUTZVPFJIU(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8EC0", Offset = "0xA3E78C0", VA = "0x18A3E8EC0")]
		public void PLLFQXSBURF(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8CC0", Offset = "0xA3E76C0", VA = "0x18A3E8CC0")]
		public void MWGHCPLEVUA(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8F90", Offset = "0xA3E7990", VA = "0x18A3E8F90")]
		public void WCXQHKCVWPX(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA3E88B0", Offset = "0xA3E72B0", VA = "0x18A3E88B0")]
		public void HZZDFXJLTSL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8030", Offset = "0xA3E6A30", VA = "0x18A3E8030")]
		public void DBOEHMTYVYU(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8140", Offset = "0xA3E6B40", VA = "0x18A3E8140")]
		public void GGIJYDDSQHW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8A00", Offset = "0xA3E7400", VA = "0x18A3E8A00")]
		private static bool IPUCPBRPVBE(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8C10", Offset = "0xA3E7610", VA = "0x18A3E8C10")]
		private static byte KHTATVSLXOM(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA3DE530", Offset = "0xA3DCF30", VA = "0x18A3DE530")]
		private static void ZPFRAWGPQKV(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class HKQRLZIBHFA : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6932160", Offset = "0x6930B60", VA = "0x186932160")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private HKQRLZIBHFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class RENMSBEILMD : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6934DD0", Offset = "0x69337D0", VA = "0x186934DD0")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class XGZVDJSDBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> YQDKQTSCLDM;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA3EFBD0", Offset = "0xA3EE5D0", VA = "0x18A3EFBD0")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private RENMSBEILMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class AJCJMVQCKWH : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6932AA0", Offset = "0x69314A0", VA = "0x186932AA0")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly AJCJMVQCKWH LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool AYJQMFYJBNB;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static YRUEVOCAGJF[] CGJALFVUPMF;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static BBOFZKRFCTL[] BNEYROEPWAN;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private AJCJMVQCKWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA3DEBC0", Offset = "0xA3DD5C0", VA = "0x18A3DEBC0")]
		public static void GZVUEGYMGMP(params BBOFZKRFCTL[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA3DEAE0", Offset = "0xA3DD4E0", VA = "0x18A3DEAE0")]
		public static void GZVUEGYMGMP(params YRUEVOCAGJF[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA3DECA0", Offset = "0xA3DD6A0", VA = "0x18A3DECA0")]
		public static void VOFFVOGREAN(YRUEVOCAGJF[] a, BBOFZKRFCTL[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class WASOOZPLRWG : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x693DAC0", Offset = "0x693C4C0", VA = "0x18693DAC0")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private WASOOZPLRWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class JRTJLCGEJWZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly BBOFZKRFCTL AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly BBOFZKRFCTL VIEWCAIJMTY;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class XOTAXBBMEYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly BBOFZKRFCTL AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly BBOFZKRFCTL LGULKDSYRGY;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly BBOFZKRFCTL DSTZARDSBYG;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly BBOFZKRFCTL OFIHSXNMIPX;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly BBOFZKRFCTL VHPCTPISTJD;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly BBOFZKRFCTL SDWLQAKTEMP;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly BBOFZKRFCTL FMZXXPXOWFM;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly BBOFZKRFCTL ZDRAXBQLUJW;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly BBOFZKRFCTL GHDWLNWSHUW;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly BBOFZKRFCTL HUNQQIPWMFL;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly BBOFZKRFCTL QEPOWXNSRYF;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly BBOFZKRFCTL GIKSQGMSLRJ;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class KNXGALXIJEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> YQDKQTSCLDM;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9A70", Offset = "0xA3E8470", VA = "0x18A3E9A70")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB6C0", Offset = "0xA3EA0C0", VA = "0x18A3EB6C0")]
		private static object QFVOZQNJDQJ(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class QYXYFHWHOMC : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6939790", Offset = "0x6938190", VA = "0x186939790")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private QYXYFHWHOMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class ALAVMDPFJPR : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6934250", Offset = "0x6932C50", VA = "0x186934250")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private ALAVMDPFJPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class XKMVRYNPAGV
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly BBOFZKRFCTL[] XTFEUTJZLIS;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class PWOJAYBAAYI : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6939490", Offset = "0x6937E90", VA = "0x186939490")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class BFNHZVHQPTS : BBOFZKRFCTL
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class LQYFBAWEVPT<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x69340F0", Offset = "0x6932AF0", VA = "0x1869340F0")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
			public KHJXOJJZUWY<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly KHJXOJJZUWY<object> TKFKEECIXWS;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private PWOJAYBAAYI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class TGWUIDADLVF : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6934AD0", Offset = "0x69334D0", VA = "0x186934AD0")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class BFNHZVHQPTS : BBOFZKRFCTL
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class LQYFBAWEVPT<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x693BAD0", Offset = "0x693A4D0", VA = "0x18693BAD0")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
			public KHJXOJJZUWY<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly KHJXOJJZUWY<object> TKFKEECIXWS;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private TGWUIDADLVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class MPWNZSMBMUF : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6937E70", Offset = "0x6936870", VA = "0x186937E70")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class BFNHZVHQPTS : BBOFZKRFCTL
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class LQYFBAWEVPT<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x6937530", Offset = "0x6935F30", VA = "0x186937530")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
			public KHJXOJJZUWY<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly KHJXOJJZUWY<object> TKFKEECIXWS;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private MPWNZSMBMUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class TZURDYGSXXY : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6931E60", Offset = "0x6930860", VA = "0x186931E60")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class BFNHZVHQPTS : BBOFZKRFCTL
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class LQYFBAWEVPT<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x6937690", Offset = "0x6936090", VA = "0x186937690")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
			public KHJXOJJZUWY<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly KHJXOJJZUWY<object> TKFKEECIXWS;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private TZURDYGSXXY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class OEUZURHVPSW : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x693EF80", Offset = "0x693D980", VA = "0x18693EF80")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class BFNHZVHQPTS : BBOFZKRFCTL
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class LQYFBAWEVPT<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x693A050", Offset = "0x6938A50", VA = "0x18693A050")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
			public KHJXOJJZUWY<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly KHJXOJJZUWY<object> TKFKEECIXWS;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private OEUZURHVPSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class MHPEAGJDJSE : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x69315A0", Offset = "0x692FFA0", VA = "0x1869315A0")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class BFNHZVHQPTS : BBOFZKRFCTL
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class LQYFBAWEVPT<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x693C100", Offset = "0x693AB00", VA = "0x18693C100")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
			public KHJXOJJZUWY<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly KHJXOJJZUWY<object> TKFKEECIXWS;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private MHPEAGJDJSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class PTTJWGQWPKJ : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x693AAB0", Offset = "0x69394B0", VA = "0x18693AAB0")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class BFNHZVHQPTS : BBOFZKRFCTL
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class LQYFBAWEVPT<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x69367E0", Offset = "0x69351E0", VA = "0x1869367E0")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
			public KHJXOJJZUWY<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly KHJXOJJZUWY<object> TKFKEECIXWS;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private PTTJWGQWPKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class LVQIUTHWNBN : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6933DF0", Offset = "0x69327F0", VA = "0x186933DF0")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class BFNHZVHQPTS : BBOFZKRFCTL
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class LQYFBAWEVPT<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x693D500", Offset = "0x693BF00", VA = "0x18693D500")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
			public KHJXOJJZUWY<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly KHJXOJJZUWY<object> TKFKEECIXWS;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private LVQIUTHWNBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class RDWDRJXYYOZ : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x693A1B0", Offset = "0x6938BB0", VA = "0x18693A1B0")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class BFNHZVHQPTS : BBOFZKRFCTL
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class LQYFBAWEVPT<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x693E520", Offset = "0x693CF20", VA = "0x18693E520")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
			public KHJXOJJZUWY<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly KHJXOJJZUWY<object> TKFKEECIXWS;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private RDWDRJXYYOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class GIVASOSPEOW : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x693CDA0", Offset = "0x693B7A0", VA = "0x18693CDA0")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class BFNHZVHQPTS : BBOFZKRFCTL
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class LQYFBAWEVPT<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x693DE00", Offset = "0x693C800", VA = "0x18693DE00")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
			public KHJXOJJZUWY<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly KHJXOJJZUWY<object> TKFKEECIXWS;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private GIVASOSPEOW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class VMFNGIWTSBU : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x693B2D0", Offset = "0x6939CD0", VA = "0x18693B2D0")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class BFNHZVHQPTS : BBOFZKRFCTL
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class LQYFBAWEVPT<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x6932680", Offset = "0x6931080", VA = "0x186932680")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
			public KHJXOJJZUWY<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly KHJXOJJZUWY<object> TKFKEECIXWS;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private VMFNGIWTSBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class RJZHEODUPKE : BBOFZKRFCTL
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class LQYFBAWEVPT<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6934FB0", Offset = "0x69339B0", VA = "0x186934FB0")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class BFNHZVHQPTS : BBOFZKRFCTL
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class LQYFBAWEVPT<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly KHJXOJJZUWY<a> LIXGJBBTANG;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x69327E0", Offset = "0x69311E0", VA = "0x1869327E0")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
			public KHJXOJJZUWY<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly KHJXOJJZUWY<object> TKFKEECIXWS;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		private RJZHEODUPKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336A400", VA = "0x18336BA00", Slot = "4")]
		public KHJXOJJZUWY<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x7561810", Offset = "0x7560210", VA = "0x187561810")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7561520", Offset = "0x755FF20", VA = "0x187561520")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7561780", Offset = "0x7560180", VA = "0x187561780")]
		public T[] GCFCJAORPHG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class TSUXYERGCKO<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int RRXEWOSXESA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object XETDTBLRBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int ONJFVMMXRGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] XOFEARZSQWN;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7B584A0", Offset = "0x7B56EA0", VA = "0x187B584A0")]
		public TSUXYERGCKO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7B581B0", Offset = "0x7B56BB0", VA = "0x187B581B0")]
		public a[] VWIOUHTZAER()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7B57DF0", Offset = "0x7B567F0", VA = "0x187B57DF0")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class LLXCYHWQXJW : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class KTOKBYSUUMM : IComparable<KTOKBYSUUMM>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class QWXTRGORGOM : IEnumerable<KTOKBYSUUMM>, IEnumerable, IEnumerator<KTOKBYSUUMM>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int NXJBPMXGHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private KTOKBYSUUMM BZAVRIIXYAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int YTKXRPSSEMX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public KTOKBYSUUMM IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int ZWVNFXOIPAU;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private KTOKBYSUUMM DZSOLYJIUUV
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object ERGKPVHJUQY
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
				[DebuggerHidden]
				public QWXTRGORGOM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
				[DebuggerHidden]
				private void THBUUIJWZTJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xA3EEC80", Offset = "0xA3ED680", VA = "0x18A3EEC80", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xA3EED00", Offset = "0xA3ED700", VA = "0x18A3EED00", Slot = "10")]
				[DebuggerHidden]
				private void TVBXYVYIQIO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xA3EEBE0", Offset = "0xA3ED5E0", VA = "0x18A3EEBE0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<KTOKBYSUUMM> EZUUQHQINNM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0xA3EEBE0", Offset = "0xA3ED5E0", VA = "0x18A3EEBE0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator SJAOULXGYMP()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly KTOKBYSUUMM[] QUHPEFGQSNO;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] VUYIDRWGHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong GDITXKPDJXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int FCAQLXAUMLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string PQMFSBFCBNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private KTOKBYSUUMM[] JWYGNFOONCQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] WJBFQPXLDCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int XMCSSJKVAGB;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA3EC5E0", Offset = "0xA3EAFE0", VA = "0x18A3EC5E0")]
			public KTOKBYSUUMM(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA3EC020", Offset = "0xA3EAA20", VA = "0x18A3EC020")]
			public KTOKBYSUUMM Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA3EC220", Offset = "0xA3EAC20", VA = "0x18A3EC220")]
			public KTOKBYSUUMM Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA3EC340", Offset = "0xA3EAD40", VA = "0x18A3EC340")]
			public KTOKBYSUUMM IIQVQFWAXHE(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA3EC2B0", Offset = "0xA3EACB0", VA = "0x18A3EC2B0")]
			internal static int DJGBMFVSKXB(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA3EC280", Offset = "0xA3EAC80", VA = "0x18A3EC280", Slot = "4")]
			public int CompareTo(KTOKBYSUUMM other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xA3EC4B0", Offset = "0xA3EAEB0", VA = "0x18A3EC4B0")]
			[IteratorStateMachine(typeof(QWXTRGORGOM))]
			public IEnumerable<KTOKBYSUUMM> MWMHNSQYIQM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class KXXVPINQEOK : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<KTOKBYSUUMM> JWYGNFOONCQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<KTOKBYSUUMM> DBRYULBKHZJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<KTOKBYSUUMM> MXGZQBRVDOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private KTOKBYSUUMM EBAMMBUZQZZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> MWWLVOEAKRO;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> KSHCYOSRBOX
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0xD6AE80", Offset = "0xD69880", VA = "0x180D6AE80", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000139")]
				[Cpp2IlInjected.Address(RVA = "0xA3ECBA0", Offset = "0xA3EB5A0", VA = "0x18A3ECBA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1D12190", Offset = "0x1D10B90", VA = "0x181D12190")]
			[DebuggerHidden]
			public KXXVPINQEOK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xA3ECC90", Offset = "0xA3EB690", VA = "0x18A3ECC90", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xA3EC740", Offset = "0xA3EB140", VA = "0x18A3EC740", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xA3EC6A0", Offset = "0xA3EB0A0", VA = "0x18A3EC6A0")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA3EC6F0", Offset = "0xA3EB0F0", VA = "0x18A3EC6F0")]
			private void ALONWGIYSGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA3ECDE0", Offset = "0xA3EB7E0", VA = "0x18A3ECDE0", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xA3ECBF0", Offset = "0xA3EB5F0", VA = "0x18A3ECBF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> WQVDXRBALVK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xA3ECBF0", Offset = "0xA3EB5F0", VA = "0x18A3ECBF0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly KTOKBYSUUMM JBSQCTQPIEC;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE1E0", Offset = "0xA3ECBE0", VA = "0x18A3EE1E0")]
		public LLXCYHWQXJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED990", Offset = "0xA3EC390", VA = "0x18A3ED990")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA3EDFC0", Offset = "0xA3EC9C0", VA = "0x18A3EDFC0")]
		public bool RRJZBUUOGPY(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA3EDEB0", Offset = "0xA3EC8B0", VA = "0x18A3EDEB0")]
		public bool QSLRHQYVAED([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE0D0", Offset = "0xA3ECAD0", VA = "0x18A3EE0D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA3EDB70", Offset = "0xA3EC570", VA = "0x18A3EDB70")]
		private static void ERSMCNPYSTL(IEnumerable<KTOKBYSUUMM> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA3EDE50", Offset = "0xA3EC850", VA = "0x18A3EDE50", Slot = "5")]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA3EDE50", Offset = "0xA3EC850", VA = "0x18A3EDE50", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE160", Offset = "0xA3ECB60", VA = "0x18A3EE160")]
		[IteratorStateMachine(typeof(KXXVPINQEOK))]
		private static IEnumerable<KeyValuePair<string, int>> VDRFGIWIFDG(IEnumerable<KTOKBYSUUMM> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class KEKHWBQFEET
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo FWSPKJXEPHK;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9270", Offset = "0xA3E7C70", VA = "0x18A3E9270")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9420", Offset = "0xA3E7E20", VA = "0x18A3E9420")]
		public static ulong OWVTREWYBXC(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class QRDNFKNJAQT
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA3EEAA0", Offset = "0xA3ED4A0", VA = "0x18A3EEAA0")]
		public static void KSSRCICPRRO(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE840", Offset = "0xA3ED240", VA = "0x18A3EE840")]
		public static void ILQCZBMXPKM(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE960", Offset = "0xA3ED360", VA = "0x18A3EE960")]
		public static byte[] JMRYSSRXQKF(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class ZDWAONULNYH<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x5BCA1C0", Offset = "0x5BC8BC0", VA = "0x185BCA1C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class WMGWRCLKBRB : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public ZDWAONULNYH<a> IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] MXGZQBRVDOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int MXBSSUXXUCX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] MWWLVOEAKRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int MYHICJNHYSZ;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> SYTWYZKVJRQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xD6AE80", Offset = "0xD69880", VA = "0x180D6AE80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0x652F1B0", Offset = "0x652DBB0", VA = "0x18652F1B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public WMGWRCLKBRB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x85C7D40", Offset = "0x85C6740", VA = "0x1885C7D40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] SHLQFDATEOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong SKMOOKHPYRH;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool PJZIDATPLEK;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x51084B0", Offset = "0x5106EB0", VA = "0x1851084B0")]
		public ZDWAONULNYH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x51083C0", Offset = "0x5106DC0", VA = "0x1851083C0")]
		public ZDWAONULNYH(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x50F72D0", Offset = "0x50F5CD0", VA = "0x1850F72D0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5102E40", Offset = "0x5101840", VA = "0x185102E40")]
		private bool MVHGDGSGPET(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5106B40", Offset = "0x5105540", VA = "0x185106B40")]
		public bool RRJZBUUOGPY([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x50F8880", Offset = "0x50F7280", VA = "0x1850F8880")]
		private static ulong KWFBTNXCVGK([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x50F9D60", Offset = "0x50F8760", VA = "0x1850F9D60")]
		private static ulong KWFBTNXCVGK([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x50FC100", Offset = "0x50FAB00", VA = "0x1850FC100")]
		private static int LCXCHLDGEQC(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x50F74E0", Offset = "0x50F5EE0", VA = "0x1850F74E0", Slot = "4")]
		[IteratorStateMachine(typeof(ZDWAONULNYH<>.WMGWRCLKBRB))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x51081B0", Offset = "0x5106BB0", VA = "0x1851081B0", Slot = "5")]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class UAIPOINAKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4052530", Offset = "0x4050F30", VA = "0x184052530")]
		public static Func<a> PAIDSFXSZPK<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4052470", Offset = "0x4050E70", VA = "0x184052470")]
		private static c NVZUMUTFECN<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0xA3E2540", Offset = "0xA3E0F40", VA = "0x18A3E2540")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2550", Offset = "0xA3E0F50", VA = "0x18A3E2550")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA3E23B0", Offset = "0xA3E0DB0", VA = "0x18A3E23B0")]
		private static byte YKKZUNDNKRP(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA3DE030", Offset = "0xA3DCA30", VA = "0x18A3DE030")]
		private static byte NCAIVPTCWPD(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1B50", Offset = "0xA3E0550", VA = "0x18A3E1B50")]
		public void SISZBYWUTCR(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class ELYJFIZRJSZ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0F90", Offset = "0xA3DF990", VA = "0x18A3E0F90")]
		public static bool JXHCVPSWYYH(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1110", Offset = "0xA3DFB10", VA = "0x18A3E1110")]
		public static bool MVOBISAOSRI(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1460", Offset = "0xA3DFE60", VA = "0x18A3E1460")]
		public static sbyte UXKNHRRFQCJ([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1180", Offset = "0xA3DFB80", VA = "0x18A3E1180")]
		public static short SOGCTMUBASY([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0ED0", Offset = "0xA3DF8D0", VA = "0x18A3E0ED0")]
		public static int FMVRJKCWHEO([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1000", Offset = "0xA3DFA00", VA = "0x18A3E1000")]
		public static long KRTCYDFCUXH([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0C50", Offset = "0xA3DF650", VA = "0x18A3E0C50")]
		public static bool DCHZHZQHGNM(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0F30", Offset = "0xA3DF930", VA = "0x18A3E0F30")]
		public static byte FVGXJXOJVLK([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA3E10B0", Offset = "0xA3DFAB0", VA = "0x18A3E10B0")]
		public static ushort LTSYWKVBGBD([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1950", Offset = "0xA3E0350", VA = "0x18A3E1950")]
		public static uint YQSKIGAROZZ([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA3E11E0", Offset = "0xA3DFBE0", VA = "0x18A3E11E0")]
		public static ulong SSJMWNMEFKA([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1800", Offset = "0xA3E0200", VA = "0x18A3E1800")]
		public static bool YGYKXZBOUYZ(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1630", Offset = "0xA3E0030", VA = "0x18A3E1630")]
		public static bool XHZIVJBTAYJ(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1520", Offset = "0xA3DFF20", VA = "0x18A3E1520")]
		public static bool WWJLBVYODYJ(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E19B0", Offset = "0xA3E03B0", VA = "0x18A3E19B0")]
		public static bool ZGFTHFIDGYP(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0DE0", Offset = "0xA3DF7E0", VA = "0x18A3E0DE0")]
		public static float DEYAYOROVAS([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E14C0", Offset = "0xA3DFEC0", VA = "0x18A3E14C0")]
		public static bool WCWMXVRCHEX(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0B60", Offset = "0xA3DF560", VA = "0x18A3E0B60")]
		public static double ACUJHINNUHV([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0FA0", Offset = "0xA3DF9A0", VA = "0x18A3E0FA0")]
		public static bool KOSJSIIKMQO(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD780", Offset = "0xA3DC180", VA = "0x18A3DD780")]
		public static int PLLFQXSBURF(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA3DCD10", Offset = "0xA3DB710", VA = "0x18A3DCD10")]
		public static int DBOEHMTYVYU(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1290", Offset = "0xA3DFC90", VA = "0x18A3E1290")]
		public static bool UNOBMIKSSXY([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class AGTXBWQPUUR
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA3DEA30", Offset = "0xA3DD430", VA = "0x18A3DEA30")]
		public static bool CRJYLSOXPDV(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class AJSSERAJEYO
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding HEDUXOELXJD;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class DDAXXSTADUK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA3E08C0", Offset = "0xA3DF2C0", VA = "0x18A3E08C0")]
		public static void UZHDKJFYOEL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0850", Offset = "0xA3DF250", VA = "0x18A3E0850")]
		public static void UZBWNCMBETC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA3E09A0", Offset = "0xA3DF3A0", VA = "0x18A3E09A0")]
		public static void UZRREWTTHBD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0930", Offset = "0xA3DF330", VA = "0x18A3E0930")]
		public static void UZMKHPZVXPU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA3E07E0", Offset = "0xA3DF1E0", VA = "0x18A3E07E0")]
		public static void UYMBVIEJCLB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0770", Offset = "0xA3DF170", VA = "0x18A3E0770")]
		public static void UYGUYBKLSZS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E04A0", Offset = "0xA3DEEA0", VA = "0x18A3E04A0")]
		public static void SDOGUHGLGJS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0510", Offset = "0xA3DEF10", VA = "0x18A3E0510")]
		public static void SDTNROAIPVB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0580", Offset = "0xA3DEF80", VA = "0x18A3E0580")]
		public static void SDYUOUUFZGK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E05F0", Offset = "0xA3DEFF0", VA = "0x18A3E05F0")]
		public static void SEEBMBODIRT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E02A0", Offset = "0xA3DECA0", VA = "0x18A3E02A0")]
		public static void SCTFFGEVUQI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0320", Offset = "0xA3DED20", VA = "0x18A3E0320")]
		public static void SCYMCMYTEBR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA3E03A0", Offset = "0xA3DEDA0", VA = "0x18A3E03A0")]
		public static void SDDSZTSQNNA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0420", Offset = "0xA3DEE20", VA = "0x18A3E0420")]
		public static void SDIZXAMNWYJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0670", Offset = "0xA3DF070", VA = "0x18A3E0670")]
		public static void SFEJYJJQDWM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA3E06F0", Offset = "0xA3DF0F0", VA = "0x18A3E06F0")]
		public static void SFJQVQDNNHV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0120", Offset = "0xA3DEB20", VA = "0x18A3E0120")]
		public static void NFNVQKETBMT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA3E00A0", Offset = "0xA3DEAA0", VA = "0x18A3E00A0")]
		public static void NFIOTDKVSBK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0220", Offset = "0xA3DEC20", VA = "0x18A3E0220")]
		public static void NFYJKXSNUJL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA3E01A0", Offset = "0xA3DEBA0", VA = "0x18A3E01A0")]
		public static void NFTCNQYQKYC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFF00", Offset = "0xA3DE900", VA = "0x18A3DFF00")]
		public static void NESUBJDDPTJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFE70", Offset = "0xA3DE870", VA = "0x18A3DFE70")]
		public static void NENNECJGGIA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0010", Offset = "0xA3DEA10", VA = "0x18A3E0010")]
		public static void NFDHVWQYIQB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFF80", Offset = "0xA3DE980", VA = "0x18A3DFF80")]
		public static void NEYAYPXAZES(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFDE0", Offset = "0xA3DE7E0", VA = "0x18A3DFDE0")]
		public static void NDXSMIBODZZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFD50", Offset = "0xA3DE750", VA = "0x18A3DFD50")]
		public static void NDSLPBHQUOQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFC30", Offset = "0xA3DE630", VA = "0x18A3DFC30")]
		public static void GEWQRRWQLUK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFCC0", Offset = "0xA3DE6C0", VA = "0x18A3DFCC0")]
		public static void GFBXOYQNVFT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0A10", Offset = "0xA3DF410", VA = "0x18A3E0A10")]
		public static void UZWYCDNQQMM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0AF0", Offset = "0xA3DF4F0", VA = "0x18A3E0AF0")]
		public static void VAMSTXVISUN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0A80", Offset = "0xA3DF480", VA = "0x18A3E0A80")]
		public static void VAHLWRBLJJE(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class KYSWEBGIXWR
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED920", Offset = "0xA3EC320", VA = "0x18A3ED920")]
		public static void UYMBVIEJCLB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED8B0", Offset = "0xA3EC2B0", VA = "0x18A3ED8B0")]
		public static void UYGUYBKLSZS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED5F0", Offset = "0xA3EBFF0", VA = "0x18A3ED5F0")]
		public static void SDOGUHGLGJS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED660", Offset = "0xA3EC060", VA = "0x18A3ED660")]
		public static void SDTNROAIPVB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED6D0", Offset = "0xA3EC0D0", VA = "0x18A3ED6D0")]
		public static void SDYUOUUFZGK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED740", Offset = "0xA3EC140", VA = "0x18A3ED740")]
		public static void SEEBMBODIRT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED420", Offset = "0xA3EBE20", VA = "0x18A3ED420")]
		public static void SCTFFGEVUQI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED490", Offset = "0xA3EBE90", VA = "0x18A3ED490")]
		public static void SCYMCMYTEBR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED500", Offset = "0xA3EBF00", VA = "0x18A3ED500")]
		public static void SDDSZTSQNNA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED570", Offset = "0xA3EBF70", VA = "0x18A3ED570")]
		public static void SDIZXAMNWYJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED7B0", Offset = "0xA3EC1B0", VA = "0x18A3ED7B0")]
		public static void SFEJYJJQDWM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED830", Offset = "0xA3EC230", VA = "0x18A3ED830")]
		public static void SFJQVQDNNHV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED2A0", Offset = "0xA3EBCA0", VA = "0x18A3ED2A0")]
		public static void NFNVQKETBMT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED220", Offset = "0xA3EBC20", VA = "0x18A3ED220")]
		public static void NFIOTDKVSBK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED3A0", Offset = "0xA3EBDA0", VA = "0x18A3ED3A0")]
		public static void NFYJKXSNUJL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED320", Offset = "0xA3EBD20", VA = "0x18A3ED320")]
		public static void NFTCNQYQKYC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED0A0", Offset = "0xA3EBAA0", VA = "0x18A3ED0A0")]
		public static void NESUBJDDPTJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED020", Offset = "0xA3EBA20", VA = "0x18A3ED020")]
		public static void NENNECJGGIA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED1A0", Offset = "0xA3EBBA0", VA = "0x18A3ED1A0")]
		public static void NFDHVWQYIQB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED120", Offset = "0xA3EBB20", VA = "0x18A3ED120")]
		public static void NEYAYPXAZES(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA3ECFA0", Offset = "0xA3EB9A0", VA = "0x18A3ECFA0")]
		public static void NDXSMIBODZZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA3ECF20", Offset = "0xA3EB920", VA = "0x18A3ECF20")]
		public static void NDSLPBHQUOQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA3ECE20", Offset = "0xA3EB820", VA = "0x18A3ECE20")]
		public static void GEWQRRWQLUK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA3ECEA0", Offset = "0xA3EB8A0", VA = "0x18A3ECEA0")]
		public static void GFBXOYQNVFT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0A10", Offset = "0xA3DF410", VA = "0x18A3E0A10")]
		public static void UZWYCDNQQMM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0AF0", Offset = "0xA3DF4F0", VA = "0x18A3E0AF0")]
		public static void VAMSTXVISUN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0A80", Offset = "0xA3DF480", VA = "0x18A3E0A80")]
		public static void VAHLWRBLJJE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA3E08C0", Offset = "0xA3DF2C0", VA = "0x18A3E08C0")]
		public static void UZHDKJFYOEL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0850", Offset = "0xA3DF250", VA = "0x18A3E0850")]
		public static void UZBWNCMBETC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA3E09A0", Offset = "0xA3DF3A0", VA = "0x18A3E09A0")]
		public static void UZRREWTTHBD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0930", Offset = "0xA3DF330", VA = "0x18A3E0930")]
		public static void UZMKHPZVXPU(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class KUVFSQNKOBZ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool PJZIDATPLEK;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBF30", Offset = "0xA3FA930", VA = "0x18A3FBF30")]
		public static void DUHBVEJWTDT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA3FD980", Offset = "0xA3FC380", VA = "0x18A3FD980")]
		public static void RILWQTWCAKE(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x2B6A300", Offset = "0x2B68D00", VA = "0x182B6A300")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4E00", Offset = "0xA3F3800", VA = "0x18A3F4E00")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4CD0", Offset = "0xA3F36D0", VA = "0x18A3F4CD0")]
		public static DiyFp GEWOYZMWCXE(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4D70", Offset = "0xA3F3770", VA = "0x18A3F4D70")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4E10", Offset = "0xA3F3810", VA = "0x18A3F4E10")]
		public static DiyFp UPMWFXZFEPG(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4D30", Offset = "0xA3F3730", VA = "0x18A3F4D30")]
		public void IOOYXXCNPYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4CE0", Offset = "0xA3F36E0", VA = "0x18A3F4CE0")]
		public static DiyFp IOOYXXCNPYZ(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xD8ED50", Offset = "0xD8D750", VA = "0x180D8ED50")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA3DE4D0", Offset = "0xA3DCED0", VA = "0x18A3DE4D0")]
		public void EZQCJVJHPHW(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA407130", Offset = "0xA405B30", VA = "0x18A407130")]
		public void KMWNNDJTKMQ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA4070B0", Offset = "0xA405AB0", VA = "0x18A4070B0")]
		public void CGOCGTAYGIA(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA407010", Offset = "0xA405A10", VA = "0x18A407010")]
		public void CGOCGTAYGIA(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA4072B0", Offset = "0xA405CB0", VA = "0x18A4072B0")]
		public void WGPIKZKHFSW(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA4071B0", Offset = "0xA405BB0", VA = "0x18A4071B0")]
		public void PKVDZFBQKDX(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class KVTLMMUNBSF
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
		private static byte[] SZXMODKGZFE;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] HZKFPRCJENY;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] NOIJVMNYKUM;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] CFFMJYRETVT;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags RALJAEJJNTQ;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char GZPEULHPVYC;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int UERVDXBOHTM;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int HLOUXTELVDA;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] CIEWLWVWHAQ;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA3FE1D0", Offset = "0xA3FCBD0", VA = "0x18A3FE1D0")]
		private static byte[] NCMNEFUTDRQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA3FE9C0", Offset = "0xA3FD3C0", VA = "0x18A3FE9C0")]
		private static byte[] TVUUEMVBDNY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA3FE8A0", Offset = "0xA3FD2A0", VA = "0x18A3FE8A0")]
		public static int OTSNVORVUSV(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA3FE780", Offset = "0xA3FD180", VA = "0x18A3FE780")]
		public static int OTSNVORVUSV(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA3FDFF0", Offset = "0xA3FC9F0", VA = "0x18A3FDFF0")]
		private static bool FIAKZJCNVGT(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA3FE0E0", Offset = "0xA3FCAE0", VA = "0x18A3FE0E0")]
		private static void LRUYLJXSXRJ(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA3FEC70", Offset = "0xA3FD670", VA = "0x18A3FEC70")]
		private static bool VMPFKUPTRJZ(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3FF560", Offset = "0xA3FDF60", VA = "0x18A3FF560")]
		private static bool ZGTYMEMUHLV(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA3FF460", Offset = "0xA3FDE60", VA = "0x18A3FF460")]
		private static bool ZAOPDBLAOUA(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA3FEAA0", Offset = "0xA3FD4A0", VA = "0x18A3FEAA0")]
		private static bool UIHDEUEAMQR(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA3FE2A0", Offset = "0xA3FCCA0", VA = "0x18A3FE2A0")]
		private static bool OPYFVBKAOFO(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA3FDC50", Offset = "0xA3FC650", VA = "0x18A3FDC50")]
		private static void ECTBSMSWGSY(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA3FF030", Offset = "0xA3FDA30", VA = "0x18A3FF030")]
		private static void YOWBXOYZOQU(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA3FDA60", Offset = "0xA3FC460", VA = "0x18A3FDA60")]
		private static bool AXTJRWAISGR(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0xA3F54D0", Offset = "0xA3F3ED0", VA = "0x18A3F54D0")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5430", Offset = "0xA3F3E30", VA = "0x18A3F5430")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA3F51B0", Offset = "0xA3F3BB0", VA = "0x18A3F51B0")]
		public DiyFp JQWGCZTFCLA()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5100", Offset = "0xA3F3B00", VA = "0x18A3F5100")]
		public DiyFp GOMXIVWVCND()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10")]
		public ulong KLUCQBEFSNC()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5290", Offset = "0xA3F3C90", VA = "0x18A3F5290")]
		public double OXRMXTUUBDE()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5340", Offset = "0xA3F3D40", VA = "0x18A3F5340")]
		public double RVOVWIHYVVQ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5180", Offset = "0xA3F3B80", VA = "0x18A3F5180")]
		public int JAPQTRVEXWR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5310", Offset = "0xA3F3D10", VA = "0x18A3F5310")]
		public ulong QATHMRLQLEF()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5410", Offset = "0xA3F3E10", VA = "0x18A3F5410")]
		public bool VPHWQTGFTVE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA3F50E0", Offset = "0xA3F3AE0", VA = "0x18A3F50E0")]
		public bool EYLPGFZJXBD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4EB0", Offset = "0xA3F38B0", VA = "0x18A3F4EB0")]
		public bool BJLPOEFEHNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xA3F50B0", Offset = "0xA3F3AB0", VA = "0x18A3F50B0")]
		public bool ELZNREJGLHE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5270", Offset = "0xA3F3C70", VA = "0x18A3F5270")]
		public int NGCBRDSWDRN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4EE0", Offset = "0xA3F38E0", VA = "0x18A3F4EE0")]
		public void CABHTGMQFRT([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5220", Offset = "0xA3F3C20", VA = "0x18A3F5220")]
		public bool LQCHFCOZGET()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4096940", Offset = "0x4095340", VA = "0x184096940")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA3F53F0", Offset = "0xA3F3DF0", VA = "0x18A3F53F0")]
		public static int UZLWTNYVNQO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA3F53E0", Offset = "0xA3F3DE0", VA = "0x18A3F53E0")]
		public static double SUPKQJTPMUW()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5020", Offset = "0xA3F3A20", VA = "0x18A3F5020")]
		public static ulong DHPIFWEKHTD(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x1855CE0", Offset = "0x18546E0", VA = "0x181855CE0")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA406F40", Offset = "0xA405940", VA = "0x18A406F40")]
		public DiyFp JQWGCZTFCLA()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xF55B50", Offset = "0xF54550", VA = "0x180F55B50")]
		public uint SHMAWJROMPJ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA406F20", Offset = "0xA405920", VA = "0x18A406F20")]
		public int JAPQTRVEXWR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA406FE0", Offset = "0xA4059E0", VA = "0x18A406FE0")]
		public uint QATHMRLQLEF()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA407000", Offset = "0xA405A00", VA = "0x18A407000")]
		public bool VPHWQTGFTVE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA406DF0", Offset = "0xA4057F0", VA = "0x18A406DF0")]
		public void CABHTGMQFRT([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA406FA0", Offset = "0xA4059A0", VA = "0x18A406FA0")]
		public bool LQCHFCOZGET()
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
		[Cpp2IlInjected.Address(RVA = "0xA3F4990", Offset = "0xA3F3390", VA = "0x18A3F4990")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class KMBBYKPARUK
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] KXCJZHKQHLN;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA4A0", Offset = "0xA3F8EA0", VA = "0x18A3FA4A0")]
		public static void QCYHUXCQNBV(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA3D0", Offset = "0xA3F8DD0", VA = "0x18A3FA3D0")]
		public static void MGDNXXLCOKI(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0xA40A680", Offset = "0xA409080", VA = "0x18A40A680")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD440", Offset = "0x4EDBE40", VA = "0x184EDD440")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D9FD80", Offset = "0x2D9E780", VA = "0x182D9FD80")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA40A620", Offset = "0xA409020", VA = "0x18A40A620")]
		public Vector HMMQZQEQCFJ(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class JZNEAKDDLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] FKRAUKYWFTP;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] XGHVTZWIUGY;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int CONPQTLBGJL;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8100", Offset = "0xA3F6B00", VA = "0x18A3F8100")]
		private static byte[] MFRCIMMELSV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA3F85D0", Offset = "0xA3F6FD0", VA = "0x18A3F85D0")]
		private static Vector QSKQKRNVUYP(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7E50", Offset = "0xA3F6850", VA = "0x18A3F7E50")]
		private static Vector GDVVHNMQEVL(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7F30", Offset = "0xA3F6930", VA = "0x18A3F7F30")]
		private static void HJEGANADNEY(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8840", Offset = "0xA3F7240", VA = "0x18A3F8840")]
		private static void TQQMWMKIISB(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7DC0", Offset = "0xA3F67C0", VA = "0x18A3F7DC0")]
		private static ulong FZPOBRNXXAU(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7FC0", Offset = "0xA3F69C0", VA = "0x18A3F7FC0")]
		private static void JPZEPDZYYTE(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA3F78D0", Offset = "0xA3F62D0", VA = "0x18A3F78D0")]
		private static bool DXRGUQMLKIZ(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA3F86B0", Offset = "0xA3F70B0", VA = "0x18A3F86B0")]
		private static DiyFp THCLBLNGMJE(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8B30", Offset = "0xA3F7530", VA = "0x18A3F8B30")]
		private static bool UKVUOTHNBCY(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7CA0", Offset = "0xA3F66A0", VA = "0x18A3F7CA0")]
		private static bool FYDPWRXUKCU(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA3F81E0", Offset = "0xA3F6BE0", VA = "0x18A3F81E0")]
		public static double? OSMLRNYUKDO(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8300", Offset = "0xA3F6D00", VA = "0x18A3F8300")]
		public static float? OSWZMBMPDAG(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class SSYNMEHCDSN
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] RVTGPUUTFVP;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] NOIJVMNYKUM;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] CFFMJYRETVT;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] OABRFXESHYL;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int AQGYFQEPSTZ;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] NEYSRFRPQLP;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int EKPGJKEGSZD;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA405270", Offset = "0xA403C70", VA = "0x18A405270")]
		private static byte[] AIAQCRDLMMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA406A00", Offset = "0xA405400", VA = "0x18A406A00")]
		public static bool WCWMXVRCHEX(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA405620", Offset = "0xA404020", VA = "0x18A405620")]
		public static bool KOSJSIIKMQO(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA4057D0", Offset = "0xA4041D0", VA = "0x18A4057D0")]
		private static bool SUIPLEGDZXB(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA405350", Offset = "0xA403D50", VA = "0x18A405350")]
		private static bool DGHAQWVRHNI(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA406920", Offset = "0xA405320", VA = "0x18A406920")]
		private static bool VNLPJFCLAZZ(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA405760", Offset = "0xA404160", VA = "0x18A405760")]
		private static bool LOQMLLBPKAJ(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA406900", Offset = "0xA405300", VA = "0x18A406900")]
		private static double UFEAKEUMOHC(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA405910", Offset = "0xA404310", VA = "0x18A405910")]
		private static double TBNNCQTXIJY(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class FHMROXAOWBW<a> : KHJXOJJZUWY<a[]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly TSUXYERGCKO<a> XYHOSHONOQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour YTSHUWGTGNF;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x194D460", Offset = "0x194BE60", VA = "0x18194D460")]
		public FHMROXAOWBW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
		public FHMROXAOWBW(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x62FEB30", Offset = "0x62FD530", VA = "0x1862FEB30", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x62FE800", Offset = "0x62FD200", VA = "0x1862FE800", Slot = "5")]
		public a[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class PZKFSGNCOOV<a> : KHJXOJJZUWY<ArraySegment<a>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly TSUXYERGCKO<a> XYHOSHONOQV;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7500A70", Offset = "0x74FF470", VA = "0x187500A70", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7500620", Offset = "0x74FF020", VA = "0x187500620", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class QPPRWJSTSGL<a> : KHJXOJJZUWY<List<a>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour YTSHUWGTGNF;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x194D460", Offset = "0x194BE60", VA = "0x18194D460")]
		public QPPRWJSTSGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
		public QPPRWJSTSGL(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7703410", Offset = "0x7701E10", VA = "0x187703410", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x76FFD50", Offset = "0x76FE750", VA = "0x1876FFD50", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class RBUTSSSAXGB<a, b, c, d> : KHJXOJJZUWY<d>, YRUEVOCAGJF where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x77346E0", Offset = "0x77330E0", VA = "0x1877346E0", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7733470", Offset = "0x7731E70", VA = "0x187733470", Slot = "5")]
		public d Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c WLUAXTUJLJD(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected RBUTSSSAXGB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class RCAAPZLYGRK<a, b, c> : RBUTSSSAXGB<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7734CB0", Offset = "0x77336B0", VA = "0x187734CB0", Slot = "6")]
		protected override IEnumerator<a> WLUAXTUJLJD(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected RCAAPZLYGRK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class RCFHNGFVQCT<a, b> : RCAAPZLYGRK<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD3BB00", Offset = "0xD3A500", VA = "0x180D3BB00", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class FSEAKJQLBEF<a, b> : RCFHNGFVQCT<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6305760", Offset = "0x6304160", VA = "0x186305760", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x6305600", Offset = "0x6304000", VA = "0x186305600", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class SCYEZIXIGTK<a> : RBUTSSSAXGB<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x79BB260", Offset = "0x79B9C60", VA = "0x1879BB260", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD3BB00", Offset = "0xD3A500", VA = "0x180D3BB00", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x74FE110", Offset = "0x74FCB10", VA = "0x1874FE110", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5725DA0", Offset = "0x57247A0", VA = "0x185725DA0", Slot = "6")]
		protected override LinkedList<a>.Enumerator WLUAXTUJLJD(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class BNEGNWZBOBD<a> : RBUTSSSAXGB<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4F055B0", Offset = "0x4F03FB0", VA = "0x184F055B0", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4F05690", Offset = "0x4F04090", VA = "0x184F05690", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4F056F0", Offset = "0x4F040F0", VA = "0x184F056F0", Slot = "6")]
		protected override Queue<a>.Enumerator WLUAXTUJLJD(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xD3BB00", Offset = "0xD3A500", VA = "0x180D3BB00", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class OIHZYMDVMFJ<a> : RBUTSSSAXGB<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x510E8C0", Offset = "0x510D2C0", VA = "0x18510E8C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x510EB00", Offset = "0x510D500", VA = "0x18510EB00", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x73DA430", Offset = "0x73D8E30", VA = "0x1873DA430", Slot = "6")]
		protected override Stack<a>.Enumerator WLUAXTUJLJD(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x73DA2D0", Offset = "0x73D8CD0", VA = "0x1873DA2D0", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class SVGULIRGKXR<a> : RBUTSSSAXGB<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x79D70C0", Offset = "0x79D5AC0", VA = "0x1879D70C0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xD3BB00", Offset = "0xD3A500", VA = "0x180D3BB00", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x79D7100", Offset = "0x79D5B00", VA = "0x1879D7100", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x79D7160", Offset = "0x79D5B60", VA = "0x1879D7160", Slot = "6")]
		protected override HashSet<a>.Enumerator WLUAXTUJLJD(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x739EA40", Offset = "0x739D440", VA = "0x18739EA40")]
		public SVGULIRGKXR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class SYAFVOJNFMR<a> : RCAAPZLYGRK<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x510E8C0", Offset = "0x510D2C0", VA = "0x18510E8C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x79DA620", Offset = "0x79D9020", VA = "0x1879DA620", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x79DA6B0", Offset = "0x79D90B0", VA = "0x1879DA6B0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class LKHRWTRPYDA<a> : RCAAPZLYGRK<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x4F055B0", Offset = "0x4F03FB0", VA = "0x184F055B0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x4F05690", Offset = "0x4F04090", VA = "0x184F05690", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xD3BB00", Offset = "0xD3A500", VA = "0x180D3BB00", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class WNLUVZUUKNM<a> : RCAAPZLYGRK<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x4F055B0", Offset = "0x4F03FB0", VA = "0x184F055B0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x4F05690", Offset = "0x4F04090", VA = "0x184F05690", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xD3BB00", Offset = "0xD3A500", VA = "0x180D3BB00", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class GLTJRWLLDUA<a> : RCAAPZLYGRK<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x63F2CC0", Offset = "0x63F16C0", VA = "0x1863F2CC0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x510EB00", Offset = "0x510D500", VA = "0x18510EB00", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5BAF7D0", Offset = "0x5BAE1D0", VA = "0x185BAF7D0", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5BAF840", Offset = "0x5BAE240", VA = "0x185BAF840")]
		public GLTJRWLLDUA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class DCZPWHIDGXW<a, b> : KHJXOJJZUWY<IGrouping<a, b>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x53B0B50", Offset = "0x53AF550", VA = "0x1853B0B50", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x53B0800", Offset = "0x53AF200", VA = "0x1853B0800", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class JMDALHTNOPX<a, b> : KHJXOJJZUWY<ILookup<a, b>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x66CBF30", Offset = "0x66CA930", VA = "0x1866CBF30", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x66CBBF0", Offset = "0x66CA5F0", VA = "0x1866CBBF0", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class NAKBCMCLLXL<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a WBDMRGPRNOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> DIJMBAQJEMX;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x4EDAD90", Offset = "0x4ED9790", VA = "0x184EDAD90", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x724BB60", Offset = "0x724A560", VA = "0x18724BB60")]
		public NAKBCMCLLXL(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x724BAF0", Offset = "0x724A4F0", VA = "0x18724BAF0", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x66B1540", Offset = "0x66AFF40", VA = "0x1866B1540", Slot = "6")]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class TLDLLFVOUDA<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> HBDUALOYLGE;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x754E050", Offset = "0x754CA50", VA = "0x18754E050", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public TLDLLFVOUDA(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7B44250", Offset = "0x7B42C50", VA = "0x187B44250", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7B44340", Offset = "0x7B42D40", VA = "0x187B44340", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7B44340", Offset = "0x7B42D40", VA = "0x187B44340", Slot = "7")]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class EPZUECZXOBV<a> : KHJXOJJZUWY<a>, YRUEVOCAGJF where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5B5D540", Offset = "0x5B5BF40", VA = "0x185B5D540", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5B5D330", Offset = "0x5B5BD30", VA = "0x185B5D330", Slot = "5")]
		public a Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public EPZUECZXOBV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class YZKJFFMEKMP : KHJXOJJZUWY<IEnumerable>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly KHJXOJJZUWY<IEnumerable> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA40C770", Offset = "0xA40B170", VA = "0x18A40C770", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA40C570", Offset = "0xA40AF70", VA = "0x18A40C570", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public YZKJFFMEKMP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class LLKWNZPSONP : KHJXOJJZUWY<ICollection>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly KHJXOJJZUWY<ICollection> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA3FFE30", Offset = "0xA3FE830", VA = "0x18A3FFE30", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA3FFC30", Offset = "0xA3FE630", VA = "0x18A3FFC30", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public LLKWNZPSONP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class CYIAVGPPHMN : KHJXOJJZUWY<IList>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly KHJXOJJZUWY<IList> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4220", Offset = "0xA3F2C20", VA = "0x18A3F4220", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4020", Offset = "0xA3F2A20", VA = "0x18A3F4020", Slot = "5")]
		public IList Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public CYIAVGPPHMN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class OVKCENHSVME<a> : RCFHNGFVQCT<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x4F055B0", Offset = "0x4F03FB0", VA = "0x184F055B0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x73D33D0", Offset = "0x73D1DD0", VA = "0x1873D33D0", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class OEMNWWRCBSK<a> : RCAAPZLYGRK<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x4F055B0", Offset = "0x4F03FB0", VA = "0x184F055B0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x73D33D0", Offset = "0x73D1DD0", VA = "0x1873D33D0", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x73D3360", Offset = "0x73D1D60", VA = "0x1873D3360", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class VGNLNNZNUMA<a> : RCAAPZLYGRK<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5BAF790", Offset = "0x5BAE190", VA = "0x185BAF790", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x510EB00", Offset = "0x510D500", VA = "0x18510EB00", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7EF1570", Offset = "0x7EEFF70", VA = "0x187EF1570", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7EF15B0", Offset = "0x7EEFFB0", VA = "0x187EF15B0")]
		public VGNLNNZNUMA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class EVPSXKPCDWA<a> : RCAAPZLYGRK<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x5BAF790", Offset = "0x5BAE190", VA = "0x185BAF790", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x510EB00", Offset = "0x510D500", VA = "0x18510EB00", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5BAF7D0", Offset = "0x5BAE1D0", VA = "0x185BAF7D0", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x5BAF840", Offset = "0x5BAE240", VA = "0x185BAF840")]
		public EVPSXKPCDWA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class PXKJGVWUSTW<a> : RCAAPZLYGRK<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x74FE020", Offset = "0x74FCA20", VA = "0x1874FE020", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xD3BB00", Offset = "0xD3A500", VA = "0x180D3BB00", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x74FE110", Offset = "0x74FCB10", VA = "0x1874FE110", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class JUNXTXZDZQQ<a> : RCFHNGFVQCT<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x4F055B0", Offset = "0x4F03FB0", VA = "0x184F055B0", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4F05690", Offset = "0x4F04090", VA = "0x184F05690", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class GASLMLMIMLB<a> : RCFHNGFVQCT<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x4F055B0", Offset = "0x4F03FB0", VA = "0x184F055B0", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x4F05690", Offset = "0x4F04090", VA = "0x184F05690", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class ZPWJTKJRDXY<a> : RCAAPZLYGRK<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x510E8C0", Offset = "0x510D2C0", VA = "0x18510E8C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x510EB00", Offset = "0x510D500", VA = "0x18510EB00", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x510E9A0", Offset = "0x510D3A0", VA = "0x18510E9A0", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class YKRFXYSGSLV
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
		[Cpp2IlInjected.Address(RVA = "0xA40BA40", Offset = "0xA40A440", VA = "0x18A40BA40")]
		public static DateTime CQSKWIPSPJB(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA40C1D0", Offset = "0xA40ABD0", VA = "0x18A40C1D0")]
		public static bool SYEBYNZXGSS(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA40BF40", Offset = "0xA40A940", VA = "0x18A40BF40")]
		public static bool NPJKBTYREJY(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA40BD30", Offset = "0xA40A730", VA = "0x18A40BD30")]
		public static bool NPJKBTYREJY(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA40BB00", Offset = "0xA40A500", VA = "0x18A40BB00")]
		public static bool MLDGBJMNZBK(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class KILNSIOJWBN : KHJXOJJZUWY<DateTime>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly KHJXOJJZUWY<DateTime> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xA3F97B0", Offset = "0xA3F81B0", VA = "0x18A3F97B0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9630", Offset = "0xA3F8030", VA = "0x18A3F9630", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9230", Offset = "0xA3F7C30", VA = "0x18A3F9230")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public KILNSIOJWBN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class UMZBBZZAVXU : KHJXOJJZUWY<DateTimeOffset>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly KHJXOJJZUWY<DateTimeOffset> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA409030", Offset = "0xA407A30", VA = "0x18A409030", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA408BE0", Offset = "0xA4075E0", VA = "0x18A408BE0", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA408C50", Offset = "0xA407650", VA = "0x18A408C50")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public UMZBBZZAVXU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class SGXQIEWJNWH : KHJXOJJZUWY<TimeSpan>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly KHJXOJJZUWY<TimeSpan> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] RLHOFIPXKYL;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA404770", Offset = "0xA403170", VA = "0x18A404770", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA404300", Offset = "0xA402D00", VA = "0x18A404300", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA404380", Offset = "0xA402D80", VA = "0x18A404380")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public SGXQIEWJNWH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class TMBBMDWMNHA<a, b, c, d, e> : KHJXOJJZUWY<e>, YRUEVOCAGJF where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4B640", Offset = "0x7B4A040", VA = "0x187B4B640", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7B472C0", Offset = "0x7B45CC0", VA = "0x187B472C0", Slot = "5")]
		public e Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d WLUAXTUJLJD(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected TMBBMDWMNHA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class TMGIJKQJWSJ<a, b, c, d> : TMBBMDWMNHA<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7734CB0", Offset = "0x77336B0", VA = "0x187734CB0", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> WLUAXTUJLJD(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6411600", Offset = "0x6410000", VA = "0x186411600")]
		protected TMGIJKQJWSJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class TKVMCPHCIQY<a, b, c> : TMGIJKQJWSJ<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xD3BB00", Offset = "0xD3A500", VA = "0x180D3BB00", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class ANKUIUSATXA<a, b> : TMBBMDWMNHA<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x72EE3C0", Offset = "0x72ECDC0", VA = "0x1872EE3C0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xD3BB00", Offset = "0xD3A500", VA = "0x180D3BB00", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x72EE660", Offset = "0x72ED060", VA = "0x1872EE660", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x72EE780", Offset = "0x72ED180", VA = "0x1872EE780", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator WLUAXTUJLJD(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6A9F480", Offset = "0x6A9DE80", VA = "0x186A9F480")]
		public ANKUIUSATXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class LQJVGEOXPHU<a, b, c> : TKVMCPHCIQY<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x69313A0", Offset = "0x692FDA0", VA = "0x1869313A0", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6931580", Offset = "0x692FF80", VA = "0x186931580", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class VMPXAWQSGNF<a, b> : TMGIJKQJWSJ<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x50E9EA0", Offset = "0x50E88A0", VA = "0x1850E9EA0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x50EA010", Offset = "0x50E8A10", VA = "0x1850EA010", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xD3BB00", Offset = "0xD3A500", VA = "0x180D3BB00", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class YDJZNQILHNL<a, b> : TKVMCPHCIQY<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x50E9EA0", Offset = "0x50E88A0", VA = "0x1850E9EA0", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x50EA010", Offset = "0x50E8A10", VA = "0x1850EA010", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class RDIJLEHRZYV<a, b> : TMBBMDWMNHA<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x50E9EA0", Offset = "0x50E88A0", VA = "0x1850E9EA0", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xD3BB00", Offset = "0xD3A500", VA = "0x180D3BB00", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x50EA010", Offset = "0x50E8A10", VA = "0x1850EA010", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7734D00", Offset = "0x7733700", VA = "0x187734D00", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator WLUAXTUJLJD(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class OOYWTIKTDRG<a, b> : TMGIJKQJWSJ<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x50E9EA0", Offset = "0x50E88A0", VA = "0x1850E9EA0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x73E1300", Offset = "0x73DFD00", VA = "0x1873E1300", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x73E1370", Offset = "0x73DFD70", VA = "0x1873E1370", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class GJVENNUFBGR<a, b> : TMGIJKQJWSJ<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x63DB350", Offset = "0x63D9D50", VA = "0x1863DB350", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD3BB00", Offset = "0xD3A500", VA = "0x180D3BB00", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x63DB3F0", Offset = "0x63D9DF0", VA = "0x1863DB3F0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x63DB450", Offset = "0x63D9E50", VA = "0x1863DB450")]
		public GJVENNUFBGR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class EAFIIWKIQLP<a, b> : TKVMCPHCIQY<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5B09A40", Offset = "0x5B08440", VA = "0x185B09A40", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x50EA010", Offset = "0x50E8A10", VA = "0x1850EA010", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class NVAVHOFAVML<a> : KHJXOJJZUWY<a>, YRUEVOCAGJF where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x727C8C0", Offset = "0x727B2C0", VA = "0x18727C8C0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x727C690", Offset = "0x727B090", VA = "0x18727C690", Slot = "5")]
		public a Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public NVAVHOFAVML()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class LQWDYBOKKNL : KHJXOJJZUWY<IDictionary>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly KHJXOJJZUWY<IDictionary> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA4004C0", Offset = "0xA3FEEC0", VA = "0x18A4004C0", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA4002E0", Offset = "0xA3FECE0", VA = "0x18A4002E0", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public LQWDYBOKKNL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class XEHJWIIEPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA40A810", Offset = "0xA409210", VA = "0x18A40A810")]
		public static object NGBFANCKYLJ(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA40B050", Offset = "0xA409A50", VA = "0x18A40B050")]
		public static object UNVEFLEORRQ(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class KEJSJETCLIU<a> : KHJXOJJZUWY<a>, YRUEVOCAGJF, SFXMQQMLSQV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class EZWOGTCCREE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type EQJHIWKHCLI;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public EZWOGTCCREE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x5BB4970", Offset = "0x5BB3370", VA = "0x185BB4970")]
			internal bool PUPJRJQPZAL(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class FABVDZWAAPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string EVJTQKRREGA;

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public FABVDZWAAPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x62FAF30", Offset = "0x62F9930", VA = "0x1862FAF30")]
			internal bool PUKCUCWSPPC(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class FAHCBGPXKAW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> KDJGIVKUDFB;

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public FAHCBGPXKAW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x62FC000", Offset = "0x62FAA00", VA = "0x1862FC000")]
			internal void PUZXLXEKRXD(JsonWriter a, a b, BBOFZKRFCTL c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class FAMIYNJUTMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> UYRCQKRUNLE;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public FAMIYNJUTMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x62FC7F0", Offset = "0x62FB1F0", VA = "0x1862FC7F0")]
			internal a PUUQOQKNILU(JsonReader a, BBOFZKRFCTL b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly ZDWAONULNYH<a> RZYQDOZAPPK;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> THIXVEBMDTI;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> MEEGFANXIVQ;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> KGNFNIGHOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool GEEGSMLWZNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> BRYLAQRKZRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> FSZXIFCAFEQ;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x67D88E0", Offset = "0x67D72E0", VA = "0x1867D88E0")]
		static KEJSJETCLIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x67DDAC0", Offset = "0x67DC4C0", VA = "0x1867DDAC0")]
		public KEJSJETCLIU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x67D2DF0", Offset = "0x67D17F0", VA = "0x1867D2DF0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x67D0830", Offset = "0x67CF230", VA = "0x1867D0830", Slot = "5")]
		public a Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x67D22B0", Offset = "0x67D0CB0", VA = "0x1867D22B0", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, a b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x67D2630", Offset = "0x67D1030", VA = "0x1867D2630", Slot = "7")]
		public a LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class ZRLQBBCTEZG<a> : KHJXOJJZUWY<a[,]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x510EF70", Offset = "0x510D970", VA = "0x18510EF70", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x510EBE0", Offset = "0x510D5E0", VA = "0x18510EBE0", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public ZRLQBBCTEZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class XOQQLEVBONI<a> : KHJXOJJZUWY<a[,,]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x50A9480", Offset = "0x50A7E80", VA = "0x1850A9480", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x50A8FB0", Offset = "0x50A79B0", VA = "0x1850A8FB0", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public XOQQLEVBONI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class LYDQNYKQRWS<a> : KHJXOJJZUWY<a[,,,]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6A0B6C0", Offset = "0x6A0A0C0", VA = "0x186A0B6C0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6A0B0C0", Offset = "0x6A09AC0", VA = "0x186A0B0C0", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public LYDQNYKQRWS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class TQESODFLSQE<a> : KHJXOJJZUWY<a?>, YRUEVOCAGJF where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7B564E0", Offset = "0x7B54EE0", VA = "0x187B564E0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7B560D0", Offset = "0x7B54AD0", VA = "0x187B560D0", Slot = "5")]
		public a? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public TQESODFLSQE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class JTUFCYHFASC<a> : KHJXOJJZUWY<a?>, YRUEVOCAGJF where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly KHJXOJJZUWY<a> JRMVZCNCLSZ;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public JTUFCYHFASC(KHJXOJJZUWY<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x66D2D60", Offset = "0x66D1760", VA = "0x1866D2D60", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x66D1E90", Offset = "0x66D0890", VA = "0x1866D1E90", Slot = "5")]
		public a? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class BETDSHWVQOZ : KHJXOJJZUWY<sbyte>, YRUEVOCAGJF, SFXMQQMLSQV<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly BETDSHWVQOZ AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA3F32E0", Offset = "0xA3F1CE0", VA = "0x18A3F32E0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3140", Offset = "0xA3F1B40", VA = "0x18A3F3140", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3150", Offset = "0xA3F1B50", VA = "0x18A3F3150", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, sbyte b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3260", Offset = "0xA3F1C60", VA = "0x18A3F3260", Slot = "7")]
		public sbyte LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public BETDSHWVQOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class RLMFEPQGMME : KHJXOJJZUWY<sbyte?>, YRUEVOCAGJF, SFXMQQMLSQV<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly RLMFEPQGMME AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA4041A0", Offset = "0xA402BA0", VA = "0x18A4041A0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA403F00", Offset = "0xA402900", VA = "0x18A403F00", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA403F70", Offset = "0xA402970", VA = "0x18A403F70", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, sbyte? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA4040D0", Offset = "0xA402AD0", VA = "0x18A4040D0", Slot = "7")]
		public sbyte? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public RLMFEPQGMME()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class UUCKZAIUNRK : KHJXOJJZUWY<sbyte[]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly UUCKZAIUNRK AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA409C70", Offset = "0xA408670", VA = "0x18A409C70", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA409B30", Offset = "0xA408530", VA = "0x18A409B30", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public UUCKZAIUNRK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class TCNTGGRZOHE : KHJXOJJZUWY<short>, YRUEVOCAGJF, SFXMQQMLSQV<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly TCNTGGRZOHE AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xA4074D0", Offset = "0xA405ED0", VA = "0x18A4074D0", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA407330", Offset = "0xA405D30", VA = "0x18A407330", Slot = "5")]
		public short Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA407340", Offset = "0xA405D40", VA = "0x18A407340", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, short b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA407450", Offset = "0xA405E50", VA = "0x18A407450", Slot = "7")]
		public short LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public TCNTGGRZOHE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class PZNJXBQYEJF : KHJXOJJZUWY<short?>, YRUEVOCAGJF, SFXMQQMLSQV<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly PZNJXBQYEJF AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA403150", Offset = "0xA401B50", VA = "0x18A403150", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA402EB0", Offset = "0xA4018B0", VA = "0x18A402EB0", Slot = "5")]
		public short? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA402F20", Offset = "0xA401920", VA = "0x18A402F20", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, short? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA403080", Offset = "0xA401A80", VA = "0x18A403080", Slot = "7")]
		public short? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public PZNJXBQYEJF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class PIVMIDYSLCZ : KHJXOJJZUWY<short[]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly PIVMIDYSLCZ AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA401C30", Offset = "0xA400630", VA = "0x18A401C30", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA401AF0", Offset = "0xA4004F0", VA = "0x18A401AF0", Slot = "5")]
		public short[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public PIVMIDYSLCZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class ISIPKTCYNZO : KHJXOJJZUWY<int>, YRUEVOCAGJF, SFXMQQMLSQV<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly ISIPKTCYNZO AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6BC0", Offset = "0xA3F55C0", VA = "0x18A3F6BC0", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6A20", Offset = "0xA3F5420", VA = "0x18A3F6A20", Slot = "5")]
		public int Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6A30", Offset = "0xA3F5430", VA = "0x18A3F6A30", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, int b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6B40", Offset = "0xA3F5540", VA = "0x18A3F6B40", Slot = "7")]
		public int LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public ISIPKTCYNZO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class RKMJBPIQPAB : KHJXOJJZUWY<int?>, YRUEVOCAGJF, SFXMQQMLSQV<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly RKMJBPIQPAB AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xA403DA0", Offset = "0xA4027A0", VA = "0x18A403DA0", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA403B00", Offset = "0xA402500", VA = "0x18A403B00", Slot = "5")]
		public int? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA403B70", Offset = "0xA402570", VA = "0x18A403B70", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, int? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA403CD0", Offset = "0xA4026D0", VA = "0x18A403CD0", Slot = "7")]
		public int? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public RKMJBPIQPAB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class SRPVEBMINQT : KHJXOJJZUWY<int[]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly SRPVEBMINQT AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA404FD0", Offset = "0xA4039D0", VA = "0x18A404FD0", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA404E90", Offset = "0xA403890", VA = "0x18A404E90", Slot = "5")]
		public int[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public SRPVEBMINQT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class UIKADEIRYXH : KHJXOJJZUWY<long>, YRUEVOCAGJF, SFXMQQMLSQV<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly UIKADEIRYXH AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA408B10", Offset = "0xA407510", VA = "0x18A408B10", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA4089F0", Offset = "0xA4073F0", VA = "0x18A4089F0", Slot = "5")]
		public long Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA408A00", Offset = "0xA407400", VA = "0x18A408A00", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, long b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA408AD0", Offset = "0xA4074D0", VA = "0x18A408AD0", Slot = "7")]
		public long LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public UIKADEIRYXH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class BZOLQUSESEY : KHJXOJJZUWY<long?>, YRUEVOCAGJF, SFXMQQMLSQV<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly BZOLQUSESEY AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3650", Offset = "0xA3F2050", VA = "0x18A3F3650", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA3F33E0", Offset = "0xA3F1DE0", VA = "0x18A3F33E0", Slot = "5")]
		public long? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3470", Offset = "0xA3F1E70", VA = "0x18A3F3470", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, long? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA3F35A0", Offset = "0xA3F1FA0", VA = "0x18A3F35A0", Slot = "7")]
		public long? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public BZOLQUSESEY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class TXUAXBAZYKE : KHJXOJJZUWY<long[]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly TXUAXBAZYKE AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA407D90", Offset = "0xA406790", VA = "0x18A407D90", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA407C50", Offset = "0xA406650", VA = "0x18A407C50", Slot = "5")]
		public long[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public TXUAXBAZYKE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class TMJKXCTHYDE : KHJXOJJZUWY<byte>, YRUEVOCAGJF, SFXMQQMLSQV<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly TMJKXCTHYDE AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA407960", Offset = "0xA406360", VA = "0x18A407960", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA4077C0", Offset = "0xA4061C0", VA = "0x18A4077C0", Slot = "5")]
		public byte Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA4077D0", Offset = "0xA4061D0", VA = "0x18A4077D0", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, byte b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA4078E0", Offset = "0xA4062E0", VA = "0x18A4078E0", Slot = "7")]
		public byte LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public TMJKXCTHYDE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class FXPTVNLSNVT : KHJXOJJZUWY<byte?>, YRUEVOCAGJF, SFXMQQMLSQV<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly FXPTVNLSNVT AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5B40", Offset = "0xA3F4540", VA = "0x18A3F5B40", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA3F58A0", Offset = "0xA3F42A0", VA = "0x18A3F58A0", Slot = "5")]
		public byte? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5910", Offset = "0xA3F4310", VA = "0x18A3F5910", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, byte? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5A70", Offset = "0xA3F4470", VA = "0x18A3F5A70", Slot = "7")]
		public byte? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public FXPTVNLSNVT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class JFCCJFUPXZX : KHJXOJJZUWY<ushort>, YRUEVOCAGJF, SFXMQQMLSQV<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly JFCCJFUPXZX AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7050", Offset = "0xA3F5A50", VA = "0x18A3F7050", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6EB0", Offset = "0xA3F58B0", VA = "0x18A3F6EB0", Slot = "5")]
		public ushort Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6EC0", Offset = "0xA3F58C0", VA = "0x18A3F6EC0", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, ushort b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6FD0", Offset = "0xA3F59D0", VA = "0x18A3F6FD0", Slot = "7")]
		public ushort LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public JFCCJFUPXZX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class VTEAOVDZINE : KHJXOJJZUWY<ushort?>, YRUEVOCAGJF, SFXMQQMLSQV<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly VTEAOVDZINE AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA40A4C0", Offset = "0xA408EC0", VA = "0x18A40A4C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA40A220", Offset = "0xA408C20", VA = "0x18A40A220", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA40A290", Offset = "0xA408C90", VA = "0x18A40A290", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, ushort? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA40A3F0", Offset = "0xA408DF0", VA = "0x18A40A3F0", Slot = "7")]
		public ushort? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public VTEAOVDZINE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class CFJVXHCXKDS : KHJXOJJZUWY<ushort[]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly CFJVXHCXKDS AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA3F38C0", Offset = "0xA3F22C0", VA = "0x18A3F38C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3780", Offset = "0xA3F2180", VA = "0x18A3F3780", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public CFJVXHCXKDS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class UIFAGTJUBJZ : KHJXOJJZUWY<uint>, YRUEVOCAGJF, SFXMQQMLSQV<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly UIFAGTJUBJZ AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA4088F0", Offset = "0xA4072F0", VA = "0x18A4088F0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA408750", Offset = "0xA407150", VA = "0x18A408750", Slot = "5")]
		public uint Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA408760", Offset = "0xA407160", VA = "0x18A408760", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, uint b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA408870", Offset = "0xA407270", VA = "0x18A408870", Slot = "7")]
		public uint LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public UIFAGTJUBJZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class QVDTKKVQCYQ : KHJXOJJZUWY<uint?>, YRUEVOCAGJF, SFXMQQMLSQV<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly QVDTKKVQCYQ AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA4039A0", Offset = "0xA4023A0", VA = "0x18A4039A0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA403700", Offset = "0xA402100", VA = "0x18A403700", Slot = "5")]
		public uint? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA403770", Offset = "0xA402170", VA = "0x18A403770", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, uint? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA4038D0", Offset = "0xA4022D0", VA = "0x18A4038D0", Slot = "7")]
		public uint? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public QVDTKKVQCYQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class PCLSUTQPNUS : KHJXOJJZUWY<uint[]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly PCLSUTQPNUS AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA401850", Offset = "0xA400250", VA = "0x18A401850", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA401710", Offset = "0xA400110", VA = "0x18A401710", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public PCLSUTQPNUS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class ISRHOANXTIC : KHJXOJJZUWY<ulong>, YRUEVOCAGJF, SFXMQQMLSQV<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly ISRHOANXTIC AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6DE0", Offset = "0xA3F57E0", VA = "0x18A3F6DE0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6CC0", Offset = "0xA3F56C0", VA = "0x18A3F6CC0", Slot = "5")]
		public ulong Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6CD0", Offset = "0xA3F56D0", VA = "0x18A3F6CD0", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, ulong b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6DA0", Offset = "0xA3F57A0", VA = "0x18A3F6DA0", Slot = "7")]
		public ulong LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public ISRHOANXTIC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class GVUIWNNQPMN : KHJXOJJZUWY<ulong?>, YRUEVOCAGJF, SFXMQQMLSQV<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly GVUIWNNQPMN AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xA3F63E0", Offset = "0xA3F4DE0", VA = "0x18A3F63E0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6170", Offset = "0xA3F4B70", VA = "0x18A3F6170", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6200", Offset = "0xA3F4C00", VA = "0x18A3F6200", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, ulong? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6330", Offset = "0xA3F4D30", VA = "0x18A3F6330", Slot = "7")]
		public ulong? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public GVUIWNNQPMN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class HDLUXZMASVD : KHJXOJJZUWY<ulong[]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly HDLUXZMASVD AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6650", Offset = "0xA3F5050", VA = "0x18A3F6650", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6510", Offset = "0xA3F4F10", VA = "0x18A3F6510", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public HDLUXZMASVD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class YYSXFVDDUWE : KHJXOJJZUWY<float>, YRUEVOCAGJF, SFXMQQMLSQV<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly YYSXFVDDUWE AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA40C4A0", Offset = "0xA40AEA0", VA = "0x18A40C4A0", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA40C380", Offset = "0xA40AD80", VA = "0x18A40C380", Slot = "5")]
		public float Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA40C390", Offset = "0xA40AD90", VA = "0x18A40C390", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, float b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA40C460", Offset = "0xA40AE60", VA = "0x18A40C460", Slot = "7")]
		public float LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public YYSXFVDDUWE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class CZRGVAEDYMX : KHJXOJJZUWY<float?>, YRUEVOCAGJF, SFXMQQMLSQV<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly CZRGVAEDYMX AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4860", Offset = "0xA3F3260", VA = "0x18A3F4860", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4630", Offset = "0xA3F3030", VA = "0x18A3F4630", Slot = "5")]
		public float? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA3F46A0", Offset = "0xA3F30A0", VA = "0x18A3F46A0", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, float? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA3F47C0", Offset = "0xA3F31C0", VA = "0x18A3F47C0", Slot = "7")]
		public float? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public CZRGVAEDYMX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class GQYWZCXXWJR : KHJXOJJZUWY<float[]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly GQYWZCXXWJR AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5DE0", Offset = "0xA3F47E0", VA = "0x18A3F5DE0", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5CA0", Offset = "0xA3F46A0", VA = "0x18A3F5CA0", Slot = "5")]
		public float[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public GQYWZCXXWJR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class NABIELKTOUP : KHJXOJJZUWY<double>, YRUEVOCAGJF, SFXMQQMLSQV<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly NABIELKTOUP AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xA401640", Offset = "0xA400040", VA = "0x18A401640", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA401520", Offset = "0xA3FFF20", VA = "0x18A401520", Slot = "5")]
		public double Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA401530", Offset = "0xA3FFF30", VA = "0x18A401530", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, double b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA401600", Offset = "0xA400000", VA = "0x18A401600", Slot = "7")]
		public double LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public NABIELKTOUP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class JYVZOKJUUHS : KHJXOJJZUWY<double?>, YRUEVOCAGJF, SFXMQQMLSQV<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly JYVZOKJUUHS AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA3F77A0", Offset = "0xA3F61A0", VA = "0x18A3F77A0", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7530", Offset = "0xA3F5F30", VA = "0x18A3F7530", Slot = "5")]
		public double? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA3F75C0", Offset = "0xA3F5FC0", VA = "0x18A3F75C0", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, double? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA3F76F0", Offset = "0xA3F60F0", VA = "0x18A3F76F0", Slot = "7")]
		public double? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public JYVZOKJUUHS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class MTKFPHDBFUC : KHJXOJJZUWY<double[]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly MTKFPHDBFUC AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA4011A0", Offset = "0xA3FFBA0", VA = "0x18A4011A0", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA401060", Offset = "0xA3FFA60", VA = "0x18A401060", Slot = "5")]
		public double[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public MTKFPHDBFUC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class LUVZJOYPWQI : KHJXOJJZUWY<bool>, YRUEVOCAGJF, SFXMQQMLSQV<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly LUVZJOYPWQI AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA400C30", Offset = "0xA3FF630", VA = "0x18A400C30", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA400B10", Offset = "0xA3FF510", VA = "0x18A400B10", Slot = "5")]
		public bool Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA400B20", Offset = "0xA3FF520", VA = "0x18A400B20", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, bool b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA400BF0", Offset = "0xA3FF5F0", VA = "0x18A400BF0", Slot = "7")]
		public bool LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public LUVZJOYPWQI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class MRWNAMESFQF : KHJXOJJZUWY<bool?>, YRUEVOCAGJF, SFXMQQMLSQV<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly MRWNAMESFQF AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA400F30", Offset = "0xA3FF930", VA = "0x18A400F30", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA400D00", Offset = "0xA3FF700", VA = "0x18A400D00", Slot = "5")]
		public bool? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xA400D70", Offset = "0xA3FF770", VA = "0x18A400D70", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, bool? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA400E90", Offset = "0xA3FF890", VA = "0x18A400E90", Slot = "7")]
		public bool? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public MRWNAMESFQF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class AGADARLTOXF : KHJXOJJZUWY<bool[]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly AGADARLTOXF AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA3F2C70", Offset = "0xA3F1670", VA = "0x18A3F2C70", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA3F2B30", Offset = "0xA3F1530", VA = "0x18A3F2B30", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public AGADARLTOXF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class HJRHJLKFDNT : KHJXOJJZUWY<byte[]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly KHJXOJJZUWY<byte[]> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA3F68F0", Offset = "0xA3F52F0", VA = "0x18A3F68F0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6880", Offset = "0xA3F5280", VA = "0x18A3F6880", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public HJRHJLKFDNT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class KPFNQLLRZEY : KHJXOJJZUWY<ArraySegment<byte>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly KHJXOJJZUWY<ArraySegment<byte>> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB960", Offset = "0xA3FA360", VA = "0x18A3FB960", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB890", Offset = "0xA3FA290", VA = "0x18A3FB890", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public KPFNQLLRZEY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class AZCAXHIEPAU : KHJXOJJZUWY<string>, YRUEVOCAGJF, SFXMQQMLSQV<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly KHJXOJJZUWY<string> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3070", Offset = "0xA3F1A70", VA = "0x18A3F3070", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3000", Offset = "0xA3F1A00", VA = "0x18A3F3000", Slot = "5")]
		public string Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3010", Offset = "0xA3F1A10", VA = "0x18A3F3010", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, string b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3000", Offset = "0xA3F1A00", VA = "0x18A3F3000", Slot = "7")]
		public string LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public AZCAXHIEPAU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class KNAKQRZAZNN : KHJXOJJZUWY<string[]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly KNAKQRZAZNN AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB660", Offset = "0xA3FA060", VA = "0x18A3FB660", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB510", Offset = "0xA3F9F10", VA = "0x18A3FB510", Slot = "5")]
		public string[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public KNAKQRZAZNN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class WAXUXTIGMQM : KHJXOJJZUWY<char>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly WAXUXTIGMQM AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA40A6F0", Offset = "0xA4090F0", VA = "0x18A40A6F0", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA40A6C0", Offset = "0xA4090C0", VA = "0x18A40A6C0", Slot = "5")]
		public char Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public WAXUXTIGMQM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class JJJCKMYWOAP : KHJXOJJZUWY<char?>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly JJJCKMYWOAP AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA3F73C0", Offset = "0xA3F5DC0", VA = "0x18A3F73C0", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7300", Offset = "0xA3F5D00", VA = "0x18A3F7300", Slot = "5")]
		public char? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public JJJCKMYWOAP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class QEQSLFBVSQH : KHJXOJJZUWY<char[]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly QEQSLFBVSQH AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA403440", Offset = "0xA401E40", VA = "0x18A403440", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA4032B0", Offset = "0xA401CB0", VA = "0x18A4032B0", Slot = "5")]
		public char[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public QEQSLFBVSQH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class KQURDIGJWVR : KHJXOJJZUWY<Guid>, YRUEVOCAGJF, SFXMQQMLSQV<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly KHJXOJJZUWY<Guid> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBD50", Offset = "0xA3FA750", VA = "0x18A3FBD50", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBB00", Offset = "0xA3FA500", VA = "0x18A3FBB00", Slot = "5")]
		public Guid Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBB60", Offset = "0xA3FA560", VA = "0x18A3FBB60", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, Guid b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBCE0", Offset = "0xA3FA6E0", VA = "0x18A3FBCE0", Slot = "7")]
		public Guid LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public KQURDIGJWVR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class ZPRMFLUJBPT : KHJXOJJZUWY<decimal>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly KHJXOJJZUWY<decimal> AESEIRAUIMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool YBRQRHMUZTT;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8747320", Offset = "0x8745D20", VA = "0x188747320")]
		public ZPRMFLUJBPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xFDD4D0", Offset = "0xFDBED0", VA = "0x180FDD4D0")]
		public ZPRMFLUJBPT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA40CCC0", Offset = "0xA40B6C0", VA = "0x18A40CCC0", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA40CAF0", Offset = "0xA40B4F0", VA = "0x18A40CAF0", Slot = "5")]
		public decimal Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class ZRUGSGSWLRI : KHJXOJJZUWY<Uri>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly KHJXOJJZUWY<Uri> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA40CF90", Offset = "0xA40B990", VA = "0x18A40CF90", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA40CF10", Offset = "0xA40B910", VA = "0x18A40CF10", Slot = "5")]
		public Uri Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public ZRUGSGSWLRI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class CHIUEOVIZXC : KHJXOJJZUWY<Version>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly KHJXOJJZUWY<Version> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3BE0", Offset = "0xA3F25E0", VA = "0x18A3F3BE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3B60", Offset = "0xA3F2560", VA = "0x18A3F3B60", Slot = "5")]
		public Version Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public CHIUEOVIZXC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class GRRSZJFKFGK<a, b> : KHJXOJJZUWY<KeyValuePair<a, b>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x6400330", Offset = "0x63FED30", VA = "0x186400330", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x63FFE60", Offset = "0x63FE860", VA = "0x1863FFE60", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class EHEPUAECQRO : KHJXOJJZUWY<StringBuilder>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly KHJXOJJZUWY<StringBuilder> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5560", Offset = "0xA3F3F60", VA = "0x18A3F5560", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA3F54E0", Offset = "0xA3F3EE0", VA = "0x18A3F54E0", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public EHEPUAECQRO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class VJEMYAUZOJS : KHJXOJJZUWY<BitArray>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly KHJXOJJZUWY<BitArray> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA40A030", Offset = "0xA408A30", VA = "0x18A40A030", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA409F10", Offset = "0xA408910", VA = "0x18A409F10", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public VJEMYAUZOJS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class CLHPEEWOAQA : KHJXOJJZUWY<Type>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly CLHPEEWOAQA AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex XWIIYRZAAMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool YRBMQYRWYNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool WFERMVIFRKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool RWNXIXCXQWL;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4000", Offset = "0xA3F2A00", VA = "0x18A3F4000")]
		public CLHPEEWOAQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x97123F0", Offset = "0x9710DF0", VA = "0x1897123F0")]
		public CLHPEEWOAQA(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3E20", Offset = "0xA3F2820", VA = "0x18A3F3E20", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3D10", Offset = "0xA3F2710", VA = "0x18A3F3D10", Slot = "5")]
		public Type Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class TMPKWVANXOU : KHJXOJJZUWY<BigInteger>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly KHJXOJJZUWY<BigInteger> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA407B10", Offset = "0xA406510", VA = "0x18A407B10", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA407A60", Offset = "0xA406460", VA = "0x18A407A60", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public TMPKWVANXOU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class EQHIGCSFGSM : KHJXOJJZUWY<Complex>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly KHJXOJJZUWY<Complex> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5700", Offset = "0xA3F4100", VA = "0x18A3F5700", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5670", Offset = "0xA3F4070", VA = "0x18A3F5670", Slot = "5")]
		public Complex Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public EQHIGCSFGSM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class DCEALGVGEOW : KHJXOJJZUWY<ExpandoObject>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly KHJXOJJZUWY<ExpandoObject> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4BD0", Offset = "0xA3F35D0", VA = "0x18A3F4BD0", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA3F49A0", Offset = "0xA3F33A0", VA = "0x18A3F49A0", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public DCEALGVGEOW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class SMXSOWSODQZ<a> : KHJXOJJZUWY<Lazy<a>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x79BEF10", Offset = "0x79BD910", VA = "0x1879BEF10", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x79BED20", Offset = "0x79BD720", VA = "0x1879BED20", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class THHPLXEAEIJ : KHJXOJJZUWY<Task>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly KHJXOJJZUWY<Task> AESEIRAUIMD;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task YSLSKOEPSYK;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA407680", Offset = "0xA406080", VA = "0x18A407680", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA4075D0", Offset = "0xA405FD0", VA = "0x18A4075D0", Slot = "5")]
		public Task Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public THHPLXEAEIJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class DAHGWIAADNT<a> : KHJXOJJZUWY<Task<a>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x53AF550", Offset = "0x53ADF50", VA = "0x1853AF550", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x53AF3E0", Offset = "0x53ADDE0", VA = "0x1853AF3E0", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class TNWSRMEQNFF<a> : KHJXOJJZUWY<ValueTask<a>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B552D0", Offset = "0x7B53CD0", VA = "0x187B552D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B55130", Offset = "0x7B53B30", VA = "0x187B55130", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class UNVLEFHLVMV<a> : KHJXOJJZUWY<Tuple<a>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF120", Offset = "0x7DFDB20", VA = "0x187DFF120", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEE50", Offset = "0x7DFD850", VA = "0x187DFEE50", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class UNFQMKZTTEU<a, b> : KHJXOJJZUWY<Tuple<a, b>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7DFDD40", Offset = "0x7DFC740", VA = "0x187DFDD40", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD920", Offset = "0x7DFC320", VA = "0x187DFD920", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class UNKXJRTRCQD<a, b, c> : KHJXOJJZUWY<Tuple<a, b, c>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE7D0", Offset = "0x7DFD1D0", VA = "0x187DFE7D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE260", Offset = "0x7DFCC60", VA = "0x187DFE260", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class UOLFVZPDXUW<a, b, c, d> : KHJXOJJZUWY<Tuple<a, b, c, d>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7E02780", Offset = "0x7E01180", VA = "0x187E02780", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7E020C0", Offset = "0x7E00AC0", VA = "0x187E020C0", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class UOQMTGJBHGF<a, b, c, d, e> : KHJXOJJZUWY<Tuple<a, b, c, d, e>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7E03780", Offset = "0x7E02180", VA = "0x187E03780", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7E02F70", Offset = "0x7E01970", VA = "0x187E02F70", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class UOASBMBJEYE<a, b, c, d, e, f> : KHJXOJJZUWY<Tuple<a, b, c, d, e, f>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7DFFE90", Offset = "0x7DFE890", VA = "0x187DFFE90", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7DFF4F0", Offset = "0x7DFDEF0", VA = "0x187DFF4F0", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class UOFYYSVGOJN<a, b, c, d, e, f, g> : KHJXOJJZUWY<Tuple<a, b, c, d, e, f, g>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7E01480", Offset = "0x7DFFE80", VA = "0x187E01480", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E00960", Offset = "0x7DFF360", VA = "0x187E00960", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class UPGHLAQTJOG<a, b, c, d, e, f, g, h> : KHJXOJJZUWY<Tuple<a, b, c, d, e, f, g, h>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7E04D70", Offset = "0x7E03770", VA = "0x187E04D70", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7E040E0", Offset = "0x7E02AE0", VA = "0x187E040E0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class WPONSULLOPC<a> : KHJXOJJZUWY<ValueTuple<a>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x85CDFE0", Offset = "0x85CC9E0", VA = "0x1885CDFE0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x85CDBC0", Offset = "0x85CC5C0", VA = "0x1885CDBC0", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class WQEIKOTDQXD<a, b> : KHJXOJJZUWY<(a, b)>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x85CF610", Offset = "0x85CE010", VA = "0x1885CF610", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x85CF120", Offset = "0x85CDB20", VA = "0x1885CF120", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class WPZBNHZGHLU<a, b, c> : KHJXOJJZUWY<(a, b, c)>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x85CEA20", Offset = "0x85CD420", VA = "0x1885CEA20", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x85CE3B0", Offset = "0x85CCDB0", VA = "0x1885CE3B0", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class WQOWFCGYJTV<a, b, c, d> : KHJXOJJZUWY<(a, b, c, d)>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x85D17D0", Offset = "0x85D01D0", VA = "0x1885D17D0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x85D0F90", Offset = "0x85CF990", VA = "0x1885D0F90", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class WQJPHVNBAIM<a, b, c, d, e> : KHJXOJJZUWY<(a, b, c, d, e)>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x85D0520", Offset = "0x85CEF20", VA = "0x1885D0520", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x85CFB60", Offset = "0x85CE560", VA = "0x1885CFB60", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class WQZJZPUTCQN<a, b, c, d, e, f> : KHJXOJJZUWY<(a, b, c, d, e, f)>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x85D4930", Offset = "0x85D3330", VA = "0x1885D4930", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x85D3D60", Offset = "0x85D2760", VA = "0x1885D3D60", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class WQUDCJAVTFE<a, b, c, d, e, f, g> : KHJXOJJZUWY<(a, b, c, d, e, f, g)>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x85D2E10", Offset = "0x85D1810", VA = "0x1885D2E10", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x85D2090", Offset = "0x85D0A90", VA = "0x1885D2090", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class WODRLZCEANR<a, b, c, d, e, f, g, h> : KHJXOJJZUWY<ValueTuple<a, b, c, d, e, f, g, h>>, YRUEVOCAGJF where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] UZBSBIUHKZK;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly LLXCYHWQXJW HOSXSVCMGYS;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x85CC380", Offset = "0x85CAD80", VA = "0x1885CC380", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x85CB450", Offset = "0x85C9E50", VA = "0x1885CB450", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class JHDEQULRZOQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] JHLCSXFJLDC;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly LLXCYHWQXJW VJYDZBIARMB;

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7150", Offset = "0xA3F5B50", VA = "0x18A3F7150")]
		static JHDEQULRZOQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class XWAESHVGMEO
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] NRACYPJSGZH;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly LLXCYHWQXJW LSYXOLOVLEQ;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xA40B890", Offset = "0xA40A290", VA = "0x18A40B890")]
		static XWAESHVGMEO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class PMZNNCWSZBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] NWBFQKCBDQY;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly LLXCYHWQXJW WJKWANGTDZD;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] NWRAIEJTFYZ;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly LLXCYHWQXJW WIVBISZBBRC;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] NWLTKXPVWNQ;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly LLXCYHWQXJW WJAIFZSYLCL;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] NVLKYPUJBIX;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly LLXCYHWQXJW WKAQSHOLGHE;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] NVGEBJALRXO;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly LLXCYHWQXJW WKFXPOIIPSN;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] NVVYTDIDUFP;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly LLXCYHWQXJW WJQCXUAQNKM;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] NVQRVWOGKUG;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly LLXCYHWQXJW WJVJVAUNWVV;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] NXWPRSZDKPB;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly LLXCYHWQXJW WHPLZEJQXBA;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xA401ED0", Offset = "0xA4008D0", VA = "0x18A401ED0")]
		static PMZNNCWSZBE()
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
