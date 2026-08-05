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
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E10", Offset = "0xCF4210", VA = "0x180CF4E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0x4104640", Offset = "0x4103A40", VA = "0x184104640")]
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
		[Cpp2IlInjected.Address(RVA = "0x3365870", Offset = "0x3364C70", VA = "0x183365870")]
		public static KHJXOJJZUWY<a> HQIIMSREBOB<a>(this BBOFZKRFCTL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA3022D0", Offset = "0xA3016D0", VA = "0x18A3022D0")]
		public static object CASZIFWNLNP(this BBOFZKRFCTL a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA304B40", Offset = "0xA303F40", VA = "0x18A304B40")]
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
				[Cpp2IlInjected.Address(RVA = "0xA3116D0", Offset = "0xA310AD0", VA = "0x18A3116D0")]
				public QKTIFDDASGU(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xA3115B0", Offset = "0xA3109B0", VA = "0x18A3115B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA312450", Offset = "0xA311850", VA = "0x18A312450")]
			public void TCOTXYHTDFM([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA312310", Offset = "0xA311710", VA = "0x18A312310")]
			public void TCOTXYHTDFM(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA311E40", Offset = "0xA311240", VA = "0x18A311E40")]
			public ReadOnlySequence<byte> MKGNZJAONTP()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA311F70", Offset = "0xA311370", VA = "0x18A311F70")]
			private void RIOHSKTYUJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA312120", Offset = "0xA311520", VA = "0x18A312120")]
			private void SAYJAXKESST([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA30AD00", Offset = "0xA30A100", VA = "0x18A30AD00")]
		public JsonReader([In] ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA30AB90", Offset = "0xA309F90", VA = "0x18A30AB90")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA308910", Offset = "0xA307D10", VA = "0x18A308910")]
		private JsonParsingException HVHGPVKNFMT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA307C20", Offset = "0xA307020", VA = "0x18A307C20")]
		private JsonParsingException BQJLSBCCAPQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA309450", Offset = "0xA308850", VA = "0x18A309450")]
		public JsonToken KGWWVGEFKGK()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA307FC0", Offset = "0xA3073C0", VA = "0x18A307FC0")]
		public void DYXAZNKYLRC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA30A4B0", Offset = "0xA3098B0", VA = "0x18A30A4B0")]
		private bool TGWPCYGAPRM(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA30A510", Offset = "0xA309910", VA = "0x18A30A510")]
		private bool TGWPCYGAPRM(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA309140", Offset = "0xA308540", VA = "0x18A309140")]
		private void ITGCKEYFRCP(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA309D50", Offset = "0xA309150", VA = "0x18A309D50")]
		public bool NQZOYZLBVYH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA30AAD0", Offset = "0xA309ED0", VA = "0x18A30AAD0")]
		public void XMVNLNNUDKR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA309660", Offset = "0xA308A60", VA = "0x18A309660")]
		public bool KIALSIHKSVC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA309240", Offset = "0xA308640", VA = "0x18A309240")]
		public void JEPAKFSPAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA3097E0", Offset = "0xA308BE0", VA = "0x18A3097E0")]
		public void MDUDCQEMKXT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA3091F0", Offset = "0xA3085F0", VA = "0x18A3091F0")]
		public bool JDFLXXNULGU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA308430", Offset = "0xA307830", VA = "0x18A308430")]
		public void FEBUAPAFVVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA3097D0", Offset = "0xA308BD0", VA = "0x18A3097D0")]
		public void LWVIYVJMDCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA308440", Offset = "0xA307840", VA = "0x18A308440")]
		public bool FMHROJPDSLR(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA30A230", Offset = "0xA309630", VA = "0x18A30A230")]
		public bool RVWEBFDYFCW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA309E10", Offset = "0xA309210", VA = "0x18A309E10")]
		public bool OQHSDFNMCTZ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA30A9F0", Offset = "0xA309DF0", VA = "0x18A30A9F0")]
		public bool VPPCUQEVJVU(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA308C60", Offset = "0xA308060", VA = "0x18A308C60")]
		private ReadOnlySequence<byte> IKIKTBNAUKL()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA3097F0", Offset = "0xA308BF0", VA = "0x18A3097F0")]
		private ReadOnlySequence<byte> MNBZDLABGXA()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA307D30", Offset = "0xA307130", VA = "0x18A307D30")]
		private void DCOMRGBMYHQ(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA309250", Offset = "0xA308650", VA = "0x18A309250")]
		private void JKGWKJBJTHX(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA309A60", Offset = "0xA308E60", VA = "0x18A309A60")]
		private void MNUWSGSKMDO(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA30A830", Offset = "0xA309C30", VA = "0x18A30A830")]
		private void UTMEMHPDHYT(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA301630", Offset = "0xA300A30", VA = "0x18A301630")]
		private static int YGOKVREKVCS(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA30A160", Offset = "0xA309560", VA = "0x18A30A160")]
		public ReadOnlySequence<byte> QZCFTBAHOVM()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA30A310", Offset = "0xA309710", VA = "0x18A30A310")]
		public string SARWKHTQHVR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA3088D0", Offset = "0xA307CD0", VA = "0x18A3088D0")]
		public string GKONBEFNHCY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA307B40", Offset = "0xA306F40", VA = "0x18A307B40")]
		public ReadOnlySequence<byte> AWUDVCLUWWC()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA309EA0", Offset = "0xA3092A0", VA = "0x18A309EA0")]
		public ReadOnlySequence<byte> QEQPYTEYWMN()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA30A6E0", Offset = "0xA309AE0", VA = "0x18A30A6E0")]
		public bool UNOBMIKSSXY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA30A570", Offset = "0xA309970", VA = "0x18A30A570")]
		private void TJGQGHLHLFS(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA307C10", Offset = "0xA307010", VA = "0x18A307C10")]
		public void BEYNSYJDNAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA3081F0", Offset = "0xA3075F0", VA = "0x18A3081F0")]
		private void EENENVJIURB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA30A940", Offset = "0xA309D40", VA = "0x18A30A940")]
		public sbyte UXKNHRRFQCJ()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA30A390", Offset = "0xA309790", VA = "0x18A30A390")]
		public short SOGCTMUBASY()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA3084D0", Offset = "0xA3078D0", VA = "0x18A3084D0")]
		public int FMVRJKCWHEO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA3096B0", Offset = "0xA308AB0", VA = "0x18A3096B0")]
		public long KRTCYDFCUXH()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA308580", Offset = "0xA307980", VA = "0x18A308580")]
		public byte FVGXJXOJVLK()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA309720", Offset = "0xA308B20", VA = "0x18A309720")]
		public ushort LTSYWKVBGBD()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA30AAE0", Offset = "0xA309EE0", VA = "0x18A30AAE0")]
		public uint YQSKIGAROZZ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA30A440", Offset = "0xA309840", VA = "0x18A30A440")]
		public ulong SSJMWNMEFKA()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA307F20", Offset = "0xA307320", VA = "0x18A307F20")]
		public float DEYAYOROVAS()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA307AA0", Offset = "0xA306EA0", VA = "0x18A307AA0")]
		public double ACUJHINNUHV()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA309F80", Offset = "0xA309380", VA = "0x18A309F80")]
		public ReadOnlySequence<byte> QFHVIHPQOJC()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA308630", Offset = "0xA307A30", VA = "0x18A308630")]
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
			[Cpp2IlInjected.Address(RVA = "0xFAA170", Offset = "0xFA9570", VA = "0x180FAA170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA307A40", Offset = "0xA306E40", VA = "0x18A307A40")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA3079C0", Offset = "0xA306DC0", VA = "0x18A3079C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA3112D0", Offset = "0xA3106D0", VA = "0x18A3112D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA307680", Offset = "0xA306A80", VA = "0x18A307680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA306CE0", Offset = "0xA3060E0", VA = "0x18A306CE0")]
		public static void NQGGOCCYGFD(BBOFZKRFCTL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3AE04A0", Offset = "0x3ADF8A0", VA = "0x183AE04A0")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0320", Offset = "0x3ADF720", VA = "0x183AE0320")]
		public static byte[] Serialize<T>(T value, BBOFZKRFCTL resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0D20", Offset = "0x3AE0120", VA = "0x183AE0D20")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0BA0", Offset = "0x3ADFFA0", VA = "0x183AE0BA0")]
		public static string ToJsonString<T>(T value, BBOFZKRFCTL resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFD70", Offset = "0x3ADF170", VA = "0x183ADFD70")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFBF0", Offset = "0x3ADEFF0", VA = "0x183ADFBF0")]
		public static T Deserialize<T>(string json, BBOFZKRFCTL resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFF40", Offset = "0x3ADF340", VA = "0x183ADFF40")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3ADFAA0", Offset = "0x3ADEEA0", VA = "0x183ADFAA0")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, BBOFZKRFCTL resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF4A0", Offset = "0x3ADE8A0", VA = "0x183ADF4A0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3ADF2C0", Offset = "0x3ADE6C0", VA = "0x183ADF2C0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, BBOFZKRFCTL resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA3069B0", Offset = "0xA305DB0", VA = "0x18A3069B0")]
		public static byte[] CIIQWQXIYLU(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA306D50", Offset = "0xA306150", VA = "0x18A306D50")]
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
			[Cpp2IlInjected.Address(RVA = "0xF6CAF0", Offset = "0xF6BEF0", VA = "0x180F6CAF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA30C190", Offset = "0xA30B590", VA = "0x18A30C190")]
		public void ZQWHXLDSJZN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA30B920", Offset = "0xA30AD20", VA = "0x18A30B920")]
		public static byte[] IAJYMHXJCVU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA30C070", Offset = "0xA30B470", VA = "0x18A30C070")]
		public static byte[] XAEWUWPRQKW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA30BAF0", Offset = "0xA30AEF0", VA = "0x18A30BAF0")]
		public static byte[] JPKHYMZDOVS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA30B730", Offset = "0xA30AB30", VA = "0x18A30B730")]
		public static byte[] HPIYQUXQDXO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2ABFD80", Offset = "0x2ABF180", VA = "0x182ABFD80")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA30AEA0", Offset = "0xA30A2A0", VA = "0x18A30AEA0")]
		public ArraySegment<byte> AIAQCRDLMMM()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA30BD30", Offset = "0xA30B130", VA = "0x18A30BD30")]
		public byte[] NXARAOZDGDZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA30BF30", Offset = "0xA30B330", VA = "0x18A30BF30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA30BC30", Offset = "0xA30B030", VA = "0x18A30BC30")]
		public void KSSRCICPRRO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA3016F0", Offset = "0xA300AF0", VA = "0x18A3016F0")]
		public void DUHBVEJWTDT(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA30B060", Offset = "0xA30A460", VA = "0x18A30B060")]
		public void DUHBVEJWTDT(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA30BEF0", Offset = "0xA30B2F0", VA = "0x18A30BEF0")]
		public void SZLCZSFYUPJ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x50155E0", Offset = "0x50149E0", VA = "0x1850155E0")]
		public void CVVKTHGDRUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5015590", Offset = "0x5014990", VA = "0x185015590")]
		public void CBKVIWDKQYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x71E4290", Offset = "0x71E3690", VA = "0x1871E4290")]
		public void JHQVKKTDZKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x531AAE0", Offset = "0x5319EE0", VA = "0x18531AAE0")]
		public void RFDUQDINQGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x50156D0", Offset = "0x5014AD0", VA = "0x1850156D0")]
		public void QQDMFDZSCER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x71E42E0", Offset = "0x71E36E0", VA = "0x1871E42E0")]
		public void VRHHJPGWRFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA30AF40", Offset = "0xA30A340", VA = "0x18A30AF40")]
		public void CGUTRMPFHJJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA30AFE0", Offset = "0xA30A3E0", VA = "0x18A30AFE0")]
		public void CTXKZUUKUNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5015630", Offset = "0x5014A30", VA = "0x185015630")]
		public void OSUMYHCHQMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8BF2A00", Offset = "0x8BF1E00", VA = "0x188BF2A00")]
		public void LPQVPAHYEPF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA30B0C0", Offset = "0xA30A4C0", VA = "0x18A30B0C0")]
		public void DZUBEJNOEKB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA30BC40", Offset = "0xA30B040", VA = "0x18A30BC40")]
		public void MCLKLRKFKOQ(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA30B6C0", Offset = "0xA30AAC0", VA = "0x18A30B6C0")]
		public void HHKUVERYKOH(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA30C000", Offset = "0xA30B400", VA = "0x18A30C000")]
		public void WKWVGBKUFTM(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA30BA80", Offset = "0xA30AE80", VA = "0x18A30BA80")]
		public void JFUTZVPFJIU(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA30BEC0", Offset = "0xA30B2C0", VA = "0x18A30BEC0")]
		public void PLLFQXSBURF(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA30BCC0", Offset = "0xA30B0C0", VA = "0x18A30BCC0")]
		public void MWGHCPLEVUA(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA30BF90", Offset = "0xA30B390", VA = "0x18A30BF90")]
		public void WCXQHKCVWPX(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA30B8B0", Offset = "0xA30ACB0", VA = "0x18A30B8B0")]
		public void HZZDFXJLTSL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA30B030", Offset = "0xA30A430", VA = "0x18A30B030")]
		public void DBOEHMTYVYU(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA30B140", Offset = "0xA30A540", VA = "0x18A30B140")]
		public void GGIJYDDSQHW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA30BA00", Offset = "0xA30AE00", VA = "0x18A30BA00")]
		private static bool IPUCPBRPVBE(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA30BC10", Offset = "0xA30B010", VA = "0x18A30BC10")]
		private static byte KHTATVSLXOM(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA301750", Offset = "0xA300B50", VA = "0x18A301750")]
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
			[Cpp2IlInjected.Address(RVA = "0x68A50C0", Offset = "0x68A44C0", VA = "0x1868A50C0")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private HKQRLZIBHFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68AA9B0", Offset = "0x68A9DB0", VA = "0x1868AA9B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA312A80", Offset = "0xA311E80", VA = "0x18A312A80")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private RENMSBEILMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68A5CF0", Offset = "0x68A50F0", VA = "0x1868A5CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private AJCJMVQCKWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA301DD0", Offset = "0xA3011D0", VA = "0x18A301DD0")]
		public static void GZVUEGYMGMP(params BBOFZKRFCTL[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA301D00", Offset = "0xA301100", VA = "0x18A301D00")]
		public static void GZVUEGYMGMP(params YRUEVOCAGJF[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA301EA0", Offset = "0xA3012A0", VA = "0x18A301EA0")]
		public static void VOFFVOGREAN(YRUEVOCAGJF[] a, BBOFZKRFCTL[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68BD1E0", Offset = "0x68BC5E0", VA = "0x1868BD1E0")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private WASOOZPLRWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA30CA50", Offset = "0xA30BE50", VA = "0x18A30CA50")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA30E650", Offset = "0xA30DA50", VA = "0x18A30E650")]
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
			[Cpp2IlInjected.Address(RVA = "0x68B3930", Offset = "0x68B2D30", VA = "0x1868B3930")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private QYXYFHWHOMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68A9B80", Offset = "0x68A8F80", VA = "0x1868A9B80")]
			static LQYFBAWEVPT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly BBOFZKRFCTL LDHSFMFGGNH;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private ALAVMDPFJPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68B3640", Offset = "0x68B2A40", VA = "0x1868B3640")]
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
				[Cpp2IlInjected.Address(RVA = "0x68A9A30", Offset = "0x68A8E30", VA = "0x1868A9A30")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private PWOJAYBAAYI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68AA3D0", Offset = "0x68A97D0", VA = "0x1868AA3D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x68B7F90", Offset = "0x68B7390", VA = "0x1868B7F90")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private TGWUIDADLVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68B11D0", Offset = "0x68B05D0", VA = "0x1868B11D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x68B0050", Offset = "0x68AF450", VA = "0x1868B0050")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private MPWNZSMBMUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68A4BF0", Offset = "0x68A3FF0", VA = "0x1868A4BF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x68B05E0", Offset = "0x68AF9E0", VA = "0x1868B05E0")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private TZURDYGSXXY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68BFE00", Offset = "0x68BF200", VA = "0x1868BFE00")]
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
				[Cpp2IlInjected.Address(RVA = "0x68B43A0", Offset = "0x68B37A0", VA = "0x1868B43A0")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private OEUZURHVPSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68A4030", Offset = "0x68A3430", VA = "0x1868A4030")]
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
				[Cpp2IlInjected.Address(RVA = "0x68B8F90", Offset = "0x68B8390", VA = "0x1868B8F90")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private MHPEAGJDJSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68B54F0", Offset = "0x68B48F0", VA = "0x1868B54F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x68ACFD0", Offset = "0x68AC3D0", VA = "0x1868ACFD0")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private PTTJWGQWPKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68A95F0", Offset = "0x68A89F0", VA = "0x1868A95F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x68BB980", Offset = "0x68BAD80", VA = "0x1868BB980")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private LVQIUTHWNBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68B44F0", Offset = "0x68B38F0", VA = "0x1868B44F0")]
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
				[Cpp2IlInjected.Address(RVA = "0x68BE4E0", Offset = "0x68BD8E0", VA = "0x1868BE4E0")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private RDWDRJXYYOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68B9FE0", Offset = "0x68B93E0", VA = "0x1868B9FE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x68BDAF0", Offset = "0x68BCEF0", VA = "0x1868BDAF0")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private GIVASOSPEOW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68B6130", Offset = "0x68B5530", VA = "0x1868B6130")]
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
				[Cpp2IlInjected.Address(RVA = "0x68A55D0", Offset = "0x68A49D0", VA = "0x1868A55D0")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private VMFNGIWTSBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x68AAB90", Offset = "0x68A9F90", VA = "0x1868AAB90")]
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
				[Cpp2IlInjected.Address(RVA = "0x68A5900", Offset = "0x68A4D00", VA = "0x1868A5900")]
				static LQYFBAWEVPT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly BBOFZKRFCTL LDHSFMFGGNH;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly BBOFZKRFCTL[] BNEYROEPWAN;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			private BFNHZVHQPTS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		private RJZHEODUPKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x33642C0", Offset = "0x33636C0", VA = "0x1833642C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x74CC7B0", Offset = "0x74CBBB0", VA = "0x1874CC7B0")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x74CC4C0", Offset = "0x74CB8C0", VA = "0x1874CC4C0")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x74CC720", Offset = "0x74CBB20", VA = "0x1874CC720")]
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
		[Cpp2IlInjected.Address(RVA = "0x7ABB750", Offset = "0x7ABAB50", VA = "0x187ABB750")]
		public TSUXYERGCKO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7ABB460", Offset = "0x7ABA860", VA = "0x187ABB460")]
		public a[] VWIOUHTZAER()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7ABB0A0", Offset = "0x7ABA4A0", VA = "0x187ABB0A0")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
				[DebuggerHidden]
				public QWXTRGORGOM(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "7")]
				[DebuggerHidden]
				private void THBUUIJWZTJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xA311B80", Offset = "0xA310F80", VA = "0x18A311B80", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xA311C00", Offset = "0xA311000", VA = "0x18A311C00", Slot = "10")]
				[DebuggerHidden]
				private void TVBXYVYIQIO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xA311AE0", Offset = "0xA310EE0", VA = "0x18A311AE0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<KTOKBYSUUMM> EZUUQHQINNM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0xA311AE0", Offset = "0xA310EE0", VA = "0x18A311AE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA30F550", Offset = "0xA30E950", VA = "0x18A30F550")]
			public KTOKBYSUUMM(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA30EFA0", Offset = "0xA30E3A0", VA = "0x18A30EFA0")]
			public KTOKBYSUUMM Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA30F1A0", Offset = "0xA30E5A0", VA = "0x18A30F1A0")]
			public KTOKBYSUUMM Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA30F2C0", Offset = "0xA30E6C0", VA = "0x18A30F2C0")]
			public KTOKBYSUUMM IIQVQFWAXHE(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA30F230", Offset = "0xA30E630", VA = "0x18A30F230")]
			internal static int DJGBMFVSKXB(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA30F200", Offset = "0xA30E600", VA = "0x18A30F200", Slot = "4")]
			public int CompareTo(KTOKBYSUUMM other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xA30F430", Offset = "0xA30E830", VA = "0x18A30F430")]
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
				[Cpp2IlInjected.Address(RVA = "0xD88E90", Offset = "0xD88290", VA = "0x180D88E90", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA30FB00", Offset = "0xA30EF00", VA = "0x18A30FB00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1D1C970", Offset = "0x1D1BD70", VA = "0x181D1C970")]
			[DebuggerHidden]
			public KXXVPINQEOK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xA30FBF0", Offset = "0xA30EFF0", VA = "0x18A30FBF0", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xA30F6A0", Offset = "0xA30EAA0", VA = "0x18A30F6A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xA30F600", Offset = "0xA30EA00", VA = "0x18A30F600")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA30F650", Offset = "0xA30EA50", VA = "0x18A30F650")]
			private void ALONWGIYSGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA30FD40", Offset = "0xA30F140", VA = "0x18A30FD40", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xA30FB50", Offset = "0xA30EF50", VA = "0x18A30FB50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> WQVDXRBALVK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xA30FB50", Offset = "0xA30EF50", VA = "0x18A30FB50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA311140", Offset = "0xA310540", VA = "0x18A311140")]
		public LLXCYHWQXJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA3108F0", Offset = "0xA30FCF0", VA = "0x18A3108F0")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA310F20", Offset = "0xA310320", VA = "0x18A310F20")]
		public bool RRJZBUUOGPY(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA310E10", Offset = "0xA310210", VA = "0x18A310E10")]
		public bool QSLRHQYVAED([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA311030", Offset = "0xA310430", VA = "0x18A311030", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA310AD0", Offset = "0xA30FED0", VA = "0x18A310AD0")]
		private static void ERSMCNPYSTL(IEnumerable<KTOKBYSUUMM> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA310DB0", Offset = "0xA3101B0", VA = "0x18A310DB0", Slot = "5")]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA310DB0", Offset = "0xA3101B0", VA = "0x18A310DB0", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA3110C0", Offset = "0xA3104C0", VA = "0x18A3110C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA30C260", Offset = "0xA30B660", VA = "0x18A30C260")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA30C410", Offset = "0xA30B810", VA = "0x18A30C410")]
		public static ulong OWVTREWYBXC(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class QRDNFKNJAQT
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA3119A0", Offset = "0xA310DA0", VA = "0x18A3119A0")]
		public static void KSSRCICPRRO(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA311740", Offset = "0xA310B40", VA = "0x18A311740")]
		public static void ILQCZBMXPKM(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA311860", Offset = "0xA310C60", VA = "0x18A311860")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B43D50", Offset = "0x5B43150", VA = "0x185B43D50", Slot = "3")]
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
				[Cpp2IlInjected.Address(RVA = "0xD88E90", Offset = "0xD88290", VA = "0x180D88E90", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A8C90", Offset = "0x64A8090", VA = "0x1864A8C90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
			[DebuggerHidden]
			public WMGWRCLKBRB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x851B720", Offset = "0x851AB20", VA = "0x18851B720", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x5087C00", Offset = "0x5087000", VA = "0x185087C00")]
		public ZDWAONULNYH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5087B10", Offset = "0x5086F10", VA = "0x185087B10")]
		public ZDWAONULNYH(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5076A20", Offset = "0x5075E20", VA = "0x185076A20")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5082590", Offset = "0x5081990", VA = "0x185082590")]
		private bool MVHGDGSGPET(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5086290", Offset = "0x5085690", VA = "0x185086290")]
		public bool RRJZBUUOGPY([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5077FD0", Offset = "0x50773D0", VA = "0x185077FD0")]
		private static ulong KWFBTNXCVGK([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x50794B0", Offset = "0x50788B0", VA = "0x1850794B0")]
		private static ulong KWFBTNXCVGK([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x507B850", Offset = "0x507AC50", VA = "0x18507B850")]
		private static int LCXCHLDGEQC(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5076C30", Offset = "0x5076030", VA = "0x185076C30", Slot = "4")]
		[IteratorStateMachine(typeof(ZDWAONULNYH<>.WMGWRCLKBRB))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5087900", Offset = "0x5086D00", VA = "0x185087900", Slot = "5")]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class UAIPOINAKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4047BF0", Offset = "0x4046FF0", VA = "0x184047BF0")]
		public static Func<a> PAIDSFXSZPK<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4047B30", Offset = "0x4046F30", VA = "0x184047B30")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3055B0", Offset = "0xA3049B0", VA = "0x18A3055B0")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA3055C0", Offset = "0xA3049C0", VA = "0x18A3055C0")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA305430", Offset = "0xA304830", VA = "0x18A305430")]
		private static byte YKKZUNDNKRP(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA301250", Offset = "0xA300650", VA = "0x18A301250")]
		private static byte NCAIVPTCWPD(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA304C30", Offset = "0xA304030", VA = "0x18A304C30")]
		public void SISZBYWUTCR(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class ELYJFIZRJSZ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA304080", Offset = "0xA303480", VA = "0x18A304080")]
		public static bool JXHCVPSWYYH(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA304200", Offset = "0xA303600", VA = "0x18A304200")]
		public static bool MVOBISAOSRI(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA304550", Offset = "0xA303950", VA = "0x18A304550")]
		public static sbyte UXKNHRRFQCJ([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA304270", Offset = "0xA303670", VA = "0x18A304270")]
		public static short SOGCTMUBASY([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA303FC0", Offset = "0xA3033C0", VA = "0x18A303FC0")]
		public static int FMVRJKCWHEO([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA3040F0", Offset = "0xA3034F0", VA = "0x18A3040F0")]
		public static long KRTCYDFCUXH([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA303D40", Offset = "0xA303140", VA = "0x18A303D40")]
		public static bool DCHZHZQHGNM(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA304020", Offset = "0xA303420", VA = "0x18A304020")]
		public static byte FVGXJXOJVLK([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA3041A0", Offset = "0xA3035A0", VA = "0x18A3041A0")]
		public static ushort LTSYWKVBGBD([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA304A40", Offset = "0xA303E40", VA = "0x18A304A40")]
		public static uint YQSKIGAROZZ([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA3042D0", Offset = "0xA3036D0", VA = "0x18A3042D0")]
		public static ulong SSJMWNMEFKA([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA3048F0", Offset = "0xA303CF0", VA = "0x18A3048F0")]
		public static bool YGYKXZBOUYZ(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA304720", Offset = "0xA303B20", VA = "0x18A304720")]
		public static bool XHZIVJBTAYJ(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA304610", Offset = "0xA303A10", VA = "0x18A304610")]
		public static bool WWJLBVYODYJ(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA304AA0", Offset = "0xA303EA0", VA = "0x18A304AA0")]
		public static bool ZGFTHFIDGYP(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA303ED0", Offset = "0xA3032D0", VA = "0x18A303ED0")]
		public static float DEYAYOROVAS([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA3045B0", Offset = "0xA3039B0", VA = "0x18A3045B0")]
		public static bool WCWMXVRCHEX(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA303C50", Offset = "0xA303050", VA = "0x18A303C50")]
		public static double ACUJHINNUHV([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA304090", Offset = "0xA303490", VA = "0x18A304090")]
		public static bool KOSJSIIKMQO(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA3009A0", Offset = "0xA2FFDA0", VA = "0x18A3009A0")]
		public static int PLLFQXSBURF(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA2FFF30", Offset = "0xA2FF330", VA = "0x18A2FFF30")]
		public static int DBOEHMTYVYU(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA304380", Offset = "0xA303780", VA = "0x18A304380")]
		public static bool UNOBMIKSSXY([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class AGTXBWQPUUR
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA301C50", Offset = "0xA301050", VA = "0x18A301C50")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3039B0", Offset = "0xA302DB0", VA = "0x18A3039B0")]
		public static void UZHDKJFYOEL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA303940", Offset = "0xA302D40", VA = "0x18A303940")]
		public static void UZBWNCMBETC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA303A90", Offset = "0xA302E90", VA = "0x18A303A90")]
		public static void UZRREWTTHBD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA303A20", Offset = "0xA302E20", VA = "0x18A303A20")]
		public static void UZMKHPZVXPU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA3038D0", Offset = "0xA302CD0", VA = "0x18A3038D0")]
		public static void UYMBVIEJCLB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA303860", Offset = "0xA302C60", VA = "0x18A303860")]
		public static void UYGUYBKLSZS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA303590", Offset = "0xA302990", VA = "0x18A303590")]
		public static void SDOGUHGLGJS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA303600", Offset = "0xA302A00", VA = "0x18A303600")]
		public static void SDTNROAIPVB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA303670", Offset = "0xA302A70", VA = "0x18A303670")]
		public static void SDYUOUUFZGK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA3036E0", Offset = "0xA302AE0", VA = "0x18A3036E0")]
		public static void SEEBMBODIRT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA303390", Offset = "0xA302790", VA = "0x18A303390")]
		public static void SCTFFGEVUQI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA303410", Offset = "0xA302810", VA = "0x18A303410")]
		public static void SCYMCMYTEBR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA303490", Offset = "0xA302890", VA = "0x18A303490")]
		public static void SDDSZTSQNNA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA303510", Offset = "0xA302910", VA = "0x18A303510")]
		public static void SDIZXAMNWYJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA303760", Offset = "0xA302B60", VA = "0x18A303760")]
		public static void SFEJYJJQDWM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA3037E0", Offset = "0xA302BE0", VA = "0x18A3037E0")]
		public static void SFJQVQDNNHV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA303210", Offset = "0xA302610", VA = "0x18A303210")]
		public static void NFNVQKETBMT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA303190", Offset = "0xA302590", VA = "0x18A303190")]
		public static void NFIOTDKVSBK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA303310", Offset = "0xA302710", VA = "0x18A303310")]
		public static void NFYJKXSNUJL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA303290", Offset = "0xA302690", VA = "0x18A303290")]
		public static void NFTCNQYQKYC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA302FF0", Offset = "0xA3023F0", VA = "0x18A302FF0")]
		public static void NESUBJDDPTJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA302F60", Offset = "0xA302360", VA = "0x18A302F60")]
		public static void NENNECJGGIA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA303100", Offset = "0xA302500", VA = "0x18A303100")]
		public static void NFDHVWQYIQB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA303070", Offset = "0xA302470", VA = "0x18A303070")]
		public static void NEYAYPXAZES(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA302ED0", Offset = "0xA3022D0", VA = "0x18A302ED0")]
		public static void NDXSMIBODZZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA302E40", Offset = "0xA302240", VA = "0x18A302E40")]
		public static void NDSLPBHQUOQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA302D20", Offset = "0xA302120", VA = "0x18A302D20")]
		public static void GEWQRRWQLUK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA302DB0", Offset = "0xA3021B0", VA = "0x18A302DB0")]
		public static void GFBXOYQNVFT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA303B00", Offset = "0xA302F00", VA = "0x18A303B00")]
		public static void UZWYCDNQQMM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA303BE0", Offset = "0xA302FE0", VA = "0x18A303BE0")]
		public static void VAMSTXVISUN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA303B70", Offset = "0xA302F70", VA = "0x18A303B70")]
		public static void VAHLWRBLJJE(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class KYSWEBGIXWR
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA310880", Offset = "0xA30FC80", VA = "0x18A310880")]
		public static void UYMBVIEJCLB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA310810", Offset = "0xA30FC10", VA = "0x18A310810")]
		public static void UYGUYBKLSZS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA310550", Offset = "0xA30F950", VA = "0x18A310550")]
		public static void SDOGUHGLGJS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA3105C0", Offset = "0xA30F9C0", VA = "0x18A3105C0")]
		public static void SDTNROAIPVB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA310630", Offset = "0xA30FA30", VA = "0x18A310630")]
		public static void SDYUOUUFZGK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA3106A0", Offset = "0xA30FAA0", VA = "0x18A3106A0")]
		public static void SEEBMBODIRT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA310380", Offset = "0xA30F780", VA = "0x18A310380")]
		public static void SCTFFGEVUQI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA3103F0", Offset = "0xA30F7F0", VA = "0x18A3103F0")]
		public static void SCYMCMYTEBR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA310460", Offset = "0xA30F860", VA = "0x18A310460")]
		public static void SDDSZTSQNNA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA3104D0", Offset = "0xA30F8D0", VA = "0x18A3104D0")]
		public static void SDIZXAMNWYJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA310710", Offset = "0xA30FB10", VA = "0x18A310710")]
		public static void SFEJYJJQDWM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA310790", Offset = "0xA30FB90", VA = "0x18A310790")]
		public static void SFJQVQDNNHV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA310200", Offset = "0xA30F600", VA = "0x18A310200")]
		public static void NFNVQKETBMT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA310180", Offset = "0xA30F580", VA = "0x18A310180")]
		public static void NFIOTDKVSBK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA310300", Offset = "0xA30F700", VA = "0x18A310300")]
		public static void NFYJKXSNUJL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA310280", Offset = "0xA30F680", VA = "0x18A310280")]
		public static void NFTCNQYQKYC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA310000", Offset = "0xA30F400", VA = "0x18A310000")]
		public static void NESUBJDDPTJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA30FF80", Offset = "0xA30F380", VA = "0x18A30FF80")]
		public static void NENNECJGGIA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA310100", Offset = "0xA30F500", VA = "0x18A310100")]
		public static void NFDHVWQYIQB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA310080", Offset = "0xA30F480", VA = "0x18A310080")]
		public static void NEYAYPXAZES(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA30FF00", Offset = "0xA30F300", VA = "0x18A30FF00")]
		public static void NDXSMIBODZZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA30FE80", Offset = "0xA30F280", VA = "0x18A30FE80")]
		public static void NDSLPBHQUOQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA30FD80", Offset = "0xA30F180", VA = "0x18A30FD80")]
		public static void GEWQRRWQLUK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA30FE00", Offset = "0xA30F200", VA = "0x18A30FE00")]
		public static void GFBXOYQNVFT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA303B00", Offset = "0xA302F00", VA = "0x18A303B00")]
		public static void UZWYCDNQQMM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA303BE0", Offset = "0xA302FE0", VA = "0x18A303BE0")]
		public static void VAMSTXVISUN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA303B70", Offset = "0xA302F70", VA = "0x18A303B70")]
		public static void VAHLWRBLJJE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA3039B0", Offset = "0xA302DB0", VA = "0x18A3039B0")]
		public static void UZHDKJFYOEL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA303940", Offset = "0xA302D40", VA = "0x18A303940")]
		public static void UZBWNCMBETC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA303A90", Offset = "0xA302E90", VA = "0x18A303A90")]
		public static void UZRREWTTHBD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA303A20", Offset = "0xA302E20", VA = "0x18A303A20")]
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
		[Cpp2IlInjected.Address(RVA = "0xA31EC20", Offset = "0xA31E020", VA = "0x18A31EC20")]
		public static void DUHBVEJWTDT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA320620", Offset = "0xA31FA20", VA = "0x18A320620")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B6A840", Offset = "0x2B69C40", VA = "0x182B6A840")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA317B30", Offset = "0xA316F30", VA = "0x18A317B30")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA317A00", Offset = "0xA316E00", VA = "0x18A317A00")]
		public static DiyFp GEWOYZMWCXE(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA317AA0", Offset = "0xA316EA0", VA = "0x18A317AA0")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA317B40", Offset = "0xA316F40", VA = "0x18A317B40")]
		public static DiyFp UPMWFXZFEPG(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA317A60", Offset = "0xA316E60", VA = "0x18A317A60")]
		public void IOOYXXCNPYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA317A10", Offset = "0xA316E10", VA = "0x18A317A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xDACAB0", Offset = "0xDABEB0", VA = "0x180DACAB0")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA3016F0", Offset = "0xA300AF0", VA = "0x18A3016F0")]
		public void EZQCJVJHPHW(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA329CE0", Offset = "0xA3290E0", VA = "0x18A329CE0")]
		public void KMWNNDJTKMQ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA329C60", Offset = "0xA329060", VA = "0x18A329C60")]
		public void CGOCGTAYGIA(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA329BC0", Offset = "0xA328FC0", VA = "0x18A329BC0")]
		public void CGOCGTAYGIA(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA329E60", Offset = "0xA329260", VA = "0x18A329E60")]
		public void WGPIKZKHFSW(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA329D60", Offset = "0xA329160", VA = "0x18A329D60")]
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
		[Cpp2IlInjected.Address(RVA = "0xA320E50", Offset = "0xA320250", VA = "0x18A320E50")]
		private static byte[] NCMNEFUTDRQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA321630", Offset = "0xA320A30", VA = "0x18A321630")]
		private static byte[] TVUUEMVBDNY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA321510", Offset = "0xA320910", VA = "0x18A321510")]
		public static int OTSNVORVUSV(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA3213F0", Offset = "0xA3207F0", VA = "0x18A3213F0")]
		public static int OTSNVORVUSV(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA320C70", Offset = "0xA320070", VA = "0x18A320C70")]
		private static bool FIAKZJCNVGT(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA320D60", Offset = "0xA320160", VA = "0x18A320D60")]
		private static void LRUYLJXSXRJ(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA3218D0", Offset = "0xA320CD0", VA = "0x18A3218D0")]
		private static bool VMPFKUPTRJZ(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3221D0", Offset = "0xA3215D0", VA = "0x18A3221D0")]
		private static bool ZGTYMEMUHLV(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA3220D0", Offset = "0xA3214D0", VA = "0x18A3220D0")]
		private static bool ZAOPDBLAOUA(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA321710", Offset = "0xA320B10", VA = "0x18A321710")]
		private static bool UIHDEUEAMQR(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA320F20", Offset = "0xA320320", VA = "0x18A320F20")]
		private static bool OPYFVBKAOFO(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA3208E0", Offset = "0xA31FCE0", VA = "0x18A3208E0")]
		private static void ECTBSMSWGSY(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA321C90", Offset = "0xA321090", VA = "0x18A321C90")]
		private static void YOWBXOYZOQU(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA3206F0", Offset = "0xA31FAF0", VA = "0x18A3206F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA318200", Offset = "0xA317600", VA = "0x18A318200")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA318160", Offset = "0xA317560", VA = "0x18A318160")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA317EE0", Offset = "0xA3172E0", VA = "0x18A317EE0")]
		public DiyFp JQWGCZTFCLA()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA317E30", Offset = "0xA317230", VA = "0x18A317E30")]
		public DiyFp GOMXIVWVCND()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xED9420", Offset = "0xED8820", VA = "0x180ED9420")]
		public ulong KLUCQBEFSNC()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA317FC0", Offset = "0xA3173C0", VA = "0x18A317FC0")]
		public double OXRMXTUUBDE()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA318070", Offset = "0xA317470", VA = "0x18A318070")]
		public double RVOVWIHYVVQ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA317EB0", Offset = "0xA3172B0", VA = "0x18A317EB0")]
		public int JAPQTRVEXWR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA318040", Offset = "0xA317440", VA = "0x18A318040")]
		public ulong QATHMRLQLEF()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA318140", Offset = "0xA317540", VA = "0x18A318140")]
		public bool VPHWQTGFTVE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA317E10", Offset = "0xA317210", VA = "0x18A317E10")]
		public bool EYLPGFZJXBD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA317BE0", Offset = "0xA316FE0", VA = "0x18A317BE0")]
		public bool BJLPOEFEHNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xA317DE0", Offset = "0xA3171E0", VA = "0x18A317DE0")]
		public bool ELZNREJGLHE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA317FA0", Offset = "0xA3173A0", VA = "0x18A317FA0")]
		public int NGCBRDSWDRN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA317C10", Offset = "0xA317010", VA = "0x18A317C10")]
		public void CABHTGMQFRT([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA317F50", Offset = "0xA317350", VA = "0x18A317F50")]
		public bool LQCHFCOZGET()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x408B830", Offset = "0x408AC30", VA = "0x18408B830")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA318120", Offset = "0xA317520", VA = "0x18A318120")]
		public static int UZLWTNYVNQO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA318110", Offset = "0xA317510", VA = "0x18A318110")]
		public static double SUPKQJTPMUW()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA317D50", Offset = "0xA317150", VA = "0x18A317D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x18651A0", Offset = "0x18645A0", VA = "0x1818651A0")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA329AF0", Offset = "0xA328EF0", VA = "0x18A329AF0")]
		public DiyFp JQWGCZTFCLA()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xF6C9A0", Offset = "0xF6BDA0", VA = "0x180F6C9A0")]
		public uint SHMAWJROMPJ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA329AD0", Offset = "0xA328ED0", VA = "0x18A329AD0")]
		public int JAPQTRVEXWR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA329B90", Offset = "0xA328F90", VA = "0x18A329B90")]
		public uint QATHMRLQLEF()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA329BB0", Offset = "0xA328FB0", VA = "0x18A329BB0")]
		public bool VPHWQTGFTVE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA3299A0", Offset = "0xA328DA0", VA = "0x18A3299A0")]
		public void CABHTGMQFRT([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA329B50", Offset = "0xA328F50", VA = "0x18A329B50")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3176C0", Offset = "0xA316AC0", VA = "0x18A3176C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA31D190", Offset = "0xA31C590", VA = "0x18A31D190")]
		public static void QCYHUXCQNBV(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA31D0C0", Offset = "0xA31C4C0", VA = "0x18A31D0C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA32D230", Offset = "0xA32C630", VA = "0x18A32D230")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4E5E4B0", Offset = "0x4E5D8B0", VA = "0x184E5E4B0")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D9D530", Offset = "0x2D9C930", VA = "0x182D9D530")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA32D1D0", Offset = "0xA32C5D0", VA = "0x18A32D1D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA31AE00", Offset = "0xA31A200", VA = "0x18A31AE00")]
		private static byte[] MFRCIMMELSV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA31B2D0", Offset = "0xA31A6D0", VA = "0x18A31B2D0")]
		private static Vector QSKQKRNVUYP(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA31AB50", Offset = "0xA319F50", VA = "0x18A31AB50")]
		private static Vector GDVVHNMQEVL(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA31AC30", Offset = "0xA31A030", VA = "0x18A31AC30")]
		private static void HJEGANADNEY(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA31B540", Offset = "0xA31A940", VA = "0x18A31B540")]
		private static void TQQMWMKIISB(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA31AAC0", Offset = "0xA319EC0", VA = "0x18A31AAC0")]
		private static ulong FZPOBRNXXAU(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA31ACC0", Offset = "0xA31A0C0", VA = "0x18A31ACC0")]
		private static void JPZEPDZYYTE(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA31A5F0", Offset = "0xA3199F0", VA = "0x18A31A5F0")]
		private static bool DXRGUQMLKIZ(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA31B3B0", Offset = "0xA31A7B0", VA = "0x18A31B3B0")]
		private static DiyFp THCLBLNGMJE(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA31B830", Offset = "0xA31AC30", VA = "0x18A31B830")]
		private static bool UKVUOTHNBCY(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA31A9A0", Offset = "0xA319DA0", VA = "0x18A31A9A0")]
		private static bool FYDPWRXUKCU(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA31AEE0", Offset = "0xA31A2E0", VA = "0x18A31AEE0")]
		public static double? OSMLRNYUKDO(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA31B000", Offset = "0xA31A400", VA = "0x18A31B000")]
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
		[Cpp2IlInjected.Address(RVA = "0xA327E70", Offset = "0xA327270", VA = "0x18A327E70")]
		private static byte[] AIAQCRDLMMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA3295D0", Offset = "0xA3289D0", VA = "0x18A3295D0")]
		public static bool WCWMXVRCHEX(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA328210", Offset = "0xA327610", VA = "0x18A328210")]
		public static bool KOSJSIIKMQO(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA3283C0", Offset = "0xA3277C0", VA = "0x18A3283C0")]
		private static bool SUIPLEGDZXB(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA327F50", Offset = "0xA327350", VA = "0x18A327F50")]
		private static bool DGHAQWVRHNI(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA3294F0", Offset = "0xA3288F0", VA = "0x18A3294F0")]
		private static bool VNLPJFCLAZZ(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA328350", Offset = "0xA327750", VA = "0x18A328350")]
		private static bool LOQMLLBPKAJ(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA3294D0", Offset = "0xA3288D0", VA = "0x18A3294D0")]
		private static double UFEAKEUMOHC(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA3284F0", Offset = "0xA3278F0", VA = "0x18A3284F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x195C0C0", Offset = "0x195B4C0", VA = "0x18195C0C0")]
		public FHMROXAOWBW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
		public FHMROXAOWBW(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6277530", Offset = "0x6276930", VA = "0x186277530", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6277200", Offset = "0x6276600", VA = "0x186277200", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x746C1D0", Offset = "0x746B5D0", VA = "0x18746C1D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x746BD90", Offset = "0x746B190", VA = "0x18746BD90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x195C0C0", Offset = "0x195B4C0", VA = "0x18195C0C0")]
		public QPPRWJSTSGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xD01070", Offset = "0xD00470", VA = "0x180D01070")]
		public QPPRWJSTSGL(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x766D5D0", Offset = "0x766C9D0", VA = "0x18766D5D0", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7669EA0", Offset = "0x76692A0", VA = "0x187669EA0", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class RBUTSSSAXGB<a, b, c, d> : KHJXOJJZUWY<d>, YRUEVOCAGJF where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x769E890", Offset = "0x769DC90", VA = "0x18769E890", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x769D610", Offset = "0x769CA10", VA = "0x18769D610", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		protected RBUTSSSAXGB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class RCAAPZLYGRK<a, b, c> : RBUTSSSAXGB<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x769EE60", Offset = "0x769E260", VA = "0x18769EE60", Slot = "6")]
		protected override IEnumerator<a> WLUAXTUJLJD(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		protected RCAAPZLYGRK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class RCFHNGFVQCT<a, b> : RCAAPZLYGRK<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD59C30", Offset = "0xD59030", VA = "0x180D59C30", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class FSEAKJQLBEF<a, b> : RCFHNGFVQCT<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x627E120", Offset = "0x627D520", VA = "0x18627E120", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x627DFC0", Offset = "0x627D3C0", VA = "0x18627DFC0", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class SCYEZIXIGTK<a> : RBUTSSSAXGB<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7926A70", Offset = "0x7925E70", VA = "0x187926A70", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD59C30", Offset = "0xD59030", VA = "0x180D59C30", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7469990", Offset = "0x7468D90", VA = "0x187469990", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x56A2950", Offset = "0x56A1D50", VA = "0x1856A2950", Slot = "6")]
		protected override LinkedList<a>.Enumerator WLUAXTUJLJD(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class BNEGNWZBOBD<a> : RBUTSSSAXGB<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4E863E0", Offset = "0x4E857E0", VA = "0x184E863E0", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4E864C0", Offset = "0x4E858C0", VA = "0x184E864C0", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4E86520", Offset = "0x4E85920", VA = "0x184E86520", Slot = "6")]
		protected override Queue<a>.Enumerator WLUAXTUJLJD(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xD59C30", Offset = "0xD59030", VA = "0x180D59C30", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class OIHZYMDVMFJ<a> : RBUTSSSAXGB<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x508DEA0", Offset = "0x508D2A0", VA = "0x18508DEA0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x508E0D0", Offset = "0x508D4D0", VA = "0x18508E0D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7347840", Offset = "0x7346C40", VA = "0x187347840", Slot = "6")]
		protected override Stack<a>.Enumerator WLUAXTUJLJD(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x73476E0", Offset = "0x7346AE0", VA = "0x1873476E0", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class SVGULIRGKXR<a> : RBUTSSSAXGB<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7942670", Offset = "0x7941A70", VA = "0x187942670", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xD59C30", Offset = "0xD59030", VA = "0x180D59C30", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x79426B0", Offset = "0x7941AB0", VA = "0x1879426B0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7942710", Offset = "0x7941B10", VA = "0x187942710", Slot = "6")]
		protected override HashSet<a>.Enumerator WLUAXTUJLJD(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x730BE80", Offset = "0x730B280", VA = "0x18730BE80")]
		public SVGULIRGKXR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class SYAFVOJNFMR<a> : RCAAPZLYGRK<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x508DEA0", Offset = "0x508D2A0", VA = "0x18508DEA0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7945BF0", Offset = "0x7944FF0", VA = "0x187945BF0", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7945C80", Offset = "0x7945080", VA = "0x187945C80", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class LKHRWTRPYDA<a> : RCAAPZLYGRK<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x4E863E0", Offset = "0x4E857E0", VA = "0x184E863E0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x4E864C0", Offset = "0x4E858C0", VA = "0x184E864C0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xD59C30", Offset = "0xD59030", VA = "0x180D59C30", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class WNLUVZUUKNM<a> : RCAAPZLYGRK<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x4E863E0", Offset = "0x4E857E0", VA = "0x184E863E0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x4E864C0", Offset = "0x4E858C0", VA = "0x184E864C0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xD59C30", Offset = "0xD59030", VA = "0x180D59C30", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class GLTJRWLLDUA<a> : RCAAPZLYGRK<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x636A710", Offset = "0x6369B10", VA = "0x18636A710", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x508E0D0", Offset = "0x508D4D0", VA = "0x18508E0D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5B2BF30", Offset = "0x5B2B330", VA = "0x185B2BF30", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5B2BFA0", Offset = "0x5B2B3A0", VA = "0x185B2BFA0")]
		public GLTJRWLLDUA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class DCZPWHIDGXW<a, b> : KHJXOJJZUWY<IGrouping<a, b>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x532FA20", Offset = "0x532EE20", VA = "0x18532FA20", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x532F6E0", Offset = "0x532EAE0", VA = "0x18532F6E0", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class JMDALHTNOPX<a, b> : KHJXOJJZUWY<ILookup<a, b>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6641A70", Offset = "0x6640E70", VA = "0x186641A70", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6641720", Offset = "0x6640B20", VA = "0x186641720", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E5BE00", Offset = "0x4E5B200", VA = "0x184E5BE00", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x71B9630", Offset = "0x71B8A30", VA = "0x1871B9630")]
		public NAKBCMCLLXL(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x71B95C0", Offset = "0x71B89C0", VA = "0x1871B95C0", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6627340", Offset = "0x6626740", VA = "0x186627340", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x74B9030", Offset = "0x74B8430", VA = "0x1874B9030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public TLDLLFVOUDA(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA7560", Offset = "0x7AA6960", VA = "0x187AA7560", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA7650", Offset = "0x7AA6A50", VA = "0x187AA7650", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7AA7650", Offset = "0x7AA6A50", VA = "0x187AA7650", Slot = "7")]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class EPZUECZXOBV<a> : KHJXOJJZUWY<a>, YRUEVOCAGJF where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5B20", Offset = "0x5AD4F20", VA = "0x185AD5B20", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5900", Offset = "0x5AD4D00", VA = "0x185AD5900", Slot = "5")]
		public a Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32F220", Offset = "0xA32E620", VA = "0x18A32F220", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA32F010", Offset = "0xA32E410", VA = "0x18A32F010", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA322A90", Offset = "0xA321E90", VA = "0x18A322A90", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA322880", Offset = "0xA321C80", VA = "0x18A322880", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA316F40", Offset = "0xA316340", VA = "0x18A316F40", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA316D30", Offset = "0xA316130", VA = "0x18A316D30", Slot = "5")]
		public IList Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public CYIAVGPPHMN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class OVKCENHSVME<a> : RCFHNGFVQCT<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x4E863E0", Offset = "0x4E857E0", VA = "0x184E863E0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7340800", Offset = "0x733FC00", VA = "0x187340800", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class OEMNWWRCBSK<a> : RCAAPZLYGRK<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x4E863E0", Offset = "0x4E857E0", VA = "0x184E863E0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7340800", Offset = "0x733FC00", VA = "0x187340800", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7340790", Offset = "0x733FB90", VA = "0x187340790", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class VGNLNNZNUMA<a> : RCAAPZLYGRK<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5B2BEF0", Offset = "0x5B2B2F0", VA = "0x185B2BEF0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x508E0D0", Offset = "0x508D4D0", VA = "0x18508E0D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A370", Offset = "0x7E49770", VA = "0x187E4A370", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A3B0", Offset = "0x7E497B0", VA = "0x187E4A3B0")]
		public VGNLNNZNUMA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class EVPSXKPCDWA<a> : RCAAPZLYGRK<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x5B2BEF0", Offset = "0x5B2B2F0", VA = "0x185B2BEF0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x508E0D0", Offset = "0x508D4D0", VA = "0x18508E0D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5B2BF30", Offset = "0x5B2B330", VA = "0x185B2BF30", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x5B2BFA0", Offset = "0x5B2B3A0", VA = "0x185B2BFA0")]
		public EVPSXKPCDWA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class PXKJGVWUSTW<a> : RCAAPZLYGRK<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x74698B0", Offset = "0x7468CB0", VA = "0x1874698B0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xD59C30", Offset = "0xD59030", VA = "0x180D59C30", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7469990", Offset = "0x7468D90", VA = "0x187469990", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class JUNXTXZDZQQ<a> : RCFHNGFVQCT<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x4E863E0", Offset = "0x4E857E0", VA = "0x184E863E0", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4E864C0", Offset = "0x4E858C0", VA = "0x184E864C0", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class GASLMLMIMLB<a> : RCFHNGFVQCT<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x4E863E0", Offset = "0x4E857E0", VA = "0x184E863E0", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x4E864C0", Offset = "0x4E858C0", VA = "0x184E864C0", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class ZPWJTKJRDXY<a> : RCAAPZLYGRK<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x508DEA0", Offset = "0x508D2A0", VA = "0x18508DEA0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x508E0D0", Offset = "0x508D4D0", VA = "0x18508E0D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x508DF70", Offset = "0x508D370", VA = "0x18508DF70", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32E4E0", Offset = "0xA32D8E0", VA = "0x18A32E4E0")]
		public static DateTime CQSKWIPSPJB(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA32EC70", Offset = "0xA32E070", VA = "0x18A32EC70")]
		public static bool SYEBYNZXGSS(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA32E9E0", Offset = "0xA32DDE0", VA = "0x18A32E9E0")]
		public static bool NPJKBTYREJY(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA32E7D0", Offset = "0xA32DBD0", VA = "0x18A32E7D0")]
		public static bool NPJKBTYREJY(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA32E5A0", Offset = "0xA32D9A0", VA = "0x18A32E5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA31C4A0", Offset = "0xA31B8A0", VA = "0x18A31C4A0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA31C320", Offset = "0xA31B720", VA = "0x18A31C320", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA31BF20", Offset = "0xA31B320", VA = "0x18A31BF20")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32BBE0", Offset = "0xA32AFE0", VA = "0x18A32BBE0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA32B790", Offset = "0xA32AB90", VA = "0x18A32B790", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA32B800", Offset = "0xA32AC00", VA = "0x18A32B800")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA327380", Offset = "0xA326780", VA = "0x18A327380", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA326F10", Offset = "0xA326310", VA = "0x18A326F10", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA326F90", Offset = "0xA326390", VA = "0x18A326F90")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public SGXQIEWJNWH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class TMBBMDWMNHA<a, b, c, d, e> : KHJXOJJZUWY<e>, YRUEVOCAGJF where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7AAE920", Offset = "0x7AADD20", VA = "0x187AAE920", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7AAA5A0", Offset = "0x7AA99A0", VA = "0x187AAA5A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		protected TMBBMDWMNHA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class TMGIJKQJWSJ<a, b, c, d> : TMBBMDWMNHA<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x769EE60", Offset = "0x769E260", VA = "0x18769EE60", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> WLUAXTUJLJD(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6388E50", Offset = "0x6388250", VA = "0x186388E50")]
		protected TMGIJKQJWSJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class TKVMCPHCIQY<a, b, c> : TMGIJKQJWSJ<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xD59C30", Offset = "0xD59030", VA = "0x180D59C30", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class ANKUIUSATXA<a, b> : TMBBMDWMNHA<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x725BDE0", Offset = "0x725B1E0", VA = "0x18725BDE0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xD59C30", Offset = "0xD59030", VA = "0x180D59C30", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x725C080", Offset = "0x725B480", VA = "0x18725C080", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x725C1A0", Offset = "0x725B5A0", VA = "0x18725C1A0", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator WLUAXTUJLJD(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6A0D510", Offset = "0x6A0C910", VA = "0x186A0D510")]
		public ANKUIUSATXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class LQJVGEOXPHU<a, b, c> : TKVMCPHCIQY<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x68A3E30", Offset = "0x68A3230", VA = "0x1868A3E30", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x68A4010", Offset = "0x68A3410", VA = "0x1868A4010", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class VMPXAWQSGNF<a, b> : TMGIJKQJWSJ<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x5069680", Offset = "0x5068A80", VA = "0x185069680", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x50697E0", Offset = "0x5068BE0", VA = "0x1850697E0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xD59C30", Offset = "0xD59030", VA = "0x180D59C30", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class YDJZNQILHNL<a, b> : TKVMCPHCIQY<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x5069680", Offset = "0x5068A80", VA = "0x185069680", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x50697E0", Offset = "0x5068BE0", VA = "0x1850697E0", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class RDIJLEHRZYV<a, b> : TMBBMDWMNHA<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5069680", Offset = "0x5068A80", VA = "0x185069680", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xD59C30", Offset = "0xD59030", VA = "0x180D59C30", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x50697E0", Offset = "0x5068BE0", VA = "0x1850697E0", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x769EEB0", Offset = "0x769E2B0", VA = "0x18769EEB0", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator WLUAXTUJLJD(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class OOYWTIKTDRG<a, b> : TMGIJKQJWSJ<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x5069680", Offset = "0x5068A80", VA = "0x185069680", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x734E6A0", Offset = "0x734DAA0", VA = "0x18734E6A0", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x734E710", Offset = "0x734DB10", VA = "0x18734E710", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class GJVENNUFBGR<a, b> : TMGIJKQJWSJ<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6353010", Offset = "0x6352410", VA = "0x186353010", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD59C30", Offset = "0xD59030", VA = "0x180D59C30", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x63530B0", Offset = "0x63524B0", VA = "0x1863530B0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6353110", Offset = "0x6352510", VA = "0x186353110")]
		public GJVENNUFBGR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class EAFIIWKIQLP<a, b> : TKVMCPHCIQY<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5A82280", Offset = "0x5A81680", VA = "0x185A82280", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x50697E0", Offset = "0x5068BE0", VA = "0x1850697E0", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class NVAVHOFAVML<a> : KHJXOJJZUWY<a>, YRUEVOCAGJF where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x71EA230", Offset = "0x71E9630", VA = "0x1871EA230", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x71E9FF0", Offset = "0x71E93F0", VA = "0x1871E9FF0", Slot = "5")]
		public a Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA323120", Offset = "0xA322520", VA = "0x18A323120", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA322F40", Offset = "0xA322340", VA = "0x18A322F40", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public LQWDYBOKKNL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class XEHJWIIEPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA32D3C0", Offset = "0xA32C7C0", VA = "0x18A32D3C0")]
		public static object NGBFANCKYLJ(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA32DB80", Offset = "0xA32CF80", VA = "0x18A32DB80")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public EZWOGTCCREE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x5B30FF0", Offset = "0x5B303F0", VA = "0x185B30FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public FABVDZWAAPN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x6273930", Offset = "0x6272D30", VA = "0x186273930")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public FAHCBGPXKAW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x6274A00", Offset = "0x6273E00", VA = "0x186274A00")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public FAMIYNJUTMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x62751F0", Offset = "0x62745F0", VA = "0x1862751F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67507C0", Offset = "0x674FBC0", VA = "0x1867507C0")]
		static KEJSJETCLIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x675A970", Offset = "0x6759D70", VA = "0x18675A970")]
		public KEJSJETCLIU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6748760", Offset = "0x6747B60", VA = "0x186748760", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6744A20", Offset = "0x6743E20", VA = "0x186744A20", Slot = "5")]
		public a Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6747400", Offset = "0x6746800", VA = "0x186747400", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, a b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6747A20", Offset = "0x6746E20", VA = "0x186747A20", Slot = "7")]
		public a LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class ZRLQBBCTEZG<a> : KHJXOJJZUWY<a[,]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x508E540", Offset = "0x508D940", VA = "0x18508E540", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x508E1B0", Offset = "0x508D5B0", VA = "0x18508E1B0", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public ZRLQBBCTEZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class XOQQLEVBONI<a> : KHJXOJJZUWY<a[,,]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5028E10", Offset = "0x5028210", VA = "0x185028E10", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5028940", Offset = "0x5027D40", VA = "0x185028940", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public XOQQLEVBONI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class LYDQNYKQRWS<a> : KHJXOJJZUWY<a[,,,]>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x697AAB0", Offset = "0x6979EB0", VA = "0x18697AAB0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x697A4B0", Offset = "0x69798B0", VA = "0x18697A4B0", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public LYDQNYKQRWS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class TQESODFLSQE<a> : KHJXOJJZUWY<a?>, YRUEVOCAGJF where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9780", Offset = "0x7AB8B80", VA = "0x187AB9780", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9370", Offset = "0x7AB8770", VA = "0x187AB9370", Slot = "5")]
		public a? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public JTUFCYHFASC(KHJXOJJZUWY<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6648880", Offset = "0x6647C80", VA = "0x186648880", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x66479A0", Offset = "0x6646DA0", VA = "0x1866479A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA316000", Offset = "0xA315400", VA = "0x18A316000", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA315E60", Offset = "0xA315260", VA = "0x18A315E60", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA315E70", Offset = "0xA315270", VA = "0x18A315E70", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, sbyte b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA315F80", Offset = "0xA315380", VA = "0x18A315F80", Slot = "7")]
		public sbyte LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA326DB0", Offset = "0xA3261B0", VA = "0x18A326DB0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA326B10", Offset = "0xA325F10", VA = "0x18A326B10", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA326B80", Offset = "0xA325F80", VA = "0x18A326B80", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, sbyte? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA326CE0", Offset = "0xA3260E0", VA = "0x18A326CE0", Slot = "7")]
		public sbyte? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32C820", Offset = "0xA32BC20", VA = "0x18A32C820", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA32C6E0", Offset = "0xA32BAE0", VA = "0x18A32C6E0", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32A080", Offset = "0xA329480", VA = "0x18A32A080", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA329EE0", Offset = "0xA3292E0", VA = "0x18A329EE0", Slot = "5")]
		public short Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA329EF0", Offset = "0xA3292F0", VA = "0x18A329EF0", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, short b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA32A000", Offset = "0xA329400", VA = "0x18A32A000", Slot = "7")]
		public short LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA325D70", Offset = "0xA325170", VA = "0x18A325D70", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA325AD0", Offset = "0xA324ED0", VA = "0x18A325AD0", Slot = "5")]
		public short? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA325B40", Offset = "0xA324F40", VA = "0x18A325B40", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, short? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA325CA0", Offset = "0xA3250A0", VA = "0x18A325CA0", Slot = "7")]
		public short? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3248B0", Offset = "0xA323CB0", VA = "0x18A3248B0", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA324770", Offset = "0xA323B70", VA = "0x18A324770", Slot = "5")]
		public short[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3198F0", Offset = "0xA318CF0", VA = "0x18A3198F0", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA319750", Offset = "0xA318B50", VA = "0x18A319750", Slot = "5")]
		public int Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA319760", Offset = "0xA318B60", VA = "0x18A319760", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, int b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA319870", Offset = "0xA318C70", VA = "0x18A319870", Slot = "7")]
		public int LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3269B0", Offset = "0xA325DB0", VA = "0x18A3269B0", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA326710", Offset = "0xA325B10", VA = "0x18A326710", Slot = "5")]
		public int? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA326780", Offset = "0xA325B80", VA = "0x18A326780", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, int? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA3268E0", Offset = "0xA325CE0", VA = "0x18A3268E0", Slot = "7")]
		public int? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA327BD0", Offset = "0xA326FD0", VA = "0x18A327BD0", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA327A90", Offset = "0xA326E90", VA = "0x18A327A90", Slot = "5")]
		public int[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32B6C0", Offset = "0xA32AAC0", VA = "0x18A32B6C0", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA32B5A0", Offset = "0xA32A9A0", VA = "0x18A32B5A0", Slot = "5")]
		public long Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA32B5B0", Offset = "0xA32A9B0", VA = "0x18A32B5B0", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, long b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA32B680", Offset = "0xA32AA80", VA = "0x18A32B680", Slot = "7")]
		public long LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA316370", Offset = "0xA315770", VA = "0x18A316370", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA316100", Offset = "0xA315500", VA = "0x18A316100", Slot = "5")]
		public long? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA316190", Offset = "0xA315590", VA = "0x18A316190", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, long? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA3162C0", Offset = "0xA3156C0", VA = "0x18A3162C0", Slot = "7")]
		public long? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32A940", Offset = "0xA329D40", VA = "0x18A32A940", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA32A800", Offset = "0xA329C00", VA = "0x18A32A800", Slot = "5")]
		public long[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32A510", Offset = "0xA329910", VA = "0x18A32A510", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA32A370", Offset = "0xA329770", VA = "0x18A32A370", Slot = "5")]
		public byte Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA32A380", Offset = "0xA329780", VA = "0x18A32A380", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, byte b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA32A490", Offset = "0xA329890", VA = "0x18A32A490", Slot = "7")]
		public byte LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA318870", Offset = "0xA317C70", VA = "0x18A318870", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA3185D0", Offset = "0xA3179D0", VA = "0x18A3185D0", Slot = "5")]
		public byte? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA318640", Offset = "0xA317A40", VA = "0x18A318640", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, byte? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA3187A0", Offset = "0xA317BA0", VA = "0x18A3187A0", Slot = "7")]
		public byte? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA319D80", Offset = "0xA319180", VA = "0x18A319D80", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA319BE0", Offset = "0xA318FE0", VA = "0x18A319BE0", Slot = "5")]
		public ushort Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA319BF0", Offset = "0xA318FF0", VA = "0x18A319BF0", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, ushort b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA319D00", Offset = "0xA319100", VA = "0x18A319D00", Slot = "7")]
		public ushort LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32D070", Offset = "0xA32C470", VA = "0x18A32D070", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA32CDD0", Offset = "0xA32C1D0", VA = "0x18A32CDD0", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA32CE40", Offset = "0xA32C240", VA = "0x18A32CE40", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, ushort? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA32CFA0", Offset = "0xA32C3A0", VA = "0x18A32CFA0", Slot = "7")]
		public ushort? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3165E0", Offset = "0xA3159E0", VA = "0x18A3165E0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA3164A0", Offset = "0xA3158A0", VA = "0x18A3164A0", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32B4A0", Offset = "0xA32A8A0", VA = "0x18A32B4A0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA32B300", Offset = "0xA32A700", VA = "0x18A32B300", Slot = "5")]
		public uint Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA32B310", Offset = "0xA32A710", VA = "0x18A32B310", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, uint b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA32B420", Offset = "0xA32A820", VA = "0x18A32B420", Slot = "7")]
		public uint LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3265B0", Offset = "0xA3259B0", VA = "0x18A3265B0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA326310", Offset = "0xA325710", VA = "0x18A326310", Slot = "5")]
		public uint? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA326380", Offset = "0xA325780", VA = "0x18A326380", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, uint? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA3264E0", Offset = "0xA3258E0", VA = "0x18A3264E0", Slot = "7")]
		public uint? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3244D0", Offset = "0xA3238D0", VA = "0x18A3244D0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA324390", Offset = "0xA323790", VA = "0x18A324390", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA319B10", Offset = "0xA318F10", VA = "0x18A319B10", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA3199F0", Offset = "0xA318DF0", VA = "0x18A3199F0", Slot = "5")]
		public ulong Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA319A00", Offset = "0xA318E00", VA = "0x18A319A00", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, ulong b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xA319AD0", Offset = "0xA318ED0", VA = "0x18A319AD0", Slot = "7")]
		public ulong LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA319110", Offset = "0xA318510", VA = "0x18A319110", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA318EA0", Offset = "0xA3182A0", VA = "0x18A318EA0", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA318F30", Offset = "0xA318330", VA = "0x18A318F30", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, ulong? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA319060", Offset = "0xA318460", VA = "0x18A319060", Slot = "7")]
		public ulong? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA319380", Offset = "0xA318780", VA = "0x18A319380", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA319240", Offset = "0xA318640", VA = "0x18A319240", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32EF40", Offset = "0xA32E340", VA = "0x18A32EF40", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA32EE20", Offset = "0xA32E220", VA = "0x18A32EE20", Slot = "5")]
		public float Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA32EE30", Offset = "0xA32E230", VA = "0x18A32EE30", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, float b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA32EF00", Offset = "0xA32E300", VA = "0x18A32EF00", Slot = "7")]
		public float LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA317590", Offset = "0xA316990", VA = "0x18A317590", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA317360", Offset = "0xA316760", VA = "0x18A317360", Slot = "5")]
		public float? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA3173D0", Offset = "0xA3167D0", VA = "0x18A3173D0", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, float? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA3174F0", Offset = "0xA3168F0", VA = "0x18A3174F0", Slot = "7")]
		public float? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA318B10", Offset = "0xA317F10", VA = "0x18A318B10", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA3189D0", Offset = "0xA317DD0", VA = "0x18A3189D0", Slot = "5")]
		public float[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3242C0", Offset = "0xA3236C0", VA = "0x18A3242C0", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA3241A0", Offset = "0xA3235A0", VA = "0x18A3241A0", Slot = "5")]
		public double Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA3241B0", Offset = "0xA3235B0", VA = "0x18A3241B0", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, double b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA324280", Offset = "0xA323680", VA = "0x18A324280", Slot = "7")]
		public double LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA31A4C0", Offset = "0xA3198C0", VA = "0x18A31A4C0", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA31A250", Offset = "0xA319650", VA = "0x18A31A250", Slot = "5")]
		public double? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA31A2E0", Offset = "0xA3196E0", VA = "0x18A31A2E0", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, double? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA31A410", Offset = "0xA319810", VA = "0x18A31A410", Slot = "7")]
		public double? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA323E20", Offset = "0xA323220", VA = "0x18A323E20", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA323CE0", Offset = "0xA3230E0", VA = "0x18A323CE0", Slot = "5")]
		public double[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3238B0", Offset = "0xA322CB0", VA = "0x18A3238B0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA323790", Offset = "0xA322B90", VA = "0x18A323790", Slot = "5")]
		public bool Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA3237A0", Offset = "0xA322BA0", VA = "0x18A3237A0", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, bool b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA323870", Offset = "0xA322C70", VA = "0x18A323870", Slot = "7")]
		public bool LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA323BB0", Offset = "0xA322FB0", VA = "0x18A323BB0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA323980", Offset = "0xA322D80", VA = "0x18A323980", Slot = "5")]
		public bool? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xA3239F0", Offset = "0xA322DF0", VA = "0x18A3239F0", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, bool? b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA323B10", Offset = "0xA322F10", VA = "0x18A323B10", Slot = "7")]
		public bool? LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA315990", Offset = "0xA314D90", VA = "0x18A315990", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA315850", Offset = "0xA314C50", VA = "0x18A315850", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA319620", Offset = "0xA318A20", VA = "0x18A319620", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA3195B0", Offset = "0xA3189B0", VA = "0x18A3195B0", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA31E650", Offset = "0xA31DA50", VA = "0x18A31E650", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA31E580", Offset = "0xA31D980", VA = "0x18A31E580", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA315D90", Offset = "0xA315190", VA = "0x18A315D90", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA315D20", Offset = "0xA315120", VA = "0x18A315D20", Slot = "5")]
		public string Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA315D30", Offset = "0xA315130", VA = "0x18A315D30", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, string b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA315D20", Offset = "0xA315120", VA = "0x18A315D20", Slot = "7")]
		public string LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA31E350", Offset = "0xA31D750", VA = "0x18A31E350", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA31E200", Offset = "0xA31D600", VA = "0x18A31E200", Slot = "5")]
		public string[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32D2A0", Offset = "0xA32C6A0", VA = "0x18A32D2A0", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA32D270", Offset = "0xA32C670", VA = "0x18A32D270", Slot = "5")]
		public char Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA31A0E0", Offset = "0xA3194E0", VA = "0x18A31A0E0", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA31A020", Offset = "0xA319420", VA = "0x18A31A020", Slot = "5")]
		public char? Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA326060", Offset = "0xA325460", VA = "0x18A326060", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA325ED0", Offset = "0xA3252D0", VA = "0x18A325ED0", Slot = "5")]
		public char[] Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA31EA40", Offset = "0xA31DE40", VA = "0x18A31EA40", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA31E7F0", Offset = "0xA31DBF0", VA = "0x18A31E7F0", Slot = "5")]
		public Guid Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA31E850", Offset = "0xA31DC50", VA = "0x18A31E850", Slot = "6")]
		public void IBXPUAGTWZZ(JsonWriter a, Guid b, BBOFZKRFCTL c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA31E9D0", Offset = "0xA31DDD0", VA = "0x18A31E9D0", Slot = "7")]
		public Guid LIRHUCUFZOT(JsonReader a, BBOFZKRFCTL b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86959E0", Offset = "0x8694DE0", VA = "0x1886959E0")]
		public ZPRMFLUJBPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xFF35A0", Offset = "0xFF29A0", VA = "0x180FF35A0")]
		public ZPRMFLUJBPT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA32F770", Offset = "0xA32EB70", VA = "0x18A32F770", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA32F5A0", Offset = "0xA32E9A0", VA = "0x18A32F5A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32FA40", Offset = "0xA32EE40", VA = "0x18A32FA40", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA32F9C0", Offset = "0xA32EDC0", VA = "0x18A32F9C0", Slot = "5")]
		public Uri Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA316900", Offset = "0xA315D00", VA = "0x18A316900", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA316880", Offset = "0xA315C80", VA = "0x18A316880", Slot = "5")]
		public Version Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public CHIUEOVIZXC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class GRRSZJFKFGK<a, b> : KHJXOJJZUWY<KeyValuePair<a, b>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x6377CD0", Offset = "0x63770D0", VA = "0x186377CD0", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x6377810", Offset = "0x6376C10", VA = "0x186377810", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA318290", Offset = "0xA317690", VA = "0x18A318290", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA318210", Offset = "0xA317610", VA = "0x18A318210", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32CBE0", Offset = "0xA32BFE0", VA = "0x18A32CBE0", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA32CAC0", Offset = "0xA32BEC0", VA = "0x18A32CAC0", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA316D10", Offset = "0xA316110", VA = "0x18A316D10")]
		public CLHPEEWOAQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x964DA30", Offset = "0x964CE30", VA = "0x18964DA30")]
		public CLHPEEWOAQA(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA316B40", Offset = "0xA315F40", VA = "0x18A316B40", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA316A30", Offset = "0xA315E30", VA = "0x18A316A30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32A6C0", Offset = "0xA329AC0", VA = "0x18A32A6C0", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA32A610", Offset = "0xA329A10", VA = "0x18A32A610", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA318430", Offset = "0xA317830", VA = "0x18A318430", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA3183A0", Offset = "0xA3177A0", VA = "0x18A3183A0", Slot = "5")]
		public Complex Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA317900", Offset = "0xA316D00", VA = "0x18A317900", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA3176D0", Offset = "0xA316AD0", VA = "0x18A3176D0", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public DCEALGVGEOW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class SMXSOWSODQZ<a> : KHJXOJJZUWY<Lazy<a>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x792A700", Offset = "0x7929B00", VA = "0x18792A700", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x792A510", Offset = "0x7929910", VA = "0x18792A510", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32A230", Offset = "0xA329630", VA = "0x18A32A230", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA32A180", Offset = "0xA329580", VA = "0x18A32A180", Slot = "5")]
		public Task Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public THHPLXEAEIJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class DAHGWIAADNT<a> : KHJXOJJZUWY<Task<a>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x532E430", Offset = "0x532D830", VA = "0x18532E430", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x532E2C0", Offset = "0x532D6C0", VA = "0x18532E2C0", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, BBOFZKRFCTL formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class TNWSRMEQNFF<a> : KHJXOJJZUWY<ValueTask<a>>, YRUEVOCAGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7AB8570", Offset = "0x7AB7970", VA = "0x187AB8570", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7AB83D0", Offset = "0x7AB77D0", VA = "0x187AB83D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D582B0", Offset = "0x7D576B0", VA = "0x187D582B0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x7D57FF0", Offset = "0x7D573F0", VA = "0x187D57FF0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D56F30", Offset = "0x7D56330", VA = "0x187D56F30", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7D56B10", Offset = "0x7D55F10", VA = "0x187D56B10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D57990", Offset = "0x7D56D90", VA = "0x187D57990", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7D57430", Offset = "0x7D56830", VA = "0x187D57430", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D5B840", Offset = "0x7D5AC40", VA = "0x187D5B840", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7D5B190", Offset = "0x7D5A590", VA = "0x187D5B190", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D5C810", Offset = "0x7D5BC10", VA = "0x187D5C810", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C010", Offset = "0x7D5B410", VA = "0x187D5C010", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D58FE0", Offset = "0x7D583E0", VA = "0x187D58FE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7D58660", Offset = "0x7D57A60", VA = "0x187D58660", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D5A590", Offset = "0x7D59990", VA = "0x187D5A590", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7D59A80", Offset = "0x7D58E80", VA = "0x187D59A80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D5DDB0", Offset = "0x7D5D1B0", VA = "0x187D5DDB0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7D5D140", Offset = "0x7D5C540", VA = "0x187D5D140", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8521910", Offset = "0x8520D10", VA = "0x188521910", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x8521500", Offset = "0x8520900", VA = "0x188521500", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8522EF0", Offset = "0x85222F0", VA = "0x188522EF0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x8522A10", Offset = "0x8521E10", VA = "0x188522A10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8522330", Offset = "0x8521730", VA = "0x188522330", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x8521CC0", Offset = "0x85210C0", VA = "0x188521CC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8525050", Offset = "0x8524450", VA = "0x188525050", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x8524820", Offset = "0x8523C20", VA = "0x188524820", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8523DE0", Offset = "0x85231E0", VA = "0x188523DE0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x8523430", Offset = "0x8522830", VA = "0x188523430", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8528130", Offset = "0x8527530", VA = "0x188528130", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x8527570", Offset = "0x8526970", VA = "0x188527570", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8526650", Offset = "0x8525A50", VA = "0x188526650", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x85258F0", Offset = "0x8524CF0", VA = "0x1885258F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x851FD00", Offset = "0x851F100", VA = "0x18851FD00", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, BBOFZKRFCTL formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x851EDE0", Offset = "0x851E1E0", VA = "0x18851EDE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA319E80", Offset = "0xA319280", VA = "0x18A319E80")]
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
		[Cpp2IlInjected.Address(RVA = "0xA32E340", Offset = "0xA32D740", VA = "0x18A32E340")]
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
		[Cpp2IlInjected.Address(RVA = "0xA324B50", Offset = "0xA323F50", VA = "0x18A324B50")]
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
