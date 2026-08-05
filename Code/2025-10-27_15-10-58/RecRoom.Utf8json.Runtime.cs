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
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xACFF70", Offset = "0xACEF70", VA = "0x180ACFF70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, POKYTICTLCW resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, POKYTICTLCW resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface AYGEWMYQSHO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface JDLSLJQPPOP<a> : AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, POKYTICTLCW formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, POKYTICTLCW formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface XJCFLGRTSJY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LOSLZCQLXAK(JsonWriter a, a b, POKYTICTLCW c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b);
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
	public static class NSMSAAPDSQF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3B52530", Offset = "0x3B51530", VA = "0x183B52530")]
		public static string ToJsonString<T>(this JDLSLJQPPOP<T> formatter, T value, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JDLSLJQPPOP<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class DYDOYGCURCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3831D00", Offset = "0x3830D00", VA = "0x183831D00")]
		public static JDLSLJQPPOP<a> QATSYKPGQYK<a>(this POKYTICTLCW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x92887A0", Offset = "0x92877A0", VA = "0x1892887A0")]
		public static object FCHPVLVTIWA(this POKYTICTLCW a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9288A00", Offset = "0x9287A00", VA = "0x189288A00")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class RNDXBWQYCQW
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] IZETBESARPP;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] HBKPHNRDOQE;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] WHCXKCGCPIJ;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] NOMEJBGWIPG;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] GAHEXTRKKJZ;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] FWNQSVVPJFU;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] EJTBIDUWGJS;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] NGZGGEMOEBD;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class TTBBZOYAMSR : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x9299E20", Offset = "0x9298E20", VA = "0x189299E20")]
				public TTBBZOYAMSR(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x9299D00", Offset = "0x9298D00", VA = "0x189299D00")]
				public TTBBZOYAMSR IAWSEDTHGMN(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class LPPKOFKWSLQ
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] UNUGGCKWDFZ;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] YJZWLHDSTBO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private TTBBZOYAMSR start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TTBBZOYAMSR end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x92993A0", Offset = "0x92983A0", VA = "0x1892993A0")]
			public void IAWSEDTHGMN([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9299260", Offset = "0x9298260", VA = "0x189299260")]
			public void IAWSEDTHGMN(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9299660", Offset = "0x9298660", VA = "0x189299660")]
			public ReadOnlySequence<byte> XTNLJPCQZVI()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x92994B0", Offset = "0x92984B0", VA = "0x1892994B0")]
			private void TOGQUYAUHZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9299070", Offset = "0x9298070", VA = "0x189299070")]
			private void CWLVYWDTQZO([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9291830", Offset = "0x9290830", VA = "0x189291830")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9290F30", Offset = "0x928FF30", VA = "0x189290F30")]
		private JsonParsingException YLSVGHSADCM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9290610", Offset = "0x928F610", VA = "0x189290610")]
		private JsonParsingException VBEUVQLIVBN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x928F1E0", Offset = "0x928E1E0", VA = "0x18928F1E0")]
		public JsonToken HWTVXUFOMOP()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x928EBE0", Offset = "0x928DBE0", VA = "0x18928EBE0")]
		public void FORHLDGDUJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x928F730", Offset = "0x928E730", VA = "0x18928F730")]
		private bool IZBGPVITURP(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x928F790", Offset = "0x928E790", VA = "0x18928F790")]
		private bool IZBGPVITURP(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x92901C0", Offset = "0x928F1C0", VA = "0x1892901C0")]
		private void OOINQDOGPXC(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x928E860", Offset = "0x928D860", VA = "0x18928E860")]
		public bool AOLSKYAPIIY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9290410", Offset = "0x928F410", VA = "0x189290410")]
		public void SFBWMWJEYRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9290E70", Offset = "0x928FE70", VA = "0x189290E70")]
		public bool XUUWJUOSSFF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x928E920", Offset = "0x928D920", VA = "0x18928E920")]
		public void BUPBHHOTUMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9290400", Offset = "0x928F400", VA = "0x189290400")]
		public void QFQJMRHFOUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x928F7F0", Offset = "0x928E7F0", VA = "0x18928F7F0")]
		public bool JKIEBNXWJZH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x928F720", Offset = "0x928E720", VA = "0x18928F720")]
		public void IXWIOVKXXMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9290BC0", Offset = "0x928FBC0", VA = "0x189290BC0")]
		public void XKSFJSQGKWE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x928FED0", Offset = "0x928EED0", VA = "0x18928FED0")]
		public bool LVBTXLMZCMU(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9290580", Offset = "0x928F580", VA = "0x189290580")]
		public bool TXPMWGMMMBY(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x928F100", Offset = "0x928E100", VA = "0x18928F100")]
		public bool HNNBDGUEXPH(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x928F910", Offset = "0x928E910", VA = "0x18928F910")]
		private ReadOnlySequence<byte> KCCLAEPXBDE()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x92907A0", Offset = "0x928F7A0", VA = "0x1892907A0")]
		private ReadOnlySequence<byte> WMFBQCCURUF()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x928E9F0", Offset = "0x928D9F0", VA = "0x18928E9F0")]
		private void FMVPBQGSWAJ(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x928E660", Offset = "0x928D660", VA = "0x18928E660")]
		private void ANHHDPMKZZO(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x92914D0", Offset = "0x92904D0", VA = "0x1892914D0")]
		private void ZMOYDBBSCZB(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x92900B0", Offset = "0x928F0B0", VA = "0x1892900B0")]
		private void MTBXILBNQUG(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9287880", Offset = "0x9286880", VA = "0x189287880")]
		private static int TSONAXICPIV(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x928F840", Offset = "0x928E840", VA = "0x18928F840")]
		public ReadOnlySequence<byte> JZSRTRBGLCX()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9290720", Offset = "0x928F720", VA = "0x189290720")]
		public string VLNDFAZCMEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9290A10", Offset = "0x928FA10", VA = "0x189290A10")]
		public string WXTIWIBUNDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x928FE00", Offset = "0x928EE00", VA = "0x18928FE00")]
		public ReadOnlySequence<byte> KHDKHMFIZZT()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9290270", Offset = "0x928F270", VA = "0x189290270")]
		public ReadOnlySequence<byte> PMSNXYQOHTE()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x928FF60", Offset = "0x928EF60", VA = "0x18928FF60")]
		public bool MJXGEPBQUPV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9290A50", Offset = "0x928FA50", VA = "0x189290A50")]
		private void XADLMKUUSDV(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x928E9E0", Offset = "0x928D9E0", VA = "0x18928E9E0")]
		public void FGZUYLSGBTD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x928EE10", Offset = "0x928DE10", VA = "0x18928EE10")]
		private void FPOWNTVMQPI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9290350", Offset = "0x928F350", VA = "0x189290350")]
		public sbyte QDRCETRPEAE()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9290420", Offset = "0x928F420", VA = "0x189290420")]
		public short SJBPOMIMJBP()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x928E930", Offset = "0x928D930", VA = "0x18928E930")]
		public int EGDCMZPCGED()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9290EC0", Offset = "0x928FEC0", VA = "0x189290EC0")]
		public long YHUFBHAOWOE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x928F3F0", Offset = "0x928E3F0", VA = "0x18928F3F0")]
		public byte IEQZPHFXYYD()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x928F050", Offset = "0x928E050", VA = "0x18928F050")]
		public ushort FTNEVOFUXZI()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x92904D0", Offset = "0x928F4D0", VA = "0x1892904D0")]
		public uint TOJCCQJGNKY()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x92917C0", Offset = "0x92907C0", VA = "0x1892917C0")]
		public ulong ZTZNTSMCYTJ()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x928F4A0", Offset = "0x928E4A0", VA = "0x18928F4A0")]
		public float ISZZFPXOZHL()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9291430", Offset = "0x9290430", VA = "0x189291430")]
		public double ZIXNVOJGRKU()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x928F540", Offset = "0x928E540", VA = "0x18928F540")]
		public ReadOnlySequence<byte> ITXLGOIDPCN()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9290BD0", Offset = "0x928FBD0", VA = "0x189290BD0")]
		private void XRBVIXVFJKD()
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
			[Cpp2IlInjected.Address(RVA = "0xC1E6C0", Offset = "0xC1D6C0", VA = "0x180C1E6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x928E600", Offset = "0x928D600", VA = "0x18928E600")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x928E580", Offset = "0x928D580", VA = "0x18928E580")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class CLNLQVSIREP
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class SIRWJFBIOAQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] UNUGGCKWDFZ;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9298710", Offset = "0x9297710", VA = "0x189298710")]
			public static byte[] JDAIBRHSROZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static POKYTICTLCW EZEYLZCHUVW;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] LLGNZOEKFVJ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] EGIBVDUSBKH;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static POKYTICTLCW OTVVLRRDHDO
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9287F50", Offset = "0x9286F50", VA = "0x189287F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9288050", Offset = "0x9287050", VA = "0x189288050")]
		public static void SYNNAIHNAAS(POKYTICTLCW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x37592A0", Offset = "0x37582A0", VA = "0x1837592A0")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3759130", Offset = "0x3758130", VA = "0x183759130")]
		public static byte[] Serialize<T>(T value, POKYTICTLCW resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x37599A0", Offset = "0x37589A0", VA = "0x1837599A0")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3759B60", Offset = "0x3758B60", VA = "0x183759B60")]
		public static string ToJsonString<T>(T value, POKYTICTLCW resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3758AB0", Offset = "0x3757AB0", VA = "0x183758AB0")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3758C80", Offset = "0x3757C80", VA = "0x183758C80")]
		public static T Deserialize<T>(string json, POKYTICTLCW resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x37589E0", Offset = "0x37579E0", VA = "0x1837589E0")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3758890", Offset = "0x3757890", VA = "0x183758890")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, POKYTICTLCW resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3758290", Offset = "0x3757290", VA = "0x183758290")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x37580B0", Offset = "0x37570B0", VA = "0x1837580B0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, POKYTICTLCW resolver)
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
		public int TIKUJTHVPPP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x102DA70", Offset = "0x102CA70", VA = "0x18102DA70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9292730", Offset = "0x9291730", VA = "0x189292730")]
		public void UOJCNNLFVQS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9291ED0", Offset = "0x9290ED0", VA = "0x189291ED0")]
		public static byte[] FWHRFNQYEQN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9292610", Offset = "0x9291610", VA = "0x189292610")]
		public static byte[] UBNXVPWQQMF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x92922E0", Offset = "0x92912E0", VA = "0x1892922E0")]
		public static byte[] OLTQQXKZVQF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9291A20", Offset = "0x9290A20", VA = "0x189291A20")]
		public static byte[] BZVXRBWYXGD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2ABEEC0", Offset = "0x2ABDEC0", VA = "0x182ABEEC0")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9292150", Offset = "0x9291150", VA = "0x189292150")]
		public ArraySegment<byte> JDAIBRHSROZ()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9291D40", Offset = "0x9290D40", VA = "0x189291D40")]
		public byte[] FPXGFVJUQHQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x92925B0", Offset = "0x92915B0", VA = "0x1892925B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x92921F0", Offset = "0x92911F0", VA = "0x1892921F0")]
		public void JLGLSOTVVZB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9292200", Offset = "0x9291200", VA = "0x189292200")]
		public void KLNKYBTNUJM(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9292040", Offset = "0x9291040", VA = "0x189292040")]
		public void HBPZQPGKGUQ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x404A740", Offset = "0x4049740", VA = "0x18404A740")]
		public void PWFLOJWWJWO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x404A600", Offset = "0x4049600", VA = "0x18404A600")]
		public void IAXACASYFYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9292100", Offset = "0x9291100", VA = "0x189292100")]
		public void IUHZZKKJMKW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x41956F0", Offset = "0x41946F0", VA = "0x1841956F0")]
		public void QKBNDMGVBHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x404A650", Offset = "0x4049650", VA = "0x18404A650")]
		public void JVOARCQHFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECAA70", Offset = "0x5EC9A70", VA = "0x185ECAA70")]
		public void PGJLXFZMGRU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9292400", Offset = "0x9291400", VA = "0x189292400")]
		public void OMKAMGYEUXE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9291C10", Offset = "0x9290C10", VA = "0x189291C10")]
		public void EDBYIUMMWGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x404A6A0", Offset = "0x40496A0", VA = "0x18404A6A0")]
		public void JYLIIZMETMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC3D0", Offset = "0x7BBB3D0", VA = "0x187BBC3D0")]
		public void RJZBKKFVFQI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9292080", Offset = "0x9291080", VA = "0x189292080")]
		public void HDYJNTHIGUU(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x92919A0", Offset = "0x92909A0", VA = "0x1892919A0")]
		public void AFSITBACGGR(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9291BA0", Offset = "0x9290BA0", VA = "0x189291BA0")]
		public void CWWUYWBZICG(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x92924D0", Offset = "0x92914D0", VA = "0x1892924D0")]
		public void RJDYEZIYTMT(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9291CD0", Offset = "0x9290CD0", VA = "0x189291CD0")]
		public void FDZVMBMKIYJ(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9292CC0", Offset = "0x9291CC0", VA = "0x189292CC0")]
		public void ZGLZPJZMLBU(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9291C60", Offset = "0x9290C60", VA = "0x189291C60")]
		public void FCQKSKMIKZJ(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9292540", Offset = "0x9291540", VA = "0x189292540")]
		public void SRQYINZVORQ(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9291FB0", Offset = "0x9290FB0", VA = "0x189291FB0")]
		public void GRJFBWMVWPO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x92924A0", Offset = "0x92914A0", VA = "0x1892924A0")]
		public void ONWEXGBUCLF(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9292740", Offset = "0x9291740", VA = "0x189292740")]
		public void XEBAQHOIYUJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9292260", Offset = "0x9291260", VA = "0x189292260")]
		private static bool NGMSXZVLJGV(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9292020", Offset = "0x9291020", VA = "0x189292020")]
		private static byte GZEJYONNNUD(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9287940", Offset = "0x9286940", VA = "0x189287940")]
		private static void AZFSOICRMBG(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class MGSBNWZVHKB : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x651F1C0", Offset = "0x651E1C0", VA = "0x18651F1C0")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private MGSBNWZVHKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class AZAYZSDMPJA : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x652B630", Offset = "0x652A630", VA = "0x18652B630")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class HCDHJJYRDTK
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> XZSKPHBOQIV;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x928A7E0", Offset = "0x92897E0", VA = "0x18928A7E0")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private AZAYZSDMPJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class CTJTPIYAGHM : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6519680", Offset = "0x6518680", VA = "0x186519680")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly CTJTPIYAGHM HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool DGZXZMQUNWO;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static AYGEWMYQSHO[] CKONLZOIDTU;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static POKYTICTLCW[] FDGRVYJHEQE;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private CTJTPIYAGHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x92884D0", Offset = "0x92874D0", VA = "0x1892884D0")]
		public static void YTBQRMTMKZK(params POKYTICTLCW[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x92885B0", Offset = "0x92875B0", VA = "0x1892885B0")]
		public static void YTBQRMTMKZK(params AYGEWMYQSHO[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9288250", Offset = "0x9287250", VA = "0x189288250")]
		public static void EEPVWYOHEXS(AYGEWMYQSHO[] a, POKYTICTLCW[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class TEOBEFPMJNH : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x652DFD0", Offset = "0x652CFD0", VA = "0x18652DFD0")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private TEOBEFPMJNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class ZISCLQNEIMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly POKYTICTLCW MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly POKYTICTLCW QVECHQDCLMT;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class NQBALKRULWO
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly POKYTICTLCW MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly POKYTICTLCW IJQQORLXZEB;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly POKYTICTLCW INKIRYPPJFV;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly POKYTICTLCW DQULCXBCZHK;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly POKYTICTLCW HJELOLMXWIW;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly POKYTICTLCW MCSRWXPZRPO;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly POKYTICTLCW ORMTWSZHZYJ;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly POKYTICTLCW FXGOJCBRRPP;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly POKYTICTLCW CRMKATYHEGT;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly POKYTICTLCW FLTLNUNSWEI;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly POKYTICTLCW BXAATPXOWFI;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly POKYTICTLCW BWWDWHMNVWM;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class LNYKOCEQHMT
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> XZSKPHBOQIV;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9292E60", Offset = "0x9291E60", VA = "0x189292E60")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9294AE0", Offset = "0x9293AE0", VA = "0x189294AE0")]
		private static object YXOQUKXPZQC(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class FXJZYRFRMEX : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x64F5C50", Offset = "0x64F4C50", VA = "0x1864F5C50")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private FXJZYRFRMEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class PCRWSBRUYLY : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6509960", Offset = "0x6508960", VA = "0x186509960")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private PCRWSBRUYLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class PKXBATLAHXA
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly POKYTICTLCW[] DVSIAQYCWHZ;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class PRINGLPNXCF : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x64F3D90", Offset = "0x64F2D90", VA = "0x1864F3D90")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class RBBRQNHARQJ : POKYTICTLCW
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class UFJZPKLPEVE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x650E730", Offset = "0x650D730", VA = "0x18650E730")]
				static UFJZPKLPEVE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly POKYTICTLCW HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly POKYTICTLCW[] FDGRVYJHEQE;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private RBBRQNHARQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
			public JDLSLJQPPOP<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly JDLSLJQPPOP<object> SMWAKODCMJZ;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private PRINGLPNXCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class NFWWSZQYGUS : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x650B510", Offset = "0x650A510", VA = "0x18650B510")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class RBBRQNHARQJ : POKYTICTLCW
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class UFJZPKLPEVE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x65287B0", Offset = "0x65277B0", VA = "0x1865287B0")]
				static UFJZPKLPEVE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly POKYTICTLCW HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly POKYTICTLCW[] FDGRVYJHEQE;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private RBBRQNHARQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
			public JDLSLJQPPOP<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly JDLSLJQPPOP<object> SMWAKODCMJZ;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private NFWWSZQYGUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class FBRBMSTJDEU : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x64F7930", Offset = "0x64F6930", VA = "0x1864F7930")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class RBBRQNHARQJ : POKYTICTLCW
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class UFJZPKLPEVE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x6503B50", Offset = "0x6502B50", VA = "0x186503B50")]
				static UFJZPKLPEVE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly POKYTICTLCW HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly POKYTICTLCW[] FDGRVYJHEQE;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private RBBRQNHARQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
			public JDLSLJQPPOP<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly JDLSLJQPPOP<object> SMWAKODCMJZ;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private FBRBMSTJDEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class VOLVYCJODBJ : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x650E410", Offset = "0x650D410", VA = "0x18650E410")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class RBBRQNHARQJ : POKYTICTLCW
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class UFJZPKLPEVE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x650AA50", Offset = "0x6509A50", VA = "0x18650AA50")]
				static UFJZPKLPEVE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly POKYTICTLCW HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly POKYTICTLCW[] FDGRVYJHEQE;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private RBBRQNHARQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
			public JDLSLJQPPOP<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly JDLSLJQPPOP<object> SMWAKODCMJZ;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private VOLVYCJODBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class XIGRWJWUAGN : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x652C4E0", Offset = "0x652B4E0", VA = "0x18652C4E0")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class RBBRQNHARQJ : POKYTICTLCW
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class UFJZPKLPEVE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x6507B10", Offset = "0x6506B10", VA = "0x186507B10")]
				static UFJZPKLPEVE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly POKYTICTLCW HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly POKYTICTLCW[] FDGRVYJHEQE;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private RBBRQNHARQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
			public JDLSLJQPPOP<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly JDLSLJQPPOP<object> SMWAKODCMJZ;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private XIGRWJWUAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class BFFXTZZSJXZ : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x6524AD0", Offset = "0x6523AD0", VA = "0x186524AD0")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class RBBRQNHARQJ : POKYTICTLCW
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class UFJZPKLPEVE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x6521BE0", Offset = "0x6520BE0", VA = "0x186521BE0")]
				static UFJZPKLPEVE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly POKYTICTLCW HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly POKYTICTLCW[] FDGRVYJHEQE;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private RBBRQNHARQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
			public JDLSLJQPPOP<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly JDLSLJQPPOP<object> SMWAKODCMJZ;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private BFFXTZZSJXZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class NURHSIOCOSG : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6527D30", Offset = "0x6526D30", VA = "0x186527D30")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class RBBRQNHARQJ : POKYTICTLCW
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class UFJZPKLPEVE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x6501770", Offset = "0x6500770", VA = "0x186501770")]
				static UFJZPKLPEVE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly POKYTICTLCW HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly POKYTICTLCW[] FDGRVYJHEQE;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private RBBRQNHARQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
			public JDLSLJQPPOP<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly JDLSLJQPPOP<object> SMWAKODCMJZ;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private NURHSIOCOSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class RNELDLFZMGS : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x64F9A10", Offset = "0x64F8A10", VA = "0x1864F9A10")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class RBBRQNHARQJ : POKYTICTLCW
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class UFJZPKLPEVE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0x6516550", Offset = "0x6515550", VA = "0x186516550")]
				static UFJZPKLPEVE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly POKYTICTLCW HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly POKYTICTLCW[] FDGRVYJHEQE;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private RBBRQNHARQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
			public JDLSLJQPPOP<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly JDLSLJQPPOP<object> SMWAKODCMJZ;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private RNELDLFZMGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class MKVUUKXPAAU : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x6521280", Offset = "0x6520280", VA = "0x186521280")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class RBBRQNHARQJ : POKYTICTLCW
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class UFJZPKLPEVE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6525110", Offset = "0x6524110", VA = "0x186525110")]
				static UFJZPKLPEVE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly POKYTICTLCW HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly POKYTICTLCW[] FDGRVYJHEQE;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private RBBRQNHARQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
			public JDLSLJQPPOP<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly JDLSLJQPPOP<object> SMWAKODCMJZ;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private MKVUUKXPAAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class LFGGGYDENZN : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x65273D0", Offset = "0x65263D0", VA = "0x1865273D0")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class RBBRQNHARQJ : POKYTICTLCW
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class UFJZPKLPEVE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x650BCC0", Offset = "0x650ACC0", VA = "0x18650BCC0")]
				static UFJZPKLPEVE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly POKYTICTLCW HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly POKYTICTLCW[] FDGRVYJHEQE;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private RBBRQNHARQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
			public JDLSLJQPPOP<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly JDLSLJQPPOP<object> SMWAKODCMJZ;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private LFGGGYDENZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class NDAMVOEJRJH : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x65094D0", Offset = "0x65084D0", VA = "0x1865094D0")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class RBBRQNHARQJ : POKYTICTLCW
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class UFJZPKLPEVE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x651E360", Offset = "0x651D360", VA = "0x18651E360")]
				static UFJZPKLPEVE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly POKYTICTLCW HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly POKYTICTLCW[] FDGRVYJHEQE;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private RBBRQNHARQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
			public JDLSLJQPPOP<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly JDLSLJQPPOP<object> SMWAKODCMJZ;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private NDAMVOEJRJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class XRSBLNIPBPN : POKYTICTLCW
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class UFJZPKLPEVE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x652D820", Offset = "0x652C820", VA = "0x18652D820")]
			static UFJZPKLPEVE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class RBBRQNHARQJ : POKYTICTLCW
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class UFJZPKLPEVE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly JDLSLJQPPOP<a> JUBJWUMZOPD;

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x650B3A0", Offset = "0x650A3A0", VA = "0x18650B3A0")]
				static UFJZPKLPEVE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly POKYTICTLCW HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly POKYTICTLCW[] FDGRVYJHEQE;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private RBBRQNHARQJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
			public JDLSLJQPPOP<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly POKYTICTLCW HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly JDLSLJQPPOP<object> SMWAKODCMJZ;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		private XRSBLNIPBPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3328250", Offset = "0x3327250", VA = "0x183328250", Slot = "4")]
		public JDLSLJQPPOP<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x5BA98E0", Offset = "0x5BA88E0", VA = "0x185BA98E0")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5BA95E0", Offset = "0x5BA85E0", VA = "0x185BA95E0")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5BA9850", Offset = "0x5BA8850", VA = "0x185BA9850")]
		public T[] BYZVBLKPVJH()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class AWILAUBSTOT<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int YRQMFQPKAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object UQRGDVJVHVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int KFKEAEYJQEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] UKQHWHRNFTS;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x589E790", Offset = "0x589D790", VA = "0x18589E790")]
		public AWILAUBSTOT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x589E3D0", Offset = "0x589D3D0", VA = "0x18589E3D0")]
		public a[] OWQREUFSZBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x589E610", Offset = "0x589D610", VA = "0x18589E610")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class SNRRBOIZBIH : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class SBIVDNZEHHZ : IComparable<SBIVDNZEHHZ>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class TIXZJDXIDOH : IEnumerable<SBIVDNZEHHZ>, IEnumerable, IEnumerator<SBIVDNZEHHZ>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int WDQRLRKBTGJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private SBIVDNZEHHZ IGHQXRUYHSG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int FMHFHEECSRO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public SBIVDNZEHHZ FOYWNDAXKGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int GLLQGAOFNOJ;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private SBIVDNZEHHZ LFSDWGFIEDO
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object UQAIKHVHSEP
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xBB3120", Offset = "0xBB2120", VA = "0x180BB3120")]
				[DebuggerHidden]
				public TIXZJDXIDOH(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "7")]
				[DebuggerHidden]
				private void PRJHWGPKORK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x9299C80", Offset = "0x9298C80", VA = "0x189299C80", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x9299C40", Offset = "0x9298C40", VA = "0x189299C40", Slot = "10")]
				[DebuggerHidden]
				private void HJPFLPVTXYN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x9299BA0", Offset = "0x9298BA0", VA = "0x189299BA0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<SBIVDNZEHHZ> GTCFTUOZULN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x9299BA0", Offset = "0x9298BA0", VA = "0x189299BA0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator JZJZEHYLQOE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly SBIVDNZEHHZ[] JYTVVBPYNMT;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] MGYLSNOLPZY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong KZRDAMSNULS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int AUBFRNVZHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string DITHQNMSPPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private SBIVDNZEHHZ[] VHPGIUYOUGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] UDLNAROFZWQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int JTKNTDYULGQ;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x9298650", Offset = "0x9297650", VA = "0x189298650")]
			public SBIVDNZEHHZ(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9298090", Offset = "0x9297090", VA = "0x189298090")]
			public SBIVDNZEHHZ Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x9298290", Offset = "0x9297290", VA = "0x189298290")]
			public SBIVDNZEHHZ Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x92983B0", Offset = "0x92973B0", VA = "0x1892983B0")]
			public SBIVDNZEHHZ FRBVTPSQCXP(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x92982F0", Offset = "0x92972F0", VA = "0x1892982F0")]
			internal static int BYDFOXHJBLS(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x9298380", Offset = "0x9297380", VA = "0x189298380", Slot = "4")]
			public int CompareTo(SBIVDNZEHHZ other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x9298520", Offset = "0x9297520", VA = "0x189298520")]
			[IteratorStateMachine(typeof(TIXZJDXIDOH))]
			public IEnumerable<SBIVDNZEHHZ> XBJDCNHOHCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class RERECGRWLBT : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int FMHFHEECSRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<SBIVDNZEHHZ> VHPGIUYOUGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<SBIVDNZEHHZ> XUCWXPFGGFW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<SBIVDNZEHHZ> WEJFWHVNYIV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private SBIVDNZEHHZ UXRAHEZWYZO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> WDYSBUHTFMD;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> RUIVYWFOUBQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0xCD6080", Offset = "0xCD5080", VA = "0x180CD6080", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x9297BD0", Offset = "0x9296BD0", VA = "0x189297BD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xCD6200", Offset = "0xCD5200", VA = "0x180CD6200")]
			[DebuggerHidden]
			public RERECGRWLBT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x9297A80", Offset = "0x9296A80", VA = "0x189297A80", Slot = "7")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x9297620", Offset = "0x9296620", VA = "0x189297620", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x9297C70", Offset = "0x9296C70", VA = "0x189297C70")]
			private void ZLAPFDWYPLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x9297C20", Offset = "0x9296C20", VA = "0x189297C20")]
			private void ZKVIHXDBGAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x9297540", Offset = "0x9296540", VA = "0x189297540", Slot = "10")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x9297580", Offset = "0x9296580", VA = "0x189297580", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> NDYTMIHJKQN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x9297580", Offset = "0x9296580", VA = "0x189297580", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator JZJZEHYLQOE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly SBIVDNZEHHZ IMODBVGEZXP;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9299000", Offset = "0x9298000", VA = "0x189299000")]
		public SNRRBOIZBIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x92987B0", Offset = "0x92977B0", VA = "0x1892987B0")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9298CD0", Offset = "0x9297CD0", VA = "0x189298CD0")]
		public bool HAJBBFYHMJF(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9298E60", Offset = "0x9297E60", VA = "0x189298E60")]
		public bool TDRQTGOAUWG([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9298F70", Offset = "0x9297F70", VA = "0x189298F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9298990", Offset = "0x9297990", VA = "0x189298990")]
		private static void ETIRAQASTCC(IEnumerable<SBIVDNZEHHZ> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9298C70", Offset = "0x9297C70", VA = "0x189298C70", Slot = "5")]
		private IEnumerator JZJZEHYLQOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9298C70", Offset = "0x9297C70", VA = "0x189298C70", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9298DE0", Offset = "0x9297DE0", VA = "0x189298DE0")]
		[IteratorStateMachine(typeof(RERECGRWLBT))]
		private static IEnumerable<KeyValuePair<string, int>> NCPNZKDMTMZ(IEnumerable<SBIVDNZEHHZ> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class UJDQGOJKTRK
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo JXUVCEDSQTJ;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x929A5F0", Offset = "0x92995F0", VA = "0x18929A5F0")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x929A190", Offset = "0x9299190", VA = "0x18929A190")]
		public static ulong BZBPBLDMQSD(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class TCNQMOJJOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x92998D0", Offset = "0x92988D0", VA = "0x1892998D0")]
		public static void JLGLSOTVVZB(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9299A10", Offset = "0x9298A10", VA = "0x189299A10")]
		public static void TQMRVEINVCD(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9299790", Offset = "0x9298790", VA = "0x189299790")]
		public static byte[] BKWREGDJWPK(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class FUTTLMVGFNO<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x4A9AC00", Offset = "0x4A99C00", VA = "0x184A9AC00", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class OZWJMSEEGHS : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int WDQRLRKBTGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> IGHQXRUYHSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public FUTTLMVGFNO<a> FOYWNDAXKGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] WEJFWHVNYIV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int WDTLENNVWAU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] WDYSBUHTFMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int WDIXKAABDEC;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> GJTMECMNIKZ
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xCD6080", Offset = "0xCD5080", VA = "0x180CD6080", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object UQAIKHVHSEP
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0x5158230", Offset = "0x5157230", VA = "0x185158230", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
			[DebuggerHidden]
			public OZWJMSEEGHS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
			[DebuggerHidden]
			private void PRJHWGPKORK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x5CD90E0", Offset = "0x5CD80E0", VA = "0x185CD90E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x405A760", Offset = "0x4059760", VA = "0x18405A760", Slot = "8")]
			[DebuggerHidden]
			private void HJPFLPVTXYN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] YUXASSLOOUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong JKFZGPQXQEC;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool OQXQYBXDNSX;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x50D3F00", Offset = "0x50D2F00", VA = "0x1850D3F00")]
		public FUTTLMVGFNO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x50D3E10", Offset = "0x50D2E10", VA = "0x1850D3E10")]
		public FUTTLMVGFNO(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x50CCF30", Offset = "0x50CBF30", VA = "0x1850CCF30")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x50CE3D0", Offset = "0x50CD3D0", VA = "0x1850CE3D0")]
		private bool FKCGZBOYGEE(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x50D0C20", Offset = "0x50CFC20", VA = "0x1850D0C20")]
		public bool HAJBBFYHMJF([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x50D22E0", Offset = "0x50D12E0", VA = "0x1850D22E0")]
		private static ulong NYPKGNLETHX([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x50D23D0", Offset = "0x50D13D0", VA = "0x1850D23D0")]
		private static ulong NYPKGNLETHX([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x50D3D70", Offset = "0x50D2D70", VA = "0x1850D3D70")]
		private static int RQJFIUWXZKP(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x50D0890", Offset = "0x50CF890", VA = "0x1850D0890", Slot = "4")]
		[IteratorStateMachine(typeof(FUTTLMVGFNO<>.OZWJMSEEGHS))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x50D1F60", Offset = "0x50D0F60", VA = "0x1850D1F60", Slot = "5")]
		private IEnumerator JZJZEHYLQOE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class YWFUYFHEREB
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3F6AFC0", Offset = "0x3F69FC0", VA = "0x183F6AFC0")]
		public static Func<a> FDGGVYNKFYP<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3F6AF00", Offset = "0x3F69F00", VA = "0x183F6AF00")]
		private static c BJDJEMSSPEY<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0x9289450", Offset = "0x9288450", VA = "0x189289450")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9289460", Offset = "0x9288460", VA = "0x189289460")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9288A60", Offset = "0x9287A60", VA = "0x189288A60")]
		private static byte BMXZHYVEDPG(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9286220", Offset = "0x9285220", VA = "0x189286220")]
		private static byte PYKVPHWEEUM(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9288B00", Offset = "0x9287B00", VA = "0x189288B00")]
		public void UHEUJRAAHAM(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class JBRKAMOXTJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x928D7E0", Offset = "0x928C7E0", VA = "0x18928D7E0")]
		public static bool DXPGNYYVSPG(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x928E260", Offset = "0x928D260", VA = "0x18928E260")]
		public static bool UKWTWMUSPQF(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x928E140", Offset = "0x928D140", VA = "0x18928E140")]
		public static sbyte QDRCETRPEAE([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x928E1A0", Offset = "0x928D1A0", VA = "0x18928E1A0")]
		public static short SJBPOMIMJBP([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x928D890", Offset = "0x928C890", VA = "0x18928D890")]
		public static int EGDCMZPCGED([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x928E330", Offset = "0x928D330", VA = "0x18928E330")]
		public static long YHUFBHAOWOE([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x928DC70", Offset = "0x928CC70", VA = "0x18928DC70")]
		public static bool JMDDNVWKCDT(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x928D950", Offset = "0x928C950", VA = "0x18928D950")]
		public static byte IEQZPHFXYYD([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x928D8F0", Offset = "0x928C8F0", VA = "0x18928D8F0")]
		public static ushort FTNEVOFUXZI([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x928E200", Offset = "0x928D200", VA = "0x18928E200")]
		public static uint TOJCCQJGNKY([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x928E4D0", Offset = "0x928D4D0", VA = "0x18928E4D0")]
		public static ulong ZTZNTSMCYTJ([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x928D690", Offset = "0x928C690", VA = "0x18928D690")]
		public static bool DIUJCSPAFBW(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x928DAA0", Offset = "0x928CAA0", VA = "0x18928DAA0")]
		public static bool JLFLSLXTKBE(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x928DFD0", Offset = "0x928CFD0", VA = "0x18928DFD0")]
		public static bool NDMBQBOGYEI(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x928D7F0", Offset = "0x928C7F0", VA = "0x18928D7F0")]
		public static bool EEOPXWABMBE(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x928D9B0", Offset = "0x928C9B0", VA = "0x18928D9B0")]
		public static float ISZZFPXOZHL([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x928E0E0", Offset = "0x928D0E0", VA = "0x18928E0E0")]
		public static bool OCUEQSSLNQO(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x928E3E0", Offset = "0x928D3E0", VA = "0x18928E3E0")]
		public static double ZIXNVOJGRKU([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x928E2D0", Offset = "0x928D2D0", VA = "0x18928E2D0")]
		public static bool WMCXDPIPJQT(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9286EF0", Offset = "0x9285EF0", VA = "0x189286EF0")]
		public static int ZGLZPJZMLBU(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9286480", Offset = "0x9285480", VA = "0x189286480")]
		public static int ONWEXGBUCLF(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x928DE00", Offset = "0x928CE00", VA = "0x18928DE00")]
		public static bool MJXGEPBQUPV([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class XVDSZUHWJUW
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x929AB80", Offset = "0x9299B80", VA = "0x18929AB80")]
		public static bool ZMPSMRTETLO(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class HUOVBYJHOIZ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding NMEIVLLDFSW;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class QIPLHKCZCZD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x928D460", Offset = "0x928C460", VA = "0x18928D460")]
		public static void ZNBGLLBWGNU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x928D4D0", Offset = "0x928C4D0", VA = "0x18928D4D0")]
		public static void ZNGNIRVTPZD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x928D380", Offset = "0x928C380", VA = "0x18928D380")]
		public static void ZMQSQXOBNRC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x928D3F0", Offset = "0x928C3F0", VA = "0x18928D3F0")]
		public static void ZMVZOEHYXCL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9296AA0", Offset = "0x9295AA0", VA = "0x189296AA0")]
		public static void ZMGEWKAGUUK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9296B10", Offset = "0x9295B10", VA = "0x189296B10")]
		public static void ZMLLTQUEEFT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x92962D0", Offset = "0x92952D0", VA = "0x1892962D0")]
		public static void GTVJGJAVJZB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9296260", Offset = "0x9295260", VA = "0x189296260")]
		public static void GTQCJCGYANS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x92963C0", Offset = "0x92953C0", VA = "0x1892963C0")]
		public static void GUFXAWOQCVT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9296340", Offset = "0x9295340", VA = "0x189296340")]
		public static void GUAQDPUSTKK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x92960E0", Offset = "0x92950E0", VA = "0x1892960E0")]
		public static void GTAHRHZFYFR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9296060", Offset = "0x9295060", VA = "0x189296060")]
		public static void GSVAUBFIOUI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x92961E0", Offset = "0x92951E0", VA = "0x1892961E0")]
		public static void GTKVLVNARCJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9296160", Offset = "0x9295160", VA = "0x189296160")]
		public static void GTFOOOTDHRA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9295FE0", Offset = "0x9294FE0", VA = "0x189295FE0")]
		public static void GSFGCGXQMMH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9295F60", Offset = "0x9294F60", VA = "0x189295F60")]
		public static void GRZZFADTDAY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9296660", Offset = "0x9295660", VA = "0x189296660")]
		public static void MRTSXOBOASI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x92966E0", Offset = "0x92956E0", VA = "0x1892966E0")]
		public static void MRYZUUVLKDR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9296760", Offset = "0x9295760", VA = "0x189296760")]
		public static void MSEGSBPITPA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x92967E0", Offset = "0x92957E0", VA = "0x1892967E0")]
		public static void MSJNPIJGDAJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9296430", Offset = "0x9295430", VA = "0x189296430")]
		public static void MQYRIMZYOYY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x92964B0", Offset = "0x92954B0", VA = "0x1892964B0")]
		public static void MRDYFTTVYKH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9296540", Offset = "0x9295540", VA = "0x189296540")]
		public static void MRJFDANTHVQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x92965D0", Offset = "0x92955D0", VA = "0x1892965D0")]
		public static void MROMAHHQRGZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9296860", Offset = "0x9295860", VA = "0x189296860")]
		public static void MTJWBQESYFC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x92968F0", Offset = "0x92958F0", VA = "0x1892968F0")]
		public static void MTPCYWYQHQL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9296A10", Offset = "0x9295A10", VA = "0x189296A10")]
		public static void SSMZIYKQEOJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9296980", Offset = "0x9295980", VA = "0x189296980")]
		public static void SSHSLRQSVDA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x928D620", Offset = "0x928C620", VA = "0x18928D620")]
		public static void ZOBOXSXJBSN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x928D540", Offset = "0x928C540", VA = "0x18928D540")]
		public static void ZNLUFYPQZKM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x928D5B0", Offset = "0x928C5B0", VA = "0x18928D5B0")]
		public static void ZNRBDFJOIVV(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class IKMIHYKVZQS
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x928D2A0", Offset = "0x928C2A0", VA = "0x18928D2A0")]
		public static void ZMGEWKAGUUK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x928D310", Offset = "0x928C310", VA = "0x18928D310")]
		public static void ZMLLTQUEEFT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x928CB50", Offset = "0x928BB50", VA = "0x18928CB50")]
		public static void GTVJGJAVJZB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x928CAE0", Offset = "0x928BAE0", VA = "0x18928CAE0")]
		public static void GTQCJCGYANS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x928CC30", Offset = "0x928BC30", VA = "0x18928CC30")]
		public static void GUFXAWOQCVT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x928CBC0", Offset = "0x928BBC0", VA = "0x18928CBC0")]
		public static void GUAQDPUSTKK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x928C980", Offset = "0x928B980", VA = "0x18928C980")]
		public static void GTAHRHZFYFR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x928C910", Offset = "0x928B910", VA = "0x18928C910")]
		public static void GSVAUBFIOUI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x928CA70", Offset = "0x928BA70", VA = "0x18928CA70")]
		public static void GTKVLVNARCJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x928C9F0", Offset = "0x928B9F0", VA = "0x18928C9F0")]
		public static void GTFOOOTDHRA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x928C890", Offset = "0x928B890", VA = "0x18928C890")]
		public static void GSFGCGXQMMH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x928C810", Offset = "0x928B810", VA = "0x18928C810")]
		public static void GRZZFADTDAY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x928CEA0", Offset = "0x928BEA0", VA = "0x18928CEA0")]
		public static void MRTSXOBOASI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x928CF20", Offset = "0x928BF20", VA = "0x18928CF20")]
		public static void MRYZUUVLKDR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x928CFA0", Offset = "0x928BFA0", VA = "0x18928CFA0")]
		public static void MSEGSBPITPA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x928D020", Offset = "0x928C020", VA = "0x18928D020")]
		public static void MSJNPIJGDAJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x928CCA0", Offset = "0x928BCA0", VA = "0x18928CCA0")]
		public static void MQYRIMZYOYY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x928CD20", Offset = "0x928BD20", VA = "0x18928CD20")]
		public static void MRDYFTTVYKH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x928CDA0", Offset = "0x928BDA0", VA = "0x18928CDA0")]
		public static void MRJFDANTHVQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x928CE20", Offset = "0x928BE20", VA = "0x18928CE20")]
		public static void MROMAHHQRGZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x928D0A0", Offset = "0x928C0A0", VA = "0x18928D0A0")]
		public static void MTJWBQESYFC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x928D120", Offset = "0x928C120", VA = "0x18928D120")]
		public static void MTPCYWYQHQL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x928D220", Offset = "0x928C220", VA = "0x18928D220")]
		public static void SSMZIYKQEOJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x928D1A0", Offset = "0x928C1A0", VA = "0x18928D1A0")]
		public static void SSHSLRQSVDA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x928D620", Offset = "0x928C620", VA = "0x18928D620")]
		public static void ZOBOXSXJBSN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x928D540", Offset = "0x928C540", VA = "0x18928D540")]
		public static void ZNLUFYPQZKM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x928D5B0", Offset = "0x928C5B0", VA = "0x18928D5B0")]
		public static void ZNRBDFJOIVV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x928D460", Offset = "0x928C460", VA = "0x18928D460")]
		public static void ZNBGLLBWGNU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x928D4D0", Offset = "0x928C4D0", VA = "0x18928D4D0")]
		public static void ZNGNIRVTPZD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x928D380", Offset = "0x928C380", VA = "0x18928D380")]
		public static void ZMQSQXOBNRC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x928D3F0", Offset = "0x928C3F0", VA = "0x18928D3F0")]
		public static void ZMVZOEHYXCL(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class QYVBLJQSLLC
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool OQXQYBXDNSX;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x92A9420", Offset = "0x92A8420", VA = "0x1892A9420")]
		public static void KLNKYBTNUJM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x92A9390", Offset = "0x92A8390", VA = "0x1892A9390")]
		public static void FVNVCTZRWVV(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x2B64950", Offset = "0x2B63950", VA = "0x182B64950")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x929DA20", Offset = "0x929CA20", VA = "0x18929DA20")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x929D850", Offset = "0x929C850", VA = "0x18929D850")]
		public static DiyFp EANHITSJHEP(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x929D900", Offset = "0x929C900", VA = "0x18929D900")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x929D860", Offset = "0x929C860", VA = "0x18929D860")]
		public static DiyFp LGOZXMXOPOJ(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x929D9E0", Offset = "0x929C9E0", VA = "0x18929D9E0")]
		public void RNUJPSZPLXO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x929D990", Offset = "0x929C990", VA = "0x18929D990")]
		public static DiyFp RNUJPSZPLXO(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xE73B10", Offset = "0xE72B10", VA = "0x180E73B10")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x92AC660", Offset = "0x92AB660", VA = "0x1892AC660")]
		public void EEPPMFLQIGL(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x92AC8E0", Offset = "0x92AB8E0", VA = "0x1892AC8E0")]
		public void WDDGHBPEHLX(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x92AC760", Offset = "0x92AB760", VA = "0x1892AC760")]
		public void KIHVPZKRMKH(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x92AC6C0", Offset = "0x92AB6C0", VA = "0x1892AC6C0")]
		public void KIHVPZKRMKH(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x92AC960", Offset = "0x92AB960", VA = "0x1892AC960")]
		public void WTANZOMRJRH(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x92AC7E0", Offset = "0x92AB7E0", VA = "0x1892AC7E0")]
		public void TMBVZTZDLXC(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class FMATKQDNQFC
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
		private static byte[] SOKRXONISUB;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] PVKHXJRIIMN;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] NONIMOTFRCL;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] ZPMCQJKKDSU;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags HONPCLGLYEF;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char GZIBHRDJUMD;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int XHCLJJPGRCB;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int XIXEFXQPCBR;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] ACALCPIEIUR;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x929FFD0", Offset = "0x929EFD0", VA = "0x18929FFD0")]
		private static byte[] TXXWWIWVVZV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x929E600", Offset = "0x929D600", VA = "0x18929E600")]
		private static byte[] CHPJMNWYNGX(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x929F830", Offset = "0x929E830", VA = "0x18929F830")]
		public static int OOTZXUDEDPE(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x929F710", Offset = "0x929E710", VA = "0x18929F710")]
		public static int OOTZXUDEDPE(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x929F950", Offset = "0x929E950", VA = "0x18929F950")]
		private static bool QEUWQUOCZDU(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x929FEE0", Offset = "0x929EEE0", VA = "0x18929FEE0")]
		private static void TBVLDIUCUNE(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x929E8D0", Offset = "0x929D8D0", VA = "0x18929E8D0")]
		private static bool DJDGFTOWSHS(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x929F0C0", Offset = "0x929E0C0", VA = "0x18929F0C0")]
		private static bool KSHHXBHHGIM(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x929FDE0", Offset = "0x929EDE0", VA = "0x18929FDE0")]
		private static bool SXHEDJEQSRF(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x929F540", Offset = "0x929E540", VA = "0x18929F540")]
		private static bool OEPWNQWWDMQ(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x92A00A0", Offset = "0x929F0A0", VA = "0x1892A00A0")]
		private static bool ZBDRBHFOZNB(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x929FA40", Offset = "0x929EA40", VA = "0x18929FA40")]
		private static void RVWREFHNEGB(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x929EC90", Offset = "0x929DC90", VA = "0x18929EC90")]
		private static void FNFAEUCVZKJ(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x929E6E0", Offset = "0x929D6E0", VA = "0x18929E6E0")]
		private static bool CSOTSIJHYSE(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0x929E050", Offset = "0x929D050", VA = "0x18929E050")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x929DFB0", Offset = "0x929CFB0", VA = "0x18929DFB0")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x929DF40", Offset = "0x929CF40", VA = "0x18929DF40")]
		public DiyFp ZNPZDTOULOP()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x929DA30", Offset = "0x929CA30", VA = "0x18929DA30")]
		public DiyFp AHWNAAFNYYA()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xC10050", Offset = "0xC0F050", VA = "0x180C10050")]
		public ulong PAAQFEJECFV()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x929DD30", Offset = "0x929CD30", VA = "0x18929DD30")]
		public double MKOPAOIHGZH()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x929DC10", Offset = "0x929CC10", VA = "0x18929DC10")]
		public double CSTTSFDZPNT()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x929DD00", Offset = "0x929CD00", VA = "0x18929DD00")]
		public int ISAWNYKCEAC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x929DE40", Offset = "0x929CE40", VA = "0x18929DE40")]
		public ulong SHCCDBGMTKM()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x929DCB0", Offset = "0x929CCB0", VA = "0x18929DCB0")]
		public bool IECQPDQEHTD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x929DE70", Offset = "0x929CE70", VA = "0x18929DE70")]
		public bool VAMHDXXHVHS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x929DEF0", Offset = "0x929CEF0", VA = "0x18929DEF0")]
		public bool XYVEOFSZKDA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x929DCD0", Offset = "0x929CCD0", VA = "0x18929DCD0")]
		public bool IQBCWPUGHDX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x929DAB0", Offset = "0x929CAB0", VA = "0x18929DAB0")]
		public int AUSHZHKXSFO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x929DAD0", Offset = "0x929CAD0", VA = "0x18929DAD0")]
		public void AUYYOIKMWOG([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x929DEA0", Offset = "0x929CEA0", VA = "0x18929DEA0")]
		public bool WCRORDFRQXI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3EFEE20", Offset = "0x3EFDE20", VA = "0x183EFEE20")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x929DF20", Offset = "0x929CF20", VA = "0x18929DF20")]
		public static int YRGUQPKZZXH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x929DE90", Offset = "0x929CE90", VA = "0x18929DE90")]
		public static double VRXHIONAMFD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x929DDB0", Offset = "0x929CDB0", VA = "0x18929DDB0")]
		public static ulong RXZYCUELYSQ(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x2DD1C40", Offset = "0x2DD0C40", VA = "0x182DD1C40")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x92AC600", Offset = "0x92AB600", VA = "0x1892AC600")]
		public DiyFp ZNPZDTOULOP()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xDCFD90", Offset = "0xDCED90", VA = "0x180DCFD90")]
		public uint JAWREKTBGWM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x92AC580", Offset = "0x92AB580", VA = "0x1892AC580")]
		public int ISAWNYKCEAC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x92AC5A0", Offset = "0x92AB5A0", VA = "0x1892AC5A0")]
		public uint SHCCDBGMTKM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x92AC570", Offset = "0x92AB570", VA = "0x1892AC570")]
		public bool IECQPDQEHTD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x92AC440", Offset = "0x92AB440", VA = "0x1892AC440")]
		public void AUYYOIKMWOG([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x92AC5C0", Offset = "0x92AB5C0", VA = "0x1892AC5C0")]
		public bool WCRORDFRQXI()
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
		[Cpp2IlInjected.Address(RVA = "0x929D110", Offset = "0x929C110", VA = "0x18929D110")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class ZQMXYTCDOLX
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] SCPPGBQIFGG;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x92B4800", Offset = "0x92B3800", VA = "0x1892B4800")]
		public static void DLTVXVBJKWI(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x92B4910", Offset = "0x92B3910", VA = "0x1892B4910")]
		public static void EWBTSTPVICT(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0x92AF730", Offset = "0x92AE730", VA = "0x1892AF730")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5B3F940", Offset = "0x5B3E940", VA = "0x185B3F940")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2D96EB0", Offset = "0x2D95EB0", VA = "0x182D96EB0")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x92AF6D0", Offset = "0x92AE6D0", VA = "0x1892AF6D0")]
		public Vector KREAMSLJTOO(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class YLFARKQAWMI
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] GUONEPOHASW;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] UBMVYRRWVEN;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int JYRPZIVLLLC;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x92B2DE0", Offset = "0x92B1DE0", VA = "0x1892B2DE0")]
		private static byte[] ROCCBPZLMGQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x92B2170", Offset = "0x92B1170", VA = "0x1892B2170")]
		private static Vector BNRHIRWEQWQ(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x92B2D00", Offset = "0x92B1D00", VA = "0x1892B2D00")]
		private static Vector QXZYTLTKRBC(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x92B2980", Offset = "0x92B1980", VA = "0x1892B2980")]
		private static void OWRDJLGTWJL(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x92B2A10", Offset = "0x92B1A10", VA = "0x1892B2A10")]
		private static void QPRFZOZINXE(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x92B28F0", Offset = "0x92B18F0", VA = "0x1892B28F0")]
		private static ulong ORZALDJSHMT(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x92B2EC0", Offset = "0x92B1EC0", VA = "0x1892B2EC0")]
		private static void WFCOEIPUICL(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x92B3640", Offset = "0x92B2640", VA = "0x1892B3640")]
		private static bool ZXMZAVFCQCC(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x92B2370", Offset = "0x92B1370", VA = "0x1892B2370")]
		private static DiyFp EMTBONYVLWV(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x92B3000", Offset = "0x92B2000", VA = "0x1892B3000")]
		private static bool XNFVZPCPNOF(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x92B2250", Offset = "0x92B1250", VA = "0x1892B2250")]
		private static bool DSTSZKDWFXJ(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x92B2500", Offset = "0x92B1500", VA = "0x1892B2500")]
		public static double? OEVSKTQQSVZ(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x92B2620", Offset = "0x92B1620", VA = "0x1892B2620")]
		public static float? OFGGFHELLSR(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class XHRPHFPBPII
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] SSPIOXZJYIA;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] NONIMOTFRCL;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] ZPMCQJKKDSU;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] XSTUJVEXFXI;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int SEIOJFAUVPU;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] MYMQKIRJKWO;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int EDIZZSOWHDU;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x92AFE90", Offset = "0x92AEE90", VA = "0x1892AFE90")]
		private static byte[] JDAIBRHSROZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x92B0380", Offset = "0x92AF380", VA = "0x1892B0380")]
		public static bool OCUEQSSLNQO(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x92B1520", Offset = "0x92B0520", VA = "0x1892B1520")]
		public static bool WMCXDPIPJQT(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x92AFF70", Offset = "0x92AEF70", VA = "0x1892AFF70")]
		private static bool NMUSVLOPQQE(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x92B00B0", Offset = "0x92AF0B0", VA = "0x1892B00B0")]
		private static bool OBMIFISJJFB(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x92B1660", Offset = "0x92B0660", VA = "0x1892B1660")]
		private static bool XEUFZUDDNPO(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x92B14B0", Offset = "0x92B04B0", VA = "0x1892B14B0")]
		private static bool UNRPFVLPRQA(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x92B1740", Offset = "0x92B0740", VA = "0x1892B1740")]
		private static double ZUJPRZGFUVF(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x92B04C0", Offset = "0x92AF4C0", VA = "0x1892B04C0")]
		private static double RQNNJLEFCWJ(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class RDFEUMOBSQP<a> : JDLSLJQPPOP<a[]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly AWILAUBSTOT<a> MKGCIQWXLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour IGJRVMGPDAQ;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x1A0F3E0", Offset = "0x1A0E3E0", VA = "0x181A0F3E0")]
		public RDFEUMOBSQP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
		public RDFEUMOBSQP(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC3C00", Offset = "0x5EC2C00", VA = "0x185EC3C00", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC3590", Offset = "0x5EC2590", VA = "0x185EC3590", Slot = "5")]
		public a[] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class KXSZQPBJIAU<a> : JDLSLJQPPOP<ArraySegment<a>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly AWILAUBSTOT<a> MKGCIQWXLGI;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5517E30", Offset = "0x5516E30", VA = "0x185517E30", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x55179C0", Offset = "0x55169C0", VA = "0x1855179C0", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class ZFTARPHXCBY<a> : JDLSLJQPPOP<List<a>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour IGJRVMGPDAQ;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1A0F3E0", Offset = "0x1A0E3E0", VA = "0x181A0F3E0")]
		public ZFTARPHXCBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAD7C10", Offset = "0xAD6C10", VA = "0x180AD7C10")]
		public ZFTARPHXCBY(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x41BC380", Offset = "0x41BB380", VA = "0x1841BC380", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x41BAAA0", Offset = "0x41B9AA0", VA = "0x1841BAAA0", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class ELNYIZXOMZK<a, b, c, d> : JDLSLJQPPOP<d>, AYGEWMYQSHO where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4A76DE0", Offset = "0x4A75DE0", VA = "0x184A76DE0", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x4A75940", Offset = "0x4A74940", VA = "0x184A75940", Slot = "5")]
		public d Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c CLSQKQBQGIY(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		protected ELNYIZXOMZK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class ELIRLTDRDOB<a, b, c> : ELNYIZXOMZK<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x4A75210", Offset = "0x4A74210", VA = "0x184A75210", Slot = "6")]
		protected override IEnumerator<a> CLSQKQBQGIY(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		protected ELIRLTDRDOB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class ELDKOMJTUCS<a, b> : ELIRLTDRDOB<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xB2FA50", Offset = "0xB2EA50", VA = "0x180B2FA50", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class NALUSJBWBIC<a, b> : ELDKOMJTUCS<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x5B58120", Offset = "0x5B57120", VA = "0x185B58120", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5B57FB0", Offset = "0x5B56FB0", VA = "0x185B57FB0", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class LUVGXHKANRX<a> : ELNYIZXOMZK<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x55DE140", Offset = "0x55DD140", VA = "0x1855DE140", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xB2FA50", Offset = "0xB2EA50", VA = "0x180B2FA50", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x55DE230", Offset = "0x55DD230", VA = "0x1855DE230", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x497D580", Offset = "0x497C580", VA = "0x18497D580", Slot = "6")]
		protected override LinkedList<a>.Enumerator CLSQKQBQGIY(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class XJYUZHWMOGY<a> : ELNYIZXOMZK<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4178F80", Offset = "0x4177F80", VA = "0x184178F80", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4179120", Offset = "0x4178120", VA = "0x184179120", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x4179070", Offset = "0x4178070", VA = "0x184179070", Slot = "6")]
		protected override Queue<a>.Enumerator CLSQKQBQGIY(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xB2FA50", Offset = "0xB2EA50", VA = "0x180B2FA50", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class CMVMXUDAIQM<a> : ELNYIZXOMZK<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x4224640", Offset = "0x4223640", VA = "0x184224640", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4224950", Offset = "0x4223950", VA = "0x184224950", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4224720", Offset = "0x4223720", VA = "0x184224720", Slot = "6")]
		protected override Stack<a>.Enumerator CLSQKQBQGIY(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x42247D0", Offset = "0x42237D0", VA = "0x1842247D0", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class RWUUNMWVJDC<a> : ELNYIZXOMZK<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x5EECC40", Offset = "0x5EEBC40", VA = "0x185EECC40", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xB2FA50", Offset = "0xB2EA50", VA = "0x180B2FA50", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5EECCD0", Offset = "0x5EEBCD0", VA = "0x185EECCD0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x5EECC80", Offset = "0x5EEBC80", VA = "0x185EECC80", Slot = "6")]
		protected override HashSet<a>.Enumerator CLSQKQBQGIY(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x55CC960", Offset = "0x55CB960", VA = "0x1855CC960")]
		public RWUUNMWVJDC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class UJJDXMQADHC<a> : ELIRLTDRDOB<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x4224640", Offset = "0x4223640", VA = "0x184224640", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x65A7D10", Offset = "0x65A6D10", VA = "0x1865A7D10", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x65A7DB0", Offset = "0x65A6DB0", VA = "0x1865A7DB0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class GQWBBQQEWRD<a> : ELIRLTDRDOB<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x4178F80", Offset = "0x4177F80", VA = "0x184178F80", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x4179120", Offset = "0x4178120", VA = "0x184179120", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB2FA50", Offset = "0xB2EA50", VA = "0x180B2FA50", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class SJXIIQUBSMB<a> : ELIRLTDRDOB<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x4178F80", Offset = "0x4177F80", VA = "0x184178F80", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x4179120", Offset = "0x4178120", VA = "0x184179120", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB2FA50", Offset = "0xB2EA50", VA = "0x180B2FA50", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class MRTPLGJHULN<a> : ELIRLTDRDOB<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5AE71B0", Offset = "0x5AE61B0", VA = "0x185AE71B0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x4224950", Offset = "0x4223950", VA = "0x184224950", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x526F200", Offset = "0x526E200", VA = "0x18526F200", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x526F250", Offset = "0x526E250", VA = "0x18526F250")]
		public MRTPLGJHULN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class YUDXQTVMJXZ<a, b> : JDLSLJQPPOP<IGrouping<a, b>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x41A0710", Offset = "0x419F710", VA = "0x1841A0710", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x41A03A0", Offset = "0x419F3A0", VA = "0x1841A03A0", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class YEUYYZYPNHI<a, b> : JDLSLJQPPOP<ILookup<a, b>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x4198260", Offset = "0x4197260", VA = "0x184198260", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x4197EF0", Offset = "0x4196EF0", VA = "0x184197EF0", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class XCLLMRFIQXA<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a VBWKGQRZQUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> OPPONUNZLGQ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x40F7BB0", Offset = "0x40F6BB0", VA = "0x1840F7BB0", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x41582E0", Offset = "0x41572E0", VA = "0x1841582E0")]
		public XCLLMRFIQXA(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x41581E0", Offset = "0x41571E0", VA = "0x1841581E0", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x41582B0", Offset = "0x41572B0", VA = "0x1841582B0", Slot = "6")]
		private IEnumerator JZJZEHYLQOE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class CEPPOKORLSN<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> UJEMGGIUHRD;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x420C4D0", Offset = "0x420B4D0", VA = "0x18420C4D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public CEPPOKORLSN(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x420C320", Offset = "0x420B320", VA = "0x18420C320", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x420C420", Offset = "0x420B420", VA = "0x18420C420", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x420C420", Offset = "0x420B420", VA = "0x18420C420", Slot = "7")]
		private IEnumerator JZJZEHYLQOE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class CYNACWUPTQK<a> : JDLSLJQPPOP<a>, AYGEWMYQSHO where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4236160", Offset = "0x4235160", VA = "0x184236160", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4235F40", Offset = "0x4234F40", VA = "0x184235F40", Slot = "5")]
		public a Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public CYNACWUPTQK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class TYVYKEANGYE : JDLSLJQPPOP<IEnumerable>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly JDLSLJQPPOP<IEnumerable> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x92ACDE0", Offset = "0x92ABDE0", VA = "0x1892ACDE0", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x92ACBD0", Offset = "0x92ABBD0", VA = "0x1892ACBD0", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public TYVYKEANGYE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class OJTSAVILNLA : JDLSLJQPPOP<ICollection>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly JDLSLJQPPOP<ICollection> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x92A6560", Offset = "0x92A5560", VA = "0x1892A6560", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x92A6350", Offset = "0x92A5350", VA = "0x1892A6350", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public OJTSAVILNLA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class AQIYXDOUBAK : JDLSLJQPPOP<IList>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly JDLSLJQPPOP<IList> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x929B490", Offset = "0x929A490", VA = "0x18929B490", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x929B280", Offset = "0x929A280", VA = "0x18929B280", Slot = "5")]
		public IList Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public AQIYXDOUBAK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class CTELXZQKZPP<a> : ELDKOMJTUCS<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x4178F80", Offset = "0x4177F80", VA = "0x184178F80", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x422BC90", Offset = "0x422AC90", VA = "0x18422BC90", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class WSSTSAJLQCH<a> : ELIRLTDRDOB<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x4178F80", Offset = "0x4177F80", VA = "0x184178F80", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x422BC90", Offset = "0x422AC90", VA = "0x18422BC90", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6A5DD90", Offset = "0x6A5CD90", VA = "0x186A5DD90", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class PYXMICKXNMH<a> : ELIRLTDRDOB<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x526F1C0", Offset = "0x526E1C0", VA = "0x18526F1C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x4224950", Offset = "0x4223950", VA = "0x184224950", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x5DBF620", Offset = "0x5DBE620", VA = "0x185DBF620", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x5DBF6C0", Offset = "0x5DBE6C0", VA = "0x185DBF6C0")]
		public PYXMICKXNMH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class HODTDBTEFOX<a> : ELIRLTDRDOB<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x526F1C0", Offset = "0x526E1C0", VA = "0x18526F1C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x4224950", Offset = "0x4223950", VA = "0x184224950", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x526F200", Offset = "0x526E200", VA = "0x18526F200", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x526F250", Offset = "0x526E250", VA = "0x18526F250")]
		public HODTDBTEFOX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class UFMPGFTSNUJ<a> : ELIRLTDRDOB<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x5EECB50", Offset = "0x5EEBB50", VA = "0x185EECB50", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xB2FA50", Offset = "0xB2EA50", VA = "0x180B2FA50", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x55DE230", Offset = "0x55DD230", VA = "0x1855DE230", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class UFDLPIFMGYL<a> : ELDKOMJTUCS<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x4178F80", Offset = "0x4177F80", VA = "0x184178F80", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x4179120", Offset = "0x4178120", VA = "0x184179120", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class ADJRALCCHUE<a> : ELDKOMJTUCS<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4178F80", Offset = "0x4177F80", VA = "0x184178F80", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x4179120", Offset = "0x4178120", VA = "0x184179120", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class EXGLOVWPOQB<a> : ELIRLTDRDOB<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x4224640", Offset = "0x4223640", VA = "0x184224640", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x4224950", Offset = "0x4223950", VA = "0x184224950", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4A823C0", Offset = "0x4A813C0", VA = "0x184A823C0", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class VGZOMIGCDAU
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
		[Cpp2IlInjected.Address(RVA = "0x92ADDA0", Offset = "0x92ACDA0", VA = "0x1892ADDA0")]
		public static DateTime PKNDECNCXGM(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x92ADBF0", Offset = "0x92ACBF0", VA = "0x1892ADBF0")]
		public static bool BPNVPMISRGP(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x92AE2A0", Offset = "0x92AD2A0", VA = "0x1892AE2A0")]
		public static bool VJGTPSESNUX(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x92AE090", Offset = "0x92AD090", VA = "0x1892AE090")]
		public static bool VJGTPSESNUX(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x92ADE60", Offset = "0x92ACE60", VA = "0x1892ADE60")]
		public static bool UFDROKERADP(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class VRJVAFEJISU : JDLSLJQPPOP<DateTime>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly JDLSLJQPPOP<DateTime> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x92AEAB0", Offset = "0x92ADAB0", VA = "0x1892AEAB0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x92AE930", Offset = "0x92AD930", VA = "0x1892AE930", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x92AE530", Offset = "0x92AD530", VA = "0x1892AE530")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public VRJVAFEJISU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class HTRQIIPNWUR : JDLSLJQPPOP<DateTimeOffset>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly JDLSLJQPPOP<DateTimeOffset> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x92A11F0", Offset = "0x92A01F0", VA = "0x1892A11F0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x92A1180", Offset = "0x92A0180", VA = "0x1892A1180", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x92A0DA0", Offset = "0x929FDA0", VA = "0x1892A0DA0")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public HTRQIIPNWUR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class PKLZMLHJJZW : JDLSLJQPPOP<TimeSpan>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly JDLSLJQPPOP<TimeSpan> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] FITHZUIJCQI;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x92A7A20", Offset = "0x92A6A20", VA = "0x1892A7A20", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x92A79A0", Offset = "0x92A69A0", VA = "0x1892A79A0", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x92A75B0", Offset = "0x92A65B0", VA = "0x1892A75B0")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public PKLZMLHJJZW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class RQMLKQZCCOX<a, b, c, d, e> : JDLSLJQPPOP<e>, AYGEWMYQSHO where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5ED45B0", Offset = "0x5ED35B0", VA = "0x185ED45B0", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2700", Offset = "0x5ED1700", VA = "0x185ED2700", Slot = "5")]
		public e Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d CLSQKQBQGIY(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		protected RQMLKQZCCOX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class RQHENKFETDO<a, b, c, d> : RQMLKQZCCOX<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x4A75210", Offset = "0x4A74210", VA = "0x184A75210", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> CLSQKQBQGIY(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		protected RQHENKFETDO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class RRSAUFOMHEZ<a, b, c> : RQHENKFETDO<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xB2FA50", Offset = "0xB2EA50", VA = "0x180B2FA50", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class PMRBEQGZSWP<a, b> : RQMLKQZCCOX<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE9D0", Offset = "0x5DAD9D0", VA = "0x185DAE9D0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xB2FA50", Offset = "0xB2EA50", VA = "0x180B2FA50", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEE60", Offset = "0x5DADE60", VA = "0x185DAEE60", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEBC0", Offset = "0x5DADBC0", VA = "0x185DAEBC0", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator CLSQKQBQGIY(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x5634880", Offset = "0x5633880", VA = "0x185634880")]
		public PMRBEQGZSWP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class JSSVUNNJRLD<a, b, c> : RRSAUFOMHEZ<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5444610", Offset = "0x5443610", VA = "0x185444610", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5444810", Offset = "0x5443810", VA = "0x185444810", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class MCNMYOOPQYY<a, b> : RQHENKFETDO<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x55CC6E0", Offset = "0x55CB6E0", VA = "0x1855CC6E0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5445440", Offset = "0x5444440", VA = "0x185445440", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB2FA50", Offset = "0xB2EA50", VA = "0x180B2FA50", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class LQNCHIXGBRW<a, b> : RRSAUFOMHEZ<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x55CC6E0", Offset = "0x55CB6E0", VA = "0x1855CC6E0", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x5445440", Offset = "0x5444440", VA = "0x185445440", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class VRPGPTFHQRG<a, b> : RQMLKQZCCOX<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x55CC6E0", Offset = "0x55CB6E0", VA = "0x1855CC6E0", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB2FA50", Offset = "0xB2EA50", VA = "0x180B2FA50", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x5445440", Offset = "0x5444440", VA = "0x185445440", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x66F60B0", Offset = "0x66F50B0", VA = "0x1866F60B0", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator CLSQKQBQGIY(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class RYBFLIVFGLP<a, b> : RQHENKFETDO<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x55CC6E0", Offset = "0x55CB6E0", VA = "0x1855CC6E0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF3D0", Offset = "0x5EEE3D0", VA = "0x185EEF3D0", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF440", Offset = "0x5EEE440", VA = "0x185EEF440", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class LCCQRDLIZWW<a, b> : RQHENKFETDO<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x55CC860", Offset = "0x55CB860", VA = "0x1855CC860", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xB2FA50", Offset = "0xB2EA50", VA = "0x180B2FA50", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x55CC8A0", Offset = "0x55CB8A0", VA = "0x1855CC8A0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x55CC960", Offset = "0x55CB960", VA = "0x1855CC960")]
		public LCCQRDLIZWW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class JYYBFQMMEQM<a, b> : RRSAUFOMHEZ<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x54452B0", Offset = "0x54442B0", VA = "0x1854452B0", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5445440", Offset = "0x5444440", VA = "0x185445440", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class WXASHBGUVHQ<a> : JDLSLJQPPOP<a>, AYGEWMYQSHO where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A64730", Offset = "0x6A63730", VA = "0x186A64730", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A644F0", Offset = "0x6A634F0", VA = "0x186A644F0", Slot = "5")]
		public a Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public WXASHBGUVHQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class SWOKDKXDQVY : JDLSLJQPPOP<IDictionary>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly JDLSLJQPPOP<IDictionary> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x92AB9D0", Offset = "0x92AA9D0", VA = "0x1892AB9D0", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x92AB7F0", Offset = "0x92AA7F0", VA = "0x1892AB7F0", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public SWOKDKXDQVY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class MPRMVCDYRQK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x92A4EF0", Offset = "0x92A3EF0", VA = "0x1892A4EF0")]
		public static object CFWPCPLFQYQ(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x92A5730", Offset = "0x92A4730", VA = "0x1892A5730")]
		public static object LWNNKPDOHSR(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class QTHYLDOQERT<a> : JDLSLJQPPOP<a>, AYGEWMYQSHO, XJCFLGRTSJY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class YNXANUMFTWX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type DCVVHWLTKKV;

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public YNXANUMFTWX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x419CB70", Offset = "0x419BB70", VA = "0x18419CB70")]
			internal bool JBVXCRTALIA(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class YNRTQNSIKLO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string OUGWZQAKAIH;

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public YNRTQNSIKLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x419C1D0", Offset = "0x419B1D0", VA = "0x18419C1D0")]
			internal bool JCBDZYMXUTJ(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class YOHOIIAAMTP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> MMHLSUGBJCM;

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public YOHOIIAAMTP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x419EDA0", Offset = "0x419DDA0", VA = "0x18419EDA0")]
			internal void JCGKXFGVEES(JsonWriter a, a b, POKYTICTLCW c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class YOCHLBGDDIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> PUEEQZMHBZX;

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public YOCHLBGDDIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x419E520", Offset = "0x419D520", VA = "0x18419E520")]
			internal a JCLRUMASNQB(JsonReader a, POKYTICTLCW b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly FUTTLMVGFNO<a> UDPLJGEJTDF;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> DDFYVIEJNTD;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> JXEYZQJRUKH;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> TSQYMXPOMNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool IAPBCOLWANF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> ATPJUYQWBUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> WQMMRAJEYIP;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E64DD0", Offset = "0x5E63DD0", VA = "0x185E64DD0")]
		static QTHYLDOQERT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E70820", Offset = "0x5E6F820", VA = "0x185E70820")]
		public QTHYLDOQERT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E2C0", Offset = "0x5E5D2C0", VA = "0x185E5E2C0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B5D0", Offset = "0x5E5A5D0", VA = "0x185E5B5D0", Slot = "5")]
		public a Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CF90", Offset = "0x5E5BF90", VA = "0x185E5CF90", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, a b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F750", Offset = "0x5E5E750", VA = "0x185E5F750", Slot = "7")]
		public a VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class YTMPOEHVVLR<a> : JDLSLJQPPOP<a[,]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x419FAE0", Offset = "0x419EAE0", VA = "0x18419FAE0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x419F720", Offset = "0x419E720", VA = "0x18419F720", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public YTMPOEHVVLR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class BRACZQWMJAB<a> : JDLSLJQPPOP<a[,,]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x4059C90", Offset = "0x4058C90", VA = "0x184059C90", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x4059790", Offset = "0x4058790", VA = "0x184059790", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public BRACZQWMJAB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class LMTVTUOMZML<a> : JDLSLJQPPOP<a[,,,]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x55D0290", Offset = "0x55CF290", VA = "0x1855D0290", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x55CFC50", Offset = "0x55CEC50", VA = "0x1855CFC50", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public LMTVTUOMZML()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class WCAMTMKFIMB<a> : JDLSLJQPPOP<a?>, AYGEWMYQSHO where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6A46190", Offset = "0x6A45190", VA = "0x186A46190", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6A45D10", Offset = "0x6A44D10", VA = "0x186A45D10", Slot = "5")]
		public a? Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public WCAMTMKFIMB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class YULJMRUQOKP<a> : JDLSLJQPPOP<a?>, AYGEWMYQSHO where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly JDLSLJQPPOP<a> IPENUFPHRLW;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public YULJMRUQOKP(JDLSLJQPPOP<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x41A1D30", Offset = "0x41A0D30", VA = "0x1841A1D30", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x41A0A70", Offset = "0x419FA70", VA = "0x1841A0A70", Slot = "5")]
		public a? Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class ONGKFSFBQNQ : JDLSLJQPPOP<sbyte>, AYGEWMYQSHO, XJCFLGRTSJY<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly ONGKFSFBQNQ MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x92A6B30", Offset = "0x92A5B30", VA = "0x1892A6B30", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x92A6A10", Offset = "0x92A5A10", VA = "0x1892A6A10", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x92A6A20", Offset = "0x92A5A20", VA = "0x1892A6A20", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, sbyte b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x92A6BC0", Offset = "0x92A5BC0", VA = "0x1892A6BC0", Slot = "7")]
		public sbyte VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public ONGKFSFBQNQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class YUEJGKFHBQL : JDLSLJQPPOP<sbyte?>, AYGEWMYQSHO, XJCFLGRTSJY<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly YUEJGKFHBQL MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x92B4080", Offset = "0x92B3080", VA = "0x1892B4080", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x92B3EB0", Offset = "0x92B2EB0", VA = "0x1892B3EB0", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x92B3F20", Offset = "0x92B2F20", VA = "0x1892B3F20", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, sbyte? b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x92B4170", Offset = "0x92B3170", VA = "0x1892B4170", Slot = "7")]
		public sbyte? VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public YUEJGKFHBQL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class ARXNDCKTITT : JDLSLJQPPOP<sbyte[]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly ARXNDCKTITT MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x929B9E0", Offset = "0x929A9E0", VA = "0x18929B9E0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x929B8A0", Offset = "0x929A8A0", VA = "0x18929B8A0", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public ARXNDCKTITT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class XMLIBTXTVLD : JDLSLJQPPOP<short>, AYGEWMYQSHO, XJCFLGRTSJY<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly XMLIBTXTVLD MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x92B1FF0", Offset = "0x92B0FF0", VA = "0x1892B1FF0", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x92B1ED0", Offset = "0x92B0ED0", VA = "0x1892B1ED0", Slot = "5")]
		public short Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x92B1EE0", Offset = "0x92B0EE0", VA = "0x1892B1EE0", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, short b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x92B2080", Offset = "0x92B1080", VA = "0x1892B2080", Slot = "7")]
		public short VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public XMLIBTXTVLD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class GGUUUNDHBKM : JDLSLJQPPOP<short?>, AYGEWMYQSHO, XJCFLGRTSJY<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly GGUUUNDHBKM MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x92A09A0", Offset = "0x929F9A0", VA = "0x1892A09A0", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x92A07D0", Offset = "0x929F7D0", VA = "0x1892A07D0", Slot = "5")]
		public short? Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x92A0840", Offset = "0x929F840", VA = "0x1892A0840", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, short? b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x92A0A90", Offset = "0x929FA90", VA = "0x1892A0A90", Slot = "7")]
		public short? VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public GGUUUNDHBKM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class YOJOZZFISKM : JDLSLJQPPOP<short[]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly YOJOZZFISKM MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x92B3C10", Offset = "0x92B2C10", VA = "0x1892B3C10", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x92B3AD0", Offset = "0x92B2AD0", VA = "0x1892B3AD0", Slot = "5")]
		public short[] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public YOJOZZFISKM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class JRXLBVZGUHZ : JDLSLJQPPOP<int>, AYGEWMYQSHO, XJCFLGRTSJY<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly JRXLBVZGUHZ MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x92A3D00", Offset = "0x92A2D00", VA = "0x1892A3D00", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x92A3BE0", Offset = "0x92A2BE0", VA = "0x1892A3BE0", Slot = "5")]
		public int Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x92A3BF0", Offset = "0x92A2BF0", VA = "0x1892A3BF0", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, int b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x92A3D90", Offset = "0x92A2D90", VA = "0x1892A3D90", Slot = "7")]
		public int VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public JRXLBVZGUHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class SZJXPSUUOSG : JDLSLJQPPOP<int?>, AYGEWMYQSHO, XJCFLGRTSJY<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly SZJXPSUUOSG MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x92AC210", Offset = "0x92AB210", VA = "0x1892AC210", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x92AC040", Offset = "0x92AB040", VA = "0x1892AC040", Slot = "5")]
		public int? Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x92AC0B0", Offset = "0x92AB0B0", VA = "0x1892AC0B0", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, int? b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x92AC300", Offset = "0x92AB300", VA = "0x1892AC300", Slot = "7")]
		public int? VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public SZJXPSUUOSG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class IDTCDROZRQC : JDLSLJQPPOP<int[]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly IDTCDROZRQC MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x92A2690", Offset = "0x92A1690", VA = "0x1892A2690", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x92A2550", Offset = "0x92A1550", VA = "0x1892A2550", Slot = "5")]
		public int[] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public IDTCDROZRQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class TKIBGFXQPOW : JDLSLJQPPOP<long>, AYGEWMYQSHO, XJCFLGRTSJY<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly TKIBGFXQPOW MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x92ACAC0", Offset = "0x92ABAC0", VA = "0x1892ACAC0", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x92AC9E0", Offset = "0x92AB9E0", VA = "0x1892AC9E0", Slot = "5")]
		public long Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x92AC9F0", Offset = "0x92AB9F0", VA = "0x1892AC9F0", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, long b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x92ACB20", Offset = "0x92ABB20", VA = "0x1892ACB20", Slot = "7")]
		public long VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public TKIBGFXQPOW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class IDNXOMPXYEH : JDLSLJQPPOP<long?>, AYGEWMYQSHO, XJCFLGRTSJY<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly IDNXOMPXYEH MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x92A2370", Offset = "0x92A1370", VA = "0x1892A2370", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x92A21B0", Offset = "0x92A11B0", VA = "0x1892A21B0", Slot = "5")]
		public long? Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x92A2240", Offset = "0x92A1240", VA = "0x1892A2240", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, long? b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x92A2430", Offset = "0x92A1430", VA = "0x1892A2430", Slot = "7")]
		public long? VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public IDNXOMPXYEH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class CMNDETVJIUV : JDLSLJQPPOP<long[]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly CMNDETVJIUV MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x929CEE0", Offset = "0x929BEE0", VA = "0x18929CEE0", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x929CDA0", Offset = "0x929BDA0", VA = "0x18929CDA0", Slot = "5")]
		public long[] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public CMNDETVJIUV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class UYTDBFRLGPB : JDLSLJQPPOP<byte>, AYGEWMYQSHO, XJCFLGRTSJY<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly UYTDBFRLGPB MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x92ADA70", Offset = "0x92ACA70", VA = "0x1892ADA70", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x92AD950", Offset = "0x92AC950", VA = "0x1892AD950", Slot = "5")]
		public byte Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x92AD960", Offset = "0x92AC960", VA = "0x1892AD960", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, byte b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x92ADB00", Offset = "0x92ACB00", VA = "0x1892ADB00", Slot = "7")]
		public byte VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public UYTDBFRLGPB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class DMXSFRITKHO : JDLSLJQPPOP<byte?>, AYGEWMYQSHO, XJCFLGRTSJY<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly DMXSFRITKHO MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x929D620", Offset = "0x929C620", VA = "0x18929D620", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x929D450", Offset = "0x929C450", VA = "0x18929D450", Slot = "5")]
		public byte? Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x929D4C0", Offset = "0x929C4C0", VA = "0x18929D4C0", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, byte? b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x929D710", Offset = "0x929C710", VA = "0x18929D710", Slot = "7")]
		public byte? VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public DMXSFRITKHO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class ROGYLLBTFUU : JDLSLJQPPOP<ushort>, AYGEWMYQSHO, XJCFLGRTSJY<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly ROGYLLBTFUU MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x92AB360", Offset = "0x92AA360", VA = "0x1892AB360", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x92AB240", Offset = "0x92AA240", VA = "0x1892AB240", Slot = "5")]
		public ushort Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x92AB250", Offset = "0x92AA250", VA = "0x1892AB250", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, ushort b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x92AB3F0", Offset = "0x92AA3F0", VA = "0x1892AB3F0", Slot = "7")]
		public ushort VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public ROGYLLBTFUU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class BNLCCXBOVAH : JDLSLJQPPOP<ushort?>, AYGEWMYQSHO, XJCFLGRTSJY<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly BNLCCXBOVAH MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x929BFF0", Offset = "0x929AFF0", VA = "0x18929BFF0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x929BE20", Offset = "0x929AE20", VA = "0x18929BE20", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x929BE90", Offset = "0x929AE90", VA = "0x18929BE90", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, ushort? b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x929C0E0", Offset = "0x929B0E0", VA = "0x18929C0E0", Slot = "7")]
		public ushort? VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public BNLCCXBOVAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class NEKCYPRGDXZ : JDLSLJQPPOP<ushort[]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly NEKCYPRGDXZ MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x92A60B0", Offset = "0x92A50B0", VA = "0x1892A60B0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x92A5F70", Offset = "0x92A4F70", VA = "0x1892A5F70", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public NEKCYPRGDXZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class KWFGPBJWSFM : JDLSLJQPPOP<uint>, AYGEWMYQSHO, XJCFLGRTSJY<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly KWFGPBJWSFM MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x92A4380", Offset = "0x92A3380", VA = "0x1892A4380", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x92A4260", Offset = "0x92A3260", VA = "0x1892A4260", Slot = "5")]
		public uint Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x92A4270", Offset = "0x92A3270", VA = "0x1892A4270", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, uint b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x92A4410", Offset = "0x92A3410", VA = "0x1892A4410", Slot = "7")]
		public uint VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public KWFGPBJWSFM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class BSJTMIQGNZD : JDLSLJQPPOP<uint?>, AYGEWMYQSHO, XJCFLGRTSJY<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly BSJTMIQGNZD MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x929C3F0", Offset = "0x929B3F0", VA = "0x18929C3F0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x929C220", Offset = "0x929B220", VA = "0x18929C220", Slot = "5")]
		public uint? Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x929C290", Offset = "0x929B290", VA = "0x18929C290", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, uint? b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x929C4E0", Offset = "0x929B4E0", VA = "0x18929C4E0", Slot = "7")]
		public uint? VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public BSJTMIQGNZD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class IPSHJZRRECB : JDLSLJQPPOP<uint[]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly IPSHJZRRECB MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x92A32C0", Offset = "0x92A22C0", VA = "0x1892A32C0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x92A3180", Offset = "0x92A2180", VA = "0x1892A3180", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public IPSHJZRRECB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class MFOJSWXRJIP : JDLSLJQPPOP<ulong>, AYGEWMYQSHO, XJCFLGRTSJY<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly MFOJSWXRJIP MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x92A4A00", Offset = "0x92A3A00", VA = "0x1892A4A00", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x92A4920", Offset = "0x92A3920", VA = "0x1892A4920", Slot = "5")]
		public ulong Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x92A4930", Offset = "0x92A3930", VA = "0x1892A4930", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, ulong b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x92A4A60", Offset = "0x92A3A60", VA = "0x1892A4A60", Slot = "7")]
		public ulong VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public MFOJSWXRJIP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class BTONGAFXWRS : JDLSLJQPPOP<ulong?>, AYGEWMYQSHO, XJCFLGRTSJY<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly BTONGAFXWRS MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x929C7E0", Offset = "0x929B7E0", VA = "0x18929C7E0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x929C620", Offset = "0x929B620", VA = "0x18929C620", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x929C6B0", Offset = "0x929B6B0", VA = "0x18929C6B0", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, ulong? b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x929C8A0", Offset = "0x929B8A0", VA = "0x18929C8A0", Slot = "7")]
		public ulong? VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public BTONGAFXWRS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class EURPAFAAHAW : JDLSLJQPPOP<ulong[]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly EURPAFAAHAW MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x929E1A0", Offset = "0x929D1A0", VA = "0x18929E1A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x929E060", Offset = "0x929D060", VA = "0x18929E060", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public EURPAFAAHAW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class CMJZKZSZNKF : JDLSLJQPPOP<float>, AYGEWMYQSHO, XJCFLGRTSJY<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly CMJZKZSZNKF MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x929CC90", Offset = "0x929BC90", VA = "0x18929CC90", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x929CBB0", Offset = "0x929BBB0", VA = "0x18929CBB0", Slot = "5")]
		public float Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x929CBC0", Offset = "0x929BBC0", VA = "0x18929CBC0", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, float b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x929CCF0", Offset = "0x929BCF0", VA = "0x18929CCF0", Slot = "7")]
		public float VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public CMJZKZSZNKF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class IFTECVRNEES : JDLSLJQPPOP<float?>, AYGEWMYQSHO, XJCFLGRTSJY<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly IFTECVRNEES MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x92A2AC0", Offset = "0x92A1AC0", VA = "0x1892A2AC0", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x92A2930", Offset = "0x92A1930", VA = "0x1892A2930", Slot = "5")]
		public float? Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x92A29A0", Offset = "0x92A19A0", VA = "0x1892A29A0", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, float? b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x92A2B80", Offset = "0x92A1B80", VA = "0x1892A2B80", Slot = "7")]
		public float? VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public IFTECVRNEES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class JCBPGHJPPJC : JDLSLJQPPOP<float[]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly JCBPGHJPPJC MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x92A3850", Offset = "0x92A2850", VA = "0x1892A3850", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x92A3710", Offset = "0x92A2710", VA = "0x1892A3710", Slot = "5")]
		public float[] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public JCBPGHJPPJC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class MKTWFZEJVOS : JDLSLJQPPOP<double>, AYGEWMYQSHO, XJCFLGRTSJY<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly MKTWFZEJVOS MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x92A4BF0", Offset = "0x92A3BF0", VA = "0x1892A4BF0", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x92A4B10", Offset = "0x92A3B10", VA = "0x1892A4B10", Slot = "5")]
		public double Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x92A4B20", Offset = "0x92A3B20", VA = "0x1892A4B20", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, double b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x92A4C50", Offset = "0x92A3C50", VA = "0x1892A4C50", Slot = "7")]
		public double VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public MKTWFZEJVOS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class IJAWJKQUPPD : JDLSLJQPPOP<double?>, AYGEWMYQSHO, XJCFLGRTSJY<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly IJAWJKQUPPD MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x92A2E50", Offset = "0x92A1E50", VA = "0x1892A2E50", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x92A2C90", Offset = "0x92A1C90", VA = "0x1892A2C90", Slot = "5")]
		public double? Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x92A2D20", Offset = "0x92A1D20", VA = "0x1892A2D20", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, double? b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x92A2F10", Offset = "0x92A1F10", VA = "0x1892A2F10", Slot = "7")]
		public double? VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public IJAWJKQUPPD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class XMGYZQYXEJH : JDLSLJQPPOP<double[]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly XMGYZQYXEJH MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x92B1B50", Offset = "0x92B0B50", VA = "0x1892B1B50", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x92B1A10", Offset = "0x92B0A10", VA = "0x1892B1A10", Slot = "5")]
		public double[] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public XMGYZQYXEJH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class ZQJVGSVRGYH : JDLSLJQPPOP<bool>, AYGEWMYQSHO, XJCFLGRTSJY<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly ZQJVGSVRGYH MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x92B46F0", Offset = "0x92B36F0", VA = "0x1892B46F0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x92B4610", Offset = "0x92B3610", VA = "0x1892B4610", Slot = "5")]
		public bool Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x92B4620", Offset = "0x92B3620", VA = "0x1892B4620", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, bool b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x92B4750", Offset = "0x92B3750", VA = "0x1892B4750", Slot = "7")]
		public bool VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public ZQJVGSVRGYH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class YXDPGMHZHEW : JDLSLJQPPOP<bool?>, AYGEWMYQSHO, XJCFLGRTSJY<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly YXDPGMHZHEW MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x92B4440", Offset = "0x92B3440", VA = "0x1892B4440", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x92B42B0", Offset = "0x92B32B0", VA = "0x1892B42B0", Slot = "5")]
		public bool? Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x92B4320", Offset = "0x92B3320", VA = "0x1892B4320", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, bool? b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x92B4500", Offset = "0x92B3500", VA = "0x1892B4500", Slot = "7")]
		public bool? VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public YXDPGMHZHEW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class PIDSIFOLTWW : JDLSLJQPPOP<bool[]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly PIDSIFOLTWW MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x92A7220", Offset = "0x92A6220", VA = "0x1892A7220", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x92A70E0", Offset = "0x92A60E0", VA = "0x1892A70E0", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public PIDSIFOLTWW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class AXJKEXAPGLI : JDLSLJQPPOP<byte[]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly JDLSLJQPPOP<byte[]> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x929BCF0", Offset = "0x929ACF0", VA = "0x18929BCF0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x929BC80", Offset = "0x929AC80", VA = "0x18929BC80", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public AXJKEXAPGLI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class PKVLEDXBQCN : JDLSLJQPPOP<ArraySegment<byte>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly JDLSLJQPPOP<ArraySegment<byte>> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x92A8210", Offset = "0x92A7210", VA = "0x1892A8210", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x92A8140", Offset = "0x92A7140", VA = "0x1892A8140", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public PKVLEDXBQCN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class WMUVYFVPCFX : JDLSLJQPPOP<string>, AYGEWMYQSHO, XJCFLGRTSJY<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly JDLSLJQPPOP<string> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x92AF7E0", Offset = "0x92AE7E0", VA = "0x1892AF7E0", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x92AF770", Offset = "0x92AE770", VA = "0x1892AF770", Slot = "5")]
		public string Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x92AF780", Offset = "0x92AE780", VA = "0x1892AF780", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, string b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x92AF770", Offset = "0x92AE770", VA = "0x1892AF770", Slot = "7")]
		public string VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public WMUVYFVPCFX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class RNOKEMGVCHW : JDLSLJQPPOP<string[]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly RNOKEMGVCHW MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x92AB010", Offset = "0x92AA010", VA = "0x1892AB010", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x92AAEC0", Offset = "0x92A9EC0", VA = "0x1892AAEC0", Slot = "5")]
		public string[] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public RNOKEMGVCHW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class IPNNZUFBLLP : JDLSLJQPPOP<char>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly IPNNZUFBLLP MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x92A3060", Offset = "0x92A2060", VA = "0x1892A3060", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x92A3030", Offset = "0x92A2030", VA = "0x1892A3030", Slot = "5")]
		public char Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public IPNNZUFBLLP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class KQTYISAILKC : JDLSLJQPPOP<char?>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly KQTYISAILKC MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x92A40F0", Offset = "0x92A30F0", VA = "0x1892A40F0", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x92A4030", Offset = "0x92A3030", VA = "0x1892A4030", Slot = "5")]
		public char? Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public KQTYISAILKC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class WUDAXCLTYDO : JDLSLJQPPOP<char[]>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly WUDAXCLTYDO MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x92AFA40", Offset = "0x92AEA40", VA = "0x1892AFA40", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x92AF8B0", Offset = "0x92AE8B0", VA = "0x1892AF8B0", Slot = "5")]
		public char[] Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public WUDAXCLTYDO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class OTIAQWCVZBA : JDLSLJQPPOP<Guid>, AYGEWMYQSHO, XJCFLGRTSJY<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly JDLSLJQPPOP<Guid> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x92A6E90", Offset = "0x92A5E90", VA = "0x1892A6E90", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x92A6CB0", Offset = "0x92A5CB0", VA = "0x1892A6CB0", Slot = "5")]
		public Guid Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x92A6D10", Offset = "0x92A5D10", VA = "0x1892A6D10", Slot = "6")]
		public void LOSLZCQLXAK(JsonWriter a, Guid b, POKYTICTLCW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x92A7000", Offset = "0x92A6000", VA = "0x1892A7000", Slot = "7")]
		public Guid VCZTUHDKQXQ(JsonReader a, POKYTICTLCW b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public OTIAQWCVZBA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class LQNGFVRKQXA : JDLSLJQPPOP<decimal>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly JDLSLJQPPOP<decimal> MQLQILIKRCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool SBXRWXUUEEA;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x75EB3A0", Offset = "0x75EA3A0", VA = "0x1875EB3A0")]
		public LQNGFVRKQXA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xDD0E60", Offset = "0xDCFE60", VA = "0x180DD0E60")]
		public LQNGFVRKQXA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x92A46D0", Offset = "0x92A36D0", VA = "0x1892A46D0", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x92A4500", Offset = "0x92A3500", VA = "0x1892A4500", Slot = "5")]
		public decimal Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class HLZHFVUVLHH : JDLSLJQPPOP<Uri>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly JDLSLJQPPOP<Uri> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x92A0C50", Offset = "0x929FC50", VA = "0x1892A0C50", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x92A0BD0", Offset = "0x929FBD0", VA = "0x1892A0BD0", Slot = "5")]
		public Uri Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public HLZHFVUVLHH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class ITBUDUPGGTR : JDLSLJQPPOP<Version>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly JDLSLJQPPOP<Version> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x92A35E0", Offset = "0x92A25E0", VA = "0x1892A35E0", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x92A3560", Offset = "0x92A2560", VA = "0x1892A3560", Slot = "5")]
		public Version Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public ITBUDUPGGTR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class DIZJRLHHYDB<a, b> : JDLSLJQPPOP<KeyValuePair<a, b>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x443D5D0", Offset = "0x443C5D0", VA = "0x18443D5D0", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x443D0D0", Offset = "0x443C0D0", VA = "0x18443D0D0", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class XCJUFOONTSP : JDLSLJQPPOP<StringBuilder>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly JDLSLJQPPOP<StringBuilder> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x92AFD80", Offset = "0x92AED80", VA = "0x1892AFD80", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x92AFD00", Offset = "0x92AED00", VA = "0x1892AFD00", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public XCJUFOONTSP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class HUJVDHZZATD : JDLSLJQPPOP<BitArray>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly JDLSLJQPPOP<BitArray> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x92A1E10", Offset = "0x92A0E10", VA = "0x1892A1E10", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x92A1CF0", Offset = "0x92A0CF0", VA = "0x1892A1CF0", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public HUJVDHZZATD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class RXRIQPKXNPP : JDLSLJQPPOP<Type>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly RXRIQPKXNPP MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex NAPXPXSIPZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool WHJMRTSLRHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool UWOTNLTCMPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool SAAPGDTILVC;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x92AB7D0", Offset = "0x92AA7D0", VA = "0x1892AB7D0")]
		public RXRIQPKXNPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x85D9200", Offset = "0x85D8200", VA = "0x1885D9200")]
		public RXRIQPKXNPP(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x92AB5F0", Offset = "0x92AA5F0", VA = "0x1892AB5F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x92AB4E0", Offset = "0x92AA4E0", VA = "0x1892AB4E0", Slot = "5")]
		public Type Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class BVBDQZETUGR : JDLSLJQPPOP<BigInteger>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly JDLSLJQPPOP<BigInteger> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x929CA70", Offset = "0x929BA70", VA = "0x18929CA70", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x929C9C0", Offset = "0x929B9C0", VA = "0x18929C9C0", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public BVBDQZETUGR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class FGZMYOZFLOX : JDLSLJQPPOP<Complex>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly JDLSLJQPPOP<Complex> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x929E460", Offset = "0x929D460", VA = "0x18929E460", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x929E3D0", Offset = "0x929D3D0", VA = "0x18929E3D0", Slot = "5")]
		public Complex Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public FGZMYOZFLOX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class DFSRSVGRCBD : JDLSLJQPPOP<ExpandoObject>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly JDLSLJQPPOP<ExpandoObject> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x929D350", Offset = "0x929C350", VA = "0x18929D350", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x929D120", Offset = "0x929C120", VA = "0x18929D120", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public DFSRSVGRCBD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class MEFOEEBNTEI<a> : JDLSLJQPPOP<Lazy<a>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5AE0920", Offset = "0x5ADF920", VA = "0x185AE0920", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5AE0710", Offset = "0x5ADF710", VA = "0x185AE0710", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class MNBQVOOKHJC : JDLSLJQPPOP<Task>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly JDLSLJQPPOP<Task> MQLQILIKRCK;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task LDFXVRHJCQT;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x92A4DB0", Offset = "0x92A3DB0", VA = "0x1892A4DB0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x92A4D00", Offset = "0x92A3D00", VA = "0x1892A4D00", Slot = "5")]
		public Task Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public MNBQVOOKHJC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class LPCAQKDOQHY<a> : JDLSLJQPPOP<Task<a>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x55DBBF0", Offset = "0x55DABF0", VA = "0x1855DBBF0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x55DBA60", Offset = "0x55DAA60", VA = "0x1855DBA60", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class SQDNOKJPGVC<a> : JDLSLJQPPOP<ValueTask<a>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x619E650", Offset = "0x619D650", VA = "0x18619E650", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x619E410", Offset = "0x619D410", VA = "0x18619E410", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class WEZWLXYDGMC<a> : JDLSLJQPPOP<Tuple<a>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x6A56EB0", Offset = "0x6A55EB0", VA = "0x186A56EB0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x6A56BC0", Offset = "0x6A55BC0", VA = "0x186A56BC0", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class WEUPOREFXAT<a, b> : JDLSLJQPPOP<Tuple<a, b>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x6A50E50", Offset = "0x6A4FE50", VA = "0x186A50E50", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x6A50A00", Offset = "0x6A4FA00", VA = "0x186A50A00", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class WEPIRKKINPK<a, b, c> : JDLSLJQPPOP<Tuple<a, b, c>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x6A50320", Offset = "0x6A4F320", VA = "0x186A50320", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x6A4FD80", Offset = "0x6A4ED80", VA = "0x186A4FD80", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class WEKBUDQLEEB<a, b, c, d> : JDLSLJQPPOP<Tuple<a, b, c, d>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F520", Offset = "0x6A4E520", VA = "0x186A4F520", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EE20", Offset = "0x6A4DE20", VA = "0x186A4EE20", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class WEEUWWWNUSS<a, b, c, d, e> : JDLSLJQPPOP<Tuple<a, b, c, d, e>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E440", Offset = "0x6A4D440", VA = "0x186A4E440", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x6A4DBD0", Offset = "0x6A4CBD0", VA = "0x186A4DBD0", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class WDZNZQCQLHJ<a, b, c, d, e, f> : JDLSLJQPPOP<Tuple<a, b, c, d, e, f>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D070", Offset = "0x6A4C070", VA = "0x186A4D070", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x6A4C670", Offset = "0x6A4B670", VA = "0x186A4C670", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class WDUHCJITBWA<a, b, c, d, e, f, g> : JDLSLJQPPOP<Tuple<a, b, c, d, e, f, g>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x6A4B990", Offset = "0x6A4A990", VA = "0x186A4B990", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x6A4AE00", Offset = "0x6A49E00", VA = "0x186A4AE00", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class WDPAFCOVSKR<a, b, c, d, e, f, g, h> : JDLSLJQPPOP<Tuple<a, b, c, d, e, f, g, h>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x6A49F10", Offset = "0x6A48F10", VA = "0x186A49F10", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A49200", Offset = "0x6A48200", VA = "0x186A49200", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class PJFAXZTUPYV<a> : JDLSLJQPPOP<ValueTuple<a>>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6570", Offset = "0x5DA5570", VA = "0x185DA6570", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x5DA6130", Offset = "0x5DA5130", VA = "0x185DA6130", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class PIPGGFMCNQU<a, b> : JDLSLJQPPOP<(a, b)>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4530", Offset = "0x5DA3530", VA = "0x185DA4530", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5DA4020", Offset = "0x5DA3020", VA = "0x185DA4020", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class PIUNDMFZXCD<a, b, c> : JDLSLJQPPOP<(a, b, c)>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x5DA59D0", Offset = "0x5DA49D0", VA = "0x185DA59D0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x5DA5320", Offset = "0x5DA4320", VA = "0x185DA5320", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class PJUVPUBMSGW<a, b, c, d> : JDLSLJQPPOP<(a, b, c, d)>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5DABB90", Offset = "0x5DAAB90", VA = "0x185DABB90", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB310", Offset = "0x5DAA310", VA = "0x185DAB310", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class PKACNAVKBSF<a, b, c, d, e> : JDLSLJQPPOP<(a, b, c, d, e)>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x5DACED0", Offset = "0x5DABED0", VA = "0x185DACED0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC4C0", Offset = "0x5DAB4C0", VA = "0x185DAC4C0", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class PJKHVGNRZKE<a, b, c, d, e, f> : JDLSLJQPPOP<(a, b, c, d, e, f)>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5DA89E0", Offset = "0x5DA79E0", VA = "0x185DA89E0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5DA7DB0", Offset = "0x5DA6DB0", VA = "0x185DA7DB0", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class PJPOSNHPIVN<a, b, c, d, e, f, g> : JDLSLJQPPOP<(a, b, c, d, e, f, g)>, AYGEWMYQSHO
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA490", Offset = "0x5DA9490", VA = "0x185DAA490", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x5DA96A0", Offset = "0x5DA86A0", VA = "0x185DA96A0", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class PHJQWQWSJAS<a, b, c, d, e, f, g, h> : JDLSLJQPPOP<ValueTuple<a, b, c, d, e, f, g, h>>, AYGEWMYQSHO where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] CEKFMDAEOMB;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly SNRRBOIZBIH NHWMRVZXCDD;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x5DA26D0", Offset = "0x5DA16D0", VA = "0x185DA26D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, POKYTICTLCW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x5DA1730", Offset = "0x5DA0730", VA = "0x185DA1730", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, POKYTICTLCW formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class JSWFXFZSKDH
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] LYBQBKWQPPR;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly SNRRBOIZBIH JRWIVWOUOLI;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x92A3E80", Offset = "0x92A2E80", VA = "0x1892A3E80")]
		static JSWFXFZSKDH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class IBHUZDCVACD
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] RBAFXVWCOEW;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly SNRRBOIZBIH SZWOFSHMQPR;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x92A2000", Offset = "0x92A1000", VA = "0x1892A2000")]
		static IBHUZDCVACD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class QRHPUYSKXWF
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] QIQKBPDHXIX;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly SNRRBOIZBIH VTYYMVYPXEU;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] QIVQYVXFGUG;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly SNRRBOIZBIH VUOTEQGHZMV;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] QJAXWCRCQFP;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly SNRRBOIZBIH VUJMHJMKQBM;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] QJGETJKZZQY;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly SNRRBOIZBIH VUZGZDUCSJN;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] QJLLQQEXJCH;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly SNRRBOIZBIH VUUABXAFIYE;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] QJQSNWYUSNQ;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly SNRRBOIZBIH VVJUTRHXLGF;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] QJVZLDSSBYZ;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly SNRRBOIZBIH VVENWKOABUW;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] QGVAAGGFQKU;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly SNRRBOIZBIH VVUIOEVSECX;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x92A83B0", Offset = "0x92A73B0", VA = "0x1892A83B0")]
		static QRHPUYSKXWF()
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
